using System;

namespace Labas_2
{
    class Program
    {
       
      
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Block1.doBlock1();
           
            if (a == 2)
            {
                int[][] arr = GenerateJuggedArray(4, 4);
                int[][] newArr = new int[arr.Length][];
                PrintJuggedArray(arr);
                int min = FindMin(arr);
                int count = 0;
                Console.WriteLine(min);
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
                PrintJuggedArray(newArr);
            }
        

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