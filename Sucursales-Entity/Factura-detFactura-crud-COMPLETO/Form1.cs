using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura_detFactura_crud_COMPLETO
{
    public partial class Form1 : Form
    {
        EntityCollection<DetalleFactura> Productos = new EntityCollection<DetalleFactura>();
        EntityCollection<ClDetalleDG> abd = new EntityCollection<ClDetalleDG>();
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
            errorProvider.Clear();
            if (txtCod_Factura.Text == string.Empty)
            {
                errorProvider.SetError(txtCod_Factura, "Debe agregar un codigo");
            }
            if (txtPrecio.Text == string.Empty)
            {
                errorProvider.SetError(txtPrecio, "Debe ingresar el precio");
            }
            if (txtCantidad.Text == string.Empty)
            {
                errorProvider.SetError(txtCantidad, "Debe ingresar una cantidad");
            }
            if (txtValor_Total.Text == string.Empty)
            {
                errorProvider.SetError(txtValor_Total, "Debe calcular el valor");
            }
            else
            {

                DetalleFactura fac = new DetalleFactura();
                fac.CodFactura = Convert.ToInt32(txtCod_Factura.Text);
                fac.NombreProducto = cbProducto.Text;
                fac.Precio = Convert.ToDecimal(txtPrecio.Text);
                fac.Cantidad = Convert.ToInt32(txtCantidad.Text);

                Productos.Add(fac);

                //int n = dgFactura.Rows.Add();

                dgFactura.DataSource = null;
                dgFactura.DataSource = Productos;

                //dgFactura.Rows[n].Cells[4].Value = txtValor_Total.Text;               

                dgFactura.Columns[0].Visible = false;

                txtCod_Factura.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "";
                txtValor_Total.Text = "";

                ////decimal total = 0;
                ////foreach (DataGridViewRow row in dgFactura.Rows)
                ////{
                ////    total += Convert.ToDecimal(row.Cells["ValorTotal"].Value);
                ////}
                ////txtTotal.Text = Convert.ToString(total);
                ////txtTotal.Refresh();

                decimal total = 0;
                foreach (DataGridViewRow row in dgFactura.Rows)
                {
                    //total += Convert.ToDecimal(row.Cells["ValorTotal"].Value);
                    total += Convert.ToDecimal(row.Cells["Precio"].Value.ToString()) * Convert.ToDecimal(row.Cells["Cantidad"].Value.ToString());
                }
                txtTotal.Text = Convert.ToString(total);

            }
        }

        private void dgFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int identificador = e.RowIndex;
            DetalleFactura contexto = ((DetalleFactura)(dgFactura.Rows[identificador].DataBoundItem));
            if (contexto != null)
            {
                txtCod_Factura.Text = contexto.CodFactura.ToString();
                cbProducto.Text = contexto.NombreProducto;
                //txtCantidad.Text = contexto.Cantidad.ToString();
                //txtPrecio.Text = contexto.Precio.ToString();
                //txtValor_Total.Text = contexto.ValorTotal.ToString();
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

                decimal total = 0;
                foreach (DataGridViewRow row in dgFactura.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Precio"].Value.ToString()) * Convert.ToDecimal(row.Cells["Cantidad"].Value.ToString());
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
            errorProvider.Clear();
            if (txtTotal.Text == string.Empty)
            {
                errorProvider.SetError(txtTotal, "Debe existir una totalidad");
            }
            else
            {
                using (Entidades context = new Entidades())
                {
                    Factura oFactura = new Factura()
                    {
                        CodFactura = Convert.ToInt32(dgFactura.CurrentRow.Cells[0].Value.ToString()),
                        Fecha = dtFecha.Value,
                        Ciudad = cbCiudad.Text,
                        ValorTotal = Convert.ToDecimal(txtTotal.Text),
                        DetalleFactura = Productos
                    };

                    //foreach (var item in Productos)
                    //{
                    //    oFactura.DetalleFactura.Add(new DetalleFactura
                    //        {
                    //            //CodFactura = item.CodFactura,
                    //            NombreProducto = item.NombreProducto,
                    //            Precio = item.Precio,
                    //            Cantidad = item.Cantidad
                    //        });
                    //}
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

        private void dgFactura_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                e.Value = (decimal)dgFactura[2, e.RowIndex].Value * (int)dgFactura[3, e.RowIndex].Value;
            }
            
        }

        private void btnConsultar_Facturas_Click(object sender, EventArgs e)
        {

        }
    }
}
