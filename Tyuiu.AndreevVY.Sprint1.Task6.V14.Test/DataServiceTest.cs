using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AndreevVY.Sprint1.Task6.V14.Lib;

namespace Tyuiu.AndreevVY.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VaildString()
        {
            string strTest = "приветWorld";
            DataService ds = new DataService();
            string res = ds.CheckLowerCaseRusLetters(strTest);
            string wait = "привет";
            Assert.AreEqual(wait, res);
        }
    }
}
