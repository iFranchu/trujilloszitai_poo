using System;

namespace sep_8_ej02
{
    class Persona
    {
        string nombre;
        public string Nombre { get { return nombre; } set { nombre = ""; } }
        sbyte edad;
        public sbyte Edad { get { return edad; } set { edad = 0; } }
        Int32 dni;
        public Int32 Dni { get { return dni; } }
        char sexo;
        public char Sexo { get { return sexo; } set { sexo = 'H'; } }
        float peso;
        public float Peso { get { return peso; } set { peso = 0; } }
        float altura;
        public float Altura { get { return altura; } set { altura = 0; } }
        float imc;


        public Persona(string nombre, sbyte edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = GenerarDNI();
            if (ComprobarSexo(sexo)) this.sexo = sexo;
            else this.sexo = 'H';
            peso = 0;
            altura = 0;
        }
        public Persona(string nombre, sbyte edad, char sexo, float peso, float altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = GenerarDNI();
            if (ComprobarSexo(sexo)) this.sexo = sexo;
            else this.sexo = 'H';
            this.peso = peso;
            this.altura = altura;
            this.imc = (float)(this.peso / Math.Pow(this.altura, 2));

        }

        public Int16 CalcularIMC()
        {
            if (this.imc < 20) return -1;
            if (this.imc <= 25 && imc >= 20) return 0;
            else return 1;
        }

        public bool EsMayorDeEdad()
        {
            if (this.edad < 18) return false;
            return true;
        }

        private bool ComprobarSexo(char sexo)
        {
            if (this.sexo == 'H' || this.sexo == 'M') return true;
            return false;
        }

        private Int32 GenerarDNI()
        {
            Random random = new Random();
            return Int32.Parse(random.Next(0, 99999999).ToString("D8"));
        }
    }
}
