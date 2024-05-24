Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormConsultaMantenimientosProximos
        Inherits System.Windows.Forms.Form

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
            Me.dgvMantenimientosProximos.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvMantenimientosProximos.Size = New System.Drawing.Size(988, 412)
            Me.dgvMantenimientosProximos.TabIndex = 0
            '
            'rbSemana
            '
            Me.rbSemana.AutoSize = True
            Me.rbSemana.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbSemana.Location = New System.Drawing.Point(152, 5)
            Me.rbSemana.Name = "rbSemana"
            Me.rbSemana.Size = New System.Drawing.Size(63, 17)
            Me.rbSemana.TabIndex = 1
            Me.rbSemana.TabStop = True
            Me.rbSemana.Text = "SEMANA"
            Me.rbSemana.UseVisualStyleBackColor = True
            '
            'rbTodos
            '
            Me.rbTodos.AutoSize = True
            Me.rbTodos.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTodos.Location = New System.Drawing.Point(11, 4)
            Me.rbTodos.Name = "rbTodos"
            Me.rbTodos.Size = New System.Drawing.Size(56, 17)
            Me.rbTodos.TabIndex = 2
            Me.rbTodos.TabStop = True
            Me.rbTodos.Text = "TODOS"
            Me.rbTodos.UseVisualStyleBackColor = True
            '
            'btnFiltrar
            '
            Me.btnFiltrar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
            Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnFiltrar.Location = New System.Drawing.Point(271, 3)
            Me.btnFiltrar.Name = "btnFiltrar"
            Me.btnFiltrar.Size = New System.Drawing.Size(90, 27)
            Me.btnFiltrar.TabIndex = 3
            Me.btnFiltrar.Text = "FILTRAR"
            Me.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnFiltrar.UseVisualStyleBackColor = True
            '
            'btnMayores
            '
            Me.btnMayores.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.btnMayores.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnMayores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnMayores.Location = New System.Drawing.Point(367, 3)
            Me.btnMayores.Name = "btnMayores"
            Me.btnMayores.Size = New System.Drawing.Size(90, 27)
            Me.btnMayores.TabIndex = 287
            Me.btnMayores.Text = "EXPORTAR"
            Me.btnMayores.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnMayores.UseVisualStyleBackColor = True
            '
            'FormConsultaMantenimientosProximos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(989, 445)
            Me.Controls.Add(Me.btnMayores)
            Me.Controls.Add(Me.btnFiltrar)
            Me.Controls.Add(Me.rbTodos)
            Me.Controls.Add(Me.rbSemana)
            Me.Controls.Add(Me.dgvMantenimientosProximos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormConsultaMantenimientosProximos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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