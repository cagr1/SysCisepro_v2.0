Namespace FORMULARIOS.CONTABILIDAD.CUENTAS_POR_COBRAR
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCuentasCobrarGeneralMin
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCuentasCobrarGeneralMin))
            Me.gbTipoReporte = New System.Windows.Forms.GroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialClienteGeneral = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.rbPorCliente = New System.Windows.Forms.RadioButton()
            Me.rbGeneral = New System.Windows.Forms.RadioButton()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.ChkTodos = New System.Windows.Forms.CheckBox()
            Me.txtTotalCuentasPorCobrar = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.dgvCuentasPorCobrar = New System.Windows.Forms.DataGridView()
            Me.dgvCliente = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCargarSitios = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportarSitio = New System.Windows.Forms.ToolStripMenuItem()
            Me.REPORTEASIENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbTipoReporte.SuspendLayout()
            CType(Me.dgvCuentasPorCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbTipoReporte
            '
            Me.gbTipoReporte.Controls.Add(Me.Label2)
            Me.gbTipoReporte.Controls.Add(Me.lblIdClienteGeneral)
            Me.gbTipoReporte.Controls.Add(Me.txtNombreComercialClienteGeneral)
            Me.gbTipoReporte.Controls.Add(Me.Label1)
            Me.gbTipoReporte.Controls.Add(Me.rbPorCliente)
            Me.gbTipoReporte.Controls.Add(Me.rbGeneral)
            Me.gbTipoReporte.Controls.Add(Me.Label7)
            Me.gbTipoReporte.Controls.Add(Me.dtpHasta)
            Me.gbTipoReporte.Controls.Add(Me.dtpDesde)
            Me.gbTipoReporte.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoReporte.ForeColor = System.Drawing.Color.Black
            Me.gbTipoReporte.Location = New System.Drawing.Point(-1, 35)
            Me.gbTipoReporte.Name = "gbTipoReporte"
            Me.gbTipoReporte.Size = New System.Drawing.Size(818, 40)
            Me.gbTipoReporte.TabIndex = 50
            Me.gbTipoReporte.TabStop = False
            Me.gbTipoReporte.Text = "TIPO DE REPORTE"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(524, -2)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(53, 13)
            Me.Label2.TabIndex = 77
            Me.Label2.Text = "CLIENTE:"
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(595, -1)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdClienteGeneral.TabIndex = 76
            Me.lblIdClienteGeneral.Text = "..."
            '
            'txtNombreComercialClienteGeneral
            '
            Me.txtNombreComercialClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialClienteGeneral.Enabled = False
            Me.txtNombreComercialClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialClienteGeneral.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtNombreComercialClienteGeneral.Location = New System.Drawing.Point(525, 14)
            Me.txtNombreComercialClienteGeneral.Name = "txtNombreComercialClienteGeneral"
            Me.txtNombreComercialClienteGeneral.Size = New System.Drawing.Size(288, 21)
            Me.txtNombreComercialClienteGeneral.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(215, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(41, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Desde:"
            '
            'rbPorCliente
            '
            Me.rbPorCliente.AutoSize = True
            Me.rbPorCliente.Location = New System.Drawing.Point(103, 18)
            Me.rbPorCliente.Name = "rbPorCliente"
            Me.rbPorCliente.Size = New System.Drawing.Size(93, 17)
            Me.rbPorCliente.TabIndex = 1
            Me.rbPorCliente.TabStop = True
            Me.rbPorCliente.Text = "POR CLIENTE"
            Me.rbPorCliente.UseVisualStyleBackColor = True
            '
            'rbGeneral
            '
            Me.rbGeneral.AutoSize = True
            Me.rbGeneral.Location = New System.Drawing.Point(13, 18)
            Me.rbGeneral.Name = "rbGeneral"
            Me.rbGeneral.Size = New System.Drawing.Size(73, 17)
            Me.rbGeneral.TabIndex = 0
            Me.rbGeneral.TabStop = True
            Me.rbGeneral.Text = "GENERAL"
            Me.rbGeneral.UseVisualStyleBackColor = True
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(382, 18)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(16, 13)
            Me.Label7.TabIndex = 2
            Me.Label7.Text = "a:"
            '
            'dtpHasta
            '
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(401, 15)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(98, 21)
            Me.dtpHasta.TabIndex = 1
            '
            'dtpDesde
            '
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(262, 15)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(97, 21)
            Me.dtpDesde.TabIndex = 0
            Me.dtpDesde.Value = New Date(2013, 1, 1, 0, 1, 0, 0)
            '
            'ChkTodos
            '
            Me.ChkTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.ChkTodos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ChkTodos.Location = New System.Drawing.Point(707, 4)
            Me.ChkTodos.Name = "ChkTodos"
            Me.ChkTodos.Size = New System.Drawing.Size(104, 15)
            Me.ChkTodos.TabIndex = 26
            Me.ChkTodos.Text = "Mostrar todas"
            Me.ChkTodos.UseVisualStyleBackColor = False
            '
            'txtTotalCuentasPorCobrar
            '
            Me.txtTotalCuentasPorCobrar.BackColor = System.Drawing.Color.White
            Me.txtTotalCuentasPorCobrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalCuentasPorCobrar.Enabled = False
            Me.txtTotalCuentasPorCobrar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalCuentasPorCobrar.Location = New System.Drawing.Point(717, 489)
            Me.txtTotalCuentasPorCobrar.Name = "txtTotalCuentasPorCobrar"
            Me.txtTotalCuentasPorCobrar.ReadOnly = True
            Me.txtTotalCuentasPorCobrar.Size = New System.Drawing.Size(95, 21)
            Me.txtTotalCuentasPorCobrar.TabIndex = 117
            Me.txtTotalCuentasPorCobrar.Text = "0.00"
            Me.txtTotalCuentasPorCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(630, 493)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(83, 13)
            Me.Label8.TabIndex = 118
            Me.Label8.Text = "TOTAL SALDO:"
            '
            'dgvCuentasPorCobrar
            '
            Me.dgvCuentasPorCobrar.AllowUserToAddRows = False
            Me.dgvCuentasPorCobrar.AllowUserToDeleteRows = False
            Me.dgvCuentasPorCobrar.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCuentasPorCobrar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCuentasPorCobrar.BackgroundColor = System.Drawing.Color.White
            Me.dgvCuentasPorCobrar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvCuentasPorCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCuentasPorCobrar.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvCuentasPorCobrar.GridColor = System.Drawing.SystemColors.ControlLightLight
            Me.dgvCuentasPorCobrar.Location = New System.Drawing.Point(0, 76)
            Me.dgvCuentasPorCobrar.MultiSelect = False
            Me.dgvCuentasPorCobrar.Name = "dgvCuentasPorCobrar"
            Me.dgvCuentasPorCobrar.ReadOnly = True
            Me.dgvCuentasPorCobrar.RowHeadersVisible = False
            Me.dgvCuentasPorCobrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCuentasPorCobrar.Size = New System.Drawing.Size(816, 407)
            Me.dgvCuentasPorCobrar.TabIndex = 119
            '
            'dgvCliente
            '
            Me.dgvCliente.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCliente.Location = New System.Drawing.Point(504, 38)
            Me.dgvCliente.Name = "dgvCliente"
            Me.dgvCliente.Size = New System.Drawing.Size(98, 58)
            Me.dgvCliente.TabIndex = 120
            Me.dgvCliente.Visible = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargarSitios, Me.btnExportarSitio, Me.REPORTEASIENTOToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(817, 32)
            Me.MenuStrip1.TabIndex = 183
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnCargarSitios
            '
            Me.btnCargarSitios.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCargarSitios.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCargarSitios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCargarSitios.Name = "btnCargarSitios"
            Me.btnCargarSitios.Size = New System.Drawing.Size(92, 28)
            Me.btnCargarSitios.Text = "BUSCAR "
            '
            'btnExportarSitio
            '
            Me.btnExportarSitio.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarSitio.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarSitio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportarSitio.Name = "btnExportarSitio"
            Me.btnExportarSitio.Size = New System.Drawing.Size(99, 28)
            Me.btnExportarSitio.Text = "EXPORTAR"
            '
            'REPORTEASIENTOToolStripMenuItem
            '
            Me.REPORTEASIENTOToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.REPORTEASIENTOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.REPORTEASIENTOToolStripMenuItem.Name = "REPORTEASIENTOToolStripMenuItem"
            Me.REPORTEASIENTOToolStripMenuItem.Size = New System.Drawing.Size(114, 28)
            Me.REPORTEASIENTOToolStripMenuItem.Text = "REPORTE PDF"
            '
            'FrmCuentasCobrarGeneralMin
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(817, 516)
            Me.Controls.Add(Me.ChkTodos)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvCuentasPorCobrar)
            Me.Controls.Add(Me.txtTotalCuentasPorCobrar)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.gbTipoReporte)
            Me.Controls.Add(Me.dgvCliente)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmCuentasCobrarGeneralMin"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "RESUMEN GENERAL DE CUENTAS POR COBRAR"
            Me.gbTipoReporte.ResumeLayout(False)
            Me.gbTipoReporte.PerformLayout()
            CType(Me.dgvCuentasPorCobrar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbTipoReporte As System.Windows.Forms.GroupBox
        Friend WithEvents ChkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents rbPorCliente As System.Windows.Forms.RadioButton
        Friend WithEvents rbGeneral As System.Windows.Forms.RadioButton
        Friend WithEvents txtNombreComercialClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtTotalCuentasPorCobrar As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents dgvCuentasPorCobrar As System.Windows.Forms.DataGridView
        Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCargarSitios As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportarSitio As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents REPORTEASIENTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace