﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportMayorizacion
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
        Me.crvReporteVentas = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvReporteVentas
        '
        Me.crvReporteVentas.ActiveViewIndex = -1
        Me.crvReporteVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReporteVentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvReporteVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReporteVentas.Location = New System.Drawing.Point(0, 0)
        Me.crvReporteVentas.Name = "crvReporteVentas"
        Me.crvReporteVentas.ShowCloseButton = False
        Me.crvReporteVentas.Size = New System.Drawing.Size(1018, 611)
        Me.crvReporteVentas.TabIndex = 1
        Me.crvReporteVentas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormReportMayorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 611)
        Me.Controls.Add(Me.crvReporteVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormReportMayorizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTE MAYORIZACION"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvReporteVentas As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
