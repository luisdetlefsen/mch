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
    public partial class frmControlCom : Form
    {
        
        MCH_CN CN = new MCH_CN();
        frmMenu fForma2;

        public frmControlCom(frmMenu F2)
        {
            InitializeComponent();
            fForma2 = F2;
        }

        private void frmControlCom_FormClosed(object sender, FormClosedEventArgs e)
        {
            fForma2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gb_ingresar.Visible = true;
            gb_actualizar.Visible = false;
            gb_eliminar.Visible = false ;

            txt_cargo_comunidad_actualizar.Text = "";
            txt_nombre_comunidad_actualizar.Text = "";

            txt_cargo_comunidad_insertar.Text = "";
            txt_nombre_comunidad_insertar.Text = "";

            
            txt_nombre_comunidad_elimina.Text = "";


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gb_ingresar.Visible = false;
            gb_actualizar.Visible = true;
            gb_eliminar.Visible = false;

            txt_cargo_comunidad_actualizar.Text = "";
            txt_nombre_comunidad_actualizar.Text = "";

            txt_cargo_comunidad_insertar.Text = "";
            txt_nombre_comunidad_insertar.Text = "";

            
            txt_nombre_comunidad_elimina.Text = "";
            String ls_mensaje = "";
            Int32 li_resultado = 0;
            txt_nombre_comunidad_actualizar.DataSource = Datos.getComunidades(-1, ref ls_mensaje, ref li_resultado);
            txt_nombre_comunidad_actualizar.DisplayMember = "Nombre";
            txt_nombre_comunidad_actualizar.ValueMember = "id_comunidad";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gb_ingresar.Visible = false;
            gb_actualizar.Visible = false;
            gb_eliminar.Visible = true;

            txt_cargo_comunidad_actualizar.Text = "";
            txt_nombre_comunidad_actualizar.Text = "";

            txt_cargo_comunidad_insertar.Text = "";
            txt_nombre_comunidad_insertar.Text = "";

            
            txt_nombre_comunidad_elimina.Text = "";
            String ls_mensaje = "";
            Int32 li_resultado = 0;
            txt_nombre_comunidad_elimina.DataSource = Datos.getComunidades(-1, ref ls_mensaje, ref li_resultado);
            txt_nombre_comunidad_elimina.DisplayMember = "Nombre";
            txt_nombre_comunidad_elimina.ValueMember = "id_comunidad";
        }

        private void frmControlCom_Load(object sender, EventArgs e)
        {
            gb_ingresar.Visible = false;
            gb_actualizar.Visible = false;
            gb_eliminar.Visible = false;

            txt_cargo_comunidad_actualizar.Text = "";
            txt_nombre_comunidad_actualizar.Text = "";

            txt_cargo_comunidad_insertar.Text = "";
            txt_nombre_comunidad_insertar.Text = "";


            txt_nombre_comunidad_elimina.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_insertar_Click(object sender, EventArgs e)
        {
            try
            {

            

            if (txt_nombre_comunidad_insertar.Text=="" || cb_hidroelectrica_insertar.Text=="" || txt_cargo_comunidad_insertar.Text=="")
            {
                MessageBox.Show("Si usted desea ingresar una nueva comunidad, por favor ingrese todos los campos");
            }
            else
            {

            

            string vchrnombrecomunidad = txt_nombre_comunidad_insertar.Text;
            int id_hidroelectrica=0;
            switch (cb_hidroelectrica_insertar.Text)
            {
                case "Hidroelectrica \"Las Conchas\"":
                    id_hidroelectrica = 1;
                    break;
                case "Hidroelectrica \"Jolom Ijix\"":
                    id_hidroelectrica = 2;
                    break;
                case "Hidroelectrica \"Seasir\"":
                    id_hidroelectrica = 3;
                    break;
            }
            int cargo_comunidad = Convert.ToInt16(txt_cargo_comunidad_insertar.Text);

            DialogResult msg = new DialogResult();

            msg = MessageBox.Show("Usted insertará una nueva comunidad:\nNombre: " + vchrnombrecomunidad + "\n" + cb_hidroelectrica_insertar.Text + "\nCon Cuota Fija: " + cargo_comunidad.ToString() + "\n            ¿Es correcto?", "Mensaje", MessageBoxButtons.YesNo);

            if (msg.ToString()=="Yes")
            {
                CN.Ejecutar_stored_procedure_insertar_comunidad("sp_InsertarComunidad", vchrnombrecomunidad, id_hidroelectrica, cargo_comunidad);
                MessageBox.Show("Comunidad Creada con exito");
            }


            }
            }
            catch 
            {

                MessageBox.Show("Ha ocurrido un error");
            }

        }

        private void pictureBox4_elimina_Click(object sender, EventArgs e)
        {
            try
            {

          
             if (txt_nombre_comunidad_elimina.Text=="")
            {
                MessageBox.Show("Si usted desea eliminar una nueva comunidad, por favor ingrese todos los campos");
            }
            else
            {

            
            int id_hidroelectrica=0;
            String vchrnombrecomunidad = txt_nombre_comunidad_elimina.Text;

            DialogResult msg = new DialogResult();
            
            msg = MessageBox.Show("Usted eliminará la comunidad:\nNombre: " + vchrnombrecomunidad + "\n            ¿Es correcto?", "Mensaje", MessageBoxButtons.YesNo);

            if (msg.ToString()=="Yes")
            {
                
                CN.Ejecutar_stored_procedure_eliminar_comunidad("sp_EliminarComunidad",vchrnombrecomunidad, 0);
                MessageBox.Show("Comunidad Elimindad con Exito");
                String ls_mensaje = "";
                Int32 li_resultado = 0;
                txt_nombre_comunidad_elimina.DataSource = Datos.getComunidades(-1, ref ls_mensaje, ref li_resultado);
                txt_nombre_comunidad_elimina.DisplayMember = "Nombre";
                txt_nombre_comunidad_elimina.ValueMember = "id_comunidad";
                
            
            }
            }

            }
            catch
            {

                MessageBox.Show("Ha ocurrido un error");
            }
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            try
            {

           
            if (txt_nombre_comunidad_actualizar.Text=="" || txt_cargo_comunidad_actualizar.Text=="")
            {
                MessageBox.Show("Si usted desea actualizar una nueva comunidad, por favor ingrese todos los campos");
            }
            else
            {

            string vchrnombrecomunidad = txt_nombre_comunidad_actualizar.Text;
            int id_hidroelectrica=0;
            
            int cargo_comunidad = Convert.ToInt16(txt_cargo_comunidad_actualizar.Text);
            DialogResult msg = new DialogResult();

            msg = MessageBox.Show("Usted insertará una nueva comunidad:\nNombre: " + vchrnombrecomunidad + "\n" +"\nCon Cuota Fija: " + cargo_comunidad.ToString() + "\n            ¿Es correcto?", "Mensaje", MessageBoxButtons.YesNo);

            if (msg.ToString()=="Yes")
            {
          
            CN.Ejecutar_stored_procedure_actualizar_comunidad("sp_ActualizarComunidad", vchrnombrecomunidad, 0, cargo_comunidad);
            MessageBox.Show("Comunidad Actualizada con Exito");
            String ls_mensaje = "";
            Int32 li_resultado = 0;
            txt_nombre_comunidad_actualizar.DataSource = Datos.getComunidades(-1, ref ls_mensaje, ref li_resultado);
            txt_nombre_comunidad_actualizar.DisplayMember = "Nombre";
            txt_nombre_comunidad_actualizar.ValueMember = "id_comunidad";
              
            }
            }

            }
            catch
            {

                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void frmControlCom_FormClosed_1(object sender, FormClosedEventArgs e)
        {

        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
}
}
