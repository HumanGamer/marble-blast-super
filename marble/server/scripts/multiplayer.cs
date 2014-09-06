//---------------------------------------------------------------
// MarbleBlast Multiplayer Mod
// marble/server/scripts/multiplayer.cs
// (C) 2013 Matthieu Parizeau
//---------------------------------------------------------------

$Multiplayer::GameName = "MBSuperMultiplayer";
$Server::GameType = $Multiplayer::GameName;
$Client::GameTypeQuery = $Multiplayer::GameName;
$Client::MissionTypeQuery = "Any";
$Multiplayer::Version = 2.0;

$Multiplayer::UpdateInterval = 10;

function commandToAll(%func, %args, %arg1, %arg2, %arg3)
{
   for (%i = 0; %i < ClientGroup.getCount(); %i++)
   {
      %obj = ClientGroup.getObject(%i);
      commandToClient(%obj, %func, %args, %arg1, %arg2, %arg3);
   }
}

function onGameStartup()
{
   updateGame();
}

function updateGame()
{
   cancel($Multiplayer::UpdateSchedule);
   
   commandToAll('UpdateTransform');
   for (%i = 0; %i < ClientGroup.getCount(); %i++)
   {
      %obj = ClientGroup.getObject(%i);
      if (%obj.player $= "")
         continue;
      if (%obj.player.getIsOOB() && %obj.GameState $= "Play")
      {
         commandToClient(%obj, 'OOBUpdate');
      }
   }
   
   $Multiplayer::UpdateSchedule = schedule($Multiplayer::UpdateInterval, 0, updateGame);
}

function serverCmdUpdateTransform(%client, %trans)
{
   if (isObject(%client.ghost))
      %client.ghost.setTransform(%trans);
}

function setGameStateAll()
{
   if (ClientGroup.getCount() == 0)
   {
      schedule(250, 0, setGameStateAll);
      return;
   }
   for (%i = 0; %i < ClientGroup.getCount(); %i++)
   {
      ClientGroup.getObject(%i).setGameState("Start");
   }
}

function GameConnection::resetTimer(%this)
{
   commandToClient(%this, 'ResetTimer');
}

function GameConnection::setMessage(%this, %msg, %timer)
{
   commandToClient(%this, 'SetMessage', %msg, %timer);
}

function GameConnection::setGemCount(%this, %count)
{
   commandToClient(%this, 'SetGemCount', %count);
}

function GameConnection::setMaxGems(%this, %max)
{
   commandToClient(%this, 'SetMaxGems', %max);
}

function GameConnection::addHelpLine(%this, %msg, %bool)
{
   commandToClient(%this, 'AddHelpLine', %msg, %bool);
}

function GameConnection::startTimer(%this)
{
   commandToClient(%this, 'StartTimer');
}

function GameConnection::stopTimer(%this)
{
   commandToClient(%this, 'StopTimer');
}

function GameConnection::setGravityDir(%this, %dir, %bool)
{
   commandToClient(%this, 'SetGravityDir', %dir, %bool);
}

function GameConnection::mountImage(%this, %image, %slot, %time)
{
   if (%image $= "")
      return;
   %this.player.mountImage(%image, %slot);
   %this.player.schedule(%time, unmountImage, %slot);
   %this.ghost.mountImage(%image, %slot);
   %this.ghost.schedule(%time, unmountImage, %slot);
}

function GameConnection::setPowerUp(%this, %shapeFile)
{
   commandToClient(%this, 'SetPowerUp', %shapeFile);
}

function GameConnection::setTime(%this, %time)
{
   commandToClient(%this, 'SetTime', %time);
}

function GameConnection::isHost(%this)
{
   if (ClientGroup.getCount() == 1 || %this.getName() $= "LocalClientConnection" || %this.getAddress() $= "local")
   {
      $Multiplayer::isHosting = true;
      return true;
   }
   return false;
}

function GameConnection::ShowMsgBox(%this, %title, %msg)
{
   commandToClient(%this, 'ShowMsgBox', %title, %msg);
}

function GameConnection::checkVersion(%this)
{
   commandToClient(%this, 'CheckVersion', $Multiplayer::Version);
   %this.versionKick = %this.schedule(5000, versionKick);
}

function GameConnection::versionKick(%this)
{
   cancel(%this.versionKick);
   %this.delete();
}

