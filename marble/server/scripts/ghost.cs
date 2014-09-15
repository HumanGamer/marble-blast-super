//---------------------------------------------------------------
// MarbleBlast Multiplayer Mod
// marble/server/scripts/ghost.cs
// (C) 2013 Matthieu Parizeau
//---------------------------------------------------------------

//---------------------------------------------------------------
//Init Datablocks
//---------------------------------------------------------------

datablock StaticShapeData(GhostMarble)
{
   shapeFile = "~/data/shapes/balls/ghostMarble.dts";
};

datablock StaticShapeData(GhostMegaMarble)
{
   shapeFile = "~/data/shapes/balls/megamarbleghost.dts";
};

datablock StaticShapeData(GhostMiniMarble)
{
   shapeFile = "~/data/shapes/balls/miniMarbleGhost.dts";
};

//---------------------------------------------------------------
// Functions, they run the game! :D
//---------------------------------------------------------------

function GameConnection::createGhost(%this)
{
   %scale = %this.player.scale; 
   %position = %this.player.position;
   %rotation = %this.player.rotation;
   
   %ghost = new StaticShape()
   {
      dataBlock = GhostMarble;
      client = %this;
      scale = %scale;
      position = %position;
      rotation = %rotation;
   };
   
   if (isObject(MissionCleanup))
      MissionCleanup.add(%ghost);
   
   %this.ghost = %ghost;
   
   echo("Created Ghost Marble");
}