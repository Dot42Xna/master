﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
    [StructLayout(LayoutKind.Sequential)]
    public struct BoundingBox : IEquatable<BoundingBox>
    {
        public const int CornerCount = 8;
        public Vector3 Min;
        public Vector3 Max;
        public Vector3[] GetCorners()
        {
            return new Vector3[] { new Vector3(this.Min.X, this.Max.Y, this.Max.Z), new Vector3(this.Max.X, this.Max.Y, this.Max.Z), new Vector3(this.Max.X, this.Min.Y, this.Max.Z), new Vector3(this.Min.X, this.Min.Y, this.Max.Z), new Vector3(this.Min.X, this.Max.Y, this.Min.Z), new Vector3(this.Max.X, this.Max.Y, this.Min.Z), new Vector3(this.Max.X, this.Min.Y, this.Min.Z), new Vector3(this.Min.X, this.Min.Y, this.Min.Z) };
        }

        public void GetCorners(Vector3[] corners)
        {
            if (corners == null)
            {
                throw new ArgumentNullException("corners");
            }
            if (corners.Length < 8)
            {
                throw new ArgumentOutOfRangeException("corners", "FrameworkResources.NotEnoughCorners");
            }
            corners[0].X = this.Min.X;
            corners[0].Y = this.Max.Y;
            corners[0].Z = this.Max.Z;
            corners[1].X = this.Max.X;
            corners[1].Y = this.Max.Y;
            corners[1].Z = this.Max.Z;
            corners[2].X = this.Max.X;
            corners[2].Y = this.Min.Y;
            corners[2].Z = this.Max.Z;
            corners[3].X = this.Min.X;
            corners[3].Y = this.Min.Y;
            corners[3].Z = this.Max.Z;
            corners[4].X = this.Min.X;
            corners[4].Y = this.Max.Y;
            corners[4].Z = this.Min.Z;
            corners[5].X = this.Max.X;
            corners[5].Y = this.Max.Y;
            corners[5].Z = this.Min.Z;
            corners[6].X = this.Max.X;
            corners[6].Y = this.Min.Y;
            corners[6].Z = this.Min.Z;
            corners[7].X = this.Min.X;
            corners[7].Y = this.Min.Y;
            corners[7].Z = this.Min.Z;
        }

        public BoundingBox(Vector3 min, Vector3 max)
        {
            this.Min = min;
            this.Max = max;
        }

        public bool Equals(BoundingBox other)
        {
            return ((this.Min == other.Min) && (this.Max == other.Max));
        }

        public override bool Equals(object obj)
        {
            bool flag = false;
            if (obj is BoundingBox)
            {
                flag = this.Equals((BoundingBox)obj);
            }
            return flag;
        }

        public override int GetHashCode()
        {
            return (this.Min.GetHashCode() + this.Max.GetHashCode());
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{Min:{0} Max:{1}}}", new object[] { this.Min.ToString(), this.Max.ToString() });
        }

        public static BoundingBox CreateMerged(BoundingBox original, BoundingBox additional)
        {
            BoundingBox box;
            Vector3.Min(ref original.Min, ref additional.Min, out box.Min);
            Vector3.Max(ref original.Max, ref additional.Max, out box.Max);
            return box;
        }

        public static void CreateMerged(ref BoundingBox original, ref BoundingBox additional, out BoundingBox result)
        {
            Vector3 vector;
            Vector3 vector2;
            Vector3.Min(ref original.Min, ref additional.Min, out vector);
            Vector3.Max(ref original.Max, ref additional.Max, out vector2);
            result.Min = vector;
            result.Max = vector2;
        }

        public static BoundingBox CreateFromSphere(BoundingSphere sphere)
        {
            BoundingBox box;
            box.Min.X = sphere.Center.X - sphere.Radius;
            box.Min.Y = sphere.Center.Y - sphere.Radius;
            box.Min.Z = sphere.Center.Z - sphere.Radius;
            box.Max.X = sphere.Center.X + sphere.Radius;
            box.Max.Y = sphere.Center.Y + sphere.Radius;
            box.Max.Z = sphere.Center.Z + sphere.Radius;
            return box;
        }

        public static void CreateFromSphere(ref BoundingSphere sphere, out BoundingBox result)
        {
            result.Min.X = sphere.Center.X - sphere.Radius;
            result.Min.Y = sphere.Center.Y - sphere.Radius;
            result.Min.Z = sphere.Center.Z - sphere.Radius;
            result.Max.X = sphere.Center.X + sphere.Radius;
            result.Max.Y = sphere.Center.Y + sphere.Radius;
            result.Max.Z = sphere.Center.Z + sphere.Radius;
        }

        public static BoundingBox CreateFromPoints(IEnumerable<Vector3> points)
        {
            if (points == null)
            {
                throw new ArgumentNullException();
            }
            bool flag = false;
            Vector3 vector = new Vector3(float.MaxValue);
            Vector3 vector2 = new Vector3(float.MinValue);
            foreach (Vector3 vector3 in points)
            {
                Vector3 vector4 = vector3;
                Vector3.Min(ref vector, ref vector4, out vector);
                Vector3.Max(ref vector2, ref vector4, out vector2);
                flag = true;
            }
            if (!flag)
            {
                throw new ArgumentException("FrameworkResources.BoundingBoxZeroPoints");
            }
            return new BoundingBox(vector, vector2);
        }

        public bool Intersects(BoundingBox box)
        {
            if ((this.Max.X < box.Min.X) || (this.Min.X > box.Max.X))
            {
                return false;
            }
            if ((this.Max.Y < box.Min.Y) || (this.Min.Y > box.Max.Y))
            {
                return false;
            }
            if ((this.Max.Z < box.Min.Z) || (this.Min.Z > box.Max.Z))
            {
                return false;
            }
            return true;
        }

        public void Intersects(ref BoundingBox box, out bool result)
        {
            result = false;
            if ((((this.Max.X >= box.Min.X) && (this.Min.X <= box.Max.X)) && ((this.Max.Y >= box.Min.Y) && (this.Min.Y <= box.Max.Y))) && ((this.Max.Z >= box.Min.Z) && (this.Min.Z <= box.Max.Z)))
            {
                result = true;
            }
        }

        public bool Intersects(BoundingFrustum frustum)
        {
            if (null == frustum)
            {
                throw new ArgumentNullException("frustum", "FrameworkResources.NullNotAllowed");
            }
            return frustum.Intersects(this);
        }

        public PlaneIntersectionType Intersects(Plane plane)
        {
            Vector3 vector;
            Vector3 vector2;
            vector.X = (plane.Normal.X >= 0f) ? this.Min.X : this.Max.X;
            vector.Y = (plane.Normal.Y >= 0f) ? this.Min.Y : this.Max.Y;
            vector.Z = (plane.Normal.Z >= 0f) ? this.Min.Z : this.Max.Z;
            vector2.X = (plane.Normal.X >= 0f) ? this.Max.X : this.Min.X;
            vector2.Y = (plane.Normal.Y >= 0f) ? this.Max.Y : this.Min.Y;
            vector2.Z = (plane.Normal.Z >= 0f) ? this.Max.Z : this.Min.Z;
            float num = ((plane.Normal.X * vector.X) + (plane.Normal.Y * vector.Y)) + (plane.Normal.Z * vector.Z);
            if ((num + plane.D) > 0f)
            {
                return PlaneIntersectionType.Front;
            }
            num = ((plane.Normal.X * vector2.X) + (plane.Normal.Y * vector2.Y)) + (plane.Normal.Z * vector2.Z);
            if ((num + plane.D) < 0f)
            {
                return PlaneIntersectionType.Back;
            }
            return PlaneIntersectionType.Intersecting;
        }

        public void Intersects(ref Plane plane, out PlaneIntersectionType result)
        {
            Vector3 vector;
            Vector3 vector2;
            vector.X = (plane.Normal.X >= 0f) ? this.Min.X : this.Max.X;
            vector.Y = (plane.Normal.Y >= 0f) ? this.Min.Y : this.Max.Y;
            vector.Z = (plane.Normal.Z >= 0f) ? this.Min.Z : this.Max.Z;
            vector2.X = (plane.Normal.X >= 0f) ? this.Max.X : this.Min.X;
            vector2.Y = (plane.Normal.Y >= 0f) ? this.Max.Y : this.Min.Y;
            vector2.Z = (plane.Normal.Z >= 0f) ? this.Max.Z : this.Min.Z;
            float num = ((plane.Normal.X * vector.X) + (plane.Normal.Y * vector.Y)) + (plane.Normal.Z * vector.Z);
            if ((num + plane.D) > 0f)
            {
                result = PlaneIntersectionType.Front;
            }
            else
            {
                num = ((plane.Normal.X * vector2.X) + (plane.Normal.Y * vector2.Y)) + (plane.Normal.Z * vector2.Z);
                if ((num + plane.D) < 0f)
                {
                    result = PlaneIntersectionType.Back;
                }
                else
                {
                    result = PlaneIntersectionType.Intersecting;
                }
            }
        }

        public float? Intersects(Ray ray)
        {
            float num3;
            float num4;
            float num5;
            float num6;
            float num = 0f;
            float maxValue = float.MaxValue;
            if (Math.Abs(ray.Direction.X) < 1E-06f)
            {
                if ((ray.Position.X < this.Min.X) || (ray.Position.X > this.Max.X))
                {
                    return null;
                }
            }
            else
            {
                num3 = 1f / ray.Direction.X;
                num4 = (this.Min.X - ray.Position.X) * num3;
                num5 = (this.Max.X - ray.Position.X) * num3;
                if (num4 > num5)
                {
                    num6 = num4;
                    num4 = num5;
                    num5 = num6;
                }
                num = MathHelper.Max(num4, num);
                maxValue = MathHelper.Min(num5, maxValue);
                if (num > maxValue)
                {
                    return null;
                }
            }
            if (Math.Abs(ray.Direction.Y) < 1E-06f)
            {
                if ((ray.Position.Y < this.Min.Y) || (ray.Position.Y > this.Max.Y))
                {
                    return null;
                }
            }
            else
            {
                num3 = 1f / ray.Direction.Y;
                num4 = (this.Min.Y - ray.Position.Y) * num3;
                num5 = (this.Max.Y - ray.Position.Y) * num3;
                if (num4 > num5)
                {
                    num6 = num4;
                    num4 = num5;
                    num5 = num6;
                }
                num = MathHelper.Max(num4, num);
                maxValue = MathHelper.Min(num5, maxValue);
                if (num > maxValue)
                {
                    return null;
                }
            }
            if (Math.Abs(ray.Direction.Z) < 1E-06f)
            {
                if ((ray.Position.Z < this.Min.Z) || (ray.Position.Z > this.Max.Z))
                {
                    return null;
                }
            }
            else
            {
                num3 = 1f / ray.Direction.Z;
                num4 = (this.Min.Z - ray.Position.Z) * num3;
                num5 = (this.Max.Z - ray.Position.Z) * num3;
                if (num4 > num5)
                {
                    num6 = num4;
                    num4 = num5;
                    num5 = num6;
                }
                num = MathHelper.Max(num4, num);
                maxValue = MathHelper.Min(num5, maxValue);
                if (num > maxValue)
                {
                    return null;
                }
            }
            return new float?(num);
        }

        public void Intersects(ref Ray ray, out float? result)
        {
            float num3;
            float num4;
            float num5;
            float num6;
            result = 0;
            float num = 0f;
            float maxValue = float.MaxValue;
            if (Math.Abs(ray.Direction.X) < 1E-06f)
            {
                if ((ray.Position.X < this.Min.X) || (ray.Position.X > this.Max.X))
                {
                    return;
                }
            }
            else
            {
                num3 = 1f / ray.Direction.X;
                num4 = (this.Min.X - ray.Position.X) * num3;
                num5 = (this.Max.X - ray.Position.X) * num3;
                if (num4 > num5)
                {
                    num6 = num4;
                    num4 = num5;
                    num5 = num6;
                }
                num = MathHelper.Max(num4, num);
                maxValue = MathHelper.Min(num5, maxValue);
                if (num > maxValue)
                {
                    return;
                }
            }
            if (Math.Abs(ray.Direction.Y) < 1E-06f)
            {
                if ((ray.Position.Y < this.Min.Y) || (ray.Position.Y > this.Max.Y))
                {
                    return;
                }
            }
            else
            {
                num3 = 1f / ray.Direction.Y;
                num4 = (this.Min.Y - ray.Position.Y) * num3;
                num5 = (this.Max.Y - ray.Position.Y) * num3;
                if (num4 > num5)
                {
                    num6 = num4;
                    num4 = num5;
                    num5 = num6;
                }
                num = MathHelper.Max(num4, num);
                maxValue = MathHelper.Min(num5, maxValue);
                if (num > maxValue)
                {
                    return;
                }
            }
            if (Math.Abs(ray.Direction.Z) < 1E-06f)
            {
                if ((ray.Position.Z < this.Min.Z) || (ray.Position.Z > this.Max.Z))
                {
                    return;
                }
            }
            else
            {
                num3 = 1f / ray.Direction.Z;
                num4 = (this.Min.Z - ray.Position.Z) * num3;
                num5 = (this.Max.Z - ray.Position.Z) * num3;
                if (num4 > num5)
                {
                    num6 = num4;
                    num4 = num5;
                    num5 = num6;
                }
                num = MathHelper.Max(num4, num);
                maxValue = MathHelper.Min(num5, maxValue);
                if (num > maxValue)
                {
                    return;
                }
            }
            result = new float?(num);
        }

        public bool Intersects(BoundingSphere sphere)
        {
            Vector3 vector;
            float num;
            Vector3.Clamp(ref sphere.Center, ref this.Min, ref this.Max, out vector);
            Vector3.DistanceSquared(ref sphere.Center, ref vector, out num);
            return (num <= (sphere.Radius * sphere.Radius));
        }

        public void Intersects(ref BoundingSphere sphere, out bool result)
        {
            Vector3 vector;
            float num;
            Vector3.Clamp(ref sphere.Center, ref this.Min, ref this.Max, out vector);
            Vector3.DistanceSquared(ref sphere.Center, ref vector, out num);
            result = num <= (sphere.Radius * sphere.Radius);
        }

        public ContainmentType Contains(BoundingBox box)
        {
            if ((this.Max.X < box.Min.X) || (this.Min.X > box.Max.X))
            {
                return ContainmentType.Disjoint;
            }
            if ((this.Max.Y < box.Min.Y) || (this.Min.Y > box.Max.Y))
            {
                return ContainmentType.Disjoint;
            }
            if ((this.Max.Z < box.Min.Z) || (this.Min.Z > box.Max.Z))
            {
                return ContainmentType.Disjoint;
            }
            return (((((this.Min.X <= box.Min.X) && (box.Max.X <= this.Max.X)) && ((this.Min.Y <= box.Min.Y) && (box.Max.Y <= this.Max.Y))) && ((this.Min.Z <= box.Min.Z) && (box.Max.Z <= this.Max.Z))) ? ContainmentType.Contains : ContainmentType.Intersects);
        }

        public void Contains(ref BoundingBox box, out ContainmentType result)
        {
            result = ContainmentType.Disjoint;
            if ((((this.Max.X >= box.Min.X) && (this.Min.X <= box.Max.X)) && ((this.Max.Y >= box.Min.Y) && (this.Min.Y <= box.Max.Y))) && ((this.Max.Z >= box.Min.Z) && (this.Min.Z <= box.Max.Z)))
            {
                result = ((((this.Min.X <= box.Min.X) && (box.Max.X <= this.Max.X)) && ((this.Min.Y <= box.Min.Y) && (box.Max.Y <= this.Max.Y))) && ((this.Min.Z <= box.Min.Z) && (box.Max.Z <= this.Max.Z))) ? ContainmentType.Contains : ContainmentType.Intersects;
            }
        }

        public ContainmentType Contains(BoundingFrustum frustum)
        {
            if (null == frustum)
            {
                throw new ArgumentNullException("frustum", "FrameworkResources.NullNotAllowed");
            }
            if (!frustum.Intersects(this))
            {
                return ContainmentType.Disjoint;
            }
            foreach (Vector3 vector in frustum.cornerArray)
            {
                if (this.Contains(vector) == ContainmentType.Disjoint)
                {
                    return ContainmentType.Intersects;
                }
            }
            return ContainmentType.Contains;
        }

        public ContainmentType Contains(Vector3 point)
        {
            return (((((this.Min.X <= point.X) && (point.X <= this.Max.X)) && ((this.Min.Y <= point.Y) && (point.Y <= this.Max.Y))) && ((this.Min.Z <= point.Z) && (point.Z <= this.Max.Z))) ? ContainmentType.Contains : ContainmentType.Disjoint);
        }

        public void Contains(ref Vector3 point, out ContainmentType result)
        {
            result = ((((this.Min.X <= point.X) && (point.X <= this.Max.X)) && ((this.Min.Y <= point.Y) && (point.Y <= this.Max.Y))) && ((this.Min.Z <= point.Z) && (point.Z <= this.Max.Z))) ? ContainmentType.Contains : ContainmentType.Disjoint;
        }

        public ContainmentType Contains(BoundingSphere sphere)
        {
            Vector3 vector;
            float num;
            Vector3.Clamp(ref sphere.Center, ref this.Min, ref this.Max, out vector);
            Vector3.DistanceSquared(ref sphere.Center, ref vector, out num);
            float radius = sphere.Radius;
            if (num > (radius * radius))
            {
                return ContainmentType.Disjoint;
            }
            return ((((((this.Min.X + radius) <= sphere.Center.X) && (sphere.Center.X <= (this.Max.X - radius))) && (((this.Max.X - this.Min.X) > radius) && ((this.Min.Y + radius) <= sphere.Center.Y))) && (((sphere.Center.Y <= (this.Max.Y - radius)) && ((this.Max.Y - this.Min.Y) > radius)) && ((((this.Min.Z + radius) <= sphere.Center.Z) && (sphere.Center.Z <= (this.Max.Z - radius))) && ((this.Max.X - this.Min.X) > radius)))) ? ContainmentType.Contains : ContainmentType.Intersects);
        }

        public void Contains(ref BoundingSphere sphere, out ContainmentType result)
        {
            Vector3 vector;
            float num;
            Vector3.Clamp(ref sphere.Center, ref this.Min, ref this.Max, out vector);
            Vector3.DistanceSquared(ref sphere.Center, ref vector, out num);
            float radius = sphere.Radius;
            if (num > (radius * radius))
            {
                result = ContainmentType.Disjoint;
            }
            else
            {
                result = (((((this.Min.X + radius) <= sphere.Center.X) && (sphere.Center.X <= (this.Max.X - radius))) && (((this.Max.X - this.Min.X) > radius) && ((this.Min.Y + radius) <= sphere.Center.Y))) && (((sphere.Center.Y <= (this.Max.Y - radius)) && ((this.Max.Y - this.Min.Y) > radius)) && ((((this.Min.Z + radius) <= sphere.Center.Z) && (sphere.Center.Z <= (this.Max.Z - radius))) && ((this.Max.X - this.Min.X) > radius)))) ? ContainmentType.Contains : ContainmentType.Intersects;
            }
        }

        internal void SupportMapping(ref Vector3 v, out Vector3 result)
        {
            result.X = (v.X >= 0f) ? this.Max.X : this.Min.X;
            result.Y = (v.Y >= 0f) ? this.Max.Y : this.Min.Y;
            result.Z = (v.Z >= 0f) ? this.Max.Z : this.Min.Z;
        }

        public static bool operator ==(BoundingBox a, BoundingBox b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(BoundingBox a, BoundingBox b)
        {
            return ((a.Min != b.Min) || (a.Max != b.Max));
        }
    }


}
