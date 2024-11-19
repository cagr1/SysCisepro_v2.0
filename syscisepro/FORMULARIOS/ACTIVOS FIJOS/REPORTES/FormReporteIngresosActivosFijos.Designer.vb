Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteIngresosActivosFijos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteIngresosActivosFijos))
            Me.PanelCombo = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbmTipoActivo = New System.Windows.Forms.ComboBox()
            Me.panelReporte = New System.Windows.Forms.Panel()
            Me.crvDatos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.PanelCombo.SuspendLayout()
            Me.panelReporte.SuspendLayout()
            Me.SuspendLayout()
            '
            'PanelCombo
            '
            Me.PanelCombo.Controls.Add(Me.Label1)
            Me.PanelCombo.Controls.Add(Me.cbmTipoActivo)
            Me.PanelCombo.Location = New System.Drawing.Point(4, 4)
            Me.PanelCombo.Name = "PanelCombo"
            Me.PanelCombo.Size = New System.Drawing.Size(1000, 39)
            Me.PanelCombo.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(4, 11)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(85, 18)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Tipo Activo"
            '
            'cbmTipoActivo
            '
            Me.cbmTipoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmTipoActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmTipoActivo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmTipoActivo.FormattingEnabled = True
            Me.cbmTipoActivo.Items.AddRange(New Object() {"ARMAS", "RADIOS", "VEHICULOS", "TERRENOS", "EQUIPOS DE COMPUTO", "LIBROS Y COLECCIONES", "EQUIPOS DE OFICINA", "MUEBLES DE OFICINA", "EQUIPOS DE COCINA", "EQUIPOS DE AMBIENTACION", "EQUIPOS DE COMUNICACION Y TELEFONIA", "EQUIPOS DE SEGURIDAD INDUSTRIAL", "CAMARAS DE SEGURIDAD", "GENERADORES", "CHALECOS", "SOFTWARE"})
            Me.cbmTipoActivo.Location = New System.Drawing.Point(97, 8)
            Me.cbmTipoActivo.Name = "cbmTipoActivo"
            Me.cbmTipoActivo.Size = New System.Drawing.Size(256, 21)
            Me.cbmTipoActivo.TabIndex = 7
            '
            'panelReporte
            '
            Me.panelReporte.Controls.Add(Me.crvDatos)
            Me.panelReporte.Location = New System.Drawing.Point(4, 49)
            Me.panelReporte.Name = "panelReporte"
            Me.panelReporte.Size = New System.Drawing.Size(1000, 532)
            Me.panelReporte.TabIndex = 1
            '
            'crvDatos
            '
            Me.crvDatos.ActiveViewIndex = -1
            Me.crvDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvDatos.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvDatos.Location = New System.Drawing.Point(0, 0)
            Me.crvDatos.Name = "crvDatos"
            Me.crvDatos.Size = New System.Drawing.Size(1000, 529)
            Me.crvDatos.TabIndex = 1
            Me.crvDatos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FormReporteIngresosActivosFijos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1008, 581)
            Me.Controls.Add(Me.panelReporte)
            Me.Controls.Add(Me.PanelCombo)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteIngresosActivosFijos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REPORTE DE INGRESOS"
            Me.PanelCombo.ResumeLayout(False)
            Me.PanelCombo.PerformLayout()
            Me.panelReporte.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PanelCombo As System.Windows.Forms.Panel
        Friend WithEvents panelReporte As System.Windows.Forms.Panel
        Friend WithEvents crvDatos As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbmTipoActivo As System.Windows.Forms.ComboBox
    End Class
End Namespace