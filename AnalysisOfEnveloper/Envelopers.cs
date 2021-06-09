using System;

namespace AnalysisOfEnveloper
{
    class Envelopers
    {
        static void Main(string[] args)
        {
            string answerformenu;
            do
            {
                Controller controller = new Controller();
                controller.PrintMenu();

                Console.Write("\nDo you want to continue?: (y/yes)?");
                answerformenu = Console.ReadLine().ToLower();
            } while (answerformenu == "y" || answerformenu == "yes");

        }
    }
}
