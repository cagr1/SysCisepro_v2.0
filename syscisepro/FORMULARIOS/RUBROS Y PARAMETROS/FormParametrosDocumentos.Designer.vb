Namespace FORMULARIOS.RUBROS_Y_PARAMETROS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormParametrosDocumentos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormParametrosDocumentos))
            Me.dgvParametrosDocumentos = New System.Windows.Forms.DataGridView()
            Me.txtIdParametro = New System.Windows.Forms.TextBox()
            Me.txtDetalleParametro = New System.Windows.Forms.TextBox()
            Me.rbDeducible = New System.Windows.Forms.RadioButton()
            Me.rbNoDeducible = New System.Windows.Forms.RadioButton()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoParametroDocumentos = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarParametroDocumentos = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarParametroDocumentos = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarParametroDocumentos = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.txtTipoDocumento = New System.Windows.Forms.TextBox()
            CType(Me.dgvParametrosDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvParametrosDocumentos
            '
            Me.dgvParametrosDocumentos.AllowUserToAddRows = False
            Me.dgvParametrosDocumentos.AllowUserToDeleteRows = False
            Me.dgvParametrosDocumentos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvParametrosDocumentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvParametrosDocumentos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgvParametrosDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvParametrosDocumentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvParametrosDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvParametrosDocumentos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvParametrosDocumentos.Location = New System.Drawing.Point(2, 114)
            Me.dgvParametrosDocumentos.MultiSelect = False
            Me.dgvParametrosDocumentos.Name = "dgvParametrosDocumentos"
            Me.dgvParametrosDocumentos.ReadOnly = True
            Me.dgvParametrosDocumentos.RowHeadersVisible = False
            Me.dgvParametrosDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvParametrosDocumentos.Size = New System.Drawing.Size(390, 240)
            Me.dgvParametrosDocumentos.TabIndex = 15
            '
            'txtIdParametro
            '
            Me.txtIdParametro.BackColor = System.Drawing.Color.White
            Me.txtIdParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdParametro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdParametro.Location = New System.Drawing.Point(83, 33)
            Me.txtIdParametro.Name = "txtIdParametro"
            Me.txtIdParametro.Size = New System.Drawing.Size(36, 22)
            Me.txtIdParametro.TabIndex = 12
            '
            'txtDetalleParametro
            '
            Me.txtDetalleParametro.BackColor = System.Drawing.Color.White
            Me.txtDetalleParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleParametro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalleParametro.Location = New System.Drawing.Point(83, 61)
            Me.txtDetalleParametro.Name = "txtDetalleParametro"
            Me.txtDetalleParametro.Size = New System.Drawing.Size(276, 22)
            Me.txtDetalleParametro.TabIndex = 18
            '
            'rbDeducible
            '
            Me.rbDeducible.AutoSize = True
            Me.rbDeducible.Enabled = False
            Me.rbDeducible.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbDeducible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbDeducible.Location = New System.Drawing.Point(12, 87)
            Me.rbDeducible.Name = "rbDeducible"
            Me.rbDeducible.Size = New System.Drawing.Size(77, 17)
            Me.rbDeducible.TabIndex = 19
            Me.rbDeducible.TabStop = True
            Me.rbDeducible.Text = "Deducible"
            Me.rbDeducible.UseVisualStyleBackColor = True
            '
            'rbNoDeducible
            '
            Me.rbNoDeducible.AutoSize = True
            Me.rbNoDeducible.Enabled = False
            Me.rbNoDeducible.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNoDeducible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbNoDeducible.Location = New System.Drawing.Point(104, 87)
            Me.rbNoDeducible.Name = "rbNoDeducible"
            Me.rbNoDeducible.Size = New System.Drawing.Size(95, 17)
            Me.rbNoDeducible.TabIndex = 20
            Me.rbNoDeducible.TabStop = True
            Me.rbNoDeducible.Text = "No Deducible"
            Me.rbNoDeducible.UseVisualStyleBackColor = True
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoParametroDocumentos, Me.btnGuardarParametroDocumentos, Me.btnModificarParametroDocumentos, Me.btnCancelarParametroDocumentos})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(394, 32)
            Me.MenuStrip1.TabIndex = 186
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoParametroDocumentos
            '
            Me.btnNuevoParametroDocumentos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoParametroDocumentos.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoParametroDocumentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoParametroDocumentos.Name = "btnNuevoParametroDocumentos"
            Me.btnNuevoParametroDocumentos.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevoParametroDocumentos.Text = "NUEVO"
            '
            'btnGuardarParametroDocumentos
            '
            Me.btnGuardarParametroDocumentos.Enabled = False
            Me.btnGuardarParametroDocumentos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarParametroDocumentos.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarParametroDocumentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarParametroDocumentos.Name = "btnGuardarParametroDocumentos"
            Me.btnGuardarParametroDocumentos.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardarParametroDocumentos.Text = "GUARDAR"
            '
            'btnModificarParametroDocumentos
            '
            Me.btnModificarParametroDocumentos.Enabled = False
            Me.btnModificarParametroDocumentos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificarParametroDocumentos.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificarParametroDocumentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificarParametroDocumentos.Name = "btnModificarParametroDocumentos"
            Me.btnModificarParametroDocumentos.Size = New System.Drawing.Size(113, 28)
            Me.btnModificarParametroDocumentos.Text = "ACTUALIZAR"
            '
            'btnCancelarParametroDocumentos
            '
            Me.btnCancelarParametroDocumentos.Enabled = False
            Me.btnCancelarParametroDocumentos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarParametroDocumentos.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarParametroDocumentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelarParametroDocumentos.Name = "btnCancelarParametroDocumentos"
            Me.btnCancelarParametroDocumentos.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelarParametroDocumentos.Text = "CANCELAR"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(12, 35)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel1.TabIndex = 187
            Me.KryptonLabel1.Values.Text = "Id"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(12, 61)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel2.TabIndex = 188
            Me.KryptonLabel2.Values.Text = "Detalle"
            '
            'txtTipoDocumento
            '
            Me.txtTipoDocumento.BackColor = System.Drawing.Color.White
            Me.txtTipoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoDocumento.Enabled = False
            Me.txtTipoDocumento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipoDocumento.Location = New System.Drawing.Point(234, 86)
            Me.txtTipoDocumento.Name = "txtTipoDocumento"
            Me.txtTipoDocumento.Size = New System.Drawing.Size(125, 22)
            Me.txtTipoDocumento.TabIndex = 21
            '
            'FormParametrosDocumentos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(394, 355)
            Me.Controls.Add(Me.KryptonLabel2)
            Me.Controls.Add(Me.txtTipoDocumento)
            Me.Controls.Add(Me.KryptonLabel1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.txtDetalleParametro)
            Me.Controls.Add(Me.txtIdParametro)
            Me.Controls.Add(Me.rbNoDeducible)
            Me.Controls.Add(Me.dgvParametrosDocumentos)
            Me.Controls.Add(Me.rbDeducible)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormParametrosDocumentos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "PARAMETROS DE DOCUMENTOS"
            CType(Me.dgvParametrosDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvParametrosDocumentos As System.Windows.Forms.DataGridView
        Friend WithEvents txtIdParametro As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalleParametro As System.Windows.Forms.TextBox
        Friend WithEvents rbDeducible As System.Windows.Forms.RadioButton
        Friend WithEvents rbNoDeducible As System.Windows.Forms.RadioButton
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoParametroDocumentos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarParametroDocumentos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarParametroDocumentos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarParametroDocumentos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtTipoDocumento As TextBox
    End Class
End Namespace