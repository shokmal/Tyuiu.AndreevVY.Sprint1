using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AndreevVY.Sprint1.Task5.V14.Lib;



namespace Tyuiu.AndreevVY.Sprint1.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VaildExpression()
        {
            int k = 12345;
            DataService ds = new DataService();
            int res = ds.Calculate(k);

            int result = Convert.ToInt32(res);

            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}
