using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint3.Task1.V7.Lib;

namespace Tyuiu.BrovinaYV.Sprint3.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValidMultiply ()
        {
            DataService ds = new DataService();
            double wait = -0.930;
            double res = ds.GetMultiplySeries(0.25, 1, 9);

            Assert.AreEqual(wait, res, 9);
        }
    }
}
