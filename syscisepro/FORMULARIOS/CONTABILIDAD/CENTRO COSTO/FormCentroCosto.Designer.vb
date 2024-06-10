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
            Me.lblIdCentroCosto = New System.Windows.Forms.Label()
            Me.lblDetalle = New System.Windows.Forms.Label()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.dgvCentroCosto = New System.Windows.Forms.DataGridView()
            Me.txtIdCentroCosto = New System.Windows.Forms.TextBox()
            Me.txtDetalleCentroCosto = New System.Windows.Forms.TextBox()
            Me.txtCodigoCentroCosto = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscarAsiento = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevoCentroCosto = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarCentroCosto = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarCentroCosto = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporteCentroCosto = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblIdCentroCosto
            '
            Me.lblIdCentroCosto.AutoSize = True
            Me.lblIdCentroCosto.ForeColor = System.Drawing.Color.Black
            Me.lblIdCentroCosto.Location = New System.Drawing.Point(45, 24)
            Me.lblIdCentroCosto.Name = "lblIdCentroCosto"
            Me.lblIdCentroCosto.Size = New System.Drawing.Size(21, 14)
            Me.lblIdCentroCosto.TabIndex = 0
            Me.lblIdCentroCosto.Text = "ID:"
            '
            'lblDetalle
            '
            Me.lblDetalle.AutoSize = True
            Me.lblDetalle.ForeColor = System.Drawing.Color.Black
            Me.lblDetalle.Location = New System.Drawing.Point(10, 52)
            Me.lblDetalle.Name = "lblDetalle"
            Me.lblDetalle.Size = New System.Drawing.Size(59, 14)
            Me.lblDetalle.TabIndex = 1
            Me.lblDetalle.Text = "DETALLE:"
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.ForeColor = System.Drawing.Color.Black
            Me.lblCodigo.Location = New System.Drawing.Point(307, 24)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(53, 14)
            Me.lblCodigo.TabIndex = 2
            Me.lblCodigo.Text = "CODIGO:"
            '
            'dgvCentroCosto
            '
            Me.dgvCentroCosto.AllowUserToAddRows = False
            Me.dgvCentroCosto.AllowUserToDeleteRows = False
            Me.dgvCentroCosto.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCentroCosto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCentroCosto.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvCentroCosto.Location = New System.Drawing.Point(1, 100)
            Me.dgvCentroCosto.MultiSelect = False
            Me.dgvCentroCosto.Name = "dgvCentroCosto"
            Me.dgvCentroCosto.ReadOnly = True
            Me.dgvCentroCosto.RowHeadersVisible = False
            Me.dgvCentroCosto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCentroCosto.Size = New System.Drawing.Size(705, 372)
            Me.dgvCentroCosto.TabIndex = 12
            '
            'txtIdCentroCosto
            '
            Me.txtIdCentroCosto.BackColor = System.Drawing.Color.White
            Me.txtIdCentroCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdCentroCosto.ForeColor = System.Drawing.Color.Black
            Me.txtIdCentroCosto.Location = New System.Drawing.Point(82, 21)
            Me.txtIdCentroCosto.Name = "txtIdCentroCosto"
            Me.txtIdCentroCosto.Size = New System.Drawing.Size(100, 22)
            Me.txtIdCentroCosto.TabIndex = 13
            '
            'txtDetalleCentroCosto
            '
            Me.txtDetalleCentroCosto.BackColor = System.Drawing.Color.White
            Me.txtDetalleCentroCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleCentroCosto.ForeColor = System.Drawing.Color.Black
            Me.txtDetalleCentroCosto.Location = New System.Drawing.Point(82, 49)
            Me.txtDetalleCentroCosto.Name = "txtDetalleCentroCosto"
            Me.txtDetalleCentroCosto.Size = New System.Drawing.Size(613, 22)
            Me.txtDetalleCentroCosto.TabIndex = 14
            '
            'txtCodigoCentroCosto
            '
            Me.txtCodigoCentroCosto.BackColor = System.Drawing.Color.White
            Me.txtCodigoCentroCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCodigoCentroCosto.ForeColor = System.Drawing.Color.Black
            Me.txtCodigoCentroCosto.Location = New System.Drawing.Point(369, 21)
            Me.txtCodigoCentroCosto.Name = "txtCodigoCentroCosto"
            Me.txtCodigoCentroCosto.Size = New System.Drawing.Size(120, 22)
            Me.txtCodigoCentroCosto.TabIndex = 15
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.lblIdCentroCosto)
            Me.GroupBox1.Controls.Add(Me.txtCodigoCentroCosto)
            Me.GroupBox1.Controls.Add(Me.lblDetalle)
            Me.GroupBox1.Controls.Add(Me.txtDetalleCentroCosto)
            Me.GroupBox1.Controls.Add(Me.lblCodigo)
            Me.GroupBox1.Controls.Add(Me.txtIdCentroCosto)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.ForeColor = System.Drawing.Color.Black
            Me.GroupBox1.Location = New System.Drawing.Point(0, 21)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(705, 78)
            Me.GroupBox1.TabIndex = 16
            Me.GroupBox1.TabStop = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarAsiento, Me.btnNuevoCentroCosto, Me.btnGuardarCentroCosto, Me.btnModificarCentroCosto, Me.btnReporteCentroCosto, Me.btnReporte, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(707, 32)
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
            'FormCentroCosto
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(707, 473)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.dgvCentroCosto)
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
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblIdCentroCosto As System.Windows.Forms.Label
        Friend WithEvents lblDetalle As System.Windows.Forms.Label
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents dgvCentroCosto As System.Windows.Forms.DataGridView
        Friend WithEvents txtIdCentroCosto As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalleCentroCosto As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigoCentroCosto As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscarAsiento As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnNuevoCentroCosto As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarCentroCosto As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarCentroCosto As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporteCentroCosto As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace