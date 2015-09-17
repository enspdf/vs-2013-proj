using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura_CRUD_extrayendo_DATAGRID
{
    public class DetalleFacturaExt
    {
        public int CodFactura { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
