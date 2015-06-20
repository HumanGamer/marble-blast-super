function playMissionGui::onWake(%this)
{
   %this.bitmap = getRandomBackground();
   buildMissionList();
   clearMissionList();
   //clearLBMissionList();
   
   PM_DifficultyButton.setText("Select Difficulty");
   
   PM_DifficultyList.clear();
   PM_DifficultyList.addRow(0, "Tutorial");
   PM_DifficultyList.addRow(1, "Beginner");
   PM_DifficultyList.addRow(2, "Intermediate");
   PM_DifficultyList.addRow(3, "Advanced");
   PM_DifficultyList.addRow(4, "Expert");
   PM_DifficultyList.addRow(5, "Custom");
   //PM_DifficultyList.addRow(6, "Directors Cut");
   for (%i = 0; %i < PM_DifficultyList.rowCount(); %i++)
   {
      %obj = PM_DifficultyList.getRowTextById(%i);
      if (%obj !$= $MissionType)
         continue;
      %id = %i;
      break;
   }
   PM_DifficultyList.setSelectedById(%id);
   
   
   PM_DifficultyPopup.setVisible(false);
   
   if ($InvalidLevels)
      MessageBoxOK("Error!", "Some levels did not load correctly!\nThis is most likely caused by syntax error(s)\n\nCheck the console for more info.");
}

function PM_DifficultyList::onSelect(%this, %id)
{
   %type = %this.getRowTextById(%id);
   
   //if (%type $= "Directors Cut")
   //   %type = "directorscut";
   PMSetMissionTab(%type);
   
   //if (%type $= "directorscut")
   //   %type = "Directors Cut";
   
   PM_DifficultyButton.setText(%type);
   
   PM_DifficultyPopup.setVisible(false);
}

//function PM_missionSelectList::onSelect(%this, %id)
//{
   //PM_setSelected(%id);
   //LB_SetSelected(%id);
   //setLevelLocked();
//}

function clearMissionList()
{
   for (%i = 0; %i < PM_missionSelectList.getCount(); %i++)
   {
      PM_missionSelectList.getObject(%i).delete();
   }
}

function PM_ToggleDifficultyPopUp()
{
   if (PM_DifficultyPopup.isVisible())
      PM_DifficultyPopup.setVisible(false);
   else
      PM_DifficultyPopup.setVisible(true);
}

function PM_StartMission()
{
   %id = PM_missionList.getSelectedId();
   %mission = getField(PM_missionList.getRowTextById(%id), 1);
   $LastMissionId = %id;
   $LastMissionType = %mission.type;

   // We need to start a server if one isn't already running
   if ($Server::ServerType $= "") {
      if($doRecordDemo)
      {
         //recordDemo("~/client/demos/demo.rec", %mission.file);
         startRecordingDemo(%mission);
      } else {
         startServer("SinglePlayer", %mission);
      }
   }
   else
      loadMission(%mission.file);
   if(isObject(MissionInfo))
      MissionInfo.level = %mission.level;
}

//function PM_skipQualify()
//{
//   %id = PM_missionList.getSelectedId();
//   %mission = getField(PM_missionList.getRowTextById(%id), 1);
//   if (%id - 1 == $pref::QualifiedLevel[$MissionType])
//      $pref::QualifiedLevel[$MissionType]++;
//   PM_setSelected(%id);
//   LB_SetSelected(%id);
//}

