using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace applst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            if (lbColores.Text == "verde")
            {
                txtColor.BackColor = Color.Green;
            }
            if (lbColores.Text == "rojo")
            {
                txtColor.BackColor = Color.Red;
            }
            if (lbColores.Text == "azul")
            {
                txtColor.BackColor = Color.Blue;
            }
            if (lbColores.Text == "amarillo")
            {
                txtColor.BackColor = Color.Yellow;
            }
            if (lbColores.Text == "negro")
            {
                txtColor.BackColor = Color.Black;
            }
            
        }
    }
}
