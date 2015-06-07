//-----------------------------------------------------------------------------
// Torque Game Engine
//
// Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Penalty and bonus times.
$Game::TimeTravelBonus = 5000;

// Item respawn values, only powerups currently respawn
$Item::RespawnTime = 7 * 1000;
$Item::PopTime = 10 * 1000;

// Game duration in secs, no limit if the duration is set to 0
$Game::Duration = 0;

// Pause while looking over the end game screen (in secs)
$Game::EndGamePause = 5;

//-----------------------------------------------------------------------------
// Variables extracted from the mission
$Game::GemCount = 0;
$Game::StartPad = 0;
$Game::EndPad = 0;

$Game::CurrentCheckPoint = 0;

//-----------------------------------------------------------------------------
//  Functions that implement game-play
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

function onServerCreated()
{
   // Server::GameType is sent to the master server.
   // This variable should uniquely identify your game and/or mod.
   $Server::GameType = $Multiplayer::GameName;

   // Server::MissionType sent to the master server.  Clients can
   // filter servers based on mission type.
   $Server::MissionType = "Deathmatch";

   // GameStartTime is the sim time the game started. Used to calculated
   // game elapsed time.
   $Game::StartTime = 0;
   
   $Game::MaxGemRadius = 20;
   $Game::MaxGemsPerSpawn = 4;

   // Load up all datablocks, objects etc.  This function is called when
   // a server is constructed.
   exec("./audioProfiles.cs");
   exec("./camera.cs");
   exec("./markers.cs");
   exec("./triggers.cs");
   exec("./inventory.cs");
   exec("./shapeBase.cs");
   exec("./staticShape.cs");
   exec("./item.cs");

   // Basic items
   exec("./marble.cs");
   //exec("./ghost.cs");
   exec("./gems.cs");
   exec("./powerUps.cs");
   exec("./buttons.cs");
   exec("./hazards.cs");
   exec("./pads.cs");
   exec("./bumpers.cs");
   exec("./signs.cs");
   exec("./fireworks.cs");
   exec("./beams.cs");
   exec("./checkpoint.cs");
   exec("./teleporter.cs");
   exec("./easter.cs");
   exec("./cannon.cs");
   exec("./water.cs");

   // Platforms and interior doors
   exec("./pathedInteriors.cs");
   exec("./hidingPlatforms.cs");
   exec("./rotationPlatforms.cs");

   // Multiplayer
   //exec("./multiplayer.cs");

   // Keep track of when the game started
   $Game::StartTime = $Sim::Time;
}

function onServerDestroyed()
{
   // Perform any game cleanup without actually ending the game
   destroyGame();
}


//-----------------------------------------------------------------------------

function onMissionLoaded()
{
   // Called by loadMission() once the mission is finished loading.
   // Nothing special for now, just start up the game play.

   $Game::GemCount = countGems(MissionGroup);

   setGravityDir("1 0 0 0 -1 0 0 0 -1",true);
   $Game::CurrentGravityDir = "1 0 0 0 -1 0 0 0 -1";

   // Start the game here if multiplayer...
   //if ($Server::ServerType $= "MultiPlayer")
   //   startGame();
}

function onMissionEnded()
{
   $Server::MissionLoaded = false;
   // Called by endMission(), right before the mission is destroyed
   // This part of a normal mission cycling or end.
   endGame();
}

function onMissionReset()
{
   setGravityDir("1 0 0 0 -1 0 0 0 -1",true);
   $Game::CurrentGravityDir = "1 0 0 0 -1 0 0 0 -1";
   endFireWorks();
   
   // Reset the players and inform them we're starting
   for( %clientIndex = 0; %clientIndex < ClientGroup.getCount(); %clientIndex++ ) {
      %cl = ClientGroup.getObject( %clientIndex );
      commandToClient(%cl, 'GameStart');
	  if (MissionInfo.gameMode !$= "hunt")
          %cl.resetStats();
   }

   // Start the game duration timer
   if ($Game::Duration)
      $Game::CycleSchedule = schedule($Game::Duration * 1000, 0, "onGameDurationEnd" );
   $Game::Running = true;

   ServerGroup.onMissionReset();

   // Set the initial state
   //setGameState("Start");
   //setupGameRadar();
}

function SimGroup::onMissionReset(%this)
{
   for(%i = 0; %i < %this.getCount(); %i++)
      %this.getObject(%i).onMissionReset();
}

function SimGroup::resetCheckPoint(%this)
{
   for(%i = 0; %i < %this.getCount(); %i++)
   {
      %obj = %this.getObject(%i);
      if (%obj.getClassName() $= "Item")// && %obj.getDataBlock().classname $= "Gem")
      {
         if (%obj.checkpointNum > $Game::CurrentCheckPoint)
            %obj.onMissionReset();
      } else if (%obj.getClassName() $= "SimGroup")
      {
         %obj.resetCheckPoint();
      } else if (%obj.getClassName() $= "PathedInterior")
      {
         if (%obj.checkpointNum > $Game::CurrentCheckPoint)
            %obj.onMissionReset();
      }
   }
}

function SimObject::onMissionReset(%this)
{
}

function GameBase::onMissionReset(%this)
{
   %this.getDataBlock().onMissionReset(%this);
}

//-----------------------------------------------------------------------------

function startGame()
{
   //if ($Game::Running) {
   //   error("startGame: End the game first!");
   //   return;
   //}
   $Game::Running = true;
   $Game::Qualified = false;
   onMissionReset();
   
   if (MissionInfo.gameMode $= "hunt")
   {
	   hideAllGems();
      handleGems();
   }
   
   onGameStartup();
}

function resetGems()
{
   hideAllGems();
   spawnGemGroup();
}

