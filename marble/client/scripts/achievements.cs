function initAchievements()
{
   // Par Time
   $Const::Achievements[0] = new ScriptObject() {
      name = "Timely Player";
      desc = "Complete any level under par time!";
      img = "timely";
   };
   // Easter Egg
   $Const::Achievements[1] = new ScriptObject() {
      name = "Egg Seeker";
      desc = "Collect any Easter Egg!";
      img = "egg";
   };
   // Side Scrolling
   $Const::Achievements[2] = new ScriptObject() {
      name = "Retro Dude";
      desc = "Complete any side scrolling level!";
      img = "retro";
   };
   // 1st Level Complete
   $Const::Achievements[3] = new ScriptObject() {
      name = "Just Started";
      desc = "Finish any level";
      img = "1stlevel";
   };
   // 5 Levels Complete
   $Const::Achievements[4] = new ScriptObject() {
      name = "5 Down!";
      desc = "Finish any 5 levels";
      img = "5thlevel";
   };
   // 10 Levels Complete
   $Const::Achievements[5] = new ScriptObject() {
      name = "10 Levels!";
      desc = "Finish any 10 levels";
      img = "10thlevel";
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
   
   if ($Dynamic::Achievement::SideScrolling && !hasAchievement(2))
   {
      awardAchievement(2);
   }
   
   if ($Dynamic::Achievement::BeatAnyLevel && !hasAchievement(3))
   {
      awardAchievement(3);
   }
   
   if ($Dynamic::Achievement::BeatAny5Levels && !hasAchievement(4))
   {
      awardAchievement(4);
   }
   
   if ($Dynamic::Achievement::BeatAny10Levels && !hasAchievement(5))
   {
      awardAchievement(5);
   }   
}

function awardAchievement(%id)
{
   notifyAchievement(%id);
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

   %iconFile = "marble/client/ui/achievements/achievement_" @ %ach.img;
   if (!isFile(%iconFile @ ".png") && !isFile(%iconFile @ ".jpg"))
      AP_AchievementIcon.setBitmap("marble/client/ui/achievements/achievement_placeholder");  
   else
      AP_AchievementIcon.setBitmap("marble/client/ui/achievements/achievement_" @ %ach.img);
   
   %name = "<spush><font:Whitestone:28><color:333333><shadowcolor:000000><shadow:1:1>" @ %ach.name @ "<spop>\n\n";
   %desc = "<spush><font:Whitestone:24><color:FFFFFF><shadowcolor:000000><shadow:1:1>" @ %ach.desc @ "<spop>";
   AP_AchievementBodyText.setText(%name @ %desc);
   AP_AchievementHeadText.setText("<spush><font:Whitestone:32><color:FFFFFF><shadowcolor:AAAAAA><shadow:1:1><just:center>New Achievement!<spop>");
}

function notifyAchievement(%id)
{
   addTask("showAchievementPopup(" @ %id @ ");");
}

function showAchievementPopup(%id)
{
   AchievementPopupDlg.achievement = %id;
   Canvas.pushDialog(AchievementPopupDlg);
   schedule(2500, 0, "hideAchievementPopup");
}

function hideAchievementPopup()
{
	$Tasks::Achievement = schedule(500, 0, nextTask);
   Canvas.popDialog(AchievementPopupDlg);
}

initAchievements();
