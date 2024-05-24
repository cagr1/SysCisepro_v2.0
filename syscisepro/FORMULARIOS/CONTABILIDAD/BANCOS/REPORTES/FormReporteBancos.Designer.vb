Namespace FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteBancos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteBancos))
            Me.crvBancos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.SuspendLayout()
            '
            'crvBancos
            '
            Me.crvBancos.ActiveViewIndex = -1
            Me.crvBancos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvBancos.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvBancos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvBancos.Location = New System.Drawing.Point(0, 0)
            Me.crvBancos.Name = "crvBancos"
            Me.crvBancos.Size = New System.Drawing.Size(934, 642)
            Me.crvBancos.TabIndex = 0
            Me.crvBancos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FormReporteBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(934, 642)
            Me.Controls.Add(Me.crvBancos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REPORTE DE BANCOS"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents crvBancos As CrystalDecisions.Windows.Forms.CrystalReportViewer
    End Class
End Namespace