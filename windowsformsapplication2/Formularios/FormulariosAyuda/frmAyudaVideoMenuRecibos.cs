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
    public partial class frmAyudaVideoMenuRecibos : Form
    {
        frmAyudaVideo fForma;
        public frmAyudaVideoMenuRecibos(frmAyudaVideo F2)
        {
            InitializeComponent();
            fForma = F2;
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fForma.Show();
        }

        private void frmAyudaVideoMenuRecibos_FormClosing(object sender, FormClosingEventArgs e)
        {
            fForma.Show();
        }

        private void btnGenerarComp_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Generar Recibos SE.wmv", "Generar Comprobantes", this, "Generar Recibos.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void btnComprobantes_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Presentacion Recibos SE.wmv", "Presentación de Recibos", this, "Presentacion Recibos.wmv");
            this.Hide();
            fvidereproducir.Show();
        }
    }
}
