using System;

namespace ej04
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico[] electrodomesticos = new Electrodomestico[10]
            {
                new Electrodomestico(),
                new Lavadora(),
                new Television(),
                new Electrodomestico(),
                new Lavadora(),
                new Television(),
                new Electrodomestico(),
                new Lavadora(),
                new Television(),
                new Electrodomestico()
            };
        }
    }
}
