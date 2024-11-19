Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBuscarComprobanteIngresoBaNcos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarComprobanteIngresoBaNcos))
            Me.rbFecha = New System.Windows.Forms.RadioButton()
            Me.rbTodo = New System.Windows.Forms.RadioButton()
            Me.dgvComprobanteEgresoBancos = New System.Windows.Forms.DataGridView()
            Me.txtTotalComprobantesIngreso = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.rbConsorcio = New System.Windows.Forms.RadioButton()
            Me.rbCliente = New System.Windows.Forms.RadioButton()
            Me.rbBanco = New System.Windows.Forms.RadioButton()
            Me.lblIdComprobanteIngresoBanco = New System.Windows.Forms.Label()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.gbTotal = New System.Windows.Forms.GroupBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.txtNombreComercialClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.dgvCliente = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbTotal.SuspendLayout()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'rbFecha
            '
            Me.rbFecha.AutoSize = True
            Me.rbFecha.BackColor = System.Drawing.Color.Transparent
            Me.rbFecha.Checked = True
            Me.rbFecha.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbFecha.Location = New System.Drawing.Point(9, 8)
            Me.rbFecha.Name = "rbFecha"
            Me.rbFecha.Size = New System.Drawing.Size(55, 17)
            Me.rbFecha.TabIndex = 20
            Me.rbFecha.TabStop = True
            Me.rbFecha.Text = "Fecha"
            Me.rbFecha.UseVisualStyleBackColor = False
            '
            'rbTodo
            '
            Me.rbTodo.AutoSize = True
            Me.rbTodo.BackColor = System.Drawing.Color.Transparent
            Me.rbTodo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTodo.Location = New System.Drawing.Point(69, 24)
            Me.rbTodo.Name = "rbTodo"
            Me.rbTodo.Size = New System.Drawing.Size(49, 17)
            Me.rbTodo.TabIndex = 19
            Me.rbTodo.Text = "Todo"
            Me.rbTodo.UseVisualStyleBackColor = False
            '
            'dgvComprobanteEgresoBancos
            '
            Me.dgvComprobanteEgresoBancos.AllowUserToAddRows = False
            Me.dgvComprobanteEgresoBancos.AllowUserToDeleteRows = False
            Me.dgvComprobanteEgresoBancos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobanteEgresoBancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvComprobanteEgresoBancos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvComprobanteEgresoBancos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobanteEgresoBancos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteEgresoBancos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobanteEgresoBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteEgresoBancos.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvComprobanteEgresoBancos.Location = New System.Drawing.Point(3, 124)
            Me.dgvComprobanteEgresoBancos.MultiSelect = False
            Me.dgvComprobanteEgresoBancos.Name = "dgvComprobanteEgresoBancos"
            Me.dgvComprobanteEgresoBancos.ReadOnly = True
            Me.dgvComprobanteEgresoBancos.RowHeadersVisible = False
            Me.dgvComprobanteEgresoBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteEgresoBancos.Size = New System.Drawing.Size(894, 308)
            Me.dgvComprobanteEgresoBancos.TabIndex = 107
            '
            'txtTotalComprobantesIngreso
            '
            Me.txtTotalComprobantesIngreso.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobantesIngreso.Enabled = False
            Me.txtTotalComprobantesIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobantesIngreso.Location = New System.Drawing.Point(732, 15)
            Me.txtTotalComprobantesIngreso.Name = "txtTotalComprobantesIngreso"
            Me.txtTotalComprobantesIngreso.ReadOnly = True
            Me.txtTotalComprobantesIngreso.Size = New System.Drawing.Size(119, 21)
            Me.txtTotalComprobantesIngreso.TabIndex = 110
            Me.txtTotalComprobantesIngreso.Text = "0.00"
            Me.txtTotalComprobantesIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(657, 18)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(52, 14)
            Me.Label2.TabIndex = 111
            Me.Label2.Text = "TOTAL:"
            '
            'rbConsorcio
            '
            Me.rbConsorcio.AutoSize = True
            Me.rbConsorcio.BackColor = System.Drawing.Color.Transparent
            Me.rbConsorcio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbConsorcio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbConsorcio.Location = New System.Drawing.Point(69, 8)
            Me.rbConsorcio.Name = "rbConsorcio"
            Me.rbConsorcio.Size = New System.Drawing.Size(55, 17)
            Me.rbConsorcio.TabIndex = 23
            Me.rbConsorcio.Text = "Grupo"
            Me.rbConsorcio.UseVisualStyleBackColor = False
            '
            'rbCliente
            '
            Me.rbCliente.AutoSize = True
            Me.rbCliente.BackColor = System.Drawing.Color.Transparent
            Me.rbCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCliente.Location = New System.Drawing.Point(130, 8)
            Me.rbCliente.Name = "rbCliente"
            Me.rbCliente.Size = New System.Drawing.Size(60, 17)
            Me.rbCliente.TabIndex = 22
            Me.rbCliente.Text = "Cliente"
            Me.rbCliente.UseVisualStyleBackColor = False
            '
            'rbBanco
            '
            Me.rbBanco.AutoSize = True
            Me.rbBanco.BackColor = System.Drawing.Color.Transparent
            Me.rbBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbBanco.Location = New System.Drawing.Point(9, 24)
            Me.rbBanco.Name = "rbBanco"
            Me.rbBanco.Size = New System.Drawing.Size(56, 17)
            Me.rbBanco.TabIndex = 21
            Me.rbBanco.Text = "Banco"
            Me.rbBanco.UseVisualStyleBackColor = False
            '
            'lblIdComprobanteIngresoBanco
            '
            Me.lblIdComprobanteIngresoBanco.AutoSize = True
            Me.lblIdComprobanteIngresoBanco.BackColor = System.Drawing.Color.Transparent
            Me.lblIdComprobanteIngresoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteIngresoBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteIngresoBanco.Location = New System.Drawing.Point(836, 4)
            Me.lblIdComprobanteIngresoBanco.Name = "lblIdComprobanteIngresoBanco"
            Me.lblIdComprobanteIngresoBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteIngresoBanco.TabIndex = 3
            Me.lblIdComprobanteIngresoBanco.Text = "..."
            '
            'dtpHasta
            '
            Me.dtpHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(775, 25)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(98, 21)
            Me.dtpHasta.TabIndex = 1
            '
            'dtpDesde
            '
            Me.dtpDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(659, 24)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(97, 21)
            Me.dtpDesde.TabIndex = 0
            '
            'gbTotal
            '
            Me.gbTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gbTotal.Controls.Add(Me.txtTotalComprobantesIngreso)
            Me.gbTotal.Controls.Add(Me.Label2)
            Me.gbTotal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotal.Location = New System.Drawing.Point(3, 434)
            Me.gbTotal.Name = "gbTotal"
            Me.gbTotal.Size = New System.Drawing.Size(894, 41)
            Me.gbTotal.TabIndex = 114
            Me.gbTotal.TabStop = False
            '
            'cmbBancos
            '
            Me.cmbBancos.BackColor = System.Drawing.Color.White
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(408, 23)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(111, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(541, 24)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(99, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'txtNombreComercialClienteGeneral
            '
            Me.txtNombreComercialClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialClienteGeneral.Location = New System.Drawing.Point(214, 23)
            Me.txtNombreComercialClienteGeneral.Name = "txtNombreComercialClienteGeneral"
            Me.txtNombreComercialClienteGeneral.Size = New System.Drawing.Size(174, 21)
            Me.txtNombreComercialClienteGeneral.TabIndex = 2
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.BackColor = System.Drawing.Color.Transparent
            Me.lblIdClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdClienteGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(270, 5)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdClienteGeneral.TabIndex = 76
            Me.lblIdClienteGeneral.Text = "..."
            '
            'dgvCliente
            '
            Me.dgvCliente.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCliente.Location = New System.Drawing.Point(214, 23)
            Me.dgvCliente.Name = "dgvCliente"
            Me.dgvCliente.Size = New System.Drawing.Size(95, 20)
            Me.dgvCliente.TabIndex = 82
            Me.dgvCliente.Visible = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnReporte, Me.ToolStripMenuItem1, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(899, 32)
            Me.MenuStrip1.TabIndex = 184
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(85, 28)
            Me.btnBuscar.Text = "BUSCAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(113, 28)
            Me.btnReporte.Text = "REPORTE A4"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(113, 28)
            Me.ToolStripMenuItem1.Text = "REPORTE A5"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(99, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 33)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdComprobanteIngresoBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCuentaBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dgvCliente)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbConsorcio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbCliente)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbTodo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbFecha)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(899, 85)
            Me.KryptonGroupBox1.TabIndex = 185
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(661, 2)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel4.TabIndex = 86
            Me.KryptonLabel4.Values.Text = "Desde"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(542, 1)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(66, 20)
            Me.KryptonLabel3.TabIndex = 85
            Me.KryptonLabel3.Values.Text = "CA/CC/TA"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(408, 1)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel2.TabIndex = 84
            Me.KryptonLabel2.Values.Text = "Banco"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(216, 1)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel1.TabIndex = 83
            Me.KryptonLabel1.Values.Text = "Cliente"
            '
            'FormBuscarComprobanteIngresoBaNcos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(899, 475)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvComprobanteEgresoBancos)
            Me.Controls.Add(Me.gbTotal)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormBuscarComprobanteIngresoBaNcos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BUSCAR COMPROBANTES DE INGRESO"
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbTotal.ResumeLayout(False)
            Me.gbTotal.PerformLayout()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvComprobanteEgresoBancos As System.Windows.Forms.DataGridView
        Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodo As System.Windows.Forms.RadioButton
        Friend WithEvents txtTotalComprobantesIngreso As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteIngresoBanco As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbTotal As System.Windows.Forms.GroupBox
        Friend WithEvents rbBanco As System.Windows.Forms.RadioButton
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents rbCliente As System.Windows.Forms.RadioButton
        Friend WithEvents txtNombreComercialClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
        Friend WithEvents rbConsorcio As System.Windows.Forms.RadioButton
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace