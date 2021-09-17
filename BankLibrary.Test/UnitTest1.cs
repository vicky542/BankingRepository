using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankLibrary;

namespace BankLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int ExpectedResult = 1000;
            ICalcInterest calcInterest = new CalcInterest();
            int ActualResult = calcInterest.Calculate(10000, 10, 1);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
