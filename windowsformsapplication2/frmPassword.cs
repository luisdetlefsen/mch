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
    public partial class frmPassword : Form
    {        
        frmMenu fForma2;

        public frmPassword(frmMenu F2)
        {
            InitializeComponent();
            fForma2 = F2;
        }

        public void VerificarPassword(string ps_password)
        {
            string sMensaje = "";
            Int32 iResultado = 0;

            if (ps_password.Trim() == "")            
            {
                MessageBox.Show("LA CONTRASEÑA NO ES CORRECTA", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (ps_password.Length > 30)
            {
                MessageBox.Show("LA CONTRASEÑA NO PUEDE SER MAYOR A 30 CARACTERES", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Datos.IngresarPassword(ps_password, ref sMensaje, ref iResultado);

                if (iResultado == 1)
                {
                    PasswordCorrecta();
                }
                else if (iResultado == 0)
                {
                    MessageBox.Show("LA CONTRASEÑA NO ES CORRECTA", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (iResultado == -1)
                {
                    MessageBox.Show("ERROR AL TRATAR DE VERIFICAR CONTRASEÑA", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void PasswordCorrecta()
        {
            mntVariable fVariable;
            fVariable = new mntVariable(fForma2);
            this.Close();
            fForma2.Hide();
            fVariable.Show();
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {
            txt_password.Focus();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            VerificarPassword(txt_password.Text);
        }
    }
}
