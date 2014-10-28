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
    public partial class frmEliminarPago : Form
    {
        frmPagos fForma2;
        public frmEliminarPago(frmPagos F2)
        {
            InitializeComponent();
            fForma2 = F2;
        }

        private void pbxContador_Click(object sender, EventArgs e)
        {
            try
            {
                frmAyuda AyudaContador;
                AyudaContador = new frmAyuda("Listado de contadores", "B", ref txtIDContador, ref txtDireccionContador);
                AyudaContador.ShowDialog();
            }
            catch
            {
                MessageBox.Show("ERROR EN LA BÚSQUEDA");
            }
        }

        private void frmEliminarPago_FormClosed(object sender, FormClosedEventArgs e)
        {
            fForma2.Show();
        }
        private void txtIDContador_LostFocus(object sender, EventArgs e)
        {
            string ps_mensaje = "";
            try
            {
                
                int pi_resultado = 0;
                dgvPagosRealizados.DataSource = Datos.getPagosGontador(Convert.ToInt32(txtIDContador.Text),ref ps_mensaje, ref pi_resultado);
                dgvPagosRealizados.Columns["ID_Cargo_Abono"].Visible = false;
                dgvPagosRealizados.Columns["ID_Lectura"].Visible = false;
                dgvPagosRealizados.Columns["Tip_Cargo_Abono"].Visible = false;
                dgvPagosRealizados.Columns["Monto"].Visible = false;
                dgvPagosRealizados.Columns["Cargo"].Visible = false;
                dgvPagosRealizados.Columns["Abono"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvPagosRealizados.Columns["Fec_Transac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvPagosRealizados.Columns["Fecha_Lectura"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvPagosRealizados.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
               
            }
            catch (Exception)
            {
                if (txtIDContador.Text!="")
                {
                    MessageBox.Show("No se encuentran datos." + ps_mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el pago seleccionado?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int iResultado = 0;
                    int ID_Cargo_Abono = Convert.ToInt32(dgvPagosRealizados["ID_Cargo_Abono", dgvPagosRealizados.SelectedRows[0].Index].Value);
                    Datos.InsertarBitacoraPagosEliminados(ID_Cargo_Abono, Sesion.Log, ref iResultado);
                    if (iResultado>0)
                    {
                        Datos.EliminarPagoDetalleCaja(ID_Cargo_Abono, ref iResultado);                        
                        if (iResultado>0)
                        {
                            Datos.EliminarPago(ID_Cargo_Abono, ref iResultado);
                            if (iResultado>0)
                            {
                                MessageBox.Show("Pago eliminado exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar correctamente el pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar correctamente el pago.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar correctamente el pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                
            }
        }
    }
}
