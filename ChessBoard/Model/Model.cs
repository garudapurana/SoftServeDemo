using System;

namespace ChessBoard
{
    class Model
    {
        private uint width;
        private uint height;
        public Model WithWidth(uint width)
        {
            this.width = width;
            return this;
        }
        public Model WithHeight(uint height)
        {
            this.height = height;
            return this;
        }

        public void BuildChess()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("  ");
                        }
                        else
                        {
                            if (j == 1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" *");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
