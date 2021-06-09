using System;

namespace SortTriangle
{
    class View
    {
        public void ErrorMessage()
        {
            Console.WriteLine("A triangle with such sides cannot exist \nPlease re-enter");
        }
        public string[] InputUser()
        {
            string[] s = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            return s;
        }
        public string ChoiceMenu()
        {
            string answerformenu;
            Console.Write("\nDo you want to continue?: (y/yes)?");
            answerformenu = Console.ReadLine().ToLower();
            return answerformenu;
        }

        public void PrintHeader()
        {
            Console.WriteLine("\n============= Triangles list: ===============");
        }
        public string ChoiceAdd()
        {
            string answerforprogram;
            Console.Write("Want to add a triangle: (y/yes)?");
            answerforprogram = Console.ReadLine().ToLower();
            return answerforprogram;
        }
        public void InputFormat()
        {
            Console.WriteLine("Input format :Name, SideAB, SideBC, SideAC");
        }
        public void ExceptionMessage(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
