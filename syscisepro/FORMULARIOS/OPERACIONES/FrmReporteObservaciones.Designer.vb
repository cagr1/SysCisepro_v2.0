Namespace FORMULARIOS.OPERACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmReporteObservaciones
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
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtObservaciones = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblCantRep = New System.Windows.Forms.Label()
            Me.GroupBox4.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.White
            Me.GroupBox4.Controls.Add(Me.Label3)
            Me.GroupBox4.Controls.Add(Me.Label16)
            Me.GroupBox4.Controls.Add(Me.DateTimePicker5)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.Location = New System.Drawing.Point(-2, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(619, 44)
            Me.GroupBox4.TabIndex = 202
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "OBSERVACIONES DEL PUESTO / VIGILANTE"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(86, 21)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(0, 13)
            Me.Label3.TabIndex = 207
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(13, 21)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(67, 13)
            Me.Label16.TabIndex = 205
            Me.Label16.Text = "VIGILANTE:"
            '
            'DateTimePicker5
            '
            Me.DateTimePicker5.Enabled = False
            Me.DateTimePicker5.Location = New System.Drawing.Point(361, 15)
            Me.DateTimePicker5.Name = "DateTimePicker5"
            Me.DateTimePicker5.Size = New System.Drawing.Size(248, 20)
            Me.DateTimePicker5.TabIndex = 204
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(320, 17)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(43, 13)
            Me.Label1.TabIndex = 206
            Me.Label1.Text = "FECHA:"
            '
            'txtObservaciones
            '
            Me.txtObservaciones.BackColor = System.Drawing.Color.White
            Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservaciones.Location = New System.Drawing.Point(-1, 61)
            Me.txtObservaciones.Multiline = True
            Me.txtObservaciones.Name = "txtObservaciones"
            Me.txtObservaciones.Size = New System.Drawing.Size(619, 115)
            Me.txtObservaciones.TabIndex = 203
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(-1, 48)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(101, 13)
            Me.Label2.TabIndex = 206
            Me.Label2.Text = "OBSERVACIONES:"
            '
            'Button2
            '
            Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.Location = New System.Drawing.Point(533, 182)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(75, 23)
            Me.Button2.TabIndex = 208
            Me.Button2.Text = "ACEPTAR"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Button1.Location = New System.Drawing.Point(452, 182)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 207
            Me.Button1.Text = "CANCELAR"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(442, 47)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(154, 13)
            Me.Label4.TabIndex = 209
            Me.Label4.Text = "RADIOS NO CONTESTADOS:"
            '
            'lblCantRep
            '
            Me.lblCantRep.AutoSize = True
            Me.lblCantRep.Location = New System.Drawing.Point(596, 47)
            Me.lblCantRep.Name = "lblCantRep"
            Me.lblCantRep.Size = New System.Drawing.Size(13, 13)
            Me.lblCantRep.TabIndex = 210
            Me.lblCantRep.Text = "0"
            '
            'FrmReporteObservaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(616, 213)
            Me.Controls.Add(Me.lblCantRep)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtObservaciones)
            Me.Controls.Add(Me.GroupBox4)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "FrmReporteObservaciones"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "OBSERVACIONES POR VIGILANTE"
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblCantRep As System.Windows.Forms.Label
    End Class
End Namespace