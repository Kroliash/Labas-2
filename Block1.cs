using System;
using System.Collections.Generic;
using System.Text;

namespace Labas_2
{
    class Block1
    {
        public static void doBlock1()
        {
            int[] arr = PrintArrays.GenerateSimpleArray(10, 0, 10);
           PrintArrays.PrintArray(arr);
            Console.WriteLine();
            int[] newArr = new int[arr.Length + FindNumber(arr)];
            for (int i = 0, j = 0; i < arr.Length; i++, j++)
            {
                if (arr[i] % 2 == 0)
                {
                    newArr[j] = 1;
                    j++;
                    newArr[j] = arr[i];
                }
                else
                {
                    newArr[j] = arr[i];
                }
            }
            PrintArrays.PrintArray(newArr);
        }

        public static int FindNumber(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    count++;
            }
            return count;
        }
    }
}
