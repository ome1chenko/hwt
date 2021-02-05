using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            string mathOperator;
            int result;

            Console.WriteLine("Enter first number:");
            firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator (+ - * /):");
            mathOperator = Console.ReadLine();

            if (mathOperator == "+")
            {
                result = firstNumber + secondNumber;
                Console.WriteLine("Result is: " + result);
            }
            else if (mathOperator == "-")
            {
                result = firstNumber - secondNumber;
                Console.WriteLine("Result is: " + result);
            }
            else if (mathOperator == "*")
            {
                result = firstNumber * secondNumber;
                Console.WriteLine("Result is: " + result);
            }
            else if (mathOperator == "/")
            {
                result = firstNumber / secondNumber;
                Console.WriteLine("Result is: " + result);
            }
        }
    }
}
