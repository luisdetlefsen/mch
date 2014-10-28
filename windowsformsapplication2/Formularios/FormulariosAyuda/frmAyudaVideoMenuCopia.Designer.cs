namespace WindowsFormsApplication2.Formularios.FormulariosAyuda
{
    partial class frmAyudaVideoMenuCopia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyudaVideoMenuCopia));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.btnCopia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.SuspendLayout();
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
            // btnCopia
            // 
            this.btnCopia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnCopia.Image = ((System.Drawing.Image)(resources.GetObject("btnCopia.Image")));
            this.btnCopia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopia.Location = new System.Drawing.Point(345, 220);
            this.btnCopia.Name = "btnCopia";
            this.btnCopia.Size = new System.Drawing.Size(154, 146);
            this.btnCopia.TabIndex = 37;
            this.btnCopia.Text = "Copia de Seguridad";
            this.btnCopia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopia.UseVisualStyleBackColor = true;
            this.btnCopia.Click += new System.EventHandler(this.btnCopia_Click);
            // 
            // frmAyudaVideoMenuCopia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo_auto_aprendizaje;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 600);
            this.Controls.Add(this.btnCopia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "frmAyudaVideoMenuCopia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Aprendizaje Copia de Seguridad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAyudaVideoMenuCopia_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox pbCancelar;
        internal System.Windows.Forms.Button btnCopia;
    }
}