function GameConnection::kick(%this, %msg)
{
   commandToClient(%this, 'kick', %msg);
}

function GameConnection::disconnect(%this, %msg)
{
   commandToClient(%this, 'disconnect', %msg);
}

function GameConnection::getSkin(%this)
{
   return %this.skin;
}

function GameConnection::getMultiplayerSpawnPos(%this, %transform)
{
	%group = nameToID("MissionGroup/SpawnPoints");
   if (!isObject(%group))
      return;
	
	if (%transform $= "")
	{
	
		%num = getRandom(%group.getCount() - 1);

		%spawn = %group.getObject(%num);
		
		return vectorAdd(%spawn.getTransform(),"0 0 3") SPC
							  getWords(%spawn.getTransform(), 3);
						  
	} else {
		for (%i = 0; %i < %group.getCount(); %i++)
		{
			%obj = %group.getObject(%i);
			
			%trans = %obj.getTransform();
			
			%distance = vectorDist(%trans, %transform);
			//echo("Spawn Distance: " @ %distance);
			
			if (%distance < %closestDist || %closestDist == 0)
			{
				%closestDist = %distance;
				%closestObj = %obj;
			}
		}
		
		return vectorAdd(%closestObj.getTransform(),"0 0 3") SPC
							  getWords(%closestObj.getTransform(), 3);
	}
}

function GameConnection::applyImpulse(%this, %impulseVec, %impulse)
{
   commandToClient(%this, 'ApplyImpulse', %impulseVec, %impulse);
}

function serverCmdCheckVersion(%client, %version)
{
   cancel(%client.versionKick);
   if (%version == $Multiplayer::Version)
   {
      sendLoadInfoToClient( %client );
      if ($missionRunning)
         %client.loadMission();
      if ($Server::ServerType $= "Multiplayer")
         messageAll('MsgClientJoin', '\c1%1 has joined the game.', %client.name, %client);   
   }
   else if (%version < $Multiplayer::Version)
      %client.disconnect("Your game is out of date.");
   else 
      %client.disconnect("This server is out of date.");
}

function serverCmdOOBClick(%client)
{
   %client.respawnPlayer();
   commandToClient(%client, 'ResetOOB');
}

function serverCmdGameFinished(%client)
{
   if (%client.isHost())
   {
      for (%i = 0; %i < ClientGroup.getCount(); %i++)
      {
          %obj = ClientGroup.getObject(%i);
         %obj.player.setMode(Victory);
          messageClient(%obj, 'MsgRaceOver', '\c0Congratulations! You\'ve finished!');
         %obj.setGameState("end");
      }
   }
}

function serverCmdSetMarbleSkin(%client, %skin)
{
   %client.skin = %skin;
   %client.player.setSkinName(%client.getSkin());
   %client.ghost.setSkinName(%client.getSkin());
}

function onMarbleCollision(%marble, %otherGhost)
{  
   %otherMarble = %otherGhost.client.player;
   //%dist = VectorDist(%marble.getPosition(), %other.getPosition());
   //%dist -= %marble.getDatablock().radius;
   //%dist -= %other.getDatablock().radius;
   
   %reduction = %otherMarble.getDatablock().reduction;
   %power = %marble.getDatablock().power;
   
   //if (%dist < 0)
   //{
      %src1 = VectorSub(%otherMarble.getPosition(), %marble.getPosition());
      %src2 = VectorSub(%marble.getPosition(), %otherMarble.getPosition());
      
      %impulse1 = VectorScale(%src1, %power);
      %impulse2 = VectorScale(%src2, %reduction);
      
      %otherMarble.client.applyImpulse(%src1, %impulse1);
      %marble.client.applyImpulse(%src2, %impulse2);
   //}
   
   
   //echo("Megas: " @ %megaMe @ " | " @ %megaGhost @ ", Collision: " @ %dist);
}

function VectorMult(%vector, %mult)
{
   if (getWordCount(%mult) > 1)
   {
      return getWord(%vector, 0) * getWord(%mult, 0) SPC getWord(%vector, 1) * getWord(%mult, 1) SPC getWord(%vector, 2) * getWord(%mult, 2);
   } else {
      return getWord(%vector, 0) * %mult SPC getWord(%vector, 1) * %mult SPC getWord(%vector, 2) * %mult;
   }
}