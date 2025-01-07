Namespace FORMULARIOS.TALENTO_HUMANO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCargarDocumentos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargarDocumentos))
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.ComboBox1 = New System.Windows.Forms.ComboBox()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.bntHorarios = New System.Windows.Forms.Button()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.SuspendLayout()
            '
            'Button2
            '
            Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(79, Byte), Integer))
            Me.Button2.FlatAppearance.BorderSize = 0
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.ForeColor = System.Drawing.Color.White
            Me.Button2.Location = New System.Drawing.Point(528, 58)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(89, 34)
            Me.Button2.TabIndex = 7
            Me.Button2.Text = "ACEPTAR"
            Me.Button2.UseVisualStyleBackColor = False
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Button1.FlatAppearance.BorderSize = 0
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.ForeColor = System.Drawing.Color.White
            Me.Button1.Location = New System.Drawing.Point(434, 58)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(89, 34)
            Me.Button1.TabIndex = 6
            Me.Button1.Text = "CANCELAR"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'ComboBox1
            '
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Items.AddRange(New Object() {"CÉDULA & VOTACIÓN", "LIBRETA MILITAR", "CONTRATO", "OTRO"})
            Me.ComboBox1.Location = New System.Drawing.Point(134, 6)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(287, 21)
            Me.ComboBox1.TabIndex = 9
            '
            'TextBox1
            '
            Me.TextBox1.Enabled = False
            Me.TextBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.Location = New System.Drawing.Point(134, 33)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(405, 21)
            Me.TextBox1.TabIndex = 11
            '
            'bntHorarios
            '
            Me.bntHorarios.BackColor = System.Drawing.Color.Transparent
            Me.bntHorarios.FlatAppearance.BorderSize = 0
            Me.bntHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntHorarios.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntHorarios.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.bntHorarios.Location = New System.Drawing.Point(581, 29)
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
            Me.TextBox2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox2.Location = New System.Drawing.Point(452, 6)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(165, 21)
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
            Me.Label3.Size = New System.Drawing.Size(399, 21)
            Me.Label3.TabIndex = 197
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(13, 6)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(102, 20)
            Me.KryptonLabel1.TabIndex = 198
            Me.KryptonLabel1.Values.Text = "Tipo Documento"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(12, 29)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(98, 20)
            Me.KryptonLabel2.TabIndex = 199
            Me.KryptonLabel2.Values.Text = "Ruta / Direccion"
            '
            'FrmCargarDocumentos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(620, 96)
            Me.Controls.Add(Me.KryptonLabel2)
            Me.Controls.Add(Me.KryptonLabel1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.TextBox2)
            Me.Controls.Add(Me.bntHorarios)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.ComboBox1)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmCargarDocumentos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CARGAR DOCUMENTOS"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents bntHorarios As System.Windows.Forms.Button
        Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace