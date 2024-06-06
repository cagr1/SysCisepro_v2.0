Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormCargarComprobantesIngresoBanco
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCargarComprobantesIngresoBanco))
            Me.gbBanco = New System.Windows.Forms.GroupBox()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.gbBuscar = New System.Windows.Forms.GroupBox()
            Me.btnBuscarPersonal = New System.Windows.Forms.Button()
            Me.txtRutaArchivo = New System.Windows.Forms.TextBox()
            Me.dgvComprobantesEgresoBanco = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblCodigoCta = New System.Windows.Forms.Label()
            Me.txtCuentaDebe = New System.Windows.Forms.TextBox()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.ContextMenuStripClicDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ToolStripMenuItemEliminar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ofdSeleccionarArchivo = New System.Windows.Forms.OpenFileDialog()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbBanco.SuspendLayout()
            Me.gbBuscar.SuspendLayout()
            CType(Me.dgvComprobantesEgresoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            Me.msKardex.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbBanco
            '
            Me.gbBanco.BackColor = System.Drawing.Color.White
            Me.gbBanco.Controls.Add(Me.cmbCuentaBancos)
            Me.gbBanco.Controls.Add(Me.Label10)
            Me.gbBanco.Controls.Add(Me.cmbBancos)
            Me.gbBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBanco.Location = New System.Drawing.Point(693, 36)
            Me.gbBanco.Name = "gbBanco"
            Me.gbBanco.Size = New System.Drawing.Size(563, 62)
            Me.gbBanco.TabIndex = 114
            Me.gbBanco.TabStop = False
            Me.gbBanco.Text = "BANCO: "
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(240, 30)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(152, 21)
            Me.cmbCuentaBancos.TabIndex = 35
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(237, 0)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(62, 13)
            Me.Label10.TabIndex = 34
            Me.Label10.Text = "CA/CC/TA:"
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
            Me.cmbBancos.Size = New System.Drawing.Size(205, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'gbBuscar
            '
            Me.gbBuscar.BackColor = System.Drawing.Color.White
            Me.gbBuscar.Controls.Add(Me.btnBuscarPersonal)
            Me.gbBuscar.Controls.Add(Me.txtRutaArchivo)
            Me.gbBuscar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBuscar.Location = New System.Drawing.Point(2, 36)
            Me.gbBuscar.Name = "gbBuscar"
            Me.gbBuscar.Size = New System.Drawing.Size(360, 62)
            Me.gbBuscar.TabIndex = 113
            Me.gbBuscar.TabStop = False
            Me.gbBuscar.Text = "BUSCAR"
            '
            'btnBuscarPersonal
            '
            Me.btnBuscarPersonal.BackColor = System.Drawing.Color.White
            Me.btnBuscarPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarPersonal.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarPersonal.Location = New System.Drawing.Point(310, 26)
            Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
            Me.btnBuscarPersonal.Size = New System.Drawing.Size(41, 30)
            Me.btnBuscarPersonal.TabIndex = 60
            Me.btnBuscarPersonal.UseVisualStyleBackColor = False
            '
            'txtRutaArchivo
            '
            Me.txtRutaArchivo.Location = New System.Drawing.Point(6, 30)
            Me.txtRutaArchivo.Name = "txtRutaArchivo"
            Me.txtRutaArchivo.Size = New System.Drawing.Size(298, 21)
            Me.txtRutaArchivo.TabIndex = 59
            '
            'dgvComprobantesEgresoBanco
            '
            Me.dgvComprobantesEgresoBanco.AllowUserToAddRows = False
            Me.dgvComprobantesEgresoBanco.AllowUserToDeleteRows = False
            Me.dgvComprobantesEgresoBanco.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobantesEgresoBanco.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvComprobantesEgresoBanco.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobantesEgresoBanco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobantesEgresoBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesEgresoBanco.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobantesEgresoBanco.Location = New System.Drawing.Point(2, 104)
            Me.dgvComprobantesEgresoBanco.MultiSelect = False
            Me.dgvComprobantesEgresoBanco.Name = "dgvComprobantesEgresoBanco"
            Me.dgvComprobantesEgresoBanco.RowHeadersVisible = False
            Me.dgvComprobantesEgresoBanco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesEgresoBanco.Size = New System.Drawing.Size(1254, 597)
            Me.dgvComprobantesEgresoBanco.TabIndex = 112
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.lblCodigoCta)
            Me.GroupBox1.Controls.Add(Me.txtCuentaDebe)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(362, 36)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(331, 62)
            Me.GroupBox1.TabIndex = 110
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "CTA. HABER"
            '
            'lblCodigoCta
            '
            Me.lblCodigoCta.AutoSize = True
            Me.lblCodigoCta.Location = New System.Drawing.Point(8, 14)
            Me.lblCodigoCta.Name = "lblCodigoCta"
            Me.lblCodigoCta.Size = New System.Drawing.Size(13, 13)
            Me.lblCodigoCta.TabIndex = 59
            Me.lblCodigoCta.Text = "0"
            '
            'txtCuentaDebe
            '
            Me.txtCuentaDebe.Location = New System.Drawing.Point(11, 30)
            Me.txtCuentaDebe.Name = "txtCuentaDebe"
            Me.txtCuentaDebe.Size = New System.Drawing.Size(309, 21)
            Me.txtCuentaDebe.TabIndex = 58
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(2, 109)
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.ReadOnly = True
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(1254, 53)
            Me.dgvFacturaVenta.TabIndex = 115
            '
            'ContextMenuStripClicDerecho
            '
            Me.ContextMenuStripClicDerecho.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemEliminar})
            Me.ContextMenuStripClicDerecho.Name = "ContextMenuStripClicDerecho"
            Me.ContextMenuStripClicDerecho.Size = New System.Drawing.Size(118, 26)
            '
            'ToolStripMenuItemEliminar
            '
            Me.ToolStripMenuItemEliminar.Name = "ToolStripMenuItemEliminar"
            Me.ToolStripMenuItemEliminar.Size = New System.Drawing.Size(117, 22)
            Me.ToolStripMenuItemEliminar.Text = "Eliminar"
            '
            'ofdSeleccionarArchivo
            '
            Me.ofdSeleccionarArchivo.FileName = "ofdSeleccionarArchivo"
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(1258, 32)
            Me.msKardex.TabIndex = 188
            Me.msKardex.Text = "msIngresoBodega"
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
            'FormCargarComprobantesIngresoBanco
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1258, 704)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.gbBanco)
            Me.Controls.Add(Me.gbBuscar)
            Me.Controls.Add(Me.dgvComprobantesEgresoBanco)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.dgvFacturaVenta)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormCargarComprobantesIngresoBanco"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CARGAR COMPROBANTES DE INGRESO"
            Me.gbBanco.ResumeLayout(False)
            Me.gbBanco.PerformLayout()
            Me.gbBuscar.ResumeLayout(False)
            Me.gbBuscar.PerformLayout()
            CType(Me.dgvComprobantesEgresoBanco, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbBanco As System.Windows.Forms.GroupBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents btnBuscarPersonal As System.Windows.Forms.Button
        Friend WithEvents txtRutaArchivo As System.Windows.Forms.TextBox
        Friend WithEvents dgvComprobantesEgresoBanco As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblCodigoCta As System.Windows.Forms.Label
        Friend WithEvents txtCuentaDebe As System.Windows.Forms.TextBox
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ToolStripMenuItemEliminar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ofdSeleccionarArchivo As System.Windows.Forms.OpenFileDialog
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
    End Class
End Namespace