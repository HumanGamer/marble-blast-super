function findMusic()
{
   if(!$musicFound)
   {
      $NumMusicFiles = 0;
      for(%file = findFirstFile("*.ogg"); %file !$= ""; %file = findNextFile("*.ogg"))
      {
         if(fileBase(%file) !$= "Shell")
         {
            $Music[$NumMusicFiles] = fileBase(%file) @ ".ogg";
            $NumMusicFiles++;
         }
      }
      $musicFound = true;
   } 
}

function findAllMusic()
{
   findMusic();
   if(!$musicAllFound)
   {
      $NumMusicAllFiles = 0;
      for(%file = findFirstFile("*.ogg"); %file !$= ""; %file = findNextFile("*.ogg"))
      {
         $AllMusic[$NumMusicAllFiles] = fileBase(%file) @ ".ogg";
         $NumMusicAllFiles++;
      }
      $musicAllFound = true;
   } 
}

function JB_GenerateSongList()
{
   // Search for music
   findAllMusic();
   
   // Add songs to JukeBox
   if (!$JukeBoxPopulated)
   {
      // Remove SongList if it already exists
      if (isObject(SongList))
         SongList.delete();
         
      // Create SongList
      new SimSet(SongList);
      RootGroup.add(SongList);
      
      for (%i = 0; %i < $NumMusicAllFiles; %i++)
      {
         %obj = $AllMusic[%i];
         
         %song = new ScriptObject()
         {
            file = %obj;
            name = upperFirst(strreplace(%obj, ".ogg", ""));
            artist = "Pizza Guy (a.k.a. Unknown Artist...)";
            desc = "Pickles (a.k.a. No Description Yet...)";
         };
         SongList.add(%song);
         
         JB_SongList.addRow(%i, %song.name);
      }
      $JukeBoxPopulated = true;
   }
}

function getMusicId(%songName)
{
   for (%i = 0; %i < SongList.getCount(); %i++)
   {
      %song = SongList.getObject(%i);
      
      if (%song.name $= %songName)
         return %i;
   }
   return -1;
}

function JukeboxGui::onWake(%this)
{
   JB_GenerateSongList();
}

function JB_SongList::onSelect(%this, %index)
{
   %song = SongList.getObject(%index);   
   
   %name = "<spush><font:Whitestone:30>" @ %song.name @ "<spop>\n";
   
   %artist = "<spush><font:EntangledMBS:20>" @ %song.artist @ "<spop>\n\n";
   
   %desc = "<spush><font:EntangledMBS:14><lmargin:1>" @ %song.desc @ "<spop>";
   
   JB_Info.setText(%name @ %artist @ %desc);
}

function JB_Play()
{
   %index = JB_SongList.getSelectedId();
   //%song = JB_SongList.getRowTextById(%index);   
   %song = SongList.getObject(%index);   
   
   playMusic(%song.file);
}

function JB_Stop()
{
   stopMusic();
}

function JB_Next()
{
   %index = JB_SongList.getSelectedId() + 1;
   if (%index > SongList.getCount() - 1)
      %index = 0;
   JB_SongList.setSelectedRow(%index);
   JB_Play();
}

function JB_Prev()
{
   %index = JB_SongList.getSelectedId() - 1;
   if (%index < 0)
      %index = SongList.getCount() - 1;
   JB_SongList.setSelectedRow(%index);
   JB_Play();
}
