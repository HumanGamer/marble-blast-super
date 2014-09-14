function startRecordingDemo(%mission)
{
   RecordingDlg.show("$Recording::File", "doRecordingDemo($Recording::File, " @ %mission @ ");", "What would you like to name your recording?");
}

function doRecordingDemo(%file, %mission)
{
   $isDemoRecording = true;
   $currentInfoFile = "marble/client/demos/" @ %file @ ".inf";
   $currentDemoFile = "marble/client/demos/" @ %file @ ".rec";
   $Recording::Desc = "Test Description";
   $Recording::Mission = %mission.file;
   recordDemo("marble/client/demos/" @ %file @ ".rec", %mission.file);
   startServer("SinglePlayer", %mission);
}

function finishRecording()
{
   if ($isDemoRecording)
   {
      createDemoInfo();
      $isDemoRecording = false;
   }
}

function createDemoInfo()
{
   %inf = $currentInfoFile;
	%file = new FileObject();

	if ( %file.openForWrite( %inf ) ) {
		%file.writeLine("//--- OBJECT WRITE BEGIN ---");
		%file.writeLine("new SimGroup(DemoGroup) {");
		%file.writeLine("\tnew ScriptObject(DemoInfo) {");
		%file.writeLine("\t\tname = \"" @ $Recording::File @ "\";");
		%file.writeLine("\t\tdesc = \"" @ $Recording::Desc @ "\";");
		%file.writeLine("\t\tmission = \"" @ $Recording::Mission @ "\";");
		%file.writeLine("\t\tartist = \"" @ $pref::Multiplayer::Name @ "\";");
		%file.writeLine("\t\tblastCount = \"" @ $BlastCount @ "\";");
		for (%i = 0; %i < $BlastCount; %i++)
		{
		   %file.writeLine("\t\tblastTime[" @ %i @ "] = \"" @ $BlastTime[%i] @ "\";");
		}
		%file.writeLine("\t};");
		%file.writeLine("};");
		%file.writeLine("//--- OBJECT WRITE END ---");
   }
		
   %file.close();
   %file.delete();
   
   addDemo($currentDemoFile);
}