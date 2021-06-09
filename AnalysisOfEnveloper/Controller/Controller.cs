namespace AnalysisOfEnveloper
{
    class Controller
    {
        public void PrintMenu()
        {

            View view = new View();
            view.Message();
            Model envelop1 = new Model(view.GetSideAofEnvelop1(),view.GetSideBofEnvelop1());
            Model envelop2 = new Model(view.GetSideAofEnvelop2(),view.GetSideBofEnvelop2());
            switch (envelop1.CompareEnvelops(envelop2))
            {
                case 1:
                    view.MessageGoodFor2();
                    break;
                case -1:
                    view.MessageGoodFor1();
                    break;
                case 0:
                    view.MessageFail();
                    break;
            }
        }
    }
}
