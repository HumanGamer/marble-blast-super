function GemPopUpGui::showPopup(%this, %points, %lost)
{
   cancel(%this.animSchedule);
   cancel(%this.hideSchedule);   
   
   %res = getRes();   
   
   GemPopUpContainer.position = getWord(%res, 0) / 2 SPC getWord(%res, 1) / 2;
   
   Canvas.pushDialog(GemPopUpGui);
   
   %icon = "+";   
   
   if (%lost)
      %icon = "-";

   %color = %this.getColor(%points, %lost);
      
   GemPopUpText.setText(%color @ %icon @ %points);
   GemPopUpText_Shadow.setText(%icon @ %points);
   
   %this.animSchedule = %this.schedule(100, animatePopup);
   
   %this.hideSchedule = %this.schedule(1000, hidePopup);
}

function GemPopUpGui::hidePopup(%this)
{
   cancel(%this.animSchedule);
   Canvas.popDialog(GemPopUpGui);
}

function GemPopUpGui::animatePopup(%this)
{
   cancel(%this.animSchedule);
   %pos = GemPopUpContainer.position;
   GemPopUpContainer.position = getWord(%pos, 0) SPC getWord(%pos, 1) - 5;
   //%pos = GemPopUpText_Shadow.position;
   //GemPopUpText_Shadow.position = getWord(%pos, 0) SPC getWord(%pos, 1) - 3;
   
   %this.animSchedule = %this.schedule(100, animatePopup);
}

function GemPopUpGui::getColor(%this, %points, %lost)
{
   switch$(%points)
   {
      case 1:
         return "<color:ff0000>";
      case 2:
         return "<color:ffff00>";
      case 5:
         return "<color:0000ff>";
      case 7:
         return "<color:00ff00>";
   }
}