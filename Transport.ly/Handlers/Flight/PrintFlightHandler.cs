using System;
using System.Linq;
using Transport.ly.Contracts;

namespace Transport.ly.Handlers.Flight
{
    public class PrintFlightHandler
    {
        public void Execute()
        {
            var flights = new FlightContract().LoadFlights();
            Console.WriteLine("************************* Print Flight Details *************************");
            foreach (var flight in flights)
            {
                Console.WriteLine($"Flight: {flight.FlightNo}, Departure: { flight.Departure}, Arrival: {flight.Arrival}, Day: {flight.Day}");
            }
        }
    }
}