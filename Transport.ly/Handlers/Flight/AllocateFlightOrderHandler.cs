using System.Collections.Generic;
using System.Linq;
using Transport.ly.Classes;
using Transport.ly.Contracts;

namespace Transport.ly.Handlers.Flight
{
    public class AllocateFlightOrderHandler
    {
        public List<FlightDto> Execute()
        {
            var flights = new FlightContract().LoadFlights();
            var orders = new OrderContract().LoadOrders();

            foreach (var flight in flights)
            {
                flight.Orders = orders
                   .Where(t => t.Value.Destination == flight.Arrival)
                   .Take(App.Default.FlightCapacity)
                   .ToList()
                   .ToDictionary(x => x.Key, x => x.Value);

                flight.Orders.Keys.ToList().ForEach(f =>
                {
                    orders.Remove(f);
                });
            }

            return flights;
        }
    }
}
