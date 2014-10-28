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
    public partial class frmControlUs : Form
    {
        frmMenu fp1;
        frmControlUs fForma2;
        public frmControlUs(frmMenu f1)
        {
            InitializeComponent();
            fp1 = f1;
            fForma2 = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUsuarios fVariable;
            fVariable = new frmUsuarios(); 
            fForma2.Hide();
            fVariable.Show();         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPerfil fVariable;
            fVariable = new frmPerfil();
            fForma2.Hide();
            fVariable.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
         
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
            asocusuario fVariable;
            fVariable = new asocusuario();
            fForma2.Hide();
            fVariable.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            frmMenu F2;
            frmSplash temp;
            temp = new frmSplash();
            F2 = new frmMenu(temp);
            this.Hide();
            F2.Show();
        }
    }
}
