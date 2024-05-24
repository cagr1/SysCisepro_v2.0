Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteMantenimientosActivosFijos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteMantenimientosActivosFijos))
            Me.crvMantenimientoActivosFijos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.lblIdMantenimiento = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'crvMantenimientoActivosFijos
            '
            Me.crvMantenimientoActivosFijos.ActiveViewIndex = -1
            Me.crvMantenimientoActivosFijos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvMantenimientoActivosFijos.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvMantenimientoActivosFijos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvMantenimientoActivosFijos.Location = New System.Drawing.Point(0, 0)
            Me.crvMantenimientoActivosFijos.Name = "crvMantenimientoActivosFijos"
            Me.crvMantenimientoActivosFijos.Size = New System.Drawing.Size(1008, 730)
            Me.crvMantenimientoActivosFijos.TabIndex = 0
            Me.crvMantenimientoActivosFijos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'lblIdMantenimiento
            '
            Me.lblIdMantenimiento.AutoSize = True
            Me.lblIdMantenimiento.BackColor = System.Drawing.Color.Transparent
            Me.lblIdMantenimiento.Location = New System.Drawing.Point(479, 9)
            Me.lblIdMantenimiento.Name = "lblIdMantenimiento"
            Me.lblIdMantenimiento.Size = New System.Drawing.Size(13, 13)
            Me.lblIdMantenimiento.TabIndex = 2
            Me.lblIdMantenimiento.Text = "5"
            '
            'FormReporteMantenimientosActivosFijos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1008, 730)
            Me.Controls.Add(Me.lblIdMantenimiento)
            Me.Controls.Add(Me.crvMantenimientoActivosFijos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteMantenimientosActivosFijos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REPORTE DE MANTENIMIENTOS DE ACTIVOS FIJOS"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvMantenimientoActivosFijos As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents lblIdMantenimiento As System.Windows.Forms.Label
    End Class
End Namespace