function populatePMList()
{
   //if (!playMissionGui.isAwake())
   //{
      //schedule(100, 0, "buildMissionList");
      //return;
   //}
   
   clearMissionList(); 
   //clearLBMissionList();
   
   clearMissionList();
   //clearLBMissionList();
   
   %group = "MTYPE_" @ $MissionType;
   
   for (%i = 0; %i < %group.getCount(); %i++)
   {
      %mission = %group.getObject(%i);
      %ctrl = new GuiControl(PM_MissionID_ @ %i)
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
            command = "PM_setSelected(" @ %i @ ");"; //LB_SetSelected(" @ %i @ ");";
            helpTag = "0";
            groupNum = "-1";
            buttonType = "PushButton";
            repeatPeriod = "1000";
            repeatDecay = "1";
            bitmap = PM_GetBitmap(%mission);
            wrap = "0";
         };
         
         new GuiMLTextCtrl(PM_LBL)
         {
            profile = "GuiMLTextProfile";
            horizSizing = "center";
            vertSizing = "bottom";
            position = "0 70";
            extent = "90 20";
            minExtent = "8 8";
            visible = "1";
            command = "PM_setSelected(" @ %i @ ");"; //LB_SetSelected(" @ %i @ ");";
            helpTag = "0";
            groupNum = "-1";
            buttonType = "PushButton";
            repeatPeriod = "1000";
            repeatDecay = "1";
            wrap = "0";
         };
      };
      PM_LBL.setText(%i + 1 @ ". " @ %mission.name);
      PM_missionSelectList.add(%ctrl);
   }
   PM_missionSelectList.resize(1, 1, "114", %group.getCount() * 110);
   
   PM_Scroll.scrollToTop();  
}

function buildMissionList()
{
   if (!isObject(PlayMissionGroup))
   {
      new SimGroup(PlayMissionGroup);
      RootGroup.add(PlayMissionGroup);
   }
   PM_missionList.clear();
   //PM_missionSelectList.clear();
   clearMissionList();
   //clearLBMissionList();
   
   if ($MissionType $= "")
      $MissionType = "Tutorial";
      
   if (isObject("MTYPE_" @ $MissionType))
      ("MTYPE_" @ $MissionType).clear();
      
   for (%file = findFirstFile($Server::MissionFileSpec);
         %file !$= ""; %file = findNextFile($Server::MissionFileSpec))
   {
      if (strStr(%file, "CVS/") == -1 && strStr(%file, "common/") == -1)
      {
         getMissionObject(%file);
      }
   }
   
   //if ($MissionErrorCount > 0)
   //{
   //   %invalidLevels = "";
   //   //%invalidLevels = "<font:Whitestone:32>Invalid Levels<font:Arial Bold:18>\n";
   //   for (%j = 0; %j < $MissionErrorCount; %j++)
   //   {
   //      %invalidLevels = %invalidLevels @ $MissionErrors[%j] @ "\n";
   //   }
   //}
   
   %group = "MTYPE_" @ $MissionType;
   
   sortByLevel(%group);
    
   
   //PM_missionSelectList.extent = "170" SPC %group.getCount() * 110;
   for (%i = 0; %i < %group.getCount(); %i++)
   {
      %mission = %group.getObject(%i);
      PM_missionList.addRow(%i, %mission.level TAB %mission);
      //PM_missionSelectList.addRow(%i, %i + 1 TAB %mission.name);
   }
   
   if (playMissionGui.isAwake())
   {
      populatePMList();
   }
   
   //if (lobbyGui.isAwake())
   //{
   //   populateLBList();
   //}
   
   //PM_missionSelectList.extent = "170" SPC PM_missionSelectList.getCount() * 110;
   //PM_missionSelectList.resize(1, 1, "114", PM_missionSelectList.getCount() * 110);
   
   //PM_Scroll.scrollToTop();
   
   //%level = $pref::QualifiedLevel[$MissionType] - 1;
   //if (%level >= %group.getCount())
   //   %level = %group.getCount() - 1;
   //PM_setSelected(%level);
   
   %level = $LastMissionId;
   
   if (%level $= "" || $LastMissionType !$= $MissionType)
      %level = 0;
      
   if (%level !$= "" && $LastMissionType $= $MissionType && $Game::Qualified)
         %level++; 
         
   if (%level > %group.getCount() - 1)
      %level = %group.getCount() - 1;
      
   if (%level < 0)
      %level = 0;
      
   PM_setSelected(%level);
   //LB_SetSelected(%level);
   //PM_missionSelectList.setSelectedById(%level);
   
   //MessageBoxOK("Invalid Levels", %invalidLevels, "");
}

