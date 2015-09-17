using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxx_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSeleccion.Text == "azul")
            {
                txtColor.BackColor = Color.Blue;
            }
            if (lbSeleccion.Text == "verde")
            {
                txtColor.BackColor = Color.Green;
            }
            if (lbSeleccion.Text == "rojo")
            {
                txtColor.BackColor = Color.Red;
            }
            if (lbSeleccion.Text == "morado")
            {
                txtColor.BackColor = Color.Purple;
            }
            if (lbSeleccion.Text == "negro")
            {
                txtColor.BackColor = Color.Black;
            }
            if (lbSeleccion.Text == "amarillo")
            {
                txtColor.BackColor = Color.Yellow;
            }
            if (lbSeleccion.Text == "naranja")
            {
                txtColor.BackColor = Color.Orange;
            }
        }
    }
}