function handleGems()
{
   %group = NameToID("MissionGroup/GemSpawns");
   if (!isObject(%group))
      return;
   for (%i = 0; %i < %group.getCount(); %i++)
   {
      %obj = %group.getObject(%i);
	   if (%obj.getClassName() $= "Item" && %obj.getDatablock().className $= "Gem")
	   {
	 	  if (!%obj.isHidden())
           return;
	   }
   }
   hideAllGems();
   spawnGemGroup();
}

function hideAllGems()
{
   %group = NameToID("MissionGroup/GemSpawns");
   if (!isObject(%group))
      return;
	for (%i = 0; %i < %group.getCount(); %i++)
   {
	   %obj = %group.getObject(%i);
	   if (%obj.getClassName() $= "Item" && %obj.getDatablock().className $= "Gem")
	   {
	 	  %obj.hide(true);
	 	  if (isObject(%obj.beam) && %obj.beam.getClassName() $= "StaticShape")
           %obj.beam.delete();
        if (isObject(%obj.node) && %obj.node.getClassName() $= "ParticleEmitterNode")
           %obj.node.delete();
	   }
   }
}

function getAverageGemPosition()
{
   %group = NameToID("MissionGroup/GemSpawns");
   if (!isObject(%group))
      return;
      
   //%totalX = 0;
   //%totalY = 0;
   //%totalZ = 0;
   
   for (%i = 0; %i < %group.getCount(); %i++)
   {
      %obj = %group.getObject(%i);
      
      if (%obj.isHidden())
         continue;    
      
      %position = %obj.getPosition();
      return %position;
      //%x = getWord(%position, 0);
      //%y = getWord(%position, 1);
      //%z = getWord(%position, 2);
      
      //%totalX += %x;
      //%totalY += %y;
      //%totalZ += %z;
   }
   
   //%totalX /= %group.getCount();
   //%totalY /= %group.getCount();
   //%totalZ /= %group.getCount();
   
   //return %totalX SPC %totalY SPC %totalZ;
}

function spawnGemGroup()
{
   %group = NameToID("MissionGroup/GemSpawns");
   if (!isObject(%group))
      return;
   
   //commandToAll('ClearRadar');
   //%groups = new SimGroup();

   %gem = %group.getObject(getRandom(%group.getCount() - 1)); 
   %gem.hide(false);  
   
   if (isObject(%gem.beam) && %gem.beam.getClassName() $= "StaticShape")
      %gem.beam.delete();
   if (isObject(%gem.node) && %gem.node.getClassName() $= "ParticleEmitterNode")
      %gem.node.delete();
   
   %position = %gem.getPosition();    
   %rotation = %gem.rotation;  
   %scale = %gem.getScale();    
         
   %shape = new StaticShape()
   {
      datablock = "GemBeam";
      position = %position;
      rotation = %rotation;
      scale = %scale;
   };
   
   %gem.beam = %shape;
   %gem.beam.setSkinName(%gem.getDatablock().skin);
   
   createGemParticles(%gem);
   
   if (isObject(MissionCleanup))
      MissionCleanup.add(%shape);
   
   %x = getWord(%position, 0);
   %y = getWord(%position, 1);
   
   //echo("Pos: " @ %x @ " " @ %y);
   
   //commandToAll('UpdateRadarObject', %gem.getId(), %gem.getDatablock().skin, %x, %y);
   
   %maxGemsPerSpawn = MissionInfo.maxGemsPerSpawn;
   if (%maxGemsPerSpawn $= "")
      %maxGemsPerSpawn = $Game::MaxGemsPerSpawn;
   
   for (%i = 0; %i < %maxGemsPerSpawn; %i++)
   {
      %lastDist = "";
	   //%obj = %group.getObject(%i);
	   
	   for (%j = 0; %j < %group.getCount(); %j++)
	   {
	      %obj = %group.getObject(%j);
         if (%obj.getClassName() $= "Item" && %obj.getDatablock().className $= "Gem" && %obj.isHidden())
         {
            %dist = VectorDist(%obj.getTransform(), %gem.getTransform());
            //echo("Distance: " @ %dist);
			
			%radius = MissionInfo.gemSpawnRadius;
			if (%radius $= "")
				%radius = $Game::MaxGemRadius;
            
            if ((%dist < %lastDist || %lastDist $= "") && %dist < %radius)
            {
               %lastDist = %dist;
               %lastObj = %obj;
               //echo("New Distance: " @ %dist);
            }
         }
	   }
	   
	   if (isObject(%lastObj))
	   {
	      %lastObj.hide(false);
         
         
   
         if (isObject(%lastObj.beam) && %lastObj.beam.getClassName() $= "StaticShape")
            %lastObj.beam.delete();
         if (isObject(%lastObj.node) && %lastObj.node.getClassName() $= "ParticleEmitterNode")
            %lastObj.node.delete();
	      
         %position = %lastObj.getPosition();   
         %rotation = %lastObj.rotation;  
         %scale = %lastObj.getScale();    
               
         %shape = new StaticShape()
         {
            datablock = "GemBeam";
            position = %position;
            rotation = %rotation;
            scale = %scale;
         };
         
         %lastObj.beam = %shape;
         %lastObj.beam.setSkinName(%lastObj.getDatablock().skin);
         
         createGemParticles(%lastObj);
         
         if (isObject(MissionCleanup))
            MissionCleanup.add(%shape);
         
         %x = getWord(%position, 0);
         %y = getWord(%position, 1);
         
         //echo("Pos: " @ %x @ " " @ %y);
   
         //commandToAll('UpdateRadarObject', %lastObj.getId(), %lastObj.getDatablock().skin, %x, %y);
	   }
   }
   //setupGameRadar();
}

