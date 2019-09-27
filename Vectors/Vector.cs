using System;

namespace Vectors
{
    public class Vector
    {
        public double[] Array { get; set; }

        public Vector(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Размерность не можеть быть меньше 1.");
            }

            Array = new double[size];
        }

        public Vector(Vector vector)
        {
            Array = vector.Array;
        }

        public Vector(double[] array)
        {
            Array = array;
        }

        public Vector(int size, double[] array)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Размерность не можеть быть меньше 1.");
            }

            Array = new double[size];

            for (int i = 0; i < array.Length; i++)
            {
                Array[i] = array[i];
            }
        }

        public int GetSize()
        {
            return Array.Length;
        }

        public Vector GetSum(Vector vector)
        {
            int max = Math.Max(GetSize(), vector.GetSize());
            int min = Math.Min(GetSize(), vector.GetSize());

            Vector vectorSum = new Vector(max);

            for (int i = 0; i < min; i++)
            {
                vectorSum.Array[i] = Array[i] + vector.Array[i];
            }

            if (GetSize() > vector.GetSize())
            {
                for (int i = min; i < max; i++)
                {
                    vectorSum.Array[i] = Array[i];
                }
            }
            else
            {
                for (int i = min; i < max; i++)
                {
                    vectorSum.Array[i] = vector.Array[i];
                }
            }

            return vectorSum;
        }

        public Vector GetDifference(Vector vector)
        {
            int max = Math.Max(GetSize(), vector.GetSize());
            int min = Math.Min(GetSize(), vector.GetSize());

            Vector vectorDifference = new Vector(max);

            for (int i = 0; i < min; i++)
            {
                vectorDifference.Array[i] = Array[i] - vector.Array[i];
            }

            if (GetSize() > vector.GetSize())
            {
                for (int i = min; i < max; i++)
                {
                    vectorDifference.Array[i] = Array[i];
                }
            }
            else
            {
                for (int i = min; i < max; i++)
                {
                    vectorDifference.Array[i] = 0 - vector.Array[i];
                }
            }

            return vectorDifference;
        }

        public Vector GetMultiplicationByScalar(double scalar)
        {
            Vector multipliedVector = new Vector(GetSize());

            for (int i = 0; i < GetSize(); i++)
            {
                multipliedVector.Array[i] = scalar * Array[i];
            }

            return multipliedVector;
        }

        public Vector GetRotatedVector()
        {
            return GetMultiplicationByScalar(-1);
        }

        public double GetLength()
        {
            double length = 0;

            for (int i = 0; i < GetSize(); i++)
            {
                length += Math.Pow(Array[i], 2);
            }

            return Math.Sqrt(length);
        }

        public double GetOrChangeComponent(int componentNumber)
        {
            return Array[componentNumber - 1];
        }

        public double GetOrChangeComponent(int componentNumber, double newMeaning)
        {
            Array[componentNumber - 1] = newMeaning;

            return Array[componentNumber - 1];
        }

        public static Vector SubstractVectors(Vector vector1, Vector vector2)
        {
            int max = Math.Max(vector1.GetSize(), vector2.GetSize());
            int min = Math.Min(vector1.GetSize(), vector2.GetSize());

            Vector result = new Vector(max);

            for (int i = 0; i < min; i++)
            {
                result.Array[i] = vector1.Array[i] - vector2.Array[i];
            }

            if (vector1.GetSize() > vector2.GetSize())
            {
                for (int i = min; i < max; i++)
                {
                    result.Array[i] = vector1.Array[i];
                }
            }
            else
            {
                for (int i = min; i < max; i++)
                {
                    result.Array[i] = 0 - vector2.Array[i];
                }
            }

            return result;
        }

        public static Vector AddVectors(Vector vector1, Vector vector2)
        {
            int max = Math.Max(vector1.GetSize(), vector2.GetSize());
            int min = Math.Min(vector1.GetSize(), vector2.GetSize());

            Vector result = new Vector(max);

            for (int i = 0; i < min; i++)
            {
                result.Array[i] = vector1.Array[i] + vector2.Array[i];
            }

            if (vector1.GetSize() > vector2.GetSize())
            {
                for (int i = min; i < max; i++)
                {
                    result.Array[i] = vector1.Array[i];
                }
            }
            else
            {
                for (int i = min; i < max; i++)
                {
                    result.Array[i] = vector2.Array[i];
                }
            }

            return result;
        }

        public static Vector MultiplyVectors(Vector vector1, Vector vector2)
        {
            int max = Math.Max(vector1.GetSize(), vector2.GetSize());
            int min = Math.Min(vector1.GetSize(), vector2.GetSize());

            Vector result = new Vector(max);

            for (int i = 0; i < min; i++)
            {
                result.Array[i] = vector1.Array[i] * vector2.Array[i];
            }

            if (vector1.GetSize() != vector2.GetSize())
            {
                for (int i = min; i < max; i++)
                {
                    result.Array[i] = 0;
                }
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

            bool isEquals = false;

            if (vector.GetSize() == GetSize())
            {
                for (int i = 0; i < GetSize(); i++)
                {
                    isEquals = Array[i] == vector.Array[i];
                }
            }

            return isEquals;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            for (int i = 0; i < GetSize(); i++)
            {
                hash = prime * hash + Array[i].GetHashCode();
            }

            return hash;
        }

        public override string ToString()
        {
            return string.Join(", ", Array);
        }
    }
}
