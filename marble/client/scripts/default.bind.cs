//-----------------------------------------------------------------------------
// Torque Game Engine
// 
// Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

if ( isObject( moveMap ) )
   moveMap.delete();
new ActionMap(moveMap);

if ( isObject( demoMap) )
   demoMap.delete();
new ActionMap(demoMap);

if ( isObject( gamepadMap ) )
   gamepadMap.delete();

new ActionMap(gamepadMap);

demoMap.bindCmd(keyboard, "escape", "", "onDemoPlayDone(true);");

//------------------------------------------------------------------------------
// Non-remapable binds
//------------------------------------------------------------------------------

function escapeFromGame()
{
   if ( $Game::State $= "End")
      return;
   if ( $Server::ServerType $= "SinglePlayer" )  {
      // In single player, we'll pause the game while the dialog box is up.
      pauseGame();
      //ExitGameText.setText("<just:center><font:DomCasualD:32>Exit from this Level?");
      Canvas.pushDialog(ExitGameDlg);
   }
   else {
      //MessageBoxYesNo( "Disconnect", "Disconnect from the server?",
      //   "escapeToLobby();", "");
      MultiplayerExitGui.init();
      Canvas.pushDialog(MultiplayerExitGui);
   }
}

function escapeToLobby()
{
   $Game::GameLoops = 0;
   cancel($Multiplayer::UpdateSchedule);
   cancel($Multiplayer::DeltaUpdate);   
   cancel($Multiplayer::CollisionUpdate);
   cancel($Multiplayer::OOBUpdate);
   cancel($Multiplayer::SpeedUpdate);
   
   endMission();
   
   Canvas.setContent(LobbyGui);
}

//function hostEscapeToLobby()
//{
//   if($Multiplayer::isHosting)
//   {
//      for (%index = 0; %index < ClientGroup.getCount(); %index++)  {
//         %client = ClientGroup.getObject(%index);
//         commandToClient(%client, 'SetLobby');
//      }
//   } else {
//      escapeToLobby();
//   }
//}

moveMap.bindCmd(keyboard, "escape", "", "escapeFromGame();");


//------------------------------------------------------------------------------
// Movement Keys
//------------------------------------------------------------------------------

$movementSpeed = 1; // m/s

function setSpeed(%speed)
{
   if(%speed)
      $movementSpeed = %speed;
}

function moveleft(%val)
{
   $mvLeftAction = %val;
}

function moveright(%val)
{
   $mvRightAction = %val;
}

function moveforward(%val)
{
   if (MissionInfo.gameMode $= "Side" && LocalClientConnection.getControlObject() $= LocalClientConnection.player)
   {
      $mvForwardAction = 0;
      return;
   }
   $mvForwardAction = %val;
}

function movebackward(%val)
{
   if (MissionInfo.gameMode $= "Side" && LocalClientConnection.getControlObject() $= LocalClientConnection.player)
   {
      $mvBackwardAction = 0;
      return;
   }
   $mvBackwardAction = %val;
}

function moveXAxis(%val)
{
   if(mAbs(%val) < 0.1)
      %val = 0;
   if(%val < 0)
   {
      $mvLeftAction = -%val;
      $mvRightAction = 0;
   }
   else
   {
      $mvLeftAction = 0;
      $mvRightAction  = %val;
   }
}

function moveYAxis(%val)
{
   if(mAbs(%val) < 0.05)
      %val = 0;
   if(%val < 0)
   {
      $mvForwardAction = -%val;
      $mvBackwardAction = 0;
   }
   else
   {
      $mvForwardAction = 0;
      $mvBackwardAction  = %val;
   }
}

function moveYawAxis(%val)
{
   if (MissionInfo.gameMode $= "Side" && LocalClientConnection.getControlObject() $= LocalClientConnection.player)
      return;
   if(mAbs(%val) < 0.05)
      %val = 0;
   if(%val < 0)
   {
      $mvYawRightSpeed = -%val * $Pref::Input::KeyboardTurnSpeed;
      $mvYawLeftSpeed = 0;
   }
   else
   {
      $mvYawRightSpeed = 0;
      $mvYawLeftSpeed = %val * $Pref::Input::KeyboardTurnSpeed;
   }
}

