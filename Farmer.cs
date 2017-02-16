using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Farmer
{
    [TestClass]
    public class Farmer
    {
        [TestMethod]
        public void TestResult()
        {
            Assert.AreEqual(565.64, calculateResult());
        }
        public double calculateResult()
        {
            double result, result1, result2 = 0;
            result1 = (-230 + Math.Sqrt(230 * 230 - 4 * 2 * (-770000)))/4;
            result2 = (-230 - Math.Sqrt(230 * 230 - 4 * 2 * (-770000)))/4;

            if (result1 > 0)
            {
                result = Math.Round(result1, 2);
            }
            else if (result2 > 0)
            {
                result = Math.Round(result2, 2);
            }
            else
            {
                Console.WriteLine("result is negative. method will output 0");
                result = 0;
            }
            return result;
        }
    }
}
