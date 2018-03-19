using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ConsoleCalc!");

            int answer = Calc();
            Console.WriteLine("The answer is: {0}", answer);

            Console.ReadKey();
        }

        private static string GetOpFromUser()
        {
            while (true)
            {
                Console.WriteLine("Enter an Operator (+ - * /): ");
                string opIn = Console.ReadLine();

                if ("+-*/".Contains(opIn))
                {
                    return opIn;
                }
                else
                    Console.WriteLine("Invalid entry, try again...");
            };
        }

        private static int GetValFromUser()
        {
            while (true)
            {
                int res;

                Console.WriteLine("Enter an Integer: ");
                string valIn = Console.ReadLine();

                if (Int32.TryParse(valIn, out res))
                {
                    return res;
                }
                else
                {
                    Console.WriteLine("Must be an integer, try again...");
                }
            }
        }

        private static int Calc()
        {
            int num1 = GetValFromUser();
            int num2 = GetValFromUser();
            string func = GetOpFromUser();

            switch (func)
            {
                case "+":
                    return num1 + num2;

                case "-":
                    return num1 - num2;

                case "*":
                    return num1 * num2;

                case "/":
                    return num1 / num2;

                default:
                    return 0;
            }
        }
    }
}
