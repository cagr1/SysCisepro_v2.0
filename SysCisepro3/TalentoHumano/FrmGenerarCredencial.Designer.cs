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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TicComisariato = new System.Windows.Forms.ToolStripButton();
            this.txtParametroBusqueda = new System.Windows.Forms.TextBox();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.dtpFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvBusquedaPersonal = new System.Windows.Forms.DataGridView();
            this.crvCredenciales = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripButton1,
            this.ticComecsa,
            this.ticFarmacia,
            this.TicComisariato});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(941, 31);
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
            this.toolStripMenuItem1.Image = global::SysCisepro3.Properties.Resources.badge_24dp_FILL0_wght400_GRAD0_opsz24;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 28);
            this.toolStripMenuItem1.Text = "GENERAR CREDENCIALES";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::SysCisepro3.Properties.Resources.badge_24dp_FILL0_wght400_GRAD0_opsz24;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 30);
            this.toolStripMenuItem2.Text = "PARA VISITANTE";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.pARAVISITANTEToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::SysCisepro3.Properties.Resources.badge_24dp_FILL0_wght400_GRAD0_opsz24;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(201, 30);
            this.toolStripMenuItem3.Text = "PARA PERSONAL";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.pARAPERSONALToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::SysCisepro3.Properties.Resources.badge_24dp_FILL0_wght400_GRAD0_opsz24;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(201, 30);
            this.toolStripMenuItem4.Text = "PARA LICITACIONES";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.pARALICITACIONESToolStripMenuItem_Click);
            // 
            // cREDENCIALCISSEPToolStripMenuItem
            // 
            this.cREDENCIALCISSEPToolStripMenuItem.Image = global::SysCisepro3.Properties.Resources.badge_24dp_FILL0_wght400_GRAD0_opsz24;
            this.cREDENCIALCISSEPToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cREDENCIALCISSEPToolStripMenuItem.Name = "cREDENCIALCISSEPToolStripMenuItem";
            this.cREDENCIALCISSEPToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.cREDENCIALCISSEPToolStripMenuItem.Text = "CREDENCIAL CIS / SEP";
            this.cREDENCIALCISSEPToolStripMenuItem.Click += new System.EventHandler(this.cREDENCIALCISSEPToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::SysCisepro3.Properties.Resources.checkbook_20dp_FILL0_wght400_GRAD0_opsz20__2_;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(148, 28);
            this.toolStripButton1.Text = "SOLICITUD ANTICIPO";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ticComecsa
            // 
            this.ticComecsa.Image = global::SysCisepro3.Properties.Resources.confirmation_number_24dp_FILL0_wght400_GRAD0_opsz24;
            this.ticComecsa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ticComecsa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ticComecsa.Name = "ticComecsa";
            this.ticComecsa.Size = new System.Drawing.Size(130, 28);
            this.ticComecsa.Text = "TICKET COMECSA";
            this.ticComecsa.Click += new System.EventHandler(this.ticComecsa_Click);
            // 
            // ticFarmacia
            // 
            this.ticFarmacia.Image = global::SysCisepro3.Properties.Resources.confirmation_number_24dp_FILL0_wght400_GRAD0_opsz24;
            this.ticFarmacia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ticFarmacia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ticFarmacia.Name = "ticFarmacia";
            this.ticFarmacia.Size = new System.Drawing.Size(132, 28);
            this.ticFarmacia.Text = "TICKET FARMACIA";
            this.ticFarmacia.Click += new System.EventHandler(this.ticFarmacia_Click);
            // 
            // TicComisariato
            // 
            this.TicComisariato.Image = global::SysCisepro3.Properties.Resources.confirmation_number_24dp_FILL0_wght400_GRAD0_opsz24;
            this.TicComisariato.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TicComisariato.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TicComisariato.Name = "TicComisariato";
            this.TicComisariato.Size = new System.Drawing.Size(150, 28);
            this.TicComisariato.Text = "TICKET COMISARIATO";
            this.TicComisariato.Click += new System.EventHandler(this.TicComisariato_Click);
            // 
            // txtParametroBusqueda
            // 
            this.txtParametroBusqueda.BackColor = System.Drawing.Color.White;
            this.txtParametroBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametroBusqueda.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroBusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtParametroBusqueda.Location = new System.Drawing.Point(62, 3);
            this.txtParametroBusqueda.Name = "txtParametroBusqueda";
            this.txtParametroBusqueda.Size = new System.Drawing.Size(246, 21);
            this.txtParametroBusqueda.TabIndex = 39;
            this.txtParametroBusqueda.TextChanged += new System.EventHandler(this.txtParametroBusqueda_TextChanged);
            this.txtParametroBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtParametroBusqueda_KeyUp);
            // 
            // txtContrato
            // 
            this.txtContrato.BackColor = System.Drawing.Color.White;
            this.txtContrato.Enabled = false;
            this.txtContrato.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrato.ForeColor = System.Drawing.Color.Yellow;
            this.txtContrato.Location = new System.Drawing.Point(237, 29);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(71, 21);
            this.txtContrato.TabIndex = 121;
            this.txtContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFechaCaducidad
            // 
            this.dtpFechaCaducidad.Enabled = false;
            this.dtpFechaCaducidad.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCaducidad.Location = new System.Drawing.Point(109, 83);
            this.dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            this.dtpFechaCaducidad.Size = new System.Drawing.Size(199, 21);
            this.dtpFechaCaducidad.TabIndex = 45;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.PictureBox1.Location = new System.Drawing.Point(320, 1);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(90, 126);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 119;
            this.PictureBox1.TabStop = false;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Enabled = false;
            this.dtpFechaEmision.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEmision.Location = new System.Drawing.Point(109, 57);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(199, 21);
            this.dtpFechaEmision.TabIndex = 42;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Yellow;
            this.txtCodigo.Location = new System.Drawing.Point(62, 30);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(60)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.Location = new System.Drawing.Point(747, 1);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(168, 126);
            this.DataGridView1.TabIndex = 219;
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // dgvBusquedaPersonal
            // 
            this.dgvBusquedaPersonal.AllowUserToAddRows = false;
            this.dgvBusquedaPersonal.AllowUserToDeleteRows = false;
            this.dgvBusquedaPersonal.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBusquedaPersonal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBusquedaPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvBusquedaPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBusquedaPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusquedaPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBusquedaPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(60)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBusquedaPersonal.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBusquedaPersonal.Location = new System.Drawing.Point(416, 2);
            this.dgvBusquedaPersonal.MultiSelect = false;
            this.dgvBusquedaPersonal.Name = "dgvBusquedaPersonal";
            this.dgvBusquedaPersonal.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusquedaPersonal.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBusquedaPersonal.RowHeadersVisible = false;
            this.dgvBusquedaPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusquedaPersonal.Size = new System.Drawing.Size(318, 125);
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
            this.crvCredenciales.Location = new System.Drawing.Point(2, 196);
            this.crvCredenciales.Name = "crvCredenciales";
            this.crvCredenciales.ShowCloseButton = false;
            this.crvCredenciales.ShowCopyButton = false;
            this.crvCredenciales.ShowGotoPageButton = false;
            this.crvCredenciales.ShowGroupTreeButton = false;
            this.crvCredenciales.ShowLogo = false;
            this.crvCredenciales.ShowParameterPanelButton = false;
            this.crvCredenciales.ShowTextSearchButton = false;
            this.crvCredenciales.Size = new System.Drawing.Size(937, 355);
            this.crvCredenciales.TabIndex = 220;
            this.crvCredenciales.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionOverlap = 0D;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 36);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtContrato);
            this.kryptonGroupBox1.Panel.Controls.Add(this.DataGridView1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.PictureBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dgvBusquedaPersonal);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtpFechaCaducidad);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtParametroBusqueda);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtpFechaEmision);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtCodigo);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(939, 154);
            this.kryptonGroupBox1.TabIndex = 221;
            this.kryptonGroupBox1.Values.Heading = "Busqueda";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Buscar";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 30);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel2.TabIndex = 40;
            this.kryptonLabel2.Values.Text = "Codigo";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(3, 57);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel3.TabIndex = 41;
            this.kryptonLabel3.Values.Text = "Fecha Emision";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(3, 83);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(103, 20);
            this.kryptonLabel4.TabIndex = 42;
            this.kryptonLabel4.Values.Text = "Fecha Caducidad";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(153, 29);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel5.TabIndex = 46;
            this.kryptonLabel5.Values.Text = "No Cont";
            // 
            // FrmGenerarCredencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(941, 553);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.crvCredenciales);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmGenerarCredencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 5F;
            this.Text = "GENERAR CREDENCIAL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGenerarCredencial_FormClosing);
            this.Load += new System.EventHandler(this.FrmGenerarCredencial_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.TextBox txtParametroBusqueda;
        internal System.Windows.Forms.TextBox txtContrato;
        internal System.Windows.Forms.DateTimePicker dtpFechaCaducidad;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.DateTimePicker dtpFechaEmision;
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
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}