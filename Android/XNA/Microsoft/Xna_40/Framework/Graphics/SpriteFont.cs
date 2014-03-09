using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Graphics
{
    public class SpriteFont
    {
        internal Font Font { get; set; }
        public float Spacing { get; set; }

        public int LineSpacing
        {
            get { return Font.Height; }
        }

        private SpriteFont(Font font)
        {
            this.Font = font;
        }

        internal static SpriteFont FromFont(Font font)
        {
            return new SpriteFont(font);
        }

        public Vector2 MeasureString(string text)
        {
            int width;
            int height;

            Font.ComputeTextInRect(text, out width, out height);

            return new Vector2(width, height);
        }
    }
}
