using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Quaternion : IEquatable<Quaternion>
    {
        public float X;
        public float Y;
        public float Z;
        public float W;
        private static Quaternion _identity;
        public static Quaternion Identity
        {
            get
            {
                return _identity;
            }
        }
        public Quaternion(float x, float y, float z, float w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        public Quaternion(Vector3 vectorPart, float scalarPart)
        {
            this.X = vectorPart.X;
            this.Y = vectorPart.Y;
            this.Z = vectorPart.Z;
            this.W = scalarPart;
        }

        public override string ToString()
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            return string.Format(currentCulture, "{{X:{0} Y:{1} Z:{2} W:{3}}}", new object[] { this.X.ToString(currentCulture), this.Y.ToString(currentCulture), this.Z.ToString(currentCulture), this.W.ToString(currentCulture) });
        }

        public bool Equals(Quaternion other)
        {
            return ((((this.X == other.X) && (this.Y == other.Y)) && (this.Z == other.Z)) && (this.W == other.W));
        }

        public override bool Equals(object obj)
        {
            bool flag = false;
            if (obj is Quaternion)
            {
                flag = this.Equals((Quaternion)obj);
            }
            return flag;
        }

        public override int GetHashCode()
        {
            return (((this.X.GetHashCode() + this.Y.GetHashCode()) + this.Z.GetHashCode()) + this.W.GetHashCode());
        }

        public float LengthSquared()
        {
            return ((((this.X * this.X) + (this.Y * this.Y)) + (this.Z * this.Z)) + (this.W * this.W));
        }

        public float Length()
        {
            float num = (((this.X * this.X) + (this.Y * this.Y)) + (this.Z * this.Z)) + (this.W * this.W);
            return (float)Math.Sqrt((double)num);
        }

        public void Normalize()
        {
            float num = (((this.X * this.X) + (this.Y * this.Y)) + (this.Z * this.Z)) + (this.W * this.W);
            float num2 = 1f / ((float)Math.Sqrt((double)num));
            this.X *= num2;
            this.Y *= num2;
            this.Z *= num2;
            this.W *= num2;
        }

        public static Quaternion Normalize(Quaternion quaternion)
        {
            Quaternion quaternion2;
            float num = (((quaternion.X * quaternion.X) + (quaternion.Y * quaternion.Y)) + (quaternion.Z * quaternion.Z)) + (quaternion.W * quaternion.W);
            float num2 = 1f / ((float)Math.Sqrt((double)num));
            quaternion2.X = quaternion.X * num2;
            quaternion2.Y = quaternion.Y * num2;
            quaternion2.Z = quaternion.Z * num2;
            quaternion2.W = quaternion.W * num2;
            return quaternion2;
        }

        public static void Normalize(ref Quaternion quaternion, out Quaternion result)
        {
            float num = (((quaternion.X * quaternion.X) + (quaternion.Y * quaternion.Y)) + (quaternion.Z * quaternion.Z)) + (quaternion.W * quaternion.W);
            float num2 = 1f / ((float)Math.Sqrt((double)num));
            result.X = quaternion.X * num2;
            result.Y = quaternion.Y * num2;
            result.Z = quaternion.Z * num2;
            result.W = quaternion.W * num2;
        }

        public void Conjugate()
        {
            this.X = -this.X;
            this.Y = -this.Y;
            this.Z = -this.Z;
        }

        public static Quaternion Conjugate(Quaternion value)
        {
            Quaternion quaternion;
            quaternion.X = -value.X;
            quaternion.Y = -value.Y;
            quaternion.Z = -value.Z;
            quaternion.W = value.W;
            return quaternion;
        }

        public static void Conjugate(ref Quaternion value, out Quaternion result)
        {
            result.X = -value.X;
            result.Y = -value.Y;
            result.Z = -value.Z;
            result.W = value.W;
        }

        public static Quaternion Inverse(Quaternion quaternion)
        {
            Quaternion quaternion2;
            float num = (((quaternion.X * quaternion.X) + (quaternion.Y * quaternion.Y)) + (quaternion.Z * quaternion.Z)) + (quaternion.W * quaternion.W);
            float num2 = 1f / num;
            quaternion2.X = -quaternion.X * num2;
            quaternion2.Y = -quaternion.Y * num2;
            quaternion2.Z = -quaternion.Z * num2;
            quaternion2.W = quaternion.W * num2;
            return quaternion2;
        }

        public static void Inverse(ref Quaternion quaternion, out Quaternion result)
        {
            float num = (((quaternion.X * quaternion.X) + (quaternion.Y * quaternion.Y)) + (quaternion.Z * quaternion.Z)) + (quaternion.W * quaternion.W);
            float num2 = 1f / num;
            result.X = -quaternion.X * num2;
            result.Y = -quaternion.Y * num2;
            result.Z = -quaternion.Z * num2;
            result.W = quaternion.W * num2;
        }

        public static Quaternion CreateFromAxisAngle(Vector3 axis, float angle)
        {
            Quaternion quaternion;
            float num = angle * 0.5f;
            float num2 = (float)Math.Sin((double)num);
            float num3 = (float)Math.Cos((double)num);
            quaternion.X = axis.X * num2;
            quaternion.Y = axis.Y * num2;
            quaternion.Z = axis.Z * num2;
            quaternion.W = num3;
            return quaternion;
        }

        public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Quaternion result)
        {
            float num = angle * 0.5f;
            float num2 = (float)Math.Sin((double)num);
            float num3 = (float)Math.Cos((double)num);
            result.X = axis.X * num2;
            result.Y = axis.Y * num2;
            result.Z = axis.Z * num2;
            result.W = num3;
        }

        public static Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll)
        {
            Quaternion quaternion;
            float num7 = roll * 0.5f;
            float num = (float)Math.Sin((double)num7);
            float num2 = (float)Math.Cos((double)num7);
            float num8 = pitch * 0.5f;
            float num3 = (float)Math.Sin((double)num8);
            float num4 = (float)Math.Cos((double)num8);
            float num9 = yaw * 0.5f;
            float num5 = (float)Math.Sin((double)num9);
            float num6 = (float)Math.Cos((double)num9);
            quaternion.X = ((num6 * num3) * num2) + ((num5 * num4) * num);
            quaternion.Y = ((num5 * num4) * num2) - ((num6 * num3) * num);
            quaternion.Z = ((num6 * num4) * num) - ((num5 * num3) * num2);
            quaternion.W = ((num6 * num4) * num2) + ((num5 * num3) * num);
            return quaternion;
        }

        public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Quaternion result)
        {
            float num7 = roll * 0.5f;
            float num = (float)Math.Sin((double)num7);
            float num2 = (float)Math.Cos((double)num7);
            float num8 = pitch * 0.5f;
            float num3 = (float)Math.Sin((double)num8);
            float num4 = (float)Math.Cos((double)num8);
            float num9 = yaw * 0.5f;
            float num5 = (float)Math.Sin((double)num9);
            float num6 = (float)Math.Cos((double)num9);
            result.X = ((num6 * num3) * num2) + ((num5 * num4) * num);
            result.Y = ((num5 * num4) * num2) - ((num6 * num3) * num);
            result.Z = ((num6 * num4) * num) - ((num5 * num3) * num2);
            result.W = ((num6 * num4) * num2) + ((num5 * num3) * num);
        }

        public static Quaternion CreateFromRotationMatrix(Matrix matrix)
        {
            float num2;
            float num3;
            float num = (matrix.M11 + matrix.M22) + matrix.M33;
            Quaternion quaternion = new Quaternion();
            if (num > 0f)
            {
                num2 = (float)Math.Sqrt((double)(num + 1f));
                quaternion.W = num2 * 0.5f;
                num2 = 0.5f / num2;
                quaternion.X = (matrix.M23 - matrix.M32) * num2;
                quaternion.Y = (matrix.M31 - matrix.M13) * num2;
                quaternion.Z = (matrix.M12 - matrix.M21) * num2;
                return quaternion;
            }
            if ((matrix.M11 >= matrix.M22) && (matrix.M11 >= matrix.M33))
            {
                num2 = (float)Math.Sqrt((double)(((1f + matrix.M11) - matrix.M22) - matrix.M33));
                num3 = 0.5f / num2;
                quaternion.X = 0.5f * num2;
                quaternion.Y = (matrix.M12 + matrix.M21) * num3;
                quaternion.Z = (matrix.M13 + matrix.M31) * num3;
                quaternion.W = (matrix.M23 - matrix.M32) * num3;
                return quaternion;
            }
            if (matrix.M22 > matrix.M33)
            {
                num2 = (float)Math.Sqrt((double)(((1f + matrix.M22) - matrix.M11) - matrix.M33));
                num3 = 0.5f / num2;
                quaternion.X = (matrix.M21 + matrix.M12) * num3;
                quaternion.Y = 0.5f * num2;
                quaternion.Z = (matrix.M32 + matrix.M23) * num3;
                quaternion.W = (matrix.M31 - matrix.M13) * num3;
                return quaternion;
            }
            num2 = (float)Math.Sqrt((double)(((1f + matrix.M33) - matrix.M11) - matrix.M22));
            num3 = 0.5f / num2;
            quaternion.X = (matrix.M31 + matrix.M13) * num3;
            quaternion.Y = (matrix.M32 + matrix.M23) * num3;
            quaternion.Z = 0.5f * num2;
            quaternion.W = (matrix.M12 - matrix.M21) * num3;
            return quaternion;
        }

        public static void CreateFromRotationMatrix(ref Matrix matrix, out Quaternion result)
        {
            float num2;
            float num = (matrix.M11 + matrix.M22) + matrix.M33;
            if (num > 0f)
            {
                num2 = (float)Math.Sqrt((double)(num + 1f));
                result.W = num2 * 0.5f;
                num2 = 0.5f / num2;
                result.X = (matrix.M23 - matrix.M32) * num2;
                result.Y = (matrix.M31 - matrix.M13) * num2;
                result.Z = (matrix.M12 - matrix.M21) * num2;
            }
            else
            {
                float num3;
                if ((matrix.M11 >= matrix.M22) && (matrix.M11 >= matrix.M33))
                {
                    num2 = (float)Math.Sqrt((double)(((1f + matrix.M11) - matrix.M22) - matrix.M33));
                    num3 = 0.5f / num2;
                    result.X = 0.5f * num2;
                    result.Y = (matrix.M12 + matrix.M21) * num3;
                    result.Z = (matrix.M13 + matrix.M31) * num3;
                    result.W = (matrix.M23 - matrix.M32) * num3;
                }
                else if (matrix.M22 > matrix.M33)
                {
                    num2 = (float)Math.Sqrt((double)(((1f + matrix.M22) - matrix.M11) - matrix.M33));
                    num3 = 0.5f / num2;
                    result.X = (matrix.M21 + matrix.M12) * num3;
                    result.Y = 0.5f * num2;
                    result.Z = (matrix.M32 + matrix.M23) * num3;
                    result.W = (matrix.M31 - matrix.M13) * num3;
                }
                else
                {
                    num2 = (float)Math.Sqrt((double)(((1f + matrix.M33) - matrix.M11) - matrix.M22));
                    num3 = 0.5f / num2;
                    result.X = (matrix.M31 + matrix.M13) * num3;
                    result.Y = (matrix.M32 + matrix.M23) * num3;
                    result.Z = 0.5f * num2;
                    result.W = (matrix.M12 - matrix.M21) * num3;
                }
            }
        }

        public static float Dot(Quaternion quaternion1, Quaternion quaternion2)
        {
            return ((((quaternion1.X * quaternion2.X) + (quaternion1.Y * quaternion2.Y)) + (quaternion1.Z * quaternion2.Z)) + (quaternion1.W * quaternion2.W));
        }

        public static void Dot(ref Quaternion quaternion1, ref Quaternion quaternion2, out float result)
        {
            result = (((quaternion1.X * quaternion2.X) + (quaternion1.Y * quaternion2.Y)) + (quaternion1.Z * quaternion2.Z)) + (quaternion1.W * quaternion2.W);
        }

        public static Quaternion Slerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
        {
            float num3;
            float num4;
            Quaternion quaternion;
            float num = amount;
            float num2 = (((quaternion1.X * quaternion2.X) + (quaternion1.Y * quaternion2.Y)) + (quaternion1.Z * quaternion2.Z)) + (quaternion1.W * quaternion2.W);
            bool flag = false;
            if (num2 < 0f)
            {
                flag = true;
                num2 = -num2;
            }
            if (num2 > 0.999999f)
            {
                num3 = 1f - num;
                num4 = flag ? -num : num;
            }
            else
            {
                float num5 = (float)Math.Acos((double)num2);
                float num6 = (float)(1.0 / Math.Sin((double)num5));
                num3 = ((float)Math.Sin((double)((1f - num) * num5))) * num6;
                num4 = flag ? (((float)-Math.Sin((double)(num * num5))) * num6) : (((float)Math.Sin((double)(num * num5))) * num6);
            }
            quaternion.X = (num3 * quaternion1.X) + (num4 * quaternion2.X);
            quaternion.Y = (num3 * quaternion1.Y) + (num4 * quaternion2.Y);
            quaternion.Z = (num3 * quaternion1.Z) + (num4 * quaternion2.Z);
            quaternion.W = (num3 * quaternion1.W) + (num4 * quaternion2.W);
            return quaternion;
        }

        public static void Slerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result)
        {
            float num3;
            float num4;
            float num = amount;
            float num2 = (((quaternion1.X * quaternion2.X) + (quaternion1.Y * quaternion2.Y)) + (quaternion1.Z * quaternion2.Z)) + (quaternion1.W * quaternion2.W);
            bool flag = false;
            if (num2 < 0f)
            {
                flag = true;
                num2 = -num2;
            }
            if (num2 > 0.999999f)
            {
                num3 = 1f - num;
                num4 = flag ? -num : num;
            }
            else
            {
                float num5 = (float)Math.Acos((double)num2);
                float num6 = (float)(1.0 / Math.Sin((double)num5));
                num3 = ((float)Math.Sin((double)((1f - num) * num5))) * num6;
                num4 = flag ? (((float)-Math.Sin((double)(num * num5))) * num6) : (((float)Math.Sin((double)(num * num5))) * num6);
            }
            result.X = (num3 * quaternion1.X) + (num4 * quaternion2.X);
            result.Y = (num3 * quaternion1.Y) + (num4 * quaternion2.Y);
            result.Z = (num3 * quaternion1.Z) + (num4 * quaternion2.Z);
            result.W = (num3 * quaternion1.W) + (num4 * quaternion2.W);
        }

        public static Quaternion Lerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
        {
            float num = amount;
            float num2 = 1f - num;
            Quaternion quaternion = new Quaternion();
            float num3 = (((quaternion1.X * quaternion2.X) + (quaternion1.Y * quaternion2.Y)) + (quaternion1.Z * quaternion2.Z)) + (quaternion1.W * quaternion2.W);
            if (num3 >= 0f)
            {
                quaternion.X = (num2 * quaternion1.X) + (num * quaternion2.X);
                quaternion.Y = (num2 * quaternion1.Y) + (num * quaternion2.Y);
                quaternion.Z = (num2 * quaternion1.Z) + (num * quaternion2.Z);
                quaternion.W = (num2 * quaternion1.W) + (num * quaternion2.W);
            }
            else
            {
                quaternion.X = (num2 * quaternion1.X) - (num * quaternion2.X);
                quaternion.Y = (num2 * quaternion1.Y) - (num * quaternion2.Y);
                quaternion.Z = (num2 * quaternion1.Z) - (num * quaternion2.Z);
                quaternion.W = (num2 * quaternion1.W) - (num * quaternion2.W);
            }
            float num4 = (((quaternion.X * quaternion.X) + (quaternion.Y * quaternion.Y)) + (quaternion.Z * quaternion.Z)) + (quaternion.W * quaternion.W);
            float num5 = 1f / ((float)Math.Sqrt((double)num4));
            quaternion.X *= num5;
            quaternion.Y *= num5;
            quaternion.Z *= num5;
            quaternion.W *= num5;
            return quaternion;
        }

        public static void Lerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result)
        {
            float num = amount;
            float num2 = 1f - num;
            float num3 = (((quaternion1.X * quaternion2.X) + (quaternion1.Y * quaternion2.Y)) + (quaternion1.Z * quaternion2.Z)) + (quaternion1.W * quaternion2.W);
            if (num3 >= 0f)
            {
                result.X = (num2 * quaternion1.X) + (num * quaternion2.X);
                result.Y = (num2 * quaternion1.Y) + (num * quaternion2.Y);
                result.Z = (num2 * quaternion1.Z) + (num * quaternion2.Z);
                result.W = (num2 * quaternion1.W) + (num * quaternion2.W);
            }
            else
            {
                result.X = (num2 * quaternion1.X) - (num * quaternion2.X);
                result.Y = (num2 * quaternion1.Y) - (num * quaternion2.Y);
                result.Z = (num2 * quaternion1.Z) - (num * quaternion2.Z);
                result.W = (num2 * quaternion1.W) - (num * quaternion2.W);
            }
            float num4 = (((result.X * result.X) + (result.Y * result.Y)) + (result.Z * result.Z)) + (result.W * result.W);
            float num5 = 1f / ((float)Math.Sqrt((double)num4));
            result.X *= num5;
            result.Y *= num5;
            result.Z *= num5;
            result.W *= num5;
        }

        public static Quaternion Concatenate(Quaternion value1, Quaternion value2)
        {
            Quaternion quaternion;
            float x = value2.X;
            float y = value2.Y;
            float z = value2.Z;
            float w = value2.W;
            float num5 = value1.X;
            float num6 = value1.Y;
            float num7 = value1.Z;
            float num8 = value1.W;
            float num9 = (y * num7) - (z * num6);
            float num10 = (z * num5) - (x * num7);
            float num11 = (x * num6) - (y * num5);
            float num12 = ((x * num5) + (y * num6)) + (z * num7);
            quaternion.X = ((x * num8) + (num5 * w)) + num9;
            quaternion.Y = ((y * num8) + (num6 * w)) + num10;
            quaternion.Z = ((z * num8) + (num7 * w)) + num11;
            quaternion.W = (w * num8) - num12;
            return quaternion;
        }

        public static void Concatenate(ref Quaternion value1, ref Quaternion value2, out Quaternion result)
        {
            float x = value2.X;
            float y = value2.Y;
            float z = value2.Z;
            float w = value2.W;
            float num5 = value1.X;
            float num6 = value1.Y;
            float num7 = value1.Z;
            float num8 = value1.W;
            float num9 = (y * num7) - (z * num6);
            float num10 = (z * num5) - (x * num7);
            float num11 = (x * num6) - (y * num5);
            float num12 = ((x * num5) + (y * num6)) + (z * num7);
            result.X = ((x * num8) + (num5 * w)) + num9;
            result.Y = ((y * num8) + (num6 * w)) + num10;
            result.Z = ((z * num8) + (num7 * w)) + num11;
            result.W = (w * num8) - num12;
        }

        public static Quaternion Negate(Quaternion quaternion)
        {
            Quaternion quaternion2;
            quaternion2.X = -quaternion.X;
            quaternion2.Y = -quaternion.Y;
            quaternion2.Z = -quaternion.Z;
            quaternion2.W = -quaternion.W;
            return quaternion2;
        }

        public static void Negate(ref Quaternion quaternion, out Quaternion result)
        {
            result.X = -quaternion.X;
            result.Y = -quaternion.Y;
            result.Z = -quaternion.Z;
            result.W = -quaternion.W;
        }

        public static Quaternion Add(Quaternion quaternion1, Quaternion quaternion2)
        {
            Quaternion quaternion;
            quaternion.X = quaternion1.X + quaternion2.X;
            quaternion.Y = quaternion1.Y + quaternion2.Y;
            quaternion.Z = quaternion1.Z + quaternion2.Z;
            quaternion.W = quaternion1.W + quaternion2.W;
            return quaternion;
        }

        public static void Add(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
        {
            result.X = quaternion1.X + quaternion2.X;
            result.Y = quaternion1.Y + quaternion2.Y;
            result.Z = quaternion1.Z + quaternion2.Z;
            result.W = quaternion1.W + quaternion2.W;
        }

        public static Quaternion Subtract(Quaternion quaternion1, Quaternion quaternion2)
        {
            Quaternion quaternion;
            quaternion.X = quaternion1.X - quaternion2.X;
            quaternion.Y = quaternion1.Y - quaternion2.Y;
            quaternion.Z = quaternion1.Z - quaternion2.Z;
            quaternion.W = quaternion1.W - quaternion2.W;
            return quaternion;
        }

        public static void Subtract(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
        {
            result.X = quaternion1.X - quaternion2.X;
            result.Y = quaternion1.Y - quaternion2.Y;
            result.Z = quaternion1.Z - quaternion2.Z;
            result.W = quaternion1.W - quaternion2.W;
        }

        public static Quaternion Multiply(Quaternion quaternion1, Quaternion quaternion2)
        {
            Quaternion quaternion;
            float x = quaternion1.X;
            float y = quaternion1.Y;
            float z = quaternion1.Z;
            float w = quaternion1.W;
            float num5 = quaternion2.X;
            float num6 = quaternion2.Y;
            float num7 = quaternion2.Z;
            float num8 = quaternion2.W;
            float num9 = (y * num7) - (z * num6);
            float num10 = (z * num5) - (x * num7);
            float num11 = (x * num6) - (y * num5);
            float num12 = ((x * num5) + (y * num6)) + (z * num7);
            quaternion.X = ((x * num8) + (num5 * w)) + num9;
            quaternion.Y = ((y * num8) + (num6 * w)) + num10;
            quaternion.Z = ((z * num8) + (num7 * w)) + num11;
            quaternion.W = (w * num8) - num12;
            return quaternion;
        }

        public static void Multiply(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
        {
            float x = quaternion1.X;
            float y = quaternion1.Y;
            float z = quaternion1.Z;
            float w = quaternion1.W;
            float num5 = quaternion2.X;
            float num6 = quaternion2.Y;
            float num7 = quaternion2.Z;
            float num8 = quaternion2.W;
            float num9 = (y * num7) - (z * num6);
            float num10 = (z * num5) - (x * num7);
            float num11 = (x * num6) - (y * num5);
            float num12 = ((x * num5) + (y * num6)) + (z * num7);
            result.X = ((x * num8) + (num5 * w)) + num9;
            result.Y = ((y * num8) + (num6 * w)) + num10;
            result.Z = ((z * num8) + (num7 * w)) + num11;
            result.W = (w * num8) - num12;
        }

        public static Quaternion Multiply(Quaternion quaternion1, float scaleFactor)
        {
            Quaternion quaternion;
            quaternion.X = quaternion1.X * scaleFactor;
            quaternion.Y = quaternion1.Y * scaleFactor;
            quaternion.Z = quaternion1.Z * scaleFactor;
            quaternion.W = quaternion1.W * scaleFactor;
            return quaternion;
        }

        public static void Multiply(ref Quaternion quaternion1, float scaleFactor, out Quaternion result)
        {
            result.X = quaternion1.X * scaleFactor;
            result.Y = quaternion1.Y * scaleFactor;
            result.Z = quaternion1.Z * scaleFactor;
            result.W = quaternion1.W * scaleFactor;
        }

        public static Quaternion Divide(Quaternion quaternion1, Quaternion quaternion2)
        {
            Quaternion quaternion;
            float x = quaternion1.X;
            float y = quaternion1.Y;
            float z = quaternion1.Z;
            float w = quaternion1.W;
            float num5 = (((quaternion2.X * quaternion2.X) + (quaternion2.Y * quaternion2.Y)) + (quaternion2.Z * quaternion2.Z)) + (quaternion2.W * quaternion2.W);
            float num6 = 1f / num5;
            float num7 = -quaternion2.X * num6;
            float num8 = -quaternion2.Y * num6;
            float num9 = -quaternion2.Z * num6;
            float num10 = quaternion2.W * num6;
            float num11 = (y * num9) - (z * num8);
            float num12 = (z * num7) - (x * num9);
            float num13 = (x * num8) - (y * num7);
            float num14 = ((x * num7) + (y * num8)) + (z * num9);
            quaternion.X = ((x * num10) + (num7 * w)) + num11;
            quaternion.Y = ((y * num10) + (num8 * w)) + num12;
            quaternion.Z = ((z * num10) + (num9 * w)) + num13;
            quaternion.W = (w * num10) - num14;
            return quaternion;
        }

        public static void Divide(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
        {
            float x = quaternion1.X;
            float y = quaternion1.Y;
            float z = quaternion1.Z;
            float w = quaternion1.W;
            float num5 = (((quaternion2.X * quaternion2.X) + (quaternion2.Y * quaternion2.Y)) + (quaternion2.Z * quaternion2.Z)) + (quaternion2.W * quaternion2.W);
            float num6 = 1f / num5;
            float num7 = -quaternion2.X * num6;
            float num8 = -quaternion2.Y * num6;
            float num9 = -quaternion2.Z * num6;
            float num10 = quaternion2.W * num6;
            float num11 = (y * num9) - (z * num8);
            float num12 = (z * num7) - (x * num9);
            float num13 = (x * num8) - (y * num7);
            float num14 = ((x * num7) + (y * num8)) + (z * num9);
            result.X = ((x * num10) + (num7 * w)) + num11;
            result.Y = ((y * num10) + (num8 * w)) + num12;
            result.Z = ((z * num10) + (num9 * w)) + num13;
            result.W = (w * num10) - num14;
        }

        public static Quaternion operator -(Quaternion quaternion)
        {
            Quaternion quaternion2;
            quaternion2.X = -quaternion.X;
            quaternion2.Y = -quaternion.Y;
            quaternion2.Z = -quaternion.Z;
            quaternion2.W = -quaternion.W;
            return quaternion2;
        }

        public static bool operator ==(Quaternion quaternion1, Quaternion quaternion2)
        {
            return ((((quaternion1.X == quaternion2.X) && (quaternion1.Y == quaternion2.Y)) && (quaternion1.Z == quaternion2.Z)) && (quaternion1.W == quaternion2.W));
        }

        public static bool operator !=(Quaternion quaternion1, Quaternion quaternion2)
        {
            return ((((quaternion1.X != quaternion2.X) || (quaternion1.Y != quaternion2.Y)) || (quaternion1.Z != quaternion2.Z)) || !(quaternion1.W == quaternion2.W));
        }

        public static Quaternion operator +(Quaternion quaternion1, Quaternion quaternion2)
        {
            Quaternion quaternion;
            quaternion.X = quaternion1.X + quaternion2.X;
            quaternion.Y = quaternion1.Y + quaternion2.Y;
            quaternion.Z = quaternion1.Z + quaternion2.Z;
            quaternion.W = quaternion1.W + quaternion2.W;
            return quaternion;
        }

        public static Quaternion operator -(Quaternion quaternion1, Quaternion quaternion2)
        {
            Quaternion quaternion;
            quaternion.X = quaternion1.X - quaternion2.X;
            quaternion.Y = quaternion1.Y - quaternion2.Y;
            quaternion.Z = quaternion1.Z - quaternion2.Z;
            quaternion.W = quaternion1.W - quaternion2.W;
            return quaternion;
        }

        public static Quaternion operator *(Quaternion quaternion1, Quaternion quaternion2)
        {
            Quaternion quaternion;
            float x = quaternion1.X;
            float y = quaternion1.Y;
            float z = quaternion1.Z;
            float w = quaternion1.W;
            float num5 = quaternion2.X;
            float num6 = quaternion2.Y;
            float num7 = quaternion2.Z;
            float num8 = quaternion2.W;
            float num9 = (y * num7) - (z * num6);
            float num10 = (z * num5) - (x * num7);
            float num11 = (x * num6) - (y * num5);
            float num12 = ((x * num5) + (y * num6)) + (z * num7);
            quaternion.X = ((x * num8) + (num5 * w)) + num9;
            quaternion.Y = ((y * num8) + (num6 * w)) + num10;
            quaternion.Z = ((z * num8) + (num7 * w)) + num11;
            quaternion.W = (w * num8) - num12;
            return quaternion;
        }

        public static Quaternion operator *(Quaternion quaternion1, float scaleFactor)
        {
            Quaternion quaternion;
            quaternion.X = quaternion1.X * scaleFactor;
            quaternion.Y = quaternion1.Y * scaleFactor;
            quaternion.Z = quaternion1.Z * scaleFactor;
            quaternion.W = quaternion1.W * scaleFactor;
            return quaternion;
        }

        public static Quaternion operator /(Quaternion quaternion1, Quaternion quaternion2)
        {
            Quaternion quaternion;
            float x = quaternion1.X;
            float y = quaternion1.Y;
            float z = quaternion1.Z;
            float w = quaternion1.W;
            float num5 = (((quaternion2.X * quaternion2.X) + (quaternion2.Y * quaternion2.Y)) + (quaternion2.Z * quaternion2.Z)) + (quaternion2.W * quaternion2.W);
            float num6 = 1f / num5;
            float num7 = -quaternion2.X * num6;
            float num8 = -quaternion2.Y * num6;
            float num9 = -quaternion2.Z * num6;
            float num10 = quaternion2.W * num6;
            float num11 = (y * num9) - (z * num8);
            float num12 = (z * num7) - (x * num9);
            float num13 = (x * num8) - (y * num7);
            float num14 = ((x * num7) + (y * num8)) + (z * num9);
            quaternion.X = ((x * num10) + (num7 * w)) + num11;
            quaternion.Y = ((y * num10) + (num8 * w)) + num12;
            quaternion.Z = ((z * num10) + (num9 * w)) + num13;
            quaternion.W = (w * num10) - num14;
            return quaternion;
        }

        static Quaternion()
        {
            _identity = new Quaternion(0f, 0f, 0f, 1f);
        }
    }


}
