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
            // Algoritmo para verificar que las materias ingresadas sean correctas, aunque me di cuenta de que no funciona lo que probé para eliminar las tildes
            //bool checkMaterias = true;
            //foreach (string materia in materias)
            //{
            //    byte[] tempBytes = Encoding.GetEncoding("ISO-8859-8").GetBytes(materia);
            //    string asciiStr = Encoding.UTF8.GetString(tempBytes);
            //    if (!posiblesMaterias.Contains(asciiStr.ToLower()))
            //    {
            //        checkMaterias = false;
            //    }
            //    else checkMaterias = true;
            //}
            this.materias = checkMaterias ? materias : new string[] { "Matemáticas" };
            this.aulas = aulas;
        }

        bool CheckMaterias(string[] array)
        {
            if (posiblesMaterias.Intersect(array).Any()) return true;
            return false;
        }
    }
}
