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
    public partial class mntPersona : Form
    {
        frmMenu fForma2;
        Boolean gb_NuevaPersona;
        Boolean gb_BusquedaPersona;
        int gi_Codigo;
        public mntPersona(frmMenu F2)
        {
            InitializeComponent();
            fForma2 = F2;
            OcultaMostrarrControlesIngreso(false);
            OcultarMotrarPnlGrid(false);
            OcultarMostrarPB(false);
            pbCancelar.Visible = false;
            lblCancelar.Visible = false;
            dgvPersonas.AutoGenerateColumns = false;
        }

        private void mntPersona_FormClosed(object sender, FormClosedEventArgs e)
        {
            fForma2.Show();
        }
        #region CONTROLES
        private void OcultaMostrarrControlesIngreso(Boolean  bCambio)
        {
            txtCedula.Visible = bCambio;
            txtCUI.Visible = bCambio;
            txtNombrePersona.Visible = bCambio;
            cmbrRegistro.Visible = bCambio;
            cmbComunidad.Visible = bCambio;
            dtFechaNac.Visible = bCambio;
            txtCodigo.Visible = bCambio;
            rHombre.Visible = bCambio;
            rMujer.Visible = bCambio;
            lblCedula.Visible = bCambio;
            lblCUI.Visible = bCambio;
            lblNombrePersona.Visible = bCambio;
            lblCodigo.Visible = bCambio;
            lblSexo.Visible = bCambio;
            lblFechaNacimiento.Visible = bCambio;
            lblComunidad.Visible = bCambio;
            LimpiarControlesIngreso();
        }
        private void LimpiarControlesIngreso()
        {
            txtCedula.Text = "";
            txtCUI.Text = "";
            txtNombrePersona.Text = "";
            cmbrRegistro.SelectedIndex = 0;
            txtCodigo.Text = "";
        }
        private void BloquearDesbloquearControlesIngreso(Boolean bCambio) 
        {
            txtCedula.Enabled = bCambio;
            txtCUI.Enabled = bCambio;
            txtNombrePersona.Enabled = bCambio;
            txtCodigo.Enabled = bCambio;
            cmbComunidad.Enabled = bCambio;
            cmbrRegistro.Enabled = bCambio;
            rHombre.Enabled = bCambio;
            rMujer.Enabled = bCambio;
            dtFechaNac.Enabled = bCambio;
            cmbrRegistro.Visible = bCambio;
        }
        private void OcultarMotrarPnlGrid(Boolean bCambio)
        {
            pnlResultados.Visible = bCambio;
        }
        private void OcultarMostrarPB(Boolean bCambio)
        {
            pbEliminar.Visible = bCambio;
            pbGuardar.Visible = bCambio;
            //pbCancelar.Visible = bCambio;
            lblEliminar.Visible = bCambio;
            lblGuardar.Visible = bCambio;
            //lblCancelar.Visible = bCambio;
        }
        private void txtNombrePersona_TextChanged(object sender, EventArgs e)
        {
            txtNombrePersona.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtCUI_TextChanged(object sender, EventArgs e)
        {
            txtCUI.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            txtCedula.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.CharacterCasing = CharacterCasing.Upper;
        }

        #endregion

        private void pbNuevaPersona_Click(object sender, EventArgs e)
        {
            String ls_mensaje = "";
            Int32 li_resultado = 0;
            cmbComunidad.DataSource = Datos.getComunidades(-1, ref ls_mensaje, ref li_resultado);
            cmbComunidad.DisplayMember = "Nombre";
            cmbComunidad.ValueMember = "id_comunidad";
            txtNombreBusqueda.Text = string.Empty;
            gb_NuevaPersona = true;
            gb_BusquedaPersona = false;
            OcultaMostrarrControlesIngreso(true);
            OcultarMostrarPB(false);
            BloquearDesbloquearControlesIngreso(true);
            pbGuardar.Visible = true;
            lblGuardar.Visible = true;
            //pbCancelar.Visible = true;
            //lblCancelar.Visible = true;
            OcultarMotrarPnlGrid(false);

        }

        private void CrearPersona()
        {
            Int32 iResultado = 0;
            string sMensaje = string.Empty;
            string sNombrePersona = txtNombrePersona.Text;
            string sNoRegistro = cmbrRegistro.Items[cmbrRegistro.SelectedIndex].ToString();
            string sCUI = txtCUI.Text;
            int iComunidad = Convert.ToInt32(cmbComunidad.SelectedValue);
            int iSexo = 0;
            string sCodigo = "";
            DateTime dFechaNac = dtFechaNac.Value;
            if (rHombre.Checked)
            {
                iSexo = 1;
            }
            Int32 iCedula = -1;
            Boolean bGrabar = true;
            if (txtCodigo.Text.Trim().Length > 0)
            {
                sCodigo  = txtCodigo.Text;
                if (sNombrePersona.Trim().Length > 0)
                {
                    if (txtCedula.Text.Trim().Length > 0)
                    {
                        if (Int32.TryParse(txtCedula.Text.Trim(), out iCedula))
                        {
                            bGrabar = true;
                        }
                        else {
                            bGrabar = false;
                            MessageBox.Show("EN LA CÉDULA SOLO SE PERMITEN NÚMEROS.");
                        }
                    }
                    if (sNoRegistro.Trim().Length == 0)
                    {
                        sNoRegistro = null;
                    }
                    if (sCUI.Length == 0)
                    {
                        sCUI = null;
                    }
                    if (bGrabar)
                    {
                        Datos.CrearPersona(sCodigo, sNombrePersona, sCUI, sNoRegistro, iCedula, iSexo, dFechaNac, iComunidad, ref sMensaje, ref iResultado);
                        if (iResultado == 0)
                        {
                            MessageBox.Show("EL USUARIO SE CREÓ CORRECTAMENTE.");
                            //txtCodigo.Text = iResultado.ToString();
                            BloquearDesbloquearControlesIngreso(false);
                            OcultarMostrarPB(false);
                        }
                        else if (iResultado == -2)
                        {
                            MessageBox.Show("EL USUARIO YA EXISTE.");
                        }
                        else
                        {
                            MessageBox.Show("ERROR, INTENTE DE NUEVO.");
                        }
                    }
                }
                else {
                    MessageBox.Show("DEBE INGRESAR EL NOMBRE DE LA PERSONA");
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR EL CÓDIGO DE LA PERSONA");
            }
        }
        private void ModificarPersona()
        {
            Int32 iResultado = 0;
            string sMensaje = string.Empty;
            string sNombrePersona = txtNombrePersona.Text;
            string sNoRegistro = cmbrRegistro.Items[cmbrRegistro.SelectedIndex].ToString();
            string sCUI = txtCUI.Text;
            string sCodigo;
            Int32 iCedula = -1;
            Int32 iID = gi_Codigo ;
            Boolean bGrabar = true;
            string sSexo = "0";
            DateTime dFechaNac = dtFechaNac.Value;
            int iComunidad = Convert.ToInt32(cmbComunidad.SelectedValue);
            if (rHombre.Checked)
            {
                sSexo = "1";
            }
            if (txtCodigo.Text.Trim().Length > 0)
            {
                sCodigo = txtCodigo.Text.Trim();
                if (sNombrePersona.Trim().Length > 0)
                {
                    if (txtCedula.Text.Trim().Length > 0)
                    {
                        if (Int32.TryParse(txtCedula.Text.Trim(), out iCedula))
                        {
                            bGrabar = true;
                        }
                        else
                        {
                            bGrabar = false;
                            MessageBox.Show("EN LA CÉDULA SOLO SE PERMITEN NÚMEROS.");
                        }
                    }
                    if (sNoRegistro.Trim().Length == 0)
                    {
                        sNoRegistro = null;
                    }
                    if (sCUI.Length == 0)
                    {
                        sCUI = null;
                    }
                    if (bGrabar)
                    {
                        //ModificarPersona(pi_ID,ps_Codigo,ps_NombrePersona,ps_CUI,ps_NoRegistro,pi_NoCedula, string ps_Sexo, DateTime pd_Fecha, int pi_Comunidad, ref string ps_Mensaje, ref Int32 pi_Resultado)
                        Datos.ModificarPersona(iID, sCodigo,sNombrePersona, sCUI, sNoRegistro, iCedula,sSexo, dFechaNac,iComunidad , ref sMensaje, ref iResultado);
                        if (iResultado == 0)
                        {
                            MessageBox.Show("EL USUARIO SE MODIFICÓ CORRECTAMENTE.");
                            txtCodigo.Text = iResultado.ToString();
                            BloquearDesbloquearControlesIngreso(false);
                            OcultarMostrarPB(false);
                            BuscarPersona();
                        }
                        else
                        {
                            MessageBox.Show("ERROR EN LA MODIFICACIÓN, INTENTE DE NUEVO.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("DEBE INGRESAR EL NOMBRE DE LA PERSONA");
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR EL CÓDIGO DE LA PERSONA");
            }
        }
        private void EliminarPersona()
        {
            Int32 iDato = 0;
            Int32 iResultado = 0;
            string sMensaje = "";
            iDato = gi_Codigo;
            DialogResult drResultado = MessageBox.Show("A CONTINUACIÓN SE ELIMINARÁ A LA PERSONA " + txtNombrePersona.Text + " ¿DESEA CONTINUAR?","ELIMINACIÓN",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drResultado == DialogResult.Yes)
            {
                Datos.EliminarPersona(iDato, ref sMensaje, ref iResultado);
                if (iResultado == 0)
                {
                    MessageBox.Show("LA PERSONA FUE ELIMINADA EXISTOSAMENTE");
                }
                else
                {
                    MessageBox.Show("ERROR EN LA ELIMINACIÓN, EL USUARIO TIENE UN CONTRATO.");
                }
            }
            BuscarPersona();
        }
        private void BuscarPersona()
        {
            string sDatosBusqueda = "";
            string sMensaje = "";
            Int32 iResultado = 0;
            DataTable dtResultado = new DataTable();
            sDatosBusqueda =  txtNombreBusqueda.Text.Trim();
            LimpiarControlesIngreso();
            if (sDatosBusqueda.Length > 0)
            {
                Datos.BuscarPersona(sDatosBusqueda, ref sMensaje, ref iResultado, ref dtResultado);
                if (iResultado == 0)
                {
                    if (dtResultado.DefaultView.Count > 0)
                    {
                        OcultarMotrarPnlGrid(true);
                        OcultarMostrarPB(true);
                        OcultaMostrarrControlesIngreso(true);
                        BloquearDesbloquearControlesIngreso(true);
                        dgvPersonas.DataSource = dtResultado.DefaultView;
                        //dgvPersonas.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        dgvPersonas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        MostrarDatosPersona(0);
                    }
                    else
                    {
                        OcultarMotrarPnlGrid(false);
                        OcultarMostrarPB(false);
                        OcultaMostrarrControlesIngreso(false);
                        BloquearDesbloquearControlesIngreso(false);
                        MessageBox.Show("NO SE ENCONTRARON RESULTADOS");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR EN LA BÚSQUEDA");
                }
            }
            else {
                MessageBox.Show("INGRESE UN NOMBRE PARA REALIZAR LA BÚSQUEDA");
            }
        }

        private void MostrarDatosPersona(Int32 iDato)
        {
            int iRegistro = 0;
            if (iDato >= 0)
            {
                gi_Codigo = Convert.ToInt32(dgvPersonas[0, iDato].Value.ToString());
                txtCodigo.Text = dgvPersonas[1, iDato].Value.ToString();
                txtNombrePersona.Text = dgvPersonas[2, iDato].Value.ToString();
                txtCUI.Text = dgvPersonas[3, iDato].Value.ToString();
                iRegistro = cmbrRegistro.FindString(dgvPersonas[4, iDato].Value.ToString());
                cmbrRegistro.SelectedIndex = iRegistro;
                iRegistro = cmbComunidad.FindString(dgvPersonas[8, iDato].Value.ToString());
                cmbComunidad.SelectedIndex = iRegistro;
                txtCedula.Text = dgvPersonas[5, iDato].Value.ToString();
                if (dgvPersonas[6, iDato].Value.ToString() == "HOMBRE")
                {
                    rHombre.Checked = true;
                }
                else
                {
                    rMujer.Checked = true;
                }
                dtFechaNac.Value = Convert.ToDateTime(dgvPersonas[7, iDato].Value.ToString());
            }
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            if (gb_NuevaPersona )
            {
                OcultaMostrarrControlesIngreso(false);
                OcultarMotrarPnlGrid(false);
                OcultarMostrarPB(false);
            }
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            String ls_mensaje = "";
            Int32 li_resultado = 0;
            cmbComunidad.DataSource = Datos.getComunidades(-1, ref ls_mensaje, ref li_resultado);
            cmbComunidad.DisplayMember = "Nombre";
            cmbComunidad.ValueMember = "id_comunidad";
            gb_NuevaPersona = false;
            gb_BusquedaPersona = true;
            BuscarPersona();
        }

        private void txtNombreBusqueda_TextChanged(object sender, EventArgs e)
        {
            txtNombreBusqueda.CharacterCasing = CharacterCasing.Upper;
        }

        private void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 iDato = 0;
            iDato = e.RowIndex;
            MostrarDatosPersona(iDato);
        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            if (gb_NuevaPersona)
            {
                CrearPersona();
            }
            else if (gb_BusquedaPersona)
            {
                ModificarPersona();
            }
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            EliminarPersona();
        }

    }
}
