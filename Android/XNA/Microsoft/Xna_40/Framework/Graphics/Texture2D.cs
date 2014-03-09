using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation.Media;

namespace Microsoft.Xna.Framework.Graphics
{
    public class Texture2D : Texture
    {
        private Bitmap bitmap;
        private Bitmap flipHBitmap;
        private Bitmap flipVBitmap;
        private Bitmap flipHVBitmap;
        public int Height { get; private set; }
        public int Width { get; private set; }

        internal protected Texture2D()
        {
            this.ResourceType = ResourceType.Texture2D;
        }

        public Texture2D(GraphicsDevice graphicsDevice, int width, int height)
            : this()
        {
            this.GraphicsDevice = graphicsDevice;
            this.Width = width;
            this.Height = height;
            this.bitmap = new Bitmap(width, height);

            BuildFlips(width, height);
        }

        public static Texture2D FromBitmap(GraphicsDevice graphicsDevice, Bitmap bitmap)
        {
            Texture2D texture = new Texture2D();
            
            texture.bitmap = new Bitmap(bitmap.Width,bitmap.Height);
            texture.bitmap.DrawImage(0, 0, bitmap, 0, 0, bitmap.Width, bitmap.Height);
            texture.bitmap.MakeTransparent(ColorUtility.ColorFromRGB(0xFF, 00, 0xFF));
            texture.Height = bitmap.Height;
            texture.Width = bitmap.Width;

            texture.BuildFlips(bitmap.Width, bitmap.Height);

            return texture;
        }

        internal protected Bitmap GetBitmap(SpriteEffects effects)
        {
            if ((effects & SpriteEffects.FlipHorizontally) == SpriteEffects.FlipHorizontally)
            {
                if (flipHBitmap == null)
                {
                    BuildFlipH();
                }
                return flipHBitmap;
            }
            else if ((effects & SpriteEffects.FlipVertically) == SpriteEffects.FlipVertically)
            {
                if (flipVBitmap == null)
                {
                    BuildFlipV();
                }
                return flipVBitmap;
            }
            else if ((effects & SpriteEffects.FlipHorizontally) == SpriteEffects.FlipHorizontally
                && (effects & SpriteEffects.FlipVertically) == SpriteEffects.FlipVertically)
            {
                if (flipHVBitmap == null)
                {
                    BuildFlipHV();
                }
                return flipHVBitmap;
            }

            return bitmap;
        }

        #region SpriteEffect Support

        private void BuildFlips(int width, int height)
        {
            if (width * height <= 1024)
            {
                BuildFlipH();
                BuildFlipV();
                BuildFlipHV();
            }
            else
            {
                this.flipHBitmap = null;
                this.flipVBitmap = null;
                this.flipHVBitmap = null;
            }
        }

        private void BuildFlipHV()
        {
            flipHVBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    flipHVBitmap.SetPixel(bitmap.Width - x - 1, bitmap.Height - y - 1, bitmap.GetPixel(x, y));
                }
            }
            flipHBitmap.MakeTransparent(ColorUtility.ColorFromRGB(0xFF, 00, 0xFF));
        }

        private void BuildFlipV()
        {
            flipVBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    flipVBitmap.SetPixel(x, bitmap.Height - y - 1, bitmap.GetPixel(x, y));
                }
            }
            flipVBitmap.MakeTransparent(ColorUtility.ColorFromRGB(0xFF, 00, 0xFF));
        }

        private void BuildFlipH()
        {
            flipHBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    flipHBitmap.SetPixel(bitmap.Width - x - 1, y, bitmap.GetPixel(x, y));
                }
            }
            flipHBitmap.MakeTransparent(ColorUtility.ColorFromRGB(0xFF, 00, 0xFF));
        }

        #endregion
    }
}