function movePitchAxis(%val)
{
   if (MissionInfo.gameMode $= "Side" && LocalClientConnection.getControlObject() $= LocalClientConnection.player)
      return;
   //if(mAbs(%val) < 0.3)
   //{
   //   %val = 0;
      //$mvPitchUpSpeed = $mvPitchDownSpeed = 0;
      //return;
   //}
   %ival = %val;

   if(%val < 0)
   {
      //$mvPitchUpSpeed = -%val * $Pref::Input::KeyboardTurnSpeed;
      if(%val < -0.3)
      {
         %val = (%val + 0.3) * (1.0 / 0.7);
         //%val = %val 
         %destPitch = (-%val * 1.05) + 0.45;
      }
      else
         %destPitch = 0.45;
      //$mvPitchDownSpeed = 0;
   }
   else
   {
      if(%val > 0.3)
      {
         %val = (%val - 0.3) * (1.0 / 0.7);
         //$mvPitchUpSpeed = 0;
         //$mvPitchDownSpeed = %val * $Pref::Input::KeyboardTurnSpeed;
         %destPitch = (-1.3 * %val) + 0.45;
      }
      else
         %destPitch = 0.45;
   }
   $mvPitch = %destPitch - $marblePitch;
   //echo("IVAL= " @ %ival @ " MVMP = " @ $marblePitch @ " DestPitch = " @ %destPitch);
//   if(%destPitch > $marblePitch)
   //{
      //$mvPitchDownSpeed = 0;
   //}
   //else
   //{
      //$mvPitchDownSpeed = $marblePitch - %destPitch;
      //$mvPitchUpSpeed = 0;
   //   $mvPitch = 
   //}
}

gamepadMap.bind(joystick, xaxis, moveXAxis);
gamepadMap.bind(joystick, yaxis, moveYAxis);
gamepadMap.bind(joystick, rzaxis, moveYawAxis);
gamepadMap.bind(joystick, slider, movePitchAxis);
gamepadMap.bind(joystick, button6, jump);
gamepadMap.bind(joystick, button7, mouseFire);

gamepadMap.push();

function moveup(%val)
{
   $mvUpAction = %val;
}

function movedown(%val)
{
   $mvDownAction = %val;
}

function turnLeft( %val )
{
   if (MissionInfo.gameMode $= "Side" && LocalClientConnection.getControlObject() $= LocalClientConnection.player)
      return;
   $mvYawRightSpeed = %val ? $Pref::Input::KeyboardTurnSpeed : 0;
   
   //$Client::MyYaw -= mRadToDeg($mvYawRightSpeed);
   
   //if ($Client::MyYaw >= 360)
      //$Client::MyYaw -= 360;
   //if ($Client::MyYaw < 0)
      //$Client::MyYaw += 360;
}

function turnRight( %val )
{
   if (MissionInfo.gameMode $= "Side" && LocalClientConnection.getControlObject() $= LocalClientConnection.player)
      return;
   $mvYawLeftSpeed = %val ? $Pref::Input::KeyboardTurnSpeed : 0;
   
   //$Client::MyYaw += mRadToDeg($mvYawLeftSpeed);
   
   //if ($Client::MyYaw >= 360)
      //$Client::MyYaw -= 360;
   //if ($Client::MyYaw < 0)
      //$Client::MyYaw += 360;
}

function panUp( %val )
{
   if (MissionInfo.gameMode $= "Side" && LocalClientConnection.getControlObject() $= LocalClientConnection.player)
      return;
   $mvPitchDownSpeed = %val ? $Pref::Input::KeyboardTurnSpeed : 0;
   
   //$Client::MyPitch += mRadToDeg($mvPitchDownSpeed);
   //if ($Client::MyPitch >= 360)
      //$Client::MyPitch -= 360;
   //if ($Client::MyPitch < 0)
      //$Client::MyPitch += 360;
}

