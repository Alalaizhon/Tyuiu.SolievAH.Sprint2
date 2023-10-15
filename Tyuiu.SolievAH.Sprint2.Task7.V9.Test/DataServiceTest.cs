using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint2.Task7.V9.Lib;

namespace Tyuiu.SolievAH.Sprint2.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool ans = ds.CheckDotInShadedArea(0.6, 0.2);
            Assert.AreEqual(true, ans);
        }
    }
}
