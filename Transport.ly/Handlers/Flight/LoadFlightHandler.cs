using System;
using System.Collections.Generic;
using Transport.ly.Classes;
using Transport.ly.Enums;

namespace Transport.ly.Handlers.Flight
{
    public class LoadFlightHandler
    {
        public List<FlightDto> Execute()
        {
            var flights = new List<FlightDto>();
            var destinations = Enum.GetValues(typeof(DestinationEnum));

            for (int i = 1, j = 1; i <= App.Default.FlightScheduledDays; i++)
            {
                foreach (var destination in destinations)
                {
                    if (Enum.IsDefined(typeof(ScheduledFlightDestinationEnum), destination.ToString()))
                    {
                        var flight = new FlightDto()
                        {
                            FlightNo = j++,
                            Departure = ArrivalEnum.YUL,
                            Arrival = (DestinationEnum)destination,
                            Day = i
                        };

                        flights.Add(flight);
                    }
                }
            }

            return flights;
        }
    }
}