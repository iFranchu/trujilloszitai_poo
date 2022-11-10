using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    class Baraja
    {
        static sbyte cantCartas = 40;
        List<Carta> cartas = new List<Carta>(cantCartas);
        sbyte proxima = 1;
        static Random r = new Random();

        public Baraja() { 
            for(int i = 0; i < cartas.Count(); i++)
            {
                cartas[i] = new Carta();
            }
        }

        public void barajar()
        {
            for (int i = 0; i < cartas.Count(); i++)
            {
                int index = r.Next(0, cartas.Count());
                Carta temporal = cartas[index];
                cartas[index] = cartas[i];
                cartas[i] = temporal;
            }
        }

        public Carta siguienteCarta()
        {
            if()
            cartas[proxima].Revelar();
        }

        public List<Carta> darCartas(sbyte cantidad)
        {
            List<Carta> cartasPedidas = new List<Carta>();
            if (cantidad < cartasDisponibles())
            {
                for (sbyte i = 0; i < cantidad; i++)
                {
                    int index = r.Next(0, cartas.Count());
                    while(cartas[index].isEntregada())
                    {
                        index = r.Next(0, cartas.Count());
                    }
                    cartas[index].EntregarDevolver();
                    cartasPedidas.Add(cartas[index]);
                }
            }
            return cartasPedidas;
        }

        public sbyte cartasDisponibles()
        {
            sbyte disponibles = (sbyte) cartas.Count();
            foreach(Carta carta in cartas)
            {
                if (carta.isEntregada()) disponibles--;
            }
            return disponibles;
        }

    }
}
