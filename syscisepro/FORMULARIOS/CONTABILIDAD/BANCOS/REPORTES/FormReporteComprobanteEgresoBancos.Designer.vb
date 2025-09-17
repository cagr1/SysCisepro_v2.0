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
            Me.crvChequeEmitido = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.lblIdComprobanteEgreso = New System.Windows.Forms.Label()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.PdfViewer2 = New PdfiumViewer.PdfViewer()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.PdfViewer1 = New PdfiumViewer.PdfViewer()
            Me.KryptonPage3 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.crvMachala = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.txtIdComprobanteEgreso = New System.Windows.Forms.TextBox()
            Me.txtIdComprobamteEgreso2 = New System.Windows.Forms.TextBox()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage3.SuspendLayout()
            Me.SuspendLayout()
            '
            'crvComprovanteEgresoBancos
            '
            Me.crvComprovanteEgresoBancos.ActiveViewIndex = -1
            Me.crvComprovanteEgresoBancos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvComprovanteEgresoBancos.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvComprovanteEgresoBancos.Location = New System.Drawing.Point(149, 44)
            Me.crvComprovanteEgresoBancos.Name = "crvComprovanteEgresoBancos"
            Me.crvComprovanteEgresoBancos.ShowCloseButton = False
            Me.crvComprovanteEgresoBancos.ShowLogo = False
            Me.crvComprovanteEgresoBancos.Size = New System.Drawing.Size(530, 390)
            Me.crvComprovanteEgresoBancos.TabIndex = 0
            Me.crvComprovanteEgresoBancos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'crvChequeEmitido
            '
            Me.crvChequeEmitido.ActiveViewIndex = -1
            Me.crvChequeEmitido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvChequeEmitido.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvChequeEmitido.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvChequeEmitido.Location = New System.Drawing.Point(0, 0)
            Me.crvChequeEmitido.Name = "crvChequeEmitido"
            Me.crvChequeEmitido.ShowCloseButton = False
            Me.crvChequeEmitido.ShowLogo = False
            Me.crvChequeEmitido.Size = New System.Drawing.Size(880, 635)
            Me.crvChequeEmitido.TabIndex = 0
            Me.crvChequeEmitido.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'lblIdComprobanteEgreso
            '
            Me.lblIdComprobanteEgreso.AutoSize = True
            Me.lblIdComprobanteEgreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteEgreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteEgreso.Location = New System.Drawing.Point(519, 8)
            Me.lblIdComprobanteEgreso.Name = "lblIdComprobanteEgreso"
            Me.lblIdComprobanteEgreso.Size = New System.Drawing.Size(25, 13)
            Me.lblIdComprobanteEgreso.TabIndex = 7
            Me.lblIdComprobanteEgreso.Text = "000"
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2, Me.KryptonPage3})
            Me.KryptonNavigator1.SelectedIndex = 0
            Me.KryptonNavigator1.Size = New System.Drawing.Size(882, 662)
            Me.KryptonNavigator1.TabIndex = 8
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.PdfViewer2)
            Me.KryptonPage1.Controls.Add(Me.crvComprovanteEgresoBancos)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(880, 635)
            Me.KryptonPage1.Text = "Comprobante"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "7FDBF879EAA34B832D9FF6244D0AE350"
            '
            'PdfViewer2
            '
            Me.PdfViewer2.Location = New System.Drawing.Point(3, 3)
            Me.PdfViewer2.Name = "PdfViewer2"
            Me.PdfViewer2.Size = New System.Drawing.Size(874, 629)
            Me.PdfViewer2.TabIndex = 1
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.crvChequeEmitido)
            Me.KryptonPage2.Controls.Add(Me.PdfViewer1)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(880, 635)
            Me.KryptonPage2.Text = "Cheque"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "3F85382D9C5245BD0FA2CEAB7EB39E6A"
            '
            'PdfViewer1
            '
            Me.PdfViewer1.Location = New System.Drawing.Point(2, 182)
            Me.PdfViewer1.Name = "PdfViewer1"
            Me.PdfViewer1.Size = New System.Drawing.Size(876, 442)
            Me.PdfViewer1.TabIndex = 1
            '
            'KryptonPage3
            '
            Me.KryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage3.Controls.Add(Me.crvMachala)
            Me.KryptonPage3.Flags = 65534
            Me.KryptonPage3.LastVisibleSet = True
            Me.KryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage3.Name = "KryptonPage3"
            Me.KryptonPage3.Size = New System.Drawing.Size(880, 635)
            Me.KryptonPage3.Text = "Comp Machala"
            Me.KryptonPage3.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage3.UniqueName = "C7D4C634119240D3BFB221348CF70ABC"
            '
            'crvMachala
            '
            Me.crvMachala.ActiveViewIndex = -1
            Me.crvMachala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvMachala.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvMachala.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvMachala.Location = New System.Drawing.Point(0, 0)
            Me.crvMachala.Name = "crvMachala"
            Me.crvMachala.ShowCloseButton = False
            Me.crvMachala.ShowLogo = False
            Me.crvMachala.Size = New System.Drawing.Size(880, 635)
            Me.crvMachala.TabIndex = 0
            Me.crvMachala.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'txtIdComprobanteEgreso
            '
            Me.txtIdComprobanteEgreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtIdComprobanteEgreso.Location = New System.Drawing.Point(745, 145)
            Me.txtIdComprobanteEgreso.Multiline = True
            Me.txtIdComprobanteEgreso.Name = "txtIdComprobanteEgreso"
            Me.txtIdComprobanteEgreso.Size = New System.Drawing.Size(100, 23)
            Me.txtIdComprobanteEgreso.TabIndex = 2
            Me.txtIdComprobanteEgreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIdComprobamteEgreso2
            '
            Me.txtIdComprobamteEgreso2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtIdComprobamteEgreso2.Location = New System.Drawing.Point(755, 208)
            Me.txtIdComprobamteEgreso2.Multiline = True
            Me.txtIdComprobamteEgreso2.Name = "txtIdComprobamteEgreso2"
            Me.txtIdComprobamteEgreso2.Size = New System.Drawing.Size(100, 23)
            Me.txtIdComprobamteEgreso2.TabIndex = 3
            Me.txtIdComprobamteEgreso2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'FormReporteComprobanteEgresoBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(882, 662)
            Me.Controls.Add(Me.lblIdComprobanteEgreso)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Controls.Add(Me.txtIdComprobanteEgreso)
            Me.Controls.Add(Me.txtIdComprobamteEgreso2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteComprobanteEgresoBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REPORTE COMPROBANTE EGRESO BANCOS"
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage3.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvComprovanteEgresoBancos As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents crvChequeEmitido As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents lblIdComprobanteEgreso As System.Windows.Forms.Label
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage3 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents txtIdComprobanteEgreso As TextBox
        Friend WithEvents txtIdComprobamteEgreso2 As TextBox
        Friend WithEvents crvMachala As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents PdfViewer1 As PdfiumViewer.PdfViewer
        Friend WithEvents PdfViewer2 As PdfiumViewer.PdfViewer
    End Class
End Namespace