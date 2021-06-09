using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class View
    {

        public void Print(List<ulong> fibList)
        {
            Console.WriteLine("Fibonacci numbers:");
            foreach (object obj in fibList)
            {
                Console.WriteLine(obj);
            }
        }
        public int GetCommand()
        {
            int chois;
            Console.WriteLine("Fibonacci numbers \n1.Working with diapason \n2.Working with length ");
            while (!int.TryParse(Console.ReadLine(), out chois) || (chois < 1 || chois > 2))
                Console.WriteLine("Fibonacci numbers \n1.Working with diapason \n2.Working with length ");
            return chois;
        }
        public int FibLength()
        {
            int length;
            Console.Write("Enter the length(max 19):");
            while (!int.TryParse(Console.ReadLine(), out length) || (length <= 0 || length > 19))
                Console.WriteLine("Enter positive numbers(max 19):");
            return length;
        }
        public ulong FibStart()
        {
            ulong length;
            Console.Write("Enter start: ");
            while (!ulong.TryParse(Console.ReadLine(), out length))
                Console.WriteLine($"Enter positive numbers:");
            return length;
        }
        public ulong FibEnd()
        {
            ulong length;
            Console.Write("Enter end: ");
            while (!ulong.TryParse(Console.ReadLine(), out length))
                Console.WriteLine("Enter positive numbers:");
            return length;
        }
    }
}
