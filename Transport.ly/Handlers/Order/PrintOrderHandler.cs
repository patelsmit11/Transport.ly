using System;
using System.Linq;
using Transport.ly.Contracts;

namespace Transport.ly.Handlers.Order
{
    public class PrintOrderHandler
    {
        public void Execute()
        {
            var flights = new FlightContract().AllocateFlightOrders();
            var orders = new OrderContract().LoadOrders().OrderBy(o => o.Key);

            Console.WriteLine();
            Console.WriteLine("************************* Print Order Details *************************");

            foreach (var order in orders)
            {
                var flight = flights.FirstOrDefault(s => s.Orders.ContainsKey(order.Key));
                if (flight != null)
                {
                    Console.WriteLine($"Order: {order.Key}, FlightNumber: {flight.FlightNo}, Departure: { flight.Departure}, Arrival: {flight.Arrival}, Day: {flight.Day}");
                }
                else
                {
                    Console.WriteLine("order: order-X, flightNumber: not scheduled");
                }
            }
        }
    }
}