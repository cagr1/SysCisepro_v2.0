Namespace FORMULARIOS.CONTABILIDAD.BALANCE
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmReporteBalanceFinal
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteBalanceFinal))
            Me.crvPlanDeCuentas = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.SuspendLayout()
            '
            'crvPlanDeCuentas
            '
            Me.crvPlanDeCuentas.ActiveViewIndex = -1
            Me.crvPlanDeCuentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvPlanDeCuentas.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvPlanDeCuentas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvPlanDeCuentas.Location = New System.Drawing.Point(0, 0)
            Me.crvPlanDeCuentas.Name = "crvPlanDeCuentas"
            Me.crvPlanDeCuentas.Size = New System.Drawing.Size(1012, 734)
            Me.crvPlanDeCuentas.TabIndex = 2
            Me.crvPlanDeCuentas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FrmReporteBalanceFinal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1012, 734)
            Me.Controls.Add(Me.crvPlanDeCuentas)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmReporteBalanceFinal"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REPORTE BALANCE FINAL"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents crvPlanDeCuentas As CrystalDecisions.Windows.Forms.CrystalReportViewer
    End Class
End Namespace