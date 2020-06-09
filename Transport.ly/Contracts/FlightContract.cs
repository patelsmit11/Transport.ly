using System.Collections.Generic;
using Transport.ly.Classes;
using Transport.ly.ContractInterface;
using Transport.ly.Handlers.Flight;

namespace Transport.ly.Contracts
{
    public class FlightContract : IFlightContract
    {
        public List<FlightDto> AllocateFlightOrders()
        {
            return new AllocateFlightOrderHandler().Execute();
        }

        public List<FlightDto> LoadFlights()
        {
            return new LoadFlightHandler().Execute();
        }

        public void PrintFlights()
        {
            new PrintFlightHandler().Execute();
        }
    }
}