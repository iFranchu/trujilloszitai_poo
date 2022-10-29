using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej09
{
    class Cine
    {
        List<Sala> salas = new List<Sala>();

        public List<Sala> Salas { get { return salas; } set { salas = value; } }

        public Cine() { }
    }
}
