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
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rbConsorcio = New System.Windows.Forms.RadioButton()
            Me.rbCliente = New System.Windows.Forms.RadioButton()
            Me.rbBanco = New System.Windows.Forms.RadioButton()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.lblIdComprobanteIngresoBanco = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.gbTotal = New System.Windows.Forms.GroupBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.gbBanco = New System.Windows.Forms.GroupBox()
            Me.gbClienteGeneral = New System.Windows.Forms.GroupBox()
            Me.txtNombreComercialClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.dgvCliente = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.gbRangoFechas.SuspendLayout()
            Me.gbTotal.SuspendLayout()
            Me.gbBanco.SuspendLayout()
            Me.gbClienteGeneral.SuspendLayout()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'rbFecha
            '
            Me.rbFecha.AutoSize = True
            Me.rbFecha.Checked = True
            Me.rbFecha.Location = New System.Drawing.Point(8, 15)
            Me.rbFecha.Name = "rbFecha"
            Me.rbFecha.Size = New System.Drawing.Size(55, 17)
            Me.rbFecha.TabIndex = 20
            Me.rbFecha.TabStop = True
            Me.rbFecha.Text = "Fecha"
            Me.rbFecha.UseVisualStyleBackColor = True
            '
            'rbTodo
            '
            Me.rbTodo.AutoSize = True
            Me.rbTodo.Location = New System.Drawing.Point(82, 31)
            Me.rbTodo.Name = "rbTodo"
            Me.rbTodo.Size = New System.Drawing.Size(49, 17)
            Me.rbTodo.TabIndex = 19
            Me.rbTodo.Text = "Todo"
            Me.rbTodo.UseVisualStyleBackColor = True
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
            Me.dgvComprobanteEgresoBancos.Location = New System.Drawing.Point(1, 103)
            Me.dgvComprobanteEgresoBancos.MultiSelect = False
            Me.dgvComprobanteEgresoBancos.Name = "dgvComprobanteEgresoBancos"
            Me.dgvComprobanteEgresoBancos.ReadOnly = True
            Me.dgvComprobanteEgresoBancos.RowHeadersVisible = False
            Me.dgvComprobanteEgresoBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteEgresoBancos.Size = New System.Drawing.Size(1162, 552)
            Me.dgvComprobanteEgresoBancos.TabIndex = 107
            '
            'txtTotalComprobantesIngreso
            '
            Me.txtTotalComprobantesIngreso.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobantesIngreso.Enabled = False
            Me.txtTotalComprobantesIngreso.Location = New System.Drawing.Point(1051, 15)
            Me.txtTotalComprobantesIngreso.Name = "txtTotalComprobantesIngreso"
            Me.txtTotalComprobantesIngreso.ReadOnly = True
            Me.txtTotalComprobantesIngreso.Size = New System.Drawing.Size(100, 20)
            Me.txtTotalComprobantesIngreso.TabIndex = 110
            Me.txtTotalComprobantesIngreso.Text = "0.00"
            Me.txtTotalComprobantesIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(1002, 18)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(43, 13)
            Me.Label2.TabIndex = 111
            Me.Label2.Text = "TOTAL:"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.rbConsorcio)
            Me.GroupBox1.Controls.Add(Me.rbCliente)
            Me.GroupBox1.Controls.Add(Me.rbBanco)
            Me.GroupBox1.Controls.Add(Me.rbFecha)
            Me.GroupBox1.Controls.Add(Me.rbTodo)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(1, 36)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(228, 60)
            Me.GroupBox1.TabIndex = 112
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "TIPO BUSQUEDA:"
            '
            'rbConsorcio
            '
            Me.rbConsorcio.AutoSize = True
            Me.rbConsorcio.Location = New System.Drawing.Point(82, 15)
            Me.rbConsorcio.Name = "rbConsorcio"
            Me.rbConsorcio.Size = New System.Drawing.Size(55, 17)
            Me.rbConsorcio.TabIndex = 23
            Me.rbConsorcio.Text = "Grupo"
            Me.rbConsorcio.UseVisualStyleBackColor = True
            '
            'rbCliente
            '
            Me.rbCliente.AutoSize = True
            Me.rbCliente.Location = New System.Drawing.Point(157, 15)
            Me.rbCliente.Name = "rbCliente"
            Me.rbCliente.Size = New System.Drawing.Size(60, 17)
            Me.rbCliente.TabIndex = 22
            Me.rbCliente.Text = "Cliente"
            Me.rbCliente.UseVisualStyleBackColor = True
            '
            'rbBanco
            '
            Me.rbBanco.AutoSize = True
            Me.rbBanco.Location = New System.Drawing.Point(8, 31)
            Me.rbBanco.Name = "rbBanco"
            Me.rbBanco.Size = New System.Drawing.Size(56, 17)
            Me.rbBanco.TabIndex = 21
            Me.rbBanco.Text = "Banco"
            Me.rbBanco.UseVisualStyleBackColor = True
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.lblIdComprobanteIngresoBanco)
            Me.gbRangoFechas.Controls.Add(Me.Label1)
            Me.gbRangoFechas.Controls.Add(Me.dtpHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpDesde)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(941, 36)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(222, 60)
            Me.gbRangoFechas.TabIndex = 113
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'lblIdComprobanteIngresoBanco
            '
            Me.lblIdComprobanteIngresoBanco.AutoSize = True
            Me.lblIdComprobanteIngresoBanco.Location = New System.Drawing.Point(191, 0)
            Me.lblIdComprobanteIngresoBanco.Name = "lblIdComprobanteIngresoBanco"
            Me.lblIdComprobanteIngresoBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteIngresoBanco.TabIndex = 3
            Me.lblIdComprobanteIngresoBanco.Text = "..."
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(105, 31)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(13, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "a"
            '
            'dtpHasta
            '
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(118, 28)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(98, 21)
            Me.dtpHasta.TabIndex = 1
            '
            'dtpDesde
            '
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(8, 28)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(97, 21)
            Me.dtpDesde.TabIndex = 0
            '
            'gbTotal
            '
            Me.gbTotal.BackColor = System.Drawing.Color.White
            Me.gbTotal.Controls.Add(Me.txtTotalComprobantesIngreso)
            Me.gbTotal.Controls.Add(Me.Label2)
            Me.gbTotal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotal.Location = New System.Drawing.Point(1, 644)
            Me.gbTotal.Name = "gbTotal"
            Me.gbTotal.Size = New System.Drawing.Size(1163, 41)
            Me.gbTotal.TabIndex = 114
            Me.gbTotal.TabStop = False
            '
            'cmbBancos
            '
            Me.cmbBancos.BackColor = System.Drawing.Color.White
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(9, 29)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(129, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(148, 29)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(110, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(148, 0)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(62, 13)
            Me.Label10.TabIndex = 34
            Me.Label10.Text = "CA/CC/TA:"
            '
            'gbBanco
            '
            Me.gbBanco.BackColor = System.Drawing.Color.White
            Me.gbBanco.Controls.Add(Me.Label10)
            Me.gbBanco.Controls.Add(Me.cmbCuentaBancos)
            Me.gbBanco.Controls.Add(Me.cmbBancos)
            Me.gbBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBanco.Location = New System.Drawing.Point(674, 36)
            Me.gbBanco.Name = "gbBanco"
            Me.gbBanco.Size = New System.Drawing.Size(267, 60)
            Me.gbBanco.TabIndex = 116
            Me.gbBanco.TabStop = False
            Me.gbBanco.Text = "BANCO: "
            '
            'gbClienteGeneral
            '
            Me.gbClienteGeneral.BackColor = System.Drawing.Color.White
            Me.gbClienteGeneral.Controls.Add(Me.txtNombreComercialClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.lblIdClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.dgvCliente)
            Me.gbClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbClienteGeneral.Location = New System.Drawing.Point(229, 36)
            Me.gbClienteGeneral.Name = "gbClienteGeneral"
            Me.gbClienteGeneral.Size = New System.Drawing.Size(445, 60)
            Me.gbClienteGeneral.TabIndex = 117
            Me.gbClienteGeneral.TabStop = False
            Me.gbClienteGeneral.Text = "CLIENTE"
            '
            'txtNombreComercialClienteGeneral
            '
            Me.txtNombreComercialClienteGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialClienteGeneral.Location = New System.Drawing.Point(6, 28)
            Me.txtNombreComercialClienteGeneral.Name = "txtNombreComercialClienteGeneral"
            Me.txtNombreComercialClienteGeneral.Size = New System.Drawing.Size(433, 20)
            Me.txtNombreComercialClienteGeneral.TabIndex = 2
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(56, 0)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdClienteGeneral.TabIndex = 76
            Me.lblIdClienteGeneral.Text = "..."
            '
            'dgvCliente
            '
            Me.dgvCliente.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCliente.Location = New System.Drawing.Point(50, 28)
            Me.dgvCliente.Name = "dgvCliente"
            Me.dgvCliente.Size = New System.Drawing.Size(233, 20)
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
            Me.MenuStrip1.Size = New System.Drawing.Size(1164, 32)
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
            'FormBuscarComprobanteIngresoBaNcos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1164, 688)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvComprobanteEgresoBancos)
            Me.Controls.Add(Me.gbClienteGeneral)
            Me.Controls.Add(Me.gbBanco)
            Me.Controls.Add(Me.gbTotal)
            Me.Controls.Add(Me.gbRangoFechas)
            Me.Controls.Add(Me.GroupBox1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormBuscarComprobanteIngresoBaNcos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BUSCAR COMPROBANTES DE INGRESO"
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.gbTotal.ResumeLayout(False)
            Me.gbTotal.PerformLayout()
            Me.gbBanco.ResumeLayout(False)
            Me.gbBanco.PerformLayout()
            Me.gbClienteGeneral.ResumeLayout(False)
            Me.gbClienteGeneral.PerformLayout()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvComprobanteEgresoBancos As System.Windows.Forms.DataGridView
        Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodo As System.Windows.Forms.RadioButton
        Friend WithEvents txtTotalComprobantesIngreso As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdComprobanteIngresoBanco As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbTotal As System.Windows.Forms.GroupBox
        Friend WithEvents rbBanco As System.Windows.Forms.RadioButton
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents gbBanco As System.Windows.Forms.GroupBox
        Friend WithEvents rbCliente As System.Windows.Forms.RadioButton
        Friend WithEvents gbClienteGeneral As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombreComercialClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
        Friend WithEvents rbConsorcio As System.Windows.Forms.RadioButton
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace