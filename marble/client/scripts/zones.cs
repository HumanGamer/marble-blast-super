package Zones {
   function onFrameAdvance(%deltaTime)
   {
      Parent::onFrameAdvance(%deltaTime);
      if (MissionInfo.useZones && !$Game::UseZones)
      {
         PG_ZoneBG.setVisible(true);  
         
         $Game::UseZones = true;
         PG_ZoneText.setAlpha(0.5);
      } else if (!MissionInfo.useZones && ($Game::UseZones || PG_ZoneBG.isVisible()))
      {
         PG_ZoneBG.setVisible(false);  
         
         $Game::UseZones = false;
      }
      if ($Game::ZoneName !$= $Game::OldZoneName)
      {
         PG_ZoneText.setText("<font:Whitestone:36><just:center><color:FFFFFF>" @ $Game::ZoneName);       
         
         $Game::OldZoneName = $Game::ZoneName;
      }
   }
};

activatePackage(Zones);