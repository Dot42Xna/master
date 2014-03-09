using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Graphics
{
    public struct VertexElement
    {
        public short Offset;

        public VertexElement(short offset)
        {
            this.Offset = offset;
        }
    }
}
