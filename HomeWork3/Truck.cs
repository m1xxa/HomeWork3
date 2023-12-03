using System;
using HomeWork3.Interfaces;

namespace HomeWork3
{
    public class Truck : ITransport
    {
        public void Delivery()
        {
            Console.WriteLine($"{nameof(Truck)} delivery is in progress");
        }
    }
}