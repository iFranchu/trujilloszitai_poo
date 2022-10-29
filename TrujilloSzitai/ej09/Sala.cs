using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej09
{
    class Sala
    {
        sbyte idSala = 0;
        sbyte filas = 0;
        sbyte columnas = 0;
        List<Asiento> asientos = new List<Asiento>();
        Pelicula peliActual = new Pelicula();
        List<Espectador> espectadores = new List<Espectador>();
        static Random rand = new Random();

        public sbyte IdSala { get { return idSala; } }
        public sbyte Filas { get { return filas; } }
        public sbyte Columnas { get { return columnas; } }
        public List<Asiento> Asientos { get { return asientos; } }
        public Pelicula PeliActual { get { return peliActual; }  }
        public List<Espectador> Espectadores { get { return espectadores; } }

        public Sala() { }

        public Sala(sbyte id, sbyte rows, sbyte cols, Pelicula film) {
            idSala = id;
            filas = rows;
            columnas = cols;
            peliActual = film;
            AsignarAsientos();
        }

        public void AsignarAsientos()
        {
            for (sbyte row = filas; row > 0; row--)
            {
                for (int col = 65; col < 65 + columnas; col++)
                {
                    asientos.Add(new Asiento((char) col, row));
                }
            }
        }

        public void VenderEntradas()
        {
                GeneradorNombres generador = new GeneradorNombres();
            foreach (Asiento a in asientos)
            {
                string[] nombre = generador.GenerarNombre();
                if (rand.NextDouble() > 0.25) a.Ocupar(new Espectador(nombre[0], nombre[1], (sbyte) rand.Next(18,80), rand.NextDouble() * (80 - 18) + 18));
            }
        }

        public void MostrarSala()
        {
            int cont = 1;
            foreach(Asiento a in asientos)
            {
                if (cont > columnas) {
                    Console.WriteLine("");
                    cont = 1;
                } 
                Console.ForegroundColor = a.IsOcupado() ? ConsoleColor.Red : ConsoleColor.Green;
                Console.Write($" {a.Etiqueta} ");
                cont++;
            }
            Console.ResetColor();
        }
    }
}
