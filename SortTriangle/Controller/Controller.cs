using System;
using System.Collections.Generic;
using System.Globalization;

namespace SortTriangle
{
    class Controller
    {
        public void PrintMenu()
        {
            View view = new View();
            string answerformenu;
            do
            {
                view.InputFormat();

                List<Model> triangles = new List<Model>();
                string answerforprogram;
                string name;
                double side1, side2, side3;

                do
                {
                    Model triangle;
                    bool state = true;
                    name = "";
                    side1 = 0.0;
                    side2 = 0.0;
                    side3 = 0.0;
                    while (state)
                    {
                        string[] userInput = view.InputUser();
                        name = userInput[0].Trim();
                        try
                        {
                            side1 = double.Parse(userInput[1], CultureInfo.InvariantCulture);
                            side2 = double.Parse(userInput[2], CultureInfo.InvariantCulture);
                            side3 = double.Parse(userInput[3], CultureInfo.InvariantCulture);
                            if (!(side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1))
                            {
                                view.ErrorMessage();
                            }
                            state = false;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    triangle = new Model().WithName(name).WithSide1(side1).WithSide2(side2).WithSide3(side3);
                    triangles.Add(triangle);
                    Console.Write("Want to add a triangle: (y/yes)?");
                    answerforprogram = Console.ReadLine().ToLower();
                } while (answerforprogram == "y" || answerforprogram == "yes");
                Console.WriteLine("\n============= Triangles list: ===============");
                triangles.Sort();
                for (int i = 0; i < triangles.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {triangles[i]}");

                }
                Console.Write("\nDo you want to continue?: (y/yes)?");
                answerformenu = Console.ReadLine().ToLower();
            } while (answerformenu == "y" || answerformenu == "yes");
        }


    }
}
