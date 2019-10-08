using System;
using System.Linq;
using System.Text;
using Vectors;

namespace Matrices
{
    public class Matrix
    {
        private Vector[] matrixRows;

        public Matrix(int rowsSize, int columnsSize)
        {
            if (rowsSize <= 0 || columnsSize <= 0)
            {
                throw new ArgumentException("Размерность не можеть быть меньше 1.");
            }

            matrixRows = new Vector[columnsSize];

            for (int i = 0; i < columnsSize; i++)
            {
                matrixRows[i] = new Vector(rowsSize);
            }
        }

        public Matrix(Matrix matrix)
        {
            matrixRows = new Vector[matrix.GetVerticalSize()];

            Array.Copy(matrix.matrixRows, 0, matrixRows, 0, matrixRows.Length);
        }

        public Matrix(double[,] array)
        {
            int rowsSize = array.GetLength(0);
            int columnsSize = array.GetLength(1);

            if (rowsSize == 0 || columnsSize == 0)
            {
                throw new ArgumentException("Размерность не может быть меньше 1.");
            }

            matrixRows = new Vector[rowsSize];

            for (int i = 0; i < rowsSize; i++)
            {
                Vector vector = new Vector(columnsSize);

                for (int j = 0; j < columnsSize; j++)
                {
                    vector.SetComponent(j, array[i, j]);
                }

                matrixRows[i] = vector;
            }
        }

        public Matrix(Vector[] vectors)
        {
            if (vectors.Length == 0)
            {
                throw new ArgumentException("Размерность не может быть меньше 1.");
            }

            int maxSize = 0;

            for (int i = 0; i < vectors.Length; i++)
            {
                if (maxSize < vectors[i].GetSize())
                {
                    maxSize = vectors[i].GetSize();
                }
            }

            matrixRows = new Vector[vectors.Length];

            for (int i = 0; i < vectors.Length; i++)
            {
                Vector vector = new Vector(maxSize);

                for (int j = 0; j < vectors[i].GetSize(); j++)
                {
                    vector.SetComponent(j, vectors[i].GetComponent(j));
                }

                matrixRows[i] = vector;
            }
        }

        public int GetHorizontalSize()
        {
            int rowsSize = matrixRows[0].GetSize();

            return rowsSize;
        }

        public int GetVerticalSize()
        {
            int columnsSize = matrixRows.Length;

            return columnsSize;
        }

        public Vector GetRow(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("Индекс не может быть отрицательным.");
            }

            Vector row = matrixRows[index];

            return row;
        }

        public void SetRow(int index, Vector newValue)
        {
            if (index < 0)
            {
                throw new ArgumentException("Индекс не может быть отрицательным.");
            }

            if (newValue.GetSize() != matrixRows[index].GetSize())
            {
                throw new ArgumentException("Размер вектора не соответствует размеру строк матрицы.");
            }

            matrixRows[index] = newValue;
        }

        public Vector GetColumn(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("Индекс не может быть отрицательным.");
            }

            int size = GetVerticalSize();

            Vector vector = new Vector(size);

            for (int i = 0; i < size; i++)
            {
                vector.SetComponent(i, matrixRows[i].GetComponent(index));
            }

