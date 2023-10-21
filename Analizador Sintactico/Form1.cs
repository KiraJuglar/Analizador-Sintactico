using System;

namespace Analizador_Sintactico
{
    public partial class Form1 : Form
    {
        List<Token> tokens;
        public Form1()
        {
            InitializeComponent();
        }

        private static List<Token> Analizar(string input)
        {
            string lexema, tipoToken;
            char c;
            List<Token> tokens = new List<Token>();
            input += "$"; // Agregar el símbolo de fin de entrada

            int estado = 0;
            int indice = 0;

            while (indice < input.Length && estado == 0)
            {
                lexema = "";
                tipoToken = "error";
                while (indice < input.Length && estado >= 0)
                {
                    c = input[indice];

                    switch (estado)
                    {
                        case 0:
                            if (char.IsWhiteSpace(c) || c == '\n' || c == '\t')
                            {
                                estado = 0;
                            }
                            else if (c == '|')
                            {
                                estado = 2;
                                lexema += c;
                            }
                            else if (c == '&')
                            {
                                estado = 4;
                                lexema += c;
                            }
                            else if (char.IsLetter(c) || c == '_')
                            {
                                estado = 1;
                                lexema += c;
                                tipoToken = "Id";
                            }
                            else if (c == '=')
                            {
                                estado = 5;
                                lexema += c;
                                tipoToken = "Asignación";
                            }
                            else if (c == '<')
                            {
                                lexema += c;
                                estado = 7;
                                tipoToken = "OpRacional";
                            }
                            else if (c == '>')
                            {
                                lexema += c;
                                estado = 8;
                                tipoToken = "OpRacional";

                            }
                            else if (c == '!')
                            {
                                lexema += c;
                                estado = 10;
                                tipoToken = "OpRacional";
                            }
                            else if (c == '+' || c == '-')
                            {
                                lexema += c;
                                estado = -1;
                                tipoToken = "OpSuma";
                            }
                            else if (c == '/' || c == '*')
                            {
                                lexema += c;
                                estado = -1;
                                tipoToken = "OpMultiplicador";
                            }
                            else if (c == '$')
                            {
                                lexema += c;
                                estado = -1;
                                tipoToken = "Pesos";
                            }
                            else if (c == ',')
                            {
                                lexema += c;
                                estado = -1;
                                tipoToken = "Coma";
                            }
                            else if (c == ';')
                            {
                                lexema += c;
                                estado = -1;
                                tipoToken = "Punto y coma";
                            }
                            else if (c == '.')
                            {
                                lexema += c;
                                estado = -1;
                                tipoToken = "Punto";
                            }
                            else if (c == '{')
                            {
                                lexema += c;
                                estado = -1;
                                tipoToken = "Llave izquierda";
                            }
                            else if (c == '}')
                            {
                                lexema += c;
                                estado = -1;
                                tipoToken = "Llave derecha";
                            }
                            else if (c == '(')
                            {
                                lexema += c;
                                estado = -1;
                                tipoToken = "Parentesis izquierdo";
                            }
                            else if (c == ')')
                            {
                                lexema += c;
                                estado = -1;
                                tipoToken = "Parentesis derecho";
                            }
                            else if (char.IsDigit(c))
                            {
                                lexema += c;
                                estado = 17;
                                tipoToken = "Constante";
                            }
                            else
                            {
                                estado = -1;
                                lexema = c.ToString();
                                tipoToken = "Error";
                            }
                            break;

                        case 1: // Estado para Identificadores
                            if (char.IsLetterOrDigit(c) || c == '_')
                            {
                                estado = 1;
                                lexema += c;
                            }
                            else
                            {
                                estado = -1;
                                indice--;
                            }
                            break;

                        case 2: // Estado para |
                            if (c == '|')
                            {
                                estado = -1;
                                lexema += c;
                                tokens.Add(new Token(lexema, "OpLogico", 15));
                            }
                            else
                            {
                                estado = -1;
                                indice--;
                            }
                            break;

                        case 4: // Estado para &
                            if (c == '&')
                            {
                                estado = -1;
                                lexema += c;
                                tokens.Add(new Token(lexema, "OpLogico", 15));
                            }
                            else
                            {
                                estado = -1;
                                indice--;
                            }
                            break;

                        case 5: // Estado para =
                            if (c == '=')
                            {
                                estado = -1;
                                lexema += c;
                                tokens.Add(new Token(lexema, "OpRacional", 17));
                            }
                            else
                            {
                                estado = -1;
                                indice--;
                            }
                            break;

                        case 7: // Estado para <
                            if (c == '=')
                            {
                                estado = -1;
                                lexema += c;
                                tokens.Add(new Token(lexema, "OpRacional", 17));
                            }
                            else
                            {
                                estado = -1;
                                indice--;
                            }
                            break;

                        case 8: // Estado para >
                            if (c == '=')
                            {
                                estado = -1;
                                lexema += c;
                                tokens.Add(new Token(lexema, "OpRacional", 17));
                            }
                            else
                            {
                                estado = -1;
                                indice--;
                            }
                            break;

                        case 10: // Estado para !
                            if (c == '=')
                            {
                                estado = -1;
                                lexema += c;
                                tokens.Add(new Token(lexema, "OpRacional", 17));
                            }
                            else
                            {
                                estado = -1;
                                indice--;
                            }
                            break;

                        case 17: // Estado para Constantes
                            if (char.IsDigit(c))
                            {
                                tipoToken = "Constante";
                                lexema += c;
                            }
                            else if (char.IsLetter(c) || c == '_')
                            {
                                tipoToken = "Id";
                                estado = 1;
                            }
                            else
                            {
                                estado = -1;
                                indice--;
                            }
                            break;
                    }



                    indice++;
                }
                estado = 0;

                tokens.Add(new Token(lexema, tipoToken, -1));
            }

            foreach (Token t in tokens)
            {
                if (t.Tipo == "Id")
                    t.Tipo = ObtenerTipoToken(t.Lexema);
                t.Numero = ObtenerNumeroToken(t.Tipo);
            }

            return tokens;
        }

