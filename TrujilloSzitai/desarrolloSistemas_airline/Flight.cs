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
        public FlightSize size => _size;
        public List<Ticket> tickets => _tickets;

        // --- CONSTRUCTORS ---
        public Flight()
        {
            AssignTickets();
        }
        public Flight(string origin, string destination, DateTime totime, DateTime ltime)
        {
            this._origin = origin;
            this._destination = destination;
            this._takeOffTime = totime;
            this._landingTime = ltime;
            this._tickets = AssignTickets();
        }
        public Flight(string origin, string destination, DateTime totime, DateTime ltime, FlightSize size) {
            this._origin = origin;
            this._destination = destination;
            this._takeOffTime = totime;
            this._landingTime = ltime;
            this._size = size;
            this._tickets = AssignTickets();
        }
        public Flight(string origin, string destination, DateTime totime, DateTime ltime, FlightStatus status)
        {
            this._origin = origin;
            this._destination = destination;
            this._takeOffTime = totime;
            this._landingTime = ltime;
            this._status = status;
            this._tickets = AssignTickets();
        }
        public Flight(string origin, string destination, DateTime totime, DateTime ltime, FlightStatus status, FlightSize size)
        {
            this._origin = origin;
            this._destination = destination;
            this._takeOffTime = totime;
            this._landingTime = ltime;
            this._status = status;
            this._size = size;
            this._tickets = AssignTickets();
        }

        // --- METHODS ---
        /// <summary>
        /// Returns the free <c>Ticket</c>'s <c>List</c> of the specified <c>Flight</c>
        /// </summary>
        /// <returns></returns>
        public List<Ticket> GetFreeTickets()
        {
            if(this._status == FlightStatus.OPEN)
            {
                List<Ticket> freeTickets = _tickets.FindAll((e) => e.passenger == null);

                return freeTickets;
            }
            return null;
        }

        /// <summary>
        /// Receives a passenger name and assigns it to a random free ticket
        /// </summary>
        /// <param name="passenger">Passenger name</param>
        /// <returns>The ticket that was sold/assigned</returns>
        public Ticket SellTicket(string passenger)
        {
            if(_status == FlightStatus.OPEN)
            {
                List<Ticket> freeTickets = GetFreeTickets();
                Ticket freeTicket = freeTickets[r.Next(maxValue: freeTickets.Count())];
                freeTicket.sell(passenger);

                CheckStatus();

                return freeTicket;
            }

            return null;
        }

        /// <summary>
        /// Checks if the flight status matches the free tickets quantity
        /// </summary>
        private void CheckStatus()
        {
            byte freeTicketsQuantity = (byte) GetFreeTickets().Count();
            if (freeTicketsQuantity == 0 && _status != FlightStatus.CLOSED) _status = FlightStatus.CLOSED;
            else if (freeTicketsQuantity > 0 && _status != FlightStatus.OPEN) _status = FlightStatus.OPEN;
        }

        /// <summary>
        /// Generates a <c>List</c> of free <c>Ticket</c>'s based on the <c>FlightSize</c>
        /// </summary>
        /// <returns>A <c>List</c> of free <c>Ticket</c>'s</returns>
        private List<Ticket> AssignTickets()
        {
            sbyte rows, cols;
            List<Ticket> tickets = new List<Ticket>();
            double price = CalculatePrice(_takeOffTime, _landingTime);

            if (_size == FlightSize.SMALL)
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

            int seats = rows*cols;

            for(int i = 1; i <= seats; i++)
            {
                tickets.Add(new Ticket(price: price, seat: i.ToString()));
            }

            return tickets;
        }

        /// <summary>
        /// Calculates the price of the average ticket based on the given take off time and landing time
        /// </summary>
        /// <param name="toTime">Take off time</param>
        /// <param name="lTime">Landing time</param>
        /// <returns>The price of an average ticket</returns>
        private double CalculatePrice(DateTime toTime, DateTime lTime)
        {
            return (lTime - toTime).TotalHours * 1000;
        }

        override
        public string ToString()
        {
            string ticketsDisplay;
            if (GetFreeTickets() == null) ticketsDisplay = "ALL TICKETS WERE SOLD";
            else if (GetFreeTickets().Count() == tickets.Count()) ticketsDisplay = $"All tickets ({tickets.Count()}) are free";
            else ticketsDisplay = $"Tickets sold: {tickets.Count() - GetFreeTickets().Count()} - Available tickets: {GetFreeTickets().Count()}";

            return $"Origin: {origin} - Destination: {destination} - Take off time: {takeOffTime.ToString()} - Landing Time: {landingTime.ToString()} - Status: {status.ToString()} - Size: {size.ToString()} - {ticketsDisplay}";
        }
    }
}
