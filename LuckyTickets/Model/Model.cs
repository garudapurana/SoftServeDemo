using System;

namespace LuckyTickets
{
    class Model
    {

        private uint maxTicket;

        public Model WithMaxTicket(uint max)
        {
            this.maxTicket = max;
            return this;
        }
        private uint minTicket;

        public Model WithMinTicket(uint min)
        {
            this.minTicket = min;
            return this;
        }

        private uint[] GetNumbers(uint num)
        {
            uint[] i = new uint[6];
            i[0] = (num / 100000) % 10;
            i[1] = (num / 10000) % 10;
            i[2] = (num / 1000) % 10;
            i[3] = (num / 100) % 10;
            i[4] = (num / 10) % 10;
            i[5] = num % 10;
            return i;
        }
        public bool EasyWay(uint num)
        {
            uint[] arr = GetNumbers(num);
            return ((arr[0] + arr[1] + arr[2]) == (arr[3] + arr[4] + arr[5]));
        }
        public bool HardWay(uint num)
        {
            uint[] arr = GetNumbers(num);

            return ((arr[0] + arr[2] + arr[4]) == (arr[1] + arr[3] + arr[5]));
        }



        public uint Count(Func<uint, bool> myMethodName)
        {
            uint count = 0;
            for (uint i = minTicket; i <= maxTicket; i++)
            {
                if (myMethodName(i))
                {
                    count++;
                }
            }
            return count;

        }

    }
}
