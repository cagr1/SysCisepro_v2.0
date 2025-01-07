Namespace FORMULARIOS.RUBROS_Y_PARAMETROS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormRubros
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRubros))
            Me.cmbRubro = New System.Windows.Forms.ComboBox()
            Me.txtIdRubro = New System.Windows.Forms.TextBox()
            Me.txtValorRubro = New System.Windows.Forms.TextBox()
            Me.dgvRubrosFondoRotativo = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoRubroFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarRubroFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarRubroFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarRubroFondorotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvRubrosFondoRotativo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'cmbRubro
            '
            Me.cmbRubro.BackColor = System.Drawing.Color.White
            Me.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbRubro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbRubro.FormattingEnabled = True
            Me.cmbRubro.Items.AddRange(New Object() {"GASOLINA SUPER", "GASOLINA EXTRA", "DIESEL"})
            Me.cmbRubro.Location = New System.Drawing.Point(157, 42)
            Me.cmbRubro.Name = "cmbRubro"
            Me.cmbRubro.Size = New System.Drawing.Size(202, 21)
            Me.cmbRubro.TabIndex = 1
            '
            'txtIdRubro
            '
            Me.txtIdRubro.BackColor = System.Drawing.Color.White
            Me.txtIdRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdRubro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdRubro.Location = New System.Drawing.Point(58, 43)
            Me.txtIdRubro.Name = "txtIdRubro"
            Me.txtIdRubro.Size = New System.Drawing.Size(43, 22)
            Me.txtIdRubro.TabIndex = 3
            '
            'txtValorRubro
            '
            Me.txtValorRubro.BackColor = System.Drawing.Color.White
            Me.txtValorRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorRubro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorRubro.Location = New System.Drawing.Point(58, 73)
            Me.txtValorRubro.Name = "txtValorRubro"
            Me.txtValorRubro.Size = New System.Drawing.Size(136, 22)
            Me.txtValorRubro.TabIndex = 5
            '
            'dgvRubrosFondoRotativo
            '
            Me.dgvRubrosFondoRotativo.AllowUserToAddRows = False
            Me.dgvRubrosFondoRotativo.AllowUserToDeleteRows = False
            Me.dgvRubrosFondoRotativo.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvRubrosFondoRotativo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvRubrosFondoRotativo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgvRubrosFondoRotativo.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvRubrosFondoRotativo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvRubrosFondoRotativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvRubrosFondoRotativo.Location = New System.Drawing.Point(0, 109)
            Me.dgvRubrosFondoRotativo.MultiSelect = False
            Me.dgvRubrosFondoRotativo.Name = "dgvRubrosFondoRotativo"
            Me.dgvRubrosFondoRotativo.ReadOnly = True
            Me.dgvRubrosFondoRotativo.RowHeadersVisible = False
            Me.dgvRubrosFondoRotativo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRubrosFondoRotativo.Size = New System.Drawing.Size(391, 148)
            Me.dgvRubrosFondoRotativo.TabIndex = 6
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoRubroFondoRotativo, Me.btnGuardarRubroFondoRotativo, Me.btnModificarRubroFondoRotativo, Me.btnCancelarRubroFondorotativo})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(391, 32)
            Me.MenuStrip1.TabIndex = 185
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoRubroFondoRotativo
            '
            Me.btnNuevoRubroFondoRotativo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoRubroFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoRubroFondoRotativo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoRubroFondoRotativo.Name = "btnNuevoRubroFondoRotativo"
            Me.btnNuevoRubroFondoRotativo.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevoRubroFondoRotativo.Text = "NUEVO"
            '
            'btnGuardarRubroFondoRotativo
            '
            Me.btnGuardarRubroFondoRotativo.Enabled = False
            Me.btnGuardarRubroFondoRotativo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarRubroFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarRubroFondoRotativo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarRubroFondoRotativo.Name = "btnGuardarRubroFondoRotativo"
            Me.btnGuardarRubroFondoRotativo.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardarRubroFondoRotativo.Text = "GUARDAR"
            '
            'btnModificarRubroFondoRotativo
            '
            Me.btnModificarRubroFondoRotativo.Enabled = False
            Me.btnModificarRubroFondoRotativo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificarRubroFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificarRubroFondoRotativo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificarRubroFondoRotativo.Name = "btnModificarRubroFondoRotativo"
            Me.btnModificarRubroFondoRotativo.Size = New System.Drawing.Size(113, 28)
            Me.btnModificarRubroFondoRotativo.Text = "ACTUALIZAR"
            '
            'btnCancelarRubroFondorotativo
            '
            Me.btnCancelarRubroFondorotativo.Enabled = False
            Me.btnCancelarRubroFondorotativo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarRubroFondorotativo.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarRubroFondorotativo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelarRubroFondorotativo.Name = "btnCancelarRubroFondorotativo"
            Me.btnCancelarRubroFondorotativo.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelarRubroFondorotativo.Text = "CANCELAR"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(13, 45)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel1.TabIndex = 186
            Me.KryptonLabel1.Values.Text = "Id"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(107, 43)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel2.TabIndex = 187
            Me.KryptonLabel2.Values.Text = "Rubro"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(13, 73)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel3.TabIndex = 188
            Me.KryptonLabel3.Values.Text = "Valor"
            '
            'FormRubros
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(391, 257)
            Me.Controls.Add(Me.KryptonLabel3)
            Me.Controls.Add(Me.txtValorRubro)
            Me.Controls.Add(Me.KryptonLabel2)
            Me.Controls.Add(Me.cmbRubro)
            Me.Controls.Add(Me.KryptonLabel1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.txtIdRubro)
            Me.Controls.Add(Me.dgvRubrosFondoRotativo)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormRubros"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CALCULOS"
            CType(Me.dgvRubrosFondoRotativo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents cmbRubro As System.Windows.Forms.ComboBox
        Friend WithEvents txtIdRubro As System.Windows.Forms.TextBox
        Friend WithEvents txtValorRubro As System.Windows.Forms.TextBox
        Friend WithEvents dgvRubrosFondoRotativo As System.Windows.Forms.DataGridView
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoRubroFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarRubroFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarRubroFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarRubroFondorotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace