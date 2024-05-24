Namespace FORMULARIOS.CONJUNTO_DE_DATOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmVisualizadorReportes
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVisualizadorReportes))
            Me.crystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.SuspendLayout()
            '
            'crystalReportViewer1
            '
            Me.crystalReportViewer1.ActiveViewIndex = -1
            Me.crystalReportViewer1.AutoSize = True
            Me.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
            Me.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crystalReportViewer1.Location = New System.Drawing.Point(0, 0)
            Me.crystalReportViewer1.Name = "crystalReportViewer1"
            Me.crystalReportViewer1.ShowCloseButton = False
            Me.crystalReportViewer1.ShowGroupTreeButton = False
            Me.crystalReportViewer1.ShowParameterPanelButton = False
            Me.crystalReportViewer1.ShowRefreshButton = False
            Me.crystalReportViewer1.ShowTextSearchButton = False
            Me.crystalReportViewer1.Size = New System.Drawing.Size(1074, 616)
            Me.crystalReportViewer1.TabIndex = 1
            Me.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FrmVisualizadorReportes
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1074, 616)
            Me.Controls.Add(Me.crystalReportViewer1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmVisualizadorReportes"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "VISUALIZADOR DE REPORTES"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Public WithEvents crystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    End Class
End Namespace