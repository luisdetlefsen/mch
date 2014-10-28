using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmMenu : Form
    {
        frmSplash fp1;
        frmMenu fForma2;
        
        public frmMenu(frmSplash f1)
        {
            InitializeComponent();
            fp1 = f1;
            fForma2 = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Datos.VerificaPermiso(Sesion.Log, 1) == 0)
            {
                button1.Visible = false;
            }
            if (Datos.VerificaPermiso(Sesion.Log, 2) == 0)
            {
                button2.Visible = false;
            }
            if (Datos.VerificaPermiso(Sesion.Log, 3) == 0)
            {
                button3.Visible = false;
            }
            if (Datos.VerificaPermiso(Sesion.Log, 4) == 0)
            {
                button4.Visible = false;
            }
            if (Datos.VerificaPermiso(Sesion.Log, 5) == 0)
            {
                button5.Visible = false;
            }
            if (Datos.VerificaPermiso(Sesion.Log, 6) == 0)
            {
                button6.Visible = false;
            }
            if (Datos.VerificaPermiso(Sesion.Log, 7) == 0)
            {
                button7.Visible = false;
            }
            if (Datos.VerificaPermiso(Sesion.Log, 8) == 0)
            {
                button8.Visible = false;
            }
            if (Datos.VerificaPermiso(Sesion.Log, 10) == 0)
            {
                pictureBox2.Visible = false;
                
            }
            if (Datos.VerificaPermiso(Sesion.Log, 9) == 0)
            {
                button9.Visible = false;

            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mntContador fContador;
            fContador = new mntContador(this);
            this.Hide();
            fContador.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mntPersona fPersona;
            fPersona = new mntPersona(this);
            this.Hide();
            fPersona.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mntContrato fContrato;
            fContrato = new mntContrato(this);
            this.Hide();
            fContrato.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mntVariable fVariable;
            fVariable = new mntVariable(this);
            fForma2.Hide();
            fVariable.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int32 iResultado = 0;
            string pruta = "";
            string pnombrearchivo = "";
            pruta = (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.ToString()).Remove(0, 6));
            pnombrearchivo = DateTime.Now.ToString("yyyy-MM-dd hh-mm ") + "MCH.bak";
            //pruta = pruta + "\\MCH.bak";
            pruta = pruta + "\\" + pnombrearchivo;
            Datos.GenerarCopiaSeguridad(pruta, ref iResultado);
            if (iResultado == 3)
            {
                MessageBox.Show("ERROR AL GENERAR COPIA DE SEGURIDAD.");
            }
            else
            {
                MessageBox.Show("SE HA GENERADO EXITOSAMENTE UNA COPIA DE SEGURIDAD EN LA CARPETA: \n" + pruta);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.Formularios.frmLectura fVariable;
            fVariable = new WindowsFormsApplication2.Formularios.frmLectura(this);
            fForma2.Hide();
            fVariable.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmRecibo fRecibo;
            fRecibo = new frmRecibo(this);
            this.Hide();
            fRecibo.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmReporteria fVariable;
            fVariable = new frmReporteria(this);
            fForma2.Hide();
            fVariable.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int pi_Resultado = 0;
            Datos.EstadoCaja(ref pi_Resultado);
            if (pi_Resultado > 0)
            {
                frmPagos fPagos;
                fPagos = new frmPagos(this);
                this.Hide();
                fPagos.Show();
            }
            else
            {
                MessageBox.Show("No se pueden realizar pagos debido a que la caja se encuentra cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmControlUs fVariable;
            fVariable = new frmControlUs(this);
            this.Hide();
            fVariable.Show();   
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmControlCom fComunidad;
            fComunidad = new frmControlCom(this);
            fForma2.Hide();
            fComunidad.Show();
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Formularios.frmCuentaCorriente fCuenta;
            fCuenta = new Formularios.frmCuentaCorriente(this);
            this.Hide();
            fCuenta.Show();
        }

        private void btnCobrosAdicionales_Click(object sender, EventArgs e)
        {

            selectCobroAdicional  fVariable;
            fVariable = new selectCobroAdicional();
          
            fVariable.Show();  
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Formularios.frmCaja fCaja;
            fCaja = new Formularios.frmCaja(this);
            this.Hide();
            fCaja.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Formularios.frmCaja fCaja;
            fCaja = new Formularios.frmCaja(this);
            this.Hide();
            fCaja.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            int pi_Resultado = 0;
            Datos.EstadoCaja(ref pi_Resultado);
            if (pi_Resultado > 0)
            {
                e.Cancel = true;
                MessageBox.Show("No se puede cerrar el programa debido a que la caja se encuentra abierta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Formularios.frmAyudaVideo fvideoayuda;
            fvideoayuda = new Formularios.frmAyudaVideo(this);
            this.Hide();
            fvideoayuda.Show();
        }
    }
}
