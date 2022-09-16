using System;
using System.Collections.Generic;

namespace sep_8_ej02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaPersonas = new List<Persona>();
            for(int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Ingrese el nombre para la persona n° {i}");
                var nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese la edad para la persona n° {i}");
                sbyte edad = Convert.ToSByte(Console.ReadLine());
                Console.WriteLine($"Ingrese el sexo para la persona n° {i}");
                char sexo = Convert.ToChar(Console.ReadLine());
                Console.WriteLine($"Ingrese el peso para la persona n° {i}");
                float peso = float.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese la altura para la persona n° {i}");
                float altura = float.Parse(Console.ReadLine());
                listaPersonas.Add(new Persona(nombre, edad, sexo, peso, altura));
                Console.Clear();
            }

            foreach(Persona persona in listaPersonas)
            {
                Console.WriteLine("");
                Console.WriteLine("Datos de persona falsa:");
                Console.WriteLine("Nombre: " + persona.Nombre);
                Console.WriteLine("Edad: " + persona.Edad);
                Console.WriteLine("DNI: " + persona.Dni);
                Console.WriteLine("Peso: " + persona.Peso);
                Console.WriteLine("Altura: " + persona.Altura);
                if (persona.CalcularIMC() == -1) Console.WriteLine("IMC: Por debajo del peso ideal");
                else if (persona.CalcularIMC() == 0) Console.WriteLine("IMC: Peso estable");
                else Console.WriteLine("IMC: Sobrepeso");

                if (persona.EsMayorDeEdad()) Console.WriteLine("La persona es mayor de edad");
                else Console.WriteLine("La persona no es mayor de edad");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
