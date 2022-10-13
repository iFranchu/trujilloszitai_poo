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
        public string Nombre { get { return nombre; } }
        sbyte edad = 0;
        public sbyte Edad { get { return edad; } }
        char sexo = 'H';
        public char Sexo { get { return sexo; } }
        sbyte inasistencias = 0;
        static Random random = new Random();

        public Persona() { }
        public Persona(string nombre, sbyte edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = (sexo == 'H' || sexo == 'M') ? sexo : 'H';
        }

        public void Inasistencia()
        {
            int probabilidad = random.Next(1, 101);
            if(this is Profesor) { 
                if(probabilidad <= 20)
                {
                    inasistencias++;
                }
            }
            else if(this is Alumno)
            {
                if (probabilidad <= 50)
                {
                    inasistencias++;
                }
            }
        }
    }
}