function endGame()
{
   if (!$Game::Running) {
      error("endGame: No game running!");
      return;
   }
   $Game::GameLoops = 0;
   cancel($Multiplayer::UpdateSchedule);
   cancel($Multiplayer::DeltaUpdate);   
   cancel($Multiplayer::CollisionUpdate);
   cancel($Multiplayer::OOBUpdate);
   cancel($Multiplayer::SpeedUpdate);
   destroyGame();

   // Inform the clients the game is over
   if (!$escapeEnd)
   {
      for (%index = 0; %index < ClientGroup.getCount(); %index++)  {
         %client = ClientGroup.getObject(%index);
         //if (!$Client::ConnectedMultiplayer)
         commandToClient(%client, 'GameEnd');
         %client.stopTimer();
      }
   }
   $escapeEnd = false;

   // Single player... grab the playgui as the elapsed time and
   // roll in clients penalty and bonus
   //PlayGUI.stopTimer();

   $Game::ScoreTime = PlayGui.elapsedTime;
   $Game::ElapsedTime = PlayGui.elapsedTime - %client.penaltyTime + PlayGui.totalBonus;
   $Game::PenaltyTime = %client.penaltyTime;
   $Game::BonusTime = PlayGui.totalBonus;

   // Not all missions have time qualifiers
   $Game::Qualified = MissionInfo.time? $Game::ScoreTime < MissionInfo.time: true;

   // Bump up the max level
   if (!$DemoBuild && !$playingDemo && $Game::Qualified && (MissionInfo.level + 1) > $Pref::QualifiedLevel[MissionInfo.type])
         $Pref::QualifiedLevel[MissionInfo.type] = MissionInfo.level + 1;
         
   //if ($Client::ConnectedMultiplayer)
   //{
      //for (%index = 0; %index < ClientGroup.getCount(); %index++)  {
         //%client = ClientGroup.getObject(%index);
         //commandToClient(%client, 'SetLobby');
      //}
   //}
}

function pauseGame()
{
   if ($Server::ServerType $= "SinglePlayer")
      $gamePaused = true;
}

function resumeGame()
{
   $gamePaused = false;
}

function destroyGame()
{
   if (isObject($CurrentBlastNode))
      deleteBlast();
   // Cancel any client timers
   for (%index = 0; %index < ClientGroup.getCount(); %index++)
   {
      cancel(ClientGroup.getObject(%index).respawnSchedule);
      cancel(ClientGroup.getObject(%index).StateSchedule);
   }

   // Perform cleanup to reset the game.
   cancel($Game::CycleSchedule);

   $Game::Running = false;
}


//-----------------------------------------------------------------------------

function GameConnection::setGameState(%this, %state)
{
   cancel(%this.StateSchedule);
   %this.GameState = %state;
   eval("%this.State"@%state@"();");
   //echo("State "@%state@"");
}

function GameConnection::StateStart(%this)
{
   %this.camera.setFlyMode();
   %this.setControlObject(%this.player);
   %this.resetTimer();
   %this.setMessage("");
   if (MissionInfo.gameMode !$= "hunt")
   {
	   %this.setGemCount(0);
	   if (MissionInfo.gameMode $= "Quota")
	   {
	      %this.setMaxGems(MissionInfo.quotaCount);
	      %this.setQuotaGems($Game::GemCount);
	   } else {
	      %this.setMaxGems($Game::GemCount);
	   }
   } else {
       %this.setTime(MissionInfo.time);
	   %this.setGemCount(0);
	   %this.setMaxGems(0);
   }
   if (isObject(StartPoint))
   {
      %position = StartPoint.getPosition();
      %rotation = StartPoint.rotation;  
      %scale = StartPoint.getScale();    
            
      %shape = new StaticShape()
      {
         datablock = "PadBeam";
         position = %position;
         rotation = %rotation;
         scale = %scale;
      };
      
      StartPoint.beam = %shape;
      StartPoint.beam.setSkinName("base");
      
      MissionCleanup.add(%shape);
      
   }
   if (isObject(StartPoint))
      StartPoint.playThread(0, "ambient");
   %this.StateSchedule = %this.schedule( 500, "setGameState", "Ready");
   if(MissionInfo.startHelpText !$= "")
   {
      %this.addHelpLine(MissionInfo.startHelpText, false);
   }
}

function GameConnection::StateReady(%this)
{
   %this.play2d(ReadyVoiceSfx);
   %this.setMessage("ready");
   %this.StateSchedule = %this.schedule( 1500, "setGameState", "set");
}

function GameConnection::StateSet(%this)
{
   %this.play2d(SetVoiceSfx);
   %this.setMessage("set");
   %this.StateSchedule = %this.schedule( 1500, "setGameState", "Go");
}

function GameConnection::StateGo(%this)
{
   %this.play2d(GetRollingVoiceSfx);
   %this.setMessage("go");
   %this.startTimer();
   %this.AnimSchedule = %this.schedule( 500, "animEnd");
   %this.StateSchedule = %this.schedule( 2000, "setGameState", "Play");

   // Target the players to the end pad and let them lose
   for( %index = 0; %index < ClientGroup.getCount(); %index++ ) {
      %player = ClientGroup.getObject(%index).player;
      %player.setPad($Game::EndPad);
      %player.setMode(Normal);
   }
   
   if (isObject(StartPoint) && isObject(StartPoint.beam) && StartPoint.beam.getClassName() $= "StaticShape")
      StartPoint.beam.delete();
}

function GameConnection::StatePlay(%this)
{
   // Normaly play mode
   %this.setMessage("");
}

function GameConnection::AnimEnd(%this)
{
   if (isObject(StartPoint))
      StartPoint.stopThread(0);
}

