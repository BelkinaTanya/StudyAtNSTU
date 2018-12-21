using System;

namespace OOPLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.5	В двухмерном массиве целых чисел поменять местами столбцы, симметричные относительно середины массива (вертикальной линии)

            var twoDimensionalArray = GetRandomArray(GetRandomValue(), GetRandomValue());
            Console.WriteLine("Первоначальный двумерный массив:");
            MatrixOutput(twoDimensionalArray);
            ColumnChange(twoDimensionalArray);
            Console.WriteLine("Двумерный массив симметричный относительно середины:");
            MatrixOutput(twoDimensionalArray);
            Console.ReadKey();
        }
        private static int GetRandomValue()
        {
            Random randoSize = new Random();
            return randoSize.Next(1, 10);
        }
        private static int[,] GetRandomArray(int rows, int columns)
        {
            var array = new int[rows, columns];
            Random randomArray = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    array[i, j] = randomArray.Next(100);
            return array;
        }
        private static void MatrixOutput(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0,4}", arr[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        private static void ColumnChange(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0, k = arr.GetLength(1) - 1; k > j; j++, k--)
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
        }
    }
}

