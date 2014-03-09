using System;
using Microsoft.SPOT;
using Microsoft.Xna.Framework.Audio;

namespace Microsoft.Xna.Framework
{
    public class AudioDeviceManager : IAudioDeviceManager, IAudioDeviceService
    {
        private Game game;

        public AudioDeviceManager(Game game)
        {
            this.game = game;

            this.game.Services.AddService(typeof(IAudioDeviceManager), this);
            this.game.Services.AddService(typeof(IAudioDeviceService), this);
        }

        #region IAudioDeviceManager Members

        public bool BeginAudio()
        {
            return true;
        }

        public void CreateDevice()
        {
            AudioDevice = CreateAudioDevice();
            game.AudioDevice = AudioDevice;
            AudioDevice.Open();
        }

        /// <summary>
        /// This method creates an audio device.  Override this method to create an audio
        /// device that supports the target hardware.
        /// </summary>
        /// <returns>Returns an constructed audio device.</returns>
        public virtual AudioDevice CreateAudioDevice()
        {
            return new AudioDevice();
        }

        public void EndAudio()
        {
        }

        #endregion

        #region IAudioDeviceService Members

        public AudioDevice AudioDevice { get; private set; }

        #endregion
    }
}
