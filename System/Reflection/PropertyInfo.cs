// Copyright (C) 2014 dot42
//
// Original filename: PropertyInfo.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using Dot42.Internal;

namespace System.Reflection
{
    /// <summary>
    /// Property reflection info.
    /// </summary>
    public class PropertyInfo : MemberInfo, IAttributesProvider
    {
        private readonly string name;
        private readonly MethodInfo getter;
        private readonly MethodInfo setter;
        private readonly IAttributes attributes;

        /// <summary>
        /// Default ctor
        /// </summary>
        internal PropertyInfo(string name, MethodInfo getter, MethodInfo setter, IAttributes attributes)
        {
            this.name = name;
            this.getter = getter;
            this.setter = setter;
            this.attributes = attributes;
        }

        /// <summary>
        /// Gets the name of this property
        /// </summary>
        public virtual string Name { get { return name; } }

        /// <summary>
        /// Gets this property be read from?
        /// </summary>
        public virtual bool CanRead { get { return (getter != null); } }

        /// <summary>
        /// Gets this property be written to?
        /// </summary>
        public virtual bool CanWrite { get { return (setter != null); } }

        /// <summary>
        /// Gets the get accessor method.
        /// </summary>
        public virtual MethodInfo GetMethod { get { return getter; } }

        /// <summary>
        /// Gets the set accessor method.
        /// </summary>
        public virtual MethodInfo SetMethod { get { return setter; } }

        /// <summary>
        /// Gets the type of this property
        /// </summary>
        public virtual Type PropertyType
        {
            get
            {
                if (getter != null)
                    return getter.ReturnType;
                if (setter != null)
                {
                    var paramTypes = setter.ParameterTypes;
                    return paramTypes[paramTypes.Length - 1];
                }
                throw new NotSupportedException("PropertyType");
            }
        }

        /// <summary>
        /// Gets a value of the property for a given instance.
        /// </summary>
        public object GetValue(object instance)
        {
            if (getter != null)
                return getter.Invoke(instance);
            return null;
        }

        /// <summary>
        /// Sets a value of the property for a given instance.
        /// </summary>
        public void SetValue(object instance, object value)
        {
            if (setter != null)
                setter.Invoke(instance, value);
        }

        /// <summary>
        /// Gets all attributes
        /// </summary>
        IAttributes IAttributesProvider.Attributes()
        {
            return attributes;
        }
    }
}

