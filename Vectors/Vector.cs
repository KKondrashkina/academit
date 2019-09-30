using System;
using System.Text;

namespace Vectors
{
    public class Vector
    {
        private double[] VectorComponents { get; set; }

        public Vector(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Размерность не может быть меньше 1.");
            }

            VectorComponents = new double[size];
        }

        public Vector(Vector vector)
        {
            VectorComponents = new double[vector.VectorComponents.Length];

            Array.Copy(vector.VectorComponents, 0, VectorComponents, 0, VectorComponents.Length);
        }

        public Vector(double[] array)
        {
            VectorComponents = new double[array.Length];

            Array.Copy(array, 0, VectorComponents, 0, array.Length);
        }

        public Vector(int size, double[] array)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Размерность не может быть меньше 1.");
            }

            VectorComponents = new double[size];

            Array.Copy(array, 0, VectorComponents, 0, array.Length);
        }

        public int GetSize()
        {
            return VectorComponents.Length;
        }

        public void GetSum(Vector vector)
        {
            int max = Math.Max(GetSize(), vector.GetSize());
            int min = Math.Min(GetSize(), vector.GetSize());

            Vector vectorSum = new Vector(max);

            for (int i = 0; i < min; i++)
            {
                vectorSum.VectorComponents[i] = VectorComponents[i] + vector.VectorComponents[i];
            }

            if (GetSize() > vector.GetSize())
            {
                Array.Copy(VectorComponents, min, vectorSum.VectorComponents, min, max - min);
            }
            else
            {
                Array.Copy(vector.VectorComponents, min, vectorSum.VectorComponents, min, max - min);
            }

            VectorComponents = vectorSum.VectorComponents;
        }

        public void GetDifference(Vector vector)
        {
            int max = Math.Max(GetSize(), vector.GetSize());
            int min = Math.Min(GetSize(), vector.GetSize());

            Vector vectorDifference = new Vector(max);

            for (int i = 0; i < min; i++)
            {
                vectorDifference.VectorComponents[i] = VectorComponents[i] - vector.VectorComponents[i];
            }

            if (GetSize() > vector.GetSize())
            {
                Array.Copy(VectorComponents, min, vectorDifference.VectorComponents, min, max - min);
            }
            else
            {
                for (int i = min; i < max; i++)
                {
                    vectorDifference.VectorComponents[i] = 0 - vector.VectorComponents[i];
                }
            }

            VectorComponents = vectorDifference.VectorComponents;
        }

        public void GetMultiplicationByScalar(double scalar)
        {
            Vector multipliedVector = new Vector(GetSize());

            for (int i = 0; i < GetSize(); i++)
            {
                multipliedVector.VectorComponents[i] = scalar * VectorComponents[i];
            }

            VectorComponents = multipliedVector.VectorComponents;
        }

        public void GetRotatedVector()
        {
            GetMultiplicationByScalar(-1);
        }

        public double GetLength()
        {
            double length = 0;

            foreach (double vectorComponent in VectorComponents)
            {
                length += Math.Pow(vectorComponent, 2);
            }

            return Math.Sqrt(length);
        }

        public double GetComponent(int index)
        {
            return VectorComponents[index];
        }

        public void ChangeComponent(int index, double newValue)
        {
            VectorComponents[index] = newValue;
        }

        public static Vector SubtractVectors(Vector vector1, Vector vector2)
        {
            Vector vectorCopy = new Vector(vector1);

            vectorCopy.GetSum(vector2);

            return vectorCopy;
        }

        public static Vector AddVectors(Vector vector1, Vector vector2)
        {
            Vector vectorCopy = new Vector(vector1);

            vectorCopy.GetDifference(vector2);

            return vectorCopy;
        }

        public static double MultiplyVectors(Vector vector1, Vector vector2)
        {
            int min = Math.Min(vector1.GetSize(), vector2.GetSize());

            double result = 0;

            for (int i = 0; i < min; i++)
            {
                result += vector1.VectorComponents[i] * vector2.VectorComponents[i];
            }

            return result;
        }

        public override bool Equals(object o)
        {
            if (ReferenceEquals(o, this))
            {
                return true;
            }

            if (ReferenceEquals(o, null) || o.GetType() != GetType())
            {
                return false;
            }

            Vector vector = (Vector)o;

            if (vector.GetSize() == GetSize())
            {
                for (int i = 0; i < GetSize(); i++)
                {
                    if (VectorComponents[i] != vector.VectorComponents[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            for (int i = 0; i < GetSize(); i++)
            {
                hash = prime * hash + VectorComponents[i].GetHashCode();
            }

            return hash;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("{ ");

            foreach (double vectorComponent in VectorComponents)
            {
                sb.Append(vectorComponent)
                  .Append(", ");
            }

            sb.Remove(sb.Length - 2, 1)
              .Append('}');

            return sb.ToString();
        }
    }
}
