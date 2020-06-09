using System.Collections.Generic;
using Transport.ly.Classes;
using static Transport.ly.Classes.OrderDto;

namespace Transport.ly.ContractInterface
{
    public interface IOrderContract
    {
        Dictionary<string, Order> LoadOrders();
        void PrintOrders();
    }
}
