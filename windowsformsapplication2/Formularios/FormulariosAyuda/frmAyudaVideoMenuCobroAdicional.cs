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
    public partial class frmAyudaVideoMenuCobroAdicional : Form
    {
        frmAyudaVideo fForma;
        public frmAyudaVideoMenuCobroAdicional(frmAyudaVideo F2)
        {
            InitializeComponent();
            fForma = F2;
        }

        private void btnAbono_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Abonos Adicionales SE.wmv", "Abonos Adicionales", this, "Abonos Adicionales.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Cargos Adicionales SE.wmv", "Cargos Adicionales", this, "Cargos Adicionales.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void btnModificarCobro_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Modificar Cobro Adicional SE.wmv", "Modificar Cobro Adicional", this, "Modificar Cobro Adicional.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void btnEliminarCobro_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Eliminar Cobro Adicional SE.wmv", "Eliminar Cobro Adicional", this, "Eliminar Cobro Adicional.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fForma.Show();
        }

        private void frmAyudaVideoMenuCobroAdicional_FormClosing(object sender, FormClosingEventArgs e)
        {
            fForma.Show();
        }
    }
}
