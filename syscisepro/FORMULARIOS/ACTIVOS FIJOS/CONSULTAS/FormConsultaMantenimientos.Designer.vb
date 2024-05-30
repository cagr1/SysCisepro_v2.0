Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormConsultaMantenimientos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaMantenimientos))
            Me.dgvActivosFijosMantenimientos = New System.Windows.Forms.DataGridView()
            Me.rbDia = New System.Windows.Forms.RadioButton()
            Me.rbSemana = New System.Windows.Forms.RadioButton()
            Me.btnConsultar = New System.Windows.Forms.Button()
            Me.gbMantenimientosProgramados = New System.Windows.Forms.GroupBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rbNoCumplidas = New System.Windows.Forms.RadioButton()
            Me.rbCumplidas = New System.Windows.Forms.RadioButton()
            Me.rbTodas = New System.Windows.Forms.RadioButton()
            Me.btnConsultarTodas = New System.Windows.Forms.Button()
            CType(Me.dgvActivosFijosMantenimientos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbMantenimientosProgramados.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvActivosFijosMantenimientos
            '
            Me.dgvActivosFijosMantenimientos.AllowUserToAddRows = False
            Me.dgvActivosFijosMantenimientos.AllowUserToDeleteRows = False
            Me.dgvActivosFijosMantenimientos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvActivosFijosMantenimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvActivosFijosMantenimientos.BackgroundColor = System.Drawing.Color.White
            Me.dgvActivosFijosMantenimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvActivosFijosMantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvActivosFijosMantenimientos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvActivosFijosMantenimientos.Location = New System.Drawing.Point(1, 49)
            Me.dgvActivosFijosMantenimientos.MultiSelect = False
            Me.dgvActivosFijosMantenimientos.Name = "dgvActivosFijosMantenimientos"
            Me.dgvActivosFijosMantenimientos.ReadOnly = True
            Me.dgvActivosFijosMantenimientos.RowHeadersVisible = False
            Me.dgvActivosFijosMantenimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvActivosFijosMantenimientos.Size = New System.Drawing.Size(984, 420)
            Me.dgvActivosFijosMantenimientos.TabIndex = 0
            '
            'rbDia
            '
            Me.rbDia.AutoSize = True
            Me.rbDia.Location = New System.Drawing.Point(25, 17)
            Me.rbDia.Name = "rbDia"
            Me.rbDia.Size = New System.Drawing.Size(42, 17)
            Me.rbDia.TabIndex = 1
            Me.rbDia.TabStop = True
            Me.rbDia.Text = "DIA"
            Me.rbDia.UseVisualStyleBackColor = True
            '
            'rbSemana
            '
            Me.rbSemana.AutoSize = True
            Me.rbSemana.Location = New System.Drawing.Point(155, 17)
            Me.rbSemana.Name = "rbSemana"
            Me.rbSemana.Size = New System.Drawing.Size(70, 17)
            Me.rbSemana.TabIndex = 2
            Me.rbSemana.TabStop = True
            Me.rbSemana.Text = "SEMANA"
            Me.rbSemana.UseVisualStyleBackColor = True
            '
            'btnConsultar
            '
            Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
            Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnConsultar.Location = New System.Drawing.Point(280, 13)
            Me.btnConsultar.Name = "btnConsultar"
            Me.btnConsultar.Size = New System.Drawing.Size(108, 25)
            Me.btnConsultar.TabIndex = 7
            Me.btnConsultar.Text = "BUSCAR"
            Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnConsultar.UseVisualStyleBackColor = True
            '
            'gbMantenimientosProgramados
            '
            Me.gbMantenimientosProgramados.Controls.Add(Me.rbDia)
            Me.gbMantenimientosProgramados.Controls.Add(Me.btnConsultar)
            Me.gbMantenimientosProgramados.Controls.Add(Me.rbSemana)
            Me.gbMantenimientosProgramados.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbMantenimientosProgramados.Location = New System.Drawing.Point(1, 0)
            Me.gbMantenimientosProgramados.Name = "gbMantenimientosProgramados"
            Me.gbMantenimientosProgramados.Size = New System.Drawing.Size(406, 47)
            Me.gbMantenimientosProgramados.TabIndex = 8
            Me.gbMantenimientosProgramados.TabStop = False
            Me.gbMantenimientosProgramados.Text = "MANTENIMIENTOS PROGRAMADOS"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rbNoCumplidas)
            Me.GroupBox1.Controls.Add(Me.rbCumplidas)
            Me.GroupBox1.Controls.Add(Me.rbTodas)
            Me.GroupBox1.Controls.Add(Me.btnConsultarTodas)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(413, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(572, 47)
            Me.GroupBox1.TabIndex = 9
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "FICHAS DE MANTENIMIENTOS REGISTRADAS"
            '
            'rbNoCumplidas
            '
            Me.rbNoCumplidas.AutoSize = True
            Me.rbNoCumplidas.Location = New System.Drawing.Point(143, 17)
            Me.rbNoCumplidas.Name = "rbNoCumplidas"
            Me.rbNoCumplidas.Size = New System.Drawing.Size(105, 17)
            Me.rbNoCumplidas.TabIndex = 11
            Me.rbNoCumplidas.TabStop = True
            Me.rbNoCumplidas.Text = "NO CUMPLIDAS"
            Me.rbNoCumplidas.UseVisualStyleBackColor = True
            '
            'rbCumplidas
            '
            Me.rbCumplidas.AutoSize = True
            Me.rbCumplidas.Location = New System.Drawing.Point(21, 17)
            Me.rbCumplidas.Name = "rbCumplidas"
            Me.rbCumplidas.Size = New System.Drawing.Size(86, 17)
            Me.rbCumplidas.TabIndex = 10
            Me.rbCumplidas.TabStop = True
            Me.rbCumplidas.Text = "CUMPLIDAS"
            Me.rbCumplidas.UseVisualStyleBackColor = True
            '
            'rbTodas
            '
            Me.rbTodas.AutoSize = True
            Me.rbTodas.Location = New System.Drawing.Point(316, 17)
            Me.rbTodas.Name = "rbTodas"
            Me.rbTodas.Size = New System.Drawing.Size(61, 17)
            Me.rbTodas.TabIndex = 9
            Me.rbTodas.TabStop = True
            Me.rbTodas.Text = "TODAS"
            Me.rbTodas.UseVisualStyleBackColor = True
            '
            'btnConsultarTodas
            '
            Me.btnConsultarTodas.Image = CType(resources.GetObject("btnConsultarTodas.Image"), System.Drawing.Image)
            Me.btnConsultarTodas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnConsultarTodas.Location = New System.Drawing.Point(393, 13)
            Me.btnConsultarTodas.Name = "btnConsultarTodas"
            Me.btnConsultarTodas.Size = New System.Drawing.Size(102, 25)
            Me.btnConsultarTodas.TabIndex = 8
            Me.btnConsultarTodas.Text = "BUSCAR"
            Me.btnConsultarTodas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnConsultarTodas.UseVisualStyleBackColor = True
            '
            'FormConsultaMantenimientos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(986, 471)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbMantenimientosProgramados)
            Me.Controls.Add(Me.dgvActivosFijosMantenimientos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormConsultaMantenimientos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "CONSULTA DE MANTENIMIENTOS DE ACTIVOS FIJOS"
            CType(Me.dgvActivosFijosMantenimientos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbMantenimientosProgramados.ResumeLayout(False)
            Me.gbMantenimientosProgramados.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgvActivosFijosMantenimientos As System.Windows.Forms.DataGridView
        Friend WithEvents rbDia As System.Windows.Forms.RadioButton
        Friend WithEvents rbSemana As System.Windows.Forms.RadioButton
        Friend WithEvents btnConsultar As System.Windows.Forms.Button
        Friend WithEvents gbMantenimientosProgramados As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbTodas As System.Windows.Forms.RadioButton
        Friend WithEvents btnConsultarTodas As System.Windows.Forms.Button
        Friend WithEvents rbNoCumplidas As System.Windows.Forms.RadioButton
        Friend WithEvents rbCumplidas As System.Windows.Forms.RadioButton
    End Class
End Namespace