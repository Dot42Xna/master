// Copyright (C) 2014 dot42
//
// Original filename: HttpVersion.cs
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
namespace System.Net
{
    /// <summary>
    /// Http protocol versions used by the HttpWebRequest and HttpWebResponse
    /// </summary>
    public class HttpVersion
    {
        /// <summary>
        /// Http protocol version 1.0
        /// </summary>
        public static readonly Version Version10 = new Version(1, 0);
        /// <summary>
        /// Http protocol version 1.1
        /// </summary>
        public static readonly Version Version11 = new Version(1, 1);
    }
}
