$Client::BackgroundFileSpec1 = "*/backgrounds/*.png";
$Client::BackgroundFileSpec2 = "*/backgrounds/*.jpg";

function getRandomBackground()
{
   if (!$Client::BackgroundListBuilt)
      buildBackgroundList();
   return getBackground(getRandom(0, BackgroundGroup.getCount() - 1));
}

function getBackground(%index)
{
   return BackgroundGroup.getObject(%index).file;
}

function buildBackgroundList()
{
   echo("Building List of Backgrounds!");
   $Client::BackgroundListBuilt = true;
   if (!isObject(BackgroundGroup))
   {
      new SimGroup(BackgroundGroup);
      RootGroup.add(BackgroundGroup);
   }
   BackgroundGroup.clear();
   
   for (%file = findFirstFile($Client::BackgroundFileSpec1);
         %file !$= ""; %file = findNextFile($Client::BackgroundFileSpec1))
   {
      if (strStr(%file, "CVS/") == -1 && strStr(%file, "common/") == -1)
      {
         getBackgroundObject(%file);
      }
   }
   
   for (%file = findFirstFile($Client::BackgroundFileSpec2);
         %file !$= ""; %file = findNextFile($Client::BackgroundFileSpec2))
   {
      if (strStr(%file, "CVS/") == -1 && strStr(%file, "common/") == -1)
      {
         getBackgroundObject(%file);
      }
   }
}

function getBackgroundObject(%background)
{
   echo("Adding Background: " @ %background);
   %bgObject = new ScriptObject(){
      file = %background;
   };
   BackgroundGroup.add(%bgObject);
}