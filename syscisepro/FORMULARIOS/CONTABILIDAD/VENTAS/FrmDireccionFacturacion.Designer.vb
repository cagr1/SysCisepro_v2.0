Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmDireccionFacturacion
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
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.Label47 = New System.Windows.Forms.Label()
            Me.Label43 = New System.Windows.Forms.Label()
            Me.Label44 = New System.Windows.Forms.Label()
            Me.Label45 = New System.Windows.Forms.Label()
            Me.Label46 = New System.Windows.Forms.Label()
            Me.TextBox12 = New System.Windows.Forms.TextBox()
            Me.TextBox13 = New System.Windows.Forms.TextBox()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.DataGridView3 = New System.Windows.Forms.DataGridView()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'GroupBox5
            '
            Me.GroupBox5.BackColor = System.Drawing.Color.White
            Me.GroupBox5.Controls.Add(Me.Label47)
            Me.GroupBox5.Controls.Add(Me.Label43)
            Me.GroupBox5.Controls.Add(Me.Label44)
            Me.GroupBox5.Controls.Add(Me.Label45)
            Me.GroupBox5.Controls.Add(Me.Label46)
            Me.GroupBox5.Controls.Add(Me.TextBox12)
            Me.GroupBox5.Controls.Add(Me.TextBox13)
            Me.GroupBox5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox5.Location = New System.Drawing.Point(0, 2)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(781, 70)
            Me.GroupBox5.TabIndex = 183
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "CLIENTE"
            '
            'Label47
            '
            Me.Label47.AutoSize = True
            Me.Label47.Location = New System.Drawing.Point(217, -1)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(25, 13)
            Me.Label47.TabIndex = 183
            Me.Label47.Text = "..."
            '
            'Label43
            '
            Me.Label43.AutoSize = True
            Me.Label43.Location = New System.Drawing.Point(168, 0)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(43, 13)
            Me.Label43.TabIndex = 7
            Me.Label43.Text = "R.U.C:"
            '
            'Label44
            '
            Me.Label44.AutoSize = True
            Me.Label44.Location = New System.Drawing.Point(57, 0)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New System.Drawing.Size(25, 13)
            Me.Label44.TabIndex = 6
            Me.Label44.Text = "..."
            '
            'Label45
            '
            Me.Label45.AutoSize = True
            Me.Label45.Location = New System.Drawing.Point(8, 46)
            Me.Label45.Name = "Label45"
            Me.Label45.Size = New System.Drawing.Size(163, 13)
            Me.Label45.TabIndex = 5
            Me.Label45.Text = "APELLIDO/NOMBRE COMERCIAL:"
            '
            'Label46
            '
            Me.Label46.AutoSize = True
            Me.Label46.Location = New System.Drawing.Point(8, 22)
            Me.Label46.Name = "Label46"
            Me.Label46.Size = New System.Drawing.Size(139, 13)
            Me.Label46.TabIndex = 4
            Me.Label46.Text = "NOMBRE / RAZÓN SOCIAL:"
            '
            'TextBox12
            '
            Me.TextBox12.BackColor = System.Drawing.Color.White
            Me.TextBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox12.Enabled = False
            Me.TextBox12.Location = New System.Drawing.Point(171, 43)
            Me.TextBox12.Name = "TextBox12"
            Me.TextBox12.Size = New System.Drawing.Size(605, 20)
            Me.TextBox12.TabIndex = 2
            '
            'TextBox13
            '
            Me.TextBox13.BackColor = System.Drawing.Color.White
            Me.TextBox13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox13.Enabled = False
            Me.TextBox13.Location = New System.Drawing.Point(171, 19)
            Me.TextBox13.Name = "TextBox13"
            Me.TextBox13.Size = New System.Drawing.Size(605, 20)
            Me.TextBox13.TabIndex = 1
            '
            'GroupBox6
            '
            Me.GroupBox6.BackColor = System.Drawing.Color.White
            Me.GroupBox6.Controls.Add(Me.DataGridView3)
            Me.GroupBox6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox6.Location = New System.Drawing.Point(0, 74)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(782, 316)
            Me.GroupBox6.TabIndex = 191
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "DIRECCIONES DE FACTURACIÓN"
            '
            'DataGridView3
            '
            Me.DataGridView3.AllowUserToAddRows = False
            Me.DataGridView3.AllowUserToDeleteRows = False
            Me.DataGridView3.AllowUserToResizeColumns = False
            Me.DataGridView3.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.DataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
            Me.DataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle2
            Me.DataGridView3.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DataGridView3.Location = New System.Drawing.Point(1, 15)
            Me.DataGridView3.MultiSelect = False
            Me.DataGridView3.Name = "DataGridView3"
            Me.DataGridView3.ReadOnly = True
            Me.DataGridView3.RowHeadersVisible = False
            Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.DataGridView3.Size = New System.Drawing.Size(779, 297)
            Me.DataGridView3.TabIndex = 37
            '
            'Column11
            '
            Me.Column11.HeaderText = "DIRECCION DE FACTURACION"
            Me.Column11.Name = "Column11"
            Me.Column11.ReadOnly = True
            Me.Column11.Width = 760
            '
            'FrmDireccionFacturacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(781, 389)
            Me.Controls.Add(Me.GroupBox6)
            Me.Controls.Add(Me.GroupBox5)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "FrmDireccionFacturacion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmDireccionFacturacion"
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            Me.GroupBox6.ResumeLayout(False)
            CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents Label47 As System.Windows.Forms.Label
        Friend WithEvents Label43 As System.Windows.Forms.Label
        Friend WithEvents Label44 As System.Windows.Forms.Label
        Friend WithEvents Label45 As System.Windows.Forms.Label
        Friend WithEvents Label46 As System.Windows.Forms.Label
        Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
        Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace