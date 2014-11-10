function updateCompass()
{
   cancel($CompassUpdate);
   
   CompassText.setText(getDirection());
   
   $CompassUpdate = schedule(30, 0, updateCompass);
}

function getDirection()
{
   %rot = getCameraRotation(getMyMarble());
   
   //%rot = TransformtoRPY(%trans);
   
   //%yaw = mRadToDeg(getWord(%rot, 1));
   //if (%yaw < 0)
   //   %yaw = %yaw + 360;
   
   %yaw = getWord(%rot, 2);
   
   %direction = "N/A: " @ %yaw;
   if (%yaw > 345 && %yaw < 360 || %yaw >= 0 && %yaw < 45)
   {
      %direction = "North";
   } else if (%yaw >= 45 && %yaw < 90)
   {
      %direction = "North-East";
   } else if (%yaw >= 90 && %yaw < 135)
   {
      %direction = "East";
   } else if (%yaw >= 135 && %yaw < 180)
   {
      %direction = "South-East";
   } else if (%yaw >= -180 && %yaw < -135)
   {
      %direction = "South";  
   } else if (%yaw >= -135 && %yaw < -90)
   {
      %direction = "South-West";
   } else if (%yaw >= -90 && %yaw < -45)
   {
      %direction = "West";
   } else if (%yaw >= -45 && %yaw < 0)
   {
      %direction = "North-West";
   }
   
   return %direction;
}