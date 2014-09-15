function ReplayCenterGui::onWake(%this)
{
   buildDemoList();
   populateReplayList();
}

function RC_List::onSelect(%this, %id)
{
   RC_SetSelected(%id);
}

function RC_SetSelected(%index)
{
   %text = RC_ReplayList.getRowTextById(%index);
   %base = fileBase(%text);
   %base = strreplace(%base, ".mis", "");
   %file = filePath(%text) @ "/" @ %base @ ".inf";
   
   if (isFile(%file))
   {
      %info = getDemoObject(%file);
      if (!isObject(%info))
      {
         error("Unable to find DemoInfo object!");
         RC_Preview.setBitmap("");
         return;
      }
      
      %mission = %info.mission;
      %mis = getMissionObject(%mission);
      
      %name = "<spush><font:Animated:24>" @ %info.name @ "<spop>\n\n";
      %desc = "<spush><font:Arial:14>" @ %info.desc @ "<spop>\n\n";
      %artist = "<spush><font:Animated:14>" @ %info.artist @ "<spop>\n\n";
      %levelName = "<spush><font:Animated:16>Level Name: <font:Arial:14>" @ %mis.name @ "<spop>";
      
      %desc = %name @ %desc @ %artist @ %levelName;
      
      
      %misPath = filePath(%mission);
      %misBase = fileBase(%mission);
      %imgBase = strreplace(%misBase, ".mis", "");
      %imgPath = %misPath @ "/" @ %imgBase;
      if (!isFile(%imgPath @ ".png") && !isFile(%imgPath @ ".jpg"))
      {
         error("No Mission Preview");
      }
      
      RC_Preview.setBitmap(%imgPath);
      RC_Desc.setText(%desc);
   } else {
      RC_Preview.setBitmap("");
   }
}

function RC_StartDemo()
{
   Canvas.setContent(LoadingGui);
   clearLoading();
   
   schedule(100, 0, "RC_ContinueStartDemo");
}

function RC_ContinueStartDemo()
{
   %id = RC_List.getSelectedId();
   %file = RC_ReplayList.getRowTextById(%id);
   $LastDemoId = %id;
   
   %info = getDemoInfo(%file);
   
   $BlastCount = %info.blastCount;
   
   for (%i = 0; %i < $BlastCount; %i++)
   {
      $BlastTime[%i] = %info.blastTime[%i];
      $UsedBlast[%i] = false;
   }
   
   $Demo::OOBCount = %info.oobCount;
   
   for (%i = 0; %i < $Demo::OOBCount; %i++)
   {
      $Demo::OOBTime[%i] = %info.oobTime[%i];
      $Demo::UsedOOB[%i] = false;
   }
   
   playDemo(%file);
}

function StartDemoTimer()
{
   $LastInputEventTime = getSimTime();
   
   // Disabled Demos for now as they can break multiplayer
   //$DemoTimerEvent = schedule(1000, 0, "checkDemoPlay");
}

function checkDemoPlay()
{
   if($LastInputEventTime + 10000 < getSimTime())
      playNextDemo();
   else
      $DemoTimerEvent = schedule(1000, 0, "checkDemoPlay");
}

function StopDemoTimer()
{
   cancel($DemoTimerEvent);
}

function playNextDemo()
{
   if($NumDemoFiles != 0)
   {
      playDemo($DemoFile[$NextDemoFile]);
      $NextDemoFile++;
      if($NextDemoFile >= $NumDemoFiles)
         $NextDemoFile = 0;
   }
}

function clearDemoList()
{
   for (%i = 0; %i < $NumDemoFiles; %i++)
   {
      $DemoFile[$NumDemoFiles] = "";
   }
   
   $NumDemoFiles = 0;
}

function buildDemoList()
{
   if($NumDemoFiles != 0)
      return;

   $NumDemoFiles = 0;
   $NextDemoFile = 0;
   for(%file = findFirstFile("*.rec"); %file !$= ""; %file = findNextFile("*.rec"))
   {
      $DemoFile[$NumDemoFiles] = %file;
      $NumDemoFiles++;
      
      %base = fileBase(%file);
      %base = strreplace(%base, ".mis", "");
      %inf = filePath(%file) @ "/" @ %base @ ".inf";
      
      if (!isFile(%inf))
         error("Missing File: " @ %inf);
   }
}

function addDemo(%demo)
{
   buildDemoList();   
   
   $DemoFile[$NumDemoFiles] = %demo;
   $NumDemoFiles++;
   
   populateReplayList();
}

function populateReplayList()
{
   RC_List.clear();
   RC_ReplayList.clear();
   for (%i = 0; %i < $NumDemoFiles; %i++)
   {
      %base = fileBase($DemoFile[%i]);
      %base = strreplace(%base, ".mis", "");
      %inf = filePath($DemoFile[%i]) @ "/" @ %base @ ".inf";
      %demo = getDemoObject(%inf);
      if (!isObject(%demo))
      {
         error("Error Obtaining Demo Info");
         RC_List.addRow(%i, fileBase($DemoFile[%i]));
         RC_ReplayList.addRow(%i, $DemoFile[%i]);
         continue;
      }
      RC_List.addRow(%i, (%i + 1) TAB %demo.name);
      RC_ReplayList.addRow(%i, $DemoFile[%i]);
   }
   
   if ($LastDemoId $= "")
      $LastDemoId = 0;
      
   if ($LastDemoId > RC_List.rowCount() - 1)
      $LastDemoId = RC_List.rowCount() - 1;
      
   if ($LastDemoId < 0)
      $LastDemoId = 0;
   RC_List.setSelectedById($LastDemoId);
   //RC_SetSelected($LastDemoId);
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
      //Canvas.setContent(MainMenuGui);
      $seeItPlayedDemo = false;
   }
   else
   {
      //runPresentation();
   }
   
   finishDemo();
}

function finishDemo()
{
   Canvas.setContent(ReplayCenterGui);
}

function getDemoObject(%demo)
{
   %infoObject = "";
	%file = new FileObject();

	if ( %file.openForRead( %demo ) ) {
		%inInfoBlock = false;
		
		while ( !%file.isEOF() ) {
			%line = %file.readLine();
			%line = trim( %line );
			
			if( %line $= "new ScriptObject(DemoInfo) {" )
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
	
	return %infoObject;
}

function getDemoInfo(%demo)
{
   return getDemoObject(strreplace(%demo, ".rec", ".inf"));
}
