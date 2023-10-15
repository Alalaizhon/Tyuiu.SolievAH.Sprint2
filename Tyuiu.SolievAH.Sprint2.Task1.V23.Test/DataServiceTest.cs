using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint2.Task1.V23.Lib;

namespace Tyuiu.SolievAH.Sprint2.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            bool[] res = new bool[6];
            bool[] wait = new bool[] { false, false, false, true, true, true };

            res = ds.GetLogicOperations(242, 571, 325, 155);

            CollectionAssert.AreEqual(wait, res);
        }
    }
    
}
