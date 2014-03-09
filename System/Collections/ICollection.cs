// Copyright (C) 2014 dot42
//
// Original filename: ICollection.cs
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
namespace System.Collections
{
    public interface ICollection : IEnumerable
    {
        /// <summary>
        /// Gets number of elements in this collection.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Is this collection thread safe.
        /// </summary>
        bool IsSynchronized { get; }

        /// <summary>
        /// Gets the object used to synchronize access to this collection.
        /// </summary>
        object SyncRoot { get; }

        /// <summary>
        /// Copy all my elements to the given array starting at the given index.
        /// </summary>
        /// <param name="array">Array to copy my elements into.</param>
        /// <param name="index">Position in <see cref="array"/> where the first element will be copied to.</param>
        void CopyTo(Array array, int index);
    }
}

