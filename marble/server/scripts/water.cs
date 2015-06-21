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
// Audio + Particles
// ---------------------------------------------------------

datablock AudioProfile(SplashSfx)
{
   filename    = "~/data/sound/splash.wav";
   description = Audio2D;
   preload = true;
};

datablock AudioProfile(Splash2Sfx)
{
   filename    = "~/data/sound/splash2.wav";
   description = Audio2D;
   preload = true;
};

datablock AudioProfile(UnderwaterSfx)
{
   filename    = "~/data/sound/underwater.wav";
   description = AudioLooping2D;
   preload = true;
};

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

datablock ParticleData(WaterSplash) {
   textureName          = "~/data/particles/smoke";
   dragCoefficient      = 1;
   gravityCoefficient   = 1;
   inheritedVelFactor   = 0;
   windCoefficient      = 0;
   constantAcceleration = 0;
   lifetimeMS           = 2000;
   lifetimeVarianceMS   = 200;
   spinSpeed     = 0;
   spinRandomMin = -90.0;
   spinRandomMax =  90.0;
   useInvAlpha   = true;

   colors[0]     = "0.8 0.9 1 1";
   colors[1]     = "0.8 0.9 1 0.5";
   colors[2]     = "0.8 0.9 1 0.0";

   sizes[0]      = 0.3;
   sizes[1]      = 0.3;
   sizes[2]      = 0.3;

   times[0]      = 0.0;
   times[1]      = 0.2;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(WaterSplashEmitter) {
   ejectionPeriodMS = 4;
   periodVarianceMS = 0;
   ejectionVelocity = 5;
   velocityVariance = 0.2;
   ejectionOffset   = 0.75;
   thetaMin         = 0;
   thetaMax         = 30;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   //overrideAdvances = false;
   //orientParticles  = true;
   lifetimeMS       = 0;
   particles = "WaterSplash";
};

datablock ParticleEmitterNodeData(WaterSplashEmitterNode)
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
   shapeFile = "~/data/shapes/liquid/liquid.dts";
   scopeAlways = true;
   skin = "Water";
	emap = false;
};

function WaterShape::onAdd(%this, %obj)
{
   if (%this.skin !$= "")
      %obj.setSkinName(%this.skin);
}

// ---------------------------------------------------------
// Triggers
// ---------------------------------------------------------

datablock TriggerData(WaterTrigger)
{
   tickPeriodMS = 100;
};

//function WaterTrigger::onAdd(%this, %obj)
//{
   //if (!isObject(WaterGroup))
   //   new SimSet(WaterGroup);
   //WaterGroup.add(%obj);
//}

function WaterTrigger::onEnterTrigger(%this, %trigger, %obj)
{
   if (!%obj.inWater) {
      // SPLASH!
	  %nor = getGravityDir();
	  %proj = VectorProj($marbleVelocity,%nor);
	  %rej = VectorRej($marbleVelocity,%nor);
	  %rejlen = VectorLen(%rej);
	  %var = -1.75+1.25*mPow(2,-%rejlen/20);
	  info("Entering Water:");
	  info("---------------------------------");
     info("Velocity: " @ $MarbleVelocity);
	  info("Gravity: " @ %nor);
	  info("Proj: " @ %proj);
	  info("Rej: " @ %rej);
	  info("Rejlen: " @ %rejlen);
	  info("Final:" @ %var);
	  info("---------------------------------");
	  findRealMarble().applyVelocity("0 0 0",VectorScale(%proj,%var));
	  %emit = new ParticleEmitterNode() {
		  position = VectorSub(%obj.position,"0 0 1");
		  rotation = "1 0 0 0";
		  scale = "1 1 1";
		  dataBlock = "WaterSplashEmitterNode";
		  emitter = "WaterSplashEmitter";
		  velocity = VectorLen(%proj);
      };
      %emit.schedule(50,"delete");
	  %obj.client.play2d(SplashSfx);
	  findRealMarble().getDataBlock().gravity /= 4;
	  PG_Water.setVisible(true);
	  $isUnderwater = true;
   }
   %obj.inWater++;
   
   // Start Timer
   startWaterTimer(%obj);
}

