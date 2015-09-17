using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects.DataClasses;

namespace Factura_detFactura_crud
{
    public partial class Form1 : Form
    {
        EntityCollection<DetalleFactura> Productos = new EntityCollection<DetalleFactura>();
        //List<DetalleFactura> Productos = new List<DetalleFactura>();
        EntityCollection<DetFactura> detfa = new EntityCollection<DetFactura>();
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            txtValor_Total.Enabled = false;
            txtTotal.Enabled = false;
            dgFactura.AutoGenerateColumns = false;
            cbProducto.SelectedIndex = 0;
            cbCiudad.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == string.Empty || txtCantidad.Text == string.Empty || txtPrecio.Text == string.Empty && txtCantidad.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar valores para calcular");
            }
            else
            {
                txtValor_Total.Text = (Convert.ToInt32(txtPrecio.Text) * (Convert.ToInt32(txtCantidad.Text))).ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtCod_Factura.Text == string.Empty)
            {
                errorProvider1.SetError(txtCod_Factura, "Debe agregar un codigo");
            }
            if (txtPrecio.Text == string.Empty)
            {
                errorProvider1.SetError(txtPrecio, "Debe ingresar el precio");
            }
            if (txtCantidad.Text == string.Empty)
            {
                errorProvider1.SetError(txtCantidad, "Debe ingresar una cantidad");
            }
            if (txtValor_Total.Text == string.Empty)
            {
                errorProvider1.SetError(txtValor_Total, "Debe calcular el valor");
            }
            else
            {
                DetalleFactura fac = new DetalleFactura();
                fac.CodFactura = Convert.ToInt32(txtCod_Factura.Text);
                fac.NombreProducto = cbProducto.Text;
                fac.Precio = Convert.ToInt32(txtPrecio.Text);
                fac.Cantidad = Convert.ToInt32(txtCantidad.Text);
                fac.ValorTotal = Convert.ToInt32(txtValor_Total.Text);

                Productos.Add(fac);
                dgFactura.DataSource = null;
                dgFactura.DataSource = Productos;

                dgFactura.Columns[0].Visible = false;

                txtCod_Factura.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "";
                txtValor_Total.Text = "";

                decimal total = 0;
                foreach (DataGridViewRow row in dgFactura.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["ValorTotal"].Value);
                }
                txtTotal.Text = Convert.ToString(total);
                txtTotal.Refresh();
            }
        }

        //private void Llenar_lista_con_otra()
        //{
        //    DetFactura det = new DetFactura();
        //    det.CodFactura = Convert.ToInt32(dgFactura.CurrentRow.Cells[0].Value.ToString());
        //    det.NombreProducto = dgFactura.CurrentRow.Cells[1].Value.ToString();
        //    det.Precio = Convert.ToInt32(dgFactura.CurrentRow.Cells[2].Value.ToString());
        //    det.Cantidad = Convert.ToInt32(dgFactura.CurrentRow.Cells[3].Value.ToString());

        //    detfa.Add(det);
        //}

        private void dgFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int identificador = e.RowIndex;
            DetalleFactura contexto = ((DetalleFactura)(dgFactura.Rows[identificador].DataBoundItem));
            if (contexto != null)
            {
                txtCod_Factura.Text = contexto.CodFactura.ToString();
                cbProducto.Text = contexto.NombreProducto;
                txtCantidad.Text = contexto.Cantidad.ToString();
                txtPrecio.Text = contexto.Precio.ToString();
                txtValor_Total.Text = contexto.ValorTotal.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCod_Factura.Text != string.Empty)
            {
                var rem = Productos.First(r => r.CodFactura == Convert.ToInt32(txtCod_Factura.Text) && r.NombreProducto == cbProducto.Text);
                if (rem != null)
                {
                    Productos.Remove(rem);
                }

                dgFactura.DataSource = null;
                dgFactura.DataSource = Productos;
                dgFactura.Refresh();
                txtTotal.Refresh();

                //int identificador = Productos.FindIndex(f => f.CodFactura == Convert.ToInt32(txtCod_Factura.Text));
                //DetalleFactura Eliminar = Productos[identificador];

                //Productos.Remove(Eliminar);
                //dgFactura.DataSource = null;
                //dgFactura.DataSource = Productos;

                decimal total = 0;
                foreach (DataGridViewRow row in dgFactura.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["ValorTotal"].Value);
                }
                txtTotal.Text = Convert.ToString(total);
                txtTotal.Refresh();

                MessageBox.Show("Producto eliminado correctamente");
                txtCod_Factura.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "";
                txtValor_Total.Text = "";
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtTotal.Text == string.Empty)
            {
                errorProvider1.SetError(txtTotal, "Debe existir una totalidad");
            }
            else
            {
                using (Entitidades context = new Entitidades())
                {
                    Factura oFactura = new Factura()
                    {

                        CodFactura = Convert.ToInt32(dgFactura.CurrentRow.Cells[0].Value.ToString()),
                        Fecha = dtFecha.Value,
                        Ciudad = cbCiudad.Text,
                        ValorTotal = Convert.ToDecimal(txtTotal.Text),
                        DetalleFactura = Productos
                    };
                    context.Factura.Add(oFactura);
                    context.SaveChanges();
                    MessageBox.Show("Factura registrada correctamente");
                    dgFactura.Rows.Clear();
                    dgFactura.Refresh();
                    txtTotal.Text = "";
                    cbProducto.SelectedIndex = 0;
                    cbCiudad.SelectedIndex = 0;
                    dtFecha.Value = DateTime.Now;
                }
            }            
        }

        private void btnConsultar_Facturas_Click(object sender, EventArgs e)
        {
            ConsultaFacturas consultar = new ConsultaFacturas();
            consultar.Show();
        }
    }
}
