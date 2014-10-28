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
    public partial class frmConsultaCaja : Form
    {
        Formularios.frmCaja fForma2;
        public frmConsultaCaja(Formularios.frmCaja F2)
        {
            InitializeComponent();
            fForma2 = F2;
        }

        private void frmConsultaCaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            fForma2.Show();
        }

        private void frmConsultaCaja_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToDateTime(dt_Desde.Value.ToString()) < Convert.ToDateTime(dt_Hasta.Value.ToString())))
                {
                    Formularios.viewConsultaCaja Form;
                    Form = new Formularios.viewConsultaCaja(this, Convert.ToDateTime(dt_Desde.Value.ToString()), Convert.ToDateTime(dt_Hasta.Value.ToString()));
                    this.Hide();
                    Form.Show();
                }
                else
                {
                    MessageBox.Show("Número de contrato o fechas incorrectas, favor revisar la información ingresada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Número de contrato o fechas incorrectas, favor revisar la información ingresada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
