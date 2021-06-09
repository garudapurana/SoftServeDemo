using Fibonacci;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FibonacciTest
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void FibonacciLength1ExpectItemsWithLength1()
        {
            int length = 1;
            Model lenhth = new Model(length);
            List<ulong> expect = new List<ulong>() { 0, 1, 1, 2, 3, 5, 8 };

            List<ulong> actual = lenhth.LengthFibonacci();

            CollectionAssert.AreEqual(actual, expect);
        }
        [TestMethod]
        public void FibonacciLength2ExpectItemsWithLength2()
        {
            int length = 2;
            Model lenhth = new Model(length);
            List<ulong> expect = new List<ulong>() { 13, 21, 34, 55, 89 };

            List<ulong> actual = lenhth.LengthFibonacci();

            CollectionAssert.AreEqual(actual, expect);

        }
        [TestMethod]
        public void FibonacciDiapason0to30()
        {
            ulong startDiapason = 0;
            ulong endDiapason = 30;
            Model diapason = new Model(startDiapason, endDiapason);
            List<ulong> expect = new List<ulong>() {0,1,1,2,3, 5, 8, 13, 21 };

            List<ulong> actual = diapason.DiapasonFibonacci();

            CollectionAssert.AreEqual(actual, expect);
        }
        [TestMethod]
        public void FibonacciDiapason0to1000ItemsNotNull()
        {
            ulong startDiapason = 0;
            ulong endDiapason = 1000;
            Model diapasonNotNull = new Model(startDiapason, endDiapason);


            List<ulong> actual = diapasonNotNull.LengthFibonacci();

            CollectionAssert.AllItemsAreNotNull(actual);
        }
        [TestMethod]
        public void FibonacciLength1ItemsNotNull()
        {
            int length = 1;
            Model lenhth = new Model(length);


            List<ulong> actual = lenhth.LengthFibonacci();
            

            CollectionAssert.AllItemsAreNotNull(actual);
        }
        [TestMethod]
        public void FibonacciLenth0IsEmpty()
        {
            int length = 0;
            Model lenhth = new Model(length);
            List<ulong> expect = new List<ulong>() {};

            List<ulong> actual = lenhth.LengthFibonacci();

            CollectionAssert.AreEqual(actual, expect);
        }


    }
}
