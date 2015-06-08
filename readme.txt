Marble Blast Super
Distributed by Greenbolt Studios
(C) 2012-2015
--------------------------------------------------

Thank you for playing Marble Blast Super.

Contents
--------

The MBS Team
Overview
Controls
About the Torque Game Engine
Problems and Questions

The MBS Team
--------

Stewart Inglis		StewMan46
Tristan Voss		Ender
David Luo		davidjl123
Matthieu Parizeau	cooldudepoke
Erik Martin		Neon Lightning
Greg McFadden		Skail
James Colsey		BlastedMarble
Chris Schroeppel	Rozi
Lee Zi Xian		LZX

Overview
--------

Roll your marble through a rich landscape of moving 
platforms and dangerous hazards.  Along the way find power ups 
to increase your speed, jumping ability or flight power, and 
use them to collect the hidden gems and race to the finish for 
the fastest time.

Controls
--------

All controls can be changed in the Options screen.

Roll Marble Forward - W
Roll Marble Backward - S
Roll Marble Left - A
Roll Marble Right - D

Jump - Space Bar
Use PowerUp - Left Mouse Button

Change Camera direction - Move Mouse - or

Look Up - Up Arrow
Look Down - Down Arrow
Turn Left - Left Arrow
Turn Right - Right Arrow

Free-Look Camera - Right Mouse Button

You can turn free look on by default from the 
Options->Controls->Mouse screen.

About the Torque Game Engine
----------------------------

The Torque Game Engine (TGE) is a full featured AAA title 
engine with the latest in scripting, geometry, particle effects, 
animation and texturing, as well as award winning multi-player 
networking code.  For $100 per programmer, you get the source to 
the engine that powers Marble Blast, Orbz, Sierra's Tribes 2, 
and many other titles currently in development.

Problems and Questions
----------------------

Listed below are some common questions and troubleshooting issues,
as well as possible solutions or workarounds:

Problem: How do I use my Logitech WingMan RumblePad controller with Marble Blast?

Solution: Bring up the console by hitting ~ (tilde) and type: 
enableJoystick(); followed by <ENTER>.  You can hide the console by 
hitting ~ again.  To disable the gamepad support bring up the console 
and type disableJoystick();

Problem: I don't have a WingMan, but I do have gamepad XYZ... will that
work?

Solution: Quite possibly!  Your gamepad must have two analog sticks - and
the controls for jumping and using powerups are by default mapped to 
the trigger buttons.  If you're a scripting whiz, you can look in
the file ~/marble/client/scripts/default.bind.cs
                           
Problem: The game brings up a dialog saying it can't find a 
compatible display device.

Solution: Make sure the drivers for you graphics card are up to
date.  Marble Blast requires an OpenGL or D3D compatible graphics accelerator.

Problem: I turned on stencil shadows, and my frame rate is
terrible!

Solution: Make sure your desktop bit depth is set to 32 bits.
If your frame rate problems persist, turn off stencil shadows.

Problem: I get clicks and pops in the sounds when the marble is 
rolling around.

Solution: Some on-board sound processors have problems with 
Marble Blast.  Try updating your audio drivers or get a new 
sound card.

Problem: I have a really big/wide monitor and Marble Blast doesn't
let me access all the different resolution settings of my monitor!!!

Solution: You can manually set your fullscreen resolution from the
in-game console.  Press the tilde key (~) to access the console, and
then type: 
listResolutions();
This should display a list of all the resolutions your monitor and
video card support.  You can then set the resolution manually with
the setResolution() command like:
setResolution(1600, 1200, 32);
Pressing the ~ again will cause the console to go away.

Problem: Your easy listening music is cramping my marble style...
how do I play my own rockin' tunes in this game?

Solution: Marble Blast looks for files with the .ogg extension
in subdirectories of the "~/marble" 
directory.  To play your own tunes, just drop any ogg/vorbis encoded file (.ogg)
into the "~/marble" directory.  
If you don't want to listen to any music while playing, you can turn off music
in the Options menu.

Problem: The Super Time on this level is way too low!  It is clearly
impossible to get such a low time!

Solution: Try again.  All of the super times are possible to achieve
without cheating... but some of them are VERY hard to get.

Problem: I have some other problem not listed above.

Solution: Check out the Marble Blast Super website at: 
http://www.mbsuper.tk

Readme file by RealNetworks, edited by Greenbolt Studios
