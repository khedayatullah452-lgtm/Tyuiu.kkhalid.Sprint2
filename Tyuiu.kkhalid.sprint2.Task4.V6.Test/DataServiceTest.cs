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
            double x = 30;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 309.375;
            Assert.AreEqual(wait, res);
        }

            [TestMethod]
            public void ValidCondition2()
            {
                DataService ds = new DataService();
                double x =25;
                double y =40 ;
                double res = ds.Calculate(x, y);
                double wait = 2100.240;
                Assert.AreEqual(wait, res);
            }
        

    }
}
