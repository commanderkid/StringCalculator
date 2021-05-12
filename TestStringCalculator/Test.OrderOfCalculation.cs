using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringCalculator;

namespace Test.CheckValidationOfString
{
    class TestOrderOfCalculation
    {
        [TestCase(new[] { "(", "1", ")" }, 1)]
        [TestCase(new[] { "1" }, 1)]
        [TestCase(new[] { "10", "*", "(", "2", "+", "3", ")" }, 50)]
        [TestCase(new[] { "(", "2", "+", "3", ")", "*", "10" }, 50)]
        [TestCase(new[] { "1", "+", "4" }, 5)]
        [TestCase(new[] { "(", "2", "+", "(", "6" ,"-3", ")", "/", "3", ")", "*", "10" }, 30)]
        public static void TestCalculation(string[] test, double answer)
        {
            EquationWalker eq = new EquationWalker();
            int i = 0;
            double ans = eq.GoThroughEquation(test, ref i, new List<double>());
            Assert.AreEqual(answer, ans);
        }
    }
}
