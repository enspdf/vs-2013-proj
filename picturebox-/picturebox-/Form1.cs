using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbOpciones_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbOpciones.Text == "camara")
            {
                pbImagenes.Image = Image.FromFile(@"C:\Users\Sebastian-pc\Desktop\phtss\visual\camera.png");
            }
            if (lbOpciones.Text == "mensaje")
            {
                pbImagenes.Image = Image.FromFile(@"C:\Users\Sebastian-pc\Desktop\phtss\visual\message.png");
            }
            if (lbOpciones.Text == "telefono")
            {
                pbImagenes.Image = Image.FromFile(@"C:\Users\Sebastian-pc\Desktop\phtss\visual\phone.png");
            }
            if (lbOpciones.Text == "rss")
            {
                pbImagenes.Image = Image.FromFile(@"C:\Users\Sebastian-pc\Desktop\phtss\visual\rss.png");
            }
            if (lbOpciones.Text == "compartir")
            {
                pbImagenes.Image = Image.FromFile(@"C:\Users\Sebastian-pc\Desktop\phtss\visual\share.png");
            }
        }
    }
}
