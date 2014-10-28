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
   public partial class frmPerfil : Form
    {
       frmPerfil fforma;
        public frmPerfil()
        {
            InitializeComponent();
            fforma = this;
        }
        public string[] descripcion = new string [100];
        public string[] nombre = new string [100];
        public int[] id = new int[100];
        public string[] NombreOpcion = new string[100];
        public int[] Opcionesid = new int[100];
        public int[] idValida = new int[100];
        public int valores;
        private void pbGuardar_Click(object sender, EventArgs e)
        {
            
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del perfil");
                tbNombre.Focus();
            }
            else
            {
                if (tbDescripción.Text == "")
                {
                    MessageBox.Show("Debe ingresar la descripción del perfil");
                    tbDescripción.Focus();
                }
                else
                {
                        int temp;
                        temp = Datos.CrearPerfil(tbNombre.Text, tbDescripción.Text, Sesion.Log);
                        switch (temp)
                        {
                            case 0: {
                                        MessageBox.Show("Perfil creado satisfactoriamente");
                                        tbNombre.Text = "";
                                        tbDescripción.Text="";
                                        id = new int[100];
                                        nombre = new string[100];
                                        descripcion = new string[100];
                                        comboBox1.Items.Clear();
                                        int temp2 = Datos.ObtenerPerfil(ref id, ref nombre, ref descripcion);
                                        valores = temp2;
                                        for (int i = 0; i < temp2; i++)
                                        {
                                            comboBox1.Items.Add(nombre[i]);
                                        }
                                        break;
                                    }
                            case 1:
                                {
                                    MessageBox.Show("Ha ocurrido un error inesperado, intente más tarde.");
                                    break;
                                }
                            case 2:
                                {
                                    MessageBox.Show("El Perfil ya existe, ingrese un nuevo usuario");
                                    tbNombre.Text = "";
                                    tbNombre.Focus();
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
            CantCol = Datos.ObtenerPerfilOpciones(id[seleccion], ref Opcionesid, ref NombreOpcion, ref idValida);

            for (int i = 0; i < NombreOpcion.Length; i++)
            {
                if (NombreOpcion[i] != null)
                {
                    if (idValida[i] == 0)
                    {
                        comboBox2.Items.Add(NombreOpcion[i]);
                    }
                    else
                    {
                        listBox1.Items.Add(NombreOpcion[i]);
                    }
                }
                else
                {
                    i = NombreOpcion.Length + 1;
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
                    for (int i = 0; i < NombreOpcion.Length; i++)
                    {
                        if (NombreOpcion[i] != null)
                        {
                            if (comboBox2.Text == NombreOpcion[i])
                            {
                                idop = i;
                                i = NombreOpcion.Length + 1;
                            }
                        }
                        else
                        {
                            i = NombreOpcion.Length + 1;
                        }
                    }
                    exito = Datos.CrearAsociacionPerfilOpcion(id[idper], Opcionesid[idop], Sesion.Log);
                    if (exito == 0)
                    {
                        MessageBox.Show("Opción asociada satisfactoriamente");
                        listBox1.Items.Clear();
                        comboBox2.Items.Clear();
                        NombreOpcion = new string[100];
                        Opcionesid = new int[100];
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
                        CantCol = Datos.ObtenerPerfilOpciones(id[seleccion], ref Opcionesid, ref NombreOpcion, ref idValida);

                        for (int i = 0; i < NombreOpcion.Length; i++)
                        {
                            if (NombreOpcion[i] != null)
                            {
                                if (idValida[i] == 0)
                                {
                                    comboBox2.Items.Add(NombreOpcion[i]);
                                }
                                else
                                {
                                    listBox1.Items.Add(NombreOpcion[i]);
                                }
                            }
                            else
                            {
                                i = NombreOpcion.Length + 1;
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
                    MessageBox.Show("Debe de seleccionar la opción.");
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el perfil a otorgar permisos.");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int idop = 0, idper = 0, exito = 0;
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
                    for (int i = 0; i < NombreOpcion.Length; i++)
                    {
                        if (NombreOpcion[i] != null)
                        {
                            if (comboBox2.Text == NombreOpcion[i])
                            {
                                idop = i;
                                i = NombreOpcion.Length + 1;
                            }
                        }
                        else
                        {
                            i = NombreOpcion.Length + 1;
                        }
                    }
                    exito = Datos.CrearAsociacionPerfilOpcion(id[idper], Opcionesid[idop], Sesion.Log);
                    if (exito == 0)
                    {
                        MessageBox.Show("Opción asociada satisfactoriamente");
                        listBox1.Items.Clear();
                        comboBox2.Items.Clear();
                        NombreOpcion = new string[100];
                        Opcionesid = new int[100];
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
                        CantCol = Datos.ObtenerPerfilOpciones(id[seleccion], ref Opcionesid, ref NombreOpcion, ref idValida);

                        for (int i = 0; i < NombreOpcion.Length; i++)
                        {
                            if (NombreOpcion[i] != null)
                            {
                                if (idValida[i] == 0)
                                {
                                    comboBox2.Items.Add(NombreOpcion[i]);
                                }
                                else
                                {
                                    listBox1.Items.Add(NombreOpcion[i]);
                                }
                            }
                            else
                            {
                                i = NombreOpcion.Length + 1;
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
                    MessageBox.Show("Debe de seleccionar la opción.");
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el perfil a otorgar permisos.");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            String nombreopcion;
            
            int idop = 0, idper = 0, exito = 0;
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

                nombreopcion = listBox1.Text;
                if (nombreopcion != "")
                {
                    exito = Datos.DesasociarOpcion(idper,nombreopcion);
                    if (exito==0)
                    {
                        MessageBox.Show("Opciòn desasociada satisfactoriamente");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error. intentelo mas tarde.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe de seleccionar la opcion a desasociar.");
                }

            }
            else
            {
                MessageBox.Show("Debe de el perfil.");
            }
        }
    }

      
      
}
