// Copyright (C) 2014 dot42
//
// Original filename: TypeHelper.cs
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
using System;

namespace Dot42.Internal
{
	internal static class TypeHelper
	{
        /// <summary>
        /// Type of java.lang.Boolean
        /// </summary>
        [DexNative]
        internal static extern Type BooleanType();

        /// <summary>
        /// Type of java.lang.Byte
        /// </summary>
        [DexNative]
        internal static extern Type ByteType();

        /// <summary>
        /// Type of java.lang.Character
        /// </summary>
        [DexNative]
        internal static extern Type CharacterType();

        /// <summary>
        /// Type of java.lang.Short
        /// </summary>
        [DexNative]
        internal static extern Type ShortType();

        /// <summary>
        /// Type of java.lang.Integer
        /// </summary>
        [DexNative]
        internal static extern Type IntegerType();

        /// <summary>
        /// Type of java.lang.Long
        /// </summary>
        [DexNative]
        internal static extern Type LongType();

        /// <summary>
        /// Type of java.lang.Float
        /// </summary>
        [DexNative]
        internal static extern Type FloatType();

        /// <summary>
        /// Type of java.lang.Double
        /// </summary>
        [DexNative]
        internal static extern Type DoubleType();

        /// <summary>
        /// Create an array type with the given component type with dimension 1.
        /// </summary>
        [Include]
        public static Type Array(Type componentType)
        {
            return Java.Lang.Reflect.Array.NewInstance(componentType, 0).GetType();
        }

        /// <summary>
        /// Create an array type with the given component type with multiple dimensions.
        /// </summary>
        [Include]
        public static Type Array(Type componentType, int dimensions)
        {
            while (true)
            {
                var type = Java.Lang.Reflect.Array.NewInstance(componentType, 0).GetType();
                if (dimensions == 1)
                    return type;
                dimensions--;
                componentType = type;
            }
        }
    }
}

