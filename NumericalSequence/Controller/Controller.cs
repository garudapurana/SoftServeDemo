namespace NumericalSequence
{
    class Controller
    {
        public void PrintMenu()
        {
            View view = new View();
            Model sequence = new Model().WithLength(view.GetRowLength()).WithMinSquare(view.GetMinSquare());
            view.Message();
            sequence.Sequence();
        }


    }
}
