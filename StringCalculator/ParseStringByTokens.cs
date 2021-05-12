using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public static class ParseStringByTokens
    {
        private static string[] Signes = Elements.Signes.Where(x => x != "." && x != ",").ToArray();
        public static string[] RetunArrayOfElements(string inputStr)
        {
            foreach (var el in Signes)
            {
                inputStr = inputStr.Replace(el, $" {el} ");
            }
            inputStr = inputStr.Replace("-", " -1 * ");
            inputStr = inputStr.Replace(".", ",");
            return inputStr.Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }
    }
}
