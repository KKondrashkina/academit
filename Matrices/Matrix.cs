using System;
using System.Linq;
using System.Text;
using Vectors;

namespace Matrices
{
    public class Matrix
    {
        public Vector[] vectorsArray;

        public Matrix(int size1, int size2)
        {
            if (size1 <= 0 || size2 <= 0)
            {
                throw new ArgumentException("Размерность не можеть быть меньше 1.");
            }

            vectorsArray = new Vector[size2];

            for (int i = 0; i < size2; i++)
            {
                vectorsArray[i] = new Vector(size1);
            }
        }

        public Matrix(Matrix matrix)
        {
            vectorsArray = new Vector[matrix.GetSize()[1]];

            Array.Copy(matrix.vectorsArray, 0, vectorsArray, 0, vectorsArray.Length);
        }

        public Matrix(double[,] array)
        {
            int size1 = array.GetLength(0);
            int size2 = array.GetLength(1);

            if (size1 == 0 || size2 == 0)
            {
                throw new ArgumentException("Размерность не может быть меньше 1.");
            }

            vectorsArray = new Vector[size1];

            for (int i = 0; i < size1; i++)
            {
                Vector vector = new Vector(size2);

                for (int j = 0; j < size2; j++)
                {
                    vector.SetComponent(j, array[i, j]);
                }

                vectorsArray[i] = vector;
            }
        }

        public Matrix(Vector[] vectors)
        {
            if (vectors.Length == 0)
            {
                throw new ArgumentException("Размерность не может быть меньше 1.");
            }

            int[] sizes = new int[vectors.Length];

            for (int i = 0; i < vectors.Length; i++)
            {
                sizes[i] = vectors[i].GetSize();
            }

            int maxSize = sizes.Max();

            vectorsArray = new Vector[vectors.Length];

            for (int i = 0; i < vectors.Length; i++)
            {
                Vector vector = new Vector(maxSize);

                for (int j = 0; j < vectors[i].GetSize(); j++)
                {
                    vector.SetComponent(j, vectors[i].GetComponent(j));
                }

                vectorsArray[i] = vector;
            }
        }

        public int[] GetSize()
        {
            int size1 = vectorsArray[0].GetSize();
            int size2 = vectorsArray.Length;

            return new int[] { size1, size2 };
        }

        public Vector GetHorizontalVector(int vectorIndex)
        {
            return vectorsArray[vectorIndex];
        }

        public void SetHorizontalVector(int vectorIndex, double[] newValue)
        {
            vectorsArray[vectorIndex] = new Vector(newValue);
        }

        public Vector GetVerticalVector(int vectorIndex)
        {
            int size = GetSize()[1];

            Vector vector = new Vector(size);

            for (int i = 0; i < size; i++)
            {
                vector.SetComponent(i, vectorsArray[i].GetComponent(vectorIndex));
            }

            return vector;
        }

        public void TransposeMatrix()
        {
            int size1 = GetSize()[0];
            int size2 = GetSize()[1];

            Matrix transposedMatrix = new Matrix(size2, size1);

            for (int i = 0; i < size1; i++)
            {
                transposedMatrix.vectorsArray[i] = GetVerticalVector(i);
            }

            vectorsArray = transposedMatrix.vectorsArray;
        }

        public void MultiplyByScalar(double scalar)
        {
            for (int i = 0; i < GetSize()[1]; i++)
            {
                vectorsArray[i].MultiplyByScalar(scalar);
            }
        }

        public double GetDeterminant()
        {
            int size1 = vectorsArray[0].GetSize();
            int size2 = vectorsArray.Length;

            if (size1 != size2)
            {
                return 0;
            }

            if (size1 == 1)
            {
                return vectorsArray[0].GetComponent(0);
            }

            if (size1 == 2)
            {
                return vectorsArray[0].GetComponent(0) * vectorsArray[1].GetComponent(1) - vectorsArray[0].GetComponent(1) * vectorsArray[1].GetComponent(0);
            }

            double determinant = 0;

            for (int i = 0; i < size2; i++)
            {
                Matrix newMatrix = new Matrix(size1 - 1, size2 - 1);

                for (int j = 1; j < size1; j++)
                {
                    for (int k = 0, newIndexY = 0; k < size2; k++, newIndexY++)
                    {
                        if (k == i)
                        {
                            newIndexY--;
                            continue;
                        }

                        newMatrix.vectorsArray[j - 1].SetComponent(newIndexY, vectorsArray[j].GetComponent(k));
                    }
                }

                if (i % 2 == 0)
                {
                    determinant += vectorsArray[0].GetComponent(i) * newMatrix.GetDeterminant();
                }
                else
                {
                    determinant += -vectorsArray[0].GetComponent(i) * newMatrix.GetDeterminant();
                }
            }

            return determinant;
        }

