using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class EquationWalker
    {
        public double GoThroughEquation(string[] ans, ref int i, List<double> numbs)
        {
            string[] SignesOnly = Elements.Signes.Where(x => x != "(" && x != ")" && x != "." && x != ",").ToArray();
            string action = null;
            while (i < ans.Length)
            {
                if (!Elements.Signes.Contains(ans[i]))
                {
                    Elements.Calculate(ans[i], action, numbs);
                    action = null;
                    i += 1;
                }
                else if (SignesOnly.Contains(ans[i]))
                {
                    action = ans[i];
                    i += 1;
                }
                else if (ans[i] == ")")
                {
                    i += 1;
                    return SummArray(numbs);
                }
                else if (ans[i] == "(")
                {
                    i += 1;
                    var elem = GoThroughEquation(ans, ref i, new List<double>());
                    Elements.Calculate(elem.ToString(), action, numbs);
                }
            }
            return SummArray(numbs);
        }

        private double SummArray(List<double> arr)
        {
            double ans = 0;
            foreach(var el in arr) ans += el;
            return ans;
        }

    }
}
