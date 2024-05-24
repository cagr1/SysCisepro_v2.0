Namespace FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteComprobanteIngresoBancos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteComprobanteIngresoBancos))
            Me.crvComprobanteIngresoBancos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.lblIdComprobanteIngreso = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'crvComprobanteIngresoBancos
            '
            Me.crvComprobanteIngresoBancos.ActiveViewIndex = -1
            Me.crvComprobanteIngresoBancos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvComprobanteIngresoBancos.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvComprobanteIngresoBancos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvComprobanteIngresoBancos.Location = New System.Drawing.Point(0, 0)
            Me.crvComprobanteIngresoBancos.Name = "crvComprobanteIngresoBancos"
            Me.crvComprobanteIngresoBancos.Size = New System.Drawing.Size(730, 666)
            Me.crvComprobanteIngresoBancos.TabIndex = 0
            Me.crvComprobanteIngresoBancos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'lblIdComprobanteIngreso
            '
            Me.lblIdComprobanteIngreso.AutoSize = True
            Me.lblIdComprobanteIngreso.Location = New System.Drawing.Point(506, 9)
            Me.lblIdComprobanteIngreso.Name = "lblIdComprobanteIngreso"
            Me.lblIdComprobanteIngreso.Size = New System.Drawing.Size(13, 13)
            Me.lblIdComprobanteIngreso.TabIndex = 1
            Me.lblIdComprobanteIngreso.Text = "0"
            '
            'FormReporteComprobanteIngresoBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(730, 666)
            Me.Controls.Add(Me.lblIdComprobanteIngreso)
            Me.Controls.Add(Me.crvComprobanteIngresoBancos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteComprobanteIngresoBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REPORTE COMPROBANTE INGRESO BANCOS"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvComprobanteIngresoBancos As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents lblIdComprobanteIngreso As System.Windows.Forms.Label
    End Class
End Namespace