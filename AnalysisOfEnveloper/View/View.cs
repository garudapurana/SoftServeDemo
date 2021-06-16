using System;

namespace AnalysisOfEnveloper
{
    class View
    {
        public void Message()
        {
            Console.WriteLine("Program for compare envelopers:");
        }

        public void MessageGoodFor2()
        {
            Console.WriteLine("Envelope 2 can fit into envelope 1");
        }

        public void MessageGoodFor1()
        {
            Console.WriteLine("Envelope 1 can fit into envelope 2");
        }

        public void MessageFail()
        {
            Console.WriteLine("Envelopes cannot fit inside each other");
        }


        public double GetSideAofEnvelop1()
        {
            double a;
            Console.Write("Enter side A of the first envelope:");
            while (!double.TryParse(Console.ReadLine(), out a) || (a <= 0))
            {
                Console.WriteLine("Please enter a positive number:");
            }
            return a;
        }
        public double GetSideBofEnvelop1()
        {
            double b;
            Console.Write("Enter side B of the first envelope:");
            while (!double.TryParse(Console.ReadLine(), out b) || (b <= 0))
            {
                Console.WriteLine("Please enter a positive number:");
            }
            return b;
        }
        public double GetSideAofEnvelop2()
        {
            double c;
            Console.Write("Enter side A of the second envelope:");
            while (!double.TryParse(Console.ReadLine(), out c) || (c <= 0))
            {
                Console.WriteLine("Please enter a positive number:");
            }
            return c;
        }
        public double GetSideBofEnvelop2()
        {
            double d;
            Console.Write("Enter side B of the second envelope:");
            while (!double.TryParse(Console.ReadLine(), out d) || (d <= 0))
            {
                Console.WriteLine("Please enter a positive number:");
            }
            return d;
        }

    }
}
