using System;
using Microsoft.SPOT;
using System.Collections;

namespace Microsoft.Xna.Framework.Graphics
{
    public struct VertexPositionColor
    {
        public Color Color;
        public Vector3 Position;

        public static readonly VertexElement[] VertexElements;

        static VertexPositionColor()
        {
            VertexElements = null;
        }

        public VertexPositionColor(Vector3 position, Color color)
        {
            this.Position = position;
            this.Color = color;
        }

        public static bool operator !=(VertexPositionColor left, VertexPositionColor right)
        {
            return (left.Position != right.Position) || (left.Color != right.Color);
        }
        public static bool operator ==(VertexPositionColor left, VertexPositionColor right)
        {
            return (left.Position == right.Position) && (left.Color == right.Color);
        }

        public override bool Equals(object obj)
        {
            return this == (VertexPositionColor)obj;
        }

        public override int GetHashCode()
        {
            return this.Position.GetHashCode() + this.Color.GetHashCode();
        }

        public override string ToString()
        {
            return "{Pos:" + Position.ToString() + ", Color:" + Color.ToString() + "}";
        }
    }
}
