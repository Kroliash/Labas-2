using System;
using System.Collections.Generic;
using System.Text;

namespace Labas_2
{
    class PrintArrays
    {
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

         public static void PrintJuggedArray(int[][] juggedArray)
        {
            for (int i = 0; i < juggedArray.Length; i++)
            {
                Console.Write($"{i}: ");
                if (juggedArray[i] != null)
                {
                    for (int j = 0; j < juggedArray[i].Length; j++)
                    {
                        Console.Write(juggedArray[i][j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static int[][] GenerateJuggedArray(int rows, int colmns)
        {
            int[][] arr = new int[rows][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[colmns];
                arr[i] = GenerateSimpleArray(colmns, -5, 10);
            }
            return arr;
        }

        public static int[] GenerateSimpleArray(int m, int x, int y)
        {
            Random r = new Random();
            int[] arr = new int[m];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(x, y);
            }
            return arr;
        }
    }
}
