using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Formularios.FormulariosAyuda
{
    public partial class frmAyudaVideoMenuContadores : Form
    {
        Form Forma;
        public frmAyudaVideoMenuContadores(Form F2)
        {
            InitializeComponent();
            Forma = F2;
        }

        private void frmAyudaVideoMenuContadores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Buscar Contador SE.wmv", "Buscar Contador", this, "Buscar Contador.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Eliminar Contador SE.wmv", "Eliminar Contador", this, "Eliminar Contador.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Modificar Contador SE.wmv", "Modificar Contador", this, "Modificar Contador.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Registrar Contador SE.wmv", "Registrar Contador", this, "Registrar Contador.wmv");
            //fvidereproducir = new Formularios.frmReproducirVideo("VideoAdministrarUsuarioPerfilAsociarVersionFinal.mp4", "Registrar Contador", this, "Wildlife.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forma.Show();
        }

        private void frmAyudaVideoMenuContadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forma.Show();
        }
    }
}
