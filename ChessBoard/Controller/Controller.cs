using System;

namespace ChessBoard
{
    class Controller
    {
        public void PrintMenu()
        {
            string answerformenu;
            do
            {
                View view = new View();
                Model model = new Model().WithWidth(view.GetWidth()).WithHeight(view.GetHeight());
                model.BuildChess();
                Console.Write("\nDo you want to continue?: (y/yes)?");
                answerformenu = Console.ReadLine().ToLower();
            } while (answerformenu == "y" || answerformenu == "yes");
        }
    }
}
