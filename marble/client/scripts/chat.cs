function ChatDlg::onWake(%this)
{
   ChatEdit.setText("");
}

function ChatDlg::sendChat(%this)
{
   %msg = ChatEdit.getValue();
   
   Canvas.popDialog(ChatDlg);   
   
   if (trim(%msg) $= "")
      return;
      
   commandToServer('SendChat', %msg);
}

function ChatText::receiveChat(%this, %msg)
{
   cancel(%this.scroll);
   %lineCount = getLineCount(ChatText.getValue());
   
   if (%lineCount > 6)
   {
      %this.scroll();
   }
   
   ChatText.setText("<just:left><font:DomCasualD:32>" @ ChatText.getValue() @ %msg @ "\n");
   
   %this.scroll = %this.schedule(5000, scroll);
}

function ChatText::scroll(%this)
{
   cancel(%this.scroll);
   %this.setText("<just:left><font:DomCasualD:32>" @ getFields(%this.getValue(), 1));
   
   %this.scroll = %this.schedule(5000, scroll);
}

function clientCmdReceiveChat(%msg)
{
   ChatText.receiveChat(%msg);
}

function getLineCount(%string)
{
   %lineCount = 0;
   %str = strlwr(expandEscape(%string));
   while (strstr(%str, "\\n") != -1)
   {
      %pos = strpos(%str, "\\n") + 1;
      %str = getSubStr(%str, %pos, strlen(%str));
      %lineCount++;
   }
   return %lineCount;
}