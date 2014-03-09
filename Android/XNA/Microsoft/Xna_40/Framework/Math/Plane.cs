using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Plane : IEquatable<Plane>
    {
        public Vector3 Normal;
        public float D;
        public Plane(float a, float b, float c, float d)
        {
            this.Normal.X = a;
            this.Normal.Y = b;
            this.Normal.Z = c;
            this.D = d;
        }

        public Plane(Vector3 normal, float d)
        {
            this.Normal = normal;
            this.D = d;
        }

        public Plane(Vector4 value)
        {
            this.Normal.X = value.X;
            this.Normal.Y = value.Y;
            this.Normal.Z = value.Z;
            this.D = value.W;
        }

        public Plane(Vector3 point1, Vector3 point2, Vector3 point3)
        {
            float num = point2.X - point1.X;
            float num2 = point2.Y - point1.Y;
            float num3 = point2.Z - point1.Z;
            float num4 = point3.X - point1.X;
            float num5 = point3.Y - point1.Y;
            float num6 = point3.Z - point1.Z;
            float num7 = (num2 * num6) - (num3 * num5);
            float num8 = (num3 * num4) - (num * num6);
            float num9 = (num * num5) - (num2 * num4);
            float num10 = ((num7 * num7) + (num8 * num8)) + (num9 * num9);
            float num11 = 1f / ((float)Math.Sqrt((double)num10));
            this.Normal.X = num7 * num11;
            this.Normal.Y = num8 * num11;
            this.Normal.Z = num9 * num11;
            this.D = -(((this.Normal.X * point1.X) + (this.Normal.Y * point1.Y)) + (this.Normal.Z * point1.Z));
        }

        public bool Equals(Plane other)
        {
            return ((((this.Normal.X == other.Normal.X) && (this.Normal.Y == other.Normal.Y)) && (this.Normal.Z == other.Normal.Z)) && (this.D == other.D));
        }

        public override bool Equals(object obj)
        {
            bool flag = false;
            if (obj is Plane)
            {
                flag = this.Equals((Plane)obj);
            }
            return flag;
        }

        public override int GetHashCode()
        {
            return (this.Normal.GetHashCode() + this.D.GetHashCode());
        }

        public override string ToString()
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            return string.Format(currentCulture, "{{Normal:{0} D:{1}}}", new object[] { this.Normal.ToString(), this.D.ToString(currentCulture) });
        }

        public void Normalize()
        {
            float num = ((this.Normal.X * this.Normal.X) + (this.Normal.Y * this.Normal.Y)) + (this.Normal.Z * this.Normal.Z);
            if (Math.Abs((float)(num - 1f)) >= 1.192093E-07f)
            {
                float num2 = 1f / ((float)Math.Sqrt((double)num));
                this.Normal.X *= num2;
                this.Normal.Y *= num2;
                this.Normal.Z *= num2;
                this.D *= num2;
            }
        }

        public static Plane Normalize(Plane value)
        {
            Plane plane;
            float num = ((value.Normal.X * value.Normal.X) + (value.Normal.Y * value.Normal.Y)) + (value.Normal.Z * value.Normal.Z);
            if (Math.Abs((float)(num - 1f)) < 1.192093E-07f)
            {
                plane.Normal = value.Normal;
                plane.D = value.D;
                return plane;
            }
            float num2 = 1f / ((float)Math.Sqrt((double)num));
            plane.Normal.X = value.Normal.X * num2;
            plane.Normal.Y = value.Normal.Y * num2;
            plane.Normal.Z = value.Normal.Z * num2;
            plane.D = value.D * num2;
            return plane;
        }

        public static void Normalize(ref Plane value, out Plane result)
        {
            float num = ((value.Normal.X * value.Normal.X) + (value.Normal.Y * value.Normal.Y)) + (value.Normal.Z * value.Normal.Z);
            if (Math.Abs((float)(num - 1f)) < 1.192093E-07f)
            {
                result.Normal = value.Normal;
                result.D = value.D;
            }
            else
            {
                float num2 = 1f / ((float)Math.Sqrt((double)num));
                result.Normal.X = value.Normal.X * num2;
                result.Normal.Y = value.Normal.Y * num2;
                result.Normal.Z = value.Normal.Z * num2;
                result.D = value.D * num2;
            }
        }

        public static Plane Transform(Plane plane, Matrix matrix)
        {
            Matrix matrix2;
            Plane plane2;
            Matrix.Invert(ref matrix, out matrix2);
            float x = plane.Normal.X;
            float y = plane.Normal.Y;
            float z = plane.Normal.Z;
            float d = plane.D;
            plane2.Normal.X = (((x * matrix2.M11) + (y * matrix2.M12)) + (z * matrix2.M13)) + (d * matrix2.M14);
            plane2.Normal.Y = (((x * matrix2.M21) + (y * matrix2.M22)) + (z * matrix2.M23)) + (d * matrix2.M24);
            plane2.Normal.Z = (((x * matrix2.M31) + (y * matrix2.M32)) + (z * matrix2.M33)) + (d * matrix2.M34);
            plane2.D = (((x * matrix2.M41) + (y * matrix2.M42)) + (z * matrix2.M43)) + (d * matrix2.M44);
            return plane2;
        }

        public static void Transform(ref Plane plane, ref Matrix matrix, out Plane result)
        {
            Matrix matrix2;
            Matrix.Invert(ref matrix, out matrix2);
            float x = plane.Normal.X;
            float y = plane.Normal.Y;
            float z = plane.Normal.Z;
            float d = plane.D;
            result.Normal.X = (((x * matrix2.M11) + (y * matrix2.M12)) + (z * matrix2.M13)) + (d * matrix2.M14);
            result.Normal.Y = (((x * matrix2.M21) + (y * matrix2.M22)) + (z * matrix2.M23)) + (d * matrix2.M24);
            result.Normal.Z = (((x * matrix2.M31) + (y * matrix2.M32)) + (z * matrix2.M33)) + (d * matrix2.M34);
            result.D = (((x * matrix2.M41) + (y * matrix2.M42)) + (z * matrix2.M43)) + (d * matrix2.M44);
        }

        public static Plane Transform(Plane plane, Quaternion rotation)
        {
            Plane plane2;
            float num = rotation.X + rotation.X;
            float num2 = rotation.Y + rotation.Y;
            float num3 = rotation.Z + rotation.Z;
            float num4 = rotation.W * num;
            float num5 = rotation.W * num2;
            float num6 = rotation.W * num3;
            float num7 = rotation.X * num;
            float num8 = rotation.X * num2;
            float num9 = rotation.X * num3;
            float num10 = rotation.Y * num2;
            float num11 = rotation.Y * num3;
            float num12 = rotation.Z * num3;
            float num13 = (1f - num10) - num12;
            float num14 = num8 - num6;
            float num15 = num9 + num5;
            float num16 = num8 + num6;
            float num17 = (1f - num7) - num12;
            float num18 = num11 - num4;
            float num19 = num9 - num5;
            float num20 = num11 + num4;
            float num21 = (1f - num7) - num10;
            float x = plane.Normal.X;
            float y = plane.Normal.Y;
            float z = plane.Normal.Z;
            plane2.Normal.X = ((x * num13) + (y * num14)) + (z * num15);
            plane2.Normal.Y = ((x * num16) + (y * num17)) + (z * num18);
            plane2.Normal.Z = ((x * num19) + (y * num20)) + (z * num21);
            plane2.D = plane.D;
            return plane2;
        }

        public static void Transform(ref Plane plane, ref Quaternion rotation, out Plane result)
        {
            float num = rotation.X + rotation.X;
            float num2 = rotation.Y + rotation.Y;
            float num3 = rotation.Z + rotation.Z;
            float num4 = rotation.W * num;
            float num5 = rotation.W * num2;
            float num6 = rotation.W * num3;
            float num7 = rotation.X * num;
            float num8 = rotation.X * num2;
            float num9 = rotation.X * num3;
            float num10 = rotation.Y * num2;
            float num11 = rotation.Y * num3;
            float num12 = rotation.Z * num3;
            float num13 = (1f - num10) - num12;
            float num14 = num8 - num6;
            float num15 = num9 + num5;
            float num16 = num8 + num6;
            float num17 = (1f - num7) - num12;
            float num18 = num11 - num4;
            float num19 = num9 - num5;
            float num20 = num11 + num4;
            float num21 = (1f - num7) - num10;
            float x = plane.Normal.X;
            float y = plane.Normal.Y;
            float z = plane.Normal.Z;
            result.Normal.X = ((x * num13) + (y * num14)) + (z * num15);
            result.Normal.Y = ((x * num16) + (y * num17)) + (z * num18);
            result.Normal.Z = ((x * num19) + (y * num20)) + (z * num21);
            result.D = plane.D;
        }

        public float Dot(Vector4 value)
        {
            return ((((this.Normal.X * value.X) + (this.Normal.Y * value.Y)) + (this.Normal.Z * value.Z)) + (this.D * value.W));
        }

        public void Dot(ref Vector4 value, out float result)
        {
            result = (((this.Normal.X * value.X) + (this.Normal.Y * value.Y)) + (this.Normal.Z * value.Z)) + (this.D * value.W);
        }

        public float DotCoordinate(Vector3 value)
        {
            return ((((this.Normal.X * value.X) + (this.Normal.Y * value.Y)) + (this.Normal.Z * value.Z)) + this.D);
        }

        public void DotCoordinate(ref Vector3 value, out float result)
        {
            result = (((this.Normal.X * value.X) + (this.Normal.Y * value.Y)) + (this.Normal.Z * value.Z)) + this.D;
        }

        public float DotNormal(Vector3 value)
        {
            return (((this.Normal.X * value.X) + (this.Normal.Y * value.Y)) + (this.Normal.Z * value.Z));
        }

        public void DotNormal(ref Vector3 value, out float result)
        {
            result = ((this.Normal.X * value.X) + (this.Normal.Y * value.Y)) + (this.Normal.Z * value.Z);
        }

        public PlaneIntersectionType Intersects(BoundingBox box)
        {
            Vector3 vector;
            Vector3 vector2;
            vector.X = (this.Normal.X >= 0f) ? box.Min.X : box.Max.X;
            vector.Y = (this.Normal.Y >= 0f) ? box.Min.Y : box.Max.Y;
            vector.Z = (this.Normal.Z >= 0f) ? box.Min.Z : box.Max.Z;
            vector2.X = (this.Normal.X >= 0f) ? box.Max.X : box.Min.X;
            vector2.Y = (this.Normal.Y >= 0f) ? box.Max.Y : box.Min.Y;
            vector2.Z = (this.Normal.Z >= 0f) ? box.Max.Z : box.Min.Z;
            float num = ((this.Normal.X * vector.X) + (this.Normal.Y * vector.Y)) + (this.Normal.Z * vector.Z);
            if ((num + this.D) > 0f)
            {
                return PlaneIntersectionType.Front;
            }
            num = ((this.Normal.X * vector2.X) + (this.Normal.Y * vector2.Y)) + (this.Normal.Z * vector2.Z);
            if ((num + this.D) < 0f)
            {
                return PlaneIntersectionType.Back;
            }
            return PlaneIntersectionType.Intersecting;
        }

        public void Intersects(ref BoundingBox box, out PlaneIntersectionType result)
        {
            Vector3 vector;
            Vector3 vector2;
            vector.X = (this.Normal.X >= 0f) ? box.Min.X : box.Max.X;
            vector.Y = (this.Normal.Y >= 0f) ? box.Min.Y : box.Max.Y;
            vector.Z = (this.Normal.Z >= 0f) ? box.Min.Z : box.Max.Z;
            vector2.X = (this.Normal.X >= 0f) ? box.Max.X : box.Min.X;
            vector2.Y = (this.Normal.Y >= 0f) ? box.Max.Y : box.Min.Y;
            vector2.Z = (this.Normal.Z >= 0f) ? box.Max.Z : box.Min.Z;
            float num = ((this.Normal.X * vector.X) + (this.Normal.Y * vector.Y)) + (this.Normal.Z * vector.Z);
            if ((num + this.D) > 0f)
            {
                result = PlaneIntersectionType.Front;
            }
            else
            {
                num = ((this.Normal.X * vector2.X) + (this.Normal.Y * vector2.Y)) + (this.Normal.Z * vector2.Z);
                if ((num + this.D) < 0f)
                {
                    result = PlaneIntersectionType.Back;
                }
                else
                {
                    result = PlaneIntersectionType.Intersecting;
                }
            }
        }

        public PlaneIntersectionType Intersects(BoundingFrustum frustum)
        {
            if (null == frustum)
            {
                throw new ArgumentNullException("frustum", "FrameworkResources.NullNotAllowed");
            }
            return frustum.Intersects(this);
        }

        public PlaneIntersectionType Intersects(BoundingSphere sphere)
        {
            float num = ((sphere.Center.X * this.Normal.X) + (sphere.Center.Y * this.Normal.Y)) + (sphere.Center.Z * this.Normal.Z);
            float num2 = num + this.D;
            if (num2 > sphere.Radius)
            {
                return PlaneIntersectionType.Front;
            }
            if (num2 < -sphere.Radius)
            {
                return PlaneIntersectionType.Back;
            }
            return PlaneIntersectionType.Intersecting;
        }

        public void Intersects(ref BoundingSphere sphere, out PlaneIntersectionType result)
        {
            float num = ((sphere.Center.X * this.Normal.X) + (sphere.Center.Y * this.Normal.Y)) + (sphere.Center.Z * this.Normal.Z);
            float num2 = num + this.D;
            if (num2 > sphere.Radius)
            {
                result = PlaneIntersectionType.Front;
            }
            else if (num2 < -sphere.Radius)
            {
                result = PlaneIntersectionType.Back;
            }
            else
            {
                result = PlaneIntersectionType.Intersecting;
            }
        }

        public static bool operator ==(Plane lhs, Plane rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Plane lhs, Plane rhs)
        {
            return ((((lhs.Normal.X != rhs.Normal.X) || (lhs.Normal.Y != rhs.Normal.Y)) || (lhs.Normal.Z != rhs.Normal.Z)) || !(lhs.D == rhs.D));
        }
    }


}
