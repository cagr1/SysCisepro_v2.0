namespace SysCisepro3.TalentoHumano
{
    partial class FrmReporteVacaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRecargar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDetalle = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPeriodo = new System.Windows.Forms.CheckBox();
            this.cbxPeriodo = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRecargar,
            this.btnGuardar,
            this.btnNuevo,
            this.btnCancelar,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1074, 25);
            this.toolStrip1.TabIndex = 216;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Image = global::SysCisepro3.Properties.Resources.BuscarRegistro;
            this.btnRecargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(114, 22);
            this.btnRecargar.Text = "RECARGAR VAC.";
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::SysCisepro3.Properties.Resources.report;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 22);
            this.btnGuardar.Text = "IMP. SOLICITUD";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::SysCisepro3.Properties.Resources.EliminarRegistro;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 22);
            this.btnNuevo.Text = "ANULAR SOL.";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SysCisepro3.Properties.Resources.excel_icon;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 22);
            this.btnCancelar.Text = "EXPORTAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::SysCisepro3.Properties.Resources.calendapermi;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(109, 22);
            this.toolStripButton1.Text = "CAM. PERÍODO";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "dddd, dd-MMM-yyyy";
            this.dtpFechaHasta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(432, 19);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(93, 22);
            this.dtpFechaHasta.TabIndex = 220;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "dddd, dd-MMM-yyyy";
            this.dtpFechaDesde.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(309, 19);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(93, 22);
            this.dtpFechaDesde.TabIndex = 219;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(60, 43);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(244, 21);
            this.txtFiltro.TabIndex = 218;
            this.txtFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyUp);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(262, 22);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(47, 13);
            this.Label10.TabIndex = 221;
            this.Label10.Text = "DESDE:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label7.Location = new System.Drawing.Point(6, 47);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(48, 13);
            this.Label7.TabIndex = 217;
            this.Label7.Text = "FILTRO:";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(416, 22);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(17, 13);
            this.Label11.TabIndex = 222;
            this.Label11.Text = "A:";
            // 
            // Label1
            // 
            this.Label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label1.Location = new System.Drawing.Point(0, 516);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(1074, 15);
            this.Label1.TabIndex = 223;
            this.Label1.Text = "O REGISTRO(S)";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column10,
            this.Column11,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
            this.dataGridView1.Location = new System.Drawing.Point(2, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 430);
            this.dataGridView1.TabIndex = 224;
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
            // Column10
            // 
            this.Column10.HeaderText = "NÓMINA";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 200;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "CARGO";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 150;
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
            this.Column8.Width = 300;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "IDP";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            this.Column12.Width = 50;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "FECREC";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            this.Column13.Width = 50;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "CED";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "PUESTO";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "FECENT";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Visible = false;
            // 
            // Column17
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column17.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column17.HeaderText = "COBRO";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 80;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "GRUPO";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 120;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 17);
            this.radioButton1.TabIndex = 225;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "FECHA REGISTRO";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(142, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 17);
            this.radioButton2.TabIndex = 226;
            this.radioButton2.Text = "FECHA SALIDA";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.Label11);
            this.groupBox1.Controls.Add(this.chkDetalle);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.Label10);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Location = new System.Drawing.Point(310, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 50);
            this.groupBox1.TabIndex = 227;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEALLE";
            // 
            // chkDetalle
            // 
            this.chkDetalle.AutoSize = true;
            this.chkDetalle.Checked = true;
            this.chkDetalle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDetalle.Location = new System.Drawing.Point(61, 0);
            this.chkDetalle.Name = "chkDetalle";
            this.chkDetalle.Size = new System.Drawing.Size(15, 14);
            this.chkDetalle.TabIndex = 227;
            this.chkDetalle.UseVisualStyleBackColor = true;
            this.chkDetalle.CheckedChanged += new System.EventHandler(this.chkDetalle_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkPeriodo);
            this.groupBox2.Controls.Add(this.cbxPeriodo);
            this.groupBox2.Location = new System.Drawing.Point(850, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 50);
            this.groupBox2.TabIndex = 228;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PERÍODO";
            // 
            // chkPeriodo
            // 
            this.chkPeriodo.AutoSize = true;
            this.chkPeriodo.Location = new System.Drawing.Point(68, 1);
            this.chkPeriodo.Name = "chkPeriodo";
            this.chkPeriodo.Size = new System.Drawing.Size(15, 14);
            this.chkPeriodo.TabIndex = 229;
            this.chkPeriodo.UseVisualStyleBackColor = true;
            this.chkPeriodo.CheckedChanged += new System.EventHandler(this.chkPeriodo_CheckedChanged);
            // 
            // cbxPeriodo
            // 
            this.cbxPeriodo.BackColor = System.Drawing.Color.White;
            this.cbxPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeriodo.Enabled = false;
            this.cbxPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPeriodo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeriodo.FormattingEnabled = true;
            this.cbxPeriodo.Location = new System.Drawing.Point(6, 19);
            this.cbxPeriodo.Name = "cbxPeriodo";
            this.cbxPeriodo.Size = new System.Drawing.Size(210, 21);
            this.cbxPeriodo.TabIndex = 228;
            // 
            // FrmReporteVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1074, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReporteVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE VACACIONES";
            this.Load += new System.EventHandler(this.FrmReporteVacaciones_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        internal System.Windows.Forms.DateTimePicker dtpFechaHasta;
        internal System.Windows.Forms.DateTimePicker dtpFechaDesde;
        internal System.Windows.Forms.TextBox txtFiltro;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnRecargar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.ComboBox cbxPeriodo;
        private System.Windows.Forms.CheckBox chkDetalle;
        private System.Windows.Forms.CheckBox chkPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}