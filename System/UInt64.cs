// Copyright (C) 2014 dot42
//
// Original filename: UInt64.cs
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
using System.Globalization;
using Dot42;
using Dot42.Internal;

namespace System
{
    [DexImport("java/lang/Long", IgnoreFromJava = true, Priority = 1)]
    partial struct UInt64: IFormattable
	{
	    public const ulong MaxValue = 0xFFFFFFFFFFFFFFFF;
        public const ulong MinValue = 0;

        public static ulong Parse(string s)
        {
            var value = long.Parse(s);
            if (value < 0L) 
                throw new OverflowException();
            return (ulong) value;
        }

        public static ulong Parse(string s, IFormatProvider provider)
        {
            return Parse(s);
        }

        public static ulong Parse(string s, NumberStyles style)
        {
            return Parse(s);
        }

        [DexImport("longValue", "()J", AccessFlags = 1)]
        internal long LongValue() /* Keep internal to avoid verify error */ 
        {
            return default(long);
        }

        public string ToString(IFormatProvider provider)
        {
            return NumberFormatter.Format(LongValue(), provider);
        }

        public string ToString(string format)
        {
            return NumberFormatter.Format(format, LongValue(), null);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            return NumberFormatter.Format(format, LongValue(), provider);
        }

    }
}

