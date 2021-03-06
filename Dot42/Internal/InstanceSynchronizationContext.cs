// Copyright (C) 2014 dot42
//
// Original filename: InstanceSynchronizationContext.cs
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
using Java.Util;

using Dot42.Threading.Tasks;

namespace Dot42.Internal
{
    internal class InstanceSynchronizationContext : AndroidSynchronizationContext
    {
        private static readonly HashMap<int,object> registeredInstances = new HashMap<int, object>();

        internal static void RegisterActivity(InstanceReference instanceReference)
        {
            var hashCode = instanceReference.GetHashCode();
            if (registeredInstances.ContainsKey(hashCode)) registeredInstances.Remove(hashCode);
            registeredInstances.Put(hashCode, instanceReference.Instance);
        }

        internal static object GetRegisteredActivity(InstanceReference instanceReference)
        {
            var hashCode = instanceReference.GetHashCode();
            return registeredInstances.ContainsKey(hashCode) ? registeredInstances.Get(hashCode) : null;
        }
    }
}

