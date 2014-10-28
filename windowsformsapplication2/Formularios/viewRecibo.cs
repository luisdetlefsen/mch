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
    public partial class viewRecibo : Form
    {
        Form fForma2;
        int Año;
        int Mes;
        string sMes;

        string nombre_comunidad;

        public viewRecibo(Form F2, int iMes, int iAño, string nMes)
        {
            InitializeComponent();
            fForma2 = F2;
            Año = iAño;
            Mes = iMes;
            sMes = nMes;
            nombre_comunidad = "";
        }

        public viewRecibo(Form F2, int iMes, int iAño, string nMes, string n_comunidad)
            : this(F2, iMes, iAño, nMes)
        {
            nombre_comunidad = n_comunidad;
        }

        private void viewRecibo_FormClosed(object sender, FormClosedEventArgs e)
        {
            fForma2.Show();
        }


        private void viewRecibo_Load(object sender, EventArgs e)
        {
            string sMensaje = "";
            int iResultado = 0;

            //Se cargan los datos del Grid que se mostrara
            DataTable dtResultados = new DataTable();

            dtResultados = Datos.getMonto(Mes, Año, nombre_comunidad, ref sMensaje, ref iResultado);
            if (iResultado != -1)
            {
                if (dtResultados.DefaultView.Count > 0)
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] Parametros = new Microsoft.Reporting.WinForms.ReportParameter[3];
                    Parametros[0] = new Microsoft.Reporting.WinForms.ReportParameter("Fecha", DateTime.Today.Day.ToString() + '/' + DateTime.Today.Month.ToString() + '/' + DateTime.Today.Year.ToString());
                    Parametros[1] = new Microsoft.Reporting.WinForms.ReportParameter("Mes", sMes.ToLower());
                    Parametros[2] = new Microsoft.Reporting.WinForms.ReportParameter("Año", Año.ToString());


                    reportViewer1.Visible = true;

                    this.reportViewer1.LocalReport.DataSources.Clear();

                    this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

                    Microsoft.Reporting.WinForms.ReportDataSource reporte = new Microsoft.Reporting.WinForms.ReportDataSource("MCHDataSet5_sp_BuscarAbono", dtResultados);

                    //Microsoft.Reporting.WinForms.ReportDataSource reporte = new Microsoft.Reporting.WinForms.ReportDataSource("MCHDataSet5_sp_BuscarAbono2", dtResultados);

                    this.reportViewer1.LocalReport.DataSources.Add(reporte);


                    this.reportViewer1.LocalReport.SetParameters(Parametros);

                    reportViewer1.LocalReport.ExecuteReportInCurrentAppDomain(System.Reflection.Assembly.GetExecutingAssembly().Evidence);
                }
                else
                {
                    MessageBox.Show("No se han realizado lecturas en este mes.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error en la busqueda, intentelo de nuevo.");
                this.Close();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

    }
}
