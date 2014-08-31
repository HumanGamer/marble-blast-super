//function PlayerListGui::show(%this)
//{
//   PlayerList.addRow(0, "" TAB "Matt" TAB "0");
//}

function PlayerListGui::addPlayer(%this, %clientId, %name, %isMe, %score)
{
   if (PlayerList.getRowTextById(%clientId) !$= "")
   {
      %this.update(%clientId, %name, %isMe, %score);
      return;
   }
   %icon = "";   
   
   if (%isMe)
      %icon = ">";
   
   PlayerList.addRow(%clientId, %icon TAB %name TAB %score);
   PlayerList_Shadow.addRow(%clientId, %icon TAB %name TAB %score);
   LB_PlayerList.addRow(%clientId, %icon TAB %name TAB %score);
}

function PlayerListGui::update(%this, %clientId, %name, %isMe, %score)
{
   if (PlayerList.getRowTextById(%clientId) $= "")
      %this.addPlayer(%clientId, %name, %isMe, %score);
   
   %icon = "";   
   
   if (%isMe)
      %icon = ">";
      
   PlayerList.setRowById(%clientId, %icon TAB %name TAB %score);
   PlayerList_Shadow.setRowById(%clientId, %icon TAB %name TAB %score);
   
   LB_PlayerList.setRowById(%clientId, %icon TAB %name TAB %score);
   
   PlayerList.sortNumerical(2, false);
   PlayerList_Shadow.sortNumerical(2, false);
   
   LB_PlayerList.sortNumerical(2, false);
}

function PlayerListGui::removePlayer(%this, %clientId)
{
   PlayerList.removeRow(%clientId);
   PlayerList_Shadow.removeRow(%clientId);
   LB_PlayerList.removeRow(%clientId);
}

function PlayerListGui::clear(%this)
{
   PlayerList.clear();
   PlayerList_Shadow.clear();
   LB_PlayerList.clear();
}