function playMissionGui::onWake(%this)
{
   buildMissionList();
   
   PM_DifficultyPopup.clear();
   PM_DifficultyPopup.add("Tutorial", 0);
   PM_DifficultyPopup.add("Beginner", 1);
   PM_DifficultyPopup.add("Medium", 2);
   PM_DifficultyPopup.add("Advanced", 3);
   PM_DifficultyPopup.add("Expert", 4);
   for (%i = 0; %i < PM_DifficultyPopup.size(); %i++)
   {
      %obj = PM_DifficultyPopup.getTextById(%i);
      if (%obj !$= $MissionType)
         continue;
      %id = %i;
      break;
   }
   PM_DifficultyPopup.setSelected(%id);
}

function PM_DifficultyPopup::onSelect(%this, %id)
{
   %type = %this.getTextById(%id);
   
   PMSetMissionTab(%type);
}

function PM_missionSelectList::onSelect(%this, %id)
{
   PM_setSelected(%id);
   LB_SetSelected(%id);
}

function PM_StartMission()
{
   %id = PM_missionList.getSelectedId();
   %mission = getField(PM_missionList.getRowTextById(%id), 1);
   $LastMissionId = %id;
   $LastMissionType = %mission.type;

   if ($pref::Multiplayer::isMultiplayer)
      %serverType = "MultiPlayer";
   else
      %serverType = "SinglePlayer";

   // We need to start a server if one isn't already running
   if ($Server::ServerType $= "") {
      if($doRecordDemo)
         recordDemo("~/client/demos/demo.rec", %mission.file);
      startServer(%serverType, %mission);
   }
   else
      loadMission(%mission.file);
   if(isObject(MissionInfo))
      MissionInfo.level = %mission.level;
}

function PM_skipQualify()
{
   %id = PM_missionList.getSelectedId();
   %mission = getField(PM_missionList.getRowTextById(%id), 1);
   if (%id - 1 == $pref::QualifiedLevel[$MissionType])
      $pref::QualifiedLevel[$MissionType]++;
   PM_setSelected(%id);
   LB_SetSelected(%id);
}

function buildMissionList()
{
   if (!isObject(PlayMissionGroup))
   {
      new SimGroup(PlayMissionGroup);
      RootGroup.add(PlayMissionGroup);
   }
   PM_missionList.clear();
   PM_missionSelectList.clear();
   
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
   
   %group = "MTYPE_" @ $MissionType;
   
   sortByLevel(%group);
   
   for (%i = 0; %i < %group.getCount(); %i++)
   {
      %mission = %group.getObject(%i);
      PM_missionList.addRow(%i, %mission.level TAB %mission);
      PM_missionSelectList.addRow(%i, %i + 1 TAB %mission.name);
   }
   
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
   LB_SetSelected(%level);
   PM_missionSelectList.setSelectedById(%level);
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

function PM_setSelected(%index)
{
   %group = "MTYPE_" @ $MissionType;
   if (!isObject(%group))
   {
      $MissionType = "Tutorial";
      %group = MTYPE_tutorial;
   }
   if (%group.getCount() == 0)
   {
      PM_play.setActive(false);
      PM_NoQualOverlay.setVisible(true);
      PM_NoQualText.setText("<color:CCCCCC><font:Animated:32><just:center>No" SPC $MissionType SPC "Levels!");
      PM_preview.setBitmap("");
      PM_description.setText("");
      PM_level_bkgnd.setText("<color:000000><font:Animated:24><just:center>" @ $MissionType);
      PM_level_fgnd.setText("<color:FFFFFF><font:Animated:24><just:center>" @ $MissionType);
      return;
   }
   %mission = getField(PM_missionList.getRowTextById(%index), 1);
   %name = "<color:000000><spush><font:Animated:24>" @ %mission.name @ "<spop><lmargin:10>\n\n";
   if (%mission.time)
      %qualify = "<spush><font:Animated:20><lmargin:0>Spare Time: " @ formatTime(%mission.time) @ "<spop><lmargin:0>\n\n";
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
   PM_description.setText(%name @ %qualify @ %desc @ %author @ %best @ %total);
   %bmp = strreplace(%mission.file, ".mis", "");
   PM_preview.setBitmap(%bmp);
   PM_level_bkgnd.setText("<color:000000><font:Animated:24><just:center>" @ $MissionType @ " Level " @ %index + 1);
   PM_level_fgnd.setText("<color:FFFFFF><font:Animated:24><just:center>" @ $MissionType @ " Level " @ %index + 1);
   PM_missionList.setSelectedById(%index);
   if (%index > $pref::QualifiedLevel[$MissionType] && !$unlockLevels)
   {
      PM_play.setActive(false);
      PM_NoQualOverlay.setVisible(true);
      PM_NoQualText.setText("<color:CCCCCC><font:Animated:32><just:center>Locked!");
   }
   else
   {
      PM_play.setActive(true);
      PM_NoQualOverlay.setVisible(false);
      PM_NoQualText.setText("");
   }
   
   if (!isFile(%bmp @ ".png") && !isFile(%bmp @ ".jpg"))
   {
      PM_NoQualOverlay.setVisible(true);
      PM_NoQualText.setText("<color:CCCCCC><font:Animated:32><just:center>No Preview!");
   }
}

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
   if (!isObject(MTYPE_medium))
	   PlayMissionGroup.add(new SimGroup(MTYPE_medium));
   if (!isObject(MTYPE_advanced))
	   PlayMissionGroup.add(new SimGroup(MTYPE_advanced));
	   if (!isObject(MTYPE_expert))
	   PlayMissionGroup.add(new SimGroup(MTYPE_expert));
   if (!isObject(MTYPE_custom))
	   PlayMissionGroup.add(new SimGroup(MTYPE_custom));
   if (!isObject(MTYPE_multiplayer))
	   PlayMissionGroup.add(new SimGroup(MTYPE_multiplayer));
	   
   if (%infoObject.type !$= "tutorial" && %infoObject.type !$= "beginner" && %infoObject.type !$= "medium" && %infoObject.type !$= "advanced" && %infoObject.type !$= "expert" && %infoObject.type !$= "multiplayer")
      %infoObject.type = "custom";
   eval("MTYPE_" @ %infoObject.type @ ".add(%infoObject);");
	
	%infoObject.file = %mission;
	
	return %infoObject;
}

function onDemoPlay(%misFile)
{
   $playingDemo = true;
   createServer("SinglePlayer", %misFile);
   %conn = new GameConnection(ServerConnection);
   RootGroup.add(ServerConnection);
   %conn.setConnectArgs($pref::Player::Name);
   %conn.setJoinPassword($Client::Password);
   %conn.connectLocal();
}

function onDemoPlayDone(%forced)
{
   $playingDemo = false;
   disconnect();

   if( %forced || $seeItPlayedDemo )
   {
      Canvas.setContent(MainMenuGui);
      $seeItPlayedDemo = false;
   }
   else
      runPresentation();
}
