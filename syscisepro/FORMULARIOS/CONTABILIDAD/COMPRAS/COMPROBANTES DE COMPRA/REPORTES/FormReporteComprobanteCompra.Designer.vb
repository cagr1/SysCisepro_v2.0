Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteComprobanteCompra
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteComprobanteCompra))
            Me.crvComprobanteCompra = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'crvComprobanteCompra
            '
            Me.crvComprobanteCompra.ActiveViewIndex = -1
            Me.crvComprobanteCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvComprobanteCompra.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvComprobanteCompra.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvComprobanteCompra.Location = New System.Drawing.Point(0, 0)
            Me.crvComprobanteCompra.Name = "crvComprobanteCompra"
            Me.crvComprobanteCompra.Size = New System.Drawing.Size(792, 671)
            Me.crvComprobanteCompra.TabIndex = 0
            Me.crvComprobanteCompra.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.BackColor = System.Drawing.Color.Transparent
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(505, 9)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblIdComprobanteCompra.TabIndex = 1
            Me.lblIdComprobanteCompra.Text = "0"
            '
            'FormReporteComprobanteCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(792, 671)
            Me.Controls.Add(Me.lblIdComprobanteCompra)
            Me.Controls.Add(Me.crvComprobanteCompra)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteComprobanteCompra"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REPORTE COMPROBANTE DE COMPRA"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvComprobanteCompra As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
    End Class
End Namespace