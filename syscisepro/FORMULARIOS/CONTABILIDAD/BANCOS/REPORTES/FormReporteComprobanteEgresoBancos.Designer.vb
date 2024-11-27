Namespace FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteComprobanteEgresoBancos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteComprobanteEgresoBancos))
            Me.crvComprovanteEgresoBancos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.tcReporteEgresoBancos = New System.Windows.Forms.TabControl()
            Me.tpComprobanteEgresoBancos = New System.Windows.Forms.TabPage()
            Me.txtIdComprobanteEgreso = New System.Windows.Forms.TextBox()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.txtIdComprobamteEgreso2 = New System.Windows.Forms.TextBox()
            Me.crvChequeEmitido = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.lblIdComprobanteEgreso = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.tcReporteEgresoBancos.SuspendLayout()
            Me.tpComprobanteEgresoBancos.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'crvComprovanteEgresoBancos
            '
            Me.crvComprovanteEgresoBancos.ActiveViewIndex = -1
            Me.crvComprovanteEgresoBancos.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvComprovanteEgresoBancos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvComprovanteEgresoBancos.Location = New System.Drawing.Point(3, 3)
            Me.crvComprovanteEgresoBancos.Name = "crvComprovanteEgresoBancos"
            Me.crvComprovanteEgresoBancos.ShowLogo = False
            Me.crvComprovanteEgresoBancos.Size = New System.Drawing.Size(868, 632)
            Me.crvComprovanteEgresoBancos.TabIndex = 0
            Me.crvComprovanteEgresoBancos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'tcReporteEgresoBancos
            '
            Me.tcReporteEgresoBancos.Controls.Add(Me.tpComprobanteEgresoBancos)
            Me.tcReporteEgresoBancos.Controls.Add(Me.TabPage2)
            Me.tcReporteEgresoBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcReporteEgresoBancos.Location = New System.Drawing.Point(1, 2)
            Me.tcReporteEgresoBancos.Name = "tcReporteEgresoBancos"
            Me.tcReporteEgresoBancos.SelectedIndex = 0
            Me.tcReporteEgresoBancos.Size = New System.Drawing.Size(882, 664)
            Me.tcReporteEgresoBancos.TabIndex = 4
            '
            'tpComprobanteEgresoBancos
            '
            Me.tpComprobanteEgresoBancos.Controls.Add(Me.txtIdComprobanteEgreso)
            Me.tpComprobanteEgresoBancos.Controls.Add(Me.crvComprovanteEgresoBancos)
            Me.tpComprobanteEgresoBancos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.tpComprobanteEgresoBancos.Location = New System.Drawing.Point(4, 22)
            Me.tpComprobanteEgresoBancos.Name = "tpComprobanteEgresoBancos"
            Me.tpComprobanteEgresoBancos.Padding = New System.Windows.Forms.Padding(3)
            Me.tpComprobanteEgresoBancos.Size = New System.Drawing.Size(874, 638)
            Me.tpComprobanteEgresoBancos.TabIndex = 0
            Me.tpComprobanteEgresoBancos.Text = "COMPROBANTE DE EGRESO"
            Me.tpComprobanteEgresoBancos.UseVisualStyleBackColor = True
            '
            'txtIdComprobanteEgreso
            '
            Me.txtIdComprobanteEgreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtIdComprobanteEgreso.Location = New System.Drawing.Point(618, 6)
            Me.txtIdComprobanteEgreso.Multiline = True
            Me.txtIdComprobanteEgreso.Name = "txtIdComprobanteEgreso"
            Me.txtIdComprobanteEgreso.Size = New System.Drawing.Size(100, 23)
            Me.txtIdComprobanteEgreso.TabIndex = 2
            Me.txtIdComprobanteEgreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.txtIdComprobamteEgreso2)
            Me.TabPage2.Controls.Add(Me.crvChequeEmitido)
            Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(874, 638)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "CHEQUE"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'txtIdComprobamteEgreso2
            '
            Me.txtIdComprobamteEgreso2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtIdComprobamteEgreso2.Location = New System.Drawing.Point(618, 6)
            Me.txtIdComprobamteEgreso2.Multiline = True
            Me.txtIdComprobamteEgreso2.Name = "txtIdComprobamteEgreso2"
            Me.txtIdComprobamteEgreso2.Size = New System.Drawing.Size(100, 23)
            Me.txtIdComprobamteEgreso2.TabIndex = 3
            Me.txtIdComprobamteEgreso2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'crvChequeEmitido
            '
            Me.crvChequeEmitido.ActiveViewIndex = -1
            Me.crvChequeEmitido.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvChequeEmitido.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvChequeEmitido.Location = New System.Drawing.Point(3, 3)
            Me.crvChequeEmitido.Name = "crvChequeEmitido"
            Me.crvChequeEmitido.ShowLogo = False
            Me.crvChequeEmitido.Size = New System.Drawing.Size(868, 632)
            Me.crvChequeEmitido.TabIndex = 0
            Me.crvChequeEmitido.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'lblIdComprobanteEgreso
            '
            Me.lblIdComprobanteEgreso.AutoSize = True
            Me.lblIdComprobanteEgreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteEgreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteEgreso.Location = New System.Drawing.Point(422, 4)
            Me.lblIdComprobanteEgreso.Name = "lblIdComprobanteEgreso"
            Me.lblIdComprobanteEgreso.Size = New System.Drawing.Size(25, 13)
            Me.lblIdComprobanteEgreso.TabIndex = 7
            Me.lblIdComprobanteEgreso.Text = "000"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(454, 4)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(12, 13)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "/"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(402, 4)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(12, 13)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "/"
            '
            'FormReporteComprobanteEgresoBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(882, 662)
            Me.Controls.Add(Me.lblIdComprobanteEgreso)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.tcReporteEgresoBancos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteComprobanteEgresoBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REPORTE COMPROBANTE EGRESO BANCOS"
            Me.tcReporteEgresoBancos.ResumeLayout(False)
            Me.tpComprobanteEgresoBancos.ResumeLayout(False)
            Me.tpComprobanteEgresoBancos.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvComprovanteEgresoBancos As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents tcReporteEgresoBancos As System.Windows.Forms.TabControl
        Friend WithEvents tpComprobanteEgresoBancos As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents crvChequeEmitido As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents lblIdComprobanteEgreso As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtIdComprobanteEgreso As System.Windows.Forms.TextBox
        Friend WithEvents txtIdComprobamteEgreso2 As System.Windows.Forms.TextBox
    End Class
End Namespace