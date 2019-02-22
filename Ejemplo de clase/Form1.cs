using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_de_clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Automovil toyota = new Automovil();
            label1.Text = "Su Automovil \n Modelo:" + toyota.modelo + "\n";
            label1.Text +="Color:"+toyota.color + "\n";
            label1.Text += "Fabricante:" + toyota.Fabricante;
        }
    }
}
