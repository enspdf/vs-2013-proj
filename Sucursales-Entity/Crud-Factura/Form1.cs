using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            CargarDatos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            DgFactura.AutoGenerateColumns = false;
            List<Factura> fac = null;
            using (Entitidades contexto = new Entitidades())
            {
                fac = (from q in contexto.Factura
                       select q).ToList();                                
            }

            DgFactura.DataSource = fac;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtCodigo.Text == string.Empty)
            {
                errorProvider1.SetError(txtCodigo, "Digite un codigo");
            }
            if (txtValorTotal.Text == string.Empty)
            {
                errorProvider1.SetError(txtValorTotal, "Digite el total");
            }
            if (cbCiudad.Text == string.Empty)
            {
                errorProvider1.SetError(cbCiudad, "Seleccione una ciudad");
            }
            else
            {
                using (Entitidades contexto = new Entitidades())
                {
                    Factura oFactura = new Factura()
                    {
                        CodFactura = Convert.ToInt32(txtCodigo.Text),
                        Fecha = dtFecha.Value,
                        ValorTotal = Convert.ToDecimal(txtValorTotal.Text),
                        Ciudad = cbCiudad.Text
                    };

                    contexto.Factura.Add(oFactura);
                    contexto.SaveChanges();
                    CargarDatos();
                    MessageBox.Show("Registo Ingresado Correctamente");
                    txtCodigo.Text = "";
                    txtValorTotal.Text = "";
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty)
            {
                using (Entitidades contexto = new Entitidades())
                {
                    int codFactura = Convert.ToInt32(txtCodigo.Text);
                    Factura oFactura = contexto.Factura.Single(f => f.CodFactura == codFactura);

                    oFactura.Fecha = dtFecha.Value;
                    oFactura.ValorTotal = Convert.ToDecimal(txtValorTotal.Text);
                    oFactura.Ciudad = cbCiudad.Text;

                    contexto.SaveChanges();
                    CargarDatos();

                    MessageBox.Show("Registro Modificado Correctamente");
                };
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Registro");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty)
            {
                using (Entitidades contexto = new Entitidades())
                {
                    int codFactura = Convert.ToInt32(txtCodigo.Text);
                    Factura oFactura = contexto.Factura.Single(f => f.CodFactura == codFactura);

                    contexto.Factura.Remove(oFactura);
                    contexto.SaveChanges();
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Registro");
            }
        }

        private void DgFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int identificador = e.RowIndex;
            Factura contexto = ((Factura)(DgFactura.Rows[identificador].DataBoundItem));
            txtCodigo.Text = contexto.CodFactura.ToString();
            dtFecha.Value = contexto.Fecha;
            txtValorTotal.Text = contexto.ValorTotal.ToString();
            cbCiudad.Text = contexto.Ciudad;
        }
    }
}
