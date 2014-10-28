namespace WindowsFormsApplication2
{
    partial class frmCambiarPassword
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
            this.lblPassActual = new System.Windows.Forms.Label();
            this.txtPassActual = new System.Windows.Forms.TextBox();
            this.lblPassNueva = new System.Windows.Forms.Label();
            this.lblVerificarPass = new System.Windows.Forms.Label();
            this.txtPassNueva = new System.Windows.Forms.TextBox();
            this.txtVerficarPass = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassActual
            // 
            this.lblPassActual.AutoSize = true;
            this.lblPassActual.Location = new System.Drawing.Point(43, 28);
            this.lblPassActual.Name = "lblPassActual";
            this.lblPassActual.Size = new System.Drawing.Size(97, 13);
            this.lblPassActual.TabIndex = 0;
            this.lblPassActual.Text = "Contraseña Actual:";
            // 
            // txtPassActual
            // 
            this.txtPassActual.Location = new System.Drawing.Point(146, 25);
            this.txtPassActual.Name = "txtPassActual";
            this.txtPassActual.PasswordChar = '*';
            this.txtPassActual.Size = new System.Drawing.Size(162, 20);
            this.txtPassActual.TabIndex = 1;
            // 
            // lblPassNueva
            // 
            this.lblPassNueva.AutoSize = true;
            this.lblPassNueva.Location = new System.Drawing.Point(41, 61);
            this.lblPassNueva.Name = "lblPassNueva";
            this.lblPassNueva.Size = new System.Drawing.Size(99, 13);
            this.lblPassNueva.TabIndex = 2;
            this.lblPassNueva.Text = "Contraseña Nueva:";
            // 
            // lblVerificarPass
            // 
            this.lblVerificarPass.AutoSize = true;
            this.lblVerificarPass.Location = new System.Drawing.Point(18, 94);
            this.lblVerificarPass.Name = "lblVerificarPass";
            this.lblVerificarPass.Size = new System.Drawing.Size(122, 13);
            this.lblVerificarPass.TabIndex = 3;
            this.lblVerificarPass.Text = "Verificación Contraseña:";
            // 
            // txtPassNueva
            // 
            this.txtPassNueva.Location = new System.Drawing.Point(146, 58);
            this.txtPassNueva.Name = "txtPassNueva";
            this.txtPassNueva.PasswordChar = '*';
            this.txtPassNueva.Size = new System.Drawing.Size(162, 20);
            this.txtPassNueva.TabIndex = 4;
            // 
            // txtVerficarPass
            // 
            this.txtVerficarPass.Location = new System.Drawing.Point(146, 91);
            this.txtVerficarPass.Name = "txtVerficarPass";
            this.txtVerficarPass.PasswordChar = '*';
            this.txtVerficarPass.Size = new System.Drawing.Size(162, 20);
            this.txtVerficarPass.TabIndex = 5;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(76, 131);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 6;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(185, 131);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 177);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txtVerficarPass);
            this.Controls.Add(this.txtPassNueva);
            this.Controls.Add(this.lblVerificarPass);
            this.Controls.Add(this.lblPassNueva);
            this.Controls.Add(this.txtPassActual);
            this.Controls.Add(this.lblPassActual);
            this.Name = "frmCambiarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassActual;
        private System.Windows.Forms.TextBox txtPassActual;
        private System.Windows.Forms.Label lblPassNueva;
        private System.Windows.Forms.Label lblVerificarPass;
        private System.Windows.Forms.TextBox txtPassNueva;
        private System.Windows.Forms.TextBox txtVerficarPass;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnCancelar;
    }
}