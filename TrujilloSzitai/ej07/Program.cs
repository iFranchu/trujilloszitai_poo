using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej07
{
    class Program
    {
        static void Main(string[] args)
        {
            Raices ecuacion1 = new Raices(2.71, 3, 4.5);
            Raices ecuacion2 = new Raices(-4, 1.71, 8);
            Raices ecuacion3 = new Raices(0.25, -1, 1);

            ecuacion1.ObtenerRaices();
            Console.WriteLine("Discriminante: " + ecuacion1.GetDiscriminante());
            ecuacion2.ObtenerRaices();
            Console.WriteLine("Discriminante: " + ecuacion2.GetDiscriminante());
            ecuacion3.ObtenerRaices();
            Console.WriteLine("Discriminante: " + ecuacion3.GetDiscriminante());

            Console.ReadKey();
        }
    }
}
