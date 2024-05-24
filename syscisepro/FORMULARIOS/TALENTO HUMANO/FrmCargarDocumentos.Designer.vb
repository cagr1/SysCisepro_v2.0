Namespace FORMULARIOS.TALENTO_HUMANO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCargarDocumentos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargarDocumentos))
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ComboBox1 = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.bntHorarios = New System.Windows.Forms.Button()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'Button2
            '
            Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.Location = New System.Drawing.Point(542, 61)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(75, 23)
            Me.Button2.TabIndex = 7
            Me.Button2.Text = "ACEPTAR"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Button1.Location = New System.Drawing.Point(461, 61)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 6
            Me.Button1.Text = "CANCELAR"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(12, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(144, 13)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "TIPO DE DOCUMENTO:"
            '
            'ComboBox1
            '
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Items.AddRange(New Object() {"CÉDULA & VOTACIÓN", "LIBRETA MILITAR", "CONTRATO", "OTRO"})
            Me.ComboBox1.Location = New System.Drawing.Point(159, 6)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(287, 21)
            Me.ComboBox1.TabIndex = 9
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(12, 36)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(127, 13)
            Me.Label2.TabIndex = 10
            Me.Label2.Text = "RUTA / DIRECCIÓN:"
            '
            'TextBox1
            '
            Me.TextBox1.Enabled = False
            Me.TextBox1.Location = New System.Drawing.Point(159, 33)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(431, 20)
            Me.TextBox1.TabIndex = 11
            '
            'bntHorarios
            '
            Me.bntHorarios.BackColor = System.Drawing.Color.White
            Me.bntHorarios.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntHorarios.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.bntHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bntHorarios.Location = New System.Drawing.Point(591, 29)
            Me.bntHorarios.Name = "bntHorarios"
            Me.bntHorarios.Size = New System.Drawing.Size(26, 26)
            Me.bntHorarios.TabIndex = 195
            Me.bntHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntHorarios.UseVisualStyleBackColor = False
            '
            'TextBox2
            '
            Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox2.Enabled = False
            Me.TextBox2.Location = New System.Drawing.Point(452, 6)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(165, 20)
            Me.TextBox2.TabIndex = 196
            '
            'OpenFileDialog1
            '
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.Red
            Me.Label3.Location = New System.Drawing.Point(12, 66)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(443, 13)
            Me.Label3.TabIndex = 197
            '
            'FrmCargarDocumentos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(620, 90)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.TextBox2)
            Me.Controls.Add(Me.bntHorarios)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.ComboBox1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmCargarDocumentos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "CARGAR DOCUMENTOS"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents bntHorarios As System.Windows.Forms.Button
        Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents Label3 As System.Windows.Forms.Label
    End Class
End Namespace