function GameConnection::StateEnd(%this)
{
   // Do score calculations, messages to winner, losers, etc.
   %this.stopTimer();
   %this.play2d(WonRaceSfx);
   
   if ($Server::ServerType $= "SinglePlayer")
   {
      //startFireWorks(EndPoint);
      %this.StateSchedule = schedule( 2000, 0, "endGame");
   }
   else {
      //if (%this.player.getIsOOB())
      //{
      if(isEventPending(%this.respawnSchedule))
      {
         cancel(%this.respawnSchedule);
      }
      //startFireWorks(%this.player);
      //}
      %this.StateSchedule = schedule( 2000, 0, "endGame");//respawnPlayerHunt);
   }
}

function GameConnection::StateWait(%this)
{   
   //%this.resetTimer();
   %this.camera.setTransform("0 0 14 1 0 0 0");
   %this.setControlObject(%this.camera);
   //%this.camera.setOrbitMode(%this.player, %this.player.getTransform(), 0.5, 4.5, 4.5);
}


//-----------------------------------------------------------------------------

function onGameDurationEnd()
{
   // This "redirect" is here so that we can abort the game cycle if
   // the $Game::Duration variable has been cleared, without having
   // to have a function to cancel the schedule.
   if ($Game::Duration && !isObject(EditorGui))
      cycleGame();
}

function cycleGame()
{
   // This is setup as a schedule so that this function can be called
   // directly from object callbacks.  Object callbacks have to be
   // carefull about invoking server functions that could cause
   // their object to be deleted.
   if (!$Game::Cycling) {
      $Game::Cycling = true;
      $Game::CycleSchedule = schedule(0, 0, "onCycleExec");
   }
}

function onCycleExec()
{
   // End the current game and start another one, we'll pause for a little
   // so the end game victory screen can be examined by the clients.
   endGame();
   $Game::CycleSchedule = schedule($Game::EndGamePause * 1000, 0, "onCyclePauseEnd");
}

function onCyclePauseEnd()
{
   $Game::Cycling = false;
   loadNextMission();
}

function loadNextMission()
{
   %nextMission = "";

   // Cycle to the next level, or back to the start if there aren't
   // any more levels.
   for (%file = findFirstFile($Server::MissionFileSpec);
         %file !$= ""; %file = findNextFile($Server::MissionFileSpec))
      if (strStr(%file, "CVS/") == -1 && strStr(%file, "common/") == -1)
      {
         %mission = getMissionObject(%file);
         if (%mission.type $= MissionInfo.type) {
            if (%mission.level == 1)
               %nextMission = %file;
            if ((%mission.level + 0) == MissionInfo.level + 1) {
               echo("Found one!");
               %nextMission = %file;
               break;
            }
         }
      }
   loadMission(%nextMission);
}



//-----------------------------------------------------------------------------
// GameConnection Methods
// These methods are extensions to the GameConnection class. Extending
// GameConnection make is easier to deal with some of this functionality,
// but these could also be implemented as stand-alone functions.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

function GameConnection::incPenaltyTime(%this,%dt)
{
   commandToClient(%this, 'IncPenaltyTime', %dt);
   %this.penaltyTime += %dt;
}

function GameConnection::incBonusTime(%this,%dt)
{
   commandToClient(%this, 'IncBonusTime', %dt);
   %this.bonusTime += %dt;
}


//-----------------------------------------------------------------------------

function GameConnection::onClientEnterGame(%this)
{
   commandToClient(%this, 'HideWater');
   commandToClient(%this, 'HidePhysMod');
   //setupGameRadar();
   // Matt: for some reason this doesn't work without doing it multiple times
   //for (%i = 0; %i < 100; %i++)
   //   commandToClient(%this, 'ClearRadar');
   commandToClient(%this, 'SetMode', MissionInfo.gameMode);
   //commandToClient(%this, 'AddPlayer', %this.getId(), %this.nameBase, true, 0, false);
   
   resetGems();
   
   //for (%i = 0; %i < ClientGroup.getCount(); %i++)
   //{
   //   %client = ClientGroup.getObject(%i);
      
      //if (%client.getId() !$= %this.getId())
      //   commandToClient(%client, 'AddPlayer', %this.getId(), %this.nameBase, false, 0, false);
   //}
   
   // Create a new camera object.
   %this.camera = new Camera() {
      dataBlock = Observer;
   };
   if (isObject(MissionCleanup))
      MissionCleanup.add( %this.camera );
   %this.camera.scopeToClient(%this);

   // Setup game parameters and create the player
   if ($Server::ServerType $= "SinglePlayer")
   {
      %this.resetStats();
      %this.spawnPlayer();

      if (%this.isHost())
      {
         // Anchor the player to the start pad
         %this.player.setMode(Start);
      } else {
         %this.player.setMode("normal");//(ClientGroup.getObject(0).player.getMode());
      }
   }

   // Start the game here for single player
   if ($Server::ServerType $= "SinglePlayer")
      startGame();
   
   if (%this.isHost())   
      if ($Server::ServerType $= "MultiPlayer")
         %this.setGameState("wait");
      else
         %this.setGameState("start");
   else {
      %this.setGameState(ClientGroup.getObject(0).GameState);
      %this.setTime(PlayGui.elapsedTime);
      %this.startTimer();
   }
   
   $Server::MissionLoaded = true;
   
   if ($Server::ServerType $= "MultiPlayer")
      %this.schedule(1000, "ShowPreMission");
      
   //setupGameRadar();
}

function GameConnection::ShowPreMission(%this)
{
   commandToClient(%this, 'ShowPreMission');
}

