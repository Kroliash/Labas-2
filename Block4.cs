using System;
using System.Collections.Generic;
using System.Text;

namespace Labas_2
{
    class Block4
    {
        public static void doBlock4()
        {
            Console.Clear();
            Console.WriteLine("Enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = int.Parse(Console.ReadLine());
            Random r = new Random();
            int[][] arr = PrintArrays.GenerateJuggedArray2(50, a, b);
            int count = 0, sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i].Length;
                count++;
                if (Math.Sqrt(sum) % 1 == 0) break;
            }
            Array.Resize(ref arr, count);
            int[] f = new int[sum];
            int point = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    f[point] = arr[i][j];
                    point++;
                }
            }
            Array.Sort(f);
            int[][] q = new int[(int)Math.Sqrt(sum)][];
            point = 0;
            for (int i = 0; i < q.Length; i++)
            {
                q[i] = new int[q.Length];
                for (int j = 0; j < q[i].Length; j++)
                {
                    q[i][j] = f[point];
                    point++;
                }
            }
            Console.WriteLine("Created array:");
            PrintArrays.PrintJuggedArray(arr);
            Console.WriteLine("Array F:");
            PrintArrays.PrintSimpleArray(f);
            Console.WriteLine("Jugged array Q:");
            PrintArrays.PrintJuggedArray(q);
        }
    }
}
