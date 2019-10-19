using System;
using System.Text;
using Vectors;

namespace Matrices
{
    public class Matrix
    {
        private Vector[] rows;

        public Matrix(int columnsCount, int rowsCount)
        {
            if (columnsCount <= 0)
            {
                throw new ArgumentException($"{nameof(columnsCount)} не может быть меньше 1.", nameof(columnsCount));
            }

            if (rowsCount <= 0)
            {
                throw new ArgumentException($"{nameof(rowsCount)} не может быть меньше 1.", nameof(rowsCount));
            }

            rows = new Vector[rowsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                rows[i] = new Vector(columnsCount);
            }
        }

        public Matrix(Matrix matrix)
        {
            rows = new Vector[matrix.GetRowsCount()];

            for (int i = 0; i < matrix.GetRowsCount(); i++)
            {
                rows[i] = new Vector(matrix.rows[i]);
            }
        }

        public Matrix(double[,] array)
        {
            int rowsCount = array.GetLength(0);
            int columnsCount = array.GetLength(1);

            if (columnsCount <= 0 || rowsCount <= 0)
            {
                throw new ArgumentException($"Размеры {nameof(array)} не могут быть меньше 1.", nameof(array));
            }

            rows = new Vector[rowsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                Vector vector = new Vector(columnsCount);

                for (int j = 0; j < columnsCount; j++)
                {
                    vector.SetComponent(j, array[i, j]);
                }

                rows[i] = vector;
            }
        }

        public Matrix(Vector[] vectors)
        {
            if (vectors.Length == 0)
            {
                throw new ArgumentException($"Длина {nameof(vectors)} не может быть меньше 1.", nameof(vectors));
            }

            int maxSize = 0;

            foreach (Vector vector in vectors)
            {
                if (maxSize < vector.GetSize())
                {
                    maxSize = vector.GetSize();
                }
            }

            rows = new Vector[vectors.Length];

            for (int i = 0; i < vectors.Length; i++)
            {
                Vector vector = new Vector(maxSize);

                vector.AddVector(vectors[i]);

                rows[i] = vector;
            }
        }

        public int GetColumnsCount() => rows[0].GetSize();

        public int GetRowsCount() => rows.Length;

        public Vector GetRow(int index)
        {
            if (index < 0 || index >= GetRowsCount())
            {
                throw new IndexOutOfRangeException("Индекс не может быть отрицательным  или больше / равным количеству строк матрицы.");
            }

            return new Vector(rows[index]);
        }

        public void SetRow(int index, Vector newValue)
        {
            if (index < 0 || index >= GetRowsCount())
            {
                throw new IndexOutOfRangeException("Индекс не может быть отрицательным  или больше / равным количеству строк матрицы.");
            }

            int vectorSize = newValue.GetSize();

            if (vectorSize != GetColumnsCount())
            {
                throw new ArgumentException($"Размер вектора {nameof(newValue)} не соответствует размеру строк матрицы.", nameof(newValue));
            }

            rows[index] = new Vector(newValue);
        }

        public Vector GetColumn(int index)
        {
            if (index < 0 || index >= GetColumnsCount())
            {
                throw new IndexOutOfRangeException("Индекс не может быть отрицательным  или больше / равным количеству столбцов матрицы.");
            }

            int size = GetRowsCount();

            Vector vector = new Vector(size);

            for (int i = 0; i < size; i++)
            {
                vector.SetComponent(i, rows[i].GetComponent(index));
            }

            return vector;
        }

        public void Transpose()
        {
            int columnsCount = GetColumnsCount();

            Vector[] transposedMatrix = new Vector[columnsCount];

            for (int i = 0; i < columnsCount; i++)
            {
                transposedMatrix[i] = GetColumn(i);
            }

            rows = transposedMatrix;
        }

        public void MultiplyByScalar(double scalar)
        {
            foreach (Vector matrixRow in rows)
            {
                matrixRow.MultiplyByScalar(scalar);
            }
        }

        public double GetDeterminant()
        {
            int columnsCount = GetColumnsCount();
            int rowsCount = GetRowsCount();

            if (columnsCount != rowsCount)
            {
                throw new InvalidOperationException("Матрица должна быть квадратная.");
            }

            if (columnsCount == 1)
            {
                return rows[0].GetComponent(0);
            }

            if (columnsCount == 2)
            {
                return rows[0].GetComponent(0) * rows[1].GetComponent(1) - rows[0].GetComponent(1) * rows[1].GetComponent(0);
            }

            double determinant = 0;

            for (int i = 0; i < rowsCount; i++)
            {
                Matrix newMatrix = new Matrix(columnsCount - 1, rowsCount - 1);

                for (int j = 1; j < columnsCount; j++)
                {
                    for (int k = 0, newIndexY = 0; k < rowsCount; k++, newIndexY++)
                    {
                        if (k == i)
                        {
                            newIndexY--;
                            continue;
                        }

                        newMatrix.rows[j - 1].SetComponent(newIndexY, rows[j].GetComponent(k));
                    }
                }

                if (i % 2 == 0)
                {
                    determinant += rows[0].GetComponent(i) * newMatrix.GetDeterminant();
                }
                else
                {
                    determinant += -rows[0].GetComponent(i) * newMatrix.GetDeterminant();
                }
            }

            return determinant;
        }

