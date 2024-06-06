Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAnularComprobanteEgresoBancos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnularComprobanteEgresoBancos))
            Me.dgvComprobanteEgresoBancos = New System.Windows.Forms.DataGridView()
            Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.gbBanco = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.lblIdBanco = New System.Windows.Forms.Label()
            Me.lblIdCuentaBancos = New System.Windows.Forms.Label()
            Me.gbNumeroCheque = New System.Windows.Forms.GroupBox()
            Me.txtNumeroCheque = New System.Windows.Forms.TextBox()
            Me.gbEmitidosAprobados = New System.Windows.Forms.GroupBox()
            Me.rbBanco = New System.Windows.Forms.RadioButton()
            Me.rbFecha = New System.Windows.Forms.RadioButton()
            Me.rbTodos = New System.Windows.Forms.RadioButton()
            Me.rbNumeroCheque = New System.Windows.Forms.RadioButton()
            Me.rbAprobados = New System.Windows.Forms.RadioButton()
            Me.rbEmitidos = New System.Windows.Forms.RadioButton()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblIdComprobanteEgresoBanco = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbBanco.SuspendLayout()
            Me.gbNumeroCheque.SuspendLayout()
            Me.gbEmitidosAprobados.SuspendLayout()
            Me.gbRangoFechas.SuspendLayout()
            Me.msKardex.SuspendLayout()
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
            Me.dgvComprobanteEgresoBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteEgresoBancos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteEgresoBancos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobanteEgresoBancos.Location = New System.Drawing.Point(2, 97)
            Me.dgvComprobanteEgresoBancos.Name = "dgvComprobanteEgresoBancos"
            Me.dgvComprobanteEgresoBancos.RowHeadersVisible = False
            Me.dgvComprobanteEgresoBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteEgresoBancos.Size = New System.Drawing.Size(1138, 566)
            Me.dgvComprobanteEgresoBancos.TabIndex = 113
            '
            'chk
            '
            Me.chk.HeaderText = "CHK"
            Me.chk.Name = "chk"
            Me.chk.Width = 45
            '
            'gbBanco
            '
            Me.gbBanco.BackColor = System.Drawing.Color.White
            Me.gbBanco.Controls.Add(Me.Label10)
            Me.gbBanco.Controls.Add(Me.cmbCuentaBancos)
            Me.gbBanco.Controls.Add(Me.cmbBancos)
            Me.gbBanco.Controls.Add(Me.lblIdBanco)
            Me.gbBanco.Controls.Add(Me.lblIdCuentaBancos)
            Me.gbBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBanco.Location = New System.Drawing.Point(405, 35)
            Me.gbBanco.Name = "gbBanco"
            Me.gbBanco.Size = New System.Drawing.Size(346, 60)
            Me.gbBanco.TabIndex = 121
            Me.gbBanco.TabStop = False
            Me.gbBanco.Text = "BANCO: "
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(194, 0)
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
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(197, 24)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(143, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.BackColor = System.Drawing.Color.White
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(6, 24)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(185, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'lblIdBanco
            '
            Me.lblIdBanco.AutoSize = True
            Me.lblIdBanco.Location = New System.Drawing.Point(135, 28)
            Me.lblIdBanco.Name = "lblIdBanco"
            Me.lblIdBanco.Size = New System.Drawing.Size(13, 13)
            Me.lblIdBanco.TabIndex = 27
            Me.lblIdBanco.Text = "0"
            '
            'lblIdCuentaBancos
            '
            Me.lblIdCuentaBancos.AutoSize = True
            Me.lblIdCuentaBancos.Location = New System.Drawing.Point(282, 34)
            Me.lblIdCuentaBancos.Name = "lblIdCuentaBancos"
            Me.lblIdCuentaBancos.Size = New System.Drawing.Size(13, 13)
            Me.lblIdCuentaBancos.TabIndex = 28
            Me.lblIdCuentaBancos.Text = "0"
            '
            'gbNumeroCheque
            '
            Me.gbNumeroCheque.BackColor = System.Drawing.Color.White
            Me.gbNumeroCheque.Controls.Add(Me.txtNumeroCheque)
            Me.gbNumeroCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNumeroCheque.Location = New System.Drawing.Point(311, 35)
            Me.gbNumeroCheque.Name = "gbNumeroCheque"
            Me.gbNumeroCheque.Size = New System.Drawing.Size(93, 60)
            Me.gbNumeroCheque.TabIndex = 120
            Me.gbNumeroCheque.TabStop = False
            Me.gbNumeroCheque.Text = "NÚMERO CHEQUE"
            '
            'txtNumeroCheque
            '
            Me.txtNumeroCheque.Location = New System.Drawing.Point(6, 24)
            Me.txtNumeroCheque.Name = "txtNumeroCheque"
            Me.txtNumeroCheque.Size = New System.Drawing.Size(80, 21)
            Me.txtNumeroCheque.TabIndex = 0
            Me.txtNumeroCheque.Text = "0"
            Me.txtNumeroCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
            Me.gbEmitidosAprobados.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEmitidosAprobados.Location = New System.Drawing.Point(2, 35)
            Me.gbEmitidosAprobados.Name = "gbEmitidosAprobados"
            Me.gbEmitidosAprobados.Size = New System.Drawing.Size(308, 60)
            Me.gbEmitidosAprobados.TabIndex = 119
            Me.gbEmitidosAprobados.TabStop = False
            Me.gbEmitidosAprobados.Text = "TIPO"
            '
            'rbBanco
            '
            Me.rbBanco.AutoSize = True
            Me.rbBanco.Location = New System.Drawing.Point(221, 16)
            Me.rbBanco.Name = "rbBanco"
            Me.rbBanco.Size = New System.Drawing.Size(62, 17)
            Me.rbBanco.TabIndex = 5
            Me.rbBanco.Text = "BANCO"
            Me.rbBanco.UseVisualStyleBackColor = True
            '
            'rbFecha
            '
            Me.rbFecha.AutoSize = True
            Me.rbFecha.Checked = True
            Me.rbFecha.Location = New System.Drawing.Point(124, 16)
            Me.rbFecha.Name = "rbFecha"
            Me.rbFecha.Size = New System.Drawing.Size(59, 17)
            Me.rbFecha.TabIndex = 4
            Me.rbFecha.TabStop = True
            Me.rbFecha.Text = "FECHA"
            Me.rbFecha.UseVisualStyleBackColor = True
            '
            'rbTodos
            '
            Me.rbTodos.AutoSize = True
            Me.rbTodos.Location = New System.Drawing.Point(221, 34)
            Me.rbTodos.Name = "rbTodos"
            Me.rbTodos.Size = New System.Drawing.Size(62, 17)
            Me.rbTodos.TabIndex = 3
            Me.rbTodos.Text = "TODOS"
            Me.rbTodos.UseVisualStyleBackColor = True
            '
            'rbNumeroCheque
            '
            Me.rbNumeroCheque.AutoSize = True
            Me.rbNumeroCheque.Location = New System.Drawing.Point(124, 34)
            Me.rbNumeroCheque.Name = "rbNumeroCheque"
            Me.rbNumeroCheque.Size = New System.Drawing.Size(67, 17)
            Me.rbNumeroCheque.TabIndex = 2
            Me.rbNumeroCheque.Text = "CHEQUE"
            Me.rbNumeroCheque.UseVisualStyleBackColor = True
            '
            'rbAprobados
            '
            Me.rbAprobados.AutoSize = True
            Me.rbAprobados.Location = New System.Drawing.Point(23, 34)
            Me.rbAprobados.Name = "rbAprobados"
            Me.rbAprobados.Size = New System.Drawing.Size(90, 17)
            Me.rbAprobados.TabIndex = 1
            Me.rbAprobados.Text = "APROBADOS"
            Me.rbAprobados.UseVisualStyleBackColor = True
            '
            'rbEmitidos
            '
            Me.rbEmitidos.AutoSize = True
            Me.rbEmitidos.Location = New System.Drawing.Point(23, 16)
            Me.rbEmitidos.Name = "rbEmitidos"
            Me.rbEmitidos.Size = New System.Drawing.Size(76, 17)
            Me.rbEmitidos.TabIndex = 0
            Me.rbEmitidos.Text = "EMITIDOS"
            Me.rbEmitidos.UseVisualStyleBackColor = True
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.Label3)
            Me.gbRangoFechas.Controls.Add(Me.lblIdComprobanteEgresoBanco)
            Me.gbRangoFechas.Controls.Add(Me.Label1)
            Me.gbRangoFechas.Controls.Add(Me.dtpHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpDesde)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(752, 35)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(389, 60)
            Me.gbRangoFechas.TabIndex = 118
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(3, 27)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(38, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Desde"
            '
            'lblIdComprobanteEgresoBanco
            '
            Me.lblIdComprobanteEgresoBanco.AutoSize = True
            Me.lblIdComprobanteEgresoBanco.Location = New System.Drawing.Point(253, 0)
            Me.lblIdComprobanteEgresoBanco.Name = "lblIdComprobanteEgresoBanco"
            Me.lblIdComprobanteEgresoBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteEgresoBanco.TabIndex = 3
            Me.lblIdComprobanteEgresoBanco.Text = "..."
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(196, 27)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(37, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Hasta"
            '
            'dtpHasta
            '
            Me.dtpHasta.CustomFormat = "dd/MMMM/yyyy"
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpHasta.Location = New System.Drawing.Point(235, 24)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(147, 21)
            Me.dtpHasta.TabIndex = 1
            '
            'dtpDesde
            '
            Me.dtpDesde.CustomFormat = "dd/MMMM/yyyy"
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDesde.Location = New System.Drawing.Point(42, 24)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(146, 21)
            Me.dtpDesde.TabIndex = 0
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnGuardar})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(1143, 32)
            Me.msKardex.TabIndex = 186
            Me.msKardex.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(92, 28)
            Me.btnBuscar.Text = "BUSCAR "
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.playlist_remove_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(85, 28)
            Me.btnGuardar.Text = "ANULAR"
            '
            'FormAnularComprobanteEgresoBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1143, 665)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.gbBanco)
            Me.Controls.Add(Me.gbNumeroCheque)
            Me.Controls.Add(Me.gbEmitidosAprobados)
            Me.Controls.Add(Me.gbRangoFechas)
            Me.Controls.Add(Me.dgvComprobanteEgresoBancos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAnularComprobanteEgresoBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ANULAR COMPROBANTE EGRESO BANCO"
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbBanco.ResumeLayout(False)
            Me.gbBanco.PerformLayout()
            Me.gbNumeroCheque.ResumeLayout(False)
            Me.gbNumeroCheque.PerformLayout()
            Me.gbEmitidosAprobados.ResumeLayout(False)
            Me.gbEmitidosAprobados.PerformLayout()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvComprobanteEgresoBancos As System.Windows.Forms.DataGridView
        Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents gbBanco As System.Windows.Forms.GroupBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents lblIdBanco As System.Windows.Forms.Label
        Friend WithEvents lblIdCuentaBancos As System.Windows.Forms.Label
        Friend WithEvents gbNumeroCheque As System.Windows.Forms.GroupBox
        Friend WithEvents txtNumeroCheque As System.Windows.Forms.TextBox
        Friend WithEvents gbEmitidosAprobados As System.Windows.Forms.GroupBox
        Friend WithEvents rbBanco As System.Windows.Forms.RadioButton
        Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rbNumeroCheque As System.Windows.Forms.RadioButton
        Friend WithEvents rbAprobados As System.Windows.Forms.RadioButton
        Friend WithEvents rbEmitidos As System.Windows.Forms.RadioButton
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteEgresoBanco As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace