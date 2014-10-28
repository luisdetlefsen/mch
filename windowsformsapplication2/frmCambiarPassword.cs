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
    public partial class frmCambiarPassword : Form
    {
        public frmCambiarPassword()
        {
            InitializeComponent();
        }

        public bool CompararNuevaPass(string ps_NuevaPass, string ps_VerificarPass)
        {
            bool bIgual;

            bIgual = false;

            if (ps_NuevaPass.CompareTo(ps_VerificarPass) == 0)
            {
                bIgual = true;
            }

            return bIgual;
        }

        public void CambiarPassword(string ps_PassActual, string ps_NuevaPass, string ps_VerificarPass)
        {
            string sMensaje;
            Int32 iResultado;

            sMensaje = "";
            iResultado = 0;

            if ((ps_NuevaPass.Trim() == "") || (ps_VerificarPass.Trim() == ""))
            {
                MessageBox.Show("LA NUEVA CONTRASEÑA NO ES CORRECTA", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((ps_NuevaPass.Length > 30) || (ps_VerificarPass.Length > 30))
            {
                MessageBox.Show("LA CONTRASEÑA NO PUEDE SER MAYOR A 30 CARACTERES", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (CompararNuevaPass(ps_NuevaPass.ToUpper().Trim(), ps_VerificarPass.ToUpper().Trim()) == true)
                {
                    Datos.CambiarPassword(ps_PassActual.Trim(), ps_NuevaPass.Trim(), ref sMensaje, ref iResultado);

                    if (iResultado == 1)
                    {
                        MessageBox.Show("LA CONTRASEÑA HA SIDO CAMBIADA EXITOSAMENTE!", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else if (iResultado == 0)
                    {
                        MessageBox.Show("LA CONTRASEÑA ACTUAL NO ES CORRECTA", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (iResultado == -1)
                    {
                        MessageBox.Show("ERROR AL TRATAR DE CAMBIAR LA CONTRASEÑA", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("LA CONTRASEÑA NUEVA NO COINCIDE CON LA VERIFICACIÓN", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            CambiarPassword(txtPassActual.Text, txtPassNueva.Text, txtVerficarPass.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
