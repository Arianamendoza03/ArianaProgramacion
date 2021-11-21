using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArianaProgramación
{
    public partial class RevezPalabras : Form
    {
        public RevezPalabras()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Entrada = textBox1.Text;
            string Salida = "";
            for (int x = Entrada.Length - 1; x >= 0; x--)
            {
                Salida += Entrada[x];
            }
            Console.WriteLine($"{0}", Salida);
            this.textBox2.Text = Salida.ToString();

        }
    }
}
