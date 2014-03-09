// Copyright (C) 2014 dot42
//
// Original filename: UInt16.cs
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
using Dot42;
using Dot42.Internal;

namespace System
{
    /// <summary>
    /// Unsigned 16-bit integer.
    /// </summary>
    [DexImport("java/lang/Short", IgnoreFromJava = true, Priority = 1)]
    partial struct UInt16 : IFormattable
	{
        public const ushort MaxValue = 0xFFFF;
        public const ushort MinValue = 0;

        public static ushort Parse(string s)
        {
            var value = long.Parse(s);
            if ((value < MinValue) || (value > MaxValue))
                throw new OverflowException();
            return (ushort) value;
        }

        public static ushort Parse(string s, IFormatProvider provider)
        {
            return Parse(s);
        }

        [DexImport("intValue", "()I", AccessFlags = 1)]
        internal int IntValue() /* Keep internal to avoid verify error */ 
        {
            return default(int);
        }

        public string ToString(IFormatProvider provider)
        {
            return int.ToString(IntValue() & 0xFFFF);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            return NumberFormatter.Format(format, IntValue() & 0xFFFF, provider);
        }
    }
}

