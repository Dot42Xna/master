using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
    [StructLayout(LayoutKind.Sequential)]
    public struct BoundingSphere : IEquatable<BoundingSphere>
    {
        public Vector3 Center;
        public float Radius;
        public BoundingSphere(Vector3 center, float radius)
        {
            if (radius < 0f)
            {
                throw new ArgumentException("FrameworkResources.NegativeRadius");
            }
            this.Center = center;
            this.Radius = radius;
        }

        public bool Equals(BoundingSphere other)
        {
            return ((this.Center == other.Center) && (this.Radius == other.Radius));
        }

        public override bool Equals(object obj)
        {
            bool flag = false;
            if (obj is BoundingSphere)
            {
                flag = this.Equals((BoundingSphere)obj);
            }
            return flag;
        }

        public override int GetHashCode()
        {
            return (this.Center.GetHashCode() + this.Radius.GetHashCode());
        }

        public override string ToString()
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            return string.Format(currentCulture, "{{Center:{0} Radius:{1}}}", new object[] { this.Center.ToString(), this.Radius.ToString(currentCulture) });
        }

        public static BoundingSphere CreateMerged(BoundingSphere original, BoundingSphere additional)
        {
            Vector3 vector;
            BoundingSphere sphere;
            Vector3.Subtract(ref additional.Center, ref original.Center, out vector);
            float num = vector.Length();
            float radius = original.Radius;
            float num3 = additional.Radius;
            if ((radius + num3) >= num)
            {
                if ((radius - num3) >= num)
                {
                    return original;
                }
                if ((num3 - radius) >= num)
                {
                    return additional;
                }
            }
            Vector3 vector2 = (Vector3)(vector * (1f / num));
            float num4 = MathHelper.Min(-radius, num - num3);
            float num6 = (MathHelper.Max(radius, num + num3) - num4) * 0.5f;
            sphere.Center = original.Center + ((Vector3)(vector2 * (num6 + num4)));
            sphere.Radius = num6;
            return sphere;
        }

        public static void CreateMerged(ref BoundingSphere original, ref BoundingSphere additional, out BoundingSphere result)
        {
            Vector3 vector;
            Vector3.Subtract(ref additional.Center, ref original.Center, out vector);
            float num = vector.Length();
            float radius = original.Radius;
            float num3 = additional.Radius;
            if ((radius + num3) >= num)
            {
                if ((radius - num3) >= num)
                {
                    result = original;
                    return;
                }
                if ((num3 - radius) >= num)
                {
                    result = additional;
                    return;
                }
            }
            Vector3 vector2 = (Vector3)(vector * (1f / num));
            float num4 = MathHelper.Min(-radius, num - num3);
            float num6 = (MathHelper.Max(radius, num + num3) - num4) * 0.5f;
            result.Center = original.Center + ((Vector3)(vector2 * (num6 + num4)));
            result.Radius = num6;
        }

        public static BoundingSphere CreateFromBoundingBox(BoundingBox box)
        {
            BoundingSphere sphere;
            float num;
            Vector3.Lerp(ref box.Min, ref box.Max, 0.5f, out sphere.Center);
            Vector3.Distance(ref box.Min, ref box.Max, out num);
            sphere.Radius = num * 0.5f;
            return sphere;
        }

        public static void CreateFromBoundingBox(ref BoundingBox box, out BoundingSphere result)
        {
            float num;
            Vector3.Lerp(ref box.Min, ref box.Max, 0.5f, out result.Center);
            Vector3.Distance(ref box.Min, ref box.Max, out num);
            result.Radius = num * 0.5f;
        }

        public static BoundingSphere CreateFromPoints(IEnumerable<Vector3> points)
        {
            Vector3 vector2;
            Vector3 vector3;
            Vector3 vector4;
            Vector3 vector5;
            Vector3 vector6;
            float num;
            float num2;
            float num3;
            Vector3 vector8;
            float num4;
            BoundingSphere sphere;
            if (points == null)
            {
                throw new ArgumentNullException("points");
            }
            IEnumerator<Vector3> enumerator = points.GetEnumerator();
            if (!enumerator.MoveNext())
            {
                throw new ArgumentException("FrameworkResources.BoundingSphereZeroPoints");
            }
            Vector3 vector = vector2 = vector3 = vector4 = vector5 = vector6 = enumerator.Current;
            foreach (Vector3 vector7 in points)
            {
                if (vector7.X < vector.X)
                {
                    vector = vector7;
                }
                if (vector7.X > vector2.X)
                {
                    vector2 = vector7;
                }
                if (vector7.Y < vector3.Y)
                {
                    vector3 = vector7;
                }
                if (vector7.Y > vector4.Y)
                {
                    vector4 = vector7;
                }
                if (vector7.Z < vector5.Z)
                {
                    vector5 = vector7;
                }
                if (vector7.Z > vector6.Z)
                {
                    vector6 = vector7;
                }
            }
            Vector3.Distance(ref vector2, ref vector, out num);
            Vector3.Distance(ref vector4, ref vector3, out num2);
            Vector3.Distance(ref vector6, ref vector5, out num3);
            if (num > num2)
            {
                if (num > num3)
                {
                    Vector3.Lerp(ref vector2, ref vector, 0.5f, out vector8);
                    num4 = num * 0.5f;
                }
                else
                {
                    Vector3.Lerp(ref vector6, ref vector5, 0.5f, out vector8);
                    num4 = num3 * 0.5f;
                }
            }
            else if (num2 > num3)
            {
                Vector3.Lerp(ref vector4, ref vector3, 0.5f, out vector8);
                num4 = num2 * 0.5f;
            }
            else
            {
                Vector3.Lerp(ref vector6, ref vector5, 0.5f, out vector8);
                num4 = num3 * 0.5f;
            }
            foreach (Vector3 vector7 in points)
            {
                Vector3 vector9;
                vector9.X = vector7.X - vector8.X;
                vector9.Y = vector7.Y - vector8.Y;
                vector9.Z = vector7.Z - vector8.Z;
                float num5 = vector9.Length();
                if (num5 > num4)
                {
                    num4 = (num4 + num5) * 0.5f;
                    vector8 += (Vector3)((1f - (num4 / num5)) * vector9);
                }
            }
            sphere.Center = vector8;
            sphere.Radius = num4;
            return sphere;
        }

        public static BoundingSphere CreateFromFrustum(BoundingFrustum frustum)
        {
            if (frustum == null)
            {
                throw new ArgumentNullException("frustum");
            }
            return CreateFromPoints(frustum.cornerArray);
        }

        public bool Intersects(BoundingBox box)
        {
            Vector3 vector;
            float num;
            Vector3.Clamp(ref this.Center, ref box.Min, ref box.Max, out vector);
            Vector3.DistanceSquared(ref this.Center, ref vector, out num);
            return (num <= (this.Radius * this.Radius));
        }

        public void Intersects(ref BoundingBox box, out bool result)
        {
            Vector3 vector;
            float num;
            Vector3.Clamp(ref this.Center, ref box.Min, ref box.Max, out vector);
            Vector3.DistanceSquared(ref this.Center, ref vector, out num);
            result = num <= (this.Radius * this.Radius);
        }

        public bool Intersects(BoundingFrustum frustum)
        {
            bool flag;
            if (null == frustum)
            {
                throw new ArgumentNullException("frustum", "FrameworkResources.NullNotAllowed");
            }
            frustum.Intersects(ref this, out flag);
            return flag;
        }

        public PlaneIntersectionType Intersects(Plane plane)
        {
            return plane.Intersects(this);
        }

        public void Intersects(ref Plane plane, out PlaneIntersectionType result)
        {
            plane.Intersects(ref this, out result);
        }

        public float? Intersects(Ray ray)
        {
            return ray.Intersects(this);
        }

        public void Intersects(ref Ray ray, out float? result)
        {
            ray.Intersects(ref this, out result);
        }

        public bool Intersects(BoundingSphere sphere)
        {
            float num;
            Vector3.DistanceSquared(ref this.Center, ref sphere.Center, out num);
            float radius = this.Radius;
            float num3 = sphere.Radius;
            return ((((radius * radius) + ((2f * radius) * num3)) + (num3 * num3)) > num);
        }

        public void Intersects(ref BoundingSphere sphere, out bool result)
        {
            float num;
            Vector3.DistanceSquared(ref this.Center, ref sphere.Center, out num);
            float radius = this.Radius;
            float num3 = sphere.Radius;
            result = (((radius * radius) + ((2f * radius) * num3)) + (num3 * num3)) > num;
        }

        public ContainmentType Contains(BoundingBox box)
        {
            Vector3 vector;
            if (!box.Intersects(this))
            {
                return ContainmentType.Disjoint;
            }
            float num = this.Radius * this.Radius;
            vector.X = this.Center.X - box.Min.X;
            vector.Y = this.Center.Y - box.Max.Y;
            vector.Z = this.Center.Z - box.Max.Z;
            if (vector.LengthSquared() > num)
            {
                return ContainmentType.Intersects;
            }
            vector.X = this.Center.X - box.Max.X;
            vector.Y = this.Center.Y - box.Max.Y;
            vector.Z = this.Center.Z - box.Max.Z;
            if (vector.LengthSquared() > num)
            {
                return ContainmentType.Intersects;
            }
            vector.X = this.Center.X - box.Max.X;
            vector.Y = this.Center.Y - box.Min.Y;
            vector.Z = this.Center.Z - box.Max.Z;
            if (vector.LengthSquared() > num)
            {
                return ContainmentType.Intersects;
            }
            vector.X = this.Center.X - box.Min.X;
            vector.Y = this.Center.Y - box.Min.Y;
            vector.Z = this.Center.Z - box.Max.Z;
            if (vector.LengthSquared() > num)
            {
                return ContainmentType.Intersects;
            }
            vector.X = this.Center.X - box.Min.X;
            vector.Y = this.Center.Y - box.Max.Y;
            vector.Z = this.Center.Z - box.Min.Z;
            if (vector.LengthSquared() > num)
            {
                return ContainmentType.Intersects;
            }
            vector.X = this.Center.X - box.Max.X;
            vector.Y = this.Center.Y - box.Max.Y;
            vector.Z = this.Center.Z - box.Min.Z;
            if (vector.LengthSquared() > num)
            {
                return ContainmentType.Intersects;
            }
            vector.X = this.Center.X - box.Max.X;
            vector.Y = this.Center.Y - box.Min.Y;
            vector.Z = this.Center.Z - box.Min.Z;
            if (vector.LengthSquared() > num)
            {
                return ContainmentType.Intersects;
            }
            vector.X = this.Center.X - box.Min.X;
            vector.Y = this.Center.Y - box.Min.Y;
            vector.Z = this.Center.Z - box.Min.Z;
            if (vector.LengthSquared() > num)
            {
                return ContainmentType.Intersects;
            }
            return ContainmentType.Contains;
        }

        public void Contains(ref BoundingBox box, out ContainmentType result)
        {
            bool flag;
            box.Intersects(ref this, out flag);
            if (!flag)
            {
                result = ContainmentType.Disjoint;
            }
            else
            {
                Vector3 vector;
                float num = this.Radius * this.Radius;
                result = ContainmentType.Intersects;
                vector.X = this.Center.X - box.Min.X;
                vector.Y = this.Center.Y - box.Max.Y;
                vector.Z = this.Center.Z - box.Max.Z;
                if (vector.LengthSquared() <= num)
                {
                    vector.X = this.Center.X - box.Max.X;
                    vector.Y = this.Center.Y - box.Max.Y;
                    vector.Z = this.Center.Z - box.Max.Z;
                    if (vector.LengthSquared() <= num)
                    {
                        vector.X = this.Center.X - box.Max.X;
                        vector.Y = this.Center.Y - box.Min.Y;
                        vector.Z = this.Center.Z - box.Max.Z;
                        if (vector.LengthSquared() <= num)
                        {
                            vector.X = this.Center.X - box.Min.X;
                            vector.Y = this.Center.Y - box.Min.Y;
                            vector.Z = this.Center.Z - box.Max.Z;
                            if (vector.LengthSquared() <= num)
                            {
                                vector.X = this.Center.X - box.Min.X;
                                vector.Y = this.Center.Y - box.Max.Y;
                                vector.Z = this.Center.Z - box.Min.Z;
                                if (vector.LengthSquared() <= num)
                                {
                                    vector.X = this.Center.X - box.Max.X;
                                    vector.Y = this.Center.Y - box.Max.Y;
                                    vector.Z = this.Center.Z - box.Min.Z;
                                    if (vector.LengthSquared() <= num)
                                    {
                                        vector.X = this.Center.X - box.Max.X;
                                        vector.Y = this.Center.Y - box.Min.Y;
                                        vector.Z = this.Center.Z - box.Min.Z;
                                        if (vector.LengthSquared() <= num)
                                        {
                                            vector.X = this.Center.X - box.Min.X;
                                            vector.Y = this.Center.Y - box.Min.Y;
                                            vector.Z = this.Center.Z - box.Min.Z;
                                            if (vector.LengthSquared() <= num)
                                            {
                                                result = ContainmentType.Contains;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
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
            float num = this.Radius * this.Radius;
            foreach (Vector3 vector in frustum.cornerArray)
            {
                Vector3 vector2;
                vector2.X = vector.X - this.Center.X;
                vector2.Y = vector.Y - this.Center.Y;
                vector2.Z = vector.Z - this.Center.Z;
                if (vector2.LengthSquared() > num)
                {
                    return ContainmentType.Intersects;
                }
            }
            return ContainmentType.Contains;
        }

        public ContainmentType Contains(Vector3 point)
        {
            return ((Vector3.DistanceSquared(point, this.Center) < (this.Radius * this.Radius)) ? ContainmentType.Contains : ContainmentType.Disjoint);
        }

        public void Contains(ref Vector3 point, out ContainmentType result)
        {
            float num;
            Vector3.DistanceSquared(ref point, ref this.Center, out num);
            result = (num < (this.Radius * this.Radius)) ? ContainmentType.Contains : ContainmentType.Disjoint;
        }

        public ContainmentType Contains(BoundingSphere sphere)
        {
            float num;
            Vector3.Distance(ref this.Center, ref sphere.Center, out num);
            float radius = this.Radius;
            float num3 = sphere.Radius;
            return (((radius + num3) >= num) ? (((radius - num3) >= num) ? ContainmentType.Contains : ContainmentType.Intersects) : ContainmentType.Disjoint);
        }

        public void Contains(ref BoundingSphere sphere, out ContainmentType result)
        {
            float num;
            Vector3.Distance(ref this.Center, ref sphere.Center, out num);
            float radius = this.Radius;
            float num3 = sphere.Radius;
            result = ((radius + num3) >= num) ? (((radius - num3) >= num) ? ContainmentType.Contains : ContainmentType.Intersects) : ContainmentType.Disjoint;
        }

        internal void SupportMapping(ref Vector3 v, out Vector3 result)
        {
            float num = v.Length();
            float num2 = this.Radius / num;
            result.X = this.Center.X + (v.X * num2);
            result.Y = this.Center.Y + (v.Y * num2);
            result.Z = this.Center.Z + (v.Z * num2);
        }

        public BoundingSphere Transform(Matrix matrix)
        {
            BoundingSphere sphere = new BoundingSphere
            {
                Center = Vector3.Transform(this.Center, matrix)
            };
            float num = ((matrix.M11 * matrix.M11) + (matrix.M12 * matrix.M12)) + (matrix.M13 * matrix.M13);
            float num2 = ((matrix.M21 * matrix.M21) + (matrix.M22 * matrix.M22)) + (matrix.M23 * matrix.M23);
            float num3 = ((matrix.M31 * matrix.M31) + (matrix.M32 * matrix.M32)) + (matrix.M33 * matrix.M33);
            float num4 = Math.Max(num, Math.Max(num2, num3));
            sphere.Radius = this.Radius * ((float)Math.Sqrt((double)num4));
            return sphere;
        }

        public void Transform(ref Matrix matrix, out BoundingSphere result)
        {
            result.Center = Vector3.Transform(this.Center, matrix);
            float num = ((matrix.M11 * matrix.M11) + (matrix.M12 * matrix.M12)) + (matrix.M13 * matrix.M13);
            float num2 = ((matrix.M21 * matrix.M21) + (matrix.M22 * matrix.M22)) + (matrix.M23 * matrix.M23);
            float num3 = ((matrix.M31 * matrix.M31) + (matrix.M32 * matrix.M32)) + (matrix.M33 * matrix.M33);
            float num4 = Math.Max(num, Math.Max(num2, num3));
            result.Radius = this.Radius * ((float)Math.Sqrt((double)num4));
        }

        public static bool operator ==(BoundingSphere a, BoundingSphere b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(BoundingSphere a, BoundingSphere b)
        {
            return ((a.Center != b.Center) || !(a.Radius == b.Radius));
        }
    }


}
