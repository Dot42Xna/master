using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;

namespace Microsoft.Xna.Framework.Input
{
    public class GamePad
    {
        private static HardwareProvider provider;
        private static InputPort left;
        private static InputPort right;
        private static InputPort up;
        private static InputPort down;
        private static InputPort a;

        static GamePad()
        {
            provider = new HardwareProvider();
            left = new InputPort(provider.GetButtonPins(Button.VK_LEFT), true, Port.ResistorMode.PullUp);
            right = new InputPort(provider.GetButtonPins(Button.VK_RIGHT), true, Port.ResistorMode.PullUp);
            up = new InputPort(provider.GetButtonPins(Button.VK_UP), true, Port.ResistorMode.PullUp);
            down = new InputPort(provider.GetButtonPins(Button.VK_DOWN), true, Port.ResistorMode.PullUp);
            a = new InputPort(provider.GetButtonPins(Button.VK_SELECT), true, Port.ResistorMode.PullUp);
        }

        public static GamePadCapabilities GetCapabilities(PlayerIndex playerIndex)
        {
            return new GamePadCapabilities();
        }

        public static GamePadState GetState(PlayerIndex playerIndex)
        {
            bool upPressed = !up.Read();
            bool downPressed = !down.Read();
            bool rightPressed = !right.Read();
            bool leftPressed = !left.Read();
            bool aPressed = !a.Read();

            GamePadState state = new GamePadState();
            Buttons buttons = (upPressed ? Buttons.DPadUp : 0) |
                (downPressed ? Buttons.DPadDown : 0) |
                (leftPressed ? Buttons.DPadLeft : 0) |
                (rightPressed ? Buttons.DPadRight : 0) |
                (aPressed ? Buttons.A : 0);

            state.DPad = new GamePadDPad(buttons);
            state.ThumbSticks = new GamePadThumbSticks(state.DPad);
            state.Buttons = new GamePadButtons(buttons);

            return state;
        }

        public static GamePadState GetState(PlayerIndex playerIndex, GamePadDeadZone deadZoneMode)
        {
            return GetState(playerIndex);
        }

        public static bool SetVibration(PlayerIndex playerIndex, float leftMotor, float rightMotor)
        {
            return true; // ignore
        }
    }
}
