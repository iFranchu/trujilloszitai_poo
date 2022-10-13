using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej07
{
    class Raices
    {
        double a;
        double b;
        double c;
        double discriminante;

        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.discriminante = Math.Pow(b, 2) - (4 * a * c);
        }

        public void ObtenerRaices()
        {
            double[] raices = { 
                ((-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a)),
                ((-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a))
            };

            if (discriminante > 0) Console.WriteLine($"Raíz 1: {raices[0]}\r\nRaíz 2: {raices[1]}");
            else if (discriminante == 0) Console.WriteLine($"Única raíz: {raices[0]}");
            else Console.WriteLine("La función no tiene raíces.");
        }

        public double GetDiscriminante()
        {
            return discriminante;
        }

        public bool DosRaices()
        {
            return (discriminante > 0);
        }

        public bool UnaRaiz()
        {
            return (discriminante == 0);
        }
    }
}
