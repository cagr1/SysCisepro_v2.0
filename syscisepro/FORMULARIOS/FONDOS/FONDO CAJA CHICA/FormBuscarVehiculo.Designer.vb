Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBuscarVehiculo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarVehiculo))
            Me.dgvVehiculos = New System.Windows.Forms.DataGridView()
            Me.txtNombresRecibe = New System.Windows.Forms.TextBox()
            CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvVehiculos
            '
            Me.dgvVehiculos.AllowUserToAddRows = False
            Me.dgvVehiculos.AllowUserToDeleteRows = False
            Me.dgvVehiculos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvVehiculos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvVehiculos.BackgroundColor = System.Drawing.Color.White
            Me.dgvVehiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvVehiculos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvVehiculos.Location = New System.Drawing.Point(3, 28)
            Me.dgvVehiculos.MultiSelect = False
            Me.dgvVehiculos.Name = "dgvVehiculos"
            Me.dgvVehiculos.RowHeadersVisible = False
            Me.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvVehiculos.Size = New System.Drawing.Size(855, 288)
            Me.dgvVehiculos.TabIndex = 2
            '
            'txtNombresRecibe
            '
            Me.txtNombresRecibe.BackColor = System.Drawing.Color.White
            Me.txtNombresRecibe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombresRecibe.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombresRecibe.ForeColor = System.Drawing.Color.Black
            Me.txtNombresRecibe.Location = New System.Drawing.Point(6, 3)
            Me.txtNombresRecibe.Name = "txtNombresRecibe"
            Me.txtNombresRecibe.Size = New System.Drawing.Size(713, 21)
            Me.txtNombresRecibe.TabIndex = 9
            '
            'FormBuscarVehiculo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(861, 319)
            Me.Controls.Add(Me.txtNombresRecibe)
            Me.Controls.Add(Me.dgvVehiculos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormBuscarVehiculo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BUSCAR VEHÍCULO"
            CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvVehiculos As System.Windows.Forms.DataGridView
        Friend WithEvents txtNombresRecibe As System.Windows.Forms.TextBox
    End Class
End Namespace