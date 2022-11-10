using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ej09
{
    class Asiento
    {
        char columna;
        sbyte fila;
        string etiqueta = "";
        Espectador cliente;

        public string Etiqueta { get { return etiqueta; } }

        public Asiento() { }

        public Asiento(char col, sbyte row) {
            columna = ComprobarColumna(col) ? Char.ToUpper(col) : 'A';
            fila = row;
            etiqueta = fila.ToString() + columna;
        }

        public void Ocupar(Espectador viewer)
        {
            cliente = viewer;
        }

        private bool ComprobarColumna(char valor)
        {
            return Regex.Match(valor.ToString(), @"^[a-zA-Z]{1}$").Success;
        }

        public bool IsOcupado()
        {
            return cliente != null;
        }
    }
}
