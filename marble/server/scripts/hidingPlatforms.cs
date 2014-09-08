datablock StaticShapeData(HidingPlatform)
{
   category = "Hazards";

   shapeFile = "marble/data/shapes/hazards/hidingPlatform.dts";
   scopeAlways = true;
   emap = false;
};

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
}

function hidePlatform(%obj)
{
   if (isEventPending(%obj.unhide) || isEventPending(%obj.unhide1) || isEventPending(%obj.hide))
   {
      return;
   }
   error("Hiding Platform: " @ %obj);
   cancel(%obj.hide);
   cancel(%obj.unhide);
   cancel(%obj.unhide1);
   %obj.normalScale = %obj.scale;
   %obj.startFade(250, 0, true);
   %obj.hide = %obj.schedule(250, "setScale", 0);
   %obj.unhide = %obj.schedule(5000, "startFade", 1000, 0, false);
   %obj.unhide1 = %obj.schedule(5000, "setScale", %obj.normalScale);
}
