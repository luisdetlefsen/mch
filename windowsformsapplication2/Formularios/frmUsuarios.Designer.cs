namespace WindowsFormsApplication2
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Barra_Inferior;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 270);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(802, 83);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Barra_Lateral;
            this.panel1.Controls.Add(this.lblCancelar);
            this.panel1.Controls.Add(this.pbCancelar);
            this.panel1.Controls.Add(this.lblGuardar);
            this.panel1.Controls.Add(this.pbGuardar);
            this.panel1.Location = new System.Drawing.Point(703, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 252);
            this.panel1.TabIndex = 4;
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(-2, 186);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(80, 20);
            this.lblCancelar.TabIndex = 5;
            this.lblCancelar.Text = "Cancelar";
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Transparent;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = global::WindowsFormsApplication2.Properties.Resources._return;
            this.pbCancelar.Location = new System.Drawing.Point(12, 138);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(48, 45);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancelar.TabIndex = 6;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.ForeColor = System.Drawing.Color.White;
            this.lblGuardar.Location = new System.Drawing.Point(1, 94);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(73, 20);
            this.lblGuardar.TabIndex = 3;
            this.lblGuardar.Text = "Agregar";
            // 
            // pbGuardar
            // 
            this.pbGuardar.BackColor = System.Drawing.Color.Transparent;
            this.pbGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pbGuardar.Image")));
            this.pbGuardar.Location = new System.Drawing.Point(12, 46);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(48, 45);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardar.TabIndex = 4;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(203, 67);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(418, 26);
            this.tbNombre.TabIndex = 5;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.Color.Transparent;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(82, 73);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(76, 20);
            this.lblContador.TabIndex = 6;
            this.lblContador.Text = "Nombre:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(203, 121);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(418, 26);
            this.tbUsuario.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario:";
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(203, 169);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(418, 26);
            this.tbPass.TabIndex = 9;
            this.tbPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña:";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(792, 343);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarios";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear usuario";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;


    }
}
