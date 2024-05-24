namespace SysCisepro3.TalentoHumano
{
    partial class FrmGenerarCredencial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerarCredencial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.cREDENCIALCISSEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ticComecsa = new System.Windows.Forms.ToolStripButton();
            this.ticFarmacia = new System.Windows.Forms.ToolStripButton();
            this.gbParámetros = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtParametroBusqueda = new System.Windows.Forms.TextBox();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.dtpFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvBusquedaPersonal = new System.Windows.Forms.DataGridView();
            this.crvCredenciales = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            //this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.TicComisariato = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.gbParámetros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaPersonal)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripButton1,
            this.ticComecsa,
            this.ticFarmacia,
            this.TicComisariato});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1097, 25);
            this.toolStrip1.TabIndex = 216;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripSeparator3,
            this.toolStripMenuItem4,
            this.cREDENCIALCISSEPToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::SysCisepro3.Properties.Resources.debit_icon;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem1.Text = "GENERAR CREDENCIALES";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItem2.Text = "PARA VISITANTE";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.pARAVISITANTEToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItem3.Text = "PARA PERSONAL";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.pARAPERSONALToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(190, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::SysCisepro3.Properties.Resources.debit_icon;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItem4.Text = "PARA LICITACIONES";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.pARALICITACIONESToolStripMenuItem_Click);
            // 
            // cREDENCIALCISSEPToolStripMenuItem
            // 
            this.cREDENCIALCISSEPToolStripMenuItem.Image = global::SysCisepro3.Properties.Resources.debit_icon;
            this.cREDENCIALCISSEPToolStripMenuItem.Name = "cREDENCIALCISSEPToolStripMenuItem";
            this.cREDENCIALCISSEPToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cREDENCIALCISSEPToolStripMenuItem.Text = "CREDENCIAL CIS / SEP";
            this.cREDENCIALCISSEPToolStripMenuItem.Click += new System.EventHandler(this.cREDENCIALCISSEPToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::SysCisepro3.Properties.Resources.debit_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(140, 22);
            this.toolStripButton1.Text = "SOLICITUD ANTICIPO";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ticComecsa
            // 
            this.ticComecsa.Image = global::SysCisepro3.Properties.Resources.debit_icon;
            this.ticComecsa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ticComecsa.Name = "ticComecsa";
            this.ticComecsa.Size = new System.Drawing.Size(122, 22);
            this.ticComecsa.Text = "TICKET COMECSA";
            this.ticComecsa.Click += new System.EventHandler(this.ticComecsa_Click);
            // 
            // ticFarmacia
            // 
            this.ticFarmacia.Image = global::SysCisepro3.Properties.Resources.debit_icon;
            this.ticFarmacia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ticFarmacia.Name = "ticFarmacia";
            this.ticFarmacia.Size = new System.Drawing.Size(124, 22);
            this.ticFarmacia.Text = "TICKET FARMACIA";
            this.ticFarmacia.Click += new System.EventHandler(this.ticFarmacia_Click);
            // 
            // gbParámetros
            // 
            this.gbParámetros.Controls.Add(this.Label4);
            this.gbParámetros.Controls.Add(this.txtParametroBusqueda);
            this.gbParámetros.Controls.Add(this.txtContrato);
            this.gbParámetros.Controls.Add(this.Label5);
            this.gbParámetros.Controls.Add(this.dtpFechaCaducidad);
            this.gbParámetros.Controls.Add(this.PictureBox1);
            this.gbParámetros.Controls.Add(this.dtpFechaEmision);
            this.gbParámetros.Controls.Add(this.Label3);
            this.gbParámetros.Controls.Add(this.Label1);
            this.gbParámetros.Controls.Add(this.Label2);
            this.gbParámetros.Controls.Add(this.txtCodigo);
            this.gbParámetros.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParámetros.Location = new System.Drawing.Point(1, 27);
            this.gbParámetros.Name = "gbParámetros";
            this.gbParámetros.Size = new System.Drawing.Size(488, 159);
            this.gbParámetros.TabIndex = 217;
            this.gbParámetros.TabStop = false;
            this.gbParámetros.Text = "PARÁMETROS DE BUSQUEDA";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 23);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(46, 13);
            this.Label4.TabIndex = 47;
            this.Label4.Text = "BUSCAR:";
            // 
            // txtParametroBusqueda
            // 
            this.txtParametroBusqueda.BackColor = System.Drawing.Color.White;
            this.txtParametroBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametroBusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtParametroBusqueda.Location = new System.Drawing.Point(58, 20);
            this.txtParametroBusqueda.Name = "txtParametroBusqueda";
            this.txtParametroBusqueda.Size = new System.Drawing.Size(295, 21);
            this.txtParametroBusqueda.TabIndex = 39;
            this.txtParametroBusqueda.TextChanged += new System.EventHandler(this.txtParametroBusqueda_TextChanged);
            this.txtParametroBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtParametroBusqueda_KeyUp);
            // 
            // txtContrato
            // 
            this.txtContrato.BackColor = System.Drawing.Color.White;
            this.txtContrato.Enabled = false;
            this.txtContrato.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrato.ForeColor = System.Drawing.Color.Yellow;
            this.txtContrato.Location = new System.Drawing.Point(282, 47);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(71, 21);
            this.txtContrato.TabIndex = 121;
            this.txtContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(236, 50);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(47, 13);
            this.Label5.TabIndex = 120;
            this.Label5.Text = "N° CONT:";
            // 
            // dtpFechaCaducidad
            // 
            this.dtpFechaCaducidad.Enabled = false;
            this.dtpFechaCaducidad.Location = new System.Drawing.Point(77, 120);
            this.dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            this.dtpFechaCaducidad.Size = new System.Drawing.Size(276, 21);
            this.dtpFechaCaducidad.TabIndex = 45;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(359, 11);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(125, 144);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 119;
            this.PictureBox1.TabStop = false;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Enabled = false;
            this.dtpFechaEmision.Location = new System.Drawing.Point(77, 84);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(276, 21);
            this.dtpFechaEmision.TabIndex = 42;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 115);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 26);
            this.Label3.TabIndex = 44;
            this.Label3.Text = "FECHA\r\nCADUCIDAD:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "CODIGO:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 80);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 26);
            this.Label2.TabIndex = 43;
            this.Label2.Text = "FECHA\r\nEMISIÓN:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Yellow;
            this.txtCodigo.Location = new System.Drawing.Point(58, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(70, 21);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(60)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridView1.Location = new System.Drawing.Point(880, 29);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(193, 157);
            this.DataGridView1.TabIndex = 219;
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // dgvBusquedaPersonal
            // 
            this.dgvBusquedaPersonal.AllowUserToAddRows = false;
            this.dgvBusquedaPersonal.AllowUserToDeleteRows = false;
            this.dgvBusquedaPersonal.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBusquedaPersonal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBusquedaPersonal.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusquedaPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusquedaPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvBusquedaPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(60)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBusquedaPersonal.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvBusquedaPersonal.Location = new System.Drawing.Point(491, 29);
            this.dgvBusquedaPersonal.MultiSelect = false;
            this.dgvBusquedaPersonal.Name = "dgvBusquedaPersonal";
            this.dgvBusquedaPersonal.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusquedaPersonal.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvBusquedaPersonal.RowHeadersVisible = false;
            this.dgvBusquedaPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusquedaPersonal.Size = new System.Drawing.Size(390, 157);
            this.dgvBusquedaPersonal.TabIndex = 218;
            this.dgvBusquedaPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusquedaPersonal_CellContentClick);
            this.dgvBusquedaPersonal.SelectionChanged += new System.EventHandler(this.dgvBusquedaPersonal_SelectionChanged);
            // 
            // crvCredenciales
            // 
            this.crvCredenciales.ActiveViewIndex = -1;
            this.crvCredenciales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCredenciales.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCredenciales.EnableRefresh = false;
            this.crvCredenciales.Location = new System.Drawing.Point(-2, 188);
            this.crvCredenciales.Name = "crvCredenciales";
            this.crvCredenciales.ShowCloseButton = false;
            this.crvCredenciales.ShowCopyButton = false;
            this.crvCredenciales.ShowGotoPageButton = false;
            this.crvCredenciales.ShowGroupTreeButton = false;
            this.crvCredenciales.ShowParameterPanelButton = false;
            this.crvCredenciales.ShowTextSearchButton = false;
            this.crvCredenciales.Size = new System.Drawing.Size(1099, 505);
            this.crvCredenciales.TabIndex = 220;
            this.crvCredenciales.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // axAcroPDF1
            // 
            //this.axAcroPDF1.Enabled = true;
            //this.axAcroPDF1.Location = new System.Drawing.Point(3, 188);
            //this.axAcroPDF1.Name = "axAcroPDF1";
            //this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            //this.axAcroPDF1.Size = new System.Drawing.Size(1070, 505);
            //this.axAcroPDF1.TabIndex = 221;
            //this.axAcroPDF1.Visible = false;
            // 
            // TicComisariato
            // 
            this.TicComisariato.Image = global::SysCisepro3.Properties.Resources.debit_icon;
            this.TicComisariato.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TicComisariato.Name = "TicComisariato";
            this.TicComisariato.Size = new System.Drawing.Size(142, 22);
            this.TicComisariato.Text = "TICKET COMISARIATO";
            this.TicComisariato.Click += new System.EventHandler(this.TicComisariato_Click);
            // 
            // FrmGenerarCredencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 696);
            this.Controls.Add(this.crvCredenciales);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.dgvBusquedaPersonal);
            this.Controls.Add(this.gbParámetros);
            this.Controls.Add(this.toolStrip1);
            //this.Controls.Add(this.axAcroPDF1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmGenerarCredencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERAR CREDENCIAL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGenerarCredencial_FormClosing);
            this.Load += new System.EventHandler(this.FrmGenerarCredencial_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbParámetros.ResumeLayout(false);
            this.gbParámetros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaPersonal)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.GroupBox gbParámetros;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtParametroBusqueda;
        internal System.Windows.Forms.TextBox txtContrato;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.DateTimePicker dtpFechaCaducidad;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.DateTimePicker dtpFechaEmision;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridView dgvBusquedaPersonal;
        internal CrystalDecisions.Windows.Forms.CrystalReportViewer crvCredenciales;
        private System.Windows.Forms.ToolStripDropDownButton toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.ToolStripMenuItem cREDENCIALCISSEPToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ticComecsa;
        private System.Windows.Forms.ToolStripButton ticFarmacia;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton TicComisariato;
    }
}