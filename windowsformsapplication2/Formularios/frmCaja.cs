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
    public partial class frmCaja : Form
    {
        frmMenu fForma2;
        public frmCaja(frmMenu F2)
        {
            InitializeComponent();
            fForma2 = F2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gb_AbrirCaja.Visible = true;
            gb_CerrarCaja.Visible = false;
            gb_Trans.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gb_AbrirCaja.Visible = false;
            gb_CerrarCaja.Visible = false;
            gb_Trans.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gb_AbrirCaja.Visible = false;
            gb_CerrarCaja.Visible = true;
            gb_Trans.Visible = false;
        }

        private void frmCaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            fForma2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pi_resultado = 0;
            try
            {
                Datos.AbrirCaja(Sesion.Log, ref pi_resultado);
                if (pi_resultado > 0)
                {
                    MessageBox.Show("Apertura de caja realizada con exito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No es posible realizar la apertura de caja, es posible que la caja se encuentre abierta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No es posible realizar la apertura de caja, es posible que la caja se encuentre abierta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            int pi_resultado = 0;
            double monto = 0;
            string descripcion = "";
            try
            {
                descripcion = tb_Desc_Trans.Text;
                monto = Convert.ToDouble(tb_MontoTrans.Text);
                if (monto > 0 && descripcion != "")
                {
                    if (rb_Ingreso.Checked)
                    {
                        Datos.IngresoSalidaCaja(monto, 1, descripcion, ref pi_resultado);
                    }
                    else
                    {
                        Datos.IngresoSalidaCaja(monto, -1, descripcion, ref pi_resultado);
                    }
                    if (pi_resultado > 0)
                    {
                        MessageBox.Show("Operación almacenada con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No ha sido posible almacenar la operación, favor intentar de nuevo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El monto ingresado no es válido o fala ingresar la descipción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No ha sido posible almacenar la operación, favor intentar de nuevo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int pi_resultado = 0;
            int pi_resultado2 = 0;
            string ps_Mensaje = "";
            try
            {
                DataTable DT = new DataTable();
                DT = Datos.getUsuarioCaja(ref ps_Mensaje, ref pi_resultado2);
                if (pi_resultado2 >= 0)
                {
                    string usurio = DT.Rows[0]["Usuario_Apertura"].ToString();
                    if (usurio== Sesion.Log)
                    {
                        double monto = Convert.ToDouble(tb_MontoCierre.Text);
                        Datos.CerrarCaja(Sesion.Log, monto, ref pi_resultado);
                        if (pi_resultado > 0)
                        {
                            MessageBox.Show("El cierre de caja se realizado con exito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No es posible realizar el cierre de caja, es posible que la caja no se encuentre abierta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario actual no corresponde con el usuario de apertura de la caja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("La caja no se encuentra abierta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("No es posible realizar el cierre de caja, es posible que la caja no se encuentre abierta o que el monto sea incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formularios.frmConsultaCaja fConsulta;
            fConsulta = new Formularios.frmConsultaCaja(this);
            this.Hide();
            fConsulta.Show();
        }
    }
}
