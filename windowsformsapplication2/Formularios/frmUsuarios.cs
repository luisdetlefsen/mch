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
   public partial class frmUsuarios : Form
    {
       frmUsuarios fforma;
        public frmUsuarios()
        {
            InitializeComponent();
            
            fforma = this;
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            String sNombre, sUsuario, sContraseña;
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre de la persona");
                tbNombre.Focus();
            }
            else
            {
                if (tbUsuario.Text == "")
                {
                    MessageBox.Show("Debe ingresar el usuario de la persona");
                    tbUsuario.Focus();
                }
                else
                {
                    if (tbPass.Text == "")
                    {
                        MessageBox.Show("Debe ingresar la contraseña temporal de la persona");
                        tbPass.Focus();
                    }
                    else
                    {
                        int temp;
                        temp=Datos.CrearUsuario(tbNombre.Text,tbUsuario.Text,tbPass.Text,"djfigueroa");
                        switch (temp)
                        {
                            case 0: {
                                        MessageBox.Show("Usuario creado satisfactoriamente");
                                        tbNombre.Text = "";
                                        tbPass.Text="";
                                        tbUsuario.Text="";
                                        break;
                                    }
                            case 1:
                                {
                                    MessageBox.Show("Ha ocurrido un error inesperado, intente más tarde.");
                                    break;
                                }
                            case 2:
                                {
                                    MessageBox.Show("El usuario ya existe, ingrese un nuevo usuario");
                                    tbUsuario.Text = "";
                                    tbUsuario.Focus();
                                    break;
                                }
                            default:
                                {
                                    MessageBox.Show("Ha ocurrido un error inesperado, intente más tarde.");
                                    break;
                                }
                           
                           
                        }
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            frmControlUs fVariable;
            frmSplash fspal = new frmSplash();
            frmMenu f1 = new frmMenu(fspal);
            fVariable = new frmControlUs(f1);
            fforma.Hide();
            fVariable.Show();
        }
    }
}
