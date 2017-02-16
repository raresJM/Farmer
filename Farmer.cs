using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Farmer
{
    [TestClass]
    public class Farmer
    {
        [TestMethod]
        public void TestResult ()
        {
            Assert.AreEqual(565.64, calculateResult());
        }
    }
}
