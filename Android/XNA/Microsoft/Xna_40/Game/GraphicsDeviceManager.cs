using System;
using Microsoft.SPOT;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.SPOT.Presentation;

namespace Microsoft.Xna.Framework
{
    public class GraphicsDeviceManager : IGraphicsDeviceManager, IGraphicsDeviceService
    {
        private Game game;

        public static readonly int DefaultBackBufferHeight;
        public static readonly int DefaultBackBufferWidth;

        public bool IsFullScreen 
        { 
            get { return true; } 
            set { ; } 
        }
        public int PreferredBackBufferHeight { get; set; }
        public int PreferredBackBufferWidth { get; set; }
        public bool SynchronizeWithVerticalRetrace { get; set; }

        static GraphicsDeviceManager()
        {
            DefaultBackBufferHeight = SystemMetrics.ScreenHeight;
            DefaultBackBufferWidth = SystemMetrics.ScreenWidth;
        }

        public GraphicsDeviceManager(Game game)
        {
            this.game = game;
            this.PreferredBackBufferHeight = DefaultBackBufferHeight;
            this.PreferredBackBufferWidth = DefaultBackBufferWidth;
            this.game.Services.AddService(typeof(IGraphicsDeviceManager), this);
            this.game.Services.AddService(typeof(IGraphicsDeviceService), this);
        }

        #region IGraphicsDeviceManager Members

        public bool BeginDraw()
        {
            throw new NotImplementedException();
        }

        public void CreateDevice()
        {
            GraphicsDevice = new GraphicsDevice();
            game.GraphicsDevice = GraphicsDevice;
        }

        public void EndDraw()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IGraphicsDeviceService Members

        public GraphicsDevice GraphicsDevice { get; private set; }

        #endregion
    }
}
