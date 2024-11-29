Namespace FORMULARIOS.CONTABILIDAD.CUENTAS_POR_PAGAR
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCuentasPorPagarMin
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCuentasPorPagarMin))
            Me.dgvCuentasPorPagar = New System.Windows.Forms.DataGridView()
            Me.txtTotalCuentasPorPagar = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.REPORTEASIENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.rbPorCliente = New System.Windows.Forms.RadioButton()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.rbGeneral = New System.Windows.Forms.RadioButton()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.ChkTodos = New System.Windows.Forms.CheckBox()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dgvProveedorGeneral = New System.Windows.Forms.DataGridView()
            Me.lblRucProveedorGeneral = New System.Windows.Forms.Label()
            Me.lblIdComprobanteEgresoBanco = New System.Windows.Forms.Label()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            CType(Me.dgvCuentasPorPagar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.dgvProveedorGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvCuentasPorPagar
            '
            Me.dgvCuentasPorPagar.AllowUserToAddRows = False
            Me.dgvCuentasPorPagar.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCuentasPorPagar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCuentasPorPagar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvCuentasPorPagar.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCuentasPorPagar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvCuentasPorPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCuentasPorPagar.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvCuentasPorPagar.Location = New System.Drawing.Point(0, 123)
            Me.dgvCuentasPorPagar.Name = "dgvCuentasPorPagar"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCuentasPorPagar.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvCuentasPorPagar.RowHeadersVisible = False
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvCuentasPorPagar.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvCuentasPorPagar.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvCuentasPorPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCuentasPorPagar.Size = New System.Drawing.Size(642, 371)
            Me.dgvCuentasPorPagar.TabIndex = 118
            '
            'txtTotalCuentasPorPagar
            '
            Me.txtTotalCuentasPorPagar.BackColor = System.Drawing.Color.White
            Me.txtTotalCuentasPorPagar.Enabled = False
            Me.txtTotalCuentasPorPagar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalCuentasPorPagar.Location = New System.Drawing.Point(542, 499)
            Me.txtTotalCuentasPorPagar.Name = "txtTotalCuentasPorPagar"
            Me.txtTotalCuentasPorPagar.ReadOnly = True
            Me.txtTotalCuentasPorPagar.Size = New System.Drawing.Size(100, 21)
            Me.txtTotalCuentasPorPagar.TabIndex = 119
            Me.txtTotalCuentasPorPagar.Text = "0.00"
            Me.txtTotalCuentasPorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Roboto Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(439, 503)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(94, 13)
            Me.Label8.TabIndex = 120
            Me.Label8.Text = "TOTAL SALDO:"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportar, Me.REPORTEASIENTOToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(647, 32)
            Me.MenuStrip1.TabIndex = 187
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(90, 28)
            Me.btnBuscar.Text = "BUSCAR "
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(98, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'REPORTEASIENTOToolStripMenuItem
            '
            Me.REPORTEASIENTOToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.REPORTEASIENTOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.REPORTEASIENTOToolStripMenuItem.Name = "REPORTEASIENTOToolStripMenuItem"
            Me.REPORTEASIENTOToolStripMenuItem.Size = New System.Drawing.Size(93, 28)
            Me.REPORTEASIENTOToolStripMenuItem.Text = "REPORTE "
            '
            'rbPorCliente
            '
            Me.rbPorCliente.AutoSize = True
            Me.rbPorCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPorCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPorCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPorCliente.Location = New System.Drawing.Point(10, 24)
            Me.rbPorCliente.Name = "rbPorCliente"
            Me.rbPorCliente.Size = New System.Drawing.Size(75, 17)
            Me.rbPorCliente.TabIndex = 3
            Me.rbPorCliente.TabStop = True
            Me.rbPorCliente.Text = "Proveedor"
            Me.rbPorCliente.UseVisualStyleBackColor = False
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(173, 26)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(255, 21)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 2
            '
            'rbGeneral
            '
            Me.rbGeneral.AutoSize = True
            Me.rbGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbGeneral.Location = New System.Drawing.Point(10, 3)
            Me.rbGeneral.Name = "rbGeneral"
            Me.rbGeneral.Size = New System.Drawing.Size(64, 17)
            Me.rbGeneral.TabIndex = 2
            Me.rbGeneral.TabStop = True
            Me.rbGeneral.Text = "General"
            Me.rbGeneral.UseVisualStyleBackColor = False
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProveedorGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(247, 5)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 76
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'ChkTodos
            '
            Me.ChkTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.ChkTodos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ChkTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.ChkTodos.Location = New System.Drawing.Point(93, 3)
            Me.ChkTodos.Name = "ChkTodos"
            Me.ChkTodos.Size = New System.Drawing.Size(75, 19)
            Me.ChkTodos.TabIndex = 4
            Me.ChkTodos.Text = "Ver todo"
            Me.ChkTodos.UseVisualStyleBackColor = False
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(172, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(67, 20)
            Me.KryptonLabel1.TabIndex = 5
            Me.KryptonLabel1.Values.Text = "Proveedor"
            '
            'dtpDesde
            '
            Me.dtpDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(437, 26)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(84, 21)
            Me.dtpDesde.TabIndex = 0
            Me.dtpDesde.Value = New Date(2013, 1, 1, 0, 1, 0, 0)
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(287, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel2.TabIndex = 77
            Me.KryptonLabel2.Values.Text = "RUC"
            '
            'dtpHasta
            '
            Me.dtpHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(544, 26)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(84, 21)
            Me.dtpHasta.TabIndex = 1
            '
            'dgvProveedorGeneral
            '
            Me.dgvProveedorGeneral.AllowUserToAddRows = False
            Me.dgvProveedorGeneral.AllowUserToDeleteRows = False
            Me.dgvProveedorGeneral.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvProveedorGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProveedorGeneral.Location = New System.Drawing.Point(389, 3)
            Me.dgvProveedorGeneral.Name = "dgvProveedorGeneral"
            Me.dgvProveedorGeneral.Size = New System.Drawing.Size(25, 20)
            Me.dgvProveedorGeneral.TabIndex = 77
            Me.dgvProveedorGeneral.Visible = False
            '
            'lblRucProveedorGeneral
            '
            Me.lblRucProveedorGeneral.AutoSize = True
            Me.lblRucProveedorGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblRucProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRucProveedorGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblRucProveedorGeneral.Location = New System.Drawing.Point(335, 5)
            Me.lblRucProveedorGeneral.Name = "lblRucProveedorGeneral"
            Me.lblRucProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblRucProveedorGeneral.TabIndex = 79
            Me.lblRucProveedorGeneral.Text = "..."
            '
            'lblIdComprobanteEgresoBanco
            '
            Me.lblIdComprobanteEgresoBanco.AutoSize = True
            Me.lblIdComprobanteEgresoBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteEgresoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteEgresoBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteEgresoBanco.Location = New System.Drawing.Point(606, 5)
            Me.lblIdComprobanteEgresoBanco.Name = "lblIdComprobanteEgresoBanco"
            Me.lblIdComprobanteEgresoBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteEgresoBanco.TabIndex = 3
            Me.lblIdComprobanteEgresoBanco.Text = "..."
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(437, 3)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(46, 20)
            Me.KryptonLabel3.TabIndex = 80
            Me.KryptonLabel3.Values.Text = "Rango"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 37)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdComprobanteEgresoBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblRucProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dgvProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.ChkTodos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbPorCliente)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(644, 80)
            Me.KryptonGroupBox1.TabIndex = 188
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'FrmCuentasPorPagarMin
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(647, 527)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.txtTotalCuentasPorPagar)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.dgvCuentasPorPagar)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmCuentasPorPagarMin"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CUENTAS POR PAGAR"
            CType(Me.dgvCuentasPorPagar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.dgvProveedorGeneral, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvCuentasPorPagar As System.Windows.Forms.DataGridView
        Friend WithEvents txtTotalCuentasPorPagar As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents REPORTEASIENTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents rbPorCliente As RadioButton
        Friend WithEvents txtNombreComercialProveedorGeneral As TextBox
        Friend WithEvents rbGeneral As RadioButton
        Friend WithEvents lblIdProveedorGeneral As Label
        Friend WithEvents ChkTodos As CheckBox
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents dtpDesde As DateTimePicker
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents dtpHasta As DateTimePicker
        Friend WithEvents dgvProveedorGeneral As DataGridView
        Friend WithEvents lblRucProveedorGeneral As Label
        Friend WithEvents lblIdComprobanteEgresoBanco As Label
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
    End Class
End Namespace