//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntifiF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comentarios
    {
        public int Codigo { get; set; }
        public int Articulo { get; set; }
        public int Usuario { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Cuerpo { get; set; }
    
        public virtual Articulos Articulos { get; set; }
        public virtual Usuarios Usuarios { get; set; }

        public int codigoArticulo { get; set; }

        public int codigoUsuario { get; set; }
    }
}