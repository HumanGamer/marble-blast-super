//-----------------------------------------------------
// Glass Structures
//-----------------------------------------------------

datablock StaticShapeData(Glass1)
{
   className = "Structure";
	category = "Structures";
	shapeFile = "~/data/shapes/structures/glass.dts";
	emap = false;
};

//-----------------------------------------------------
// Mechanical
//-----------------------------------------------------

datablock StaticShapeData(LightBulb)
{
   className = "LightBulb";
   category = "decorations";
   shapeFile = "~/data/shapes/decorations/lightbulb.dts";
   emap = false;
};

//-----------------------------------------------------
// Nature
//-----------------------------------------------------

datablock StaticShapeData(Tree)
{
   className = "Tree";
   category = "decorations";
   shapeFile = "~/data/shapes/environment/tree.dts";
   emap = false;
};

datablock StaticShapeData(Flower)
{
   className = "Flower";
   category = "decorations";
   shapeFile = "~/data/shapes/environment/flower.dts";
   emap = false;
};

function Flower::onAdd(%this, %obj)
{
	if (%obj.skin !$= "")
	{
		%obj.setSkinName(%obj.skin);
	}
}

datablock StaticShapeData(TallGrass)
{
   className = "TallGrass";
   category = "decorations";
   shapeFile = "~/data/shapes/environment/tallgrass.dts";
   emap = false;
};
