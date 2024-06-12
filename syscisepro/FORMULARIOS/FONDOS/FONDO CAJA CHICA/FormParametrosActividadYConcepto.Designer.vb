Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormParametrosActividadYConcepto
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormParametrosActividadYConcepto))
            Me.tcParametros = New System.Windows.Forms.TabControl()
            Me.tpActividades = New System.Windows.Forms.TabPage()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cbmPlanCuentas = New System.Windows.Forms.ComboBox()
            Me.lblCuentaGastos = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtCtaContable = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtDetalle = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgvGastosCajaChica = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblIdGastoCajaChica = New System.Windows.Forms.Label()
            Me.txtCuentaContable = New System.Windows.Forms.TextBox()
            Me.txtDetalleCuenta = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.crvActividades = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.tcParametros.SuspendLayout()
            Me.tpActividades.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvGastosCajaChica, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.tpReporte.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcParametros
            '
            Me.tcParametros.Controls.Add(Me.tpActividades)
            Me.tcParametros.Controls.Add(Me.tpReporte)
            Me.tcParametros.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcParametros.Location = New System.Drawing.Point(2, 33)
            Me.tcParametros.Name = "tcParametros"
            Me.tcParametros.SelectedIndex = 0
            Me.tcParametros.Size = New System.Drawing.Size(1041, 483)
            Me.tcParametros.TabIndex = 0
            '
            'tpActividades
            '
            Me.tpActividades.BackColor = System.Drawing.Color.White
            Me.tpActividades.Controls.Add(Me.GroupBox2)
            Me.tpActividades.Controls.Add(Me.dgvGastosCajaChica)
            Me.tpActividades.Controls.Add(Me.GroupBox1)
            Me.tpActividades.Location = New System.Drawing.Point(4, 22)
            Me.tpActividades.Name = "tpActividades"
            Me.tpActividades.Padding = New System.Windows.Forms.Padding(3)
            Me.tpActividades.Size = New System.Drawing.Size(1033, 457)
            Me.tpActividades.TabIndex = 0
            Me.tpActividades.Text = "ACTIVIDADES"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.cbmPlanCuentas)
            Me.GroupBox2.Controls.Add(Me.lblCuentaGastos)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.txtCtaContable)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.txtDetalle)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(239, 4)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(790, 66)
            Me.GroupBox2.TabIndex = 8
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "CONCEPTO"
            '
            'cbmPlanCuentas
            '
            Me.cbmPlanCuentas.BackColor = System.Drawing.Color.White
            Me.cbmPlanCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmPlanCuentas.Enabled = False
            Me.cbmPlanCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmPlanCuentas.FormattingEnabled = True
            Me.cbmPlanCuentas.Location = New System.Drawing.Point(480, 33)
            Me.cbmPlanCuentas.Name = "cbmPlanCuentas"
            Me.cbmPlanCuentas.Size = New System.Drawing.Size(250, 21)
            Me.cbmPlanCuentas.TabIndex = 13
            '
            'lblCuentaGastos
            '
            Me.lblCuentaGastos.AutoSize = True
            Me.lblCuentaGastos.Location = New System.Drawing.Point(736, 38)
            Me.lblCuentaGastos.Name = "lblCuentaGastos"
            Me.lblCuentaGastos.Size = New System.Drawing.Size(52, 13)
            Me.lblCuentaGastos.TabIndex = 12
            Me.lblCuentaGastos.Text = "CUENTA "
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(477, 17)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(103, 13)
            Me.Label5.TabIndex = 10
            Me.Label5.Text = "PLAN DE CUENTAS"
            '
            'txtCtaContable
            '
            Me.txtCtaContable.BackColor = System.Drawing.Color.White
            Me.txtCtaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCtaContable.Enabled = False
            Me.txtCtaContable.Location = New System.Drawing.Point(371, 33)
            Me.txtCtaContable.Name = "txtCtaContable"
            Me.txtCtaContable.Size = New System.Drawing.Size(103, 21)
            Me.txtCtaContable.TabIndex = 9
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(368, 17)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(108, 13)
            Me.Label4.TabIndex = 8
            Me.Label4.Text = "CUENTA CONTABLE"
            '
            'txtDetalle
            '
            Me.txtDetalle.BackColor = System.Drawing.Color.White
            Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalle.Enabled = False
            Me.txtDetalle.Location = New System.Drawing.Point(9, 33)
            Me.txtDetalle.Name = "txtDetalle"
            Me.txtDetalle.Size = New System.Drawing.Size(356, 21)
            Me.txtDetalle.TabIndex = 5
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 17)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(55, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "DETALLE:"
            '
            'dgvGastosCajaChica
            '
            Me.dgvGastosCajaChica.AllowUserToAddRows = False
            Me.dgvGastosCajaChica.AllowUserToDeleteRows = False
            Me.dgvGastosCajaChica.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvGastosCajaChica.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvGastosCajaChica.BackgroundColor = System.Drawing.Color.White
            Me.dgvGastosCajaChica.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvGastosCajaChica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvGastosCajaChica.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvGastosCajaChica.Location = New System.Drawing.Point(2, 76)
            Me.dgvGastosCajaChica.MultiSelect = False
            Me.dgvGastosCajaChica.Name = "dgvGastosCajaChica"
            Me.dgvGastosCajaChica.RowHeadersVisible = False
            Me.dgvGastosCajaChica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvGastosCajaChica.Size = New System.Drawing.Size(1027, 379)
            Me.dgvGastosCajaChica.TabIndex = 7
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblIdGastoCajaChica)
            Me.GroupBox1.Controls.Add(Me.txtCuentaContable)
            Me.GroupBox1.Controls.Add(Me.txtDetalleCuenta)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(2, 4)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(231, 66)
            Me.GroupBox1.TabIndex = 6
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "ACTIVIDAD"
            '
            'lblIdGastoCajaChica
            '
            Me.lblIdGastoCajaChica.AutoSize = True
            Me.lblIdGastoCajaChica.Location = New System.Drawing.Point(147, 36)
            Me.lblIdGastoCajaChica.Name = "lblIdGastoCajaChica"
            Me.lblIdGastoCajaChica.Size = New System.Drawing.Size(75, 13)
            Me.lblIdGastoCajaChica.TabIndex = 13
            Me.lblIdGastoCajaChica.Text = "N° REGISTRO"
            '
            'txtCuentaContable
            '
            Me.txtCuentaContable.BackColor = System.Drawing.Color.White
            Me.txtCuentaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCuentaContable.Enabled = False
            Me.txtCuentaContable.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCuentaContable.Location = New System.Drawing.Point(93, 30)
            Me.txtCuentaContable.Name = "txtCuentaContable"
            Me.txtCuentaContable.Size = New System.Drawing.Size(48, 26)
            Me.txtCuentaContable.TabIndex = 4
            Me.txtCuentaContable.Text = "1.1.1.1"
            '
            'txtDetalleCuenta
            '
            Me.txtDetalleCuenta.BackColor = System.Drawing.Color.White
            Me.txtDetalleCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleCuenta.Enabled = False
            Me.txtDetalleCuenta.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalleCuenta.Location = New System.Drawing.Point(9, 30)
            Me.txtDetalleCuenta.Name = "txtDetalleCuenta"
            Me.txtDetalleCuenta.Size = New System.Drawing.Size(79, 26)
            Me.txtDetalleCuenta.TabIndex = 3
            Me.txtDetalleCuenta.Text = "CAJA CHICA"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(90, 14)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(90, 13)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "CUENTA CONTABLE"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(9, 14)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(44, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "DETALLE"
            '
            'tpReporte
            '
            Me.tpReporte.BackColor = System.Drawing.Color.White
            Me.tpReporte.Controls.Add(Me.crvActividades)
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(1033, 459)
            Me.tpReporte.TabIndex = 1
            Me.tpReporte.Text = "REPORTE"
            '
            'crvActividades
            '
            Me.crvActividades.ActiveViewIndex = -1
            Me.crvActividades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvActividades.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvActividades.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvActividades.Location = New System.Drawing.Point(3, 3)
            Me.crvActividades.Name = "crvActividades"
            Me.crvActividades.Size = New System.Drawing.Size(1027, 453)
            Me.crvActividades.TabIndex = 0
            Me.crvActividades.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1042, 32)
            Me.MenuStrip1.TabIndex = 199
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelar.Text = "CANCELAR"
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
            'FormParametrosActividadYConcepto
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1042, 515)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tcParametros)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormParametrosActividadYConcepto"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "PARÁMETROS DE ACTIVIDAD Y CONCEPTOS"
            Me.tcParametros.ResumeLayout(False)
            Me.tpActividades.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.dgvGastosCajaChica, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.tpReporte.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tcParametros As System.Windows.Forms.TabControl
        Friend WithEvents tpActividades As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents cbmPlanCuentas As System.Windows.Forms.ComboBox
        Friend WithEvents lblCuentaGastos As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtCtaContable As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dgvGastosCajaChica As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdGastoCajaChica As System.Windows.Forms.Label
        Friend WithEvents txtCuentaContable As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalleCuenta As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents tpReporte As System.Windows.Forms.TabPage
        Friend WithEvents crvActividades As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace