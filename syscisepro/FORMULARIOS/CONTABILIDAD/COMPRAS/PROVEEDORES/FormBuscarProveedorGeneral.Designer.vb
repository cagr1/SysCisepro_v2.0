Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBuscarProveedorGeneral
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarProveedorGeneral))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.gbParámetros = New System.Windows.Forms.GroupBox()
            Me.btnVolver = New System.Windows.Forms.Button()
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
            Me.gbParámetros.Controls.Add(Me.btnVolver)
            Me.gbParámetros.Controls.Add(Me.rb)
            Me.gbParámetros.Controls.Add(Me.txtBusqueda)
            Me.gbParámetros.Controls.Add(Me.rbNombre)
            Me.gbParámetros.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbParámetros.Location = New System.Drawing.Point(2, 2)
            Me.gbParámetros.Name = "gbParámetros"
            Me.gbParámetros.Size = New System.Drawing.Size(700, 77)
            Me.gbParámetros.TabIndex = 46
            Me.gbParámetros.TabStop = False
            Me.gbParámetros.Text = "PARÁMETROS DE BUSQUEDA"
            '
            'btnVolver
            '
            Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnVolver.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnVolver.Image = CType(resources.GetObject("btnVolver.Image"), System.Drawing.Image)
            Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnVolver.Location = New System.Drawing.Point(585, 20)
            Me.btnVolver.Name = "btnVolver"
            Me.btnVolver.Size = New System.Drawing.Size(79, 45)
            Me.btnVolver.TabIndex = 34
            Me.btnVolver.Text = "ENVIAR"
            Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnVolver.UseVisualStyleBackColor = True
            '
            'rb
            '
            Me.rb.AutoSize = True
            Me.rb.Location = New System.Drawing.Point(79, 20)
            Me.rb.Name = "rb"
            Me.rb.Size = New System.Drawing.Size(109, 18)
            Me.rb.TabIndex = 39
            Me.rb.TabStop = True
            Me.rb.Text = "RUC / CÉDULA"
            Me.rb.UseVisualStyleBackColor = True
            '
            'txtBusqueda
            '
            Me.txtBusqueda.Location = New System.Drawing.Point(6, 44)
            Me.txtBusqueda.Name = "txtBusqueda"
            Me.txtBusqueda.Size = New System.Drawing.Size(485, 22)
            Me.txtBusqueda.TabIndex = 35
            '
            'rbNombre
            '
            Me.rbNombre.AutoSize = True
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
            Me.dgvProveedorGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProveedorGeneral.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvProveedorGeneral.Location = New System.Drawing.Point(1, 79)
            Me.dgvProveedorGeneral.Name = "dgvProveedorGeneral"
            Me.dgvProveedorGeneral.ReadOnly = True
            Me.dgvProveedorGeneral.RowHeadersVisible = False
            Me.dgvProveedorGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedorGeneral.Size = New System.Drawing.Size(701, 281)
            Me.dgvProveedorGeneral.TabIndex = 45
            '
            'FormBuscarProveedorGeneral
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(704, 362)
            Me.Controls.Add(Me.gbParámetros)
            Me.Controls.Add(Me.dgvProveedorGeneral)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormBuscarProveedorGeneral"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "BUSCAR PROVEEDOR GENERAL"
            Me.gbParámetros.ResumeLayout(False)
            Me.gbParámetros.PerformLayout()
            CType(Me.dgvProveedorGeneral, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbParámetros As System.Windows.Forms.GroupBox
        Friend WithEvents btnVolver As System.Windows.Forms.Button
        Friend WithEvents rb As System.Windows.Forms.RadioButton
        Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
        Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
        Friend WithEvents dgvProveedorGeneral As System.Windows.Forms.DataGridView
    End Class
End Namespace