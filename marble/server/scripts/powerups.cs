//-----------------------------------------------------------------------------
// Torque Game Engine
// 
// Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// PowerUp base class
//-----------------------------------------------------------------------------

function PowerUp::onPickup(%this,%obj,%user,%amount)
{
   // Dont' pickup the power up if it's the same
   // one we already have.
   %gravinvcheck = %user.grav_inv_rotation $= getWords(%obj.getTransform(),3);
   if (%user.powerUpData == %this && (%this.powerUpId != 9 || (%this.powerUpId == 9 && %gravinvcheck)))
      return false;

   // Grab it...
   %user.client.play2d(%this.pickupAudio);
   if (%this.powerUpId)
   {
      if(%obj.showHelpOnPickup)
         %user.client.addHelpLine("Press <func:bind mouseFire> to use the " @ %this.useName @ "!", false);
   
      %user.setPowerUp(%this);
   }
   Parent::onPickup(%this, %obj, %user, %amount);
   return true;
}


//-----------------------------------------------------------------------------

datablock AudioProfile(doSuperJumpSfx)
{
   filename    = "~/data/sound/doSuperJump.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(PuSuperJumpVoiceSfx)
{
   filename    = "~/data/sound/puSuperJumpVoice.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock ItemData(SuperJumpItem)
{
   // Mission editor category
   category = "Powerups";
   className = "PowerUp";
   powerUpId = 1;

   activeAudio = DoSuperJumpSfx;
   pickupAudio = PuSuperJumpVoiceSfx;

   // Basic Item properties
   shapeFile = "~/data/shapes/items/superjump.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;
   emap = false;

   // Dynamic properties defined by the scripts
   pickupName = "a SuperJump PowerUp!";
   useName = "SuperJump PowerUp";
   maxInventory = 1;
};

function SuperJumpItem::onAdd(%this, %obj)
{
   %obj.playThread(0,"Ambient");
}


//-----------------------------------------------------------------------------

datablock AudioProfile(doSuperBounceSfx)
{
   filename    = "~/data/sound/doSuperBounce.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(PuSuperBounceVoiceSfx)
{
   filename    = "~/data/sound/puSuperBounceVoice.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock ItemData(SuperBounceItem)
{
   // Mission editor category
   category = "Powerups";
   className = "PowerUp";
   powerUpId = 3;

   activeAudio = DoSuperBounceSfx;
   pickupAudio = PuSuperBounceVoiceSfx;

   // Basic Item properties
   shapeFile = "~/data/shapes/items/superbounce.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;

   // Dynamic properties defined by the scripts
   pickupName = "a SuperBounce PowerUp!";
   useName = "SuperBounce PowerUp";
   maxInventory = 1;
   
   image = SuperBounceImage;
   mountSlot = 0;
};

datablock AudioProfile(SuperBounceLoopSfx)
{
   filename    = "~/data/sound/forcefield.wav";
   description = AudioClosestLooping3d;
   preload = true;
};

datablock ShapeBaseImageData(SuperBounceImage)
{
   // Basic Item properties
   shapeFile = "~/data/shapes/images/glow_bounce.dts";
   emap = true;

   // Specify mount point & offset for 3rd person, and eye offset
   // for first person rendering.
   mountPoint = 0;
   offset = "0 0 0";
   stateName[0] = "Blah";
   stateSound[0] = SuperBounceLoopSfx;
};


//-----------------------------------------------------------------------------

datablock AudioProfile(doSuperSpeedSfx)
{
   filename    = "~/data/sound/doSuperSpeed.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(PuSuperSpeedVoiceSfx)
{
   filename    = "~/data/sound/puSuperSpeedVoice.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock ItemData(SuperSpeedItem)
{
   // Mission editor category
   category = "Powerups";
   className = "PowerUp";
   powerUpId = 2;

   activeAudio = DoSuperSpeedSfx;
   pickupAudio = PuSuperSpeedVoiceSfx;

   // Basic Item properties
   shapeFile = "~/data/shapes/items/superspeed.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;
   emap = false;

   // Dynamic properties defined by the scripts
   pickupName = "a SuperSpeed PowerUp!";
   useName = "SuperSpeed PowerUp";
   maxInventory = 1;
};

function SuperSpeedItem::onAdd(%this, %obj)
{
   %obj.playThread(0,"Ambient");
}


//-----------------------------------------------------------------------------

datablock AudioProfile(doShockAbsorberSfx)
{
   filename    = "~/data/sound/doShockAbsorber.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(PuShockAbsorberVoiceSfx)
{
   filename    = "~/data/sound/puShockAbsorberVoice.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock ItemData(ShockAbsorberItem)
{
   // Mission editor category
   category = "Powerups";
   className = "PowerUp";
   powerUpId = 4;

   activeAudio = DoShockAbsorberSfx;
   pickupAudio = PuShockAbsorberVoiceSfx;

   // Basic Item properties
   shapeFile = "~/data/shapes/items/shockabsorber.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;

   // Dynamic properties defined by the scripts
   pickupName = "a ShockAbsorber PowerUp!";
   useName = "ShockAbsorber PowerUp";
   maxInventory = 1;
   emap = false;
   
   image = ShockAbsorberImage;
   mountSlot = 0;
};

datablock AudioProfile(ShockLoopSfx)
{
   filename    = "~/data/sound/superbounceactive.wav";
   description = AudioClosestLooping3d;
   preload = true;
};

datablock ShapeBaseImageData(ShockAbsorberImage)
{
   // Basic Item properties
   shapeFile = "~/data/shapes/images/glow_bounce.dts";
   emap = true;

   // Specify mount point & offset for 3rd person, and eye offset
   // for first person rendering.
   mountPoint = 0;
   offset = "0 0 0";
   stateName[0] = "Blah";
   stateSound[0] = ShockLoopSfx;
};


//-----------------------------------------------------------------------------

datablock AudioProfile(doHelicopterSfx)
{
   filename    = "~/data/sound/doHelicopter.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(PuGyrocopterVoiceSfx)
{
   filename    = "~/data/sound/puGyrocopterVoice.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock ItemData(HelicopterItem)
{
   // Mission editor category
   category = "Powerups";
   className = "PowerUp";
   powerUpId = 5;

   activeAudio = DoHelicopterSfx;
   pickupAudio = PuGyrocopterVoiceSfx;

   // Basic Item properties
   shapeFile = "~/data/shapes/images/helicopter.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;

   // Dynamic properties defined by the scripts
   pickupName = "a Gyrocopter PowerUp!";
   useName = "Gyrocopter PowerUp";
   maxInventory = 1;
   
   image = HelicopterImage;
   mountSlot = 2;
};

datablock AudioProfile(HelicopterLoopSfx)
{
   filename    = "~/data/sound/Use_Gyrocopter.wav";
   description = AudioClosestLooping3d;
   preload = true;
};

datablock ShapeBaseImageData(HelicopterImage)
{
   // Basic Item properties
   shapeFile = "~/data/shapes/images/helicopter.dts";
   emap = true;
   mountPoint = 0;
   offset = "0 0 0";
   stateName[0]                     = "Rotate";
   stateSequence[0]                 = "rotate";
   stateSound[0] = HelicopterLoopSfx;
   ignoreMountRotation = true;
};


//-----------------------------------------------------------------------------
// Special non-inventory power ups
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

datablock AudioProfile(PuTimeTravelVoiceSfx)
{
   filename    = "~/data/sound/puTimeTravelVoice.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock ItemData(TimeTravelItem)
{
   // Mission editor category
   category = "Powerups";
   className = "PowerUp";

   // Basic Item properties
   pickupAudio = PuTimeTravelVoiceSfx;
   shapeFile = "~/data/shapes/items/timetravel.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;
   emap = false;

   // Dynamic properties defined by the scripts
   noRespawn = true;
   maxInventory = 1;
};

function TimeTravelItem::onAdd(%this, %obj)
{
   %obj.playThread(0,"Ambient");
}   

function TimeTravelItem::getPickupName(%this, %obj)
{
   if (MissionInfo.gameMode !$= "hunt")
   {
      if(%obj.timeBonus !$= "")
         %time = %obj.timeBonus / 1000;
      else
         %time = $Game::TimeTravelBonus / 1000;

      return "a " @ %time @ " second TimeTravel Bonus!";
   } else {
      return "a TimeTravel!";
   }
}

function TimeTravelItem::onPickup(%this,%obj,%user,%amount)
{
   Parent::onPickup(%this, %obj, %user, %amount);
   if (MissionInfo.gameMode !$= "hunt")
   {
      if(%obj.timeBonus !$= "")
         %user.client.incBonusTime(%obj.timeBonus);
      else
         %user.client.incBonusTime($Game::TimeTravelBonus);
   }
}


//-----------------------------------------------------------------------------

datablock AudioProfile(PuAntiGravityVoiceSfx)
{
   filename    = "~/data/sound/gravitychange.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock ItemData(AntiGravityItem)
{
   // Mission editor category
   category = "Powerups";
   className = "PowerUp";

   pickupAudio = PuAntiGravityVoiceSfx;
   pickupName = "a GravityChanger!";

   // Basic Item properties
   shapeFile = "~/data/shapes/items/antiGravity.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;
   emap = false;

   // Dynamic properties defined by the scripts
   maxInventory = 1;
};

function AntiGravityItem::onAdd(%this, %obj)
{
   %obj.playThread(0,"Ambient");
}   

function AntiGravityItem::onPickup(%this,%obj,%user,%amount)
{
   %rotation = getWords(%obj.getTransform(),3);
   %ortho = vectorOrthoBasis(%rotation);
   %up = getWords(%ortho,6);
   if (getGravityDir() !$= %up) {
      Parent::onPickup(%this, %obj, %user, %amount);
      %user.client.setGravityDir(%ortho);
      $Game::CurrentGravityDir = %ortho;
   }
}

//-----------------------------------------------------------------------------

datablock AudioProfile(PuBlastVoiceSfx)
{
   filename    = "~/data/sound/puBlastVoice.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock ItemData(BlastItem)
{
   // Mission editor category
   category = "Powerups";
   className = "PowerUp";
   powerUpId = 6;

   //activeAudio = DoSuperBounceSfx;
   pickupAudio = PuBlastVoiceSfx;

   // Basic Item properties
   shapeFile = "~/data/shapes/items/ultrablast.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;

   // Dynamic properties defined by the scripts
   pickupName = "an Ultra Blast PowerUp!";
   useName = "Ultra Blast PowerUp";
   maxInventory = 1;
   
   noPickupMessage = true;
};

function BlastItem::onAdd(%this, %obj)
{
   %obj.playThread(0,"Ambient");
}   

function BlastItem::usePowerUp(%this, %obj)
{
   %obj.setBlastEnergy(%obj.getDatablock().maxBlast);
}

//-----------------------------------------------------------------------------

datablock AudioProfile(doMegaMarbleSfx)
{
   filename    = "~/data/sound/doMegaMarble.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(PuMegaMarbleVoiceSfx)
{
   filename    = "~/data/sound/puMegaMarbleVoice.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock ItemData(MegaMarbleItem)
{
   // Mission editor category
   category = "Powerups";
   className = "PowerUp";
   powerUpId = 7;

   activeAudio = doMegaMarbleSfx;
   pickupAudio = PuMegaMarbleVoiceSfx;

   // Basic Item properties
   shapeFile = "~/data/shapes/items/megamarble.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;

   // Dynamic properties defined by the scripts
   pickupName = "a Mega Marble PowerUp!";
   useName = "Mega Marble PowerUp";
   maxInventory = 1;
};

function MegaMarbleItem::onAdd(%this, %obj)
{
   %obj.playThread(0,"Ambient");
}   

function MegaMarbleItem::usePowerUp(%this, %obj)
{
   %obj.client.makeMega();
}

function GameConnection::makeMega(%this)
{
   cancel(%this.megaMarbleSchedule);
   
   %this.player.setDatablock(MegaMarbleBall);
   if (isObject(%this.ghost))
      %this.ghost.setDatablock(GhostMegaMarble);
   
   %this.applyImpulse("0 0 -1", "0 0 7");
   
   %this.megaMarbleSchedule = %this.schedule(10000, makeNoMega);
}

function GameConnection::makeNoMega(%this)
{
   cancel(%this.megaMarbleSchedule);
   
   %impulse = false;
   if (%this.player.getDatablock().getName() $= "MiniMarbleBall")
      %impulse = true;
   
   %this.player.setDatablock(DefaultMarble);
   if (isObject(%this.ghost))
      %this.ghost.setDatablock(GhostMarble);
   
   if (%impulse)
      %this.applyImpulse("0 0 -1", "0 0 7");
}

datablock AudioProfile(doMiniMarbleSfx)
{
   filename    = "~/data/sound/doMiniMarble.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(PuMiniMarbleVoiceSfx)
{
   filename    = "~/data/sound/puMiniMarbleVoice.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock ItemData(MiniMarbleItem)
{
   // Mission editor category
   category = "Powerups";
   className = "PowerUp";
   powerUpId = 8;

   activeAudio = doMiniMarbleSfx;
   pickupAudio = PuMiniMarbleVoiceSfx;

   // Basic Item properties
   shapeFile = "~/data/shapes/items/miniMarble.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;

   // Dynamic properties defined by the scripts
   pickupName = "a Mini Marble PowerUp!";
   useName = "Mini Marble PowerUp";
   maxInventory = 1;
};

function MiniMarbleItem::onAdd(%this, %obj)
{
   %obj.playThread(0,"Ambient");
}   

function MiniMarbleItem::usePowerUp(%this, %obj)
{
   %obj.client.makeMini();
}

function GameConnection::makeMini(%this)
{
   cancel(%this.megaMarbleSchedule);
   
   %this.player.setDatablock(MiniMarbleBall);
   if (isObject(%this.ghost))
      %this.ghost.setDatablock(GhostMiniMarble);
   
   %this.megaMarbleSchedule = %this.schedule(10000, makeNoMega);
}

datablock AudioProfile(doGravityInverterSfx)
{
   filename    = "~/data/sound/doGravityInverter.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(PuGravityInverterVoiceSfx)
{
   filename    = "~/data/sound/puGravityInverterVoice.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock ItemData(GravityInverterItem)
{
   // Mission editor category
   category = "Powerups";
   className = "PowerUp";
   powerUpId = 9;

   activeAudio = doGravityInverterSfx;
   pickupAudio = PuGravityInverterVoiceSfx;

   // Basic Item properties
   shapeFile = "~/data/shapes/items/gravity_inverter.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;

   // Dynamic properties defined by the scripts
   pickupName = "a Gravity Inverter PowerUp!";
   useName = "Gravity Inverter PowerUp";
   maxInventory = 1;
};

function GravityInverterItem::onPickup(%this,%obj,%user,%amount)
{
   Parent::onPickup(%this, %obj, %user, %amount);
   %user.grav_inv_rotation = getWords(%obj.getTransform(),3);
   //echo("Set: " @ %user.grav_inv_rotation);
}

function GravityInverterItem::usePowerUp(%this, %obj)
{
   //echo("Get: " @ %obj.grav_inv_rotation);
   %rotation = %obj.grav_inv_rotation;
   %ortho = vectorOrthoBasis(%rotation);
   %up = getWords(%ortho,6);
   if (getGravityDir() !$= %up) {
      %obj.client.setGravityDir(%ortho);
      $Game::CurrentGravityDir = %ortho;
   }
}

function GravityInverterItem::onAdd(%this, %obj)
{
   %obj.playThread(0,"Ambient");
}  
