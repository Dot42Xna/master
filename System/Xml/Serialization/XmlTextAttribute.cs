// Copyright (C) 2014 dot42
//
// Original filename: XmlTextAttribute.cs
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
namespace System.Xml.Serialization
{
    /// <summary>
    /// Indicates to the XmlSerializer that the member must be treated as XML text when the class that contains it is serialized or deserialized.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Parameter|AttributeTargets.ReturnValue)]
    public class XmlTextAttribute : Attribute
    {
        private string dataType;

        /// <summary>
        /// Default ctor
        /// </summary>
        public XmlTextAttribute()
        {            
        }

        /// <summary>
        /// Type ctor
        /// </summary>
        public XmlTextAttribute(Type type)
        {
            Type = type;
        }

        /// <summary>
        /// Gets or sets the XML Schema definition language (XSD) data type of the text generated by the XmlSerializer.
        /// </summary>
        public string DataType
        {
            get { return dataType ?? string.Empty; }
            set { dataType = value; }
        }

        /// <summary>
        /// Gets/sets the type of the member.
        /// </summary>
        public Type Type { get; set; }
    }
}

