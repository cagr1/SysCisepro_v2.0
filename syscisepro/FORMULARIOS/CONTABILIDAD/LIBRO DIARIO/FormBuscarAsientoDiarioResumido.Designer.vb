Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBuscarAsientoDiarioResumido
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarAsientoDiarioResumido))
            Me.gbTotalDebeTotalHaber = New System.Windows.Forms.GroupBox()
            Me.txtTotalHaber = New System.Windows.Forms.TextBox()
            Me.txtTotalDebe = New System.Windows.Forms.TextBox()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.gbAsientoDiario = New System.Windows.Forms.GroupBox()
            Me.lblNumeroRegistro = New System.Windows.Forms.Label()
            Me.dgvAsientoDiario = New System.Windows.Forms.DataGridView()
            Me.gbTotalDebeTotalHaber.SuspendLayout()
            Me.gbAsientoDiario.SuspendLayout()
            CType(Me.dgvAsientoDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbTotalDebeTotalHaber
            '
            Me.gbTotalDebeTotalHaber.BackColor = System.Drawing.Color.White
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.txtTotalHaber)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.txtTotalDebe)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.lblTotal)
            Me.gbTotalDebeTotalHaber.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotalDebeTotalHaber.Location = New System.Drawing.Point(3, 259)
            Me.gbTotalDebeTotalHaber.Name = "gbTotalDebeTotalHaber"
            Me.gbTotalDebeTotalHaber.Size = New System.Drawing.Size(877, 37)
            Me.gbTotalDebeTotalHaber.TabIndex = 115
            Me.gbTotalDebeTotalHaber.TabStop = False
            '
            'txtTotalHaber
            '
            Me.txtTotalHaber.Enabled = False
            Me.txtTotalHaber.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalHaber.Location = New System.Drawing.Point(780, 10)
            Me.txtTotalHaber.Name = "txtTotalHaber"
            Me.txtTotalHaber.Size = New System.Drawing.Size(88, 21)
            Me.txtTotalHaber.TabIndex = 35
            Me.txtTotalHaber.Text = "0.00"
            Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalDebe
            '
            Me.txtTotalDebe.Enabled = False
            Me.txtTotalDebe.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalDebe.Location = New System.Drawing.Point(683, 10)
            Me.txtTotalDebe.Name = "txtTotalDebe"
            Me.txtTotalDebe.Size = New System.Drawing.Size(88, 21)
            Me.txtTotalDebe.TabIndex = 36
            Me.txtTotalDebe.Text = "0.00"
            Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(628, 14)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(48, 13)
            Me.lblTotal.TabIndex = 34
            Me.lblTotal.Text = "TOTAL :"
            '
            'gbAsientoDiario
            '
            Me.gbAsientoDiario.BackColor = System.Drawing.Color.White
            Me.gbAsientoDiario.Controls.Add(Me.lblNumeroRegistro)
            Me.gbAsientoDiario.Controls.Add(Me.dgvAsientoDiario)
            Me.gbAsientoDiario.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbAsientoDiario.Location = New System.Drawing.Point(3, 3)
            Me.gbAsientoDiario.Name = "gbAsientoDiario"
            Me.gbAsientoDiario.Size = New System.Drawing.Size(877, 256)
            Me.gbAsientoDiario.TabIndex = 114
            Me.gbAsientoDiario.TabStop = False
            Me.gbAsientoDiario.Text = "ASIENTO DE DIARIO:"
            '
            'lblNumeroRegistro
            '
            Me.lblNumeroRegistro.AutoSize = True
            Me.lblNumeroRegistro.Location = New System.Drawing.Point(135, 0)
            Me.lblNumeroRegistro.Name = "lblNumeroRegistro"
            Me.lblNumeroRegistro.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroRegistro.TabIndex = 1
            Me.lblNumeroRegistro.Text = "0"
            '
            'dgvAsientoDiario
            '
            Me.dgvAsientoDiario.AllowUserToAddRows = False
            Me.dgvAsientoDiario.AllowUserToDeleteRows = False
            Me.dgvAsientoDiario.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientoDiario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvAsientoDiario.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsientoDiario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvAsientoDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientoDiario.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvAsientoDiario.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvAsientoDiario.Location = New System.Drawing.Point(3, 17)
            Me.dgvAsientoDiario.MultiSelect = False
            Me.dgvAsientoDiario.Name = "dgvAsientoDiario"
            Me.dgvAsientoDiario.ReadOnly = True
            Me.dgvAsientoDiario.RowHeadersVisible = False
            Me.dgvAsientoDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientoDiario.Size = New System.Drawing.Size(871, 236)
            Me.dgvAsientoDiario.TabIndex = 0
            '
            'FormBuscarAsientoDiarioResumido
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(883, 298)
            Me.Controls.Add(Me.gbTotalDebeTotalHaber)
            Me.Controls.Add(Me.gbAsientoDiario)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormBuscarAsientoDiarioResumido"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ASIENTO DIARIO"
            Me.gbTotalDebeTotalHaber.ResumeLayout(False)
            Me.gbTotalDebeTotalHaber.PerformLayout()
            Me.gbAsientoDiario.ResumeLayout(False)
            Me.gbAsientoDiario.PerformLayout()
            CType(Me.dgvAsientoDiario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbTotalDebeTotalHaber As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents gbAsientoDiario As System.Windows.Forms.GroupBox
        Friend WithEvents lblNumeroRegistro As System.Windows.Forms.Label
        Friend WithEvents dgvAsientoDiario As System.Windows.Forms.DataGridView
    End Class
End Namespace