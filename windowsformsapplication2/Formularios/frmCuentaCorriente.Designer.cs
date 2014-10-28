namespace WindowsFormsApplication2.Formularios
{
    partial class frmCuentaCorriente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuentaCorriente));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pnlInsertar = new System.Windows.Forms.Panel();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.tb_Contrato = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_Hasta = new System.Windows.Forms.DateTimePicker();
            this.dt_Desde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mchDataSet61 = new WindowsFormsApplication2.MCHDataSet6();
            this.sp_CuentaCorriente_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_CuentaCorrienteTableAdapter = new WindowsFormsApplication2.MCHDataSet6TableAdapters.sp_CuentaCorrienteTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_contador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.txtNombreBusqueda = new System.Windows.Forms.TextBox();
            this.lblNombreBusqueda = new System.Windows.Forms.Label();
            this.pnlInsertar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchDataSet61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CuentaCorriente_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.SuspendLayout();
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
            this.pnlInsertar.TabIndex = 15;
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
            // tb_Contrato
            // 
            this.tb_Contrato.Location = new System.Drawing.Point(217, 171);
            this.tb_Contrato.Name = "tb_Contrato";
            this.tb_Contrato.Size = new System.Drawing.Size(100, 20);
            this.tb_Contrato.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dt_Hasta);
            this.panel2.Controls.Add(this.dt_Desde);
            this.panel2.Controls.Add(this.tb_Contrato);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(47, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 419);
            this.panel2.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(583, 84);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Desde:";
            // 
            // dt_Hasta
            // 
            this.dt_Hasta.CustomFormat = "\"dd-MM-yyyy\"";
            this.dt_Hasta.Location = new System.Drawing.Point(217, 238);
            this.dt_Hasta.Name = "dt_Hasta";
            this.dt_Hasta.Size = new System.Drawing.Size(200, 20);
            this.dt_Hasta.TabIndex = 17;
            // 
            // dt_Desde
            // 
            this.dt_Desde.CustomFormat = "\"dd-MM-yyyy\"";
            this.dt_Desde.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_Desde.Location = new System.Drawing.Point(217, 207);
            this.dt_Desde.Name = "dt_Desde";
            this.dt_Desde.Size = new System.Drawing.Size(200, 20);
            this.dt_Desde.TabIndex = 16;
            this.dt_Desde.ValueChanged += new System.EventHandler(this.dt_Desde_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contrato:";
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
            this.reportViewer1.TabIndex = 16;
            this.reportViewer1.Visible = false;
            // 
            // mchDataSet61
            // 
            this.mchDataSet61.DataSetName = "MCHDataSet6";
            this.mchDataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_CuentaCorriente_BindingSource
            // 
            this.sp_CuentaCorriente_BindingSource.DataMember = "sp_CuentaCorriente";
            this.sp_CuentaCorriente_BindingSource.DataSource = this.mchDataSet61;
            // 
            // sp_CuentaCorrienteTableAdapter
            // 
            this.sp_CuentaCorrienteTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Barra_Inferior;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tb_contador);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pbBuscar);
            this.panel3.Controls.Add(this.txtNombreBusqueda);
            this.panel3.Controls.Add(this.lblNombreBusqueda);
            this.panel3.Location = new System.Drawing.Point(47, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 83);
            this.panel3.TabIndex = 18;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // tb_contador
            // 
            this.tb_contador.Location = new System.Drawing.Point(92, 46);
            this.tb_contador.Name = "tb_contador";
            this.tb_contador.Size = new System.Drawing.Size(247, 20);
            this.tb_contador.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contador:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(345, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Buscar";
            // 
            // pbBuscar
            // 
            this.pbBuscar.BackColor = System.Drawing.Color.Transparent;
            this.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscar.Image")));
            this.pbBuscar.Location = new System.Drawing.Point(350, 5);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(48, 47);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 5;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // txtNombreBusqueda
            // 
            this.txtNombreBusqueda.Location = new System.Drawing.Point(92, 17);
            this.txtNombreBusqueda.Name = "txtNombreBusqueda";
            this.txtNombreBusqueda.Size = new System.Drawing.Size(247, 20);
            this.txtNombreBusqueda.TabIndex = 1;
            // 
            // lblNombreBusqueda
            // 
            this.lblNombreBusqueda.AutoSize = true;
            this.lblNombreBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblNombreBusqueda.Location = new System.Drawing.Point(5, 15);
            this.lblNombreBusqueda.Name = "lblNombreBusqueda";
            this.lblNombreBusqueda.Size = new System.Drawing.Size(76, 20);
            this.lblNombreBusqueda.TabIndex = 4;
            this.lblNombreBusqueda.Text = "Nombre:";
            // 
            // frmCuentaCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 574);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlInsertar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmCuentaCorriente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta Corriente";
            this.Load += new System.EventHandler(this.frmCuentaCorriente_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCuentaCorriente_FormClosed);
            this.pnlInsertar.ResumeLayout(false);
            this.pnlInsertar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchDataSet61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CuentaCorriente_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlInsertar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.TextBox tb_Contrato;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MCHDataSet6 mchDataSet61;
        private System.Windows.Forms.BindingSource sp_CuentaCorriente_BindingSource;
        private WindowsFormsApplication2.MCHDataSet6TableAdapters.sp_CuentaCorrienteTableAdapter sp_CuentaCorrienteTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_Hasta;
        private System.Windows.Forms.DateTimePicker dt_Desde;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.TextBox txtNombreBusqueda;
        private System.Windows.Forms.Label lblNombreBusqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_contador;
        private System.Windows.Forms.Label label4;

    }
}