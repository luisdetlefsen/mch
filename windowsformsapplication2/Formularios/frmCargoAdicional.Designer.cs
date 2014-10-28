namespace WindowsFormsApplication2
{
    partial class frmCargoAdicional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargoAdicional));
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoFijo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCargoAbono = new System.Windows.Forms.ComboBox();
            this.chkTipoCobro = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPercent
            // 
            this.txtPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercent.Location = new System.Drawing.Point(145, 232);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(220, 26);
            this.txtPercent.TabIndex = 15;
            this.txtPercent.Tag = "";
            this.txtPercent.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Porcentaje:";
            // 
            // txtMontoFijo
            // 
            this.txtMontoFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoFijo.Location = new System.Drawing.Point(145, 179);
            this.txtMontoFijo.Name = "txtMontoFijo";
            this.txtMontoFijo.Size = new System.Drawing.Size(220, 26);
            this.txtMontoFijo.TabIndex = 13;
            this.txtMontoFijo.Tag = "";
            this.txtMontoFijo.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Monto Fijo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(145, 53);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(220, 26);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.Color.Transparent;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(24, 59);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(108, 20);
            this.lblContador.TabIndex = 12;
            this.lblContador.Text = "Descripción:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Barra_Lateral;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblGuardar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(386, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 289);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-2, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cancelar";
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.ForeColor = System.Drawing.Color.White;
            this.lblGuardar.Location = new System.Drawing.Point(2, 79);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(72, 20);
            this.lblGuardar.TabIndex = 6;
            this.lblGuardar.Text = "Aceptar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(13, 31);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(48, 45);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(13, 144);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 45);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cargo/Abono:";
            // 
            // cmbCargoAbono
            // 
            this.cmbCargoAbono.AutoCompleteCustomSource.AddRange(new string[] {
            "c",
            "a"});
            this.cmbCargoAbono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCargoAbono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCargoAbono.FormattingEnabled = true;
            this.cmbCargoAbono.Items.AddRange(new object[] {
            "Cargo",
            "Abono"});
            this.cmbCargoAbono.Location = new System.Drawing.Point(145, 110);
            this.cmbCargoAbono.Name = "cmbCargoAbono";
            this.cmbCargoAbono.Size = new System.Drawing.Size(220, 21);
            this.cmbCargoAbono.TabIndex = 19;
            // 
            // chkTipoCobro
            // 
            this.chkTipoCobro.AutoSize = true;
            this.chkTipoCobro.Location = new System.Drawing.Point(234, 146);
            this.chkTipoCobro.Name = "chkTipoCobro";
            this.chkTipoCobro.Size = new System.Drawing.Size(131, 17);
            this.chkTipoCobro.TabIndex = 20;
            this.chkTipoCobro.Text = "Cobro/Abono Variable";
            this.chkTipoCobro.UseVisualStyleBackColor = true;
            this.chkTipoCobro.CheckedChanged += new System.EventHandler(this.chkTipoCobro_CheckedChanged);
            // 
            // frmCargoAdicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 324);
            this.Controls.Add(this.chkTipoCobro);
            this.Controls.Add(this.cmbCargoAbono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMontoFijo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblContador);
            this.Name = "frmCargoAdicional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cobro/Abono Adicional";
            this.Load += new System.EventHandler(this.frmCargoAdicional_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoFijo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.PictureBox btnAceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCargoAbono;
        private System.Windows.Forms.CheckBox chkTipoCobro;
    }
}