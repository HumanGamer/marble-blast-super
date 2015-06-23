datablock AudioProfile(EasterEggVoiceSfx)
{
   filename    = "~/data/sound/puEasterEggVoice.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(EasterEggAlreadySfx)
{
   filename    = "~/data/sound/puEasterEggAlready.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock ItemData(EasterEggItem)
{
   category = "Items";
   
   shapeFile = "marble/data/shapes/items/easteregg.dts";
	emap = false;
   
   pickupName = "an EasterEgg!";
   noRespawn = true;
};

function EasterEggItem::onPickup(%this, %obj, %user, %amount)
{
   Parent::onPickup(%this,%obj,%user,%amount);
   
   %found = $pref::EasterEgg[$Server::MissionFile];
   $pref::EasterEgg[$Server::MissionFile] = "1";
   
   $Dynamic::Achievement::FoundEasterEgg = true;
   checkAchievements();
   
   if (%found)
      %user.client.play2d(EasterEggAlreadySfx);
   else
      %user.client.play2d(EasterEggVoiceSfx);
}