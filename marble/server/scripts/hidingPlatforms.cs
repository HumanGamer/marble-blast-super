datablock StaticShapeData(HidingPlatform)
{
   category = "Hazards";

   shapeFile = "marble/data/shapes/hazards/hidingPlatform.dts";
   scopeAlways = true;
   emap = false;
};

function HidingPlatform::onAdd(%this, %obj)
{
   %obj.setSkinName(%obj.skin);
   %obj.used = false;
   if (%obj.hideStart)
      hidePlatform(%obj);
}

function HidingPlatform::onMissionReset(%data, %obj)
{
   cancel(%obj.hide);
   cancel(%obj.unhide);
   cancel(%obj.unhide1);
   if (%obj.normalScale $= "")
      %obj.normalScale = %obj.scale;
   if (isObject(%obj))
      %obj.setScale(%obj.normalScale);
   %obj.startFade(0, 0, false);
   
   %obj.used = false;
   if (%obj.hideStart)
      hidePlatform(%obj);
}

function hidePlatform(%obj)
{
   if (isEventPending(%obj.unhide) || isEventPending(%obj.unhide1) || isEventPending(%obj.hide))
   {
      return;
   }
   cancel(%obj.hide);
   cancel(%obj.unhide);
   cancel(%obj.unhide1);
   if (%obj.normalScale $= "")
      %obj.normalScale = %obj.scale;
   %obj.startFade(250, 0, true);
   
   %obj.hide = %obj.schedule(250, "setScale", 0);
   
   if (%obj.permanent $= true || %obj.timer !$= "")
      return;
   %obj.unhide = %obj.schedule(5000, "startFade", 1000, 0, false);
   %obj.unhide1 = %obj.schedule(5000, "setScale", %obj.normalScale);
}

function showPlatform(%obj)
{
   if (%obj.normalScale $= "")
      %obj.normalScale = %obj.scale;
   %obj.setScale(%obj.normalScale);
   %obj.startFade(250, 0, false);
}

function checkHidingPlatforms()
{
   if (!isObject(MissionGroup))
      return;
   for (%i = 0; %i < MissionGroup.getCount(); %i++)
   {
      %obj = MissionGroup.getObject(%i);
      
      if (%obj.getClassName() $= "StaticShape" && %obj.getDatablock().getName() $= "HidingPlatform")
      {
         if (%obj.timer $= "")
            continue;
            
         if (%obj.currentTime $= "")
            %obj.currentTime = 0;          
            
         %obj.currentTime += $Game::UpdateInterval;
         
         if (%obj.currentTime >= %obj.timer)
         {
            %obj.currentTime = 0;
            
            if (%obj.scale $= "0 0 0")
            {
               showPlatform(%obj);
            } else {
               hidePlatform(%obj);
            }
         }
      }
   }
}

//-----------------------------------------------------------------------------

datablock TriggerData(HidingPlatformTrigger)
{
   tickPeriodMS = 100;
};

function HidingPlatformTrigger::onEnterTrigger(%this,%trigger,%obj)
{
   %target = %trigger.target;
   
   if (%target $= "" || %target.getName() $= "")
   {
      error("Hiding Platform Trigger(" @ %trigger @ ") missing target or target name!");
      return;
   }
   
   %name = %target.getName();
   
   for (%i = 0; %i < MissionGroup.getCount(); %i++)
   {
      %obj1 = MissionGroup.getObject(%i);
      
      if (%obj1.getName() $= %name)
      {
         if (%obj1.used || !%obj1.trigger)
            return;
         
         if (%obj1.scale $= "0 0 0")
         {
            showPlatform(%obj1);
         } else {
            hidePlatform(%obj1);
         }
         
         %obj1.used = true;
      }
   }
}

//-----------------------------------------------------------------------------

datablock StaticShapeData(ExplodingPlatform)
{
   category = "Hazards";

   shapeFile = "marble/data/shapes/hazards/hidingPlatform.dts";
   scopeAlways = true;
   emap = false;
};

function ExplodingPlatform::onAdd(%this, %obj)
{
   %obj.setSkinName(%obj.skin);
}

function ExplodingPlatform::onMissionReset(%data, %obj)
{
   cancel(%obj.hide);
   //cancel(%obj.unhide);
   //cancel(%obj.unhide1);
   if (%obj.normalScale $= "")
      %obj.normalScale = %obj.scale;
   if (isObject(%obj))
      %obj.setScale(%obj.normalScale);
   %obj.startFade(0, 0, false);
}

function ExplodingPlatform::explode(%this, %obj)
{
   if (isEventPending(%obj.hide))
   {
      return;
   }
   cancel(%obj.hide);
   %obj.normalScale = %obj.scale;
   
   %explosion = new Explosion()
   {
      position = %obj.position;
      rotation = %obj.rotation;
      
      datablock = "LandMineExplosion";
   };
   
   MissionCleanup.add(%explosion);
   
   %obj.startFade(250, 0, true);
   %obj.hide = %obj.schedule(250, "setScale", 0);   
   
   %obj.unhide = %obj.schedule(5000, "startFade", 1000, 0, false);
   %obj.unhide1 = %obj.schedule(5000, "setScale", %obj.normalScale);
}
