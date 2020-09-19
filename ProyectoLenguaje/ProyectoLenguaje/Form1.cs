﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            fileManager.Abrir(sender, e, textBox, this, "gt");
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerArchivos fileManager = new ManagerArchivos();
            fileManager.Guardar(sender, e, textBox, this, "gt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Analizador analizador = new Analizador();
            analizador.analizar(textBox);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
            textBox.SelectionColor = Color.Black;

        }

        private void tipografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fuentes.ShowDialog() == DialogResult.OK)
            {
                textBox.SelectionFont = fuentes.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colores.ShowDialog() == DialogResult.OK)
            {
                textBox.SelectionColor = colores.Color;
            }
        }

        private void erroresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Error error = new Error();
            error.Visible = true;
        }
    }
}