function panDown( %val )
{
   if (MissionInfo.gameMode $= "Side" && LocalClientConnection.getControlObject() $= LocalClientConnection.player)
      return;
   $mvPitchUpSpeed = %val ? $Pref::Input::KeyboardTurnSpeed : 0;
   
   //$Client::MyPitch -= mRadToDeg($mvPitchUpSpeed);
   //if ($Client::MyPitch >= 360)
      //$Client::MyPitch -= 360;
   //if ($Client::MyPitch < 0)
      //$Client::MyPitch += 360;
}

function getKeyboardAdjustAmount(%val)
{
   // based on a default camera fov of 90'
   return($pref::Input::KeyboardTurnSpeed * %val * ($cameraFov / 90) * 0.01);
}

function getMouseAdjustAmount(%val)
{
   // based on a default camera fov of 90'
   return($pref::Input::MouseSensitivity * %val * ($cameraFov / 90) * 0.01);
}

function yaw(%val)
{
   if (MissionInfo.gameMode $= "Side" && LocalClientConnection.getControlObject() $= LocalClientConnection.player)
      return;
   $mvYaw += getMouseAdjustAmount(%val);
   if($pref::input::InvertXAxis)
      $mvYaw -= getMouseAdjustAmount(%val);
   else
      $mvYaw += getMouseAdjustAmount(%val);
   
   //$Client::MyYaw += mRadToDeg($mvYaw);
   //
   //if ($Client::MyYaw >= 360)
      //$Client::MyYaw -= 360;
   //if ($Client::MyYaw < 0)
      //$Client::MyYaw += 360;
}

function pitch(%val)
{
   if (MissionInfo.gameMode $= "Side" && LocalClientConnection.getControlObject() $= LocalClientConnection.player)
      return;
   if($freelooking || $pref::Input::AlwaysFreeLook)
   {
      if($pref::input::InvertYAxis)
         $mvPitch -= getMouseAdjustAmount(%val);
      else
         $mvPitch += getMouseAdjustAmount(%val);
   }
   //$Client::MyPitch += mRadToDeg($mvPitch);
   //if ($Client::MyPitch >= 360)
      //$Client::MyPitch -= 360;
   //if ($Client::MyPitch < 0)
      //$Client::MyPitch += 360;
}

//function getCameraRotation()
//{
   //return $marblePitch SPC $Client::MyYaw SPC 0; //$Client::MyRoll;
//}

function jump(%val)
{
   if (%val)
   {
      $spaceDown = true;
   } else {
      $spaceDown = false;
   }
   $mvTriggerCount2++;
}

function freelook(%val)
{
   $freeLooking = %val;
}

moveMap.bind( keyboard, a, moveleft );
moveMap.bind( keyboard, d, moveright );
moveMap.bind( keyboard, w, moveforward );
moveMap.bind( keyboard, s, movebackward );
moveMap.bind( keyboard, space, jump );
moveMap.bind( mouse, xaxis, yaw );
moveMap.bind( mouse, yaxis, pitch );
moveMap.bind(keyboard, up, panUp);
moveMap.bind(keyboard, down, panDown);
moveMap.bind(keyboard, left, turnLeft);
moveMap.bind(keyboard, right, turnRight);


//------------------------------------------------------------------------------
// Mouse Trigger
//------------------------------------------------------------------------------

function mouseFire(%val)
{
   if (%val)
   {
      $leftMouseDown = true;
      commandToServer('UseCurrentPowerUp');
   } else {
      $leftMouseDown = false;
   }
   
   $mvTriggerCount0++;
}

function altTrigger(%val)
{
   //$mvTriggerCount1++;
   //if (%val && $Client::BlastEnergy > 1000)
      //$mvTriggerCount1 = %val;
   if (%val && $Client::BlastEnergy > 1000)
   {
      commandToServer('UseBlast');
      if ($isDemoRecording)
      {
         $BlastCount++;
         $BlastTime[$BlastCount - 1] = PlayGui.elapsedTime;
      }
   }
}

