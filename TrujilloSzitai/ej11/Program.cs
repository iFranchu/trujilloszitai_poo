using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo1 = new Equipo("Berazategui", 0.8);
            Equipo equipo2 = new Equipo("Liniers", 0.7);

            Partido partido1 = new Partido(new Equipo[] { equipo1, equipo2 });
            partido1.jugarPartido();

            Apuesta apuesta1 = new Apuesta(partido1);
            List<Apostador> ganadores = apuesta1.ganadores();

            Console.WriteLine($"Resultados del partido de {partido1.Equipos[0].Nombre} (local) contra {partido1.Equipos[1].Nombre} (visitante)");
            Console.WriteLine($"{partido1.Equipos[0].Nombre} {partido1.GolesL} - {partido1.GolesV}");

            Console.WriteLine("");
            Console.WriteLine("Datos de las apuestas:");
            foreach(Apostador a in apuesta1.Apostadores)
            {
                Console.WriteLine($"{a.Nombre} apostó ${a.DineroApostado} por el resultado {a.GolesL} - {a.GolesV}");
            }

            Console.WriteLine("");
            Console.WriteLine("Ganador/es:");
            if(ganadores.Count() == 1 && ganadores[0].GolesL == apuesta1.Partido.GolesL && ganadores[0].GolesV == apuesta1.Partido.GolesV)
            {
                Apostador ganador = ganadores[0];
                Console.WriteLine($"{ganador.Nombre} fue el primero en acertar al resultado exacto, ganando ${apuesta1.calcularMonto()}");
            }
            else if(ganadores.Count() > 1 )
            {
                foreach (Apostador g in ganadores)
                {
                    Console.Write(g.Nombre + ", ");
                }
                Console.Write($" acertaron al resultado del partido, ganando cada uno ${apuesta1.calcularGanancias(ganadores.Count(), apuesta1.UltimoPremio)}");
            }
            else
            {
                Console.WriteLine($"Nadie ha acertado al resultado. Hay pendiente un bote de ${apuesta1.Bote}");
            }

            Console.ReadKey();
        }
    }
}
