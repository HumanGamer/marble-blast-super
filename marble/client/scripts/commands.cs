//---------------------------------------------------------------
// Marble Blast Super
// marble/client/scripts/commands.cs
// (C) 2013 Matthieu Parizeau
//---------------------------------------------------------------

//---------------------------------------------------------------
//Client Commands
//---------------------------------------------------------------

function clientCmdIncPenaltyTime(%dt)
{
   PlayGui.adjustTimer(%dt);
}

function clientCmdIncBonusTime(%dt)
{
   PlayGui.addBonusTime(%dt);
}

function clientCmdEndBonusTime(%dt)
{
   PlayGui.endBonusTime(%dt);
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

function clientCmdSetQuotaGems(%count)
{
   PlayGui.setQuotaGems(%count);
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

function clientCmdOOBUpdate()
{
   //$leftMouseDown
   // Matt: Now uses space bar to avoid using powerups on spawn
   if (($spaceDown) && !$Game::OOBDone)
   {
      $Game::OOBDone = true;
      commandToServer('OOBClick');
      
      if ($isDemoRecording)
      {
         $Demo::OOBCount++;
         echo($Demo::OOBCount @ " | " @ PlayGui.elapsedTime);
         $Demo::OOBTime[$Demo::OOBCount - 1] = PlayGui.elapsedTime;
      }
   }
}

function clientCmdResetOOB()
{
   $Game::OOBDone = false;
}

function clientCmdGetMarbleSkin()
{
   commandToServer('SetMarbleSkin', MS_skinGroup.getObject($pref::MarbleIndex).skin);
}

function clientCmdShowGemPickup(%points, %lost)
{
   GemPopUpGui.showPopup(%points, %lost);
}

function clientCmdApplyImpulse(%impulseVec, %impulse)
{
   findRealMarble().applyImpulse(%impulseVec, %impulse);
}
