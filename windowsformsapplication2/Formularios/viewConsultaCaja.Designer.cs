namespace WindowsFormsApplication2.Formularios
{
    partial class viewConsultaCaja
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
            this.mchDataSet71 = new WindowsFormsApplication2.MCHDataSet7();
            this.sp_Consultar_Caja_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Consultar_CajaTableAdapter = new WindowsFormsApplication2.MCHDataSet7TableAdapters.sp_Consultar_CajaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchDataSet71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Consultar_Caja_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MCHDataSet6_sp_CuentaCorriente";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication2.ConsultaCaja.rdlc";
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
            // mchDataSet71
            // 
            this.mchDataSet71.DataSetName = "MCHDataSet7";
            this.mchDataSet71.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_Consultar_Caja_BindingSource
            // 
            this.sp_Consultar_Caja_BindingSource.DataMember = "sp_Consultar_Caja";
            this.sp_Consultar_Caja_BindingSource.DataSource = this.mchDataSet71;
            // 
            // sp_Consultar_CajaTableAdapter
            // 
            this.sp_Consultar_CajaTableAdapter.ClearBeforeFill = true;
            // 
            // viewConsultaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "viewConsultaCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Caja";
            this.Load += new System.EventHandler(this.viewConsultaCaja_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.viewConsultaCaja_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchDataSet71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Consultar_Caja_BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MCHDataSet7 mchDataSet71;
        private System.Windows.Forms.BindingSource sp_Consultar_Caja_BindingSource;
        private WindowsFormsApplication2.MCHDataSet7TableAdapters.sp_Consultar_CajaTableAdapter sp_Consultar_CajaTableAdapter;
    }
}