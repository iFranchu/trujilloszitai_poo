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
            DateTime toTime1 = new DateTime(year: 2023, month: 7, day: 20, hour: 6, minute: 30, second: 0);
            DateTime lTime1 = new DateTime(year: 2023, month: 7, day: 20, hour: 10, minute: 30, second: 0);
            DateTime toTime2 = new DateTime(year: 2023, month: 8, day: 21, hour: 6, minute: 30, second: 0);
            DateTime lTime2 = new DateTime(year: 2023, month: 8, day: 21, hour: 18, minute: 30, second: 0);
            DateTime toTime3 = new DateTime(year: 2023, month: 9, day: 22, hour: 6, minute: 30, second: 0);
            DateTime lTime3 = new DateTime(year: 2023, month: 9, day: 23, hour: 10, minute: 30, second: 0);

            List<Flight> trujilloFlights = new List<Flight>()
            {
                new Flight("aca", "alla", toTime1, lTime1),
                new Flight("buenos aires", "nunca mas", toTime2, lTime2, FlightSize.MEDIUM),
                new Flight("entre rios", "logitech", toTime3, lTime3, FlightStatus.CLOSED, FlightSize.BIG),
            };
            Airline airline = new Airline(name: "Areolíneas Trujillo", flights: trujilloFlights);
            List<Ticket> ticketsSold = new List<Ticket>();
            Ticket ticketSold1;
            Ticket ticketSold2;
            Ticket ticketSold3;

            List<Ticket> trujilloFreeTickets;
            List<Flight> openFlights;
            List<Flight> closedFlights;

            Console.WriteLine("Vendiendo pasajes...");
            for (int i = 0; i < 30; i++)
            {
                ticketSold1 = airline.SellTicket("aca", "alla", toTime1, lTime1, $"pasajero {i}");
                ticketSold2 = airline.SellTicket("buenos aires", "nunca mas", toTime2, lTime2, $"pasajero {i}");
                ticketSold3 = airline.SellTicket("entre rios", "logitech", toTime3, lTime3, $"pasajero {i}");

                if (ticketSold1 != null) ticketsSold.Add(ticketSold1);
                if (ticketSold2 != null) ticketsSold.Add(ticketSold2);
                if (ticketSold3 != null) ticketsSold.Add(ticketSold3);
            }
            Console.WriteLine("¡Listo! Los pasajes vendidos son:");
            foreach (Ticket ticket in ticketsSold)
            {
                Console.WriteLine(ticket.ToString());
            }

            trujilloFreeTickets = airline.GetAllFreeTickets();
            openFlights = airline.GetFlights(FlightStatus.OPEN);
            closedFlights = airline.GetFlights(FlightStatus.CLOSED);

            Console.WriteLine();
            Console.WriteLine($"Pasajes libres ({trujilloFreeTickets.Count()}) de {airline.name}:");
            foreach (Ticket ticket in trujilloFreeTickets)
            {
                Console.WriteLine(ticket.ToString());
            }

            Console.WriteLine();
            Console.WriteLine($"Estado actual de {airline.name}:");
            Console.WriteLine(airline.ToString());

            Console.WriteLine();
            Console.WriteLine($"Vuelos abiertos de {airline.name}:");
            foreach(Flight flight in openFlights)
            {
                Console.WriteLine(flight.ToString());
            }

            Console.WriteLine();
            Console.WriteLine($"Vuelos cerrados de {airline.name}:");
            foreach (Flight flight in closedFlights)
            {
                Console.WriteLine(flight.ToString());
            }

            Console.ReadKey();
        }
    }
}
