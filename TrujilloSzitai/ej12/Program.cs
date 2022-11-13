using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego1 = new Juego(6);
            juego1.ronda();
            if (!juego1.finJuego()) Console.WriteLine("- FIN DEL JUEGO -");

            Console.ReadKey();
        }
    }
}
