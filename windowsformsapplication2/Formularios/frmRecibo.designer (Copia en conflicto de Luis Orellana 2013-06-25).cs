namespace WindowsFormsApplication2
{
    partial class frmRecibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecibo));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_reporte_comunidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MCHDataSet = new WindowsFormsApplication2.MCHDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlInsertar = new System.Windows.Forms.Panel();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.sp_reporte_comunidadTableAdapter = new WindowsFormsApplication2.MCHDataSetTableAdapters.sp_reporte_comunidadTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.sp_reporte_comunidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pnlInsertar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(54, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 419);
            this.panel2.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(389, 171);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMPRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.comboBox1.Location = new System.Drawing.Point(226, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // pnlInsertar
            // 
            this.pnlInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlInsertar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInsertar.Controls.Add(this.lblGuardar);
            this.pnlInsertar.Controls.Add(this.pbGuardar);
            this.pnlInsertar.Location = new System.Drawing.Point(703, 133);
            this.pnlInsertar.Name = "pnlInsertar";
            this.pnlInsertar.Size = new System.Drawing.Size(82, 229);
            this.pnlInsertar.TabIndex = 8;
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.ForeColor = System.Drawing.Color.White;
            this.lblGuardar.Location = new System.Drawing.Point(0, 79);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(75, 20);
            this.lblGuardar.TabIndex = 1;
            this.lblGuardar.Text = "Generar";
            // 
            // pbGuardar
            // 
            this.pbGuardar.BackColor = System.Drawing.Color.Transparent;
            this.pbGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pbGuardar.Image")));
            this.pbGuardar.Location = new System.Drawing.Point(12, 35);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(48, 45);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardar.TabIndex = 0;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // sp_reporte_comunidadTableAdapter
            // 
            this.sp_reporte_comunidadTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MCHDataSet_sp_reporte_comunidad";
            reportDataSource1.Value = this.sp_reporte_comunidadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication2.rptRecibo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(22, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 475);
            this.reportViewer1.TabIndex = 9;
            this.reportViewer1.Visible = false;
            // 
            // frmRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(786, 574);
            this.Controls.Add(this.pnlInsertar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "frmRecibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibo";
            this.Load += new System.EventHandler(this.frmRecibo_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRecibo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.sp_reporte_comunidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pnlInsertar.ResumeLayout(false);
            this.pnlInsertar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlInsertar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.BindingSource sp_reporte_comunidadBindingSource;
        private MCHDataSet MCHDataSet;
        private WindowsFormsApplication2.MCHDataSetTableAdapters.sp_reporte_comunidadTableAdapter sp_reporte_comunidadTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}