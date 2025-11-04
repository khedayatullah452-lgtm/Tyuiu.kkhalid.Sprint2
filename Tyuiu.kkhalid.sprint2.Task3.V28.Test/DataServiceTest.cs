using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.kkhalid.sprint2.Task3.V28.Lib;


namespace Tyuiu.kkhalid.sprint2.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {

        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -1.133;
            Assert.AreEqual(res, wait);
        }





        [TestMethod]
        public void ValidCondition2()
        {


            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.000;
            Assert.AreEqual(res, wait);
        }

           
        



    }
}
