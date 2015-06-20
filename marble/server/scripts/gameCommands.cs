function serverCmdOOBClick(%client)
{
   %client.respawnPlayer();
   commandToClient(%client, 'ResetOOB');
}

function serverCmdSetMarbleSkin(%client, %skin)
{
   %client.skin = %skin;
   if (isObject(%client.player))
      %client.player.setSkinName(%client.getSkin());
}