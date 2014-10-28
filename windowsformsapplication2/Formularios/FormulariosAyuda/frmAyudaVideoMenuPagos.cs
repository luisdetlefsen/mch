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
    public partial class frmAyudaVideoMenuPagos : Form
    {
        frmAyudaVideo fForma;
        public frmAyudaVideoMenuPagos(frmAyudaVideo F2)
        {
            InitializeComponent();
            fForma = F2;
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fForma.Show();
        }

        private void frmAyudaVideoMenuPagos_FormClosing(object sender, FormClosingEventArgs e)
        {
            fForma.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Ingresar Pagos SE.wmv", "Ingresar Pagos", this, "Ingresar Pagos.wmv");
            //fvidereproducir = new Formularios.frmReproducirVideo("VideoAdministrarUsuarioPerfilAsociarVersionFinal.mp4", "Registrar Contador", this, "Wildlife.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Eliminar Pago SE.wmv", "Eliminar Pagos", this, "Eliminar Pago.wmv");
            //fvidereproducir = new Formularios.frmReproducirVideo("VideoAdministrarUsuarioPerfilAsociarVersionFinal.mp4", "Registrar Contador", this, "Wildlife.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Abono Adicional Fijo y Porcentual SE.wmv", "Abonos Adicionales", this, "Abono Adicional Fijo y Porcentual.wmv");
            //fvidereproducir = new Formularios.frmReproducirVideo("VideoAdministrarUsuarioPerfilAsociarVersionFinal.mp4", "Registrar Contador", this, "Wildlife.wmv");
            this.Hide();
            fvidereproducir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.frmReproducirVideo fvidereproducir;
            fvidereproducir = new Formularios.frmReproducirVideo("Cobro Adicional Fijo y Porcentual SE.wmv", "Cargos Adicionales", this, "Cobro Adicional Fijo y Porcentual.wmv");
            //fvidereproducir = new Formularios.frmReproducirVideo("VideoAdministrarUsuarioPerfilAsociarVersionFinal.mp4", "Registrar Contador", this, "Wildlife.wmv");
            this.Hide();
            fvidereproducir.Show();
        }
    }
}
