//---------------------------------------------------------------
// Marble Blast Super
// marble/server/scripts/gameConnection.cs
// (C) 2013 Matthieu Parizeau
//---------------------------------------------------------------

function GameConnection::resetTimer(%this)
{
   commandToClient(%this, 'ResetTimer');
}

function GameConnection::setMessage(%this, %msg, %timer)
{
   commandToClient(%this, 'SetMessage', %msg, %timer);
}

function GameConnection::setGemCount(%this, %count)
{
   commandToClient(%this, 'SetGemCount', %count);
}

function GameConnection::setMaxGems(%this, %max)
{
   commandToClient(%this, 'SetMaxGems', %max);
}

function GameConnection::setQuotaGems(%this, %quota)
{
   commandToClient(%this, 'SetQuotaGems', %quota);
}

function GameConnection::addHelpLine(%this, %msg, %bool)
{
   commandToClient(%this, 'AddHelpLine', %msg, %bool);
}

function GameConnection::startTimer(%this)
{
   commandToClient(%this, 'StartTimer');
}

function GameConnection::stopTimer(%this)
{
   commandToClient(%this, 'StopTimer');
}

function GameConnection::setGravityDir(%this, %dir, %bool)
{
   commandToClient(%this, 'SetGravityDir', %dir, %bool);
}

function GameConnection::mountImage(%this, %image, %slot, %time)
{
   if (%image $= "")
      return;
   %this.player.mountImage(%image, %slot);
   %this.player.schedule(%time, unmountImage, %slot);
}

function GameConnection::setPowerUp(%this, %shapeFile)
{
   commandToClient(%this, 'SetPowerUp', %shapeFile);
}

function GameConnection::setTime(%this, %time)
{
   commandToClient(%this, 'SetTime', %time);
}

function GameConnection::getSkin(%this)
{
   return %this.skin;
}

function GameConnection::cameraLookAtPoint(%this, %x, %y)
{
   %object = %this.player;
   cancel($CameraLookSched);
   if (!isObject(%object))
   {
      $CameraLookSched = %this.schedule(250, cameraLookAtPoint, %x, %y);
      return;
   }
   %center = %object.getTransform();
   %centerX = getWord(%center, 0);
   %centerY = getWord(%center, 1);
   
   %dx = %x - %centerX;
   %dy = %y - %centerY;

   %angle = mAtan(%dx, %dy);
   
   //<marble>.setPosition("x y z r0 r1 r2 r3", pitch); <<<Thanks HiGuy>>>
   %transform = getWords(%center, 0, 2) SPC "0 0 1" SPC %angle;
   %object.setPosition(%transform, 0.45);
}

function GameConnection::getHuntSpawnPos(%this, %transform)
{
	%group = nameToID("MissionGroup/SpawnPoints");
   if (!isObject(%group))
      return;
	
	if (%transform $= "")
	{
	
		%num = getRandom(%group.getCount() - 1);

		%spawn = %group.getObject(%num);
		
		return vectorAdd(%spawn.getTransform(),"0 0 3") SPC
							  getWords(%spawn.getTransform(), 3);
						  
	} else {
		for (%i = 0; %i < %group.getCount(); %i++)
		{
			%obj = %group.getObject(%i);
			
			%trans = %obj.getTransform();
			
			%distance = vectorDist(%trans, %transform);
			
			if (%distance < %closestDist || %closestDist == 0)
			{
				%closestDist = %distance;
				%closestObj = %obj;
			}
		}
		
		return vectorAdd(%closestObj.getTransform(),"0 0 3") SPC
							  getWords(%closestObj.getTransform(), 3);
	}
}

function GameConnection::applyImpulse(%this, %impulseVec, %impulse)
{
   commandToClient(%this, 'ApplyImpulse', %impulseVec, %impulse);
}

function VectorMult(%vector, %mult)
{
   if (getWordCount(%mult) > 1)
   {
      return getWord(%vector, 0) * getWord(%mult, 0) SPC getWord(%vector, 1) * getWord(%mult, 1) SPC getWord(%vector, 2) * getWord(%mult, 2);
   } else {
      return getWord(%vector, 0) * %mult SPC getWord(%vector, 1) * %mult SPC getWord(%vector, 2) * %mult;
   }
}

function minValue(%val1, %val2, %val3, %val4, %val5, %val6, %val7, %val8, %val9)
{
   %min = %val1;
   if (%val2 < %min && %val2 !$= "")
      %min = %val2;
   if (%val3 < %min && %val3 !$= "")
      %min = %val3;
   if (%val4 < %min && %val4 !$= "")
      %min = %val4;
   if (%val5 < %min && %val5 !$= "")
      %min = %val5;
   if (%val6 < %min && %val6 !$= "")
      %min = %val6;
   if (%val7 < %min && %val7 !$= "")
      %min = %val7;
   if (%val8 < %min && %val8 !$= "")
      %min = %val8;
   if (%val9 < %min && %val9 !$= "")
      %min = %val9;
   return %min;
}