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
           
            
            double res = ds.GetMultiplySeries(5, 1, 6);
            double wait = 10220.275;
            Assert.AreEqual(wait, res); 
        }
    }
}
