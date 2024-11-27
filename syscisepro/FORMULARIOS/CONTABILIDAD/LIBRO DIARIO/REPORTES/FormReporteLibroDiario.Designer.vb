Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteLibroDiario
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteLibroDiario))
            Me.crvReporteLibroDiario = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblIdLibroDiario = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'crvReporteLibroDiario
            '
            Me.crvReporteLibroDiario.ActiveViewIndex = -1
            Me.crvReporteLibroDiario.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvReporteLibroDiario.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvReporteLibroDiario.Location = New System.Drawing.Point(0, 0)
            Me.crvReporteLibroDiario.Name = "crvReporteLibroDiario"
            Me.crvReporteLibroDiario.ShowLogo = False
            Me.crvReporteLibroDiario.Size = New System.Drawing.Size(979, 552)
            Me.crvReporteLibroDiario.TabIndex = 0
            Me.crvReporteLibroDiario.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(801, 9)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(12, 13)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "/"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(756, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(12, 13)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "/"
            '
            'lblIdLibroDiario
            '
            Me.lblIdLibroDiario.AutoSize = True
            Me.lblIdLibroDiario.Location = New System.Drawing.Point(773, 9)
            Me.lblIdLibroDiario.Name = "lblIdLibroDiario"
            Me.lblIdLibroDiario.Size = New System.Drawing.Size(25, 13)
            Me.lblIdLibroDiario.TabIndex = 4
            Me.lblIdLibroDiario.Text = "000"
            '
            'FormReporteLibroDiario
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(979, 552)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblIdLibroDiario)
            Me.Controls.Add(Me.crvReporteLibroDiario)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteLibroDiario"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REPORTE LIBRO DIARIO"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvReporteLibroDiario As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblIdLibroDiario As System.Windows.Forms.Label
    End Class
End Namespace