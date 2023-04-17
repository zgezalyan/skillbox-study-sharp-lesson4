using System;

namespace ArrayConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowSize;
            int colSize;
            int matrixASum = 0;
            int matrixBSum = 0;
            int resMatrixSum = 0;

            int[,] matrixA;
            int[,] matrixB;
            int[,] sumOfMatrix;

            Random rand = new Random();

            Console.Write("Введите количество строк: ");
            rowSize = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            colSize = int.Parse(Console.ReadLine());

            matrixA = new int[rowSize, colSize];
            matrixB = new int[rowSize, colSize];
            sumOfMatrix = new int[rowSize, colSize];
            
            Console.WriteLine("Матрица А:");
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    matrixA[i, j] = rand.Next(100);
                    matrixB[i, j] = rand.Next(100);
                    sumOfMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
                    matrixASum += matrixA[i, j];
                    matrixBSum += matrixB[i, j];
                    resMatrixSum += sumOfMatrix[i, j];
                    Console.Write($"{matrixA[i, j],5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов матрицы А: {matrixASum}");
            Console.WriteLine();

            Console.WriteLine("Матрица B:");
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    Console.Write($"{matrixB[i, j],5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов матрицы B: {matrixBSum}");
            Console.WriteLine();

            Console.WriteLine("Сумма матриц А и B:");
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    Console.Write($"{sumOfMatrix[i, j],5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов матрицы: {resMatrixSum}");
            Console.ReadKey();
        }
    }
}
