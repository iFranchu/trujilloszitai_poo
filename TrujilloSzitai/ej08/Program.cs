using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej08
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor manuel = new Profesor("Manuel", 41, 'H', new string[] { "Filosofía", "Física" }, new byte[] { 1 });
            List<Alumno> alumnos1 = new List<Alumno>()
            {
                new Alumno("Omar", 16, 'H'),
                new Alumno("Matias", 16, 'H'),
                new Alumno("Nicolas", 16, 'H'),
                new Alumno("Osvaldo", 16, 'H'),
                new Alumno("Fabian", 16, 'H'),
                new Alumno("Pepe", 16, 'H'),
                new Alumno("Horacio", 16, 'H'),
                new Alumno("Angel", 16, 'H'),
                new Alumno("Lucas", 16, 'H'),
                new Alumno("Santino", 16, 'H'),
                new Alumno("Constanza", 16, 'M'),
                new Alumno("Lucia", 16, 'M'),
                new Alumno("Amalia", 16, 'M'),
                new Alumno("Emilia", 16, 'M'),
                new Alumno("Mariana", 16, 'M'),
                new Alumno("Rosa", 16, 'M'),
                new Alumno("Fabiola", 16, 'M'),
                new Alumno("Guadalupe", 16, 'M'),
                new Alumno("Omar II", 16, 'H'),
                new Alumno("Omar III", 16, 'H'),
            };
            Aula aula1 = new Aula(1, 20, new string[] { "Filosofía", "Matemáticas" }, manuel, alumnos1);

            if (aula1.AulaDisponible()) {
                Console.WriteLine($"El aula {aula1.IdAula} está disponible para ser utilizada.\r\nA continuación se muestra la información del aula:");
                Console.WriteLine("Datos del aula:");
                Console.WriteLine(aula1.ToString());
                Console.WriteLine("");
                Console.WriteLine("Datos del docente");
                Console.WriteLine(aula1.Profesor.ToString());
                Console.WriteLine("");
                Console.WriteLine("Lista de alumnos aprobados:");
                foreach (Alumno alumno in aula1.Alumnos)
                {
                    if (alumno.IsAprobado()) Console.WriteLine($"{alumno.Nombre} está aprobado con una califación de {alumno.Nota}");
                }
            }
            else
            {
                Console.WriteLine("El aula no se encuentra disponible para dar clases.");
                Console.WriteLine(aula1.ToString());
            }

            Console.ReadKey();
        }
    }
}
