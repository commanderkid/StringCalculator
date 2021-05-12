using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public static class Start
    {
        static Start()
        {
            Greeting();
            Checking();
        }

        private static void Greeting()
        {
            Console.WriteLine("Welcome to calculator!");
            Console.WriteLine("Remember, that appropriate symbols and digits are:");
            WriteAppropriateSymbolsAndDigits();
            Console.WriteLine("Please write equation below:");
        }

        private static void WriteAppropriateSymbolsAndDigits()
        {
            for (int i = 0; i < 10; i++) Console.Write($"{i} ");
            foreach (var el in Elements.Signes) Console.Write($"{el} ");
            Console.Write("-\n");
        }

        private 


    }
}
