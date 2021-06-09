namespace AnalysisOfEnveloper
{
    public class Model
    {
        private double sideA;
        private double sideB;
        public Model(double sideA, double sideB) 
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        public int CompareEnvelops(Model envelop)
        {
            if ((sideA > envelop.sideA && sideB > envelop.sideB) || (sideA > envelop.sideB && sideB > envelop.sideA))
                return 1;
            else if ((sideA < envelop.sideA && sideB < envelop.sideB) || (sideA < envelop.sideB && sideB < envelop.sideA))
                return -1;
            else
                return 0;
        }
    }
}
