using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringCalculator;

namespace Test.CheckValidationOfString
{
    class TestParsing
    {
        [TestCase("(123)", new[] {"(", "123", ")"})]
        [TestCase("(-1+7)", new[] { "(", "-1", "*", "1", "+", "7", ")" })]
        [TestCase("(123+4)", new[] { "(", "123", "+", "4", ")" })]
        [TestCase("-3*(123+4)/-2.345", new[] { "-1", "*", "3", "*", "(", "123", "+", "4", ")", "/", "-1", "*", "2,345" })]
        [TestCase("(123+4)/2.345", new[] { "(", "123", "+", "4", ")", "/", "2,345" })]
        [TestCase("(123+4)/2.345+(123*(-((23+1)*9.0)-3)-5)", new[] { "(", "123", "+", "4", ")", "/", "2,345", "+", "(", "123", "*", "(", "-1", "*", "(", "(", "23", "+", "1", ")", "*", "9,0", ")", "-1", "*", "3", ")", "-1", "*", "5", ")" })]
        public void CorrectParsing(string test, string[] result)
        {
            var arr = ParseStringByTokens.RetunArrayOfElements(test);
            Assert.AreEqual(result, arr);
        }
    }
}
