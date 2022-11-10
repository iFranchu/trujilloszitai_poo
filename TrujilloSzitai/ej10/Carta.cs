using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    class Carta
    {
        sbyte numero = 1;
        string palo = "";
        bool revelada = false;
        bool entregada = false;
        string[] palos = { "bastos", "oro", "copas", "espada" };
        static HashSet<int> excluir = new HashSet<int>() { 8, 9 };
        static IEnumerable<int> rango = Enumerable.Range(1, 12).Where(i => !excluir.Contains(i));
        static Random r = new Random();

        public Carta()
        {
            generarCarta();
        }

        public void generarCarta()
        {
            int index = r.Next(0, 12 - excluir.Count);
            numero = (sbyte)rango.ElementAt(index);
            palo = palos[r.Next(0, 4)];
        }

        public void EntregarDevolver()
        {
            entregada = !entregada;
        }

        public void Revelar()
        {
            revelada = true;
        }

        public bool isEntregada()
        {
            return entregada;
        }

        public bool isRevelada()
        {
            return revelada;
        }

        public override string ToString()
        {
            return $"{numero} de {palo}";
        }
    }
}