function sortByLevel(%grp)
{
   if (%grp.getCount() <= 0)
      return;
   %ngrp = new SimGroup();
   while ((%obj = %grp.getObject(0)) != -1)
   {
      %ngrp.add(%obj);
      if (%grp.getCount() <= 0)
         break;
   }
   
   while (%ngrp.getCount() != 0)
   {
      %lowestLevel = %ngrp.getObject(0).level;
      
      %lowestIndex = 0;
      for (%i = 1; %i < %ngrp.getCount(); %i++)
      {
         %level = %ngrp.getObject(%i).level;
         if (%lowestLevel > %level)
         {
            %lowestIndex = %i;
            %lowestLevel = %level;
         }
      }
      
      %obj = %ngrp.getObject(%lowestIndex);
      %grp.add(%obj);
   }
   %ngrp.delete();
}

function PM_GetBitmap(%mission)
{
   if (!isFile(%mission))
      return strreplace(%mission.file, ".mis", "");
   else
      return strreplace(%mission, ".mis", "");
}

function containsEgg(%mission)
{
   return %mission.hasEgg;
}

function hasEgg(%mission)
{
   %found = $pref::EasterEgg[%mission.file];
}

function getGameModeName(%gamemode)
{
   switch$ (%gamemode)
   {
      case "Quota":
         return "Quota";
      case "Hunt":
         return "Gem Hunt";
      case "Side":
         return "Side Scrolling";
   }
   
   return "Standard";
}

