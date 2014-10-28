using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication2.Formularios
{
    public partial class frmReporteriaPreview : Form
    {
        public String sPath;       
        public ReportDataSource sRptDataSource;
        public ReportParameter[] sRptParams;

        public frmReporteriaPreview(String Path, ReportDataSource RptDataSource, ReportParameter[] RptParams)
        {
            sPath = Path;            
            sRptDataSource = RptDataSource;
            sRptParams = RptParams;
            InitializeComponent();
        }

        private void frmReporteriaPreview_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = sPath;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(sRptDataSource);
            reportViewer1.LocalReport.SetParameters(sRptParams);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }
    }
}