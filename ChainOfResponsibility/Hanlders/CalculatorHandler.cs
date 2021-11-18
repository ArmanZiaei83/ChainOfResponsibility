namespace ChainOfResponsibility.Hanlders
{
    public class CalculatorHandler : Handler
    {
        private Handler _handler;
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        public CalculatorHandler(double firstNumber, double secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public Handler SetNext(Handler handler)
        {
            _handler = handler;
            return handler;
        }

        public virtual object Handle(string request)
        {
            return _handler?.Handle(request);
        }
    }
}