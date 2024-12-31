Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteComprobanteCompra
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteComprobanteCompra))
            Me.crvComprobanteCompra = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.reporte1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.reporte2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.PdfViewer1 = New PdfiumViewer.PdfViewer()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.reporte1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.reporte1.SuspendLayout()
            CType(Me.reporte2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.reporte2.SuspendLayout()
            Me.SuspendLayout()
            '
            'crvComprobanteCompra
            '
            Me.crvComprobanteCompra.ActiveViewIndex = -1
            Me.crvComprobanteCompra.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvComprobanteCompra.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvComprobanteCompra.Location = New System.Drawing.Point(0, 0)
            Me.crvComprobanteCompra.Name = "crvComprobanteCompra"
            Me.crvComprobanteCompra.ShowLogo = False
            Me.crvComprobanteCompra.Size = New System.Drawing.Size(790, 644)
            Me.crvComprobanteCompra.TabIndex = 0
            Me.crvComprobanteCompra.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.BackColor = System.Drawing.Color.Transparent
            Me.lblIdComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(505, 9)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblIdComprobanteCompra.TabIndex = 1
            Me.lblIdComprobanteCompra.Text = "0"
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.reporte1, Me.reporte2})
            Me.KryptonNavigator1.SelectedIndex = 0
            Me.KryptonNavigator1.Size = New System.Drawing.Size(792, 671)
            Me.KryptonNavigator1.TabIndex = 2
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'reporte1
            '
            Me.reporte1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.reporte1.Controls.Add(Me.crvComprobanteCompra)
            Me.reporte1.Flags = 65534
            Me.reporte1.LastVisibleSet = True
            Me.reporte1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.reporte1.Name = "reporte1"
            Me.reporte1.Size = New System.Drawing.Size(790, 644)
            Me.reporte1.Text = "Reporte 1"
            Me.reporte1.ToolTipTitle = "Page ToolTip"
            Me.reporte1.UniqueName = "F7990784E53E44CC669371C96A36F93B"
            '
            'reporte2
            '
            Me.reporte2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.reporte2.Controls.Add(Me.PdfViewer1)
            Me.reporte2.Flags = 65534
            Me.reporte2.LastVisibleSet = True
            Me.reporte2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.reporte2.Name = "reporte2"
            Me.reporte2.Size = New System.Drawing.Size(790, 644)
            Me.reporte2.Text = "Reporte 2"
            Me.reporte2.ToolTipTitle = "Page ToolTip"
            Me.reporte2.UniqueName = "07F3F7733153425D7C8171E10751E838"
            '
            'PdfViewer1
            '
            Me.PdfViewer1.Location = New System.Drawing.Point(0, 0)
            Me.PdfViewer1.Name = "PdfViewer1"
            Me.PdfViewer1.Size = New System.Drawing.Size(791, 638)
            Me.PdfViewer1.TabIndex = 0
            '
            'FormReporteComprobanteCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(792, 671)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Controls.Add(Me.lblIdComprobanteCompra)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteComprobanteCompra"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.Text = "REPORTE COMPROBANTE DE COMPRA"
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.reporte1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.reporte1.ResumeLayout(False)
            CType(Me.reporte2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.reporte2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents crvComprobanteCompra As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents reporte1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents reporte2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents PdfViewer1 As PdfiumViewer.PdfViewer
    End Class
End Namespace