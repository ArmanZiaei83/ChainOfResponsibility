namespace ChainOfResponsibility.Hanlders
{
    public interface Handler
    {
        public Handler SetNext(Handler handler);
        object Handle(string request);
    }
}