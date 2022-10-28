using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej08
{
    class Aula
    {
        byte idAula = 0;
        sbyte capacidad = 30;
        sbyte presentismo = 0;
        string[] materias = { "Matemáticas" };
        string[] posiblesMaterias = new string[3]{
            "Matemáticas",
            "Filosofía",
            "Física",
        };
        Profesor profesor = new Profesor();
        List<Alumno> alumnos = new List<Alumno>();

        public byte IdAula { get { return idAula; } }
        public sbyte Capacidad { get { return capacidad; } }
        public sbyte Presentismo { get { return presentismo; } }
        public Profesor Profesor { get { return profesor; } }
        public List<Alumno> Alumnos { get { return alumnos; } }

        public Aula(byte id, sbyte capacidad, string[] materias, Profesor profesor, List<Alumno> alumnos)
        {
            var intersection = materias.Intersect(posiblesMaterias, StringComparer.OrdinalIgnoreCase);

            this.idAula = id;
            this.capacidad = capacidad;
            this.materias = intersection.Any() ? materias : new string[] { "Matemáticas" };
            this.profesor = profesor;
            this.alumnos = alumnos;
            this.presentismo = Asistencia();
        }

        public bool AulaDisponible()
        {
            return (profesor.Presente && ProfesorCorrecto(profesor.Materias) && (presentismo >= capacidad / 2));
        }

        bool ProfesorCorrecto(string[] array)
        {
            var intersection = array.Intersect(posiblesMaterias, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(intersection.Any());
            return intersection.Any();

        }

        sbyte Asistencia()
        {
            sbyte p = 0;
            foreach(Alumno alumno in alumnos)
            {
                if (alumno.Presente) p++;
            }
            return p;
        }

        public override string ToString()
        {
            return $"Aula N°: {this.idAula}\r\nCapacidad para: {this.capacidad} alumnos\r\nAlumnos presentes: {this.presentismo} de {alumnos.Count()}\r\nDocente presente: {profesor.Presente}\r\nMaterias del docente: {string.Join(",", profesor.Materias)}\r\nMaterias dictadas: {string.Join(",", materias)}";
        }
    }
}
