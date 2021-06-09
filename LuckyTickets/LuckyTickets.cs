using System;

namespace LuckyTickets
{
    class LuckyTickets
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Controller controller = new Controller();
                controller.PrintMenu();
                Console.Write("\nDo you want to continue?: (y/yes)?");
                answer = Console.ReadLine().ToLower();
            } while (answer == "y" || answer == "yes");
        }
    }
}

