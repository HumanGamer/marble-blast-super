//-----------------------------------------------------------------------------
// Torque Game Engine
//
// Copyright (c) 2001 GarageGames.Com
// Portions Copyright (c) 2001 by Sierra Online, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

$BlastLifetime = 250;

datablock ParticleData(BlastParticle)
{
   textureName          = "~/data/particles/spark";
   dragCoeffiecient     = 0;
   gravityCoefficient   = 2;
   windCoefficient      = 0;
   inheritedVelFactor   = 0;
   constantAcceleration = 0;//-2;
   lifetimeMS           = $BlastLifetime;
   lifetimeVarianceMS   = 100;

   colors[0]     = "0 0.5 1 0";
   colors[1]     = "0 0.6 1 1.0";
   colors[2]     = "0 0.6 1 0.0";


   sizes[0]      = 1;
   sizes[1]      = 0.5;
   sizes[2]      = 0.125;

   times[0]      = 0;
   times[1]      = 0.75;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(BlastEmitter)
{
   ejectionPeriodMS = 5;
   periodVarianceMS = 0.1;
   ejectionVelocity = 4.0;
   velocityVariance = 0.25;
   thetaMin         = 150;//90;
   thetaMax         = 170;//70.0;
   lifetimeMS       = 5000;//0;
   particles = "BlastParticle";
};

datablock ParticleEmitterNodeData(BlastNode)
{
   timeMultiple = 1;
};

datablock ParticleData(BounceParticle)
{
   textureName          = "~/data/particles/star";
   dragCoeffiecient     = 1.0;
   gravityCoefficient   = 0;
   windCoefficient      = 0;
   inheritedVelFactor   = 0;
   constantAcceleration = -2;
   lifetimeMS           = 500;
   lifetimeVarianceMS   = 100;
   useInvAlpha =  true;
   spinSpeed     = 90;
   spinRandomMin = -90.0;
   spinRandomMax =  90.0;

   colors[0]     = "0 0.5 1 0";
   colors[1]     = "0 0.6 1 1.0";
   colors[2]     = "0 0.6 1 0.0";


   sizes[0]      = 0.25;
   sizes[1]      = 0.25;
   sizes[2]      = 0.25;

   times[0]      = 0;
   times[1]      = 0.75;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(MarbleBounceEmitter)
{
   ejectionPeriodMS = 80;
   periodVarianceMS = 0;
   ejectionVelocity = 3.0;
   velocityVariance = 0.25;
   thetaMin         = 80.0;
   thetaMax         = 90.0;
   lifetimeMS       = 250;
   particles = "BounceParticle";
};

//-----------------------------------------------------------------------------

datablock ParticleData(TrailParticle)
{
   textureName          = "~/data/particles/spark";
   dragCoeffiecient     = 0.6;
   gravityCoefficient   = 0;
   windCoefficient      = 0;
   inheritedVelFactor   = 0;
   constantAcceleration = 0;
   lifetimeMS           = 700;
   lifetimeVarianceMS   = 0;
   useInvAlpha =  true;
   spinSpeed     = 0;

   colors[0]     = "0.9 0.0 0.0 1.0";
   colors[1]     = "0.9 0.9 0.0 1.0";
   colors[2]     = "0.9 0.9 0.0 0.0";


   sizes[0]      = 0.125;
   sizes[1]      = 0.025;
   sizes[2]      = 0.0125;

   times[0]      = 2;
   times[1]      = 2;
   times[2]      = 2;
};

datablock ParticleEmitterData(MarbleTrailEmitter)
{
   ejectionPeriodMS = 0;
   periodVarianceMS = 0;
   ejectionVelocity = 0;
   velocityVariance = 0;
   //thetaMin         = 30.0;
   //thetaMax         = 50.0;
   thetaMin         = 90.0;
   thetaMax         = 70.0;
   lifetimeMS       = 10000;
   particles = "TrailParticle";
};

//-----------------------------------------------------------------------------

datablock ParticleData(SuperJumpParticle)
{
   textureName          = "~/data/particles/twirl";
   dragCoefficient      = 0.25;
   gravityCoefficient   = 0;
   inheritedVelFactor   = 0.1;
   constantAcceleration = 0;
   lifetimeMS           = 1000;
   lifetimeVarianceMS   = 150;
   spinSpeed     = 90;
   spinRandomMin = -90.0;
   spinRandomMax =  90.0;

   colors[0]     = "0 0.5 1 0";
   colors[1]     = "0 0.6 1 1.0";
   colors[2]     = "0 0.6 1 0.0";

   sizes[0]      = 0.25;
   sizes[1]      = 0.25;
   sizes[2]      = 0.5;

   times[0]      = 0;
   times[1]      = 0.75;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(MarbleSuperJumpEmitter)
{
   ejectionPeriodMS = 10;
   periodVarianceMS = 0;
   ejectionVelocity = 1.0;
   velocityVariance = 0.25;
   thetaMin         = 150.0;
   thetaMax         = 170.0;
   lifetimeMS       = 5000;
   particles = "SuperJumpParticle";
};

//-----------------------------------------------------------------------------

datablock ParticleData(SuperSpeedParticle)
{
   textureName          = "~/data/particles/spark";
   dragCoefficient      = 0.25;
   gravityCoefficient   = 0;
   inheritedVelFactor   = 0.25;
   constantAcceleration = 0;
   lifetimeMS           = 1500;
   lifetimeVarianceMS   = 150;

   colors[0]     = "0.8 0.8 0 0";
   colors[1]     = "0.8 0.8 0 1.0";
   colors[2]     = "0.8 0.8 0 0.0";

   sizes[0]      = 0.25;
   sizes[1]      = 0.25;
   sizes[2]      = 1.0;

   times[0]      = 0;
   times[1]      = 0.25;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(MarbleSuperSpeedEmitter)
{
   ejectionPeriodMS = 5;
   periodVarianceMS = 0;
   ejectionVelocity = 1.0;
   velocityVariance = 0.25;
   thetaMin         = 130.0;
   thetaMax         = 170.0;
   lifetimeMS       = 5000;
   particles = "SuperSpeedParticle";
};

//-----------------------------------------------------------------------------

//datablock ParticleEmitterData(MarbleSuperBounceEmitter)
//{
   //ejectionPeriodMS = 20;
   //periodVarianceMS = 0;
   //ejectionVelocity = 3.0;
   //velocityVariance = 0.25;
   //thetaMin         = 80.0;
   //thetaMax         = 90.0;
   //lifetimeMS       = 250;
   //particles = "MarbleStar";
//};

//-----------------------------------------------------------------------------

//datablock ParticleEmitterData(MarbleShockAbsorberEmitter)
//{
   //ejectionPeriodMS = 20;
   //periodVarianceMS = 0;
   //ejectionVelocity = 3.0;
   //velocityVariance = 0.25;
   //thetaMin         = 80.0;
   //thetaMax         = 90.0;
   //lifetimeMS       = 250;
   //particles = "MarbleStar";
//};

//-----------------------------------------------------------------------------

//datablock ParticleEmitterData(MarbleHelicopterEmitter)
//{
   //ejectionPeriodMS = 20;
   //periodVarianceMS = 0;
   //ejectionVelocity = 3.0;
   //velocityVariance = 0.25;
   //thetaMin         = 80.0;
   //thetaMax         = 90.0;
   //lifetimeMS       = 5000;
   //particles = "MarbleStar";
//};

//-----------------------------------------------------------------------------
// ActivePowerUp
// 0 - no active powerup
// 1 - Super Jump
// 2 - Super Speed
// 3 - Super Bounce
// 4 - Indestructible

datablock AudioProfile(BlastSfx)
{
   filename    = "~/data/sound/blast.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(Bounce1Sfx)
{
   filename    = "~/data/sound/bouncehard1.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(Bounce2Sfx)
{
   filename    = "~/data/sound/bouncehard2.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(Bounce3Sfx)
{
   filename    = "~/data/sound/bouncehard3.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(Bounce4Sfx)
{
   filename    = "~/data/sound/bouncehard4.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(JumpSfx)
{
   filename    = "~/data/sound/Jump.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(RollingHardSfx)
{
   filename    = "~/data/sound/Rolling_Hard.wav";
   description = AudioClosestLooping3d;
   preload = true;
};

datablock AudioProfile(MegaBounce1Sfx)
{
   filename    = "~/data/sound/mega_bouncehard1.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(MegaBounce2Sfx)
{
   filename    = "~/data/sound/mega_bouncehard2.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(MegaBounce3Sfx)
{
   filename    = "~/data/sound/mega_bouncehard3.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(MegaBounce4Sfx)
{
   filename    = "~/data/sound/mega_bouncehard4.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(MegaRollingHardSfx)
{
   filename    = "~/data/sound/mega_Rolling_Hard.wav";
   description = AudioClosestLooping3d;
   preload = true;
};

datablock AudioProfile(SlippingSfx)
{
   filename    = "~/data/sound/Sliding.wav";
   description = AudioClosestLooping3d;
   preload = true;
};

datablock MarbleData(DefaultMarble)
{
   shapeFile = "~/data/shapes/balls/marble.dts";
   emap = true;
   renderFirstPerson = true;
// maxRollVelocity = 55;
// angularAcceleration = 120;
   maxRollVelocity = 15;
   angularAcceleration = 75;
   brakingAcceleration = 30;
   gravity = 20;
   staticFriction = 1.1;
   kineticFriction = 0.7;
   bounceKineticFriction = 0.2;
   maxDotSlide = 0.5;
   bounceRestitution = 0.5;
   jumpImpulse = 7.5;
   maxForceRadius = 50;

   bounce1 = Bounce1Sfx;
   bounce2 = Bounce2Sfx;
   bounce3 = Bounce3Sfx;
   bounce4 = Bounce4Sfx;

   rollHardSound = RollingHardSfx;
   slipSound = SlippingSfx;
   jumpSound = JumpSfx;
   
   // Emitters
   minTrailSpeed = 10;            // Trail threshold
   trailEmitter = MarbleTrailEmitter;
   
   minBounceSpeed = 3;           // Bounce threshold
   bounceEmitter = MarbleBounceEmitter;
   
   powerUpEmitter[1] = MarbleSuperJumpEmitter; 		// Super Jump
   powerUpEmitter[2] = MarbleSuperSpeedEmitter; 	// Super Speed
// powerUpEmitter[3] = MarbleSuperBounceEmitter; 	// Super Bounce
// powerUpEmitter[4] = MarbleShockAbsorberEmitter; 	// Shock Absorber
// powerUpEmitter[5] = MarbleHelicopterEmitter; 	// Helicopter
   
   // Power up timouts. Timeout on the speed and jump only affect
   // the particle trail
   powerUpTime[1] = 1000;	// Super Jump
   powerUpTime[2] = 1000; 	// Super Speed
   powerUpTime[3] = 5000; 	// Super Bounce
   powerUpTime[4] = 5000; 	// Shock Absorber
   powerUpTime[5] = 5000; 	// Helicopter

   // Allowable Inventory Items
   maxInv[SuperJumpItem] = 20;
   maxInv[SuperSpeedItem] = 20;
   maxInv[SuperBounceItem] = 20;
   maxInv[IndestructibleItem] = 20;
   maxInv[TimeTravelItem] = 20;
//   maxInv[GoodiesItem] = 10;

   radius = 0.27;
   reduction = 0.25;
   power = 4;
   maxPower = 25;
   bounceCol = 0.5;
   minCol = 0.3;
   
   blastRechargeTime = 36000;
   maxBlastRecharge = 5500;//5700;
   maxBlast = 6500;//6700;
   minUsableBlast = 1000;//1300;
};

datablock MarbleData(MegaMarbleBall : DefaultMarble)
{
   shapeFile = "~/data/shapes/balls/megamarbleball.dts";
   
   maxRollVelocity = 14;
   
   bounce1 = MegaBounce1Sfx;
   bounce2 = MegaBounce2Sfx;
   bounce3 = MegaBounce3Sfx;
   bounce4 = MegaBounce4Sfx;

   rollHardSound = MegaRollingHardSfx;   
   
   radius = 0.6075;
   reduction = 0.5625;
   power = 20;
   maxPower = 32;
   bounceCol = 0.5;
   minCol = 0.3;
   
   blastRechargeTime = 36000;
   maxBlastRecharge = 5500;
   maxBlast = 6500;
   minUsableBlast = 1000;
};

datablock MarbleData(MiniMarbleBall : DefaultMarble)
{
   shapeFile = "~/data/shapes/balls/miniMarble.dts";
   
   maxRollVelocity = 15;
   
   bounce1 = MegaBounce1Sfx;
   bounce2 = MegaBounce2Sfx;
   bounce3 = MegaBounce3Sfx;
   bounce4 = MegaBounce4Sfx;

   rollHardSound = MegaRollingHardSfx;   
   
   radius = 0.135;
   reduction = 0.125;
   power = 2;
   maxPower = 5;
   bounceCol = 0.5;
   minCol = 0.3;
   
   blastRechargeTime = 36000;
   maxBlastRecharge = 5500;
   maxBlast = 6500;
   minUsableBlast = 1000;
};


//-----------------------------------------------------------------------------

function MarbleData::onAdd(%this, %obj)
{
   echo("New Marble: " @ %obj);
}

function MarbleData::onTrigger(%this, %obj, %triggerNum, %val)
{
}


//-----------------------------------------------------------------------------

function MarbleData::onCollision(%this,%obj,%col)
{
   // Try and pickup all items
   if (%col.getClassName() $= "Item")
   {
      %data = %col.getDatablock();
      %obj.pickup(%col,1);
   //} else if (%col.getClassName() $= "StaticShape" && %col.getDatablock().getName() $= "GhostMarble" || %col.getDatablock().getName() $= "GhostMegaMarble")
   //{
      //onMarbleCollision(%obj, %col);
   } else if (%col.getClassName() $= "StaticShape" && %col.getDatablock().getName() $= "HidingPlatform")
   {
      if (%col.timer $= "" && !%col.used && !%col.trigger)
         hidePlatform(%col);
   } else if (%col.getClassName() $= "StaticShape" && %col.getDatablock().getName() $= "ExplodingPlatform")
   {
      ExplodingPlatform.explode(%col);
   }// else if (%col.getClassName() $= "StaticShape" && %col.getDatablock().getName() $= "CannonBall")
   //{
   //   //echo("collision!");
   //   CannonBall.explode(%col, %obj);
   //}
}

function findClosestPlayer(%position, %radius)
{
   if (!isObject(MissionCleanup))
      return;
   for (%i = 0; %i < MissionCleanup.getCount(); %i++)
   {
      %obj = MissionCleanup.getObject(%i);
      
      if (%obj.getClassName() $= "Marble")
      {
         %dist = VectorDist(%position, %obj.getPosition());
         //echo(%dist);
         if (%dist > %radius)
            continue;
         if (%dist < %lastDist || %lastDist $= "")
         {
            %lastDist = %dist;
            %lastObj = %obj;
         }
      }
   }
   
   return %lastObj;
}


//-----------------------------------------------------------------------------
// The following event callbacks are punted over to the connection
// for processing

function MarbleData::onEnterPad(%this,%object)
{
   %object.client.onEnterPad();
}

function MarbleData::onLeavePad(%this,%object)
{
   %object.client.onLeavePad();
}

function MarbleData::onStartPenalty(%this,%object)
{
   %object.client.onStartPenalty();
}

function MarbleData::onOutOfBounds(%this,%object)
{
   %object.client.onOutOfBounds();
}

function MarbleData::setCheckpoint(%this,%object,%check)
{
   %object.client.setCheckpoint(%check);
}

//-----------------------------------------------------------------------------
// Marble object
//-----------------------------------------------------------------------------

function Marble::setPowerUp(%this,%item,%reset)
{
   if (%item.powerUpId == 6)
   {
      %item.usePowerUp(%this);
      return;
   }
   %this.client.setPowerUp(%item.shapeFile);
   %this.powerUpData = %item;
   if (%item.powerUpId < 6)
      %this.setPowerUpId(%item.powerUpId,%reset);
   else
      %this.setPowerUpId(0,%reset);
}

function Marble::useCurrentPowerUp(%this)
{
   if (isObject(%this.powerUpData))
   {
      %this.powerUpData.usePowerUp(%this);
      %this.onPowerUpUsed(%this);
   }
}

function serverCmdUseCurrentPowerUp(%client)
{
   %client.player.useCurrentPowerUp();
}

function Marble::getPowerUp(%this)
{
   return %this.powerUpData;
}

function Marble::onPowerUpUsed(%obj)
{
   if (%obj.getIsOOB())
      return;
   %data = %obj.powerUpData;
   %image = %data.image;   
   %slot = %data.mountSlot;
   %time = %obj.getDatablock().powerUpTime[%data.powerUpId];
   
   %obj.client.mountImage(%image, %slot, %time);   
   
   %obj.client.setPowerUp("");
   %obj.playAudio(0, %obj.powerUpData.activeAudio);
   %obj.powerUpData = "";
}

function Marble::getIsOOB(%this)
{
   return %this.isOOB;
}

function Marble::setBlastEnergy(%this, %energy)
{
   %this.blastEnergy = %energy;
   if (%this.blastEnergy > %this.getDatablock().maxBlast)
      %this.blastEnergy = %this.getDatablock().maxBlast;
   if (%this.blastEnergy > %this.getDatablock().maxBlastRecharge)
      commandToClient(%this.client, 'SetBlastEnergy', %this.blastEnergy, %this.getDatablock().maxBlast, true);
   else
      commandToClient(%this.client, 'SetBlastEnergy', %this.blastEnergy, %this.getDatablock().maxBlastRecharge, false);
}

function Marble::updateBlast(%this)
{
   cancel(%this.blastUpdate);  
   
   %nextTime = 8.4;
   
   if (%this.blastEnergy < %this.getDataBlock().maxBlastRecharge && !$Core::PhysicsDisabled)
   {
      %energy = %this.blastEnergy + 1.2;
      if (%energy > %this.getDataBlock().maxBlastRecharge)
         %energy = %this.getDataBlock().maxBlastRecharge;
      %this.setBlastEnergy(%energy);
   }
   
   %this.blastUpdate = %this.schedule(%nextTime, "updateBlast");
}

function Marble::useBlast(%this)
{
   if (%this.blastEnergy >= %this.getDatablock().getName().minUsableBlast && !$Core::PhysicsDisabled)
   {
      %energy = (%this.blastEnergy / 1000) * -1;
      %from = %energy SPC %energy SPC %energy;
      %push = VectorMult(%from, getGravityDir());
      
      %this.client.applyImpulse("0 0 0", %push);
      %this.setBlastEnergy(0);
      %this.client.play2d(BlastSfx);
      
      %position = %this.position;
      %rotation = %this.rotation;
      
      %node = new ParticleEmitterNode()
      {
         position = %position;
         rotation = %rotation;
         scale = "1 1 1";
         datablock = "BlastNode";
         emitter = "BlastEmitter";
         velocity = "1";
      };
      
      $CurrentBlastNode = %node;
      
      schedule($BlastLifetime, 0, "deleteBlast");
   }
}

function deleteBlast()
{
   if (isObject($CurrentBlastNode))
      $CurrentBlastNode.delete();
   $CurrentBlastNode = "";
}

function serverCmdUseBlast(%client)
{
   %client.player.useBlast();
}


//-----------------------------------------------------------------------------

function marbleVel()
{
   return $MarbleVelocity;
}

function metricsMarble()
{
   Canvas.pushDialog(FrameOverlayGui, 1000);
   TextOverlayControl.setValue("$MarbleVelocity");
}
