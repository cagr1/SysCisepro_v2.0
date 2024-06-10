Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBuscarProveedorCalificado
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarProveedorCalificado))
            Me.gbParámetros = New System.Windows.Forms.GroupBox()
            Me.rb = New System.Windows.Forms.RadioButton()
            Me.txtBusqueda = New System.Windows.Forms.TextBox()
            Me.rbNombre = New System.Windows.Forms.RadioButton()
            Me.dgvProveedorGeneral = New System.Windows.Forms.DataGridView()
            Me.gbParámetros.SuspendLayout()
            CType(Me.dgvProveedorGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbParámetros
            '
            Me.gbParámetros.BackColor = System.Drawing.Color.White
            Me.gbParámetros.Controls.Add(Me.rb)
            Me.gbParámetros.Controls.Add(Me.txtBusqueda)
            Me.gbParámetros.Controls.Add(Me.rbNombre)
            Me.gbParámetros.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbParámetros.Location = New System.Drawing.Point(3, 2)
            Me.gbParámetros.Name = "gbParámetros"
            Me.gbParámetros.Size = New System.Drawing.Size(700, 50)
            Me.gbParámetros.TabIndex = 48
            Me.gbParámetros.TabStop = False
            Me.gbParámetros.Text = "BUSQUEDA"
            '
            'rb
            '
            Me.rb.AutoSize = True
            Me.rb.Location = New System.Drawing.Point(79, 21)
            Me.rb.Name = "rb"
            Me.rb.Size = New System.Drawing.Size(109, 18)
            Me.rb.TabIndex = 39
            Me.rb.Text = "RUC / CÉDULA"
            Me.rb.UseVisualStyleBackColor = True
            '
            'txtBusqueda
            '
            Me.txtBusqueda.BackColor = System.Drawing.Color.White
            Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBusqueda.Location = New System.Drawing.Point(193, 19)
            Me.txtBusqueda.Name = "txtBusqueda"
            Me.txtBusqueda.Size = New System.Drawing.Size(480, 22)
            Me.txtBusqueda.TabIndex = 35
            '
            'rbNombre
            '
            Me.rbNombre.AutoSize = True
            Me.rbNombre.Checked = True
            Me.rbNombre.Location = New System.Drawing.Point(6, 21)
            Me.rbNombre.Name = "rbNombre"
            Me.rbNombre.Size = New System.Drawing.Size(67, 18)
            Me.rbNombre.TabIndex = 38
            Me.rbNombre.TabStop = True
            Me.rbNombre.Text = "NOMBRE"
            Me.rbNombre.UseVisualStyleBackColor = True
            '
            'dgvProveedorGeneral
            '
            Me.dgvProveedorGeneral.AllowUserToAddRows = False
            Me.dgvProveedorGeneral.AllowUserToDeleteRows = False
            Me.dgvProveedorGeneral.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvProveedorGeneral.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvProveedorGeneral.BackgroundColor = System.Drawing.Color.White
            Me.dgvProveedorGeneral.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvProveedorGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProveedorGeneral.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvProveedorGeneral.Location = New System.Drawing.Point(2, 58)
            Me.dgvProveedorGeneral.Name = "dgvProveedorGeneral"
            Me.dgvProveedorGeneral.ReadOnly = True
            Me.dgvProveedorGeneral.RowHeadersVisible = False
            Me.dgvProveedorGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedorGeneral.Size = New System.Drawing.Size(701, 302)
            Me.dgvProveedorGeneral.TabIndex = 47
            '
            'FormBuscarProveedorCalificado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(704, 362)
            Me.Controls.Add(Me.gbParámetros)
            Me.Controls.Add(Me.dgvProveedorGeneral)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormBuscarProveedorCalificado"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BUSCAR PROVEEDOR CALIFICADO"
            Me.gbParámetros.ResumeLayout(False)
            Me.gbParámetros.PerformLayout()
            CType(Me.dgvProveedorGeneral, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbParámetros As System.Windows.Forms.GroupBox
        Friend WithEvents rb As System.Windows.Forms.RadioButton
        Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
        Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
        Friend WithEvents dgvProveedorGeneral As System.Windows.Forms.DataGridView
    End Class
End Namespace