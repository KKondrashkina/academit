using System;
using System.Text;

namespace Vectors
{
    public class Vector
    {
        private double[] components;

        public Vector(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Размерность не может быть меньше 1.");
            }

            components = new double[size];
        }

        public Vector(Vector vector)
        {
            components = new double[vector.components.Length];

            Array.Copy(vector.components, 0, components, 0, components.Length);
        }

        public Vector(double[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Размерность не может быть меньше 1.");
            }

            components = new double[array.Length];

            Array.Copy(array, 0, components, 0, array.Length);
        }

        public Vector(int size, double[] array)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Размерность не может быть меньше 1.");
            }

            components = new double[size];

            Array.Copy(array, 0, components, 0, Math.Min(size, array.Length));
        }

        public int GetSize()
        {
            return components.Length;
        }

        public void AddVector(Vector vector)
        {
            int size1 = GetSize();
            int size2 = vector.GetSize();

            if (size1 < size2)
            {
                Array.Resize(ref components, size2);
            }

            for (int i = 0; i < size2; i++)
            {
                components[i] += vector.components[i];
            }
        }

        public void SubtractVector(Vector vector)
        {
            int size1 = GetSize();
            int size2 = vector.GetSize();

            if (size1 < size2)
            {
                Array.Resize(ref components, size2);
            }

            for (int i = 0; i < size2; i++)
            {
                components[i] -= vector.components[i];
            }
        }

        public void MultiplyByScalar(double scalar)
        {
            for (int i = 0; i < GetSize(); i++)
            {
                components[i] *= scalar;
            }
        }

        public void RotateVector()
        {
            MultiplyByScalar(-1);
        }

        public double GetLength()
        {
            double length = 0;

            foreach (double vectorComponent in components)
            {
                length += Math.Pow(vectorComponent, 2);
            }

            return Math.Sqrt(length);
        }

        public double GetComponent(int index)
        {
            return components[index];
        }

        public void SetComponent(int index, double newValue)
        {
            components[index] = newValue;
        }

        public static Vector SubtractVectors(Vector vector1, Vector vector2)
        {
            Vector vectorCopy = new Vector(vector1);

            vectorCopy.AddVector(vector2);

            return vectorCopy;
        }

        public static Vector AddVectors(Vector vector1, Vector vector2)
        {
            Vector vectorCopy = new Vector(vector1);

            vectorCopy.SubtractVector(vector2);

            return vectorCopy;
        }

        public static double MultiplyVectors(Vector vector1, Vector vector2)
        {
            int min = Math.Min(vector1.GetSize(), vector2.GetSize());

            double result = 0;

            for (int i = 0; i < min; i++)
            {
                result += vector1.components[i] * vector2.components[i];
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

            if (vector.GetSize() != GetSize())
            {
                return false;
            }

            for (int i = 0; i < GetSize(); i++)
            {
                if (components[i] != vector.components[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            for (int i = 0; i < GetSize(); i++)
            {
                hash = prime * hash + components[i].GetHashCode();
            }

            return hash;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("{ ");

            foreach (double vectorComponent in components)
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
