using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desarrolloSistemas_airline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Flight> heiliFlights = new List<Flight>()
            {
                new Flight("aca", "alla", new DateTime(year: 2023, month: 7, day: 20, hour: 6, minute: 30, second: 0), new DateTime(year: 2023, month: 7, day: 20, hour: 10, minute: 30, second: 0)),
                new Flight("buenos aires", "nunca mas", new DateTime(year: 2023, month: 7, day: 20, hour: 6, minute: 30, second: 0), new DateTime(year: 2023, month: 7, day: 20, hour: 10, minute: 30, second: 0), FlightSize.MEDIUM),
                new Flight("entre rios", "logitech", new DateTime(year: 2023, month: 7, day: 20, hour: 6, minute: 30, second: 0), new DateTime(year: 2023, month: 7, day: 20, hour: 10, minute: 30, second: 0), FlightStatus.CLOSED, FlightSize.BIG),
            };
            Airline airline = new Airline(name: "Areolíneas Heili", flights: heiliFlights);

            List<Ticket> heiliFreeTickets = airline.getAllFreeTickets();
            List<Flight> openFlights = airline.getFlights(FlightStatus.OPEN);
            List<Flight> closedFlights = airline.getFlights(FlightStatus.CLOSED);

            Console.WriteLine($"Pasajes libres de {airline.name}:");
            Console.WriteLine(heiliFreeTickets.Count());
            foreach (Ticket ticket in heiliFreeTickets)
            {
                Console.WriteLine(ticket.id);
            }

            Console.ReadKey();
        }
    }
}
