$NumHelpPages = 12;

function HelpCreditsGui::onWake(%this)
{
   %this.bitmap = getRandomBackground();
   $CurHelpPage = 1;
   %this.setPage($CurHelpPage);
   
   HC_List.clear();
   HC_List.addRow(0, "Overview");
   HC_List.addRow(1, "Basic Controls");
   HC_List.addRow(2, "Camera Controls");
   HC_List.addRow(3, "Goals");
   HC_List.addRow(4, "PowerUps (Part 1/2)");
   HC_List.addRow(5, "PowerUps (Part 2/2)");
   HC_List.addRow(6, "Hazards (Part 1/3)");
   HC_List.addRow(7, "Hazards (Part 2/3)");
   HC_List.addRow(8, "Hazards (Part 3/3)");
   HC_List.addRow(9, "Environment");
   HC_List.addRow(10, "About GarageGames");
   HC_List.addRow(11, "About Torque");
   HC_List.addRow(12, "Special Thanks");
   
   HC_List.setSelectedByID(0);
}

function HC_List::onSelect(%this, %index)
{
   HelpCreditsGui.setPage(%index + 1);
}

function HelpCreditsGui::setPage(%this, %page)
{
   HC_StartPad.setVisible(false);
   HC_EndPad.setVisible(false);
   HC_Gem1.setVisible(false);
   HC_Gem2.setVisible(false);
   HC_Gem3.setVisible(false);
   HC_SuperSpeed.setVisible(false);
   HC_SuperJump.setVisible(false);
   HC_ShockAbsorber.setVisible(false);
   HC_AntiGravity.setVisible(false);
   HC_Helicopter.setVisible(false);
   HC_TimeTravel.setVisible(false);
   HC_DuctFan.setVisible(false);
   HC_Tornado.setVisible(false);
   HC_Trapdoor.setVisible(false);
   HC_Oilslick.setVisible(false);
   HC_Landmine.setVisible(false);
   HC_Bumper.setVisible(false);
   HC_SuperBounce.setVisible(false);
   HC_Cannon.setvisible(false);
   HC_Bomb.setvisible(false);
   HC_RotatingPlatform.setvisible(false);
   HC_HidingPlatform.setVisible(false);
   HC_Water.setVisible(false);
   
  

   switch(%page)
   {
      case 1:
         %text = "<font:Whitestone:50><color:000000><just:center>Overview<font:EntangledMBS:24><just:left>\n\n" @
              "Marble Blast Super is a modification of the classic platformer game - Marble Blast Gold. There are new levels, features, and graphics. There are hazards you must avoid on your trip to the finish.";
      case 2:
         %text = "<font:Whitestone:50><color:000000><just:center>Basic Controls<font:EntangledMBS:24><just:left>\n\n" @
                 "The marble can be moved forward, back, left and right by pressing <func:bind moveforward>, <func:bind movebackward>, <func:bind moveleft> and <func:bind moveright>, respectively.  Pressing <func:bind jump> causes the marble to jump, and pressing <func:bind mouseFire> uses whatever powerup you currently have available.  All movement is relative to the view direction.";
      case 3:
         %text = "<font:Whitestone:50><color:000000><just:center>Camera Controls<font:EntangledMBS:24><just:left>\n\n" @
                 "The camera direction can be changed by moving the mouse or by pressing <func:bind panUp>, <func:bind panDown>, <func:bind turnLeft> or <func:bind turnRight>.  In order to look up and down freely with the mouse, hold down <func:bind freelook>.  You can turn free look on always from the Mouse pane of the Control Options screen.";
      case 4:
         %text = "<font:Whitestone:50><color:000000><just:center>Goals<font:EntangledMBS:24><just:left>\n\n" @
                 "<lmargin:70>Start Pad - this is where you start the level.\n\nEnd Pad - roll your marble here to end the level.\n\nGems - if a level has gems, you must pick them all up before you can exit.";
         HC_StartPad.setVisible(true);
         HC_EndPad.setVisible(true);
         HC_Gem1.setVisible(true);
         HC_Gem2.setVisible(true);
         HC_Gem3.setVisible(true);

      case 5:
         %text = "<font:Whitestone:50><color:000000><just:center>PowerUps (Part 1/2)<font:EntangledMBS:24>\n\n<just:left>" @
                 "<lmargin:70>SuperJump PowerUp - gives you a burst of speed.\n\nSuperSpring PowerUp - gives you a big jump up.\n\nShockAbsorber PowerUp - absorbs bounce impacts.\n\nSuperBounce PowerUp - makes you bounce higher.";
         HC_SuperSpeed.setVisible(true);
         HC_SuperJump.setVisible(true);
         HC_ShockAbsorber.setVisible(true);
         HC_SuperBounce.setVisible(true);
      case 6:
         %text = "<font:Whitestone:50><color:000000><just:center>PowerUps (Part 2/2)<font:EntangledMBS:24><just:left>\n\n" @
                 "<lmargin:70>Gyrocopter PowerUp - slows your fall in the air.\n\nTimeTravel - takes some time off the clock.\n\nGravityChanger - Changes the direction of \"down\" - the new down is in the direction of the arrow.";
         HC_AntiGravity.setVisible(true);
         HC_Helicopter.setVisible(true);
         HC_TimeTravel.setVisible(true);
      case 7:
         %text = "<font:Whitestone:50><color:000000><just:center>Hazards (Part 1/3)<font:EntangledMBS:24><just:left>\n\n" @
                 "<lmargin:70>Duct Fan - be careful this doesn't blow you away!\n\nTornado - it'll pull you in and spit you out.\n\nTrap Door - keep moving when you're rolling over one of these.";
         HC_DuctFan.setVisible(true);
         HC_Tornado.setVisible(true);
         HC_Trapdoor.setVisible(true);
      case 8:
         %text = "<font:Whitestone:50><color:000000><just:center>Hazards (Part 2/3)<font:EntangledMBS:24><just:left>\n\n" @
                 "<lmargin:70>Bumper - this'll bounce you if you touch it.\n\nLand Mine - Warning!  Explodes on contact!\n\nOil Slick - you won't have much traction on these surfaces.\n\nPlatform - can be anything. They can collapse or even explode.";
         HC_Bumper.setVisible(true);
         HC_Landmine.setVisible(true);
         HC_Oilslick.setVisible(true);
		 HC_HidingPlatform.setVisible(true);
		case 9: %text = "<font:Whitestone:50><color:000000><just:center>Hazards (Part 3/3)<font:EntangledMBS:24><just:left>\n\n" @
                 "<lmargin:70>Cannon - shoots cannon balls that blow you off the map.\n\nBomb - Can be triggered in unexpected ways..\n\nRotating Platform - time to get dizzy!";
         HC_Cannon.setVisible(true);
         HC_Bomb.setVisible(true);
         HC_RotatingPlatform.setvisible(true);
		case 10: %text = "<font:Whitestone:50><color:000000><just:center>Environment<font:EntangledMBS:24><just:left>\n\n" @
                 "<lmargin:70>Water - Slows you down and you can swim in it, just like real life water!";
         HC_Water.setVisible(true);
      case 11:
         %text = "<font:Whitestone:50><color:000000><just:center>About GarageGames<font:EntangledMBS:24><just:left>\n\n" @
                 "GarageGames is a unique Internet publishing label for independent games and gamemakers.  Our mission is to provide the independent developer with tools, knowledge, co-conspirators - whatever is needed to unleash the creative spirit and get great innovative independent games to market.";
      case 12:
        %text = "<font:Whitestone:50><color:000000><just:center>About Torque<font:EntangledMBS:24><just:left>\n\n" @
                "The Torque Game Engine (TGE) is a full featured AAA title engine with the latest in scripting, geometry, particle effects, animation and texturing, as well as award winning multi-player networking code.  For $100 per programmer, you get the source to the engine!";
      case 13:
         %text = "<font:Whitestone:50><color:000000><just:center>Special Thanks<font:EntangledMBS:24><just:left>\n\n" @
            "We'd like to thank the Marble Blast Community, for their advice, " @
            "and everyone, including the team itself, who has helped make Marble Blast Super happen."  @
            " And finally, thanks to GarageGames and Monster Studios which created Marble Blast Gold, the game MBS is modded on.";

   }
   HC_Text.setText(%text);
}

function HelpNext()
{
   $CurHelpPage++;
   if($CurHelpPage > $NumHelpPages)
      $CurHelpPage = 1;
   HelpCreditsGui.setPage($CurHelpPage);
}

function HelpPrev()
{
   $CurHelpPage--;
   if($CurHelpPage < 1)
      $CurHelpPage = $NumHelpPages;
   HelpCreditsGui.setPage($CurHelpPage);
}