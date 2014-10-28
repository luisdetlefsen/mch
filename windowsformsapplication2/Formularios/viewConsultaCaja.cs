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
    public partial class viewConsultaCaja : Form
    {
        Form fForma2;
        DateTime FechaIni;
        DateTime Fechafin;
        public viewConsultaCaja(Form F2, DateTime FecI, DateTime FecF)
        {
            InitializeComponent();
            fForma2 = F2;
            FechaIni = FecI;
            Fechafin = FecF;
        }

        private void viewConsultaCaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            fForma2.Show();
        }

        private void viewConsultaCaja_Load(object sender, EventArgs e)
        {
            string sMensaje = "";
            int iResultado = 0;

            //Se cargan los datos del Grid que se mostrara
            DataTable dtResultados = new DataTable();

            dtResultados = Datos.getConsultaCaja(FechaIni, Fechafin, ref sMensaje, ref iResultado);
            if (iResultado != -1)
            {
                if (dtResultados.DefaultView.Count > 0)
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] Parametros = new Microsoft.Reporting.WinForms.ReportParameter[2];
                    Parametros[0] = new Microsoft.Reporting.WinForms.ReportParameter("FechaInicial", FechaIni.ToString());
                    Parametros[1] = new Microsoft.Reporting.WinForms.ReportParameter("FechaFinal", Fechafin.ToString());

                    reportViewer1.Visible = true;

                    this.reportViewer1.LocalReport.DataSources.Clear();

                    this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

                    Microsoft.Reporting.WinForms.ReportDataSource reporte = new Microsoft.Reporting.WinForms.ReportDataSource("MCHDataSet7_sp_Consultar_Caja", dtResultados);
                    this.reportViewer1.LocalReport.DataSources.Add(reporte);
                    //this.reportViewer1.LocalReport.SetParameters(Parametros);

                    reportViewer1.LocalReport.ExecuteReportInCurrentAppDomain(System.Reflection.Assembly.GetExecutingAssembly().Evidence);
                }
                else
                {
                    MessageBox.Show("No se han encontrado datos.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error en la busqueda, intentelo de nuevo.");
                this.Close();
            }
        }
    }
}
