Namespace FORMULARIOS.CONTABILIDAD.CUENTAS_POR_PAGAR
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCuentasPorPagarMin
        Inherits System.Windows.Forms.Form

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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCuentasPorPagarMin))
            Me.gbTipoReporte = New System.Windows.Forms.GroupBox()
            Me.ChkTodos = New System.Windows.Forms.CheckBox()
            Me.rbPorCliente = New System.Windows.Forms.RadioButton()
            Me.rbGeneral = New System.Windows.Forms.RadioButton()
            Me.gbNombreComercialProveedor = New System.Windows.Forms.GroupBox()
            Me.lblRucProveedorGeneral = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.dgvProveedorGeneral = New System.Windows.Forms.DataGridView()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.lblIdComprobanteEgresoBanco = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.dgvCuentasPorPagar = New System.Windows.Forms.DataGridView()
            Me.txtTotalCuentasPorPagar = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.REPORTEASIENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbTipoReporte.SuspendLayout()
            Me.gbNombreComercialProveedor.SuspendLayout()
            CType(Me.dgvProveedorGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbRangoFechas.SuspendLayout()
            CType(Me.dgvCuentasPorPagar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbTipoReporte
            '
            Me.gbTipoReporte.Controls.Add(Me.ChkTodos)
            Me.gbTipoReporte.Controls.Add(Me.rbPorCliente)
            Me.gbTipoReporte.Controls.Add(Me.rbGeneral)
            Me.gbTipoReporte.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoReporte.Location = New System.Drawing.Point(-1, 25)
            Me.gbTipoReporte.Name = "gbTipoReporte"
            Me.gbTipoReporte.Size = New System.Drawing.Size(194, 60)
            Me.gbTipoReporte.TabIndex = 94
            Me.gbTipoReporte.TabStop = False
            Me.gbTipoReporte.Text = "TIPO DE REPORTE"
            '
            'ChkTodos
            '
            Me.ChkTodos.Location = New System.Drawing.Point(113, 11)
            Me.ChkTodos.Name = "ChkTodos"
            Me.ChkTodos.Size = New System.Drawing.Size(91, 19)
            Me.ChkTodos.TabIndex = 4
            Me.ChkTodos.Text = "Ver todo"
            Me.ChkTodos.UseVisualStyleBackColor = True
            '
            'rbPorCliente
            '
            Me.rbPorCliente.AutoSize = True
            Me.rbPorCliente.Location = New System.Drawing.Point(8, 34)
            Me.rbPorCliente.Name = "rbPorCliente"
            Me.rbPorCliente.Size = New System.Drawing.Size(103, 17)
            Me.rbPorCliente.TabIndex = 3
            Me.rbPorCliente.TabStop = True
            Me.rbPorCliente.Text = "POR PROVEEDOR"
            Me.rbPorCliente.UseVisualStyleBackColor = True
            '
            'rbGeneral
            '
            Me.rbGeneral.AutoSize = True
            Me.rbGeneral.Location = New System.Drawing.Point(9, 13)
            Me.rbGeneral.Name = "rbGeneral"
            Me.rbGeneral.Size = New System.Drawing.Size(67, 17)
            Me.rbGeneral.TabIndex = 2
            Me.rbGeneral.TabStop = True
            Me.rbGeneral.Text = "GENERAL"
            Me.rbGeneral.UseVisualStyleBackColor = True
            '
            'gbNombreComercialProveedor
            '
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblRucProveedorGeneral)
            Me.gbNombreComercialProveedor.Controls.Add(Me.Label1)
            Me.gbNombreComercialProveedor.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblIdProveedorGeneral)
            Me.gbNombreComercialProveedor.Controls.Add(Me.dgvProveedorGeneral)
            Me.gbNombreComercialProveedor.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.gbNombreComercialProveedor.Location = New System.Drawing.Point(191, 25)
            Me.gbNombreComercialProveedor.Name = "gbNombreComercialProveedor"
            Me.gbNombreComercialProveedor.Size = New System.Drawing.Size(289, 60)
            Me.gbNombreComercialProveedor.TabIndex = 95
            Me.gbNombreComercialProveedor.TabStop = False
            Me.gbNombreComercialProveedor.Text = "PROVEEDOR"
            '
            'lblRucProveedorGeneral
            '
            Me.lblRucProveedorGeneral.AutoSize = True
            Me.lblRucProveedorGeneral.Location = New System.Drawing.Point(168, -1)
            Me.lblRucProveedorGeneral.Name = "lblRucProveedorGeneral"
            Me.lblRucProveedorGeneral.Size = New System.Drawing.Size(25, 13)
            Me.lblRucProveedorGeneral.TabIndex = 79
            Me.lblRucProveedorGeneral.Text = "..."
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(113, -1)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(49, 13)
            Me.Label1.TabIndex = 78
            Me.Label1.Text = "R.U.C.:"
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(5, 20)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(278, 20)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 2
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(74, -1)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(25, 13)
            Me.lblIdProveedorGeneral.TabIndex = 76
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'dgvProveedorGeneral
            '
            Me.dgvProveedorGeneral.AllowUserToAddRows = False
            Me.dgvProveedorGeneral.AllowUserToDeleteRows = False
            Me.dgvProveedorGeneral.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvProveedorGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProveedorGeneral.Location = New System.Drawing.Point(188, 20)
            Me.dgvProveedorGeneral.Name = "dgvProveedorGeneral"
            Me.dgvProveedorGeneral.Size = New System.Drawing.Size(68, 20)
            Me.dgvProveedorGeneral.TabIndex = 77
            Me.dgvProveedorGeneral.Visible = False
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.Controls.Add(Me.lblIdComprobanteEgresoBanco)
            Me.gbRangoFechas.Controls.Add(Me.Label7)
            Me.gbRangoFechas.Controls.Add(Me.dtpHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpDesde)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(480, 24)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(229, 61)
            Me.gbRangoFechas.TabIndex = 116
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'lblIdComprobanteEgresoBanco
            '
            Me.lblIdComprobanteEgresoBanco.AutoSize = True
            Me.lblIdComprobanteEgresoBanco.Location = New System.Drawing.Point(142, 0)
            Me.lblIdComprobanteEgresoBanco.Name = "lblIdComprobanteEgresoBanco"
            Me.lblIdComprobanteEgresoBanco.Size = New System.Drawing.Size(25, 13)
            Me.lblIdComprobanteEgresoBanco.TabIndex = 3
            Me.lblIdComprobanteEgresoBanco.Text = "..."
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(108, 22)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(13, 13)
            Me.Label7.TabIndex = 2
            Me.Label7.Text = "a"
            '
            'dtpHasta
            '
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(121, 19)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(98, 20)
            Me.dtpHasta.TabIndex = 1
            '
            'dtpDesde
            '
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(11, 19)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(97, 20)
            Me.dtpDesde.TabIndex = 0
            Me.dtpDesde.Value = New Date(2013, 1, 1, 0, 1, 0, 0)
            '
            'dgvCuentasPorPagar
            '
            Me.dgvCuentasPorPagar.AllowUserToAddRows = False
            Me.dgvCuentasPorPagar.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCuentasPorPagar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCuentasPorPagar.BackgroundColor = System.Drawing.Color.White
            Me.dgvCuentasPorPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCuentasPorPagar.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvCuentasPorPagar.Location = New System.Drawing.Point(0, 87)
            Me.dgvCuentasPorPagar.Name = "dgvCuentasPorPagar"
            Me.dgvCuentasPorPagar.RowHeadersVisible = False
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvCuentasPorPagar.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvCuentasPorPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCuentasPorPagar.Size = New System.Drawing.Size(709, 406)
            Me.dgvCuentasPorPagar.TabIndex = 118
            '
            'txtTotalCuentasPorPagar
            '
            Me.txtTotalCuentasPorPagar.BackColor = System.Drawing.Color.White
            Me.txtTotalCuentasPorPagar.Enabled = False
            Me.txtTotalCuentasPorPagar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalCuentasPorPagar.Location = New System.Drawing.Point(606, 499)
            Me.txtTotalCuentasPorPagar.Name = "txtTotalCuentasPorPagar"
            Me.txtTotalCuentasPorPagar.ReadOnly = True
            Me.txtTotalCuentasPorPagar.Size = New System.Drawing.Size(100, 23)
            Me.txtTotalCuentasPorPagar.TabIndex = 119
            Me.txtTotalCuentasPorPagar.Text = "0.00"
            Me.txtTotalCuentasPorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(516, 503)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(84, 13)
            Me.Label8.TabIndex = 120
            Me.Label8.Text = "TOTAL SALDO:"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportar, Me.REPORTEASIENTOToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(710, 24)
            Me.MenuStrip1.TabIndex = 187
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(132, 20)
            Me.btnBuscar.Text = "BUSCAR CUENTAS"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(90, 20)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'REPORTEASIENTOToolStripMenuItem
            '
            Me.REPORTEASIENTOToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.report
            Me.REPORTEASIENTOToolStripMenuItem.Name = "REPORTEASIENTOToolStripMenuItem"
            Me.REPORTEASIENTOToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
            Me.REPORTEASIENTOToolStripMenuItem.Text = "REPORTE PDF"
            '
            'FrmCuentasPorPagarMin
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(710, 527)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.txtTotalCuentasPorPagar)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.dgvCuentasPorPagar)
            Me.Controls.Add(Me.gbRangoFechas)
            Me.Controls.Add(Me.gbNombreComercialProveedor)
            Me.Controls.Add(Me.gbTipoReporte)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmCuentasPorPagarMin"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "CUENTAS POR PAGAR"
            Me.gbTipoReporte.ResumeLayout(False)
            Me.gbTipoReporte.PerformLayout()
            Me.gbNombreComercialProveedor.ResumeLayout(False)
            Me.gbNombreComercialProveedor.PerformLayout()
            CType(Me.dgvProveedorGeneral, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            CType(Me.dgvCuentasPorPagar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbTipoReporte As System.Windows.Forms.GroupBox
        Friend WithEvents ChkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents rbPorCliente As System.Windows.Forms.RadioButton
        Friend WithEvents rbGeneral As System.Windows.Forms.RadioButton
        Friend WithEvents gbNombreComercialProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents lblRucProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents dgvProveedorGeneral As System.Windows.Forms.DataGridView
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdComprobanteEgresoBanco As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents dgvCuentasPorPagar As System.Windows.Forms.DataGridView
        Friend WithEvents txtTotalCuentasPorPagar As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents REPORTEASIENTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace