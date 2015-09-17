using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPACI2
{
    public partial class Factura : Form
    {
        ClCiudad ciudades = new ClCiudad();
        List<ClCiudad> LCIudades = new List<ClCiudad>();
        List<ClCompra> DatosGrid = new List<ClCompra>();
        public Factura()
        {
            InitializeComponent();
            this.CenterToScreen();

            ClCiudad ciu;

            ciu = new ClCiudad();
            ciu.ciudad = "Medellin";
            LCIudades.Add(ciu);

            ciu = new ClCiudad();
            ciu.ciudad = "Bogota";
            LCIudades.Add(ciu);

            ciu = new ClCiudad();
            ciu.ciudad = "Cali";
            LCIudades.Add(ciu);

            ciu = new ClCiudad();
            ciu.ciudad = "Cartagena";
            LCIudades.Add(ciu);

            ciu = new ClCiudad();
            ciu.ciudad = "Barranquilla";
            LCIudades.Add(ciu);

            ciu = new ClCiudad();
            ciu.ciudad = "Pasto";
            LCIudades.Add(ciu);

            ciu = new ClCiudad();
            ciu.ciudad = "Monteria";
            LCIudades.Add(ciu);

            cbCiudad.DataSource = LCIudades;
            cbCiudad.DisplayMember = "ciudad";


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtCodigo_factura.Text == string.Empty && txtNombre_cliente.Text == string.Empty)
            {
                errorProvider1.SetError(txtCodigo_factura, "Debe ingresar un codigo");
            }
            if (txtNombre_cliente.Text == string.Empty)
            {
                errorProvider1.SetError(txtNombre_cliente, "Debe ingresar un Nombre");
            }
            if (txtId_cliente.Text == string.Empty)
            {
                errorProvider1.SetError(txtId_cliente, "Debe ingresar una identificacion para el cliente");
            }
            if (txtValor_factura.Text == string.Empty)
            {
                errorProvider1.SetError(txtValor_factura, "Debe ingresar un valor");
            }
            if (txtProducto.Text == string.Empty)
            {
                errorProvider1.SetError(txtProducto, "Debe ingresar el Nombre de un producto");
            }
            else
            {
                ClCompra com = new ClCompra();
                com.Cod = txtCodigo_factura.Text;
                com.Cliente = txtNombre_cliente.Text;
                com.Identificacion = txtId_cliente.Text;
                com.Fecha = dtFecha.Text;
                com.Ciudad = cbCiudad.Text;
                com.Valor = txtValor_factura.Text;
                com.Producto = txtProducto.Text;

                DatosGrid.Add(com);
                dgDatos.DataSource = null;
                dgDatos.DataSource = DatosGrid;
                MessageBox.Show("Registro creado correctamente!");
                txtCodigo_factura.Text = "";
                txtId_cliente.Text = "";
                txtNombre_cliente.Text = "";
                txtProducto.Text = "";
                txtValor_factura.Text = "";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo_factura.Text != string.Empty)
            {
                int identificador = DatosGrid.FindIndex(U => U.Cod == txtCodigo_factura.Text);
                ClCompra EditarCompra = DatosGrid[identificador];

                EditarCompra.Cod = txtCodigo_factura.Text;
                EditarCompra.Cliente = txtNombre_cliente.Text;
                EditarCompra.Identificacion = txtId_cliente.Text;
                EditarCompra.Fecha = dtFecha.Text;
                EditarCompra.Ciudad = cbCiudad.Text;
                EditarCompra.Valor = txtValor_factura.Text;
                EditarCompra.Producto = txtProducto.Text;

                DatosGrid[identificador] = EditarCompra;
                dgDatos.DataSource = null;
                dgDatos.DataSource = DatosGrid;

                MessageBox.Show("Registro Modificado Correctamente!");
                txtCodigo_factura.Text = "";
                txtNombre_cliente.Text = "";
                txtId_cliente.Text = "";
                txtValor_factura.Text = "";
                txtProducto.Text = "";
                txtCodigo_factura.Enabled = true;
                btnGuardar.Enabled = true;
                txtId_cliente.Enabled = true;
                //txtIdentificacion.Enabled = true;
                //btnGuardar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una factura");
            }
        }

        private void dgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int identificador = e.RowIndex;
            ClCompra FacturaSeleccionada = ((ClCompra)(dgDatos.Rows[identificador].DataBoundItem));
            if (FacturaSeleccionada != null)
            {
                txtCodigo_factura.Text = FacturaSeleccionada.Cod;
                txtNombre_cliente.Text = FacturaSeleccionada.Cliente;
                txtId_cliente.Text = FacturaSeleccionada.Identificacion;
                dtFecha.Text = FacturaSeleccionada.Fecha;
                cbCiudad.Text = FacturaSeleccionada.Ciudad;
                txtValor_factura.Text = FacturaSeleccionada.Valor;
                txtProducto.Text = FacturaSeleccionada.Producto;

                txtCodigo_factura.Enabled = false;
                txtId_cliente.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo_factura.Text != string.Empty)
            {
                int identificador = DatosGrid.FindIndex(C => C.Cod == txtCodigo_factura.Text);
                ClCompra EliminarCompra = DatosGrid[identificador];
                DatosGrid.Remove(EliminarCompra);
                dgDatos.DataSource = null;
                dgDatos.DataSource = DatosGrid;
                MessageBox.Show("Registro Eliminado Correctamente!");

                txtCodigo_factura.Text = "";
                txtId_cliente.Text = "";
                txtNombre_cliente.Text = "";
                txtProducto.Text = "";
                txtValor_factura.Text = "";

                txtId_cliente.Enabled = true;

                txtCodigo_factura.Enabled = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Factura");
            }
        }

        private void txtCodigo_factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No se pueden ingresar letras, solo numeros");
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("No se pueden ingresar numeros, solo letras");
                e.Handled = true;
                return;
            }
        }

        private void txtId_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No se pueden ingresar letras, solo numeros");
                e.Handled = true;
                return;
            }
        }

        private void txtValor_factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No se pueden ingresar letras, solo numeros");
                e.Handled = true;
                return;
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("No se pueden ingresar numeros, solo letras");
                e.Handled = true;
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId_cliente.Text == string.Empty && txtNombre_cliente.Text == string.Empty)
            {
                dgDatos.DataSource = null;
                dgDatos.DataSource = DatosGrid;
            }
            if (txtId_cliente.Text != string.Empty)
            {
                List<ClCompra> Busquedas = DatosGrid.Where(w => w.Identificacion.Equals(txtId_cliente.Text)).ToList();
                dgDatos.DataSource = null;
                dgDatos.DataSource = Busquedas;
            }
            else if (txtNombre_cliente.Text != string.Empty)
            {
                List<ClCompra> Busquedas = DatosGrid.Where(w => w.Cliente.Contains(txtNombre_cliente.Text)).ToList();
                dgDatos.DataSource = null;
                dgDatos.DataSource = Busquedas;
            }
            else
            {
                MessageBox.Show("No se han encontrado resultados");
                dgDatos.DataSource = null;
                dgDatos.DataSource = DatosGrid;
            }
        }
    }
}

