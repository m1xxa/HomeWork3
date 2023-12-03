using HomeWork3.Interfaces;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransportFactory truckFactory = new TruckFactory();
            ITransport truck = truckFactory.CreateTransport();
            truck.Delivery();

            ITransportFactory shipFactory = new ShipFactory();
            ITransport ship = shipFactory.CreateTransport();
            ship.Delivery();
        }
    }
}