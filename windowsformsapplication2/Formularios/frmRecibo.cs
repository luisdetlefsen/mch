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
    public partial class frmRecibo : Form
    {
        frmMenu fForma2;

        public frmRecibo(frmMenu F2)
        {
            InitializeComponent();
            fForma2 = F2;
        }




        private void pbGuardar_Click(object sender, EventArgs e)
        {
            viewRecibo Form;
            Form = new viewRecibo(this, comboBox1.SelectedIndex + 1, Convert.ToInt32(numericUpDown1.Value), comboBox1.Text, comboBox2.Text);
            this.Hide();
            Form.Show();


        }

        private void frmRecibo_FormClosed(object sender, FormClosedEventArgs e)
        {
            fForma2.Show();
        }

        private void frmRecibo_Load(object sender, EventArgs e)
        {
            String ls_mensaje = "";
            Int32 li_resultado = 0;
            comboBox2.DataSource = Datos.getComunidades(-1, ref ls_mensaje, ref li_resultado);
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "id_comunidad";

            comboBox1.SelectedIndex = DateTime.Today.Month - 1;
            numericUpDown1.Value = DateTime.Today.Year;
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
