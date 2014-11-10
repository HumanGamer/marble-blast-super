// All Euler - AxisAngle conversion functions created by Jeff Hutchinson

// http://www.euclideanspace.com/maths/geometry/rotations/conversions/eulerToAngle/
function eulerToAA(%pitch, %roll, %yaw)
{
   %c1 = mCos(%pitch / 2);
   %s1 = mSin(%pitch / 2);
   %c2 = mCos(%roll / 2);
   %s2 = mSin(%roll / 2);
   %c3 = mCos(%yaw / 2);
   %s3 = mSos(%yaw / 2);
   %c1c2 = %c1 * %c2;
   %s1s2 = %s1 * %s2;
   %w = %c1c2 * %c3 - %s1s2 * %s3;
   %x = %c1c2 * %s3 + %s1s2 * %c3;
   %y = %s1 * %c2 * %c3 + %c1 * %s2 * %s3;
   %z = %c1 * %s2 * %c3 - %s1 * %c2 * %s3;
   %angle = 2 * mAcos(%w);
   %norm = %x * %x + %y * %y + %z * %z;
   if (%norm < 0.001)
   {
      %x = 1;
      %y = 0;
      %z = 0;
   }
   else
   {
      %norm = mSqrt(%norm);
      %x /= %norm;
      %y /= %norm;
      %z /= %norm;
   }
   return %x SPC %y SPC %z SPC %angle;
}

function eulerToAAVec(%vec)
{
   return eulerToAA(getWord(%vec, 0), getWord(%vec, 1), getWord(%vec, 2));
}

// Note: x, y, and z MUST BE A UNIT VECTOR (have a magnitude of 1)
function AAToEuler(%x, %y, %z, %a)
{
   %s = mSin(%a);
   %c = mCos(%a);
   %t = 1 - %c;

   // check for sinularities
   %sing = (%x * %y * %t + %z * %s);
   if (%sing > 0.998) // north pole singularity
   {
      %pitch = 2 * mAtan(%x * mSin(%a / 2), mCos(%a / 2));
      %roll = 1.57079632; // PI / 2
      %yaw = 0;
   }
   else if (%sing < -0.998) // south pole singularity
   {
      %pitch = -2 * mAtan(%x * mSin(%a / 2), mCos(%a / 2));
      %roll = -1.57079632; // PI / 2
      %yaw = 0;
   }
   else // normal
   {
      %pitch = mAtan(%y * %s - %x * %z * %t, 1 - (%y * %y + %z * %z) * %t);
      %roll = mAsin(%x * %y * %t + %z * %s);
      %yaw = mAtan(%x * %s - %y * %z * %t, 1 - (%x * %x + %z * %z) * %t);
   }
   return %pitch SPC %roll SPC %yaw;
}

function AAToEulerVec(%aa)
{
   return AAToEuler(getWord(%aa, 0), getWord(%aa, 1), getWord(%aa, 2), getWord(%aa, 3));
}