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
    public partial class frmAyudaVideoMenuLecturas : Form
    {
        frmAyudaVideo fForma;
        public frmAyudaVideoMenuLecturas(frmAyudaVideo F2)
        {
            InitializeComponent();
            fForma = F2;
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fForma.Show();
        }

        private void frmAyudaVideoMenuLecturas_FormClosing(object sender, FormClosingEventArgs e)
        {
            fForma.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Ingreso Lectura SE.wmv", "Ingresar Lectura", this, "Ingreso Lectura.wmv");
            this.Hide();
            fvidereproducir.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Eliminar Lectura SE.wmv", "Eliminar Lectura", this, "Eliminar Lectura.wmv");
            this.Hide();
            fvidereproducir.Show();
        }
    }
}
