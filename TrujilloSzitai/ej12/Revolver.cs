using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    class Revolver
    {
        List<bool> tambor = new List<bool>(6) { false, false, false, false, false, false };
        sbyte posicionActual = 0;
        bool cargada = false;
        static Random r = new Random();

        public Revolver()
        {
            cargarArma();
        }

        public bool cargarArma()
        {
            if (cargada) return false;
            tambor.Insert(r.Next(0, 6), true);
            return true;
        }

        public bool gatillar()
        {
            return tambor[posicionActual];
        }

        public void rotarTambor()
        {
            if (posicionActual < 5) posicionActual++;
            else posicionActual = 0;
        }

        public override string ToString()
        {
            return $"Tambor en la recámara n° {posicionActual+1}\r\nLa bala se encuentra en la recámara n° {tambor.IndexOf(true) + 1}";
        }
    }
}
