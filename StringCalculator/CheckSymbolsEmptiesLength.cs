using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
   public static class CheckSymbolsEmptiesLength
    {
        public static bool CheckLength(string input)
        {
            if (input.Length <= 1000)
                return true;
            else
            {
                Console.WriteLine("Too long equation, more than 1000 symbols\n");
                return false;
            }
        }

        public static bool CheckIsStringNullEmptyOrSpace(string input)
        {
            if (!(string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input)))
                return true;
            else
            {
                Console.WriteLine("String is empty\n");
                return false;
            }
        }

        public static bool CheckApropriateSymbols(string symbols)
        {
            foreach (var el in symbols)
            {
                if (!(char.IsDigit(el) || char.IsControl(el) || char.IsWhiteSpace(el) ||
                    Elements.Signes.Contains(el.ToString())))
                {
                    Console.WriteLine($"Find wrong symbol: \'{el}\'");
                    return  false;
                }
            }
            return  true;
        }

        public static bool CheckSignCorrection(string str)
        {
            string[] SignesWithOutParanthasis = Elements.Signes.Where(x => x != "(" && x != ")").ToArray();
            if (str.Length == 1 && SignesWithOutParanthasis.Contains(str[0].ToString()))
            {
                Console.WriteLine("Bad equation\n");
                return false;
            }

             for (int i = 1; i < str.Length; i++)
             {
                if
                (
                    (SignesWithOutParanthasis.Contains(str[i - 1].ToString()) && SignesWithOutParanthasis.Contains(str[i].ToString())) ||
                    (str[i - 1].ToString() == "(" && (SignesWithOutParanthasis.Contains(str[i].ToString()) && str[i] != '-'))          ||
                    (str[i - 1].ToString() == "(" && str[i].ToString() == ")")                                                         ||
                    (str[i].ToString() == ")" && SignesWithOutParanthasis.Contains(str[i - 1].ToString()))                             ||
                    ((str[i - 1].ToString() == "." || str[i - 1].ToString() == ",") && str[i].ToString() == "(")                       ||
                    ((str[i].ToString() == "." || str[i].ToString() == ",") && str[i - 1].ToString() == ")")                           ||
                    (SignesWithOutParanthasis.Contains(str[0].ToString()) && str[0] != '-' )                                           ||
                    (SignesWithOutParanthasis.Contains(str[0].ToString()) && (str[1] == '(' || str[1] == ')'))                         ||
                    (SignesWithOutParanthasis.Contains(str[str.Length - 1].ToString()))                                                
                )
                {
                    Console.WriteLine($"Find wrong sign {str[i]} near {str[i - 1]}\n");
                    return false;
                }
             }
             return true;
        }
    }
}
