using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    class Television : Electrodomestico
    {
        sbyte pulgadas = 20;
        public sbyte Pulgadas { get { return pulgadas; } }
        bool sintonizador = false;

        public Television() { }

        public Television(float precio, float peso) : base(precio, peso) { }

        public Television(float precio, string color, char consumo, float peso, sbyte pulgadas, bool sintonizador) : base(precio, color, consumo, peso)
        {
            this.pulgadas = pulgadas;
            this.sintonizador = sintonizador;
        }

        public override float PrecioFinal()
        {
            float precioFinal = this.PrecioBase;
            if (this.pulgadas > 40) precioFinal += (precioFinal * 30) / 100;
            if (this.sintonizador) precioFinal += 50;
            return precioFinal;
        }
    }
}
