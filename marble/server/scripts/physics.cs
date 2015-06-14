function togglePhysics(%val)
{
   if (%val)
   {
      %state = c().getGameState();
      if ((%state $= "Play" || %state $= "Go") && !isEventPending(c().respawnSchedule))
      {
         $Core::PhysicsDisabled = !$Core::PhysicsDisabled;
         if ($Core::PhysicsDisabled)
         {
            PlayGui.stopTimer();
         } else {
            PlayGui.startTimer();
         }
      }
   }
}
