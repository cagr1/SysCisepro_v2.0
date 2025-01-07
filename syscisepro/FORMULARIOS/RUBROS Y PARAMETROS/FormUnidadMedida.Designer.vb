Namespace FORMULARIOS.RUBROS_Y_PARAMETROS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormUnidadMedida
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUnidadMedida))
            Me.txtCodigoUnidadMedida = New System.Windows.Forms.TextBox()
            Me.txtDetalleUnidadMedida = New System.Windows.Forms.TextBox()
            Me.txtIdUnidadMedida = New System.Windows.Forms.TextBox()
            Me.dgvUnidadMedida = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoUnidadMedida = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarUnidadMedida = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarUnidadMedida = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarUnidadMedida = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvUnidadMedida, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtCodigoUnidadMedida
            '
            Me.txtCodigoUnidadMedida.BackColor = System.Drawing.Color.White
            Me.txtCodigoUnidadMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCodigoUnidadMedida.Location = New System.Drawing.Point(68, 91)
            Me.txtCodigoUnidadMedida.Name = "txtCodigoUnidadMedida"
            Me.txtCodigoUnidadMedida.Size = New System.Drawing.Size(231, 22)
            Me.txtCodigoUnidadMedida.TabIndex = 5
            '
            'txtDetalleUnidadMedida
            '
            Me.txtDetalleUnidadMedida.BackColor = System.Drawing.Color.White
            Me.txtDetalleUnidadMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleUnidadMedida.Location = New System.Drawing.Point(68, 63)
            Me.txtDetalleUnidadMedida.Name = "txtDetalleUnidadMedida"
            Me.txtDetalleUnidadMedida.Size = New System.Drawing.Size(231, 22)
            Me.txtDetalleUnidadMedida.TabIndex = 3
            '
            'txtIdUnidadMedida
            '
            Me.txtIdUnidadMedida.BackColor = System.Drawing.Color.White
            Me.txtIdUnidadMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdUnidadMedida.Location = New System.Drawing.Point(68, 36)
            Me.txtIdUnidadMedida.Name = "txtIdUnidadMedida"
            Me.txtIdUnidadMedida.Size = New System.Drawing.Size(83, 22)
            Me.txtIdUnidadMedida.TabIndex = 1
            '
            'dgvUnidadMedida
            '
            Me.dgvUnidadMedida.AllowUserToAddRows = False
            Me.dgvUnidadMedida.AllowUserToDeleteRows = False
            Me.dgvUnidadMedida.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvUnidadMedida.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvUnidadMedida.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgvUnidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvUnidadMedida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvUnidadMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvUnidadMedida.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvUnidadMedida.Location = New System.Drawing.Point(0, 123)
            Me.dgvUnidadMedida.MultiSelect = False
            Me.dgvUnidadMedida.Name = "dgvUnidadMedida"
            Me.dgvUnidadMedida.ReadOnly = True
            Me.dgvUnidadMedida.RowHeadersVisible = False
            Me.dgvUnidadMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvUnidadMedida.Size = New System.Drawing.Size(389, 170)
            Me.dgvUnidadMedida.TabIndex = 16
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoUnidadMedida, Me.btnGuardarUnidadMedida, Me.btnModificarUnidadMedida, Me.btnCancelarUnidadMedida})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(389, 32)
            Me.MenuStrip1.TabIndex = 186
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoUnidadMedida
            '
            Me.btnNuevoUnidadMedida.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoUnidadMedida.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoUnidadMedida.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoUnidadMedida.Name = "btnNuevoUnidadMedida"
            Me.btnNuevoUnidadMedida.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevoUnidadMedida.Text = "NUEVO"
            '
            'btnGuardarUnidadMedida
            '
            Me.btnGuardarUnidadMedida.Enabled = False
            Me.btnGuardarUnidadMedida.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarUnidadMedida.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarUnidadMedida.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarUnidadMedida.Name = "btnGuardarUnidadMedida"
            Me.btnGuardarUnidadMedida.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardarUnidadMedida.Text = "GUARDAR"
            '
            'btnModificarUnidadMedida
            '
            Me.btnModificarUnidadMedida.Enabled = False
            Me.btnModificarUnidadMedida.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificarUnidadMedida.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificarUnidadMedida.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificarUnidadMedida.Name = "btnModificarUnidadMedida"
            Me.btnModificarUnidadMedida.Size = New System.Drawing.Size(113, 28)
            Me.btnModificarUnidadMedida.Text = "ACTUALIZAR"
            '
            'btnCancelarUnidadMedida
            '
            Me.btnCancelarUnidadMedida.Enabled = False
            Me.btnCancelarUnidadMedida.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarUnidadMedida.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarUnidadMedida.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelarUnidadMedida.Name = "btnCancelarUnidadMedida"
            Me.btnCancelarUnidadMedida.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelarUnidadMedida.Text = "CANCELAR"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(13, 36)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel1.TabIndex = 187
            Me.KryptonLabel1.Values.Text = "Id"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(13, 65)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel2.TabIndex = 188
            Me.KryptonLabel2.Values.Text = "Detalle"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(13, 91)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel3.TabIndex = 189
            Me.KryptonLabel3.Values.Text = "Codigo"
            '
            'FormUnidadMedida
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(389, 293)
            Me.Controls.Add(Me.txtCodigoUnidadMedida)
            Me.Controls.Add(Me.KryptonLabel3)
            Me.Controls.Add(Me.KryptonLabel2)
            Me.Controls.Add(Me.KryptonLabel1)
            Me.Controls.Add(Me.txtDetalleUnidadMedida)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvUnidadMedida)
            Me.Controls.Add(Me.txtIdUnidadMedida)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormUnidadMedida"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "UNIDAD DE MEDIDA"
            CType(Me.dgvUnidadMedida, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtDetalleUnidadMedida As System.Windows.Forms.TextBox
        Friend WithEvents txtIdUnidadMedida As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigoUnidadMedida As System.Windows.Forms.TextBox
        Friend WithEvents dgvUnidadMedida As System.Windows.Forms.DataGridView
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoUnidadMedida As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarUnidadMedida As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarUnidadMedida As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarUnidadMedida As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace