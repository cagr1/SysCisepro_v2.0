Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormCuentasBancos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCuentasBancos))
            Me.txtIdCuentaBancos = New System.Windows.Forms.TextBox()
            Me.txtNumeroCuentasBancos = New System.Windows.Forms.TextBox()
            Me.txtMontoCuentasBancos = New System.Windows.Forms.TextBox()
            Me.cmbTipoCuenta = New System.Windows.Forms.ComboBox()
            Me.txtCodigoBanco = New System.Windows.Forms.TextBox()
            Me.lblIdBanco = New System.Windows.Forms.Label()
            Me.cmbBanco = New System.Windows.Forms.ComboBox()
            Me.dgvCuentasBancos = New System.Windows.Forms.DataGridView()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoCuentaBancos = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarCuentaBancos = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarCuentaBancos = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarCuentaBancos = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvCuentasBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtIdCuentaBancos
            '
            Me.txtIdCuentaBancos.BackColor = System.Drawing.Color.White
            Me.txtIdCuentaBancos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdCuentaBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdCuentaBancos.Location = New System.Drawing.Point(84, 30)
            Me.txtIdCuentaBancos.Name = "txtIdCuentaBancos"
            Me.txtIdCuentaBancos.Size = New System.Drawing.Size(101, 21)
            Me.txtIdCuentaBancos.TabIndex = 4
            '
            'txtNumeroCuentasBancos
            '
            Me.txtNumeroCuentasBancos.BackColor = System.Drawing.Color.White
            Me.txtNumeroCuentasBancos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroCuentasBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroCuentasBancos.Location = New System.Drawing.Point(84, 57)
            Me.txtNumeroCuentasBancos.Name = "txtNumeroCuentasBancos"
            Me.txtNumeroCuentasBancos.Size = New System.Drawing.Size(101, 21)
            Me.txtNumeroCuentasBancos.TabIndex = 5
            '
            'txtMontoCuentasBancos
            '
            Me.txtMontoCuentasBancos.BackColor = System.Drawing.Color.White
            Me.txtMontoCuentasBancos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMontoCuentasBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoCuentasBancos.Location = New System.Drawing.Point(280, 57)
            Me.txtMontoCuentasBancos.Name = "txtMontoCuentasBancos"
            Me.txtMontoCuentasBancos.Size = New System.Drawing.Size(100, 21)
            Me.txtMontoCuentasBancos.TabIndex = 6
            Me.txtMontoCuentasBancos.Text = "0.00"
            Me.txtMontoCuentasBancos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'cmbTipoCuenta
            '
            Me.cmbTipoCuenta.BackColor = System.Drawing.Color.White
            Me.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoCuenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipoCuenta.FormattingEnabled = True
            Me.cmbTipoCuenta.Items.AddRange(New Object() {"Cuenta de Ahorros", "Cuenta Corriente"})
            Me.cmbTipoCuenta.Location = New System.Drawing.Point(280, 32)
            Me.cmbTipoCuenta.Name = "cmbTipoCuenta"
            Me.cmbTipoCuenta.Size = New System.Drawing.Size(100, 21)
            Me.cmbTipoCuenta.TabIndex = 7
            '
            'txtCodigoBanco
            '
            Me.txtCodigoBanco.BackColor = System.Drawing.Color.White
            Me.txtCodigoBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCodigoBanco.Enabled = False
            Me.txtCodigoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoBanco.Location = New System.Drawing.Point(280, 3)
            Me.txtCodigoBanco.Name = "txtCodigoBanco"
            Me.txtCodigoBanco.Size = New System.Drawing.Size(100, 21)
            Me.txtCodigoBanco.TabIndex = 10
            '
            'lblIdBanco
            '
            Me.lblIdBanco.AutoSize = True
            Me.lblIdBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdBanco.Location = New System.Drawing.Point(400, 11)
            Me.lblIdBanco.Name = "lblIdBanco"
            Me.lblIdBanco.Size = New System.Drawing.Size(19, 13)
            Me.lblIdBanco.TabIndex = 9
            Me.lblIdBanco.Text = "00"
            '
            'cmbBanco
            '
            Me.cmbBanco.BackColor = System.Drawing.Color.White
            Me.cmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBanco.FormattingEnabled = True
            Me.cmbBanco.Location = New System.Drawing.Point(68, 3)
            Me.cmbBanco.Name = "cmbBanco"
            Me.cmbBanco.Size = New System.Drawing.Size(117, 21)
            Me.cmbBanco.TabIndex = 8
            '
            'dgvCuentasBancos
            '
            Me.dgvCuentasBancos.AllowUserToAddRows = False
            Me.dgvCuentasBancos.AllowUserToDeleteRows = False
            Me.dgvCuentasBancos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCuentasBancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCuentasBancos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvCuentasBancos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvCuentasBancos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvCuentasBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCuentasBancos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvCuentasBancos.Location = New System.Drawing.Point(5, 163)
            Me.dgvCuentasBancos.MultiSelect = False
            Me.dgvCuentasBancos.Name = "dgvCuentasBancos"
            Me.dgvCuentasBancos.RowHeadersVisible = False
            Me.dgvCuentasBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCuentasBancos.Size = New System.Drawing.Size(453, 153)
            Me.dgvCuentasBancos.TabIndex = 10
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoCuentaBancos, Me.btnGuardarCuentaBancos, Me.btnModificarCuentaBancos, Me.btnCancelarCuentaBancos})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(461, 32)
            Me.msKardex.TabIndex = 184
            Me.msKardex.Text = "msIngresoBodega"
            '
            'btnNuevoCuentaBancos
            '
            Me.btnNuevoCuentaBancos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoCuentaBancos.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoCuentaBancos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoCuentaBancos.Name = "btnNuevoCuentaBancos"
            Me.btnNuevoCuentaBancos.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevoCuentaBancos.Text = "NUEVO"
            '
            'btnGuardarCuentaBancos
            '
            Me.btnGuardarCuentaBancos.Enabled = False
            Me.btnGuardarCuentaBancos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarCuentaBancos.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarCuentaBancos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarCuentaBancos.Name = "btnGuardarCuentaBancos"
            Me.btnGuardarCuentaBancos.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardarCuentaBancos.Text = "GUARDAR"
            '
            'btnModificarCuentaBancos
            '
            Me.btnModificarCuentaBancos.Enabled = False
            Me.btnModificarCuentaBancos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificarCuentaBancos.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificarCuentaBancos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificarCuentaBancos.Name = "btnModificarCuentaBancos"
            Me.btnModificarCuentaBancos.Size = New System.Drawing.Size(106, 28)
            Me.btnModificarCuentaBancos.Text = "MODIFICAR"
            '
            'btnCancelarCuentaBancos
            '
            Me.btnCancelarCuentaBancos.Enabled = False
            Me.btnCancelarCuentaBancos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarCuentaBancos.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarCuentaBancos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelarCuentaBancos.Name = "btnCancelarCuentaBancos"
            Me.btnCancelarCuentaBancos.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelarCuentaBancos.Text = "CANCELAR"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(5, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbTipoCuenta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtMontoCuentasBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdCuentaBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCodigoBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumeroCuentasBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdBanco)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(453, 122)
            Me.KryptonGroupBox1.TabIndex = 185
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(5, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Banco"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(193, 4)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(81, 20)
            Me.KryptonLabel2.TabIndex = 10
            Me.KryptonLabel2.Values.Text = "Cta Contable"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(6, 31)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel3.TabIndex = 11
            Me.KryptonLabel3.Values.Text = "Id Cuenta"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(5, 57)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(69, 20)
            Me.KryptonLabel4.TabIndex = 12
            Me.KryptonLabel4.Values.Text = "No Cuenta"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(193, 32)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(76, 20)
            Me.KryptonLabel5.TabIndex = 13
            Me.KryptonLabel5.Values.Text = "Tipo Cuenta"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(193, 57)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(89, 20)
            Me.KryptonLabel6.TabIndex = 14
            Me.KryptonLabel6.Values.Text = "Monto Cuenta"
            '
            'FormCuentasBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(461, 316)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.dgvCuentasBancos)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormCuentasBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "DEFINIR CUENTAS DE BANCOS"
            CType(Me.dgvCuentasBancos, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents txtIdCuentaBancos As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroCuentasBancos As System.Windows.Forms.TextBox
        Friend WithEvents txtMontoCuentasBancos As System.Windows.Forms.TextBox
        Friend WithEvents cmbTipoCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
        Friend WithEvents lblIdBanco As System.Windows.Forms.Label
        Friend WithEvents dgvCuentasBancos As System.Windows.Forms.DataGridView
        Friend WithEvents txtCodigoBanco As System.Windows.Forms.TextBox
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoCuentaBancos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarCuentaBancos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarCuentaBancos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarCuentaBancos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    End Class
End Namespace