function LoginGui::onWake(%this)
{
   LoginUsernameLabel.setText("Username:");
   LoginPasswordLabel.setText("Password:");
}

function doLogin()
{
   if (isObject(LoginConnection))
      LoginConnection.delete();
   new HTTPObject(LoginConnection);
   
   LoginConnection.get("marbleblastsuper.tk:80", "/game/login.php", "login=" @ $Login::Username @ "===" @ $Login::Password);
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
   %this.deletionSchedule = %this.schedule(0, delete);
}

function onLogin()
{
   
   $Login::Password = "";
   $pref::Multiplayer::Name = $Login::Username;
   $Login::Username = "";
   Canvas.setContent(MultiplayerGui);
}

function register()
{
   warn("Register is not yet implemented...");
}