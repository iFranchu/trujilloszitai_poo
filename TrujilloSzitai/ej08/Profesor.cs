using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej08
{
    class Profesor : Persona
    {
        string[] materias = { "Matemáticas" };
        byte[] aulas = { 0 };

        string[] posiblesMaterias = new string[3]{
            "Matemáticas",
            "Filosofía",
            "Física",
        };

        public string[] Materias { get { return materias; } }
        public string[] PosiblesMaterias { get { return posiblesMaterias; } }

        public Profesor() { }
        public Profesor(string nombre, sbyte edad, char sexo, string[] materias, byte[] aulas) : base(nombre, edad, sexo)
        {
            this.materias = CheckMaterias(materias) ? materias : new string[] { "Matemáticas" };
            this.aulas = aulas;
        }

        bool CheckMaterias(string[] array)
        {
            var intersection = array.Intersect(posiblesMaterias, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(intersection.Any());
            return intersection.Any();
        }
    }
}
