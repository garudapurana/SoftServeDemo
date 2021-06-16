using System.Collections.Generic;

namespace Fibonacci
{
    public class Model
    {
        private ulong startDisapason;
        private ulong endDiapason;
        private int lengthOfNumber;

        public Model(ulong startDisapason, ulong endDiapason)
        {
            this.startDisapason = startDisapason;
            this.endDiapason = endDiapason;
        }

        public Model(int lengthOfNumber)
        {
            this.lengthOfNumber = lengthOfNumber;
        }

        public ulong ClassicFibonacci(ulong n)
        {
            ulong x = 1;
            ulong y = 0;
            ulong ans = 0;
            for (ulong i = 2; i <= n; i++)
            {
                ans = x + y;
                x = y;
                y = ans;
            }
            return ans;
        }

        public List<ulong> DiapasonFibonacci()
        {
            List<ulong> fibDiapason = new List<ulong>();
            for (ulong i = 1; i <=endDiapason; i++)
            {
                ulong n = ClassicFibonacci(i);
                if (n >= startDisapason && n <=endDiapason)
                {
                    fibDiapason.Add(n);
                }
            }
            return fibDiapason;
        }

        public List<ulong> LengthFibonacci()
        {
            List<ulong> fibLength = new List<ulong>();
            for (ulong i = 1; ; i++)
            {
                ulong n = ClassicFibonacci(i);
                if (n.ToString().Length == lengthOfNumber)
                {
                    fibLength.Add(n);
                }
                if (n.ToString().Length > lengthOfNumber)
                {
                    break;
                }
            }
            return fibLength;
        }
    }
}
