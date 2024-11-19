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
            Me.txtNombreBanco = New System.Windows.Forms.TextBox()
            Me.txtDireccionBanco = New System.Windows.Forms.TextBox()
            Me.txtOficialCreditoBanco = New System.Windows.Forms.TextBox()
            Me.txtTelefonoBanco = New System.Windows.Forms.TextBox()
            Me.txtFaxBanco = New System.Windows.Forms.TextBox()
            Me.txtEMailBanco = New System.Windows.Forms.TextBox()
            Me.txtCodigoCuentaBanco = New System.Windows.Forms.TextBox()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvBancos
            '
            Me.dgvBancos.AllowUserToAddRows = False
            Me.dgvBancos.AllowUserToDeleteRows = False
            Me.dgvBancos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvBancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvBancos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvBancos.BorderStyle = System.Windows.Forms.BorderStyle.None
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
            Me.dgvBancos.Location = New System.Drawing.Point(12, 177)
            Me.dgvBancos.MultiSelect = False
            Me.dgvBancos.Name = "dgvBancos"
            Me.dgvBancos.ReadOnly = True
            Me.dgvBancos.RowHeadersVisible = False
            Me.dgvBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvBancos.Size = New System.Drawing.Size(511, 214)
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
            Me.msKardex.Size = New System.Drawing.Size(532, 32)
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
            Me.txtIdBanco.Location = New System.Drawing.Point(63, 3)
            Me.txtIdBanco.Name = "txtIdBanco"
            Me.txtIdBanco.Size = New System.Drawing.Size(39, 21)
            Me.txtIdBanco.TabIndex = 8
            '
            'txtNombreBanco
            '
            Me.txtNombreBanco.BackColor = System.Drawing.Color.White
            Me.txtNombreBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreBanco.Location = New System.Drawing.Point(63, 29)
            Me.txtNombreBanco.Name = "txtNombreBanco"
            Me.txtNombreBanco.Size = New System.Drawing.Size(220, 21)
            Me.txtNombreBanco.TabIndex = 9
            '
            'txtDireccionBanco
            '
            Me.txtDireccionBanco.BackColor = System.Drawing.Color.White
            Me.txtDireccionBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccionBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccionBanco.Location = New System.Drawing.Point(63, 55)
            Me.txtDireccionBanco.Multiline = True
            Me.txtDireccionBanco.Name = "txtDireccionBanco"
            Me.txtDireccionBanco.Size = New System.Drawing.Size(220, 20)
            Me.txtDireccionBanco.TabIndex = 11
            '
            'txtOficialCreditoBanco
            '
            Me.txtOficialCreditoBanco.BackColor = System.Drawing.Color.White
            Me.txtOficialCreditoBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtOficialCreditoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOficialCreditoBanco.Location = New System.Drawing.Point(94, 81)
            Me.txtOficialCreditoBanco.Name = "txtOficialCreditoBanco"
            Me.txtOficialCreditoBanco.Size = New System.Drawing.Size(189, 21)
            Me.txtOficialCreditoBanco.TabIndex = 12
            '
            'txtTelefonoBanco
            '
            Me.txtTelefonoBanco.BackColor = System.Drawing.Color.White
            Me.txtTelefonoBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTelefonoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefonoBanco.Location = New System.Drawing.Point(360, 4)
            Me.txtTelefonoBanco.Name = "txtTelefonoBanco"
            Me.txtTelefonoBanco.Size = New System.Drawing.Size(114, 21)
            Me.txtTelefonoBanco.TabIndex = 13
            '
            'txtFaxBanco
            '
            Me.txtFaxBanco.BackColor = System.Drawing.Color.White
            Me.txtFaxBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFaxBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFaxBanco.Location = New System.Drawing.Point(360, 28)
            Me.txtFaxBanco.Name = "txtFaxBanco"
            Me.txtFaxBanco.Size = New System.Drawing.Size(114, 21)
            Me.txtFaxBanco.TabIndex = 14
            '
            'txtEMailBanco
            '
            Me.txtEMailBanco.BackColor = System.Drawing.Color.White
            Me.txtEMailBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtEMailBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEMailBanco.Location = New System.Drawing.Point(360, 54)
            Me.txtEMailBanco.Name = "txtEMailBanco"
            Me.txtEMailBanco.Size = New System.Drawing.Size(137, 21)
            Me.txtEMailBanco.TabIndex = 15
            '
            'txtCodigoCuentaBanco
            '
            Me.txtCodigoCuentaBanco.BackColor = System.Drawing.Color.White
            Me.txtCodigoCuentaBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCodigoCuentaBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoCuentaBanco.Location = New System.Drawing.Point(183, 3)
            Me.txtCodigoCuentaBanco.Name = "txtCodigoCuentaBanco"
            Me.txtCodigoCuentaBanco.Size = New System.Drawing.Size(100, 21)
            Me.txtCodigoCuentaBanco.TabIndex = 17
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(8, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtEMailBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtOficialCreditoBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFaxBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCodigoCuentaBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTelefonoBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDireccionBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreBanco)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(515, 136)
            Me.KryptonGroupBox1.TabIndex = 186
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Id"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(127, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel2.TabIndex = 9
            Me.KryptonLabel2.Values.Text = "Codigo"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(298, 4)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(58, 20)
            Me.KryptonLabel3.TabIndex = 18
            Me.KryptonLabel3.Values.Text = "Telefono"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(3, 29)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel4.TabIndex = 19
            Me.KryptonLabel4.Values.Text = "Nombre"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(3, 55)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(62, 20)
            Me.KryptonLabel5.TabIndex = 20
            Me.KryptonLabel5.Values.Text = "Direccion"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(298, 30)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(28, 20)
            Me.KryptonLabel6.TabIndex = 21
            Me.KryptonLabel6.Values.Text = "Fax"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(298, 55)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(40, 20)
            Me.KryptonLabel7.TabIndex = 22
            Me.KryptonLabel7.Values.Text = "Email"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(3, 81)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(88, 20)
            Me.KryptonLabel8.TabIndex = 23
            Me.KryptonLabel8.Values.Text = "Oficial Credito"
            '
            'FormRegistroBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(532, 393)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.dgvBancos)
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
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
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
        Friend WithEvents txtNombreBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccionBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtOficialCreditoBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtTelefonoBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtFaxBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtEMailBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigoCuentaBanco As System.Windows.Forms.TextBox
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace