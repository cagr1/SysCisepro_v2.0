Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmBuscarActivoFijo
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.txtParametrobusqueda = New System.Windows.Forms.TextBox()
            Me.dgvActivosFijos = New System.Windows.Forms.DataGridView()
            Me.cbmTipoActivo = New System.Windows.Forms.ComboBox()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvActivosFijos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtParametrobusqueda
            '
            Me.txtParametrobusqueda.BackColor = System.Drawing.Color.White
            Me.txtParametrobusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtParametrobusqueda.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtParametrobusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.txtParametrobusqueda.Location = New System.Drawing.Point(84, 2)
            Me.txtParametrobusqueda.Name = "txtParametrobusqueda"
            Me.txtParametrobusqueda.Size = New System.Drawing.Size(428, 23)
            Me.txtParametrobusqueda.TabIndex = 11
            '
            'dgvActivosFijos
            '
            Me.dgvActivosFijos.AllowUserToAddRows = False
            Me.dgvActivosFijos.AllowUserToDeleteRows = False
            Me.dgvActivosFijos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvActivosFijos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvActivosFijos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgvActivosFijos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgvActivosFijos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvActivosFijos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvActivosFijos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvActivosFijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvActivosFijos.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvActivosFijos.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvActivosFijos.Location = New System.Drawing.Point(3, 28)
            Me.dgvActivosFijos.MultiSelect = False
            Me.dgvActivosFijos.Name = "dgvActivosFijos"
            Me.dgvActivosFijos.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvActivosFijos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvActivosFijos.RowHeadersVisible = False
            Me.dgvActivosFijos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.0!)
            Me.dgvActivosFijos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvActivosFijos.Size = New System.Drawing.Size(752, 265)
            Me.dgvActivosFijos.TabIndex = 12
            '
            'cbmTipoActivo
            '
            Me.cbmTipoActivo.BackColor = System.Drawing.Color.White
            Me.cbmTipoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmTipoActivo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmTipoActivo.ForeColor = System.Drawing.Color.Black
            Me.cbmTipoActivo.FormattingEnabled = True
            Me.cbmTipoActivo.Items.AddRange(New Object() {"ARMAS", "RADIOS", "VEHICULOS", "TERRENOS", "EQUIPOS DE COMPUTO", "LIBROS Y COLECCIONES", "EQUIPOS DE OFICINA", "MUEBLES DE OFICINA", "EQUIPOS DE COCINA", "EQUIPOS DE AMBIENTACION", "EQUIPOS DE COMUNICACION Y TELEFONIA", "EQUIPOS DE SEGURIDAD INDUSTRIAL", "CAMARAS DE SEGURIDAD", "GENERADORES", "CHALECOS", "SOFTWARE"})
            Me.cbmTipoActivo.Location = New System.Drawing.Point(570, 3)
            Me.cbmTipoActivo.Name = "cbmTipoActivo"
            Me.cbmTipoActivo.Size = New System.Drawing.Size(185, 21)
            Me.cbmTipoActivo.TabIndex = 14
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(12, 2)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(46, 20)
            Me.KryptonLabel1.TabIndex = 16
            Me.KryptonLabel1.Values.Text = "Buscar"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(518, 2)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel2.TabIndex = 17
            Me.KryptonLabel2.Values.Text = "Tipo"
            '
            'FrmBuscarActivoFijo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(758, 296)
            Me.Controls.Add(Me.KryptonLabel2)
            Me.Controls.Add(Me.KryptonLabel1)
            Me.Controls.Add(Me.cbmTipoActivo)
            Me.Controls.Add(Me.txtParametrobusqueda)
            Me.Controls.Add(Me.dgvActivosFijos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "FrmBuscarActivoFijo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BUSCAR ACTIVO FIJO (Doble click para seleccionar)"
            CType(Me.dgvActivosFijos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtParametrobusqueda As System.Windows.Forms.TextBox
        Friend WithEvents dgvActivosFijos As System.Windows.Forms.DataGridView
        Friend WithEvents cbmTipoActivo As System.Windows.Forms.ComboBox
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace