Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormGastosFondoRotativo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGastosFondoRotativo))
            Me.txtIdGastosFR = New System.Windows.Forms.TextBox()
            Me.txtNombreGastoFR = New System.Windows.Forms.TextBox()
            Me.txtCtaContableGastoFR = New System.Windows.Forms.TextBox()
            Me.dgvGastosFondoRotativo = New System.Windows.Forms.DataGridView()
            Me.txtCtaContableActividad = New System.Windows.Forms.TextBox()
            Me.txtDetalleActividad = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoGastosFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarGastosFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarGastosFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvGastosFondoRotativo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtIdGastosFR
            '
            Me.txtIdGastosFR.BackColor = System.Drawing.Color.White
            Me.txtIdGastosFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdGastosFR.Location = New System.Drawing.Point(300, 3)
            Me.txtIdGastosFR.Name = "txtIdGastosFR"
            Me.txtIdGastosFR.Size = New System.Drawing.Size(71, 22)
            Me.txtIdGastosFR.TabIndex = 13
            '
            'txtNombreGastoFR
            '
            Me.txtNombreGastoFR.BackColor = System.Drawing.Color.White
            Me.txtNombreGastoFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreGastoFR.Location = New System.Drawing.Point(300, 27)
            Me.txtNombreGastoFR.Name = "txtNombreGastoFR"
            Me.txtNombreGastoFR.Size = New System.Drawing.Size(175, 22)
            Me.txtNombreGastoFR.TabIndex = 14
            '
            'txtCtaContableGastoFR
            '
            Me.txtCtaContableGastoFR.BackColor = System.Drawing.Color.White
            Me.txtCtaContableGastoFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCtaContableGastoFR.Location = New System.Drawing.Point(481, 5)
            Me.txtCtaContableGastoFR.Name = "txtCtaContableGastoFR"
            Me.txtCtaContableGastoFR.Size = New System.Drawing.Size(95, 22)
            Me.txtCtaContableGastoFR.TabIndex = 15
            '
            'dgvGastosFondoRotativo
            '
            Me.dgvGastosFondoRotativo.AllowUserToAddRows = False
            Me.dgvGastosFondoRotativo.AllowUserToDeleteRows = False
            Me.dgvGastosFondoRotativo.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvGastosFondoRotativo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvGastosFondoRotativo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvGastosFondoRotativo.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvGastosFondoRotativo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvGastosFondoRotativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvGastosFondoRotativo.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvGastosFondoRotativo.Location = New System.Drawing.Point(3, 120)
            Me.dgvGastosFondoRotativo.MultiSelect = False
            Me.dgvGastosFondoRotativo.Name = "dgvGastosFondoRotativo"
            Me.dgvGastosFondoRotativo.RowHeadersVisible = False
            Me.dgvGastosFondoRotativo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvGastosFondoRotativo.Size = New System.Drawing.Size(591, 304)
            Me.dgvGastosFondoRotativo.TabIndex = 16
            '
            'txtCtaContableActividad
            '
            Me.txtCtaContableActividad.BackColor = System.Drawing.Color.White
            Me.txtCtaContableActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCtaContableActividad.Enabled = False
            Me.txtCtaContableActividad.Location = New System.Drawing.Point(84, 27)
            Me.txtCtaContableActividad.Name = "txtCtaContableActividad"
            Me.txtCtaContableActividad.Size = New System.Drawing.Size(122, 22)
            Me.txtCtaContableActividad.TabIndex = 3
            Me.txtCtaContableActividad.Text = "1.1.1.2"
            Me.txtCtaContableActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtDetalleActividad
            '
            Me.txtDetalleActividad.BackColor = System.Drawing.Color.White
            Me.txtDetalleActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleActividad.Enabled = False
            Me.txtDetalleActividad.Location = New System.Drawing.Point(84, 3)
            Me.txtDetalleActividad.Name = "txtDetalleActividad"
            Me.txtDetalleActividad.Size = New System.Drawing.Size(122, 22)
            Me.txtDetalleActividad.TabIndex = 1
            Me.txtDetalleActividad.Text = "FONDO ROTATIVO"
            Me.txtDetalleActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoGastosFondoRotativo, Me.btnGuardarGastosFondoRotativo, Me.btnCancelarGastosFondoRotativo, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(599, 32)
            Me.MenuStrip1.TabIndex = 184
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoGastosFondoRotativo
            '
            Me.btnNuevoGastosFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoGastosFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoGastosFondoRotativo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoGastosFondoRotativo.Name = "btnNuevoGastosFondoRotativo"
            Me.btnNuevoGastosFondoRotativo.Size = New System.Drawing.Size(81, 28)
            Me.btnNuevoGastosFondoRotativo.Text = "NUEVO"
            '
            'btnGuardarGastosFondoRotativo
            '
            Me.btnGuardarGastosFondoRotativo.Enabled = False
            Me.btnGuardarGastosFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarGastosFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarGastosFondoRotativo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarGastosFondoRotativo.Name = "btnGuardarGastosFondoRotativo"
            Me.btnGuardarGastosFondoRotativo.Size = New System.Drawing.Size(95, 28)
            Me.btnGuardarGastosFondoRotativo.Text = "GUARDAR"
            '
            'btnCancelarGastosFondoRotativo
            '
            Me.btnCancelarGastosFondoRotativo.Enabled = False
            Me.btnCancelarGastosFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarGastosFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarGastosFondoRotativo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelarGastosFondoRotativo.Name = "btnCancelarGastosFondoRotativo"
            Me.btnCancelarGastosFondoRotativo.Size = New System.Drawing.Size(97, 28)
            Me.btnCancelarGastosFondoRotativo.Text = "CANCELAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(90, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 36)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCtaContableGastoFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCtaContableActividad)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreGastoFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdGastosFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDetalleActividad)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(591, 78)
            Me.KryptonGroupBox1.TabIndex = 185
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(4, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Detalle"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(3, 29)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(81, 20)
            Me.KryptonLabel2.TabIndex = 1
            Me.KryptonLabel2.Values.Text = "Cta Contable"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(212, 4)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(79, 20)
            Me.KryptonLabel3.TabIndex = 4
            Me.KryptonLabel3.Values.Text = "ID Concepto"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(212, 27)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel4.TabIndex = 5
            Me.KryptonLabel4.Values.Text = "Detalle"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(394, 5)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(81, 20)
            Me.KryptonLabel5.TabIndex = 15
            Me.KryptonLabel5.Values.Text = "Cta Contable"
            '
            'FormGastosFondoRotativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(599, 426)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvGastosFondoRotativo)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormGastosFondoRotativo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CONCEPTOS DE FONDO ROTATIVO"
            CType(Me.dgvGastosFondoRotativo, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents txtIdGastosFR As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreGastoFR As System.Windows.Forms.TextBox
        Friend WithEvents txtCtaContableGastoFR As System.Windows.Forms.TextBox
        Friend WithEvents dgvGastosFondoRotativo As System.Windows.Forms.DataGridView
        Friend WithEvents txtCtaContableActividad As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalleActividad As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoGastosFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarGastosFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarGastosFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace