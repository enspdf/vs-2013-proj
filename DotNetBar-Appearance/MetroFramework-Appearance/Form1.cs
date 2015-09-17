using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MetroFramework_Appearance
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            metroTextBox1.PasswordChar = '*';
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Mensaje1", "nombre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MetroMessageBox.Show(this, "Te vas :(");
            }
            else if (result == DialogResult.No)
            {
                MetroMessageBox.Show(this, "Te quedas :D", "Nam",MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        
    }
}
