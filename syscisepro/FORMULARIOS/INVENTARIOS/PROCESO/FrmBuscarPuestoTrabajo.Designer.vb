Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmBuscarPuestoTrabajo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarPuestoTrabajo))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtParametrobusqueda = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(3, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(40, 14)
            Me.Label1.TabIndex = 13
            Me.Label1.Text = "Buscar"
            '
            'txtParametrobusqueda
            '
            Me.txtParametrobusqueda.BackColor = System.Drawing.Color.White
            Me.txtParametrobusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtParametrobusqueda.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtParametrobusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.txtParametrobusqueda.Location = New System.Drawing.Point(57, 3)
            Me.txtParametrobusqueda.Name = "txtParametrobusqueda"
            Me.txtParametrobusqueda.Size = New System.Drawing.Size(295, 23)
            Me.txtParametrobusqueda.TabIndex = 11
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(370, 7)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(41, 14)
            Me.Label2.TabIndex = 14
            Me.Label2.Text = "Cliente"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(420, 7)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(0, 13)
            Me.Label3.TabIndex = 15
            '
            'ListView1
            '
            Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28})
            Me.ListView1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ListView1.FullRowSelect = True
            Me.ListView1.HideSelection = False
            Me.ListView1.Location = New System.Drawing.Point(0, 28)
            Me.ListView1.MultiSelect = False
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(856, 312)
            Me.ListView1.TabIndex = 16
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "ID"
            Me.ColumnHeader1.Width = 0
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "RIVER"
            Me.ColumnHeader4.Width = 50
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "SITIO"
            Me.ColumnHeader3.Width = 200
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "DIRECCIÓN"
            Me.ColumnHeader5.Width = 300
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "CUIDAD"
            Me.ColumnHeader6.Width = 90
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "SUPERVISOR"
            Me.ColumnHeader7.Width = 200
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "ID PRO"
            Me.ColumnHeader2.Width = 0
            '
            'ColumnHeader8
            '
            Me.ColumnHeader8.Text = "PROVINCIA"
            Me.ColumnHeader8.Width = 0
            '
            'ColumnHeader9
            '
            Me.ColumnHeader9.Text = "ID CIU"
            Me.ColumnHeader9.Width = 0
            '
            'ColumnHeader10
            '
            Me.ColumnHeader10.Text = "ID PAR"
            Me.ColumnHeader10.Width = 0
            '
            'ColumnHeader11
            '
            Me.ColumnHeader11.Text = "PARROQUIA"
            Me.ColumnHeader11.Width = 0
            '
            'ColumnHeader12
            '
            Me.ColumnHeader12.Text = "REFERENCIA"
            Me.ColumnHeader12.Width = 0
            '
            'ColumnHeader13
            '
            Me.ColumnHeader13.Text = "TIPO"
            Me.ColumnHeader13.Width = 0
            '
            'ColumnHeader14
            '
            Me.ColumnHeader14.Text = "ID SUP"
            Me.ColumnHeader14.Width = 0
            '
            'ColumnHeader15
            '
            Me.ColumnHeader15.Text = "ESTA"
            Me.ColumnHeader15.Width = 0
            '
            'ColumnHeader16
            '
            Me.ColumnHeader16.Text = "CLIE"
            Me.ColumnHeader16.Width = 0
            '
            'ColumnHeader17
            '
            Me.ColumnHeader17.Text = "CEDRUC"
            Me.ColumnHeader17.Width = 0
            '
            'ColumnHeader18
            '
            Me.ColumnHeader18.Text = "RUC"
            Me.ColumnHeader18.Width = 0
            '
            'ColumnHeader19
            '
            Me.ColumnHeader19.Text = "RAZON SOC"
            Me.ColumnHeader19.Width = 0
            '
            'ColumnHeader20
            '
            Me.ColumnHeader20.Text = "NOM COM"
            Me.ColumnHeader20.Width = 0
            '
            'ColumnHeader21
            '
            Me.ColumnHeader21.Text = "LAT"
            Me.ColumnHeader21.Width = 0
            '
            'ColumnHeader22
            '
            Me.ColumnHeader22.Text = "LOG"
            Me.ColumnHeader22.Width = 0
            '
            'ColumnHeader23
            '
            Me.ColumnHeader23.Text = "GRUPO"
            Me.ColumnHeader23.Width = 0
            '
            'ColumnHeader24
            '
            Me.ColumnHeader24.Text = "RIVE"
            Me.ColumnHeader24.Width = 0
            '
            'ColumnHeader25
            '
            Me.ColumnHeader25.Text = "P. 24H"
            Me.ColumnHeader25.Width = 0
            '
            'ColumnHeader26
            '
            Me.ColumnHeader26.Text = "P. 12H"
            Me.ColumnHeader26.Width = 0
            '
            'ColumnHeader27
            '
            Me.ColumnHeader27.Text = "P. 8H"
            Me.ColumnHeader27.Width = 0
            '
            'ColumnHeader28
            '
            Me.ColumnHeader28.Text = "P. OH"
            Me.ColumnHeader28.Width = 0
            '
            'FrmBuscarPuestoTrabajo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(856, 340)
            Me.Controls.Add(Me.ListView1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtParametrobusqueda)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmBuscarPuestoTrabajo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BUSCAR PUESTOS DE TRABAJO"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtParametrobusqueda As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents ListView1 As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    End Class
End Namespace