using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint3.Task2.V14.Lib;

namespace Tyuiu.BrovinaYV.Sprint3.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValidMultiply()
        {
            DataService ds = new DataService();
           
            int value = 5;
            int startValue = 1;
            int stopValue = 6;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 13824.0;
            Assert.AreEqual(wait, res); 
        }
    }
}
