using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace sep_8_ej03
{
    class Password
    {
                string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        sbyte longitud = 8;
        public sbyte Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        string contraseña;
        public string Contraseña { get { return contraseña; } }

        // Regex regex = new Regex("^(?=.*[A-Za-z])(?=.*%d)(?=.*[@$!%*#?&])[A-Za-z%d@$!%*#?&]{8,}$");
        string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!#$%&/()='?¿*+~{}[]^"; // Caracteres a usar para generar la contraseña

        public Password(string name, sbyte longitud)
        {
            this.longitud = longitud;
            this.nombre = name;
            this.contraseña = GenerarPassword(this.longitud).ToString();
        }

        public sbyte EsFuerte() // Método ligeramente distinto al de la consigna para retornar un sbyte y en base a eso realizar un análisis de la seguridad
        {
            sbyte cantMayus = 0;
            sbyte cantNum = 0;
            sbyte sec = 0;
            for (sbyte i = 0; i < contraseña.Length; i++)
            {
                if (Char.IsUpper(contraseña[i])) cantMayus++; // Analizando caracter por caracter
                if (Char.IsDigit(contraseña[i])) cantNum++;
            }
            if (contraseña.Length > 8) sec++;
            if (cantMayus > 2) sec++;
            if (cantNum > 5) sec++;
            if (contraseña.Any(Char.IsLower)) sec++;
            return sec;
        }
        public StringBuilder GenerarPassword(sbyte longitud)
        {
            StringBuilder password = new StringBuilder(); // String mutable
            Random random = new Random();
            while (0 < longitud--)
            {
                password.Append(caracteres[random.Next(caracteres.Length)]);
            }
            return password;
        }
    }
}
