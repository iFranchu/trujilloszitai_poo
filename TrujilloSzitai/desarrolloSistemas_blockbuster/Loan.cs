using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desarrolloSistemas_blockbuster
{
    class Loan
    {
        Movie _movie = new Movie();
        int _daysLimit = 0;
        Customer _customer = new Customer();
        DateTime _date = new DateTime();

        public Movie movie => _movie;
        public int daysLimit => _daysLimit;
        public DateTime date => _date;

        public Loan()
        {

        }

        public Loan(Movie movie, int daysLimit, Customer customer, DateTime date)
        {
            _movie = movie;
            _daysLimit = daysLimit;
            _customer = customer;
            _date = date;
        }
    }
}
