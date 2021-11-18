using System.Net.Http;
using ChainOfResponsibility.Hanlders;

namespace ChainOfResponsibility.Calculations
{
    public class Minus : CalculatorHandler
    {
        public Minus(double firstNumber, double secondNumber) :
            base(firstNumber, secondNumber)
        {
        }

        public override object Handle(string request)
        {
            if (request == "minus")
                return FirstNumber - SecondNumber;
            return base.Handle(request);
        }
    }
}