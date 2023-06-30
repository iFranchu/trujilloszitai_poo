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
        public List<Flight> getFlights(FlightStatus status)
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

        public List<Ticket> getAllFreeTickets()
        {
            List<Flight> openFlights = getFlights(FlightStatus.OPEN);

            if(openFlights.Count() > 0)
            {
                List<Ticket> freeTickets = new List<Ticket>();

                foreach (Flight flight in openFlights)
                {
                    freeTickets.AddRange(flight.getFreeTickets());
                }

                return freeTickets;
            }

            return null;
        }

        public string sellPassage(string origin, string destination, DateTime takeOffTime, DateTime landingTime, string passengerName)
        {
            List<Flight> matchFlights = getFlights(FlightStatus.OPEN).FindAll((e) => (e.origin == origin && e.destination == destination && e.takeOffTime == takeOffTime && e.landingTime == landingTime));

            if(matchFlights.Count() > 0)
            {
                Flight flight = matchFlights[r.Next(matchFlights.Count())];

                string seatId = flight.sellPassage(passengerName);

                return seatId;
            }

            return null;
        }
    }
}
