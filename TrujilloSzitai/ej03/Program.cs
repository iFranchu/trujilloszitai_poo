using System;

namespace ej03
{
    class Persona
    {
        public string nombre;
        public string apellido;
        public DateTime fechaNacimiento;
        public int edad;


        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
        }
        
        public int anios()
        {/*var currentYear = DateTime.Now.Year; if (DateTime.Compare(fechaNacimiento, DateTime.Now) < 0) edad = currentYear - fechaNacimiento.Year - 1; else edad = currentYear - fechaNacimiento.Year; return edad;*/
            return Convert.ToInt32(Math.Round(DateTime.Now.Subtract(fechaNacimiento).TotalDays * 0.00273790926)) - 1 ;

    }
}

internal class Program
    {
        static void Main(string[] args)
        {
            Persona per1, per2;

            per1 = new Persona("el", "sexo", new DateTime(2001, 4, 7));

            Console.WriteLine("{0} tiene {1} años", per1.nombre, per1.anios());
            Console.WriteLine(per1.nombre + " tiene " + per1.anios() + " años");
            Console.WriteLine($"{per1.nombre} tiene {per1.anios()} años");
            Console.ReadKey();
        }
    }
}
