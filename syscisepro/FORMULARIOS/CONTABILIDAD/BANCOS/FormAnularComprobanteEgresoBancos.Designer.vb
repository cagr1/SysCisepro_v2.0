Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormAnularComprobanteEgresoBancos
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnularComprobanteEgresoBancos))
            Me.dgvComprobanteEgresoBancos = New System.Windows.Forms.DataGridView()
            Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.lblIdBanco = New System.Windows.Forms.Label()
            Me.lblIdCuentaBancos = New System.Windows.Forms.Label()
            Me.txtNumeroCheque = New System.Windows.Forms.TextBox()
            Me.rbBanco = New System.Windows.Forms.RadioButton()
            Me.rbFecha = New System.Windows.Forms.RadioButton()
            Me.rbTodos = New System.Windows.Forms.RadioButton()
            Me.rbNumeroCheque = New System.Windows.Forms.RadioButton()
            Me.rbAprobados = New System.Windows.Forms.RadioButton()
            Me.rbEmitidos = New System.Windows.Forms.RadioButton()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblIdComprobanteEgresoBanco = New System.Windows.Forms.Label()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvComprobanteEgresoBancos
            '
            Me.dgvComprobanteEgresoBancos.AllowUserToAddRows = False
            Me.dgvComprobanteEgresoBancos.AllowUserToDeleteRows = False
            Me.dgvComprobanteEgresoBancos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobanteEgresoBancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvComprobanteEgresoBancos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.dgvComprobanteEgresoBancos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobanteEgresoBancos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobanteEgresoBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteEgresoBancos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteEgresoBancos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobanteEgresoBancos.Location = New System.Drawing.Point(2, 116)
            Me.dgvComprobanteEgresoBancos.Name = "dgvComprobanteEgresoBancos"
            Me.dgvComprobanteEgresoBancos.RowHeadersVisible = False
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobanteEgresoBancos.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvComprobanteEgresoBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteEgresoBancos.Size = New System.Drawing.Size(881, 400)
            Me.dgvComprobanteEgresoBancos.TabIndex = 113
            '
            'chk
            '
            Me.chk.HeaderText = "CHK"
            Me.chk.Name = "chk"
            Me.chk.Width = 45
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentaBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(477, 26)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(103, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.BackColor = System.Drawing.Color.White
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(339, 26)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(123, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'lblIdBanco
            '
            Me.lblIdBanco.AutoSize = True
            Me.lblIdBanco.BackColor = System.Drawing.Color.Transparent
            Me.lblIdBanco.Location = New System.Drawing.Point(433, 10)
            Me.lblIdBanco.Name = "lblIdBanco"
            Me.lblIdBanco.Size = New System.Drawing.Size(13, 13)
            Me.lblIdBanco.TabIndex = 27
            Me.lblIdBanco.Text = "0"
            Me.lblIdBanco.Visible = False
            '
            'lblIdCuentaBancos
            '
            Me.lblIdCuentaBancos.AutoSize = True
            Me.lblIdCuentaBancos.BackColor = System.Drawing.Color.Transparent
            Me.lblIdCuentaBancos.Location = New System.Drawing.Point(567, 10)
            Me.lblIdCuentaBancos.Name = "lblIdCuentaBancos"
            Me.lblIdCuentaBancos.Size = New System.Drawing.Size(13, 13)
            Me.lblIdCuentaBancos.TabIndex = 28
            Me.lblIdCuentaBancos.Text = "0"
            Me.lblIdCuentaBancos.Visible = False
            '
            'txtNumeroCheque
            '
            Me.txtNumeroCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroCheque.Location = New System.Drawing.Point(242, 27)
            Me.txtNumeroCheque.Name = "txtNumeroCheque"
            Me.txtNumeroCheque.Size = New System.Drawing.Size(80, 21)
            Me.txtNumeroCheque.TabIndex = 0
            Me.txtNumeroCheque.Text = "0"
            Me.txtNumeroCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'rbBanco
            '
            Me.rbBanco.AutoSize = True
            Me.rbBanco.BackColor = System.Drawing.Color.Transparent
            Me.rbBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbBanco.Location = New System.Drawing.Point(165, 13)
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
            Me.rbFecha.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbFecha.Location = New System.Drawing.Point(92, 13)
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
            Me.rbTodos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTodos.Location = New System.Drawing.Point(164, 31)
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
            Me.rbNumeroCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNumeroCheque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbNumeroCheque.Location = New System.Drawing.Point(92, 31)
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
            Me.rbAprobados.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbAprobados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbAprobados.Location = New System.Drawing.Point(6, 31)
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
            Me.rbEmitidos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbEmitidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbEmitidos.Location = New System.Drawing.Point(6, 13)
            Me.rbEmitidos.Name = "rbEmitidos"
            Me.rbEmitidos.Size = New System.Drawing.Size(69, 17)
            Me.rbEmitidos.TabIndex = 0
            Me.rbEmitidos.Text = "Emitidos"
            Me.rbEmitidos.UseVisualStyleBackColor = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(597, 10)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(38, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Desde"
            '
            'lblIdComprobanteEgresoBanco
            '
            Me.lblIdComprobanteEgresoBanco.AutoSize = True
            Me.lblIdComprobanteEgresoBanco.BackColor = System.Drawing.Color.Transparent
            Me.lblIdComprobanteEgresoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteEgresoBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteEgresoBanco.Location = New System.Drawing.Point(797, 7)
            Me.lblIdComprobanteEgresoBanco.Name = "lblIdComprobanteEgresoBanco"
            Me.lblIdComprobanteEgresoBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteEgresoBanco.TabIndex = 3
            Me.lblIdComprobanteEgresoBanco.Text = "..."
            '
            'dtpHasta
            '
            Me.dtpHasta.CustomFormat = "dd/MMMM/yyyy"
            Me.dtpHasta.Enabled = False
            Me.dtpHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(720, 26)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(104, 21)
            Me.dtpHasta.TabIndex = 1
            '
            'dtpDesde
            '
            Me.dtpDesde.CustomFormat = "dd/MMMM/yyyy"
            Me.dtpDesde.Enabled = False
            Me.dtpDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(600, 26)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(96, 21)
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
            Me.msKardex.Size = New System.Drawing.Size(884, 32)
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
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0.85R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderDockInactive
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(2, 31)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdComprobanteEgresoBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.Label2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.Label3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdCuentaBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCuentaBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumeroCheque)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbEmitidos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbFecha)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbAprobados)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbTodos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbNumeroCheque)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(881, 79)
            Me.KryptonGroupBox1.TabIndex = 187
            Me.KryptonGroupBox1.Values.Heading = "Tipo"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(717, 10)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(37, 13)
            Me.Label2.TabIndex = 31
            Me.Label2.Text = "Hasta"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(477, 3)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(66, 20)
            Me.KryptonLabel3.TabIndex = 30
            Me.KryptonLabel3.Values.Text = "CA/CC/TA"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(339, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel2.TabIndex = 26
            Me.KryptonLabel2.Values.Text = "Banco"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(244, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(72, 20)
            Me.KryptonLabel1.TabIndex = 6
            Me.KryptonLabel1.Values.Text = "No Cheque"
            '
            'FormAnularComprobanteEgresoBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(884, 518)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.dgvComprobanteEgresoBancos)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAnularComprobanteEgresoBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ANULAR COMPROBANTE EGRESO BANCO"
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvComprobanteEgresoBancos As System.Windows.Forms.DataGridView
        Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents lblIdBanco As System.Windows.Forms.Label
        Friend WithEvents lblIdCuentaBancos As System.Windows.Forms.Label
        Friend WithEvents txtNumeroCheque As System.Windows.Forms.TextBox
        Friend WithEvents rbBanco As System.Windows.Forms.RadioButton
        Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rbNumeroCheque As System.Windows.Forms.RadioButton
        Friend WithEvents rbAprobados As System.Windows.Forms.RadioButton
        Friend WithEvents rbEmitidos As System.Windows.Forms.RadioButton
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteEgresoBanco As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents Label2 As Label
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace