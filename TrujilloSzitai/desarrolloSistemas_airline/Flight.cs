using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desarrolloSistemas_airline
{
    class Flight
    {
        string _origin = "";
        string _destination = "";
        DateTime _takeOffTime = new DateTime();
        DateTime _landingTime = new DateTime();
        FlightStatus _status = FlightStatus.OPEN;
        List<Ticket> _tickets = new List<Ticket>();

        public string origin => _origin;
        public string destination => _destination;
        public DateTime takeOffTime => _takeOffTime;
        public DateTime landingTime => _landingTime;
        public FlightStatus status => _status;
        public List<Ticket> tickets => _tickets;

        // --- CONSTRUCTORS ---
        public Flight(string origin, string destination, DateTime totime, DateTime ltime, FlightStatus status, List<Ticket> tickets) {
            this._origin = origin;
            this._destination = destination;
            this._takeOffTime = totime;
            this._landingTime = ltime;
            this._status = status;
            this._tickets = tickets;
        }

        public Flight(string origin, string destination, DateTime totime, DateTime ltime, FlightStatus status)
        {
            this._origin = origin;
            this._destination = destination;
            this._takeOffTime = totime;
            this._landingTime = ltime;
            this._status = status;
        }
    }
}