        private static string ObtenerTipoToken(string lexema)
        {
            switch (lexema)
            {
                case "if": return "condicional SI";
                case "else": return "condicional SINO";
                case "while": return "Mientras";
                case "return": return "Retorna";
                case "int":
                case "float":
                case "char":
                case "bool":
                case "void": return "Tipo de dato";
                case "true":
                case "false": return "Booleano";
                case "for": return "ciclo for";
                case "switch": return "switch";
                case "case": return "case";
                case "break": return "break";
                default: return "Id";
            }
        }

        private static int ObtenerNumeroToken(string tipoToken)
        {
            switch (tipoToken)
            {
                case "Tipo de dato": return 0;
                case "Id": return 1;
                case "Punto y coma": return 2;
                case "Coma": return 3;
                case "Parentesis izquierdo": return 4;
                case "Parentesis derecho": return 5;
                case "Llave izquierda": return 6;
                case "Llave derecha": return 7;
                case "Asignación": return 8;
                case "condicional SI": return 9;
                case "Mientras": return 10;
                case "Retorna": return 11;
                case "condicional SINO": return 12;
                case "Constante": return 13;
                case "OpSuma": return 14;
                case "OpLogico": return 15;
                case "OpMultiplicador": return 16;
                case "OpRacional": return 17;
                case "Pesos": return 18;
                case "Booleano": return 19;
                case "ciclo for": return 20;
                case "switch": return 21;
                case "case": return 22;
                case "break": return 23;
                default: return -1;
            }
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            string codigo = txtbCodigo.Text;
            tokens = Analizar(codigo);

            lvLexico.Items.Clear();
            txtbCodigo.Clear();
            foreach (Token token in tokens)
            {
                ListViewItem item = new ListViewItem(token.Tipo);
                item.SubItems.Add(token.Lexema);
                item.SubItems.Add(token.Numero.ToString());
                lvLexico.Items.Add(item);
            }
        }
    }
}