datablock StaticShapeData(RotationPlatform)
{
   category = "Hazards";

   shapeFile = "marble/data/shapes/hazards/rotationPlatform.dts";
   scopeAlways = true;
   emap = false;
};

function RotationPlatform::onAdd(%this, %obj)
{
   %obj.setSkinName(%obj.skin);
}

function RotationPlatform::onMissionReset(%this, %obj)
{
   %position = %obj.getTransform();
   %rotation = "1 0 0 0";
   %obj.setTransform(getWords(%position, 0, 2) SPC %rotation);
}

function RotationPlatform::update(%this, %obj)
{
   %axis = %obj.axis;
   %inc = %obj.inc;
      
   if (%axis $= "")
      %obj.axis = "z";      
      
   if (%inc $= "")
      %obj.inc = 1;
      
   %axis = %obj.axis;
   %inc = %obj.inc;
   
   %position = %obj.getTransform();
   %rotation = getWords(%position, 3, 7);
   
   if (%rotation $= "1 0 0 0")
      %rotation = getRotationByAxis(%axis);
      
   if (mRadToDeg(getWord(%rotation, 3)) > 180)
      %rotation = VectorScale(getWords(0, 2), -1) SPC getWord(%rotation, 3);
   
   %rotation = getWords(%rotation, 0, 2) SPC mDegToRad(mRadToDeg(getWord(%rotation, 3)) + %inc);
   
   %obj.setTransform(getWords(%position, 0, 2) SPC %rotation);
}

function getAxis(%axis, %rotation)
{
   switch$(%axis)
   {
      case "y": return getWord(%rotation, 1);
      case "z": return getWord(%rotation, 2);
   }
   
   return getWord(%rotation, 0);
}

function getRotationByAxis(%axis)
{
   switch$(%axis)
   {
      case "y": return "0 1 0 0.01";
      case "z": return "0 0 1 0.01";
   }
   
   return "1 0 0 0.01";
}

function updateRotationPlatforms()
{
   if (!isObject(MissionGroup))
      return;
   for (%i = 0; %i < MissionGroup.getCount(); %i++)
   {
      %obj = MissionGroup.getObject(%i);
      
      if (%obj.getClassName() $= "StaticShape" && %obj.getDatablock().getName() $= "RotationPlatform")
      {
         if (%obj.timer $= "")
            %obj.timer = $Multiplayer::UpdateInterval;
            
         if (%obj.currentTime $= "")
            %obj.currentTime = 0;          
            
         %obj.currentTime += $Multiplayer::UpdateInterval;
         
         if (%obj.currentTime >= %obj.timer)
         {
            %obj.currentTime = 0;
            
            RotationPlatform.update(%obj);
         }
      }
   }
}