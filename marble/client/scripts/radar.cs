function addRadarObject(%id, %bitmap, %x, %y)
{
   %oldObj = "RadarObject_" @ %id;
   if (isObject(%oldObj))
   {
      clientCmdRemoveRadarObject(%id);
      //return;
   }
   
   %gamePos = %x SPC %y;
   
   //%x = %x * -1;
   //%y = %y * -1;
   //
   //%x = %x * 8;
   //%y = %y * 8;
   //
   //%x += 150;
   //%y += 150;
   
   RadarContainer.extent = getRes();
   
   %res = RadarContainer.extent;
   
   %maxX = getWord(%res, 0);
   %maxY = getWord(%res, 1);
   
   %location = %maxX / 2 + 16 SPC %maxY / 2 + 16;//"-100 -100";//%x SPC %y;
   
   %obj = new GuiBitmapCtrl("RadarObject_" @ %id)
   {
      profile = "GuiDefaultProfile";
      horizSizing = "right";
      vertSizing = "bottom";
      position = %location;
      extent = "32 32";
      minExtent = "8 8";
      visible = "1";
      helpTag = "0";
      bitmap = %bitmap;
      wrap = "0";
      gamePos = %gamePos;
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
   
   %bitmap = "marble/client/ui/game/gem_" @ %color;
   addRadarObject(%id, %bitmap, %x, %y);
   
   //%marble = getMyMarble();
   //if (!isObject(%marble))
   //{
   //   schedule(250, 0, "clientCmdUpdateRadarObject", %id, %color, %x, %y);
   //   return;
   //}
   
   //%id = "RadarObject_" @ %id;
   //
   //%center = %marble.getTransform();
   //%centerX = getWord(%center, 0);
   //%centerY = getWord(%center, 1);
   //
   //%maxX = getWord(getRes(), 0);
   //%maxY = getWord(getRes(), 1);
   //
   //%rx = (%centerX - %x);
   //if (%rx < 0)
      //%rx = 0;
   //if (%rx >= %maxX)
      //%rx = %maxX;
   //%ry = (%centerY - %y);
   //if (%ry < 0)
      //%ry = 0;
   //if (%ry >= %maxY)
      //%ry = %maxY;
   
   //%id.position = %rx SPC %ry;
}

function updateRadar()
{
   cancel($radarUpdate);
   
   if (!isObject(getMyMarble()))
   {
      $radarUpdate = schedule(30, 0, updateRadar);
      return;   
   }
   
   %trans = getMyMarble().getTransform();
   %centerX = getWord(%trans, 0);
   %centerY = getWord(%trans, 1);
   //%centerZ = getWord(%trans, 2);
   
   //%cameraRotation = getWord(%eye, 3) SPC getWord(%eye, 4) SPC getWord(%eye, 5) SPC getWord(%eye, 6);
   
   //%angle = mFloor(mRadToDeg(getWord(%cameraRotation, 1) * getWord(%cameraRotation, 3))); 
   
   //PlayerListGui.update(123, "Angle", false, %angle);
   
   //%cameraRotation = getCameraRotation();
   //PlayerListGui.update(123, "Angle", false, %cameraRotation);
   
   RadarContainer.extent = getRes();
   
   %res = RadarContainer.extent;
   
   %maxX = getWord(%res, 0);
   %maxY = getWord(%res, 1);
   
   %minX = %maxX / 8;
   %minY = %maxY / 8;
   
   %maxX -= %minX;
   %maxY -= %minY;
   
   %scale = 10;
   
   %yaw = mDegToRad(getWord(getCameraRotation(getMyMarble()), 2));
   
   %cos = mCos(%yaw);
   %sin = mSin(%yaw);
   
   for (%i = 0; %i < RadarContainer.getCount(); %i++)
   {
      %obj = RadarContainer.getObject(%i);
      
      %x = getWord(%obj.gamePos, 0);
      %y = getWord(%obj.gamePos, 1);
      //%z = getWord(%obj.gamePos, 2);
      
      //%rx = %centerX - %x;
      //%ry = %centerY - %y;
      //
      //%rx = %rx * -1;
      //%ry = %ry * -1;
      //
      //%rx = %rx * 8;
      //%ry = %ry * 8;
      //
      //%rx += 150;
      //%ry += 150;
      
      // jeff math
      %difX = %x - %centerX;
      %difY = %y - %centerY;
      //%difZ = %z - %centerZ;

      %posX = %difX + %maxX/2; // position difference + max extent of control
      %posY = %difX + %maxY/2;

      %rotX = %cos * %difX - %sin * %difY;
      %rotY = %sin * %difX + %cos * %difY;

      %sclX = %rotX * %scale;
      %sclY = %rotY * -1 * %scale;

      %posX = %sclX + %maxX/2;
      %posY = %sclY + %maxY/2;
      
      //%dx = %centerX - %x;
      //%dy = %centerY - %y;
      
      //%angle = mAtan(%dx, %dy);
      
      //$mvYaw = getWord(%cameraRotation, 1) - %angle;
      
      //PlayerListGui.update(123, "Angle", false, %angle);
      
      //break;
      
      //%obj.position = %x + 1 SPC %y + 1;
      
      //%posY *= -1;
      
      //%posX = (%centerX - %x);
      if (%posX < %minX)
         %posX = %minX;
      if (%posX >= %maxX)
         %posX = %maxX;
      //%posY = (%centerY - %y);
      if (%posY < %minY)
         %posY = %minY;
      if (%posY >= %maxY)
         %posY = %maxY;
      
      %obj.position = %posX SPC %posY;
   }
   
   $radarUpdate = schedule(30, 0, updateRadar);
}