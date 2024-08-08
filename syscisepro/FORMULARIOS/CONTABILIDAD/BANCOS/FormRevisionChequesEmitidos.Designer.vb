Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormRevisionChequesEmitidos
        'Inherits System.Windows.Forms.Form
        Inherits Krypton.Toolkit.KryptonForm
        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRevisionChequesEmitidos))
            Me.txtTotalEmitidosNoCobrados = New System.Windows.Forms.TextBox()
            Me.txtTotalEmitidosCobrados = New System.Windows.Forms.TextBox()
            Me.lblIdComprobanteEgresoBanco = New System.Windows.Forms.Label()
            Me.dgvChequesEmitidosAprobados = New System.Windows.Forms.DataGridView()
            Me.CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.gbTotalChequesEmitidosNoCobrados = New System.Windows.Forms.GroupBox()
            Me.tcRevisionCheques = New System.Windows.Forms.TabControl()
            Me.tpEmitidosNoCobrados = New System.Windows.Forms.TabPage()
            Me.tpEmitidosCobrados = New System.Windows.Forms.TabPage()
            Me.dgvEmitidosCobrados = New System.Windows.Forms.DataGridView()
            Me.gbTotalEmitidosCobrados = New System.Windows.Forms.GroupBox()
            Me.tpCaducados = New System.Windows.Forms.TabPage()
            Me.dgvEmitidosCaducados = New System.Windows.Forms.DataGridView()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.chkCaducado = New System.Windows.Forms.CheckBox()
            Me.dtpFechaCobroCheque = New System.Windows.Forms.DateTimePicker()
            Me.gbBanco = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAprobar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.CrToolStripTextBox1 = New CrystalDecisions.Windows.Forms.CRToolStripTextBox()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox5 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.btnBuscarModi = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.txtFiltro = New System.Windows.Forms.TextBox()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox3 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            CType(Me.dgvChequesEmitidosAprobados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcRevisionCheques.SuspendLayout()
            Me.tpEmitidosNoCobrados.SuspendLayout()
            Me.tpEmitidosCobrados.SuspendLayout()
            CType(Me.dgvEmitidosCobrados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpCaducados.SuspendLayout()
            CType(Me.dgvEmitidosCaducados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbBanco.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox5.Panel.SuspendLayout()
            Me.KryptonGroupBox5.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtTotalEmitidosNoCobrados
            '
            Me.txtTotalEmitidosNoCobrados.BackColor = System.Drawing.Color.White
            Me.txtTotalEmitidosNoCobrados.Enabled = False
            Me.txtTotalEmitidosNoCobrados.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalEmitidosNoCobrados.Location = New System.Drawing.Point(80, 18)
            Me.txtTotalEmitidosNoCobrados.Name = "txtTotalEmitidosNoCobrados"
            Me.txtTotalEmitidosNoCobrados.Size = New System.Drawing.Size(69, 21)
            Me.txtTotalEmitidosNoCobrados.TabIndex = 0
            Me.txtTotalEmitidosNoCobrados.Text = "0.00"
            Me.txtTotalEmitidosNoCobrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalEmitidosCobrados
            '
            Me.txtTotalEmitidosCobrados.BackColor = System.Drawing.Color.White
            Me.txtTotalEmitidosCobrados.Enabled = False
            Me.txtTotalEmitidosCobrados.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalEmitidosCobrados.Location = New System.Drawing.Point(5, 18)
            Me.txtTotalEmitidosCobrados.Name = "txtTotalEmitidosCobrados"
            Me.txtTotalEmitidosCobrados.Size = New System.Drawing.Size(69, 21)
            Me.txtTotalEmitidosCobrados.TabIndex = 0
            Me.txtTotalEmitidosCobrados.Text = "0.00"
            Me.txtTotalEmitidosCobrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIdComprobanteEgresoBanco
            '
            Me.lblIdComprobanteEgresoBanco.AutoSize = True
            Me.lblIdComprobanteEgresoBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblIdComprobanteEgresoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteEgresoBanco.Location = New System.Drawing.Point(15, 0)
            Me.lblIdComprobanteEgresoBanco.Name = "lblIdComprobanteEgresoBanco"
            Me.lblIdComprobanteEgresoBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteEgresoBanco.TabIndex = 58
            Me.lblIdComprobanteEgresoBanco.Text = "..."
            '
            'dgvChequesEmitidosAprobados
            '
            Me.dgvChequesEmitidosAprobados.AllowUserToAddRows = False
            Me.dgvChequesEmitidosAprobados.AllowUserToDeleteRows = False
            Me.dgvChequesEmitidosAprobados.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvChequesEmitidosAprobados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvChequesEmitidosAprobados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
            Me.dgvChequesEmitidosAprobados.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvChequesEmitidosAprobados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvChequesEmitidosAprobados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvChequesEmitidosAprobados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvChequesEmitidosAprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvChequesEmitidosAprobados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvChequesEmitidosAprobados.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvChequesEmitidosAprobados.Location = New System.Drawing.Point(3, 4)
            Me.dgvChequesEmitidosAprobados.MultiSelect = False
            Me.dgvChequesEmitidosAprobados.Name = "dgvChequesEmitidosAprobados"
            Me.dgvChequesEmitidosAprobados.RowHeadersVisible = False
            Me.dgvChequesEmitidosAprobados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvChequesEmitidosAprobados.Size = New System.Drawing.Size(929, 454)
            Me.dgvChequesEmitidosAprobados.TabIndex = 46
            '
            'CHK
            '
            Me.CHK.HeaderText = "CHK"
            Me.CHK.Name = "CHK"
            Me.CHK.Width = 40
            '
            'gbTotalChequesEmitidosNoCobrados
            '
            Me.gbTotalChequesEmitidosNoCobrados.BackColor = System.Drawing.Color.White
            Me.gbTotalChequesEmitidosNoCobrados.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotalChequesEmitidosNoCobrados.Location = New System.Drawing.Point(3, 616)
            Me.gbTotalChequesEmitidosNoCobrados.Name = "gbTotalChequesEmitidosNoCobrados"
            Me.gbTotalChequesEmitidosNoCobrados.Size = New System.Drawing.Size(1118, 42)
            Me.gbTotalChequesEmitidosNoCobrados.TabIndex = 56
            Me.gbTotalChequesEmitidosNoCobrados.TabStop = False
            Me.gbTotalChequesEmitidosNoCobrados.Text = "TOTAL EMITIDOS NO COBRADOS"
            '
            'tcRevisionCheques
            '
            Me.tcRevisionCheques.Controls.Add(Me.tpEmitidosNoCobrados)
            Me.tcRevisionCheques.Controls.Add(Me.tpEmitidosCobrados)
            Me.tcRevisionCheques.Controls.Add(Me.tpCaducados)
            Me.tcRevisionCheques.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcRevisionCheques.Location = New System.Drawing.Point(2, 95)
            Me.tcRevisionCheques.Name = "tcRevisionCheques"
            Me.tcRevisionCheques.SelectedIndex = 0
            Me.tcRevisionCheques.Size = New System.Drawing.Size(949, 491)
            Me.tcRevisionCheques.TabIndex = 57
            '
            'tpEmitidosNoCobrados
            '
            Me.tpEmitidosNoCobrados.BackColor = System.Drawing.Color.White
            Me.tpEmitidosNoCobrados.Controls.Add(Me.dgvChequesEmitidosAprobados)
            Me.tpEmitidosNoCobrados.Controls.Add(Me.gbTotalChequesEmitidosNoCobrados)
            Me.tpEmitidosNoCobrados.Location = New System.Drawing.Point(4, 22)
            Me.tpEmitidosNoCobrados.Name = "tpEmitidosNoCobrados"
            Me.tpEmitidosNoCobrados.Padding = New System.Windows.Forms.Padding(3)
            Me.tpEmitidosNoCobrados.Size = New System.Drawing.Size(941, 465)
            Me.tpEmitidosNoCobrados.TabIndex = 0
            Me.tpEmitidosNoCobrados.Text = "EMITIDOS NO COBRADOS GENERAL"
            '
            'tpEmitidosCobrados
            '
            Me.tpEmitidosCobrados.BackColor = System.Drawing.Color.White
            Me.tpEmitidosCobrados.Controls.Add(Me.dgvEmitidosCobrados)
            Me.tpEmitidosCobrados.Controls.Add(Me.gbTotalEmitidosCobrados)
            Me.tpEmitidosCobrados.Location = New System.Drawing.Point(4, 22)
            Me.tpEmitidosCobrados.Name = "tpEmitidosCobrados"
            Me.tpEmitidosCobrados.Padding = New System.Windows.Forms.Padding(3)
            Me.tpEmitidosCobrados.Size = New System.Drawing.Size(941, 465)
            Me.tpEmitidosCobrados.TabIndex = 1
            Me.tpEmitidosCobrados.Text = "EMITIDOS COBRADOS GENERAL"
            '
            'dgvEmitidosCobrados
            '
            Me.dgvEmitidosCobrados.AllowUserToAddRows = False
            Me.dgvEmitidosCobrados.AllowUserToDeleteRows = False
            Me.dgvEmitidosCobrados.AllowUserToResizeRows = False
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvEmitidosCobrados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvEmitidosCobrados.BackgroundColor = System.Drawing.Color.White
            Me.dgvEmitidosCobrados.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvEmitidosCobrados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvEmitidosCobrados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvEmitidosCobrados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvEmitidosCobrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvEmitidosCobrados.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvEmitidosCobrados.GridColor = System.Drawing.SystemColors.Control
            Me.dgvEmitidosCobrados.Location = New System.Drawing.Point(3, 5)
            Me.dgvEmitidosCobrados.MultiSelect = False
            Me.dgvEmitidosCobrados.Name = "dgvEmitidosCobrados"
            Me.dgvEmitidosCobrados.ReadOnly = True
            Me.dgvEmitidosCobrados.RowHeadersVisible = False
            Me.dgvEmitidosCobrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvEmitidosCobrados.Size = New System.Drawing.Size(929, 454)
            Me.dgvEmitidosCobrados.TabIndex = 0
            '
            'gbTotalEmitidosCobrados
            '
            Me.gbTotalEmitidosCobrados.BackColor = System.Drawing.Color.White
            Me.gbTotalEmitidosCobrados.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotalEmitidosCobrados.Location = New System.Drawing.Point(6, 616)
            Me.gbTotalEmitidosCobrados.Name = "gbTotalEmitidosCobrados"
            Me.gbTotalEmitidosCobrados.Size = New System.Drawing.Size(1115, 42)
            Me.gbTotalEmitidosCobrados.TabIndex = 57
            Me.gbTotalEmitidosCobrados.TabStop = False
            Me.gbTotalEmitidosCobrados.Text = "TOTAL EMITIDOS COBRADOS"
            '
            'tpCaducados
            '
            Me.tpCaducados.Controls.Add(Me.dgvEmitidosCaducados)
            Me.tpCaducados.Location = New System.Drawing.Point(4, 22)
            Me.tpCaducados.Name = "tpCaducados"
            Me.tpCaducados.Padding = New System.Windows.Forms.Padding(3)
            Me.tpCaducados.Size = New System.Drawing.Size(941, 465)
            Me.tpCaducados.TabIndex = 2
            Me.tpCaducados.Text = "EMITIDOS CADUCADOS"
            Me.tpCaducados.UseVisualStyleBackColor = True
            '
            'dgvEmitidosCaducados
            '
            Me.dgvEmitidosCaducados.AllowUserToAddRows = False
            Me.dgvEmitidosCaducados.AllowUserToDeleteRows = False
            Me.dgvEmitidosCaducados.AllowUserToResizeRows = False
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvEmitidosCaducados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvEmitidosCaducados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
            Me.dgvEmitidosCaducados.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvEmitidosCaducados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvEmitidosCaducados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvEmitidosCaducados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvEmitidosCaducados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvEmitidosCaducados.DefaultCellStyle = DataGridViewCellStyle9
            Me.dgvEmitidosCaducados.Location = New System.Drawing.Point(3, 5)
            Me.dgvEmitidosCaducados.MultiSelect = False
            Me.dgvEmitidosCaducados.Name = "dgvEmitidosCaducados"
            Me.dgvEmitidosCaducados.ReadOnly = True
            Me.dgvEmitidosCaducados.RowHeadersVisible = False
            Me.dgvEmitidosCaducados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvEmitidosCaducados.Size = New System.Drawing.Size(929, 460)
            Me.dgvEmitidosCaducados.TabIndex = 1
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(123, 3)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(81, 21)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(6, 3)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(81, 21)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'chkCaducado
            '
            Me.chkCaducado.AutoSize = True
            Me.chkCaducado.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkCaducado.Location = New System.Drawing.Point(109, 8)
            Me.chkCaducado.Name = "chkCaducado"
            Me.chkCaducado.Size = New System.Drawing.Size(75, 17)
            Me.chkCaducado.TabIndex = 3
            Me.chkCaducado.Text = "Caducado"
            Me.chkCaducado.UseVisualStyleBackColor = False
            '
            'dtpFechaCobroCheque
            '
            Me.dtpFechaCobroCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaCobroCheque.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaCobroCheque.Location = New System.Drawing.Point(3, 2)
            Me.dtpFechaCobroCheque.Name = "dtpFechaCobroCheque"
            Me.dtpFechaCobroCheque.Size = New System.Drawing.Size(91, 21)
            Me.dtpFechaCobroCheque.TabIndex = 2
            '
            'gbBanco
            '
            Me.gbBanco.BackColor = System.Drawing.Color.White
            Me.gbBanco.Controls.Add(Me.Label10)
            Me.gbBanco.Controls.Add(Me.cmbCuentaBancos)
            Me.gbBanco.Controls.Add(Me.cmbBancos)
            Me.gbBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBanco.Location = New System.Drawing.Point(892, 44)
            Me.gbBanco.Name = "gbBanco"
            Me.gbBanco.Size = New System.Drawing.Size(24, 45)
            Me.gbBanco.TabIndex = 117
            Me.gbBanco.TabStop = False
            Me.gbBanco.Text = "BANCO: "
            Me.gbBanco.Visible = False
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(155, 0)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(62, 13)
            Me.Label10.TabIndex = 34
            Me.Label10.Text = "CA/CC/TA:"
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(155, 18)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(110, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.BackColor = System.Drawing.Color.White
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(10, 18)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(129, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnAprobar, Me.btnReporte, Me.CrToolStripTextBox1, Me.ToolStripMenuItem1, Me.btnExportar, Me.ToolStripMenuItem2})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(951, 32)
            Me.MenuStrip1.TabIndex = 187
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(90, 28)
            Me.btnBuscar.Text = "BUSCAR "
            '
            'btnAprobar
            '
            Me.btnAprobar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAprobar.Image = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnAprobar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAprobar.Name = "btnAprobar"
            Me.btnAprobar.Size = New System.Drawing.Size(96, 28)
            Me.btnAprobar.Text = "APROBAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(90, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'CrToolStripTextBox1
            '
            Me.CrToolStripTextBox1.AutoSize = False
            Me.CrToolStripTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.CrToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.CrToolStripTextBox1.Enabled = False
            Me.CrToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.CrToolStripTextBox1.Name = "CrToolStripTextBox1"
            Me.CrToolStripTextBox1.ReadOnly = True
            Me.CrToolStripTextBox1.Size = New System.Drawing.Size(100, 20)
            Me.CrToolStripTextBox1.Text = "EXPORTAR"
            Me.CrToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.CrToolStripTextBox1.Visible = False
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(105, 28)
            Me.ToolStripMenuItem1.Text = "COBRADOS"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(126, 28)
            Me.btnExportar.Text = "NO COBRADOS"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(114, 28)
            Me.ToolStripMenuItem2.Text = "CADUCADOS"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlGroupBox
            Me.KryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(6, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaHasta)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(214, 56)
            Me.KryptonGroupBox1.TabIndex = 188
            Me.KryptonGroupBox1.Values.Heading = "Fechas"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(96, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(17, 20)
            Me.KryptonLabel1.TabIndex = 2
            Me.KryptonLabel1.Values.Text = "a"
            '
            'KryptonGroupBox5
            '
            Me.KryptonGroupBox5.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption
            Me.KryptonGroupBox5.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlGroupBox
            Me.KryptonGroupBox5.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox
            Me.KryptonGroupBox5.Location = New System.Drawing.Point(224, 35)
            Me.KryptonGroupBox5.Name = "KryptonGroupBox5"
            '
            'KryptonGroupBox5.Panel
            '
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.btnBuscarModi)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtFiltro)
            Me.KryptonGroupBox5.Size = New System.Drawing.Size(255, 55)
            Me.KryptonGroupBox5.TabIndex = 189
            Me.KryptonGroupBox5.Values.Heading = "Busqueda"
            '
            'btnBuscarModi
            '
            Me.btnBuscarModi.AutoSize = True
            Me.btnBuscarModi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnBuscarModi.Location = New System.Drawing.Point(212, -2)
            Me.btnBuscarModi.Name = "btnBuscarModi"
            Me.btnBuscarModi.Size = New System.Drawing.Size(32, 32)
            Me.btnBuscarModi.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnBuscarModi.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
            Me.btnBuscarModi.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnBuscarModi.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
            Me.btnBuscarModi.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
            Me.btnBuscarModi.StateCommon.Content.Padding = New System.Windows.Forms.Padding(2)
            Me.btnBuscarModi.TabIndex = 249
            Me.btnBuscarModi.Values.ImageStates.ImageCheckedNormal = Nothing
            Me.btnBuscarModi.Values.ImageStates.ImageCheckedPressed = Nothing
            Me.btnBuscarModi.Values.ImageStates.ImageCheckedTracking = Nothing
            Me.btnBuscarModi.Values.ImageStates.ImageDisabled = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarModi.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarModi.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnBuscarModi.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnBuscarModi.Values.Text = ""
            '
            'txtFiltro
            '
            Me.txtFiltro.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFiltro.Location = New System.Drawing.Point(9, 4)
            Me.txtFiltro.Name = "txtFiltro"
            Me.txtFiltro.Size = New System.Drawing.Size(189, 21)
            Me.txtFiltro.TabIndex = 13
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlGroupBox
            Me.KryptonGroupBox2.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(484, 35)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.chkCaducado)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dtpFechaCobroCheque)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(105, 55)
            Me.KryptonGroupBox2.TabIndex = 190
            Me.KryptonGroupBox2.Values.Heading = "Cobro"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption
            Me.KryptonGroupBox3.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlGroupBox
            Me.KryptonGroupBox3.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(594, 44)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalEmitidosNoCobrados)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblIdComprobanteEgresoBanco)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalEmitidosCobrados)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(167, 53)
            Me.KryptonGroupBox3.TabIndex = 191
            Me.KryptonGroupBox3.Values.Heading = ""
            '
            'FormRevisionChequesEmitidos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(951, 587)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.KryptonGroupBox5)
            Me.Controls.Add(Me.gbBanco)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tcRevisionCheques)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormRevisionChequesEmitidos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REVISIÓN DE CHEQUES EMITIDOS"
            CType(Me.dgvChequesEmitidosAprobados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcRevisionCheques.ResumeLayout(False)
            Me.tpEmitidosNoCobrados.ResumeLayout(False)
            Me.tpEmitidosCobrados.ResumeLayout(False)
            CType(Me.dgvEmitidosCobrados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpCaducados.ResumeLayout(False)
            CType(Me.dgvEmitidosCaducados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbBanco.ResumeLayout(False)
            Me.gbBanco.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.Panel.ResumeLayout(False)
            Me.KryptonGroupBox5.Panel.PerformLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            Me.KryptonGroupBox2.Panel.PerformLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            Me.KryptonGroupBox3.Panel.PerformLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvChequesEmitidosAprobados As System.Windows.Forms.DataGridView
        Friend WithEvents CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents gbTotalChequesEmitidosNoCobrados As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalEmitidosNoCobrados As System.Windows.Forms.TextBox
        Friend WithEvents tcRevisionCheques As System.Windows.Forms.TabControl
        Friend WithEvents tpEmitidosNoCobrados As System.Windows.Forms.TabPage
        Friend WithEvents tpEmitidosCobrados As System.Windows.Forms.TabPage
        Friend WithEvents dgvEmitidosCobrados As System.Windows.Forms.DataGridView
        Friend WithEvents gbTotalEmitidosCobrados As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalEmitidosCobrados As System.Windows.Forms.TextBox
        Friend WithEvents lblIdComprobanteEgresoBanco As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaCobroCheque As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbBanco As System.Windows.Forms.GroupBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents tpCaducados As System.Windows.Forms.TabPage
        Friend WithEvents dgvEmitidosCaducados As System.Windows.Forms.DataGridView
        Friend WithEvents chkCaducado As System.Windows.Forms.CheckBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAprobar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CrToolStripTextBox1 As CrystalDecisions.Windows.Forms.CRToolStripTextBox
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox5 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents btnBuscarModi As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents txtFiltro As TextBox
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox3 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    End Class
End Namespace