using System;
using System.Linq;
using System.Text;
using Vectors;

namespace Matrices
{
    public class Matrix
    {
        private Vector[] rows;

        public Matrix(int width, int height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException(nameof(width), $"и {nameof(height)} не могут быть меньше 1.");
            }

            rows = new Vector[height];

            for (int i = 0; i < height; i++)
            {
                rows[i] = new Vector(width);
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
            int height = array.GetLength(0);
            int width = array.GetLength(1);

            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException(nameof(width), $"и {nameof(height)} не могут быть меньше 1.");
            }

            rows = new Vector[height];

            for (int i = 0; i < height; i++)
            {
                Vector vector = new Vector(width);

                for (int j = 0; j < width; j++)
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
                throw new ArgumentException(nameof(vectors.Length), " не может быть меньше 1.");
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
            if (index < 0 || index > 100000)
            {
                throw new IndexOutOfRangeException("Индекс не может быть отрицательным  или больше 100000.");
            }

            return new Vector(rows[index]);
        }

        public void SetRow(int index, Vector newValue)
        {
            if (index < 0 || index > 100000)
            {
                throw new IndexOutOfRangeException("Индекс не может быть отрицательным  или больше 100000.");
            }

            int vectorSize = newValue.GetSize();

            if (vectorSize != GetColumnsCount())
            {
                throw new ArgumentException($"Размер вектора {nameof(vectorSize)} не соответствует размеру строк матрицы.");
            }

            rows[index] = new Vector(newValue);
        }

        public Vector GetColumn(int index)
        {
            if (index < 0 || index > 100000)
            {
                throw new IndexOutOfRangeException("Индекс не может быть отрицательным  или больше 100000.");
            }

            int size = GetRowsCount();

            Vector vector = new Vector(size);

            for (int i = 0; i < size; i++)
            {
                vector.SetComponent(i, rows[i].GetComponent(index));
            }

            return vector;
        }

        public void TransposeMatrix()
        {
            int width = GetColumnsCount();

            Vector[] transposedMatrix = new Vector[width];

            for (int i = 0; i < width; i++)
            {
                transposedMatrix[i] = new Vector(GetColumn(i));
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
            int width = GetColumnsCount();
            int height = GetRowsCount();

            if (width != height)
            {
                throw new ArgumentException($"{nameof(width)} должно быть равно {nameof(height)}");
            }

            if (width == 1)
            {
                return rows[0].GetComponent(0);
            }

            if (width == 2)
            {
                return rows[0].GetComponent(0) * rows[1].GetComponent(1) - rows[0].GetComponent(1) * rows[1].GetComponent(0);
            }

            double determinant = 0;

            for (int i = 0; i < height; i++)
            {
                Matrix newMatrix = new Matrix(width - 1, height - 1);

                for (int j = 1; j < width; j++)
                {
                    for (int k = 0, newIndexY = 0; k < height; k++, newIndexY++)
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
            int height = GetRowsCount();
            int width = GetColumnsCount();

            int vectorSize = vector.GetSize();

            if (vectorSize != width)
            {
                throw new ArgumentException($"Размер вектора {nameof(vectorSize)} не соответствует размеру строк матрицы.");
            }

            Vector newVector = new Vector(height);

            for (int i = 0; i < height; i++)
            {
                double component = Vector.MultiplyVectors(rows[i], vector);

                newVector.SetComponent(i, component);
            }

            return newVector;
        }

        public void AddMatrix(Matrix matrix)
        {
            int height = GetRowsCount();
            int matrixHeight = matrix.GetRowsCount();
            int width = GetColumnsCount();
            int matrixWidth = matrix.GetColumnsCount();

            if (height != matrixHeight || width != matrixWidth)
            {
                throw new ArgumentException($"Размеры матриц должны быть: {nameof(width)} = {nameof(matrixWidth)}, " +
                    $"{nameof(height)} = {nameof(matrixHeight)}.");
            }

            for (int i = 0; i < GetRowsCount(); i++)
            {
                rows[i].AddVector(matrix.rows[i]);
            }
        }

        public void SubtractMatrix(Matrix matrix)
        {
            int height = GetRowsCount();
            int matrixHeight = matrix.GetRowsCount();
            int width = GetColumnsCount();
            int matrixWidth = matrix.GetColumnsCount();

            if (height != matrixHeight || width != matrixWidth)
            {
                throw new ArgumentException($"Размеры матриц должны быть: {nameof(width)} = {nameof(matrixWidth)}, " +
                    $"{nameof(height)} = {nameof(matrixHeight)}.");
            }

            for (int i = 0; i < GetRowsCount(); i++)
            {
                rows[i].SubtractVector(matrix.rows[i]);
            }
        }

        public static Matrix AddMatrices(Matrix matrix1, Matrix matrix2)
        {
            int matrix1Height = matrix1.GetRowsCount();
            int matrix2Height = matrix2.GetRowsCount();
            int matrix1Width = matrix1.GetColumnsCount();
            int matrix2Width = matrix2.GetColumnsCount();

            if (matrix1Height != matrix2Height || matrix1Width != matrix2Width)
            {
                throw new ArgumentException($"Размеры матриц должны быть: {nameof(matrix1Width)} = {nameof(matrix2Width)}, " +
                    $"{nameof(matrix1Height)} = {nameof(matrix2Height)}.");
            }

            Matrix matrixCopy = new Matrix(matrix1);

            matrixCopy.AddMatrix(matrix2);

            return matrixCopy;
        }

        public static Matrix SubtractMatrices(Matrix matrix1, Matrix matrix2)
        {
            int matrix1Height = matrix1.GetRowsCount();
            int matrix2Height = matrix2.GetRowsCount();
            int matrix1Width = matrix1.GetColumnsCount();
            int matrix2Width = matrix2.GetColumnsCount();

            if (matrix1Height != matrix2Height || matrix1Width != matrix2Width)
            {
                throw new ArgumentException($"Размеры матриц должны быть: {nameof(matrix1Width)} = {nameof(matrix2Width)}, " +
                    $"{nameof(matrix1Height)} = {nameof(matrix2Height)}.");
            }

            Matrix matrixCopy = new Matrix(matrix1);

            matrixCopy.SubtractMatrix(matrix2);

            return matrixCopy;
        }

        public static Matrix MultiplyMatrices(Matrix matrix1, Matrix matrix2)
        {
            int matrix1Width = matrix1.GetColumnsCount();
            int matrix2Height = matrix2.GetRowsCount();

            if (matrix1Width != matrix2Height)
            {
                throw new ArgumentException($"Матрицы не согласованы. {nameof(matrix1Width)} не равен {nameof(matrix2Height)}");
            }

            int matrix1Height = matrix1.GetRowsCount();
            int matrix2Width = matrix2.GetColumnsCount();

            Matrix newMatrix = new Matrix(matrix2Width, matrix1Height);

            for (int i = 0; i < matrix1Height; i++)
            {
                for (int j = 0; j < matrix2Width; j++)
                {
                    newMatrix.rows[i].SetComponent(j, Vector.MultiplyVectors(matrix1.GetRow(i), matrix2.GetColumn(j)));
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

            sb.Remove(sb.Length - 2, 1)
              .Append('}');

            return sb.ToString();
        }
    }
}
