Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormConsultaMantenimientosProximos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaMantenimientosProximos))
            Me.dgvMantenimientosProximos = New System.Windows.Forms.DataGridView()
            Me.rbSemana = New System.Windows.Forms.RadioButton()
            Me.rbTodos = New System.Windows.Forms.RadioButton()
            Me.btnFiltrar = New System.Windows.Forms.Button()
            Me.btnMayores = New System.Windows.Forms.Button()
            CType(Me.dgvMantenimientosProximos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvMantenimientosProximos
            '
            Me.dgvMantenimientosProximos.AllowUserToAddRows = False
            Me.dgvMantenimientosProximos.AllowUserToDeleteRows = False
            Me.dgvMantenimientosProximos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvMantenimientosProximos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvMantenimientosProximos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvMantenimientosProximos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvMantenimientosProximos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvMantenimientosProximos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMantenimientosProximos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvMantenimientosProximos.Location = New System.Drawing.Point(1, 33)
            Me.dgvMantenimientosProximos.MultiSelect = False
            Me.dgvMantenimientosProximos.Name = "dgvMantenimientosProximos"
            Me.dgvMantenimientosProximos.ReadOnly = True
            Me.dgvMantenimientosProximos.RowHeadersVisible = False
            Me.dgvMantenimientosProximos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMantenimientosProximos.Size = New System.Drawing.Size(784, 412)
            Me.dgvMantenimientosProximos.TabIndex = 0
            '
            'rbSemana
            '
            Me.rbSemana.AutoSize = True
            Me.rbSemana.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbSemana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbSemana.Location = New System.Drawing.Point(102, 4)
            Me.rbSemana.Name = "rbSemana"
            Me.rbSemana.Size = New System.Drawing.Size(66, 17)
            Me.rbSemana.TabIndex = 1
            Me.rbSemana.TabStop = True
            Me.rbSemana.Text = "Semana"
            Me.rbSemana.UseVisualStyleBackColor = True
            '
            'rbTodos
            '
            Me.rbTodos.AutoSize = True
            Me.rbTodos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTodos.Location = New System.Drawing.Point(11, 4)
            Me.rbTodos.Name = "rbTodos"
            Me.rbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rbTodos.TabIndex = 2
            Me.rbTodos.TabStop = True
            Me.rbTodos.Text = "Todos"
            Me.rbTodos.UseVisualStyleBackColor = True
            '
            'btnFiltrar
            '
            Me.btnFiltrar.FlatAppearance.BorderSize = 0
            Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnFiltrar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFiltrar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnFiltrar.Location = New System.Drawing.Point(190, 1)
            Me.btnFiltrar.Name = "btnFiltrar"
            Me.btnFiltrar.Size = New System.Drawing.Size(32, 27)
            Me.btnFiltrar.TabIndex = 3
            Me.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnFiltrar.UseVisualStyleBackColor = True
            '
            'btnMayores
            '
            Me.btnMayores.FlatAppearance.BorderSize = 0
            Me.btnMayores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMayores.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnMayores.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnMayores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnMayores.Location = New System.Drawing.Point(240, 2)
            Me.btnMayores.Name = "btnMayores"
            Me.btnMayores.Size = New System.Drawing.Size(38, 27)
            Me.btnMayores.TabIndex = 287
            Me.btnMayores.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnMayores.UseVisualStyleBackColor = True
            '
            'FormConsultaMantenimientosProximos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(787, 445)
            Me.Controls.Add(Me.btnMayores)
            Me.Controls.Add(Me.btnFiltrar)
            Me.Controls.Add(Me.rbTodos)
            Me.Controls.Add(Me.rbSemana)
            Me.Controls.Add(Me.dgvMantenimientosProximos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormConsultaMantenimientosProximos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CONSULTA DE MANTENIMIENTO DE ACTIVOS PRÓXIMOS"
            CType(Me.dgvMantenimientosProximos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvMantenimientosProximos As System.Windows.Forms.DataGridView
        Friend WithEvents rbSemana As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents btnFiltrar As System.Windows.Forms.Button
        Friend WithEvents btnMayores As System.Windows.Forms.Button
    End Class
End Namespace