// Copyright (C) 2014 dot42
//
// Original filename: ParameterizedThreadStartRunnable.cs
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
using Java.Lang;

namespace System.Threading
{
    /// <summary>
    /// Helper for starting threads with ParameterizedThreadStart delegate.
    /// </summary>
    internal sealed class ParameterizedThreadStartRunnable : IRunnable
    {
        private readonly ParameterizedThreadStart start;
        private readonly object obj;

        /// <summary>
        /// Default ctor
        /// </summary>
        public ParameterizedThreadStartRunnable(ParameterizedThreadStart start, object obj)
        {
            this.start = start;
            this.obj = obj;
        }

        public void Run()
        {
            start(obj);
        }
    }
}
