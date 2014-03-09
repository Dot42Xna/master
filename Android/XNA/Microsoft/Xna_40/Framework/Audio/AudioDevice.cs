using System;
using Microsoft.SPOT;
using Microsoft.Xna.Framework.Microsoft.Xna.Framework.Media;

namespace Microsoft.Xna.Framework.Audio
{
    /// <summary>
    /// The AudioDevice class should be subclassed to support the audio hardware on the
    /// target device.
    /// </summary>
    public class AudioDevice
    {
        /// <summary>
        /// Is the audio data repeating when finished?
        /// </summary>
        public virtual bool IsRepeating { get; set; }

        /// <summary>
        /// Is the audio muted?
        /// </summary>
        public virtual bool IsMuted { get; set; }

        /// <summary>
        /// Sets the volume (0.0f silence to 1.0f full volume)
        /// </summary>
        public virtual float Volume { get; set; }


        public AudioDevice()
        {
            MediaPlayer.AudioDevice = this;
        }

        /// <summary>
        /// Open or initialize audio hardware to prepare for sound generation
        /// </summary>
        public virtual void Open()
        {
        }

        /// <summary>
        /// Play the specified audio stream
        /// </summary>
        /// <param name="audioData">The audio stream to play</param>
        public virtual void Play(byte[] audioData)
        {
        }

        /// <summary>
        /// Stop the currently playing audio, cannot be resumed later
        /// </summary>
        public virtual void Stop()
        {
        }

        /// <summary>
        /// Pause the currently playing audio, can be resumed later
        /// </summary>
        public virtual void Pause()
        {
        }

        /// <summary>
        /// Resume the currently paused audio
        /// </summary>
        public virtual void Resume()
        {
        }

        /// <summary>
        /// Close or deinitialize the audio hardware
        /// </summary>
        public virtual void Close()
        {
        }
    }
}
