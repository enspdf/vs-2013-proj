using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_objeto
{
    public partial class Hospitaal : Form
    {
        public Hospitaal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hospital hp = new Hospital();
            hp.nombre = txtNom_hos.Text = "Pablo Tobón Uribe";
            hp.direccion = txtDir_hos.Text ="calle 43 A 43-09";
            hp.secciones = txtSec.Text = "5";
            hp.medicos = txtN_med.Text = "30";
            hp.enfermeras = txtN_enf.Text = "17";
            
            Especialidad ep = new Especialidad();
            ep.especiali1 = txtEspe1.Text ="Neurologia";
            ep.eespeciali2 = txtEspe2.Text="Cirujano";
            ep.especiali3 = txtEspe3.Text="Ortopedista";
            ep.especiali4 = txtEspe4.Text="Cardiologia";
            ep.especiali5 = txtEspe5.Text="Oncologia";

            Habitacion hb = new Habitacion();
            hb.hospital = txtHos_hab.Text = txtNom_hos.Text;
            hb.ciudad = txtCiu_hos.Text = "Medellín";
            hb.piso = txtPiso.Text = "3";
            hb.numero = txtNum_pis.Text = "301 - A";
            hb.tipo = txtTipo.Text = "Cuidados intensivos";

            Farmacia fm = new Farmacia();
            fm.nombre = txtNom_far.Text = "Farmacia Tobón Uribe";
            fm.ciudad = txtCiu_far.Text = txtCiu_hos.Text;
            fm.direccion = txtDir_far.Text = txtDir_hos.Text;
            fm.medicamento = txtMedicamento.Text = "Aspirinas 100 Mg";
            fm.precio = txtPrecio.Text = "500";

            Paciente pa = new Paciente();
            pa.nombre = txtNom_pac.Text = "Alberto";
            pa.apellido = txtAp_pac.Text = "Martinez Hernandez";
            pa.documento = txtNum_pac.Text = "30945298";
            pa.edad = txtEd_pac.Text = "27";
            pa.ciudad = txtCiu_pac.Text = txtCiu_hos.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
