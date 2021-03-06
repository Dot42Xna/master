// Copyright (C) 2014 dot42
//
// Original filename: ObjectDisposedException.cs
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
namespace System
{
	public class ObjectDisposedException : InvalidOperationException
	{
	    private readonly string objectName;

	    public ObjectDisposedException(string objectName) : base(objectName)
        {
            this.objectName = objectName;
        }

	    public ObjectDisposedException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public ObjectDisposedException(string objectName, string message)
            : base(message)
        {
            this.objectName = objectName;
        }

	    public string ObjectName { get { return objectName; } }
    }
}

