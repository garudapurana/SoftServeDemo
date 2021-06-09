using System;

namespace NumbersToLine
{
    class View
    {
        public string GetNumber()
        {
            Console.WriteLine("Введите число:");
            ulong number;
            while (!ulong.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Вводите только положительные числа");
            }
            return number.ToString();
        }
    }
}
