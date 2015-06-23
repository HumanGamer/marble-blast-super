$Game::UpdateInterval = 30;

function onGameStartup()
{
   if (!isEventPending($CompassUpdate))
      updateCompass();
   updateDelta();
   updateGame();
   updateDemo();
   oobUpdate();
}

function updateDelta()
{
   cancel($Game::DeltaUpdate);   
   
   if ($Game::LastTime $= "")
      $Game::LastTime = getRealTime();
   %passed = getRealTime() - $Game::LastTime;
   $Game::LastTime = getRealTime();
   $Game::GameLoops++;
   
   $Game::DeltaUpdate = schedule(10, 0, updateDelta);
}

function updateDemo()
{   
   cancel($Game::UpdateDemo);
   if ($playingDemo && $Client::BlastEnergy > 1000)
   {
      for (%i = 0; %i < $BlastCount; %i++)
      {
         %time = $BlastTime[%i];
         
         if (PlayGui.elapsedTime >= %time && !$UsedBlast[%i])
         {
            commandToServer('UseBlast');
            $UsedBlast[%i] = true;
         }
      }
   }
   
   if ($playingDemo && !$Game::OOBDone && LocalClientConnection.player.isOOB)
   {
      for (%i = 0; %i < $Demo::OOBCount; %i++)
      {
         %time = $Demo::OOBTime[%i];
         
         if (PlayGui.elapsedTime >= %time && !$Demo::UsedOOB[%i])
         {
            $Game::OOBDone = true;
            commandToServer('OOBClick');
            $Demo::UsedOOB[%i] = true;
         }
      }
   }
   $Game::UpdateDemo = schedule(1, 0, updateDemo);
}

function updateGame()
{
   cancel($Game::UpdateSchedule);
   
   checkHidingPlatforms();
   checkBombs();
   updateCannons();
   updateRotationPlatforms();
   
   $Game::UpdateSchedule = schedule($Game::UpdateInterval, 0, updateGame);
}

function oobUpdate()
{
   cancel($Game::OOBUpdate);
   for (%i = 0; %i < ClientGroup.getCount(); %i++)
   {
      %obj = ClientGroup.getObject(%i);
      if (%obj.player $= "")
         continue;
      if (%obj.player.getIsOOB() && %obj.GameState $= "Play")
      {
         commandToClient(%obj, 'OOBUpdate');
      }
   }
   
   $Game::OOBUpdate = schedule(1, 0, oobUpdate);
}
