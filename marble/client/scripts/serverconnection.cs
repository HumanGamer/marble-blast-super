//-----------------------------------------------------------------------------
// Torque Game Engine
// 
// Copyright (c) 2001 GarageGames.Com
// Portions Copyright (c) 2001 by Sierra Online, Inc.
//-----------------------------------------------------------------------------

// Functions dealing with connecting to a server


//-----------------------------------------------------------------------------
// Server connection error
//-----------------------------------------------------------------------------

addMessageCallback( 'MsgConnectionError', handleConnectionErrorMessage );

function handleConnectionErrorMessage(%msgType, %msgString, %msgError)
{
   // On connect the server transmits a message to display if there
   // are any problems with the connection.  Most connection errors
   // are game version differences, so hopefully the server message
   // will tell us where to get the latest version of the game.
   $ServerConnectionErrorMessage = %msgError;
}


//----------------------------------------------------------------------------
// GameConnection client callbacks
//----------------------------------------------------------------------------

function GameConnection::initialControlSet(%this)
{
   echo ("*** Initial Control Object");

   // The first control object has been set by the server
   // and we are now ready to go.
   
   // first check if the editor is active
   if (!Editor::checkActiveLoadDone())
   {
      if (Canvas.getContent() != PlayGui.getId() && !$Client::NoGuiChange)
      {
         Canvas.setContent(PlayGui);
      }
   }
}

function GameConnection::setLagIcon(%this, %state)
{
   if (%this.getAddress() $= "local")
      return;
   LagIcon.setVisible(%state $= "true");
}

function GameConnection::onConnectionAccepted(%this)
{
   // Called on the new connection object after connect() succeeds.
   LagIcon.setVisible(false);
}

function GameConnection::onConnectionTimedOut(%this)
{
   // Called when an established connection times out
   disconnectedCleanup();
   MessageBoxOK( "TIMED OUT", "The server connection has timed out.");
}

function GameConnection::onConnectionDropped(%this, %msg)
{
   // Established connection was dropped by the server
   disconnectedCleanup();
   MessageBoxOK( "DISCONNECT", "The server has dropped the connection: " @ %msg);
}

function GameConnection::onConnectionError(%this, %msg)
{
   // General connection error, usually raised by ghosted objects
   // initialization problems, such as missing files.  We'll display
   // the server's connection error message.
   disconnectedCleanup();
   MessageBoxOK( "DISCONNECT", $ServerConnectionErrorMessage @ " (" @ %msg @ ")" );
}


//----------------------------------------------------------------------------
// Connection Failed Events
// These events aren't attached to a GameConnection object because they
// occur before one exists.
//----------------------------------------------------------------------------

function GameConnection::onConnectRequestRejected( %this, %msg )
{
   switch$(%msg)
   {
      case "CR_INVALID_PROTOCOL_VERSION":
         %error = "Incompatible protocol version: Your game version is not compatible with this server.";
      case "CR_INVALID_CONNECT_PACKET":
         %error = "Internal Error: badly formed network packet";
      case "CR_YOUAREBANNED":
         %error = "You are not allowed to play on this server.";
      case "CR_SERVERFULL":
         %error = "This server is full.";
      case "CHR_PASSWORD":
         // XXX Should put up a password-entry dialog.
         if ($Client::Password $= "")
            MessageBoxOK( "REJECTED", "That server requires a password.");
         else {
            $Client::Password = "";
            MessageBoxOK( "REJECTED", "That password is incorrect.");
         }
         return;
      case "CHR_PROTOCOL":
         %error = "Incompatible protocol version: Your game version is not compatible with this server.";
      case "CHR_CLASSCRC":
         %error = "Incompatible game classes: Your game version is not compatible with this server.";
      case "CHR_INVALID_CHALLENGE_PACKET":
         %error = "Internal Error: Invalid server response packet";
      default:
         %error = "Connection error.  Please try another server.  Error code: (" @ %msg @ ")";
   }
   disconnectedCleanup();
   MessageBoxOK( "REJECTED", %error);
}

function GameConnection::onConnectRequestTimedOut(%this)
{
   disconnectedCleanup();
   MessageBoxOK( "TIMED OUT", "Your connection to the server timed out." );
}

//-----------------------------------------------------------------------------
// Host
//-----------------------------------------------------------------------------

function enterMPName()
{
   EnterMultiplayerNameDlg.show("$pref::Multiplayer::Name", "checkMPName();", "What is your name?");
}

