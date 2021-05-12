using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
   public class CheckStringValidarion
    {
        public string CheckLength(string input)
        {
            if (input.Length <= 1000)
                return input;
            else return "Too long equation, more than 1000 symbols";
        }

        public string DeleteAllWhiteSpaces(string input)
        {
            return String.Join("", input.Where(x => !Char.IsControl(x) && !Char.IsWhiteSpace(x)));
        }

        public string CheckString(string input)
        {
            if (IfStringNullEmptyOrSpace(input))
            {
                return "String is empty";
            }
            else return input;
        }

        private bool IfStringNullEmptyOrSpace(string input)
        {
            return string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input);
        }

        public Tuple<bool, int> CorrectOrder(string str, int i = 0)
        {
            bool hasPair = true;
            if (str[i] == '(')
            {
                hasPair = false;
                return CorrectOrder(str, i++);
            }
            else if (str[i] == ')')
                if (hasPair) hasPair = false;
        }
    }
}
