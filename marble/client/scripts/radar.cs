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
      gamePos = %location;
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
   cancel($radarUpdate);
   %x = %x * -1;
   %y = %y * -1;
   
   %x = %x * 8;
   %y = %y * 8;
   
   %x += 150;
   %y += 150;
   
   %bitmap = "marble/client/ui/game/gem_" @ %color;
   addRadarObject(%id, %bitmap, %x, %y);
   
   %marble = getMyMarble();
   if (!isObject(%marble))
   {
      schedule(250, 0, "clientCmdUpdateRadarObject", %id, %color, %x, %y);
      return;
   }
   
   %center = %marble.getTransform();
   %centerX = getWord(%center, 0);
   %centerY = getWord(%center, 1);
   
   %maxX = getWord(getRes(), 0);
   %maxY = getWord(getRes(), 1);
   
   %rx = (%centerX - %x);
   if (%rx < 0)
      %rx = 0;
   if (%rx >= %maxX)
      %rx = %maxX;
   %ry = (%centerY - %y);
   if (%ry < 0)
      %ry = 0;
   if (%ry >= %maxY)
      %ry = %maxY;
   
   %id.position = %rx SPC %ry;
   
   updateRadar();
}

function updateRadar()
{
   cancel($radarUpdate);
   
   if (!isObject(getMyMarble()))
   {
      $radarUpdate = schedule(10, 0, updateRadar);
      return;   
   }
   
   %eye = getMyMarble().getWorldBoxCenter();
   %centerX = getWord(%eye, 0);
   %centerY = getWord(%eye, 1);
   
   //%cameraRotation = getWord(%eye, 3) SPC getWord(%eye, 4) SPC getWord(%eye, 5) SPC getWord(%eye, 6);
   
   //%angle = mFloor(mRadToDeg(getWord(%cameraRotation, 1) * getWord(%cameraRotation, 3))); 
   
   //PlayerListGui.update(123, "Angle", false, %angle);
   
   //%cameraRotation = getCameraRotation();
   //PlayerListGui.update(123, "Angle", false, %cameraRotation);
   
   %maxX = getWord(getRes(), 0);
   %maxY = getWord(getRes(), 1);
   
   for (%i = 0; %i < RadarContainer.getCount(); %i++)
   {
      %obj = RadarContainer.getObject(%i);
      
      %x = getWord(%obj.gamePos, 0);
      %y = getWord(%obj.gamePos, 1);
      
      //%dx = %centerX - %x;
      //%dy = %centerY - %y;
      
      //%angle = mAtan(%dx, %dy);
      
      //$mvYaw = getWord(%cameraRotation, 1) - %angle;
      
      //PlayerListGui.update(123, "Angle", false, %angle);
      
      //break;
      
      //%obj.position = %x + 1 SPC %y + 1;
      
      %rx = (%centerX - %x);
      if (%rx < 0)
         %rx = 0;
      if (%rx >= %maxX)
         %rx = %maxX;
      %ry = (%centerY - %y);
      if (%ry < 0)
         %ry = 0;
      if (%ry >= %maxY)
         %ry = %maxY;
      
      %obj.position = %rx SPC %ry;
   }
   
   $radarUpdate = schedule(10, 0, updateRadar);
}