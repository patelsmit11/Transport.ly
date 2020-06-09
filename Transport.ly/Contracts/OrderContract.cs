using System.Collections.Generic;
using Transport.ly.Classes;
using Transport.ly.ContractInterface;
using Transport.ly.Handlers.Order;

namespace Transport.ly.Contracts
{
    public class OrderContract : IOrderContract
    {
        public Dictionary<string, OrderDto.Order> LoadOrders()
        {
            return new LoadOrderHandler().Execute();
        }

        public void PrintOrders()
        {
            new PrintOrderHandler().Execute();
        }
    }
}