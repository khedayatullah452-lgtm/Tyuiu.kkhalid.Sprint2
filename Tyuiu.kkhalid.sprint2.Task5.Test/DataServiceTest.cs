using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.kkhalid.sprint2.Task5.V8.Lib;

namespace Tyuiu.kkhalid.sprint2.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Январь", ds.FindDateOfPreviousDay(1, 31)); 
            Assert.AreEqual("Февраль", ds.FindDateOfPreviousDay(2, 28));
            Assert.AreEqual("Март ", ds.FindDateOfPreviousDay(3, 31));
            Assert.AreEqual("Апрель", ds.FindDateOfPreviousDay(4, 30));
            Assert.AreEqual(" Май", ds.FindDateOfPreviousDay(5, 31));  
            Assert.AreEqual(" Июнь", ds.FindDateOfPreviousDay(6, 30));
            Assert.AreEqual(" Июль", ds.FindDateOfPreviousDay(7, 31));
            Assert.AreEqual("Август", ds.FindDateOfPreviousDay(8, 31));
            Assert.AreEqual(" Сентябрь", ds.FindDateOfPreviousDay(9, 30));
            Assert.AreEqual("Октябрь", ds.FindDateOfPreviousDay(10, 31));
            Assert.AreEqual(" Ноябрь", ds.FindDateOfPreviousDay(11, 30));
            Assert.AreEqual(" Декабрь", ds.FindDateOfPreviousDay(12, 31)); 


            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(2,28);

            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(1,31);

            });


        }
    }
}