using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint1.Review.V8.Lib;

namespace Tyuiu.IvanchikovDA.Sprint1.Review.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = -1.683;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