function GameConnection::onClientLeaveGame(%this)
{
   
   commandToClient(%this, 'StopBlast');
   //commandToAll('RemovePlayer', %this.getId());
   if (isObject(%this.camera))
      %this.camera.delete();
   if (isObject(%this.player))
      %this.player.delete();
   //if (isObject(%this.ghost))
      //%this.ghost.delete();
   $Multiplayer::MarbleCount--;
}

function GameConnection::resetStats(%this)
{
   // Reset game stats
   %this.bonusTime = 0;
   %this.penaltyTime = 0;
   %this.gemCount = 0;
   $Game::CurrentCheckPoint = 0;

   // Reset the checkpoint
   if (isObject(%this.checkPoint))
      %this.checkPoint.delete();
   %this.checkPoint = new ScriptObject() {
      pad = $Game::StartPad;
      time = 0;
      gemCount = 0;
      penaltyTime = 0;
      bonusTime = 0;
      powerUp = 0;
   };
}


//-----------------------------------------------------------------------------

function GameConnection::onEnterPad(%this)
{
   if (%this.player.getPad() == $Game::EndPad && MissionInfo.gameMode !$= "hunt") {
      
      if (MissionInfo.gameMode $= "Quota")
      {
         if (%this.gemCount < MissionInfo.quotaCount)
         {
            %this.play2d(MissingGemsSfx);
            messageClient(%this, 'MsgMissingGems', '\c0You can\'t finish without enough gems!!');
         } else {
            %this.player.setMode(Victory);
            messageClient(%this, 'MsgRaceOver', '\c0Congratulations! You\'ve finished!');
            %this.setGameState("End");
         }
      } else if ($Game::GemCount && %this.gemCount < $Game::GemCount) {
         %this.play2d(MissingGemsSfx);
         messageClient(%this, 'MsgMissingGems', '\c0You can\'t finish without all the gems!!');
      }
      else {
         %this.player.setMode(Victory);
         messageClient(%this, 'MsgRaceOver', '\c0Congratulations! You\'ve finished!');
         %this.setGameState("End");
      }
   }
}

function GameConnection::onLeavePad(%this)
{
   // Don't care if the leave
}


//-----------------------------------------------------------------------------

function GameConnection::onOutOfBounds(%this)
{
   if (%this.GameState $= "End")
      return;
      
   if (MissionInfo.gameMode $= "hunt")
   {
      %this.player.lastPowerUp = %this.player.getPowerUp();
      
      %this.player.setPowerUp("");
      
      %this.setPowerUp(%this.player.lastPowerUp.shapeFile);
   
   }

   // Reset the player back to the last checkpoint
   %this.setMessage("outOfBounds",2000);
   %this.play2d(OutOfBoundsVoiceSfx);
   %this.player.setOOB(true);
   if(!isEventPending(%this.respawnSchedule))
      %this.respawnSchedule = %this.schedule(2500, respawnPlayer);
      
   %this.player.isOOB = true;
}

function Marble::onOOBClick(%this)
{
   //if(%this.client.GameState $= "Play")
   //{
   //   %this.client.respawnPlayer();
   //}
}

function GameConnection::onDestroyed(%this)
{
   if (%this.client.GameState $= "End")
      return;

   // Reset the player back to the last checkpoint
   PlayGui.setMessage("destroyed",2000);
   %client.play2d(DestroyedVoiceSfx);
   %this.player.setOOB(true);
   if(!isEventPending(%this.respawnSchedule))
      %this.respawnSchedule = %this.schedule(2500, respawnPlayer);
}

function GameConnection::onFoundGem(%this,%amount, %gem)
{
   %this.gemCount += %amount;
   if (MissionInfo.gameMode !$= "hunt")
   {
	   if (MissionInfo.gameMode $= "Quota")
	   {
	      %remaining = MissionInfo.quotaCount - %this.gemCount;
	      if (%remaining == 0) {
           messageClient(%this, 'MsgHaveAllGems', '\c0You have reached the gem quota, head for the finish!');
           %this.play2d(GotAllGemsSfx);
           //%this.gemCount = $Game::GemCount;
         } else if (%remaining < 0) {
            %this.onOutOfBounds();
         } else {
           if(%remaining == 1)
             %msg = '\c0You picked up a gem.  Only one gem to go!';
           else
             %msg = '\c0You picked up a gem.  %1 gems to go!';

           messageClient(%this, 'MsgItemPickup', %msg, %remaining);
           %this.play2d(GotGemSfx);
         }
	   } else {
	      %remaining = $Game::gemCount - %this.gemCount;
         if (%remaining <= 0) {
           messageClient(%this, 'MsgHaveAllGems', '\c0You have all the gems, head for the finish!');
           %this.play2d(GotAllGemsSfx);
           %this.gemCount = $Game::GemCount;
         }
         else
         {
           if(%remaining == 1)
             %msg = '\c0You picked up a gem.  Only one gem to go!';
           else
             %msg = '\c0You picked up a gem.  %1 gems to go!';

           messageClient(%this, 'MsgItemPickup', %msg, %remaining);
           %this.play2d(GotGemSfx);
         }
	   }
	   
	   //commandToAll('RemoveRadarObject', %gem.getId());
   } else {
       //%msg = '\c0You picked up a gem!';

	   //messageClient(%this, 'MsgItemPickup', %msg);
	   
	   //commandToAll('RemoveRadarObject', %gem.getId());
	   
      commandToClient(%this, 'ShowGemPickup', %amount, %amount < 0);
	   
	   //commandToClient(%this, 'UpdateScore', %this.getId(), %this.nameBase, true, %this.gemCount, false);
	   
	   //for (%i = 0; %i < ClientGroup.getCount(); %i++)
      //{
      //   %client = ClientGroup.getObject(%i);
      //   
      //   if (%client.getId() !$= %this.getId())
      //      commandToClient(%client, 'UpdateScore', %this.getId(), %this.nameBase, true, %this.gemCount, false);
      //}
	   %this.play2d(GotGemSfx);
	   
     for (%i = 0; %i < ClientGroup.getCount(); %i++)
     {
        %cl = ClientGroup.getObject(%i);
        if (%cl.getId() $= %this.getId())
           continue;
        %cl.play2d(OpponentGotGemSfx);
     }
      handleGems();
      if (isObject(%gem.beam) && %gem.beam.getClassName() $= "StaticShape")
         %gem.beam.delete();
      if (isObject(%gem.node) && %gem.node.getClassName() $= "ParticleEmitterNode")
         %gem.node.delete();
   }

   %this.setGemCount(%this.gemCount);
}


