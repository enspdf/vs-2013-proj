using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            Cargar();
        }

        private void Cargar()
        {
            using (Entidades contexto = new Entidades())
            {
                IQueryable<Banco> Ban = from q in contexto.Banco
                                        select q;
                List<Banco> lista = Ban.ToList();

                DgBanco.DataSource = lista;
                DgBanco.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Entidades contexto = new Entidades())
            {
                Banco oBanco = new Banco
                {
                    CodigoBanco = Convert.ToInt32(txtCodigo.Text),
                    NombreBanco = txtNombre.Text,
                    DireccionPrincipal = txtDireccion.Text,
                    NombreCiudad = cbCiudad.Text
                };

                contexto.Banco.Add(oBanco);
                contexto.SaveChanges();

                Cargar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            using (Entidades contexto = new Entidades())
            {
                int codban = Convert.ToInt32(txtCodigo.Text);
                Banco oBanco = contexto.Banco.Single(b => b.CodigoBanco == codban);

                oBanco.NombreBanco = txtNombre.Text;
                oBanco.DireccionPrincipal = txtDireccion.Text;
                oBanco.NombreCiudad = cbCiudad.Text;

                contexto.SaveChanges();

                Cargar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            using (Entidades contexto = new Entidades())
            {
                int codban = Convert.ToInt32(txtCodigo.Text);
                Banco oBanco = contexto.Banco.Single(b => b.CodigoBanco == codban);

                contexto.Banco.Remove(oBanco);
                contexto.SaveChanges();

                Cargar();
            }
        }

        private void DgBanco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            Banco contexto = ((Banco)(DgBanco.Rows[indice].DataBoundItem));
            txtCodigo.Text = contexto.CodigoBanco.ToString();
            txtNombre.Text = contexto.NombreBanco;
            txtDireccion.Text = contexto.DireccionPrincipal;
            cbCiudad.Text = contexto.NombreCiudad;
        }
    }
}
