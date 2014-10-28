using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Formularios
{
    public partial class frmCuentaCorriente : Form
    {
        frmMenu fForma2;
        public frmCuentaCorriente(frmMenu F2)
        {
            InitializeComponent();
            fForma2 = F2;
        }

        private void frmCuentaCorriente_FormClosed(object sender, FormClosedEventArgs e)
        {
            fForma2.Show();
        }

        private void frmCuentaCorriente_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToDateTime(dt_Desde.Value.ToString()) < Convert.ToDateTime(dt_Hasta.Value.ToString()))&&(tb_Contrato.Text!=""))
                {
                    Formularios.viewCuentaCorriente Form;
                    Form = new Formularios.viewCuentaCorriente(this, Convert.ToInt32(tb_Contrato.Text), Convert.ToDateTime(dt_Desde.Value.ToString()), Convert.ToDateTime(dt_Hasta.Value.ToString()));
                    this.Hide();
                    Form.Show();
                }
                else
                {
                    MessageBox.Show("Número de contrato o fechas incorrectas, favor revisar la información ingresada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Número de contrato o fechas incorrectas, favor revisar la información ingresada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dt_Desde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string sb_nombre = txtNombreBusqueda.Text;
                string sb_contador = tb_contador.Text;
                bool historial=true;
                DataTable dtc = new DataTable();
                string sp_mensaje=string.Empty;
                int ip_resultado=0;
                Datos.BuscarContrato(sb_nombre, sb_contador, historial, ref sp_mensaje, ref ip_resultado, ref dtc);
                if (ip_resultado >=0)
                {
                    dataGridView1.DataSource = dtc;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se encontraron resultados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Contrato.Text = dataGridView1[0, e.RowIndex].Value.ToString();
        }
    }
}
