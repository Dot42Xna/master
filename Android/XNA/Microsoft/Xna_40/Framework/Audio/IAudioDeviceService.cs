using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Audio
{
    public interface IAudioDeviceService
    {
        AudioDevice AudioDevice { get; }
    }
}
