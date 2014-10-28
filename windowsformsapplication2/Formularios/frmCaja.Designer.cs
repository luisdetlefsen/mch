namespace WindowsFormsApplication2.Formularios
{
    partial class frmCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaja));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_Trans = new System.Windows.Forms.GroupBox();
            this.tb_Desc_Trans = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_MontoTrans = new System.Windows.Forms.MaskedTextBox();
            this.pnlInsertar = new System.Windows.Forms.Panel();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_Salida = new System.Windows.Forms.RadioButton();
            this.rb_Ingreso = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_CerrarCaja = new System.Windows.Forms.GroupBox();
            this.tb_MontoCierre = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_AbrirCaja = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_Trans.SuspendLayout();
            this.pnlInsertar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.gb_CerrarCaja.SuspendLayout();
            this.gb_AbrirCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources._1383740864_cashbox_close2;
            this.button2.Location = new System.Drawing.Point(382, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 146);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cerrar Caja";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication2.Properties.Resources._1383740630_coins;
            this.button1.Location = new System.Drawing.Point(213, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 146);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ingreso o Salida de Dinero";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::WindowsFormsApplication2.Properties.Resources._1383740864_cashbox_open2;
            this.button7.Location = new System.Drawing.Point(42, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 146);
            this.button7.TabIndex = 16;
            this.button7.Text = "Abrir Caja";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Barra_Inferior;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 507);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // gb_Trans
            // 
            this.gb_Trans.BackColor = System.Drawing.Color.Transparent;
            this.gb_Trans.Controls.Add(this.tb_Desc_Trans);
            this.gb_Trans.Controls.Add(this.label4);
            this.gb_Trans.Controls.Add(this.tb_MontoTrans);
            this.gb_Trans.Controls.Add(this.pnlInsertar);
            this.gb_Trans.Controls.Add(this.label1);
            this.gb_Trans.Controls.Add(this.rb_Salida);
            this.gb_Trans.Controls.Add(this.rb_Ingreso);
            this.gb_Trans.Controls.Add(this.label2);
            this.gb_Trans.Location = new System.Drawing.Point(48, 189);
            this.gb_Trans.Name = "gb_Trans";
            this.gb_Trans.Size = new System.Drawing.Size(662, 260);
            this.gb_Trans.TabIndex = 19;
            this.gb_Trans.TabStop = false;
            this.gb_Trans.Text = "Ingreso o salida de dinero";
            this.gb_Trans.Visible = false;
            // 
            // tb_Desc_Trans
            // 
            this.tb_Desc_Trans.Location = new System.Drawing.Point(242, 131);
            this.tb_Desc_Trans.Name = "tb_Desc_Trans";
            this.tb_Desc_Trans.Size = new System.Drawing.Size(222, 20);
            this.tb_Desc_Trans.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Descripción:";
            // 
            // tb_MontoTrans
            // 
            this.tb_MontoTrans.Location = new System.Drawing.Point(242, 94);
            this.tb_MontoTrans.Mask = "######.##";
            this.tb_MontoTrans.Name = "tb_MontoTrans";
            this.tb_MontoTrans.Size = new System.Drawing.Size(100, 20);
            this.tb_MontoTrans.TabIndex = 21;
            // 
            // pnlInsertar
            // 
            this.pnlInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlInsertar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInsertar.Controls.Add(this.lblGuardar);
            this.pnlInsertar.Controls.Add(this.pbGuardar);
            this.pnlInsertar.Location = new System.Drawing.Point(516, 21);
            this.pnlInsertar.Name = "pnlInsertar";
            this.pnlInsertar.Size = new System.Drawing.Size(82, 229);
            this.pnlInsertar.TabIndex = 20;
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
            this.lblGuardar.Text = "Guardar";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Monto:";
            // 
            // rb_Salida
            // 
            this.rb_Salida.AutoSize = true;
            this.rb_Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Salida.Location = new System.Drawing.Point(346, 48);
            this.rb_Salida.Name = "rb_Salida";
            this.rb_Salida.Size = new System.Drawing.Size(65, 21);
            this.rb_Salida.TabIndex = 17;
            this.rb_Salida.Text = "Salida";
            this.rb_Salida.UseVisualStyleBackColor = true;
            // 
            // rb_Ingreso
            // 
            this.rb_Ingreso.AutoSize = true;
            this.rb_Ingreso.Checked = true;
            this.rb_Ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Ingreso.Location = new System.Drawing.Point(242, 48);
            this.rb_Ingreso.Name = "rb_Ingreso";
            this.rb_Ingreso.Size = new System.Drawing.Size(73, 21);
            this.rb_Ingreso.TabIndex = 16;
            this.rb_Ingreso.TabStop = true;
            this.rb_Ingreso.Text = "Ingreso";
            this.rb_Ingreso.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tipo:";
            // 
            // gb_CerrarCaja
            // 
            this.gb_CerrarCaja.BackColor = System.Drawing.Color.Transparent;
            this.gb_CerrarCaja.Controls.Add(this.tb_MontoCierre);
            this.gb_CerrarCaja.Controls.Add(this.button4);
            this.gb_CerrarCaja.Controls.Add(this.label3);
            this.gb_CerrarCaja.Location = new System.Drawing.Point(42, 189);
            this.gb_CerrarCaja.Name = "gb_CerrarCaja";
            this.gb_CerrarCaja.Size = new System.Drawing.Size(662, 260);
            this.gb_CerrarCaja.TabIndex = 20;
            this.gb_CerrarCaja.TabStop = false;
            this.gb_CerrarCaja.Text = "Cerrar Caja";
            this.gb_CerrarCaja.Visible = false;
            // 
            // tb_MontoCierre
            // 
            this.tb_MontoCierre.Location = new System.Drawing.Point(335, 24);
            this.tb_MontoCierre.Mask = "######.##";
            this.tb_MontoCierre.Name = "tb_MontoCierre";
            this.tb_MontoCierre.Size = new System.Drawing.Size(100, 20);
            this.tb_MontoCierre.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::WindowsFormsApplication2.Properties.Resources.candado_cerrar;
            this.button4.Location = new System.Drawing.Point(273, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 146);
            this.button4.TabIndex = 15;
            this.button4.Text = "Cerrar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Conteo de Cierre:";
            // 
            // gb_AbrirCaja
            // 
            this.gb_AbrirCaja.BackColor = System.Drawing.Color.Transparent;
            this.gb_AbrirCaja.Controls.Add(this.button3);
            this.gb_AbrirCaja.Location = new System.Drawing.Point(45, 189);
            this.gb_AbrirCaja.Name = "gb_AbrirCaja";
            this.gb_AbrirCaja.Size = new System.Drawing.Size(662, 260);
            this.gb_AbrirCaja.TabIndex = 20;
            this.gb_AbrirCaja.TabStop = false;
            this.gb_AbrirCaja.Text = "Abrir Caja";
            this.gb_AbrirCaja.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::WindowsFormsApplication2.Properties.Resources.candado_abrir;
            this.button3.Location = new System.Drawing.Point(257, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 146);
            this.button3.TabIndex = 14;
            this.button3.Text = "Abrir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::WindowsFormsApplication2.Properties.Resources.Reportes;
            this.button5.Location = new System.Drawing.Point(550, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 146);
            this.button5.TabIndex = 21;
            this.button5.Text = "Reporte Caja";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(799, 600);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_CerrarCaja);
            this.Controls.Add(this.gb_AbrirCaja);
            this.Controls.Add(this.gb_Trans);
            this.Name = "frmCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Caja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCaja_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_Trans.ResumeLayout(false);
            this.gb_Trans.PerformLayout();
            this.pnlInsertar.ResumeLayout(false);
            this.pnlInsertar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.gb_CerrarCaja.ResumeLayout(false);
            this.gb_CerrarCaja.PerformLayout();
            this.gb_AbrirCaja.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gb_Trans;
        private System.Windows.Forms.GroupBox gb_CerrarCaja;
        private System.Windows.Forms.MaskedTextBox tb_MontoCierre;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Desc_Trans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tb_MontoTrans;
        private System.Windows.Forms.Panel pnlInsertar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_Salida;
        private System.Windows.Forms.RadioButton rb_Ingreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_AbrirCaja;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}