using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{
    class Serie : Entregable
    {
        string titulo = "";
        sbyte temporadas = 3;
        bool entregado = false;
        string genero = "";
        string creador = "";

        public string Titulo { get { return titulo; } set { titulo = value; } }
        public sbyte Temporadas { get { return temporadas; } set { temporadas = value; } }
        public string Genero { get { return genero; } set { genero = value; } }
        public string Creador { get { return creador; } set { creador = value; } }

        public Serie() { }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo, sbyte temporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.temporadas = temporadas;
            this.genero = genero;
            this.creador = creador;
        }

        public void Entregar()
        {
            this.entregado = true;
        }
        public void Devolver()
        {
            this.entregado = false;
        }
        public bool IsEntregado()
        {
            return this.entregado;
        }
        public bool CompareTo(Object a)
        {
            Serie serie = (Serie)a;

            if (serie.temporadas > this.temporadas) return true;
            else return false;
        }
    }
}
