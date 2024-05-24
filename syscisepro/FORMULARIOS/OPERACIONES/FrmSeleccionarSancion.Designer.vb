Namespace FORMULARIOS.OPERACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmSeleccionarSancion
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSeleccionarSancion))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtParametrobusqueda = New System.Windows.Forms.TextBox()
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(4, 6)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(100, 14)
            Me.Label1.TabIndex = 13
            Me.Label1.Text = "BUSCAR SANCIÓN:"
            '
            'txtParametrobusqueda
            '
            Me.txtParametrobusqueda.BackColor = System.Drawing.Color.White
            Me.txtParametrobusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtParametrobusqueda.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtParametrobusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.txtParametrobusqueda.Location = New System.Drawing.Point(112, 1)
            Me.txtParametrobusqueda.Name = "txtParametrobusqueda"
            Me.txtParametrobusqueda.Size = New System.Drawing.Size(642, 23)
            Me.txtParametrobusqueda.TabIndex = 11
            '
            'ListView1
            '
            Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
            Me.ListView1.FullRowSelect = True
            Me.ListView1.Location = New System.Drawing.Point(-1, 24)
            Me.ListView1.MultiSelect = False
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(757, 271)
            Me.ListView1.TabIndex = 196
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "ID"
            Me.ColumnHeader1.Width = 50
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "DETALLE"
            Me.ColumnHeader4.Width = 300
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "VALOR"
            Me.ColumnHeader5.Width = 200
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "ESTADO"
            Me.ColumnHeader6.Width = 90
            '
            'FrmSeleccionarSancion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(755, 293)
            Me.Controls.Add(Me.ListView1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtParametrobusqueda)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmSeleccionarSancion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SELECCIONAR SANCIONES"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtParametrobusqueda As System.Windows.Forms.TextBox
        Friend WithEvents ListView1 As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    End Class
End Namespace