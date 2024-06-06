Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormRegistroBancos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistroBancos))
            Me.dgvBancos = New System.Windows.Forms.DataGridView()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoBanco = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarBanco = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarBanco = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarBanco = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporteBanco = New System.Windows.Forms.ToolStripMenuItem()
            Me.txtIdBanco = New System.Windows.Forms.TextBox()
            Me.lblEmail = New System.Windows.Forms.Label()
            Me.txtNombreBanco = New System.Windows.Forms.TextBox()
            Me.lblFax = New System.Windows.Forms.Label()
            Me.lblTelefonos = New System.Windows.Forms.Label()
            Me.txtDireccionBanco = New System.Windows.Forms.TextBox()
            Me.lblOficialCredito = New System.Windows.Forms.Label()
            Me.txtOficialCreditoBanco = New System.Windows.Forms.TextBox()
            Me.lblDireccionBanco = New System.Windows.Forms.Label()
            Me.txtTelefonoBanco = New System.Windows.Forms.TextBox()
            Me.txtFaxBanco = New System.Windows.Forms.TextBox()
            Me.lblNombreBanco = New System.Windows.Forms.Label()
            Me.txtEMailBanco = New System.Windows.Forms.TextBox()
            Me.lblIdBanco = New System.Windows.Forms.Label()
            Me.lblCodigoCuentaBanco = New System.Windows.Forms.Label()
            Me.txtCodigoCuentaBanco = New System.Windows.Forms.TextBox()
            Me.gpBancos = New System.Windows.Forms.GroupBox()
            CType(Me.dgvBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            Me.gpBancos.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvBancos
            '
            Me.dgvBancos.AllowUserToAddRows = False
            Me.dgvBancos.AllowUserToDeleteRows = False
            Me.dgvBancos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvBancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvBancos.BackgroundColor = System.Drawing.Color.White
            Me.dgvBancos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvBancos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvBancos.Location = New System.Drawing.Point(1, 160)
            Me.dgvBancos.MultiSelect = False
            Me.dgvBancos.Name = "dgvBancos"
            Me.dgvBancos.ReadOnly = True
            Me.dgvBancos.RowHeadersVisible = False
            Me.dgvBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvBancos.Size = New System.Drawing.Size(721, 231)
            Me.dgvBancos.TabIndex = 17
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoBanco, Me.btnGuardarBanco, Me.btnModificarBanco, Me.btnCancelarBanco, Me.btnReporteBanco})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(723, 32)
            Me.msKardex.TabIndex = 185
            Me.msKardex.Text = "msIngresoBodega"
            '
            'btnNuevoBanco
            '
            Me.btnNuevoBanco.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoBanco.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoBanco.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoBanco.Name = "btnNuevoBanco"
            Me.btnNuevoBanco.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevoBanco.Text = "NUEVO"
            '
            'btnGuardarBanco
            '
            Me.btnGuardarBanco.Enabled = False
            Me.btnGuardarBanco.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarBanco.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarBanco.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarBanco.Name = "btnGuardarBanco"
            Me.btnGuardarBanco.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardarBanco.Text = "GUARDAR"
            '
            'btnModificarBanco
            '
            Me.btnModificarBanco.Enabled = False
            Me.btnModificarBanco.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificarBanco.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificarBanco.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificarBanco.Name = "btnModificarBanco"
            Me.btnModificarBanco.Size = New System.Drawing.Size(106, 28)
            Me.btnModificarBanco.Text = "MODIFICAR"
            '
            'btnCancelarBanco
            '
            Me.btnCancelarBanco.Enabled = False
            Me.btnCancelarBanco.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarBanco.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarBanco.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelarBanco.Name = "btnCancelarBanco"
            Me.btnCancelarBanco.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelarBanco.Text = "CANCELAR"
            '
            'btnReporteBanco
            '
            Me.btnReporteBanco.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporteBanco.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporteBanco.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporteBanco.Name = "btnReporteBanco"
            Me.btnReporteBanco.Size = New System.Drawing.Size(92, 28)
            Me.btnReporteBanco.Text = "REPORTE"
            '
            'txtIdBanco
            '
            Me.txtIdBanco.BackColor = System.Drawing.Color.White
            Me.txtIdBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdBanco.Location = New System.Drawing.Point(78, 15)
            Me.txtIdBanco.Name = "txtIdBanco"
            Me.txtIdBanco.Size = New System.Drawing.Size(39, 21)
            Me.txtIdBanco.TabIndex = 8
            '
            'lblEmail
            '
            Me.lblEmail.AutoSize = True
            Me.lblEmail.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEmail.Location = New System.Drawing.Point(513, 98)
            Me.lblEmail.Name = "lblEmail"
            Me.lblEmail.Size = New System.Drawing.Size(51, 13)
            Me.lblEmail.TabIndex = 7
            Me.lblEmail.Text = "E - MAIL:"
            '
            'txtNombreBanco
            '
            Me.txtNombreBanco.BackColor = System.Drawing.Color.White
            Me.txtNombreBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreBanco.Location = New System.Drawing.Point(78, 43)
            Me.txtNombreBanco.Name = "txtNombreBanco"
            Me.txtNombreBanco.Size = New System.Drawing.Size(410, 21)
            Me.txtNombreBanco.TabIndex = 9
            '
            'lblFax
            '
            Me.lblFax.AutoSize = True
            Me.lblFax.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFax.Location = New System.Drawing.Point(513, 72)
            Me.lblFax.Name = "lblFax"
            Me.lblFax.Size = New System.Drawing.Size(74, 13)
            Me.lblFax.TabIndex = 6
            Me.lblFax.Text = "NRO DE FAX :"
            '
            'lblTelefonos
            '
            Me.lblTelefonos.AutoSize = True
            Me.lblTelefonos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefonos.Location = New System.Drawing.Point(513, 46)
            Me.lblTelefonos.Name = "lblTelefonos"
            Me.lblTelefonos.Size = New System.Drawing.Size(68, 13)
            Me.lblTelefonos.TabIndex = 5
            Me.lblTelefonos.Text = "TELEFONO :"
            '
            'txtDireccionBanco
            '
            Me.txtDireccionBanco.BackColor = System.Drawing.Color.White
            Me.txtDireccionBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccionBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccionBanco.Location = New System.Drawing.Point(78, 69)
            Me.txtDireccionBanco.Multiline = True
            Me.txtDireccionBanco.Name = "txtDireccionBanco"
            Me.txtDireccionBanco.Size = New System.Drawing.Size(410, 20)
            Me.txtDireccionBanco.TabIndex = 11
            '
            'lblOficialCredito
            '
            Me.lblOficialCredito.AutoSize = True
            Me.lblOficialCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOficialCredito.Location = New System.Drawing.Point(10, 98)
            Me.lblOficialCredito.Name = "lblOficialCredito"
            Me.lblOficialCredito.Size = New System.Drawing.Size(117, 13)
            Me.lblOficialCredito.TabIndex = 4
            Me.lblOficialCredito.Text = "OFICIAL DE CREDITO :"
            '
            'txtOficialCreditoBanco
            '
            Me.txtOficialCreditoBanco.BackColor = System.Drawing.Color.White
            Me.txtOficialCreditoBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtOficialCreditoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOficialCreditoBanco.Location = New System.Drawing.Point(141, 95)
            Me.txtOficialCreditoBanco.Name = "txtOficialCreditoBanco"
            Me.txtOficialCreditoBanco.Size = New System.Drawing.Size(347, 21)
            Me.txtOficialCreditoBanco.TabIndex = 12
            '
            'lblDireccionBanco
            '
            Me.lblDireccionBanco.AutoSize = True
            Me.lblDireccionBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDireccionBanco.Location = New System.Drawing.Point(10, 72)
            Me.lblDireccionBanco.Name = "lblDireccionBanco"
            Me.lblDireccionBanco.Size = New System.Drawing.Size(66, 13)
            Me.lblDireccionBanco.TabIndex = 3
            Me.lblDireccionBanco.Text = "DIRECCION:"
            '
            'txtTelefonoBanco
            '
            Me.txtTelefonoBanco.BackColor = System.Drawing.Color.White
            Me.txtTelefonoBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTelefonoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefonoBanco.Location = New System.Drawing.Point(599, 43)
            Me.txtTelefonoBanco.Name = "txtTelefonoBanco"
            Me.txtTelefonoBanco.Size = New System.Drawing.Size(114, 21)
            Me.txtTelefonoBanco.TabIndex = 13
            '
            'txtFaxBanco
            '
            Me.txtFaxBanco.BackColor = System.Drawing.Color.White
            Me.txtFaxBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFaxBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFaxBanco.Location = New System.Drawing.Point(599, 69)
            Me.txtFaxBanco.Name = "txtFaxBanco"
            Me.txtFaxBanco.Size = New System.Drawing.Size(114, 21)
            Me.txtFaxBanco.TabIndex = 14
            '
            'lblNombreBanco
            '
            Me.lblNombreBanco.AutoSize = True
            Me.lblNombreBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreBanco.Location = New System.Drawing.Point(10, 46)
            Me.lblNombreBanco.Name = "lblNombreBanco"
            Me.lblNombreBanco.Size = New System.Drawing.Size(59, 13)
            Me.lblNombreBanco.TabIndex = 1
            Me.lblNombreBanco.Text = "NOMBRE :"
            '
            'txtEMailBanco
            '
            Me.txtEMailBanco.BackColor = System.Drawing.Color.White
            Me.txtEMailBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtEMailBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEMailBanco.Location = New System.Drawing.Point(599, 95)
            Me.txtEMailBanco.Name = "txtEMailBanco"
            Me.txtEMailBanco.Size = New System.Drawing.Size(114, 21)
            Me.txtEMailBanco.TabIndex = 15
            '
            'lblIdBanco
            '
            Me.lblIdBanco.AutoSize = True
            Me.lblIdBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdBanco.Location = New System.Drawing.Point(10, 18)
            Me.lblIdBanco.Name = "lblIdBanco"
            Me.lblIdBanco.Size = New System.Drawing.Size(23, 13)
            Me.lblIdBanco.TabIndex = 0
            Me.lblIdBanco.Text = "ID :"
            '
            'lblCodigoCuentaBanco
            '
            Me.lblCodigoCuentaBanco.AutoSize = True
            Me.lblCodigoCuentaBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigoCuentaBanco.Location = New System.Drawing.Point(126, 18)
            Me.lblCodigoCuentaBanco.Name = "lblCodigoCuentaBanco"
            Me.lblCodigoCuentaBanco.Size = New System.Drawing.Size(54, 13)
            Me.lblCodigoCuentaBanco.TabIndex = 16
            Me.lblCodigoCuentaBanco.Text = "CODIGO :"
            '
            'txtCodigoCuentaBanco
            '
            Me.txtCodigoCuentaBanco.BackColor = System.Drawing.Color.White
            Me.txtCodigoCuentaBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCodigoCuentaBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoCuentaBanco.Location = New System.Drawing.Point(187, 15)
            Me.txtCodigoCuentaBanco.Name = "txtCodigoCuentaBanco"
            Me.txtCodigoCuentaBanco.Size = New System.Drawing.Size(100, 21)
            Me.txtCodigoCuentaBanco.TabIndex = 17
            '
            'gpBancos
            '
            Me.gpBancos.BackColor = System.Drawing.Color.White
            Me.gpBancos.Controls.Add(Me.txtCodigoCuentaBanco)
            Me.gpBancos.Controls.Add(Me.lblCodigoCuentaBanco)
            Me.gpBancos.Controls.Add(Me.lblIdBanco)
            Me.gpBancos.Controls.Add(Me.txtEMailBanco)
            Me.gpBancos.Controls.Add(Me.lblNombreBanco)
            Me.gpBancos.Controls.Add(Me.txtFaxBanco)
            Me.gpBancos.Controls.Add(Me.txtTelefonoBanco)
            Me.gpBancos.Controls.Add(Me.lblDireccionBanco)
            Me.gpBancos.Controls.Add(Me.txtOficialCreditoBanco)
            Me.gpBancos.Controls.Add(Me.lblOficialCredito)
            Me.gpBancos.Controls.Add(Me.txtDireccionBanco)
            Me.gpBancos.Controls.Add(Me.lblTelefonos)
            Me.gpBancos.Controls.Add(Me.lblFax)
            Me.gpBancos.Controls.Add(Me.txtNombreBanco)
            Me.gpBancos.Controls.Add(Me.lblEmail)
            Me.gpBancos.Controls.Add(Me.txtIdBanco)
            Me.gpBancos.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gpBancos.Location = New System.Drawing.Point(1, 36)
            Me.gpBancos.Name = "gpBancos"
            Me.gpBancos.Size = New System.Drawing.Size(721, 122)
            Me.gpBancos.TabIndex = 16
            Me.gpBancos.TabStop = False
            Me.gpBancos.Text = "BANCOS"
            '
            'FormRegistroBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(723, 393)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.dgvBancos)
            Me.Controls.Add(Me.gpBancos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormRegistroBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REGISTRO DE BANCOS"
            CType(Me.dgvBancos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            Me.gpBancos.ResumeLayout(False)
            Me.gpBancos.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvBancos As System.Windows.Forms.DataGridView
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoBanco As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarBanco As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarBanco As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarBanco As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporteBanco As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtIdBanco As System.Windows.Forms.TextBox
        Friend WithEvents lblEmail As System.Windows.Forms.Label
        Friend WithEvents txtNombreBanco As System.Windows.Forms.TextBox
        Friend WithEvents lblFax As System.Windows.Forms.Label
        Friend WithEvents lblTelefonos As System.Windows.Forms.Label
        Friend WithEvents txtDireccionBanco As System.Windows.Forms.TextBox
        Friend WithEvents lblOficialCredito As System.Windows.Forms.Label
        Friend WithEvents txtOficialCreditoBanco As System.Windows.Forms.TextBox
        Friend WithEvents lblDireccionBanco As System.Windows.Forms.Label
        Friend WithEvents txtTelefonoBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtFaxBanco As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreBanco As System.Windows.Forms.Label
        Friend WithEvents txtEMailBanco As System.Windows.Forms.TextBox
        Friend WithEvents lblIdBanco As System.Windows.Forms.Label
        Friend WithEvents lblCodigoCuentaBanco As System.Windows.Forms.Label
        Friend WithEvents txtCodigoCuentaBanco As System.Windows.Forms.TextBox
        Friend WithEvents gpBancos As System.Windows.Forms.GroupBox
    End Class
End Namespace