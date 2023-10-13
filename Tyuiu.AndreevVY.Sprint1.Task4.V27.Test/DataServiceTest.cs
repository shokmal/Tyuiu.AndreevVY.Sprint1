using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AndreevVY.Sprint1.Task4.V27.Lib;
namespace Tyuiu.AndreevVY.Sprint1.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VaildExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double wait = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
