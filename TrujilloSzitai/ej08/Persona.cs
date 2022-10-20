using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej08
{
    class Persona
    {
        string nombre = "";
        sbyte edad = 0;
        char sexo = 'H';
        sbyte inasistencias = 0;
        bool presente = true;

        public string Nombre { get { return nombre; } }
        public sbyte Edad { get { return edad; } }
        public char Sexo { get { return sexo; } }
        public sbyte Inasistencias { get { return inasistencias; } }
        public bool Presente { get { return presente; } }

        static Random random = new Random();

        public Persona() { }
        public Persona(string nombre, sbyte edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = (sexo == 'H' || sexo == 'M') ? sexo : 'H';
            this.presente = Asistencia();
        }

        public bool Asistencia()
        {
            int probabilidad = random.Next(1, 101);
            if(this is Profesor) { 
                if(probabilidad <= 20)
                {
                    inasistencias++;
                    return false;
                }
                return true;
            }
            else if(this is Alumno)
            {
                if (probabilidad <= 50)
                {
                    inasistencias++;
                    return false;
                }
                return true;
            }
            return true;
        }
    }
}
