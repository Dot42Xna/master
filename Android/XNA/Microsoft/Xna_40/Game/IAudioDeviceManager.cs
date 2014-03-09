using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework
{
    public interface IAudioDeviceManager
    {
        bool BeginAudio();
        void CreateDevice();
        void EndAudio();
    }
}
