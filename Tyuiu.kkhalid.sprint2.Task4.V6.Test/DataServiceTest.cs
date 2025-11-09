using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.kkhalid.sprint2.Task4.V6.Lib;

namespace Tyuiu.kkhalid.sprint2.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 0.007;
            Assert.AreEqual(wait, res);
        }


    }
}
