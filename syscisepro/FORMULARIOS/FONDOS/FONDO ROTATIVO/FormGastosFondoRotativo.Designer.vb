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
            Me.lblIgGastoFR = New System.Windows.Forms.Label()
            Me.lblNombreGastoFR = New System.Windows.Forms.Label()
            Me.lblCtaContableGastosFR = New System.Windows.Forms.Label()
            Me.txtIdGastosFR = New System.Windows.Forms.TextBox()
            Me.txtNombreGastoFR = New System.Windows.Forms.TextBox()
            Me.txtCtaContableGastoFR = New System.Windows.Forms.TextBox()
            Me.dgvGastosFondoRotativo = New System.Windows.Forms.DataGridView()
            Me.gbConcepto = New System.Windows.Forms.GroupBox()
            Me.gpActividad = New System.Windows.Forms.GroupBox()
            Me.txtCtaContableActividad = New System.Windows.Forms.TextBox()
            Me.lblCtaContableActividad = New System.Windows.Forms.Label()
            Me.txtDetalleActividad = New System.Windows.Forms.TextBox()
            Me.lblDetalleActividad = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoGastosFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarGastosFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarGastosFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvGastosFondoRotativo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbConcepto.SuspendLayout()
            Me.gpActividad.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblIgGastoFR
            '
            Me.lblIgGastoFR.AutoSize = True
            Me.lblIgGastoFR.Location = New System.Drawing.Point(10, 26)
            Me.lblIgGastoFR.Name = "lblIgGastoFR"
            Me.lblIgGastoFR.Size = New System.Drawing.Size(81, 13)
            Me.lblIgGastoFR.TabIndex = 10
            Me.lblIgGastoFR.Text = "ID CONCEPTO:"
            '
            'lblNombreGastoFR
            '
            Me.lblNombreGastoFR.AutoSize = True
            Me.lblNombreGastoFR.Location = New System.Drawing.Point(10, 53)
            Me.lblNombreGastoFR.Name = "lblNombreGastoFR"
            Me.lblNombreGastoFR.Size = New System.Drawing.Size(55, 13)
            Me.lblNombreGastoFR.TabIndex = 11
            Me.lblNombreGastoFR.Text = "DETALLE:"
            '
            'lblCtaContableGastosFR
            '
            Me.lblCtaContableGastosFR.AutoSize = True
            Me.lblCtaContableGastosFR.Location = New System.Drawing.Point(218, 25)
            Me.lblCtaContableGastosFR.Name = "lblCtaContableGastosFR"
            Me.lblCtaContableGastosFR.Size = New System.Drawing.Size(93, 13)
            Me.lblCtaContableGastosFR.TabIndex = 12
            Me.lblCtaContableGastosFR.Text = "CTA. CONTABLE:"
            '
            'txtIdGastosFR
            '
            Me.txtIdGastosFR.BackColor = System.Drawing.Color.White
            Me.txtIdGastosFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdGastosFR.Location = New System.Drawing.Point(92, 23)
            Me.txtIdGastosFR.Name = "txtIdGastosFR"
            Me.txtIdGastosFR.Size = New System.Drawing.Size(120, 21)
            Me.txtIdGastosFR.TabIndex = 13
            '
            'txtNombreGastoFR
            '
            Me.txtNombreGastoFR.BackColor = System.Drawing.Color.White
            Me.txtNombreGastoFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreGastoFR.Location = New System.Drawing.Point(90, 50)
            Me.txtNombreGastoFR.Name = "txtNombreGastoFR"
            Me.txtNombreGastoFR.Size = New System.Drawing.Size(175, 21)
            Me.txtNombreGastoFR.TabIndex = 14
            '
            'txtCtaContableGastoFR
            '
            Me.txtCtaContableGastoFR.BackColor = System.Drawing.Color.White
            Me.txtCtaContableGastoFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCtaContableGastoFR.Location = New System.Drawing.Point(312, 22)
            Me.txtCtaContableGastoFR.Name = "txtCtaContableGastoFR"
            Me.txtCtaContableGastoFR.Size = New System.Drawing.Size(95, 21)
            Me.txtCtaContableGastoFR.TabIndex = 15
            '
            'dgvGastosFondoRotativo
            '
            Me.dgvGastosFondoRotativo.AllowUserToAddRows = False
            Me.dgvGastosFondoRotativo.AllowUserToDeleteRows = False
            Me.dgvGastosFondoRotativo.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvGastosFondoRotativo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvGastosFondoRotativo.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvGastosFondoRotativo.Location = New System.Drawing.Point(2, 113)
            Me.dgvGastosFondoRotativo.MultiSelect = False
            Me.dgvGastosFondoRotativo.Name = "dgvGastosFondoRotativo"
            Me.dgvGastosFondoRotativo.RowHeadersVisible = False
            Me.dgvGastosFondoRotativo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvGastosFondoRotativo.Size = New System.Drawing.Size(644, 311)
            Me.dgvGastosFondoRotativo.TabIndex = 16
            '
            'gbConcepto
            '
            Me.gbConcepto.Controls.Add(Me.lblIgGastoFR)
            Me.gbConcepto.Controls.Add(Me.lblNombreGastoFR)
            Me.gbConcepto.Controls.Add(Me.txtCtaContableGastoFR)
            Me.gbConcepto.Controls.Add(Me.lblCtaContableGastosFR)
            Me.gbConcepto.Controls.Add(Me.txtIdGastosFR)
            Me.gbConcepto.Controls.Add(Me.txtNombreGastoFR)
            Me.gbConcepto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbConcepto.Location = New System.Drawing.Point(234, 35)
            Me.gbConcepto.Name = "gbConcepto"
            Me.gbConcepto.Size = New System.Drawing.Size(412, 77)
            Me.gbConcepto.TabIndex = 17
            Me.gbConcepto.TabStop = False
            Me.gbConcepto.Text = "CONCEPTO"
            '
            'gpActividad
            '
            Me.gpActividad.Controls.Add(Me.txtCtaContableActividad)
            Me.gpActividad.Controls.Add(Me.lblCtaContableActividad)
            Me.gpActividad.Controls.Add(Me.txtDetalleActividad)
            Me.gpActividad.Controls.Add(Me.lblDetalleActividad)
            Me.gpActividad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gpActividad.Location = New System.Drawing.Point(2, 35)
            Me.gpActividad.Name = "gpActividad"
            Me.gpActividad.Size = New System.Drawing.Size(232, 77)
            Me.gpActividad.TabIndex = 18
            Me.gpActividad.TabStop = False
            Me.gpActividad.Text = "ACTIVIDAD"
            '
            'txtCtaContableActividad
            '
            Me.txtCtaContableActividad.BackColor = System.Drawing.Color.White
            Me.txtCtaContableActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCtaContableActividad.Enabled = False
            Me.txtCtaContableActividad.Location = New System.Drawing.Point(104, 49)
            Me.txtCtaContableActividad.Name = "txtCtaContableActividad"
            Me.txtCtaContableActividad.Size = New System.Drawing.Size(122, 21)
            Me.txtCtaContableActividad.TabIndex = 3
            Me.txtCtaContableActividad.Text = "1.1.1.2"
            Me.txtCtaContableActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblCtaContableActividad
            '
            Me.lblCtaContableActividad.AutoSize = True
            Me.lblCtaContableActividad.Location = New System.Drawing.Point(6, 52)
            Me.lblCtaContableActividad.Name = "lblCtaContableActividad"
            Me.lblCtaContableActividad.Size = New System.Drawing.Size(90, 13)
            Me.lblCtaContableActividad.TabIndex = 2
            Me.lblCtaContableActividad.Text = "CTA CONTABLE:"
            '
            'txtDetalleActividad
            '
            Me.txtDetalleActividad.BackColor = System.Drawing.Color.White
            Me.txtDetalleActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleActividad.Enabled = False
            Me.txtDetalleActividad.Location = New System.Drawing.Point(104, 21)
            Me.txtDetalleActividad.Name = "txtDetalleActividad"
            Me.txtDetalleActividad.Size = New System.Drawing.Size(122, 21)
            Me.txtDetalleActividad.TabIndex = 1
            Me.txtDetalleActividad.Text = "FONDO ROTATIVO"
            Me.txtDetalleActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblDetalleActividad
            '
            Me.lblDetalleActividad.AutoSize = True
            Me.lblDetalleActividad.Location = New System.Drawing.Point(6, 24)
            Me.lblDetalleActividad.Name = "lblDetalleActividad"
            Me.lblDetalleActividad.Size = New System.Drawing.Size(55, 13)
            Me.lblDetalleActividad.TabIndex = 0
            Me.lblDetalleActividad.Text = "DETALLE:"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoGastosFondoRotativo, Me.btnGuardarGastosFondoRotativo, Me.btnCancelarGastosFondoRotativo, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(650, 32)
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
            'FormGastosFondoRotativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(650, 426)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gpActividad)
            Me.Controls.Add(Me.gbConcepto)
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
            Me.gbConcepto.ResumeLayout(False)
            Me.gbConcepto.PerformLayout()
            Me.gpActividad.ResumeLayout(False)
            Me.gpActividad.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblIgGastoFR As System.Windows.Forms.Label
        Friend WithEvents lblNombreGastoFR As System.Windows.Forms.Label
        Friend WithEvents lblCtaContableGastosFR As System.Windows.Forms.Label
        Friend WithEvents txtIdGastosFR As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreGastoFR As System.Windows.Forms.TextBox
        Friend WithEvents txtCtaContableGastoFR As System.Windows.Forms.TextBox
        Friend WithEvents dgvGastosFondoRotativo As System.Windows.Forms.DataGridView
        Friend WithEvents gbConcepto As System.Windows.Forms.GroupBox
        Friend WithEvents gpActividad As System.Windows.Forms.GroupBox
        Friend WithEvents txtCtaContableActividad As System.Windows.Forms.TextBox
        Friend WithEvents lblCtaContableActividad As System.Windows.Forms.Label
        Friend WithEvents txtDetalleActividad As System.Windows.Forms.TextBox
        Friend WithEvents lblDetalleActividad As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoGastosFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarGastosFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarGastosFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace