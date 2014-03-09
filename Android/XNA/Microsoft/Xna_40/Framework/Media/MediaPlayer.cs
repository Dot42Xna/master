using System;
using Microsoft.SPOT;
using Microsoft.Xna.Framework.Audio;

namespace Microsoft.Xna.Framework.Microsoft.Xna.Framework.Media
{
    public enum MediaState { Paused, Playing, Stopped }

    public static class MediaPlayer
    {
        #region Fields

        private static MediaState state = MediaState.Stopped;

        #endregion

        #region Properties

        internal static AudioDevice AudioDevice { get; set; }

        public static bool GameHasControl
        {
            get { return true; }
        }

        public static bool IsMuted 
        {
            get { return AudioDevice.IsMuted; }
            set { AudioDevice.IsMuted = value; }
        }

        public static bool IsRepeating 
        {
            get { return AudioDevice.IsRepeating; }
            set { AudioDevice.IsRepeating = value; }
        }

        public static bool IsVisualizationEnabled
        {
            get { return false; }
            set { }
        }

        public static TimeSpan PlayPosition
        {
            get { return TimeSpan.Zero; }
        }

        public static MediaState State
        {
            get { return state; }
            private set
            {
                if (state != value)
                {
                    state = value;
                    OnMediaStateChanged();
                }
            }
        }

        public static float Volume 
        {
            get { return AudioDevice.Volume; }
            set { AudioDevice.Volume = value; }
        }

        #endregion

        #region Events

        public static event EventHandler MediaStateChanged;

        #endregion

        #region Methods

        public static void Pause()
        {
            AudioDevice.Pause();
            State = MediaState.Paused;
        }

        public static void Play(Song song)
        {
            AudioDevice.Play(song.AudioData);
            State = MediaState.Playing;
        }

        public static void Resume()
        {
            AudioDevice.Resume();
            State = MediaState.Playing;
        }

        public static void Stop()
        {
            AudioDevice.Stop();
            State = MediaState.Stopped;
        }

        #region Fire Event Methods

        private static void OnMediaStateChanged()
        {
            EventHandler handler = MediaStateChanged;

            if (handler != null)
            {
                handler(null, new EventArgs());
            }
        }

        #endregion

        #endregion
    }
}
