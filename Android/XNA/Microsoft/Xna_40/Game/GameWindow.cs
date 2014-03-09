using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation;

namespace Microsoft.Xna.Framework
{
    public class GameWindow
    {
        private Rectangle clientBounds;

        public bool AllowUserResizing
        {
            get { return false; }
        }

        public Rectangle ClientBounds
        {
            get { return clientBounds; }
        }

        public IntPtr Handle 
        {
            get { return new IntPtr(); } 
        }

        public string ScreenDeviceName 
        {
            get { return "Main"; } 
        }

        public string Title { get; set; }

        internal GameWindow()
        {
            this.clientBounds = new Rectangle(0, 0, SystemMetrics.ScreenWidth, SystemMetrics.ScreenHeight);
        }
    }
}
