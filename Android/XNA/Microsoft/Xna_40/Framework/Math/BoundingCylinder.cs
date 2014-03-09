
using System;
using System.Collections.Generic;
using System.Globalization;


namespace Microsoft.Xna.Framework
{
    [Serializable]
    public struct BoundingCylinder : IEquatable<BoundingCylinder>
    {
        #region Public Fields

        public Vector2 Center;
        public float MaxZ;
        public float MinZ;
        public float Radius;

        #endregion Public Fields

        #region Public Constructors

        public BoundingCylinder( Vector3 cp, float height, float radius )
        {
            Center.X = cp.X;
            Center.Y = cp.Y;

            Radius = radius;

            MinZ = cp.Z;
            MaxZ = cp.Z + height;
        }

        #endregion Public Constructors

        #region Public Methods

        public static BoundingCylinder Empty = new BoundingCylinder(new Vector3(0, 0, 0), 0, 0);

        public ContainmentType Contains(BoundingBox box)
        {
            // above or below
            if (box.Min.Z > MaxZ || box.Max.Z < MinZ)
                return ContainmentType.Disjoint;

            // for containment it MUST fit in Z
            if (MaxZ <= box.Max.Z && MinZ >= box.Min.Z)
            {
                if (!pointInXY(box.Max.X, box.Max.Y) || !pointInXY(box.Min.X, box.Max.Y) || !pointInXY(box.Min.X, box.Min.Y) || !pointInXY(box.Max.X, box.Min.Y))
                    return ContainmentType.Intersects;

                return ContainmentType.Contains;
            }

            if (!pointInXY(box.Max.X, box.Max.Y) || !pointInXY(box.Min.X, box.Max.Y) || !pointInXY(box.Min.X, box.Min.Y) || !pointInXY(box.Max.X, box.Min.Y))
                return ContainmentType.Disjoint;

            return ContainmentType.Intersects;
        }

        public bool Equals(BoundingCylinder other)
        {
            return this.Center == other.Center && this.Radius == other.Radius && this.MinZ == other.MinZ && this.MaxZ == other.MaxZ;
        }

        public override bool Equals(object obj)
        {
            if (obj is BoundingCylinder)
                return this.Equals((BoundingCylinder)obj);

            return false;
        }

        public override int GetHashCode()
        {
            return this.Center.GetHashCode() + this.Radius.GetHashCode() + this.MaxZ.GetHashCode() + this.MinZ.GetHashCode();
        }

        public static bool operator ==(BoundingCylinder a, BoundingCylinder b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(BoundingCylinder a, BoundingCylinder b)
        {
            return !a.Equals(b);
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{Center:{0} Radius:{1} MinZ:{2} MaxZ:{3}}}", this.Center.ToString(), this.Radius.ToString(),this.MinZ.ToString(),this.MaxZ.ToString());
        }

        #endregion Public Methods

        #region Private Methods

        bool pointInXY(float X, float Y)
        {
            float distSquare = (X - Center.X) * (X - Center.X) + (Y - Center.Y) * (Y - Center.Y);
            return distSquare <= Radius * Radius;
        }

        #endregion Private Methods
    }
}