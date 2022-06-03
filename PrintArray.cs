using System;
using System.Collections.Generic;
using System.Text;

namespace Labas_2
{
    class PrintArrays
    {
        public static int[][] GenerateJuggedArray2(int rows, int a, int b)
        {
            Random r = new Random();
            int[][] arr = new int[rows][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[r.Next(a, b + 1)];
                arr[i] = GenerateSimpleArray(arr[i], 0, 9);
            }
            return arr;
        }
        static int[] GenerateSimpleArray(int[] arr, int x, int y)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(x, y);
            }
            return arr;
        }
        public static void PrintSimpleArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static void PrintJagArray2(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} : ", i);
                if (arr[i] != null)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write("{0} ", arr[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }
        public static int[] InOneRaw()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int[] oneRawArray = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                oneRawArray[i] = Convert.ToInt32(data[i]);
            }
            return oneRawArray;
        }
        public static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
        public static int[] RandomArray(int n)
        {
            int[] randArray = new int[n];
            Random rand = new Random();
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = rand.Next(-15, 16);
            }
            return randArray;
        }
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

        public static void PrintRecArr(int[,] array)
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
