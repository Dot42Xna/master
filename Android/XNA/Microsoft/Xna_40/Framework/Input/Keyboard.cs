using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Input
{
    public static class Keyboard
    {
        public static KeyboardState GetState()
        {
            return GetState((PlayerIndex)0xF);
        }

        public static KeyboardState GetState(PlayerIndex playerIndex)
        {
            return new KeyboardState(new Keys[] { });
        }
    }
}
