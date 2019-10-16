using System;
using Vectors;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(5, 7);
            Matrix matrix2 = new Matrix(matrix1);
            Matrix matrix3 = new Matrix(new double[,] { { 5, 6 }, { 3, 2 }, { 5, 6 } });
            Matrix matrix4 = new Matrix(new Vector[] { new Vector(new double[] { 5.6, 6.4 }),
                new Vector(new double[] { 3.7, 6.5, 7.8 }) });
            Matrix matrix5 = new Matrix(matrix4);

            Console.WriteLine("Размер матрицы {0} = {1} на {2}", matrix1, matrix1.GetColumnsCount(), matrix1.GetRowsCount());
            Console.WriteLine();
            Console.WriteLine("Размер матрицы {0} = {1} на {2}", matrix2, matrix2.GetColumnsCount(), matrix2.GetRowsCount());
            Console.WriteLine();
            Console.WriteLine("Размер матрицы {0} = {1} на {2}", matrix3, matrix3.GetColumnsCount(), matrix3.GetRowsCount());
            Console.WriteLine();
            Console.WriteLine("Размер матрицы {0} = {1} на {2}", matrix4, matrix4.GetColumnsCount(), matrix4.GetRowsCount());
            Console.WriteLine();
            Console.WriteLine();

            int index = 1;

            Console.WriteLine("Горизонтальный вектор номер {0} = {1}", index, matrix3.GetRow(index));
            Console.WriteLine();
            matrix3.SetRow(1, new Vector(new double[] { 2, 3 }));
            Console.WriteLine("Теперь горизонтальный вектор номер {0} = {1}", index, matrix3.GetRow(index));
            Console.WriteLine();
            Console.WriteLine("Вертикальный вектор номер {0} = {1}", index, matrix3.GetColumn(index));
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Результат транспонирования матрицы {0} = ", matrix4);
            matrix4.Transpose();
            Console.WriteLine(matrix4);
            Console.WriteLine();

            Console.Write("Результат умножения матрицы {0} на 10 = ", matrix3);
            matrix3.MultiplyByScalar(10);
            Console.WriteLine(matrix3);
            Console.WriteLine();

            Matrix matrix6 = new Matrix(new double[,] { { 5, 6 }, { 3, 2 } });

            Console.WriteLine("Определитель матрицы {0} = {1}", matrix6, matrix6.GetDeterminant());
            Console.WriteLine();

            Vector vector = new Vector(new double[] { -1, -10 });

            Console.Write("Результат умножения матрицы {0} на вектор {1} = {2}", matrix3, vector, matrix3.MultiplyByVector(vector));
            Console.WriteLine();

            Console.Write("Результат сложения матриц {0} и {1} = ", matrix3, matrix4);
            matrix3.AddMatrix(matrix4);
            Console.WriteLine(matrix3);
            Console.WriteLine();

            Console.Write("Разность матриц {0} и {1} = ", matrix3, matrix4);
            matrix3.SubtractMatrix(matrix4);
            Console.WriteLine(matrix3);
            Console.WriteLine();

            Console.WriteLine("Результат сложения матриц {0} и {1} = {2}", matrix4, matrix3, Matrix.AddMatrices(matrix4, matrix3));
            Console.WriteLine();
            Console.WriteLine("Разность матриц {0} и {1} = {2}", matrix4, matrix3, Matrix.SubtractMatrices(matrix4, matrix3));
            Console.WriteLine();
            Console.WriteLine("Результат умножения матриц {0} и {1} = {2}", matrix6, matrix5, Matrix.MultiplyMatrices(matrix6, matrix5));

            Console.ReadKey();
        }
    }
}
