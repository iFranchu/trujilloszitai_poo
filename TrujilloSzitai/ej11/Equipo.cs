using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
    class Equipo
    {
        string nombre = "";
        double efectividad = 0.5;

        public string Nombre { get { return nombre; } }
        public double Efectividad { get { return efectividad; } }

        public Equipo() { }

        public Equipo(string nombre, double efectividad)
        {
            this.nombre = nombre;
            if(efectividad <= 1.0 && efectividad >= 0.01) this.efectividad = efectividad;
        }
    }
}
