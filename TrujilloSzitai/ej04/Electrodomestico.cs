using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ej04
{
    class Electrodomestico
    {
        float precioBase = 100;
        public float PrecioBase { get { return precioBase; } }
        string color = "blanco";
        public string Color { get { return color; } }
        char consumo = 'F';
        public char Consumo { get { return consumo; } }
        float peso = 5;
        public float Peso { get { return peso; } }
        private string[] colorValores = { "blanco", "negro", "rojo", "azul", "gris" };

        public Electrodomestico() { }
        
        public Electrodomestico(float precio, float peso) {
            this.precioBase = precio;
            this.peso = peso;
        }

        public Electrodomestico(float precio, string color, char consumo, float peso)
        {
            this.precioBase = precio;
            this.color = ComprobarColor(color) ? color.ToLower() : "blanco";
            this.consumo = ComprobarConsumo(Char.ToUpper(consumo)) ? Char.ToUpper(consumo) : 'F';
            this.peso = peso;
        }

        private bool ComprobarConsumo(char valor)
        {
            if (Regex.Match(valor.ToString(), @"^[a-fA-F]{1}$").Success) return true;
            return false;
        }

        private bool ComprobarColor(string valor)
        {
            if (colorValores.Contains(valor.ToLower())) return true;
            return false;
        }

        public virtual float PrecioFinal()
        {
            float precioFinal = this.precioBase;

            precioFinal += 100 - ((int)this.consumo - 65) * 20;

            if (this.peso > 0 && this.peso <= 19) precioFinal += 10;
            else if (this.peso >= 20 && this.peso <= 49) precioFinal += 50;
            else if (this.peso >= 50 && this.peso <= 79) precioFinal += 80;
            else if (this.peso >= 80) precioFinal += 100;

            return precioFinal;
        }

    }
}
