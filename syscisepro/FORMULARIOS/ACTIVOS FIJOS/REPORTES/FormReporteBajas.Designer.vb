Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteBajas
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteBajas))
            Me.crvBajas = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.lblIdBaja = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'crvBajas
            '
            Me.crvBajas.ActiveViewIndex = -1
            Me.crvBajas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvBajas.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvBajas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvBajas.Location = New System.Drawing.Point(0, 0)
            Me.crvBajas.Name = "crvBajas"
            Me.crvBajas.Size = New System.Drawing.Size(1008, 730)
            Me.crvBajas.TabIndex = 0
            Me.crvBajas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'lblIdBaja
            '
            Me.lblIdBaja.AutoSize = True
            Me.lblIdBaja.Location = New System.Drawing.Point(480, 9)
            Me.lblIdBaja.Name = "lblIdBaja"
            Me.lblIdBaja.Size = New System.Drawing.Size(13, 13)
            Me.lblIdBaja.TabIndex = 1
            Me.lblIdBaja.Text = "0"
            '
            'FormReporteBajas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1008, 730)
            Me.Controls.Add(Me.lblIdBaja)
            Me.Controls.Add(Me.crvBajas)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormReporteBajas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BAJAS DE ACTIVOS FIJOS"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvBajas As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents lblIdBaja As System.Windows.Forms.Label
    End Class
End Namespace