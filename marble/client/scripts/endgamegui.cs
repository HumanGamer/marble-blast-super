//-----------------------------------------------------------------------------
// Torque Game Engine
// 
// Copyright (c) 2001 GarageGames.Com
// Portions Copyright (c) 2001 by Sierra Online, Inc.
//-----------------------------------------------------------------------------

function EndGameGui::onWake()
{
   //if (!$Game::Qualified)
   //{
      //EG_play.visible = false;
   //} else {
      //EG_play.visible = true;
   //}
   //playMissionGui.onWake();
   %level = PM_missionList.getSelectedId();
   %level += 1;
   %group = "MTYPE_" @ $MissionType;
   %type = $MissionType;
   if (%level > %group.getCount() - 1)
   {
      %level = 0;
      if (%type $= "Tutorial")
         %type = "Beginner";
      else if (%type $= "Beginner")
         %type = "Medium";
      else if (%type $= "Medium")
         %type = "Advanced";
      else if (%type $= "Advanced")
         %type = "Expert";
      else if (%type $= "Expert")
         %type = "Tutorial";
      else if (%type $= "Custom")
         %type = "Tutorial";
   }
   PMSetMissionTab(%type);
   PM_setSelected(%level);
}   