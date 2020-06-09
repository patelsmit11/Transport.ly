using System.Collections.Generic;
using Transport.ly.Classes;

namespace Transport.ly.ContractInterface
{
    public interface IFlightContract
    {
        List<FlightDto> LoadFlights();
        List<FlightDto> AllocateFlightOrders();
        void PrintFlights();
    }
}