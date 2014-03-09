using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation;
using Microsoft.SPOT.Presentation.Media;
using Media = Microsoft.SPOT.Presentation.Media;

namespace Microsoft.Xna.Framework.Graphics
{
    public class GraphicsDevice
    {
        public Bitmap backBuffer { get; private set; }
        public Viewport Viewport { get; private set; }
        public VertexDeclaration VertexDeclaration { get; set; }

        public int BackBufferWidth { get; private set; }
        public int BackBufferHeight { get; private set; }
        public int BackBufferDepth { get; private set; }

        public GraphicsDevice()
        {
            BackBufferWidth = SystemMetrics.ScreenWidth;
            BackBufferHeight = SystemMetrics.ScreenHeight;
            BackBufferDepth = SystemMetrics.ScreenColorDepth;

            backBuffer = new Bitmap(BackBufferWidth, BackBufferHeight);

            Viewport = new Viewport()
            {
                AspectRatio = ((float)SystemMetrics.ScreenWidth) / SystemMetrics.ScreenHeight,
                X = 0,
                Y = 0,
                Width = SystemMetrics.ScreenWidth,
                Height = SystemMetrics.ScreenHeight,
                MaxDepth = SystemMetrics.ScreenColorDepth,
                MinDepth = SystemMetrics.ScreenColorDepth,
                TitleSafeArea = new Rectangle(0, 0, SystemMetrics.ScreenWidth, SystemMetrics.ScreenHeight),
            };
        }

        private Media.Color ToSpotColor(Color color)
        {
            return ColorUtility.ColorFromRGB(color.R, color.G, color.B);
        }

        public void Clear(Color color)
        {
            Media.Color c = ToSpotColor(color);
            backBuffer.DrawRectangle(c, 0, 0, 0, backBuffer.Width, backBuffer.Height,
                0, 0, c, 0, 0, c, backBuffer.Width, backBuffer.Height, Bitmap.OpacityOpaque);
        }

        public void DrawTexture(Texture2D texture, int x, int y)
        {
            backBuffer.DrawImage(x, y, texture.GetBitmap(SpriteEffects.None), 0, 0, texture.Width, texture.Height);
        }

        public void DrawTexture(Texture2D texture, int xDst, int yDst, int xSrc, int ySrc, int width, int height)
        {
            backBuffer.DrawImage(xDst, yDst, texture.GetBitmap(SpriteEffects.None), xSrc, ySrc, width, height, Bitmap.OpacityOpaque);
        }

        public void DrawTexture(Texture2D texture, int xDst, int yDst, int xSrc, int ySrc, int width, int height, SpriteEffects effects)
        {
            backBuffer.DrawImage(xDst, yDst, texture.GetBitmap(effects), xSrc, ySrc, width, height, Bitmap.OpacityOpaque);
        }

        public void DrawText(string text, int x, int y, Color color, SpriteFont font, int width, int height, uint dtFlags)
        {
            Media.Color c = ToSpotColor(color);
            backBuffer.DrawTextInRect(text, x, y, width, height, dtFlags, c, font.Font);
        }

        public void DrawText(string text, int x, int y, Color color, SpriteFont font)
        {
            Media.Color c = ToSpotColor(color);
            backBuffer.DrawText(text, font.Font, c, x, y);
        }

        public void DrawUserPrimitives(PrimitiveType primitiveType, VertexPositionColor[] vertexData, int vertexOffset, int primitiveCount)
        {
            switch (primitiveType)
            {
                case PrimitiveType.PointList:
                    while (primitiveCount-- > 0)
                    {
                        Vector3 position = vertexData[vertexOffset].Position;
                        backBuffer.SetPixel((int)position.X, (int)position.Y,
                            ToSpotColor(vertexData[vertexOffset++].Color));
                    }
                    break;
                case PrimitiveType.LineList:
                    while (primitiveCount-- > 0)
                    {
                        Media.Color color = ToSpotColor(vertexData[vertexOffset].Color);
                        Vector3 start = vertexData[vertexOffset++].Position;
                        Vector3 end = vertexData[vertexOffset++].Position;
                        backBuffer.DrawLine(color, 1, (int)start.X, (int)start.Y, (int)end.X, (int)end.Y);
                    }
                    break;
                case PrimitiveType.TriangleList:
                    while (primitiveCount-- > 0)
                    {
                        Vector3 a = vertexData[vertexOffset].Position;
                        Media.Color ac = ToSpotColor(vertexData[vertexOffset++].Color);
                        Vector3 b = vertexData[vertexOffset].Position;
                        Media.Color bc = ToSpotColor(vertexData[vertexOffset++].Color);
                        Vector3 c = vertexData[vertexOffset].Position;
                        Media.Color cc = ToSpotColor(vertexData[vertexOffset++].Color);

                        backBuffer.DrawLine(ac, 1, (int)a.X, (int)a.Y, (int)b.X, (int)b.Y);
                        backBuffer.DrawLine(bc, 1, (int)b.X, (int)b.Y, (int)c.X, (int)c.Y);
                        backBuffer.DrawLine(cc, 1, (int)c.X, (int)c.Y, (int)a.X, (int)a.Y);
                    }
                    break;
                default:
                    throw new NotSupportedException
                        ("The specified primitiveType is not supported by this graphics device.");
            }
        }

        public void Present()
        {
            backBuffer.Flush();
        }
    }
}