//-----------------------------------------------------------------------------

function GameConnection::spawnPlayer(%this)
{
   // Combination create player and drop him somewhere
	if (MissionInfo.gameMode $= "hunt")
	{
		%spawnPoint = %this.getMultiplayerSpawnPos();
	} else {
		%spawnPoint = %this.getCheckpointPos();
	}	
   %this.createPlayer(%spawnPoint);
   serverPlay2d(spawnSfx);
   
   //%this.clearCamera();
   
   if (MissionInfo.gameMode $= "hunt")
   {
      %averagePos = getAverageGemPosition();
      %this.cameraLookAtPoint(getWord(%averagePos, 0), getWord(%averagePos, 1));
   }
   commandToClient(%this, 'GetMarbleSkin');
}

function restartLevel()
{
   $resetLevel = true;
   for (%i = 0; %i < ClientGroup.getCount(); %i++)
   {
      %client = ClientGroup.getObject(%i);
      
      %client.respawnPlayer();
   }
   onGameStartup();
   
   if ($Client::ConnectedMultiplayer)
   {
      if (!$Game::Running) {
         error("endGame: No game running!");
         return;
      }
      $Game::GameLoops = 0;
      cancel($Multiplayer::UpdateSchedule);
      cancel($Multiplayer::DeltaUpdate);   
      cancel($Multiplayer::CollisionUpdate);
      cancel($Multiplayer::OOBUpdate);
      cancel($Multiplayer::SpeedUpdate);
      destroyGame();
      commandToAll('ResetGhostVars');
      for (%i = 0; %i < ClientGroup.getCount(); %i++)
      {
         %cl = ClientGroup.getObject(%i);
         %cl.player.delete();
         %cl.ShowPreMission();
         //%cl.resetTimer();
         %cl.setGameState("wait");
      }
   }
   //LocalClientConnection.respawnPlayer();
}

function GameConnection::respawnPlayer(%this)
{
   // Reset the player back to the last checkpoint
   cancel(%this.respawnSchedule);
   
   if (!$Client::ConnectedMultiplayer && (!isObject(%this.checkPoint) || !isObject(%this.checkPoint.pad)))
      %this.resetStats();
   
   if (!$Client::ConnectedMultiplayer && (isObject(%this.checkPoint.pad) && %this.checkPoint.pad.getName() $= "StartPoint"))
      $resetLevel = true;
      
   //if (!$resetLevel)
   //{
   //   if (isObject(ServerGroup))
   //   {
   //      ServerGroup.onMissionReset($Game::CurrentCheckPoint);
   //   }
   //}
   
   %this.player.unmountImage(0);
   %this.player.unmountImage(2);
   //if (isObject(%this.ghost))
   //{
   //   %this.ghost.unmountImage(0);
   //   %this.ghost.unmountImage(2);
   //}
   
   if ($resetLevel)
   {
      %this.setGravityDir("1 0 0 0 -1 0 0 0 -1",true);
      if ((isObject(%this.checkPoint.pad) && %this.checkPoint.pad.getDatablock().getName() !$= "StartPad"))
         %this.checkPoint.pad.getDatablock().setActiveCheckPoint(%this.checkPoint.pad, false);
   } else {
      
      if (%this.checkPoint.gravityDir !$= "")
         %this.setGravityDir(%this.checkPoint.gravityDir,true);
      else
         %this.setGravityDir("1 0 0 0 -1 0 0 0 -1",true);
   }
   endFireWorks();
      
   //%this.player.disablePowerUps();
   
   // Reset the players and inform them we're starting
   for( %clientIndex = 0; %clientIndex < ClientGroup.getCount(); %clientIndex++ ) {
      %cl = ClientGroup.getObject( %clientIndex );
      commandToClient(%cl, 'GameStart');
	  if (MissionInfo.gameMode !$= "hunt" || $resetLevel)
	  {
	     if ((isObject(%this.checkPoint.pad) && %this.checkPoint.pad.getName() $= "StartPoint")  || $resetLevel)
            %cl.resetStats();
	  }
   }

   // Start the game duration timer
   if ($Game::Duration)
      $Game::CycleSchedule = schedule($Game::Duration * 1000, 0, "onGameDurationEnd" );
   $Game::Running = true;

   if (MissionInfo.gameMode !$= "hunt" || $resetLevel)
   {
      if (!$Client::ConnectedMultiplayer && (isObject(%this.checkPoint.pad) && %this.checkPoint.pad.getName() $= "StartPoint") || $resetLevel)
      {
         ServerGroup.onMissionReset();
      } else if (%this.checkPoint.pad.getName() !$= "StartPoint")
      {
         ServerGroup.resetCheckPoint();
      }
   }

   // Set the initial state
   if (MissionInfo.gameMode $= "hunt" && !$resetLevel)
       %this.setGameState("play");
   else {
      if ((isObject(%this.checkPoint.pad) && %this.checkPoint.pad.getName() $= "StartPoint") || $resetLevel)
         %this.setGameState("Start");
      else {
         %this.setGameState("play");
      }
   }
   
   
   %this.player.isOOB = false;
   %this.player.setOOB(false);
   if (MissionInfo.gameMode $= "hunt")
	{
	   if ($resetLevel)
	   {
	      %this.player.setMode(Start);
	      
		   %spawnPoint = %this.getMultiplayerSpawnPos();
		 
		 
         %this.player.setPowerUp(%this.checkPoint.powerUp,true);
	   }
      else
      {
         %this.player.setMode("normal");
         %spawnPoint = %this.getMultiplayerSpawnPos(%this.player.getTransform());
         %this.player.setPowerUp(%this.player.lastPowerUp,true);
      }
	} else
	{
	   if (%this.checkPoint.pad.getName() $= "StartPoint" || $resetLevel)
         %this.player.setMode(Start);
      else
         %this.player.setMode("normal");
		%spawnPoint = %this.getCheckpointPos();
		%this.player.setPowerUp(%this.checkPoint.powerUp,true);
	}
	
   %pos = getWord(%spawnPoint, 0) + getWord(%this.spawnOffset, 0) SPC getWord(%spawnPoint, 1) + getWord(%this.spawnOffset, 1) SPC getWord(%spawnPoint, 2) + getWord(%this.spawnOffset, 2) SPC getWord(%spawnPoint, 3) SPC getWord(%spawnPoint, 4) SPC getWord(%spawnPoint, 5) SPC getWords(%spawnPoint, 6);
   %this.player.setPosition(%pos, 0.45);
   
   if ($resetLevel)
   {
      %this.penaltyTime = %this.checkPoint.penaltyTime;
      %this.bonusTime = %this.checkPoint.bonusTime;
   }
   
   if (!$resetLevel)
      commandToClient(%this, 'EndBonusTime');

   if (MissionInfo.gameMode !$= "hunt")
   {
      %this.gemCount = %this.checkPoint.gemCount;
      if ($resetLevel)
         %this.setTime(%this.checkPoint.time);
      %this.setGemCount(%this.gemCount);
   }
   %this.play2d(spawnSfx);
   
   %this.makeNoMega();   
   
   if ($resetLevel)
   {
      %this.player.setBlastEnergy(0);
   }
   
   $resetLevel = false;
   
   //%this.clearCamera();
   
   if (MissionInfo.gameMode $= "hunt")
   {
      %averagePos = getAverageGemPosition();
      %this.cameraLookAtPoint(getWord(%averagePos, 0), getWord(%averagePos, 1));
   }
   //%this.player.powerUpEnableSched = %this.player.schedule(500, enablePowerUps);
   
   //setupGameRadar();
}

