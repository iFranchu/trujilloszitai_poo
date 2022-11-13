using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    class Juego
    {
        List<Jugador> jugadores = new List<Jugador>();
        Revolver r = new Revolver();

        public Juego(sbyte cantidad)
        {
            for (sbyte i = 0; i < cantidad; i++)
            {
                jugadores.Insert(i, new Jugador((sbyte)(i + 1)));
            }
        }

        public bool finJuego()
        {
            return !jugadores.Find(j => j.Vivo).Vivo;
        }

        public void ronda()
        {
            Console.WriteLine(r.ToString());
            foreach (Jugador j in jugadores)
            {
                if (!j.disparar(r)) {
                    Console.WriteLine($"{j.Nombre} ha MUERTO.");
                    return;
                }
                else
                {
                    Console.WriteLine($"{j.Nombre} ha gatillado y, ¡aleluya! No había bala en la recámara actual.");
                    r.rotarTambor();
                }
            }
        }
    }
}
