Namespace FORMULARIOS.OPERACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmReporteObservaciones
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
            Me.Label3 = New System.Windows.Forms.Label()
            Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
            Me.txtObservaciones = New System.Windows.Forms.TextBox()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.lblCantRep = New System.Windows.Forms.Label()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.SuspendLayout()
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(63, 28)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(13, 13)
            Me.Label3.TabIndex = 207
            Me.Label3.Text = "0"
            '
            'DateTimePicker5
            '
            Me.DateTimePicker5.Enabled = False
            Me.DateTimePicker5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateTimePicker5.Location = New System.Drawing.Point(350, 24)
            Me.DateTimePicker5.Name = "DateTimePicker5"
            Me.DateTimePicker5.Size = New System.Drawing.Size(189, 21)
            Me.DateTimePicker5.TabIndex = 204
            '
            'txtObservaciones
            '
            Me.txtObservaciones.BackColor = System.Drawing.Color.White
            Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservaciones.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservaciones.Location = New System.Drawing.Point(-1, 77)
            Me.txtObservaciones.Multiline = True
            Me.txtObservaciones.Name = "txtObservaciones"
            Me.txtObservaciones.Size = New System.Drawing.Size(540, 95)
            Me.txtObservaciones.TabIndex = 203
            '
            'Button2
            '
            Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(79, Byte), Integer))
            Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Button2.FlatAppearance.BorderSize = 0
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.ForeColor = System.Drawing.Color.White
            Me.Button2.Location = New System.Drawing.Point(439, 178)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(89, 34)
            Me.Button2.TabIndex = 208
            Me.Button2.Text = "ACEPTAR"
            Me.Button2.UseVisualStyleBackColor = False
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Button1.FlatAppearance.BorderSize = 0
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.ForeColor = System.Drawing.Color.White
            Me.Button1.Location = New System.Drawing.Point(341, 178)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(89, 34)
            Me.Button1.TabIndex = 207
            Me.Button1.Text = "CANCELAR"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'lblCantRep
            '
            Me.lblCantRep.AutoSize = True
            Me.lblCantRep.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantRep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblCantRep.Location = New System.Drawing.Point(505, 54)
            Me.lblCantRep.Name = "lblCantRep"
            Me.lblCantRep.Size = New System.Drawing.Size(13, 13)
            Me.lblCantRep.TabIndex = 210
            Me.lblCantRep.Text = "0"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(-1, 51)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(90, 20)
            Me.KryptonLabel1.TabIndex = 211
            Me.KryptonLabel1.Values.Text = "Observaciones"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(363, 51)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(133, 20)
            Me.KryptonLabel2.TabIndex = 212
            Me.KryptonLabel2.Values.Text = "Radios No Contestado"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(-1, 24)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(58, 20)
            Me.KryptonLabel3.TabIndex = 213
            Me.KryptonLabel3.Values.Text = "Vigilante"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(302, 24)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel4.TabIndex = 214
            Me.KryptonLabel4.Values.Text = "Fecha"
            '
            'FrmReporteObservaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(540, 213)
            Me.Controls.Add(Me.KryptonLabel4)
            Me.Controls.Add(Me.DateTimePicker5)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.KryptonLabel3)
            Me.Controls.Add(Me.KryptonLabel2)
            Me.Controls.Add(Me.KryptonLabel1)
            Me.Controls.Add(Me.lblCantRep)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.txtObservaciones)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "FrmReporteObservaciones"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "OBSERVACIONES POR VIGILANTE"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblCantRep As System.Windows.Forms.Label
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace