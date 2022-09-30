using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{
    interface Entregable
    {
        void Entregar();
        void Devolver();
        bool IsEntregado();
        bool CompareTo(Object a);
    }
}
