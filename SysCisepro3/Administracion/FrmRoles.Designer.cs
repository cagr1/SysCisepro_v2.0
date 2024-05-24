namespace SysCisepro3.Administracion
{
    partial class FrmRoles
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbxEstado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoRol = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vERTODOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUARDARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTUALIZARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cANCELARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.MENU_UNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MENU_DOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MENU_TRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_UNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ROL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PERMISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.gUARDARPERMISOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTUALIZARPERMISOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cANCELARPERMISOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRoles);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(737, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ROLES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.AllowUserToResizeRows = false;
            this.dgvRoles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoles.Location = new System.Drawing.Point(6, 103);
            this.dgvRoles.MultiSelect = false;
            this.dgvRoles.Name = "dgvRoles";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoles.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.Size = new System.Drawing.Size(722, 290);
            this.dgvRoles.TabIndex = 2;
            this.dgvRoles.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvRoles_CellBeginEdit);
            this.dgvRoles.SelectionChanged += new System.EventHandler(this.dgvRoles_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TIPO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DESCRIPCION";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ESTADO";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "FECHA ";
            this.Column5.Name = "Column5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chbxEstado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTipoRol);
            this.groupBox1.Location = new System.Drawing.Point(6, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(43, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID:";
            // 
            // chbxEstado
            // 
            this.chbxEstado.AutoSize = true;
            this.chbxEstado.Enabled = false;
            this.chbxEstado.Location = new System.Drawing.Point(642, 33);
            this.chbxEstado.Name = "chbxEstado";
            this.chbxEstado.Size = new System.Drawing.Size(65, 17);
            this.chbxEstado.TabIndex = 5;
            this.chbxEstado.Text = "ACTIVO";
            this.chbxEstado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESCRIPCION";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(463, 31);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(159, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIPO:";
            // 
            // txtTipoRol
            // 
            this.txtTipoRol.Enabled = false;
            this.txtTipoRol.Location = new System.Drawing.Point(189, 31);
            this.txtTipoRol.Name = "txtTipoRol";
            this.txtTipoRol.Size = new System.Drawing.Size(161, 20);
            this.txtTipoRol.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vERTODOSToolStripMenuItem,
            this.nUEVOToolStripMenuItem,
            this.gUARDARToolStripMenuItem,
            this.aCTUALIZARToolStripMenuItem,
            this.cANCELARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vERTODOSToolStripMenuItem
            // 
            this.vERTODOSToolStripMenuItem.Image = global::SysCisepro3.Properties.Resources.BuscarRegistro;
            this.vERTODOSToolStripMenuItem.Name = "vERTODOSToolStripMenuItem";
            this.vERTODOSToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.vERTODOSToolStripMenuItem.Text = "VER TODOS";
            this.vERTODOSToolStripMenuItem.Click += new System.EventHandler(this.vERTODOSToolStripMenuItem_Click);
            // 
            // nUEVOToolStripMenuItem
            // 
            this.nUEVOToolStripMenuItem.Image = global::SysCisepro3.Properties.Resources.NuevoRegistro;
            this.nUEVOToolStripMenuItem.Name = "nUEVOToolStripMenuItem";
            this.nUEVOToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nUEVOToolStripMenuItem.Text = "NUEVO";
            this.nUEVOToolStripMenuItem.Click += new System.EventHandler(this.nUEVOToolStripMenuItem_Click);
            // 
            // gUARDARToolStripMenuItem
            // 
            this.gUARDARToolStripMenuItem.Enabled = false;
            this.gUARDARToolStripMenuItem.Image = global::SysCisepro3.Properties.Resources.GuardarRegistro;
            this.gUARDARToolStripMenuItem.Name = "gUARDARToolStripMenuItem";
            this.gUARDARToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.gUARDARToolStripMenuItem.Text = "GUARDAR";
            this.gUARDARToolStripMenuItem.Click += new System.EventHandler(this.gUARDARToolStripMenuItem_Click);
            // 
            // aCTUALIZARToolStripMenuItem
            // 
            this.aCTUALIZARToolStripMenuItem.Image = global::SysCisepro3.Properties.Resources.refresh;
            this.aCTUALIZARToolStripMenuItem.Name = "aCTUALIZARToolStripMenuItem";
            this.aCTUALIZARToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.aCTUALIZARToolStripMenuItem.Text = "ACTUALIZAR";
            this.aCTUALIZARToolStripMenuItem.Click += new System.EventHandler(this.aCTUALIZARToolStripMenuItem_Click);
            // 
            // cANCELARToolStripMenuItem
            // 
            this.cANCELARToolStripMenuItem.Enabled = false;
            this.cANCELARToolStripMenuItem.Image = global::SysCisepro3.Properties.Resources.cancel;
            this.cANCELARToolStripMenuItem.Name = "cANCELARToolStripMenuItem";
            this.cANCELARToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.cANCELARToolStripMenuItem.Text = "CANCELAR";
            this.cANCELARToolStripMenuItem.Click += new System.EventHandler(this.cANCELARToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPermisos);
            this.tabPage2.Controls.Add(this.cbxTipo);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.menuStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(737, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PERMISOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.AllowUserToResizeRows = false;
            this.dgvPermisos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MENU_UNO,
            this.MENU_DOS,
            this.MENU_TRES,
            this.ESTADO,
            this.ID_UNO,
            this.ID_DOS,
            this.ID_TRES,
            this.ID_ROL,
            this.ID_PERMISO});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPermisos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPermisos.Location = new System.Drawing.Point(7, 66);
            this.dgvPermisos.MultiSelect = false;
            this.dgvPermisos.Name = "dgvPermisos";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPermisos.RowHeadersVisible = false;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPermisos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermisos.Size = new System.Drawing.Size(721, 389);
            this.dgvPermisos.TabIndex = 3;
            this.dgvPermisos.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvPermisos_CellBeginEdit);
            this.dgvPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellContentClick);
            // 
            // MENU_UNO
            // 
            this.MENU_UNO.HeaderText = "MENU PRINCIPAL";
            this.MENU_UNO.Name = "MENU_UNO";
            this.MENU_UNO.ReadOnly = true;
            // 
            // MENU_DOS
            // 
            this.MENU_DOS.HeaderText = "SEGUNDO MENU";
            this.MENU_DOS.Name = "MENU_DOS";
            this.MENU_DOS.ReadOnly = true;
            // 
            // MENU_TRES
            // 
            this.MENU_TRES.HeaderText = "TERCER MENU";
            this.MENU_TRES.Name = "MENU_TRES";
            this.MENU_TRES.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            // 
            // ID_UNO
            // 
            this.ID_UNO.HeaderText = "ID_UNO";
            this.ID_UNO.Name = "ID_UNO";
            this.ID_UNO.Visible = false;
            // 
            // ID_DOS
            // 
            this.ID_DOS.HeaderText = "Column1";
            this.ID_DOS.Name = "ID_DOS";
            this.ID_DOS.Visible = false;
            // 
            // ID_TRES
            // 
            this.ID_TRES.HeaderText = "ID_TRES";
            this.ID_TRES.Name = "ID_TRES";
            this.ID_TRES.Visible = false;
            // 
            // ID_ROL
            // 
            this.ID_ROL.HeaderText = "ID_ROL";
            this.ID_ROL.Name = "ID_ROL";
            this.ID_ROL.Visible = false;
            // 
            // ID_PERMISO
            // 
            this.ID_PERMISO.HeaderText = "ID_PERMISO";
            this.ID_PERMISO.Name = "ID_PERMISO";
            this.ID_PERMISO.Visible = false;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(100, 39);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(157, 21);
            this.cbxTipo.TabIndex = 2;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "TIPO DE ROL:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gUARDARPERMISOSToolStripMenuItem1,
            this.aCTUALIZARPERMISOSToolStripMenuItem1,
            this.cANCELARPERMISOSToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(731, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // gUARDARPERMISOSToolStripMenuItem1
            // 
            this.gUARDARPERMISOSToolStripMenuItem1.Enabled = false;
            this.gUARDARPERMISOSToolStripMenuItem1.Image = global::SysCisepro3.Properties.Resources.GuardarRegistro;
            this.gUARDARPERMISOSToolStripMenuItem1.Name = "gUARDARPERMISOSToolStripMenuItem1";
            this.gUARDARPERMISOSToolStripMenuItem1.Size = new System.Drawing.Size(92, 20);
            this.gUARDARPERMISOSToolStripMenuItem1.Text = "GUARDAR ";
            this.gUARDARPERMISOSToolStripMenuItem1.Click += new System.EventHandler(this.gUARDARPERMISOSToolStripMenuItem1_Click);
            // 
            // aCTUALIZARPERMISOSToolStripMenuItem1
            // 
            this.aCTUALIZARPERMISOSToolStripMenuItem1.Image = global::SysCisepro3.Properties.Resources.refresh;
            this.aCTUALIZARPERMISOSToolStripMenuItem1.Name = "aCTUALIZARPERMISOSToolStripMenuItem1";
            this.aCTUALIZARPERMISOSToolStripMenuItem1.Size = new System.Drawing.Size(104, 20);
            this.aCTUALIZARPERMISOSToolStripMenuItem1.Text = "ACTUALIZAR";
            this.aCTUALIZARPERMISOSToolStripMenuItem1.Click += new System.EventHandler(this.aCTUALIZARPERMISOSToolStripMenuItem1_Click);
            // 
            // cANCELARPERMISOSToolStripMenuItem1
            // 
            this.cANCELARPERMISOSToolStripMenuItem1.Enabled = false;
            this.cANCELARPERMISOSToolStripMenuItem1.Image = global::SysCisepro3.Properties.Resources.cancel;
            this.cANCELARPERMISOSToolStripMenuItem1.Name = "cANCELARPERMISOSToolStripMenuItem1";
            this.cANCELARPERMISOSToolStripMenuItem1.Size = new System.Drawing.Size(95, 20);
            this.cANCELARPERMISOSToolStripMenuItem1.Text = "CANCELAR";
            this.cANCELARPERMISOSToolStripMenuItem1.Click += new System.EventHandler(this.cANCELARPERMISOSToolStripMenuItem1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(737, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MENU";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 492);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROLES Y PERMISOS";
            this.Load += new System.EventHandler(this.FrmRoles_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vERTODOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gUARDARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCTUALIZARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cANCELARToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbxEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoRol;
        internal System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem gUARDARPERMISOSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aCTUALIZARPERMISOSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cANCELARPERMISOSToolStripMenuItem1;
        internal System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn MENU_UNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MENU_DOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MENU_TRES;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_UNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ROL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PERMISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TabPage tabPage3;

    }
}