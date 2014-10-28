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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Log;
            Log = Datos.VerificarLogIn(tbUsuario.Text, tbPass.Text);
            if (Log > 0)
            {

                Sesion.Log = tbUsuario.Text;
                frmMenu F2;
                F2 = new frmMenu(this);
                this.Hide();
                F2.Show();
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña no son válidos.", "Atención");
            }
        }
    }
}
