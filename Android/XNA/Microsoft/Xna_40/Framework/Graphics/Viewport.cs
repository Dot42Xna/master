using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Graphics
{
    public struct Viewport
    {
        public int X { get; internal set; }
        public int Y { get; internal set; }
        public int Width { get; internal set; }
        public int Height { get; internal set; }
        public float MinDepth { get; internal set; }
        public float MaxDepth { get; internal set; }
        public float AspectRatio { get; internal set; }
        public Rectangle TitleSafeArea { get; internal set; }
    }
}
