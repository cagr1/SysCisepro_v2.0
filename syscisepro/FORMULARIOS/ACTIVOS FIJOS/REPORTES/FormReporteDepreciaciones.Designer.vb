Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteDepreciaciones
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteDepreciaciones))
            Me.crvDepreciaciones = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.lblIdDepreciacion = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'crvDepreciaciones
            '
            Me.crvDepreciaciones.ActiveViewIndex = -1
            Me.crvDepreciaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvDepreciaciones.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvDepreciaciones.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvDepreciaciones.Location = New System.Drawing.Point(0, 0)
            Me.crvDepreciaciones.Name = "crvDepreciaciones"
            Me.crvDepreciaciones.Size = New System.Drawing.Size(1008, 730)
            Me.crvDepreciaciones.TabIndex = 0
            Me.crvDepreciaciones.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'lblIdDepreciacion
            '
            Me.lblIdDepreciacion.AutoSize = True
            Me.lblIdDepreciacion.Location = New System.Drawing.Point(480, 8)
            Me.lblIdDepreciacion.Name = "lblIdDepreciacion"
            Me.lblIdDepreciacion.Size = New System.Drawing.Size(13, 13)
            Me.lblIdDepreciacion.TabIndex = 1
            Me.lblIdDepreciacion.Text = "0"
            '
            'FormReporteDepreciaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1008, 730)
            Me.Controls.Add(Me.lblIdDepreciacion)
            Me.Controls.Add(Me.crvDepreciaciones)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormReporteDepreciaciones"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REPORTE GENERAL DE DEPRECIACIONES"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvDepreciaciones As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents lblIdDepreciacion As System.Windows.Forms.Label
    End Class
End Namespace