using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q1;

namespace Q1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Answer a = new Answer();
            var x = a.A();
            Assert.AreEqual(2, x);
        }
    }
}
