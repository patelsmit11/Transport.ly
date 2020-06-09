using System;
using Transport.ly.Contracts;

namespace Transport.ly
{
    class Program
    {
        static void Main(string[] args)
        {
            new FlightContract().PrintFlights();
            new OrderContract().PrintOrders();

            Console.ReadKey();
        }
    }
}