using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej08
{
    class Alumno : Persona
    {
        sbyte nota = 1;

        public sbyte Nota { get { return nota; } }

        public Alumno() { }

        public Alumno(string nombre, sbyte edad, char sexo) : base(nombre, edad, sexo) {
            this.nota = (sbyte) Random.Next(1, 11);
        }

        public bool IsAprobado()
        {
            return (nota >= 6);
        }
    }
}
