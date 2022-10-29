using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej09
{
    class Program
    {
        static void Main(string[] args)
        {
            Cine cine = new Cine();
            Pelicula peli1 = new Pelicula("Argentina, 1985", 140, 16, "Matías Videla");
            Sala sala1 = new Sala(1, 8, 9, peli1);
            cine.Salas = new List<Sala>() { sala1 };

            cine.Salas[0].VenderEntradas();

            Console.WriteLine("Verde: Libre\r\nRojo: Ocupado");
            cine.Salas[0].MostrarSala();

            Console.ReadKey();
        }
    }
}
