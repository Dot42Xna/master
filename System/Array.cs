// Copyright (C) 2014 dot42
//
// Original filename: Array.cs
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
using System.Collections;
using Dot42;
using Dot42.Internal;
using Java.Util;

namespace System
{
    /// <summary>
    /// Base class for array.
    /// This will always map to java/lang/Object because there is no special base class for java array's.
    /// </summary>
    [Dot42.DexImport("java/lang/Object", IgnoreFromJava = true)]
    public abstract class Array : IEnumerable, ICollection, IList
    {
        /// <summary>
        /// Gets the number of elements in this array.
        /// </summary>
        public int Length
        {
            [DexNative]
            get { return 0; }
        }

        /// <summary>
        /// Gets the value of the array at the given index.
        /// </summary>
        public object GetValue(int index)
        {
            return Java.Lang.Reflect.Array.Get(this, index);
        }

        /// <summary>
        /// Gets the value of the array at the given index.
        /// </summary>
        public void SetValue(object value, int index)
        {
            Java.Lang.Reflect.Array.Set(this, index, value);
        }

        /// <summary>
        /// Set a range of element in the given array starting at the given index to 0 or null.
        /// </summary>
        public static void Clear(Array source, int index, int length)
        {
            var end = index + length;
            if (source is sbyte[]) Arrays.Fill((sbyte[]) source, index, end, 0);
            else if (source is bool[]) Arrays.Fill((bool[])source, index, end, false);
            else if (source is char[]) Arrays.Fill((char[])source, index, end, '\0');
            else if (source is short[]) Arrays.Fill((short[])source, index, end, 0);
            else if (source is int[]) Arrays.Fill((int[])source, index, end, 0);
            else if (source is long[]) Arrays.Fill((long[])source, index, end, 0L);
            else if (source is float[]) Arrays.Fill((float[])source, index, end, 0.0F);
            else if (source is double[]) Arrays.Fill((double[])source, index, end, 0.0);
            else Arrays.Fill((object[])source, index, end, null);
        }

        /// <summary>
        /// Copy a range of elements from the front of the source array to the front of the destination array.
        /// </summary>
        public static void Copy(Array source, Array destination, int length)
        {
            Java.Lang.System.Arraycopy(source, 0, destination, 0, length);
        }

        /// <summary>
        /// Copy a range of elements from the front of the source array to the front of the destination array.
        /// </summary>
        /// <remarks>
        /// The length should fit inside an int, otherwise an ArgumentOutOfRangeException will be thrown.
        /// </remarks>
        public static void Copy(Array source, Array destination, long length)
        {
            if (length > int.MaxValue) throw new ArgumentOutOfRangeException("length", "Dot42 support up to " + int.MaxValue);
            
            Java.Lang.System.Arraycopy(source, 0, destination, 0, (int)length);
        }

        /// <summary>
        /// Copy a range of elements from the specified index of the source array to the specified index of the destination array.
        /// </summary>
        public static void Copy(Array source, int sourceIndex, Array destination, int destinationIndex, int length)
        {
            Java.Lang.System.Arraycopy(source, sourceIndex, destination, destinationIndex, length);
        }

        /// <summary>
        /// Copy a range of elements from the specified index of the source array to the specified index of the destination array.
        /// </summary>
        /// <remarks>
        /// The sourceIndex, destinationIndex and length should fit inside an int, otherwise an ArgumentOutOfRangeException will be thrown.
        /// </remarks>
        public static void Copy(Array source, long sourceIndex, Array destination, long destinationIndex, long length)
        {
            if (sourceIndex > int.MaxValue) throw new ArgumentOutOfRangeException("sourceIndex", "Dot42 support up to " + int.MaxValue);
            if (destinationIndex > int.MaxValue) throw new ArgumentOutOfRangeException("destinationIndex", "Dot42 support up to " + int.MaxValue);
            if (length > int.MaxValue) throw new ArgumentOutOfRangeException("length", "Dot42 support up to " + int.MaxValue);
            
            Java.Lang.System.Arraycopy(source, (int)sourceIndex, destination, (int)destinationIndex, (int)length);
        }

        /// <summary>
        /// Search for the first occurrence of the given value in the given array.
        /// </summary>
        public static int IndexOf(Array array, object value)
        {
            var byteArr = array as sbyte[];
            if (byteArr != null) return Arrays.BinarySearch(byteArr, (sbyte) value);
            var boolArr = array as bool[];
            if (boolArr != null) return Arrays.BinarySearch(boolArr, (bool) value);
            var charArr = array as char[];
            if (charArr != null) return Arrays.BinarySearch(charArr, (char) value);
            var shortArr = array as short[];
            if (shortArr != null) return Arrays.BinarySearch(shortArr, (short) value);
            var intArr = array as int[];
            if (intArr != null) return Arrays.BinarySearch(intArr, (int)value);
            var longArr = array as long[];
            if (longArr != null) return Arrays.BinarySearch(longArr, (long)value);
            var floatArr = array as float[];
            if (floatArr != null) return Arrays.BinarySearch(floatArr, (float)value);
            var doubleArr = array as double[];
            if (doubleArr != null) return Arrays.BinarySearch(doubleArr, (double)value);
            return Arrays.BinarySearch((object[])array, value);
        }

