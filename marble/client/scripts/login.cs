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
   schedule(0, 0, "LoginConnection.delete();");
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