        public Vector MultiplyByVector(Vector vector)
        {
            int rowsCount = GetRowsCount();
            int columnsCount = GetColumnsCount();

            int vectorSize = vector.GetSize();

            if (vectorSize != columnsCount)
            {
                throw new ArgumentException($"Размер вектора {nameof(vector)} не соответствует размеру строк матрицы.", nameof(vector));
            }

            Vector newVector = new Vector(rowsCount);

            for (int i = 0; i < rowsCount; i++)
            {
                double component = Vector.MultiplyVectors(rows[i], vector);

                newVector.SetComponent(i, component);
            }

            return newVector;
        }

        public void AddMatrix(Matrix matrix)
        {
            int rowsCount = GetRowsCount();
            int matrixRowsCount = matrix.GetRowsCount();
            int columnsCount = GetColumnsCount();
            int matrixColumnsCount = matrix.GetColumnsCount();

            if (rowsCount != matrixRowsCount || columnsCount != matrixColumnsCount)
            {
                throw new ArgumentException($"Размер матрицы {nameof(matrix)} не подходящий.", nameof(matrix));
            }

            for (int i = 0; i < GetRowsCount(); i++)
            {
                rows[i].AddVector(matrix.rows[i]);
            }
        }

        public void SubtractMatrix(Matrix matrix)
        {
            int rowsCount = GetRowsCount();
            int matrixRowsCount = matrix.GetRowsCount();
            int columnsCount = GetColumnsCount();
            int matrixColumnsCount = matrix.GetColumnsCount();

            if (rowsCount != matrixRowsCount || columnsCount != matrixColumnsCount)
            {
                throw new ArgumentException($"Размер матрицы {nameof(matrix)} не подходящий.", nameof(matrix));
            }

            for (int i = 0; i < GetRowsCount(); i++)
            {
                rows[i].SubtractVector(matrix.rows[i]);
            }
        }

        public static Matrix AddMatrices(Matrix matrix1, Matrix matrix2)
        {
            int matrix1RowsCount = matrix1.GetRowsCount();
            int matrix2RowsCount = matrix2.GetRowsCount();
            int matrix1ColumnsCount = matrix1.GetColumnsCount();
            int matrix2ColumnsCount = matrix2.GetColumnsCount();

            if (matrix1RowsCount != matrix2RowsCount || matrix1ColumnsCount != matrix2ColumnsCount)
            {
                throw new ArgumentException($"Размер матрицы {nameof(matrix1)} не равен размеру матрицы {nameof(matrix2)}.", nameof(matrix2));
            }

            Matrix matrixCopy = new Matrix(matrix1);

            matrixCopy.AddMatrix(matrix2);

            return matrixCopy;
        }

        public static Matrix SubtractMatrices(Matrix matrix1, Matrix matrix2)
        {
            int matrix1RowsCount = matrix1.GetRowsCount();
            int matrix2RowsCount = matrix2.GetRowsCount();
            int matrix1ColumnsCount = matrix1.GetColumnsCount();
            int matrix2ColumnsCount = matrix2.GetColumnsCount();

            if (matrix1RowsCount != matrix2RowsCount || matrix1ColumnsCount != matrix2ColumnsCount)
            {
                throw new ArgumentException($"Размер матрицы {nameof(matrix1)} не равен размеру матрицы {nameof(matrix2)}.", nameof(matrix2));
            }

            Matrix matrixCopy = new Matrix(matrix1);

            matrixCopy.SubtractMatrix(matrix2);

            return matrixCopy;
        }

        public static Matrix MultiplyMatrices(Matrix matrix1, Matrix matrix2)
        {
            int matrix1ColumnsCount = matrix1.GetColumnsCount();
            int matrix2RowsCount = matrix2.GetRowsCount();

            if (matrix1ColumnsCount != matrix2RowsCount)
            {
                throw new ArgumentException($"Матрицы {nameof(matrix1)} и {nameof(matrix2)} не согласованы.", nameof(matrix2));
            }

            int matrix1RowsCount = matrix1.GetRowsCount();
            int matrix2ColumnsCount = matrix2.GetColumnsCount();

            Matrix newMatrix = new Matrix(matrix2ColumnsCount, matrix1RowsCount);

            for (int i = 0; i < matrix1RowsCount; i++)
            {
                for (int j = 0; j < matrix2ColumnsCount; j++)
                {
                    newMatrix.rows[i].SetComponent(j, Vector.MultiplyVectors(matrix1.rows[i], matrix2.GetColumn(j)));
                }
            }

            return newMatrix;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("{ ");

            foreach (Vector vector in rows)
            {
                sb.Append(vector)
                    .Append(", ");
            }

            sb.Append('}');

            return sb.ToString();
        }
    }
}