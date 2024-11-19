Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteActivosFijosImprimirCodigos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteActivosFijosImprimirCodigos))
            Me.crvActivosFijos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbmTipoActivo = New System.Windows.Forms.ComboBox()
            Me.SuspendLayout()
            '
            'crvActivosFijos
            '
            Me.crvActivosFijos.ActiveViewIndex = -1
            Me.crvActivosFijos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvActivosFijos.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvActivosFijos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvActivosFijos.Location = New System.Drawing.Point(0, 0)
            Me.crvActivosFijos.Name = "crvActivosFijos"
            Me.crvActivosFijos.ShowLogo = False
            Me.crvActivosFijos.Size = New System.Drawing.Size(1014, 502)
            Me.crvActivosFijos.TabIndex = 0
            Me.crvActivosFijos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(489, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(74, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "TIPO ACTIVO"
            '
            'cbmTipoActivo
            '
            Me.cbmTipoActivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmTipoActivo.FormattingEnabled = True
            Me.cbmTipoActivo.Items.AddRange(New Object() {"ARMAS", "RADIOS", "VEHICULOS", "TERRENOS", "EQUIPOS DE COMPUTO", "LIBROS Y COLECCIONES", "EQUIPOS DE OFICINA", "MUEBLES DE OFICINA", "EQUIPOS DE COCINA", "EQUIPOS DE AMBIENTACION", "EQUIPOS DE COMUNICACION Y TELEFONIA", "EQUIPOS DE SEGURIDAD INDUSTRIAL", "CAMARAS DE SEGURIDAD", "GENERADORES", "CHALECOS", "SOFTWARE"})
            Me.cbmTipoActivo.Location = New System.Drawing.Point(578, 2)
            Me.cbmTipoActivo.Name = "cbmTipoActivo"
            Me.cbmTipoActivo.Size = New System.Drawing.Size(256, 21)
            Me.cbmTipoActivo.TabIndex = 3
            '
            'FormReporteActivosFijosImprimirCodigos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1014, 502)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cbmTipoActivo)
            Me.Controls.Add(Me.crvActivosFijos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormReporteActivosFijosImprimirCodigos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.Text = "GENERAR STICKER CON CODIGOS DE ACTIVOS FIJOS"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvActivosFijos As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbmTipoActivo As System.Windows.Forms.ComboBox
    End Class
End Namespace