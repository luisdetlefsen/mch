namespace WindowsFormsApplication2.Formularios.FormulariosAyuda
{
    partial class frmElementosAprendizajeWeb
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
            this.webbGenerico = new System.Windows.Forms.WebBrowser();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // webbGenerico
            // 
            this.webbGenerico.Location = new System.Drawing.Point(11, 11);
            this.webbGenerico.Margin = new System.Windows.Forms.Padding(2);
            this.webbGenerico.MinimumSize = new System.Drawing.Size(15, 16);
            this.webbGenerico.Name = "webbGenerico";
            this.webbGenerico.ScrollBarsEnabled = false;
            this.webbGenerico.Size = new System.Drawing.Size(777, 530);
            this.webbGenerico.TabIndex = 0;
            this.webbGenerico.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Transparent;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = global::WindowsFormsApplication2.Properties.Resources._return;
            this.pbCancelar.Location = new System.Drawing.Point(744, 546);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(34, 32);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancelar.TabIndex = 8;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(725, 581);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(73, 16);
            this.lblCancelar.TabIndex = 7;
            this.lblCancelar.Text = "Regresar";
            // 
            // frmElementosAprendizajeWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo_auto_aprendizaje;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 600);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.pbCancelar);
            this.Controls.Add(this.webbGenerico);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmElementosAprendizajeWeb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Aprendizaje Seguridad Informática";
            this.Load += new System.EventHandler(this.frmElementosAprendizajeWeb_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmElementosAprendizajeWeb_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webbGenerico;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.Label lblCancelar;
    }
}