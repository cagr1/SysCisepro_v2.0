Namespace FORMULARIOS.TALENTO_HUMANO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmSeleccionarMotivoFechaSalida
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSeleccionarMotivoFechaSalida))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(161, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "FECHA AVISO DE SALIDA:"
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.Location = New System.Drawing.Point(170, 4)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
            Me.DateTimePicker1.TabIndex = 1
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(3, 36)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(246, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "MOTIVO DE RENUNCIA / OBSERVACIÓN"
            '
            'TextBox1
            '
            Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox1.Location = New System.Drawing.Point(6, 52)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(364, 89)
            Me.TextBox1.TabIndex = 3
            '
            'Button1
            '
            Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Button1.Location = New System.Drawing.Point(214, 147)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 4
            Me.Button1.Text = "CANCELAR"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.Location = New System.Drawing.Point(295, 147)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(75, 23)
            Me.Button2.TabIndex = 5
            Me.Button2.Text = "ACEPTAR"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'FrmSeleccionarMotivoFechaSalida
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(374, 177)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.DateTimePicker1)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmSeleccionarMotivoFechaSalida"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SALIDA"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Button2 As System.Windows.Forms.Button
    End Class
End Namespace