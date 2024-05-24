Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteCodigosActivos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteCodigosActivos))
            Me.crvCodigos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.SuspendLayout()
            '
            'crvCodigos
            '
            Me.crvCodigos.ActiveViewIndex = -1
            Me.crvCodigos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvCodigos.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvCodigos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvCodigos.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.crvCodigos.Location = New System.Drawing.Point(0, 0)
            Me.crvCodigos.Name = "crvCodigos"
            Me.crvCodigos.Size = New System.Drawing.Size(1012, 524)
            Me.crvCodigos.TabIndex = 0
            Me.crvCodigos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FormReporteCodigosActivos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1012, 524)
            Me.Controls.Add(Me.crvCodigos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormReporteCodigosActivos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REPORTE GENERAL DE CODIGOS DE ACTIVOS"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents crvCodigos As CrystalDecisions.Windows.Forms.CrystalReportViewer
    End Class
End Namespace