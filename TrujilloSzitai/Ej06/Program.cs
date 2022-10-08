using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej06
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("978-1234567890", "SQL Injection - The official guide", "Raul Benegas", 540);
            Libro libro2 = new Libro("978-0987654321", "La riqueza de las naciones", "Adam Smith", 816);

            Console.WriteLine(libro1.ToString());
            Console.WriteLine(libro2.ToString());

            switch (libro1.ComparePages(libro2))
            {
                case 1:
                    Console.WriteLine($"El libro {libro1.Titulo} ({libro1.Paginas} páginas) tiene más paginas que el libro {libro2.Titulo} ({libro2.Paginas} páginas)");
                    break;
                case 0:
                    Console.WriteLine($"El libro {libro2.Titulo} ({libro2.Paginas} páginas) tiene la misma cantidad de páginas que el libro {libro1.Titulo} ({libro1.Paginas} páginas)");
                    break;
                case -1:
                    Console.WriteLine($"El libro {libro2.Titulo} ({libro2.Paginas} páginas) tiene más páginas que el libro {libro1.Titulo} ({libro1.Paginas} páginas)");
                    break;
            }

            Console.ReadKey();
        }
    }
}
