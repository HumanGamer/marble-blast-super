//-----------------------------------------------------
// Glass Structures
//-----------------------------------------------------

datablock StaticShapeData(Glass1)
{
   className = "Structure";
	category = "Structures";
	shapeFile = "~/data/shapes/structures/glass1.dts";
	emap = false;
};

datablock StaticShapeData(Glass2)
{
   className = "Structure";
	category = "Structures";
	shapeFile = "~/data/shapes/structures/glass2.dts";
	emap = false;
};

datablock StaticShapeData(Glass3)
{
   className = "Structure";
	category = "Structures";
	shapeFile = "~/data/shapes/structures/glass3.dts";
	emap = false;
};

datablock StaticShapeData(Glass_Floor)
{
   className = "Structure";
	category = "Structures";
	shapeFile = "~/data/shapes/structures/glass_floor.dts";
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
