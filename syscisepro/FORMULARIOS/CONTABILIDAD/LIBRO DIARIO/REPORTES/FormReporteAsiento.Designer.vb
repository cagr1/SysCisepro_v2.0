Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteAsiento
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteAsiento))
            Me.crvAsientoDiario = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.lblNumeroRegistro = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'crvAsientoDiario
            '
            Me.crvAsientoDiario.ActiveViewIndex = -1
            Me.crvAsientoDiario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvAsientoDiario.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvAsientoDiario.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvAsientoDiario.Location = New System.Drawing.Point(0, 0)
            Me.crvAsientoDiario.Name = "crvAsientoDiario"
            Me.crvAsientoDiario.Size = New System.Drawing.Size(844, 647)
            Me.crvAsientoDiario.TabIndex = 0
            Me.crvAsientoDiario.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'lblNumeroRegistro
            '
            Me.lblNumeroRegistro.AutoSize = True
            Me.lblNumeroRegistro.Location = New System.Drawing.Point(497, 9)
            Me.lblNumeroRegistro.Name = "lblNumeroRegistro"
            Me.lblNumeroRegistro.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroRegistro.TabIndex = 1
            Me.lblNumeroRegistro.Text = "0"
            '
            'FormReporteAsiento
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(844, 647)
            Me.Controls.Add(Me.lblNumeroRegistro)
            Me.Controls.Add(Me.crvAsientoDiario)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteAsiento"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REPORTE"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvAsientoDiario As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents lblNumeroRegistro As System.Windows.Forms.Label
    End Class
End Namespace