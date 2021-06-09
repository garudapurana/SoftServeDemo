using System;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Controller controller = new Controller();
                controller.PrintProgram();
                Console.Write("\n\nDo you want to continue?: (y/yes)?");
                answer = Console.ReadLine().ToLower();
            } while (answer == "y" || answer == "yes");
        }
    }
}
