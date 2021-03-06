// Copyright (C) 2014 dot42
//
// Original filename: XmlElementAttribute.cs
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
using System.Xml.Schema;

namespace System.Xml.Serialization
{
    /// <summary>
    /// Indicates that a public field or property represents an XML element when the XmlSerializer serializes or deserializes the object that contains it.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
    public class XmlElementAttribute : Attribute
    {
        private string elementName;
        private int order;

        /// <summary>
        /// Default ctor
        /// </summary>
        public XmlElementAttribute()
        {            
        }

        /// <summary>
        /// Element name ctor
        /// </summary>
        public XmlElementAttribute(string elementName)
        {
            this.elementName = elementName;
        }

        /// <summary>
        /// Type name ctor
        /// </summary>
        public XmlElementAttribute(Type type)
        {
            Type = type;
        }

        /// <summary>
        /// Element name + type ctor
        /// </summary>
        public XmlElementAttribute(string elementName, Type type)
        {
            this.elementName = elementName;
            Type = type;
        }

        /// <summary>
        /// Gets/sets the name of the XML element.
        /// </summary>
        public string ElementName
        {
            get { return elementName ?? string.Empty; }
            set { elementName = value; }
        }

        /// <summary>
        /// Gets/sets the namespace of the XML attribute.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets/sets whether the XML element name generated by the XmlSerializer is qualified or unqualified.
        /// </summary>
        public XmlSchemaForm Form { get; set; }

        /// <summary>
        /// Gets/sets the XSD data type of the XML element generated by the XmlSerializer.
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Gets/sets whether the XmlSerializer must serialize a member that is set to null as an empty tag with the xsi:nil attribute set to true.
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// Gets/sets the complex type of the XML element.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Gets/sets the explicit order in which elements are serialized/deserialized.
        /// </summary>
        public int Order
        {
            get { return order; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Negative values not allowed", "Order");
                order = value;
            }
        }
    }
}