function WaterTrigger::onLeaveTrigger(%this, %trigger, %obj)
{
   %obj.inWater--;
   if (%obj.inWater) return;
   %obj.client.play2d(Splash2Sfx);
   findRealMarble().getDataBlock().gravity *= 4;
   
   PG_Water.setVisible(false);
   $isUnderwater = false;
   
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

//function onUnload() {
//	PG_Water.setVisible(0);
//}

function updateWaterEffects() {
   if (!isObject(LocalClientConnection) || !isObject(LocalClientConnection.getControlObject()))
   {
      alxStop($waterHandle);
		$waterHandle = "";
      return;
   }
	//$showWater = false;
	//if (!isObject(WaterGroup))
	//   new SimSet(WaterGroup);
	//for (%i = 0; %i < WaterGroup.getCount(); %i++)
	//{
	   //%waterObj = WaterGroup.getObject(%i);
	   //$showWater = $showWater || //isInMyWorldBox(%waterObj);
	//}
	////withAll("WaterTrigger","$showWater = $showWater || isInMyWorldBox(%this);");
	//PG_Water.setVisible($showWater);
	if ($isUnderwater && $waterHandle $= "" && LocalClientConnection.getControlObject() $= LocalClientConnection.player) {
		$waterHandle = alxPlay(UnderwaterSfx);
	}
	else if ((!$isUnderwater && $waterHandle !$= "") || LocalClientConnection.getControlObject() !$= LocalClientConnection.player) {
		alxStop($waterHandle);
		$waterHandle = "";
	}
}

$waterHandle = "";

function isInMyWorldBox(%this) {
	%box = %this.getWorldBox();
	%tr = getCameraTransform();
	%inx = getWord(%box,0) <= getWord(%tr,0) && getWord(%tr,0) <= getWord(%box,3);
	%iny = getWord(%box,1) <= getWord(%tr,1) && getWord(%tr,1) <= getWord(%box,4);
	%inz = getWord(%box,2) <= getWord(%tr,2) && getWord(%tr,2) <= getWord(%box,5);
	return %inx && %iny && %inz;
}

package WaterUpdate {
	function onFrameAdvance(%timeDelta)
	{
		Parent::onFrameAdvance(%timeDelta);
		
		//if ($showDelta)
		//{
		//	// SPAM THE CONSOLE LIKE MAD
		//	echo("DELTA: " @ %timeDelta);
		//}
		
		updateWaterEffects();
	}
};

activatePackage(WaterUpdate);

// project u onto v
function VectorProj(%u,%v) {
   return VectorScale(%v,VectorDot(%u,%v)/VectorDot(%v,%v));
}

// reject u from v (i.e. component of u perpendicular to v)
function VectorRej(%u,%v) {
   return VectorSub(%u,VectorProj(%u,%v));
}

function findRealMarble() {
   if (!isObject(ServerConnection)) return "";
   if (!isObject(LocalClientConnection.player)) return "";
   if (LocalClientConnection.getControlObject() == LocalClientConnection.player && isObject(ServerConnection.getControlObject())) return ServerConnection.getControlObject();
   //Iterate through all objects in client-side server connection
   for (%i = 0; %i < ServerConnection.getCount(); %i ++) {
      //Get the object from the iteration
      %obj = ServerConnection.getObject(%i);
      //Check for ID. The marble ID will *always* be higher.
      //Analysis shaped by using tree();
      //tree(); is one of those hidden-but-useful functions
      if (%obj.getId() < LocalClientConnection.player.getId())
         continue;
      //If it's a marble, then we're good!
      //This is *guaranteed* to be the client-side marble, 100%
      //of the time, if you are playing single player
      if (%obj.getClassName() $= "Marble") {
         return %obj;
      }
   }
}

// gets the transform matrix of the camera (assumes default gravity)
function getCameraTransform() {
   if (!isObject(LocalClientConnection)) return;
   if (!isObject(LocalClientConnection.player)) return;
   %distanceTrans = "0" SPC -LocalClientConnection.player.getDatablock().cameraDistance SPC "0.28 1 0 0 0";
   %gravityTrans = "0 0 0" SPC RotationFromOrtho($gravityMatrix);
   %pitchTrans = "0 0 0 -1 0 0" SPC $marblePitch2;
   %yawTrans = "0 0 0 0 0 1" SPC $marbleYaw;
   %marbleTrans = LocalClientConnection.player.getPosition() SPC "1 0 0 0";
   %start = MatrixMultiply(%marbleTrans,MatrixMultiply(%yawTrans,MatrixMultiply(%pitchTrans,%gravityTrans)));
   %final = MatrixMultiply(%start,%distanceTrans);
	%ray = ContainerRayCast(%start, %final, (1 << 16) - 1);
	if (!%ray) return %final;
	return getWords(%ray, 1, 3) SPC getWords(%start, 3, 6);
}

// gets the rotation four-vector for an ortho matrix
function RotationFromOrtho(%ortho) {
   if (mSqrt(mPow(getWord(%ortho,7)-getWord(%ortho,5),2)+mPow(getWord(%ortho,2)-getWord(%ortho,6),2)+mPow(getWord(%ortho,3)-getWord(%ortho,1),2)) == 0) return "1 0 0 0";
   // Solve for rotation axis
   %rotX = (getWord(%ortho,7)-getWord(%ortho,5))/mSqrt(mPow(getWord(%ortho,7)-getWord(%ortho,5),2)+mPow(getWord(%ortho,2)-getWord(%ortho,6),2)+mPow(getWord(%ortho,3)-getWord(%ortho,1),2));
   %rotY = (getWord(%ortho,2)-getWord(%ortho,6))/mSqrt(mPow(getWord(%ortho,7)-getWord(%ortho,5),2)+mPow(getWord(%ortho,2)-getWord(%ortho,6),2)+mPow(getWord(%ortho,3)-getWord(%ortho,1),2));
   %rotZ = (getWord(%ortho,3)-getWord(%ortho,1))/mSqrt(mPow(getWord(%ortho,7)-getWord(%ortho,5),2)+mPow(getWord(%ortho,2)-getWord(%ortho,6),2)+mPow(getWord(%ortho,3)-getWord(%ortho,1),2));
   %rotA = mAcos((getWord(%ortho,0)+getWord(%ortho,4)+getWord(%ortho,8)-1)/2);
   return %rotX SPC %rotY SPC %rotZ SPC %rotA;
}


// For when mass shouldn't matter ...
function Marble::applyVelocity(%this,%pos,%vec) {
   Parent::applyImpulse(%this,%pos,VectorScale(%vec,%this.getDatablock().mass));
}