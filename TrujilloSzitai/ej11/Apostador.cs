using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
    class Apostador : ApuestaMinima
    {
        string nombre;
        double dinero;
        sbyte golesLocal;
        sbyte golesVisitante;
        sbyte diferenciaGoles;
        double dineroApostado;
        GeneradorNombres nombreRandom = new GeneradorNombres();
        static Random r = new Random();

        public string Nombre { get { return nombre; } }
        public sbyte GolesL { get { return golesLocal; } }
        public sbyte GolesV { get { return golesVisitante; } }
        public sbyte DiferenciaGoles { get { return diferenciaGoles; } }
        public double Dinero{ get { return dinero; } }
        public double DineroApostado { get { return dineroApostado; } }

        public Apostador()
        {
            golesLocal = (sbyte)r.Next(0, 11);
            golesVisitante = (sbyte)r.Next(0, 11);
            diferenciaGoles = (sbyte) (golesLocal - golesVisitante);
            nombre = nombreRandom.GenerarNombre();
            dinero = r.Next(500, 50000) - dineroApostado;
            Apostar(r.Next((int)ApuestaMin, (int)dinero + 1));
        }

        public Apostador(string nombre, int dinero, sbyte golesL, sbyte golesV, int dineroApostado)
        {
            this.nombre = nombre;
            this.dinero = dinero >= 500 ? dinero : 500;
            Apostar(dineroApostado);
            this.golesLocal = golesL;
            this.golesVisitante = golesV;
            diferenciaGoles = (sbyte)(golesLocal - golesVisitante);
        }

        public bool Apostar(double din)
        {
            if (din > dinero || din < ApuestaMin) return false;
            dineroApostado = din;
            dinero -= dineroApostado;
            return true;
        }

        public void recibirGanancia(double din)
        {
            if (din < 1) return;
            dinero += din;
        }
    }
}
