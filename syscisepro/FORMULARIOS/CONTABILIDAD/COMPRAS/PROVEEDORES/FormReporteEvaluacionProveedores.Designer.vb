Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteEvaluacionProveedores
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteEvaluacionProveedores))
            Me.crvEvaluacionProveedor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblIdEvaluacionProveedor = New System.Windows.Forms.Label()
            Me.lblTipoProveedor = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'crvEvaluacionProveedor
            '
            Me.crvEvaluacionProveedor.ActiveViewIndex = -1
            Me.crvEvaluacionProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvEvaluacionProveedor.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvEvaluacionProveedor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvEvaluacionProveedor.Location = New System.Drawing.Point(0, 0)
            Me.crvEvaluacionProveedor.Name = "crvEvaluacionProveedor"
            Me.crvEvaluacionProveedor.Size = New System.Drawing.Size(726, 650)
            Me.crvEvaluacionProveedor.TabIndex = 1
            Me.crvEvaluacionProveedor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(477, 9)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(12, 13)
            Me.Label2.TabIndex = 10
            Me.Label2.Text = "/"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(518, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(12, 13)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "/"
            '
            'lblIdEvaluacionProveedor
            '
            Me.lblIdEvaluacionProveedor.AutoSize = True
            Me.lblIdEvaluacionProveedor.Location = New System.Drawing.Point(491, 9)
            Me.lblIdEvaluacionProveedor.Name = "lblIdEvaluacionProveedor"
            Me.lblIdEvaluacionProveedor.Size = New System.Drawing.Size(25, 13)
            Me.lblIdEvaluacionProveedor.TabIndex = 8
            Me.lblIdEvaluacionProveedor.Text = "000"
            '
            'lblTipoProveedor
            '
            Me.lblTipoProveedor.AutoSize = True
            Me.lblTipoProveedor.Location = New System.Drawing.Point(536, 9)
            Me.lblTipoProveedor.Name = "lblTipoProveedor"
            Me.lblTipoProveedor.Size = New System.Drawing.Size(16, 13)
            Me.lblTipoProveedor.TabIndex = 11
            Me.lblTipoProveedor.Text = "..."
            '
            'FormReporteEvaluacionProveedores
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(726, 650)
            Me.Controls.Add(Me.lblTipoProveedor)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblIdEvaluacionProveedor)
            Me.Controls.Add(Me.crvEvaluacionProveedor)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteEvaluacionProveedores"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REPORTE EVALUACION DE PROVEEDOR"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvEvaluacionProveedor As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblIdEvaluacionProveedor As System.Windows.Forms.Label
        Friend WithEvents lblTipoProveedor As System.Windows.Forms.Label
    End Class
End Namespace