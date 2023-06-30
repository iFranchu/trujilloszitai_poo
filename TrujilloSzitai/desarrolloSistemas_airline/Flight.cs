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
        FlightSize _size = FlightSize.SMALL;
        List<Ticket> _tickets = new List<Ticket>();

        private static Random r = new Random();

        public string origin => _origin;
        public string destination => _destination;
        public DateTime takeOffTime => _takeOffTime;
        public DateTime landingTime => _landingTime;
        public FlightStatus status => _status;
        public List<Ticket> tickets => _tickets;

        // --- CONSTRUCTORS ---
        public Flight()
        {
            assignTickets();
        }
        public Flight(string origin, string destination, DateTime totime, DateTime ltime)
        {
            this._origin = origin;
            this._destination = destination;
            this._takeOffTime = totime;
            this._landingTime = ltime;
            assignTickets();
        }
        public Flight(string origin, string destination, DateTime totime, DateTime ltime, FlightSize size) {
            this._origin = origin;
            this._destination = destination;
            this._takeOffTime = totime;
            this._landingTime = ltime;
            this._size = size;
            assignTickets();
        }
        public Flight(string origin, string destination, DateTime totime, DateTime ltime, FlightStatus status)
        {
            this._origin = origin;
            this._destination = destination;
            this._takeOffTime = totime;
            this._landingTime = ltime;
            this._status = status;
            assignTickets();
        }
        public Flight(string origin, string destination, DateTime totime, DateTime ltime, FlightStatus status, FlightSize size)
        {
            this._origin = origin;
            this._destination = destination;
            this._takeOffTime = totime;
            this._landingTime = ltime;
            this._status = status;
            this._size = size;
            assignTickets();
        }

        // --- METHODS ---
        public List<Ticket> getFreeTickets()
        {
            if(this._status == FlightStatus.OPEN)
            {
                List<Ticket> freeTickets = _tickets.FindAll((e) => e.passenger != null);

                return freeTickets;
            }
            return null;
        }

        public string sellPassage(string passenger)
        {
            if(_status == FlightStatus.OPEN)
            {
                List<Ticket> freeTickets = getFreeTickets();
                Ticket freeTicket = freeTickets[r.Next(maxValue: freeTickets.Count())];

                checkStatus();

                return freeTicket.id;
            }

            return null;
        }

        public void checkStatus()
        {
            byte freeTicketsQuantity = (byte) getFreeTickets().Count();
            if (freeTicketsQuantity == 0 && _status != FlightStatus.CLOSED) _status = FlightStatus.CLOSED;
            else if (freeTicketsQuantity > 0 && _status != FlightStatus.OPEN) _status = FlightStatus.OPEN;
        }

        private void assignTickets()
        {
            sbyte rows, cols;
            if(_size == FlightSize.SMALL)
            {
                rows = 24;
                cols = 3;
            } else if (_size == FlightSize.MEDIUM)
            {
                rows = 48;
                cols = 4;
            } else
            {
                rows = 72;
                cols = 6;
            }

            _tickets = new List<Ticket>(rows*cols);

            for(int i = 1; i <= _tickets.Capacity; i++)
            {
                _tickets[i-1] = new Ticket(seat: i.ToString());
            }
        }


    }
}
