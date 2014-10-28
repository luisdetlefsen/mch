namespace WindowsFormsApplication2.Formularios.FormulariosAyuda
{
    partial class frmAyudaVideoMenuCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyudaVideoMenuCaja));
            this.btnAbrirCaja = new System.Windows.Forms.Button();
            this.btnSalidaDinero = new System.Windows.Forms.Button();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.btnIngresoDinero = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.btnReporteCaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaja.Image = global::WindowsFormsApplication2.Properties.Resources._1383740864_cashbox_open2;
            this.btnAbrirCaja.Location = new System.Drawing.Point(243, 72);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(155, 146);
            this.btnAbrirCaja.TabIndex = 40;
            this.btnAbrirCaja.Text = "Abrir Caja";
            this.btnAbrirCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirCaja.UseVisualStyleBackColor = false;
            this.btnAbrirCaja.Click += new System.EventHandler(this.btnAbrirCaja_Click);
            // 
            // btnSalidaDinero
            // 
            this.btnSalidaDinero.BackColor = System.Drawing.Color.Transparent;
            this.btnSalidaDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidaDinero.Image = ((System.Drawing.Image)(resources.GetObject("btnSalidaDinero.Image")));
            this.btnSalidaDinero.Location = new System.Drawing.Point(404, 224);
            this.btnSalidaDinero.Name = "btnSalidaDinero";
            this.btnSalidaDinero.Size = new System.Drawing.Size(155, 146);
            this.btnSalidaDinero.TabIndex = 39;
            this.btnSalidaDinero.Text = "Salida de Dinero";
            this.btnSalidaDinero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalidaDinero.UseVisualStyleBackColor = false;
            this.btnSalidaDinero.Click += new System.EventHandler(this.btnSalidaDinero_Click);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCaja.Image = global::WindowsFormsApplication2.Properties.Resources._1383740864_cashbox_close2;
            this.btnCerrarCaja.Location = new System.Drawing.Point(404, 72);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(155, 146);
            this.btnCerrarCaja.TabIndex = 38;
            this.btnCerrarCaja.Text = "Cerrar Caja";
            this.btnCerrarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrarCaja.UseVisualStyleBackColor = false;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // btnIngresoDinero
            // 
            this.btnIngresoDinero.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresoDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoDinero.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresoDinero.Image")));
            this.btnIngresoDinero.Location = new System.Drawing.Point(243, 224);
            this.btnIngresoDinero.Name = "btnIngresoDinero";
            this.btnIngresoDinero.Size = new System.Drawing.Size(155, 146);
            this.btnIngresoDinero.TabIndex = 37;
            this.btnIngresoDinero.Text = "Ingreso de Dinero";
            this.btnIngresoDinero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIngresoDinero.UseVisualStyleBackColor = false;
            this.btnIngresoDinero.Click += new System.EventHandler(this.btnIngresoDinero_Click);
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
            // btnReporteCaja
            // 
            this.btnReporteCaja.BackColor = System.Drawing.Color.Transparent;
            this.btnReporteCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteCaja.Image")));
            this.btnReporteCaja.Location = new System.Drawing.Point(323, 375);
            this.btnReporteCaja.Name = "btnReporteCaja";
            this.btnReporteCaja.Size = new System.Drawing.Size(155, 146);
            this.btnReporteCaja.TabIndex = 41;
            this.btnReporteCaja.Text = "Reporte de Caja";
            this.btnReporteCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporteCaja.UseVisualStyleBackColor = false;
            this.btnReporteCaja.Click += new System.EventHandler(this.btnReporteCaja_Click);
            // 
            // frmAyudaVideoMenuCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo_auto_aprendizaje;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 600);
            this.Controls.Add(this.btnReporteCaja);
            this.Controls.Add(this.btnAbrirCaja);
            this.Controls.Add(this.btnSalidaDinero);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.btnIngresoDinero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "frmAyudaVideoMenuCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Aprendizaje Caja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAyudaVideoMenuCaja_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirCaja;
        private System.Windows.Forms.Button btnSalidaDinero;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.Button btnIngresoDinero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.Button btnReporteCaja;
    }
}