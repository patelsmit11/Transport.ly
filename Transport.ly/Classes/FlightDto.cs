using System.Collections.Generic;
using Transport.ly.Enums;
using static Transport.ly.Classes.OrderDto;

namespace Transport.ly.Classes
{
    public class FlightDto
    {
        public int FlightNo { get; set; }
        public ArrivalEnum Departure { get; set; }
        public DestinationEnum Arrival { get; set; }
        public int Day { get; set; }
        public Dictionary<string, Order> Orders { get; set; }
    }
}