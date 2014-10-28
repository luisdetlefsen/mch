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
    public partial class frmAyudaVideoMenuUsuarios : Form
    {
        frmAyudaVideo fForma;
        public frmAyudaVideoMenuUsuarios(frmAyudaVideo F2)
        {
            InitializeComponent();
            fForma = F2;
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fForma.Show();
        }

        private void frmAyudaVideoMenuUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            fForma.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("AdministrarUsuario.mp4", "Manejo de Usuarios", this, "AdministrarUsuario.mp4");
            this.Hide();
            fvidereproducir.Show();
        }
    }
}
