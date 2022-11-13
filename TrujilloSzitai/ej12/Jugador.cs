using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    class Jugador
    {
        sbyte id;
        string nombre;
        bool vivo = true;

        public string Nombre { get { return nombre; } }
        public bool Vivo { get { return vivo; } }

        public Jugador(sbyte id) { nombre = $"Jugador {id}"; }

        public bool disparar(Revolver r) {
            if(vivo) vivo = !r.gatillar();
            return vivo;
        }
    }
}
