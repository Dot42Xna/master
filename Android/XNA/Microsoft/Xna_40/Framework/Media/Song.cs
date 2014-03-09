using System;
using Microsoft.SPOT;
using Microsoft.Xna.Framework.Audio;

namespace Microsoft.Xna.Framework.Microsoft.Xna.Framework.Media
{
    public sealed class Song
    {
        internal AudioDevice AudioDevice { get; set; }
        internal byte[] AudioData { get; private set; }

        public bool IsProtected
        {
            get { return false; }
        }

        public bool IsRated
        {
            get { return false; }
        }

        public string Name { get; private set; }

        public int PlayCount { get; private set; }

        public int Rating 
        {
            get { return 0; }
        }

        internal Song(byte[] resourceBytes)
        {
            this.AudioData = resourceBytes;
        }
        
        public void Dispose()
        {
        }
    }
}
