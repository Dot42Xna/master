using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Input
{
    public enum KeyState { Up, Down }

    public class KeyboardState
    {
        private int[] state = new int[3];

        public KeyboardState(params Keys[] keys)
        {
            foreach (Keys k in keys)
            {
                SetKey(k, KeyState.Down);
            }
        }

        private void SetKey(Keys key, KeyState keyState)
        {
            int index = ((int)key) - 0x20;
            int offset = index & 0x1f;

            if (keyState == KeyState.Down)
            {
                state[index >> 5] |= 1 << offset;
            }
            else
            {
                state[index >> 5] &= ~(1 << offset);
            }
        }

        public KeyState this[Keys key]
        {
            get 
            {
                int index = ((int)key) - 0x20;
                int offset = index & 0x1f;

                return ((state[index >> 5] & (1 << offset)) == 0) ? KeyState.Up : KeyState.Down;
            }
        }

        public bool IsKeyDown(Keys key)
        {
            return this[key] == KeyState.Down;
        }

        public bool IsKeyUp(Keys key)
        {
            return this[key] == KeyState.Up;
        }


    }
}