function PM_setSelected(%index)
{
   %group = "MTYPE_" @ $MissionType;
   if (!isObject(%group))
   {
      $MissionType = "Tutorial";
      %group = MTYPE_tutorial;
   }
   %type = $MissionType;
   //if (%type $= "directorscut")
   //   %type = "Directors Cut";
   if (%group.getCount() == 0)
   {
      PM_play.setActive(false);
      PM_NoQualOverlay.setVisible(true);
      PM_NoQualText.setText("<color:CCCCCC><font:Bauhaus 93:32><just:center>No" SPC %type SPC "Levels!");
      PM_preview.setBitmap("");
      PM_description.setText("");
      PM_level_bkgnd.setText("<color:000000><font:Bauhaus 93:24><just:center>" @ %type);
      PM_level_fgnd.setText("<color:FFFFFF><font:Bauhaus 93:24><just:center>" @ %type);
      return;
   }
   %mission = getField(PM_missionList.getRowTextById(%index), 1);
   %name = "<color:000000><spush><font:Bauhaus 93:24><lmargin:1>" @ %mission.name @ "<spop><lmargin:10>";
   if (containsEgg(%mission))
   {
      if (hasEgg(%mission))
      {
         %egg = " <bitmap:marble/client/ui/play/easteregg_has.png>\n";
      } else {
         %egg = " <bitmap:marble/client/ui/play/easteregg_noegg.png>\n";
      }
   } else {
      %egg = "\n";
   }
   %gamemode = "<spush><font:Bauhaus 93:18><color:CCCCCC><shadowcolor:000000><shadow:1:1><lmargin:10>" @ getGameModeName(%mission.gameMode) @ "<spop><lmargin:0>\n\n";
   if (%mission.artist !$= "")
   {
      %author = "<spush><font:EntangledMBS:18><lmargin:1>" @ %mission.artist @ "<spop>\n\n";
   } else {
      %author = "<spush><font:EntangledMBS:18><lmargin:1>" @ "(Anonymous)" @ "<spop>\n\n";
   }
   if (%mission.time)
      %qualify = "<spush><font:Bauhaus 93:20><color:CCCCCC><shadowcolor:000000><shadow:1:1><lmargin:10>Par Time: " @ formatTime(%mission.time) @ "<spop><lmargin:0>\n";
   else
      %qualify = "<spush><font:Bauhaus 93:20><color:CCCCCC><shadowcolor:000000><shadow:1:1><lmargin:10>Par Time: " @ "None" @ "<spop><lmargin:0>\n";
   if (%mission.goldTime)
      %qualify = %qualify @ "<spush><font:Bauhaus 93:20><color:17e299><shadowcolor:000000><shadow:1:1><lmargin:10>Super Time: " @ formatTime(%mission.goldTime) @ "<spop><lmargin:0>\n";
   else
      %qualify = %qualify @ "<spush><font:Bauhaus 93:20><color:17e299><shadowcolor:000000><shadow:1:1><lmargin:10>Super Time: " @ "None" @ "<spop><lmargin:0>\n";
   if (%mission.hyperTime)
      %qualify = %qualify @ "<spush><font:Bauhaus 93:20><color:834396><shadowcolor:000000><shadow:1:1><lmargin:10>Hyper Time: " @ formatTime(%mission.hyperTime) @ "<spop><lmargin:0>\n\n";
   else
      %qualify = %qualify @ "<spush><font:Bauhaus 93:20><color:834396><shadowcolor:000000><shadow:1:1><lmargin:10>Hyper Time: " @ "None" @ "<spop><lmargin:0>\n\n";
   %desc = "<lmargin:1>" @ %mission.desc @ "\n\n";
   %best = "<spush><font:Bauhaus 93:20><lmargin:1>Your best times:<spop><lmargin:10><tab:0,130,180><font:Whitestone:14>\n";
   getBestTimes(%mission.file);
   %total = "";
   for (%i = 0; %i < 3; %i++)
   {
      %thetime = getField($hs[%i], 1) @ "\t" @ formatTime(getField($hs[%i], 0));
      %time = "<shadow:1:1><color:000000><shadowcolor:ffffff4f><lmargin:10>" @ %thetime;
      if (%mission.hyperTime && getField($hs[%i], 0) < %mission.hyperTime)
         %time = %time @ "<bitmap:marble/client/ui/play/hyperscore.png>";
      else if (%mission.goldTime && getField($hs[%i], 0) < %mission.goldTime)
         %time = %time @ "<bitmap:marble/client/ui/play/superscore.png>";
      %time = %time @ "\n";
      %total = %total @ %time;
   }
   PM_description.setText(%name @ %egg @ %gamemode @ %desc @ %author @ %qualify @ %best @ %total);
   %bmp = strreplace(%mission.file, ".mis", "");
   PM_preview.setBitmap(%bmp);
   //if (isFile(%bmp @ ".png"))
      //EG_preview.setBitmap(%bmp);// @ ".png");
   //else
      //EG_NextLevel.setBitmap(%bmp @ ".jpg");
   PM_level_bkgnd.setText("<color:000000><font:Bauhaus 93:24><just:center>" @ %type @ " Level " @ %index + 1);
   PM_level_fgnd.setText("<color:FFFFFF><font:Bauhaus 93:24><just:center>" @ %type @ " Level " @ %index + 1);
   //EG_level_bkgnd.setText("<color:000000><font:Bauhaus 93:24><just:center>" @ %type @ " Level " @ %index + 1);
   //EG_level_fgnd.setText("<color:FFFFFF><font:Bauhaus 93:24><just:center>" @ %type @ " Level " @ %index + 1);
   PM_missionList.setSelectedById(%index);
   
   //$CurrentLevelLocked = %index > $pref::QualifiedLevel[$MissionType] && !$unlockLevels;
   
   //setLevelLocked();
   
   if (!isFile(%bmp @ ".png") && !isFile(%bmp @ ".jpg"))
   {
      PM_NoQualOverlay.setVisible(true);
      PM_NoQualText.setText("<color:CCCCCC><font:Bauhaus 93:32><just:center>No Preview!");
      //EG_NoQualOverlay.setVisible(true);
      //EG_NoQualText.setText("<color:CCCCCC><font:Bauhaus 93:32><just:center>No Preview!");
   }
   
   for (%i = 0; %i < PM_missionSelectList.getCount(); %i++)
   {
      %object = "PM_MissionID_"@%i;
      %object.profile = "GuiDefaultProfile";
   }
   
   %object = "PM_MissionID_"@%index;  
   %object.profile = "GuiPMSelectedMission";
}

