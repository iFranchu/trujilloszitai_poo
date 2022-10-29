using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej09
{
    class Pelicula
    {
        string titulo = "";
        short duracion = 0;
        sbyte edadMin = 0;
        string director = "";

        public string Titulo { get { return titulo; } }
        public float Duracion { get { return duracion; } }
        public sbyte EdadMin { get { return edadMin; } }
        public string Director { get { return director; } }

        public Pelicula() { }

        public Pelicula (string title, short runtime, sbyte minAge, string directedBy) {
            titulo = title;
            duracion = runtime;
            edadMin = minAge;
            director = directedBy;
        }
    }
}
