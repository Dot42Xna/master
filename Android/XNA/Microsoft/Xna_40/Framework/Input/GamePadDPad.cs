using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Input
{
    public class GamePadDPad
    {
        public ButtonState Up { get; private set; }
        public ButtonState Down { get; private set; }
        public ButtonState Right { get; private set; }
        public ButtonState Left { get; private set; }

        internal GamePadDPad(Buttons buttons)
        {
            Up = (((int)buttons & (int)Buttons.DPadUp) != 0) ? ButtonState.Pressed : ButtonState.Released;
            Down = (((int)buttons & (int)Buttons.DPadDown) != 0) ? ButtonState.Pressed : ButtonState.Released;
            Left = (((int)buttons & (int)Buttons.DPadLeft) != 0) ? ButtonState.Pressed : ButtonState.Released;
            Right = (((int)buttons & (int)Buttons.DPadRight) != 0) ? ButtonState.Pressed : ButtonState.Released;
        }

        public GamePadDPad(ButtonState upValue, ButtonState downValue, ButtonState leftValue, ButtonState rightValue)
        {
            Up = upValue;
            Down = downValue;
            Left = leftValue;
            Right = rightValue;
        }
    }
}
