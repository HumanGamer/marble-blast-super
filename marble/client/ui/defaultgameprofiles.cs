//-----------------------------------------------------------------------------
// Torque Game Engine
// 
// Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Override base controls
GuiButtonProfile.soundButtonOver = AudioButtonOver;
GuiButtonProfile.soundButtonDown = AudioButtonDown;

GuiDefaultProfile.soundButtonDown = AudioButtonDown;

//-----------------------------------------------------------------------------
// Chat Hud profiles


new GuiControlProfile ("ChatHudMessageProfile")
{
   fontType = "Arial";
   fontSize = 16;
   fontColor = "255 255 0";      // default color (death msgs, scoring, inventory)
   fontColors[1] = "4 235 105";   // client join/drop, tournament mode
   fontColors[2] = "219 200 128"; // gameplay, admin/voting, pack/deployable
   fontColors[3] = "77 253 95";   // team chat, spam protection message, client tasks
   fontColors[4] = "40 231 240";  // global chat
   fontColors[5] = "200 200 50 200";  // used in single player game
   // WARNING! Colors 6-9 are reserved for name coloring 
   autoSizeWidth = true;
   autoSizeHeight = true;
};

new GuiControlProfile ("ChatHudScrollProfile")
{
   opaque = false;
   bitmap = "common/ui/darkScroll";
   hasBitmapArray = true;
};


new GuiControlProfile (GuiTPTextEditProfile)
{
   opaque = false;
   fillColor = "255 255 255";
   fillColorHL = "128 128 128";
   border = false;
   borderColor = "0 0 0";
   fontColor = "0 0 0";
   fontColorHL = "255 255 255";
   fontColorNA = "128 128 128";
   textOffset = "0 2";
   autoSizeWidth = false;
   autoSizeHeight = true;
   tab = true;
   canKeyFocus = true;
};

new GuiControlProfile (OverlayScreenProfile)
{
   opaque = true;
   fillColor = "0 0 0 96";
   fillColorHL = "128 128 128";
   border = false;
   borderColor = "0 0 0";
   fontColor = "0 0 0";
   fontColorHL = "255 255 255";
   fontColorNA = "128 128 128";
   textOffset = "0 2";
   autoSizeWidth = false;
   autoSizeHeight = true;
   tab = true;
   canKeyFocus = true;
};

new GuiControlProfile (GuiBigTextEditProfile)
{
   fontType = "DomCasualD";
   fontSize = 32;
   opaque = false;
   fillColor = "255 255 255";
   fillColorHL = "128 128 128";
   border = false;
   borderColor = "0 0 0";
   fontColor = "0 0 0";
   fontColorHL = "255 255 255";
   fontColorNA = "128 128 128";
   textOffset = "0 2";
   autoSizeWidth = false;
   autoSizeHeight = true;
   tab = true;
   canKeyFocus = true;
};

new GuiControlProfile (BevelPurpleProfile)
{
   // fill color
   opaque = true;
   border = 2;
   fillColor   = "161 150 229";
   fillColorHL = "255 0 0";
   fillColorNA = "0 0 255";

   // border color
   borderColor   = "0 255 0";
   borderColorNA = "92 86 131";

   textOffset = "6 6";

};



//-----------------------------------------------------------------------------
// Common Hud profiles

new GuiControlProfile ("HudScrollProfile")
{
   opaque = false;
   border = true;
   borderColor = "0 255 0";
   bitmap = "common/ui/darkScroll";
   hasBitmapArray = true;
};

new GuiControlProfile ("HudTextProfile")
{
   opaque = false;
   fillColor = "128 128 128";
   fontColor = "0 255 0";
   border = true;
   borderColor = "0 255 0";
};


//-----------------------------------------------------------------------------
// Center and bottom print

new GuiControlProfile ("CenterPrintProfile")
{
   opaque = false;
   fillColor = "128 128 128";
   fontColor = "0 255 0";
   border = true;
   borderColor = "0 255 0";
};

new GuiControlProfile ("CenterPrintTextProfile")
{
   opaque = false;
   fontType = "Arial";
   fontSize = 12;
   fontColor = "0 255 0";
};

if(!isObject(GuiPlayerListProfile)) new GuiControlProfile (GuiPlayerListProfile : GuiTextArrayProfile)
{
   fontType = "Whitestone";
   fontSize = 32;
   
   tab = false;
   canKeyFocus = false;
   
   fontColor = "100 235 100";//"235 235 235";
};

