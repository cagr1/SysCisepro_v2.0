Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormCargarComprobantesEgresoBanco
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCargarComprobantesEgresoBanco))
            Me.lblCodigoCta = New System.Windows.Forms.Label()
            Me.txtCuentaDebe = New System.Windows.Forms.TextBox()
            Me.dgvComprobantesEgresoBanco = New System.Windows.Forms.DataGridView()
            Me.btnBuscarPersonal = New System.Windows.Forms.Button()
            Me.txtRutaArchivo = New System.Windows.Forms.TextBox()
            Me.ofdSeleccionarArchivo = New System.Windows.Forms.OpenFileDialog()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.ContextMenuStripClicDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ToolStripMenuItemEliminar = New System.Windows.Forms.ToolStripMenuItem()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvComprobantesEgresoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            Me.msKardex.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblCodigoCta
            '
            Me.lblCodigoCta.AutoSize = True
            Me.lblCodigoCta.BackColor = System.Drawing.Color.Transparent
            Me.lblCodigoCta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigoCta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblCodigoCta.Location = New System.Drawing.Point(390, 0)
            Me.lblCodigoCta.Name = "lblCodigoCta"
            Me.lblCodigoCta.Size = New System.Drawing.Size(13, 13)
            Me.lblCodigoCta.TabIndex = 59
            Me.lblCodigoCta.Text = "0"
            '
            'txtCuentaDebe
            '
            Me.txtCuentaDebe.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCuentaDebe.Location = New System.Drawing.Point(291, 21)
            Me.txtCuentaDebe.Name = "txtCuentaDebe"
            Me.txtCuentaDebe.Size = New System.Drawing.Size(217, 21)
            Me.txtCuentaDebe.TabIndex = 58
            '
            'dgvComprobantesEgresoBanco
            '
            Me.dgvComprobantesEgresoBanco.AllowUserToAddRows = False
            Me.dgvComprobantesEgresoBanco.AllowUserToDeleteRows = False
            Me.dgvComprobantesEgresoBanco.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobantesEgresoBanco.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvComprobantesEgresoBanco.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvComprobantesEgresoBanco.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobantesEgresoBanco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesEgresoBanco.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobantesEgresoBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesEgresoBanco.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvComprobantesEgresoBanco.Location = New System.Drawing.Point(2, 116)
            Me.dgvComprobantesEgresoBanco.MultiSelect = False
            Me.dgvComprobantesEgresoBanco.Name = "dgvComprobantesEgresoBanco"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesEgresoBanco.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvComprobantesEgresoBanco.RowHeadersVisible = False
            Me.dgvComprobantesEgresoBanco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesEgresoBanco.Size = New System.Drawing.Size(812, 391)
            Me.dgvComprobantesEgresoBanco.TabIndex = 60
            '
            'btnBuscarPersonal
            '
            Me.btnBuscarPersonal.BackColor = System.Drawing.Color.Transparent
            Me.btnBuscarPersonal.FlatAppearance.BorderSize = 0
            Me.btnBuscarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscarPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarPersonal.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarPersonal.Location = New System.Drawing.Point(243, 11)
            Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
            Me.btnBuscarPersonal.Size = New System.Drawing.Size(29, 30)
            Me.btnBuscarPersonal.TabIndex = 60
            Me.btnBuscarPersonal.UseVisualStyleBackColor = False
            '
            'txtRutaArchivo
            '
            Me.txtRutaArchivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRutaArchivo.Location = New System.Drawing.Point(8, 20)
            Me.txtRutaArchivo.Name = "txtRutaArchivo"
            Me.txtRutaArchivo.Size = New System.Drawing.Size(229, 21)
            Me.txtRutaArchivo.TabIndex = 59
            '
            'ofdSeleccionarArchivo
            '
            Me.ofdSeleccionarArchivo.FileName = "ofdSeleccionarArchivo"
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(668, 20)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(120, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.BackColor = System.Drawing.Color.White
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(526, 21)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(120, 21)
            Me.cmbBancos.TabIndex = 25
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
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(818, 32)
            Me.msKardex.TabIndex = 187
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
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(5, 34)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCodigoCta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCuentaBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnBuscarPersonal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCuentaDebe)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRutaArchivo)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(801, 75)
            Me.KryptonGroupBox1.TabIndex = 188
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(668, -2)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(66, 20)
            Me.KryptonLabel3.TabIndex = 63
            Me.KryptonLabel3.Values.Text = "CA/CC/TA"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(526, -2)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel2.TabIndex = 62
            Me.KryptonLabel2.Values.Text = "Banco"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(294, -2)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel1.TabIndex = 61
            Me.KryptonLabel1.Values.Text = "Cta Debe"
            '
            'FormCargarComprobantesEgresoBanco
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(818, 510)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.dgvComprobantesEgresoBanco)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormCargarComprobantesEgresoBanco"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CARGAR COMPROBANTES EGRESO"
            CType(Me.dgvComprobantesEgresoBanco, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
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
        Friend WithEvents txtCuentaDebe As System.Windows.Forms.TextBox
        Friend WithEvents dgvComprobantesEgresoBanco As System.Windows.Forms.DataGridView
        Friend WithEvents txtRutaArchivo As System.Windows.Forms.TextBox
        Friend WithEvents ofdSeleccionarArchivo As System.Windows.Forms.OpenFileDialog
        Friend WithEvents btnBuscarPersonal As System.Windows.Forms.Button
        Friend WithEvents lblCodigoCta As System.Windows.Forms.Label
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ToolStripMenuItemEliminar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace