using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint3.Task5.V1.Lib;

namespace Tyuiu.BrovinaYV.Sprint3.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(5, 1, 1, 3, 10);
            double wait = 6.3;
            Assert.AreEqual(res, wait);
        }
    }
}
