using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        public double n;
        public double m;
        public char symbol;
        public Calculator()
        {
            this.n = n;
            this.m = m;
            this.symbol = symbol;
        }
        public double Calculation()
        {
            double result = 0;

            Console.WriteLine("Enter first number:");
            Double n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter symbol:");
            string symbol = Console.ReadLine();

            Console.WriteLine("Enter second number");
            Double m = int.Parse(Console.ReadLine());

            switch (symbol)
            {
                case "+":
                    result = n + m;
                    break;
                case "-":
                    result = n - m;
                    break;
                case "*":
                    result = n * m;
                    break;
                case "/":
                    result = n / m;
                    break;
                default:
                    Console.WriteLine("Wrong operation");
                    break;
            }
            Console.WriteLine(result);
            return result;





        }
    }
}