function GameConnection::respawnPlayerHunt(%this)
{
   // Reset the player back to the last checkpoint
   cancel(%this.respawnSchedule);
   
   %this.player.unmountImage(0);
   %this.player.unmountImage(2);
   //%this.ghost.unmountImage(0);
   //%this.ghost.unmountImage(2);
   
   %this.setGravityDir("1 0 0 0 -1 0 0 0 -1",true);
   $Game::CurrentGravityDir = "1 0 0 0 -1 0 0 0 -1";
   endFireWorks();
   
   // Reset the players and inform them we're starting
   for( %clientIndex = 0; %clientIndex < ClientGroup.getCount(); %clientIndex++ ) {
      %cl = ClientGroup.getObject( %clientIndex );
      commandToClient(%cl, 'GameStart');
      %cl.resetStats();
   }

   // Start the game duration timer
   if ($Game::Duration)
      $Game::CycleSchedule = schedule($Game::Duration * 1000, 0, "onGameDurationEnd" );
   $Game::Running = true;

   ServerGroup.onMissionReset();

   // Set the initial state
   %this.setGameState("Start");
   
   
   %this.player.isOOB = false;
   %this.player.setOOB(false);
   %this.player.setMode(Start);
	if (MissionInfo.gameMode $= "hunt")
	{
		%spawnPoint = %this.getMultiplayerSpawnPos(%this.player.getTransform());
	} else {
		%spawnPoint = %this.getCheckpointPos();
	}
   %pos = getWord(%spawnPoint, 0) + getWord(%this.spawnOffset, 0) SPC getWord(%spawnPoint, 1) + getWord(%this.spawnOffset, 1) SPC getWord(%spawnPoint, 2) + getWord(%this.spawnOffset, 2) SPC getWord(%spawnPoint, 3) SPC getWord(%spawnPoint, 4) SPC getWord(%spawnPoint, 5) SPC getWords(%spawnPoint, 6);
   %this.player.setPosition(%pos, 0.45);
   %this.player.setPowerUp(%this.checkPoint.powerUp,true);
   
   %this.penaltyTime = %this.checkPoint.penaltyTime;
   %this.bonusTime = %this.checkPoint.bonusTime;
   %this.gemCount = 0;
   %this.setTime(MissionInfo.time);
   %this.setGemCount(%this.gemCount);
   %this.play2d(spawnSfx);
   
   //%this.clearCamera();
   
   if (MissionInfo.gameMode $= "hunt")
   {
      %averagePos = getAverageGemPosition();
      %this.cameraLookAtPoint(getWord(%averagePos, 0), getWord(%averagePos, 1));
   }
}

//-----------------------------------------------------------------------------

