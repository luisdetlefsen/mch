namespace WindowsFormsApplication2
{
    partial class viewRecibo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_BuscarAbonoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MCHDataSet4 = new WindowsFormsApplication2.MCHDataSet4();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_reporte_comunidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MCHDataSet = new WindowsFormsApplication2.MCHDataSet();
            this.sp_reporte_comunidadTableAdapter = new WindowsFormsApplication2.MCHDataSetTableAdapters.sp_reporte_comunidadTableAdapter();
            this.mCHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sp_BuscarAbonoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCHDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_reporte_comunidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_BuscarAbonoBindingSource
            // 
            this.sp_BuscarAbonoBindingSource.DataMember = "sp_BuscarAbono";
            this.sp_BuscarAbonoBindingSource.DataSource = this.MCHDataSet4;
            // 
            // MCHDataSet4
            // 
            this.MCHDataSet4.DataSetName = "MCHDataSet4";
            this.MCHDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Barra_Inferior;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 491);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MCHDataSet4_sp_BuscarAbono";
            reportDataSource1.Value = this.sp_BuscarAbonoBindingSource;
            reportDataSource2.Name = "MCHDataSet5_sp_BuscarAbono2";
            reportDataSource2.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication2.Comprobante5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(22, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 475);
            this.reportViewer1.TabIndex = 9;
            this.reportViewer1.Visible = false;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sp_reporte_comunidadBindingSource
            // 
            this.sp_reporte_comunidadBindingSource.DataMember = "sp_reporte_comunidad";
            this.sp_reporte_comunidadBindingSource.DataSource = this.MCHDataSet;
            // 
            // MCHDataSet
            // 
            this.MCHDataSet.DataSetName = "MCHDataSet";
            this.MCHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_reporte_comunidadTableAdapter
            // 
            this.sp_reporte_comunidadTableAdapter.ClearBeforeFill = true;
            // 
            // mCHDataSetBindingSource
            // 
            this.mCHDataSetBindingSource.DataSource = this.MCHDataSet;
            this.mCHDataSetBindingSource.Position = 0;
            // 
            // viewRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(786, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "viewRecibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibo";
            this.Load += new System.EventHandler(this.viewRecibo_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.viewRecibo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.sp_BuscarAbonoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCHDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_reporte_comunidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource sp_reporte_comunidadBindingSource;
        private MCHDataSet MCHDataSet;
        private WindowsFormsApplication2.MCHDataSetTableAdapters.sp_reporte_comunidadTableAdapter sp_reporte_comunidadTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_BuscarAbonoBindingSource;
        private MCHDataSet4 MCHDataSet4;
        private System.Windows.Forms.BindingSource mCHDataSetBindingSource;
        
    }
}