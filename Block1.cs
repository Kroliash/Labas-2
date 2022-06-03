using System;
using System.Collections.Generic;
using System.Text;

namespace Labas_2
{
    class Block1
    {
        public static void doBlock1()
        {
            Console.Clear();
            int[] a;
            int ch;
            Console.WriteLine("Enter 1 to fill array by random");
            Console.WriteLine("Enter 2 to fill array by one raw");
            Console.WriteLine("Enter 0  to finish the Block1");
            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter the number of elements");
                    int n = int.Parse(Console.ReadLine());
                    a = PrintArrays.RandomArray(n);
                    Console.WriteLine("Here is your array");
                    PrintArrays.PrintArray(a);
                    Console.WriteLine();
                    SolveProblem(ref a);
                    Console.WriteLine("Here is your new array");
                    PrintArrays.PrintArray(a);
                    break;
                case 2:
                    a = PrintArrays.InOneRaw();
                    Console.WriteLine();
                    SolveProblem(ref a);
                    Console.WriteLine("Here is your new array");
                    PrintArrays.PrintArray(a);
                    Console.WriteLine();
                    break;
                case 0:
                    Console.WriteLine("Ok, got it");
                    break;
                default:
                    Console.WriteLine("An incorrect choice, try again");
                    break;
            }
            Console.WriteLine();
        }
        static void SolveProblem(ref int[] a)
        {
            int[] newArr1 = new int[a.Length + FindNumber(a)];
            for (int i = 0, j = 0; i < a.Length; i++, j++)
            {
                if (a[i] % 2 == 0)
                {
                    newArr1[j] = 1;
                    j++;
                    newArr1[j] = a[i];
                }
                else
                {
                    newArr1[j] = a[i];
                }
            }

            a = newArr1;
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
