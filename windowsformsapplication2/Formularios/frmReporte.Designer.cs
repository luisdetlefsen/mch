namespace WindowsFormsApplication2.Formularios
{
    partial class frmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_reporte_comunidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mCHDataSet = new WindowsFormsApplication2.MCHDataSet();
            this.spreportecomunidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblGuardar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombrePar = new System.Windows.Forms.Label();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxCliente = new System.Windows.Forms.PictureBox();
            this.cbReporte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbConsumo = new System.Windows.Forms.GroupBox();
            this.cmbComunidad = new System.Windows.Forms.ComboBox();
            this.lblComunidad = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mCHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_reporte_comunidadTableAdapter = new WindowsFormsApplication2.MCHDataSetTableAdapters.sp_reporte_comunidadTableAdapter();
            this.mCHDataSet2 = new WindowsFormsApplication2.MCHDataSet2();
            this.mCHDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vconsumocomunidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_consumo_comunidadTableAdapter = new WindowsFormsApplication2.MCHDataSet2TableAdapters.v_consumo_comunidadTableAdapter();
            this.v_consumo_comunidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vconsumocomunidadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.sp_reporte_comunidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreportecomunidadBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).BeginInit();
            this.gbConsumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vconsumocomunidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_consumo_comunidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vconsumocomunidadBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_reporte_comunidadBindingSource
            // 
            this.sp_reporte_comunidadBindingSource.DataMember = "sp_reporte_comunidad";
            this.sp_reporte_comunidadBindingSource.DataSource = this.mCHDataSet;
            // 
            // mCHDataSet
            // 
            this.mCHDataSet.DataSetName = "MCHDataSet";
            this.mCHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spreportecomunidadBindingSource
            // 
            this.spreportecomunidadBindingSource.DataMember = "sp_reporte_comunidad";
            this.spreportecomunidadBindingSource.DataSource = this.mCHDataSet;
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.ForeColor = System.Drawing.Color.White;
            this.lblGuardar.Location = new System.Drawing.Point(2, 127);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(75, 20);
            this.lblGuardar.TabIndex = 0;
            this.lblGuardar.Text = "Generar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblCancelar);
            this.panel1.Controls.Add(this.lblGuardar);
            this.panel1.Controls.Add(this.pbCancelar);
            this.panel1.Controls.Add(this.pbGuardar);
            this.panel1.Location = new System.Drawing.Point(703, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 350);
            this.panel1.TabIndex = 12;
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(0, 218);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(83, 20);
            this.lblCancelar.TabIndex = 16;
            this.lblCancelar.Text = "Regresar";
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Transparent;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelar.Image")));
            this.pbCancelar.Location = new System.Drawing.Point(14, 170);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(48, 45);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancelar.TabIndex = 15;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // pbGuardar
            // 
            this.pbGuardar.BackColor = System.Drawing.Color.Transparent;
            this.pbGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pbGuardar.Image")));
            this.pbGuardar.Location = new System.Drawing.Point(14, 83);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(48, 45);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardar.TabIndex = 0;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Barra_Inferior;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 520);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MCHDataSet_sp_reporte_comunidad";
            reportDataSource1.Value = this.sp_reporte_comunidadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication2.REstadoCuenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(689, 489);
            this.reportViewer1.TabIndex = 13;
            this.reportViewer1.Visible = false;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.gbEstado);
            this.panel2.Controls.Add(this.cbReporte);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.gbConsumo);
            this.panel2.Location = new System.Drawing.Point(60, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 419);
            this.panel2.TabIndex = 14;
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.txtContrato);
            this.gbEstado.Controls.Add(this.label3);
            this.gbEstado.Controls.Add(this.txtNombre);
            this.gbEstado.Controls.Add(this.lblNombrePar);
            this.gbEstado.Controls.Add(this.txtContador);
            this.gbEstado.Controls.Add(this.label1);
            this.gbEstado.Controls.Add(this.pbxCliente);
            this.gbEstado.Location = new System.Drawing.Point(158, 98);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(348, 182);
            this.gbEstado.TabIndex = 18;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado de Cuenta";
            this.gbEstado.Visible = false;
            // 
            // txtContrato
            // 
            this.txtContrato.Enabled = false;
            this.txtContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrato.Location = new System.Drawing.Point(112, 143);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(169, 26);
            this.txtContrato.TabIndex = 22;
            this.txtContrato.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Contrato:";
            this.label3.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(112, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 26);
            this.txtNombre.TabIndex = 20;
            // 
            // lblNombrePar
            // 
            this.lblNombrePar.AutoSize = true;
            this.lblNombrePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePar.Location = new System.Drawing.Point(18, 94);
            this.lblNombrePar.Name = "lblNombrePar";
            this.lblNombrePar.Size = new System.Drawing.Size(76, 20);
            this.lblNombrePar.TabIndex = 19;
            this.lblNombrePar.Text = "Nombre:";
            // 
            // txtContador
            // 
            this.txtContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContador.Location = new System.Drawing.Point(111, 40);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(169, 26);
            this.txtContador.TabIndex = 14;
            this.txtContador.TextChanged += new System.EventHandler(this.txtContador_TextChanged);
            this.txtContador.LostFocus += new System.EventHandler(this.txtContador_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Contador:";
            // 
            // pbxCliente
            // 
            this.pbxCliente.BackColor = System.Drawing.Color.Transparent;
            this.pbxCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbxCliente.Image")));
            this.pbxCliente.Location = new System.Drawing.Point(286, 40);
            this.pbxCliente.Name = "pbxCliente";
            this.pbxCliente.Size = new System.Drawing.Size(26, 26);
            this.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCliente.TabIndex = 15;
            this.pbxCliente.TabStop = false;
            this.pbxCliente.Click += new System.EventHandler(this.pbxCliente_Click);
            // 
            // cbReporte
            // 
            this.cbReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReporte.FormattingEnabled = true;
            this.cbReporte.Items.AddRange(new object[] {
            "Consumo por Comunidad",
            "Estado de Cuenta"});
            this.cbReporte.Location = new System.Drawing.Point(267, 29);
            this.cbReporte.Name = "cbReporte";
            this.cbReporte.Size = new System.Drawing.Size(201, 21);
            this.cbReporte.TabIndex = 17;
            this.cbReporte.SelectedIndexChanged += new System.EventHandler(this.cbReporte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Reporte:";
            // 
            // gbConsumo
            // 
            this.gbConsumo.Controls.Add(this.cmbComunidad);
            this.gbConsumo.Controls.Add(this.lblComunidad);
            this.gbConsumo.Controls.Add(this.numericUpDown1);
            this.gbConsumo.Controls.Add(this.label4);
            this.gbConsumo.Controls.Add(this.comboBox1);
            this.gbConsumo.Location = new System.Drawing.Point(158, 82);
            this.gbConsumo.Name = "gbConsumo";
            this.gbConsumo.Size = new System.Drawing.Size(348, 182);
            this.gbConsumo.TabIndex = 20;
            this.gbConsumo.TabStop = false;
            this.gbConsumo.Text = "Consumo por Comunidad";
            this.gbConsumo.Visible = false;
            // 
            // cmbComunidad
            // 
            this.cmbComunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComunidad.Location = new System.Drawing.Point(21, 49);
            this.cmbComunidad.Name = "cmbComunidad";
            this.cmbComunidad.Size = new System.Drawing.Size(290, 21);
            this.cmbComunidad.TabIndex = 21;
            // 
            // lblComunidad
            // 
            this.lblComunidad.AutoSize = true;
            this.lblComunidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComunidad.Location = new System.Drawing.Point(18, 26);
            this.lblComunidad.Name = "lblComunidad";
            this.lblComunidad.Size = new System.Drawing.Size(99, 20);
            this.lblComunidad.TabIndex = 20;
            this.lblComunidad.Text = "Comunidad";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(196, 117);
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
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha:";
            // 
            // comboBox1
            // 
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
            this.comboBox1.Location = new System.Drawing.Point(21, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // mCHDataSetBindingSource
            // 
            this.mCHDataSetBindingSource.DataSource = this.mCHDataSet;
            this.mCHDataSetBindingSource.Position = 0;
            // 
            // sp_reporte_comunidadTableAdapter
            // 
            this.sp_reporte_comunidadTableAdapter.ClearBeforeFill = true;
            // 
            // mCHDataSet2
            // 
            this.mCHDataSet2.DataSetName = "MCHDataSet2";
            this.mCHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mCHDataSet2BindingSource
            // 
            this.mCHDataSet2BindingSource.DataSource = this.mCHDataSet2;
            this.mCHDataSet2BindingSource.Position = 0;
            // 
            // vconsumocomunidadBindingSource
            // 
            this.vconsumocomunidadBindingSource.DataMember = "v_consumo_comunidad";
            this.vconsumocomunidadBindingSource.DataSource = this.mCHDataSet2BindingSource;
            // 
            // v_consumo_comunidadTableAdapter
            // 
            this.v_consumo_comunidadTableAdapter.ClearBeforeFill = true;
            // 
            // v_consumo_comunidadBindingSource
            // 
            this.v_consumo_comunidadBindingSource.DataMember = "v_consumo_comunidad";
            this.v_consumo_comunidadBindingSource.DataSource = this.mCHDataSet2;
            // 
            // vconsumocomunidadBindingSource1
            // 
            this.vconsumocomunidadBindingSource1.DataMember = "v_consumo_comunidad";
            this.vconsumocomunidadBindingSource1.DataSource = this.mCHDataSet2BindingSource;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "MCHDataSet_sp_reporte_comunidad";
            reportDataSource2.Value = this.sp_reporte_comunidadBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication2.RConsumoComunidad.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 12);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(689, 489);
            this.reportViewer2.TabIndex = 15;
            this.reportViewer2.Visible = false;
            this.reportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.reportViewer2);
            this.Name = "frmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReporte_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.sp_reporte_comunidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreportecomunidadBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).EndInit();
            this.gbConsumo.ResumeLayout(false);
            this.gbConsumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCHDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vconsumocomunidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_consumo_comunidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vconsumocomunidadBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource spreportecomunidadBindingSource;
        private MCHDataSet mCHDataSet;
        private System.Windows.Forms.BindingSource mCHDataSetBindingSource;
        private WindowsFormsApplication2.MCHDataSetTableAdapters.sp_reporte_comunidadTableAdapter sp_reporte_comunidadTableAdapter;
        private MCHDataSet2 mCHDataSet2;
        private System.Windows.Forms.BindingSource mCHDataSet2BindingSource;
        private System.Windows.Forms.BindingSource vconsumocomunidadBindingSource;
        private WindowsFormsApplication2.MCHDataSet2TableAdapters.v_consumo_comunidadTableAdapter v_consumo_comunidadTableAdapter;
        private System.Windows.Forms.BindingSource v_consumo_comunidadBindingSource;
        private System.Windows.Forms.BindingSource vconsumocomunidadBindingSource1;
        private System.Windows.Forms.BindingSource sp_reporte_comunidadBindingSource;
        private System.Windows.Forms.ComboBox cbReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxCliente;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.TextBox txtContrato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombrePar;
        private System.Windows.Forms.GroupBox gbConsumo;
        private System.Windows.Forms.ComboBox cmbComunidad;
        private System.Windows.Forms.Label lblComunidad;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox pbCancelar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}