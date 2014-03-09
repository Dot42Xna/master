using System;
using System.Collections;
using System.Reflection;
using System.Resources;
using Microsoft.SPOT;
using Microsoft.Xna.Framework.Graphics;
using ResourceUtility = Microsoft.SPOT.ResourceUtility;
using Microsoft.Xna.Framework.Microsoft.Xna.Framework.Media;

namespace Microsoft.Xna.Framework.Content
{
    public class ContentManager
    {
        private IGraphicsDeviceService graphicsDeviceService;
        private string rootDirectory;
        private object[] emptyParams = new object[] { };

        private static ArrayList cache = new ArrayList();
        private class Content
        {
            public Enum Id { get; set; }
            public object Resource { get; set; }
        }

        public string RootDirectory 
        {
            get { return rootDirectory; }
            set
            {
                rootDirectory = value;
            }
        }
        public IServiceProvider ServiceProvider { get; private set; }

        private GraphicsDevice GraphicsDevice
        {
            get
            {
                if (graphicsDeviceService == null)
                {
                    graphicsDeviceService = (IGraphicsDeviceService)ServiceProvider.GetService(typeof(IGraphicsDeviceService));
                }
                return graphicsDeviceService.GraphicsDevice;
            }
        }

        public ContentManager(IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
            this.graphicsDeviceService = null;
        }

        public ContentManager(IServiceProvider serviceProvider, string rootDirectory)
            : this(serviceProvider)
        {
            this.RootDirectory = rootDirectory;
        }

        public virtual object Load(Enum id)
        {
            object resource = GetFromCache(id);
            if (resource == null)
            {
                Type resourceType = id.GetType().DeclaringType;
                MethodInfo mmi = resourceType.GetMethod("get_ResourceManager", BindingFlags.NonPublic | BindingFlags.Static);
                ResourceManager rm = (ResourceManager)mmi.Invoke(resourceType, emptyParams);

                resource = Load(ResourceUtility.GetObject(rm, id));
                cache.Add(new Content() { Id = id, Resource = resource });
            }

            return resource;
        }

        private object Load(object resource)
        {   
            if (resource is Bitmap)
            {
                return Texture2D.FromBitmap(this.GraphicsDevice, (Bitmap)resource);
            }
            else if (resource is Font)
            {
                return SpriteFont.FromFont((Font)resource);
            }
            else if (resource is byte[])
            {
                return new Song((byte[])resource);
            }
            else if (resource is string)
            {
                return resource;
            }

            // Don't know how to deal with the type/resource combination.
            throw new NotSupportedException("Object type and/or resource type not supported.");
        }

        private object GetFromCache(Enum id)
        {
            foreach (Content content in cache)
            {
                if (content.Id.Equals(id))
                {
                    return content.Resource;
                }
            }
            return null;
        }

        public void Unload()
        {
            
        }
    }
}
