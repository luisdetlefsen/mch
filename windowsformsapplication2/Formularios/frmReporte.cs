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
    public partial class frmReporte : Form
    {
        frmMenu fForma2;

        public frmReporte(frmMenu F2)
        {
            InitializeComponent();
            fForma2 = F2;
            txtContador.Tag = "true";
        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            string sMensaje = "";
            int iResultado = 0;
            int iReporte = -1;
            int iContador = 0;

            //Se cargan los datos del Grid que se mostrara
            DataTable dtResultados = new DataTable();

            iReporte = cbReporte.SelectedIndex;

            if (iReporte == 1)
            {

                //iContador = Convert.ToInt32(txtContador.Text);

                string sContador = txtContador.Text;

                dtResultados.Clear();

                dtResultados = Datos.getEstadoCuenta(sContador, ref sMensaje, ref iResultado);
                if (dtResultados.DefaultView.Count > 0)
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] Parametros = new Microsoft.Reporting.WinForms.ReportParameter[1];
                    Parametros[0] = new Microsoft.Reporting.WinForms.ReportParameter("contador", sContador);
                    panel2.Visible = false;

                    //pnlInsertar.Visible = false;
                    reportViewer1.Visible = true;
                    this.reportViewer1.LocalReport.DataSources.Clear();

                    this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
                    //this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                    

                    Microsoft.Reporting.WinForms.ReportDataSource reporte = new Microsoft.Reporting.WinForms.ReportDataSource("MCHDataSet3_sp_estado_cuenta", dtResultados);

                    this.reportViewer1.LocalReport.DataSources.Add(reporte);
                    this.reportViewer1.LocalReport.SetParameters(Parametros);

                    reportViewer1.LocalReport.ExecuteReportInCurrentAppDomain(System.Reflection.Assembly.GetExecutingAssembly().Evidence);

                    //this.reportViewer1.LocalReport.Refresh();
                    //this.reportViewer1.Refresh();
                }
                else
                {
                    MessageBox.Show("No existen datos para el contador.");
                }
               
            }

            if (iReporte == 0)
            {

                int iComunidad = Convert.ToInt32(cmbComunidad.SelectedValue);
                int iMes = Convert.ToInt32(comboBox1.SelectedIndex + 1);
                int iAnio = Convert.ToInt32(numericUpDown1.Value);

                dtResultados.Clear();

                dtResultados = Datos.getReporteComunidades(iComunidad, iMes, iAnio, ref sMensaje, ref iResultado);
                if (dtResultados.DefaultView.Count > 0)
                {

                    Microsoft.Reporting.WinForms.ReportParameter[] Parametros = new Microsoft.Reporting.WinForms.ReportParameter[3];
                    Parametros[0] = new Microsoft.Reporting.WinForms.ReportParameter("id_comunidad", iComunidad.ToString());
                    Parametros[1] = new Microsoft.Reporting.WinForms.ReportParameter("mes", iMes.ToString());
                    Parametros[2] = new Microsoft.Reporting.WinForms.ReportParameter("año", iAnio.ToString());
                    panel2.Visible = false;

                    //pnlInsertar.Visible = false;
                    reportViewer2.Visible = true;
                    this.reportViewer2.LocalReport.DataSources.Clear();

                    this.reportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    this.reportViewer2.LocalReport.SetParameters(Parametros);

                    Microsoft.Reporting.WinForms.ReportDataSource reporte = new Microsoft.Reporting.WinForms.ReportDataSource("MCHDataSet_sp_reporte_comunidad", dtResultados);

                    this.reportViewer2.LocalReport.DataSources.Add(reporte);

                    reportViewer2.LocalReport.ExecuteReportInCurrentAppDomain(System.Reflection.Assembly.GetExecutingAssembly().Evidence);

                }
                else
                {
                    MessageBox.Show("No se han realizado lecturas en este mes.");
                }

            }

            
        }

        private void frmReporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            fForma2.Show();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mCHDataSet.sp_reporte_comunidad' table. You can move, or remove it, as needed.
            //this.sp_reporte_comunidadTableAdapter.Fill(this.mCHDataSet.sp_reporte_comunidad);
            // TODO: This line of code loads data into the 'mCHDataSet.sp_reporte_comunidad' table. You can move, or remove it, as needed.
            //this.sp_reporte_comunidadTableAdapter.Fill(this.mCHDataSet.sp_reporte_comunidad);
            // TODO: This line of code loads data into the 'mCHDataSet2.v_consumo_comunidad' table. You can move, or remove it, as needed.
            //this.v_consumo_comunidadTableAdapter.Fill(this.mCHDataSet2.v_consumo_comunidad);
            comboBox1.SelectedIndex = DateTime.Today.Month - 1;
            numericUpDown1.Value = DateTime.Today.Year;
        }

        private void pbxCliente_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    frmAyuda AyudaCliente;
            //    AyudaCliente = new frmAyuda("Listado de Contratos", "C", ref txtContador, ref txtNombre);
            //    AyudaCliente.ShowDialog();
            //    if (txtNombre.Text != string.Empty)
            //    {
            //        string[] Datos = txtNombre.Text.Split(',');
            //        txtNombre.Text = Datos[0];
            //        txtContrato.Text = Datos[1];
            //    }
            //    else
            //    {
            //        txtContrato.Clear();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("ERROR EN LA BÚSQUEDA");
            //}

            try
            {
                frmAyuda AyudaContador;
                AyudaContador = new frmAyuda("Listado de contadores", "B", ref txtContador, ref txtNombre);
                AyudaContador.ShowDialog();
                if (txtNombre.Text != string.Empty)
                {
                    string[] Datos = txtNombre.Text.Split(',');
                    txtNombre.Text = Datos[0];
                    //txtContrato.Text = Datos[1];
                }
                else
                {
                    txtContrato.Clear();
                }
            }
            catch
            {
                MessageBox.Show("ERROR EN LA BÚSQUEDA");
            }
        }

        private void cbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ls_mensaje;
            int li_resultado;

            ls_mensaje = "";
            li_resultado = 0;

            if (cbReporte.SelectedIndex == 1)
            {
                gbEstado.Visible = true;
                gbConsumo.Visible = false;
            }
            else 
            {
                gbConsumo.Visible = true;
                cmbComunidad.DataSource = Datos.getComunidades(-1, ref ls_mensaje, ref li_resultado);
                cmbComunidad.DisplayMember = "Nombre";
                cmbComunidad.ValueMember = "id_comunidad";
                gbEstado.Visible = false;
            }
        }

        private void txtContador_LostFocus(object sender, EventArgs e)
        {
            //frmAyuda.BuscarAyudaIndividual("Contador", "C", ref txtContador, ref txtNombre);
            //if (txtNombre.Text != string.Empty)
            //{
            //    string[] Datos = txtNombre.Text.Split(',');
            //    txtNombre.Text = Datos[0];
            //    txtContrato.Text = Datos[1];
            //}
            //else
            //{
            //    txtContador.Clear();
            //}

            try
            {
                frmAyuda.BuscarAyudaIndividual("contador", "B", ref txtContador, ref txtNombre);
               if (txtNombre.Text != string.Empty)
               {
                   string[] Datos = txtNombre.Text.Split(',');
                   txtNombre.Text = Datos[0];
                   txtContrato.Text = Datos[1];
               }
               else
               {
                   txtContador.Clear();
               }


            }
            catch
            {
                MessageBox.Show("ERROR EN LA BÚSQUEDA");
            }

        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

            //pnlInsertar.Visible = false;
            reportViewer1.Visible = false;
            reportViewer2.Visible = false;
        }

        private void txtContador_TextChanged(object sender, EventArgs e)
        {
            txtContador.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