        public void MultiplyByVector(Vector vector)
        {
            int vectorSize = vector.GetSize();
            int size2 = GetSize()[1];

            Matrix newMatrix = new Matrix(1, Math.Max(vectorSize, size2));
            Vector newVector = new Vector(Math.Max(vectorSize, size2));

            for (int i = 0; i < vectorSize; i++)
            {
                newVector.SetComponent(i, vector.GetComponent(i));
            }

            double component = 0;
            int size1 = GetSize()[0];

            for (int i = 0; i < Math.Min(vectorSize, size2); i++)
            {
                for (int j = 0; j < size1; j++)
                {
                    component += vectorsArray[i].GetComponent(j) * newVector.GetComponent(j);
                }

                newMatrix.vectorsArray[i].SetComponent(0, component);

                component = 0;
            }

            vectorsArray = newMatrix.vectorsArray;
        }

        public void AddMatrix(Matrix matrix)
        {
            int size1 = GetSize()[0];
            int size2 = GetSize()[1];
            int matrixSize1 = matrix.GetSize()[0];
            int matrixSize2 = matrix.GetSize()[1];

            Matrix sum = new Matrix(Math.Max(size1, matrixSize1), Math.Max(size2, matrixSize2));

            for (int i = 0; i < Math.Min(size2, matrixSize2); i++)
            {
                sum.vectorsArray[i] = Vector.AddVectors(vectorsArray[i], matrix.vectorsArray[i]);
            }

            if (size2 > matrixSize2)
            {
                for (int i = Math.Min(size2, matrixSize2); i < Math.Max(size2, matrixSize2); i++)
                {
                    sum.vectorsArray[i].AddVector(vectorsArray[i]);
                }
            }
            else
            {
                for (int i = Math.Min(size2, matrixSize2); i < Math.Max(size2, matrixSize2); i++)
                {
                    sum.vectorsArray[i].AddVector(matrix.vectorsArray[i]);
                }
            }

            vectorsArray = sum.vectorsArray;
        }

        public void SubtractMatrix(Matrix matrix)
        {
            int size1 = GetSize()[0];
            int size2 = GetSize()[1];
            int matrixSize1 = matrix.GetSize()[0];
            int matrixSize2 = matrix.GetSize()[1];

            Matrix sum = new Matrix(Math.Max(size1, matrixSize1), Math.Max(size2, matrixSize2));

            for (int i = 0; i < Math.Min(size2, matrixSize2); i++)
            {
                sum.vectorsArray[i] = Vector.SubtractVectors(vectorsArray[i], matrix.vectorsArray[i]);
            }

            if (size2 > matrix.GetSize()[1])
            {
                for (int i = Math.Min(size2, matrixSize2); i < Math.Max(size2, matrixSize2); i++)
                {
                    vectorsArray[i].RotateVector();
                    sum.vectorsArray[i].SubtractVector(vectorsArray[i]);
                }
            }
            else
            {
                for (int i = Math.Min(size2, matrixSize2); i < Math.Max(size2, matrixSize2); i++)
                {
                    sum.vectorsArray[i].SubtractVector(matrix.vectorsArray[i]);
                }
            }

            vectorsArray = sum.vectorsArray;
        }

        public static Matrix AddMatrices(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrixCopy = new Matrix(matrix1);

            matrixCopy.AddMatrix(matrix2);

            return matrixCopy;
        }

        public static Matrix SubtractMatrices(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrixCopy = new Matrix(matrix1);

            matrixCopy.SubtractMatrix(matrix2);

            return matrixCopy;
        }

        public static Matrix MultiplyMatrices(Matrix matrix1, Matrix matrix2)
        {
            int matrix1Size1 = matrix1.GetSize()[0];
            int matrix1Size2 = matrix1.GetSize()[1];
            int matrix2Size1 = matrix2.GetSize()[0];
            int matrix2Size2 = matrix2.GetSize()[1];

            if (matrix1Size1 != matrix2Size2 || matrix1Size2 != matrix2Size1)
            {
                throw new ArgumentException("Матрицы не согласованы.");
            }

            Matrix newMatrix = new Matrix(matrix1Size2, matrix2Size1);


            for (int i = 0; i < matrix1Size2; i++)
            {
                for (int j = 0; j < matrix2Size1; j++)
                {
                    newMatrix.vectorsArray[i].SetComponent(j, Vector.MultiplyVectors(matrix1.GetHorizontalVector(i), matrix2.GetVerticalVector(j)));
                }
            }

            return newMatrix;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("{ ");

            foreach (Vector vector in vectorsArray)
            {
                sb.Append(vector)
                  .Append(", ");
            }

            sb.Remove(sb.Length - 2, 1)
              .Append('}');

            return sb.ToString();
        }
    }
}
