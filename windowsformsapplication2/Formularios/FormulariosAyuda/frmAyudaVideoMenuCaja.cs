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
    public partial class frmAyudaVideoMenuCaja : Form
    {
        frmAyudaVideo fForma;
        public frmAyudaVideoMenuCaja(frmAyudaVideo F2)
        {
            InitializeComponent();
            fForma = F2;
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fForma.Show();
        }

        private void frmAyudaVideoMenuCaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            fForma.Show();
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Abrir Caja SE.wmv", "Abrir Caja", this, "Abrir Caja.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Cerrar Caja SE.wmv", "Cerrar Caja", this, "Cerrar Caja.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void btnIngresoDinero_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Ingreso de Dinero SE.wmv", "Ingreso de Dinero", this, "Ingreso de Dinero.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void btnSalidaDinero_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Salida de Dinero SE.wmv", "Salida de Dinero", this, "Salida de Dinero.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void btnReporteCaja_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Reporte Caja SE.wmv", "Reporte Caja", this, "Reporte Caja.wmv");
            this.Hide();
            fvidereproducir.Show();
        }
    }
}
