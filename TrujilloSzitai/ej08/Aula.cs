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
        string[] materiasPermitidas = { "matematicas" };
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
            this.materiasPermitidas = materias;
            this.profesor = profesor;
            this.alumnos = alumnos;
        }

        public bool AulaDisponible()
        {
            return (profesor.Asistencia() && ProfesorCorrecto() && Asistencia());
        }

        public bool ProfesorCorrecto()
        {
            bool checkedMaterias = true;
            foreach(string materia in this.profesor.Materias)
            {
                if (materiasPermitidas.Contains(materia)) return true;
                else checkedMaterias = false;
            }
            return checkedMaterias;

        }

        public bool Asistencia()
        {
            sbyte presentismo = 0;
            foreach(Alumno alumno in alumnos)
            {
                if (alumno.Presente) presentismo++;
            }
            return (presentismo > capacidad / 2);
        }
    }
}
