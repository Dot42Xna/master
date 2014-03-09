// Copyright (C) 2014 dot42
//
// Original filename: UInt32.cs
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
    /// Unsigned 32-bit integer.
    /// </summary>
    [DexImport("java/lang/Integer", IgnoreFromJava = true, Priority = 1)]
    partial struct UInt32 : IFormattable
	{
	    public const uint MaxValue = 0xFFFFFFFF;
        public const uint MinValue = 0;

        //Workaround: Notice this is a long, so no negative number will be checked in the Parse method.
        private const long maxValue = 0xFFFFFFFFL;

        public static uint Parse(string s)
        {
            var value = long.Parse(s);
            if ((value < MinValue) || (value > maxValue))
                throw new OverflowException(string.Format("Value {0} should not be less than {1} and not larger than {2}.", value.ToString(), MinValue, maxValue));
            return (uint) value;
        }

        public static uint Parse(string s, IFormatProvider provider)
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
            return long.ToString(((long)IntValue()) & 0xFFFFFFFFL);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return NumberFormatter.Format(format, ((long)IntValue()) & 0xFFFFFFFFL, null);
        }
    }
}

