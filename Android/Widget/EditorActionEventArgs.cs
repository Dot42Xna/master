// Copyright (C) 2014 dot42
//
// Original filename: EditorActionEventArgs.cs
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
using Android.View;

namespace Android.Widget
{
	public class EditorActionEventArgs : View.ViewEventArgs
	{
	    public EditorActionEventArgs(int actionId, KeyEvent @event)
	    {
	        Event = @event;
	        ActionId = actionId;
	    }

	    /// <summary>
        /// Identifier of the action. This will be either the identifier you supplied, or EditorInfo.IME_NULL if being called due to the enter key being pressed..
        /// </summary>
	    public int ActionId { get; private set; }

        /// <summary>
        /// If triggered by an enter key, this is the event; otherwise, this is null.
        /// </summary>
        public KeyEvent Event { get; private set; }
    }
}

