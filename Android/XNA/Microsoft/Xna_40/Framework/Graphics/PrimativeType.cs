using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Graphics
{
    public enum PrimitiveType
    {
        // Summary:
        //     Renders the vertices as a collection of isolated points. This value is unsupported
        //     for indexed primitives.
        PointList = 1,
        //
        // Summary:
        //     Renders the vertices as a list of isolated straight line segments; the count
        //     may be any positive integer.
        LineList = 2,
        //
        // Summary:
        //     Renders the vertices as a single polyline; the count may be any positive
        //     integer.
        LineStrip = 3,
        //
        // Summary:
        //     Renders the specified vertices as a sequence of isolated triangles. Each
        //     group of three vertices defines a separate triangle. Back-face culling is
        //     affected by the current winding-order render state.
        TriangleList = 4,
        //
        // Summary:
        //     Renders the vertices as a triangle strip. The back-face culling flag is flipped
        //     automatically on even-numbered triangles.
        TriangleStrip = 5,
        //
        // Summary:
        //     Renders the vertices as a triangle fan.
        TriangleFan = 6,
    }
}
