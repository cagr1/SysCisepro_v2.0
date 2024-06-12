Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmBuscarComprobanteIngresoEgreso
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtParametrobusqueda = New System.Windows.Forms.TextBox()
            Me.rbtEgreso = New System.Windows.Forms.RadioButton()
            Me.rbtIngreso = New System.Windows.Forms.RadioButton()
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ListView2 = New System.Windows.Forms.ListView()
            Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 6)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(57, 14)
            Me.Label1.TabIndex = 7
            Me.Label1.Text = "N° COMP.:"
            '
            'txtParametrobusqueda
            '
            Me.txtParametrobusqueda.BackColor = System.Drawing.Color.White
            Me.txtParametrobusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtParametrobusqueda.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtParametrobusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.txtParametrobusqueda.Location = New System.Drawing.Point(61, 3)
            Me.txtParametrobusqueda.Name = "txtParametrobusqueda"
            Me.txtParametrobusqueda.Size = New System.Drawing.Size(99, 23)
            Me.txtParametrobusqueda.TabIndex = 5
            '
            'rbtEgreso
            '
            Me.rbtEgreso.AutoSize = True
            Me.rbtEgreso.Location = New System.Drawing.Point(285, 6)
            Me.rbtEgreso.Name = "rbtEgreso"
            Me.rbtEgreso.Size = New System.Drawing.Size(70, 17)
            Me.rbtEgreso.TabIndex = 8
            Me.rbtEgreso.Text = "EGRESO"
            Me.rbtEgreso.UseVisualStyleBackColor = True
            '
            'rbtIngreso
            '
            Me.rbtIngreso.AutoSize = True
            Me.rbtIngreso.Checked = True
            Me.rbtIngreso.Location = New System.Drawing.Point(172, 6)
            Me.rbtIngreso.Name = "rbtIngreso"
            Me.rbtIngreso.Size = New System.Drawing.Size(74, 17)
            Me.rbtIngreso.TabIndex = 10
            Me.rbtIngreso.TabStop = True
            Me.rbtIngreso.Text = "INGRESO"
            Me.rbtIngreso.UseVisualStyleBackColor = True
            '
            'ListView1
            '
            Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader2})
            Me.ListView1.FullRowSelect = True
            Me.ListView1.HideSelection = False
            Me.ListView1.Location = New System.Drawing.Point(0, 29)
            Me.ListView1.MultiSelect = False
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(754, 264)
            Me.ListView1.TabIndex = 17
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "COMPROBANTE"
            Me.ColumnHeader1.Width = 300
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "ID"
            Me.ColumnHeader4.Width = 50
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "IDS"
            Me.ColumnHeader3.Width = 50
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "DESCRIPCIÓN"
            Me.ColumnHeader5.Width = 300
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "CANTIDAD"
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "VALOR"
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "TOTAL"
            '
            'ListView2
            '
            Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader18})
            Me.ListView2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ListView2.FullRowSelect = True
            Me.ListView2.HideSelection = False
            Me.ListView2.Location = New System.Drawing.Point(0, 29)
            Me.ListView2.MultiSelect = False
            Me.ListView2.Name = "ListView2"
            Me.ListView2.Size = New System.Drawing.Size(754, 264)
            Me.ListView2.TabIndex = 18
            Me.ListView2.UseCompatibleStateImageBehavior = False
            Me.ListView2.View = System.Windows.Forms.View.Details
            Me.ListView2.Visible = False
            '
            'ColumnHeader8
            '
            Me.ColumnHeader8.Text = "ID"
            Me.ColumnHeader8.Width = 40
            '
            'ColumnHeader15
            '
            Me.ColumnHeader15.Text = "PROVEEDOR"
            Me.ColumnHeader15.Width = 0
            '
            'ColumnHeader16
            '
            Me.ColumnHeader16.Text = "NUMERO"
            Me.ColumnHeader16.Width = 80
            '
            'ColumnHeader17
            '
            Me.ColumnHeader17.Text = "FECHA"
            Me.ColumnHeader17.Width = 80
            '
            'ColumnHeader19
            '
            Me.ColumnHeader19.Text = "SUBTOTAL"
            Me.ColumnHeader19.Width = 80
            '
            'ColumnHeader20
            '
            Me.ColumnHeader20.Text = "IVA"
            Me.ColumnHeader20.Width = 80
            '
            'ColumnHeader21
            '
            Me.ColumnHeader21.Text = "TOTAL"
            Me.ColumnHeader21.Width = 80
            '
            'ColumnHeader18
            '
            Me.ColumnHeader18.Text = "OBSERVACION"
            Me.ColumnHeader18.Width = 600
            '
            'FrmBuscarComprobanteIngresoEgreso
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(754, 293)
            Me.Controls.Add(Me.ListView2)
            Me.Controls.Add(Me.ListView1)
            Me.Controls.Add(Me.rbtIngreso)
            Me.Controls.Add(Me.rbtEgreso)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtParametrobusqueda)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmBuscarComprobanteIngresoEgreso"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "COMPROBANTES INGRESO / EGRESO (Doble click para seleccionar)"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtParametrobusqueda As System.Windows.Forms.TextBox
        Friend WithEvents rbtEgreso As System.Windows.Forms.RadioButton
        Friend WithEvents rbtIngreso As System.Windows.Forms.RadioButton
        Friend WithEvents ListView1 As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ListView2 As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    End Class
End Namespace