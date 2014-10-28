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
    public partial class frmAyudaVideoVirus : Form
    {
        Form Forma;
        public frmAyudaVideoVirus(Form F2)
        {
            InitializeComponent();
            Forma = F2;
        }

        private void frmAyudaVideoVirus_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormulariosAyuda.frmElementosAprendizajeWeb fvidereproducir;
            fvidereproducir = new FormulariosAyuda.frmElementosAprendizajeWeb(this,1);
            this.Hide();
            fvidereproducir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormulariosAyuda.frmElementosAprendizajeWeb fvidereproducir;
            fvidereproducir = new FormulariosAyuda.frmElementosAprendizajeWeb(this,2);
            this.Hide();
            fvidereproducir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormulariosAyuda.frmElementosAprendizajeWeb fvidereproducir;
            fvidereproducir = new FormulariosAyuda.frmElementosAprendizajeWeb(this,3);
            this.Hide();
            fvidereproducir.Show();
        }

    
        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forma.Show();
        }

        private void frmAyudaVideoVirus_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forma.Show();
        }
    }
}
