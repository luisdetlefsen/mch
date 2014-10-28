namespace WindowsFormsApplication2
{
    partial class frmSelectCobroAdicional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectCobroAdicional));
            this.lblTitlle = new System.Windows.Forms.Label();
            this.gridViewCobrosAdicionales = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.pbNuevoCobroAdiconal = new System.Windows.Forms.PictureBox();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCobrosAdicionales)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoCobroAdiconal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlle
            // 
            this.lblTitlle.AutoSize = true;
            this.lblTitlle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlle.Location = new System.Drawing.Point(12, 29);
            this.lblTitlle.Name = "lblTitlle";
            this.lblTitlle.Size = new System.Drawing.Size(155, 18);
            this.lblTitlle.TabIndex = 5;
            this.lblTitlle.Text = "Cobros Adicionales";
            // 
            // gridViewCobrosAdicionales
            // 
            this.gridViewCobrosAdicionales.AllowUserToAddRows = false;
            this.gridViewCobrosAdicionales.AllowUserToDeleteRows = false;
            this.gridViewCobrosAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCobrosAdicionales.Location = new System.Drawing.Point(3, 14);
            this.gridViewCobrosAdicionales.Name = "gridViewCobrosAdicionales";
            this.gridViewCobrosAdicionales.ReadOnly = true;
            this.gridViewCobrosAdicionales.Size = new System.Drawing.Size(474, 344);
            this.gridViewCobrosAdicionales.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridViewCobrosAdicionales);
            this.panel2.Location = new System.Drawing.Point(12, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 361);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblCancelar);
            this.panel1.Controls.Add(this.pbNuevoCobroAdiconal);
            this.panel1.Controls.Add(this.pbCancelar);
            this.panel1.Location = new System.Drawing.Point(522, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 358);
            this.panel1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Aplicar";
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(0, 185);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(80, 20);
            this.lblCancelar.TabIndex = 1;
            this.lblCancelar.Text = "Cancelar";
            // 
            // pbNuevoCobroAdiconal
            // 
            this.pbNuevoCobroAdiconal.BackColor = System.Drawing.Color.Transparent;
            this.pbNuevoCobroAdiconal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNuevoCobroAdiconal.Image = ((System.Drawing.Image)(resources.GetObject("pbNuevoCobroAdiconal.Image")));
            this.pbNuevoCobroAdiconal.Location = new System.Drawing.Point(15, 12);
            this.pbNuevoCobroAdiconal.Name = "pbNuevoCobroAdiconal";
            this.pbNuevoCobroAdiconal.Size = new System.Drawing.Size(49, 47);
            this.pbNuevoCobroAdiconal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNuevoCobroAdiconal.TabIndex = 8;
            this.pbNuevoCobroAdiconal.TabStop = false;
            this.pbNuevoCobroAdiconal.Click += new System.EventHandler(this.pbNuevoCobroAdiconal_Click);
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Transparent;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelar.Image")));
            this.pbCancelar.Location = new System.Drawing.Point(16, 137);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(48, 45);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancelar.TabIndex = 2;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Si Monto Fijo y Porcentaje se encuentran con 0, el monto es variable.";
            // 
            // frmSelectCobroAdicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitlle);
            this.Controls.Add(this.panel2);
            this.Name = "frmSelectCobroAdicional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Cobro Adicional";
            this.Load += new System.EventHandler(this.frmSelectCobroAdicional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCobrosAdicionales)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoCobroAdiconal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlle;
        private System.Windows.Forms.DataGridView gridViewCobrosAdicionales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox pbNuevoCobroAdiconal;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.Label label1;
    }
}