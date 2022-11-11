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
        List<Carta> cartas = new List<Carta>();
        sbyte proxima = 1;
        static Random r = new Random();

        public sbyte CantCartas { get { return cantCartas; } }

        public Baraja() { 
            for(int i = 0; i < cantCartas; i++)
            {
                Carta nuevaCarta = new Carta();
                while(cartas.Find(c => (c.Palo == nuevaCarta.Palo) && (c.Numero == nuevaCarta.Numero)) != null)
                {
                    nuevaCarta = new Carta();
                }
                cartas.Insert(i, nuevaCarta);
            }
            List<Carta> cartasOrdenadas = cartas.OrderBy(c => c.Numero).ToList();
            cartas = cartasOrdenadas;
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

        public bool siguienteCarta()
        {
            if (proxima >= cartas.Count())
            {
                proxima = 1;
                recuperarCartas();
                return false;
            }
            if (!cartas[proxima].Entregada) { 
                cartas[proxima].Entregar();
                return true;
            }
            return false;
        }

        public List<Carta> darCartas(sbyte cantidad)
        {
            List<Carta> cartasPedidas = new List<Carta>();
            if (cantidad < cartasDisponibles())
            {
                for (sbyte i = 0; i < cantidad; i++)
                {
                    int index = r.Next(0, cartas.Count());
                    while(cartas[index].Entregada)
                    {
                        index = r.Next(0, cartas.Count());
                    }
                    cartas[index].Entregar();
                    cartasPedidas.Add(cartas[index]);
                }
            }
            return cartasPedidas;
        }

        public sbyte cartasDisponibles()
        {
            return (sbyte) cartas.Count(c => !c.Entregada);
        }

        public List<Carta> cartasMonton()
        {
            return cartas.FindAll(c => c.Entregada);
        }

        public List<Carta> mostrarBaraja()
        {
            return cartas.FindAll(c => !c.Entregada);
        }

        void recuperarCartas()
        {
            foreach(Carta c in cartas)
            {
                c.Devolver();
            }
        }
    }
}
