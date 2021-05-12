using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public static class DeleteAllWhiteSpaces
    {
        public static string DeleteWhiteSpaces(string input)
        {
            return String.Join("", input.Where(x => !Char.IsControl(x) && !Char.IsWhiteSpace(x)));
        }
    }
}
