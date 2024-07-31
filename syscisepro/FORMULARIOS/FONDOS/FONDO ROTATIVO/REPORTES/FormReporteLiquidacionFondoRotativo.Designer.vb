Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteLiquidacionFondoRotativo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteLiquidacionFondoRotativo))
            Me.crvReporteLiquidacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.lblIdLiquidacionFondoRotativo = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'crvReporteLiquidacion
            '
            Me.crvReporteLiquidacion.ActiveViewIndex = -1
            Me.crvReporteLiquidacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvReporteLiquidacion.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvReporteLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvReporteLiquidacion.Location = New System.Drawing.Point(0, 0)
            Me.crvReporteLiquidacion.Name = "crvReporteLiquidacion"
            Me.crvReporteLiquidacion.Size = New System.Drawing.Size(934, 582)
            Me.crvReporteLiquidacion.TabIndex = 0
            Me.crvReporteLiquidacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'lblIdLiquidacionFondoRotativo
            '
            Me.lblIdLiquidacionFondoRotativo.AutoSize = True
            Me.lblIdLiquidacionFondoRotativo.Location = New System.Drawing.Point(1032, 9)
            Me.lblIdLiquidacionFondoRotativo.Name = "lblIdLiquidacionFondoRotativo"
            Me.lblIdLiquidacionFondoRotativo.Size = New System.Drawing.Size(25, 13)
            Me.lblIdLiquidacionFondoRotativo.TabIndex = 1
            Me.lblIdLiquidacionFondoRotativo.Text = "000"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(1015, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(12, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "/"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(1060, 9)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(12, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "/"
            '
            'FormReporteLiquidacionFondoRotativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(934, 582)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblIdLiquidacionFondoRotativo)
            Me.Controls.Add(Me.crvReporteLiquidacion)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteLiquidacionFondoRotativo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REPORTE LIQUIDACION FONDO ROTATIVO"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvReporteLiquidacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents lblIdLiquidacionFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace