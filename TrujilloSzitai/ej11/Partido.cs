using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
    class Partido
    {
        Equipo[] equipos = new Equipo[2] { new Equipo(), new Equipo() };
        sbyte golesLocal = 0;
        sbyte golesVisitante = 0;
        static Random r = new Random();

        public Equipo[] Equipos { get { return equipos; } }
        public sbyte GolesL { get { return golesLocal; } }
        public sbyte GolesV { get { return golesVisitante; } }

        public Partido() { }
        public Partido(Equipo[] equipos) {
            this.equipos = equipos;
        }

        public void jugarPartido() { 
            for(int oportunidades = 0; oportunidades < 10; oportunidades++)
            {
                double ofensivaLocal = r.NextDouble();
                double ofensivaVisitante = r.NextDouble();


                if (ofensivaLocal > equipos[1].Efectividad)
                {
                    golesLocal++;
                }
                if(ofensivaVisitante > equipos[0].Efectividad)
                {
                    golesVisitante++;
                }
            }
        }
    }
}
