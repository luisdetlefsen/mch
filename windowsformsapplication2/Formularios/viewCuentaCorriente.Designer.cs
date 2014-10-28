namespace WindowsFormsApplication2.Formularios
{
    partial class viewCuentaCorriente
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
            this.sp_CuentaCorriente_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mchDataSet61 = new WindowsFormsApplication2.MCHDataSet6();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sp_CuentaCorrienteTableAdapter = new WindowsFormsApplication2.MCHDataSet6TableAdapters.sp_CuentaCorrienteTableAdapter();
            this.mchDataSet61BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sp_CuentaCorriente_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchDataSet61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchDataSet61BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_CuentaCorriente_BindingSource
            // 
            this.sp_CuentaCorriente_BindingSource.DataMember = "sp_CuentaCorriente";
            this.sp_CuentaCorriente_BindingSource.DataSource = this.mchDataSet61;
            // 
            // mchDataSet61
            // 
            this.mchDataSet61.DataSetName = "MCHDataSet6";
            this.mchDataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MCHDataSet6_sp_CuentaCorriente";
            reportDataSource1.Value = this.sp_CuentaCorriente_BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication2.CuentaCorriente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 11);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 475);
            this.reportViewer1.TabIndex = 13;
            this.reportViewer1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Barra_Inferior;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 489);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // sp_CuentaCorrienteTableAdapter
            // 
            this.sp_CuentaCorrienteTableAdapter.ClearBeforeFill = true;
            // 
            // mchDataSet61BindingSource
            // 
            this.mchDataSet61BindingSource.DataMember = "sp_CuentaCorriente";
            this.mchDataSet61BindingSource.DataSource = this.mchDataSet61;
            // 
            // viewCuentaCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "viewCuentaCorriente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta Corriente";
            this.Load += new System.EventHandler(this.viewCuentaCorriente_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.viewCuentaCorriente_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.sp_CuentaCorriente_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchDataSet61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchDataSet61BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MCHDataSet6 mchDataSet61;
        private System.Windows.Forms.BindingSource sp_CuentaCorriente_BindingSource;
        private WindowsFormsApplication2.MCHDataSet6TableAdapters.sp_CuentaCorrienteTableAdapter sp_CuentaCorrienteTableAdapter;
        private System.Windows.Forms.BindingSource mchDataSet61BindingSource;
    }
}