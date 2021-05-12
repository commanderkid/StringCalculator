using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public static class Initialise
    {
        public static void Start()
        {
            StartGreeting.Greeting();
            PreStart();
        }

        public static void PreStart()
        {
            Console.WriteLine("Write your equation below");
            ReadLineAndDellWhiteSpaces();
            Console.ReadKey();
        }


        private static void ReStarter()
        {
            Console.Write("Do you wish to enter new equation (y/Y - write) (other key - exit): ");
            while(true)
            {
                char key = Console.ReadKey().KeyChar;
                if (key == 'y' || key == 'Y')
                {
                    Console.WriteLine();
                    PreStart();
                }
                else
                {
                    Console.WriteLine("\nGoodby!");
                }
            }
        }

        private static void ReadLineAndDellWhiteSpaces()
        {
            string WithOutWhiteSpaces = DeleteAllWhiteSpaces.DeleteWhiteSpaces(Console.ReadLine());
            MassChek(WithOutWhiteSpaces);
        }

        private static void MassChek(string input)
        {
            if(!CheckSymbolsEmptiesLength.CheckIsStringNullEmptyOrSpace(input) ||
               !CheckSymbolsEmptiesLength.CheckApropriateSymbols(input)        ||
               !CheckSymbolsEmptiesLength.CheckLength(input)                   ||
               !CheckSymbolsEmptiesLength.CheckSignCorrection(input)           ||
               !CheckPrenthasisValidation.CheckValidation(input))
            {
                ReStarter();
            }
            string[] el = ParseStringByTokens.RetunArrayOfElements(input);
            if(!CheckDigits.CheckNumberCorrection(el))
            {
                ReStarter();
            }
            Ans(el);
        }

        private static void Ans(string[] input)
        {
            int i = 0;
            EquationWalker ew = new EquationWalker();
            double ans = ew.GoThroughEquation(input, ref i, new List<double>());
            Console.WriteLine($"Answer is {Math.Round(ans, 3)}");
            ReStarter();
        }
    }
}
