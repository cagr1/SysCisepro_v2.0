Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormSoat
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSoat))
            Me.dgvSoat = New System.Windows.Forms.DataGridView()
            Me.txtFechaActual = New System.Windows.Forms.TextBox()
            Me.pbSoat = New System.Windows.Forms.PictureBox()
            Me.btnConsultar = New System.Windows.Forms.Button()
            CType(Me.dgvSoat, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbSoat, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvSoat
            '
            Me.dgvSoat.AllowUserToAddRows = False
            Me.dgvSoat.AllowUserToDeleteRows = False
            Me.dgvSoat.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSoat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvSoat.BackgroundColor = System.Drawing.Color.White
            Me.dgvSoat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvSoat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvSoat.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvSoat.Location = New System.Drawing.Point(3, 38)
            Me.dgvSoat.MultiSelect = False
            Me.dgvSoat.Name = "dgvSoat"
            Me.dgvSoat.RowHeadersVisible = False
            Me.dgvSoat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSoat.Size = New System.Drawing.Size(988, 417)
            Me.dgvSoat.TabIndex = 0
            '
            'txtFechaActual
            '
            Me.txtFechaActual.Enabled = False
            Me.txtFechaActual.Location = New System.Drawing.Point(12, 7)
            Me.txtFechaActual.Name = "txtFechaActual"
            Me.txtFechaActual.Size = New System.Drawing.Size(240, 20)
            Me.txtFechaActual.TabIndex = 1
            Me.txtFechaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'pbSoat
            '
            Me.pbSoat.Image = CType(resources.GetObject("pbSoat.Image"), System.Drawing.Image)
            Me.pbSoat.Location = New System.Drawing.Point(826, 2)
            Me.pbSoat.Name = "pbSoat"
            Me.pbSoat.Size = New System.Drawing.Size(165, 30)
            Me.pbSoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbSoat.TabIndex = 2
            Me.pbSoat.TabStop = False
            '
            'btnConsultar
            '
            Me.btnConsultar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
            Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnConsultar.Location = New System.Drawing.Point(258, 2)
            Me.btnConsultar.Name = "btnConsultar"
            Me.btnConsultar.Size = New System.Drawing.Size(83, 30)
            Me.btnConsultar.TabIndex = 3
            Me.btnConsultar.Text = "CONSULTAR"
            Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnConsultar.UseVisualStyleBackColor = True
            '
            'FormSoat
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(993, 456)
            Me.Controls.Add(Me.btnConsultar)
            Me.Controls.Add(Me.pbSoat)
            Me.Controls.Add(Me.txtFechaActual)
            Me.Controls.Add(Me.dgvSoat)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormSoat"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MANTENIMIENTOS DE SOAT"
            CType(Me.dgvSoat, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbSoat, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvSoat As System.Windows.Forms.DataGridView
        Friend WithEvents txtFechaActual As System.Windows.Forms.TextBox
        Friend WithEvents pbSoat As System.Windows.Forms.PictureBox
        Friend WithEvents btnConsultar As System.Windows.Forms.Button
    End Class
End Namespace