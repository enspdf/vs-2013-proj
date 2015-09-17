using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucursales_Entity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entities contexto = new Entities();

            Banco ban = new Banco
            {
                Nombre = txtNom_ban.Text,
                Codbanco = int.Parse(txtCod_Ban.Text)
            };

            Sucursal suc = new Sucursal
            {
                CodSucursal = int.Parse(txtCod_suc.Text),
                DireccionSuc = txtDir_suc.Text,
                Nombre = txtNom_suc.Text,
                CodBanco = ban.Codbanco
            };

            suc.Banco = ban;

            contexto.Banco.Add(ban);
            contexto.Sucursal.Add(suc);

            contexto.SaveChanges();
        }
    }
}
