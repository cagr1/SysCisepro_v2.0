Namespace FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteComprobanteEgresoBancoMachala
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteComprobanteEgresoBancoMachala))
            Me.crvComprobanteEgresoBancoMachala = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.lblIdComprobanteEgreso = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtIdComprobanteEgreso = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            'crvComprobanteEgresoBancoMachala
            '
            Me.crvComprobanteEgresoBancoMachala.ActiveViewIndex = -1
            Me.crvComprobanteEgresoBancoMachala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvComprobanteEgresoBancoMachala.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvComprobanteEgresoBancoMachala.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvComprobanteEgresoBancoMachala.Location = New System.Drawing.Point(0, 0)
            Me.crvComprobanteEgresoBancoMachala.Name = "crvComprobanteEgresoBancoMachala"
            Me.crvComprobanteEgresoBancoMachala.ShowLogo = False
            Me.crvComprobanteEgresoBancoMachala.Size = New System.Drawing.Size(1194, 675)
            Me.crvComprobanteEgresoBancoMachala.TabIndex = 0
            Me.crvComprobanteEgresoBancoMachala.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'lblIdComprobanteEgreso
            '
            Me.lblIdComprobanteEgreso.AutoSize = True
            Me.lblIdComprobanteEgreso.Location = New System.Drawing.Point(613, 9)
            Me.lblIdComprobanteEgreso.Name = "lblIdComprobanteEgreso"
            Me.lblIdComprobanteEgreso.Size = New System.Drawing.Size(25, 13)
            Me.lblIdComprobanteEgreso.TabIndex = 10
            Me.lblIdComprobanteEgreso.Text = "000"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(645, 9)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(12, 13)
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "/"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(593, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(12, 13)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "/"
            '
            'txtIdComprobanteEgreso
            '
            Me.txtIdComprobanteEgreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtIdComprobanteEgreso.Location = New System.Drawing.Point(490, 3)
            Me.txtIdComprobanteEgreso.Multiline = True
            Me.txtIdComprobanteEgreso.Name = "txtIdComprobanteEgreso"
            Me.txtIdComprobanteEgreso.Size = New System.Drawing.Size(100, 23)
            Me.txtIdComprobanteEgreso.TabIndex = 11
            Me.txtIdComprobanteEgreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'FormReporteComprobanteEgresoBancoMachala
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1194, 675)
            Me.Controls.Add(Me.txtIdComprobanteEgreso)
            Me.Controls.Add(Me.lblIdComprobanteEgreso)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.crvComprobanteEgresoBancoMachala)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.ImeMode = System.Windows.Forms.ImeMode.[On]
            Me.Name = "FormReporteComprobanteEgresoBancoMachala"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "COMPROBANTE EGRESO BANCO MACHALA"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvComprobanteEgresoBancoMachala As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents lblIdComprobanteEgreso As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtIdComprobanteEgreso As System.Windows.Forms.TextBox
    End Class
End Namespace