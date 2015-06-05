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
   emap = true;
   
   pickupName = "an EasterEgg!";
   noRespawn = true;
};

function EasterEggItem::onPickup(%this, %obj, %user, %amount)
{
   Parent::onPickup(%this,%obj,%user,%amount);
   
   //if (MissionInfo.type $= "custom" || MissionInfo.type $= "multiplayer")
   //{
   //   %found = false;
   //} else {
      %found = $pref::EasterEgg[$Server::MissionFile];
      $pref::EasterEgg[$Server::MissionFile] = "1";
      //eval("%found = $pref::EasterEgg[" @ $Server::MissionFile @ "];");// @ MissionInfo.type @ "[" @ MissionInfo.level @ "];");   
   
      //eval("$pref::EasterEgg[" @ $Server::MissionFile @ "] = \"1\";");// @ MissionInfo.type @ "[" @ MissionInfo.level @ "] = \"1\";"); 
   //}
   
   if (%found)
      %user.client.play2d(EasterEggAlreadySfx);
   else
      %user.client.play2d(EasterEggVoiceSfx);
}