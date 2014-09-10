function playMissionGui::onWake(%this)
{
   buildMissionList();

   //if ($LastMissionId $= "" || $LastMissionType !$= %mission.type)
   //   $LastMissionId = 0;   
   //PM_setSelected($LastMissionId);
}

function PM_StartMission()
{
   %id = PM_missionList.getSelectedId();
   %mission = PM_missionList.getRowTextById(%id);//getField(PM_missionList.getRowTextById(%id), 1);
   $LastMissionId = %id;
   $LastMissionType = %mission.type;
   $WonLast = false;

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
   PM_setSelected(%id - 1);
}

function buildMissionList()
{
   if (!isObject(PlayMissionGroup))
      RootGroup.add(new SimGroup(PlayMissionGroup));
   PM_missionList.clear();
   if ($MissionType $= "")
      $MissionType = "Beginner";
   if (isObject("MTYPE_" @ $MissionType))
      ("MTYPE_" @ $MissionType).clear();
   %index = 0;
   for (%file = findFirstFile($Server::MissionFileSpec);
         %file !$= ""; %file = findNextFile($Server::MissionFileSpec))
   {
      if (strStr(%file, "CVS/") == -1 && strStr(%file, "common/") == -1)
      {
         %mission = getMissionObject(%file);
         if (%mission.type $= $MissionType)
         {
            PM_missionList.addRow(%index, %mission);
            %index++;
         }
      }
   }
   PM_missionList.sortNumerical(0);
   %group = "MTYPE_" @ $MissionType;
   sortByLevel(%group);
   sortByLevel(%group);
   //%level = $pref::QualifiedLevel[$MissionType] - 1;
   //if (%level >= %group.getCount())
   //   %level = %group.getCount() - 1;
   //PM_setSelected(%level);
   
   if ($LastMissionId $= "" || $LastMissionType !$= $MissionType)
      $LastMissionId = 0;
   if ($LastMissionId !$= "" && $LastMissionType $= $MissionType && $WonLast)
         $LastMissionId++; 
   if ($LastMissionId > %group.getCount() - 1)
      $LastMissionId = %group.getCount() - 1;
   if ($LastMissionId < 0)
      $LastMissionId = 0;
   PM_setSelected($LastMissionId);
   LB_SetSelected($LastMissionId);
   
   $WonLast = false;
}

function sortByLevel(%group)
{
   %new = new SimGroup();
   while ((%obj = %group.getObject(0)) != -1)
   {
      %new.add(%obj);
   }
   while (%new.getCount() != 0)
   {
      %lowestLevel = %new.getObject(0).level;
      %lowestIndex = 0;
      for (%i = 0; %i < %new.getCount(); %i++)
      {
         %level = %new.getObject(%i).level;
         if (%lowestLevel > %level)
         {
            %lowestIndex = %i;
            %lowestLevel = %level;
         }
      }
      %group.add(%new.getObject(%lowestIndex));
      
   }
   %new.delete();
   
   
   
   for (%i = 0; %i < %group.getCount(); %i++)
   {
      %level = %group.getObject(%i).level;
      if (%i > 0)
      {
         %olevel = %group.getObject(%i - 1).level;
         if (%level == %olevel)
         {
            %group.getObject(%i).level++;
         }
      }
   }
}

function PM_setSelected(%index)
{
   %group = "MTYPE_" @ $MissionType;
   if (!isObject(%group))
   {
      $MissionType = "Beginner";
      %group = MTYPE_beginner;
   }
   if (%group.getCount() == 0)
   {
      PM_play.setActive(false);
      PM_NoQualOverlay.setVisible(true);
      PM_NoQualText.setText("<color:CCCCCC><font:DomCasualD:32><just:center>No" SPC $MissionType SPC "Levels!");
      PM_next.setActive(false);
      PM_prev.setActive(false);
      PM_preview.setBitmap("");
      PM_description.setText("");
      PM_level_bkgnd.setText("<color:000000><font:DomCasualD:24><just:center>" @ $MissionType);
      PM_level_fgnd.setText("<color:FFFFFF><font:DomCasualD:24><just:center>" @ $MissionType);
      return;
   }
   //%mission = %group.getObject(%index);
   %mission = PM_missionList.getRowTextById(%index);//getField(PM_missionList.getRowTextById(%index), 1);
   %name = "<color:000000><spush><font:Arial Bold:24>" @ %mission.name @ "<spop><lmargin:10>\n\n";
   if (%mission.time)
      %qualify = "<spush><font:Arial:20><lmargin:0>Spare Time: " @ formatTime(%mission.time) @ "<spop><lmargin:0>\n\n";
   if (%mission.artist !$= "")
   {
      %author = "<spush><font:Arial Bold:18>" @ %mission.artist @ "<spop>\n\n";
   } else {
      %author = "<spush><font:Arial Bold:18>" @ "Unknown Artist" @ "<spop>\n\n";
   }
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
   PM_description.setText(%name @ %qualify @ %desc @ %author @ %best @ %total);
   %bmp = strreplace(%mission.file, ".mis", "");
   PM_preview.setBitmap(%bmp);
   if (%index <= 0) PM_prev.setActive(false); else PM_prev.setActive(true);
   if (%index >= %group.getCount() - 1) PM_next.setActive(false); else PM_next.setActive(true);
   PM_prev.command = "PM_setSelected(" @ %index - 1 @ ");";
   PM_next.command = "PM_setSelected(" @ %index + 1 @ ");";
   PM_level_bkgnd.setText("<color:000000><font:DomCasualD:24><just:center>" @ $MissionType @ " Level " @ %index + 1);
   PM_level_fgnd.setText("<color:FFFFFF><font:DomCasualD:24><just:center>" @ $MissionType @ " Level " @ %index + 1);
   PM_missionList.setSelectedById(%index);
   if (%index > $pref::QualifiedLevel[$MissionType] && !$testCheats)
   {
      PM_play.setActive(false);
      PM_NoQualOverlay.setVisible(true);
      PM_NoQualText.setText("<color:CCCCCC><font:Arial:32><just:center>You haven't unlocked this level yet.");
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
      PM_NoQualText.setText("<color:CCCCCC><font:Arial:32><just:center>No Preview!");
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
   if (!isObject(MTYPE_multiplayer))
	   PlayMissionGroup.add(new SimGroup(MTYPE_multiplayer));
	   
   if (%infoObject.type !$= "beginner" && %infoObject.type !$= "intermediate" && %infoObject.type !$= "advanced" && %infoObject.type !$= "expert" && %infoObject.type !$= "multiplayer")
      %infoObject.type = "custom";
   eval("MTYPE_" @ %infoObject.type @ ".add(%infoObject);");
	
	%infoObject.file = %mission;
	
	return %infoObject;
}

//function toggleMultiplayer()
//{
   //if ($pref::Multiplayer::isMultiplayer)
   //{
      //JoinServerButton.setVisible(true);
   //} else {
      //JoinServerButton.setVisible(false);
   //}
//}
