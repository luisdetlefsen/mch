namespace WindowsFormsApplication2
{
    partial class frmAyuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListadoAyuda = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTextoAyuda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAyuda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoAyuda
            // 
            this.dgvListadoAyuda.AllowUserToAddRows = false;
            this.dgvListadoAyuda.AllowUserToDeleteRows = false;
            this.dgvListadoAyuda.AllowUserToOrderColumns = true;
            this.dgvListadoAyuda.AllowUserToResizeRows = false;
            this.dgvListadoAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoAyuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoAyuda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.descripcion});
            this.dgvListadoAyuda.Location = new System.Drawing.Point(0, 21);
            this.dgvListadoAyuda.Name = "dgvListadoAyuda";
            this.dgvListadoAyuda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoAyuda.Size = new System.Drawing.Size(492, 356);
            this.dgvListadoAyuda.TabIndex = 0;
            this.dgvListadoAyuda.DoubleClick += new System.EventHandler(this.dgvListadoAyuda_DoubleClick);
            this.dgvListadoAyuda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListadoAyuda_KeyDown);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "No.";
            this.id.MinimumWidth = 30;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 200;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 200;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 200;
            // 
            // txtTextoAyuda
            // 
            this.txtTextoAyuda.Location = new System.Drawing.Point(0, 0);
            this.txtTextoAyuda.Name = "txtTextoAyuda";
            this.txtTextoAyuda.Size = new System.Drawing.Size(492, 20);
            this.txtTextoAyuda.TabIndex = 1;
            this.txtTextoAyuda.TextChanged += new System.EventHandler(this.txtTextoAyuda_TextChanged);
            // 
            // frmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 377);
            this.Controls.Add(this.txtTextoAyuda);
            this.Controls.Add(this.dgvListadoAyuda);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAyuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAyuda";
            this.Load += new System.EventHandler(this.frmAyuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAyuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoAyuda;
        private System.Windows.Forms.TextBox txtTextoAyuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}