using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint3.Task0.V22.Lib;

namespace Tyuiu.BrovinaYV.Sprint3.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double wait = 55217.446;
            double res = ds.GetMultiplySeries(0.25, 1, 8);

            Assert.AreEqual(wait, res, 6);
        }
    }
}
