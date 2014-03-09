using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Input
{
    public struct GamePadButtons
    {
        internal Buttons Buttons { get; set; }

        private ButtonState GetButtonState(Buttons button)
        {
            return (((int)Buttons & (int)Buttons.A) == (int)Buttons.A) ? ButtonState.Pressed : ButtonState.Released;
        }

        public GamePadButtons(Buttons buttons)
            : this()
        {
            this.Buttons = buttons;
        }

        public ButtonState A 
        {
            get { return GetButtonState(Buttons.A); } 
        }

        public ButtonState B
        {
            get { return GetButtonState(Buttons.B); } 
        }

        public ButtonState Back
        {
            get { return GetButtonState(Buttons.Back); } 
        }

        public ButtonState X
        {
            get { return GetButtonState(Buttons.X); } 
        }

        public ButtonState Y
        {
            get { return GetButtonState(Buttons.Y); } 
        }

        public ButtonState Start
        {
            get { return GetButtonState(Buttons.Start); } 
        }

        public ButtonState LeftShoulder
        {
            get { return GetButtonState(Buttons.LeftShoulder); } 
        }

        public ButtonState LeftStick
        {
            get { return GetButtonState(Buttons.LeftStick); } 
        }

        public ButtonState RightShoulder
        {
            get { return GetButtonState(Buttons.RightShoulder); } 
        }

        public ButtonState RightStick
        {
            get { return GetButtonState(Buttons.RightStick); } 
        }

        public ButtonState BigButton
        {
            get { return GetButtonState(Buttons.BigButton); } 
        }
    }
}