function checkMPName()
{
   if ($pref::Multiplayer::Name $= "")
   {
      disconnect();
   } else {
      Canvas.popDialog(EnterMultiplayerNameDlg);
   }
}

function startServer(%serverType, %mission)
{
   //if (%serverType $= "Multiplayer")
   //   EnterMultiplayerNameDlg.show("$pref::Multiplayer::Name", "continueStartServer(" @ %serverType @ "," @ %mission @ ");", "What is your name?");
   //else 
      continueStartServer(%serverType, %mission);
}

function continueStartServer(%serverType, %mission)
{
   createServer(%serverType, %mission.file);
   %conn = new GameConnection(ServerConnection);
   RootGroup.add(ServerConnection);
   %conn.setConnectArgs($pref::Multiplayer::Name, $Multiplayer::Version, $Multiplayer::GameName);
   %conn.setJoinPassword($Client::Password);
   %conn.connectLocal();
}

//-----------------------------------------------------------------------------
// Connect
//-----------------------------------------------------------------------------

function connectTo()
{
   EnterMultiplayerNameDlg.show("$pref::Multiplayer::IP", "connect($pref::Multiplayer::IP);", "Enter the IP of the server");
}

function connect(%ip)
{
   if (isObject(ServerConnection))
   {
      warn("Already connected to a server!");
      return;
   }
   //EnterMultiplayerNameDlg.show("$pref::Multiplayer::Name", "continueConnect(\""@%ip@"\");", "What is your name?");
   continueConnect(%ip);
}

function continueConnect(%ip)
{
   if (%ip !$= "")
   {
      $Client::ConnectedMultiplayer = true;
      echo("IP: " @ %ip);
   } else {
      echo("IP: 127.0.0.1");
   }
   //%ip = %ip @ ":28000";
   if (!$Client::NoGuiChange)
      Canvas.setContent(ConnectGui);
   %conn = new GameConnection(ServerConnection);
   RootGroup.add(%conn);
   %conn.setConnectArgs($pref::Multiplayer::Name, $Multiplayer::Version, $Multiplayer::GameName);
   %conn.setJoinPassword($Client::Password);
   if (%ip $= "")
      %conn.connectLocal();
   else
      %conn.connect(%ip);
}

function stopRandomConnect()
{
   //if (isEventPending($connectRandSchedule))
   //   cancel($connectRandSchedule);
   cancel($connectDelay);
   cancelServerQuery();
   //Canvas.setContent(MainMenuGui);
}

function connectRandom()
{
   stopRandomConnect();
   Canvas.setContent(ConnectGui);
   queryMasterServer(28000, 0, $Client::GameTypeQuery, $Client::MissionTypeQuery, 0, 100, 0, 2, 500, 0, 0);
   //$connectRandSchedule = schedule(2500, 0, continueConnectRandom);
}

function onServerQueryStatus(%status, %msg, %value)
{
	if (%status !$= "done")
		return;
   if (getServerCount() > 0)
   {
      %rand = getRandom(0, getServerCount());
      %flag = setServerInfo(%rand);
      if (%flag)
      {
         cancel($connectDelay);
         $connectDelay = schedule(2500, 0, connect, $ServerInfo::Address);
      }
   } else {
      Canvas.setContent(MultiplayerGui);
      MessageBoxOK("Information", "No Games Avaliable", "");
   }
}

//-----------------------------------------------------------------------------
// Disconnect
//-----------------------------------------------------------------------------

function disconnect()
{
   // Delete the connection if it's still there.
   if (isObject(ServerConnection))
      ServerConnection.delete();
   disconnectedCleanup();
   //resetGhostVars();

   // Call destroyServer in case we're hosting
   destroyServer();
}

function disconnectedCleanup()
{
   // Clear misc script stuff
   HudMessageVector.clear();

   if (isObject(MusicPlayer))
      MusicPlayer.stop();
   //
   //LagIcon.setVisible(false);
   //PlayerListGui.clear();
   
   // Clear all print messages
   clientCmdclearBottomPrint();
   clientCmdClearCenterPrint();

   // Back to the launch screen
   Canvas.setContent(MainMenuGui);

   // Dump anything we're not using
   clearTextureHolds();
   purgeResources();
   stopDemo();
   
   $Client::ConnectedMultiplayer = false;
   resetGhostVars();
   PlayerListGui.clear();
}

