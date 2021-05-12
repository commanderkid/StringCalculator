using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public static class CheckPrenthasisValidation
    {
        public static bool CheckValidation(string input)
        {
            int i = 0;
            if(CheckCorrectOrderOfParentheses(input, ref i))
                return true;
            else
            {
                Console.WriteLine("Wrong parenthasis order");
                return false;
            }
        }

        private static bool CheckCorrectOrderOfParentheses(string str, ref int i, bool prevPair = true)
        {
            bool hasPair = prevPair;
            while (i < str.Length)
            {
                if (str[i] == '(')
                {
                    i += 1;
                    hasPair = CheckCorrectOrderOfParentheses(str, ref i, false);
                }
                else if (str[i] == ')')
                {
                    i += 1;
                    if (hasPair && !prevPair) return true;
                    else if (hasPair) return false;
                    else return true;
                }
                else i += 1;
            }
            return prevPair && hasPair;
        }
    }
}
