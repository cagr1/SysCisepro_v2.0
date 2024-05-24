namespace SysCisepro3.TalentoHumano
{
    partial class FrmVacaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.btnPersonalEntra = new System.Windows.Forms.Button();
            this.txtIdPersonal = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtPersonal = new System.Windows.Forms.TextBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValorCobro = new System.Windows.Forms.TextBox();
            this.chkCobro = new System.Windows.Forms.CheckBox();
            this.txtDisponibles = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxPeriodo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPendientes = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.bntPuesto = new System.Windows.Forms.Button();
            this.txtSitio = new System.Windows.Forms.TextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.Label23 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(779, 25);
            this.toolStrip1.TabIndex = 215;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::SysCisepro3.Properties.Resources.NuevoRegistro;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 22);
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::SysCisepro3.Properties.Resources.GuardarRegistro;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 22);
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::SysCisepro3.Properties.Resources.cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 22);
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.White;
            this.GroupBox1.Controls.Add(this.dtpFechaEntrada);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.txtArea);
            this.GroupBox1.Controls.Add(this.Label27);
            this.GroupBox1.Controls.Add(this.txtCargo);
            this.GroupBox1.Controls.Add(this.Label25);
            this.GroupBox1.Controls.Add(this.btnPersonalEntra);
            this.GroupBox1.Controls.Add(this.txtIdPersonal);
            this.GroupBox1.Controls.Add(this.Label22);
            this.GroupBox1.Controls.Add(this.txtPersonal);
            this.GroupBox1.Controls.Add(this.Label26);
            this.GroupBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(0, 28);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(778, 64);
            this.GroupBox1.TabIndex = 216;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "DATOS DE PERSONAL";
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.CustomFormat = "dddd, dd/MM/yyyy";
            this.dtpFechaEntrada.Enabled = false;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(530, 39);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(242, 20);
            this.dtpFechaEntrada.TabIndex = 206;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 207;
            this.label6.Text = "INGRESO:";
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.White;
            this.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(285, 39);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(156, 20);
            this.txtArea.TabIndex = 197;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(242, 42);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(37, 13);
            this.Label27.TabIndex = 196;
            this.Label27.Text = "ÁREA:";
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.White;
            this.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCargo.Enabled = false;
            this.txtCargo.Location = new System.Drawing.Point(59, 39);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(163, 20);
            this.txtCargo.TabIndex = 195;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(13, 42);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(43, 13);
            this.Label25.TabIndex = 194;
            this.Label25.Text = "CARGO:";
            // 
            // btnPersonalEntra
            // 
            this.btnPersonalEntra.BackColor = System.Drawing.Color.White;
            this.btnPersonalEntra.Enabled = false;
            this.btnPersonalEntra.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalEntra.Image = global::SysCisepro3.Properties.Resources.people_add;
            this.btnPersonalEntra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalEntra.Location = new System.Drawing.Point(748, 12);
            this.btnPersonalEntra.Name = "btnPersonalEntra";
            this.btnPersonalEntra.Size = new System.Drawing.Size(26, 26);
            this.btnPersonalEntra.TabIndex = 193;
            this.btnPersonalEntra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonalEntra.UseVisualStyleBackColor = false;
            this.btnPersonalEntra.Click += new System.EventHandler(this.btnPersonalEntra_Click);
            // 
            // txtIdPersonal
            // 
            this.txtIdPersonal.BackColor = System.Drawing.Color.White;
            this.txtIdPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdPersonal.Enabled = false;
            this.txtIdPersonal.Location = new System.Drawing.Point(44, 13);
            this.txtIdPersonal.Name = "txtIdPersonal";
            this.txtIdPersonal.Size = new System.Drawing.Size(47, 20);
            this.txtIdPersonal.TabIndex = 28;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(18, 18);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(25, 13);
            this.Label22.TabIndex = 8;
            this.Label22.Text = "ID:";
            // 
            // txtPersonal
            // 
            this.txtPersonal.BackColor = System.Drawing.Color.White;
            this.txtPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPersonal.Enabled = false;
            this.txtPersonal.Location = new System.Drawing.Point(219, 16);
            this.txtPersonal.Name = "txtPersonal";
            this.txtPersonal.Size = new System.Drawing.Size(529, 20);
            this.txtPersonal.TabIndex = 0;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(167, 17);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(55, 13);
            this.Label26.TabIndex = 3;
            this.Label26.Text = "NOMBRES:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.White;
            this.GroupBox2.Controls.Add(this.txtValorCobro);
            this.GroupBox2.Controls.Add(this.chkCobro);
            this.GroupBox2.Controls.Add(this.txtDisponibles);
            this.GroupBox2.Controls.Add(this.label9);
            this.GroupBox2.Controls.Add(this.cbxPeriodo);
            this.GroupBox2.Controls.Add(this.label8);
            this.GroupBox2.Controls.Add(this.btnAgregar);
            this.GroupBox2.Controls.Add(this.btnRemover);
            this.GroupBox2.Controls.Add(this.dataGridView2);
            this.GroupBox2.Controls.Add(this.txtPendientes);
            this.GroupBox2.Controls.Add(this.txtDias);
            this.GroupBox2.Controls.Add(this.label1);
            this.GroupBox2.Controls.Add(this.dataGridView1);
            this.GroupBox2.Controls.Add(this.txtNumDoc);
            this.GroupBox2.Controls.Add(this.txtObservacion);
            this.GroupBox2.Controls.Add(this.Label18);
            this.GroupBox2.Controls.Add(this.label2);
            this.GroupBox2.Controls.Add(this.dtpHasta);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.bntPuesto);
            this.GroupBox2.Controls.Add(this.txtSitio);
            this.GroupBox2.Controls.Add(this.dtpDesde);
            this.GroupBox2.Controls.Add(this.Label23);
            this.GroupBox2.Controls.Add(this.dtpFecha);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label31);
            this.GroupBox2.Controls.Add(this.label5);
            this.GroupBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(0, 92);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(778, 528);
            this.GroupBox2.TabIndex = 217;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "DATOS DE LA SOLICITUD DE VACACIONES";
            // 
            // txtValorCobro
            // 
            this.txtValorCobro.BackColor = System.Drawing.Color.White;
            this.txtValorCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorCobro.Enabled = false;
            this.txtValorCobro.Location = new System.Drawing.Point(669, 324);
            this.txtValorCobro.Name = "txtValorCobro";
            this.txtValorCobro.Size = new System.Drawing.Size(72, 20);
            this.txtValorCobro.TabIndex = 232;
            this.txtValorCobro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCobro_KeyPress);
            this.txtValorCobro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValorCobro_KeyUp);
            // 
            // chkCobro
            // 
            this.chkCobro.AutoSize = true;
            this.chkCobro.Location = new System.Drawing.Point(669, 305);
            this.chkCobro.Name = "chkCobro";
            this.chkCobro.Size = new System.Drawing.Size(74, 17);
            this.chkCobro.TabIndex = 231;
            this.chkCobro.Text = "COBRADAS";
            this.chkCobro.UseVisualStyleBackColor = true;
            this.chkCobro.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtDisponibles
            // 
            this.txtDisponibles.BackColor = System.Drawing.Color.White;
            this.txtDisponibles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDisponibles.Enabled = false;
            this.txtDisponibles.Location = new System.Drawing.Point(181, 324);
            this.txtDisponibles.Name = "txtDisponibles";
            this.txtDisponibles.Size = new System.Drawing.Size(58, 20);
            this.txtDisponibles.TabIndex = 229;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 228;
            this.label9.Text = "DÍAS DISPONIBLES:";
            // 
            // cbxPeriodo
            // 
            this.cbxPeriodo.BackColor = System.Drawing.Color.White;
            this.cbxPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeriodo.Enabled = false;
            this.cbxPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPeriodo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeriodo.FormattingEnabled = true;
            this.cbxPeriodo.Location = new System.Drawing.Point(73, 298);
            this.cbxPeriodo.Name = "cbxPeriodo";
            this.cbxPeriodo.Size = new System.Drawing.Size(166, 21);
            this.cbxPeriodo.TabIndex = 227;
            this.cbxPeriodo.SelectedValueChanged += new System.EventHandler(this.cbxPeriodo_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 226;
            this.label8.Text = "PERÍODO:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::SysCisepro3.Properties.Resources.add;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(748, 298);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(26, 26);
            this.btnAgregar.TabIndex = 225;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.White;
            this.btnRemover.Enabled = false;
            this.btnRemover.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Image = global::SysCisepro3.Properties.Resources.remove;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(747, 324);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(26, 26);
            this.btnRemover.TabIndex = 224;
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column18});
            this.dataGridView2.Location = new System.Drawing.Point(7, 377);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(766, 145);
            this.dataGridView2.TabIndex = 223;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "N°";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 40;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "F. SALIDA";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 90;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "F. ENTRADA";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 90;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "DÍAS";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 50;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "PENDIENTES";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 70;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "PERÍODO";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 140;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "OBSERVACIÓN";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 600;
            // 
            // Column18
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column18.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column18.HeaderText = "COBRO";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 80;
            // 
            // txtPendientes
            // 
            this.txtPendientes.BackColor = System.Drawing.Color.White;
            this.txtPendientes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPendientes.Enabled = false;
            this.txtPendientes.Location = new System.Drawing.Point(621, 324);
            this.txtPendientes.Name = "txtPendientes";
            this.txtPendientes.Size = new System.Drawing.Size(35, 20);
            this.txtPendientes.TabIndex = 222;
            // 
            // txtDias
            // 
            this.txtDias.BackColor = System.Drawing.Color.White;
            this.txtDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDias.Enabled = false;
            this.txtDias.Location = new System.Drawing.Point(621, 298);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(35, 20);
            this.txtDias.TabIndex = 220;
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDoc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 219;
            this.label1.Text = "DÍAS:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column17});
            this.dataGridView1.Location = new System.Drawing.Point(6, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(766, 244);
            this.dataGridView1.TabIndex = 218;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            this.Column9.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N°";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "N° DOC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FEC. SALIDA";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "FEC. ENTRADA";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DÍAS";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "PEND.";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "PERÍODO";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 180;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "OBSERVACIÓN";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 600;
            // 
            // Column17
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column17.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column17.HeaderText = "COBRO";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 80;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.BackColor = System.Drawing.Color.White;
            this.txtNumDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumDoc.Enabled = false;
            this.txtNumDoc.Location = new System.Drawing.Point(208, 21);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(52, 20);
            this.txtNumDoc.TabIndex = 217;
            this.txtNumDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDoc_KeyPress);
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Enabled = false;
            this.txtObservacion.Location = new System.Drawing.Point(57, 353);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(715, 20);
            this.txtObservacion.TabIndex = 201;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(5, 356);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(49, 13);
            this.Label18.TabIndex = 200;
            this.Label18.Text = "OBSERV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 216;
            this.label2.Text = "N° DOC:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dddd, dd/MM/yyyy";
            this.dtpHasta.Enabled = false;
            this.dtpHasta.Location = new System.Drawing.Point(308, 324);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(264, 20);
            this.dtpHasta.TabIndex = 209;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(256, 327);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(55, 13);
            this.Label4.TabIndex = 210;
            this.Label4.Text = "INGRESA:";
            // 
            // bntPuesto
            // 
            this.bntPuesto.BackColor = System.Drawing.Color.White;
            this.bntPuesto.Enabled = false;
            this.bntPuesto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPuesto.Image = global::SysCisepro3.Properties.Resources.network_checklist_icon;
            this.bntPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntPuesto.Location = new System.Drawing.Point(748, 17);
            this.bntPuesto.Name = "bntPuesto";
            this.bntPuesto.Size = new System.Drawing.Size(26, 26);
            this.bntPuesto.TabIndex = 213;
            this.bntPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntPuesto.UseVisualStyleBackColor = false;
            this.bntPuesto.Click += new System.EventHandler(this.bntPuesto_Click);
            // 
            // txtSitio
            // 
            this.txtSitio.BackColor = System.Drawing.Color.White;
            this.txtSitio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSitio.Enabled = false;
            this.txtSitio.Location = new System.Drawing.Point(322, 21);
            this.txtSitio.Name = "txtSitio";
            this.txtSitio.Size = new System.Drawing.Size(426, 20);
            this.txtSitio.TabIndex = 211;
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dddd, dd/MM/yyyy";
            this.dtpDesde.Enabled = false;
            this.dtpDesde.Location = new System.Drawing.Point(308, 298);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(264, 20);
            this.dtpDesde.TabIndex = 207;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(276, 24);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(49, 13);
            this.Label23.TabIndex = 212;
            this.Label23.Text = "PUESTO:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "MMMM yyyy";
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(45, 21);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(90, 20);
            this.dtpFecha.TabIndex = 204;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(256, 301);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(37, 13);
            this.Label3.TabIndex = 208;
            this.Label3.Text = "SALE:";
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(4, 24);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(43, 13);
            this.Label31.TabIndex = 205;
            this.Label31.Text = "FECHA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 230;
            this.label5.Text = "PEND:";
            // 
            // FrmVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 621);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR VACACIONES PERSONAL";
            this.Load += new System.EventHandler(this.FrmVacaciones_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtArea;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.TextBox txtCargo;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Button btnPersonalEntra;
        internal System.Windows.Forms.TextBox txtIdPersonal;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox txtPersonal;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button bntPuesto;
        internal System.Windows.Forms.TextBox txtSitio;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.DateTimePicker dtpHasta;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DateTimePicker dtpDesde;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.TextBox txtObservacion;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.TextBox txtNumDoc;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.TextBox txtPendientes;
        internal System.Windows.Forms.TextBox txtDias;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        internal System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dataGridView2;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.Button btnRemover;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox cbxPeriodo;
        internal System.Windows.Forms.TextBox txtDisponibles;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCobro;
        internal System.Windows.Forms.TextBox txtValorCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
    }
}