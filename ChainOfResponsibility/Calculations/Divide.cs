using ChainOfResponsibility.Hanlders;

namespace ChainOfResponsibility.Calculations
{
    public class Divide : CalculatorHandler
    {
        public Divide(double firstNumber, double secondNumber) :
            base(firstNumber, secondNumber)
        {
        }

        public override object Handle(string request)
        {
            if (request == "divide")
                return FirstNumber / SecondNumber;
            return base.Handle(request);
        }
    }
}