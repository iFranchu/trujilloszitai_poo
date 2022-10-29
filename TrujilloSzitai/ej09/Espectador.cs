using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej09
{
    class Espectador
    {
        string nombre = "";
        string apellido = "";
        sbyte edad = 0;
        double dinero = 0;
        sbyte sala = 0;

        public string Nombre { get { return nombre;  } }
        public string Apellido { get { return apellido; } }
        public sbyte Edad { get { return edad; } }
        public double Dinero { get { return dinero; } }
        public sbyte Sala { get { return sala; } }

        public Espectador() { }

        public Espectador(string name, string surname, sbyte age, double money)
        {
            nombre = name;
            apellido = surname;
            edad = age;
            dinero = money;
        }
    }
}
