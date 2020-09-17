using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLenguaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerArchivos fileManager = new ManagerArchivos();
            fileManager.Abrir(sender, e, textBox, this);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerArchivos fileManager = new ManagerArchivos();
            fileManager.Guardar(sender, e, textBox, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int variable = 2;
            textBox.Select(variable, 1);
            textBox.SelectionColor = Color.Red;
        }
    }
}
