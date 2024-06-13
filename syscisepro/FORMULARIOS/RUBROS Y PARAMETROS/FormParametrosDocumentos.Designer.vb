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
            Me.lblIdParametro = New System.Windows.Forms.Label()
            Me.lblDetalleParametro = New System.Windows.Forms.Label()
            Me.txtDetalleParametro = New System.Windows.Forms.TextBox()
            Me.rbDeducible = New System.Windows.Forms.RadioButton()
            Me.rbNoDeducible = New System.Windows.Forms.RadioButton()
            Me.txtTipoDocumento = New System.Windows.Forms.TextBox()
            Me.gbReferencia = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoParametroDocumentos = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarParametroDocumentos = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarParametroDocumentos = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarParametroDocumentos = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvParametrosDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbReferencia.SuspendLayout()
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
            Me.dgvParametrosDocumentos.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvParametrosDocumentos.Location = New System.Drawing.Point(2, 136)
            Me.dgvParametrosDocumentos.MultiSelect = False
            Me.dgvParametrosDocumentos.Name = "dgvParametrosDocumentos"
            Me.dgvParametrosDocumentos.ReadOnly = True
            Me.dgvParametrosDocumentos.RowHeadersVisible = False
            Me.dgvParametrosDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvParametrosDocumentos.Size = New System.Drawing.Size(390, 218)
            Me.dgvParametrosDocumentos.TabIndex = 15
            '
            'txtIdParametro
            '
            Me.txtIdParametro.BackColor = System.Drawing.Color.White
            Me.txtIdParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdParametro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdParametro.Location = New System.Drawing.Point(70, 15)
            Me.txtIdParametro.Name = "txtIdParametro"
            Me.txtIdParametro.Size = New System.Drawing.Size(36, 22)
            Me.txtIdParametro.TabIndex = 12
            '
            'lblIdParametro
            '
            Me.lblIdParametro.AutoSize = True
            Me.lblIdParametro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdParametro.Location = New System.Drawing.Point(6, 18)
            Me.lblIdParametro.Name = "lblIdParametro"
            Me.lblIdParametro.Size = New System.Drawing.Size(24, 13)
            Me.lblIdParametro.TabIndex = 11
            Me.lblIdParametro.Text = "ID :"
            '
            'lblDetalleParametro
            '
            Me.lblDetalleParametro.AutoSize = True
            Me.lblDetalleParametro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDetalleParametro.Location = New System.Drawing.Point(6, 45)
            Me.lblDetalleParametro.Name = "lblDetalleParametro"
            Me.lblDetalleParametro.Size = New System.Drawing.Size(52, 13)
            Me.lblDetalleParametro.TabIndex = 9
            Me.lblDetalleParametro.Text = "DETALLE:"
            '
            'txtDetalleParametro
            '
            Me.txtDetalleParametro.BackColor = System.Drawing.Color.White
            Me.txtDetalleParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleParametro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalleParametro.Location = New System.Drawing.Point(70, 42)
            Me.txtDetalleParametro.Name = "txtDetalleParametro"
            Me.txtDetalleParametro.Size = New System.Drawing.Size(276, 22)
            Me.txtDetalleParametro.TabIndex = 18
            '
            'rbDeducible
            '
            Me.rbDeducible.AutoSize = True
            Me.rbDeducible.Enabled = False
            Me.rbDeducible.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbDeducible.Location = New System.Drawing.Point(9, 70)
            Me.rbDeducible.Name = "rbDeducible"
            Me.rbDeducible.Size = New System.Drawing.Size(82, 17)
            Me.rbDeducible.TabIndex = 19
            Me.rbDeducible.TabStop = True
            Me.rbDeducible.Text = "DEDUCIBLE"
            Me.rbDeducible.UseVisualStyleBackColor = True
            '
            'rbNoDeducible
            '
            Me.rbNoDeducible.AutoSize = True
            Me.rbNoDeducible.Enabled = False
            Me.rbNoDeducible.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNoDeducible.Location = New System.Drawing.Point(101, 70)
            Me.rbNoDeducible.Name = "rbNoDeducible"
            Me.rbNoDeducible.Size = New System.Drawing.Size(102, 17)
            Me.rbNoDeducible.TabIndex = 20
            Me.rbNoDeducible.TabStop = True
            Me.rbNoDeducible.Text = "NO DEDUCIBLE"
            Me.rbNoDeducible.UseVisualStyleBackColor = True
            '
            'txtTipoDocumento
            '
            Me.txtTipoDocumento.BackColor = System.Drawing.Color.White
            Me.txtTipoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoDocumento.Enabled = False
            Me.txtTipoDocumento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipoDocumento.Location = New System.Drawing.Point(221, 69)
            Me.txtTipoDocumento.Name = "txtTipoDocumento"
            Me.txtTipoDocumento.Size = New System.Drawing.Size(125, 22)
            Me.txtTipoDocumento.TabIndex = 21
            '
            'gbReferencia
            '
            Me.gbReferencia.BackColor = System.Drawing.Color.White
            Me.gbReferencia.Controls.Add(Me.lblIdParametro)
            Me.gbReferencia.Controls.Add(Me.txtTipoDocumento)
            Me.gbReferencia.Controls.Add(Me.lblDetalleParametro)
            Me.gbReferencia.Controls.Add(Me.rbNoDeducible)
            Me.gbReferencia.Controls.Add(Me.txtIdParametro)
            Me.gbReferencia.Controls.Add(Me.rbDeducible)
            Me.gbReferencia.Controls.Add(Me.txtDetalleParametro)
            Me.gbReferencia.Location = New System.Drawing.Point(2, 33)
            Me.gbReferencia.Name = "gbReferencia"
            Me.gbReferencia.Size = New System.Drawing.Size(390, 100)
            Me.gbReferencia.TabIndex = 22
            Me.gbReferencia.TabStop = False
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
            'FormParametrosDocumentos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(394, 355)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbReferencia)
            Me.Controls.Add(Me.dgvParametrosDocumentos)
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
            Me.gbReferencia.ResumeLayout(False)
            Me.gbReferencia.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvParametrosDocumentos As System.Windows.Forms.DataGridView
        Friend WithEvents txtIdParametro As System.Windows.Forms.TextBox
        Friend WithEvents lblIdParametro As System.Windows.Forms.Label
        Friend WithEvents lblDetalleParametro As System.Windows.Forms.Label
        Friend WithEvents txtDetalleParametro As System.Windows.Forms.TextBox
        Friend WithEvents rbDeducible As System.Windows.Forms.RadioButton
        Friend WithEvents rbNoDeducible As System.Windows.Forms.RadioButton
        Friend WithEvents txtTipoDocumento As System.Windows.Forms.TextBox
        Friend WithEvents gbReferencia As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoParametroDocumentos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarParametroDocumentos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarParametroDocumentos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarParametroDocumentos As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace