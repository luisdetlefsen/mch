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
   public partial class asocusuario : Form
    {
       asocusuario fforma;
        public asocusuario()
        {
            InitializeComponent();
            fforma = this;
        }
        public string[] descripcion = new string [100];
        public string[] nombre = new string [100];
        public int[] id = new int[100];
        public string[] NombreUsuario = new string[100];
        public string[] Usuariosid = new string[100];
        public int[] idValida = new int[100];
        public int valores;
        
        private void frmPerfil_Load(object sender, EventArgs e)
        {
            
            int temp=Datos.ObtenerPerfil(ref id, ref nombre, ref descripcion);
            valores = temp;
            for (int i = 0; i < temp; i++)
            {
                comboBox1.Items.Add(nombre[i]);
            }
        }

        public void getPerfilSeleccion(string nombre_seleccion)
        {
            int seleccion;
            for (int i = 0; i < valores; i++)
            {
                if (nombre_seleccion == nombre[i])
                {
                    seleccion = i;
                    i = valores + 1;
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = -1;
            int CantCol = 0;
            for (int i = 0; i < nombre.Length; i++)
            {
                if (comboBox1.Text == nombre[i])
                {
                    seleccion = i;
                    i = nombre.Length + 1;
                }
            }
            label7.Text = descripcion[seleccion];
            CantCol = Datos.ObtenerPerfilUsuarios(id[seleccion], ref Usuariosid, ref NombreUsuario, ref idValida);

            for (int i = 0; i < Usuariosid.Length; i++)
            {
                if (Usuariosid[i] != null)
                {
                    if (idValida[i] == 0)
                    {
                        comboBox2.Items.Add(Usuariosid[i]);
                    }
                    else
                    {
                        listBox1.Items.Add(Usuariosid[i]);
                    }
                }
                else
                {
                    i = Usuariosid.Length + 1;
                }
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int idop=0, idper=0,exito=0;
            if (comboBox1.Text != "")
            {
                for (int i = 0; i < nombre.Length; i++)
                {
                    if (nombre[i] != null)
                    {
                        if (comboBox1.Text == nombre[i])
                        {
                            idper = i;
                            i = +1;
                        }
                    }
                    else
                    {
                        i = nombre.Length + 1;
                    }
                }
                if (comboBox2.Text != "")
                {
                    for (int i = 0; i < Usuariosid.Length; i++)
                    {
                        if (Usuariosid[i] != null)
                        {
                            if (comboBox2.Text == Usuariosid[i])
                            {
                                idop = i;
                                i = Usuariosid.Length + 1;
                            }
                        }
                        else
                        {
                            i = Usuariosid.Length + 1;
                        }
                    }
                    exito = Datos.CrearAsociacionPerfilUsuarios(id[idper], Usuariosid[idop], Sesion.Log);
                    if (exito == 0)
                    {
                        MessageBox.Show("Usuario asociado satisfactoriamente");
                        listBox1.Items.Clear();
                        comboBox2.Items.Clear();
                        Usuariosid = new string[100];
                        NombreUsuario = new string[100];
                        idValida = new int[100];
                        int seleccion = -1;
                        int CantCol = 0;
                        for (int i = 0; i < nombre.Length; i++)
                        {
                            if (comboBox1.Text == nombre[i])
                            {
                                seleccion = i;
                                i = nombre.Length + 1;
                            }
                        }
                        label7.Text = descripcion[seleccion];
                        CantCol = Datos.ObtenerPerfilUsuarios(id[seleccion], ref Usuariosid, ref NombreUsuario, ref idValida);

                        for (int i = 0; i < Usuariosid.Length; i++)
                        {
                            if (Usuariosid[i] != null)
                            {
                                if (idValida[i] == 0)
                                {
                                    comboBox2.Items.Add(Usuariosid[i]);
                                }
                                else
                                {
                                    listBox1.Items.Add(Usuariosid[i]);
                                }
                            }
                            else
                            {
                                i = Usuariosid.Length + 1;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se fue posible realizar la asociación, intentelo más tarde.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe de seleccionar al usuario.");
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el usuario a otorgar permisos.");
            }
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

        private void lblCancelar_Click(object sender, EventArgs e)
        {

        }
    }

      
      
}
