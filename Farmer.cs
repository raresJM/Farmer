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
        [TestMethod]
        public void TestResult_newWidth_10_finalArea_11()
        {
            Assert.AreEqual(11, calculateResult(10,11)); 
        }




        //refactored method to accept parameters: 
        // length - square length, 
        // b -   width of the adjacent landplot
        public double calculateResult(double newWidth, double finalArea)
        {
            double result, result1;
            result1 = (-width + Math.Sqrt(width * width - 4 * 2 * (-770000)))/4;
            result2 = (-width - Math.Sqrt(width * width - 4 * 2 * (-770000)))/4;

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
