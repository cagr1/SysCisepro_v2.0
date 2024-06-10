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
            Me.lblIdCuentaBancos = New System.Windows.Forms.Label()
            Me.lblNumeroCuenta = New System.Windows.Forms.Label()
            Me.lblMontoCuenta = New System.Windows.Forms.Label()
            Me.lblTipoCuenta = New System.Windows.Forms.Label()
            Me.txtIdCuentaBancos = New System.Windows.Forms.TextBox()
            Me.txtNumeroCuentasBancos = New System.Windows.Forms.TextBox()
            Me.txtMontoCuentasBancos = New System.Windows.Forms.TextBox()
            Me.cmbTipoCuenta = New System.Windows.Forms.ComboBox()
            Me.gbCuentaBancos = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtCodigoBanco = New System.Windows.Forms.TextBox()
            Me.lblIdBanco = New System.Windows.Forms.Label()
            Me.cmbBanco = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgvCuentasBancos = New System.Windows.Forms.DataGridView()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoCuentaBancos = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarCuentaBancos = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarCuentaBancos = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarCuentaBancos = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbCuentaBancos.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.dgvCuentasBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblIdCuentaBancos
            '
            Me.lblIdCuentaBancos.AutoSize = True
            Me.lblIdCuentaBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdCuentaBancos.Location = New System.Drawing.Point(61, 18)
            Me.lblIdCuentaBancos.Name = "lblIdCuentaBancos"
            Me.lblIdCuentaBancos.Size = New System.Drawing.Size(68, 13)
            Me.lblIdCuentaBancos.TabIndex = 0
            Me.lblIdCuentaBancos.Text = "ID CUENTA :"
            '
            'lblNumeroCuenta
            '
            Me.lblNumeroCuenta.AutoSize = True
            Me.lblNumeroCuenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroCuenta.Location = New System.Drawing.Point(61, 44)
            Me.lblNumeroCuenta.Name = "lblNumeroCuenta"
            Me.lblNumeroCuenta.Size = New System.Drawing.Size(104, 13)
            Me.lblNumeroCuenta.TabIndex = 1
            Me.lblNumeroCuenta.Text = "NUMERO CUENTA :"
            '
            'lblMontoCuenta
            '
            Me.lblMontoCuenta.AutoSize = True
            Me.lblMontoCuenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoCuenta.Location = New System.Drawing.Point(363, 44)
            Me.lblMontoCuenta.Name = "lblMontoCuenta"
            Me.lblMontoCuenta.Size = New System.Drawing.Size(99, 13)
            Me.lblMontoCuenta.TabIndex = 2
            Me.lblMontoCuenta.Text = "MONTO CUENTA :"
            '
            'lblTipoCuenta
            '
            Me.lblTipoCuenta.AutoSize = True
            Me.lblTipoCuenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipoCuenta.Location = New System.Drawing.Point(347, 18)
            Me.lblTipoCuenta.Name = "lblTipoCuenta"
            Me.lblTipoCuenta.Size = New System.Drawing.Size(83, 13)
            Me.lblTipoCuenta.TabIndex = 3
            Me.lblTipoCuenta.Text = "TIPO CUENTA :"
            '
            'txtIdCuentaBancos
            '
            Me.txtIdCuentaBancos.BackColor = System.Drawing.Color.White
            Me.txtIdCuentaBancos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdCuentaBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdCuentaBancos.Location = New System.Drawing.Point(164, 15)
            Me.txtIdCuentaBancos.Name = "txtIdCuentaBancos"
            Me.txtIdCuentaBancos.Size = New System.Drawing.Size(117, 21)
            Me.txtIdCuentaBancos.TabIndex = 4
            '
            'txtNumeroCuentasBancos
            '
            Me.txtNumeroCuentasBancos.BackColor = System.Drawing.Color.White
            Me.txtNumeroCuentasBancos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroCuentasBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroCuentasBancos.Location = New System.Drawing.Point(164, 41)
            Me.txtNumeroCuentasBancos.Name = "txtNumeroCuentasBancos"
            Me.txtNumeroCuentasBancos.Size = New System.Drawing.Size(117, 21)
            Me.txtNumeroCuentasBancos.TabIndex = 5
            '
            'txtMontoCuentasBancos
            '
            Me.txtMontoCuentasBancos.BackColor = System.Drawing.Color.White
            Me.txtMontoCuentasBancos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMontoCuentasBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoCuentasBancos.Location = New System.Drawing.Point(466, 41)
            Me.txtMontoCuentasBancos.Name = "txtMontoCuentasBancos"
            Me.txtMontoCuentasBancos.Size = New System.Drawing.Size(112, 21)
            Me.txtMontoCuentasBancos.TabIndex = 6
            Me.txtMontoCuentasBancos.Text = "0.00"
            Me.txtMontoCuentasBancos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'cmbTipoCuenta
            '
            Me.cmbTipoCuenta.BackColor = System.Drawing.Color.White
            Me.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbTipoCuenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipoCuenta.FormattingEnabled = True
            Me.cmbTipoCuenta.Items.AddRange(New Object() {"Cuenta de Ahorros", "Cuenta Corriente"})
            Me.cmbTipoCuenta.Location = New System.Drawing.Point(438, 14)
            Me.cmbTipoCuenta.Name = "cmbTipoCuenta"
            Me.cmbTipoCuenta.Size = New System.Drawing.Size(140, 21)
            Me.cmbTipoCuenta.TabIndex = 7
            '
            'gbCuentaBancos
            '
            Me.gbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.gbCuentaBancos.Controls.Add(Me.txtIdCuentaBancos)
            Me.gbCuentaBancos.Controls.Add(Me.cmbTipoCuenta)
            Me.gbCuentaBancos.Controls.Add(Me.lblIdCuentaBancos)
            Me.gbCuentaBancos.Controls.Add(Me.lblTipoCuenta)
            Me.gbCuentaBancos.Controls.Add(Me.txtMontoCuentasBancos)
            Me.gbCuentaBancos.Controls.Add(Me.lblNumeroCuenta)
            Me.gbCuentaBancos.Controls.Add(Me.txtNumeroCuentasBancos)
            Me.gbCuentaBancos.Controls.Add(Me.lblMontoCuenta)
            Me.gbCuentaBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbCuentaBancos.Location = New System.Drawing.Point(2, 88)
            Me.gbCuentaBancos.Name = "gbCuentaBancos"
            Me.gbCuentaBancos.Size = New System.Drawing.Size(654, 67)
            Me.gbCuentaBancos.TabIndex = 8
            Me.gbCuentaBancos.TabStop = False
            Me.gbCuentaBancos.Text = "CUENTA"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.txtCodigoBanco)
            Me.Panel1.Controls.Add(Me.lblIdBanco)
            Me.Panel1.Controls.Add(Me.cmbBanco)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(2, 35)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(654, 52)
            Me.Panel1.TabIndex = 9
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(360, 15)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(93, 13)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "CTA. CONTABLE:"
            '
            'txtCodigoBanco
            '
            Me.txtCodigoBanco.BackColor = System.Drawing.Color.White
            Me.txtCodigoBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCodigoBanco.Enabled = False
            Me.txtCodigoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoBanco.Location = New System.Drawing.Point(477, 12)
            Me.txtCodigoBanco.Name = "txtCodigoBanco"
            Me.txtCodigoBanco.Size = New System.Drawing.Size(100, 21)
            Me.txtCodigoBanco.TabIndex = 10
            '
            'lblIdBanco
            '
            Me.lblIdBanco.AutoSize = True
            Me.lblIdBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdBanco.Location = New System.Drawing.Point(326, 15)
            Me.lblIdBanco.Name = "lblIdBanco"
            Me.lblIdBanco.Size = New System.Drawing.Size(19, 13)
            Me.lblIdBanco.TabIndex = 9
            Me.lblIdBanco.Text = "00"
            '
            'cmbBanco
            '
            Me.cmbBanco.BackColor = System.Drawing.Color.White
            Me.cmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBanco.FormattingEnabled = True
            Me.cmbBanco.Location = New System.Drawing.Point(147, 11)
            Me.cmbBanco.Name = "cmbBanco"
            Me.cmbBanco.Size = New System.Drawing.Size(173, 21)
            Me.cmbBanco.TabIndex = 8
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(8, 15)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(132, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "SELECCIONE EL BANCO :"
            '
            'dgvCuentasBancos
            '
            Me.dgvCuentasBancos.AllowUserToAddRows = False
            Me.dgvCuentasBancos.AllowUserToDeleteRows = False
            Me.dgvCuentasBancos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCuentasBancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCuentasBancos.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvCuentasBancos.Location = New System.Drawing.Point(2, 157)
            Me.dgvCuentasBancos.MultiSelect = False
            Me.dgvCuentasBancos.Name = "dgvCuentasBancos"
            Me.dgvCuentasBancos.RowHeadersVisible = False
            Me.dgvCuentasBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCuentasBancos.Size = New System.Drawing.Size(654, 159)
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
            Me.msKardex.Size = New System.Drawing.Size(658, 32)
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
            'FormCuentasBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(658, 316)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.dgvCuentasBancos)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.gbCuentaBancos)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormCuentasBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "DEFINIR CUENTAS DE BANCOS"
            Me.gbCuentaBancos.ResumeLayout(False)
            Me.gbCuentaBancos.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            CType(Me.dgvCuentasBancos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblIdCuentaBancos As System.Windows.Forms.Label
        Friend WithEvents lblNumeroCuenta As System.Windows.Forms.Label
        Friend WithEvents lblMontoCuenta As System.Windows.Forms.Label
        Friend WithEvents lblTipoCuenta As System.Windows.Forms.Label
        Friend WithEvents txtIdCuentaBancos As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroCuentasBancos As System.Windows.Forms.TextBox
        Friend WithEvents txtMontoCuentasBancos As System.Windows.Forms.TextBox
        Friend WithEvents cmbTipoCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents gbCuentaBancos As System.Windows.Forms.GroupBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblIdBanco As System.Windows.Forms.Label
        Friend WithEvents dgvCuentasBancos As System.Windows.Forms.DataGridView
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtCodigoBanco As System.Windows.Forms.TextBox
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoCuentaBancos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarCuentaBancos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarCuentaBancos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarCuentaBancos As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace