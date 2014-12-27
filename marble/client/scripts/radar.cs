// Adds a radar object
function addRadarObject(%id, %bitmap, %x, %y)
{
   %oldObj = "RadarObject_" @ %id;
   if (isObject(%oldObj))
   {
      clientCmdRemoveRadarObject(%id);
      //return;
   }
   
   // Set gamepos to the 3d position without z
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
   
   // Trying to find correct positioning as it seemed off and I'm not sure what I should use.
   // This seems to look better than before.
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

// Removes A Radar Object
function clientCmdRemoveRadarObject(%id)
{
   %obj = "RadarObject_" @ %id;
   if (isObject(%obj))
      %obj.delete();
}

// Clears the radar. Used when level ends or restarts.
function clientCmdClearRadar()
{
   for (%i = 0; %i < RadarContainer.getCount(); %i++)
   {
      RadarContainer.getObject(%i).delete();
   }
}

// Used to Update an Active RadarObject
// Currently Unused or used to call addRadarObject I believe
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

// Updates Radar Objects
function updateRadar()
{
   cancel($radarUpdate);
   
   // If marble doesn't exist skip this radar update
   if (!isObject(getMyMarble()))
   {
      $radarUpdate = schedule(30, 0, updateRadar);
      return;   
   }
   
   // Get Marble Transform
   %trans = getMyMarble().getTransform();
   %centerX = getWord(%trans, 0);
   %centerY = getWord(%trans, 1);
   
   //%centerZ = getWord(%trans, 2);
   
   //%cameraRotation = getWord(%eye, 3) SPC getWord(%eye, 4) SPC getWord(%eye, 5) SPC getWord(%eye, 6);
   
   //%angle = mFloor(mRadToDeg(getWord(%cameraRotation, 1) * getWord(%cameraRotation, 3))); 
   
   //PlayerListGui.update(123, "Angle", false, %angle);
   
   //%cameraRotation = getCameraRotation();
   //PlayerListGui.update(123, "Angle", false, %cameraRotation);
   
   // Make sure that the RadarContainer's size is the same as the screen resolution.
   RadarContainer.extent = getRes();
   
   // Save the extent in res
   %res = RadarContainer.extent;
   
   // Gets Current Size of RadarContainer
   %maxX = getWord(%res, 0);
   %maxY = getWord(%res, 1);
   
   // Don't let the RadarObjects go further than 1/8th the resolution as a minimum
   %minX = %maxX / 8;
   %minY = %maxY / 8;
   
   // Shift The RadarObject to be centred on the RadarContainer
   %maxX -= %minX;
   %maxY -= %minY;
   
   // Radar Scale
   %scale = 10;
   
   // Set %yaw to the current Yaw
   %yaw = mDegToRad(getWord(getCameraRotation(getMyMarble()), 2));
   
   // Cosine and Sine of yaw
   %cos = mCos(%yaw);
   %sin = mSin(%yaw);
   
   // Loop through all radar objects
   for (%i = 0; %i < RadarContainer.getCount(); %i++)
   {
      %obj = RadarContainer.getObject(%i);
      
	  // Get their in 3d position without z axis
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
      
      // jeff's math - unsure how it works
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
	  
	  // end of jeff's math
      
      //%dx = %centerX - %x;
      //%dy = %centerY - %y;
      
      //%angle = mAtan(%dx, %dy);
      
      //$mvYaw = getWord(%cameraRotation, 1) - %angle;
      
      //PlayerListGui.update(123, "Angle", false, %angle);
      
      //break;
      
      //%obj.position = %x + 1 SPC %y + 1;
      
      //%posY *= -1;
      
      //%posX = (%centerX - %x);
	  
	  // Make sure radar objects do not end up offscreen
      if (%posX < %minX)
         %posX = %minX;
      if (%posX >= %maxX)
         %posX = %maxX;
      //%posY = (%centerY - %y);
      if (%posY < %minY)
         %posY = %minY;
      if (%posY >= %maxY)
         %posY = %maxY;
      
	  // Set the position
      %obj.position = %posX SPC %posY;
   }
   
   // Update Radar again in 30 milliseconds
   $radarUpdate = schedule(30, 0, updateRadar);
}