using System;

namespace Microsoft.Xna.Framework
{
    public struct Triangle
    {
        public Vector3 V0;
        public Vector3 V1;
        public Vector3 V2;

        public Triangle(Vector3 v0, Vector3 v1, Vector3 v2)
        {
            V0 = v0;
            V1 = v1;
            V2 = v2;
        }
    }

    public struct TriangleNormal
    {
        public Vector3 Vn0;
        public Vector3 Vn1;
        public Vector3 Vn2;

        public TriangleNormal(Vector3 vn0, Vector3 vn1, Vector3 vn2)
        {
            Vn0 = vn0;
            Vn1 = vn1;
            Vn2 = vn2;
        }
    }
}
