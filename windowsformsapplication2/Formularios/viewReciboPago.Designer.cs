namespace WindowsFormsApplication2.Formularios
{
    partial class viewReciboPago
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mchDataSet81 = new WindowsFormsApplication2.MCHDataSet8();
            this.sp_Reporte_Recibo = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Reporte_ReciboTableAdapter = new WindowsFormsApplication2.MCHDataSet8TableAdapters.sp_Reporte_ReciboTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchDataSet81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Reporte_Recibo)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MCHDataSet6_sp_CuentaCorriente";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication2.ReciboDePago.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 11);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 475);
            this.reportViewer1.TabIndex = 15;
            this.reportViewer1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Barra_Inferior;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 489);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // mchDataSet81
            // 
            this.mchDataSet81.DataSetName = "MCHDataSet8";
            this.mchDataSet81.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_Reporte_Recibo
            // 
            this.sp_Reporte_Recibo.DataMember = "sp_Reporte_Recibo";
            this.sp_Reporte_Recibo.DataSource = this.mchDataSet81;
            // 
            // sp_Reporte_ReciboTableAdapter
            // 
            this.sp_Reporte_ReciboTableAdapter.ClearBeforeFill = true;
            // 
            // viewReciboPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(786, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "viewReciboPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibo de Pago";
            this.Load += new System.EventHandler(this.viewReciboPago_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.viewReciboPago_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchDataSet81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Reporte_Recibo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MCHDataSet8 mchDataSet81;
        private System.Windows.Forms.BindingSource sp_Reporte_Recibo;
        private WindowsFormsApplication2.MCHDataSet8TableAdapters.sp_Reporte_ReciboTableAdapter sp_Reporte_ReciboTableAdapter;
    }
}