//function setLevelLocked()
//{
   //if ($CurrentLevelLocked)
   //{
      //PM_play.setActive(false);
      //PM_NoQualOverlay.setVisible(true);
      //PM_NoQualText.setText("<color:CCCCCC><font:Bauhaus 93:32><just:center>Locked!");
   //} else {
      //PM_play.setActive(true);
      //PM_NoQualOverlay.setVisible(false);
      //PM_NoQualText.setText("");
   //}
//}

function PMSetMissionTab(%tab)
{
   //%bitmap = "PM_Tab" @ $MissionType;
   //playMissionGui.getObject(0).bringtofront(%bitmap);
   
   $MissionType = %tab;
   
   //%bitmap = "PM_Tab" @ $MissionType;
   //playMissionGui.getObject(0).pushtoback(%bitmap);
   
   buildMissionList();
}

function getMissionObject(%mission) {
   %infoObject = "";
	%file = new FileObject();

	if ( %file.openForRead( %mission ) ) {
		%inInfoBlock = false;
		
		while ( !%file.isEOF() ) {
			%line = %file.readLine();
			%line = trim( %line );
			
			if( %line $= "new ScriptObject(MissionInfo) {" )
			{
            %line = "new ScriptObject() {";
				%inInfoBlock = true;
         } else if( %inInfoBlock && %line $= "};" ) {
				%inInfoBlock = false;
				%infoObject = %infoObject @ %line; 
				break;
			}
			
			if( %inInfoBlock )
			   %infoObject = %infoObject @ %line @ " ";
		}
		
		%file.close();
		%file.delete();
	}
	
	%infoObject = "%infoObject = " @ %infoObject;
	eval(%infoObject);
	
	if (!isObject(MTYPE_tutorial))
	   PlayMissionGroup.add(new SimGroup(MTYPE_tutorial));
	if (!isObject(MTYPE_beginner))
	   PlayMissionGroup.add(new SimGroup(MTYPE_beginner));
   if (!isObject(MTYPE_intermediate))
	   PlayMissionGroup.add(new SimGroup(MTYPE_intermediate));
   if (!isObject(MTYPE_advanced))
	   PlayMissionGroup.add(new SimGroup(MTYPE_advanced));
	   if (!isObject(MTYPE_expert))
	   PlayMissionGroup.add(new SimGroup(MTYPE_expert));
   if (!isObject(MTYPE_custom))
	   PlayMissionGroup.add(new SimGroup(MTYPE_custom));
   if (!isObject(MTYPE_template))
	   PlayMissionGroup.add(new SimGroup(MTYPE_template));
   //if (!isObject(MTYPE_directorscut))
	//   PlayMissionGroup.add(new SimGroup(MTYPE_directorscut));
	   
   if (%infoObject.type !$= "tutorial" && %infoObject.type !$= "beginner" && %infoObject.type !$= "intermediate" && %infoObject.type !$= "advanced" && %infoObject.type !$= "expert" && %infoObject.type !$= "template")// && %infoObject.type !$= "directorscut")
      %infoObject.type = "custom";
      
   if (%infoObject.gameType $= "")
      %infoObject.gameType = "SinglePlayer";
      
   if (playMissionGui.isAwake() && %infoObject.gameType !$= "SinglePlayer")
      return;
      
   if (!isObject(%infoObject)) {
      error("Invalid Level: " @ %mission);
      $InvalidLevels = true;
      //$MissionErrorCount++;
      //$MissionErrors[$MissionErrorCount] = %mission;
   } else {
      eval("MTYPE_" @ %infoObject.type @ ".add(%infoObject);");
   }
   
	%infoObject.file = %mission;
	
	return %infoObject;
}
