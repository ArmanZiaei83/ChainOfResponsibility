using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using ChainOfResponsibility.Calculations;
using ChainOfResponsibility.Hanlders;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = GetFirstNumber();
            var secondNumber = GetSecondNumber();

            CreateMainMenu();

            var userOperation = Console.ReadLine();

            var calculator = CreateCalculations(firstNumber,
                secondNumber,
                out var summation,
                out var minus,
                out var multiply,
                out var divide);

            calculator
                .SetNext(summation)
                .SetNext(minus)
                .SetNext(multiply)
                .SetNext(divide);

            Print(calculator.Handle(userOperation).ToString());
        }

        private static CalculatorHandler CreateCalculations(double firstNumber,
            double secondNumber, out Summation summation, out Minus minus,
            out Multiply multiply, out Divide divide)
        {
            var calculator = new CalculatorHandler(firstNumber, secondNumber);
            summation = new Summation(firstNumber, secondNumber);
            minus = new Minus(firstNumber, secondNumber);
            multiply = new Multiply(firstNumber, secondNumber);
            divide = new Divide(firstNumber, secondNumber);
            return calculator;
        }

        private static double GetSecondNumber()
        {
            Print("Enter your second number : ");
            var secondNumber = Convert.ToDouble(Console.ReadLine());
            return secondNumber;
        }

        private static double GetFirstNumber()
        {
            Print("Enter your first number : ");
            var firstNumber = Convert.ToDouble(Console.ReadLine());
            return firstNumber;
        }

        private static void CreateMainMenu()
        {
            Print("<< Select An Operation >>");
            Print("\nminus");
            Print("summation");
            Print("divide");
            Print("multiply\n");
        }

        private static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}