using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej02
{
    internal class Program
    {
        class Persona
        {
            public int edad;
            public int cantBrazos;
            public int cantPiernas;
            public string alias;
            public string colorOjos;
            public bool miopia;
            public Persona(int age, int arms, int legs, string name, string eyesColor, bool miopia)
            {
                this.edad = age;
                this.cantBrazos = arms;
                this.cantPiernas = legs;
                this.alias = name;
                this.colorOjos = eyesColor;
                this.miopia = miopia;
            }

            public void presentacion()
            {
                Console.WriteLine($"Hola mi nombre es {this.alias} y soy un guia explorador de la tribu 54 guarida 12. \r\n Tengo {this.edad} años y ojos {this.colorOjos} \r\n {miopiaTest(this.miopia)}");
            }
            public string miopiaTest(bool miopiaDatazo)
            {
                if (miopiaDatazo == true)
                {
                    return "Tengo miopia\r\n\r\n D=";
                }
                else
                {
                    return "No tengo miopia\r\n\r\n =D";
                }
            }
        }
        static void Main(string[] args)
        {
            Persona per1 = new Persona(16, 2, 0, "Jorge", "Marrónes", true);
            per1.presentacion();
            Console.ReadKey();
        }
    }
}