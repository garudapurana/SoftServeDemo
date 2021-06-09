using System;
namespace LuckyTickets
{
    class Controller
    {
        public void PrintMenu()
        {
            View view = new View();
            uint minTicket = 0, maxTicket = 0;
            bool boool = true;
            while (boool)
            {
                try
                {
                    view.MessageMin();
                    if (!uint.TryParse(view.GetNumber(), out minTicket) || (minTicket == 0 || minTicket > 999999))
                    {
                        view.ErorrMessage();
                        return;

                    }
                    view.MessageMax();
                    if (!uint.TryParse(view.GetNumber(), out maxTicket) || (maxTicket == 0 || maxTicket > 999999))
                    {
                        view.ErorrMessage();
                        return;

                    }
                    if (maxTicket < minTicket)
                    {

                        view.CompareErorr();
                        return;

                    }
                    boool = false;
                }
                catch (Exception ex)
                {
                    view.MessageExaption(ex);
                }
            }

            Model model = new Model().WithMinTicket(minTicket).WithMaxTicket(maxTicket);

            view.CompareMethod(model.Count(model.EasyWay), model.Count(model.HardWay));
        }

    }
}
