using HomeWork3.Interfaces;

namespace HomeWork3
{
    public class TruckFactory : ITransportFactory
    {
        public ITransport CreateTransport() => new Truck();
    }
}