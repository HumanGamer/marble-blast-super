// ---------------------------------------------------------
// ------------------------ Water Mod ----------------------
// ---------------------------------------------------------
// ------------- marble/server/scripts/water.cs ------------
// ---------------------------------------------------------
// ---------------------------------------------------------
// -------------------- Matthieu Parizeau ------------------
// ---------------------------------------------------------
// ---------------------------------------------------------

// ---------------------------------------------------------
// Global Variables
// ---------------------------------------------------------

$Water::UpdateDelay = 100;

// ---------------------------------------------------------
// Particles
// ---------------------------------------------------------

datablock ParticleData(BubbleParticle)
{
   textureName = "~/data/particles/bubble";
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
   
   colors[0] = "0.9 0.9 0.9 1.0";
   colors[1] = "0.75 0.75 0.75 1.0";
   colors[2] = "0.5 0.5 0.9 0.5";
   
   sizes[0] = 0.5;
   sizes[1] = 0.25;
   sizes[2] = 0.125;
   
   times[0] = 0.0;
   times[1] = 0.75;
   times[2] = 1.0;
};

datablock ParticleEmitterData(BubbleEmitter)
{
   ejectionPeriodMS = 80;
   periodVariance = 0;
   ejectionVelocity = 3.0;
   velocityVariance = 0.25;
   thetaMin = 0.0;
   thetaMax = 90.0;
   particles = "BubbleParticle";
};

datablock ParticleEmitterNodeData(BubbleEmitterNode)
{
   timeMultiple = 1;
};

// ---------------------------------------------------------
// Shapes
// ---------------------------------------------------------

datablock StaticShapeData(WaterShape)
{
   category = "Water";
   className = "Water";
   shapeFile = "~/data/shapes/water/water.dts";
   scopeAlways = true;
   
};

// ---------------------------------------------------------
// Triggers
// ---------------------------------------------------------

datablock TriggerData(WaterTrigger)
{
   tickPeriodMS = 100;
};

function WaterTrigger::onEnterTrigger(%this, %trigger, %obj)
{
   %obj.inWater = true;
   %obj.getDataBlock().gravity = "5";
   
   PG_Water.setVisible(true);
   
   // Start Timer
   startWaterTimer(%obj);
}

function WaterTrigger::onLeaveTrigger(%this, %trigger, %obj)
{
   %obj.inWater = false;
   %obj.getDataBlock().gravity = "20";
   
   PG_Water.setVisible(false);
   
   // Stop Timer
   stopWaterTimer(%obj);
}

// ---------------------------------------------------------
// Timer
// ---------------------------------------------------------

function startWaterTimer(%obj)
{
   waterUpdate(%obj);
}

function waterUpdate(%obj)
{
   cancel(%obj.waterUpdate);
   
   if (!isObject(%obj))
      return;   
      
   if (isObject(%obj.bubbles))
      %obj.bubbles.delete();
      
   if (getRandom(0, 2) == 0)
   {
      // Set the transform of the particle emitter to the same as that of the marble
      %transform = %obj.getTransform();
      
      // Add Particles
      %bubbles = new ParticleEmitterNode()
      {
         position = "10000 50000 23980";
         rotation = "1 0 0 0";
         scale = "1 1 1";
         dataBlock = BubbleEmitterNode;
         emitter = BubbleEmitter;
      };
      
      MissionCleanup.add(%bubbles);
      %obj.bubbles = %bubbles;
      
      %obj.bubbles.setTransform(%transform);
   
   }
   
   %obj.waterUpdate = schedule($Water::UpdateDelay, 0, "waterUpdate", %obj);
}

function stopWaterTimer(%obj)
{
   cancel(%obj.waterUpdate);
   
   // Remove Particles
   if (isObject(%obj.bubbles))
      %obj.bubbles.delete();
}
