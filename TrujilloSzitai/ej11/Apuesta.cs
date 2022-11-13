using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
    class Apuesta : ApuestaMinima
    {
        List<Apostador> apostadores = generarApostadores();
        double bote = 0;
        double ultimoPremio = 0;
        Partido partido = new Partido();
        static Random r = new Random();

        public List<Apostador> Apostadores { get { return apostadores; } }
        public Partido Partido { get { return partido; } }
        public double Bote { get { return bote; } }
        public double UltimoPremio { get { return ultimoPremio; } }

        public Apuesta() {
            bote = calcularMonto();
        }

        public Apuesta(List<Apostador> apostadores, Partido partido)
        {
            if (apostadores.Count() > 1) this.apostadores = apostadores;
            this.partido = partido;
            bote = calcularMonto();
        }
        public Apuesta(Partido partido)
        {
            this.partido = partido;
            bote = calcularMonto();
        }

        static List<Apostador> generarApostadores()
        {
            List<Apostador> apostadoresRandom = new List<Apostador>();
            for (int i = 0; i < 10; i++)
            {
                apostadoresRandom.Insert(i, new Apostador());
            }
            return apostadoresRandom;
        }

        public List<Apostador> ganadores()
        {
            sbyte golesL = partido.GolesL;
            sbyte golesV = partido.GolesV;
            sbyte diferencia = (sbyte) (golesL - golesV);
            List<Apostador> listaGanadores = new List<Apostador>();
            
            foreach (Apostador a in apostadores)
            {
                if (a.GolesL == golesL && a.GolesV == golesV) {
                    listaGanadores = new List<Apostador>() { a };
                    darGanancias(a);
                    return listaGanadores;
                }
                else if ((a.DiferenciaGoles > 0 && diferencia > 0) || (a.DiferenciaGoles < 0 && diferencia < 0) || (a.DiferenciaGoles == 0 && diferencia == 0)) {
                    listaGanadores.Add(a); 
                }
            }
            if(listaGanadores.Count() >= 1) repartirGanancias(listaGanadores);
            else
            {
                reapostar();
                bote += calcularMonto();
            }
            return listaGanadores;
        }

        void reapostar()
        {
            foreach(Apostador a in apostadores)
            {
                if(a.Dinero > ApuestaMin) a.Apostar(r.Next((int)ApuestaMin, (int)a.Dinero + 1));
            }
        }

        void repartirGanancias(List<Apostador> ganadores)
        {
            ultimoPremio = bote;
            foreach (Apostador g in ganadores)
            {
                g.recibirGanancia(calcularGanancias(ganadores.Count(), ultimoPremio));
            }
            bote = 0;
        }

        void darGanancias(Apostador ganador)
        {
            ultimoPremio = bote;
            ganador.recibirGanancia(bote);
            bote = 0;
        }

        public double calcularMonto()
        {
            double montoTotal = 0;
            foreach(Apostador a in apostadores)
            {
                montoTotal += a.DineroApostado;
            }
            return montoTotal;
        }

        public double calcularGanancias(int cantidadGanadores, double premio)
        {
            return premio / cantidadGanadores;
        }
    }
}