if(!isObject(GuiPlayerListShadowProfile)) new GuiControlProfile (GuiPlayerListShadowProfile : GuiPlayerListProfile)
{
   fontType = "Whitestone";
   fontSize = 32;
   
   tab = false;
   canKeyFocus = false;
   
   fontColor = "0 0 0";
};

if(!isObject(GuiGemPopUpTextProfile)) new GuiControlProfile (GuiGemPopUpTextProfile : GuiMLTextProfile)
{
   fontType = "Whitestone";
   fontSize = 36;
   
   tab = false;
   canKeyFocus = false;
   
   //fontColor = "235 235 235";
};

if(!isObject(GuiGemPopUpTextShadowProfile)) new GuiControlProfile (GuiGemPopUpTextShadowProfile : GuiGemPopUpTextProfile)
{
   fontType = "Whitestone";
   fontSize = 36;
   
   tab = false;
   canKeyFocus = false;
   
   fontColor = "0 0 0";
};

if(!isObject(GuiBlastProfile)) new GuiControlProfile ("GuiBlastProfile")
{
   opaque = false;
   fillColor = "44 44 44 100";
   border = true;
   borderColor   = "100 100 100";
};

if(!isObject(GuiBlastUsableProfile)) new GuiControlProfile ("GuiBlastUsableProfile")
{
   opaque = false;
   fillColor = "44 152 162 100";
   border = true;
   borderColor   = "100 100 100";
};

if(!isObject(GuiBlastExtraProfile)) new GuiControlProfile ("GuiBlastExtraProfile")
{
   opaque = false;
   fillColor = "120 120 0 200";
   border = true;
   borderColor   = "100 100 100";
};

if (!isObject(PlayMissionListProfile)) new GuiControlProfile(PlayMissionListProfile)
{
   fontType = "Whitestone";
   fontSize = 18;
   fillColorHL = "128 128 255";
   fontColor = "0 0 0";
   fontColorHL = "255 255 255";
   fontColorLink = "255 96 96";
   fontColorLinkHL = "0 0 255";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

if (!isObject(PlayMissionDifficultyPopupProfile)) new GuiControlProfile(PlayMissionDifficultyPopupProfile)
{
   opaque = true;
   //fillColor = "255 255 255";
   mouseOverSelected = true;

   border = 1;
   borderThickness = 1;
   borderColor = "0 128 0";
   fontType = "Whitestone";
   fontSize = 20;
   fontColor = "0 0 0";
   fontColorHL = "255 255 255";
   fontColorSEL = "255 255 255";
   fixedExtent = true;
   justify = "center";
   bitmap = "marble/client/ui/play/scroll";
   hasBitmapArray = true;
};

if (!isObject(PlayMissionScrollProfile)) new GuiControlProfile(PlayMissionScrollProfile)
{
   opaque = false;
   //fillColor = "255 255 255";
   border = 0;
   borderThickness = 0;
   borderColor = "0 128 0";
   bitmap = "marble/client/ui/play/scrollTransparent";
   hasBitmapArray = true;
};

if (!isObject(PlayMissionDifficultyScrollProfile)) new GuiControlProfile(PlayMissionDifficultyScrollProfile)
{
   opaque = false;
   //fillColor = "255 255 255";
   border = 0;
   borderThickness = 0;
   borderColor = "0 128 0";
   bitmap = "marble/client/ui/play/scrollTransparent";
   hasBitmapArray = true;
};

if (!isObject(PlayMissionDifficultyListProfile)) new GuiControlProfile(PlayMissionDifficultyListProfile)
{
   fontType = "Whitestone";
   fontSize = 18;
   fillColorHL = "128 128 255";
   fontColor = "0 0 0";
   fontColorHL = "255 255 255";
   fontColorLink = "255 96 96";
   fontColorLinkHL = "0 0 255";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

if (!isObject(GuiPMMission)) new GuiControlProfile(GuiPMMission)
{
   opaque = false;
   fillColor = "0 0 0";
   border = 1;
   borderThickness = 1;
   borderColor = "0 128 0";
};


if (!isObject(GuiPMSelectedMission)) new GuiControlProfile(GuiPMSelectedMission)
{
   opaque = true;
   fillColor = "128 128 255";
   border = 1;
   borderThickness = 1;
   borderColor = "0 128 0";
};

if (!isObject(GuiBigGameTextProfile)) new GuiControlProfile(GuiBigGameTextProfile : GuiBigTextProfile)
{
   fontType = "Animated";
};
