using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desarrolloSistemas_blockbuster
{
    class Customer
    {
        string _id = "";
        string _firstName = "";
        string _lastName = "";
        Address _address = new Address();

        public string id => _id;
        public string firstName => _firstName;
        public string lastName => _lastName;
        public Address address => _address;

        public Customer()
        {

        }

        public Customer(string id, string firstName, string lastName, Address address)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
        }
    }
}
