namespace WindowsFormsApplication2.Formularios.FormulariosAyuda
{
    partial class frmAyudaVideoMenuRecibos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyudaVideoMenuRecibos));
            this.btnGenerarComp = new System.Windows.Forms.Button();
            this.btnComprobantes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarComp
            // 
            this.btnGenerarComp.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarComp.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarComp.Image")));
            this.btnGenerarComp.Location = new System.Drawing.Point(249, 182);
            this.btnGenerarComp.Name = "btnGenerarComp";
            this.btnGenerarComp.Size = new System.Drawing.Size(155, 146);
            this.btnGenerarComp.TabIndex = 40;
            this.btnGenerarComp.Text = "Generar Comprobantes";
            this.btnGenerarComp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerarComp.UseVisualStyleBackColor = false;
            this.btnGenerarComp.Click += new System.EventHandler(this.btnGenerarComp_Click);
            // 
            // btnComprobantes
            // 
            this.btnComprobantes.BackColor = System.Drawing.Color.Transparent;
            this.btnComprobantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobantes.Image = ((System.Drawing.Image)(resources.GetObject("btnComprobantes.Image")));
            this.btnComprobantes.Location = new System.Drawing.Point(410, 182);
            this.btnComprobantes.Name = "btnComprobantes";
            this.btnComprobantes.Size = new System.Drawing.Size(155, 146);
            this.btnComprobantes.TabIndex = 38;
            this.btnComprobantes.Text = "Presentación Comprobantes";
            this.btnComprobantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnComprobantes.UseVisualStyleBackColor = false;
            this.btnComprobantes.Click += new System.EventHandler(this.btnComprobantes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Barra_Lateral;
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Barra_Lateral;
            this.panel2.Controls.Add(this.lblCancelar);
            this.panel2.Controls.Add(this.pbCancelar);
            this.panel2.Location = new System.Drawing.Point(715, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 354);
            this.panel2.TabIndex = 35;
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(-2, 296);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(83, 20);
            this.lblCancelar.TabIndex = 7;
            this.lblCancelar.Text = "Regresar";
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Transparent;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = global::WindowsFormsApplication2.Properties.Resources._return;
            this.pbCancelar.Location = new System.Drawing.Point(12, 248);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(48, 45);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancelar.TabIndex = 8;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // frmAyudaVideoMenuRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo_auto_aprendizaje;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 600);
            this.Controls.Add(this.btnGenerarComp);
            this.Controls.Add(this.btnComprobantes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "frmAyudaVideoMenuRecibos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Aprendizaje Comprobantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAyudaVideoMenuRecibos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarComp;
        private System.Windows.Forms.Button btnComprobantes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox pbCancelar;
    }
}