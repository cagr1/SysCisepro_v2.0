Namespace FORMULARIOS.CONTABILIDAD.CENTRO_COSTO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormCentroCosto
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCentroCosto))
            Me.dgvCentroCosto = New System.Windows.Forms.DataGridView()
            Me.txtIdCentroCosto = New System.Windows.Forms.TextBox()
            Me.txtDetalleCentroCosto = New System.Windows.Forms.TextBox()
            Me.txtCodigoCentroCosto = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscarAsiento = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevoCentroCosto = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarCentroCosto = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarCentroCosto = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporteCentroCosto = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvCentroCosto
            '
            Me.dgvCentroCosto.AllowUserToAddRows = False
            Me.dgvCentroCosto.AllowUserToDeleteRows = False
            Me.dgvCentroCosto.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCentroCosto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCentroCosto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.dgvCentroCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvCentroCosto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvCentroCosto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCentroCosto.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvCentroCosto.Location = New System.Drawing.Point(9, 56)
            Me.dgvCentroCosto.MultiSelect = False
            Me.dgvCentroCosto.Name = "dgvCentroCosto"
            Me.dgvCentroCosto.ReadOnly = True
            Me.dgvCentroCosto.RowHeadersVisible = False
            Me.dgvCentroCosto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCentroCosto.Size = New System.Drawing.Size(567, 354)
            Me.dgvCentroCosto.TabIndex = 12
            '
            'txtIdCentroCosto
            '
            Me.txtIdCentroCosto.BackColor = System.Drawing.Color.White
            Me.txtIdCentroCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdCentroCosto.ForeColor = System.Drawing.Color.Black
            Me.txtIdCentroCosto.Location = New System.Drawing.Point(68, 4)
            Me.txtIdCentroCosto.Name = "txtIdCentroCosto"
            Me.txtIdCentroCosto.Size = New System.Drawing.Size(100, 21)
            Me.txtIdCentroCosto.TabIndex = 13
            '
            'txtDetalleCentroCosto
            '
            Me.txtDetalleCentroCosto.BackColor = System.Drawing.Color.White
            Me.txtDetalleCentroCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalleCentroCosto.ForeColor = System.Drawing.Color.Black
            Me.txtDetalleCentroCosto.Location = New System.Drawing.Point(68, 30)
            Me.txtDetalleCentroCosto.Name = "txtDetalleCentroCosto"
            Me.txtDetalleCentroCosto.Size = New System.Drawing.Size(481, 21)
            Me.txtDetalleCentroCosto.TabIndex = 14
            '
            'txtCodigoCentroCosto
            '
            Me.txtCodigoCentroCosto.BackColor = System.Drawing.Color.White
            Me.txtCodigoCentroCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCodigoCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoCentroCosto.ForeColor = System.Drawing.Color.Black
            Me.txtCodigoCentroCosto.Location = New System.Drawing.Point(285, 2)
            Me.txtCodigoCentroCosto.Name = "txtCodigoCentroCosto"
            Me.txtCodigoCentroCosto.Size = New System.Drawing.Size(120, 21)
            Me.txtCodigoCentroCosto.TabIndex = 15
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarAsiento, Me.btnNuevoCentroCosto, Me.btnGuardarCentroCosto, Me.btnModificarCentroCosto, Me.btnReporteCentroCosto, Me.btnReporte, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(589, 32)
            Me.MenuStrip1.TabIndex = 210
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscarAsiento
            '
            Me.btnBuscarAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarAsiento.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarAsiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscarAsiento.Name = "btnBuscarAsiento"
            Me.btnBuscarAsiento.Size = New System.Drawing.Size(85, 28)
            Me.btnBuscarAsiento.Text = "BUSCAR"
            '
            'btnNuevoCentroCosto
            '
            Me.btnNuevoCentroCosto.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoCentroCosto.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoCentroCosto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoCentroCosto.Name = "btnNuevoCentroCosto"
            Me.btnNuevoCentroCosto.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevoCentroCosto.Text = "NUEVO"
            '
            'btnGuardarCentroCosto
            '
            Me.btnGuardarCentroCosto.Enabled = False
            Me.btnGuardarCentroCosto.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarCentroCosto.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarCentroCosto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarCentroCosto.Name = "btnGuardarCentroCosto"
            Me.btnGuardarCentroCosto.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardarCentroCosto.Text = "GUARDAR"
            '
            'btnModificarCentroCosto
            '
            Me.btnModificarCentroCosto.Enabled = False
            Me.btnModificarCentroCosto.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificarCentroCosto.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificarCentroCosto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificarCentroCosto.Name = "btnModificarCentroCosto"
            Me.btnModificarCentroCosto.Size = New System.Drawing.Size(113, 28)
            Me.btnModificarCentroCosto.Text = "ACTUALIZAR"
            '
            'btnReporteCentroCosto
            '
            Me.btnReporteCentroCosto.Enabled = False
            Me.btnReporteCentroCosto.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporteCentroCosto.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnReporteCentroCosto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporteCentroCosto.Name = "btnReporteCentroCosto"
            Me.btnReporteCentroCosto.Size = New System.Drawing.Size(99, 28)
            Me.btnReporteCentroCosto.Text = "CANCELAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(92, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(91, 20)
            Me.btnExportar.Text = "EXPORTAR"
            Me.btnExportar.Visible = False
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCodigoCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dgvCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDetalleCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdCentroCosto)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(588, 437)
            Me.KryptonGroupBox1.TabIndex = 211
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(9, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Id"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(9, 30)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel2.TabIndex = 1
            Me.KryptonLabel2.Values.Text = "Detalle"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(217, 4)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel3.TabIndex = 2
            Me.KryptonLabel3.Values.Text = "Codigo"
            '
            'FormCentroCosto
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(589, 473)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormCentroCosto"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "DEFINICION DE CENTROS DE COSTO"
            CType(Me.dgvCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvCentroCosto As System.Windows.Forms.DataGridView
        Friend WithEvents txtIdCentroCosto As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalleCentroCosto As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigoCentroCosto As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscarAsiento As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnNuevoCentroCosto As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarCentroCosto As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarCentroCosto As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporteCentroCosto As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    End Class
End Namespace