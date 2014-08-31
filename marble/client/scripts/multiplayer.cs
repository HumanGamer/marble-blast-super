//---------------------------------------------------------------
// MarbleBlast Multiplayer Mod
// marble/client/scripts/multiplayer.cs
// (C) 2013 Matthieu Parizeau
//---------------------------------------------------------------

$Multiplayer::GameName = "MBSuperMultiplayer";
$Server::GameType = $Multiplayer::GameName;
$Client::GameTypeQuery = $Multiplayer::GameName;
$Client::MissionTypeQuery = "Any";
$Multiplayer::Version = 2.0;

//---------------------------------------------------------------
//Get Client References
//---------------------------------------------------------------

function getMyMarble()
{
   if (!isObject(ServerConnection))
      return;
      
   if ($Multiplayer::MyMarble !$= "")
      return $Multiplayer::MyMarble;
      
   for (%i = 0; %i < ServerConnection.getCount(); %i++)
   {
      %obj = ServerConnection.getObject(%i);
      if (%obj.getClassName() $= "Marble")
      {
         $Multiplayer::MyMarble = %obj;
         return %obj;
      }
   }
}

function getMyGhost()
{
   if (!isObject(ServerConnection))
      return;
      
   if ($Multiplayer::MyGhost !$= "")
      return $Multiplayer::MyGhost;
      
   for (%i = 0; %i < ServerConnection.getCount(); %i++)
   {
      %obj = ServerConnection.getObject(%i);
      if (%obj.getClassName() $= "StaticShape" && strStr(%obj.getDatablock().shapeFile, "/balls/") != -1 && getWord(%obj.getScale(), 0) $= $Multiplayer::MyScale)
      {
         $Multiplayer::MyGhost = %obj;
         return %obj;
      }
   }
}

//---------------------------------------------------------------
//Hide Unnessary Data
//---------------------------------------------------------------

function hideMarbles()
{
   if (!isObject(ServerConnection))
      return;
      
   if ($Multiplayer::MyMarble $= "")
   {
      getMyMarble();
      return;
   }
      
   for (%i = 0; %i < ServerConnection.getCount(); %i++)
   {
      %obj = ServerConnection.getObject(%i);
      if (%obj.getClassName() $= "Marble" && %obj.getId() != $Multiplayer::MyMarble.getId())
      {
         %obj.setScale(0);
      }
   }
}

function hideMyGhost()
{
   if (!isObject(ServerConnection))
      return;
      
   if ($Multiplayer::MyGhost $= "")
   {
      getMyGhost();
      return;
   }
      
   $Multiplayer::MyGhost.hide(1);
}

function resetGhostVars()
{
   $Multiplayer::MyGhost = "";
   $Multiplayer::MyMarble = "";
   $Multiplayer::MyScale = "";
   $Multiplayer::isHosting = false;
   $Multiplayer::GameMode = "";
}

//---------------------------------------------------------------
//Client Commands
//---------------------------------------------------------------

function clientCmdResetGhostVars()
{
   resetGhostVars();
}

function clientCmdSetGhostScale(%scale)
{
   $Multiplayer::MyScale = %scale;
}

function clientCmdUpdateTransform()
{
   if ($Multiplayer::MyMarble $= "" || $Multiplayer::MyGhost $= "")
   {
      getMyMarble();
      getMyGhost();
      hideMyGhost();
      return;
   }
   hideMarbles();
   %trans = $Multiplayer::MyMarble.getTransform();
   commandToServer('UpdateTransform', %trans);
}

function clientCmdIncPenaltyTime(%dt)
{
   PlayGui.adjustTimer(%dt);
}

function clientCmdIncBonusTime(%dt)
{
   PlayGui.addBonusTime(%dt);
}

function clientCmdResetTimer()
{
   PlayGui.resetTimer();
}

function clientCmdSetMessage(%msg, %timer)
{
   PlayGui.setMessage(%msg, %timer);
}

function clientCmdSetGemCount(%count)
{
   PlayGui.setGemCount(%count);
}

function clientCmdSetMaxGems(%count)
{
   PlayGui.setMaxGems(%count);
}

function clientCmdAddHelpLine(%msg, %bool)
{
   addHelpLine(%msg, %bool);
}

function clientCmdStartTimer()
{
   PlayGui.startTimer();
}

function clientCmdStopTimer()
{
   PlayGui.stopTimer();
}

function clientCmdSetGravityDir(%dir, %bool)
{
   setGravityDir(%dir, %bool);
}

function clientCmdSetPowerUp(%shapeFile)
{
   PlayGui.setPowerUp(%shapeFile);
}

function clientCmdSetTime(%time)
{
   PlayGui.setTime(%time);
}

function clientCmdShowMsgBox(%title, %msg)
{
   MessageBoxOK(%title, %msg, "");
}

function clientCmdKick(%msg)
{
   disconnect();
   if (%msg $= "")
      %msg = "Unknown Reason";
   MessageBoxOK("Kicked", %msg, "");
}

function clientCmdDisconnect(%msg)
{
   disconnect();
   if (%msg !$= "")
      MessageBoxOK("Disconnected", %msg, "");
}

function clientCmdCheckVersion(%version)
{
   if (%version > $Multiplayer::Version)
   {
      disconnect();
      MessageBoxOK("Could not connect", "Your Game is out of date.\nMake sure to update.", "");
   } else if (%version < $Multiplayer::Version)
   {
      disconnect();
      MessageBoxOK("Could not connect", "The Server is out of date.\nMake sure to let the host know.", "");
   } else {
      commandToServer('CheckVersion', $Multiplayer::Version);
   }
}

function clientCmdOOBUpdate()
{
   //$leftMouseDown
   // Matt: Now uses space bar to avoid using powerups on spawn
   if (($spaceDown) && !$Multiplayer::OOBDone)
   {
      $Multiplayer::OOBDone = true;
      commandToServer('OOBClick');
   }
}

function clientCmdResetOOB()
{
   $Multiplayer::OOBDone = false;
}

function clientCmdSetMode(%mode)
{
   $Multiplayer::GameMode = %mode;
}

function clientCmdGetMarbleSkin()
{
   commandToServer('SetMarbleSkin', MS_skinGroup.getObject($pref::MarbleIndex).skin);
}

function clientCmdAddPlayer(%clientId, %name, %isMe, %score)
{
   PlayerListGui.addPlayer(%clientId, %name, %isMe, %score);
}

function clientCmdUpdateScore(%clientId, %name, %isMe, %score)
{
   PlayerListGui.update(%clientId, %name, %isMe, %score);
}

function clientCmdRemovePlayer(%clientId)
{
   PlayerListGui.removePlayer(%clientId);
}

function clientCmdClearPlayerList()
{
   PlayerListGui.clear();
}

function clientCmdShowGemPickup(%points, %lost)
{
   GemPopUpGui.showPopup(%points, %lost);
}
