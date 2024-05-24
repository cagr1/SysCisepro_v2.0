Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmBuscarProveedorCliente
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarProveedorCliente))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtParametrobusqueda = New System.Windows.Forms.TextBox()
            Me.dgvCustodios = New System.Windows.Forms.DataGridView()
            Me.rbtProveedor = New System.Windows.Forms.RadioButton()
            Me.rbtCliente = New System.Windows.Forms.RadioButton()
            Me.rbtPersonal = New System.Windows.Forms.RadioButton()
            CType(Me.dgvCustodios, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 6)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(51, 14)
            Me.Label1.TabIndex = 7
            Me.Label1.Text = "BUSCAR:"
            '
            'txtParametrobusqueda
            '
            Me.txtParametrobusqueda.BackColor = System.Drawing.Color.White
            Me.txtParametrobusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtParametrobusqueda.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtParametrobusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.txtParametrobusqueda.Location = New System.Drawing.Point(57, 2)
            Me.txtParametrobusqueda.Name = "txtParametrobusqueda"
            Me.txtParametrobusqueda.Size = New System.Drawing.Size(453, 23)
            Me.txtParametrobusqueda.TabIndex = 5
            '
            'dgvCustodios
            '
            Me.dgvCustodios.AllowUserToAddRows = False
            Me.dgvCustodios.AllowUserToDeleteRows = False
            Me.dgvCustodios.AllowUserToResizeRows = False
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
            'rbtProveedor
            '
            Me.rbtProveedor.AutoSize = True
            Me.rbtProveedor.Location = New System.Drawing.Point(596, 4)
            Me.rbtProveedor.Name = "rbtProveedor"
            Me.rbtProveedor.Size = New System.Drawing.Size(74, 17)
            Me.rbtProveedor.TabIndex = 8
            Me.rbtProveedor.Text = "Proveedor"
            Me.rbtProveedor.UseVisualStyleBackColor = True
            '
            'rbtCliente
            '
            Me.rbtCliente.AutoSize = True
            Me.rbtCliente.Location = New System.Drawing.Point(685, 4)
            Me.rbtCliente.Name = "rbtCliente"
            Me.rbtCliente.Size = New System.Drawing.Size(57, 17)
            Me.rbtCliente.TabIndex = 9
            Me.rbtCliente.Text = "Cliente"
            Me.rbtCliente.UseVisualStyleBackColor = True
            '
            'rbtPersonal
            '
            Me.rbtPersonal.AutoSize = True
            Me.rbtPersonal.Checked = True
            Me.rbtPersonal.Location = New System.Drawing.Point(516, 4)
            Me.rbtPersonal.Name = "rbtPersonal"
            Me.rbtPersonal.Size = New System.Drawing.Size(66, 17)
            Me.rbtPersonal.TabIndex = 10
            Me.rbtPersonal.TabStop = True
            Me.rbtPersonal.Text = "Personal"
            Me.rbtPersonal.UseVisualStyleBackColor = True
            '
            'FrmBuscarProveedorCliente
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(754, 293)
            Me.Controls.Add(Me.rbtPersonal)
            Me.Controls.Add(Me.rbtCliente)
            Me.Controls.Add(Me.rbtProveedor)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtParametrobusqueda)
            Me.Controls.Add(Me.dgvCustodios)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmBuscarProveedorCliente"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "PROVEEDOR O CLIENTE (Doble click para seleccionar)"
            CType(Me.dgvCustodios, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Public WithEvents txtParametrobusqueda As System.Windows.Forms.TextBox
        Public WithEvents rbtProveedor As System.Windows.Forms.RadioButton
        Public WithEvents rbtCliente As System.Windows.Forms.RadioButton
        Public WithEvents rbtPersonal As System.Windows.Forms.RadioButton
        Public WithEvents dgvCustodios As System.Windows.Forms.DataGridView
    End Class
End Namespace