Namespace FORMULARIOS.CONTABILIDAD.CENTRO_COSTO.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteCentrosCosto
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteCentrosCosto))
            Me.crvReporteCentrosCosto = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.SuspendLayout()
            '
            'crvReporteCentrosCosto
            '
            Me.crvReporteCentrosCosto.ActiveViewIndex = -1
            Me.crvReporteCentrosCosto.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvReporteCentrosCosto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvReporteCentrosCosto.Location = New System.Drawing.Point(0, 0)
            Me.crvReporteCentrosCosto.Name = "crvReporteCentrosCosto"
            Me.crvReporteCentrosCosto.ShowLogo = False
            Me.crvReporteCentrosCosto.Size = New System.Drawing.Size(936, 526)
            Me.crvReporteCentrosCosto.TabIndex = 0
            Me.crvReporteCentrosCosto.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FormReporteCentrosCosto
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(936, 526)
            Me.Controls.Add(Me.crvReporteCentrosCosto)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteCentrosCosto"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REPORTE CENTROS DE COSTO"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents crvReporteCentrosCosto As CrystalDecisions.Windows.Forms.CrystalReportViewer
    End Class
End Namespace