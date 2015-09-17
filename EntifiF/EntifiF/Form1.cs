using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntifiF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BDEntityEntities1 contexto = new BDEntityEntities1();

            Usuarios usuario1 = new Usuarios
            {
                Codigo = 2,
                Nombre = "Alberto"
            };

            Articulos articulo1 = new Articulos
            {
                Codigo = 2,
                Cuerpo = "Lorem ipsum 2...",
                Titulo = "Titulo 2"
            };

            Comentarios comentario1 = new Comentarios
            {
                Codigo = 2,
                Cuerpo = "abcde",
                Fecha = DateTime.Today,
                codigoUsuario = usuario1.Codigo,
                codigoArticulo = articulo1.Codigo
            };

            comentario1.Usuarios = usuario1;

            articulo1.Comentarios.Add(comentario1);

            contexto.Usuarios.Add(usuario1);
            contexto.Articulos.Add(articulo1);
            contexto.Comentarios.Add(comentario1);

            contexto.SaveChanges();
        }
    }
}
