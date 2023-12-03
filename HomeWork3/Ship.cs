using System;
using HomeWork3.Interfaces;

namespace HomeWork3
{
    public class Ship : ITransport
    {
        public void Delivery()
        {
            Console.WriteLine($"{nameof(Ship)} delivery is in progress");
        }
    }
}