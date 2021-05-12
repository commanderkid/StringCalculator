using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public static class Elements
    {

        public static string[] Signes = new[]
        {
            ".", ",", "*", "/", "(", ")", "+", "-"
        };

        public static void Calculate(string element, string action, List<double> ans)
        {
            switch(action)
            {
                case "+":
                    ans.Add(double.Parse(element));
                    break;
                case "*":
                    ans[ans.Count - 1] = ans[ans.Count - 1] * 
                        double.Parse(element);
                    break;
                case "/":
                    ans[ans.Count - 1] = ans[ans.Count - 1] /
                          double.Parse(element);
                    break;
                default:
                    ans.Add(double.Parse(element));
                    break;
            }
        }
    }
}
