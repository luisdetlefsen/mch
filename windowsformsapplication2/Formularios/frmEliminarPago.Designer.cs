namespace WindowsFormsApplication2.Formularios
{
    partial class frmEliminarPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarPago));
            this.pbxContador = new System.Windows.Forms.PictureBox();
            this.txtDireccionContador = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.dgvPagosRealizados = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.txtIDContador = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxContador)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.pnlResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosRealizados)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxContador
            // 
            this.pbxContador.BackColor = System.Drawing.Color.Transparent;
            this.pbxContador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxContador.Image = ((System.Drawing.Image)(resources.GetObject("pbxContador.Image")));
            this.pbxContador.Location = new System.Drawing.Point(568, 16);
            this.pbxContador.Name = "pbxContador";
            this.pbxContador.Size = new System.Drawing.Size(26, 26);
            this.pbxContador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxContador.TabIndex = 13;
            this.pbxContador.TabStop = false;
            this.pbxContador.Click += new System.EventHandler(this.pbxContador_Click);
            // 
            // txtDireccionContador
            // 
            this.txtDireccionContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionContador.Location = new System.Drawing.Point(303, 16);
            this.txtDireccionContador.Name = "txtDireccionContador";
            this.txtDireccionContador.ReadOnly = true;
            this.txtDireccionContador.Size = new System.Drawing.Size(262, 26);
            this.txtDireccionContador.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(164, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(401, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblGuardar);
            this.panel1.Controls.Add(this.pbGuardar);
            this.panel1.Location = new System.Drawing.Point(700, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 406);
            this.panel1.TabIndex = 4;
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.ForeColor = System.Drawing.Color.White;
            this.lblGuardar.Location = new System.Drawing.Point(11, 79);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(73, 20);
            this.lblGuardar.TabIndex = 0;
            this.lblGuardar.Text = "Eliminar";
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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(48, 51);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 20);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Nombre:";
            // 
            // pnlResultados
            // 
            this.pnlResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlResultados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlResultados.Controls.Add(this.dgvPagosRealizados);
            this.pnlResultados.Location = new System.Drawing.Point(21, 127);
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.Size = new System.Drawing.Size(612, 184);
            this.pnlResultados.TabIndex = 8;
            // 
            // dgvPagosRealizados
            // 
            this.dgvPagosRealizados.AllowUserToAddRows = false;
            this.dgvPagosRealizados.AllowUserToDeleteRows = false;
            this.dgvPagosRealizados.AllowUserToResizeColumns = false;
            this.dgvPagosRealizados.AllowUserToResizeRows = false;
            this.dgvPagosRealizados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvPagosRealizados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosRealizados.Location = new System.Drawing.Point(29, 17);
            this.dgvPagosRealizados.MultiSelect = false;
            this.dgvPagosRealizados.Name = "dgvPagosRealizados";
            this.dgvPagosRealizados.ReadOnly = true;
            this.dgvPagosRealizados.RowHeadersVisible = false;
            this.dgvPagosRealizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagosRealizados.Size = new System.Drawing.Size(542, 147);
            this.dgvPagosRealizados.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pbxContador);
            this.panel2.Controls.Add(this.txtDireccionContador);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Controls.Add(this.pnlResultados);
            this.panel2.Controls.Add(this.txtDocumento);
            this.panel2.Controls.Add(this.lblFechaInicial);
            this.panel2.Controls.Add(this.txtIDContador);
            this.panel2.Controls.Add(this.lblContador);
            this.panel2.Location = new System.Drawing.Point(16, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 493);
            this.panel2.TabIndex = 3;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(164, 85);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(401, 26);
            this.txtDocumento.TabIndex = 2;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(48, 88);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(101, 20);
            this.lblFechaInicial.TabIndex = 4;
            this.lblFechaInicial.Text = "CUI/Cédula";
            // 
            // txtIDContador
            // 
            this.txtIDContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDContador.Location = new System.Drawing.Point(164, 16);
            this.txtIDContador.Name = "txtIDContador";
            this.txtIDContador.Size = new System.Drawing.Size(133, 26);
            this.txtIDContador.TabIndex = 0;
            this.txtIDContador.LostFocus += new System.EventHandler(this.txtIDContador_LostFocus);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(48, 19);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(83, 20);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "Contador";
            // 
            // frmEliminarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(799, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmEliminarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Pago";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEliminarPago_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbxContador)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.pnlResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosRealizados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxContador;
        private System.Windows.Forms.TextBox txtDireccionContador;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.DataGridView dgvPagosRealizados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.TextBox txtIDContador;
        private System.Windows.Forms.Label lblContador;
    }
}