﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura_detFactura_crud_COMPLETO
{
    public class ClDetalleDG
    {
        public int CodFactura { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
