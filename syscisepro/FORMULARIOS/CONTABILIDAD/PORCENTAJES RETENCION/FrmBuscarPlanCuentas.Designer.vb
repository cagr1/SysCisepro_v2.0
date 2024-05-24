Namespace FORMULARIOS.CONTABILIDAD.PORCENTAJES_RETENCION
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmBuscarPlanCuentas
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
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.cbxTipoCuenta = New System.Windows.Forms.ComboBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.txtParametrobusqueda = New System.Windows.Forms.TextBox()
            Me.listView1 = New System.Windows.Forms.ListView()
            Me.SuspendLayout()
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "CUENTA"
            Me.ColumnHeader3.Width = 600
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.White
            Me.label2.Location = New System.Drawing.Point(406, 8)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(33, 14)
            Me.label2.TabIndex = 137
            Me.label2.Text = "TIPO:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(6, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(51, 14)
            Me.Label1.TabIndex = 134
            Me.Label1.Text = "BUSCAR:"
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "CÓDIGO"
            Me.ColumnHeader4.Width = 100
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "ID"
            Me.ColumnHeader1.Width = 0
            '
            'cbxTipoCuenta
            '
            Me.cbxTipoCuenta.BackColor = System.Drawing.Color.White
            Me.cbxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbxTipoCuenta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxTipoCuenta.FormattingEnabled = True
            Me.cbxTipoCuenta.Items.AddRange(New Object() {"-- TODOS --", "ACTIVOS", "PASIVOS", "PATRIMONIO", "INGRESOS", "GASTOS", "GANANCIAS"})
            Me.cbxTipoCuenta.Location = New System.Drawing.Point(445, 4)
            Me.cbxTipoCuenta.Name = "cbxTipoCuenta"
            Me.cbxTipoCuenta.Size = New System.Drawing.Size(116, 21)
            Me.cbxTipoCuenta.TabIndex = 138
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.White
            Me.label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.Black
            Me.label4.Location = New System.Drawing.Point(12, 136)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(709, 68)
            Me.label4.TabIndex = 135
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.label4.Visible = False
            '
            'txtParametrobusqueda
            '
            Me.txtParametrobusqueda.BackColor = System.Drawing.Color.White
            Me.txtParametrobusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtParametrobusqueda.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtParametrobusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.txtParametrobusqueda.Location = New System.Drawing.Point(59, 4)
            Me.txtParametrobusqueda.Name = "txtParametrobusqueda"
            Me.txtParametrobusqueda.Size = New System.Drawing.Size(295, 23)
            Me.txtParametrobusqueda.TabIndex = 133
            '
            'listView1
            '
            Me.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader3})
            Me.listView1.FullRowSelect = True
            Me.listView1.Location = New System.Drawing.Point(2, 32)
            Me.listView1.MultiSelect = False
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New System.Drawing.Size(729, 263)
            Me.listView1.TabIndex = 136
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = System.Windows.Forms.View.Details
            '
            'FrmBuscarPlanCuentas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(733, 298)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cbxTipoCuenta)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.txtParametrobusqueda)
            Me.Controls.Add(Me.listView1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "FrmBuscarPlanCuentas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "BUSCAR CUENTAS CONTABLES"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Public WithEvents cbxTipoCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents label4 As System.Windows.Forms.Label
        Public WithEvents txtParametrobusqueda As System.Windows.Forms.TextBox
        Friend WithEvents listView1 As System.Windows.Forms.ListView
    End Class

End Namespace
