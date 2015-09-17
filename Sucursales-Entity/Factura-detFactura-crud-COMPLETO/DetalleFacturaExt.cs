using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura_detFactura_crud_COMPLETO
{
    public class DetalleFacturaExt
    {

        DetalleFactura detalles = new DetalleFactura();

        public decimal ValorTotal
        {
            get
            {
                return this.detalles.Cantidad * this.detalles.Precio;
            }            
        }

        DetalleFactura detalleFactura;

        public DetalleFacturaExt(DetalleFactura detalleFactura)
        {
            this.detalleFactura = detalleFactura;
        }

    }
}
