//function GuiEditorGui::init(%this)
//{
   //GuiEditorMenuBar.clearMenus();
   //GuiEditorMenuBar.addMenu("File", 0);
   //GuiEditorMenuBar.addMenuItem("File", "New Gui...", 1);
   //GuiEditorMenuBar.addMenuItem("File", "Save Gui...", 3, "Ctrl S");
//
   //GuiEditorMenuBar.addMenu("Edit", 1);
   //GuiEditorMenuBar.addMenuItem("Edit", "Undo", 1, "Ctrl Z");
   //GuiEditorMenuBar.setMenuItemBitmap("Edit", "Undo", 1);
   //GuiEditorMenuBar.addMenuItem("Edit", "Redo", 2, "Ctrl R");
   //GuiEditorMenuBar.setMenuItemBitmap("Edit", "Redo", 2);
   //GuiEditorMenuBar.addMenuItem("Edit", "-", 0);
   //GuiEditorMenuBar.addMenuItem("Edit", "Cut", 3, "Ctrl X");
   //GuiEditorMenuBar.setMenuItemBitmap("Edit", "Cut", 3);
   //GuiEditorMenuBar.addMenuItem("Edit", "Copy", 4, "Ctrl C");
   //GuiEditorMenuBar.setMenuItemBitmap("Edit", "Copy", 4);
   //GuiEditorMenuBar.addMenuItem("Edit", "Paste", 5, "Ctrl V");
   //GuiEditorMenuBar.setMenuItemBitmap("Edit", "Paste", 5);
   //GuiEditorMenuBar.addMenuItem("Edit", "-", 0);
   //GuiEditorMenuBar.addMenuItem("Edit", "Select All", 6, "Ctrl A");
   //GuiEditorMenuBar.addMenuItem("Edit", "Select None", 7, "Ctrl N");
   //GuiEditorMenuBar.addMenuItem("Edit", "-", 0);
   //GuiEditorMenuBar.addMenuItem("Edit", "Gui Editor Settings...", 12);
//}

function GuiEditorGui::onWake(%this)
{
   GuiEditorGui.init();
   
   exec("./GuiNewGuiDlg.gui");
}

function GuiEditorMenuBar::onMenuItemSelect(%this, %menuId, %menu, %itemId, %item)
{
   switch$(%menu)
   {
      case "File":
         %this.onFileMenuItemSelect(%itemId, %item);
      case "Edit":
         %this.onEditMenuItemSelect(%itemId, %item);
   }
}

function GuiEditorMenuBar::onFileMenuItemSelect(%this, %itemId, %item)
{
   switch$(%item)
   {
      case "New Gui...":
         GuiEditorStartCreate();
      case "Save Gui...":
         GuiEditorSaveGui();
   }
}

function GuiEditorMenuBar::onEditMenuItemSelect(%this, %itemId, %item)
{
   if(%item $= "Gui Editor Settings...")
      Canvas.pushDialog(GuiEditorSettingsDlg);
   // edit commands for world editor...
   switch$(%item)
   {
      case "Undo":
         GuiEditorGui.undo();
      case "Redo":
         GuiEditorGui.redo();
      case "Copy":
         GuiEditorGui.copySelection();
      case "Cut":
         GuiEditorGui.copySelection();
         GuiEditorGui.deleteSelection();
      case "Paste":
         GuiEditorGui.pasteSelection();
      case "Select All":
      case "Select None":
   }
}


//----------------------------------------
function GuiEditorStartCreate()
{
   NewGuiDialogClass.setText("GuiControl");
   NewGuiDialogClass.sort();
   NewGuiDialogName.setValue("NewGui");
   Canvas.pushDialog(NewGuiDialog);
}

//----------------------------------------
function GuiEditorCreate()
{
   %name = NewGuiDialogName.getValue();
   %class = NewGuiDialogClass.getText();
   Canvas.popDialog(NewGuiDialog);
   %obj = eval("return new " @ %class @ "(" @ %name @ ");");
   GuiEditorOpen(%obj);
}

//----------------------------------------
function GuiEditorSaveGui()
{
   %obj = GuiEditorContent.getObject(0);
   if(%obj == -1 || %obj.getName() $= "")
      return;
   %name = %obj.getName() @ ".gui";
   getSaveFilename("*.gui", "GuiEditorSaveGuiCallback", %name);
}

function GuiEditorSaveGuiCallback(%name)
{
   %obj = GuiEditorContent.getObject(0);
   
   // make sure it is saved...
   if(!%obj.save(%name))
   {
      MessageBoxOK("GuiEditor Save Failure", "Failed to save '" @ %name @ "'. The file may be read-only.");
   }
}   

//----------------------------------------
function GuiEdit(%val)
{
   if(%val != 0 || !$testCheats)
      return;
      
   %content = Canvas.getContent();
   
   if(%content == GuiEditorGui.getId())
   {
      //GlobalActionMap.bind(mouse, button1, mouselook);

      %obj = GuiEditorContent.getObject(0);
      if(%obj != -1)
      {
         GuiGroup.add(%obj);
         Canvas.setContent(%obj);
      }
      
      GlobalActionMap.unbind( keyboard, "delete" );
   }
   else
   {
      //GlobalActionMap.unbind(mouse, button1);
      GuiEditorOpen(%content);
   }
}

package GuiEditor_BlockDialogs
{

function GuiCanvas::pushDialog()
{

}

function GuiCanvas::popDialog()
{

}

};

//----------------------------------------
function GuiEditorOpen(%content)
{
   Canvas.setContent(GuiEditorGui);
   while((%obj = GuiEditorContent.getObject(0)) != -1)
      GuiGroup.add(%obj); // get rid of anything being edited

   %i = 0;
   GuiEditorContentList.clear();
   while((%obj = GuiGroup.getObject(%i)) != -1)
   {
      if(%obj.getName() !$= Canvas)
      {
         if(%obj.getName() $= "")
            %name = "(unnamed) - " @ %obj;
         else
            %name = %obj.getName() @ " - " @ %obj;

         GuiEditorContentList.add(%name, %obj);
      }
      %i++;
   }
   activatePackage(GuiEditor_BlockDialogs);
   GuiEditorContent.add(%content);
   deactivatePackage(GuiEditor_BlockDialogs);
   GuiEditorContentList.sort();
   GuiEditorClassPopup.sort();
   if(%content.getName() $= "")
      %name = "(unnamed) - " @ %content;
   else
      %name = %content.getName() @ " - " @ %content;
   
   GuiEditorContentList.setText(%name);
   GuiEditorClassPopup.setText("New Control");
   GuiEditor.setRoot(%content);
   %content.resize(0,0,"640","480");
   GuiEditorTreeView.open(%content);

}

//----------------------------------------
function GuiEditorContentList::onSelect(%this, %id)
{
   GuiEditorOpen(%id);
}

//----------------------------------------
function GuiEditorClassPopup::onSelect(%this, %id)
{
   %class = %this.getText();
   %obj = eval("return new " @ %class @ "();");
   GuiEditor.addNewCtrl(%obj);
   GuiEditorClassPopup.setText("New Control");
}

//----------------------------------------
function GuiEditorTreeView::onSelect(%this, %obj, %rightMouse)
{
   if(%rightMouse)
      GuiEditor.setCurrentAddSet(%obj);
   else
   {
      GuiEditorInspectFields.inspect(%obj);
      GuiEditorInspectName.setValue(%obj.getName());
      GuiEditor.select(%obj);
   }
}

//----------------------------------------
function GuiEditorInspectApply()
{
   GuiEditorInspectFields.apply(GuiEditorInspectName.getValue());
}

//----------------------------------------
function GuiEditor::onSelect(%this, %ctrl)
{
   
   GuiEditorInspectFields.inspect(%ctrl);
   GuiEditorInspectName.setValue(%ctrl.getName());
   GuiEditor.select(%ctrl);
}

//----------------------------------------
function GuiEditorDeleteSelected( %val ) {
   if( %val )
      GuiEditor.deleteSelection();
}      

GlobalActionMap.bind(keyboard, "f10", GuiEdit);
