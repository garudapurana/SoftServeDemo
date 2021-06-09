using AnalysisOfEnveloper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace AnalysisOfEnveloperTest
{
    [TestClass]
    public class CompareEnvelopsTest
    {
        [TestMethod]
        public void CompareEnvelop1LessEnvelop2ExpectMinus1()
        {
            double sideA = 5;
            double sideB = 6;
            double sideC = 7;
            double sideD = 8;
            Model envelop1 = new Model(sideA,sideB);
            Model envelop2 = new Model(sideC,sideD);
            int expected = -1;

            int actual = envelop1.CompareEnvelops(envelop2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CompareEnvelop2LessEnvelop1Expect1()
        {
            double sideA = 8;
            double sideB = 7;
            double sideC = 2;
            double sideD = 3;
            Model envelop1 = new Model(sideA, sideB);
            Model envelop2 = new Model(sideC, sideD);
            int expected = 1;

            int actual = envelop1.CompareEnvelops(envelop2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CompareEnvelop1EqualEnvelop2Expect0()
        {
            double sideA = 2;
            double sideB = 2;
            double sideC = 2;
            double sideD = 2;
            Model envelop1 = new Model(sideA, sideB);
            Model envelop2 = new Model(sideC, sideD);
            int expected = 0;

            int actual = envelop1.CompareEnvelops(envelop2);

            Assert.AreEqual(expected, actual);
        }
    }
}
