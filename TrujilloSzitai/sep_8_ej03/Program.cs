using System;
using System.Collections.Generic;

namespace sep_8_ej03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Password> passwords = new List<Password>();
            int cantidad;
            Console.WriteLine("Ingrese la cantidad de contraseñas a generar:");
            string c = Console.ReadLine();
            Console.Clear();
            if (int.TryParse(c, out cantidad) && cantidad > 0 && cantidad < 50)
            {
                for (int i = 1; i <= cantidad; i++)
                {
                    sbyte longitud = 0;
                    string name;
                    while (longitud < 6 || longitud > 50)
                    {
                        Console.WriteLine($"Ingrese la longitud de la contraseña n° {i} (entre 6 y 50)");
                        longitud = Convert.ToSByte(Console.ReadLine());
                    }
                    Console.WriteLine($"Ingrese el nombre de la contraseña n° {i}");
                    name = Console.ReadLine();
                    passwords.Add(new Password(name, longitud));
                    Console.Clear();
                }
                Console.WriteLine("Listado de contraseñas:");
                foreach (Password password in passwords)
                {
                    Console.Write($"{password.Nombre}: {password.Contraseña} - ");
                    switch (password.EsFuerte())
                    {
                        case 4:
                            Console.Write("Seguridad alta");
                            break;
                        case 3:
                            Console.Write("Seguridad media");
                            break;
                        case 2:
                            Console.Write("Seguridad baja");
                            break;
                        case 1:
                            Console.Write("Contraseña insegura");
                            break;
                        default:
                            Console.Write("Inseguridad extrema. Se recomienda cambiar AHORA MISMO.");
                            break;
                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("La cantidad no puede ser un texto o menor a 1.");
            }
            Console.ReadKey();
        }
    }
}
