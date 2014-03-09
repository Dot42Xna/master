using System;

namespace Microsoft.Xna.Framework.Graphics
{
    public class VertexDeclaration : IDisposable
    {
        private VertexElement[] elements;

        public GraphicsDevice GraphicsDevice { get; private set;}
        public string Name { get; set; }
        public object Tag { get; set; }

        public bool IsDisposed { get; private set; }

        public VertexDeclaration(GraphicsDevice graphicsDevice, VertexElement[] elements)
        {
            this.GraphicsDevice = graphicsDevice;
            this.elements = elements;
        }

        public void Dispose()
        {
        }

        public VertexElement[] GetVertexElements()
        {
            return elements;
        }

        public override string ToString()
        {
            return "{graphics:" + GraphicsDevice.ToString() + ", elements:" + elements.Length.ToString() + "}";
        }
    }
}
