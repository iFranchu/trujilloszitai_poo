using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{
    class Videojuego : Entregable
    {
        string titulo = "";
        sbyte horasDeJuego = 10;
        bool entregado = false;
        string genero = "";
        string compania = "";

        public string Titulo { get { return titulo; } set { titulo = value; } }
        public sbyte HorasDeJuego { get { return horasDeJuego; } set { horasDeJuego = value; } }
        public string Genero { get { return genero; } set { genero = value; } }
        public string Comapania { get { return compania; } set { compania = value; } }

        public Videojuego() { }

        public Videojuego(string titulo, sbyte horas)
        {
            this.titulo = titulo;
            this.horasDeJuego = horas;
        }

        public Videojuego(string titulo, sbyte horas, string genero, string compania)
        {
            this.titulo = titulo;
            this.horasDeJuego = horas;
            this.genero = genero;
            this.compania = compania;
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
            Videojuego videojuego = (Videojuego)a;

            if (videojuego.horasDeJuego > this.horasDeJuego) return true;
            else return false;
        }
    }
}
