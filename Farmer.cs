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
            Assert.AreEqual(770, calculateResult(230,770000));
        }
        [TestMethod]
        public void TestResult_newWidth_10_finalArea_11()
        {
            Assert.AreEqual(1, calculateResult(10,11)); 
        }
        [TestMethod]
        public void TestResult_newWidth_10_finalArea_24()
        {
            Assert.AreEqual(2, calculateResult(10, 24));
        }

        //refactored method to accept parameters: 
        // finalArea - final Area of the final landplot, 
        // newWidth -   width of the adjacent landplot
        public double calculateResult(double newWidth, double finalArea)
        {
            double result, result1, result2;
            result1 = (-newWidth + Math.Sqrt(newWidth * newWidth - 4 * (-finalArea)))/2;
            result2 = (-newWidth - Math.Sqrt(newWidth * newWidth - 4 * (-finalArea)))/2;
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
