using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desarrolloSistemas_airline
{
    class Airline
    {
        string _name = "";
        List<Flight> _flights = new List<Flight>();
        public string name => _name;
        public List<Flight> flights => _flights;

        private static Random r = new Random();

        // --- CONSTRUCTORS ---
        public Airline(string name)
        {
            this._name = name;
        }
        public Airline(string name, List<Flight> flights)
        {
            this._name = name;
            this._flights = flights;
        }

        // --- METHODS ---

        /// <summary>
        /// Returns the list of flights that match the given <c>FlightStatus</c> (Open or Closed)
        /// </summary>
        public List<Flight> GetFlights(FlightStatus status)
        {
            if (_flights != null)
            {
                List<Flight> searchFlights = _flights.FindAll(
                    delegate (Flight e)
                    {
                        return e.status == status;
                    }
                    );
                return searchFlights;
            }
            return null;
        }

        /// <summary>
        /// Returns the list of all the available tickets from all the flights.
        /// </summary>
        /// <returns></returns>
        public List<Ticket> GetAllFreeTickets()
        {
            List<Flight> openFlights = GetFlights(FlightStatus.OPEN);

            if(openFlights.Count() > 0)
            {
                List<Ticket> freeTickets = new List<Ticket>();

                foreach (Flight flight in openFlights)
                {
                    freeTickets.AddRange(flight.GetFreeTickets());
                }

                return freeTickets;
            }

            return null;
        }

        /// <summary>
        /// Assigns a <c>passegner</c> to a random <c>Ticket</c> from the specified <c>Flight</c>.
        /// </summary>
        /// <param name="origin"><c>Flight</c> origin</param>
        /// <param name="destination"><c>Flight</c> destination</param>
        /// <param name="takeOffTime"><c>Flight</c> take off time</param>
        /// <param name="landingTime"><c>Flight</c> landing time</param>
        /// <param name="passengerName">The <c>passenger</c> name</param>
        /// <returns>The <c>Ticket</c> that was assigned to the passenger or <c>null</c> if there are not free tickets left.</returns>
        public Ticket SellTicket(string origin, string destination, DateTime takeOffTime, DateTime landingTime, string passengerName)
        {
            List<Flight> matchFlights = GetFlights(FlightStatus.OPEN).FindAll((e) => (e.origin == origin && e.destination == destination && e.takeOffTime == takeOffTime && e.landingTime == landingTime));

            if(matchFlights.Count() > 0)
            {
                Flight flight = matchFlights[r.Next(matchFlights.Count())];

                Ticket ticketSold = flight.SellTicket(passengerName);

                return ticketSold;
            }

            return null;
        }

        override
        public string ToString()
        {
            return $"Name: {name} - Flights: {flights.Count()} - Open flights: {GetFlights(FlightStatus.OPEN).Count()} - Closed flights: {GetFlights(FlightStatus.CLOSED).Count()}";
        }
    }
}
