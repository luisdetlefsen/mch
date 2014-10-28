namespace WindowsFormsApplication2
{
    partial class mntPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mntPersona));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbNuevaPersona = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.txtNombreBusqueda = new System.Windows.Forms.TextBox();
            this.lblNombreBusqueda = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCUI = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCUI = new System.Windows.Forms.TextBox();
            this.txtNombrePersona = new System.Windows.Forms.TextBox();
            this.lblNombrePersona = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.cmbrRegistro = new System.Windows.Forms.ComboBox();
            this.rHombre = new System.Windows.Forms.RadioButton();
            this.rMujer = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cmbComunidad = new System.Windows.Forms.ComboBox();
            this.lblComunidad = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comunidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevaPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pbNuevaPersona);
            this.panel3.Controls.Add(this.pbBuscar);
            this.panel3.Controls.Add(this.txtNombreBusqueda);
            this.panel3.Controls.Add(this.lblNombreBusqueda);
            this.panel3.Location = new System.Drawing.Point(33, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 83);
            this.panel3.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(434, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nuevo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(345, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Buscar";
            // 
            // pbNuevaPersona
            // 
            this.pbNuevaPersona.BackColor = System.Drawing.Color.Transparent;
            this.pbNuevaPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNuevaPersona.Image = ((System.Drawing.Image)(resources.GetObject("pbNuevaPersona.Image")));
            this.pbNuevaPersona.Location = new System.Drawing.Point(440, 5);
            this.pbNuevaPersona.Name = "pbNuevaPersona";
            this.pbNuevaPersona.Size = new System.Drawing.Size(49, 47);
            this.pbNuevaPersona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNuevaPersona.TabIndex = 6;
            this.pbNuevaPersona.TabStop = false;
            this.pbNuevaPersona.Click += new System.EventHandler(this.pbNuevaPersona_Click);
            // 
            // pbBuscar
            // 
            this.pbBuscar.BackColor = System.Drawing.Color.Transparent;
            this.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscar.Image")));
            this.pbBuscar.Location = new System.Drawing.Point(350, 5);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(48, 47);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 5;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // txtNombreBusqueda
            // 
            this.txtNombreBusqueda.Location = new System.Drawing.Point(77, 31);
            this.txtNombreBusqueda.Name = "txtNombreBusqueda";
            this.txtNombreBusqueda.Size = new System.Drawing.Size(247, 20);
            this.txtNombreBusqueda.TabIndex = 1;
            this.txtNombreBusqueda.TextChanged += new System.EventHandler(this.txtNombreBusqueda_TextChanged);
            // 
            // lblNombreBusqueda
            // 
            this.lblNombreBusqueda.AutoSize = true;
            this.lblNombreBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblNombreBusqueda.Location = new System.Drawing.Point(5, 29);
            this.lblNombreBusqueda.Name = "lblNombreBusqueda";
            this.lblNombreBusqueda.Size = new System.Drawing.Size(76, 20);
            this.lblNombreBusqueda.TabIndex = 4;
            this.lblNombreBusqueda.Text = "Nombre:";
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
            // lblCUI
            // 
            this.lblCUI.AutoSize = true;
            this.lblCUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUI.Location = new System.Drawing.Point(30, 91);
            this.lblCUI.Name = "lblCUI";
            this.lblCUI.Size = new System.Drawing.Size(40, 20);
            this.lblCUI.TabIndex = 2;
            this.lblCUI.Text = "CUI";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cmbComunidad);
            this.panel2.Controls.Add(this.lblComunidad);
            this.panel2.Controls.Add(this.dtFechaNac);
            this.panel2.Controls.Add(this.lblFechaNacimiento);
            this.panel2.Controls.Add(this.lblSexo);
            this.panel2.Controls.Add(this.rMujer);
            this.panel2.Controls.Add(this.rHombre);
            this.panel2.Controls.Add(this.cmbrRegistro);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Controls.Add(this.pnlResultados);
            this.panel2.Controls.Add(this.txtCedula);
            this.panel2.Controls.Add(this.lblCedula);
            this.panel2.Controls.Add(this.txtCUI);
            this.panel2.Controls.Add(this.lblCUI);
            this.panel2.Controls.Add(this.txtNombrePersona);
            this.panel2.Controls.Add(this.lblNombrePersona);
            this.panel2.Location = new System.Drawing.Point(33, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 419);
            this.panel2.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(112, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(401, 26);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(30, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Código:";
            // 
            // pnlResultados
            // 
            this.pnlResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlResultados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlResultados.Controls.Add(this.dgvPersonas);
            this.pnlResultados.Location = new System.Drawing.Point(27, 230);
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.Size = new System.Drawing.Size(612, 170);
            this.pnlResultados.TabIndex = 8;
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.AllowUserToResizeColumns = false;
            this.dgvPersonas.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Código,
            this.Nombre,
            this.CUI,
            this.Registro,
            this.Cedula,
            this.Sexo,
            this.FechadeNacimiento,
            this.Comunidad});
            this.dgvPersonas.Location = new System.Drawing.Point(23, 20);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.RowHeadersVisible = false;
            this.dgvPersonas.Size = new System.Drawing.Size(565, 147);
            this.dgvPersonas.TabIndex = 0;
            this.dgvPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_CellClick);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(201, 113);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(312, 26);
            this.txtCedula.TabIndex = 6;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(30, 117);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(65, 20);
            this.lblCedula.TabIndex = 6;
            this.lblCedula.Text = "Cédula";
            // 
            // txtCUI
            // 
            this.txtCUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUI.Location = new System.Drawing.Point(112, 84);
            this.txtCUI.Name = "txtCUI";
            this.txtCUI.Size = new System.Drawing.Size(401, 26);
            this.txtCUI.TabIndex = 4;
            this.txtCUI.TextChanged += new System.EventHandler(this.txtCUI_TextChanged);
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePersona.Location = new System.Drawing.Point(112, 55);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(401, 26);
            this.txtNombrePersona.TabIndex = 3;
            this.txtNombrePersona.TextChanged += new System.EventHandler(this.txtNombrePersona_TextChanged);
            // 
            // lblNombrePersona
            // 
            this.lblNombrePersona.AutoSize = true;
            this.lblNombrePersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePersona.Location = new System.Drawing.Point(30, 59);
            this.lblNombrePersona.Name = "lblNombrePersona";
            this.lblNombrePersona.Size = new System.Drawing.Size(76, 20);
            this.lblNombrePersona.TabIndex = 0;
            this.lblNombrePersona.Text = "Nombre:";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.ForeColor = System.Drawing.Color.White;
            this.lblEliminar.Location = new System.Drawing.Point(0, 283);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(73, 20);
            this.lblEliminar.TabIndex = 5;
            this.lblEliminar.Text = "Eliminar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblEliminar);
            this.panel1.Controls.Add(this.pbEliminar);
            this.panel1.Controls.Add(this.lblCancelar);
            this.panel1.Controls.Add(this.pbCancelar);
            this.panel1.Controls.Add(this.lblGuardar);
            this.panel1.Controls.Add(this.pbGuardar);
            this.panel1.Location = new System.Drawing.Point(703, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 350);
            this.panel1.TabIndex = 5;
            // 
            // pbEliminar
            // 
            this.pbEliminar.BackColor = System.Drawing.Color.Transparent;
            this.pbEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminar.Image")));
            this.pbEliminar.Location = new System.Drawing.Point(12, 235);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(48, 45);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEliminar.TabIndex = 4;
            this.pbEliminar.TabStop = false;
            this.pbEliminar.Click += new System.EventHandler(this.pbEliminar_Click);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(-2, 175);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(80, 20);
            this.lblCancelar.TabIndex = 3;
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
            this.lblGuardar.Location = new System.Drawing.Point(0, 79);
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
            this.pbGuardar.Location = new System.Drawing.Point(12, 35);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(48, 45);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardar.TabIndex = 0;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // cmbrRegistro
            // 
            this.cmbrRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbrRegistro.FormattingEnabled = true;
            this.cmbrRegistro.Items.AddRange(new object[] {
            "A1",
            "B2",
            "C3",
            "D4",
            "E5",
            "F6",
            "G7",
            "H8",
            "I9",
            "J10",
            "K11",
            "L12",
            "M13",
            "N14",
            "Ñ15",
            "O16",
            "P17",
            "Q18",
            "R19",
            "S20",
            "T21",
            "U22"});
            this.cmbrRegistro.Location = new System.Drawing.Point(112, 115);
            this.cmbrRegistro.Name = "cmbrRegistro";
            this.cmbrRegistro.Size = new System.Drawing.Size(83, 24);
            this.cmbrRegistro.TabIndex = 5;
            // 
            // rHombre
            // 
            this.rHombre.AutoSize = true;
            this.rHombre.Checked = true;
            this.rHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rHombre.Location = new System.Drawing.Point(115, 143);
            this.rHombre.Name = "rHombre";
            this.rHombre.Size = new System.Drawing.Size(76, 21);
            this.rHombre.TabIndex = 10;
            this.rHombre.TabStop = true;
            this.rHombre.Text = "Hombre";
            this.rHombre.UseVisualStyleBackColor = true;
            // 
            // rMujer
            // 
            this.rMujer.AutoSize = true;
            this.rMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMujer.Location = new System.Drawing.Point(206, 143);
            this.rMujer.Name = "rMujer";
            this.rMujer.Size = new System.Drawing.Size(61, 21);
            this.rMujer.TabIndex = 11;
            this.rMujer.Text = "Mujer";
            this.rMujer.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(30, 144);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(49, 20);
            this.lblSexo.TabIndex = 12;
            this.lblSexo.Text = "Sexo";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(29, 167);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(178, 20);
            this.lblFechaNacimiento.TabIndex = 13;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNac.Location = new System.Drawing.Point(215, 169);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(298, 23);
            this.dtFechaNac.TabIndex = 14;
            // 
            // cmbComunidad
            // 
            this.cmbComunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComunidad.Location = new System.Drawing.Point(131, 196);
            this.cmbComunidad.Name = "cmbComunidad";
            this.cmbComunidad.Size = new System.Drawing.Size(382, 21);
            this.cmbComunidad.TabIndex = 18;
            // 
            // lblComunidad
            // 
            this.lblComunidad.AutoSize = true;
            this.lblComunidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComunidad.Location = new System.Drawing.Point(29, 196);
            this.lblComunidad.Name = "lblComunidad";
            this.lblComunidad.Size = new System.Drawing.Size(99, 20);
            this.lblComunidad.TabIndex = 17;
            this.lblComunidad.Text = "Comunidad";
            // 
            // No
            // 
            this.No.DataPropertyName = "ID_Persona";
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No.Width = 45;
            // 
            // Código
            // 
            this.Código.DataPropertyName = "Codigo";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 270;
            // 
            // CUI
            // 
            this.CUI.DataPropertyName = "CUI";
            this.CUI.HeaderText = "CUI";
            this.CUI.Name = "CUI";
            this.CUI.ReadOnly = true;
            this.CUI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CUI.Width = 80;
            // 
            // Registro
            // 
            this.Registro.DataPropertyName = "No_Registro";
            this.Registro.HeaderText = "Registro";
            this.Registro.Name = "Registro";
            this.Registro.ReadOnly = true;
            this.Registro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Registro.Width = 55;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "No_Cedula";
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cedula.Width = 70;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // FechadeNacimiento
            // 
            this.FechadeNacimiento.DataPropertyName = "FechaNac";
            this.FechadeNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechadeNacimiento.Name = "FechadeNacimiento";
            // 
            // Comunidad
            // 
            this.Comunidad.DataPropertyName = "Comunidad";
            this.Comunidad.HeaderText = "Comunidad";
            this.Comunidad.Name = "Comunidad";
            // 
            // mntPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(799, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Name = "mntPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Personas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mntPersona_FormClosed);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevaPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbNuevaPersona;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.TextBox txtNombreBusqueda;
        private System.Windows.Forms.Label lblNombreBusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCUI;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNombrePersona;
        private System.Windows.Forms.Label lblNombrePersona;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCUI;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cmbrRegistro;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rMujer;
        private System.Windows.Forms.RadioButton rHombre;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbComunidad;
        private System.Windows.Forms.Label lblComunidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comunidad;
    }
}