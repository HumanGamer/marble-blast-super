function LobbyGui::onWake(%this)
{
   buildMissionList();
   clearLBMissionList();
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
   
   LB_DifficultyButton.setText("Select Difficulty");
   
   LB_DifficultyList.clear();
   LB_DifficultyList.addRow(0, "Practice");
   LB_DifficultyList.addRow(1, "Beginner");
   LB_DifficultyList.addRow(2, "Medium");
   LB_DifficultyList.addRow(3, "Advanced");
   LB_DifficultyList.addRow(4, "Expert");
   LB_DifficultyList.addRow(5, "Custom");
   for (%i = 0; %i < LB_DifficultyList.rowCount(); %i++)
   {
      %obj = LB_DifficultyList.getRowTextById(%i);
      if (%obj !$= $MissionType)
         continue;
      %id = %i;
      break;
   }
   LB_DifficultyList.setSelectedById(%id);
   
   
   LB_DifficultyPopup.setVisible(false);
}

function LB_DifficultyList::onSelect(%this, %id)
{
   %type = %this.getRowTextById(%id);
   
   PMSetMissionTab(%type);
   
   LB_DifficultyButton.setText(%type);
   
   LB_DifficultyPopup.setVisible(false);
}

function LB_ToggleDifficultyPopUp()
{
   if (LB_DifficultyPopup.isVisible())
      LB_DifficultyPopup.setVisible(false);
   else
      LB_DifficultyPopup.setVisible(true);
}

function clearLBMissionList()
{
   for (%i = 0; %i < LB_missionSelectList.getCount(); %i++)
   {
      LB_missionSelectList.getObject(%i).delete();
   }
}

function populateLBList()
{
   clearLBMissionList();  
   clearLBMissionList();
   
   %group = "MTYPE_" @ $MissionType;
   
   for (%i = 0; %i < %group.getCount(); %i++)
   {
      %mission = %group.getObject(%i);
      %ctrl = new GuiControl(LB_MissionID_ @ %i)
      {
         profile = "GuiDefaultProfile";
         horizSizing = "center";
         vertSizing = "bottom";
         position = "0" SPC %i * 110;
         extent = "100 100";
         minExtent = "8 8";
         
         new GuiBitmapCtrl()
         {
            profile = "GuiButtonProfile";
            horizSizing = "center";
            vertSizing = "bottom";
            position = "0 10";
            extent = "90 60";
            minExtent = "8 8";
            visible = "1";
            command = "PM_setSelected(" @ %i @ ");LB_SetSelected(" @ %i @ ");setLevelLocked();";
            helpTag = "0";
            groupNum = "-1";
            buttonType = "PushButton";
            repeatPeriod = "1000";
            repeatDecay = "1";
            bitmap = PM_GetBitmap(%mission);
            wrap = "0";
         };
         
         new GuiMLTextCtrl(LB_LBL)
         {
            profile = "GuiMLTextProfile";
            horizSizing = "center";
            vertSizing = "bottom";
            position = "0 70";
            extent = "90 20";
            minExtent = "8 8";
            visible = "1";
            command = "PM_setSelected(" @ %i @ ");LB_SetSelected(" @ %i @ ");setLevelLocked();";
            helpTag = "0";
            groupNum = "-1";
            buttonType = "PushButton";
            repeatPeriod = "1000";
            repeatDecay = "1";
            wrap = "0";
         };
      };
      LB_LBL.setText(%i + 1 @ ". " @ %mission.name);
      LB_missionSelectList.add(%ctrl);
   }
   LB_missionSelectList.resize(1, 1, "114", LB_missionSelectList.getCount() * 110);
   
   LB_Scroll.scrollToTop();  
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
      $MissionType = "Practice";
      %group = MTYPE_practice;
   }
   if (%group.getCount() == 0)
   {
      LB_Play.setActive(false);
      //LB_NoQualOverlay.setVisible(true);
      //PM_NoQualText.setText("<color:CCCCCC><font:DomCasualD:32><just:center>No" SPC $MissionType SPC "Levels!");
      LB_Next.setActive(false);
      LB_Prev.setActive(false);
      LB_Preview.setBitmap("");
      LB_Desc.setText("");
      //PM_description.setText("");
      //PM_level_bkgnd.setText("<color:000000><font:DomCasualD:24><just:center>" @ $MissionType);
      //PM_level_fgnd.setText("<color:FFFFFF><font:DomCasualD:24><just:center>" @ $MissionType);
      return;
   }
   LB_Play.setActive(true);
   %mission = getField(PM_missionList.getRowTextById(%index), 1);//%group.getObject(%index);
   %name = "<color:000000><spush><font:Animated:24>" @ %mission.name @ "<spop><lmargin:10>\n\n";
   if (%mission.time)
      %qualify = "<spush><font:Animated:20><lmargin:0>Time: " @ formatTime(%mission.time) @ "<spop><lmargin:0>\n\n";
   if (%mission.artist !$= "")
   {
      %author = "<spush><font:Animated:18>" @ %mission.artist @ "<spop>\n\n";
   } else {
      %author = "<spush><font:Animated:18>" @ "Unknown Artist" @ "<spop>\n\n";
   }   
   %desc = %mission.desc @ "\n\n";
   %best = "<spush><font:Animated:20>Your best times:<spop><lmargin:10><tab:0,130,180><font:Arial Bold:14>\n";
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
   LB_Desc.setText(%name @ %author @ %desc);
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
   for (%i = 0; %i < LB_missionSelectList.getCount(); %i++)
   {
      %object = "LB_MissionID_"@%i;
      %object.profile = "GuiDefaultProfile";
   }
   
   %object = "LB_MissionID_"@%index;  
   %object.profile = "GuiPMSelectedMission";
}