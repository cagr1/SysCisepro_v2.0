Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteTransferenciasActivosFijos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteTransferenciasActivosFijos))
            Me.crvTransferenciaActivosFijos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.lblIdTransferencia = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'crvTransferenciaActivosFijos
            '
            Me.crvTransferenciaActivosFijos.ActiveViewIndex = -1
            Me.crvTransferenciaActivosFijos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvTransferenciaActivosFijos.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvTransferenciaActivosFijos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvTransferenciaActivosFijos.Location = New System.Drawing.Point(0, 0)
            Me.crvTransferenciaActivosFijos.Name = "crvTransferenciaActivosFijos"
            Me.crvTransferenciaActivosFijos.Size = New System.Drawing.Size(1014, 736)
            Me.crvTransferenciaActivosFijos.TabIndex = 0
            Me.crvTransferenciaActivosFijos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'lblIdTransferencia
            '
            Me.lblIdTransferencia.AutoSize = True
            Me.lblIdTransferencia.BackColor = System.Drawing.Color.Transparent
            Me.lblIdTransferencia.Location = New System.Drawing.Point(501, 9)
            Me.lblIdTransferencia.Name = "lblIdTransferencia"
            Me.lblIdTransferencia.Size = New System.Drawing.Size(13, 13)
            Me.lblIdTransferencia.TabIndex = 1
            Me.lblIdTransferencia.Text = "0"
            '
            'FormReporteTransferenciasActivosFijos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = Color.White
            Me.ClientSize = New System.Drawing.Size(1014, 736)
            Me.Controls.Add(Me.lblIdTransferencia)
            Me.Controls.Add(Me.crvTransferenciaActivosFijos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormReporteTransferenciasActivosFijos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REPORTE DE TRANSFERENCIA DE ACTIVOS"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvTransferenciaActivosFijos As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents lblIdTransferencia As System.Windows.Forms.Label
    End Class
End Namespace