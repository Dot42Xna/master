﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector4 : IEquatable<Vector4>
    {
        public float X;
        public float Y;
        public float Z;
        public float W;
        private static Vector4 _zero;
        private static Vector4 _one;
        private static Vector4 _unitX;
        private static Vector4 _unitY;
        private static Vector4 _unitZ;
        private static Vector4 _unitW;

        public static readonly int SizeInBytes = Marshal.SizeOf(new Vector4());

        public static Vector4 Zero
        {
            get
            {
                return _zero;
            }
        }
        public static Vector4 One
        {
            get
            {
                return _one;
            }
        }
        public static Vector4 UnitX
        {
            get
            {
                return _unitX;
            }
        }
        public static Vector4 UnitY
        {
            get
            {
                return _unitY;
            }
        }
        public static Vector4 UnitZ
        {
            get
            {
                return _unitZ;
            }
        }
        public static Vector4 UnitW
        {
            get
            {
                return _unitW;
            }
        }
        public Vector4(float x, float y, float z, float w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        public Vector4(Vector2 value, float z, float w)
        {
            this.X = value.X;
            this.Y = value.Y;
            this.Z = z;
            this.W = w;
        }

        public Vector4(Vector3 value, float w)
        {
            this.X = value.X;
            this.Y = value.Y;
            this.Z = value.Z;
            this.W = w;
        }

        public Vector4(float value)
        {
            this.X = this.Y = this.Z = this.W = value;
        }

        public override string ToString()
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            return string.Format(currentCulture, "{{X:{0} Y:{1} Z:{2} W:{3}}}", new object[] { this.X.ToString(currentCulture), this.Y.ToString(currentCulture), this.Z.ToString(currentCulture), this.W.ToString(currentCulture) });
        }

        public bool Equals(Vector4 other)
        {
            return ((((this.X == other.X) && (this.Y == other.Y)) && (this.Z == other.Z)) && (this.W == other.W));
        }

        public override bool Equals(object obj)
        {
            bool flag = false;
            if (obj is Vector4)
            {
                flag = this.Equals((Vector4)obj);
            }
            return flag;
        }

        public override int GetHashCode()
        {
            return (((this.X.GetHashCode() + this.Y.GetHashCode()) + this.Z.GetHashCode()) + this.W.GetHashCode());
        }

        public float Length()
        {
            float num = (((this.X * this.X) + (this.Y * this.Y)) + (this.Z * this.Z)) + (this.W * this.W);
            return (float)Math.Sqrt((double)num);
        }

        public float LengthSquared()
        {
            return ((((this.X * this.X) + (this.Y * this.Y)) + (this.Z * this.Z)) + (this.W * this.W));
        }

        public static float Distance(Vector4 value1, Vector4 value2)
        {
            float num = value1.X - value2.X;
            float num2 = value1.Y - value2.Y;
            float num3 = value1.Z - value2.Z;
            float num4 = value1.W - value2.W;
            float num5 = (((num * num) + (num2 * num2)) + (num3 * num3)) + (num4 * num4);
            return (float)Math.Sqrt((double)num5);
        }

        public static void Distance(ref Vector4 value1, ref Vector4 value2, out float result)
        {
            float num = value1.X - value2.X;
            float num2 = value1.Y - value2.Y;
            float num3 = value1.Z - value2.Z;
            float num4 = value1.W - value2.W;
            float num5 = (((num * num) + (num2 * num2)) + (num3 * num3)) + (num4 * num4);
            result = (float)Math.Sqrt((double)num5);
        }

        public static float DistanceSquared(Vector4 value1, Vector4 value2)
        {
            float num = value1.X - value2.X;
            float num2 = value1.Y - value2.Y;
            float num3 = value1.Z - value2.Z;
            float num4 = value1.W - value2.W;
            return ((((num * num) + (num2 * num2)) + (num3 * num3)) + (num4 * num4));
        }

        public static void DistanceSquared(ref Vector4 value1, ref Vector4 value2, out float result)
        {
            float num = value1.X - value2.X;
            float num2 = value1.Y - value2.Y;
            float num3 = value1.Z - value2.Z;
            float num4 = value1.W - value2.W;
            result = (((num * num) + (num2 * num2)) + (num3 * num3)) + (num4 * num4);
        }

        public static float Dot(Vector4 vector1, Vector4 vector2)
        {
            return ((((vector1.X * vector2.X) + (vector1.Y * vector2.Y)) + (vector1.Z * vector2.Z)) + (vector1.W * vector2.W));
        }

        public static void Dot(ref Vector4 vector1, ref Vector4 vector2, out float result)
        {
            result = (((vector1.X * vector2.X) + (vector1.Y * vector2.Y)) + (vector1.Z * vector2.Z)) + (vector1.W * vector2.W);
        }

        public void Normalize()
        {
            float num = (((this.X * this.X) + (this.Y * this.Y)) + (this.Z * this.Z)) + (this.W * this.W);
            float num2 = 1f / ((float)Math.Sqrt((double)num));
            this.X *= num2;
            this.Y *= num2;
            this.Z *= num2;
            this.W *= num2;
        }

        public static Vector4 Normalize(Vector4 vector)
        {
            Vector4 vector2;
            float num = (((vector.X * vector.X) + (vector.Y * vector.Y)) + (vector.Z * vector.Z)) + (vector.W * vector.W);
            float num2 = 1f / ((float)Math.Sqrt((double)num));
            vector2.X = vector.X * num2;
            vector2.Y = vector.Y * num2;
            vector2.Z = vector.Z * num2;
            vector2.W = vector.W * num2;
            return vector2;
        }

        public static void Normalize(ref Vector4 vector, out Vector4 result)
        {
            float num = (((vector.X * vector.X) + (vector.Y * vector.Y)) + (vector.Z * vector.Z)) + (vector.W * vector.W);
            float num2 = 1f / ((float)Math.Sqrt((double)num));
            result.X = vector.X * num2;
            result.Y = vector.Y * num2;
            result.Z = vector.Z * num2;
            result.W = vector.W * num2;
        }

        public static Vector4 Min(Vector4 value1, Vector4 value2)
        {
            Vector4 vector;
            vector.X = (value1.X < value2.X) ? value1.X : value2.X;
            vector.Y = (value1.Y < value2.Y) ? value1.Y : value2.Y;
            vector.Z = (value1.Z < value2.Z) ? value1.Z : value2.Z;
            vector.W = (value1.W < value2.W) ? value1.W : value2.W;
            return vector;
        }

        public static void Min(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
        {
            result.X = (value1.X < value2.X) ? value1.X : value2.X;
            result.Y = (value1.Y < value2.Y) ? value1.Y : value2.Y;
            result.Z = (value1.Z < value2.Z) ? value1.Z : value2.Z;
            result.W = (value1.W < value2.W) ? value1.W : value2.W;
        }

        public static Vector4 Max(Vector4 value1, Vector4 value2)
        {
            Vector4 vector;
            vector.X = (value1.X > value2.X) ? value1.X : value2.X;
            vector.Y = (value1.Y > value2.Y) ? value1.Y : value2.Y;
            vector.Z = (value1.Z > value2.Z) ? value1.Z : value2.Z;
            vector.W = (value1.W > value2.W) ? value1.W : value2.W;
            return vector;
        }

        public static void Max(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
        {
            result.X = (value1.X > value2.X) ? value1.X : value2.X;
            result.Y = (value1.Y > value2.Y) ? value1.Y : value2.Y;
            result.Z = (value1.Z > value2.Z) ? value1.Z : value2.Z;
            result.W = (value1.W > value2.W) ? value1.W : value2.W;
        }

        public static Vector4 Clamp(Vector4 value1, Vector4 min, Vector4 max)
        {
            Vector4 vector;
            float x = value1.X;
            x = (x > max.X) ? max.X : x;
            x = (x < min.X) ? min.X : x;
            float y = value1.Y;
            y = (y > max.Y) ? max.Y : y;
            y = (y < min.Y) ? min.Y : y;
            float z = value1.Z;
            z = (z > max.Z) ? max.Z : z;
            z = (z < min.Z) ? min.Z : z;
            float w = value1.W;
            w = (w > max.W) ? max.W : w;
            w = (w < min.W) ? min.W : w;
            vector.X = x;
            vector.Y = y;
            vector.Z = z;
            vector.W = w;
            return vector;
        }

        public static void Clamp(ref Vector4 value1, ref Vector4 min, ref Vector4 max, out Vector4 result)
        {
            float x = value1.X;
            x = (x > max.X) ? max.X : x;
            x = (x < min.X) ? min.X : x;
            float y = value1.Y;
            y = (y > max.Y) ? max.Y : y;
            y = (y < min.Y) ? min.Y : y;
            float z = value1.Z;
            z = (z > max.Z) ? max.Z : z;
            z = (z < min.Z) ? min.Z : z;
            float w = value1.W;
            w = (w > max.W) ? max.W : w;
            w = (w < min.W) ? min.W : w;
            result.X = x;
            result.Y = y;
            result.Z = z;
            result.W = w;
        }

        public static Vector4 Lerp(Vector4 value1, Vector4 value2, float amount)
        {
            Vector4 vector;
            vector.X = value1.X + ((value2.X - value1.X) * amount);
            vector.Y = value1.Y + ((value2.Y - value1.Y) * amount);
            vector.Z = value1.Z + ((value2.Z - value1.Z) * amount);
            vector.W = value1.W + ((value2.W - value1.W) * amount);
            return vector;
        }

        public static void Lerp(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)
        {
            result.X = value1.X + ((value2.X - value1.X) * amount);
            result.Y = value1.Y + ((value2.Y - value1.Y) * amount);
            result.Z = value1.Z + ((value2.Z - value1.Z) * amount);
            result.W = value1.W + ((value2.W - value1.W) * amount);
        }

        public static Vector4 Barycentric(Vector4 value1, Vector4 value2, Vector4 value3, float amount1, float amount2)
        {
            Vector4 vector;
            vector.X = (value1.X + (amount1 * (value2.X - value1.X))) + (amount2 * (value3.X - value1.X));
            vector.Y = (value1.Y + (amount1 * (value2.Y - value1.Y))) + (amount2 * (value3.Y - value1.Y));
            vector.Z = (value1.Z + (amount1 * (value2.Z - value1.Z))) + (amount2 * (value3.Z - value1.Z));
            vector.W = (value1.W + (amount1 * (value2.W - value1.W))) + (amount2 * (value3.W - value1.W));
            return vector;
        }

        public static void Barycentric(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, float amount1, float amount2, out Vector4 result)
        {
            result.X = (value1.X + (amount1 * (value2.X - value1.X))) + (amount2 * (value3.X - value1.X));
            result.Y = (value1.Y + (amount1 * (value2.Y - value1.Y))) + (amount2 * (value3.Y - value1.Y));
            result.Z = (value1.Z + (amount1 * (value2.Z - value1.Z))) + (amount2 * (value3.Z - value1.Z));
            result.W = (value1.W + (amount1 * (value2.W - value1.W))) + (amount2 * (value3.W - value1.W));
        }

        public static Vector4 SmoothStep(Vector4 value1, Vector4 value2, float amount)
        {
            Vector4 vector;
            amount = (amount > 1f) ? 1f : ((amount < 0f) ? 0f : amount);
            amount = (amount * amount) * (3f - (2f * amount));
            vector.X = value1.X + ((value2.X - value1.X) * amount);
            vector.Y = value1.Y + ((value2.Y - value1.Y) * amount);
            vector.Z = value1.Z + ((value2.Z - value1.Z) * amount);
            vector.W = value1.W + ((value2.W - value1.W) * amount);
            return vector;
        }

        public static void SmoothStep(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)
        {
            amount = (amount > 1f) ? 1f : ((amount < 0f) ? 0f : amount);
            amount = (amount * amount) * (3f - (2f * amount));
            result.X = value1.X + ((value2.X - value1.X) * amount);
            result.Y = value1.Y + ((value2.Y - value1.Y) * amount);
            result.Z = value1.Z + ((value2.Z - value1.Z) * amount);
            result.W = value1.W + ((value2.W - value1.W) * amount);
        }

        public static Vector4 CatmullRom(Vector4 value1, Vector4 value2, Vector4 value3, Vector4 value4, float amount)
        {
            Vector4 vector;
            float num = amount * amount;
            float num2 = amount * num;
            vector.X = 0.5f * ((((2f * value2.X) + ((-value1.X + value3.X) * amount)) + (((((2f * value1.X) - (5f * value2.X)) + (4f * value3.X)) - value4.X) * num)) + ((((-value1.X + (3f * value2.X)) - (3f * value3.X)) + value4.X) * num2));
            vector.Y = 0.5f * ((((2f * value2.Y) + ((-value1.Y + value3.Y) * amount)) + (((((2f * value1.Y) - (5f * value2.Y)) + (4f * value3.Y)) - value4.Y) * num)) + ((((-value1.Y + (3f * value2.Y)) - (3f * value3.Y)) + value4.Y) * num2));
            vector.Z = 0.5f * ((((2f * value2.Z) + ((-value1.Z + value3.Z) * amount)) + (((((2f * value1.Z) - (5f * value2.Z)) + (4f * value3.Z)) - value4.Z) * num)) + ((((-value1.Z + (3f * value2.Z)) - (3f * value3.Z)) + value4.Z) * num2));
            vector.W = 0.5f * ((((2f * value2.W) + ((-value1.W + value3.W) * amount)) + (((((2f * value1.W) - (5f * value2.W)) + (4f * value3.W)) - value4.W) * num)) + ((((-value1.W + (3f * value2.W)) - (3f * value3.W)) + value4.W) * num2));
            return vector;
        }

        public static void CatmullRom(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, ref Vector4 value4, float amount, out Vector4 result)
        {
            float num = amount * amount;
            float num2 = amount * num;
            result.X = 0.5f * ((((2f * value2.X) + ((-value1.X + value3.X) * amount)) + (((((2f * value1.X) - (5f * value2.X)) + (4f * value3.X)) - value4.X) * num)) + ((((-value1.X + (3f * value2.X)) - (3f * value3.X)) + value4.X) * num2));
            result.Y = 0.5f * ((((2f * value2.Y) + ((-value1.Y + value3.Y) * amount)) + (((((2f * value1.Y) - (5f * value2.Y)) + (4f * value3.Y)) - value4.Y) * num)) + ((((-value1.Y + (3f * value2.Y)) - (3f * value3.Y)) + value4.Y) * num2));
            result.Z = 0.5f * ((((2f * value2.Z) + ((-value1.Z + value3.Z) * amount)) + (((((2f * value1.Z) - (5f * value2.Z)) + (4f * value3.Z)) - value4.Z) * num)) + ((((-value1.Z + (3f * value2.Z)) - (3f * value3.Z)) + value4.Z) * num2));
            result.W = 0.5f * ((((2f * value2.W) + ((-value1.W + value3.W) * amount)) + (((((2f * value1.W) - (5f * value2.W)) + (4f * value3.W)) - value4.W) * num)) + ((((-value1.W + (3f * value2.W)) - (3f * value3.W)) + value4.W) * num2));
        }

        public static Vector4 Hermite(Vector4 value1, Vector4 tangent1, Vector4 value2, Vector4 tangent2, float amount)
        {
            Vector4 vector;
            float num = amount * amount;
            float num2 = amount * num;
            float num3 = ((2f * num2) - (3f * num)) + 1f;
            float num4 = (-2f * num2) + (3f * num);
            float num5 = (num2 - (2f * num)) + amount;
            float num6 = num2 - num;
            vector.X = (((value1.X * num3) + (value2.X * num4)) + (tangent1.X * num5)) + (tangent2.X * num6);
            vector.Y = (((value1.Y * num3) + (value2.Y * num4)) + (tangent1.Y * num5)) + (tangent2.Y * num6);
            vector.Z = (((value1.Z * num3) + (value2.Z * num4)) + (tangent1.Z * num5)) + (tangent2.Z * num6);
            vector.W = (((value1.W * num3) + (value2.W * num4)) + (tangent1.W * num5)) + (tangent2.W * num6);
            return vector;
        }

        public static void Hermite(ref Vector4 value1, ref Vector4 tangent1, ref Vector4 value2, ref Vector4 tangent2, float amount, out Vector4 result)
        {
            float num = amount * amount;
            float num2 = amount * num;
            float num3 = ((2f * num2) - (3f * num)) + 1f;
            float num4 = (-2f * num2) + (3f * num);
            float num5 = (num2 - (2f * num)) + amount;
            float num6 = num2 - num;
            result.X = (((value1.X * num3) + (value2.X * num4)) + (tangent1.X * num5)) + (tangent2.X * num6);
            result.Y = (((value1.Y * num3) + (value2.Y * num4)) + (tangent1.Y * num5)) + (tangent2.Y * num6);
            result.Z = (((value1.Z * num3) + (value2.Z * num4)) + (tangent1.Z * num5)) + (tangent2.Z * num6);
            result.W = (((value1.W * num3) + (value2.W * num4)) + (tangent1.W * num5)) + (tangent2.W * num6);
        }

        public static Vector4 Transform(Vector2 position, Matrix matrix)
        {
            Vector4 vector;
            float num = ((position.X * matrix.M11) + (position.Y * matrix.M21)) + matrix.M41;
            float num2 = ((position.X * matrix.M12) + (position.Y * matrix.M22)) + matrix.M42;
            float num3 = ((position.X * matrix.M13) + (position.Y * matrix.M23)) + matrix.M43;
            float num4 = ((position.X * matrix.M14) + (position.Y * matrix.M24)) + matrix.M44;
            vector.X = num;
            vector.Y = num2;
            vector.Z = num3;
            vector.W = num4;
            return vector;
        }

        public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector4 result)
        {
            float num = ((position.X * matrix.M11) + (position.Y * matrix.M21)) + matrix.M41;
            float num2 = ((position.X * matrix.M12) + (position.Y * matrix.M22)) + matrix.M42;
            float num3 = ((position.X * matrix.M13) + (position.Y * matrix.M23)) + matrix.M43;
            float num4 = ((position.X * matrix.M14) + (position.Y * matrix.M24)) + matrix.M44;
            result.X = num;
            result.Y = num2;
            result.Z = num3;
            result.W = num4;
        }

        public static Vector4 Transform(Vector3 position, Matrix matrix)
        {
            Vector4 vector;
            float num = (((position.X * matrix.M11) + (position.Y * matrix.M21)) + (position.Z * matrix.M31)) + matrix.M41;
            float num2 = (((position.X * matrix.M12) + (position.Y * matrix.M22)) + (position.Z * matrix.M32)) + matrix.M42;
            float num3 = (((position.X * matrix.M13) + (position.Y * matrix.M23)) + (position.Z * matrix.M33)) + matrix.M43;
            float num4 = (((position.X * matrix.M14) + (position.Y * matrix.M24)) + (position.Z * matrix.M34)) + matrix.M44;
            vector.X = num;
            vector.Y = num2;
            vector.Z = num3;
            vector.W = num4;
            return vector;
        }

        public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector4 result)
        {
            float num = (((position.X * matrix.M11) + (position.Y * matrix.M21)) + (position.Z * matrix.M31)) + matrix.M41;
            float num2 = (((position.X * matrix.M12) + (position.Y * matrix.M22)) + (position.Z * matrix.M32)) + matrix.M42;
            float num3 = (((position.X * matrix.M13) + (position.Y * matrix.M23)) + (position.Z * matrix.M33)) + matrix.M43;
            float num4 = (((position.X * matrix.M14) + (position.Y * matrix.M24)) + (position.Z * matrix.M34)) + matrix.M44;
            result.X = num;
            result.Y = num2;
            result.Z = num3;
            result.W = num4;
        }

        public static Vector4 Transform(Vector4 vector, Matrix matrix)
        {
            Vector4 vector2;
            float num = (((vector.X * matrix.M11) + (vector.Y * matrix.M21)) + (vector.Z * matrix.M31)) + (vector.W * matrix.M41);
            float num2 = (((vector.X * matrix.M12) + (vector.Y * matrix.M22)) + (vector.Z * matrix.M32)) + (vector.W * matrix.M42);
            float num3 = (((vector.X * matrix.M13) + (vector.Y * matrix.M23)) + (vector.Z * matrix.M33)) + (vector.W * matrix.M43);
            float num4 = (((vector.X * matrix.M14) + (vector.Y * matrix.M24)) + (vector.Z * matrix.M34)) + (vector.W * matrix.M44);
            vector2.X = num;
            vector2.Y = num2;
            vector2.Z = num3;
            vector2.W = num4;
            return vector2;
        }

        public static void Transform(ref Vector4 vector, ref Matrix matrix, out Vector4 result)
        {
            float num = (((vector.X * matrix.M11) + (vector.Y * matrix.M21)) + (vector.Z * matrix.M31)) + (vector.W * matrix.M41);
            float num2 = (((vector.X * matrix.M12) + (vector.Y * matrix.M22)) + (vector.Z * matrix.M32)) + (vector.W * matrix.M42);
            float num3 = (((vector.X * matrix.M13) + (vector.Y * matrix.M23)) + (vector.Z * matrix.M33)) + (vector.W * matrix.M43);
            float num4 = (((vector.X * matrix.M14) + (vector.Y * matrix.M24)) + (vector.Z * matrix.M34)) + (vector.W * matrix.M44);
            result.X = num;
            result.Y = num2;
            result.Z = num3;
            result.W = num4;
        }

        public static Vector4 Transform(Vector2 value, Quaternion rotation)
        {
            Vector4 vector;
            float num = rotation.X + rotation.X;
            float num2 = rotation.Y + rotation.Y;
            float num3 = rotation.Z + rotation.Z;
            float num4 = rotation.W * num;
            float num5 = rotation.W * num2;
            float num6 = rotation.W * num3;
            float num7 = rotation.X * num;
            float num8 = rotation.X * num2;
            float num9 = rotation.X * num3;
            float num10 = rotation.Y * num2;
            float num11 = rotation.Y * num3;
            float num12 = rotation.Z * num3;
            float num13 = (value.X * ((1f - num10) - num12)) + (value.Y * (num8 - num6));
            float num14 = (value.X * (num8 + num6)) + (value.Y * ((1f - num7) - num12));
            float num15 = (value.X * (num9 - num5)) + (value.Y * (num11 + num4));
            vector.X = num13;
            vector.Y = num14;
            vector.Z = num15;
            vector.W = 1f;
            return vector;
        }

        public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector4 result)
        {
            float num = rotation.X + rotation.X;
            float num2 = rotation.Y + rotation.Y;
            float num3 = rotation.Z + rotation.Z;
            float num4 = rotation.W * num;
            float num5 = rotation.W * num2;
            float num6 = rotation.W * num3;
            float num7 = rotation.X * num;
            float num8 = rotation.X * num2;
            float num9 = rotation.X * num3;
            float num10 = rotation.Y * num2;
            float num11 = rotation.Y * num3;
            float num12 = rotation.Z * num3;
            float num13 = (value.X * ((1f - num10) - num12)) + (value.Y * (num8 - num6));
            float num14 = (value.X * (num8 + num6)) + (value.Y * ((1f - num7) - num12));
            float num15 = (value.X * (num9 - num5)) + (value.Y * (num11 + num4));
            result.X = num13;
            result.Y = num14;
            result.Z = num15;
            result.W = 1f;
        }

        public static Vector4 Transform(Vector3 value, Quaternion rotation)
        {
            Vector4 vector;
            float num = rotation.X + rotation.X;
            float num2 = rotation.Y + rotation.Y;
            float num3 = rotation.Z + rotation.Z;
            float num4 = rotation.W * num;
            float num5 = rotation.W * num2;
            float num6 = rotation.W * num3;
            float num7 = rotation.X * num;
            float num8 = rotation.X * num2;
            float num9 = rotation.X * num3;
            float num10 = rotation.Y * num2;
            float num11 = rotation.Y * num3;
            float num12 = rotation.Z * num3;
            float num13 = ((value.X * ((1f - num10) - num12)) + (value.Y * (num8 - num6))) + (value.Z * (num9 + num5));
            float num14 = ((value.X * (num8 + num6)) + (value.Y * ((1f - num7) - num12))) + (value.Z * (num11 - num4));
            float num15 = ((value.X * (num9 - num5)) + (value.Y * (num11 + num4))) + (value.Z * ((1f - num7) - num10));
            vector.X = num13;
            vector.Y = num14;
            vector.Z = num15;
            vector.W = 1f;
            return vector;
        }

        public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector4 result)
        {
            float num = rotation.X + rotation.X;
            float num2 = rotation.Y + rotation.Y;
            float num3 = rotation.Z + rotation.Z;
            float num4 = rotation.W * num;
            float num5 = rotation.W * num2;
            float num6 = rotation.W * num3;
            float num7 = rotation.X * num;
            float num8 = rotation.X * num2;
            float num9 = rotation.X * num3;
            float num10 = rotation.Y * num2;
            float num11 = rotation.Y * num3;
            float num12 = rotation.Z * num3;
            float num13 = ((value.X * ((1f - num10) - num12)) + (value.Y * (num8 - num6))) + (value.Z * (num9 + num5));
            float num14 = ((value.X * (num8 + num6)) + (value.Y * ((1f - num7) - num12))) + (value.Z * (num11 - num4));
            float num15 = ((value.X * (num9 - num5)) + (value.Y * (num11 + num4))) + (value.Z * ((1f - num7) - num10));
            result.X = num13;
            result.Y = num14;
            result.Z = num15;
            result.W = 1f;
        }

        public static Vector4 Transform(Vector4 value, Quaternion rotation)
        {
            Vector4 vector;
            float num = rotation.X + rotation.X;
            float num2 = rotation.Y + rotation.Y;
            float num3 = rotation.Z + rotation.Z;
            float num4 = rotation.W * num;
            float num5 = rotation.W * num2;
            float num6 = rotation.W * num3;
            float num7 = rotation.X * num;
            float num8 = rotation.X * num2;
            float num9 = rotation.X * num3;
            float num10 = rotation.Y * num2;
            float num11 = rotation.Y * num3;
            float num12 = rotation.Z * num3;
            float num13 = ((value.X * ((1f - num10) - num12)) + (value.Y * (num8 - num6))) + (value.Z * (num9 + num5));
            float num14 = ((value.X * (num8 + num6)) + (value.Y * ((1f - num7) - num12))) + (value.Z * (num11 - num4));
            float num15 = ((value.X * (num9 - num5)) + (value.Y * (num11 + num4))) + (value.Z * ((1f - num7) - num10));
            vector.X = num13;
            vector.Y = num14;
            vector.Z = num15;
            vector.W = value.W;
            return vector;
        }

        public static void Transform(ref Vector4 value, ref Quaternion rotation, out Vector4 result)
        {
            float num = rotation.X + rotation.X;
            float num2 = rotation.Y + rotation.Y;
            float num3 = rotation.Z + rotation.Z;
            float num4 = rotation.W * num;
            float num5 = rotation.W * num2;
            float num6 = rotation.W * num3;
            float num7 = rotation.X * num;
            float num8 = rotation.X * num2;
            float num9 = rotation.X * num3;
            float num10 = rotation.Y * num2;
            float num11 = rotation.Y * num3;
            float num12 = rotation.Z * num3;
            float num13 = ((value.X * ((1f - num10) - num12)) + (value.Y * (num8 - num6))) + (value.Z * (num9 + num5));
            float num14 = ((value.X * (num8 + num6)) + (value.Y * ((1f - num7) - num12))) + (value.Z * (num11 - num4));
            float num15 = ((value.X * (num9 - num5)) + (value.Y * (num11 + num4))) + (value.Z * ((1f - num7) - num10));
            result.X = num13;
            result.Y = num14;
            result.Z = num15;
            result.W = value.W;
        }

        public static void Transform(Vector4[] sourceArray, ref Matrix matrix, Vector4[] destinationArray)
        {
            if (sourceArray == null)
            {
                throw new ArgumentNullException("sourceArray");
            }
            if (destinationArray == null)
            {
                throw new ArgumentNullException("destinationArray");
            }
            if (destinationArray.Length < sourceArray.Length)
            {
                throw new ArgumentException("FrameworkResources.NotEnoughTargetSize");
            }
            for (int i = 0; i < sourceArray.Length; i++)
            {
                float x = sourceArray[i].X;
                float y = sourceArray[i].Y;
                float z = sourceArray[i].Z;
                float w = sourceArray[i].W;
                destinationArray[i].X = (((x * matrix.M11) + (y * matrix.M21)) + (z * matrix.M31)) + (w * matrix.M41);
                destinationArray[i].Y = (((x * matrix.M12) + (y * matrix.M22)) + (z * matrix.M32)) + (w * matrix.M42);
                destinationArray[i].Z = (((x * matrix.M13) + (y * matrix.M23)) + (z * matrix.M33)) + (w * matrix.M43);
                destinationArray[i].W = (((x * matrix.M14) + (y * matrix.M24)) + (z * matrix.M34)) + (w * matrix.M44);
            }
        }

        public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Matrix matrix, Vector4[] destinationArray, int destinationIndex, int length)
        {
            if (sourceArray == null)
            {
                throw new ArgumentNullException("sourceArray");
            }
            if (destinationArray == null)
            {
                throw new ArgumentNullException("destinationArray");
            }
            if (sourceArray.Length < (sourceIndex + length))
            {
                throw new ArgumentException("FrameworkResources.NotEnoughSourceSize");
            }
            if (destinationArray.Length < (destinationIndex + length))
            {
                throw new ArgumentException("FrameworkResources.NotEnoughTargetSize");
            }
            while (length > 0)
            {
                float x = sourceArray[sourceIndex].X;
                float y = sourceArray[sourceIndex].Y;
                float z = sourceArray[sourceIndex].Z;
                float w = sourceArray[sourceIndex].W;
                destinationArray[destinationIndex].X = (((x * matrix.M11) + (y * matrix.M21)) + (z * matrix.M31)) + (w * matrix.M41);
                destinationArray[destinationIndex].Y = (((x * matrix.M12) + (y * matrix.M22)) + (z * matrix.M32)) + (w * matrix.M42);
                destinationArray[destinationIndex].Z = (((x * matrix.M13) + (y * matrix.M23)) + (z * matrix.M33)) + (w * matrix.M43);
                destinationArray[destinationIndex].W = (((x * matrix.M14) + (y * matrix.M24)) + (z * matrix.M34)) + (w * matrix.M44);
                sourceIndex++;
                destinationIndex++;
                length--;
            }
        }

        public static void Transform(Vector4[] sourceArray, ref Quaternion rotation, Vector4[] destinationArray)
        {
            if (sourceArray == null)
            {
                throw new ArgumentNullException("sourceArray");
            }
            if (destinationArray == null)
            {
                throw new ArgumentNullException("destinationArray");
            }
            if (destinationArray.Length < sourceArray.Length)
            {
                throw new ArgumentException("FrameworkResources.NotEnoughTargetSize");
            }
            float num = rotation.X + rotation.X;
            float num2 = rotation.Y + rotation.Y;
            float num3 = rotation.Z + rotation.Z;
            float num4 = rotation.W * num;
            float num5 = rotation.W * num2;
            float num6 = rotation.W * num3;
            float num7 = rotation.X * num;
            float num8 = rotation.X * num2;
            float num9 = rotation.X * num3;
            float num10 = rotation.Y * num2;
            float num11 = rotation.Y * num3;
            float num12 = rotation.Z * num3;
            float num13 = (1f - num10) - num12;
            float num14 = num8 - num6;
            float num15 = num9 + num5;
            float num16 = num8 + num6;
            float num17 = (1f - num7) - num12;
            float num18 = num11 - num4;
            float num19 = num9 - num5;
            float num20 = num11 + num4;
            float num21 = (1f - num7) - num10;
            for (int i = 0; i < sourceArray.Length; i++)
            {
                float x = sourceArray[i].X;
                float y = sourceArray[i].Y;
                float z = sourceArray[i].Z;
                destinationArray[i].X = ((x * num13) + (y * num14)) + (z * num15);
                destinationArray[i].Y = ((x * num16) + (y * num17)) + (z * num18);
                destinationArray[i].Z = ((x * num19) + (y * num20)) + (z * num21);
                destinationArray[i].W = sourceArray[i].W;
            }
        }

        public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector4[] destinationArray, int destinationIndex, int length)
        {
            if (sourceArray == null)
            {
                throw new ArgumentNullException("sourceArray");
            }
            if (destinationArray == null)
            {
                throw new ArgumentNullException("destinationArray");
            }
            if (sourceArray.Length < (sourceIndex + length))
            {
                throw new ArgumentException("FrameworkResources.NotEnoughSourceSize");
            }
            if (destinationArray.Length < (destinationIndex + length))
            {
                throw new ArgumentException("FrameworkResources.NotEnoughTargetSize");
            }
            float num = rotation.X + rotation.X;
            float num2 = rotation.Y + rotation.Y;
            float num3 = rotation.Z + rotation.Z;
            float num4 = rotation.W * num;
            float num5 = rotation.W * num2;
            float num6 = rotation.W * num3;
            float num7 = rotation.X * num;
            float num8 = rotation.X * num2;
            float num9 = rotation.X * num3;
            float num10 = rotation.Y * num2;
            float num11 = rotation.Y * num3;
            float num12 = rotation.Z * num3;
            float num13 = (1f - num10) - num12;
            float num14 = num8 - num6;
            float num15 = num9 + num5;
            float num16 = num8 + num6;
            float num17 = (1f - num7) - num12;
            float num18 = num11 - num4;
            float num19 = num9 - num5;
            float num20 = num11 + num4;
            float num21 = (1f - num7) - num10;
            while (length > 0)
            {
                float x = sourceArray[sourceIndex].X;
                float y = sourceArray[sourceIndex].Y;
                float z = sourceArray[sourceIndex].Z;
                float w = sourceArray[sourceIndex].W;
                destinationArray[destinationIndex].X = ((x * num13) + (y * num14)) + (z * num15);
                destinationArray[destinationIndex].Y = ((x * num16) + (y * num17)) + (z * num18);
                destinationArray[destinationIndex].Z = ((x * num19) + (y * num20)) + (z * num21);
                destinationArray[destinationIndex].W = w;
                sourceIndex++;
                destinationIndex++;
                length--;
            }
        }

        public static Vector4 Negate(Vector4 value)
        {
            Vector4 vector;
            vector.X = -value.X;
            vector.Y = -value.Y;
            vector.Z = -value.Z;
            vector.W = -value.W;
            return vector;
        }

        public static void Negate(ref Vector4 value, out Vector4 result)
        {
            result.X = -value.X;
            result.Y = -value.Y;
            result.Z = -value.Z;
            result.W = -value.W;
        }

        public static Vector4 Add(Vector4 value1, Vector4 value2)
        {
            Vector4 vector;
            vector.X = value1.X + value2.X;
            vector.Y = value1.Y + value2.Y;
            vector.Z = value1.Z + value2.Z;
            vector.W = value1.W + value2.W;
            return vector;
        }

        public static void Add(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
        {
            result.X = value1.X + value2.X;
            result.Y = value1.Y + value2.Y;
            result.Z = value1.Z + value2.Z;
            result.W = value1.W + value2.W;
        }

        public static Vector4 Subtract(Vector4 value1, Vector4 value2)
        {
            Vector4 vector;
            vector.X = value1.X - value2.X;
            vector.Y = value1.Y - value2.Y;
            vector.Z = value1.Z - value2.Z;
            vector.W = value1.W - value2.W;
            return vector;
        }

        public static void Subtract(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
        {
            result.X = value1.X - value2.X;
            result.Y = value1.Y - value2.Y;
            result.Z = value1.Z - value2.Z;
            result.W = value1.W - value2.W;
        }

        public static Vector4 Multiply(Vector4 value1, Vector4 value2)
        {
            Vector4 vector;
            vector.X = value1.X * value2.X;
            vector.Y = value1.Y * value2.Y;
            vector.Z = value1.Z * value2.Z;
            vector.W = value1.W * value2.W;
            return vector;
        }

        public static void Multiply(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
        {
            result.X = value1.X * value2.X;
            result.Y = value1.Y * value2.Y;
            result.Z = value1.Z * value2.Z;
            result.W = value1.W * value2.W;
        }

        public static Vector4 Multiply(Vector4 value1, float scaleFactor)
        {
            Vector4 vector;
            vector.X = value1.X * scaleFactor;
            vector.Y = value1.Y * scaleFactor;
            vector.Z = value1.Z * scaleFactor;
            vector.W = value1.W * scaleFactor;
            return vector;
        }

        public static void Multiply(ref Vector4 value1, float scaleFactor, out Vector4 result)
        {
            result.X = value1.X * scaleFactor;
            result.Y = value1.Y * scaleFactor;
            result.Z = value1.Z * scaleFactor;
            result.W = value1.W * scaleFactor;
        }

        public static Vector4 Divide(Vector4 value1, Vector4 value2)
        {
            Vector4 vector;
            vector.X = value1.X / value2.X;
            vector.Y = value1.Y / value2.Y;
            vector.Z = value1.Z / value2.Z;
            vector.W = value1.W / value2.W;
            return vector;
        }

        public static void Divide(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
        {
            result.X = value1.X / value2.X;
            result.Y = value1.Y / value2.Y;
            result.Z = value1.Z / value2.Z;
            result.W = value1.W / value2.W;
        }

        public static Vector4 Divide(Vector4 value1, float divider)
        {
            Vector4 vector;
            float num = 1f / divider;
            vector.X = value1.X * num;
            vector.Y = value1.Y * num;
            vector.Z = value1.Z * num;
            vector.W = value1.W * num;
            return vector;
        }

        public static void Divide(ref Vector4 value1, float divider, out Vector4 result)
        {
            float num = 1f / divider;
            result.X = value1.X * num;
            result.Y = value1.Y * num;
            result.Z = value1.Z * num;
            result.W = value1.W * num;
        }

        public static Vector4 operator -(Vector4 value)
        {
            Vector4 vector;
            vector.X = -value.X;
            vector.Y = -value.Y;
            vector.Z = -value.Z;
            vector.W = -value.W;
            return vector;
        }

        public static bool operator ==(Vector4 value1, Vector4 value2)
        {
            return ((((value1.X == value2.X) && (value1.Y == value2.Y)) && (value1.Z == value2.Z)) && (value1.W == value2.W));
        }

        public static bool operator !=(Vector4 value1, Vector4 value2)
        {
            return ((((value1.X != value2.X) || (value1.Y != value2.Y)) || (value1.Z != value2.Z)) || !(value1.W == value2.W));
        }

        public static Vector4 operator +(Vector4 value1, Vector4 value2)
        {
            Vector4 vector;
            vector.X = value1.X + value2.X;
            vector.Y = value1.Y + value2.Y;
            vector.Z = value1.Z + value2.Z;
            vector.W = value1.W + value2.W;
            return vector;
        }

        public static Vector4 operator -(Vector4 value1, Vector4 value2)
        {
            Vector4 vector;
            vector.X = value1.X - value2.X;
            vector.Y = value1.Y - value2.Y;
            vector.Z = value1.Z - value2.Z;
            vector.W = value1.W - value2.W;
            return vector;
        }

        public static Vector4 operator *(Vector4 value1, Vector4 value2)
        {
            Vector4 vector;
            vector.X = value1.X * value2.X;
            vector.Y = value1.Y * value2.Y;
            vector.Z = value1.Z * value2.Z;
            vector.W = value1.W * value2.W;
            return vector;
        }

        public static Vector4 operator *(Vector4 value1, float scaleFactor)
        {
            Vector4 vector;
            vector.X = value1.X * scaleFactor;
            vector.Y = value1.Y * scaleFactor;
            vector.Z = value1.Z * scaleFactor;
            vector.W = value1.W * scaleFactor;
            return vector;
        }

        public static Vector4 operator *(float scaleFactor, Vector4 value1)
        {
            Vector4 vector;
            vector.X = value1.X * scaleFactor;
            vector.Y = value1.Y * scaleFactor;
            vector.Z = value1.Z * scaleFactor;
            vector.W = value1.W * scaleFactor;
            return vector;
        }

        public static Vector4 operator /(Vector4 value1, Vector4 value2)
        {
            Vector4 vector;
            vector.X = value1.X / value2.X;
            vector.Y = value1.Y / value2.Y;
            vector.Z = value1.Z / value2.Z;
            vector.W = value1.W / value2.W;
            return vector;
        }

        public static Vector4 operator /(Vector4 value1, float divider)
        {
            Vector4 vector;
            float num = 1f / divider;
            vector.X = value1.X * num;
            vector.Y = value1.Y * num;
            vector.Z = value1.Z * num;
            vector.W = value1.W * num;
            return vector;
        }

        static Vector4()
        {
            _zero = new Vector4();
            _one = new Vector4(1f, 1f, 1f, 1f);
            _unitX = new Vector4(1f, 0f, 0f, 0f);
            _unitY = new Vector4(0f, 1f, 0f, 0f);
            _unitZ = new Vector4(0f, 0f, 1f, 0f);
            _unitW = new Vector4(0f, 0f, 0f, 1f);
        }
    }


}
