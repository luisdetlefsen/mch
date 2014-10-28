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
    public partial class frmAyudaVideoMenuContratos : Form
    {
        Form Forma;
        public frmAyudaVideoMenuContratos(Form F2)
        {
            InitializeComponent();
            Forma = F2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Buscar Contratos SE.wmv", "Buscar Contrato", this, "Buscar Contratos.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Eliminar Contratos SE.wmv", "Eliminar Contrato", this, "Eliminar Contratos.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Registrar Contratos SE.wmv", "Registrar Contrato", this, "Registrar Contratos.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forma.Show();
        }

        private void frmAyudaVideoMenuContratos_Load(object sender, EventArgs e)
        {

        }

        private void frmAyudaVideoMenuContratos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forma.Show();
        }
    }
}
