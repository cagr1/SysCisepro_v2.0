Namespace FORMULARIOS.CONTABILIDAD.MAYORIZACION
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormSaldosMayores
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSaldosMayores))
            Me.tcSaldos = New System.Windows.Forms.TabControl()
            Me.tpCuentas = New System.Windows.Forms.TabPage()
            Me.dgvCuentas = New System.Windows.Forms.DataGridView()
            Me.nodo = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.dgvCuentasPorProcesar = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dtpAnio = New System.Windows.Forms.DateTimePicker()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.lblHasta = New System.Windows.Forms.Label()
            Me.lblDesde = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.txtEgresos = New System.Windows.Forms.TextBox()
            Me.txtIngresos = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.txtAcreedorEgresos = New System.Windows.Forms.TextBox()
            Me.txtDeudorEgresos = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtAcreedorIngresos = New System.Windows.Forms.TextBox()
            Me.txtDeudorIngresos = New System.Windows.Forms.TextBox()
            Me.txtUtilidad = New System.Windows.Forms.TextBox()
            Me.lblUtilidadPerdida = New System.Windows.Forms.Label()
            Me.txtDeudor = New System.Windows.Forms.TextBox()
            Me.txtAcreedor = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtCapital = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAsientoInicial = New System.Windows.Forms.ToolStripMenuItem()
            Me.tcSaldos.SuspendLayout()
            Me.tpCuentas.SuspendLayout()
            CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvCuentasPorProcesar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcSaldos
            '
            Me.tcSaldos.Controls.Add(Me.tpCuentas)
            Me.tcSaldos.Location = New System.Drawing.Point(-4, 72)
            Me.tcSaldos.Name = "tcSaldos"
            Me.tcSaldos.SelectedIndex = 0
            Me.tcSaldos.Size = New System.Drawing.Size(1018, 549)
            Me.tcSaldos.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
            Me.tcSaldos.TabIndex = 0
            '
            'tpCuentas
            '
            Me.tpCuentas.Controls.Add(Me.dgvCuentas)
            Me.tpCuentas.Controls.Add(Me.dgvCuentasPorProcesar)
            Me.tpCuentas.Location = New System.Drawing.Point(4, 22)
            Me.tpCuentas.Name = "tpCuentas"
            Me.tpCuentas.Padding = New System.Windows.Forms.Padding(3)
            Me.tpCuentas.Size = New System.Drawing.Size(1010, 523)
            Me.tpCuentas.TabIndex = 0
            Me.tpCuentas.Text = "PLAN DE CUENTAS"
            Me.tpCuentas.UseVisualStyleBackColor = True
            '
            'dgvCuentas
            '
            Me.dgvCuentas.AllowUserToAddRows = False
            Me.dgvCuentas.AllowUserToDeleteRows = False
            Me.dgvCuentas.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCuentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCuentas.BackgroundColor = System.Drawing.Color.White
            Me.dgvCuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nodo})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCuentas.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvCuentas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvCuentas.GridColor = System.Drawing.Color.Gray
            Me.dgvCuentas.Location = New System.Drawing.Point(3, 3)
            Me.dgvCuentas.MultiSelect = False
            Me.dgvCuentas.Name = "dgvCuentas"
            Me.dgvCuentas.ReadOnly = True
            Me.dgvCuentas.RowHeadersVisible = False
            Me.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCuentas.Size = New System.Drawing.Size(1004, 517)
            Me.dgvCuentas.TabIndex = 194
            '
            'nodo
            '
            Me.nodo.HeaderText = "+"
            Me.nodo.Name = "nodo"
            Me.nodo.ReadOnly = True
            Me.nodo.Width = 25
            '
            'dgvCuentasPorProcesar
            '
            Me.dgvCuentasPorProcesar.AllowUserToAddRows = False
            Me.dgvCuentasPorProcesar.AllowUserToDeleteRows = False
            Me.dgvCuentasPorProcesar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCuentasPorProcesar.Location = New System.Drawing.Point(514, 3)
            Me.dgvCuentasPorProcesar.Name = "dgvCuentasPorProcesar"
            Me.dgvCuentasPorProcesar.Size = New System.Drawing.Size(478, 566)
            Me.dgvCuentasPorProcesar.TabIndex = 195
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dtpAnio)
            Me.GroupBox1.Controls.Add(Me.dtpFinal)
            Me.GroupBox1.Controls.Add(Me.dtpInicio)
            Me.GroupBox1.Controls.Add(Me.lblHasta)
            Me.GroupBox1.Controls.Add(Me.lblDesde)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(3, 33)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1003, 37)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            '
            'dtpAnio
            '
            Me.dtpAnio.CustomFormat = "yyyy"
            Me.dtpAnio.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.dtpAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAnio.Location = New System.Drawing.Point(39, 11)
            Me.dtpAnio.Name = "dtpAnio"
            Me.dtpAnio.ShowUpDown = True
            Me.dtpAnio.Size = New System.Drawing.Size(60, 20)
            Me.dtpAnio.TabIndex = 257
            '
            'dtpFinal
            '
            Me.dtpFinal.Enabled = False
            Me.dtpFinal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFinal.Location = New System.Drawing.Point(611, 11)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(254, 21)
            Me.dtpFinal.TabIndex = 253
            '
            'dtpInicio
            '
            Me.dtpInicio.Enabled = False
            Me.dtpInicio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpInicio.Location = New System.Drawing.Point(288, 11)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(254, 21)
            Me.dtpInicio.TabIndex = 252
            '
            'lblHasta
            '
            Me.lblHasta.AutoSize = True
            Me.lblHasta.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.lblHasta.Location = New System.Drawing.Point(568, 16)
            Me.lblHasta.Name = "lblHasta"
            Me.lblHasta.Size = New System.Drawing.Size(43, 13)
            Me.lblHasta.TabIndex = 255
            Me.lblHasta.Text = "Hasta:"
            '
            'lblDesde
            '
            Me.lblDesde.AutoSize = True
            Me.lblDesde.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.lblDesde.Location = New System.Drawing.Point(246, 16)
            Me.lblDesde.Name = "lblDesde"
            Me.lblDesde.Size = New System.Drawing.Size(43, 13)
            Me.lblDesde.TabIndex = 254
            Me.lblDesde.Text = "Desde:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label1.Location = New System.Drawing.Point(6, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(31, 13)
            Me.Label1.TabIndex = 256
            Me.Label1.Text = "AÑO:"
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.txtTotal)
            Me.GroupBox2.Controls.Add(Me.txtEgresos)
            Me.GroupBox2.Controls.Add(Me.txtIngresos)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.Label21)
            Me.GroupBox2.Controls.Add(Me.txtAcreedorEgresos)
            Me.GroupBox2.Controls.Add(Me.txtDeudorEgresos)
            Me.GroupBox2.Controls.Add(Me.Label20)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.txtAcreedorIngresos)
            Me.GroupBox2.Controls.Add(Me.txtDeudorIngresos)
            Me.GroupBox2.Controls.Add(Me.txtUtilidad)
            Me.GroupBox2.Controls.Add(Me.lblUtilidadPerdida)
            Me.GroupBox2.Controls.Add(Me.txtDeudor)
            Me.GroupBox2.Controls.Add(Me.txtAcreedor)
            Me.GroupBox2.Controls.Add(Me.Label10)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.txtCapital)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.Label22)
            Me.GroupBox2.Location = New System.Drawing.Point(3, 618)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1003, 110)
            Me.GroupBox2.TabIndex = 2
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Resultados"
            '
            'txtTotal
            '
            Me.txtTotal.Enabled = False
            Me.txtTotal.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotal.Location = New System.Drawing.Point(871, 79)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(125, 26)
            Me.txtTotal.TabIndex = 290
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtEgresos
            '
            Me.txtEgresos.Enabled = False
            Me.txtEgresos.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEgresos.Location = New System.Drawing.Point(871, 47)
            Me.txtEgresos.Name = "txtEgresos"
            Me.txtEgresos.Size = New System.Drawing.Size(125, 26)
            Me.txtEgresos.TabIndex = 287
            Me.txtEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIngresos
            '
            Me.txtIngresos.Enabled = False
            Me.txtIngresos.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIngresos.Location = New System.Drawing.Point(871, 15)
            Me.txtIngresos.Name = "txtIngresos"
            Me.txtIngresos.Size = New System.Drawing.Size(125, 26)
            Me.txtIngresos.TabIndex = 283
            Me.txtIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(825, 82)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(40, 22)
            Me.Label5.TabIndex = 292
            Me.Label5.Text = ") ="
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.ForeColor = System.Drawing.Color.Maroon
            Me.Label21.Location = New System.Drawing.Point(771, 48)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(80, 22)
            Me.Label21.TabIndex = 288
            Me.Label21.Text = "EGRESOS"
            '
            'txtAcreedorEgresos
            '
            Me.txtAcreedorEgresos.Enabled = False
            Me.txtAcreedorEgresos.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedorEgresos.Location = New System.Drawing.Point(592, 59)
            Me.txtAcreedorEgresos.Name = "txtAcreedorEgresos"
            Me.txtAcreedorEgresos.Size = New System.Drawing.Size(113, 23)
            Me.txtAcreedorEgresos.TabIndex = 286
            Me.txtAcreedorEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudorEgresos
            '
            Me.txtDeudorEgresos.Enabled = False
            Me.txtDeudorEgresos.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudorEgresos.Location = New System.Drawing.Point(473, 59)
            Me.txtDeudorEgresos.Name = "txtDeudorEgresos"
            Me.txtDeudorEgresos.Size = New System.Drawing.Size(113, 23)
            Me.txtDeudorEgresos.TabIndex = 285
            Me.txtDeudorEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.Label20.Location = New System.Drawing.Point(761, 16)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(90, 22)
            Me.Label20.TabIndex = 284
            Me.Label20.Text = "INGRESOS"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label2.Location = New System.Drawing.Point(606, 11)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(55, 13)
            Me.Label2.TabIndex = 282
            Me.Label2.Text = "ACREEDOR"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label3.Location = New System.Drawing.Point(491, 11)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(43, 13)
            Me.Label3.TabIndex = 281
            Me.Label3.Text = "DEUDOR"
            '
            'txtAcreedorIngresos
            '
            Me.txtAcreedorIngresos.Enabled = False
            Me.txtAcreedorIngresos.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedorIngresos.Location = New System.Drawing.Point(592, 27)
            Me.txtAcreedorIngresos.Name = "txtAcreedorIngresos"
            Me.txtAcreedorIngresos.Size = New System.Drawing.Size(113, 23)
            Me.txtAcreedorIngresos.TabIndex = 280
            Me.txtAcreedorIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudorIngresos
            '
            Me.txtDeudorIngresos.Enabled = False
            Me.txtDeudorIngresos.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudorIngresos.Location = New System.Drawing.Point(473, 27)
            Me.txtDeudorIngresos.Name = "txtDeudorIngresos"
            Me.txtDeudorIngresos.Size = New System.Drawing.Size(113, 23)
            Me.txtDeudorIngresos.TabIndex = 279
            Me.txtDeudorIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtUtilidad
            '
            Me.txtUtilidad.Enabled = False
            Me.txtUtilidad.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUtilidad.Location = New System.Drawing.Point(249, 44)
            Me.txtUtilidad.Name = "txtUtilidad"
            Me.txtUtilidad.Size = New System.Drawing.Size(123, 26)
            Me.txtUtilidad.TabIndex = 258
            Me.txtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblUtilidadPerdida
            '
            Me.lblUtilidadPerdida.AutoSize = True
            Me.lblUtilidadPerdida.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUtilidadPerdida.ForeColor = System.Drawing.Color.Navy
            Me.lblUtilidadPerdida.Location = New System.Drawing.Point(265, 20)
            Me.lblUtilidadPerdida.Name = "lblUtilidadPerdida"
            Me.lblUtilidadPerdida.Size = New System.Drawing.Size(90, 22)
            Me.lblUtilidadPerdida.TabIndex = 259
            Me.lblUtilidadPerdida.Text = "UTILIDAD"
            '
            'txtDeudor
            '
            Me.txtDeudor.Enabled = False
            Me.txtDeudor.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudor.Location = New System.Drawing.Point(109, 15)
            Me.txtDeudor.Name = "txtDeudor"
            Me.txtDeudor.Size = New System.Drawing.Size(119, 23)
            Me.txtDeudor.TabIndex = 252
            Me.txtDeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAcreedor
            '
            Me.txtAcreedor.Enabled = False
            Me.txtAcreedor.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedor.Location = New System.Drawing.Point(109, 44)
            Me.txtAcreedor.Name = "txtAcreedor"
            Me.txtAcreedor.Size = New System.Drawing.Size(119, 23)
            Me.txtAcreedor.TabIndex = 253
            Me.txtAcreedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label10.Location = New System.Drawing.Point(6, 78)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(97, 13)
            Me.Label10.TabIndex = 257
            Me.Label10.Text = "PATRIMONIO NETO"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label8.Location = New System.Drawing.Point(60, 20)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(43, 13)
            Me.Label8.TabIndex = 254
            Me.Label8.Text = "ACTIVO"
            '
            'txtCapital
            '
            Me.txtCapital.Enabled = False
            Me.txtCapital.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCapital.Location = New System.Drawing.Point(109, 73)
            Me.txtCapital.Name = "txtCapital"
            Me.txtCapital.Size = New System.Drawing.Size(119, 23)
            Me.txtCapital.TabIndex = 256
            Me.txtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label9.Location = New System.Drawing.Point(60, 49)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(43, 13)
            Me.Label9.TabIndex = 255
            Me.Label9.Text = "PASIVO"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.Maroon
            Me.Label4.Location = New System.Drawing.Point(786, 82)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(50, 22)
            Me.Label4.TabIndex = 291
            Me.Label4.Text = "EGR."
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.Label22.Location = New System.Drawing.Point(707, 82)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(80, 22)
            Me.Label22.TabIndex = 289
            Me.Label22.Text = "(ING. -"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportar, Me.btnAsientoInicial})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1008, 32)
            Me.MenuStrip1.TabIndex = 190
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(87, 28)
            Me.btnBuscar.Text = "BUSCAR"
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
            'btnAsientoInicial
            '
            Me.btnAsientoInicial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAsientoInicial.Image = Global.syscisepro.My.Resources.Resources.list_24dp__2_
            Me.btnAsientoInicial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAsientoInicial.Name = "btnAsientoInicial"
            Me.btnAsientoInicial.Size = New System.Drawing.Size(94, 28)
            Me.btnAsientoInicial.Text = "GENERAR"
            '
            'FormSaldosMayores
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1008, 737)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.tcSaldos)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormSaldosMayores"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ESTABLECER ESTADO DE SITUACIÓN INICIAL"
            Me.tcSaldos.ResumeLayout(False)
            Me.tpCuentas.ResumeLayout(False)
            CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvCuentasPorProcesar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tcSaldos As System.Windows.Forms.TabControl
        Friend WithEvents tpCuentas As System.Windows.Forms.TabPage
        Friend WithEvents dgvCuentas As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblHasta As System.Windows.Forms.Label
        Friend WithEvents lblDesde As System.Windows.Forms.Label
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents dgvCuentasPorProcesar As System.Windows.Forms.DataGridView
        Friend WithEvents nodo As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtUtilidad As System.Windows.Forms.TextBox
        Friend WithEvents lblUtilidadPerdida As System.Windows.Forms.Label
        Friend WithEvents txtDeudor As System.Windows.Forms.TextBox
        Friend WithEvents txtAcreedor As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtCapital As System.Windows.Forms.TextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtIngresos As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtAcreedorIngresos As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudorIngresos As System.Windows.Forms.TextBox
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents txtEgresos As System.Windows.Forms.TextBox
        Friend WithEvents txtAcreedorEgresos As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudorEgresos As System.Windows.Forms.TextBox
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAsientoInicial As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents dtpAnio As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
    End Class
End Namespace