using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public static class CheckDigits
    {
        public static bool CheckNumberCorrection(string[] parsedString)
        {
            double ans;
            foreach (var el in parsedString)
            {
                if (Elements.Signes.Contains(el)) continue;
                else
                {
                    if (!double.TryParse(el, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out ans))
                    {
                        Console.WriteLine($"Can't convert {el} in to number");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
