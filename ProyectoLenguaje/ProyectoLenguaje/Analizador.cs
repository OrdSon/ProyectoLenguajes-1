using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLenguaje
{
    class Analizador
    {
        private const string expresion = @"\+{1,3}";
        public void colorearSymbolos(RichTextBox textBox)
        {
            String lol = "++ + + + + ++ ++ + + ++ asdasd qweqwe +++ ++ + ";
            MatchCollection encontrados = Regex.Matches(textBox.Text, expresion);
            if (encontrados.Count > 0)
            {
                foreach (Match match in encontrados)
                {   
                    if (match.Value.Length >= 3)
                    {
                        textBox.Select(match.Index, match.Length);
                        textBox.SelectionColor = Color.Red;
                    }
                    else
                    {
                        textBox.Select(match.Index, match.Length);
                        textBox.SelectionColor = Color.Green;
                    }
                    
                }
            }
        }
    }
}
