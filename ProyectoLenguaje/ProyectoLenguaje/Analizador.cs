using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLenguaje
{
    public class Analizador
    {

        LinkedList<Token> tokens;
        Regex regexCadenas = new Regex("\"([^\"]*)\" | '([^']*)'");
        Regex regexEnteros = new Regex("^(0|([1-9]+[0-9]*))$");
        Regex regexBoolean = new Regex("^(true)$|^(false)$");
        Regex regexDecimal = new Regex("^(0|([1-9]+[0-9]*)\\.[0-9]+)$");
        Regex regexChart = new Regex("(\'.?\'){1}");
        Regex regexAritmetica = new Regex("^(\\+\\+?)$|^(\\-\\-?)$|^(\\*)$|^(\\/)$");
        Regex regexRelacional = new Regex("^(\\<|\\>)\\=?$|^(\\=|\\!)\\=$");
        Regex regexLogica = new Regex("^(\\|){1,2}$|^(\\&){1,2}$|^(\\!)$");
        Regex regexIdentificador = new Regex("^[a-zA-Z1-9-_]*$");
        Regex regexReservadas = new Regex("^(SI)(NO)?(_SI)?$|^(MIENTRAS)$|^(HACER)$|^(PARA)$|^(HASTA)$|^(DESDE)$|^(INCREMENTO)$");
        Regex regexTipoObjeto = new Regex("^(Entero)$|^(Decimal)$|^(Cadena)$|^(Boolean)$|^(Chart)$");

        public void colorear (TextBox textBox)
        {
            MatchCollection cadenasEncontradas = regexCadenas.Matches(textBox.Text);
            MatchCollection enterosEncontrados = regexEnteros.Matches(textBox.Text);
            MatchCollection booleanEncontradas = regexBoolean.Matches(textBox.Text);
            MatchCollection decimalesEncontradas = regexDecimal.Matches(textBox.Text);
            MatchCollection chartsEncontradas = regexChart.Matches(textBox.Text);
            MatchCollection aritmeticasEncontradas = regexAritmetica.Matches(textBox.Text);
            MatchCollection relacionalEncontradas = regexRelacional.Matches(textBox.Text);
            MatchCollection logicaEncontradas = regexLogica.Matches(textBox.Text);
            MatchCollection identificadoresEncontrados = regexIdentificador.Matches(textBox.Text);
            MatchCollection reservadasEncontradas = regexReservadas.Matches(textBox.Text);
            MatchCollection tiposEncontrados = regexTipoObjeto.Matches(textBox.Text);
           
        }
        public void analizar(RichTextBox textBox)
            {
            tokens = new LinkedList<Token>();
            Token.Tipo tipo = new Token.Tipo();
            String[] separadores = {" ", "\\s+",";", "\t" };
            if (textBox.Lines.Length <= 0)
            {
                MessageBox.Show("Sin texto que analizar");
                return;
            }
            for(int i = 0; i < textBox.Lines.Length; i++)
            {
                String [] linea = textBox.Lines[i].Split(separadores, System.StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < linea.Length; j++)
                {
                    String valor = linea[j];
                     if (regexDecimal.IsMatch(valor))
                    {
                        tipo = Token.Tipo.VALOR_DECIMAL;
                        colorear(valor, textBox, Color.SkyBlue);
                    }
                    else if (regexEnteros.IsMatch(valor))
                    {
                        tipo = Token.Tipo.VALOR_ENTERO;
                        colorear(valor, textBox, Color.Yellow);
                    }
                    else if (regexBoolean.IsMatch(valor))
                    {
                        tipo = Token.Tipo.VALOR_BOOLEAN;
                        colorear(valor, textBox, Color.Orange);
                    }
                    else if (regexAritmetica.IsMatch(valor))
                    {
                        tipo = Token.Tipo.OPERADOR_ARITMETICO;
                        colorear(valor, textBox, Color.Blue);
                    }
                    else if (regexRelacional.IsMatch(valor))
                    {
                        tipo = Token.Tipo.OPERADOR_RELACIONAL;
                        colorear(valor, textBox, Color.Blue);
                    }
                    else if (regexLogica.IsMatch(valor))
                    {
                        tipo = Token.Tipo.OPERADOR_LOGICO;
                        colorear(valor, textBox, Color.Blue);
                    }
                    else if (regexTipoObjeto.IsMatch(valor))
                    {
                        tipo = Token.Tipo.TIPO_OBJETO;
                        colorear(valor, textBox, Color.DarkBlue);
                    }
                    else if (regexReservadas.IsMatch(valor))
                    {
                        tipo = Token.Tipo.PALABRA_RESERVADA;
                        colorear(valor, textBox, Color.Green);
                    }
                    else if (regexIdentificador.IsMatch(valor))
                    {
                        tipo = Token.Tipo.IDENTIFICADOR;
                        colorear(valor, textBox, Color.DarkGray);
                    }
                    
                    else
                    {
                        tipo = Token.Tipo.ERROR;
                    }
                    tokens.AddLast(new Token(tipo, valor, (i+1)));
                }
            }

            MatchCollection cadenasEncontradas = regexCadenas.Matches(textBox.Text);
            foreach(Match e in cadenasEncontradas)
            {
                tokens.AddLast(new Token(Token.Tipo.VALOR_CADENA, e.Value, e.Index));
                textBox.Select(e.Index, e.Length);
                textBox.SelectionColor = Color.Purple;
            }
            MatchCollection charsEncontrados = regexChart.Matches(textBox.Text);
            foreach (Match e in charsEncontrados)
            {
                tokens.AddLast(new Token(Token.Tipo.VALOR_CHART, e.Value, e.Index));
                textBox.Select(e.Index, e.Length);
                textBox.SelectionColor = Color.Yellow;
            }

        }
        private void colorear(String valor, RichTextBox textBox, Color color)
        {
            if(valor == null)
            {
                return;
            }
            if (valor == "+" | valor == "-" | valor == "/" | valor == "*" | valor == "++" | valor == "--")
            {
                valor = "\\" + valor;
            }
            Regex regex = new Regex(valor);
            MatchCollection encontrados = regex.Matches(textBox.Text);
            if (!regex.IsMatch(textBox.Text))
            {
                return;
            }
            foreach (Match e in encontrados)
            {
                textBox.Select(e.Index, valor.Length);
                textBox.SelectionColor = color;
            }
        }
    }
}