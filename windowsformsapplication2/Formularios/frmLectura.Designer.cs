namespace WindowsFormsApplication2.Formularios
{
    partial class frmLectura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLectura));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_lecturas_no_pagadas = new System.Windows.Forms.DataGridView();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_eliminar_lecturas = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtNoContador = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtLectura = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.txtFechaLectura = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lecturas_no_pagadas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Barra_Inferior;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 520);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblCancelar);
            this.panel1.Controls.Add(this.pbCancelar);
            this.panel1.Controls.Add(this.lblGuardar);
            this.panel1.Controls.Add(this.pbGuardar);
            this.panel1.Location = new System.Drawing.Point(703, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 350);
            this.panel1.TabIndex = 8;
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(-2, 175);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(80, 20);
            this.lblCancelar.TabIndex = 1;
            this.lblCancelar.Text = "Cancelar";
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Transparent;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelar.Image")));
            this.pbCancelar.Location = new System.Drawing.Point(12, 127);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(48, 45);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancelar.TabIndex = 2;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.ForeColor = System.Drawing.Color.White;
            this.lblGuardar.Location = new System.Drawing.Point(0, 79);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(75, 20);
            this.lblGuardar.TabIndex = 0;
            this.lblGuardar.Text = "Guardar";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(33, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 83);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgv_lecturas_no_pagadas);
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Controls.Add(this.btn_eliminar_lecturas);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Controls.Add(this.txtNoContador);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Controls.Add(this.txtLectura);
            this.panel2.Controls.Add(this.lblContador);
            this.panel2.Controls.Add(this.txtFechaLectura);
            this.panel2.Controls.Add(this.lblCliente);
            this.panel2.Location = new System.Drawing.Point(33, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 419);
            this.panel2.TabIndex = 7;
            // 
            // dgv_lecturas_no_pagadas
            // 
            this.dgv_lecturas_no_pagadas.AllowUserToAddRows = false;
            this.dgv_lecturas_no_pagadas.AllowUserToDeleteRows = false;
            this.dgv_lecturas_no_pagadas.AllowUserToResizeColumns = false;
            this.dgv_lecturas_no_pagadas.AllowUserToResizeRows = false;
            this.dgv_lecturas_no_pagadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lecturas_no_pagadas.Location = new System.Drawing.Point(189, 319);
            this.dgv_lecturas_no_pagadas.Name = "dgv_lecturas_no_pagadas";
            this.dgv_lecturas_no_pagadas.ReadOnly = true;
            this.dgv_lecturas_no_pagadas.RowHeadersVisible = false;
            this.dgv_lecturas_no_pagadas.Size = new System.Drawing.Size(221, 93);
            this.dgv_lecturas_no_pagadas.TabIndex = 18;
            this.dgv_lecturas_no_pagadas.Visible = false;
            this.dgv_lecturas_no_pagadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lecturas_no_pagadas_CellClick);
            this.dgv_lecturas_no_pagadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lecturas_no_pagadas_CellContentClick);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(418, 389);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 17;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Visible = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_eliminar_lecturas
            // 
            this.btn_eliminar_lecturas.Location = new System.Drawing.Point(10, 319);
            this.btn_eliminar_lecturas.Name = "btn_eliminar_lecturas";
            this.btn_eliminar_lecturas.Size = new System.Drawing.Size(173, 45);
            this.btn_eliminar_lecturas.TabIndex = 16;
            this.btn_eliminar_lecturas.Text = "Eliminar Lecturas";
            this.btn_eliminar_lecturas.UseVisualStyleBackColor = true;
            this.btn_eliminar_lecturas.Click += new System.EventHandler(this.btn_eliminar_lecturas_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(417, 130);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // txtNoContador
            // 
            this.txtNoContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoContador.Location = new System.Drawing.Point(189, 173);
            this.txtNoContador.Name = "txtNoContador";
            this.txtNoContador.Size = new System.Drawing.Size(221, 26);
            this.txtNoContador.TabIndex = 14;
            this.txtNoContador.TextChanged += new System.EventHandler(this.txtNoContador_TextChanged);
            this.txtNoContador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoContador_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(63, 173);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(120, 20);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "No. Contador:";
            // 
            // txtLectura
            // 
            this.txtLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLectura.Location = new System.Drawing.Point(189, 237);
            this.txtLectura.Name = "txtLectura";
            this.txtLectura.Size = new System.Drawing.Size(221, 26);
            this.txtLectura.TabIndex = 3;
            this.txtLectura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLectura_KeyPress);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(6, 237);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(177, 20);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "Lectura en Kilowatts:";
            // 
            // txtFechaLectura
            // 
            this.txtFechaLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaLectura.Location = new System.Drawing.Point(189, 205);
            this.txtFechaLectura.Name = "txtFechaLectura";
            this.txtFechaLectura.ReadOnly = true;
            this.txtFechaLectura.Size = new System.Drawing.Size(221, 26);
            this.txtFechaLectura.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(34, 205);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(149, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Fecha de lectura:";
            // 
            // frmLectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(799, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLectura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Lecturas";
            this.Load += new System.EventHandler(this.frmLectura_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLectura_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lecturas_no_pagadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtLectura;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox txtFechaLectura;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtNoContador;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dgv_lecturas_no_pagadas;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_eliminar_lecturas;
    }
}