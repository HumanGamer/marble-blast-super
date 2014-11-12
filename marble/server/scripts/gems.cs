//-----------------------------------------------------------------------------
// Torque Game Engine
//
// Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

datablock ParticleData(GemParticle)
{
   textureName          = "~/data/particles/star";
   dragCoeffiecient     = 2;
   gravityCoefficient   = -1;
   windCoefficient      = 0;
   inheritedVelFactor   = 0;
   constantAcceleration = 0;
   lifetimeMS           = 250;
   lifetimeVarianceMS   = 100;
   useInvAlpha =  true;
   spinSpeed     = 0;

   colors[0]     = "1.0 1.0 1.0 1.0";
   colors[1]     = "1.0 1.0 1.0 1.0";
   colors[2]     = "1.0 1.0 1.0 0.0";

   sizes[0]      = 0.5;
   sizes[1]      = 0.5;
   sizes[2]      = 0.5;

   times[0]      = 1.0;
   times[1]      = 1.0;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(GemParticleEmitter)
{
   ejectionPeriodMS = 250;
   periodVarianceMS = 0;
   ejectionVelocity = 2;
   velocityVariance = 0;
   thetaMin         = 0;
   thetaMax         = 50;
   lifetimeMS       = 0;
   particles = "GemParticle";
};

datablock ParticleEmitterNodeData(GemParticleNode)
{
   timeMultiple = 1;
};

//-----------------------------------------------------------------------------
// Gem base class
//-----------------------------------------------------------------------------

datablock AudioProfile(GotGemSfx)
{
   filename    = "~/data/sound/gotGem.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(GotAllGemsSfx)
{
   filename    = "~/data/sound/gotAllGems.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(OpponentGotGemSfx)
{
   filename    = "~/data/sound/gotGemOpponent.wav";
   description = AudioDefault3d;
   preload = true;
};


//-----------------------------------------------------------------------------

$GemSkinColors[0] = "base";
$GemSkinColors[1] = "blue";
$GemSkinColors[2] = "red";
$GemSkinColors[3] = "yellow";
$GemSkinColors[4] = "purple";
$GemSkinColors[5] = "orange";
$GemSkinColors[6] = "green";
$GemSkinColors[7] = "turquoise";
$GemSkinColors[8] = "black";

function Gem::onAdd(%this,%obj)
{
   %obj.collideable = "0";
	%obj.static = "1";
	%obj.rotate = "1";
	
	%skin = %this.skin;
	if (%skin $= "")
	   %skin = $GemSkinColors[getRandom(8)]; // Random skin if none assigned
   %obj.setSkinName(%skin);
   
   %this.setRadar(%obj, %skin);
   
}

function Gem::setRadar(%this, %obj, %skin)
{
   if (ClientGroup.getCount() <= 0)
   {
      %this.schedule(250, "setRadar", %obj, %skin);
      return;
   }
   if (MissionInfo.gameMode !$= "hunt")
   {
      %position = %obj.getPosition();   
      %x = getWord(%position, 0);
      %y = getWord(%position, 1);
      //commandToAll('UpdateRadarObject', %obj.getId(), %skin, %x, %y);
   }
}

function createGemParticles(%obj)
{
   if (isObject(%obj.node))
      %obj.node.delete();  
      
   %position = getWords(%obj.position, 0, 1) SPC getWord(%obj.position, 2) + 0.5;
   %rotation = %obj.rotation;
   
   %node = new ParticleEmitterNode()
   {
      position = %position;
      rotation = %rotation;
      scale = "1 1 1";
      datablock = "GemParticleNode";
      emitter = "GemParticleEmitter";
      velocity = "1";
   };
     
   %obj.node = %node;
   
   MissionCleanup.add(%node); 
}

function Gem::onPickup(%this,%obj,%user,%amount)
{
   Parent::onPickup(%this,%obj,%user,%amount);
   if (isObject(%obj.node))
      %obj.node.delete();
   if (MissionInfo.gameMode $= "hunt")
       %user.client.onFoundGem(%this.points, %obj);
   else
       %user.client.onFoundGem(%amount, %obj);
   return true;
}

function Gem::saveState(%this,%obj,%state)
{
   %state.object[%obj.getId()] = %obj.isHidden();
}

function Gem::restoreState(%this,%obj,%state)
{
   %obj.hide(%state.object[%obj.getId()]);
}

//-----------------------------------------------------------------------------

datablock ItemData(GemItem)
{
   // Mission editor category
   category = "Gems";
   className = "Gem";

   // Basic Item properties
   shapeFile = "~/data/shapes/items/gem.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;

   // Dynamic properties defined by the scripts
   pickupName = "a gem!";
   maxInventory = 1;
   noRespawn = true;
   gemType = 1;
   noPickupMessage = true;
};

datablock ItemData(GemItemBlue: GemItem) 
{
   skin = "blue";
};

datablock ItemData(GemItemRed: GemItem)
{
   skin = "red";
};

datablock ItemData(GemItemYellow: GemItem)
{
   skin = "yellow";
};

datablock ItemData(GemItemPurple: GemItem)
{
   skin = "purple";
};

datablock ItemData(GemItemGreen: GemItem)
{
   skin = "green";
};

datablock ItemData(GemItemTurquoise: GemItem)
{
   skin = "turquoise";
};

datablock ItemData(GemItemOrange: GemItem)
{
   skin = "orange";
};

datablock ItemData(GemItemBlack: GemItem)
{
   skin = "black";
};

datablock ItemData(GemItemMulti)
{
   // Mission editor category
   category = "Gems";
   className = "Gem";

   // Basic Item properties
   shapeFile = "~/data/shapes/items/gem.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;

   // Dynamic properties defined by the scripts
   pickupName = "a gem!";
   maxInventory = 1;
   noRespawn = true;
   gemType = 1;
   noPickupMessage = true;
   skin = "red";
   points = 1;
};

datablock ItemData(GemItemMulti2Pts)
{
   // Mission editor category
   category = "Gems";
   className = "Gem";

   // Basic Item properties
   shapeFile = "~/data/shapes/items/gem.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;

   // Dynamic properties defined by the scripts
   pickupName = "a gem!";
   maxInventory = 1;
   noRespawn = true;
   gemType = 1;
   noPickupMessage = true;
   skin = "yellow";
   points = 2;
};

datablock ItemData(GemItemMulti5Pts)
{
   // Mission editor category
   category = "Gems";
   className = "Gem";

   // Basic Item properties
   shapeFile = "~/data/shapes/items/gem.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;

   // Dynamic properties defined by the scripts
   pickupName = "a gem!";
   maxInventory = 1;
   noRespawn = true;
   gemType = 1;
   noPickupMessage = true;
   skin = "blue";
   points = 5;
};

datablock ItemData(GemItemMulti7Pts)
{
   // Mission editor category
   category = "Gems";
   className = "Gem";

   // Basic Item properties
   shapeFile = "~/data/shapes/items/gem.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;

   // Dynamic properties defined by the scripts
   pickupName = "a gem!";
   maxInventory = 1;
   noRespawn = true;
   gemType = 1;
   noPickupMessage = true;
   skin = "green";
   points = 7;
};
