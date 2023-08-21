using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desarrolloSistemas_blockbuster
{
    class BranchOffice
    {
        List<Movie> _movies = new List<Movie>();
        List<Loan> _loans = new List<Loan>();
        List<Customer> _customers = new List<Customer>();
        Address _address = new Address();

        public List<Movie> movies => _movies;
        public List<Loan> loans => _loans;
        public List<Customer> customers => _customers;
        public Address address => _address;

        public BranchOffice()
        {

        }

        public BranchOffice(List<Movie> movies, List<Loan> loans, List<Customer> customers, Address address)
        {
            _movies = movies;
            _loans = loans;
            _customers = customers;
            _address = address;
        }

    }
}
