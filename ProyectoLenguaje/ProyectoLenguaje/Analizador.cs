﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLenguaje
{
    public class Analizador
    {
        private LinkedList<Token> salida;
        private int estado;
        String auxiliar;
        public void analizar(RichTextBox textBox)
        {
            String texto = textBox.Text;
            String exp1= "00021310321 ++++++++++++ + ++";
            String exp2 = "123120123";
            String expresionCadenas = "^\"[^\"]*\"$";
            String expresionNumeros = "^(0|([1-9]+[0-9]*))$";
            String expresionCharts = "'.?'";
            String expresionAritmetica = "^(\\+\\+?)$|^(\\-\\-?)$|^(\\*)$|^(\\/)$";
            String expresionRelacional = "^(\\<|\\>)\\=?$|^(\\=|\\!)\\=$";
            String expresionLogica = "^(\\|){1,2}$|^(\\&){1,2}$|^(\\!)$";
            String expresionIdentificador = "^[a-zA-Z1-9-_]*$";

            Regex regex = new Regex(expresionIdentificador);
            MatchCollection match = regex.Matches(texto);
            foreach(Match e in match){
                if (match.Count > 0)
                {
                    textBox.Select(e.Index,e.Length);
                    textBox.SelectionColor = Color.Red;
                }
            }
        }
        public LinkedList<Token> analizador(String entrada)
        {
            String prueba = "0009";
            String reprueba = "123412124000012301";
            entrada = entrada + "#";
            salida = new LinkedList<Token>();
            estado = 0;
            auxiliar = "";
            Char caracter;
            for (int i = 0; i < entrada.Length; i++)
            {
                caracter = entrada.ElementAt(i);
                switch (estado)
                {
                    case 0:

                        break;
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                }

            }
            return null;
        }
    }
}