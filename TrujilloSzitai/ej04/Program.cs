using System;
using System.Collections.Generic;

namespace ej04
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico[] dispositivos = new Electrodomestico[10]
            {
                new Electrodomestico(150, "negro", 'B', 23),
                new Lavadora(600, "azul", 'A', 40, 32),
                new Television(500, "negro", 'B', 8, 43, true),
                new Electrodomestico(200, "blanco", 'D', 20),
                new Lavadora(350, "blanco", 'A', 17, 12),
                new Television(100, "rojo", 'F', 6, 28, false),
                new Electrodomestico(150, "gris", 'F', 18),
                new Lavadora(120, "negro", 'E', 12, 5),
                new Television(250, "gris", 'B', 8, 32, true),
                new Electrodomestico(150, "rojo", 'A', 19)
            };
            float precioLavadoras = 0;
            float precioTelevisiones = 0;
            float precioTotal = 0;

            foreach (Electrodomestico item in dispositivos)
            {
                if (item is Lavadora) precioLavadoras += item.PrecioFinal();
                else if (item is Television) precioTelevisiones += item.PrecioFinal();
                precioTotal += item.PrecioFinal();
            }

            Console.WriteLine("Precio de todas las lavadoras: " + precioLavadoras);
            Console.WriteLine("Precio de todas los televisores: " + precioTelevisiones);
            Console.WriteLine("Precio total: " + precioTotal);
            Console.ReadKey();
        }
    }
}
