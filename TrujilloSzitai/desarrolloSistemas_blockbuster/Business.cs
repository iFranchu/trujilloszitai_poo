using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desarrolloSistemas_blockbuster
{
    class Business
    {
        string _name = "";
        List<BranchOffice> _outlets = new List<BranchOffice>();

        public string name => _name;
        public List<BranchOffice> outlets => _outlets;

        public Business() { }

        public Business(string name, List<BranchOffice> outlets)
        {
            _name = name;
            _outlets = outlets;
        }
    }
}
