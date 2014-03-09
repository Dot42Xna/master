using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Ray : IEquatable<Ray>
    {
        public Vector3 Position;
        public Vector3 Direction;
        public Ray(Vector3 position, Vector3 direction)
        {
            this.Position = position;
            this.Direction = direction;
        }

        public bool Equals(Ray other)
        {
            return (((((this.Position.X == other.Position.X) && (this.Position.Y == other.Position.Y)) && ((this.Position.Z == other.Position.Z) && (this.Direction.X == other.Direction.X))) && (this.Direction.Y == other.Direction.Y)) && (this.Direction.Z == other.Direction.Z));
        }

        public override bool Equals(object obj)
        {
            bool flag = false;
            if ((obj != null) && (obj is Ray))
            {
                flag = this.Equals((Ray)obj);
            }
            return flag;
        }

        public override int GetHashCode()
        {
            return (this.Position.GetHashCode() + this.Direction.GetHashCode());
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{Position:{0} Direction:{1}}}", new object[] { this.Position.ToString(), this.Direction.ToString() });
        }

        public float? Intersects(BoundingBox box)
        {
            return box.Intersects(this);
        }

        public void Intersects(ref BoundingBox box, out float? result)
        {
            box.Intersects(ref this, out result);
        }

        public float? Intersects(BoundingFrustum frustum)
        {
            if (frustum == null)
            {
                throw new ArgumentNullException("frustum");
            }
            return frustum.Intersects(this);
        }

        public float? Intersects(Plane plane)
        {
            float num = ((plane.Normal.X * this.Direction.X) + (plane.Normal.Y * this.Direction.Y)) + (plane.Normal.Z * this.Direction.Z);
            if (Math.Abs(num) < 1E-05f)
            {
                return null;
            }
            float num2 = ((plane.Normal.X * this.Position.X) + (plane.Normal.Y * this.Position.Y)) + (plane.Normal.Z * this.Position.Z);
            float num3 = (-plane.D - num2) / num;
            if (num3 < 0f)
            {
                if (num3 < -1E-05f)
                {
                    return null;
                }
                num3 = 0f;
            }
            return new float?(num3);
        }

        public void Intersects(ref Plane plane, out float? result)
        {
            float num = ((plane.Normal.X * this.Direction.X) + (plane.Normal.Y * this.Direction.Y)) + (plane.Normal.Z * this.Direction.Z);
            if (Math.Abs(num) < 1E-05f)
            {
                result = 0;
            }
            else
            {
                float num2 = ((plane.Normal.X * this.Position.X) + (plane.Normal.Y * this.Position.Y)) + (plane.Normal.Z * this.Position.Z);
                float num3 = (-plane.D - num2) / num;
                if (num3 < 0f)
                {
                    if (num3 < -1E-05f)
                    {
                        result = 0;
                        return;
                    }
                    result = 0f;
                }
                result = new float?(num3);
            }
        }

        public float? Intersects(BoundingSphere sphere)
        {
            float num = sphere.Center.X - this.Position.X;
            float num2 = sphere.Center.Y - this.Position.Y;
            float num3 = sphere.Center.Z - this.Position.Z;
            float num4 = ((num * num) + (num2 * num2)) + (num3 * num3);
            float num5 = sphere.Radius * sphere.Radius;
            if (num4 <= num5)
            {
                return 0f;
            }
            float num6 = ((num * this.Direction.X) + (num2 * this.Direction.Y)) + (num3 * this.Direction.Z);
            if (num6 < 0f)
            {
                return null;
            }
            float num7 = num4 - (num6 * num6);
            if (num7 > num5)
            {
                return null;
            }
            float num8 = (float)Math.Sqrt((double)(num5 - num7));
            return new float?(num6 - num8);
        }

        public void Intersects(ref BoundingSphere sphere, out float? result)
        {
            float num = sphere.Center.X - this.Position.X;
            float num2 = sphere.Center.Y - this.Position.Y;
            float num3 = sphere.Center.Z - this.Position.Z;
            float num4 = ((num * num) + (num2 * num2)) + (num3 * num3);
            float num5 = sphere.Radius * sphere.Radius;
            if (num4 <= num5)
            {
                result = 0f;
            }
            else
            {
                result = 0;
                float num6 = ((num * this.Direction.X) + (num2 * this.Direction.Y)) + (num3 * this.Direction.Z);
                if (num6 >= 0f)
                {
                    float num7 = num4 - (num6 * num6);
                    if (num7 <= num5)
                    {
                        float num8 = (float)Math.Sqrt((double)(num5 - num7));
                        result = new float?(num6 - num8);
                    }
                }
            }
        }

        public static bool operator ==(Ray a, Ray b)
        {
            return (((((a.Position.X == b.Position.X) && (a.Position.Y == b.Position.Y)) && ((a.Position.Z == b.Position.Z) && (a.Direction.X == b.Direction.X))) && (a.Direction.Y == b.Direction.Y)) && (a.Direction.Z == b.Direction.Z));
        }

        public static bool operator !=(Ray a, Ray b)
        {
            return (((((a.Position.X != b.Position.X) || (a.Position.Y != b.Position.Y)) || ((a.Position.Z != b.Position.Z) || (a.Direction.X != b.Direction.X))) || (a.Direction.Y != b.Direction.Y)) || !(a.Direction.Z == b.Direction.Z));
        }
    }


}
