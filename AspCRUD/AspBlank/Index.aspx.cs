using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspBlank
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Deshabilitar();
        }

        void Deshabilitar()
        {
            txtNumero.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtValor.Enabled = false;
            btnGuardar.Enabled = false;
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNumero.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtValor.Enabled = true;
            btnGuardar.Enabled = true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using(var guardar = new EntidadesTest())
            {
                Table1 save = new Table1()
                {
                    NAME = txtNombre.Text,
                    NUMBER = Convert.ToInt32(txtNumero.Text),
                    PHONE = Convert.ToInt32(txtTelefono.Text),
                    VALUE = Convert.ToInt32(txtValor.Text)
                };

                guardar.Table1.Add(save);

                try
                {
                    guardar.SaveChanges();
                    lblResultado.Text = "Guardado Correctamente";
                }
                catch (Exception ex)
                {
                    lblResultado.Text = "Error" + ex;
                }

            }
        }

        
    }
}