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
    public partial class mntContador : Form
    {
        frmMenu fForma2;
        Boolean gb_NuevoContador;
        Boolean gb_BuscaContdor;
        public mntContador(frmMenu F2)
        {
            InitializeComponent();
            fForma2 = F2;
            OcultaMostrarrControlesIngreso(false);
            OcultarMostrarPB(false);
            //obtener los datos de las comunidades


        }
        private void mntPersona_FormClosed(object sender, FormClosedEventArgs e)
        {
            fForma2.Show();
        }
        #region CONTROLES

            private void OcultaMostrarrControlesIngreso(Boolean  bCambio)
            {
                txtPoste.Visible = bCambio;
                txtDirección.Visible = bCambio;
                txtCodigob.Visible = bCambio;
                lblCodigo.Visible = bCambio;
                cmbComunidad.Visible = bCambio;
                cmbTipoServicio.Visible = bCambio;
                lblComunidad.Visible = bCambio;
                lbTipoServ.Visible = bCambio;
                lblPoste.Visible = bCambio;
                lblDireccion.Visible = bCambio;
                LimpiarControlesIngreso();
            }
            private void LimpiarControlesIngreso()
            {
                txtPoste.Text = "";
                txtDirección.Text = "";
                txtCodigob.Text = "";
            }
            private void BloquearDesbloquearControlesIngreso(Boolean bCambio) 
            {
                txtPoste.Enabled = bCambio;
                txtDirección.Enabled = bCambio;
                txtCodigob.Enabled = bCambio;
            }
            private void OcultarMostrarPB(Boolean bCambio)
            {
                
                pbEliminar.Visible = bCambio;
                pbGuardar.Visible = bCambio;
                pbCancelar.Visible = bCambio;
                lblEliminar.Visible = bCambio;
                lblGuardar.Visible = bCambio;
                lblCancelar.Visible = bCambio;
            }
   

        #endregion

        private void pbNuevoContador_Click(object sender, EventArgs e)
        {
            txtcodigoBusca.Text = string.Empty;
            gb_NuevoContador = true;
            gb_BuscaContdor = false;
            OcultaMostrarrControlesIngreso(true);
            OcultarMostrarPB(false);
            BloquearDesbloquearControlesIngreso(true);
            pbGuardar.Visible = true;
            lblGuardar.Visible = true;
            pbCancelar.Visible = true;
            lblCancelar.Visible = true;
            txtCodigob.Enabled = true;
            cmbComunidad.Enabled = true;
            cmbTipoServicio.Enabled = true;
            if (cmbComunidad.Items.Count > 0)
            {
                cmbComunidad.SelectedIndex = 0;
            }
            if (cmbTipoServicio.Items.Count > 0)
            {
                cmbTipoServicio.SelectedIndex = 0;
            }
           
         
           
        }

        private void CrearContador() 
        {

                Int32 iResultado = 0;
                string sMensaje = string.Empty;
                string sNoContador = txtCodigob.Text;
                string sDireccion = txtDirección.Text;
                string sNo_poste = txtPoste.Text;
                Int32 iComunidad = Convert.ToInt32(cmbComunidad.SelectedValue);
                Int32 iTipoServicio = Convert.ToInt32(cmbTipoServicio.SelectedValue);
                Boolean bGrabar = true;
                if (sNoContador.Trim() == "")
                {
                    MessageBox.Show("DEBE INGRESAR EL CÓDIGO DEL CONTADOR");
                    bGrabar = false;
                }
                if (bGrabar)
                {
                    Datos.CrearContador(sNoContador, sDireccion, sNo_poste, iComunidad, iTipoServicio, ref sMensaje, ref iResultado);
                    if (iResultado >= 1)
                    {
                        MessageBox.Show("EL CONTADOR SE CREÓ CORRECTAMENTE.");
                        BloquearDesbloquearControlesIngreso(false);
                        OcultarMostrarPB(false);
                        txtCodigob.Enabled = false;
                        cmbComunidad.Enabled = false;
                        cmbTipoServicio.Enabled = false;
                    }
                    else if (iResultado == -2)
                    {
                        MessageBox.Show("EL CÓDIGO DE CONTADOR YA EXISTE, NO PUEDE ALMACENAR DOS CONTADORES CON EL MISMO CÓDIGO.");
                    }
                    else
                    {
                        MessageBox.Show("ERROR, INTENTE DE NUEVO. " + sMensaje);
                    }
                }
            

        }
        private void ModificarContador()
        {
            Int32 iResultado = 0;
            string sMensaje = string.Empty;
            string sNoContador = txtCodigob.Text;
            string sDireccion = txtDirección.Text;
            string sNo_poste = txtPoste.Text;
            Int32 iTipoServicio = Convert.ToInt32(cmbTipoServicio.SelectedValue);
            Int32 iComunidad = Convert.ToInt32(cmbComunidad.SelectedValue);
            Boolean bGrabar = true;
            if (sNoContador.Trim() == "")
            {
                MessageBox.Show("DEBE INGRESAR EL CÓDIGO DEL CONTADOR");
                bGrabar = false;
            }
            if (bGrabar)
            {
                Datos.ModificarContador(sNoContador, sDireccion, sNo_poste, iComunidad, iTipoServicio, ref sMensaje, ref iResultado);
                if (iResultado > 0)
                {
                    MessageBox.Show("EL CONTADOR SE MODIFICÓ CORRECTAMENTE.");
                    txtCodigob.Enabled = false;
                }
                else
                {
                    MessageBox.Show("ERROR, INTENTE DE NUEVO. " + sMensaje);
                }
            }
        }
        private void EliminarContador()
        {
            Int32 iResultado = 0;
            string sMensaje = "";
            String sCodigoContador = txtCodigob.Text;
            DialogResult drResultado = MessageBox.Show("A CONTINUACIÓN SE ELIMINARÁ EL CONTADOR  " + sCodigoContador.ToUpper() + " ¿DESEA CONTINUAR?", "ELIMINACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drResultado == DialogResult.Yes)
            {
                Datos.EliminarContador(sCodigoContador, ref sMensaje, ref iResultado);
                if (iResultado == 1)
                {
                    MessageBox.Show("EL CONTADOR FUE ELIMINADO EXITOSAMENTE");
                }
                else
                {
                    MessageBox.Show("ERROR EN LA ELIMINACIÓN. " + sMensaje);
                }
            }
            LimpiarControlesIngreso();
            OcultaMostrarrControlesIngreso(false); ;
            OcultarMostrarPB(false);
        }
        private void BuscarContador()
        {
            string sDatosBusqueda = "";
            string sMensaje = "";
            Int32 iResultado = 0;
            DataTable dtResultado = new DataTable();
            sDatosBusqueda =  txtcodigoBusca.Text.Trim();
            LimpiarControlesIngreso();
            if (sDatosBusqueda.Length > 0)
            {
                Datos.BuscarContador(sDatosBusqueda, ref sMensaje, ref iResultado, ref dtResultado);
                if (iResultado == 0)
                {
                    if (dtResultado.DefaultView.Count > 0)
                    {
                       
                        OcultaMostrarrControlesIngreso(true);
                        OcultarMostrarPB(false);
                        BloquearDesbloquearControlesIngreso(true);
                        OcultarMostrarPB(true);
                        txtCodigob.Enabled = true;
                        gb_NuevoContador = false;
                      
                        txtCodigob.Text = dtResultado.Rows[0]["ID_contador"].ToString();
                        txtDirección.Text = dtResultado.Rows[0]["Direccion"].ToString();
                        txtPoste.Text = dtResultado.Rows[0]["No_poste"].ToString();
                        cmbComunidad.SelectedValue = dtResultado.Rows[0]["ID_comunidad"].ToString();
                        cmbTipoServicio.SelectedValue = dtResultado.Rows[0]["tipo_servicio"].ToString();
                        cmbTipoServicio.Enabled = true;
                        cmbComunidad.Enabled = true;
                        txtCodigob.Enabled = false;
                    }
                    else
                    {
                        OcultaMostrarrControlesIngreso(false);
                        OcultarMostrarPB(true);
                        BloquearDesbloquearControlesIngreso(false);
                        OcultarMostrarPB(false);
                        txtCodigob.Enabled = false;
                        gb_NuevoContador = true;
                        MessageBox.Show("NO SE ENCONTRARON RESULTADOS");
                    }
                }
                else
                {
                    OcultaMostrarrControlesIngreso(false);
                    OcultarMostrarPB(true);
                    BloquearDesbloquearControlesIngreso(false);
                    OcultarMostrarPB(false);
                    txtCodigob.Enabled = false;
                    gb_NuevoContador = true;
                    MessageBox.Show("ERROR EN LA BÚSQUEDA. " + sMensaje);
                }
            }
            else {
                MessageBox.Show("INGRESE UN CÓDIGO PARA REALIZAR LA BÚSQUEDA");
            }
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            OcultaMostrarrControlesIngreso(false);;
            OcultarMostrarPB(false);
            txtcodigoBusca.Text = txtCodigob.Text; 
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gb_NuevoContador = false;
                gb_BuscaContdor = true;
                BuscarContador();
            }
            catch 
            {
                MessageBox.Show("ERROR, SE PRODUJO UN ERROR AL REALIZAR LA OPERACIÓN");
            }
        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gb_NuevoContador)
                {
                    CrearContador();
                }
                else if (gb_BuscaContdor)
                {
                    ModificarContador();
                }
            }
            catch 
            {
                MessageBox.Show("ERROR, SE PRODUJO UN ERROR AL REALIZAR LA OPERACIÓN");
            }
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarContador();
            }
            catch
            {
                MessageBox.Show("ERROR, SE PRODUJO UN ERROR AL REALIZAR LA OPERACIÓN");
            }
        }

        private void mntContador_Load(object sender, EventArgs e)
        {
            try
            {
                String ls_mensaje = "";
                Int32 li_resultado = 0;
                cmbComunidad.DataSource = Datos.getComunidades(-1, ref ls_mensaje, ref li_resultado);
                cmbComunidad.DisplayMember = "Nombre";
                cmbComunidad.ValueMember = "id_comunidad";
                cmbTipoServicio.DataSource = Datos.getTipoServicio(ref ls_mensaje, ref li_resultado);
                cmbTipoServicio.DisplayMember = "tipo_servicio";
                cmbTipoServicio.ValueMember = "no_tipo_servicio";

            }
            catch 
            {
                MessageBox.Show("ERROR, SE PRODUJO UN ERROR AL REALIZAR LA OPERACIÓN");
            }
         
        }

        private void txtCodigob_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar)) //solo permite ingresar alfanuméricos.
            {
                e.Handled = true;
            }
        }

        private void txtCodigob_TextChanged(object sender, EventArgs e)
        {
            txtCodigob.CharacterCasing = CharacterCasing.Upper;
        }

    }
}
