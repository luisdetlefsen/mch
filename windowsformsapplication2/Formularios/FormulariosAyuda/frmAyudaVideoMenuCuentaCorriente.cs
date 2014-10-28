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
    public partial class frmAyudaVideoMenuCuentaCorriente : Form
    {
        frmAyudaVideo fForma;
        public frmAyudaVideoMenuCuentaCorriente(frmAyudaVideo F2)
        {
            InitializeComponent();
            fForma = F2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Cuenta Corriente SE.wmv", "Cuenta Corriente", this, "Cuenta Corriente.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fForma.Show();
        }

        private void frmAdudaVideoMenuCuentaCorriente_FormClosing(object sender, FormClosingEventArgs e)
        {
            fForma.Show();
        }
    }
}