function GameConnection::createPlayer(%this, %spawnPoint)
{
   if (%this.player > 0)  {
      // The client should not have a player currently
      // assigned.  Assigning a new one could result in
      // a player ghost.
      error( "Attempting to create an angus ghost!" );
   }
   
   %scale = 1 - $Multiplayer::MarbleCount / 10000;
   //commandToClient(%this, 'SetGhostScale', %scale);
   $Multiplayer::MarbleCount++;
   
   if ($Server::ServerType $= "SinglePlayer")
   {
      %this.spawnOffset = 0 SPC 0 SPC 0;
   } else {
      %offset = $Multiplayer::MarbleCount * (getRandom() - 0.5);
      %this.spawnOffset = %offset SPC %offset SPC 0;
   }

   %player = new Marble() {
      dataBlock = DefaultMarble;
      client = %this;
      scale = %scale SPC %scale SPC %scale;
   };  
   
   if (isObject(MissionCleanup))
      MissionCleanup.add(%player);
   
   %pos = getWord(%spawnPoint, 0) + getWord(%this.spawnOffset, 0) SPC getWord(%spawnPoint, 1) + getWord(%this.spawnOffset, 1) SPC getWord(%spawnPoint, 2) + getWord(%this.spawnOffset, 2) SPC getWord(%spawnPoint, 3) SPC getWord(%spawnPoint, 4) SPC getWord(%spawnPoint, 5) SPC getWords(%spawnPoint, 6);

   // Player setup...
   %player.setPosition(%pos, 0.45);
   %player.setEnergyLevel(60);
   %player.setShapeName(%this.name);
   %player.client.status = 1;

   // Update the camera to start with the player
   %this.camera.setTransform(%player.getEyeTransform());

   // Give the client control of the player
   %this.player = %player;
   %this.setControlObject(%player);
   
   //%this.createGhost();
   
   %this.player.updateBlast();
}


//-----------------------------------------------------------------------------

function GameConnection::setCheckpoint(%this,%object)
{
   
   // Store the last checkpoint which will be used to restore
   // the player when he goes out of bounds.
   if (%object !$= %this.checkPoint.pad) {
      if (%object.num $= "" || %this.checkPoint.pad.num $= "" || %object.num > %this.checkPoint.pad.num)
      {
         if (%this.checkPoint.pad.getDatablock().getName() !$= "StartPad")
            %this.checkPoint.pad.getDatablock().setActiveCheckPoint(%this.checkPoint.pad, false);
         %this.checkPoint.delete();
         %this.checkPoint = new ScriptObject() {
            pad = %object;
            time = PlayGUI.elapsedTime;
            gemCount = %this.gemCount;
            penaltyTime = %this.penaltyTime;
            bonusTime = %this.bonusTime;
            powerUp = %this.player.getPowerUp();
            gravityDir = $Game::CurrentGravityDir;
         };
         %this.checkPoint.pad.getDatablock().setActiveCheckPoint(%this.checkPoint.pad, true);
         
         MissionCleanup.add(%this.checkPoint);

         messageClient(%this, 'MsgCheckPoint', "\c0Check Point!");
         %this.play2d(CheckPointSfx);
         $Game::CurrentCheckPoint++;
      }
   }
}

function GameConnection::getCheckpointPos(%this,%num)
{
   // Return the point a little above the object's center
   if (!isObject(%this.checkPoint.pad))
      return "0 0 300 1 0 0 0";
   return vectorAdd(%this.checkPoint.pad.getTransform(),"0 0 3") SPC
                    getWords(%this.checkPoint.pad.getTransform(), 3);
}

//function setupGameRadar()
//{
   //commandToAll('ClearRadar');
   //MissionGroup.setupRadar();
//}

//function SimGroup::setupRadar(%this)
//{
   //for (%i = 0; %i < %this.getCount(); %i++)
   //{
      //%obj = %this.getObject(%i);
      //
      //if (%obj.getClassName() $= "Item" && strstr(%obj.getDataBlock().getName(), "GemItem") > -1 && !%obj.isHidden())
      //{
         //%position = %obj.getPosition();   
         //%x = getWord(%position, 0);
         //%y = getWord(%position, 1);
         ////echo("Gem: " @ %obj.getId());
         ////clientCmdUpdateRadarObject(%obj.getId(), %obj.getSkinName(), %x, %y);
         //commandToAll('UpdateRadarObject', %obj.getId(), %obj.getSkinName(), %x, %y);
      //}
      //else if (%obj.getClassName() $= "StaticShape" && %obj.getDatablock().getName() $= "EndPad")
      //{
         //%position = %obj.getPosition();   
         //%x = getWord(%position, 0);
         //%y = getWord(%position, 1);
         ////echo("Pad: " @ %obj.getId());
         ////clientCmdUpdateRadarObject(%obj.getId(), "pad", %x, %y);
         //commandToAll('UpdateRadarObject', %obj.getId(), "pad", %x, %y);
      //}
      //else if (%obj.getClassName() $= "SimGroup")
      //{
         ////echo("Group: " @ %obj.getId());
         //%obj.setupRadar();
      //}// else {
      ////   if (%obj.getClassName() $= "StaticShape" || %obj.getClassName() $= "Item")
      ////      echo("Other: " @ %obj.getId() @ " " @ %obj.getClassName() @ " " @ %obj.getDatablock().getName());
      ////}
   //}
//}

//-----------------------------------------------------------------------------
// Support functions
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

function countGems(%group)
{
   // Count up all gems out there are in the world
   %gems = 0;
   for (%i = 0; %i < %group.getCount(); %i++)
   {
      %object = %group.getObject(%i);
      %type = %object.getClassName();
      if (%type $= "SimGroup")
         %gems += countGems(%object);
      else
         if (%type $= "Item" &&
               %object.getDatablock().classname $= "Gem")
            %gems++;
   }
   return %gems;
}
