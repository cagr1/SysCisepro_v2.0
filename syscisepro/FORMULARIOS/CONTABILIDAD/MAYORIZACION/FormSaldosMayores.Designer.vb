Namespace FORMULARIOS.CONTABILIDAD.MAYORIZACION
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormSaldosMayores
        'Inherits System.Windows.Forms.Form
        Inherits Krypton.Toolkit.KryptonForm
        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSaldosMayores))
            Me.dgvCuentas = New System.Windows.Forms.DataGridView()
            Me.nodo = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.dgvCuentasPorProcesar = New System.Windows.Forms.DataGridView()
            Me.dtpAnio = New System.Windows.Forms.DateTimePicker()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.txtEgresos = New System.Windows.Forms.TextBox()
            Me.txtIngresos = New System.Windows.Forms.TextBox()
            Me.txtAcreedorEgresos = New System.Windows.Forms.TextBox()
            Me.txtDeudorEgresos = New System.Windows.Forms.TextBox()
            Me.txtAcreedorIngresos = New System.Windows.Forms.TextBox()
            Me.txtDeudorIngresos = New System.Windows.Forms.TextBox()
            Me.txtUtilidad = New System.Windows.Forms.TextBox()
            Me.txtDeudor = New System.Windows.Forms.TextBox()
            Me.txtAcreedor = New System.Windows.Forms.TextBox()
            Me.txtCapital = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAsientoInicial = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.lblUtilidadPerdida = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvCuentasPorProcesar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvCuentas
            '
            Me.dgvCuentas.AllowUserToAddRows = False
            Me.dgvCuentas.AllowUserToDeleteRows = False
            Me.dgvCuentas.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCuentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCuentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvCuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nodo})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCuentas.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvCuentas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvCuentas.GridColor = System.Drawing.Color.Gray
            Me.dgvCuentas.Location = New System.Drawing.Point(0, 0)
            Me.dgvCuentas.MultiSelect = False
            Me.dgvCuentas.Name = "dgvCuentas"
            Me.dgvCuentas.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCuentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvCuentas.RowHeadersVisible = False
            Me.dgvCuentas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCuentas.Size = New System.Drawing.Size(861, 344)
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
            Me.dgvCuentasPorProcesar.Location = New System.Drawing.Point(478, 0)
            Me.dgvCuentasPorProcesar.Name = "dgvCuentasPorProcesar"
            Me.dgvCuentasPorProcesar.Size = New System.Drawing.Size(380, 353)
            Me.dgvCuentasPorProcesar.TabIndex = 195
            '
            'dtpAnio
            '
            Me.dtpAnio.CustomFormat = "yyyy"
            Me.dtpAnio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAnio.Location = New System.Drawing.Point(52, 3)
            Me.dtpAnio.Name = "dtpAnio"
            Me.dtpAnio.ShowUpDown = True
            Me.dtpAnio.Size = New System.Drawing.Size(60, 21)
            Me.dtpAnio.TabIndex = 257
            '
            'dtpFinal
            '
            Me.dtpFinal.Enabled = False
            Me.dtpFinal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFinal.Location = New System.Drawing.Point(456, 4)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(209, 21)
            Me.dtpFinal.TabIndex = 253
            '
            'dtpInicio
            '
            Me.dtpInicio.Enabled = False
            Me.dtpInicio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpInicio.Location = New System.Drawing.Point(186, 3)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(209, 21)
            Me.dtpInicio.TabIndex = 252
            '
            'txtTotal
            '
            Me.txtTotal.Enabled = False
            Me.txtTotal.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotal.Location = New System.Drawing.Point(720, 53)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(125, 23)
            Me.txtTotal.TabIndex = 290
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtEgresos
            '
            Me.txtEgresos.Enabled = False
            Me.txtEgresos.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEgresos.Location = New System.Drawing.Point(720, 27)
            Me.txtEgresos.Name = "txtEgresos"
            Me.txtEgresos.Size = New System.Drawing.Size(125, 23)
            Me.txtEgresos.TabIndex = 287
            Me.txtEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIngresos
            '
            Me.txtIngresos.Enabled = False
            Me.txtIngresos.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIngresos.Location = New System.Drawing.Point(720, 1)
            Me.txtIngresos.Name = "txtIngresos"
            Me.txtIngresos.Size = New System.Drawing.Size(125, 23)
            Me.txtIngresos.TabIndex = 283
            Me.txtIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAcreedorEgresos
            '
            Me.txtAcreedorEgresos.Enabled = False
            Me.txtAcreedorEgresos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedorEgresos.Location = New System.Drawing.Point(523, 53)
            Me.txtAcreedorEgresos.Name = "txtAcreedorEgresos"
            Me.txtAcreedorEgresos.Size = New System.Drawing.Size(113, 21)
            Me.txtAcreedorEgresos.TabIndex = 286
            Me.txtAcreedorEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudorEgresos
            '
            Me.txtDeudorEgresos.Enabled = False
            Me.txtDeudorEgresos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudorEgresos.Location = New System.Drawing.Point(405, 53)
            Me.txtDeudorEgresos.Name = "txtDeudorEgresos"
            Me.txtDeudorEgresos.Size = New System.Drawing.Size(113, 21)
            Me.txtDeudorEgresos.TabIndex = 285
            Me.txtDeudorEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAcreedorIngresos
            '
            Me.txtAcreedorIngresos.Enabled = False
            Me.txtAcreedorIngresos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedorIngresos.Location = New System.Drawing.Point(523, 27)
            Me.txtAcreedorIngresos.Name = "txtAcreedorIngresos"
            Me.txtAcreedorIngresos.Size = New System.Drawing.Size(113, 21)
            Me.txtAcreedorIngresos.TabIndex = 280
            Me.txtAcreedorIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudorIngresos
            '
            Me.txtDeudorIngresos.Enabled = False
            Me.txtDeudorIngresos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudorIngresos.Location = New System.Drawing.Point(405, 27)
            Me.txtDeudorIngresos.Name = "txtDeudorIngresos"
            Me.txtDeudorIngresos.Size = New System.Drawing.Size(113, 21)
            Me.txtDeudorIngresos.TabIndex = 279
            Me.txtDeudorIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtUtilidad
            '
            Me.txtUtilidad.Enabled = False
            Me.txtUtilidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUtilidad.Location = New System.Drawing.Point(267, 29)
            Me.txtUtilidad.Name = "txtUtilidad"
            Me.txtUtilidad.Size = New System.Drawing.Size(123, 21)
            Me.txtUtilidad.TabIndex = 258
            Me.txtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudor
            '
            Me.txtDeudor.Enabled = False
            Me.txtDeudor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudor.Location = New System.Drawing.Point(122, 1)
            Me.txtDeudor.Name = "txtDeudor"
            Me.txtDeudor.Size = New System.Drawing.Size(119, 21)
            Me.txtDeudor.TabIndex = 252
            Me.txtDeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAcreedor
            '
            Me.txtAcreedor.Enabled = False
            Me.txtAcreedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedor.Location = New System.Drawing.Point(122, 27)
            Me.txtAcreedor.Name = "txtAcreedor"
            Me.txtAcreedor.Size = New System.Drawing.Size(119, 21)
            Me.txtAcreedor.TabIndex = 253
            Me.txtAcreedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtCapital
            '
            Me.txtCapital.Enabled = False
            Me.txtCapital.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCapital.Location = New System.Drawing.Point(122, 53)
            Me.txtCapital.Name = "txtCapital"
            Me.txtCapital.Size = New System.Drawing.Size(119, 21)
            Me.txtCapital.TabIndex = 256
            Me.txtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportar, Me.btnAsientoInicial})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(868, 32)
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
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 36)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFinal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpInicio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAnio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(865, 56)
            Me.KryptonGroupBox1.TabIndex = 191
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(33, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Año"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(133, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel2.TabIndex = 258
            Me.KryptonLabel2.Values.Text = "Desde"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(409, 4)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel3.TabIndex = 259
            Me.KryptonLabel3.Values.Text = "Hasta"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(3, 96)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvCuentas)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvCuentasPorProcesar)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(865, 368)
            Me.KryptonGroupBox2.TabIndex = 192
            Me.KryptonGroupBox2.Values.Heading = "Plan Cuentas"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(3, 471)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotal)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtEgresos)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtIngresos)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblUtilidadPerdida)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtAcreedorEgresos)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtDeudor)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtDeudorEgresos)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtAcreedor)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtCapital)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtUtilidad)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtDeudorIngresos)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtAcreedorIngresos)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(865, 110)
            Me.KryptonGroupBox3.TabIndex = 193
            Me.KryptonGroupBox3.Values.Heading = "Resultados"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(12, 3)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel4.TabIndex = 259
            Me.KryptonLabel4.Values.Text = "Activo"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(12, 29)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel5.TabIndex = 260
            Me.KryptonLabel5.Values.Text = "Pasivo"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(12, 55)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(101, 20)
            Me.KryptonLabel6.TabIndex = 261
            Me.KryptonLabel6.Values.Text = "Patrimonio Neto"
            '
            'lblUtilidadPerdida
            '
            Me.lblUtilidadPerdida.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.lblUtilidadPerdida.Location = New System.Drawing.Point(297, 3)
            Me.lblUtilidadPerdida.Name = "lblUtilidadPerdida"
            Me.lblUtilidadPerdida.Size = New System.Drawing.Size(57, 20)
            Me.lblUtilidadPerdida.TabIndex = 262
            Me.lblUtilidadPerdida.Values.Text = "Utilidad"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(433, 3)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(51, 20)
            Me.KryptonLabel8.TabIndex = 263
            Me.KryptonLabel8.Values.Text = "Deudor"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(551, 3)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel9.TabIndex = 287
            Me.KryptonLabel9.Values.Text = "Acreedor"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(652, 3)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(57, 20)
            Me.KryptonLabel10.TabIndex = 288
            Me.KryptonLabel10.Values.Text = "Ingresos"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(652, 29)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.OrangeRed
            Me.KryptonLabel11.TabIndex = 289
            Me.KryptonLabel11.Values.Text = "Egresos"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel12.Location = New System.Drawing.Point(652, 56)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel12.TabIndex = 290
            Me.KryptonLabel12.Values.Text = "Resultado"
            '
            'FormSaldosMayores
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(868, 584)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormSaldosMayores"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ESTABLECER ESTADO DE SITUACIÓN INICIAL"
            CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvCuentasPorProcesar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            Me.KryptonGroupBox3.Panel.PerformLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvCuentas As System.Windows.Forms.DataGridView
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents dgvCuentasPorProcesar As System.Windows.Forms.DataGridView
        Friend WithEvents nodo As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents txtUtilidad As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudor As System.Windows.Forms.TextBox
        Friend WithEvents txtAcreedor As System.Windows.Forms.TextBox
        Friend WithEvents txtCapital As System.Windows.Forms.TextBox
        Friend WithEvents txtIngresos As System.Windows.Forms.TextBox
        Friend WithEvents txtAcreedorIngresos As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudorIngresos As System.Windows.Forms.TextBox
        Friend WithEvents txtEgresos As System.Windows.Forms.TextBox
        Friend WithEvents txtAcreedorEgresos As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudorEgresos As System.Windows.Forms.TextBox
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAsientoInicial As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents dtpAnio As System.Windows.Forms.DateTimePicker
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblUtilidadPerdida As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace