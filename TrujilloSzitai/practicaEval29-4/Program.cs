using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaEval29_4
{
    class Persona
    {
        public string nombre;
        DateTime fechaNac;
        public List<Hijo> hijos = new List<Hijo>();
        public bool hijoMayor21 = false;
        public bool hijoAunNoCumple = false;
        public bool cincuentañeroOMasViejoConHijosTardios = false;
        public bool cobraSalario = false;
        int edad;

        public Persona(string nombre, DateTime fechaNac, Hijo[] listaHijos)
        {
            this.nombre = nombre;
            this.fechaNac = fechaNac;
            hijos.AddRange(listaHijos);
            edad = DateTime.Now.AddTicks(-fechaNac.Ticks).Year;
            foreach (Hijo hijo in hijos)
            {
                if (hijo.calcularEdad() > 21) hijoMayor21 = true;
                if (hijo.calcularEdad() < 21 && hijo.calcularEdad() > 3) cobraSalario = true;
                if (DateTime.Compare(DateTime.Now.AddYears(-(DateTime.Now.Year - fechaNac.Year)), fechaNac) <= 0) hijoAunNoCumple = true;
            }
            if (edad > 50 && hijoMayor21 == false) cincuentañeroOMasViejoConHijosTardios = true;
        }
        public int calcularEdad()
        {
            return DateTime.Now.AddTicks(-fechaNac.Ticks).Year-1;
        }
    }
    class Hijo
    {
        string nombre;
        DateTime fechaNac;

        public Hijo(string nombre, DateTime fechaNac)
        {
            this.nombre = nombre;
            this.fechaNac = fechaNac;
        }
        public int calcularEdad()
        {
            return DateTime.Now.AddTicks(-fechaNac.Ticks).Year;
        }
    }
        class Program
        {
        static List<Persona> EliminarPersonas(List<Persona> lista)
        {
            List<Persona> nuevaLista = new List<Persona>();
            for (int i = 0; i < lista.Count; i += 2)
            {
                nuevaLista.Add(lista[i]);
            }
            return nuevaLista;
        }

        static void PrintData(string data, List<Persona> lista)
        {
            Console.WriteLine(data);
            foreach(Persona per in lista)
            {
                Console.WriteLine(per.nombre);
            }
            Console.WriteLine("-------------------------------------------------");
        }

        static void Main(string[] args)
            {
            List<Persona> listaPersonas = new List<Persona>();
            List<Persona> padresHijosMayores = new List<Persona>();
            List<Persona> padresHijosMenores = new List<Persona>();
            List<Persona> asalariados = new List<Persona>();
            List<Persona> viejardos = new List<Persona>();
            listaPersonas.Add(new Persona("Romero", new DateTime(1978, 5, 1), new Hijo[] { new Hijo("Eugenio", new DateTime(2008, 11, 30)), new Hijo("Lautaro", new DateTime(2001, 9, 21)) }));
                listaPersonas.Add(new Persona("Arquímedes", new DateTime(1957, 9, 17), new Hijo[] { new Hijo("Hades", new DateTime(1980, 2, 18)), new Hijo("Roberto", new DateTime(1987, 1, 3)) }));
                listaPersonas.Add(new Persona("Juanceto", new DateTime(1978, 7, 13), new Hijo[] { 
                    new Hijo("Manuel", new DateTime(1999, 8, 15)), new Hijo("Estefano", new DateTime(1995, 12, 25)) }));
                listaPersonas.Add(new Persona("Mariano", new DateTime(2000, 7, 13)
                    , new Hijo[] { 
                    new Hijo("Manuel", new DateTime(2020, 2, 12)), 
                    new Hijo("Estefano", new DateTime(2022, 11, 17)) 
                }));
                listaPersonas.Add(new Persona("Gloria", new DateTime(2000, 7, 13), new Hijo[] {
                    new Hijo("Manuel", new DateTime(2020, 2, 12)), 
                    new Hijo("Estefano", new DateTime(2022, 11, 17)) 
                }));

            foreach (Persona per in listaPersonas)
            {
                if (per.hijoMayor21) padresHijosMayores.Add(per);
                if (per.hijoAunNoCumple) padresHijosMenores.Add(per);
                if (per.cincuentañeroOMasViejoConHijosTardios) viejardos.Add(per);
                if (per.cobraSalario) asalariados.Add(per);
            }
            listaPersonas = EliminarPersonas(listaPersonas);
                var random = new Random();
                listaPersonas[random.Next(listaPersonas.Count)].hijos.Add(new Hijo("Manuel", new DateTime(1973, 7, 14)));
            PrintData("Las personas que tienen al menos un hijo mayor de 21 años son:", padresHijosMayores);
            PrintData("Las personas que tienen al menos un hijo que aún no ha cumplido años son:", padresHijosMenores);
            PrintData("Las personas que tienen más de 50 años pero ninguno de sus hijos supera los 21 años de edad son:", viejardos);
            PrintData("Los asalariados son:", asalariados);
                Console.ReadKey();
            }
        }
    
}
