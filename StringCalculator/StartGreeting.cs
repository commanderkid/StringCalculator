using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public static class StartGreeting
    {
        public static void Greeting()
        {
            Console.Write("Welcome to equation solver!\n\n");
            Console.WriteLine("Please note, that available only this symbols and digits:");
            ShowAvailableSymbols();
        }

        private static void ShowAvailableSymbols()
        {
            for (int i = 0; i < 10; i++)
                Console.Write($"{i} ");
            foreach (var el in Elements.Signes)
                Console.Write($"{el} ");
            Console.WriteLine("\n");
        }
    }
}
