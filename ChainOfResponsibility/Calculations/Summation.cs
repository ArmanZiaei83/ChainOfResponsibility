using ChainOfResponsibility.Hanlders;

namespace ChainOfResponsibility.Calculations
{
    public class Summation : CalculatorHandler
    {
        public Summation(double firstNumber, double secondNumber) 
            : base(firstNumber, secondNumber)
        {
        }

        public override object Handle(string request)
        {
            if (request == "summation")
                return FirstNumber + SecondNumber;
            return base.Handle(request);
        }
    }
}