using System;

namespace NumericalSequence
{
    class Model
    {
        private uint rowLength;

        public Model WithLength(uint length)
        {
            this.rowLength = length;
            return this;
        }

        private uint minSquare;

        public Model WithMinSquare(uint minSquare)
        {
            this.minSquare = minSquare;
            return this;
        }

        public void Sequence()
        {
            for (int i = 0; i < rowLength; i++)
            {
                if (Math.Pow(i, 2) > minSquare)
                    Console.Write(i + ",");
            }
        }
    }
}
