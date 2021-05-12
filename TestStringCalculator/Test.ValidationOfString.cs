using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using StringCalculator;

namespace Test.CheckValidationOfString
{
    [TestFixture]
    public class NullOrEmpty
    {
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase("     ", false)]
        public void InputStringIsNull(string input, bool ans)
        {
            Assert.AreEqual(ans, CheckSymbolsEmptiesLength.CheckIsStringNullEmptyOrSpace(input));
        }

        [Test]
        public void InputStringHasNoWhiteSpaces()
        {
            string ans = DeleteAllWhiteSpaces.DeleteWhiteSpaces(" 1 +\n54 * 3 - (1 -   5)");
            Assert.AreEqual("1+54*3-(1-5)", ans);
        }

        [Test]
        public void InputStringIsTooLong()
        {
            CheckSymbolsEmptiesLength.CheckLength("aaaa");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1001; i++)
                sb.Append('a');
            Assert.AreEqual(false, CheckSymbolsEmptiesLength.CheckLength(sb.ToString()));
        }
        
        [TestCase("1, 2/3(45)", true)]
        [TestCase("1 3 4 5 6 7 8 9 10 + - . , ( )", true)]
        [TestCase("1234567 ^", false)]
        public void InputStringHasApropriateSymbols(string test, bool ans)
        {
            bool answer = CheckSymbolsEmptiesLength.CheckApropriateSymbols(test);
            Assert.AreEqual(ans, answer);
        }

        [TestCase("1+1", true)]
        [TestCase("(-1+2)", true)]
        [TestCase("1 + (2 - 1)", true)]
        [TestCase("(())", true)]
        [TestCase("((()()))", true)]
        [TestCase("(()1", false)]
        [TestCase(")(", false)]
        [TestCase("(())(()", false)]
        [TestCase("((()(", false)]
        [TestCase("()))))", false)]
        [TestCase("(((((", false)]
        public void InputStringHasCorrectParanthasisOrder(string input, bool ans)
        {
            Assert.AreEqual(ans, CheckPrenthasisValidation.CheckValidation(input));
        }

        [TestCase(new[] { "123.0" }, true)]
        [TestCase(new[] {"123,0" }, true)]
        [TestCase(new[] {"12.33.2" }, false)]
        [TestCase(new[] { "1233.2", "123.56.1" }, false)]
        public void InputStringHasCorrectNumbers(string[] el, bool ans)
        {
            Assert.AreEqual(ans, CheckDigits.CheckNumberCorrection(el));
        }
    }
}
