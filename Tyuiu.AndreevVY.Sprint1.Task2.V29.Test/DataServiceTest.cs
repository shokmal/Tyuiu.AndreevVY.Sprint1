using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AndreevVY.Sprint1.Task2.V29.Lib;

namespace Tyuiu.AndreevVY.Sprint1.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VaildExpression()
        {
            DataService ds = new DataService();
            int x = 60;
            var res = ds.ConvertSecondsToHours(x);
            Assert.AreEqual(1, res);
        }
    }
}
