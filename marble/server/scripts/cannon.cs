datablock StaticShapeData(Cannon)
{
   category = "Hazards";
   
   shapeFile = "marble/data/shapes/hazards/cannon.dts";
   
   scopeAlways = true;
   emap = false;
};

//function Cannon::onAdd(%this, %obj)
//{
   //%head = new StaticShape()
   //{
      //datablock = "CannonHead";
      //position = %obj.position;
      //rotation = %obj.rotation;
      //scale = %obj.scale;
   //};
   //
   //%obj.head = %head;
   //
   //if (!isObject(MissionCleanup))
      //$InstantGroup = new SimGroup(MissionCleanup);
   //MissionCleanup.add(%head);
//}

function Cannon::aim(%this, %obj)
{
   if (!isObject(%obj))
      return;
   %target = %obj.target;
   %power = %obj.power;
   
   if (%obj.radius $= "")
      %obj.radius = 15;
   
   if (%target $= "")
      %target = findClosestPlayer(%obj.getPosition(), %obj.radius);
      
   if (!isObject(%target))
   {
      %obj.targetPosition = "";
      return;
   }
      
   if (%power $= "")
      %obj.power = 25;
      
   %position = %obj.getPosition();
      
   %targetPos = %target.getPosition();
   %obj.targetPosition = %targetPos;
}

function Cannon::shoot(%this, %obj)
{  
   if (%obj.targetPosition $= "")
      return;
   if (!isObject(%obj))
      return;
   if (isObject(%obj.ball))
      %obj.ball.delete();
   %cannonball = new StaticShape()
   {
      datablock = "CannonBall";
      position = %obj.position;
      rotation = %obj.rotation;
      scale = %obj.scale;
      target = %obj.targetPosition;
      power = %obj.power;
   };
   
   %obj.ball = %cannonball;
   if (!isObject(CannonBalls))
      new SimGroup(CannonBalls);
   CannonBalls.add(%cannonball);
}

function updateCannons()
{
   if (!isObject(MissionGroup))
      return;
   updateCannonBalls();
   for (%i = 0; %i < MissionGroup.getCount(); %i++)
   {
      %obj = MissionGroup.getObject(%i);
      
      if (%obj.getClassName() $= "StaticShape" && %obj.getDatablock().getName() $= "Cannon")
      {
         if (%obj.timer $= "")
            %obj.timer = "3000";
      
         if (%obj.currentTime $= "")
               %obj.currentTime = 0;          
         
         %obj.currentTime += $Game::UpdateInterval;
         
         if (%obj.currentTime >= %obj.timer)
         {
            %obj.currentTime = 0;
            
            Cannon.aim(%obj);
            Cannon.shoot(%obj);
         }
      }
   }
}

//datablock StaticShapeData(CannonHead)
//{
   //shapeFile = "marble/data/shapes/hazards/cannon-head.dts";
   //
   //scopeAlways = true;
   //emap = false;
//};

datablock StaticShapeData(CannonBall)
{
   shapeFile = "marble/data/shapes/hazards/cannon-ball.dts";
   
   scopeAlways = true;
   emap = false;
};

function CannonBall::update(%this, %obj)
{
   if (!isObject(%obj))
      return;
    %position = %obj.getPosition();
      
   %targetPos = %obj.target;
   
   %power = %obj.power / 100;
   
   %src = VectorSub(%position, %targetPos);
   
   %impulse = VectorScale(%src, %power * -1);
   
   %obj.setTransform(VectorAdd(%position, %impulse));
   
   %dist = VectorDist(%obj.getPosition(), %obj.target);
   
   if (%dist <= 1)
      %this.explode(%obj);
      //%obj.schedule(250, "delete");
}

function CannonBall::explode(%this, %obj, %player)
{
   //%player.setOOB(true);   
   
   %explosion = new Explosion()
   {
      datablock = "LandMineFakeExplosion";
      position = %obj.position;
      rotation = %obj.rotation;
      scale = %obj.scale;
   };
   
   %obj.delete();
   
   if (!isObject(CannonBalls))
      new SimGroup(CannonBalls);
   CannonBalls.add(%explosion);
}

function updateCannonBalls()
{
   if (!isObject(CannonBalls))
      return;
   for (%i = 0; %i < CannonBalls.getCount(); %i++)
   {
      %obj = CannonBalls.getObject(%i);
      
      //if (%obj.getClassName() $= "StaticShape" && %obj.getDatablock().getName() $= "Cannon")
      if (%obj.getClassName() $= "StaticShape" && %obj.getDatablock().getName() $= "CannonBall")
      {
         //if (isObject(%obj.ball)
         //{   
            CannonBall.update(%obj);
         //}
      }
   }
}