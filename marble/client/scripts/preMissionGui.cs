function PreMissionGui::onWake(%this)
{
   Pre_ReadyLabel.setText("Ready:");
   Pre_Play.setActive(false);
   $Pre::Ready = false;
}

function Pre_OnReadyChange()
{
   commandToServer('SetReady', $Pre::Ready);
}

function Pre_Play()
{
   if (!ServerConnection.isHost())
      return;
      
   commandToServer('StartGameNow');
}

function Pre_Leave()
{
   if (ServerConnection.isHost())
      hostEscapeToLobby();
   else
      disconnect();
}

function clientCmdShowPreMission()
{
   $Pre::Ready = false;
   Canvas.pushDialog(PreMissionGui);
}

function clientCmdHidePreMission()
{
   Canvas.popDialog(PreMissionGui);
}

function clientCmdAllClientsReady(%flag)
{
   if (!ServerConnection.isHost())
   {
      Pre_Play.setActive(false);
      return;
   }
   
   if (%flag)
      Pre_Play.setActive(true);
   else
      Pre_Play.setActive(false);
}