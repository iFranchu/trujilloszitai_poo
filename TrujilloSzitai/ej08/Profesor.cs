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
            "matematicas",
            "filosofia",
            "fisica",
        };

        public string[] Materias { get { return materias; } }
        public string[] PosiblesMaterias { get { return posiblesMaterias; } }

        //string[] posiblesMaterias =
        //{
        //    "Matemáticas",
        //    "Filosofía",
        //    "Física"
        //};

        public Profesor() { }
        public Profesor(string nombre, sbyte edad, char sexo, string[] materias, byte[] aulas) : base(nombre, edad, sexo)
        {
            // Algoritmo para verificar que las materias ingresadas sean correctas
            bool checkMaterias = true;
            foreach (string materia in materias)
            {
                byte[] tempBytes = Encoding.GetEncoding("ISO-8859-8").GetBytes(materia);
                string asciiStr = Encoding.UTF8.GetString(tempBytes);
                if (!posiblesMaterias.Contains(asciiStr.ToLower())) {
                    checkMaterias = false;
                }
            }
            if (checkMaterias) this.materias = materias;
            else this.materias = new string[] { "Matemáticas" };
            
            this.aulas = aulas;
        }
    }
}
