using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint3.Task3.V30.Lib;

namespace Tyuiu.BrovinaYV.Sprint3.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            double res = ds.GetMaxCharCount("fyyklbtyn ygrc vfyyyyh", 'y');
            Assert.AreEqual(4, res);
        }
    }
}
