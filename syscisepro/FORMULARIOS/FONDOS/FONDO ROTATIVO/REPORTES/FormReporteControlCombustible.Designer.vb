Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteControlCombustible
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteControlCombustible))
            Me.crvControlCombustible = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.lblIdControlCombustible = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'crvControlCombustible
            '
            Me.crvControlCombustible.ActiveViewIndex = -1
            Me.crvControlCombustible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvControlCombustible.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvControlCombustible.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvControlCombustible.Location = New System.Drawing.Point(0, 0)
            Me.crvControlCombustible.Name = "crvControlCombustible"
            Me.crvControlCombustible.Size = New System.Drawing.Size(896, 568)
            Me.crvControlCombustible.TabIndex = 0
            Me.crvControlCombustible.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'lblIdControlCombustible
            '
            Me.lblIdControlCombustible.AutoSize = True
            Me.lblIdControlCombustible.Location = New System.Drawing.Point(651, 9)
            Me.lblIdControlCombustible.Name = "lblIdControlCombustible"
            Me.lblIdControlCombustible.Size = New System.Drawing.Size(25, 13)
            Me.lblIdControlCombustible.TabIndex = 1
            Me.lblIdControlCombustible.Text = "000"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(678, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(12, 13)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "/"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(637, 9)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(12, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "/"
            '
            'FormReporteControlCombustible
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(896, 568)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblIdControlCombustible)
            Me.Controls.Add(Me.crvControlCombustible)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteControlCombustible"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REPORTE CONTROL DE COMBUSTIBLE"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvControlCombustible As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents lblIdControlCombustible As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace