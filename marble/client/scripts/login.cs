function LoginGui::onWake(%this)
{
   LoginUsernameEdit.setText($pref::Multiplayer::Name); 
   LoginPasswordEdit.setText($pref::Login::Password);
   
   LoginUsernameLabel.setText("Username:");
   LoginPasswordLabel.setText("Password:");
   
   LoginRememberText.setText("Remember");
   
   Login_Status.setText("Logging In...");
   
   //$pref::Multiplayer::isMultiplayer = 0;
   PMSetMissionTab("beginner");
   
   setLoginEnabled(true);  
}

function setLoginEnabled(%enabled)
{
   LoginForm.setVisible(%enabled);
   Login_RegisterBtn.setVisible(%enabled);
   Login_LoginBtn.setVisible(%enabled);
   LoginRememberBox.setVisible(%enabled);
   Login_BackBtn.setVisible(%enabled);
   Login_Status.setVisible(!%enabled);
   Login_CancelBtn.setVisible(!%enabled);
}

function doLogin()
{
   setLoginEnabled(false);   
   
   if (isObject(LoginConnection))
      LoginConnection.delete();
   new HTTPObject(LoginConnection);
   
   //LoginConnection.get("marbleblastsuper.tk:80", "/game/login.php", "login=" @ $Login::Username @ "===" @ $Login::Password);
   onLogin();
}

function cancelLogin()
{
   if (isObject(LoginConnection))
      LoginConnection.delete();
      
   setLoginEnabled(true);
}

function LoginConnection::onLine(%this, %line)
{
   cancel(%this.deletionSchedule);
   
   echo (%line);
   switch$(%line)
   {
      case "LOGIN::USERNAME":
         MessageBoxOK("Error", "User not found!", "");
      case "LOGIN::PASSWORD":
         MessageBoxOK("Error", "Incorrect Password!", "");
      case "LOGIN::SUCCESS":
         onLogin();
   }
   setLoginEnabled(true);
   %this.deletionSchedule = %this.schedule(0, delete);
}

function onLogin()
{
   if ($pref::Login::RememberPassword)
      $pref::Login::Password = $Login::Password;
   else
      $pref::Login::Password = "";
   
   $Login::Password = "";
   $pref::Multiplayer::Name = strlwr($Login::Username);
   $Login::Username = "";
   Canvas.setContent(MultiplayerGui);
}