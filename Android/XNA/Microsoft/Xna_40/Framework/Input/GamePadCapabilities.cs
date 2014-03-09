using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Input
{
    public struct GamePadCapabilities
    {
        public GamePadType GamePadType 
        { 
            get { return GamePadType.GamePad; } 
        }

        public bool IsConnected
        {
            get { return true; }
        }

        public bool HasAButton
        {
            get { return true; }
        }

        public bool HasBackButton
        {
            get { return false; }
        }

        public bool HasBButton
        {
            get { return true; }
        }

        public bool HasDPadDownButton
        {
            get { return true; }
        }

        public bool HasDPadLeftButton
        {
            get { return true; }
        }

        public bool HasDPadRightButton
        {
            get { return true; }
        }

        public bool HasDPadUpButton
        {
            get { return true; }
        }

        public bool HasLeftShoulderButton
        {
            get { return false; }
        }

        public bool HasLeftStickButton
        {
            get { return true; }
        }

        public bool HasRightShoulderButton
        {
            get { return false; }
        }

        public bool HasRightStickButton
        {
            get { return false; }
        }

        public bool HasStartButton
        {
            get { return false; }
        }

        public bool HasXButton
        {
            get { return true; }
        }

        public bool HasYButton
        {
            get { return true; }
        }

        public bool HasBigButton
        {
            get { return false; }
        }

        public bool HasLeftXThumbStick
        {
            get { return true; }
        }

        public bool HasLeftYThumbStick
        {
            get { return true; }
        }

        public bool HasRightXThumbStick
        {
            get { return false; }
        }

        public bool HasRightYThumbStick
        {
            get { return false; }
        }

        public bool HasLeftTrigger
        {
            get { return false; }
        }

        public bool HasRightTrigger
        {
            get { return false; }
        }

        public bool HasLeftVibrationMotor
        {
            get { return false; }
        }

        public bool HasRightVibrationMotor
        {
            get { return false; }
        }

        public bool HasVoiceSupport
        {
            get { return false; }
        }
    }
}
