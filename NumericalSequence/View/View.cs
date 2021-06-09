using System;

namespace NumericalSequence
{
    class View
    {
        public uint GetRowLength()
        {
            uint rowLength;
            Console.Write("Enter the length of the row: ");
            while (!uint.TryParse(Console.ReadLine(), out rowLength) || (rowLength == 0))
            {
                Console.WriteLine("Incorrect data! Please re-enter: ");
            }
            return rowLength;
        }
        public uint GetMinSquare()
        {
            uint minSquare;
            Console.Write("Enter the value for the minimum square: ");
            while (!uint.TryParse(Console.ReadLine(), out minSquare) || (minSquare == 0))
            {
                Console.WriteLine("Incorrect data! Please re-enter: ");
            }
            return minSquare;
        }
        public void Message()
        {
            Console.WriteLine("Row of numbers: ");
        }

    }
}
