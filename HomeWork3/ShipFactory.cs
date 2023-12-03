using HomeWork3.Interfaces;

namespace HomeWork3
{
    public class ShipFactory : ITransportFactory
    {
        public ITransport CreateTransport() => new Ship();
    }
}