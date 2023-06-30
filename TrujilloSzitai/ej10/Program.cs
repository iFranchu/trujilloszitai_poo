using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    class Program
    {
        static void Main(string[] args)
        {
            Baraja mazo = new Baraja();

            mazo.barajar();

            List<Carta> jugador1 = mazo.darCartas(15);




            for (int i = 0; i < 10; i++)
            {
                if (!mazo.siguienteCarta()) Console.WriteLine("No se puede entregar la carta.");
                else Console.WriteLine(mazo.mostrarCarta(mazo.Proxima));
            }

            Console.WriteLine("");
            Console.WriteLine($"Cartas disponibles: {mazo.cartasDisponibles()}");
            Console.WriteLine("");

            if (mazo.cartasMonton().Count() == 0)
            {
                Console.WriteLine("Aún no han salido cartas.");
            }
            else
            {
                Console.WriteLine("Las siguientes cartas ya han salido:");
                foreach (Carta c in mazo.cartasMonton())
                {
                    Console.WriteLine(c.ToString());
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Todas las cartas disponibles:");
            foreach (Carta c in mazo.mostrarBaraja())
            {
                Console.WriteLine(c.ToString());
            }

            Console.ReadKey();
        }
    }
}
