using Newtonsoft.Json;
using System.Collections.Generic;
using Transport.ly.Enums;

namespace Transport.ly.Classes
{
    public class OrderDto
    {
        [JsonProperty("orders")]
        public Dictionary<string, Order> Orders { get; set; }

        public partial class Order
        {
            [JsonProperty("destination")]
            public DestinationEnum Destination { get; set; }
        }
    }
}