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
        string _passenger = "";
        public string id => _id;
        public double price => _price;
        public string seat => _seat;
        public string passenger => _passenger;

        // --- CONSTRUCTORS ---
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

        public bool isFree()
        {
            return this._passenger == null;
        }

        public void sell(string passenger)
        {
            this._passenger = passenger;
        }
    }
}
