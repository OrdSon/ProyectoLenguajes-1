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
        public void algo()
        {
            string lol = "";
            int numero = 0;
            char algo = 'a';
            for(int i = 0; i<10; i++)
            {
                i++;
            }
            while (true)
            {
                int lolito = 0;
            }
             
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            Open.Filter = "Codigo [*.gt*]|*.gt|All Files [*,*]|*,*";
            Open.CheckFileExists = true;
            Open.Title = "Abrir Archivo";
            Open.ShowDialog(this);
            try
            {
                Open.OpenFile();
                myStreamReader = System.IO.File.OpenText(Open.FileName);
                textBox.Text = myStreamReader.ReadToEnd();

            }
            catch (Exception) 
            { 
            
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            Save.Filter = "Codigo (*.gt)|*.gt|All files(*.*)|*.*";
            Save.CheckPathExists = true;
            Save.Title = "Guardar como";
            Save.ShowDialog(this);
            try
            {
                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                myStreamWriter.Write(textBox.Text);
                myStreamWriter.Flush();

            }
            catch (Exception) 
            { 
            
            }

        }
    }
}
