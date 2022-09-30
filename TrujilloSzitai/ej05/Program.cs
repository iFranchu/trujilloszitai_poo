using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Serie> series = new List<Serie>(5) {
                new Serie(),
                new Serie("The Walking Dead", "Jorge"),
                new Serie("Breaking Good", 5, "Grasa", "SDLG"),
                new Serie("Mejor Llama a Raul", 6, "Szitai", "Manaos"),
                new Serie()
            };
            List<Videojuego> videojuegos = new List<Videojuego>(5) {
                new Videojuego(),
                new Videojuego("Doom Infinito", 127),
                new Videojuego("La Grasa the videogame", 80, "Grasa", "SDLG"),
                new Videojuego("Redención but muerte roja 2", 40, "Tiros", "Sandstar Games"),
                new Videojuego()
            };

            int seriesEntregadas = 0;
            int juegosEntregados = 0;
            Serie serieMasLarga = series[0];
            Videojuego juegoMasLargo = videojuegos[0];
            Random random = new Random();

            foreach (Serie serie in series)
            {
                if (random.Next(1, 3) == 1) {
                    serie.Entregar();
                    seriesEntregadas++;
                    Console.WriteLine($"La serie {serie.Titulo} está entregada.");
                }
                if (serieMasLarga.CompareTo(serie)) serieMasLarga = serie;
            }

            foreach (Videojuego videojuego in videojuegos)
            {
                if (random.Next(1, 3) == 1) { 
                    videojuego.Entregar();
                    juegosEntregados++;
                    Console.WriteLine($"El videojuego {videojuego.Titulo} está entregado.");
                }
                if (juegoMasLargo.CompareTo(videojuego)) juegoMasLargo = videojuego;
            }

            Console.WriteLine($"Hay {seriesEntregadas} series entregadas.");
            Console.WriteLine($"Hay {juegosEntregados} videojuegos entregados.");
            Console.WriteLine("");
            Console.WriteLine($"{serieMasLarga.Titulo} es la serie más larga con {serieMasLarga.Temporadas} temporadas.");
            Console.WriteLine($"{juegoMasLargo.Titulo} es el videojuego más largo con {juegoMasLargo.HorasDeJuego} horas de juego.");
            Console.ReadKey();
        }
    }
}
