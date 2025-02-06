Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormBuscarComprobanteEgresoBancos
        'Inherits System.Windows.Forms.Form
        Inherits Krypton.Toolkit.KryptonForm
        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgvComprobanteEgresoBancos = New System.Windows.Forms.DataGridView()
            Me.lblIdBeneficiario = New System.Windows.Forms.Label()
            Me.txtBuscar = New System.Windows.Forms.TextBox()
            Me.lblIdComprobanteEgresoBanco = New System.Windows.Forms.Label()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.rbBanco = New System.Windows.Forms.RadioButton()
            Me.rbFecha = New System.Windows.Forms.RadioButton()
            Me.rbTodos = New System.Windows.Forms.RadioButton()
            Me.rbNumeroCheque = New System.Windows.Forms.RadioButton()
            Me.rbAprobados = New System.Windows.Forms.RadioButton()
            Me.rbEmitidos = New System.Windows.Forms.RadioButton()
            Me.txtNumeroCheque = New System.Windows.Forms.TextBox()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporteTodos = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.txtTotalComprobantesEgreso = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.PdfViewer1 = New PdfiumViewer.PdfViewer()
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvComprobanteEgresoBancos
            '
            Me.dgvComprobanteEgresoBancos.AllowUserToAddRows = False
            Me.dgvComprobanteEgresoBancos.AllowUserToDeleteRows = False
            Me.dgvComprobanteEgresoBancos.AllowUserToResizeRows = False
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobanteEgresoBancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvComprobanteEgresoBancos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvComprobanteEgresoBancos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobanteEgresoBancos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteEgresoBancos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvComprobanteEgresoBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteEgresoBancos.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvComprobanteEgresoBancos.Location = New System.Drawing.Point(13, 83)
            Me.dgvComprobanteEgresoBancos.MultiSelect = False
            Me.dgvComprobanteEgresoBancos.Name = "dgvComprobanteEgresoBancos"
            Me.dgvComprobanteEgresoBancos.RowHeadersVisible = False
            Me.dgvComprobanteEgresoBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteEgresoBancos.Size = New System.Drawing.Size(925, 396)
            Me.dgvComprobanteEgresoBancos.TabIndex = 18
            '
            'lblIdBeneficiario
            '
            Me.lblIdBeneficiario.AutoSize = True
            Me.lblIdBeneficiario.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdBeneficiario.Location = New System.Drawing.Point(856, 3)
            Me.lblIdBeneficiario.Name = "lblIdBeneficiario"
            Me.lblIdBeneficiario.Size = New System.Drawing.Size(16, 13)
            Me.lblIdBeneficiario.TabIndex = 4
            Me.lblIdBeneficiario.Text = "..."
            '
            'txtBuscar
            '
            Me.txtBuscar.BackColor = System.Drawing.Color.White
            Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBuscar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBuscar.Location = New System.Drawing.Point(763, 19)
            Me.txtBuscar.Name = "txtBuscar"
            Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtBuscar.Size = New System.Drawing.Size(136, 23)
            Me.txtBuscar.TabIndex = 1
            '
            'lblIdComprobanteEgresoBanco
            '
            Me.lblIdComprobanteEgresoBanco.AutoSize = True
            Me.lblIdComprobanteEgresoBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteEgresoBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteEgresoBanco.Location = New System.Drawing.Point(688, 3)
            Me.lblIdComprobanteEgresoBanco.Name = "lblIdComprobanteEgresoBanco"
            Me.lblIdComprobanteEgresoBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteEgresoBanco.TabIndex = 3
            Me.lblIdComprobanteEgresoBanco.Text = "..."
            '
            'dtpHasta
            '
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(659, 20)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(98, 21)
            Me.dtpHasta.TabIndex = 1
            '
            'dtpDesde
            '
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(546, 21)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(97, 21)
            Me.dtpDesde.TabIndex = 0
            '
            'rbBanco
            '
            Me.rbBanco.AutoSize = True
            Me.rbBanco.BackColor = System.Drawing.Color.Transparent
            Me.rbBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbBanco.Location = New System.Drawing.Point(83, 18)
            Me.rbBanco.Name = "rbBanco"
            Me.rbBanco.Size = New System.Drawing.Size(56, 17)
            Me.rbBanco.TabIndex = 5
            Me.rbBanco.Text = "Banco"
            Me.rbBanco.UseVisualStyleBackColor = False
            '
            'rbFecha
            '
            Me.rbFecha.AutoSize = True
            Me.rbFecha.BackColor = System.Drawing.Color.Transparent
            Me.rbFecha.Checked = True
            Me.rbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbFecha.Location = New System.Drawing.Point(84, 3)
            Me.rbFecha.Name = "rbFecha"
            Me.rbFecha.Size = New System.Drawing.Size(55, 17)
            Me.rbFecha.TabIndex = 4
            Me.rbFecha.TabStop = True
            Me.rbFecha.Text = "Fecha"
            Me.rbFecha.UseVisualStyleBackColor = False
            '
            'rbTodos
            '
            Me.rbTodos.AutoSize = True
            Me.rbTodos.BackColor = System.Drawing.Color.Transparent
            Me.rbTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTodos.Location = New System.Drawing.Point(146, 18)
            Me.rbTodos.Name = "rbTodos"
            Me.rbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rbTodos.TabIndex = 3
            Me.rbTodos.Text = "Todos"
            Me.rbTodos.UseVisualStyleBackColor = False
            '
            'rbNumeroCheque
            '
            Me.rbNumeroCheque.AutoSize = True
            Me.rbNumeroCheque.BackColor = System.Drawing.Color.Transparent
            Me.rbNumeroCheque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbNumeroCheque.Location = New System.Drawing.Point(146, 3)
            Me.rbNumeroCheque.Name = "rbNumeroCheque"
            Me.rbNumeroCheque.Size = New System.Drawing.Size(62, 17)
            Me.rbNumeroCheque.TabIndex = 2
            Me.rbNumeroCheque.Text = "Cheque"
            Me.rbNumeroCheque.UseVisualStyleBackColor = False
            '
            'rbAprobados
            '
            Me.rbAprobados.AutoSize = True
            Me.rbAprobados.BackColor = System.Drawing.Color.Transparent
            Me.rbAprobados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbAprobados.Location = New System.Drawing.Point(6, 18)
            Me.rbAprobados.Name = "rbAprobados"
            Me.rbAprobados.Size = New System.Drawing.Size(78, 17)
            Me.rbAprobados.TabIndex = 1
            Me.rbAprobados.Text = "Aprobados"
            Me.rbAprobados.UseVisualStyleBackColor = False
            '
            'rbEmitidos
            '
            Me.rbEmitidos.AutoSize = True
            Me.rbEmitidos.BackColor = System.Drawing.Color.Transparent
            Me.rbEmitidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbEmitidos.Location = New System.Drawing.Point(6, 3)
            Me.rbEmitidos.Name = "rbEmitidos"
            Me.rbEmitidos.Size = New System.Drawing.Size(69, 17)
            Me.rbEmitidos.TabIndex = 0
            Me.rbEmitidos.Text = "Emitidos"
            Me.rbEmitidos.UseVisualStyleBackColor = False
            '
            'txtNumeroCheque
            '
            Me.txtNumeroCheque.Location = New System.Drawing.Point(225, 20)
            Me.txtNumeroCheque.Name = "txtNumeroCheque"
            Me.txtNumeroCheque.Size = New System.Drawing.Size(80, 21)
            Me.txtNumeroCheque.TabIndex = 0
            Me.txtNumeroCheque.Text = "0"
            Me.txtNumeroCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(430, 21)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(110, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(311, 21)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(113, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnGuardar, Me.btnReporte, Me.ToolStripMenuItem1, Me.btnExportar, Me.btnReporteTodos})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(951, 32)
            Me.MenuStrip1.TabIndex = 183
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(127, 28)
            Me.btnBuscar.Text = "LISTAR TODOS"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(113, 28)
            Me.btnReporte.Text = "REPORTE A5"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(113, 28)
            Me.ToolStripMenuItem1.Text = "REPORTE A4"
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
            'btnReporteTodos
            '
            Me.btnReporteTodos.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporteTodos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporteTodos.Name = "btnReporteTodos"
            Me.btnReporteTodos.Size = New System.Drawing.Size(125, 28)
            Me.btnReporteTodos.Text = "REPORTE TOTAL"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 3)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdBeneficiario)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdComprobanteEgresoBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtBuscar)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCuentaBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumeroCheque)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbEmitidos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbFecha)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbAprobados)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbTodos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbNumeroCheque)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(921, 74)
            Me.KryptonGroupBox1.TabIndex = 184
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(763, 0)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(74, 20)
            Me.KryptonLabel5.TabIndex = 89
            Me.KryptonLabel5.Values.Text = "Beneficiario"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(546, 1)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel4.TabIndex = 88
            Me.KryptonLabel4.Values.Text = "Desde"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(430, 0)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(66, 20)
            Me.KryptonLabel3.TabIndex = 87
            Me.KryptonLabel3.Values.Text = "CA/CC/TA"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(225, 0)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel1.TabIndex = 86
            Me.KryptonLabel1.Values.Text = "Cheque"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(311, 0)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel2.TabIndex = 85
            Me.KryptonLabel2.Values.Text = "Banco"
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 32)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup
            Me.KryptonNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlGroupBox
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.KryptonNavigator1.SelectedIndex = 0
            Me.KryptonNavigator1.Size = New System.Drawing.Size(951, 538)
            Me.KryptonNavigator1.TabIndex = 185
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.txtTotalComprobantesEgreso)
            Me.KryptonPage1.Controls.Add(Me.Label2)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Controls.Add(Me.dgvComprobanteEgresoBancos)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(949, 509)
            Me.KryptonPage1.Text = "Busqueda"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "2685B76B94C8487025ABD2AF7DF1EE84"
            '
            'txtTotalComprobantesEgreso
            '
            Me.txtTotalComprobantesEgreso.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobantesEgreso.Enabled = False
            Me.txtTotalComprobantesEgreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobantesEgreso.Location = New System.Drawing.Point(821, 485)
            Me.txtTotalComprobantesEgreso.Name = "txtTotalComprobantesEgreso"
            Me.txtTotalComprobantesEgreso.ReadOnly = True
            Me.txtTotalComprobantesEgreso.Size = New System.Drawing.Size(100, 21)
            Me.txtTotalComprobantesEgreso.TabIndex = 185
            Me.txtTotalComprobantesEgreso.Text = "0.00"
            Me.txtTotalComprobantesEgreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(762, 490)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(50, 13)
            Me.Label2.TabIndex = 186
            Me.Label2.Text = "TOTAL:"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.PdfViewer1)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(949, 509)
            Me.KryptonPage2.Text = "Reporte Total"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "2039460348D1486504B11D9AE0B19389"
            '
            'PdfViewer1
            '
            Me.PdfViewer1.Location = New System.Drawing.Point(2, 3)
            Me.PdfViewer1.Name = "PdfViewer1"
            Me.PdfViewer1.Size = New System.Drawing.Size(944, 505)
            Me.PdfViewer1.TabIndex = 0
            '
            'FormBuscarComprobanteEgresoBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(951, 570)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "FormBuscarComprobanteEgresoBancos"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BUSCAR COMPROBANTE EGRESO BANCOS"
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            Me.KryptonPage1.PerformLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvComprobanteEgresoBancos As System.Windows.Forms.DataGridView
        Friend WithEvents lblIdComprobanteEgresoBanco As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents rbAprobados As System.Windows.Forms.RadioButton
        Friend WithEvents rbEmitidos As System.Windows.Forms.RadioButton
        Friend WithEvents txtNumeroCheque As System.Windows.Forms.TextBox
        Friend WithEvents rbNumeroCheque As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rbBanco As System.Windows.Forms.RadioButton
        Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblIdBeneficiario As System.Windows.Forms.Label
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents btnReporteTodos As ToolStripMenuItem
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents txtTotalComprobantesEgreso As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents PdfViewer1 As PdfiumViewer.PdfViewer
    End Class
End Namespace