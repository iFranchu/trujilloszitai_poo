using System;

namespace sep_8_ej01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta account = new Cuenta("Ernesto");
            // Ingresar test
            if (account.Ingresar(48.13)) Console.WriteLine("Transacción realizada con éxito\r\nSaldo disponible: " + account.MostrarSaldo());
            else Console.WriteLine("No se puede ingresar una cantidad de dinero negativa\r\nSaldo disponible: " + account.MostrarSaldo());
            // Retirar test
            if (account.Retirar(30)) Console.WriteLine("Transacción realizada con éxito\r\nSaldo disponible: " + account.MostrarSaldo());
            else Console.WriteLine("Saldo insuficiente\r\nSaldo disponible: " + account.MostrarSaldo());

            Console.ReadKey();
        }
    }
}
