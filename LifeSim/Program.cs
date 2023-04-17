using System;

namespace LifeSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] cellBoolArray = new bool[25, 50];
            string[,] cellShowArray = new string[25, 50];
            int[,] cellNeighborsArray = new int[25, 50];

            Random rand = new Random();
            for (int i = 0; i < cellBoolArray.GetLength(0); i++)
            {
                for (int j = 0; j < cellShowArray.GetLength(1); j++)
                {
                    cellBoolArray[i, j] = rand.Next() % 2 == 0;
                }
            }

            Console.CursorVisible = false;
            while (true)
            {
                // Цикл подсчета соседей
                for (int i = 0; i < cellBoolArray.GetLength(0); i++)
                {
                    for (int j = 0; j < cellShowArray.GetLength(1); j++)
                    {
                        cellNeighborsArray[i, j] = 0;
                        if (i > 0)
                        {
                            if (cellBoolArray[i - 1, j])
                            {
                                cellNeighborsArray[i, j] += 1;
                            }
                            if (j > 0)
                            {
                                if (cellBoolArray[i - 1, j - 1])
                                {
                                    cellNeighborsArray[i, j] += 1;
                                }
                            }
                            if (j < cellBoolArray.GetLength(1) - 1)
                            {
                                if (cellBoolArray[i - 1, j + 1])
                                {
                                    cellNeighborsArray[i, j] += 1;
                                }
                            }

                        }
                        if (i < cellBoolArray.GetLength(0) - 1)
                        {
                            if (cellBoolArray[i + 1, j])
                            {
                                cellNeighborsArray[i, j] += 1;
                            }
                            if (j > 0)
                            {
                                if (cellBoolArray[i + 1, j - 1])
                                {
                                    cellNeighborsArray[i, j] += 1;
                                }
                            }
                            if (j < cellBoolArray.GetLength(1) - 1)
                            {
                                if (cellBoolArray[i + 1, j + 1])
                                {
                                    cellNeighborsArray[i, j] += 1;
                                }
                            }
                        }
                        if (j > 0)
                        {
                            if (cellBoolArray[i, j - 1])
                            {
                                cellNeighborsArray[i, j] += 1;
                            }
                        }
                        if (j < cellBoolArray.GetLength(1) - 1)
                        {
                            if (cellBoolArray[i, j + 1])
                            {
                                cellNeighborsArray[i, j] += 1;
                            }
                        }
                    }

                }

                // Цикл расчета жизни в клетках
                for (int i = 0; i < cellBoolArray.GetLength(0); i++)
                {
                    for (int j = 0; j < cellShowArray.GetLength(1); j++)
                    {
                        if (cellBoolArray[i, j])
                        {
                            if (cellNeighborsArray[i, j] < 2 || cellNeighborsArray[i, j] > 3)
                            {
                                cellBoolArray[i, j] = false;
                            }
                        }
                        else
                        {
                            if (cellNeighborsArray[i, j] == 3)
                            {
                                cellBoolArray[i, j] = true;
                            }
                        }
                        cellShowArray[i, j] = cellBoolArray[i, j] ? "O" : "-";
                        Console.Write($"{cellShowArray[i, j],2}");
                    }
                    Console.WriteLine();
                }
                if (Console.ReadKey().KeyChar == 'q')
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}