            return vector;
        }

        public void TransposeMatrix()
        {
            int rowsSize = GetHorizontalSize();
            int columnsSize = GetVerticalSize();

            double[,] transposedMatrix = new double[rowsSize, columnsSize];

            for (int i = 0; i < rowsSize; i++)
            {
                for (int j = 0; j < columnsSize; j++)
                {
                    transposedMatrix[i, j] = matrixRows[j].GetComponent(i);
                }
            }

            matrixRows = new Matrix(transposedMatrix).matrixRows;
        }

        public void MultiplyByScalar(double scalar)
        {
            foreach (Vector matrixRow in matrixRows)
            {
                matrixRow.MultiplyByScalar(scalar);
            }
        }

        public double GetDeterminant()
        {
            int rowsSize = matrixRows[0].GetSize();
            int columnsSize = matrixRows.Length;

            if (rowsSize != columnsSize)
            {
                throw new ArgumentException("Матрица должна быть квадратная.");
            }

            if (rowsSize == 1)
            {
                return matrixRows[0].GetComponent(0);
            }

            if (rowsSize == 2)
            {
                return matrixRows[0].GetComponent(0) * matrixRows[1].GetComponent(1) - matrixRows[0].GetComponent(1) * matrixRows[1].GetComponent(0);
            }

            double determinant = 0;

            for (int i = 0; i < columnsSize; i++)
            {
                Matrix newMatrix = new Matrix(rowsSize - 1, columnsSize - 1);

                for (int j = 1; j < rowsSize; j++)
                {
                    for (int k = 0, newIndexY = 0; k < columnsSize; k++, newIndexY++)
                    {
                        if (k == i)
                        {
                            newIndexY--;
                            continue;
                        }

                        newMatrix.matrixRows[j - 1].SetComponent(newIndexY, matrixRows[j].GetComponent(k));
                    }
                }

                if (i % 2 == 0)
                {
                    determinant += matrixRows[0].GetComponent(i) * newMatrix.GetDeterminant();
                }
                else
                {
                    determinant += -matrixRows[0].GetComponent(i) * newMatrix.GetDeterminant();
                }
            }

            return determinant;
        }

        public Vector MultiplyByVector(Vector vector)
        {
            int columnsSize = GetVerticalSize();
            int horizontalSize = GetHorizontalSize();

            if (vector.GetSize() != horizontalSize)
            {
                throw new ArgumentException("Размер вектора не соответвует размеру матрицы.");
            }

            Vector newVector = new Vector(columnsSize);

            double component;

            for (int i = 0; i < columnsSize; i++)
            {
                component = Vector.MultiplyVectors(matrixRows[i], vector);

                newVector.SetComponent(i, component);
            }

            return newVector;
        }

        public void AddMatrix(Matrix matrix)
        {
            if(GetVerticalSize()!=matrix.GetVerticalSize()||GetHorizontalSize()!=matrix.GetHorizontalSize())
            {
                throw new ArgumentException("Размеры матриц не совпадают.");
            }

            int columnsSize = GetVerticalSize();
            int matrixColumnsSize = matrix.GetVerticalSize();

            for (int i = 0; i < Math.Min(columnsSize, matrixColumnsSize); i++)
            {
                matrixRows[i] = Vector.AddVectors(matrixRows[i], matrix.matrixRows[i]);
            }

            if (columnsSize > matrixColumnsSize)
            {
                for (int i = Math.Min(columnsSize, matrixColumnsSize); i < Math.Max(columnsSize, matrixColumnsSize); i++)
                {
                    matrixRows[i].AddVector(matrixRows[i]);
                }
            }
            else
            {
                for (int i = Math.Min(columnsSize, matrixColumnsSize); i < Math.Max(columnsSize, matrixColumnsSize); i++)
                {
                    matrixRows[i].AddVector(matrix.matrixRows[i]);
                }
            }
        }

        public void SubtractMatrix(Matrix matrix)
        {
            if (GetVerticalSize() != matrix.GetVerticalSize() || GetHorizontalSize() != matrix.GetHorizontalSize())
            {
                throw new ArgumentException("Размеры матриц не совпадают.");
            }

            int columnsSize = GetVerticalSize();
            int matrixColumnsSize = matrix.GetVerticalSize();

            for (int i = 0; i < Math.Min(columnsSize, matrixColumnsSize); i++)
            {
                matrixRows[i] = Vector.SubtractVectors(matrixRows[i], matrix.matrixRows[i]);
            }

            if (columnsSize > matrix.GetVerticalSize())
            {
                for (int i = Math.Min(columnsSize, matrixColumnsSize); i < Math.Max(columnsSize, matrixColumnsSize); i++)
                {
                    matrixRows[i].RotateVector();
                    matrixRows[i].SubtractVector(matrixRows[i]);
                }
            }
            else
            {
                for (int i = Math.Min(columnsSize, matrixColumnsSize); i < Math.Max(columnsSize, matrixColumnsSize); i++)
                {
                    matrixRows[i].SubtractVector(matrix.matrixRows[i]);
                }
            }
        }

        public static Matrix AddMatrices(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.GetVerticalSize() != matrix2.GetVerticalSize() || matrix1.GetHorizontalSize() != matrix2.GetHorizontalSize())
            {
                throw new ArgumentException("Размеры матриц не совпадают.");
            }

            Matrix matrixCopy = new Matrix(matrix1);

            matrixCopy.AddMatrix(matrix2);

            return matrixCopy;
        }

        public static Matrix SubtractMatrices(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.GetVerticalSize() != matrix2.GetVerticalSize() || matrix1.GetHorizontalSize() != matrix2.GetHorizontalSize())
            {
                throw new ArgumentException("Размеры матриц не совпадают.");
            }
            Matrix matrixCopy = new Matrix(matrix1);

            matrixCopy.SubtractMatrix(matrix2);

            return matrixCopy;
        }

        public static Matrix MultiplyMatrices(Matrix matrix1, Matrix matrix2)
        {
            int matrix1ColumnsSize = matrix1.GetVerticalSize();
            int matrix2RowsSize = matrix2.GetHorizontalSize();

            if (matrix1ColumnsSize != matrix2RowsSize)
            {
                throw new ArgumentException("Матрицы не согласованы.");
            }

            Matrix newMatrix = new Matrix(matrix1ColumnsSize, matrix2RowsSize);

            for (int i = 0; i < matrix1ColumnsSize; i++)
            {
                for (int j = 0; j < matrix2RowsSize; j++)
                {
                    newMatrix.matrixRows[i].SetComponent(j, Vector.MultiplyVectors(matrix1.GetRow(i), matrix2.GetColumn(j)));
                }
            }

            return newMatrix;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("{ ");

            foreach (Vector vector in matrixRows)
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
