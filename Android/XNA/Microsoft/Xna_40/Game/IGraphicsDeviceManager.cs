using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework
{
    public interface IGraphicsDeviceManager
    {
        bool BeginDraw();
        void CreateDevice();
        void EndDraw();
    }
}
