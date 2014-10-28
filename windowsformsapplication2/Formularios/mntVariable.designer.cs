namespace WindowsFormsApplication2
{
    partial class mntVariable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mntVariable));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtNombrePar = new System.Windows.Forms.TextBox();
            this.lblNombrePar = new System.Windows.Forms.Label();
            this.pnlParametros = new System.Windows.Forms.Panel();
            this.pbModificar = new System.Windows.Forms.PictureBox();
            this.lblModificar = new System.Windows.Forms.Label();
            this.dgvParametros = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_parametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip_parametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInsertar = new System.Windows.Forms.Panel();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametros)).BeginInit();
            this.pnlInsertar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.lblValor);
            this.panel2.Controls.Add(this.txtNombrePar);
            this.panel2.Controls.Add(this.lblNombrePar);
            this.panel2.Location = new System.Drawing.Point(51, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 419);
            this.panel2.TabIndex = 7;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(303, 180);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(103, 20);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(306, 145);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(223, 26);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(244, 147);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(56, 20);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // txtNombrePar
            // 
            this.txtNombrePar.Enabled = false;
            this.txtNombrePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePar.Location = new System.Drawing.Point(306, 98);
            this.txtNombrePar.Name = "txtNombrePar";
            this.txtNombrePar.Size = new System.Drawing.Size(223, 26);
            this.txtNombrePar.TabIndex = 1;
            // 
            // lblNombrePar
            // 
            this.lblNombrePar.AutoSize = true;
            this.lblNombrePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePar.Location = new System.Drawing.Point(224, 101);
            this.lblNombrePar.Name = "lblNombrePar";
            this.lblNombrePar.Size = new System.Drawing.Size(76, 20);
            this.lblNombrePar.TabIndex = 0;
            this.lblNombrePar.Text = "Nombre:";
            // 
            // pnlParametros
            // 
            this.pnlParametros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlParametros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlParametros.Controls.Add(this.pbModificar);
            this.pnlParametros.Controls.Add(this.lblModificar);
            this.pnlParametros.Controls.Add(this.dgvParametros);
            this.pnlParametros.Location = new System.Drawing.Point(9, 74);
            this.pnlParametros.Name = "pnlParametros";
            this.pnlParametros.Size = new System.Drawing.Size(184, 341);
            this.pnlParametros.TabIndex = 8;
            // 
            // pbModificar
            // 
            this.pbModificar.Image = global::WindowsFormsApplication2.Properties.Resources.setting;
            this.pbModificar.Location = new System.Drawing.Point(19, 279);
            this.pbModificar.Name = "pbModificar";
            this.pbModificar.Size = new System.Drawing.Size(48, 45);
            this.pbModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbModificar.TabIndex = 4;
            this.pbModificar.TabStop = false;
            this.pbModificar.Click += new System.EventHandler(this.pbModificar_Click);
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.White;
            this.lblModificar.Location = new System.Drawing.Point(73, 291);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(82, 20);
            this.lblModificar.TabIndex = 5;
            this.lblModificar.Text = "Modificar";
            this.lblModificar.EnabledChanged += new System.EventHandler(this.lblModificar_EnabledChanged);
            // 
            // dgvParametros
            // 
            this.dgvParametros.AllowUserToAddRows = false;
            this.dgvParametros.AllowUserToDeleteRows = false;
            this.dgvParametros.AllowUserToResizeColumns = false;
            this.dgvParametros.AllowUserToResizeRows = false;
            this.dgvParametros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvParametros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.id_parametro,
            this.tip_parametro,
            this.parametro,
            this.valor});
            this.dgvParametros.Location = new System.Drawing.Point(12, 13);
            this.dgvParametros.Name = "dgvParametros";
            this.dgvParametros.ReadOnly = true;
            this.dgvParametros.RowHeadersVisible = false;
            this.dgvParametros.Size = new System.Drawing.Size(152, 249);
            this.dgvParametros.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre.Width = 150;
            // 
            // id_parametro
            // 
            this.id_parametro.DataPropertyName = "id_parametro";
            this.id_parametro.HeaderText = "id_parametro";
            this.id_parametro.Name = "id_parametro";
            this.id_parametro.ReadOnly = true;
            this.id_parametro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_parametro.Visible = false;
            this.id_parametro.Width = 45;
            // 
            // tip_parametro
            // 
            this.tip_parametro.DataPropertyName = "tip_parametro";
            this.tip_parametro.HeaderText = "tip_parametro";
            this.tip_parametro.Name = "tip_parametro";
            this.tip_parametro.ReadOnly = true;
            this.tip_parametro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tip_parametro.Visible = false;
            // 
            // parametro
            // 
            this.parametro.DataPropertyName = "parametro";
            this.parametro.HeaderText = "parametro";
            this.parametro.Name = "parametro";
            this.parametro.ReadOnly = true;
            this.parametro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.parametro.Visible = false;
            this.parametro.Width = 270;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.valor.Visible = false;
            // 
            // pnlInsertar
            // 
            this.pnlInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlInsertar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInsertar.Controls.Add(this.lblCancelar);
            this.pnlInsertar.Controls.Add(this.pbCancelar);
            this.pnlInsertar.Controls.Add(this.lblGuardar);
            this.pnlInsertar.Controls.Add(this.pbGuardar);
            this.pnlInsertar.Location = new System.Drawing.Point(700, 74);
            this.pnlInsertar.Name = "pnlInsertar";
            this.pnlInsertar.Size = new System.Drawing.Size(82, 235);
            this.pnlInsertar.TabIndex = 8;
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
            this.pbCancelar.Location = new System.Drawing.Point(14, 127);
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
            this.lblGuardar.Location = new System.Drawing.Point(2, 79);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(75, 20);
            this.lblGuardar.TabIndex = 1;
            this.lblGuardar.Text = "Guardar";
            this.lblGuardar.EnabledChanged += new System.EventHandler(this.lblGuardar_EnabledChanged);
            // 
            // pbGuardar
            // 
            this.pbGuardar.BackColor = System.Drawing.Color.Transparent;
            this.pbGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pbGuardar.Image")));
            this.pbGuardar.Location = new System.Drawing.Point(14, 35);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(48, 45);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardar.TabIndex = 0;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(191, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_password);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(512, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 59);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(14, 18);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(173, 20);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "Cambiar Contraseña";
            // 
            // mntVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(786, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlParametros);
            this.Controls.Add(this.pnlInsertar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "mntVariable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Parámetros";
            this.Load += new System.EventHandler(this.mntVariable_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mntVariable_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlParametros.ResumeLayout(false);
            this.pnlParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametros)).EndInit();
            this.pnlInsertar.ResumeLayout(false);
            this.pnlInsertar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlParametros;
        private System.Windows.Forms.DataGridView dgvParametros;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtNombrePar;
        private System.Windows.Forms.Label lblNombrePar;
        private System.Windows.Forms.Panel pnlInsertar;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_parametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip_parametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn parametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.PictureBox pbModificar;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_password;
    }
}