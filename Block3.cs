using System;
using System.Collections.Generic;
using System.Text;

namespace Labas_2
{
    class Block3
    {
        public static void doBlock3()
        {
            Console.Clear();
            Console.WriteLine("Enter the number of lines");
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of colunms");
            int colunms = int.Parse(Console.ReadLine());
            Console.Clear();
            int[][] arr = PrintArrays.GenerateJuggedArray(lines, colunms);
            int[][] newArr = new int[arr.Length][];
            PrintArrays.PrintJuggedArray(arr);
            int min = FindMin(arr);
            int count = 0;
            Console.WriteLine("The minimal number is {0}",min);
            for (int i = 0; i < arr.Length; i++)
            {
                if (!NeedToDelete(arr[i], min))
                {
                    newArr[count] = arr[i];
                    count++;
                }
            }
            Array.Resize(ref newArr, count);
            Console.WriteLine("////////////////");
            Console.WriteLine("Here is ur array:");
            PrintArrays.PrintJuggedArray(newArr);

        }

        static bool NeedToDelete(int[] arr, int min)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == min)
                    return true;
            }
            return false;
        }



        static int FindMin(int[][] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < min)
                    {
                        min = arr[i][j];
                    }
                }
            }
            return min;
        }
    }
}
