using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix : IEquatable<Matrix>
    {
        public float M11;
        public float M12;
        public float M13;
        public float M14;
        public float M21;
        public float M22;
        public float M23;
        public float M24;
        public float M31;
        public float M32;
        public float M33;
        public float M34;
        public float M41;
        public float M42;
        public float M43;
        public float M44;
        private static Matrix _identity;

        public float[] Get_This_Matrix4x4_In_Float_Array() 
        {
            float[] MatrixFloat = { M11, M12, M13, M14, M21, M22, M23, M24, M31, M32, M33, M34, M41, M42, M43, M44 };
                        
            return MatrixFloat;

        }

        public static Matrix Identity
        {
            get
            {
                return _identity;
            }
        }
        public Vector3 Up
        {
            get
            {
                Vector3 vector;
                vector.X = this.M21;
                vector.Y = this.M22;
                vector.Z = this.M23;
                return vector;
            }
            set
            {
                this.M21 = value.X;
                this.M22 = value.Y;
                this.M23 = value.Z;
            }
        }
        public Vector3 Down
        {
            get
            {
                Vector3 vector;
                vector.X = -this.M21;
                vector.Y = -this.M22;
                vector.Z = -this.M23;
                return vector;
            }
            set
            {
                this.M21 = -value.X;
                this.M22 = -value.Y;
                this.M23 = -value.Z;
            }
        }
        public Vector3 Right
        {
            get
            {
                Vector3 vector;
                vector.X = this.M11;
                vector.Y = this.M12;
                vector.Z = this.M13;
                return vector;
            }
            set
            {
                this.M11 = value.X;
                this.M12 = value.Y;
                this.M13 = value.Z;
            }
        }
        public Vector3 Left
        {
            get
            {
                Vector3 vector;
                vector.X = -this.M11;
                vector.Y = -this.M12;
                vector.Z = -this.M13;
                return vector;
            }
            set
            {
                this.M11 = -value.X;
                this.M12 = -value.Y;
                this.M13 = -value.Z;
            }
        }
        public Vector3 Forward
        {
            get
            {
                Vector3 vector;
                vector.X = -this.M31;
                vector.Y = -this.M32;
                vector.Z = -this.M33;
                return vector;
            }
            set
            {
                this.M31 = -value.X;
                this.M32 = -value.Y;
                this.M33 = -value.Z;
            }
        }
        public Vector3 Backward
        {
            get
            {
                Vector3 vector;
                vector.X = this.M31;
                vector.Y = this.M32;
                vector.Z = this.M33;
                return vector;
            }
            set
            {
                this.M31 = value.X;
                this.M32 = value.Y;
                this.M33 = value.Z;
            }
        }
        public Vector3 Translation
        {
            get
            {
                Vector3 vector;
                vector.X = this.M41;
                vector.Y = this.M42;
                vector.Z = this.M43;
                return vector;
            }
            set
            {
                this.M41 = value.X;
                this.M42 = value.Y;
                this.M43 = value.Z;
            }
        }
        public Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
        {
            this.M11 = m11;
            this.M12 = m12;
            this.M13 = m13;
            this.M14 = m14;
            this.M21 = m21;
            this.M22 = m22;
            this.M23 = m23;
            this.M24 = m24;
            this.M31 = m31;
            this.M32 = m32;
            this.M33 = m33;
            this.M34 = m34;
            this.M41 = m41;
            this.M42 = m42;
            this.M43 = m43;
            this.M44 = m44;
        }

        public static Matrix CreateBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 cameraUpVector, Vector3? cameraForwardVector)
        {
            Vector3 vector;
            Vector3 vector2;
            Vector3 vector3;
            Matrix matrix;
            vector.X = objectPosition.X - cameraPosition.X;
            vector.Y = objectPosition.Y - cameraPosition.Y;
            vector.Z = objectPosition.Z - cameraPosition.Z;
            float num = vector.LengthSquared();
            if (num < 0.0001f)
            {
                vector = cameraForwardVector.HasValue ? -cameraForwardVector.Value : Vector3.Forward;
            }
            else
            {
                Vector3.Multiply(ref vector, (float)(1f / ((float)Math.Sqrt((double)num))), out vector);
            }
            Vector3.Cross(ref cameraUpVector, ref vector, out vector2);
            vector2.Normalize();
            Vector3.Cross(ref vector, ref vector2, out vector3);
            matrix.M11 = vector2.X;
            matrix.M12 = vector2.Y;
            matrix.M13 = vector2.Z;
            matrix.M14 = 0f;
            matrix.M21 = vector3.X;
            matrix.M22 = vector3.Y;
            matrix.M23 = vector3.Z;
            matrix.M24 = 0f;
            matrix.M31 = vector.X;
            matrix.M32 = vector.Y;
            matrix.M33 = vector.Z;
            matrix.M34 = 0f;
            matrix.M41 = objectPosition.X;
            matrix.M42 = objectPosition.Y;
            matrix.M43 = objectPosition.Z;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 cameraUpVector, Vector3? cameraForwardVector, out Matrix result)
        {
            Vector3 vector;
            Vector3 vector2;
            Vector3 vector3;
            vector.X = objectPosition.X - cameraPosition.X;
            vector.Y = objectPosition.Y - cameraPosition.Y;
            vector.Z = objectPosition.Z - cameraPosition.Z;
            float num = vector.LengthSquared();
            if (num < 0.0001f)
            {
                vector = cameraForwardVector.HasValue ? -cameraForwardVector.Value : Vector3.Forward;
            }
            else
            {
                Vector3.Multiply(ref vector, (float)(1f / ((float)Math.Sqrt((double)num))), out vector);
            }
            Vector3.Cross(ref cameraUpVector, ref vector, out vector2);
            vector2.Normalize();
            Vector3.Cross(ref vector, ref vector2, out vector3);
            result.M11 = vector2.X;
            result.M12 = vector2.Y;
            result.M13 = vector2.Z;
            result.M14 = 0f;
            result.M21 = vector3.X;
            result.M22 = vector3.Y;
            result.M23 = vector3.Z;
            result.M24 = 0f;
            result.M31 = vector.X;
            result.M32 = vector.Y;
            result.M33 = vector.Z;
            result.M34 = 0f;
            result.M41 = objectPosition.X;
            result.M42 = objectPosition.Y;
            result.M43 = objectPosition.Z;
            result.M44 = 1f;
        }

        public static Matrix CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector)
        {
            Vector3 vector;
            Vector3 vector3;
            Vector3 vector4;
            float num2;
            Matrix matrix;
            vector.X = objectPosition.X - cameraPosition.X;
            vector.Y = objectPosition.Y - cameraPosition.Y;
            vector.Z = objectPosition.Z - cameraPosition.Z;
            float num = vector.LengthSquared();
            if (num < 0.0001f)
            {
                vector = cameraForwardVector.HasValue ? -cameraForwardVector.Value : Vector3.Forward;
            }
            else
            {
                Vector3.Multiply(ref vector, (float)(1f / ((float)Math.Sqrt((double)num))), out vector);
            }
            Vector3 vector2 = rotateAxis;
            Vector3.Dot(ref rotateAxis, ref vector, out num2);
            if (Math.Abs(num2) > 0.9982547f)
            {
                if (objectForwardVector.HasValue)
                {
                    vector4 = objectForwardVector.Value;
                    Vector3.Dot(ref rotateAxis, ref vector4, out num2);
                    if (Math.Abs(num2) > 0.9982547f)
                    {
                        num2 = ((rotateAxis.X * Vector3.Forward.X) + (rotateAxis.Y * Vector3.Forward.Y)) + (rotateAxis.Z * Vector3.Forward.Z);
                        vector4 = (Math.Abs(num2) > 0.9982547f) ? Vector3.Right : Vector3.Forward;
                    }
                }
                else
                {
                    num2 = ((rotateAxis.X * Vector3.Forward.X) + (rotateAxis.Y * Vector3.Forward.Y)) + (rotateAxis.Z * Vector3.Forward.Z);
                    vector4 = (Math.Abs(num2) > 0.9982547f) ? Vector3.Right : Vector3.Forward;
                }
                Vector3.Cross(ref rotateAxis, ref vector4, out vector3);
                vector3.Normalize();
                Vector3.Cross(ref vector3, ref rotateAxis, out vector4);
                vector4.Normalize();
            }
            else
            {
                Vector3.Cross(ref rotateAxis, ref vector, out vector3);
                vector3.Normalize();
                Vector3.Cross(ref vector3, ref vector2, out vector4);
                vector4.Normalize();
            }
            matrix.M11 = vector3.X;
            matrix.M12 = vector3.Y;
            matrix.M13 = vector3.Z;
            matrix.M14 = 0f;
            matrix.M21 = vector2.X;
            matrix.M22 = vector2.Y;
            matrix.M23 = vector2.Z;
            matrix.M24 = 0f;
            matrix.M31 = vector4.X;
            matrix.M32 = vector4.Y;
            matrix.M33 = vector4.Z;
            matrix.M34 = 0f;
            matrix.M41 = objectPosition.X;
            matrix.M42 = objectPosition.Y;
            matrix.M43 = objectPosition.Z;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateConstrainedBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector, out Matrix result)
        {
            Vector3 vector;
            Vector3 vector3;
            Vector3 vector4;
            float num2;
            vector.X = objectPosition.X - cameraPosition.X;
            vector.Y = objectPosition.Y - cameraPosition.Y;
            vector.Z = objectPosition.Z - cameraPosition.Z;
            float num = vector.LengthSquared();
            if (num < 0.0001f)
            {
                vector = cameraForwardVector.HasValue ? -cameraForwardVector.Value : Vector3.Forward;
            }
            else
            {
                Vector3.Multiply(ref vector, (float)(1f / ((float)Math.Sqrt((double)num))), out vector);
            }
            Vector3 vector2 = rotateAxis;
            Vector3.Dot(ref rotateAxis, ref vector, out num2);
            if (Math.Abs(num2) > 0.9982547f)
            {
                if (objectForwardVector.HasValue)
                {
                    vector4 = objectForwardVector.Value;
                    Vector3.Dot(ref rotateAxis, ref vector4, out num2);
                    if (Math.Abs(num2) > 0.9982547f)
                    {
                        num2 = ((rotateAxis.X * Vector3.Forward.X) + (rotateAxis.Y * Vector3.Forward.Y)) + (rotateAxis.Z * Vector3.Forward.Z);
                        vector4 = (Math.Abs(num2) > 0.9982547f) ? Vector3.Right : Vector3.Forward;
                    }
                }
                else
                {
                    num2 = ((rotateAxis.X * Vector3.Forward.X) + (rotateAxis.Y * Vector3.Forward.Y)) + (rotateAxis.Z * Vector3.Forward.Z);
                    vector4 = (Math.Abs(num2) > 0.9982547f) ? Vector3.Right : Vector3.Forward;
                }
                Vector3.Cross(ref rotateAxis, ref vector4, out vector3);
                vector3.Normalize();
                Vector3.Cross(ref vector3, ref rotateAxis, out vector4);
                vector4.Normalize();
            }
            else
            {
                Vector3.Cross(ref rotateAxis, ref vector, out vector3);
                vector3.Normalize();
                Vector3.Cross(ref vector3, ref vector2, out vector4);
                vector4.Normalize();
            }
            result.M11 = vector3.X;
            result.M12 = vector3.Y;
            result.M13 = vector3.Z;
            result.M14 = 0f;
            result.M21 = vector2.X;
            result.M22 = vector2.Y;
            result.M23 = vector2.Z;
            result.M24 = 0f;
            result.M31 = vector4.X;
            result.M32 = vector4.Y;
            result.M33 = vector4.Z;
            result.M34 = 0f;
            result.M41 = objectPosition.X;
            result.M42 = objectPosition.Y;
            result.M43 = objectPosition.Z;
            result.M44 = 1f;
        }

        public static Matrix CreateTranslation(Vector3 position)
        {
            Matrix matrix;
            matrix.M11 = 1f;
            matrix.M12 = 0f;
            matrix.M13 = 0f;
            matrix.M14 = 0f;
            matrix.M21 = 0f;
            matrix.M22 = 1f;
            matrix.M23 = 0f;
            matrix.M24 = 0f;
            matrix.M31 = 0f;
            matrix.M32 = 0f;
            matrix.M33 = 1f;
            matrix.M34 = 0f;
            matrix.M41 = position.X;
            matrix.M42 = position.Y;
            matrix.M43 = position.Z;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateTranslation(ref Vector3 position, out Matrix result)
        {
            result.M11 = 1f;
            result.M12 = 0f;
            result.M13 = 0f;
            result.M14 = 0f;
            result.M21 = 0f;
            result.M22 = 1f;
            result.M23 = 0f;
            result.M24 = 0f;
            result.M31 = 0f;
            result.M32 = 0f;
            result.M33 = 1f;
            result.M34 = 0f;
            result.M41 = position.X;
            result.M42 = position.Y;
            result.M43 = position.Z;
            result.M44 = 1f;
        }

        public static Matrix CreateTranslation(float xPosition, float yPosition, float zPosition)
        {
            Matrix matrix;
            matrix.M11 = 1f;
            matrix.M12 = 0f;
            matrix.M13 = 0f;
            matrix.M14 = 0f;
            matrix.M21 = 0f;
            matrix.M22 = 1f;
            matrix.M23 = 0f;
            matrix.M24 = 0f;
            matrix.M31 = 0f;
            matrix.M32 = 0f;
            matrix.M33 = 1f;
            matrix.M34 = 0f;
            matrix.M41 = xPosition;
            matrix.M42 = yPosition;
            matrix.M43 = zPosition;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateTranslation(float xPosition, float yPosition, float zPosition, out Matrix result)
        {
            result.M11 = 1f;
            result.M12 = 0f;
            result.M13 = 0f;
            result.M14 = 0f;
            result.M21 = 0f;
            result.M22 = 1f;
            result.M23 = 0f;
            result.M24 = 0f;
            result.M31 = 0f;
            result.M32 = 0f;
            result.M33 = 1f;
            result.M34 = 0f;
            result.M41 = xPosition;
            result.M42 = yPosition;
            result.M43 = zPosition;
            result.M44 = 1f;
        }

        public static Matrix CreateScale(float xScale, float yScale, float zScale)
        {
            Matrix matrix;
            float num = xScale;
            float num2 = yScale;
            float num3 = zScale;
            matrix.M11 = num;
            matrix.M12 = 0f;
            matrix.M13 = 0f;
            matrix.M14 = 0f;
            matrix.M21 = 0f;
            matrix.M22 = num2;
            matrix.M23 = 0f;
            matrix.M24 = 0f;
            matrix.M31 = 0f;
            matrix.M32 = 0f;
            matrix.M33 = num3;
            matrix.M34 = 0f;
            matrix.M41 = 0f;
            matrix.M42 = 0f;
            matrix.M43 = 0f;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateScale(float xScale, float yScale, float zScale, out Matrix result)
        {
            float num = xScale;
            float num2 = yScale;
            float num3 = zScale;
            result.M11 = num;
            result.M12 = 0f;
            result.M13 = 0f;
            result.M14 = 0f;
            result.M21 = 0f;
            result.M22 = num2;
            result.M23 = 0f;
            result.M24 = 0f;
            result.M31 = 0f;
            result.M32 = 0f;
            result.M33 = num3;
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreateScale(Vector3 scales)
        {
            Matrix matrix;
            float x = scales.X;
            float y = scales.Y;
            float z = scales.Z;
            matrix.M11 = x;
            matrix.M12 = 0f;
            matrix.M13 = 0f;
            matrix.M14 = 0f;
            matrix.M21 = 0f;
            matrix.M22 = y;
            matrix.M23 = 0f;
            matrix.M24 = 0f;
            matrix.M31 = 0f;
            matrix.M32 = 0f;
            matrix.M33 = z;
            matrix.M34 = 0f;
            matrix.M41 = 0f;
            matrix.M42 = 0f;
            matrix.M43 = 0f;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateScale(ref Vector3 scales, out Matrix result)
        {
            float x = scales.X;
            float y = scales.Y;
            float z = scales.Z;
            result.M11 = x;
            result.M12 = 0f;
            result.M13 = 0f;
            result.M14 = 0f;
            result.M21 = 0f;
            result.M22 = y;
            result.M23 = 0f;
            result.M24 = 0f;
            result.M31 = 0f;
            result.M32 = 0f;
            result.M33 = z;
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreateScale(float scale)
        {
            Matrix matrix;
            float num = scale;
            matrix.M11 = num;
            matrix.M12 = 0f;
            matrix.M13 = 0f;
            matrix.M14 = 0f;
            matrix.M21 = 0f;
            matrix.M22 = num;
            matrix.M23 = 0f;
            matrix.M24 = 0f;
            matrix.M31 = 0f;
            matrix.M32 = 0f;
            matrix.M33 = num;
            matrix.M34 = 0f;
            matrix.M41 = 0f;
            matrix.M42 = 0f;
            matrix.M43 = 0f;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateScale(float scale, out Matrix result)
        {
            float num = scale;
            result.M11 = num;
            result.M12 = 0f;
            result.M13 = 0f;
            result.M14 = 0f;
            result.M21 = 0f;
            result.M22 = num;
            result.M23 = 0f;
            result.M24 = 0f;
            result.M31 = 0f;
            result.M32 = 0f;
            result.M33 = num;
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreateRotationX(float radians)
        {
            Matrix matrix;
            float num = (float)Math.Cos((double)radians);
            float num2 = (float)Math.Sin((double)radians);
            matrix.M11 = 1f;
            matrix.M12 = 0f;
            matrix.M13 = 0f;
            matrix.M14 = 0f;
            matrix.M21 = 0f;
            matrix.M22 = num;
            matrix.M23 = num2;
            matrix.M24 = 0f;
            matrix.M31 = 0f;
            matrix.M32 = -num2;
            matrix.M33 = num;
            matrix.M34 = 0f;
            matrix.M41 = 0f;
            matrix.M42 = 0f;
            matrix.M43 = 0f;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateRotationX(float radians, out Matrix result)
        {
            float num = (float)Math.Cos((double)radians);
            float num2 = (float)Math.Sin((double)radians);
            result.M11 = 1f;
            result.M12 = 0f;
            result.M13 = 0f;
            result.M14 = 0f;
            result.M21 = 0f;
            result.M22 = num;
            result.M23 = num2;
            result.M24 = 0f;
            result.M31 = 0f;
            result.M32 = -num2;
            result.M33 = num;
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreateRotationY(float radians)
        {
            Matrix matrix;
            float num = (float)Math.Cos((double)radians);
            float num2 = (float)Math.Sin((double)radians);
            matrix.M11 = num;
            matrix.M12 = 0f;
            matrix.M13 = -num2;
            matrix.M14 = 0f;
            matrix.M21 = 0f;
            matrix.M22 = 1f;
            matrix.M23 = 0f;
            matrix.M24 = 0f;
            matrix.M31 = num2;
            matrix.M32 = 0f;
            matrix.M33 = num;
            matrix.M34 = 0f;
            matrix.M41 = 0f;
            matrix.M42 = 0f;
            matrix.M43 = 0f;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateRotationY(float radians, out Matrix result)
        {
            float num = (float)Math.Cos((double)radians);
            float num2 = (float)Math.Sin((double)radians);
            result.M11 = num;
            result.M12 = 0f;
            result.M13 = -num2;
            result.M14 = 0f;
            result.M21 = 0f;
            result.M22 = 1f;
            result.M23 = 0f;
            result.M24 = 0f;
            result.M31 = num2;
            result.M32 = 0f;
            result.M33 = num;
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreateRotationZ(float radians)
        {
            Matrix matrix;
            float num = (float)Math.Cos((double)radians);
            float num2 = (float)Math.Sin((double)radians);
            matrix.M11 = num;
            matrix.M12 = num2;
            matrix.M13 = 0f;
            matrix.M14 = 0f;
            matrix.M21 = -num2;
            matrix.M22 = num;
            matrix.M23 = 0f;
            matrix.M24 = 0f;
            matrix.M31 = 0f;
            matrix.M32 = 0f;
            matrix.M33 = 1f;
            matrix.M34 = 0f;
            matrix.M41 = 0f;
            matrix.M42 = 0f;
            matrix.M43 = 0f;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateRotationZ(float radians, out Matrix result)
        {
            float num = (float)Math.Cos((double)radians);
            float num2 = (float)Math.Sin((double)radians);
            result.M11 = num;
            result.M12 = num2;
            result.M13 = 0f;
            result.M14 = 0f;
            result.M21 = -num2;
            result.M22 = num;
            result.M23 = 0f;
            result.M24 = 0f;
            result.M31 = 0f;
            result.M32 = 0f;
            result.M33 = 1f;
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreateFromAxisAngle(Vector3 axis, float angle)
        {
            Matrix matrix;
            float x = axis.X;
            float y = axis.Y;
            float z = axis.Z;
            float num4 = (float)Math.Sin((double)angle);
            float num5 = (float)Math.Cos((double)angle);
            float num6 = x * x;
            float num7 = y * y;
            float num8 = z * z;
            float num9 = x * y;
            float num10 = x * z;
            float num11 = y * z;
            matrix.M11 = num6 + (num5 * (1f - num6));
            matrix.M12 = (num9 - (num5 * num9)) + (num4 * z);
            matrix.M13 = (num10 - (num5 * num10)) - (num4 * y);
            matrix.M14 = 0f;
            matrix.M21 = (num9 - (num5 * num9)) - (num4 * z);
            matrix.M22 = num7 + (num5 * (1f - num7));
            matrix.M23 = (num11 - (num5 * num11)) + (num4 * x);
            matrix.M24 = 0f;
            matrix.M31 = (num10 - (num5 * num10)) + (num4 * y);
            matrix.M32 = (num11 - (num5 * num11)) - (num4 * x);
            matrix.M33 = num8 + (num5 * (1f - num8));
            matrix.M34 = 0f;
            matrix.M41 = 0f;
            matrix.M42 = 0f;
            matrix.M43 = 0f;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Matrix result)
        {
            float x = axis.X;
            float y = axis.Y;
            float z = axis.Z;
            float num4 = (float)Math.Sin((double)angle);
            float num5 = (float)Math.Cos((double)angle);
            float num6 = x * x;
            float num7 = y * y;
            float num8 = z * z;
            float num9 = x * y;
            float num10 = x * z;
            float num11 = y * z;
            result.M11 = num6 + (num5 * (1f - num6));
            result.M12 = (num9 - (num5 * num9)) + (num4 * z);
            result.M13 = (num10 - (num5 * num10)) - (num4 * y);
            result.M14 = 0f;
            result.M21 = (num9 - (num5 * num9)) - (num4 * z);
            result.M22 = num7 + (num5 * (1f - num7));
            result.M23 = (num11 - (num5 * num11)) + (num4 * x);
            result.M24 = 0f;
            result.M31 = (num10 - (num5 * num10)) + (num4 * y);
            result.M32 = (num11 - (num5 * num11)) - (num4 * x);
            result.M33 = num8 + (num5 * (1f - num8));
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
        {
            Matrix matrix;
            if ((fieldOfView <= 0f) || (fieldOfView >= 3.141593f))
            {
                throw new ArgumentOutOfRangeException("fieldOfView", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.OutRangeFieldOfView", new object[] { "fieldOfView" }));
            }
            if (nearPlaneDistance <= 0f)
            {
                throw new ArgumentOutOfRangeException("nearPlaneDistance", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.NegativePlaneDistance", new object[] { "nearPlaneDistance" }));
            }
            if (farPlaneDistance <= 0f)
            {
                throw new ArgumentOutOfRangeException("farPlaneDistance", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.NegativePlaneDistance", new object[] { "farPlaneDistance" }));
            }
            if (nearPlaneDistance >= farPlaneDistance)
            {
                throw new ArgumentOutOfRangeException("nearPlaneDistance", "FrameworkResources.OppositePlanes");
            }
            float num = 1f / ((float)Math.Tan((double)(fieldOfView * 0.5f)));
            float num2 = num / aspectRatio;
            matrix.M11 = num2;
            matrix.M12 = matrix.M13 = matrix.M14 = 0f;
            matrix.M22 = num;
            matrix.M21 = matrix.M23 = matrix.M24 = 0f;
            matrix.M31 = matrix.M32 = 0f;
            matrix.M33 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            matrix.M34 = -1f;
            matrix.M41 = matrix.M42 = matrix.M44 = 0f;
            matrix.M43 = (nearPlaneDistance * farPlaneDistance) / (nearPlaneDistance - farPlaneDistance);
            return matrix;
        }

        public static void CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
        {
            if ((fieldOfView <= 0f) || (fieldOfView >= 3.141593f))
            {
                throw new ArgumentOutOfRangeException("fieldOfView", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.OutRangeFieldOfView", new object[] { "fieldOfView" }));
            }
            if (nearPlaneDistance <= 0f)
            {
                throw new ArgumentOutOfRangeException("nearPlaneDistance", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.NegativePlaneDistance", new object[] { "nearPlaneDistance" }));
            }
            if (farPlaneDistance <= 0f)
            {
                throw new ArgumentOutOfRangeException("farPlaneDistance", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.NegativePlaneDistance", new object[] { "farPlaneDistance" }));
            }
            if (nearPlaneDistance >= farPlaneDistance)
            {
                throw new ArgumentOutOfRangeException("nearPlaneDistance", "FrameworkResources.OppositePlanes");
            }
            float num = 1f / ((float)Math.Tan((double)(fieldOfView * 0.5f)));
            float num2 = num / aspectRatio;
            result.M11 = num2;
            result.M12 = result.M13 = result.M14 = 0f;
            result.M22 = num;
            result.M21 = result.M23 = result.M24 = 0f;
            result.M31 = result.M32 = 0f;
            result.M33 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result.M34 = -1f;
            result.M41 = result.M42 = result.M44 = 0f;
            result.M43 = (nearPlaneDistance * farPlaneDistance) / (nearPlaneDistance - farPlaneDistance);
        }

        public static Matrix CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance)
        {
            Matrix matrix;
            if (nearPlaneDistance <= 0f)
            {
                throw new ArgumentOutOfRangeException("nearPlaneDistance", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.NegativePlaneDistance", new object[] { "nearPlaneDistance" }));
            }
            if (farPlaneDistance <= 0f)
            {
                throw new ArgumentOutOfRangeException("farPlaneDistance", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.NegativePlaneDistance", new object[] { "farPlaneDistance" }));
            }
            if (nearPlaneDistance >= farPlaneDistance)
            {
                throw new ArgumentOutOfRangeException("nearPlaneDistance", "FrameworkResources.OppositePlanes");
            }
            matrix.M11 = (2f * nearPlaneDistance) / width;
            matrix.M12 = matrix.M13 = matrix.M14 = 0f;
            matrix.M22 = (2f * nearPlaneDistance) / height;
            matrix.M21 = matrix.M23 = matrix.M24 = 0f;
            matrix.M33 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            matrix.M31 = matrix.M32 = 0f;
            matrix.M34 = -1f;
            matrix.M41 = matrix.M42 = matrix.M44 = 0f;
            matrix.M43 = (nearPlaneDistance * farPlaneDistance) / (nearPlaneDistance - farPlaneDistance);
            return matrix;
        }

        public static void CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
        {
            if (nearPlaneDistance <= 0f)
            {
                throw new ArgumentOutOfRangeException("nearPlaneDistance", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.NegativePlaneDistance", new object[] { "nearPlaneDistance" }));
            }
            if (farPlaneDistance <= 0f)
            {
                throw new ArgumentOutOfRangeException("farPlaneDistance", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.NegativePlaneDistance", new object[] { "farPlaneDistance" }));
            }
            if (nearPlaneDistance >= farPlaneDistance)
            {
                throw new ArgumentOutOfRangeException("nearPlaneDistance", "FrameworkResources.OppositePlanes");
            }
            result.M11 = (2f * nearPlaneDistance) / width;
            result.M12 = result.M13 = result.M14 = 0f;
            result.M22 = (2f * nearPlaneDistance) / height;
            result.M21 = result.M23 = result.M24 = 0f;
            result.M33 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result.M31 = result.M32 = 0f;
            result.M34 = -1f;
            result.M41 = result.M42 = result.M44 = 0f;
            result.M43 = (nearPlaneDistance * farPlaneDistance) / (nearPlaneDistance - farPlaneDistance);
        }

        public static Matrix CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance)
        {
            Matrix matrix;
            if (nearPlaneDistance <= 0f)
            {
                throw new ArgumentOutOfRangeException("nearPlaneDistance", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.NegativePlaneDistance", new object[] { "nearPlaneDistance" }));
            }
            if (farPlaneDistance <= 0f)
            {
                throw new ArgumentOutOfRangeException("farPlaneDistance", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.NegativePlaneDistance", new object[] { "farPlaneDistance" }));
            }
            if (nearPlaneDistance >= farPlaneDistance)
            {
                throw new ArgumentOutOfRangeException("nearPlaneDistance", "FrameworkResources.OppositePlanes");
            }
            matrix.M11 = (2f * nearPlaneDistance) / (right - left);
            matrix.M12 = matrix.M13 = matrix.M14 = 0f;
            matrix.M22 = (2f * nearPlaneDistance) / (top - bottom);
            matrix.M21 = matrix.M23 = matrix.M24 = 0f;
            matrix.M31 = (left + right) / (right - left);
            matrix.M32 = (top + bottom) / (top - bottom);
            matrix.M33 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            matrix.M34 = -1f;
            matrix.M43 = (nearPlaneDistance * farPlaneDistance) / (nearPlaneDistance - farPlaneDistance);
            matrix.M41 = matrix.M42 = matrix.M44 = 0f;
            return matrix;
        }

        public static void CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
        {
            if (nearPlaneDistance <= 0f)
            {
                throw new ArgumentOutOfRangeException("nearPlaneDistance", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.NegativePlaneDistance", new object[] { "nearPlaneDistance" }));
            }
            if (farPlaneDistance <= 0f)
            {
                throw new ArgumentOutOfRangeException("farPlaneDistance", string.Format(CultureInfo.CurrentCulture, "FrameworkResources.NegativePlaneDistance", new object[] { "farPlaneDistance" }));
            }
            if (nearPlaneDistance >= farPlaneDistance)
            {
                throw new ArgumentOutOfRangeException("nearPlaneDistance", "FrameworkResources.OppositePlanes");
            }
            result.M11 = (2f * nearPlaneDistance) / (right - left);
            result.M12 = result.M13 = result.M14 = 0f;
            result.M22 = (2f * nearPlaneDistance) / (top - bottom);
            result.M21 = result.M23 = result.M24 = 0f;
            result.M31 = (left + right) / (right - left);
            result.M32 = (top + bottom) / (top - bottom);
            result.M33 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result.M34 = -1f;
            result.M43 = (nearPlaneDistance * farPlaneDistance) / (nearPlaneDistance - farPlaneDistance);
            result.M41 = result.M42 = result.M44 = 0f;
        }

        public static Matrix CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane)
        {
            Matrix matrix;
            matrix.M11 = 2f / width;
            matrix.M12 = matrix.M13 = matrix.M14 = 0f;
            matrix.M22 = 2f / height;
            matrix.M21 = matrix.M23 = matrix.M24 = 0f;
            matrix.M33 = 1f / (zNearPlane - zFarPlane);
            matrix.M31 = matrix.M32 = matrix.M34 = 0f;
            matrix.M41 = matrix.M42 = 0f;
            matrix.M43 = zNearPlane / (zNearPlane - zFarPlane);
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane, out Matrix result)
        {
            result.M11 = 2f / width;
            result.M12 = result.M13 = result.M14 = 0f;
            result.M22 = 2f / height;
            result.M21 = result.M23 = result.M24 = 0f;
            result.M33 = 1f / (zNearPlane - zFarPlane);
            result.M31 = result.M32 = result.M34 = 0f;
            result.M41 = result.M42 = 0f;
            result.M43 = zNearPlane / (zNearPlane - zFarPlane);
            result.M44 = 1f;
        }

        public static Matrix CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
        {
            Matrix matrix;
            matrix.M11 = 2f / (right - left);
            matrix.M12 = matrix.M13 = matrix.M14 = 0f;
            matrix.M22 = 2f / (top - bottom);
            matrix.M21 = matrix.M23 = matrix.M24 = 0f;
            matrix.M33 = 1f / (zNearPlane - zFarPlane);
            matrix.M31 = matrix.M32 = matrix.M34 = 0f;
            matrix.M41 = (left + right) / (left - right);
            matrix.M42 = (top + bottom) / (bottom - top);
            matrix.M43 = zNearPlane / (zNearPlane - zFarPlane);
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane, out Matrix result)
        {
            result.M11 = 2f / (right - left);
            result.M12 = result.M13 = result.M14 = 0f;
            result.M22 = 2f / (top - bottom);
            result.M21 = result.M23 = result.M24 = 0f;
            result.M33 = 1f / (zNearPlane - zFarPlane);
            result.M31 = result.M32 = result.M34 = 0f;
            result.M41 = (left + right) / (left - right);
            result.M42 = (top + bottom) / (bottom - top);
            result.M43 = zNearPlane / (zNearPlane - zFarPlane);
            result.M44 = 1f;
        }

        public static Matrix CreateLookAt(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector)
        {
            Matrix matrix;
            Vector3 vector = Vector3.Normalize(cameraPosition - cameraTarget);
            Vector3 vector2 = Vector3.Normalize(Vector3.Cross(cameraUpVector, vector));
            Vector3 vector3 = Vector3.Cross(vector, vector2);
            matrix.M11 = vector2.X;
            matrix.M12 = vector3.X;
            matrix.M13 = vector.X;
            matrix.M14 = 0f;
            matrix.M21 = vector2.Y;
            matrix.M22 = vector3.Y;
            matrix.M23 = vector.Y;
            matrix.M24 = 0f;
            matrix.M31 = vector2.Z;
            matrix.M32 = vector3.Z;
            matrix.M33 = vector.Z;
            matrix.M34 = 0f;
            matrix.M41 = -Vector3.Dot(vector2, cameraPosition);
            matrix.M42 = -Vector3.Dot(vector3, cameraPosition);
            matrix.M43 = -Vector3.Dot(vector, cameraPosition);
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateLookAt(ref Vector3 cameraPosition, ref Vector3 cameraTarget, ref Vector3 cameraUpVector, out Matrix result)
        {
            Vector3 vector = Vector3.Normalize(cameraPosition - cameraTarget);
            Vector3 vector2 = Vector3.Normalize(Vector3.Cross(cameraUpVector, vector));
            Vector3 vector3 = Vector3.Cross(vector, vector2);
            result.M11 = vector2.X;
            result.M12 = vector3.X;
            result.M13 = vector.X;
            result.M14 = 0f;
            result.M21 = vector2.Y;
            result.M22 = vector3.Y;
            result.M23 = vector.Y;
            result.M24 = 0f;
            result.M31 = vector2.Z;
            result.M32 = vector3.Z;
            result.M33 = vector.Z;
            result.M34 = 0f;
            result.M41 = -Vector3.Dot(vector2, cameraPosition);
            result.M42 = -Vector3.Dot(vector3, cameraPosition);
            result.M43 = -Vector3.Dot(vector, cameraPosition);
            result.M44 = 1f;
        }

        public static Matrix CreateWorld(Vector3 position, Vector3 forward, Vector3 up)
        {
            Matrix matrix;
            Vector3 vector = Vector3.Normalize(-forward);
            Vector3 vector2 = Vector3.Normalize(Vector3.Cross(up, vector));
            Vector3 vector3 = Vector3.Cross(vector, vector2);
            matrix.M11 = vector2.X;
            matrix.M12 = vector2.Y;
            matrix.M13 = vector2.Z;
            matrix.M14 = 0f;
            matrix.M21 = vector3.X;
            matrix.M22 = vector3.Y;
            matrix.M23 = vector3.Z;
            matrix.M24 = 0f;
            matrix.M31 = vector.X;
            matrix.M32 = vector.Y;
            matrix.M33 = vector.Z;
            matrix.M34 = 0f;
            matrix.M41 = position.X;
            matrix.M42 = position.Y;
            matrix.M43 = position.Z;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateWorld(ref Vector3 position, ref Vector3 forward, ref Vector3 up, out Matrix result)
        {
            Vector3 vector = Vector3.Normalize(-forward);
            Vector3 vector2 = Vector3.Normalize(Vector3.Cross(up, vector));
            Vector3 vector3 = Vector3.Cross(vector, vector2);
            result.M11 = vector2.X;
            result.M12 = vector2.Y;
            result.M13 = vector2.Z;
            result.M14 = 0f;
            result.M21 = vector3.X;
            result.M22 = vector3.Y;
            result.M23 = vector3.Z;
            result.M24 = 0f;
            result.M31 = vector.X;
            result.M32 = vector.Y;
            result.M33 = vector.Z;
            result.M34 = 0f;
            result.M41 = position.X;
            result.M42 = position.Y;
            result.M43 = position.Z;
            result.M44 = 1f;
        }

        public static Matrix CreateFromQuaternion(Quaternion quaternion)
        {
            Matrix matrix;
            float num = quaternion.X * quaternion.X;
            float num2 = quaternion.Y * quaternion.Y;
            float num3 = quaternion.Z * quaternion.Z;
            float num4 = quaternion.X * quaternion.Y;
            float num5 = quaternion.Z * quaternion.W;
            float num6 = quaternion.Z * quaternion.X;
            float num7 = quaternion.Y * quaternion.W;
            float num8 = quaternion.Y * quaternion.Z;
            float num9 = quaternion.X * quaternion.W;
            matrix.M11 = 1f - (2f * (num2 + num3));
            matrix.M12 = 2f * (num4 + num5);
            matrix.M13 = 2f * (num6 - num7);
            matrix.M14 = 0f;
            matrix.M21 = 2f * (num4 - num5);
            matrix.M22 = 1f - (2f * (num3 + num));
            matrix.M23 = 2f * (num8 + num9);
            matrix.M24 = 0f;
            matrix.M31 = 2f * (num6 + num7);
            matrix.M32 = 2f * (num8 - num9);
            matrix.M33 = 1f - (2f * (num2 + num));
            matrix.M34 = 0f;
            matrix.M41 = 0f;
            matrix.M42 = 0f;
            matrix.M43 = 0f;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateFromQuaternion(ref Quaternion quaternion, out Matrix result)
        {
            float num = quaternion.X * quaternion.X;
            float num2 = quaternion.Y * quaternion.Y;
            float num3 = quaternion.Z * quaternion.Z;
            float num4 = quaternion.X * quaternion.Y;
            float num5 = quaternion.Z * quaternion.W;
            float num6 = quaternion.Z * quaternion.X;
            float num7 = quaternion.Y * quaternion.W;
            float num8 = quaternion.Y * quaternion.Z;
            float num9 = quaternion.X * quaternion.W;
            result.M11 = 1f - (2f * (num2 + num3));
            result.M12 = 2f * (num4 + num5);
            result.M13 = 2f * (num6 - num7);
            result.M14 = 0f;
            result.M21 = 2f * (num4 - num5);
            result.M22 = 1f - (2f * (num3 + num));
            result.M23 = 2f * (num8 + num9);
            result.M24 = 0f;
            result.M31 = 2f * (num6 + num7);
            result.M32 = 2f * (num8 - num9);
            result.M33 = 1f - (2f * (num2 + num));
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreateFromYawPitchRoll(float yaw, float pitch, float roll)
        {
            Quaternion quaternion;
            Matrix matrix;
            Quaternion.CreateFromYawPitchRoll(yaw, pitch, roll, out quaternion);
            CreateFromQuaternion(ref quaternion, out matrix);
            return matrix;
        }

        public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Matrix result)
        {
            Quaternion quaternion;
            Quaternion.CreateFromYawPitchRoll(yaw, pitch, roll, out quaternion);
            CreateFromQuaternion(ref quaternion, out result);
        }

        public static Matrix CreateShadow(Vector3 lightDirection, Plane plane)
        {
            Plane plane2;
            Matrix matrix;
            Plane.Normalize(ref plane, out plane2);
            float num = ((plane2.Normal.X * lightDirection.X) + (plane2.Normal.Y * lightDirection.Y)) + (plane2.Normal.Z * lightDirection.Z);
            float num2 = -plane2.Normal.X;
            float num3 = -plane2.Normal.Y;
            float num4 = -plane2.Normal.Z;
            float num5 = -plane2.D;
            matrix.M11 = (num2 * lightDirection.X) + num;
            matrix.M21 = num3 * lightDirection.X;
            matrix.M31 = num4 * lightDirection.X;
            matrix.M41 = num5 * lightDirection.X;
            matrix.M12 = num2 * lightDirection.Y;
            matrix.M22 = (num3 * lightDirection.Y) + num;
            matrix.M32 = num4 * lightDirection.Y;
            matrix.M42 = num5 * lightDirection.Y;
            matrix.M13 = num2 * lightDirection.Z;
            matrix.M23 = num3 * lightDirection.Z;
            matrix.M33 = (num4 * lightDirection.Z) + num;
            matrix.M43 = num5 * lightDirection.Z;
            matrix.M14 = 0f;
            matrix.M24 = 0f;
            matrix.M34 = 0f;
            matrix.M44 = num;
            return matrix;
        }

        public static void CreateShadow(ref Vector3 lightDirection, ref Plane plane, out Matrix result)
        {
            Plane plane2;
            Plane.Normalize(ref plane, out plane2);
            float num = ((plane2.Normal.X * lightDirection.X) + (plane2.Normal.Y * lightDirection.Y)) + (plane2.Normal.Z * lightDirection.Z);
            float num2 = -plane2.Normal.X;
            float num3 = -plane2.Normal.Y;
            float num4 = -plane2.Normal.Z;
            float num5 = -plane2.D;
            result.M11 = (num2 * lightDirection.X) + num;
            result.M21 = num3 * lightDirection.X;
            result.M31 = num4 * lightDirection.X;
            result.M41 = num5 * lightDirection.X;
            result.M12 = num2 * lightDirection.Y;
            result.M22 = (num3 * lightDirection.Y) + num;
            result.M32 = num4 * lightDirection.Y;
            result.M42 = num5 * lightDirection.Y;
            result.M13 = num2 * lightDirection.Z;
            result.M23 = num3 * lightDirection.Z;
            result.M33 = (num4 * lightDirection.Z) + num;
            result.M43 = num5 * lightDirection.Z;
            result.M14 = 0f;
            result.M24 = 0f;
            result.M34 = 0f;
            result.M44 = num;
        }

        public static Matrix CreateReflection(Plane value)
        {
            Matrix matrix;
            value.Normalize();
            float x = value.Normal.X;
            float y = value.Normal.Y;
            float z = value.Normal.Z;
            float num4 = -2f * x;
            float num5 = -2f * y;
            float num6 = -2f * z;
            matrix.M11 = (num4 * x) + 1f;
            matrix.M12 = num5 * x;
            matrix.M13 = num6 * x;
            matrix.M14 = 0f;
            matrix.M21 = num4 * y;
            matrix.M22 = (num5 * y) + 1f;
            matrix.M23 = num6 * y;
            matrix.M24 = 0f;
            matrix.M31 = num4 * z;
            matrix.M32 = num5 * z;
            matrix.M33 = (num6 * z) + 1f;
            matrix.M34 = 0f;
            matrix.M41 = num4 * value.D;
            matrix.M42 = num5 * value.D;
            matrix.M43 = num6 * value.D;
            matrix.M44 = 1f;
            return matrix;
        }

        public static void CreateReflection(ref Plane value, out Matrix result)
        {
            Plane plane;
            Plane.Normalize(ref value, out plane);
            value.Normalize();
            float x = plane.Normal.X;
            float y = plane.Normal.Y;
            float z = plane.Normal.Z;
            float num4 = -2f * x;
            float num5 = -2f * y;
            float num6 = -2f * z;
            result.M11 = (num4 * x) + 1f;
            result.M12 = num5 * x;
            result.M13 = num6 * x;
            result.M14 = 0f;
            result.M21 = num4 * y;
            result.M22 = (num5 * y) + 1f;
            result.M23 = num6 * y;
            result.M24 = 0f;
            result.M31 = num4 * z;
            result.M32 = num5 * z;
            result.M33 = (num6 * z) + 1f;
            result.M34 = 0f;
            result.M41 = num4 * plane.D;
            result.M42 = num5 * plane.D;
            result.M43 = num6 * plane.D;
            result.M44 = 1f;
        }

        public static Matrix Transform(Matrix value, Quaternion rotation)
        {
            Matrix matrix;
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
            matrix.M11 = ((value.M11 * num13) + (value.M12 * num14)) + (value.M13 * num15);
            matrix.M12 = ((value.M11 * num16) + (value.M12 * num17)) + (value.M13 * num18);
            matrix.M13 = ((value.M11 * num19) + (value.M12 * num20)) + (value.M13 * num21);
            matrix.M14 = value.M14;
            matrix.M21 = ((value.M21 * num13) + (value.M22 * num14)) + (value.M23 * num15);
            matrix.M22 = ((value.M21 * num16) + (value.M22 * num17)) + (value.M23 * num18);
            matrix.M23 = ((value.M21 * num19) + (value.M22 * num20)) + (value.M23 * num21);
            matrix.M24 = value.M24;
            matrix.M31 = ((value.M31 * num13) + (value.M32 * num14)) + (value.M33 * num15);
            matrix.M32 = ((value.M31 * num16) + (value.M32 * num17)) + (value.M33 * num18);
            matrix.M33 = ((value.M31 * num19) + (value.M32 * num20)) + (value.M33 * num21);
            matrix.M34 = value.M34;
            matrix.M41 = ((value.M41 * num13) + (value.M42 * num14)) + (value.M43 * num15);
            matrix.M42 = ((value.M41 * num16) + (value.M42 * num17)) + (value.M43 * num18);
            matrix.M43 = ((value.M41 * num19) + (value.M42 * num20)) + (value.M43 * num21);
            matrix.M44 = value.M44;
            return matrix;
        }

        public static void Transform(ref Matrix value, ref Quaternion rotation, out Matrix result)
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
            float num13 = (1f - num10) - num12;
            float num14 = num8 - num6;
            float num15 = num9 + num5;
            float num16 = num8 + num6;
            float num17 = (1f - num7) - num12;
            float num18 = num11 - num4;
            float num19 = num9 - num5;
            float num20 = num11 + num4;
            float num21 = (1f - num7) - num10;
            float num22 = ((value.M11 * num13) + (value.M12 * num14)) + (value.M13 * num15);
            float num23 = ((value.M11 * num16) + (value.M12 * num17)) + (value.M13 * num18);
            float num24 = ((value.M11 * num19) + (value.M12 * num20)) + (value.M13 * num21);
            float num25 = value.M14;
            float num26 = ((value.M21 * num13) + (value.M22 * num14)) + (value.M23 * num15);
            float num27 = ((value.M21 * num16) + (value.M22 * num17)) + (value.M23 * num18);
            float num28 = ((value.M21 * num19) + (value.M22 * num20)) + (value.M23 * num21);
            float num29 = value.M24;
            float num30 = ((value.M31 * num13) + (value.M32 * num14)) + (value.M33 * num15);
            float num31 = ((value.M31 * num16) + (value.M32 * num17)) + (value.M33 * num18);
            float num32 = ((value.M31 * num19) + (value.M32 * num20)) + (value.M33 * num21);
            float num33 = value.M34;
            float num34 = ((value.M41 * num13) + (value.M42 * num14)) + (value.M43 * num15);
            float num35 = ((value.M41 * num16) + (value.M42 * num17)) + (value.M43 * num18);
            float num36 = ((value.M41 * num19) + (value.M42 * num20)) + (value.M43 * num21);
            float num37 = value.M44;
            result.M11 = num22;
            result.M12 = num23;
            result.M13 = num24;
            result.M14 = num25;
            result.M21 = num26;
            result.M22 = num27;
            result.M23 = num28;
            result.M24 = num29;
            result.M31 = num30;
            result.M32 = num31;
            result.M33 = num32;
            result.M34 = num33;
            result.M41 = num34;
            result.M42 = num35;
            result.M43 = num36;
            result.M44 = num37;
        }

        public override string ToString()
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            return ("{ " + string.Format(currentCulture, "{{M11:{0} M12:{1} M13:{2} M14:{3}}} ", new object[] { this.M11.ToString(currentCulture), this.M12.ToString(currentCulture), this.M13.ToString(currentCulture), this.M14.ToString(currentCulture) }) + string.Format(currentCulture, "{{M21:{0} M22:{1} M23:{2} M24:{3}}} ", new object[] { this.M21.ToString(currentCulture), this.M22.ToString(currentCulture), this.M23.ToString(currentCulture), this.M24.ToString(currentCulture) }) + string.Format(currentCulture, "{{M31:{0} M32:{1} M33:{2} M34:{3}}} ", new object[] { this.M31.ToString(currentCulture), this.M32.ToString(currentCulture), this.M33.ToString(currentCulture), this.M34.ToString(currentCulture) }) + string.Format(currentCulture, "{{M41:{0} M42:{1} M43:{2} M44:{3}}} ", new object[] { this.M41.ToString(currentCulture), this.M42.ToString(currentCulture), this.M43.ToString(currentCulture), this.M44.ToString(currentCulture) }) + "}");
        }

        public bool Equals(Matrix other)
        {
            return ((((((this.M11 == other.M11) && (this.M22 == other.M22)) && ((this.M33 == other.M33) && (this.M44 == other.M44))) && (((this.M12 == other.M12) && (this.M13 == other.M13)) && ((this.M14 == other.M14) && (this.M21 == other.M21)))) && ((((this.M23 == other.M23) && (this.M24 == other.M24)) && ((this.M31 == other.M31) && (this.M32 == other.M32))) && (((this.M34 == other.M34) && (this.M41 == other.M41)) && (this.M42 == other.M42)))) && (this.M43 == other.M43));
        }

        public override bool Equals(object obj)
        {
            bool flag = false;
            if (obj is Matrix)
            {
                flag = this.Equals((Matrix)obj);
            }
            return flag;
        }

        public override int GetHashCode()
        {
            return (((((((((((((((this.M11.GetHashCode() + this.M12.GetHashCode()) + this.M13.GetHashCode()) + this.M14.GetHashCode()) + this.M21.GetHashCode()) + this.M22.GetHashCode()) + this.M23.GetHashCode()) + this.M24.GetHashCode()) + this.M31.GetHashCode()) + this.M32.GetHashCode()) + this.M33.GetHashCode()) + this.M34.GetHashCode()) + this.M41.GetHashCode()) + this.M42.GetHashCode()) + this.M43.GetHashCode()) + this.M44.GetHashCode());
        }

        public static Matrix Transpose(Matrix matrix)
        {
            Matrix matrix2;
            matrix2.M11 = matrix.M11;
            matrix2.M12 = matrix.M21;
            matrix2.M13 = matrix.M31;
            matrix2.M14 = matrix.M41;
            matrix2.M21 = matrix.M12;
            matrix2.M22 = matrix.M22;
            matrix2.M23 = matrix.M32;
            matrix2.M24 = matrix.M42;
            matrix2.M31 = matrix.M13;
            matrix2.M32 = matrix.M23;
            matrix2.M33 = matrix.M33;
            matrix2.M34 = matrix.M43;
            matrix2.M41 = matrix.M14;
            matrix2.M42 = matrix.M24;
            matrix2.M43 = matrix.M34;
            matrix2.M44 = matrix.M44;
            return matrix2;
        }

        public static void Transpose(ref Matrix matrix, out Matrix result)
        {
            float num = matrix.M11;
            float num2 = matrix.M12;
            float num3 = matrix.M13;
            float num4 = matrix.M14;
            float num5 = matrix.M21;
            float num6 = matrix.M22;
            float num7 = matrix.M23;
            float num8 = matrix.M24;
            float num9 = matrix.M31;
            float num10 = matrix.M32;
            float num11 = matrix.M33;
            float num12 = matrix.M34;
            float num13 = matrix.M41;
            float num14 = matrix.M42;
            float num15 = matrix.M43;
            float num16 = matrix.M44;
            result.M11 = num;
            result.M12 = num5;
            result.M13 = num9;
            result.M14 = num13;
            result.M21 = num2;
            result.M22 = num6;
            result.M23 = num10;
            result.M24 = num14;
            result.M31 = num3;
            result.M32 = num7;
            result.M33 = num11;
            result.M34 = num15;
            result.M41 = num4;
            result.M42 = num8;
            result.M43 = num12;
            result.M44 = num16;
        }

        public float Determinant()
        {
            float num = this.M11;
            float num2 = this.M12;
            float num3 = this.M13;
            float num4 = this.M14;
            float num5 = this.M21;
            float num6 = this.M22;
            float num7 = this.M23;
            float num8 = this.M24;
            float num9 = this.M31;
            float num10 = this.M32;
            float num11 = this.M33;
            float num12 = this.M34;
            float num13 = this.M41;
            float num14 = this.M42;
            float num15 = this.M43;
            float num16 = this.M44;
            float num17 = (num11 * num16) - (num12 * num15);
            float num18 = (num10 * num16) - (num12 * num14);
            float num19 = (num10 * num15) - (num11 * num14);
            float num20 = (num9 * num16) - (num12 * num13);
            float num21 = (num9 * num15) - (num11 * num13);
            float num22 = (num9 * num14) - (num10 * num13);
            return ((((num * (((num6 * num17) - (num7 * num18)) + (num8 * num19))) - (num2 * (((num5 * num17) - (num7 * num20)) + (num8 * num21)))) + (num3 * (((num5 * num18) - (num6 * num20)) + (num8 * num22)))) - (num4 * (((num5 * num19) - (num6 * num21)) + (num7 * num22))));
        }

        public static Matrix Invert(Matrix matrix)
        {
            Matrix matrix2;
            float num = matrix.M11;
            float num2 = matrix.M12;
            float num3 = matrix.M13;
            float num4 = matrix.M14;
            float num5 = matrix.M21;
            float num6 = matrix.M22;
            float num7 = matrix.M23;
            float num8 = matrix.M24;
            float num9 = matrix.M31;
            float num10 = matrix.M32;
            float num11 = matrix.M33;
            float num12 = matrix.M34;
            float num13 = matrix.M41;
            float num14 = matrix.M42;
            float num15 = matrix.M43;
            float num16 = matrix.M44;
            float num17 = (num11 * num16) - (num12 * num15);
            float num18 = (num10 * num16) - (num12 * num14);
            float num19 = (num10 * num15) - (num11 * num14);
            float num20 = (num9 * num16) - (num12 * num13);
            float num21 = (num9 * num15) - (num11 * num13);
            float num22 = (num9 * num14) - (num10 * num13);
            float num23 = ((num6 * num17) - (num7 * num18)) + (num8 * num19);
            float num24 = -(((num5 * num17) - (num7 * num20)) + (num8 * num21));
            float num25 = ((num5 * num18) - (num6 * num20)) + (num8 * num22);
            float num26 = -(((num5 * num19) - (num6 * num21)) + (num7 * num22));
            float num27 = 1f / ((((num * num23) + (num2 * num24)) + (num3 * num25)) + (num4 * num26));
            matrix2.M11 = num23 * num27;
            matrix2.M21 = num24 * num27;
            matrix2.M31 = num25 * num27;
            matrix2.M41 = num26 * num27;
            matrix2.M12 = -(((num2 * num17) - (num3 * num18)) + (num4 * num19)) * num27;
            matrix2.M22 = (((num * num17) - (num3 * num20)) + (num4 * num21)) * num27;
            matrix2.M32 = -(((num * num18) - (num2 * num20)) + (num4 * num22)) * num27;
            matrix2.M42 = (((num * num19) - (num2 * num21)) + (num3 * num22)) * num27;
            float num28 = (num7 * num16) - (num8 * num15);
            float num29 = (num6 * num16) - (num8 * num14);
            float num30 = (num6 * num15) - (num7 * num14);
            float num31 = (num5 * num16) - (num8 * num13);
            float num32 = (num5 * num15) - (num7 * num13);
            float num33 = (num5 * num14) - (num6 * num13);
            matrix2.M13 = (((num2 * num28) - (num3 * num29)) + (num4 * num30)) * num27;
            matrix2.M23 = -(((num * num28) - (num3 * num31)) + (num4 * num32)) * num27;
            matrix2.M33 = (((num * num29) - (num2 * num31)) + (num4 * num33)) * num27;
            matrix2.M43 = -(((num * num30) - (num2 * num32)) + (num3 * num33)) * num27;
            float num34 = (num7 * num12) - (num8 * num11);
            float num35 = (num6 * num12) - (num8 * num10);
            float num36 = (num6 * num11) - (num7 * num10);
            float num37 = (num5 * num12) - (num8 * num9);
            float num38 = (num5 * num11) - (num7 * num9);
            float num39 = (num5 * num10) - (num6 * num9);
            matrix2.M14 = -(((num2 * num34) - (num3 * num35)) + (num4 * num36)) * num27;
            matrix2.M24 = (((num * num34) - (num3 * num37)) + (num4 * num38)) * num27;
            matrix2.M34 = -(((num * num35) - (num2 * num37)) + (num4 * num39)) * num27;
            matrix2.M44 = (((num * num36) - (num2 * num38)) + (num3 * num39)) * num27;
            return matrix2;
        }

        public static void Invert(ref Matrix matrix, out Matrix result)
        {
            float num = matrix.M11;
            float num2 = matrix.M12;
            float num3 = matrix.M13;
            float num4 = matrix.M14;
            float num5 = matrix.M21;
            float num6 = matrix.M22;
            float num7 = matrix.M23;
            float num8 = matrix.M24;
            float num9 = matrix.M31;
            float num10 = matrix.M32;
            float num11 = matrix.M33;
            float num12 = matrix.M34;
            float num13 = matrix.M41;
            float num14 = matrix.M42;
            float num15 = matrix.M43;
            float num16 = matrix.M44;
            float num17 = (num11 * num16) - (num12 * num15);
            float num18 = (num10 * num16) - (num12 * num14);
            float num19 = (num10 * num15) - (num11 * num14);
            float num20 = (num9 * num16) - (num12 * num13);
            float num21 = (num9 * num15) - (num11 * num13);
            float num22 = (num9 * num14) - (num10 * num13);
            float num23 = ((num6 * num17) - (num7 * num18)) + (num8 * num19);
            float num24 = -(((num5 * num17) - (num7 * num20)) + (num8 * num21));
            float num25 = ((num5 * num18) - (num6 * num20)) + (num8 * num22);
            float num26 = -(((num5 * num19) - (num6 * num21)) + (num7 * num22));
            float num27 = 1f / ((((num * num23) + (num2 * num24)) + (num3 * num25)) + (num4 * num26));
            result.M11 = num23 * num27;
            result.M21 = num24 * num27;
            result.M31 = num25 * num27;
            result.M41 = num26 * num27;
            result.M12 = -(((num2 * num17) - (num3 * num18)) + (num4 * num19)) * num27;
            result.M22 = (((num * num17) - (num3 * num20)) + (num4 * num21)) * num27;
            result.M32 = -(((num * num18) - (num2 * num20)) + (num4 * num22)) * num27;
            result.M42 = (((num * num19) - (num2 * num21)) + (num3 * num22)) * num27;
            float num28 = (num7 * num16) - (num8 * num15);
            float num29 = (num6 * num16) - (num8 * num14);
            float num30 = (num6 * num15) - (num7 * num14);
            float num31 = (num5 * num16) - (num8 * num13);
            float num32 = (num5 * num15) - (num7 * num13);
            float num33 = (num5 * num14) - (num6 * num13);
            result.M13 = (((num2 * num28) - (num3 * num29)) + (num4 * num30)) * num27;
            result.M23 = -(((num * num28) - (num3 * num31)) + (num4 * num32)) * num27;
            result.M33 = (((num * num29) - (num2 * num31)) + (num4 * num33)) * num27;
            result.M43 = -(((num * num30) - (num2 * num32)) + (num3 * num33)) * num27;
            float num34 = (num7 * num12) - (num8 * num11);
            float num35 = (num6 * num12) - (num8 * num10);
            float num36 = (num6 * num11) - (num7 * num10);
            float num37 = (num5 * num12) - (num8 * num9);
            float num38 = (num5 * num11) - (num7 * num9);
            float num39 = (num5 * num10) - (num6 * num9);
            result.M14 = -(((num2 * num34) - (num3 * num35)) + (num4 * num36)) * num27;
            result.M24 = (((num * num34) - (num3 * num37)) + (num4 * num38)) * num27;
            result.M34 = -(((num * num35) - (num2 * num37)) + (num4 * num39)) * num27;
            result.M44 = (((num * num36) - (num2 * num38)) + (num3 * num39)) * num27;
        }

        public static Matrix Lerp(Matrix matrix1, Matrix matrix2, float amount)
        {
            Matrix matrix;
            matrix.M11 = matrix1.M11 + ((matrix2.M11 - matrix1.M11) * amount);
            matrix.M12 = matrix1.M12 + ((matrix2.M12 - matrix1.M12) * amount);
            matrix.M13 = matrix1.M13 + ((matrix2.M13 - matrix1.M13) * amount);
            matrix.M14 = matrix1.M14 + ((matrix2.M14 - matrix1.M14) * amount);
            matrix.M21 = matrix1.M21 + ((matrix2.M21 - matrix1.M21) * amount);
            matrix.M22 = matrix1.M22 + ((matrix2.M22 - matrix1.M22) * amount);
            matrix.M23 = matrix1.M23 + ((matrix2.M23 - matrix1.M23) * amount);
            matrix.M24 = matrix1.M24 + ((matrix2.M24 - matrix1.M24) * amount);
            matrix.M31 = matrix1.M31 + ((matrix2.M31 - matrix1.M31) * amount);
            matrix.M32 = matrix1.M32 + ((matrix2.M32 - matrix1.M32) * amount);
            matrix.M33 = matrix1.M33 + ((matrix2.M33 - matrix1.M33) * amount);
            matrix.M34 = matrix1.M34 + ((matrix2.M34 - matrix1.M34) * amount);
            matrix.M41 = matrix1.M41 + ((matrix2.M41 - matrix1.M41) * amount);
            matrix.M42 = matrix1.M42 + ((matrix2.M42 - matrix1.M42) * amount);
            matrix.M43 = matrix1.M43 + ((matrix2.M43 - matrix1.M43) * amount);
            matrix.M44 = matrix1.M44 + ((matrix2.M44 - matrix1.M44) * amount);
            return matrix;
        }

        public static void Lerp(ref Matrix matrix1, ref Matrix matrix2, float amount, out Matrix result)
        {
            result.M11 = matrix1.M11 + ((matrix2.M11 - matrix1.M11) * amount);
            result.M12 = matrix1.M12 + ((matrix2.M12 - matrix1.M12) * amount);
            result.M13 = matrix1.M13 + ((matrix2.M13 - matrix1.M13) * amount);
            result.M14 = matrix1.M14 + ((matrix2.M14 - matrix1.M14) * amount);
            result.M21 = matrix1.M21 + ((matrix2.M21 - matrix1.M21) * amount);
            result.M22 = matrix1.M22 + ((matrix2.M22 - matrix1.M22) * amount);
            result.M23 = matrix1.M23 + ((matrix2.M23 - matrix1.M23) * amount);
            result.M24 = matrix1.M24 + ((matrix2.M24 - matrix1.M24) * amount);
            result.M31 = matrix1.M31 + ((matrix2.M31 - matrix1.M31) * amount);
            result.M32 = matrix1.M32 + ((matrix2.M32 - matrix1.M32) * amount);
            result.M33 = matrix1.M33 + ((matrix2.M33 - matrix1.M33) * amount);
            result.M34 = matrix1.M34 + ((matrix2.M34 - matrix1.M34) * amount);
            result.M41 = matrix1.M41 + ((matrix2.M41 - matrix1.M41) * amount);
            result.M42 = matrix1.M42 + ((matrix2.M42 - matrix1.M42) * amount);
            result.M43 = matrix1.M43 + ((matrix2.M43 - matrix1.M43) * amount);
            result.M44 = matrix1.M44 + ((matrix2.M44 - matrix1.M44) * amount);
        }

        public static Matrix Negate(Matrix matrix)
        {
            Matrix matrix2;
            matrix2.M11 = -matrix.M11;
            matrix2.M12 = -matrix.M12;
            matrix2.M13 = -matrix.M13;
            matrix2.M14 = -matrix.M14;
            matrix2.M21 = -matrix.M21;
            matrix2.M22 = -matrix.M22;
            matrix2.M23 = -matrix.M23;
            matrix2.M24 = -matrix.M24;
            matrix2.M31 = -matrix.M31;
            matrix2.M32 = -matrix.M32;
            matrix2.M33 = -matrix.M33;
            matrix2.M34 = -matrix.M34;
            matrix2.M41 = -matrix.M41;
            matrix2.M42 = -matrix.M42;
            matrix2.M43 = -matrix.M43;
            matrix2.M44 = -matrix.M44;
            return matrix2;
        }

        public static void Negate(ref Matrix matrix, out Matrix result)
        {
            result.M11 = -matrix.M11;
            result.M12 = -matrix.M12;
            result.M13 = -matrix.M13;
            result.M14 = -matrix.M14;
            result.M21 = -matrix.M21;
            result.M22 = -matrix.M22;
            result.M23 = -matrix.M23;
            result.M24 = -matrix.M24;
            result.M31 = -matrix.M31;
            result.M32 = -matrix.M32;
            result.M33 = -matrix.M33;
            result.M34 = -matrix.M34;
            result.M41 = -matrix.M41;
            result.M42 = -matrix.M42;
            result.M43 = -matrix.M43;
            result.M44 = -matrix.M44;
        }

        public static Matrix Add(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix;
            matrix.M11 = matrix1.M11 + matrix2.M11;
            matrix.M12 = matrix1.M12 + matrix2.M12;
            matrix.M13 = matrix1.M13 + matrix2.M13;
            matrix.M14 = matrix1.M14 + matrix2.M14;
            matrix.M21 = matrix1.M21 + matrix2.M21;
            matrix.M22 = matrix1.M22 + matrix2.M22;
            matrix.M23 = matrix1.M23 + matrix2.M23;
            matrix.M24 = matrix1.M24 + matrix2.M24;
            matrix.M31 = matrix1.M31 + matrix2.M31;
            matrix.M32 = matrix1.M32 + matrix2.M32;
            matrix.M33 = matrix1.M33 + matrix2.M33;
            matrix.M34 = matrix1.M34 + matrix2.M34;
            matrix.M41 = matrix1.M41 + matrix2.M41;
            matrix.M42 = matrix1.M42 + matrix2.M42;
            matrix.M43 = matrix1.M43 + matrix2.M43;
            matrix.M44 = matrix1.M44 + matrix2.M44;
            return matrix;
        }

        public static void Add(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
        {
            result.M11 = matrix1.M11 + matrix2.M11;
            result.M12 = matrix1.M12 + matrix2.M12;
            result.M13 = matrix1.M13 + matrix2.M13;
            result.M14 = matrix1.M14 + matrix2.M14;
            result.M21 = matrix1.M21 + matrix2.M21;
            result.M22 = matrix1.M22 + matrix2.M22;
            result.M23 = matrix1.M23 + matrix2.M23;
            result.M24 = matrix1.M24 + matrix2.M24;
            result.M31 = matrix1.M31 + matrix2.M31;
            result.M32 = matrix1.M32 + matrix2.M32;
            result.M33 = matrix1.M33 + matrix2.M33;
            result.M34 = matrix1.M34 + matrix2.M34;
            result.M41 = matrix1.M41 + matrix2.M41;
            result.M42 = matrix1.M42 + matrix2.M42;
            result.M43 = matrix1.M43 + matrix2.M43;
            result.M44 = matrix1.M44 + matrix2.M44;
        }

        public static Matrix Subtract(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix;
            matrix.M11 = matrix1.M11 - matrix2.M11;
            matrix.M12 = matrix1.M12 - matrix2.M12;
            matrix.M13 = matrix1.M13 - matrix2.M13;
            matrix.M14 = matrix1.M14 - matrix2.M14;
            matrix.M21 = matrix1.M21 - matrix2.M21;
            matrix.M22 = matrix1.M22 - matrix2.M22;
            matrix.M23 = matrix1.M23 - matrix2.M23;
            matrix.M24 = matrix1.M24 - matrix2.M24;
            matrix.M31 = matrix1.M31 - matrix2.M31;
            matrix.M32 = matrix1.M32 - matrix2.M32;
            matrix.M33 = matrix1.M33 - matrix2.M33;
            matrix.M34 = matrix1.M34 - matrix2.M34;
            matrix.M41 = matrix1.M41 - matrix2.M41;
            matrix.M42 = matrix1.M42 - matrix2.M42;
            matrix.M43 = matrix1.M43 - matrix2.M43;
            matrix.M44 = matrix1.M44 - matrix2.M44;
            return matrix;
        }

        public static void Subtract(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
        {
            result.M11 = matrix1.M11 - matrix2.M11;
            result.M12 = matrix1.M12 - matrix2.M12;
            result.M13 = matrix1.M13 - matrix2.M13;
            result.M14 = matrix1.M14 - matrix2.M14;
            result.M21 = matrix1.M21 - matrix2.M21;
            result.M22 = matrix1.M22 - matrix2.M22;
            result.M23 = matrix1.M23 - matrix2.M23;
            result.M24 = matrix1.M24 - matrix2.M24;
            result.M31 = matrix1.M31 - matrix2.M31;
            result.M32 = matrix1.M32 - matrix2.M32;
            result.M33 = matrix1.M33 - matrix2.M33;
            result.M34 = matrix1.M34 - matrix2.M34;
            result.M41 = matrix1.M41 - matrix2.M41;
            result.M42 = matrix1.M42 - matrix2.M42;
            result.M43 = matrix1.M43 - matrix2.M43;
            result.M44 = matrix1.M44 - matrix2.M44;
        }

        public static Matrix Multiply(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix;
            matrix.M11 = (((matrix1.M11 * matrix2.M11) + (matrix1.M12 * matrix2.M21)) + (matrix1.M13 * matrix2.M31)) + (matrix1.M14 * matrix2.M41);
            matrix.M12 = (((matrix1.M11 * matrix2.M12) + (matrix1.M12 * matrix2.M22)) + (matrix1.M13 * matrix2.M32)) + (matrix1.M14 * matrix2.M42);
            matrix.M13 = (((matrix1.M11 * matrix2.M13) + (matrix1.M12 * matrix2.M23)) + (matrix1.M13 * matrix2.M33)) + (matrix1.M14 * matrix2.M43);
            matrix.M14 = (((matrix1.M11 * matrix2.M14) + (matrix1.M12 * matrix2.M24)) + (matrix1.M13 * matrix2.M34)) + (matrix1.M14 * matrix2.M44);
            matrix.M21 = (((matrix1.M21 * matrix2.M11) + (matrix1.M22 * matrix2.M21)) + (matrix1.M23 * matrix2.M31)) + (matrix1.M24 * matrix2.M41);
            matrix.M22 = (((matrix1.M21 * matrix2.M12) + (matrix1.M22 * matrix2.M22)) + (matrix1.M23 * matrix2.M32)) + (matrix1.M24 * matrix2.M42);
            matrix.M23 = (((matrix1.M21 * matrix2.M13) + (matrix1.M22 * matrix2.M23)) + (matrix1.M23 * matrix2.M33)) + (matrix1.M24 * matrix2.M43);
            matrix.M24 = (((matrix1.M21 * matrix2.M14) + (matrix1.M22 * matrix2.M24)) + (matrix1.M23 * matrix2.M34)) + (matrix1.M24 * matrix2.M44);
            matrix.M31 = (((matrix1.M31 * matrix2.M11) + (matrix1.M32 * matrix2.M21)) + (matrix1.M33 * matrix2.M31)) + (matrix1.M34 * matrix2.M41);
            matrix.M32 = (((matrix1.M31 * matrix2.M12) + (matrix1.M32 * matrix2.M22)) + (matrix1.M33 * matrix2.M32)) + (matrix1.M34 * matrix2.M42);
            matrix.M33 = (((matrix1.M31 * matrix2.M13) + (matrix1.M32 * matrix2.M23)) + (matrix1.M33 * matrix2.M33)) + (matrix1.M34 * matrix2.M43);
            matrix.M34 = (((matrix1.M31 * matrix2.M14) + (matrix1.M32 * matrix2.M24)) + (matrix1.M33 * matrix2.M34)) + (matrix1.M34 * matrix2.M44);
            matrix.M41 = (((matrix1.M41 * matrix2.M11) + (matrix1.M42 * matrix2.M21)) + (matrix1.M43 * matrix2.M31)) + (matrix1.M44 * matrix2.M41);
            matrix.M42 = (((matrix1.M41 * matrix2.M12) + (matrix1.M42 * matrix2.M22)) + (matrix1.M43 * matrix2.M32)) + (matrix1.M44 * matrix2.M42);
            matrix.M43 = (((matrix1.M41 * matrix2.M13) + (matrix1.M42 * matrix2.M23)) + (matrix1.M43 * matrix2.M33)) + (matrix1.M44 * matrix2.M43);
            matrix.M44 = (((matrix1.M41 * matrix2.M14) + (matrix1.M42 * matrix2.M24)) + (matrix1.M43 * matrix2.M34)) + (matrix1.M44 * matrix2.M44);
            return matrix;
        }

        public static void Multiply(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
        {
            float num = (((matrix1.M11 * matrix2.M11) + (matrix1.M12 * matrix2.M21)) + (matrix1.M13 * matrix2.M31)) + (matrix1.M14 * matrix2.M41);
            float num2 = (((matrix1.M11 * matrix2.M12) + (matrix1.M12 * matrix2.M22)) + (matrix1.M13 * matrix2.M32)) + (matrix1.M14 * matrix2.M42);
            float num3 = (((matrix1.M11 * matrix2.M13) + (matrix1.M12 * matrix2.M23)) + (matrix1.M13 * matrix2.M33)) + (matrix1.M14 * matrix2.M43);
            float num4 = (((matrix1.M11 * matrix2.M14) + (matrix1.M12 * matrix2.M24)) + (matrix1.M13 * matrix2.M34)) + (matrix1.M14 * matrix2.M44);
            float num5 = (((matrix1.M21 * matrix2.M11) + (matrix1.M22 * matrix2.M21)) + (matrix1.M23 * matrix2.M31)) + (matrix1.M24 * matrix2.M41);
            float num6 = (((matrix1.M21 * matrix2.M12) + (matrix1.M22 * matrix2.M22)) + (matrix1.M23 * matrix2.M32)) + (matrix1.M24 * matrix2.M42);
            float num7 = (((matrix1.M21 * matrix2.M13) + (matrix1.M22 * matrix2.M23)) + (matrix1.M23 * matrix2.M33)) + (matrix1.M24 * matrix2.M43);
            float num8 = (((matrix1.M21 * matrix2.M14) + (matrix1.M22 * matrix2.M24)) + (matrix1.M23 * matrix2.M34)) + (matrix1.M24 * matrix2.M44);
            float num9 = (((matrix1.M31 * matrix2.M11) + (matrix1.M32 * matrix2.M21)) + (matrix1.M33 * matrix2.M31)) + (matrix1.M34 * matrix2.M41);
            float num10 = (((matrix1.M31 * matrix2.M12) + (matrix1.M32 * matrix2.M22)) + (matrix1.M33 * matrix2.M32)) + (matrix1.M34 * matrix2.M42);
            float num11 = (((matrix1.M31 * matrix2.M13) + (matrix1.M32 * matrix2.M23)) + (matrix1.M33 * matrix2.M33)) + (matrix1.M34 * matrix2.M43);
            float num12 = (((matrix1.M31 * matrix2.M14) + (matrix1.M32 * matrix2.M24)) + (matrix1.M33 * matrix2.M34)) + (matrix1.M34 * matrix2.M44);
            float num13 = (((matrix1.M41 * matrix2.M11) + (matrix1.M42 * matrix2.M21)) + (matrix1.M43 * matrix2.M31)) + (matrix1.M44 * matrix2.M41);
            float num14 = (((matrix1.M41 * matrix2.M12) + (matrix1.M42 * matrix2.M22)) + (matrix1.M43 * matrix2.M32)) + (matrix1.M44 * matrix2.M42);
            float num15 = (((matrix1.M41 * matrix2.M13) + (matrix1.M42 * matrix2.M23)) + (matrix1.M43 * matrix2.M33)) + (matrix1.M44 * matrix2.M43);
            float num16 = (((matrix1.M41 * matrix2.M14) + (matrix1.M42 * matrix2.M24)) + (matrix1.M43 * matrix2.M34)) + (matrix1.M44 * matrix2.M44);
            result.M11 = num;
            result.M12 = num2;
            result.M13 = num3;
            result.M14 = num4;
            result.M21 = num5;
            result.M22 = num6;
            result.M23 = num7;
            result.M24 = num8;
            result.M31 = num9;
            result.M32 = num10;
            result.M33 = num11;
            result.M34 = num12;
            result.M41 = num13;
            result.M42 = num14;
            result.M43 = num15;
            result.M44 = num16;
        }

        public static Matrix Multiply(Matrix matrix1, float scaleFactor)
        {
            Matrix matrix;
            float num = scaleFactor;
            matrix.M11 = matrix1.M11 * num;
            matrix.M12 = matrix1.M12 * num;
            matrix.M13 = matrix1.M13 * num;
            matrix.M14 = matrix1.M14 * num;
            matrix.M21 = matrix1.M21 * num;
            matrix.M22 = matrix1.M22 * num;
            matrix.M23 = matrix1.M23 * num;
            matrix.M24 = matrix1.M24 * num;
            matrix.M31 = matrix1.M31 * num;
            matrix.M32 = matrix1.M32 * num;
            matrix.M33 = matrix1.M33 * num;
            matrix.M34 = matrix1.M34 * num;
            matrix.M41 = matrix1.M41 * num;
            matrix.M42 = matrix1.M42 * num;
            matrix.M43 = matrix1.M43 * num;
            matrix.M44 = matrix1.M44 * num;
            return matrix;
        }

        public static void Multiply(ref Matrix matrix1, float scaleFactor, out Matrix result)
        {
            float num = scaleFactor;
            result.M11 = matrix1.M11 * num;
            result.M12 = matrix1.M12 * num;
            result.M13 = matrix1.M13 * num;
            result.M14 = matrix1.M14 * num;
            result.M21 = matrix1.M21 * num;
            result.M22 = matrix1.M22 * num;
            result.M23 = matrix1.M23 * num;
            result.M24 = matrix1.M24 * num;
            result.M31 = matrix1.M31 * num;
            result.M32 = matrix1.M32 * num;
            result.M33 = matrix1.M33 * num;
            result.M34 = matrix1.M34 * num;
            result.M41 = matrix1.M41 * num;
            result.M42 = matrix1.M42 * num;
            result.M43 = matrix1.M43 * num;
            result.M44 = matrix1.M44 * num;
        }

        public static Matrix Divide(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix;
            matrix.M11 = matrix1.M11 / matrix2.M11;
            matrix.M12 = matrix1.M12 / matrix2.M12;
            matrix.M13 = matrix1.M13 / matrix2.M13;
            matrix.M14 = matrix1.M14 / matrix2.M14;
            matrix.M21 = matrix1.M21 / matrix2.M21;
            matrix.M22 = matrix1.M22 / matrix2.M22;
            matrix.M23 = matrix1.M23 / matrix2.M23;
            matrix.M24 = matrix1.M24 / matrix2.M24;
            matrix.M31 = matrix1.M31 / matrix2.M31;
            matrix.M32 = matrix1.M32 / matrix2.M32;
            matrix.M33 = matrix1.M33 / matrix2.M33;
            matrix.M34 = matrix1.M34 / matrix2.M34;
            matrix.M41 = matrix1.M41 / matrix2.M41;
            matrix.M42 = matrix1.M42 / matrix2.M42;
            matrix.M43 = matrix1.M43 / matrix2.M43;
            matrix.M44 = matrix1.M44 / matrix2.M44;
            return matrix;
        }

        public static void Divide(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
        {
            result.M11 = matrix1.M11 / matrix2.M11;
            result.M12 = matrix1.M12 / matrix2.M12;
            result.M13 = matrix1.M13 / matrix2.M13;
            result.M14 = matrix1.M14 / matrix2.M14;
            result.M21 = matrix1.M21 / matrix2.M21;
            result.M22 = matrix1.M22 / matrix2.M22;
            result.M23 = matrix1.M23 / matrix2.M23;
            result.M24 = matrix1.M24 / matrix2.M24;
            result.M31 = matrix1.M31 / matrix2.M31;
            result.M32 = matrix1.M32 / matrix2.M32;
            result.M33 = matrix1.M33 / matrix2.M33;
            result.M34 = matrix1.M34 / matrix2.M34;
            result.M41 = matrix1.M41 / matrix2.M41;
            result.M42 = matrix1.M42 / matrix2.M42;
            result.M43 = matrix1.M43 / matrix2.M43;
            result.M44 = matrix1.M44 / matrix2.M44;
        }

        public static Matrix Divide(Matrix matrix1, float divider)
        {
            Matrix matrix;
            float num = 1f / divider;
            matrix.M11 = matrix1.M11 * num;
            matrix.M12 = matrix1.M12 * num;
            matrix.M13 = matrix1.M13 * num;
            matrix.M14 = matrix1.M14 * num;
            matrix.M21 = matrix1.M21 * num;
            matrix.M22 = matrix1.M22 * num;
            matrix.M23 = matrix1.M23 * num;
            matrix.M24 = matrix1.M24 * num;
            matrix.M31 = matrix1.M31 * num;
            matrix.M32 = matrix1.M32 * num;
            matrix.M33 = matrix1.M33 * num;
            matrix.M34 = matrix1.M34 * num;
            matrix.M41 = matrix1.M41 * num;
            matrix.M42 = matrix1.M42 * num;
            matrix.M43 = matrix1.M43 * num;
            matrix.M44 = matrix1.M44 * num;
            return matrix;
        }

        public static void Divide(ref Matrix matrix1, float divider, out Matrix result)
        {
            float num = 1f / divider;
            result.M11 = matrix1.M11 * num;
            result.M12 = matrix1.M12 * num;
            result.M13 = matrix1.M13 * num;
            result.M14 = matrix1.M14 * num;
            result.M21 = matrix1.M21 * num;
            result.M22 = matrix1.M22 * num;
            result.M23 = matrix1.M23 * num;
            result.M24 = matrix1.M24 * num;
            result.M31 = matrix1.M31 * num;
            result.M32 = matrix1.M32 * num;
            result.M33 = matrix1.M33 * num;
            result.M34 = matrix1.M34 * num;
            result.M41 = matrix1.M41 * num;
            result.M42 = matrix1.M42 * num;
            result.M43 = matrix1.M43 * num;
            result.M44 = matrix1.M44 * num;
        }

        public static Matrix operator -(Matrix matrix1)
        {
            Matrix matrix;
            matrix.M11 = -matrix1.M11;
            matrix.M12 = -matrix1.M12;
            matrix.M13 = -matrix1.M13;
            matrix.M14 = -matrix1.M14;
            matrix.M21 = -matrix1.M21;
            matrix.M22 = -matrix1.M22;
            matrix.M23 = -matrix1.M23;
            matrix.M24 = -matrix1.M24;
            matrix.M31 = -matrix1.M31;
            matrix.M32 = -matrix1.M32;
            matrix.M33 = -matrix1.M33;
            matrix.M34 = -matrix1.M34;
            matrix.M41 = -matrix1.M41;
            matrix.M42 = -matrix1.M42;
            matrix.M43 = -matrix1.M43;
            matrix.M44 = -matrix1.M44;
            return matrix;
        }

        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            return ((((((matrix1.M11 == matrix2.M11) && (matrix1.M22 == matrix2.M22)) && ((matrix1.M33 == matrix2.M33) && (matrix1.M44 == matrix2.M44))) && (((matrix1.M12 == matrix2.M12) && (matrix1.M13 == matrix2.M13)) && ((matrix1.M14 == matrix2.M14) && (matrix1.M21 == matrix2.M21)))) && ((((matrix1.M23 == matrix2.M23) && (matrix1.M24 == matrix2.M24)) && ((matrix1.M31 == matrix2.M31) && (matrix1.M32 == matrix2.M32))) && (((matrix1.M34 == matrix2.M34) && (matrix1.M41 == matrix2.M41)) && (matrix1.M42 == matrix2.M42)))) && (matrix1.M43 == matrix2.M43));
        }

        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            return ((((((matrix1.M11 != matrix2.M11) || (matrix1.M12 != matrix2.M12)) || ((matrix1.M13 != matrix2.M13) || (matrix1.M14 != matrix2.M14))) || (((matrix1.M21 != matrix2.M21) || (matrix1.M22 != matrix2.M22)) || ((matrix1.M23 != matrix2.M23) || (matrix1.M24 != matrix2.M24)))) || ((((matrix1.M31 != matrix2.M31) || (matrix1.M32 != matrix2.M32)) || ((matrix1.M33 != matrix2.M33) || (matrix1.M34 != matrix2.M34))) || (((matrix1.M41 != matrix2.M41) || (matrix1.M42 != matrix2.M42)) || (matrix1.M43 != matrix2.M43)))) || !(matrix1.M44 == matrix2.M44));
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix;
            matrix.M11 = matrix1.M11 + matrix2.M11;
            matrix.M12 = matrix1.M12 + matrix2.M12;
            matrix.M13 = matrix1.M13 + matrix2.M13;
            matrix.M14 = matrix1.M14 + matrix2.M14;
            matrix.M21 = matrix1.M21 + matrix2.M21;
            matrix.M22 = matrix1.M22 + matrix2.M22;
            matrix.M23 = matrix1.M23 + matrix2.M23;
            matrix.M24 = matrix1.M24 + matrix2.M24;
            matrix.M31 = matrix1.M31 + matrix2.M31;
            matrix.M32 = matrix1.M32 + matrix2.M32;
            matrix.M33 = matrix1.M33 + matrix2.M33;
            matrix.M34 = matrix1.M34 + matrix2.M34;
            matrix.M41 = matrix1.M41 + matrix2.M41;
            matrix.M42 = matrix1.M42 + matrix2.M42;
            matrix.M43 = matrix1.M43 + matrix2.M43;
            matrix.M44 = matrix1.M44 + matrix2.M44;
            return matrix;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix;
            matrix.M11 = matrix1.M11 - matrix2.M11;
            matrix.M12 = matrix1.M12 - matrix2.M12;
            matrix.M13 = matrix1.M13 - matrix2.M13;
            matrix.M14 = matrix1.M14 - matrix2.M14;
            matrix.M21 = matrix1.M21 - matrix2.M21;
            matrix.M22 = matrix1.M22 - matrix2.M22;
            matrix.M23 = matrix1.M23 - matrix2.M23;
            matrix.M24 = matrix1.M24 - matrix2.M24;
            matrix.M31 = matrix1.M31 - matrix2.M31;
            matrix.M32 = matrix1.M32 - matrix2.M32;
            matrix.M33 = matrix1.M33 - matrix2.M33;
            matrix.M34 = matrix1.M34 - matrix2.M34;
            matrix.M41 = matrix1.M41 - matrix2.M41;
            matrix.M42 = matrix1.M42 - matrix2.M42;
            matrix.M43 = matrix1.M43 - matrix2.M43;
            matrix.M44 = matrix1.M44 - matrix2.M44;
            return matrix;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix;
            matrix.M11 = (((matrix1.M11 * matrix2.M11) + (matrix1.M12 * matrix2.M21)) + (matrix1.M13 * matrix2.M31)) + (matrix1.M14 * matrix2.M41);
            matrix.M12 = (((matrix1.M11 * matrix2.M12) + (matrix1.M12 * matrix2.M22)) + (matrix1.M13 * matrix2.M32)) + (matrix1.M14 * matrix2.M42);
            matrix.M13 = (((matrix1.M11 * matrix2.M13) + (matrix1.M12 * matrix2.M23)) + (matrix1.M13 * matrix2.M33)) + (matrix1.M14 * matrix2.M43);
            matrix.M14 = (((matrix1.M11 * matrix2.M14) + (matrix1.M12 * matrix2.M24)) + (matrix1.M13 * matrix2.M34)) + (matrix1.M14 * matrix2.M44);
            matrix.M21 = (((matrix1.M21 * matrix2.M11) + (matrix1.M22 * matrix2.M21)) + (matrix1.M23 * matrix2.M31)) + (matrix1.M24 * matrix2.M41);
            matrix.M22 = (((matrix1.M21 * matrix2.M12) + (matrix1.M22 * matrix2.M22)) + (matrix1.M23 * matrix2.M32)) + (matrix1.M24 * matrix2.M42);
            matrix.M23 = (((matrix1.M21 * matrix2.M13) + (matrix1.M22 * matrix2.M23)) + (matrix1.M23 * matrix2.M33)) + (matrix1.M24 * matrix2.M43);
            matrix.M24 = (((matrix1.M21 * matrix2.M14) + (matrix1.M22 * matrix2.M24)) + (matrix1.M23 * matrix2.M34)) + (matrix1.M24 * matrix2.M44);
            matrix.M31 = (((matrix1.M31 * matrix2.M11) + (matrix1.M32 * matrix2.M21)) + (matrix1.M33 * matrix2.M31)) + (matrix1.M34 * matrix2.M41);
            matrix.M32 = (((matrix1.M31 * matrix2.M12) + (matrix1.M32 * matrix2.M22)) + (matrix1.M33 * matrix2.M32)) + (matrix1.M34 * matrix2.M42);
            matrix.M33 = (((matrix1.M31 * matrix2.M13) + (matrix1.M32 * matrix2.M23)) + (matrix1.M33 * matrix2.M33)) + (matrix1.M34 * matrix2.M43);
            matrix.M34 = (((matrix1.M31 * matrix2.M14) + (matrix1.M32 * matrix2.M24)) + (matrix1.M33 * matrix2.M34)) + (matrix1.M34 * matrix2.M44);
            matrix.M41 = (((matrix1.M41 * matrix2.M11) + (matrix1.M42 * matrix2.M21)) + (matrix1.M43 * matrix2.M31)) + (matrix1.M44 * matrix2.M41);
            matrix.M42 = (((matrix1.M41 * matrix2.M12) + (matrix1.M42 * matrix2.M22)) + (matrix1.M43 * matrix2.M32)) + (matrix1.M44 * matrix2.M42);
            matrix.M43 = (((matrix1.M41 * matrix2.M13) + (matrix1.M42 * matrix2.M23)) + (matrix1.M43 * matrix2.M33)) + (matrix1.M44 * matrix2.M43);
            matrix.M44 = (((matrix1.M41 * matrix2.M14) + (matrix1.M42 * matrix2.M24)) + (matrix1.M43 * matrix2.M34)) + (matrix1.M44 * matrix2.M44);
            return matrix;
        }

        public static Matrix operator *(Matrix matrix, float scaleFactor)
        {
            Matrix matrix2;
            float num = scaleFactor;
            matrix2.M11 = matrix.M11 * num;
            matrix2.M12 = matrix.M12 * num;
            matrix2.M13 = matrix.M13 * num;
            matrix2.M14 = matrix.M14 * num;
            matrix2.M21 = matrix.M21 * num;
            matrix2.M22 = matrix.M22 * num;
            matrix2.M23 = matrix.M23 * num;
            matrix2.M24 = matrix.M24 * num;
            matrix2.M31 = matrix.M31 * num;
            matrix2.M32 = matrix.M32 * num;
            matrix2.M33 = matrix.M33 * num;
            matrix2.M34 = matrix.M34 * num;
            matrix2.M41 = matrix.M41 * num;
            matrix2.M42 = matrix.M42 * num;
            matrix2.M43 = matrix.M43 * num;
            matrix2.M44 = matrix.M44 * num;
            return matrix2;
        }

        public static Matrix operator *(float scaleFactor, Matrix matrix)
        {
            Matrix matrix2;
            float num = scaleFactor;
            matrix2.M11 = matrix.M11 * num;
            matrix2.M12 = matrix.M12 * num;
            matrix2.M13 = matrix.M13 * num;
            matrix2.M14 = matrix.M14 * num;
            matrix2.M21 = matrix.M21 * num;
            matrix2.M22 = matrix.M22 * num;
            matrix2.M23 = matrix.M23 * num;
            matrix2.M24 = matrix.M24 * num;
            matrix2.M31 = matrix.M31 * num;
            matrix2.M32 = matrix.M32 * num;
            matrix2.M33 = matrix.M33 * num;
            matrix2.M34 = matrix.M34 * num;
            matrix2.M41 = matrix.M41 * num;
            matrix2.M42 = matrix.M42 * num;
            matrix2.M43 = matrix.M43 * num;
            matrix2.M44 = matrix.M44 * num;
            return matrix2;
        }

        public static Matrix operator /(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix;
            matrix.M11 = matrix1.M11 / matrix2.M11;
            matrix.M12 = matrix1.M12 / matrix2.M12;
            matrix.M13 = matrix1.M13 / matrix2.M13;
            matrix.M14 = matrix1.M14 / matrix2.M14;
            matrix.M21 = matrix1.M21 / matrix2.M21;
            matrix.M22 = matrix1.M22 / matrix2.M22;
            matrix.M23 = matrix1.M23 / matrix2.M23;
            matrix.M24 = matrix1.M24 / matrix2.M24;
            matrix.M31 = matrix1.M31 / matrix2.M31;
            matrix.M32 = matrix1.M32 / matrix2.M32;
            matrix.M33 = matrix1.M33 / matrix2.M33;
            matrix.M34 = matrix1.M34 / matrix2.M34;
            matrix.M41 = matrix1.M41 / matrix2.M41;
            matrix.M42 = matrix1.M42 / matrix2.M42;
            matrix.M43 = matrix1.M43 / matrix2.M43;
            matrix.M44 = matrix1.M44 / matrix2.M44;
            return matrix;
        }

        public static Matrix operator /(Matrix matrix1, float divider)
        {
            Matrix matrix;
            float num = 1f / divider;
            matrix.M11 = matrix1.M11 * num;
            matrix.M12 = matrix1.M12 * num;
            matrix.M13 = matrix1.M13 * num;
            matrix.M14 = matrix1.M14 * num;
            matrix.M21 = matrix1.M21 * num;
            matrix.M22 = matrix1.M22 * num;
            matrix.M23 = matrix1.M23 * num;
            matrix.M24 = matrix1.M24 * num;
            matrix.M31 = matrix1.M31 * num;
            matrix.M32 = matrix1.M32 * num;
            matrix.M33 = matrix1.M33 * num;
            matrix.M34 = matrix1.M34 * num;
            matrix.M41 = matrix1.M41 * num;
            matrix.M42 = matrix1.M42 * num;
            matrix.M43 = matrix1.M43 * num;
            matrix.M44 = matrix1.M44 * num;
            return matrix;
        }

        static Matrix()
        {
            _identity = new Matrix(1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f);
        }
    }


}
