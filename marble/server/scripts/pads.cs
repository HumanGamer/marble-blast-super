//-----------------------------------------------------------------------------
// Torque Game Engine
// 
// Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------


//-----------------------------------------------------------------------------

datablock StaticShapeData(StartPad)
{
   className = "Pad";
   category = "Pads";
   shapeFile = "~/data/shapes/pads/startArea.dts";
   scopeAlways = true;
   emap = false;
};

function StartPad::onAdd(%this, %obj)
{
   $Game::StartPad = %obj;
   %obj.setName("StartPoint");
   //%obj.playThread(0,"ambient");
}


//-----------------------------------------------------------------------------

datablock StaticShapeData(EndPad)
{
   className = "Pad";
   category = "Pads";
   shapeFile = "~/data/shapes/pads/endArea.dts";
   scopeAlways = true;
   emap = false;
};

function EndPad::onAdd(%this, %obj)
{
   $Game::EndPad = %obj;
   %obj.setName("EndPoint");
   %obj.playThread(0,"ambient");
   
   %position = %obj.getPosition();  
   %rotation = %obj.rotation;  
   %scale = %obj.getScale();    
         
   %shape = new StaticShape()
   {
      datablock = "PadBeam";
      position = %position;
      rotation = %rotation;
      scale = %scale;
   };
   
   %obj.beam = %shape;
   %obj.beam.setSkinName("base");
   
   if (isObject(MissionCleanup))
      MissionCleanup.add(%shape);
      
   %this.setRadar(%obj);
}

function EndPad::setRadar(%this, %obj)
{
   if (ClientGroup.getCount() <= 0)
   {
      %this.schedule(250, "setRadar", %obj);
      return;
   }
   if (MissionInfo.gameMode !$= "hunt")
   {
      %position = %obj.getPosition();   
      %x = getWord(%position, 0);
      %y = getWord(%position, 1);
      commandToAll('UpdateRadarObject', %obj.getId(), "pad", %x, %y);
   }
}

