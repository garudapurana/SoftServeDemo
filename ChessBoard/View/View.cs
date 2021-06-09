using System;

namespace ChessBoard
{
    class View
    {
        public uint GetHeight()
        {
            uint height;
            Console.Write($"Enter chess board height (min 1)(max{Console.WindowHeight}):");
            while (!uint.TryParse(Console.ReadLine(), out height) || (height == 0 || height > (uint)Console.WindowHeight))
            {
                Console.WriteLine("Incorrect data! Please re-enter:");
            }
            return height;
        }

        public uint GetWidth()
        {
            uint width;
            Console.Write($"Enter chess board width (min 1)(max{Console.WindowWidth / 2 - 1}):");
            while (!uint.TryParse(Console.ReadLine(), out width) || (width == 0 || width > (uint)Console.WindowWidth / 2 - 1))
            {
                Console.WriteLine("Incorrect data! Please re-enter:");
            }
            return width;
        }
    }
}
