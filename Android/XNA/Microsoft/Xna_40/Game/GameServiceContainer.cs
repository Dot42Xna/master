using System;
using Microsoft.SPOT;
using System.Collections;

namespace Microsoft.Xna.Framework
{
    public class GameServiceContainer : IServiceProvider
    {
        private class TypeObjectPair
        {
            public Type Type { get; set; }
            public object Object { get; set; }
        }

        ArrayList services = new ArrayList();

        public GameServiceContainer()
        {
        }

        public void AddService(Type type, object provider)
        {
            services.Add(new TypeObjectPair() { Type = type, Object = provider });
        }

        public void RemoveService(Type type)
        {
            for (int i = 0; i < services.Count; i++)
            {
                TypeObjectPair top = (TypeObjectPair)services[i];
                if (top.Type == type)
                {
                    services.RemoveAt(i);
                    break;
                }
            }
        }

        #region IServiceProvider Members

        public object GetService(Type serviceType)
        {
            for (int i = 0; i < services.Count; i++)
            {
                TypeObjectPair top = (TypeObjectPair)services[i];
                if (top.Type == serviceType)
                {
                    return top.Object;
                }
            }
            return null;
        }

        #endregion
    }
}
