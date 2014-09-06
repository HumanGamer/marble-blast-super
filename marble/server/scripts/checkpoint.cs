datablock StaticShapeData(CheckPointShape)
{
   category = "Pads";
   //className = "CheckPointShape";
   shapeFile = "~/data/shapes/pads/checkpoint.dts";
};

function CheckPointShape::setActiveCheckPoint(%this, %obj, %flag)
{
   if (%flag)
   {
      %obj.setSkinName("active");
   } else {
      %obj.setSkinName("base");
   }
}

datablock TriggerData(CheckPointTrigger)
{
   category = "Pads";
   //className = "CheckPointTrigger";
   tickPeriodMS = 100;
};

function CheckPointTrigger::onEnterTrigger(%this, %trigger, %obj)
{
   %target = %trigger.target;
   %obj.client.setCheckPoint(%target);
}