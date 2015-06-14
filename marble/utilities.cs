function c()
{
   if (!isObject(LocalClientConnection))
      return "";
   return LocalClientConnection;
}

function p()
{
   if (!isObject(LocalClientConnection))
      return "";
   return LocalClientConnection.getControlObject();
}
