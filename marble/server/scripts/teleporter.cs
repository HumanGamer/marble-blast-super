datablock AudioProfile(TeleportSfx)
{
   filename    = "~/data/sound/teleport.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(TeleportFinishSfx)
{
   filename    = "~/data/sound/teleportFinish.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock TriggerData(TeleportTrigger)
{
   tickPeriodMS = 100;
};

function TeleportTrigger::onEnterTrigger(%this, %trigger, %obj)
{
   cancel(%obj.teleportFade);
   cancel(%obj.teleport);
   cancel(%obj.teleportSound);
   %target = %trigger.target;
   %time = %trigger.time;
   if (%time $= "")
      %time = 1000;
   
   if (isObject(%target) && %target.getClassName() $= "Trigger" && %target.getDatablock().getName() $= "TeleportTargetTrigger")
   {
      info("Teleporting");
      %targetPos = %target.getPosition();
      
      %obj.startFade(250, 0, true);
      
      %obj.client.play2d(TeleportSfx);
      
      %obj.teleportFade = %obj.schedule(%time, "startFade", 250, 0, false);
      %obj.teleport = %obj.schedule(%time, "setTransform", %targetPos);
      %obj.teleportSound = %obj.schedule(%time, "play2d", TeleportFinishSfx);
   }
}

function TeleportTrigger::onLeaveTrigger(%this, %trigger, %obj)
{
   cancel(%obj.teleportFade);
   cancel(%obj.teleport);
   cancel(%obj.teleportSound);
   %obj.startFade(250, 0, false);
}

datablock TriggerData(TeleportTargetTrigger)
{
   tickPeriodMS = 100;
};