using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Formularios
{
    public partial class frmAyudaVideo : Form
    {
        frmMenu fForma2;
        public frmAyudaVideo(frmMenu F2)
        {
            InitializeComponent();
            fForma2 = F2;
        }
        private void pbCancelar_Click(object sender, EventArgs e)
        {
            //frmSplash fspal = new frmSplash();
            //frmMenu f1 = new frmMenu(fspal);
            this.Hide();
            //f1.Show();   
            fForma2.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuContadores fVideoMenuContadores;
            fVideoMenuContadores = new Formularios.FormulariosAyuda.frmAyudaVideoMenuContadores(this);
            this.Hide();
            fVideoMenuContadores.Show();            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuPersonas fVideoMenuPersonas;
            fVideoMenuPersonas = new Formularios.FormulariosAyuda.frmAyudaVideoMenuPersonas(this);
            this.Hide();
            fVideoMenuPersonas.Show();            
            //Formularios.frmReproducirVideo fvidereproducir;
            //fvidereproducir = new Formularios.frmReproducirVideo("VideoAdministrarUsuarioPerfilAsociarVersionFinal.mp4", "Personas", this);
            //this.Hide();
            //fvidereproducir.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuContratos fVideoMenuContratos;
            fVideoMenuContratos = new Formularios.FormulariosAyuda.frmAyudaVideoMenuContratos(this);
            this.Hide();
            fVideoMenuContratos.Show();            
            //Formularios.frmReproducirVideo fvidereproducir;
            //fvidereproducir = new Formularios.frmReproducirVideo("VideoAdministrarUsuarioPerfilAsociarVersionFinal.mp4", "Contratos", this);
            //this.Hide();
            //fvidereproducir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuLecturas fVideoMenuLecturas;
            fVideoMenuLecturas = new Formularios.FormulariosAyuda.frmAyudaVideoMenuLecturas(this);
            this.Hide();
            fVideoMenuLecturas.Show();
            //Formularios.frmReproducirVideo fvidereproducir;
            //fvidereproducir = new Formularios.frmReproducirVideo("VideoAdministrarUsuarioPerfilAsociarVersionFinal.mp4", "Ingreso de Lecturas", this);
            //this.Hide();
            //fvidereproducir.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuPagos fVideoMenuPagos;
            fVideoMenuPagos = new Formularios.FormulariosAyuda.frmAyudaVideoMenuPagos(this);
            this.Hide();
            fVideoMenuPagos.Show();
            //Formularios.frmReproducirVideo fvidereproducir;
            //fvidereproducir = new Formularios.frmReproducirVideo("VideoAdministrarUsuarioPerfilAsociarVersionFinal.mp4", "Pagos", this);
            //this.Hide();
            //fvidereproducir.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuRecibos fVideoMenuRecibos;
            fVideoMenuRecibos = new Formularios.FormulariosAyuda.frmAyudaVideoMenuRecibos(this);
            this.Hide();
            fVideoMenuRecibos.Show();
            //Formularios.frmReproducirVideo fvidereproducir;
            //fvidereproducir = new Formularios.frmReproducirVideo("VideoAdministrarUsuarioPerfilAsociarVersionFinal.mp4", "Generar Comprobantes", this);
            //this.Hide();
            //fvidereproducir.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuReportes fVideoMenuReportes;
            fVideoMenuReportes = new Formularios.FormulariosAyuda.frmAyudaVideoMenuReportes(this);
            this.Hide();
            fVideoMenuReportes.Show();
            //Formularios.frmReproducirVideo fvidereproducir;
            //fvidereproducir = new Formularios.frmReproducirVideo("VideoAdministrarUsuarioPerfilAsociarVersionFinal.mp4", "Reportes", this);
            //this.Hide();
            //fvidereproducir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuCopia fVideoMenuCopia;
            fVideoMenuCopia = new Formularios.FormulariosAyuda.frmAyudaVideoMenuCopia(this);
            this.Hide();
            fVideoMenuCopia.Show();
            //Formularios.frmReproducirVideo fvidereproducir;
            //fvidereproducir = new Formularios.frmReproducirVideo("VideoAdministrarUsuarioPerfilAsociarVersionFinal.mp4", "Copia de seguridad", this);
            //this.Hide();
            //fvidereproducir.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuCuentaCorriente fVideoMenuCuentaCorriente;
            fVideoMenuCuentaCorriente = new Formularios.FormulariosAyuda.frmAyudaVideoMenuCuentaCorriente(this);
            this.Hide();
            fVideoMenuCuentaCorriente.Show();
            //Formularios.frmReproducirVideo fvidereproducir;
            //fvidereproducir = new Formularios.frmReproducirVideo("VideoAdministrarUsuarioPerfilAsociarVersionFinal.mp4", "Cuenta corriente", this);
            //this.Hide();
            //fvidereproducir.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuUsuarios fVideoMenuUsuarios;
            fVideoMenuUsuarios = new Formularios.FormulariosAyuda.frmAyudaVideoMenuUsuarios(this);
            this.Hide();
            fVideoMenuUsuarios.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuComunidad fVideoMenuComunidad;
            fVideoMenuComunidad = new Formularios.FormulariosAyuda.frmAyudaVideoMenuComunidad(this);
            this.Hide();
            fVideoMenuComunidad.Show();
        }

        private void frmAyudaVideo_Load(object sender, EventArgs e)
        {

        }

        private void frmAyudaVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
            fForma2.Show();
        }

        private void btnVirus_Click(object sender, EventArgs e)
        {
            FormulariosAyuda.frmAyudaVideoVirus objElementosAprendizajeWeb;

            objElementosAprendizajeWeb = new FormulariosAyuda.frmAyudaVideoVirus(this);

            this.Hide();
            objElementosAprendizajeWeb.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuCaja fVideoMenuCaja;
            fVideoMenuCaja = new Formularios.FormulariosAyuda.frmAyudaVideoMenuCaja(this);
            this.Hide();
            fVideoMenuCaja.Show();
        }

        private void pBAyudaConf_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuConfiguración fVideoMenuConfiguración;
            fVideoMenuConfiguración = new Formularios.FormulariosAyuda.frmAyudaVideoMenuConfiguración(this);
            this.Hide();
            fVideoMenuConfiguración.Show();
        }

        private void btnAyudaCobrosAdicionales_Click(object sender, EventArgs e)
        {
            Formularios.FormulariosAyuda.frmAyudaVideoMenuCobroAdicional fVideoMenuCobro;
            fVideoMenuCobro = new Formularios.FormulariosAyuda.frmAyudaVideoMenuCobroAdicional(this);
            this.Hide();
            fVideoMenuCobro.Show();
        }
    }
}
