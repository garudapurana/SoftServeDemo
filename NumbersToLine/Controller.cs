using System;

namespace NumbersToLine
{
    class Controller
    {
        public void PrintMenu()
        {
            View view = new View();
            var number = view.GetNumber();

            Model model = new Model();
            foreach (var s in model.solve(model.splitIntoCategories(number)))
            {
                Console.WriteLine(s);
            }
        }
    }
}
