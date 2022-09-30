using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej06
{
    class Libro
    {
        string _ISBN = "";
        string titulo = "";
        string autor = "";
        Int16 paginas = 100;

        public string ISBN { get { return _ISBN; } set { _ISBN = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Autor { get { return autor; } set { autor = value; } }
        public Int16 Paginas { get { return paginas; } set { paginas = value; } }

        public Libro() { }

        public override string ToString()
        {
            return $"El libro {titulo} de código {_ISBN} creado por {autor} tiene {paginas}";
        }
    }
}
