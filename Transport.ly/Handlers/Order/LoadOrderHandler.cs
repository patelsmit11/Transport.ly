using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Transport.ly.Classes;

namespace Transport.ly.Handlers.Order
{
    public class LoadOrderHandler
    {
        public Dictionary<string, OrderDto.Order> Execute()
        {
            string fileName = "coding-assigment-orders.json";
            return JsonConvert.DeserializeObject<Dictionary<string, OrderDto.Order>>(File.ReadAllText(fileName));
        }
    }
}