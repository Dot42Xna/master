// Copyright (C) 2014 dot42
//
// Original filename: NumberedBackReference.cs
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
namespace System.Text.RegularExpressions.Internal
{
    internal class NumberedBackReference : ParserItem
    {
        public NumberedBackReference(int startIndex, int endIndex, int number)
            : base(startIndex, endIndex)
        {
            Number = number;
        }

        public int Number { get; private set; }

        public override string Replacement(string pattern, PatternMap map)
        {
            return string.Format("\\{0}", map.GetSourceToTargetsIndex(Number)[0]);
        }
    }
}
