Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteSolicitudFondoRotativo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteSolicitudFondoRotativo))
            Me.crvSolicitudFondoRotativo = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.btnVolver = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'crvSolicitudFondoRotativo
            '
            Me.crvSolicitudFondoRotativo.ActiveViewIndex = -1
            Me.crvSolicitudFondoRotativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvSolicitudFondoRotativo.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvSolicitudFondoRotativo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvSolicitudFondoRotativo.Location = New System.Drawing.Point(0, 0)
            Me.crvSolicitudFondoRotativo.Name = "crvSolicitudFondoRotativo"
            Me.crvSolicitudFondoRotativo.Size = New System.Drawing.Size(982, 655)
            Me.crvSolicitudFondoRotativo.TabIndex = 0
            Me.crvSolicitudFondoRotativo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'btnVolver
            '
            Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnVolver.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnVolver.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnVolver.Location = New System.Drawing.Point(821, 2)
            Me.btnVolver.Name = "btnVolver"
            Me.btnVolver.Size = New System.Drawing.Size(159, 24)
            Me.btnVolver.TabIndex = 3
            Me.btnVolver.Text = "CARGAR DATOS"
            Me.btnVolver.UseVisualStyleBackColor = True
            '
            'FormReporteSolicitudFondoRotativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(982, 655)
            Me.Controls.Add(Me.btnVolver)
            Me.Controls.Add(Me.crvSolicitudFondoRotativo)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteSolicitudFondoRotativo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REPORTE SOLICITUD DE FONDO ROTATIVO"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents crvSolicitudFondoRotativo As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents btnVolver As System.Windows.Forms.Button
    End Class
End Namespace