using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework.Graphics
{
    public abstract class GraphicsResource
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public object Tag { get; set; }

        public virtual GraphicsDevice GraphicsDevice { get; protected set; }
        public virtual ResourceType ResourceType { get; protected set; }
    }
}
