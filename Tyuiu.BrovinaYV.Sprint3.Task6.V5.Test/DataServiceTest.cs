using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint3.Task6.V5.Lib;

namespace Tyuiu.BrovinaYV.Sprint3.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            int res = ds.GetSumTheDivisors(15, 22);
            Assert.AreEqual(res, 242);
        }
    }
}
