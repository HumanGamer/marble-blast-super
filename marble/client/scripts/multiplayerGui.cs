function MultiplayerGui::onWake(%this)
{
   getUserList();
}

function getUserList()
{
   MP_UserList.clear();
   MP_UserList.addRow(MP_ChatText.rowCount(), $pref::Multiplayer::Name);
}

function sendChat()
{
   %chat = MP_ChatEdit.getValue();
   
   if (strlen(trim(%chat)) <= 0)
      return;
   
   %sender = $pref::Multiplayer::Name;
   
   MP_receiveChat(%sender @ ": " @ %chat);
   
   MP_ChatEdit.setText("");
}

function MP_receiveChat(%message)
{
   MP_ChatText.addRow(MP_ChatText.rowCount(), %message);
}