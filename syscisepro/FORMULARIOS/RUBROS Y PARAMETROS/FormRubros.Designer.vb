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
            Me.lblRubro = New System.Windows.Forms.Label()
            Me.cmbRubro = New System.Windows.Forms.ComboBox()
            Me.lblIdRubro = New System.Windows.Forms.Label()
            Me.txtIdRubro = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtValorRubro = New System.Windows.Forms.TextBox()
            Me.dgvRubrosFondoRotativo = New System.Windows.Forms.DataGridView()
            Me.gbReferencia = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoRubroFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarRubroFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarRubroFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarRubroFondorotativo = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvRubrosFondoRotativo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbReferencia.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblRubro
            '
            Me.lblRubro.AutoSize = True
            Me.lblRubro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRubro.Location = New System.Drawing.Point(103, 19)
            Me.lblRubro.Name = "lblRubro"
            Me.lblRubro.Size = New System.Drawing.Size(47, 13)
            Me.lblRubro.TabIndex = 0
            Me.lblRubro.Text = "RUBRO:"
            '
            'cmbRubro
            '
            Me.cmbRubro.BackColor = System.Drawing.Color.White
            Me.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbRubro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbRubro.FormattingEnabled = True
            Me.cmbRubro.Items.AddRange(New Object() {"GASOLINA SUPER", "GASOLINA EXTRA", "DIESEL"})
            Me.cmbRubro.Location = New System.Drawing.Point(151, 17)
            Me.cmbRubro.Name = "cmbRubro"
            Me.cmbRubro.Size = New System.Drawing.Size(202, 21)
            Me.cmbRubro.TabIndex = 1
            '
            'lblIdRubro
            '
            Me.lblIdRubro.AutoSize = True
            Me.lblIdRubro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdRubro.Location = New System.Drawing.Point(12, 19)
            Me.lblIdRubro.Name = "lblIdRubro"
            Me.lblIdRubro.Size = New System.Drawing.Size(21, 13)
            Me.lblIdRubro.TabIndex = 2
            Me.lblIdRubro.Text = "ID:"
            '
            'txtIdRubro
            '
            Me.txtIdRubro.BackColor = System.Drawing.Color.White
            Me.txtIdRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdRubro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdRubro.Location = New System.Drawing.Point(40, 16)
            Me.txtIdRubro.Name = "txtIdRubro"
            Me.txtIdRubro.Size = New System.Drawing.Size(43, 22)
            Me.txtIdRubro.TabIndex = 3
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(140, 47)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(63, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "VALOR / %:"
            '
            'txtValorRubro
            '
            Me.txtValorRubro.BackColor = System.Drawing.Color.White
            Me.txtValorRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorRubro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorRubro.Location = New System.Drawing.Point(217, 44)
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
            Me.dgvRubrosFondoRotativo.BackgroundColor = System.Drawing.Color.White
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
            'gbReferencia
            '
            Me.gbReferencia.BackColor = System.Drawing.Color.White
            Me.gbReferencia.Controls.Add(Me.lblIdRubro)
            Me.gbReferencia.Controls.Add(Me.cmbRubro)
            Me.gbReferencia.Controls.Add(Me.txtIdRubro)
            Me.gbReferencia.Controls.Add(Me.txtValorRubro)
            Me.gbReferencia.Controls.Add(Me.Label1)
            Me.gbReferencia.Controls.Add(Me.lblRubro)
            Me.gbReferencia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbReferencia.Location = New System.Drawing.Point(0, 34)
            Me.gbReferencia.Name = "gbReferencia"
            Me.gbReferencia.Size = New System.Drawing.Size(391, 72)
            Me.gbReferencia.TabIndex = 9
            Me.gbReferencia.TabStop = False
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
            'FormRubros
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(391, 257)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbReferencia)
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
            Me.gbReferencia.ResumeLayout(False)
            Me.gbReferencia.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblRubro As System.Windows.Forms.Label
        Friend WithEvents cmbRubro As System.Windows.Forms.ComboBox
        Friend WithEvents lblIdRubro As System.Windows.Forms.Label
        Friend WithEvents txtIdRubro As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtValorRubro As System.Windows.Forms.TextBox
        Friend WithEvents dgvRubrosFondoRotativo As System.Windows.Forms.DataGridView
        Friend WithEvents gbReferencia As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoRubroFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarRubroFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarRubroFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarRubroFondorotativo As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace