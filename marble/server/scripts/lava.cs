// ---------------------------------------------------------
// Global Variables
// ---------------------------------------------------------

$Lava::UpdateDelay = 100;
$Lava::SurviveTime = 4000;
$Lava::Gravity = 8;

// ---------------------------------------------------------
// Particles
// ---------------------------------------------------------

datablock ParticleData(LavaSmokeParticle)
{
   textureName = "~/data/particles/smoke";
   dragCoeffiecient = 1.0;
   gravityCoeffiecient = 0;
   windCoeffiecient = 0; 
   inheritedVelFactor = 0;
   constantAcceleration = -2;
   lifetimeMS = 500;
   lifetimeVarianceMS = 100;
   useInvAlpha = true;
   spinSpeed = 90;
   spinRandomMin = -90;
   spinRandomMax = 90;
   
   colors[0] = "0.5 0.5 0.5 0.5";
   colors[1] = "0.75 0.75 0.75 1.0";
   colors[2] = "0.9 0.9 0.9 1.0";
   
   sizes[0] = 0.5;
   sizes[1] = 0.25;
   sizes[2] = 0.125;
   
   times[0] = 0.0;
   times[1] = 0.75;
   times[2] = 1.0;
};

datablock ParticleEmitterData(LavaSmokeEmitter)
{
   ejectionPeriodMS = 80;
   periodVariance = 0;
   ejectionVelocity = 3.0;
   velocityVariance = 0.25;
   thetaMin = 0.0;
   thetaMax = 90.0;
   particles = "LavaSmokeParticle";
};

datablock ParticleEmitterNodeData(LavaSmokeEmitterNode)
{
   timeMultiple = 1;
};

// Explosion
datablock ParticleEmitterNodeData(LandMineEmitterNode)
{
   timeMultiple = 1;
};

// ---------------------------------------------------------
// Shapes
// ---------------------------------------------------------

datablock StaticShapeData(LavaShape)
{
   category = "Lava";
   className = "Lava";
   shapeFile = "~/data/shapes/liquid/liquid.dts";
   scopeAlways = true;
   emap = false;
   
   skin = "lava";
};

function LavaShape::onAdd(%this, %obj)
{
	if (%this.skin !$= "")
      %obj.setSkinName(%this.skin);
}

// ---------------------------------------------------------
// Triggers
// ---------------------------------------------------------

datablock TriggerData(LavaTrigger)
{
   tickPeriodMS = 100;
};

function LavaTrigger::onEnterTrigger(%this, %trigger, %obj)
{
   %obj.inLava++;
   %obj.getDataBlock().gravity = $Lava::Gravity;
   
   PG_Lava.setVisible(true);
	PG_LavaTime.setVisible(true);
   
   // Start Timer
   startLavaTimer(%obj);
}

function LavaTrigger::onLeaveTrigger(%this, %trigger, %obj)
{
   %obj.inLava--;
   
   if (%obj.inLava)
      return;
		
	%obj.lavaTime = 0;
	%obj.lavaDead = false;
   
   %obj.getDataBlock().gravity = "20";
   
   PG_Lava.setVisible(false);
	PG_LavaTime.setVisible(false);
	PG_LavaTime.setValue(1);
   
   // Stop Timer
   stopLavaTimer(%obj);
}

// ---------------------------------------------------------
// Timer
// ---------------------------------------------------------

function startLavaTimer(%obj)
{
   lavaUpdate(%obj);
}

function lavaUpdate(%obj)
{
   cancel(%obj.lavaUpdate);
   
   if (!isObject(%obj))
      return;   
      
   if (isObject(%obj.lavaSmoke))
      %obj.lavaSmoke.delete();
		
   if (!$Core::PhysicsDisabled)
	   %obj.lavaTime++;
	
	PG_LavaTime.setValue((100 - (%obj.lavaTime * 100 / ($Lava::SurviveTime / 100))) / 100);
	
	if (%obj.lavaTime > $Lava::SurviveTime / 100)
	{
	   info("Lava Death");
		stopLavaTimer();
		$LavaDeath = true;
		$Core::PhysicsDisabled = true;
		findRealMarble().setScale("0 0 0");
		
		%obj.playAudio(0, LavaHissSfx);
		
		if (LocalClientConnection.player.getID() == %obj.getID()) LocalClientConnection.onOutOfBounds();
		
		%explosion = new ParticleEmitterNode()
		{
			position = %obj.position;
			rotation = %obj.rotation;
			scale = %obj.scale;
			dataBlock = LandMineEmitterNode;
			emitter = LandMineEmitter;
		};
		MissionCleanup.add(%explosion);
		
		%explosion.schedule(100, delete);
		return;
	}
      
   if (getRandom(0, 2) == 0)
   {
      // Set the transform of the particle emitter to the same as that of the marble
      %transform = %obj.getTransform();
      
      // Add Particles
      %lavaSmoke = new ParticleEmitterNode()
      {
         position = "10000 50000 23980";
         rotation = "1 0 0 0";
         scale = "1 1 1";
         dataBlock = LavaSmokeEmitterNode;
         emitter = LavaSmokeEmitter;
      };
      
      MissionCleanup.add(%lavaSmoke);
      %obj.lavaSmoke = %lavaSmoke;
      
      %obj.lavaSmoke.setTransform(%transform);
   
   }
   
   %obj.lavaUpdate = schedule($Lava::UpdateDelay, 0, "lavaUpdate", %obj);
}

function stopLavaTimer(%obj)
{
   cancel(%obj.lavaUpdate);
   
   // Remove Particles
   if (isObject(%obj.lavaSmoke))
      %obj.lavaSmoke.delete();
}
