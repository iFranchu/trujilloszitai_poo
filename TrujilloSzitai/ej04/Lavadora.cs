using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    class Lavadora : Electrodomestico
    {
        float carga = 5;
        public float Carga { get { return carga; } }

        public Lavadora() { }

        public Lavadora(float precio, float peso) : base(precio, peso) { }

        public Lavadora(float precio, string color, char consumo, float peso, float carga) : base(precio, color, consumo, peso)
        {
            this.carga = carga;
        }

        public override float PrecioFinal()
        {
            float precioFinal = this.PrecioBase;

            if (this.Peso > 30) precioFinal += 50;
            return precioFinal;
        }
    }
}
