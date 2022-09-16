using System;

namespace sep_8_ej01
{
    class Cuenta
    {
        string titular;
        string Titular { get { return titular; } set { titular = value; } }
        double cantidad { get { return cantidad; } set { cantidad = value; } }
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public Cuenta(string titular)
        {
            this.titular = titular;
        }

        public bool Ingresar(double ingreso)
        {
            if (ingreso <= 0) return false;
            this.cantidad += ingreso;
            return true;
        }

        public bool Retirar(double retiro)
        {
            if (this.cantidad - retiro < 0) return false;
            this.cantidad -= retiro;
            return true;
        }

        public double MostrarSaldo()
        {
            return this.cantidad;
        }

    }
}
