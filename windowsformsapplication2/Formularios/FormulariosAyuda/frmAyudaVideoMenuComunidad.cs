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
    public partial class frmAyudaVideoMenuComunidad : Form
    {
        frmAyudaVideo fForma;
        public frmAyudaVideoMenuComunidad(frmAyudaVideo F2)
        {
            InitializeComponent();
            fForma = F2;
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fForma.Show();
        }

        private void frmAyudaVideoMenuComunidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            fForma.Show();
        }

        private void btnRegistrarComunidad_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Registrar Comunidad SE.wmv", "Registrar Comunidad", this, "Registrar Comunidad.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void btnEliminarComunidad_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Eliminar Comunidad SE.wmv", "Eliminar Comunidad", this, "Eliminar Comunidad.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void btnModificarComunidad_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Modificar Comunidad SE.wmv", "Modificar Comunidad", this, "Modificar Comunidad.wmv");
            this.Hide();
            fvidereproducir.Show();
        }
    }
}
