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
    public partial class frmAyudaVideoMenuPersonas : Form
    {
        Form Forma;
        public frmAyudaVideoMenuPersonas(Form F2)
        {
            InitializeComponent();
            Forma = F2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Registrar Persona SE.wmv", "Registrar Persona", this, "Registrar Persona.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Buscar Persona SE.wmv", "Buscar Persona", this,"Buscar Persona.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Modificar Persona SE.wmv", "Modificar Persona", this, "Modificar Persona.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Eliminar Persona SE.wmv", "Eliminar Persona", this, "Eliminar Persona.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forma.Show();
        }

        private void frmAyudaVideoMenuPersonas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forma.Show();
        }
    }
}
