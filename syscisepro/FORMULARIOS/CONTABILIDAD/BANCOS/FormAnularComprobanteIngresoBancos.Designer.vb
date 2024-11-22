Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAnularComprobanteIngresoBancos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnularComprobanteIngresoBancos))
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.lblIdComprobanteIngresoBanco = New System.Windows.Forms.Label()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.dgvPagosFacturaVentaPorFactura = New System.Windows.Forms.DataGridView()
            Me.dgvPagosFacturaVentaPorIngreso = New System.Windows.Forms.DataGridView()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dgvComprobanteEgresoBancos = New System.Windows.Forms.DataGridView()
            Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvPagosFacturaVentaPorFactura, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvPagosFacturaVentaPorIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentaBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(209, 30)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(161, 21)
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
            Me.cmbBancos.Location = New System.Drawing.Point(15, 29)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(168, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'lblIdComprobanteIngresoBanco
            '
            Me.lblIdComprobanteIngresoBanco.AutoSize = True
            Me.lblIdComprobanteIngresoBanco.BackColor = System.Drawing.Color.Transparent
            Me.lblIdComprobanteIngresoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteIngresoBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteIngresoBanco.Location = New System.Drawing.Point(526, 4)
            Me.lblIdComprobanteIngresoBanco.Name = "lblIdComprobanteIngresoBanco"
            Me.lblIdComprobanteIngresoBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteIngresoBanco.TabIndex = 3
            Me.lblIdComprobanteIngresoBanco.Text = "..."
            '
            'dtpHasta
            '
            Me.dtpHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(553, 29)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(109, 21)
            Me.dtpHasta.TabIndex = 1
            '
            'dtpDesde
            '
            Me.dtpDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(417, 29)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(108, 21)
            Me.dtpDesde.TabIndex = 0
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblIdFacturaVenta)
            Me.GroupBox1.Controls.Add(Me.dgvPagosFacturaVentaPorFactura)
            Me.GroupBox1.Controls.Add(Me.dgvPagosFacturaVentaPorIngreso)
            Me.GroupBox1.Location = New System.Drawing.Point(0, 174)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(686, 100)
            Me.GroupBox1.TabIndex = 120
            Me.GroupBox1.TabStop = False
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(436, 16)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(25, 13)
            Me.lblIdFacturaVenta.TabIndex = 4
            Me.lblIdFacturaVenta.Text = "..."
            '
            'dgvPagosFacturaVentaPorFactura
            '
            Me.dgvPagosFacturaVentaPorFactura.AllowUserToAddRows = False
            Me.dgvPagosFacturaVentaPorFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPagosFacturaVentaPorFactura.Location = New System.Drawing.Point(345, 10)
            Me.dgvPagosFacturaVentaPorFactura.Name = "dgvPagosFacturaVentaPorFactura"
            Me.dgvPagosFacturaVentaPorFactura.Size = New System.Drawing.Size(412, 84)
            Me.dgvPagosFacturaVentaPorFactura.TabIndex = 1
            '
            'dgvPagosFacturaVentaPorIngreso
            '
            Me.dgvPagosFacturaVentaPorIngreso.AllowUserToAddRows = False
            Me.dgvPagosFacturaVentaPorIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPagosFacturaVentaPorIngreso.Location = New System.Drawing.Point(9, 10)
            Me.dgvPagosFacturaVentaPorIngreso.Name = "dgvPagosFacturaVentaPorIngreso"
            Me.dgvPagosFacturaVentaPorIngreso.Size = New System.Drawing.Size(421, 84)
            Me.dgvPagosFacturaVentaPorIngreso.TabIndex = 0
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.GroupBox2.Controls.Add(Me.dgvComprobanteEgresoBancos)
            Me.GroupBox2.Location = New System.Drawing.Point(1, 109)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(727, 434)
            Me.GroupBox2.TabIndex = 121
            Me.GroupBox2.TabStop = False
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
            Me.dgvComprobanteEgresoBancos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvComprobanteEgresoBancos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvComprobanteEgresoBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteEgresoBancos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteEgresoBancos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobanteEgresoBancos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvComprobanteEgresoBancos.Location = New System.Drawing.Point(3, 16)
            Me.dgvComprobanteEgresoBancos.MultiSelect = False
            Me.dgvComprobanteEgresoBancos.Name = "dgvComprobanteEgresoBancos"
            Me.dgvComprobanteEgresoBancos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvComprobanteEgresoBancos.RowHeadersVisible = False
            Me.dgvComprobanteEgresoBancos.RowHeadersWidth = 25
            Me.dgvComprobanteEgresoBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteEgresoBancos.Size = New System.Drawing.Size(721, 415)
            Me.dgvComprobanteEgresoBancos.TabIndex = 108
            '
            'chk
            '
            Me.chk.HeaderText = "CHK"
            Me.chk.Name = "chk"
            Me.chk.Width = 40
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnReporte})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(734, 32)
            Me.msKardex.TabIndex = 187
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
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.playlist_remove_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(85, 28)
            Me.btnReporte.Text = "ANULAR"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdComprobanteIngresoBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCuentaBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbBancos)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(725, 68)
            Me.KryptonGroupBox1.TabIndex = 188
            Me.KryptonGroupBox1.Values.Heading = ""
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(529, 31)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(18, 20)
            Me.KryptonLabel4.TabIndex = 32
            Me.KryptonLabel4.Values.Text = "A"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(385, 31)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(26, 20)
            Me.KryptonLabel3.TabIndex = 31
            Me.KryptonLabel3.Values.Text = "De"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(209, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(66, 20)
            Me.KryptonLabel2.TabIndex = 30
            Me.KryptonLabel2.Values.Text = "CA/CC/TA"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(15, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Banco"
            '
            'FormAnularComprobanteIngresoBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(734, 551)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAnularComprobanteIngresoBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ANULAR COMPROBANTE DE INGRESO BANCOS"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvPagosFacturaVentaPorFactura, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvPagosFacturaVentaPorIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
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
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents lblIdComprobanteIngresoBanco As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents dgvComprobanteEgresoBancos As System.Windows.Forms.DataGridView
        Friend WithEvents dgvPagosFacturaVentaPorIngreso As System.Windows.Forms.DataGridView
        Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents dgvPagosFacturaVentaPorFactura As System.Windows.Forms.DataGridView
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace