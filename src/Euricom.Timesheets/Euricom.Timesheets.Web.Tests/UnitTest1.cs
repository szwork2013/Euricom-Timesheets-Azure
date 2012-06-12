using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euricom.Timesheets.Web.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var var1 = 1;
            var var2 = 2;
            var sum = 3;
            Assert.AreEqual(sum, var1 + var2);
        }
    }
}
