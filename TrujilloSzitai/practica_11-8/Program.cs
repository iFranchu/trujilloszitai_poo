using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    class Persona
    {
        public string nombre;
        public string apellido;
        public DateTime fechaNac;
        public int edad;
        public Persona(int edad, string nombre, string apellido, DateTime fechaNac)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.fechaNac = fechaNac;
        }



        public int Edad()
        {
            return DateTime.Now.AddTicks(-fechaNac.Ticks).Year;
        }

        public void ProxEdad(int dias)
        {
            Console.WriteLine("En "+dias+" días la persona tendrá " + DateTime.Now.AddTicks(-fechaNac.Ticks).AddDays(dias).Year + " años.");
        }

    }

    class Program
    {
        static Persona o;
        static List<Persona> lista = new List<Persona>();
        /*
        static Persona averiguarMenor(List<Persona> listatemp)
        {
            //o = new Persona

            Persona temp  = new Persona(999, "x", "x");
            foreach (Persona p in lista)
            {
                if (p.edad < temp.edad)
                {
                    temp = p;
                }
            }
            return temp;
        }
        */

        static void Main(string[] args)
        {
            /* int suma = 0, promedio = 0;
            int cantMayores = 0; */
            Random random = new Random();

            lista.Add(new Persona(20, "Pablo", "Perez", new DateTime(2000, 11, 2)));
            lista.Add(new Persona(25, "Juan", "Suarez", new DateTime(2003, 10, 2)));
            lista.Add(new Persona(30, "Analia", "Gomez", new DateTime(2020, 1, 2)));

            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista[i].Edad() == lista[i].edad)
                {
                    Console.WriteLine("La persona tiene " + lista[i].edad + " años");
                }
                else
                {
                    Console.WriteLine("La persona no tiene la edad indicada anteriormente (" + lista[i].edad + "), si no que tiene " + lista[i].Edad() + " años");
                }

                lista[i].ProxEdad(random.Next(1, 1000));
            }




            /*
                        for(int i = 0; i < lista.Count; i++)
                        {
                            if (lista[i].edad > 21)
                            {
                                cantMayores++;
                                suma += lista[i].edad;
                            }
                        }
                        promedio = suma / cantMayores;
                        Console.WriteLine(promedio);


                        o = averiguarMenor(lista);
                        Console.WriteLine(o.nombre);

                        int menor = 999;
                        for (int i = 0; i < lista.Count; i++)
                        {
                            if (lista[i].edad < menor)
                            {
                                menor = lista[i].edad;
                                o = lista[i];
                            }
                        }


                        Console.WriteLine(o.nombre + " edad " + o.edad);

                        promedio = suma / cantMayores;
                        Console.WriteLine(promedio);
            */


            Console.ReadKey();

        }
    }
}
