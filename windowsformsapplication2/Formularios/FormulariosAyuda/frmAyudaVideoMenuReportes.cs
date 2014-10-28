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
    public partial class frmAyudaVideoMenuReportes : Form
    {
        frmAyudaVideo fForma;
        public frmAyudaVideoMenuReportes(frmAyudaVideo F2)
        {
            InitializeComponent();
            fForma = F2;

        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fForma.Show();
        }

        private void frmAyudaVideoMenuReportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            fForma.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Reportes.wmv", "Manejo Reportes", this, "Reportes.wmv");
            this.Hide();
            fvidereproducir.Show();
        }
    }
}
