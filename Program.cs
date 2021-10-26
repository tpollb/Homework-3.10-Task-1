using System;

namespace Homework_3._10_Task_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("x = even");
            } else Console.WriteLine("x = odd");

            Console.ReadKey();
        }
    }
}
