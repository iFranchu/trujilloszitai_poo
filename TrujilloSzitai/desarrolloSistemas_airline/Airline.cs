using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desarrolloSistemas_airline
{
    class Airline
    {
        string _name;
        public string name => _name;
        List<Flight> _flights;
        public List<Flight> flights;

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
            if (_flights == null)
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

        public List<Ticket> getFreeTickets()
        {

        }
    }
}
