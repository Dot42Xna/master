// Copyright (C) 2014 dot42
//
// Original filename: TaskConstants_T.cs
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
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	internal class TaskConstants<T>
	{
	    private static Task<T> canceled = null;

	    internal static Task<T> Canceled
	    {
	        get
	        {
	            if (canceled == null)
	            {
                    var tcs = new TaskCompletionSource<T>();
                    tcs.SetCanceled();
                    canceled = tcs.Task;
	            }

	            return canceled;
	        }
	    }
	}
}



