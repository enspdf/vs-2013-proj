using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_FACTURACION
{
    public partial class RegistrarCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            subtotal.Text = (Convert.ToInt32(precio.Text) * Convert.ToInt32(cantidad.Text)).ToString();
        }
    }
}