using System;

namespace Labas_2
{
    class Program
    {
       
      
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Enter 1 to start Block1");
                Console.WriteLine("Enter 2 to start Block2");
                Console.WriteLine("Enter 3 to start Block3");
                Console.WriteLine("Enter 4 to start Block4");
                Console.WriteLine("Enter 0 to finish the program");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Block1.doBlock1();
                        break;
                    case 2:
                        Block2.doBlock2();
                        break;
                    case 3:
                        Block3.doBlock3();
                        break;
                    case 4:
                        Block4.doBlock4();
                        break;
                    case 0:
                        Console.WriteLine("Ok, got it!");
                        break;
                    default:
                        Console.WriteLine("An incorrect choice, try again");
                        break;
                }
            } while (choice != 0);
        }
    }
}