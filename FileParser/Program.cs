using System;

namespace FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("1. <строка для подсчёта>\n2. <строка для поиска> <строка для замены>");

                string path = @"C:\Users\Garuda\source\repos\FileParser\FileParser\text.txt";
                int command = Convert.ToInt32(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        Console.Write("Введите строку для поиска: ");
                        string[] userinputline = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        FileParser fileParser1 = new FileParser().WithPath(path).WithLineForSeach(userinputline[0]);
                        Console.WriteLine($"Число вхождений подстроки {userinputline[0]} = {fileParser1.CountStr()}");
                        break;
                    case 2:
                        Console.Write("Введите строку для поиска и строку для замены: ");
                        string[] userinputlines = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        FileParser fileParser2 = new FileParser().WithPath(path).WithLineForSeach(userinputlines[0]).WithLineForReplace(userinputlines[1]);
                        fileParser2.ReplaceStr();
                        break;
                }
                Console.Write("\nПродолжить ввод(y/yes)?");
                answer = Console.ReadLine().ToLower();
            } while (answer == "y" || answer == "yes");
        }
    }
}
