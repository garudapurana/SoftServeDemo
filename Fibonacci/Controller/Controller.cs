using System;

namespace Fibonacci
{
    class Controller
    {
        public void PrintProgram()
        {
            View view = new View();
            int command = view.GetCommand();
            switch (command)
            {
                case 1:
                    Model diapas = new Model(view.FibStart(), view.FibEnd());
                    view.Print(diapas.DiapasonFibonacci());
                    break;
                case 2:
                    Model lenhth = new Model(view.FibLength());
                    view.Print(lenhth.LengthFibonacci());
                    break;
            }
        }
    }
}
