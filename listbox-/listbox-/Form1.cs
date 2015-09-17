using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in lstColores.SelectedItems)
            {
                int intselectedindex = lstColores.SelectedIndices[0];
                if (intselectedindex == 0)
                {
                    txtColor.BackColor = Color.Blue;
                }
                if (intselectedindex == 1)
                {
                    txtColor.BackColor = Color.Green;
                }
                if (intselectedindex == 2)
                {
                    txtColor.BackColor = Color.Purple;
                }
                if (intselectedindex == 3)
                {
                    txtColor.BackColor = Color.Orange;
                }
            }
        }
    }
}
