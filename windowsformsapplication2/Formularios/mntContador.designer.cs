namespace WindowsFormsApplication2
{
    partial class mntContador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mntContador));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbNuevoContador = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.txtcodigoBusca = new System.Windows.Forms.TextBox();
            this.lblCodigoBusca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPoste = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.lbTipoServ = new System.Windows.Forms.Label();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.txtPoste = new System.Windows.Forms.TextBox();
            this.txtCodigob = new System.Windows.Forms.TextBox();
            this.cmbComunidad = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblComunidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoContador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pbNuevoContador);
            this.panel3.Controls.Add(this.pbBuscar);
            this.panel3.Controls.Add(this.txtcodigoBusca);
            this.panel3.Controls.Add(this.lblCodigoBusca);
            this.panel3.Location = new System.Drawing.Point(33, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 83);
            this.panel3.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(434, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nuevo";
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
            // pbNuevoContador
            // 
            this.pbNuevoContador.BackColor = System.Drawing.Color.Transparent;
            this.pbNuevoContador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNuevoContador.Image = ((System.Drawing.Image)(resources.GetObject("pbNuevoContador.Image")));
            this.pbNuevoContador.Location = new System.Drawing.Point(440, 5);
            this.pbNuevoContador.Name = "pbNuevoContador";
            this.pbNuevoContador.Size = new System.Drawing.Size(49, 47);
            this.pbNuevoContador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNuevoContador.TabIndex = 6;
            this.pbNuevoContador.TabStop = false;
            this.pbNuevoContador.Click += new System.EventHandler(this.pbNuevoContador_Click);
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
            // txtcodigoBusca
            // 
            this.txtcodigoBusca.Location = new System.Drawing.Point(77, 31);
            this.txtcodigoBusca.MaxLength = 100;
            this.txtcodigoBusca.Name = "txtcodigoBusca";
            this.txtcodigoBusca.Size = new System.Drawing.Size(247, 20);
            this.txtcodigoBusca.TabIndex = 3;
            // 
            // lblCodigoBusca
            // 
            this.lblCodigoBusca.AutoSize = true;
            this.lblCodigoBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBusca.ForeColor = System.Drawing.Color.White;
            this.lblCodigoBusca.Location = new System.Drawing.Point(5, 29);
            this.lblCodigoBusca.Name = "lblCodigoBusca";
            this.lblCodigoBusca.Size = new System.Drawing.Size(65, 20);
            this.lblCodigoBusca.TabIndex = 4;
            this.lblCodigoBusca.Text = "Código";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Barra_Inferior;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 520);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblPoste
            // 
            this.lblPoste.AutoSize = true;
            this.lblPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoste.Location = new System.Drawing.Point(18, 92);
            this.lblPoste.Name = "lblPoste";
            this.lblPoste.Size = new System.Drawing.Size(92, 20);
            this.lblPoste.TabIndex = 2;
            this.lblPoste.Text = "No. Poste:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cmbTipoServicio);
            this.panel2.Controls.Add(this.lbTipoServ);
            this.panel2.Controls.Add(this.txtDirección);
            this.panel2.Controls.Add(this.txtPoste);
            this.panel2.Controls.Add(this.txtCodigob);
            this.panel2.Controls.Add(this.cmbComunidad);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Controls.Add(this.lblComunidad);
            this.panel2.Controls.Add(this.lblPoste);
            this.panel2.Controls.Add(this.lblDireccion);
            this.panel2.Location = new System.Drawing.Point(33, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 419);
            this.panel2.TabIndex = 6;
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoServicio.Location = new System.Drawing.Point(175, 168);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(477, 21);
            this.cmbTipoServicio.TabIndex = 15;
            // 
            // lbTipoServ
            // 
            this.lbTipoServ.AutoSize = true;
            this.lbTipoServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoServ.Location = new System.Drawing.Point(18, 169);
            this.lbTipoServ.Name = "lbTipoServ";
            this.lbTipoServ.Size = new System.Drawing.Size(141, 20);
            this.lbTipoServ.TabIndex = 21;
            this.lbTipoServ.Text = "Tipo de Servicio:";
            // 
            // txtDirección
            // 
            this.txtDirección.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirección.Location = new System.Drawing.Point(175, 202);
            this.txtDirección.MaxLength = 255;
            this.txtDirección.Multiline = true;
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(477, 70);
            this.txtDirección.TabIndex = 16;
            // 
            // txtPoste
            // 
            this.txtPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoste.Location = new System.Drawing.Point(175, 89);
            this.txtPoste.MaxLength = 45;
            this.txtPoste.Name = "txtPoste";
            this.txtPoste.Size = new System.Drawing.Size(477, 26);
            this.txtPoste.TabIndex = 13;
            // 
            // txtCodigob
            // 
            this.txtCodigob.Enabled = false;
            this.txtCodigob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigob.Location = new System.Drawing.Point(175, 49);
            this.txtCodigob.MaxLength = 100;
            this.txtCodigob.Name = "txtCodigob";
            this.txtCodigob.Size = new System.Drawing.Size(477, 26);
            this.txtCodigob.TabIndex = 12;
            this.txtCodigob.TextChanged += new System.EventHandler(this.txtCodigob_TextChanged);
            this.txtCodigob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigob_KeyPress);
            // 
            // cmbComunidad
            // 
            this.cmbComunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComunidad.Location = new System.Drawing.Point(175, 134);
            this.cmbComunidad.Name = "cmbComunidad";
            this.cmbComunidad.Size = new System.Drawing.Size(477, 21);
            this.cmbComunidad.TabIndex = 14;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(18, 52);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Código:";
            // 
            // lblComunidad
            // 
            this.lblComunidad.AutoSize = true;
            this.lblComunidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComunidad.Location = new System.Drawing.Point(18, 134);
            this.lblComunidad.Name = "lblComunidad";
            this.lblComunidad.Size = new System.Drawing.Size(109, 20);
            this.lblComunidad.TabIndex = 4;
            this.lblComunidad.Text = "Comunidad: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(18, 205);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(89, 20);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.ForeColor = System.Drawing.Color.White;
            this.lblEliminar.Location = new System.Drawing.Point(0, 283);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(73, 20);
            this.lblEliminar.TabIndex = 5;
            this.lblEliminar.Text = "Eliminar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblEliminar);
            this.panel1.Controls.Add(this.pbEliminar);
            this.panel1.Controls.Add(this.lblCancelar);
            this.panel1.Controls.Add(this.pbCancelar);
            this.panel1.Controls.Add(this.lblGuardar);
            this.panel1.Controls.Add(this.pbGuardar);
            this.panel1.Location = new System.Drawing.Point(703, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 350);
            this.panel1.TabIndex = 5;
            // 
            // pbEliminar
            // 
            this.pbEliminar.BackColor = System.Drawing.Color.Transparent;
            this.pbEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminar.Image")));
            this.pbEliminar.Location = new System.Drawing.Point(12, 235);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(48, 45);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEliminar.TabIndex = 4;
            this.pbEliminar.TabStop = false;
            this.pbEliminar.Click += new System.EventHandler(this.pbEliminar_Click);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(-2, 175);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(80, 20);
            this.lblCancelar.TabIndex = 3;
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
            this.lblGuardar.TabIndex = 1;
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
            // mntContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(799, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Name = "mntContador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Contadores";
            this.Load += new System.EventHandler(this.mntContador_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mntPersona_FormClosed);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoContador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbNuevoContador;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.TextBox txtcodigoBusca;
        private System.Windows.Forms.Label lblCodigoBusca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPoste;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.Label lblComunidad;
        private System.Windows.Forms.TextBox txtPoste;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cmbComunidad;
        private System.Windows.Forms.TextBox txtCodigob;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.Label lbTipoServ;
    }
}