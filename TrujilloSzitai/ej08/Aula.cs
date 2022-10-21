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
        string[] materias = { "matematicas" };
        string[] posiblesMaterias = new string[3]{
            "matematicas",
            "filosofia",
            "fisica",
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
            this.idAula = id;
            this.capacidad = capacidad;
            bool checkMaterias = true;
            foreach (string materia in materias)
            {
                byte[] tempBytes = Encoding.GetEncoding("ISO-8859-8").GetBytes(materia);
                string asciiStr = Encoding.UTF8.GetString(tempBytes);
                if (!posiblesMaterias.Contains(asciiStr.ToLower()))
                {
                    checkMaterias = false;
                }
                else checkMaterias = true;
            }
            this.materias = checkMaterias ? materias : new string[] { "Matemáticas" };
            this.profesor = profesor;
            this.alumnos = alumnos;
            this.presentismo = Asistencia();
        }

        public bool AulaDisponible()
        {
            return (profesor.Presente && ProfesorCorrecto() && (presentismo >= capacidad / 2));
        }

        bool ProfesorCorrecto()
        {
            bool checkedMaterias = true;
            foreach(string materia in this.profesor.Materias)
            {
                if (materias.Contains(materia)) return true;
                else checkedMaterias = false;
            }
            return checkedMaterias;

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
            return $"Aula N°: {this.idAula}\r\nCapacidad para: {this.capacidad} alumnos\r\nAlumnos presentes: {this.presentismo} de {alumnos.Count()}\r\nDocente presente: {profesor.Presente}\r\nMaterias dictadas: {string.Join(",", materias)}";
        }
    }
}