        /// <summary>
        /// Gets an enumerator to enumerate over all elements of this array.
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            return CompilerHelper.AsEnumerable(this).GetEnumerator();
        }

        /// <summary>
        /// Gets the number of elements in this collection.
        /// </summary>
        int ICollection.Count
        {
            get { return Java.Lang.Reflect.Array.GetLength(this); }
        }

        public bool IsSynchronized { get { return false; } }
        public object SyncRoot { get { return this; } }

        /// <summary>
        /// Copies all the elements of the current one-dimensional Array to the specified one-dimensional Array starting at the specified destination Array index. 
        /// </summary>
        public void CopyTo(Array array, int index)
        {
            Java.Lang.System.Arraycopy(this, 0, array, index, Length);
        }

        public void CopyTo(Array array, long index)
        {
            if (index > int.MaxValue) throw new NotSupportedException();
            
            Java.Lang.System.Arraycopy(this, 0, array, (int)index, Length);
        }

        public bool IsFixedSize { get { return true; } }
        public bool IsReadOnly { get { return false; } }

        public object this[int index]
        {
            get { return GetValue(index); }
            set { SetValue(value, index); }
        }

        public int Add(object element)
        {
            throw new NotSupportedException();
        }

        public void Clear()
        {
            Clear(this, 0, Length);
        }

        public bool Contains(object element)
        {
            return (IndexOf(this, element) >= 0);
        }

        public int IndexOf(object element)
        {
            return IndexOf(this, element);
        }

        public void Insert(int index, object element)
        {
            throw new NotSupportedException();
        }

        public void Remove(object element)
        {
            throw new NotSupportedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Sort the elements in the entire array.
        /// </summary>
        public void Sort()
        {
            Sort((IComparer)null);
        }

        /// <summary>
        /// Sort the elements in the entire array.
        /// </summary>
        public void Sort(IComparer comparer)
        {
            comparer = comparer ?? Comparer.Default;
            Java.Util.Arrays.Sort((object[])this, comparer);
        }

        /// <summary>
        /// Sort the elements in the entire array.
        /// </summary>
        private void Sort(int index,int length, IComparer comparer)
        {
            comparer = comparer ?? Comparer.Default;
            Java.Util.Arrays.Sort((object[])this, index, index + length, comparer);
        }

        /// <summary>
        /// Sort the elements in the entire array.
        /// </summary>
        public static void Sort(Array array)
        {
            Sort(array, null);
        }

        /// <summary>
        /// Sort the elements in the entire array.
        /// </summary>
        public static void Sort(Array array, IComparer comparer)
        {
            if (array == null) throw new ArgumentNullException("array");
            array.Sort(comparer);
        }

        /// <summary>
        /// Sort the elements in the entire array.
        /// </summary>
        public static void Sort(Array array, int index, int length, IComparer comparer)
        {
            if (array == null) throw new ArgumentNullException("array");
            array.Sort(index, length, comparer);
        }

        /// <summary>
        /// Clones the current array
        /// </summary>
        /// <returns></returns>
        public Array Clone()
        {
            var sbyteArr = this as sbyte[];
            if (sbyteArr != null) return Arrays.CopyOf(sbyteArr, Length);
            var byteArr = this as byte[];
            if (byteArr != null) return Arrays.CopyOf(byteArr, Length);
            var boolArr = this as bool[];
            if (boolArr != null) return Arrays.CopyOf(boolArr, Length);
            var charArr = this as char[];
            if (charArr != null) return Arrays.CopyOf(charArr, Length);
            var shortArr = this as short[];
            if (shortArr != null) return Arrays.CopyOf(shortArr, Length);
            var intArr = this as int[];
            if (intArr != null) return Arrays.CopyOf(intArr, Length);
            var longArr = this as long[];
            if (longArr != null) return Arrays.CopyOf(longArr, Length);
            var floatArr = this as float[];
            if (floatArr != null) return Arrays.CopyOf(floatArr, Length);
            var doubleArr = this as double[];
            if (doubleArr != null) return Arrays.CopyOf(doubleArr, Length);
            return Arrays.CopyOf((object[])this, Length);
        }

        /// <summary>
        /// Changes the number of elements of a one-dimensional array to the specified new size.
        /// </summary>
        public static void Resize<T>(ref T[] array,int newSize)
        {
            Arrays.CopyOf<T>(array, newSize);
        }

        /// <summary>
        /// Get the number of elements in the specified dimension of the Array.
        /// </summary>
        public int GetLength(int dimension)
        {
            if (dimension == 0) return Length;

            if (dimension >=1)
            {
                var array = GetValue(0) as Array;
                if (array != null) return array.GetLength(dimension-1);
            }

            throw new NotImplementedException("System.Array.GetLength");
        }

        /*
        //Rank is missing, Java doesn't support multiple dimension arrays as far as I know like 
        //var i = new int[1,2,3], however it does support
        //var i = new int[1][2][3]
        public int Rank
        {
            get { return 1; }
        }
        */


    }
}

