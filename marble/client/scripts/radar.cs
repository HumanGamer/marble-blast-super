function addRadarObject(%id, %bitmap, %x, %y)
{
   %oldObj = "RadarObject_" @ %id;
   if (isObject(%oldObj))
   {
      clientCmdRemoveRadarObject(%id);
      return;
   }
   
   %location = %x SPC %y;
   
   %obj = new GuiBitmapCtrl("RadarObject_" @ %id)
   {
      profile = "GuiDefaultProfile";
      horizSizing = "right";
      vertSizing = "bottom";
      position = %location;
      extent = "8 8";
      minExtent = "8 8";
      visible = "1";
      helpTag = "0";
      bitmap = %bitmap;
      wrap = "0";
   };
   
   RadarContainer.add(%obj);
   
   //echo("Added New Gem: " @ %oldObj @ " location: " @ %location);
}

//function updateRadarObject(%id, %x, %y)
//{
   //%obj = "RadarObject_" @ %id;
   //%obj.position = %x SPC %y;
   //
   //echo("Updated Gem: " @ %obj);
//}

function clientCmdRemoveRadarObject(%id)
{
   %obj = "RadarObject_" @ %id;
   if (isObject(%obj))
      %obj.delete();
}

function clientCmdClearRadar()
{
   for (%i = 0; %i < RadarContainer.getCount(); %i++)
   {
      RadarContainer.getObject(%i).delete();
   }
}

function clientCmdUpdateRadarObject(%id, %color, %x, %y)
{
   //cancel($radarUpdate);
   %x = %x * -1;
   %y = %y * -1;
   
   %x = %x * 8;
   %y = %y * 8;
   
   %x += 150;
   %y += 150;
   
   %bitmap = "marble/client/ui/game/gem_" @ %color;
   addRadarObject(%id, %bitmap, %x, %y);
   
   //updateRadar();
}

//function updateRadar()
//{
   //cancel($radarUpdate);
   //
   //%eye = getMyMarble().getEyeTransform();
   //
   //%cameraRotation = getWord(%eye, 3) SPC getWord(%eye, 4) SPC getWord(%eye, 5) SPC getWord(%eye, 6);
   //
   //%angle = mFloor(mRadToDeg(getWord(%cameraRotation, 1) * getWord(%cameraRotation, 3))); 
   //
   //PlayerListGui.update(123, "Angle", false, %angle);
   //
   //for (%i = 0; %i < RadarContainer.getCount(); %i++)
   //{
      //%obj = RadarContainer.getObject(%i);
      //
      //
   //}
   //
   //$radarUpdate = schedule(10, 0, updateRadar);
//}