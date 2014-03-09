// Copyright (C) 2014 dot42
//
// Original filename: FileInfo.cs
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
using System.Runtime.InteropServices;

namespace System.IO
{
    /// <summary>
    /// Provides properties and instance methods for the creation, copying, deletion,
    ///  moving, and opening of files.
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    public sealed class FileInfo : FileSystemInfo
    {   
        /// <summary>
        ///  creates a FileInfo class, which acts as a wrapper for a file path.
        /// </summary>
        public FileInfo(string fileName)
            :base(fileName)
        {
            
        }
    }
}
