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
    public partial class frmAyuda : Form
    {

        private string sz_TipoOperacion;
        private TextBox tb_Codigo;
        private TextBox tb_Detalle;
        private DataTable dtResultados;

        /// <summary>
        /// Constructor de la pantalla de busqueda
        /// </summary>
        /// <param name="ps_NombrePantalla">Nombre a desplegar en la pantalla de busqueda</param>
        /// <param name="ps_TipoOperacion">Tipo de operacion a buscar con el SP proxy</param>
        /// <param name="pt_Codigo">Text box donde se incluira el codigo seleccionado</param>
        /// <param name="pt_Detalle">Text box donde se incluira la descripcion del codigo seleccionado</param>
        public frmAyuda(string ps_NombrePantalla, string ps_TipoOperacion, ref TextBox pt_Codigo, ref TextBox pt_Detalle)
        {
            InitializeComponent();

            // Se asigna el nombre de la pantalla principal
            this.Text = ps_NombrePantalla;

            //Se almacenan los datos del tipo de operacion y los controles
            sz_TipoOperacion = ps_TipoOperacion;
            tb_Codigo = pt_Codigo;
            tb_Detalle = pt_Detalle;
        }

        /// <summary>
        /// Obtiene los datos a mostrar en el Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAyuda_Load(object sender, EventArgs e)
        {
            try
            {
                string sMensaje = "";
                int iResultado = 0;

                //Se cargan los datos del Grid que se mostrara
                dtResultados = new DataTable();

                Datos.BuscarAyudaTabla(sz_TipoOperacion, ref sMensaje, ref iResultado, ref dtResultados);
                if (iResultado == 0)
                {
                    dgvListadoAyuda.DataSource = dtResultados.DefaultView;
                }
                else
                {
                    MessageBox.Show(sMensaje.ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Indica que se ha seleccionado un registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListadoAyuda_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //Si la cantidad de registros seleccionados no es uno exactamente, se termina el procedimiento
                if (dgvListadoAyuda.SelectedRows.Count != 1)
                {
                    return;
                }

                //Se asignan los valores seleccionados a los controles del formulario padre
                tb_Codigo.Text = dgvListadoAyuda.SelectedRows[0].Cells[0].Value.ToString();
                tb_Detalle.Text = dgvListadoAyuda.SelectedRows[0].Cells[1].Value.ToString();

                //Se cierra el formulario ya que se ha elegido un valor
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListadoAyuda_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //Si la tecla presionada no es Enter, se termina el procedimiento
                if (e.KeyCode != Keys.Enter) return;

                //Si la cantidad de registros seleccionados no es uno exactamente, se termina el procedimiento
                if (dgvListadoAyuda.SelectedRows.Count != 1) return;

                //Se asignan los valores seleccionados a los controles del formulario padre
                tb_Codigo.Text = dgvListadoAyuda.SelectedRows[0].Cells[0].Value.ToString().Trim();
                tb_Detalle.Text = dgvListadoAyuda.SelectedRows[0].Cells[1].Value.ToString().Trim();

                //Se cierra el formulario ya que se ha elegido un valor
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se recorren todos los registros filtrando segun el valor ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTextoAyuda_TextChanged(object sender, EventArgs e)
        {
            dtResultados.DefaultView.RowFilter = string.Format("id like '%{0}%' or nombre like '%{0}%' or descripcion like '%{0}%'", txtTextoAyuda.Text);
        }

        /// <summary>
        /// Metodo estatico encargado de realizar la busqueda de un registro individual en base a su codigo
        /// Es llamado para complementar a la pantalla de ayuda de los registros
        /// </summary>
        /// <param name="ps_NombrePantalla">Nombre del dato a buscar para usar en mensajes</param>
        /// <param name="ps_TipoOperacion">Tipo de operacion en el SP proxy</param>
        /// <param name="pt_Codigo">TextBox donde se muestra el codigo de busqueda</param>
        /// <param name="pt_Detalle">TextBox donde se muestra la descripcion de ayuda</param>
        public static void BuscarAyudaIndividual(string ps_NombrePantalla, string ps_TipoOperacion, ref TextBox pt_Codigo, ref TextBox pt_Detalle)
        {
            try
            {
                DataTable dtRegistroIndividual;
                string sMensaje = "";
                int iResultado = 0;

                //Si ya se ingreso una vez, activa el control
                if (pt_Codigo.Tag.ToString() == "true")
                {
                    pt_Codigo.Tag = "";
                    return;
                }

                //Se inicializa el nombre del cliente
                pt_Detalle.Text = "";

                //Si no se ha ingresado un valor se termina el procedimiento
                if (pt_Codigo.Text.Trim() == "")
                {
                    return;
                }

                //Se cargan los datos del Grid que se mostrara
                dtRegistroIndividual = new DataTable();

                Datos.BuscarAyudaIndividual(ps_TipoOperacion, pt_Codigo.Text, ref sMensaje, ref iResultado, ref dtRegistroIndividual);
                if (iResultado == 0)
                {
                    if (dtRegistroIndividual.Rows.Count > 0)
                    {
                        pt_Detalle.Text = dtRegistroIndividual.Rows[0][1].ToString();
                    }
                    else
                    {
                        pt_Codigo.Text = "";
                        MessageBox.Show(("No exiten registros asociados al " + ps_NombrePantalla + " ingresado").ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    pt_Codigo.Text = "";
                    MessageBox.Show(sMensaje.ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                pt_Codigo.Text = "";
                MessageBox.Show(ex.Message.ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
