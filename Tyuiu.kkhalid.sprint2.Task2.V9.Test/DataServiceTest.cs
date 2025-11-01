using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.kkhalid.sprint2.Task2.V9.Lib;


namespace Tyuiu.kkhalid.sprint2.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 5;
            bool  res = ds.CheckDotInShadedArea(x, y);
            bool  wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
