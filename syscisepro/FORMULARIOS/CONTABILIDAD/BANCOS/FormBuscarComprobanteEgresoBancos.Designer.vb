Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBuscarComprobanteEgresoBancos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarComprobanteEgresoBancos))
            Me.dgvComprobanteEgresoBancos = New System.Windows.Forms.DataGridView()
            Me.gbComandos = New System.Windows.Forms.GroupBox()
            Me.lblIdBeneficiario = New System.Windows.Forms.Label()
            Me.txtBuscar = New System.Windows.Forms.TextBox()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblIdComprobanteEgresoBanco = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.gbEmitidosAprobados = New System.Windows.Forms.GroupBox()
            Me.rbBanco = New System.Windows.Forms.RadioButton()
            Me.rbFecha = New System.Windows.Forms.RadioButton()
            Me.rbTodos = New System.Windows.Forms.RadioButton()
            Me.rbNumeroCheque = New System.Windows.Forms.RadioButton()
            Me.rbAprobados = New System.Windows.Forms.RadioButton()
            Me.rbEmitidos = New System.Windows.Forms.RadioButton()
            Me.gbNumeroCheque = New System.Windows.Forms.GroupBox()
            Me.txtNumeroCheque = New System.Windows.Forms.TextBox()
            Me.gbTotal = New System.Windows.Forms.GroupBox()
            Me.txtTotalComprobantesEgreso = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.gbBanco = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbComandos.SuspendLayout()
            Me.gbRangoFechas.SuspendLayout()
            Me.gbEmitidosAprobados.SuspendLayout()
            Me.gbNumeroCheque.SuspendLayout()
            Me.gbTotal.SuspendLayout()
            Me.gbBanco.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvComprobanteEgresoBancos
            '
            Me.dgvComprobanteEgresoBancos.AllowUserToAddRows = False
            Me.dgvComprobanteEgresoBancos.AllowUserToDeleteRows = False
            Me.dgvComprobanteEgresoBancos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobanteEgresoBancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvComprobanteEgresoBancos.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobanteEgresoBancos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteEgresoBancos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobanteEgresoBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteEgresoBancos.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvComprobanteEgresoBancos.Location = New System.Drawing.Point(12, 86)
            Me.dgvComprobanteEgresoBancos.MultiSelect = False
            Me.dgvComprobanteEgresoBancos.Name = "dgvComprobanteEgresoBancos"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteEgresoBancos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvComprobanteEgresoBancos.RowHeadersVisible = False
            Me.dgvComprobanteEgresoBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteEgresoBancos.Size = New System.Drawing.Size(1181, 482)
            Me.dgvComprobanteEgresoBancos.TabIndex = 18
            '
            'gbComandos
            '
            Me.gbComandos.BackColor = System.Drawing.Color.White
            Me.gbComandos.Controls.Add(Me.lblIdBeneficiario)
            Me.gbComandos.Controls.Add(Me.txtBuscar)
            Me.gbComandos.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComandos.Location = New System.Drawing.Point(934, 27)
            Me.gbComandos.Name = "gbComandos"
            Me.gbComandos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.gbComandos.Size = New System.Drawing.Size(259, 53)
            Me.gbComandos.TabIndex = 45
            Me.gbComandos.TabStop = False
            Me.gbComandos.Text = "BUSCAR BENEFICIARIO"
            '
            'lblIdBeneficiario
            '
            Me.lblIdBeneficiario.AutoSize = True
            Me.lblIdBeneficiario.Location = New System.Drawing.Point(75, 0)
            Me.lblIdBeneficiario.Name = "lblIdBeneficiario"
            Me.lblIdBeneficiario.Size = New System.Drawing.Size(25, 13)
            Me.lblIdBeneficiario.TabIndex = 4
            Me.lblIdBeneficiario.Text = "..."
            '
            'txtBuscar
            '
            Me.txtBuscar.BackColor = System.Drawing.Color.White
            Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBuscar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBuscar.Location = New System.Drawing.Point(6, 18)
            Me.txtBuscar.Name = "txtBuscar"
            Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtBuscar.Size = New System.Drawing.Size(247, 23)
            Me.txtBuscar.TabIndex = 1
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.Label3)
            Me.gbRangoFechas.Controls.Add(Me.lblIdComprobanteEgresoBanco)
            Me.gbRangoFechas.Controls.Add(Me.Label1)
            Me.gbRangoFechas.Controls.Add(Me.dtpHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpDesde)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(642, 27)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(286, 53)
            Me.gbRangoFechas.TabIndex = 105
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(3, 22)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(37, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Desde"
            '
            'lblIdComprobanteEgresoBanco
            '
            Me.lblIdComprobanteEgresoBanco.AutoSize = True
            Me.lblIdComprobanteEgresoBanco.Location = New System.Drawing.Point(253, 0)
            Me.lblIdComprobanteEgresoBanco.Name = "lblIdComprobanteEgresoBanco"
            Me.lblIdComprobanteEgresoBanco.Size = New System.Drawing.Size(25, 13)
            Me.lblIdComprobanteEgresoBanco.TabIndex = 3
            Me.lblIdComprobanteEgresoBanco.Text = "..."
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(141, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(37, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Hasta"
            '
            'dtpHasta
            '
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(180, 19)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(98, 20)
            Me.dtpHasta.TabIndex = 1
            '
            'dtpDesde
            '
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(42, 19)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(97, 20)
            Me.dtpDesde.TabIndex = 0
            '
            'gbEmitidosAprobados
            '
            Me.gbEmitidosAprobados.BackColor = System.Drawing.Color.White
            Me.gbEmitidosAprobados.Controls.Add(Me.rbBanco)
            Me.gbEmitidosAprobados.Controls.Add(Me.rbFecha)
            Me.gbEmitidosAprobados.Controls.Add(Me.rbTodos)
            Me.gbEmitidosAprobados.Controls.Add(Me.rbNumeroCheque)
            Me.gbEmitidosAprobados.Controls.Add(Me.rbAprobados)
            Me.gbEmitidosAprobados.Controls.Add(Me.rbEmitidos)
            Me.gbEmitidosAprobados.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEmitidosAprobados.Location = New System.Drawing.Point(1, 27)
            Me.gbEmitidosAprobados.Name = "gbEmitidosAprobados"
            Me.gbEmitidosAprobados.Size = New System.Drawing.Size(227, 53)
            Me.gbEmitidosAprobados.TabIndex = 106
            Me.gbEmitidosAprobados.TabStop = False
            Me.gbEmitidosAprobados.Text = "TIPO"
            '
            'rbBanco
            '
            Me.rbBanco.AutoSize = True
            Me.rbBanco.Location = New System.Drawing.Point(90, 28)
            Me.rbBanco.Name = "rbBanco"
            Me.rbBanco.Size = New System.Drawing.Size(55, 17)
            Me.rbBanco.TabIndex = 5
            Me.rbBanco.Text = "BANCO"
            Me.rbBanco.UseVisualStyleBackColor = True
            '
            'rbFecha
            '
            Me.rbFecha.AutoSize = True
            Me.rbFecha.Checked = True
            Me.rbFecha.Location = New System.Drawing.Point(90, 13)
            Me.rbFecha.Name = "rbFecha"
            Me.rbFecha.Size = New System.Drawing.Size(55, 17)
            Me.rbFecha.TabIndex = 4
            Me.rbFecha.TabStop = True
            Me.rbFecha.Text = "FECHA"
            Me.rbFecha.UseVisualStyleBackColor = True
            '
            'rbTodos
            '
            Me.rbTodos.AutoSize = True
            Me.rbTodos.Location = New System.Drawing.Point(160, 28)
            Me.rbTodos.Name = "rbTodos"
            Me.rbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rbTodos.TabIndex = 3
            Me.rbTodos.Text = "TODOS"
            Me.rbTodos.UseVisualStyleBackColor = True
            '
            'rbNumeroCheque
            '
            Me.rbNumeroCheque.AutoSize = True
            Me.rbNumeroCheque.Location = New System.Drawing.Point(160, 13)
            Me.rbNumeroCheque.Name = "rbNumeroCheque"
            Me.rbNumeroCheque.Size = New System.Drawing.Size(61, 17)
            Me.rbNumeroCheque.TabIndex = 2
            Me.rbNumeroCheque.Text = "CHEQUE"
            Me.rbNumeroCheque.UseVisualStyleBackColor = True
            '
            'rbAprobados
            '
            Me.rbAprobados.AutoSize = True
            Me.rbAprobados.Location = New System.Drawing.Point(8, 28)
            Me.rbAprobados.Name = "rbAprobados"
            Me.rbAprobados.Size = New System.Drawing.Size(79, 17)
            Me.rbAprobados.TabIndex = 1
            Me.rbAprobados.Text = "APROBADOS"
            Me.rbAprobados.UseVisualStyleBackColor = True
            '
            'rbEmitidos
            '
            Me.rbEmitidos.AutoSize = True
            Me.rbEmitidos.Location = New System.Drawing.Point(8, 13)
            Me.rbEmitidos.Name = "rbEmitidos"
            Me.rbEmitidos.Size = New System.Drawing.Size(73, 17)
            Me.rbEmitidos.TabIndex = 0
            Me.rbEmitidos.Text = "EMITIDOS"
            Me.rbEmitidos.UseVisualStyleBackColor = True
            '
            'gbNumeroCheque
            '
            Me.gbNumeroCheque.BackColor = System.Drawing.Color.White
            Me.gbNumeroCheque.Controls.Add(Me.txtNumeroCheque)
            Me.gbNumeroCheque.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNumeroCheque.Location = New System.Drawing.Point(234, 27)
            Me.gbNumeroCheque.Name = "gbNumeroCheque"
            Me.gbNumeroCheque.Size = New System.Drawing.Size(100, 53)
            Me.gbNumeroCheque.TabIndex = 107
            Me.gbNumeroCheque.TabStop = False
            Me.gbNumeroCheque.Text = "NÚMERO CHEQUE"
            '
            'txtNumeroCheque
            '
            Me.txtNumeroCheque.Location = New System.Drawing.Point(10, 19)
            Me.txtNumeroCheque.Name = "txtNumeroCheque"
            Me.txtNumeroCheque.Size = New System.Drawing.Size(80, 20)
            Me.txtNumeroCheque.TabIndex = 0
            Me.txtNumeroCheque.Text = "0"
            Me.txtNumeroCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'gbTotal
            '
            Me.gbTotal.BackColor = System.Drawing.Color.White
            Me.gbTotal.Controls.Add(Me.txtTotalComprobantesEgreso)
            Me.gbTotal.Controls.Add(Me.Label2)
            Me.gbTotal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotal.Location = New System.Drawing.Point(12, 574)
            Me.gbTotal.Name = "gbTotal"
            Me.gbTotal.Size = New System.Drawing.Size(1189, 35)
            Me.gbTotal.TabIndex = 115
            Me.gbTotal.TabStop = False
            '
            'txtTotalComprobantesEgreso
            '
            Me.txtTotalComprobantesEgreso.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobantesEgreso.Enabled = False
            Me.txtTotalComprobantesEgreso.Location = New System.Drawing.Point(1078, 14)
            Me.txtTotalComprobantesEgreso.Name = "txtTotalComprobantesEgreso"
            Me.txtTotalComprobantesEgreso.ReadOnly = True
            Me.txtTotalComprobantesEgreso.Size = New System.Drawing.Size(100, 20)
            Me.txtTotalComprobantesEgreso.TabIndex = 110
            Me.txtTotalComprobantesEgreso.Text = "0.00"
            Me.txtTotalComprobantesEgreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(1016, 17)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(43, 13)
            Me.Label2.TabIndex = 111
            Me.Label2.Text = "TOTAL:"
            '
            'gbBanco
            '
            Me.gbBanco.BackColor = System.Drawing.Color.White
            Me.gbBanco.Controls.Add(Me.Label10)
            Me.gbBanco.Controls.Add(Me.cmbCuentaBancos)
            Me.gbBanco.Controls.Add(Me.cmbBancos)
            Me.gbBanco.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBanco.Location = New System.Drawing.Point(340, 27)
            Me.gbBanco.Name = "gbBanco"
            Me.gbBanco.Size = New System.Drawing.Size(296, 53)
            Me.gbBanco.TabIndex = 117
            Me.gbBanco.TabStop = False
            Me.gbBanco.Text = "BANCO: "
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(175, 0)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(61, 13)
            Me.Label10.TabIndex = 34
            Me.Label10.Text = "CA/CC/TA:"
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(163, 19)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(127, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(6, 19)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(148, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnGuardar, Me.btnReporte, Me.ToolStripMenuItem1, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1201, 24)
            Me.MenuStrip1.TabIndex = 183
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(119, 20)
            Me.btnBuscar.Text = "LISTAR TODOS"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(84, 20)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.report
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(105, 20)
            Me.btnReporte.Text = "REPORTE A5"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.report
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(105, 20)
            Me.ToolStripMenuItem1.Text = "REPORTE A4"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(91, 20)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'FormBuscarComprobanteEgresoBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1201, 619)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvComprobanteEgresoBancos)
            Me.Controls.Add(Me.gbBanco)
            Me.Controls.Add(Me.gbTotal)
            Me.Controls.Add(Me.gbNumeroCheque)
            Me.Controls.Add(Me.gbEmitidosAprobados)
            Me.Controls.Add(Me.gbRangoFechas)
            Me.Controls.Add(Me.gbComandos)
            Me.Name = "FormBuscarComprobanteEgresoBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "BUSCAR COMPROBANTE EGRESO BANCOS"
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbComandos.ResumeLayout(False)
            Me.gbComandos.PerformLayout()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.gbEmitidosAprobados.ResumeLayout(False)
            Me.gbEmitidosAprobados.PerformLayout()
            Me.gbNumeroCheque.ResumeLayout(False)
            Me.gbNumeroCheque.PerformLayout()
            Me.gbTotal.ResumeLayout(False)
            Me.gbTotal.PerformLayout()
            Me.gbBanco.ResumeLayout(False)
            Me.gbBanco.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvComprobanteEgresoBancos As System.Windows.Forms.DataGridView
        Friend WithEvents gbComandos As System.Windows.Forms.GroupBox
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdComprobanteEgresoBanco As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents gbEmitidosAprobados As System.Windows.Forms.GroupBox
        Friend WithEvents rbAprobados As System.Windows.Forms.RadioButton
        Friend WithEvents rbEmitidos As System.Windows.Forms.RadioButton
        Friend WithEvents gbNumeroCheque As System.Windows.Forms.GroupBox
        Friend WithEvents txtNumeroCheque As System.Windows.Forms.TextBox
        Friend WithEvents rbNumeroCheque As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rbBanco As System.Windows.Forms.RadioButton
        Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
        Friend WithEvents gbTotal As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalComprobantesEgreso As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents gbBanco As System.Windows.Forms.GroupBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
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
    End Class
End Namespace