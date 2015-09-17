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
    public partial class ConsultaFacturas : Form
    {
        public ConsultaFacturas()
        {
            InitializeComponent();
            this.CenterToScreen();
            dgConsultar_Facturas.RowHeadersVisible = false;
            CargarFacturas();
        }

        private void CargarFacturas()
        {
            //EntityCollection<Factura> facturas = null;

            dgConsultar_Facturas.AutoGenerateColumns = false;
            using(Entitidades contexto = new Entitidades())
            {
                var fac = new List<Factura>(contexto.Factura);
                fac = (from q in contexto.Factura
                           select q).ToList();
                //facturas = (from q in contexto.Factura
                //            select q).To();                
                dgConsultar_Facturas.DataSource = fac;
            }
            
        }
    }    
}
