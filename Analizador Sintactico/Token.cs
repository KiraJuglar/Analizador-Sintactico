using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_Sintactico
{
    internal class Token
    {
        public string Lexema { get; set; }
        public string Tipo { get; set; }
        public int Numero { get; set; }

        public Token(string lexema, string tipo, int numero)
        {
            Lexema = lexema;
            Tipo = tipo;
            Numero = numero;
        }
    }
}
