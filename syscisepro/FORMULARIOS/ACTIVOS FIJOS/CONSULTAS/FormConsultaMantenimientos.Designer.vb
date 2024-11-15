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
            Me.rbNoCumplidas = New System.Windows.Forms.RadioButton()
            Me.rbCumplidas = New System.Windows.Forms.RadioButton()
            Me.rbTodas = New System.Windows.Forms.RadioButton()
            Me.btnConsultarTodas = New System.Windows.Forms.Button()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            CType(Me.dgvActivosFijosMantenimientos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvActivosFijosMantenimientos
            '
            Me.dgvActivosFijosMantenimientos.AllowUserToAddRows = False
            Me.dgvActivosFijosMantenimientos.AllowUserToDeleteRows = False
            Me.dgvActivosFijosMantenimientos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvActivosFijosMantenimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvActivosFijosMantenimientos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvActivosFijosMantenimientos.BorderStyle = System.Windows.Forms.BorderStyle.None
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
            Me.dgvActivosFijosMantenimientos.Location = New System.Drawing.Point(6, 71)
            Me.dgvActivosFijosMantenimientos.MultiSelect = False
            Me.dgvActivosFijosMantenimientos.Name = "dgvActivosFijosMantenimientos"
            Me.dgvActivosFijosMantenimientos.ReadOnly = True
            Me.dgvActivosFijosMantenimientos.RowHeadersVisible = False
            Me.dgvActivosFijosMantenimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvActivosFijosMantenimientos.Size = New System.Drawing.Size(735, 399)
            Me.dgvActivosFijosMantenimientos.TabIndex = 0
            '
            'rbDia
            '
            Me.rbDia.AutoSize = True
            Me.rbDia.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbDia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbDia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbDia.Location = New System.Drawing.Point(14, 8)
            Me.rbDia.Name = "rbDia"
            Me.rbDia.Size = New System.Drawing.Size(41, 17)
            Me.rbDia.TabIndex = 1
            Me.rbDia.TabStop = True
            Me.rbDia.Text = "Dia"
            Me.rbDia.UseVisualStyleBackColor = False
            '
            'rbSemana
            '
            Me.rbSemana.AutoSize = True
            Me.rbSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbSemana.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbSemana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbSemana.Location = New System.Drawing.Point(66, 8)
            Me.rbSemana.Name = "rbSemana"
            Me.rbSemana.Size = New System.Drawing.Size(66, 17)
            Me.rbSemana.TabIndex = 2
            Me.rbSemana.TabStop = True
            Me.rbSemana.Text = "Semana"
            Me.rbSemana.UseVisualStyleBackColor = False
            '
            'btnConsultar
            '
            Me.btnConsultar.BackColor = System.Drawing.Color.Transparent
            Me.btnConsultar.FlatAppearance.BorderSize = 0
            Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnConsultar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnConsultar.Location = New System.Drawing.Point(157, 4)
            Me.btnConsultar.Name = "btnConsultar"
            Me.btnConsultar.Size = New System.Drawing.Size(36, 25)
            Me.btnConsultar.TabIndex = 7
            Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnConsultar.UseVisualStyleBackColor = False
            '
            'rbNoCumplidas
            '
            Me.rbNoCumplidas.AutoSize = True
            Me.rbNoCumplidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbNoCumplidas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNoCumplidas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbNoCumplidas.Location = New System.Drawing.Point(110, 8)
            Me.rbNoCumplidas.Name = "rbNoCumplidas"
            Me.rbNoCumplidas.Size = New System.Drawing.Size(83, 17)
            Me.rbNoCumplidas.TabIndex = 11
            Me.rbNoCumplidas.TabStop = True
            Me.rbNoCumplidas.Text = "Sin Cumplir"
            Me.rbNoCumplidas.UseVisualStyleBackColor = False
            '
            'rbCumplidas
            '
            Me.rbCumplidas.AutoSize = True
            Me.rbCumplidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbCumplidas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCumplidas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCumplidas.Location = New System.Drawing.Point(17, 8)
            Me.rbCumplidas.Name = "rbCumplidas"
            Me.rbCumplidas.Size = New System.Drawing.Size(78, 17)
            Me.rbCumplidas.TabIndex = 10
            Me.rbCumplidas.TabStop = True
            Me.rbCumplidas.Text = "Cumplidas"
            Me.rbCumplidas.UseVisualStyleBackColor = False
            '
            'rbTodas
            '
            Me.rbTodas.AutoSize = True
            Me.rbTodas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbTodas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTodas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTodas.Location = New System.Drawing.Point(218, 8)
            Me.rbTodas.Name = "rbTodas"
            Me.rbTodas.Size = New System.Drawing.Size(55, 17)
            Me.rbTodas.TabIndex = 9
            Me.rbTodas.TabStop = True
            Me.rbTodas.Text = "Todas"
            Me.rbTodas.UseVisualStyleBackColor = False
            '
            'btnConsultarTodas
            '
            Me.btnConsultarTodas.BackColor = System.Drawing.Color.Transparent
            Me.btnConsultarTodas.FlatAppearance.BorderSize = 0
            Me.btnConsultarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnConsultarTodas.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnConsultarTodas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnConsultarTodas.Location = New System.Drawing.Point(279, 4)
            Me.btnConsultarTodas.Name = "btnConsultarTodas"
            Me.btnConsultarTodas.Size = New System.Drawing.Size(41, 25)
            Me.btnConsultarTodas.TabIndex = 8
            Me.btnConsultarTodas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnConsultarTodas.UseVisualStyleBackColor = False
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(6, 4)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbDia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnConsultar)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbSemana)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(239, 61)
            Me.KryptonGroupBox1.TabIndex = 10
            Me.KryptonGroupBox1.Values.Heading = "Mantenimientos Programados"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(263, 4)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnConsultarTodas)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.rbTodas)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.rbNoCumplidas)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.rbCumplidas)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(478, 61)
            Me.KryptonGroupBox2.TabIndex = 11
            Me.KryptonGroupBox2.Values.Heading = "Fichas Mantenimientos Registradas"
            '
            'FormConsultaMantenimientos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(747, 471)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.dgvActivosFijosMantenimientos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormConsultaMantenimientos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CONSULTA DE MANTENIMIENTOS DE ACTIVOS FIJOS"
            CType(Me.dgvActivosFijosMantenimientos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            Me.KryptonGroupBox2.Panel.PerformLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgvActivosFijosMantenimientos As System.Windows.Forms.DataGridView
        Friend WithEvents rbDia As System.Windows.Forms.RadioButton
        Friend WithEvents rbSemana As System.Windows.Forms.RadioButton
        Friend WithEvents btnConsultar As System.Windows.Forms.Button
        Friend WithEvents rbTodas As System.Windows.Forms.RadioButton
        Friend WithEvents btnConsultarTodas As System.Windows.Forms.Button
        Friend WithEvents rbNoCumplidas As System.Windows.Forms.RadioButton
        Friend WithEvents rbCumplidas As System.Windows.Forms.RadioButton
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    End Class
End Namespace