namespace WindowsFormsApplication2
{
    partial class frmControlCom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlCom));
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_ingresar = new System.Windows.Forms.GroupBox();
            this.txt_cargo_comunidad_insertar = new System.Windows.Forms.MaskedTextBox();
            this.cb_hidroelectrica_insertar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox5_insertar = new System.Windows.Forms.PictureBox();
            this.txt_nombre_comunidad_insertar = new System.Windows.Forms.TextBox();
            this.gb_eliminar = new System.Windows.Forms.GroupBox();
            this.txt_nombre_comunidad_elimina = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox4_elimina = new System.Windows.Forms.PictureBox();
            this.gb_actualizar = new System.Windows.Forms.GroupBox();
            this.txt_nombre_comunidad_actualizar = new System.Windows.Forms.ComboBox();
            this.txt_cargo_comunidad_actualizar = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_ingresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5_insertar)).BeginInit();
            this.gb_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_elimina)).BeginInit();
            this.gb_actualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::WindowsFormsApplication2.Properties.Resources.Lectura;
            this.button5.Location = new System.Drawing.Point(500, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 146);
            this.button5.TabIndex = 15;
            this.button5.Text = "Eliminar Comunidad";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.checklist2;
            this.button2.Location = new System.Drawing.Point(312, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 146);
            this.button2.TabIndex = 14;
            this.button2.Text = "Actualizar Comunidad";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication2.Properties.Resources.Persona;
            this.button1.Location = new System.Drawing.Point(125, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 146);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ingresar Comunidad";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Barra_Lateral;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // gb_ingresar
            // 
            this.gb_ingresar.Controls.Add(this.txt_cargo_comunidad_insertar);
            this.gb_ingresar.Controls.Add(this.cb_hidroelectrica_insertar);
            this.gb_ingresar.Controls.Add(this.label6);
            this.gb_ingresar.Controls.Add(this.label7);
            this.gb_ingresar.Controls.Add(this.label16);
            this.gb_ingresar.Controls.Add(this.label17);
            this.gb_ingresar.Controls.Add(this.pictureBox5_insertar);
            this.gb_ingresar.Controls.Add(this.txt_nombre_comunidad_insertar);
            this.gb_ingresar.Location = new System.Drawing.Point(126, 227);
            this.gb_ingresar.Name = "gb_ingresar";
            this.gb_ingresar.Size = new System.Drawing.Size(506, 193);
            this.gb_ingresar.TabIndex = 21;
            this.gb_ingresar.TabStop = false;
            this.gb_ingresar.Text = "Insertar Comunidad";
            this.gb_ingresar.Visible = false;
            // 
            // txt_cargo_comunidad_insertar
            // 
            this.txt_cargo_comunidad_insertar.Location = new System.Drawing.Point(179, 139);
            this.txt_cargo_comunidad_insertar.Mask = "00000";
            this.txt_cargo_comunidad_insertar.Name = "txt_cargo_comunidad_insertar";
            this.txt_cargo_comunidad_insertar.Size = new System.Drawing.Size(214, 20);
            this.txt_cargo_comunidad_insertar.TabIndex = 18;
            this.txt_cargo_comunidad_insertar.ValidatingType = typeof(int);
            // 
            // cb_hidroelectrica_insertar
            // 
            this.cb_hidroelectrica_insertar.FormattingEnabled = true;
            this.cb_hidroelectrica_insertar.Items.AddRange(new object[] {
            "Hidroelectrica \"Las Conchas\"",
            "Hidroelectrica \"Jolom Ijix\"",
            "Hidroelectrica \"Seasir\""});
            this.cb_hidroelectrica_insertar.Location = new System.Drawing.Point(179, 92);
            this.cb_hidroelectrica_insertar.Name = "cb_hidroelectrica_insertar";
            this.cb_hidroelectrica_insertar.Size = new System.Drawing.Size(214, 21);
            this.cb_hidroelectrica_insertar.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cargo Comunidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hidroeléctrica";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Nombre Comunidad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(409, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 20);
            this.label17.TabIndex = 11;
            this.label17.Text = "Guardar";
            // 
            // pictureBox5_insertar
            // 
            this.pictureBox5_insertar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5_insertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5_insertar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5_insertar.Image")));
            this.pictureBox5_insertar.Location = new System.Drawing.Point(423, 46);
            this.pictureBox5_insertar.Name = "pictureBox5_insertar";
            this.pictureBox5_insertar.Size = new System.Drawing.Size(48, 45);
            this.pictureBox5_insertar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5_insertar.TabIndex = 10;
            this.pictureBox5_insertar.TabStop = false;
            this.pictureBox5_insertar.Click += new System.EventHandler(this.pictureBox5_insertar_Click);
            // 
            // txt_nombre_comunidad_insertar
            // 
            this.txt_nombre_comunidad_insertar.Location = new System.Drawing.Point(178, 46);
            this.txt_nombre_comunidad_insertar.Name = "txt_nombre_comunidad_insertar";
            this.txt_nombre_comunidad_insertar.Size = new System.Drawing.Size(215, 20);
            this.txt_nombre_comunidad_insertar.TabIndex = 1;
            // 
            // gb_eliminar
            // 
            this.gb_eliminar.Controls.Add(this.txt_nombre_comunidad_elimina);
            this.gb_eliminar.Controls.Add(this.label20);
            this.gb_eliminar.Controls.Add(this.label21);
            this.gb_eliminar.Controls.Add(this.pictureBox4_elimina);
            this.gb_eliminar.Location = new System.Drawing.Point(149, 227);
            this.gb_eliminar.Name = "gb_eliminar";
            this.gb_eliminar.Size = new System.Drawing.Size(506, 193);
            this.gb_eliminar.TabIndex = 22;
            this.gb_eliminar.TabStop = false;
            this.gb_eliminar.Text = "Eliminar Comunidad";
            this.gb_eliminar.Visible = false;
            // 
            // txt_nombre_comunidad_elimina
            // 
            this.txt_nombre_comunidad_elimina.FormattingEnabled = true;
            this.txt_nombre_comunidad_elimina.Location = new System.Drawing.Point(177, 85);
            this.txt_nombre_comunidad_elimina.Name = "txt_nombre_comunidad_elimina";
            this.txt_nombre_comunidad_elimina.Size = new System.Drawing.Size(216, 21);
            this.txt_nombre_comunidad_elimina.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 80);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(166, 20);
            this.label20.TabIndex = 12;
            this.label20.Text = "Nombre Comunidad";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Maroon;
            this.label21.Location = new System.Drawing.Point(401, 128);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 20);
            this.label21.TabIndex = 11;
            this.label21.Text = "Guardar";
            // 
            // pictureBox4_elimina
            // 
            this.pictureBox4_elimina.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4_elimina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4_elimina.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4_elimina.Image")));
            this.pictureBox4_elimina.Location = new System.Drawing.Point(413, 76);
            this.pictureBox4_elimina.Name = "pictureBox4_elimina";
            this.pictureBox4_elimina.Size = new System.Drawing.Size(48, 45);
            this.pictureBox4_elimina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4_elimina.TabIndex = 10;
            this.pictureBox4_elimina.TabStop = false;
            this.pictureBox4_elimina.Click += new System.EventHandler(this.pictureBox4_elimina_Click);
            // 
            // gb_actualizar
            // 
            this.gb_actualizar.Controls.Add(this.txt_nombre_comunidad_actualizar);
            this.gb_actualizar.Controls.Add(this.txt_cargo_comunidad_actualizar);
            this.gb_actualizar.Controls.Add(this.label1);
            this.gb_actualizar.Controls.Add(this.label3);
            this.gb_actualizar.Controls.Add(this.label4);
            this.gb_actualizar.Controls.Add(this.pictureBox2);
            this.gb_actualizar.Location = new System.Drawing.Point(125, 246);
            this.gb_actualizar.Name = "gb_actualizar";
            this.gb_actualizar.Size = new System.Drawing.Size(506, 193);
            this.gb_actualizar.TabIndex = 22;
            this.gb_actualizar.TabStop = false;
            this.gb_actualizar.Text = "Actualizar Comunidad";
            this.gb_actualizar.Visible = false;
            // 
            // txt_nombre_comunidad_actualizar
            // 
            this.txt_nombre_comunidad_actualizar.FormattingEnabled = true;
            this.txt_nombre_comunidad_actualizar.Location = new System.Drawing.Point(179, 46);
            this.txt_nombre_comunidad_actualizar.Name = "txt_nombre_comunidad_actualizar";
            this.txt_nombre_comunidad_actualizar.Size = new System.Drawing.Size(215, 21);
            this.txt_nombre_comunidad_actualizar.TabIndex = 20;
            // 
            // txt_cargo_comunidad_actualizar
            // 
            this.txt_cargo_comunidad_actualizar.Location = new System.Drawing.Point(179, 81);
            this.txt_cargo_comunidad_actualizar.Mask = "00000";
            this.txt_cargo_comunidad_actualizar.Name = "txt_cargo_comunidad_actualizar";
            this.txt_cargo_comunidad_actualizar.Size = new System.Drawing.Size(214, 20);
            this.txt_cargo_comunidad_actualizar.TabIndex = 19;
            this.txt_cargo_comunidad_actualizar.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cargo Comunidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre Comunidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(409, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Guardar";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(423, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Transparent;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = global::WindowsFormsApplication2.Properties.Resources._return;
            this.pbCancelar.Location = new System.Drawing.Point(646, 528);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(48, 45);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancelar.TabIndex = 23;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // frmControlCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 585);
            this.Controls.Add(this.pbCancelar);
            this.Controls.Add(this.gb_eliminar);
            this.Controls.Add(this.gb_actualizar);
            this.Controls.Add(this.gb_ingresar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmControlCom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Comunidades";
            this.Load += new System.EventHandler(this.frmControlCom_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmControlCom_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_ingresar.ResumeLayout(false);
            this.gb_ingresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5_insertar)).EndInit();
            this.gb_eliminar.ResumeLayout(false);
            this.gb_eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_elimina)).EndInit();
            this.gb_actualizar.ResumeLayout(false);
            this.gb_actualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gb_ingresar;
        private System.Windows.Forms.ComboBox cb_hidroelectrica_insertar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox5_insertar;
        private System.Windows.Forms.TextBox txt_nombre_comunidad_insertar;
        private System.Windows.Forms.GroupBox gb_eliminar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox4_elimina;
        private System.Windows.Forms.GroupBox gb_actualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox txt_cargo_comunidad_insertar;
        private System.Windows.Forms.MaskedTextBox txt_cargo_comunidad_actualizar;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.ComboBox txt_nombre_comunidad_elimina;
        private System.Windows.Forms.ComboBox txt_nombre_comunidad_actualizar;
    }
}