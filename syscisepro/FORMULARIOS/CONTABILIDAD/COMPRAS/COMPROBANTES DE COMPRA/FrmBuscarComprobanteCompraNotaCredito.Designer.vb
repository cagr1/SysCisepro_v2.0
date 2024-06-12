Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmBuscarComprobanteCompraNotaCredito
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgvCustodios = New System.Windows.Forms.DataGridView()
            Me.dtpMes = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            CType(Me.dgvCustodios, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(3, 6)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(143, 14)
            Me.Label1.TabIndex = 7
            Me.Label1.Text = "BUSCAR FACTURAS DESDE:"
            '
            'dgvCustodios
            '
            Me.dgvCustodios.AllowUserToAddRows = False
            Me.dgvCustodios.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCustodios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCustodios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgvCustodios.BackgroundColor = System.Drawing.Color.White
            Me.dgvCustodios.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvCustodios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvCustodios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCustodios.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvCustodios.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvCustodios.Location = New System.Drawing.Point(1, 27)
            Me.dgvCustodios.MultiSelect = False
            Me.dgvCustodios.Name = "dgvCustodios"
            Me.dgvCustodios.ReadOnly = True
            Me.dgvCustodios.RowHeadersVisible = False
            Me.dgvCustodios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCustodios.Size = New System.Drawing.Size(752, 265)
            Me.dgvCustodios.TabIndex = 6
            '
            'dtpMes
            '
            Me.dtpMes.CustomFormat = "MMMM yyyy"
            Me.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpMes.Location = New System.Drawing.Point(145, 3)
            Me.dtpMes.Name = "dtpMes"
            Me.dtpMes.Size = New System.Drawing.Size(100, 20)
            Me.dtpMes.TabIndex = 199
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.White
            Me.Label2.Location = New System.Drawing.Point(253, 6)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(43, 14)
            Me.Label2.TabIndex = 200
            Me.Label2.Text = "HASTA:"
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DateTimePicker1.Location = New System.Drawing.Point(302, 3)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
            Me.DateTimePicker1.TabIndex = 201
            '
            'FrmBuscarComprobanteCompraNotaCredito
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(754, 293)
            Me.Controls.Add(Me.DateTimePicker1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpMes)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dgvCustodios)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmBuscarComprobanteCompraNotaCredito"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BUSCAR FACTURA (Doble click para seleccionar)"
            CType(Me.dgvCustodios, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dgvCustodios As System.Windows.Forms.DataGridView
        Friend WithEvents dtpMes As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    End Class
End Namespace