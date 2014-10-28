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
    public partial class mntVariable : Form
    {
        frmMenu fForma2;
        Int32 iIdParametro;
        Int32 iTipParametro;
        string sParametro;
        string sNomParametro;
        string sValor;

        public mntVariable(frmMenu F2)
        {
            InitializeComponent();
            MostrarParametros();
            fForma2 = F2;
            Limpiar();
        }

        private void Limpiar()
        {
            ControlesParametro(true);
            ControlesDatos(false);
            txtNombrePar.Text = "";
            txtValor.Text = "";
            txtValor.BackColor = Color.White;
            lblDescripcion.Text = "Descripción";
        }

        private void MostrarParametros()
        {
            string sMensaje = "";
            Int32 iResultado = 0;
            DataTable dtResultado = new DataTable();

            Datos.MostrarParametros(ref sMensaje, ref iResultado, ref dtResultado);
            if (iResultado == 0)
            {
                if (dtResultado.DefaultView.Count > 0)
                {
                    dgvParametros.DataSource = dtResultado.DefaultView;                   
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRARON RESULTADOS", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("ERROR AL MOSTRAR LOS DATOS", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertarParametro()
        {
            string sMensaje = "";
            Int32 iResultado = 0;
            string sParametroNuevo = "";

            sParametroNuevo = txtValor.Text.Trim();

            Datos.InsertarParametro(iIdParametro, iTipParametro, sParametroNuevo, ref sMensaje, ref iResultado);
            if (iResultado == 0)
            {
                MessageBox.Show("SE HAN GRABADO LOS DATOS EXITOSAMENTE", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (iResultado == -2)
            {
                MessageBox.Show("POR FAVOR INGRESE UN DATO CORRECTO", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("ERROR GRABAR LOS DATOS", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarDatos(Int32 pFila)
        {
            iIdParametro = Convert.ToInt32(dgvParametros["id_parametro", pFila].Value);
            iTipParametro = Convert.ToInt32(dgvParametros["tip_parametro", pFila].Value);
            sNomParametro = dgvParametros["nombre", pFila].Value.ToString();
            sParametro = dgvParametros["parametro", pFila].Value.ToString();
            sValor = dgvParametros["valor", pFila].Value.ToString();
        }

        private void MostrarDatos()
        {
            txtNombrePar.Text = sNomParametro;
            txtValor.Text = sParametro;
            lblDescripcion.Text = sValor;
        }

        private bool CambioDatos(string pDatoNuevo)
        {
            bool bcambio;

            bcambio = false;

            if (string.Compare(sParametro, pDatoNuevo) != 0)
            {
                bcambio = true;
            }

            return bcambio;
        }

        private void ControlesParametro(bool habilitado)
        {
            dgvParametros.Enabled = habilitado;
            pbModificar.Enabled = habilitado;
            lblModificar.Enabled = habilitado;
        }

        private void ControlesDatos(bool habilitado)
        {
            txtValor.Enabled = habilitado;
            lblNombrePar.Enabled = habilitado;
            lblValor.Enabled = habilitado;
            lblDescripcion.Enabled = habilitado;
            pbGuardar.Enabled = habilitado;
            pbCancelar.Enabled = habilitado;
            lblGuardar.Enabled = habilitado;
            lblCancelar.Enabled = habilitado;

        }

        private void ColorDeshabilitado(Label lLabel)
        {
            if (lLabel.Enabled == false)
            {
                lLabel.ForeColor = Color.Silver;
            }
            else
            {
                lLabel.ForeColor = Color.White;
            }

        }

        private bool ValidarParametro(Int32 ai_TipParametro, string as_Parametro)
        {
            double lf_out = -1;
            int li_out = -1;
            bool lb_resultado;

            lb_resultado = false;

            //Porcentajes
            if (ai_TipParametro == 1)
            {
                if (double.TryParse(as_Parametro, out lf_out))
                {
                    if((Convert.ToDouble(as_Parametro) <= 100) && (Convert.ToDouble(as_Parametro) >= 0))
                    {
                        lb_resultado = true;
                    }
                }
            }
            //Dinero
            else if (ai_TipParametro == 4 || ai_TipParametro == 5 || ai_TipParametro == 6 || ai_TipParametro == 7 || ai_TipParametro == 8 || ai_TipParametro == 9)
            {
                if (double.TryParse(as_Parametro, out lf_out))
                {
                    if (Convert.ToDouble(as_Parametro) >= 0)
                    {
                        lb_resultado = true;
                    }
                }
            }
            //Dias
            else if (ai_TipParametro == 2 || ai_TipParametro == 3)
            {
                if (int.TryParse(as_Parametro, out li_out))
                {
                    if ((Convert.ToInt32(as_Parametro) <= 29) && (Convert.ToInt32(as_Parametro) > 0))
                    {
                        lb_resultado = true;
                    }
                }
            }

            return lb_resultado;
        }
        
        private void pbModificar_Click(object sender, EventArgs e)
        {
            GuardarDatos(dgvParametros.CurrentRow.Index);
            MostrarDatos();
            txtValor.BackColor = Color.LightGreen;
            ControlesParametro(false);
            ControlesDatos(true);            
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (CambioDatos(txtValor.Text.Trim()))
            {
                txtValor.BackColor = Color.Yellow;
            }
            else
            {
                txtValor.BackColor = Color.LightGreen;
            }
        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            if(ValidarParametro(iTipParametro, txtValor.Text.Trim()))
            {
                InsertarParametro();
                Limpiar();
                dgvParametros.ClearSelection();
                MostrarParametros();

            }
            else
            {
                MessageBox.Show("POR FAVOR INGRESE UN VALOR CORRECTO","ERROR!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.BackColor = Color.Red;
                txtValor.Focus();
            }
        }

        private void lblModificar_EnabledChanged(object sender, EventArgs e)
        {
            ColorDeshabilitado(lblModificar);
        }

        private void lblGuardar_EnabledChanged(object sender, EventArgs e)
        {
            ColorDeshabilitado(lblGuardar);
        }

        private void lblCancelar_EnabledChanged(object sender, EventArgs e)
        {
            ColorDeshabilitado(lblCancelar);
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            dgvParametros.ClearSelection();
            MostrarParametros();
        }

        private void mntVariable_FormClosing(object sender, FormClosingEventArgs e)
        {
            fForma2.Show();
        }

        private void mntVariable_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmCambiarPassword fCambiarPassword;
            fCambiarPassword = new frmCambiarPassword();
            fCambiarPassword.ShowDialog();
        }
    }
}
