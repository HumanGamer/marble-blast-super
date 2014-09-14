function LobbyGui::onWake(%this)
{
   buildMissionList();
   if (!$Client::ConnectedMultiplayer && $Server::ServerType $= "") {
      $Client::NoGuiChange = true;
      createServer("Multiplayer");
      connect("");
      LocalClientConnection.isHost();
      //$Multiplayer::isHosting = true;
   }
   if ($Multiplayer::isHosting)
   {
      LB_Prev.visible = "1";
      LB_Next.visible = "1";
      LB_Play.visible = "1";
   } else {
      LB_Prev.visible = "0";
      LB_Next.visible = "0";
      LB_Play.visible = "0";
   }
}

function LB_HostSelected()
{
   %id = PM_missionList.getSelectedId();
   %mission = getField(PM_missionList.getRowTextById(%id), 1);//getField(PM_missionList.getRowTextById(%id), 1);
   $LastMissionId = %id;
   $LastMissionType = %mission.type;
   
   %serverType = "MultiPlayer";

   // We need to start a server if one isn't already running
   if ($Server::ServerType $= "") {
      //if($doRecordDemo)
      //   recordDemo("~/client/demos/demo.rec", %mission.file);
      startServer(%serverType, %mission);
   }
   else
      loadMission(%mission.file);
   if(isObject(MissionInfo))
      MissionInfo.level = %mission.level;
}

function LB_SetSelected(%index)
{
   %group = "MTYPE_" @ $MissionType;
   if (!isObject(%group))
   {
      $MissionType = "Multiplayer";
      %group = MTYPE_multiplayer;
   }
   if (%group.getCount() == 0)
   {
      LB_Play.setActive(false);
      //LB_NoQualOverlay.setVisible(true);
      //PM_NoQualText.setText("<color:CCCCCC><font:DomCasualD:32><just:center>No" SPC $MissionType SPC "Levels!");
      LB_Next.setActive(false);
      LB_Prev.setActive(false);
      LB_Preview.setBitmap("");
      //PM_description.setText("");
      //PM_level_bkgnd.setText("<color:000000><font:DomCasualD:24><just:center>" @ $MissionType);
      //PM_level_fgnd.setText("<color:FFFFFF><font:DomCasualD:24><just:center>" @ $MissionType);
      return;
   }
   %mission = getField(PM_missionList.getRowTextById(%index), 1);//%group.getObject(%index);
   %name = "<color:000000><spush><font:Arial:20>" @ %mission.name @ "<spop><lmargin:10>\n\n";
   if (%mission.time)
      %qualify = "<spush><font:Arial:20><lmargin:0>Spare Time: " @ formatTime(%mission.time) @ "<spop><lmargin:0>\n\n";
   %desc = %mission.desc @ "\n\n";
   %best = "<spush><font:Arial:20>Your best times:<spop><lmargin:10><tab:0,130,180><font:Arial Bold:14>\n";
   getBestTimes(%mission.file);
   %total = "";
   for (%i = 0; %i < 3; %i++)
   {
      %thetime = getField($hs[%i], 1) @ "\t" @ formatTime(getField($hs[%i], 0));
      %time = "<shadow:1:1><color:000000><shadowcolor:ffffff4f>" @ %thetime;
      if (%mission.goldTime && getField($hs[%i], 0) < %mission.goldTime)
         %time = %time @ "<bitmap:marble/client/ui/play/goldscore.png>";
      %time = %time @ "\n";
      %total = %total @ %time;
   }
   LB_Level_Name.setText(%name);
   //PM_description.setText(%name @ %qualify @ %desc @ %best @ %total);
   %bmp = strreplace(%mission.file, ".mis", "");
   LB_Preview.setBitmap(%bmp);
   if (%index <= 0) LB_prev.setActive(false); else LB_prev.setActive(true);
   if (%index >= %group.getCount() - 1) LB_next.setActive(false); else LB_next.setActive(true);
   LB_prev.command = "LB_setSelected(" @ %index - 1 @ ");";
   LB_next.command = "LB_setSelected(" @ %index + 1 @ ");";
   //PM_level_bkgnd.setText("<color:000000><font:DomCasualD:24><just:center>" @ $MissionType @ " Level " @ %index + 1);
   //PM_level_fgnd.setText("<color:FFFFFF><font:DomCasualD:24><just:center>" @ $MissionType @ " Level " @ %index + 1);
   PM_missionList.setSelectedRow(%index);
   //if (%index > $pref::QualifiedLevel[$MissionType] && !$testCheats)
   //{
   //   PM_play.setActive(false);
   //   PM_NoQualOverlay.setVisible(true);
   //   PM_NoQualText.setText("<color:CCCCCC><font:Arial:32><just:center>You haven't unlocked this level yet.");
   //}
   //else
   //{
      PM_play.setActive(true);
      PM_NoQualOverlay.setVisible(false);
      PM_NoQualText.setText("");
   //}
   
   //if (!isFile(%bmp @ ".png") && !isFile(%bmp @ ".jpg"))
   //{
   //   PM_NoQualOverlay.setVisible(true);
   //   PM_NoQualText.setText("<color:CCCCCC><font:Arial:32><just:center>No Preview!");
   //}
}