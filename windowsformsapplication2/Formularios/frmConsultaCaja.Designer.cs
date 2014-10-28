namespace WindowsFormsApplication2.Formularios
{
    partial class frmConsultaCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCaja));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_Hasta = new System.Windows.Forms.DateTimePicker();
            this.dt_Desde = new System.Windows.Forms.DateTimePicker();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlInsertar = new System.Windows.Forms.Panel();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.mchDataSet71 = new WindowsFormsApplication2.MCHDataSet7();
            this.sp_ConsultarCaja_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Consultar_CajaTableAdapter = new WindowsFormsApplication2.MCHDataSet7TableAdapters.sp_Consultar_CajaTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.pnlInsertar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchDataSet71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ConsultarCaja_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MCHDataSet_sp_reporte_comunidad";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication2.rptRecibo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 475);
            this.reportViewer1.TabIndex = 20;
            this.reportViewer1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Desde:";
            // 
            // dt_Hasta
            // 
            this.dt_Hasta.CustomFormat = "\"dd-MM-yyyy\"";
            this.dt_Hasta.Location = new System.Drawing.Point(217, 133);
            this.dt_Hasta.Name = "dt_Hasta";
            this.dt_Hasta.Size = new System.Drawing.Size(200, 20);
            this.dt_Hasta.TabIndex = 17;
            // 
            // dt_Desde
            // 
            this.dt_Desde.CustomFormat = "\"dd-MM-yyyy\"";
            this.dt_Desde.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_Desde.Location = new System.Drawing.Point(217, 102);
            this.dt_Desde.Name = "dt_Desde";
            this.dt_Desde.Size = new System.Drawing.Size(200, 20);
            this.dt_Desde.TabIndex = 16;
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.ForeColor = System.Drawing.Color.White;
            this.lblGuardar.Location = new System.Drawing.Point(0, 42);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(75, 20);
            this.lblGuardar.TabIndex = 1;
            this.lblGuardar.Text = "Generar";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dt_Hasta);
            this.panel2.Controls.Add(this.dt_Desde);
            this.panel2.Location = new System.Drawing.Point(47, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 419);
            this.panel2.TabIndex = 18;
            // 
            // pnlInsertar
            // 
            this.pnlInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlInsertar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInsertar.Controls.Add(this.lblGuardar);
            this.pnlInsertar.Controls.Add(this.pbGuardar);
            this.pnlInsertar.Location = new System.Drawing.Point(696, 133);
            this.pnlInsertar.Name = "pnlInsertar";
            this.pnlInsertar.Size = new System.Drawing.Size(82, 229);
            this.pnlInsertar.TabIndex = 19;
            // 
            // pbGuardar
            // 
            this.pbGuardar.BackColor = System.Drawing.Color.Transparent;
            this.pbGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pbGuardar.Image")));
            this.pbGuardar.Location = new System.Drawing.Point(12, -2);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(48, 45);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardar.TabIndex = 0;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // mchDataSet71
            // 
            this.mchDataSet71.DataSetName = "MCHDataSet7";
            this.mchDataSet71.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_ConsultarCaja_BindingSource
            // 
            this.sp_ConsultarCaja_BindingSource.DataMember = "sp_Consultar_Caja";
            this.sp_ConsultarCaja_BindingSource.DataSource = this.mchDataSet71;
            // 
            // sp_Consultar_CajaTableAdapter
            // 
            this.sp_Consultar_CajaTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Barra_Inferior;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsultaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 574);
            this.Controls.Add(this.pnlInsertar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmConsultaCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Caja";
            this.Load += new System.EventHandler(this.frmConsultaCaja_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsultaCaja_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlInsertar.ResumeLayout(false);
            this.pnlInsertar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchDataSet71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ConsultarCaja_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_Hasta;
        private System.Windows.Forms.DateTimePicker dt_Desde;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlInsertar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private MCHDataSet7 mchDataSet71;
        private System.Windows.Forms.BindingSource sp_ConsultarCaja_BindingSource;
        private WindowsFormsApplication2.MCHDataSet7TableAdapters.sp_Consultar_CajaTableAdapter sp_Consultar_CajaTableAdapter;
    }
}