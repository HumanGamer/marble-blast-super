function MultiplayerEndGui::onWake(%this)
{
   MultiplayerEndTitle.setText("<color:FFFFFF>Level Complete!");
   
   if ($Multiplayer::isHosting)
   {
      ME_Lobby.visible = true;
      ME_Replay.visible = true;
   } else {
      ME_Lobby.visible = false;
      ME_Replay.visible = false;
   }
}
