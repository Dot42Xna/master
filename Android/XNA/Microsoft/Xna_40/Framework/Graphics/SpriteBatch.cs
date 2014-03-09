using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Graphics
{
    public class SpriteBatch
    {
        private SpriteBlendMode blendMode;
        private SpriteSortMode sortMode;
        private SaveStateMode saveMode;

        private enum EntryType { Draw, DrawRectangle, DrawString }
        private class Entry
        {
            public EntryType EntryType;
            public Texture2D Texture;
            public Vector2 Position;
            public Rectangle SourceRectangle;
            public Color Color;
            public float Rotation;
            public Vector2 Scale;
            public SpriteEffects Effects;
            public float LayerDepth;
            public string Text;
            public SpriteFont SpriteFont;
            public Entry Next;
        }
        private Entry start;
        private Entry insertPoint;

        public string Name { get; set; }
        public object Tag { get; set; }
        public GraphicsDevice GraphicsDevice { get; private set; }

        public SpriteBatch(GraphicsDevice graphicsDevice)
        {
            this.GraphicsDevice = graphicsDevice;
        }

        public void Begin()
        {
            Begin(SpriteBlendMode.AlphaBlend, SpriteSortMode.Deferred, SaveStateMode.None);
        }

        public void Begin(SpriteBlendMode blendMode)
        {
            Begin(blendMode, SpriteSortMode.Deferred, SaveStateMode.None);
        }

        public void Begin(SpriteBlendMode blendMode, SpriteSortMode sortMode, SaveStateMode saveMode)
        {
            this.blendMode = blendMode; // ignored for now
            this.sortMode = sortMode;
            this.saveMode = saveMode; // ignored for now
            this.start = null;
            this.insertPoint = null;
        }

        public void Draw(Texture2D texture, Vector2 position, Color color)
        {
            if (sortMode == SpriteSortMode.Immediate)
            {
                GraphicsDevice.DrawTexture(texture, (int)position.X, (int)position.Y, 0, 0, texture.Width, texture.Height, 0);
                return;
            }

            InsertEntry(new Entry()
            {
                EntryType = EntryType.Draw,
                Texture = texture,
                Position = position,
                Color = color,
            });
        }

        public void Draw(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
        {
            if (!sourceRectangle.HasValue)
            {
                sourceRectangle = new Rectangle(0, 0, texture.Width, texture.Height);
            }

            if (sortMode == SpriteSortMode.Immediate)
            {
                GraphicsDevice.DrawTexture(texture, (int)(position.X-origin.X), (int)(position.Y-origin.Y), sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width, sourceRectangle.Height);
                return;
            }

            InsertEntry(new Entry()
            {
                EntryType = EntryType.DrawRectangle,
                Texture = texture,
                Position = new Vector2(position.X - origin.X, position.Y - origin.Y),
                Color = color,
                SourceRectangle = sourceRectangle,
                Effects = effects,
                Rotation = rotation,
                Scale = new Vector2(scale, scale),
                LayerDepth = layerDepth,
            });
        }

        //public void Draw(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color,
        //                    float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects,
        //                    float layerDepth)
        //{
        //    if (sortMode == SpriteSortMode.Immediate)
        //    {
        //        //GraphicsDevice.DrawText(texture, (int)position.X, (int)position.Y, 0, 0, texture.Width, texture.Height, 0);
        //        return;
        //    }

        //    InsertEntry(new Entry()
        //    {
        //        EntryType = EntryType.Draw,
        //        Texture = texture,
        //        Position = position,
        //        Color = color,
        //    });
        //}

        public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color)
        {
            if (sortMode == SpriteSortMode.Immediate)
            {
                GraphicsDevice.DrawText(text, (int)position.X, (int)position.Y, color, spriteFont);
                return;
            }

            InsertEntry(new Entry()
            {
                EntryType = EntryType.DrawString,
                SpriteFont = spriteFont,
                Text = text,
                Position = position,
                Color = color,
            });

        }

        public void End()
        {
            if (sortMode != SpriteSortMode.Immediate)
            {
                Entry entry = start;
                while (entry != null)
                {
                    switch (entry.EntryType)
                    {
                        case EntryType.Draw:
                            GraphicsDevice.DrawTexture(entry.Texture,
                                (int)entry.Position.X, (int)entry.Position.Y);
                            break;
                        case EntryType.DrawRectangle:
                            GraphicsDevice.DrawTexture(entry.Texture, 
                                (int)entry.Position.X, (int)entry.Position.Y,
                                entry.SourceRectangle.X, entry.SourceRectangle.Y,
                                entry.SourceRectangle.Width, entry.SourceRectangle.Height,
                                entry.Effects);
                            break;
                        case EntryType.DrawString:
                            GraphicsDevice.DrawText(entry.Text, 
                                (int)entry.Position.X, (int)entry.Position.Y, 
                                entry.Color, entry.SpriteFont);
                            break;
                        default:
                            break;
                    }
                    entry = entry.Next;
                }
            }
        }

        private void InsertEntry(Entry entry)
        {
            if (insertPoint != null)
            {
                insertPoint.Next = entry;
                insertPoint = insertPoint.Next;
            }
            else
            {
                start = entry;
                insertPoint = start;
            }
        }
    }
}
