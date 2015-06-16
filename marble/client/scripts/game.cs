//-----------------------------------------------------------------------------
// Torque Game Engine
// 
// Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

//----------------------------------------------------------------------------
// Game start / end events sent from the server
//----------------------------------------------------------------------------

function clientCmdGameStart()
{
}

function getBestTimes(%mis)
{
   for(%i = 0; %i < 3; %i++)
   {
      $hs[%i] = $pref::highScores[%mis, %i];
      if($hs[%i] $= "")
      {
         if(MissionInfo.time)
            $hs[%i] = MissionInfo.time @ "\tMBS";
         else
            $hs[%i] = "5998999\tMBS";
      }
   }
}

function clientCmdGameEnd()
{
   if($playingDemo)
      return;
   
   finishRecording();
   
   if ($Client::ConnectedMultiplayer)
   {
      Canvas.pushDialog(MultiplayerEndGui);  
      
      //checkAchievements();    
      
      return;
   }

   getBestTimes($Server::MissionFile);
   $highScoreIndex = "";
   for(%i = 0; %i < 3; %i++)
   {
      if($Game::ScoreTime < getField($hs[%i], 0))
      {
         for(%j = 2; %j > %i; %j--)
         {
            $hs[%j] = $hs[%j - 1];
         }
         $highScoreIndex = %i;
         $hs[%i] = $Game::ScoreTime @ "\t" @ $pref::highScoreName;
         break;
      }
   }
   reformatGameEndText();
   Canvas.pushDialog(EndGameGui);
   
   if($highScoreIndex !$= "")
   {
      if($highScoreIndex == 0)
         %msgIn = "";
      else if($highScoreIndex == 1)
         %msgIn = " 2nd";
      else
         %msgIn = " 3rd";
      EnterNameText.setText("<just:center><font:Xirod:25>Congratulations!\n<font:Arial:22>You got your" @ %msgIn @ " best personal time!");
      Canvas.pushDialog(EnterNameDlg);
      EnterNameEdit.setSelectionRange(0, 100000);
   }
   
   //if ($Game::Qualified)
   //   $Dynamic::Achievement::ParTime = true;
   //checkAchievements();
}

function highScoreNameAccept()
{
   Canvas.popDialog(EnterNameDlg);
   for(%i = 0; %i < 3; %i++)
      $pref::highScores[$Server::MissionFile, %i] = $hs[%i];
}

function highScoreNameChanged()
{
   $hs[$highScoreIndex] = $Game::ScoreTime @ "\t" @ $pref::highScoreName;
   reformatGameEndText();
}

function reformatGameEndText()
{
   // Final Score
   %text = 
      "<shadow:1:1><tab:240,250>" @
      "<font:Whitestone:39><color:ffff00>Final Time:\t<color:fff090>" @
      formatTime($Game::ScoreTime) @ "<color:000000><font:Whitestone:28>\n<just:center>";

   // Qualification time
   if($Game::Qualified)
   {
      %text = %text @ "<color:fdfdfd>";
      if (MissionInfo.hyperTime && $Game::ScoreTime < MissionInfo.hyperTime)
      {
         %text = %text @ "You beat the <color:834396>Hyper<color:fdfdfd> time!";
      } else if (MissionInfo.goldTime && $Game::ScoreTime < MissionInfo.goldTime)
      {
         %text = %text @ "You beat the <color:17e299>Super<color:fdfdfd> time!";
      } else {
         %text = %text @ "You have completed the level!";
      }
   }
   else
      %text = %text @ "<color:ff0000>You failed to qualify!";

   // Basic time info
   %text = %text @
      "\n<just:left><font:Whitestone:14>\n<lmargin:65><tab:235,245><shadowcolor:ffffff7f><shadow:1:1>";
   if (MissionInfo.time)
      %text = %text @
         "<color:ff0000>" @
         "<font:Whitestone:28>Spare Time:\t" @
         ($Game::Qualified? "<shadowcolor:ffffff7f><color:AAAAAA>": "<shadowcolor:0000007f><color:ff0000>") @
         formatTime(MissionInfo.time) @ "\n";
   else
      %text = %text @ "<color:22a9bb><font:Whitestone:28>Spare Time:\t\t99:59.99\n";

   if(MissionInfo.goldTime)
   {
      %text = %text @ "<shadowcolor:ffffff7f><color:05ff91><font:Whitestone:28>Super Time:\t<color:05ff91><shadowcolor:0000007f>" @
         formatTime(MissionInfo.goldTime) @ "\n";
   }
   
   if(MissionInfo.hyperTime)
   {
      %text = %text @ "<shadowcolor:ffffff7f><color:834396><font:Whitestone:28>Hyper Time:\t<color:834396><shadowcolor:0000007f>" @
         formatTime(MissionInfo.hyperTime) @ "\n";
   }

   %text = %text @
      "<shadowcolor:ffffff7f><color:AAAAAA>" @
      "<font:Whitestone:28>Elapsed Time:\t" @ formatTime($Game::ElapsedTime)  @ "\n" @
      "<font:Whitestone:28>Bonus Time:\t" @ formatTime($Game::BonusTime) @ "\n";
   %text = %text @ "<font:Whitestone:14>\n<font:Whitestone:32><color:EEEEEE>Best Times:\n";
   for(%i = 0; %i < 3; %i++)
   {
      %time = getField($hs[%i], 0);
      %name = getField($hs[%i], 1);
      %text = %text 
         @ "<shadowcolor:ffffff7f><color:AAAAAA><font:Whitestone:24>" @ %i+1 @ ". " @ %name @ "\t";
      if (%time < MissionInfo.hyperTime)
      {
         %text = %text @ "<shadowcolor:0000007f><color:834396>";
      } else if (%time < MissionInfo.goldTime)
      {
         %text = %text @ "<shadowcolor:0000007f><color:05ff91>";
      }
      
      %text = %text @ formatTime(%time) @ "\n";
   }
   // Display the end-game screen
   EndGameGuiDescription.setText(%text);
}


//-----------------------------------------------------------------------------

function formatTime(%time)
{
   %isNeg = "\t";
   if (%time < 0)
   {
      %time = -%time;
      %isNeg = "-\t";
   }
   %hundredth = mFloor((%time % 1000) / 10);
   %totalSeconds = mFloor(%time / 1000);
   %seconds = %totalSeconds % 60;
   %minutes = (%totalSeconds - %seconds) / 60;

   %secondsOne   = %seconds % 10;
   %secondsTen   = (%seconds - %secondsOne) / 10;
   %minutesOne   = %minutes % 10;
   %minutesTen   = (%minutes - %minutesOne) / 10;
   %hundredthOne = %hundredth % 10; 
   %hundredthTen = (%hundredth - %hundredthOne) / 10;

   return %isNeg @ %minutesTen @ %minutesOne @ ":" @
       %secondsTen @ %secondsOne @ "." @
       %hundredthTen @ %hundredthOne;
}

function clientCmdSetBlastEnergy(%energy, %max, %extra)
{
   $Client::BlastEnergy = %energy;
   PG_BlastBar.setValue(%energy / %max);
   if (%extra) {
      PG_BlastBar.profile = "GuiBlastExtraProfile";
   } else if (%energy < 1000)
   {
      PG_BlastBar.profile = "GuiBlastProfile";
   } else {
      PG_BlastBar.profile = "GuiBlastUsableProfile";
   }
}

function clientCmdHideWater()
{
   PG_Water.setVisible(false);
}

function clientCmdHidePhysMod()
{
   PG_PhysMod.setVisible(false);
}
