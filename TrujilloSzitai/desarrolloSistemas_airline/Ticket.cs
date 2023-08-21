using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desarrolloSistemas_airline
{
    class Ticket
    {
        string _id = "";
        double _price = 0;
        string _seat = "";
        string _passenger = null;

        private static Random r = new Random();

        public string id => _id;
        public double price => _price;
        public string seat => _seat;
        public string passenger => _passenger;

        // --- CONSTRUCTORS ---
        public Ticket(string seat)
        {
            this._id = RandomTicket(6);
            this._seat = seat;
        }
        public Ticket(double price, string seat)
        {
            this._id = RandomTicket(6);
            this._price = price;
            this._seat = seat;
        }
        public Ticket(string id, double price, string seat, string passenger)
        {
            this._id = id;
            this._price = price;
            this._seat = seat;
            this._passenger = passenger;
        }

        public Ticket(string id, double price, string seat)
        {
            this._id = id;
            this._price = price;
            this._seat = seat;
        }

        // --- METHODS ---
        /// <summary>
        /// Returns a bool that indicates if the ticket is free
        /// </summary>
        /// <returns>A bool that indicates if the ticket is free</returns>
        public bool IsFree()
        {
            return this._passenger == null;
        }

        /// <summary>
        /// Assigns a passenger to the specified ticket
        /// </summary>
        /// <param name="passenger">The passenger name</param>
        public void sell(string passenger)
        {
            if(this.IsFree()) this._passenger = passenger;
        }

        /// <summary>
        /// Generates a random alphanumeric ticket id
        /// </summary>
        /// <returns>A random alphanumeric ticket id 6 characters length</returns>
        private static string RandomTicket(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[r.Next(s.Length)]).ToArray());
        }

        override
        public string ToString()
        {
            string passengerToString = passenger == null ? "" : $" - Passenger: {passenger}";
            return $"Ticket {id} - Price: {price} - Seat: {seat} {passengerToString}";
        }
    }
}
