function initAchievements()
{
   // Par Time
   $Const::Achievements[0] = new ScriptObject() {
      name = "Timely Player";
      desc = "Complete any level under par time!";
   };
   // Easter Egg
   $Const::Achievements[1] = new ScriptObject() {
      name = "Egg Seeker";
      desc = "Collect any Easter Egg!";
   };
}

function checkAchievements()
{
   if ($Dynamic::Achievement::ParTime && !hasAchievement(0))
   {
      awardAchievement(0);
   }
   
   if ($Dynamic::Achievement::FoundEasterEgg && !hasAchievement(1))
   {
      awardAchievement(1);
   }
}

function awardAchievement(%id)
{
   showAchievementPopup(%id);
   $pref::Achievements[%id] = true;
}

function hasAchievement(%id)
{
   return $pref::Achievements[%id];
}

function AchievementPopupDlg::onWake(%this)
{
   %ach = $Const::Achievements[%this.achievement];
   
   AP_AchievementBodyText.setAlpha(0.5);
   AP_AchievementHeadText.setAlpha(0.5);
   
   %name = "<spush><font:Whitestone:28><color:333333><shadowcolor:000000><shadow:1:1>" @ %ach.name @ "<spop>\n\n";
   %desc = "<spush><font:Whitestone:24><color:FFFFFF><shadowcolor:000000><shadow:1:1>" @ %ach.desc @ "<spop>";
   AP_AchievementBodyText.setText(%name @ %desc);
   AP_AchievementHeadText.setText("<spush><font:Whitestone:32><color:FFFFFF><shadowcolor:AAAAAA><shadow:1:1><just:center>New Achievement!<spop>");
}

function showAchievementPopup(%id)
{
   AchievementPopupDlg.achievement = %id;
   Canvas.pushDialog(AchievementPopupDlg);
   schedule(2500, 0, "hideAchievementPopup");
}

function hideAchievementPopup()
{
   Canvas.popDialog(AchievementPopupDlg);
}

initAchievements();
