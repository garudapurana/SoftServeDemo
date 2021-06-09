using System;

namespace LuckyTickets
{
    class View
    {
        public void MessageMin()
        {
            Console.Write("Enter min ticket number: ");
        }
        public void MessageMax()
        {
            Console.Write("Enter max ticket number: ");
        }
        public string GetNumber()
        {
            return Console.ReadLine();
        }

        public void CompareMethod(uint easy, uint hard)
        {
            if (easy < hard)
            {
                Console.WriteLine("Hard way won");
            }
            else if (easy > hard)
            {
                Console.WriteLine("Easy way won");
            }
            else
            {
                Console.WriteLine("Easy way is equal Hard way");
            }

            Console.WriteLine($"Easy way: {easy}");
            Console.WriteLine($"Hard way: {hard}");
        }
        public void MessageExaption(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        public void ErorrMessage()
        {
            throw new Exception("You can enter numbers from 1 to 999999");
        }
        public void CompareErorr()
        {
            throw new Exception("Max ticket number must be greater than min ticket number!");
        }
    }
}
