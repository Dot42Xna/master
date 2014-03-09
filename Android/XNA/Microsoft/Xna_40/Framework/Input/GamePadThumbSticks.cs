using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Input
{
    public struct GamePadThumbSticks
    {
        public Vector2 Left { get; private set; }
        public Vector2 Right { get; private set; }

        internal GamePadThumbSticks(GamePadDPad DPad)
            : this()
        {
                Left = new Vector2(
                    AxisValue(DPad.Left == ButtonState.Pressed, DPad.Right == ButtonState.Pressed),
                    AxisValue(DPad.Up == ButtonState.Pressed, DPad.Down == ButtonState.Pressed));

                Right = Vector2.Zero;
        }

        public GamePadThumbSticks(Vector2 leftThumbstick, Vector2 rightThumbstick)
            : this()
        {
            Left = leftThumbstick;
            Right = rightThumbstick;
        }

        private static float AxisValue(bool a, bool b)
        {
            return (a ? -1.0F : 0.0F) + (b ? 1F : 0F);
        }


    }

}
