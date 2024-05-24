Namespace FORMULARIOS.CONTABILIDAD.SRI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporte
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
            Me.components = New System.ComponentModel.Container()
            Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporte))
            Me.ClassATSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ReportViewerATS = New Microsoft.Reporting.WinForms.ReportViewer()
            CType(Me.ClassATSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ClassATSBindingSource
            '
            Me.ClassATSBindingSource.DataMember = "ClassATS"
            '
            'ReportViewerATS
            '
            Me.ReportViewerATS.Dock = System.Windows.Forms.DockStyle.Fill
            ReportDataSource1.Name = "ATS"
            ReportDataSource1.Value = Me.ClassATSBindingSource
            Me.ReportViewerATS.LocalReport.DataSources.Add(ReportDataSource1)
            Me.ReportViewerATS.LocalReport.ReportEmbeddedResource = "syscisepro.Report1.rdlc"
            Me.ReportViewerATS.Location = New System.Drawing.Point(0, 0)
            Me.ReportViewerATS.Name = "ReportViewerATS"
            Me.ReportViewerATS.Size = New System.Drawing.Size(972, 593)
            Me.ReportViewerATS.TabIndex = 0
            Me.ReportViewerATS.ZoomPercent = 75
            '
            'FormReporte
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(972, 593)
            Me.Controls.Add(Me.ReportViewerATS)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporte"
            Me.Text = "FormReporte"
            CType(Me.ClassATSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ReportViewerATS As Microsoft.Reporting.WinForms.ReportViewer
        Friend WithEvents ClassATSBindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace