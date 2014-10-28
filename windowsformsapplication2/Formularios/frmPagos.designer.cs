namespace WindowsFormsApplication2
{
    partial class frmPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_TotalACancelar = new System.Windows.Forms.TextBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.cb_UtilizaSaldo = new System.Windows.Forms.CheckBox();
            this.tb_Pago = new System.Windows.Forms.TextBox();
            this.lb_pago = new System.Windows.Forms.Label();
            this.tb_Saldo = new System.Windows.Forms.TextBox();
            this.lb_Saldo = new System.Windows.Forms.Label();
            this.pbxContador = new System.Windows.Forms.PictureBox();
            this.txtDireccionContador = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.dgvPagosPendientes = new System.Windows.Forms.DataGridView();
            this.fecha_lectura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.txtIDContador = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCobros = new System.Windows.Forms.Label();
            this.pbCobros = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxContador)).BeginInit();
            this.pnlResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosPendientes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Barra_Inferior;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 520);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(48, 19);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(83, 20);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "Contador";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tb_TotalACancelar);
            this.panel2.Controls.Add(this.lb_total);
            this.panel2.Controls.Add(this.cb_UtilizaSaldo);
            this.panel2.Controls.Add(this.tb_Pago);
            this.panel2.Controls.Add(this.lb_pago);
            this.panel2.Controls.Add(this.tb_Saldo);
            this.panel2.Controls.Add(this.lb_Saldo);
            this.panel2.Controls.Add(this.pbxContador);
            this.panel2.Controls.Add(this.txtDireccionContador);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Controls.Add(this.pnlResultados);
            this.panel2.Controls.Add(this.txtDocumento);
            this.panel2.Controls.Add(this.lblFechaInicial);
            this.panel2.Controls.Add(this.txtIDContador);
            this.panel2.Controls.Add(this.lblContador);
            this.panel2.Location = new System.Drawing.Point(19, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 493);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tb_TotalACancelar
            // 
            this.tb_TotalACancelar.Enabled = false;
            this.tb_TotalACancelar.Location = new System.Drawing.Point(87, 370);
            this.tb_TotalACancelar.Name = "tb_TotalACancelar";
            this.tb_TotalACancelar.Size = new System.Drawing.Size(100, 20);
            this.tb_TotalACancelar.TabIndex = 20;
            this.tb_TotalACancelar.Visible = false;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(21, 370);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(48, 20);
            this.lb_total.TabIndex = 19;
            this.lb_total.Text = "Total:";
            this.lb_total.Visible = false;
            // 
            // cb_UtilizaSaldo
            // 
            this.cb_UtilizaSaldo.AutoSize = true;
            this.cb_UtilizaSaldo.Checked = true;
            this.cb_UtilizaSaldo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_UtilizaSaldo.Location = new System.Drawing.Point(194, 321);
            this.cb_UtilizaSaldo.Name = "cb_UtilizaSaldo";
            this.cb_UtilizaSaldo.Size = new System.Drawing.Size(103, 17);
            this.cb_UtilizaSaldo.TabIndex = 18;
            this.cb_UtilizaSaldo.Text = "Utilizar el crédito";
            this.cb_UtilizaSaldo.UseVisualStyleBackColor = true;
            this.cb_UtilizaSaldo.Visible = false;
            this.cb_UtilizaSaldo.CheckedChanged += new System.EventHandler(this.cb_UtilizaSaldo_CheckedChanged);
            // 
            // tb_Pago
            // 
            this.tb_Pago.Location = new System.Drawing.Point(87, 344);
            this.tb_Pago.Name = "tb_Pago";
            this.tb_Pago.Size = new System.Drawing.Size(100, 20);
            this.tb_Pago.TabIndex = 17;
            this.tb_Pago.Visible = false;
            this.tb_Pago.TextChanged += new System.EventHandler(this.tb_Pago_TextChanged);
            // 
            // lb_pago
            // 
            this.lb_pago.AutoSize = true;
            this.lb_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pago.Location = new System.Drawing.Point(21, 344);
            this.lb_pago.Name = "lb_pago";
            this.lb_pago.Size = new System.Drawing.Size(50, 20);
            this.lb_pago.TabIndex = 16;
            this.lb_pago.Text = "Pago:";
            this.lb_pago.Visible = false;
            this.lb_pago.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_Saldo
            // 
            this.tb_Saldo.Enabled = false;
            this.tb_Saldo.Location = new System.Drawing.Point(87, 321);
            this.tb_Saldo.Name = "tb_Saldo";
            this.tb_Saldo.Size = new System.Drawing.Size(100, 20);
            this.tb_Saldo.TabIndex = 15;
            this.tb_Saldo.Visible = false;
            // 
            // lb_Saldo
            // 
            this.lb_Saldo.AutoSize = true;
            this.lb_Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Saldo.Location = new System.Drawing.Point(21, 318);
            this.lb_Saldo.Name = "lb_Saldo";
            this.lb_Saldo.Size = new System.Drawing.Size(64, 20);
            this.lb_Saldo.TabIndex = 14;
            this.lb_Saldo.Text = "Crédito:";
            this.lb_Saldo.Visible = false;
            // 
            // pbxContador
            // 
            this.pbxContador.BackColor = System.Drawing.Color.Transparent;
            this.pbxContador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxContador.Image = ((System.Drawing.Image)(resources.GetObject("pbxContador.Image")));
            this.pbxContador.Location = new System.Drawing.Point(568, 16);
            this.pbxContador.Name = "pbxContador";
            this.pbxContador.Size = new System.Drawing.Size(26, 26);
            this.pbxContador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxContador.TabIndex = 13;
            this.pbxContador.TabStop = false;
            this.pbxContador.Click += new System.EventHandler(this.pbxContador_Click);
            // 
            // txtDireccionContador
            // 
            this.txtDireccionContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionContador.Location = new System.Drawing.Point(303, 16);
            this.txtDireccionContador.Name = "txtDireccionContador";
            this.txtDireccionContador.ReadOnly = true;
            this.txtDireccionContador.Size = new System.Drawing.Size(262, 26);
            this.txtDireccionContador.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(164, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(401, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(48, 51);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 20);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Nombre:";
            // 
            // pnlResultados
            // 
            this.pnlResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlResultados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlResultados.Controls.Add(this.dgvPagosPendientes);
            this.pnlResultados.Location = new System.Drawing.Point(21, 127);
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.Size = new System.Drawing.Size(612, 184);
            this.pnlResultados.TabIndex = 8;
            // 
            // dgvPagosPendientes
            // 
            this.dgvPagosPendientes.AllowUserToAddRows = false;
            this.dgvPagosPendientes.AllowUserToDeleteRows = false;
            this.dgvPagosPendientes.AllowUserToResizeColumns = false;
            this.dgvPagosPendientes.AllowUserToResizeRows = false;
            this.dgvPagosPendientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvPagosPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha_lectura,
            this.monto,
            this.lectura,
            this.codigo,
            this.CUI,
            this.nombre,
            this.id_contador});
            this.dgvPagosPendientes.Location = new System.Drawing.Point(152, 17);
            this.dgvPagosPendientes.MultiSelect = false;
            this.dgvPagosPendientes.Name = "dgvPagosPendientes";
            this.dgvPagosPendientes.ReadOnly = true;
            this.dgvPagosPendientes.RowHeadersVisible = false;
            this.dgvPagosPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagosPendientes.Size = new System.Drawing.Size(349, 147);
            this.dgvPagosPendientes.TabIndex = 0;
            this.dgvPagosPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagosPendientes_CellContentClick);
            // 
            // fecha_lectura
            // 
            this.fecha_lectura.DataPropertyName = "fecha_lectura";
            this.fecha_lectura.HeaderText = "Fecha Lectura";
            this.fecha_lectura.Name = "fecha_lectura";
            this.fecha_lectura.ReadOnly = true;
            this.fecha_lectura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lectura
            // 
            this.lectura.DataPropertyName = "lectura";
            this.lectura.HeaderText = "ID_LECTURA";
            this.lectura.Name = "lectura";
            this.lectura.ReadOnly = true;
            this.lectura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lectura.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codigo.Visible = false;
            // 
            // CUI
            // 
            this.CUI.DataPropertyName = "CUI";
            this.CUI.HeaderText = "CUI";
            this.CUI.Name = "CUI";
            this.CUI.ReadOnly = true;
            this.CUI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CUI.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombre.Visible = false;
            // 
            // id_contador
            // 
            this.id_contador.DataPropertyName = "id_contador";
            this.id_contador.HeaderText = "id_contador";
            this.id_contador.Name = "id_contador";
            this.id_contador.ReadOnly = true;
            this.id_contador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_contador.Visible = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(164, 85);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(401, 26);
            this.txtDocumento.TabIndex = 2;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(48, 88);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(101, 20);
            this.lblFechaInicial.TabIndex = 4;
            this.lblFechaInicial.Text = "CUI/Cédula";
            // 
            // txtIDContador
            // 
            this.txtIDContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDContador.Location = new System.Drawing.Point(164, 16);
            this.txtIDContador.Name = "txtIDContador";
            this.txtIDContador.Size = new System.Drawing.Size(133, 26);
            this.txtIDContador.TabIndex = 0;
            this.txtIDContador.TextChanged += new System.EventHandler(this.txtIDContador_TextChanged_1);
            this.txtIDContador.LostFocus += new System.EventHandler(this.txtIDContador_LostFocus);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblCobros);
            this.panel1.Controls.Add(this.pbCobros);
            this.panel1.Controls.Add(this.lblCancelar);
            this.panel1.Controls.Add(this.pbCancelar);
            this.panel1.Controls.Add(this.lblGuardar);
            this.panel1.Controls.Add(this.pbGuardar);
            this.panel1.Location = new System.Drawing.Point(703, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 406);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 356);
            this.label1.MaximumSize = new System.Drawing.Size(80, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "Eliminar Pago";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources._1385728779_Gnome_Edit_Delete_64;
            this.pictureBox2.Location = new System.Drawing.Point(15, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // lblCobros
            // 
            this.lblCobros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCobros.ForeColor = System.Drawing.Color.White;
            this.lblCobros.Location = new System.Drawing.Point(-1, 263);
            this.lblCobros.Name = "lblCobros";
            this.lblCobros.Size = new System.Drawing.Size(80, 40);
            this.lblCobros.TabIndex = 15;
            this.lblCobros.Text = "+Cobros +Abonos";
            // 
            // pbCobros
            // 
            this.pbCobros.BackColor = System.Drawing.Color.Transparent;
            this.pbCobros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCobros.Image = ((System.Drawing.Image)(resources.GetObject("pbCobros.Image")));
            this.pbCobros.Location = new System.Drawing.Point(15, 213);
            this.pbCobros.Name = "pbCobros";
            this.pbCobros.Size = new System.Drawing.Size(49, 47);
            this.pbCobros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCobros.TabIndex = 14;
            this.pbCobros.TabStop = false;
            this.pbCobros.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(-2, 175);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(80, 20);
            this.lblCancelar.TabIndex = 1;
            this.lblCancelar.Text = "Cancelar";
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Transparent;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelar.Image")));
            this.pbCancelar.Location = new System.Drawing.Point(12, 127);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(48, 45);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancelar.TabIndex = 2;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.ForeColor = System.Drawing.Color.White;
            this.lblGuardar.Location = new System.Drawing.Point(11, 79);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(56, 20);
            this.lblGuardar.TabIndex = 0;
            this.lblGuardar.Text = "Pagar";
            this.lblGuardar.Click += new System.EventHandler(this.lblGuardar_Click);
            // 
            // pbGuardar
            // 
            this.pbGuardar.BackColor = System.Drawing.Color.Transparent;
            this.pbGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pbGuardar.Image")));
            this.pbGuardar.Location = new System.Drawing.Point(12, 35);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(48, 45);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardar.TabIndex = 0;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(799, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Name = "frmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de pagos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mntPersona_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxContador)).EndInit();
            this.pnlResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosPendientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.TextBox txtIDContador;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pbxContador;
        private System.Windows.Forms.TextBox txtDireccionContador;
        private System.Windows.Forms.DataGridView dgvPagosPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_lectura;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectura;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_contador;
        private System.Windows.Forms.Label lblCobros;
        private System.Windows.Forms.PictureBox pbCobros;
        private System.Windows.Forms.TextBox tb_Saldo;
        private System.Windows.Forms.Label lb_Saldo;
        private System.Windows.Forms.TextBox tb_Pago;
        private System.Windows.Forms.Label lb_pago;
        private System.Windows.Forms.TextBox tb_TotalACancelar;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.CheckBox cb_UtilizaSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}