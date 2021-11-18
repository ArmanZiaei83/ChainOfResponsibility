using ChainOfResponsibility.Hanlders;

namespace ChainOfResponsibility.Calculations
{
    public class Multiply : CalculatorHandler
    {
        public Multiply(double firstNumber, double secondNumber) :
            base(firstNumber, secondNumber)
        {
        }

        public override object Handle(string request)
        {
            if (request == "multiply")
                return FirstNumber * SecondNumber;
            return base.Handle(request);
        }
    }
}