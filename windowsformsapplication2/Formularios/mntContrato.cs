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
    public partial class mntContrato : Form
    {
        frmMenu fForma2;
        Boolean gb_NuevoContrato;
        Boolean gb_BusquedaContrato;
        public mntContrato(frmMenu F2)
        {
            InitializeComponent();
            fForma2 = F2;
            OcultaMostrarrControlesIngreso(false);
            OcultarMotrarPnlGrid(false);
            OcultarMostrarPB(false);

            //Se marcan los controles que tienen "Ayuda"
            txIDCliente.Tag = "true";
            txtIDContador.Tag = "true";
        }

        private void mntPersona_FormClosed(object sender, FormClosedEventArgs e)
        {
            fForma2.Show();
        }
        #region CONTROLES
        private void OcultaMostrarrControlesIngreso(Boolean  bCambio)
        {
            txtCodigo.Visible = bCambio;
            txIDCliente.Visible = bCambio;
            txtNombreCliente.Visible = bCambio;
            txtIDContador.Visible = bCambio;
            txtDireccionContador.Visible = bCambio;
            txtFechaInicio.Visible = bCambio;
            txtFechaFin.Visible = bCambio;
            lblCodigo.Visible = bCambio;
            lblCliente.Visible = bCambio;
            lblContador.Visible = bCambio;
            lblFechaInicial.Visible = bCambio;
            lblFechaFinal.Visible = bCambio;
            pbxCliente.Visible = bCambio;
            pbxContador.Visible = bCambio;
        }
        private void LimpiarControlesIngreso()
        {
            txtCodigo.Text = "";
            txIDCliente.Text = "";
            txtNombreCliente.Text = "";
            txtIDContador.Text = "";
            txtDireccionContador.Text = "";
            txtFechaInicio.Text = "";
            txtFechaFin.Text = "";
        }
        private void BloquearDesbloquearControlesIngreso(Boolean bCambio) 
        {
            txtCodigo.Enabled = bCambio;
            txIDCliente.Enabled = bCambio;
            txtIDContador.Enabled = bCambio;
            pbxCliente.Enabled = bCambio;
            pbxContador.Enabled = bCambio;

        }
        private void OcultarMotrarPnlGrid(Boolean bCambio)
        {
            pnlResultados.Visible = bCambio;
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

        private void pbNuevaPersona_Click(object sender, EventArgs e)
        {
            txtNombreBusqueda.Text = string.Empty;
            gb_NuevoContrato = true;
            gb_BusquedaContrato = false;
            OcultaMostrarrControlesIngreso(true);
            OcultarMostrarPB(false);
            BloquearDesbloquearControlesIngreso(true);
            pbGuardar.Visible = true;
            lblGuardar.Visible = true;
            pbCancelar.Visible = true;
            lblCancelar.Visible = true;
            OcultarMotrarPnlGrid(false);
        }

        private void CrearContrato()
        {
            int iResultado = 0;
            int iSecuencial = 0;
            string sMensaje = string.Empty;
            string sIDPersona = txIDCliente.Text;
            string sIDContador = txtIDContador.Text;
            Boolean bGrabar = true;

            // Se realizan validaciones

            // Se manda a almacenar en la BD
            if (bGrabar)
            {
                //Se comun
                Datos.VerificarContrato(sIDPersona, sIDContador, ref sMensaje, ref iResultado);

                //Se revisan los resultados del SP
                switch (iResultado)
                {
                    case 0:
                        break;
                    case -1:
                        MessageBox.Show("NO EXISTE EL USUARIO INDICADO.");
                        break;
                    case -2:
                        MessageBox.Show("NO EXISTE EL CONTADOR INDICADO.");
                        break;
                    case -3:
                        if (MessageBox.Show("YA EXISTE UN CONTRATO ASOCIADO AL CONTADOR INDICADO. DESEA CONTINUAR?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        {
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("ERROR DESCONOCIDO AL ALMACENAR EL CONTRATO.");
                        break;
                }

                //Se reinician las variables de referencia envidadas a l metodo
                iResultado = 0;
                sMensaje = string.Empty;

                //Se hace la llamada al metodo
                Datos.CrearContrato(sIDPersona, sIDContador, ref sMensaje, ref iResultado, ref iSecuencial);

                switch (iResultado)
                {
                    case 0:
                        MessageBox.Show("EL CONTRATO SE CREÓ CORRECTAMENTE.");
                        txtCodigo.Text = iSecuencial.ToString();
                        BloquearDesbloquearControlesIngreso(false);
                        OcultarMostrarPB(false);
                        break;
                    case -1:
                        MessageBox.Show("NO EXISTE EL USUARIO INDICADO.");
                        break;
                    case -2:
                        MessageBox.Show("NO EXISTE EL CONTADOR INDICADO.");
                        break;
                    case -3:
                        MessageBox.Show("ERROR AL MARCAR COMO ELIMINADO EL CONTRATO ACTUAL PARA EL CONTADOR.");
                        break;
                    case -4:
                        MessageBox.Show("ERROR AL CREAR EL NUEVO CONTRATO PARA EL CONTADOR.");
                        break;
                    default:
                        MessageBox.Show("ERROR DESCONOCIDO AL ALMACENAR EL CONTRATO.");
                        break;
                }

            }
        }

        private void EliminarContrato()
        {
            Int32 iDato = 0;
            Int32 iResultado = 0;
            string sMensaje = "";
            iDato = Convert.ToInt32( txtCodigo.Text);
            DialogResult drResultado = MessageBox.Show("A CONTINUACIÓN SE ELIMINARÁ EL CONTRATO " + txtCodigo.Text + " ¿DESEA CONTINUAR?", "ELIMINACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drResultado == DialogResult.Yes)
            {
                Datos.EliminarContrato(iDato, ref sMensaje, ref iResultado);
                if (iResultado == 0)
                {
                    MessageBox.Show("EL CONTRATO FUE ELIMINADO EXISTOSAMENTE");
                }
                else
                {
                    MessageBox.Show("ERROR EN LA ELIMINACIÓN");
                }
            }
            BuscarContrato();
        }

        private void BuscarContrato()
        {
            string sDatosBusqueda = "";
            string sDatosBusqueda2 = "";
            bool bDatosHistoricos = false;
            string sMensaje = "";
            Int32 iResultado = 0;
            DataTable dtResultado = new DataTable();
            
            sDatosBusqueda =  txtNombreBusqueda.Text.Trim();
            sDatosBusqueda2 = txtNombreBusqueda2.Text.Trim();
            bDatosHistoricos = chkHistorico.Checked;

            LimpiarControlesIngreso();

            if ((sDatosBusqueda.Length > 0) || (sDatosBusqueda2.Length > 0))
            {
                Datos.BuscarContrato(sDatosBusqueda, sDatosBusqueda2, bDatosHistoricos, ref sMensaje, ref iResultado, ref dtResultado);
         
                if (iResultado == 0)
                {
                    if (dtResultado.DefaultView.Count > 0)
                    {
                        OcultarMotrarPnlGrid(true);
                        OcultarMostrarPB(true);
                        OcultaMostrarrControlesIngreso(true);
                        BloquearDesbloquearControlesIngreso(true);
                        dgvContrato.DataSource = dtResultado.DefaultView;
                        MostrarDatosContrato(0);
                    }
                    else
                    {
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

        private void MostrarDatosContrato(Int32 iDato)
        {
            if ((iDato >= 0) && (iDato < dgvContrato.Rows.Count))
            {
                txtCodigo.Text = dgvContrato[0, iDato].Value.ToString();
                txIDCliente.Text = dgvContrato[1, iDato].Value.ToString();
                txtNombreCliente.Text = dgvContrato[2, iDato].Value.ToString();
                txtIDContador.Text = dgvContrato[3, iDato].Value.ToString();
                txtFechaInicio.Text = dgvContrato[4, iDato].Value.ToString();
                txtFechaFin.Text = dgvContrato[5, iDato].Value.ToString();
            }
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            if (gb_NuevoContrato )
            {
                OcultaMostrarrControlesIngreso(false);
                OcultarMotrarPnlGrid(false);
                OcultarMostrarPB(false);
            }
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            gb_NuevoContrato = false;
            gb_BusquedaContrato = true;
            BuscarContrato();
        }

        private void txtNombreBusqueda_TextChanged(object sender, EventArgs e)
        {
            txtNombreBusqueda.CharacterCasing = CharacterCasing.Upper;
        }

        private void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 iDato = 0;
            iDato = e.RowIndex;
            MostrarDatosContrato(iDato);
        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            if (gb_NuevoContrato)
            {
                CrearContrato();
            }
            else if (gb_BusquedaContrato)
            {
                MessageBox.Show("Los datos de un contrato no pueden ser modificados");
            }
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            EliminarContrato();
        }

        private void txtIDContador_TextChanged(object sender, EventArgs e)
        {
            txtIDContador.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtNombreBusqueda2_TextChanged(object sender, EventArgs e)
        {
            txtNombreBusqueda2.CharacterCasing = CharacterCasing.Upper;
        }

        private void txIDCliente_TextChanged(object sender, EventArgs e)
        {
            txIDCliente.CharacterCasing = CharacterCasing.Upper;
        }

        private void pbxCliente_Click(object sender, EventArgs e)
        {
            try
            {
                frmAyuda AyudaCliente;
                AyudaCliente = new frmAyuda("Listado de clientes", "A", ref txIDCliente, ref txtNombreCliente);
                AyudaCliente.ShowDialog();
            }
            catch
            {
                MessageBox.Show("ERROR EN LA BÚSQUEDA");
            }
        }

        private void txIDCliente_LostFocus(object sender, EventArgs e)
        {
            try
            {
                frmAyuda.BuscarAyudaIndividual("cliente", "A", ref txIDCliente, ref txtNombreCliente);
            }
            catch
            {
                MessageBox.Show("ERROR EN LA BÚSQUEDA");
            }
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

        private void txtIDContador_LostFocus(object sender, EventArgs e)
        {
            try
            {
                frmAyuda.BuscarAyudaIndividual("contador", "B", ref txtIDContador, ref txtDireccionContador);
            }
            catch
            {
                MessageBox.Show("ERROR EN LA BÚSQUEDA");
            }
        }

    }
}