moveMap.bind( mouse, button0, mouseFire );
//if($platform $= "macos")
   //moveMap.bind( keyboard, e, altTrigger );
//else
   moveMap.bind( mouse, button1, altTrigger );
   
moveMap.bind( keyboard, f, freelook );
   
function openChat(%val)
{
   if (%val)
   {
      Canvas.pushDialog(ChatDlg);
   }
}
   
moveMap.bind(keyboard, "enter", openChat);


//------------------------------------------------------------------------------
// Camera & View functions
//------------------------------------------------------------------------------

function toggleCamera(%val)
{
   if (%val && $testCheats)
      commandToServer('ToggleCamera');
}

moveMap.bind(keyboard, "alt c", toggleCamera);

//------------------------------------------------------------------------------
// Helper Functions
//------------------------------------------------------------------------------

function dropCameraAtPlayer(%val)
{
   if (%val && $testCheats)
      commandToServer('dropCameraAtPlayer');
}

function dropPlayerAtCamera(%val)
{
   if (%val && $testCheats)
      commandToServer('DropPlayerAtCamera');
}

moveMap.bind(keyboard, "F8", dropCameraAtPlayer);
moveMap.bind(keyboard, "F7", dropPlayerAtCamera);

function toggleHud(%val)
{
   if (%val)
   {
      if ($Client::HudHidden)
      {
         %visible = true;
         $Client::HudHidden = false;
      } else {
         %visible = false;
         $Client::HudHidden = true;
      }
      PG_GemBox.visible = %visible;
      CompassDlg.visible = %visible;
      PG_NumBG.visible = %visible;
      //PG_NegSign.visible = %visible;
      PG_Rear.visible = %visible;
      PG_RearView.visible = %visible;
      //CenterMessageDlg.visible = %visible;
      //CenterPrintDlg.visible = %visible;
      //BottomPrintDlg.visible = %visible;
      LagIcon.visible = %visible;
      HUD_ShowGem.visible = %visible;
      GemsFoundHundred.visible = %visible;
      GemsFoundTen.visible = %visible;
      GemsFoundOne.visible = %visible;
      GemsSlash.visible = %visible;
      GemsTotalHundred.visible = %visible;
      GemsTotalTen.visible = %visible;
      GemsTotalOne.visible = %visible;
      PG_Timer.visible = %visible;
      //PG_HelpText.visible = %visible;
      //PG_ChatText.visible = %visible;
      HUD_ShowPowerUp.visible = %visible;
      PG_PowerUp.visible = %visible;
      PG_BlastOverlay.visible = %visible;
      PG_BlastBar.visible = %visible;
      RadarContainer.visible = %visible;
   }
}

moveMap.bind(keyboard, "ctrl h", toggleHud);


//------------------------------------------------------------------------------
// Dubuging Functions
//------------------------------------------------------------------------------

$MFDebugRenderMode = 0;
function cycleDebugRenderMode(%val)
{
   if (!%val)
      return;

   if (getBuildString() $= "Debug")
   {
      if($MFDebugRenderMode == 0)
      {
         // Outline mode, including fonts so no stats
         $MFDebugRenderMode = 1;
         GLEnableOutline(true);
      }
      else if ($MFDebugRenderMode == 1)
      {
         // Interior debug mode
         $MFDebugRenderMode = 2;
         GLEnableOutline(false);
         setInteriorRenderMode(7);
         showInterior();
      }
      else if ($MFDebugRenderMode == 2)
      {
         // Back to normal
         $MFDebugRenderMode = 0;
         setInteriorRenderMode(0);
         GLEnableOutline(false);
         show();
      }
   }
   else
   {
      echo("Debug render modes only available when running a Debug build.");
   }
}

GlobalActionMap.bind(keyboard, "F9", cycleDebugRenderMode);


//------------------------------------------------------------------------------
// Misc.
//------------------------------------------------------------------------------

GlobalActionMap.bind(keyboard, "tilde", toggleConsole);
GlobalActionMap.bindCmd(keyboard, "alt enter", "", "pauseMusic();toggleFullScreen();resumeMusic();");
