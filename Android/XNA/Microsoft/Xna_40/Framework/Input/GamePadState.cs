using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Input
{
    public struct GamePadState
    {
        //public GamePadState(GamePadThumbSticks thumbSticks, GamePadTriggers triggers, GamePadButtons buttons, GamePadDPad dPad);
        //public GamePadState(Vector2 leftThumbStick, Vector2 rightThumbStick, float leftTrigger, float rightTrigger, params Buttons[] buttons);

        public GamePadButtons Buttons { get; internal set; }
        public GamePadDPad DPad { get; internal set; }
        
        public bool IsConnected 
        { 
            get { return true; } 
        }
        
        //public int PacketNumber { get; }
        
        public GamePadThumbSticks ThumbSticks { get; internal set; }
        
        //public GamePadTriggers Triggers { get; }

        public bool IsButtonDown(Buttons button)
        {
            return ((int)Buttons.Buttons & (int)button) == (int)button;
        }
        public bool IsButtonUp(Buttons button)
        {
            return ((int)Buttons.Buttons & (int)button) == 0;
        }
    }
}
