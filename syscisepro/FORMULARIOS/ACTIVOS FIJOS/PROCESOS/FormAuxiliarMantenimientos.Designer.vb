Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAuxiliarMantenimientos
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAuxiliarMantenimientos))
            Me.dgvMantenimimientos = New System.Windows.Forms.DataGridView()
            Me.dgvAsientos = New System.Windows.Forms.DataGridView()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnExportarMantenimientos = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label2 = New System.Windows.Forms.Label()
            CType(Me.dgvMantenimimientos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAsientos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvMantenimimientos
            '
            Me.dgvMantenimimientos.AllowUserToAddRows = False
            Me.dgvMantenimimientos.AllowUserToDeleteRows = False
            Me.dgvMantenimimientos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvMantenimimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvMantenimimientos.BackgroundColor = System.Drawing.Color.White
            Me.dgvMantenimimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMantenimimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvMantenimimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMantenimimientos.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvMantenimimientos.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dgvMantenimimientos.Location = New System.Drawing.Point(1, 35)
            Me.dgvMantenimimientos.MultiSelect = False
            Me.dgvMantenimimientos.Name = "dgvMantenimimientos"
            Me.dgvMantenimimientos.ReadOnly = True
            Me.dgvMantenimimientos.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvMantenimimientos.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvMantenimimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMantenimimientos.Size = New System.Drawing.Size(1085, 162)
            Me.dgvMantenimimientos.TabIndex = 207
            '
            'dgvAsientos
            '
            Me.dgvAsientos.AllowUserToAddRows = False
            Me.dgvAsientos.AllowUserToDeleteRows = False
            Me.dgvAsientos.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvAsientos.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientos.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvAsientos.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dgvAsientos.Location = New System.Drawing.Point(1, 233)
            Me.dgvAsientos.MultiSelect = False
            Me.dgvAsientos.Name = "dgvAsientos"
            Me.dgvAsientos.ReadOnly = True
            Me.dgvAsientos.RowHeadersVisible = False
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvAsientos.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvAsientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientos.Size = New System.Drawing.Size(1085, 190)
            Me.dgvAsientos.TabIndex = 208
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(12, 214)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(56, 14)
            Me.Label1.TabIndex = 209
            Me.Label1.Text = "ASIENTO"
            '
            'btnExportarMantenimientos
            '
            Me.btnExportarMantenimientos.BackColor = System.Drawing.Color.White
            Me.btnExportarMantenimientos.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarMantenimientos.Image = CType(resources.GetObject("btnExportarMantenimientos.Image"), System.Drawing.Image)
            Me.btnExportarMantenimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportarMantenimientos.Location = New System.Drawing.Point(992, 1)
            Me.btnExportarMantenimientos.Name = "btnExportarMantenimientos"
            Me.btnExportarMantenimientos.Size = New System.Drawing.Size(94, 31)
            Me.btnExportarMantenimientos.TabIndex = 228
            Me.btnExportarMantenimientos.Text = "EXPORTAR"
            Me.btnExportarMantenimientos.UseVisualStyleBackColor = False
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.White
            Me.Button1.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button1.Location = New System.Drawing.Point(992, 200)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(94, 31)
            Me.Button1.TabIndex = 229
            Me.Button1.Text = "EXPORTAR"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(12, 16)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(112, 14)
            Me.Label2.TabIndex = 230
            Me.Label2.Text = "MANTENIMIENTOS"
            '
            'FormAuxiliarMantenimientos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1089, 424)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.btnExportarMantenimientos)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dgvAsientos)
            Me.Controls.Add(Me.dgvMantenimimientos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAuxiliarMantenimientos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AUXILIAR MANTENIMIENTOS"
            CType(Me.dgvMantenimimientos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAsientos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvMantenimimientos As System.Windows.Forms.DataGridView
        Friend WithEvents dgvAsientos As System.Windows.Forms.DataGridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnExportarMantenimientos As System.Windows.Forms.Button
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace