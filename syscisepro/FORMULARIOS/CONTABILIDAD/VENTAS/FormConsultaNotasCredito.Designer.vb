Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormConsultaNotasCredito
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaNotasCredito))
            Me.gbNumeroFactura = New System.Windows.Forms.GroupBox()
            Me.txtNumeroFacturaBuscar = New System.Windows.Forms.TextBox()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.gbClienteGeneral = New System.Windows.Forms.GroupBox()
            Me.txtClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.dgvNotaCredito = New System.Windows.Forms.DataGridView()
            Me.gbTotal = New System.Windows.Forms.GroupBox()
            Me.lblSubtotalIva = New System.Windows.Forms.Label()
            Me.txtTotalSubtotal = New System.Windows.Forms.TextBox()
            Me.lblIva = New System.Windows.Forms.Label()
            Me.txtTotalIVA = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtTotalFacturas = New System.Windows.Forms.TextBox()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.dgvDetalleFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.dgvCliente = New System.Windows.Forms.DataGridView()
            Me.gbEstadoFactura = New System.Windows.Forms.GroupBox()
            Me.rbTodas = New System.Windows.Forms.RadioButton()
            Me.rbAnuladas = New System.Windows.Forms.RadioButton()
            Me.rbActivas = New System.Windows.Forms.RadioButton()
            Me.gbTipoReporte = New System.Windows.Forms.GroupBox()
            Me.rbNroNotaCredito = New System.Windows.Forms.RadioButton()
            Me.rbConsorcio = New System.Windows.Forms.RadioButton()
            Me.rbPorCliente = New System.Windows.Forms.RadioButton()
            Me.rbTodo = New System.Windows.Forms.RadioButton()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnSalir = New System.Windows.Forms.ToolStripMenuItem()
            Me.GENERARRIDEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ofdSeleccionarArchivo = New System.Windows.Forms.OpenFileDialog()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnNotaCreditoPath = New System.Windows.Forms.Button()
            Me.txtNotaCreditoPath = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.gbNumeroFactura.SuspendLayout()
            Me.gbRangoFechas.SuspendLayout()
            Me.gbClienteGeneral.SuspendLayout()
            CType(Me.dgvNotaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbTotal.SuspendLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbEstadoFactura.SuspendLayout()
            Me.gbTipoReporte.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbNumeroFactura
            '
            Me.gbNumeroFactura.BackColor = System.Drawing.Color.White
            Me.gbNumeroFactura.Controls.Add(Me.txtNumeroFacturaBuscar)
            Me.gbNumeroFactura.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNumeroFactura.Location = New System.Drawing.Point(1157, 8)
            Me.gbNumeroFactura.Name = "gbNumeroFactura"
            Me.gbNumeroFactura.Size = New System.Drawing.Size(117, 61)
            Me.gbNumeroFactura.TabIndex = 101
            Me.gbNumeroFactura.TabStop = False
            Me.gbNumeroFactura.Text = "NRO NOTA CREDITO"
            '
            'txtNumeroFacturaBuscar
            '
            Me.txtNumeroFacturaBuscar.BackColor = System.Drawing.Color.White
            Me.txtNumeroFacturaBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroFacturaBuscar.Location = New System.Drawing.Point(7, 24)
            Me.txtNumeroFacturaBuscar.Name = "txtNumeroFacturaBuscar"
            Me.txtNumeroFacturaBuscar.Size = New System.Drawing.Size(105, 20)
            Me.txtNumeroFacturaBuscar.TabIndex = 0
            Me.txtNumeroFacturaBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.lblIdFacturaVenta)
            Me.gbRangoFechas.Controls.Add(Me.Label1)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaDesde)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(931, 7)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(222, 61)
            Me.gbRangoFechas.TabIndex = 98
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(191, 1)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(25, 13)
            Me.lblIdFacturaVenta.TabIndex = 4
            Me.lblIdFacturaVenta.Text = "..."
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(104, 28)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(13, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "a"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(118, 24)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(98, 20)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(5, 24)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(98, 20)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'gbClienteGeneral
            '
            Me.gbClienteGeneral.BackColor = System.Drawing.Color.White
            Me.gbClienteGeneral.Controls.Add(Me.txtClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.lblIdClienteGeneral)
            Me.gbClienteGeneral.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbClienteGeneral.Location = New System.Drawing.Point(202, 7)
            Me.gbClienteGeneral.Name = "gbClienteGeneral"
            Me.gbClienteGeneral.Size = New System.Drawing.Size(589, 61)
            Me.gbClienteGeneral.TabIndex = 97
            Me.gbClienteGeneral.TabStop = False
            Me.gbClienteGeneral.Text = "CLIENTES"
            '
            'txtClienteGeneral
            '
            Me.txtClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtClienteGeneral.Location = New System.Drawing.Point(6, 24)
            Me.txtClienteGeneral.Name = "txtClienteGeneral"
            Me.txtClienteGeneral.Size = New System.Drawing.Size(577, 20)
            Me.txtClienteGeneral.TabIndex = 31
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(66, 1)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(13, 13)
            Me.lblIdClienteGeneral.TabIndex = 30
            Me.lblIdClienteGeneral.Text = "0"
            '
            'dgvNotaCredito
            '
            Me.dgvNotaCredito.AllowUserToAddRows = False
            Me.dgvNotaCredito.AllowUserToDeleteRows = False
            Me.dgvNotaCredito.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvNotaCredito.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvNotaCredito.BackgroundColor = System.Drawing.Color.White
            Me.dgvNotaCredito.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvNotaCredito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvNotaCredito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvNotaCredito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvNotaCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvNotaCredito.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvNotaCredito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvNotaCredito.Location = New System.Drawing.Point(3, 16)
            Me.dgvNotaCredito.MultiSelect = False
            Me.dgvNotaCredito.Name = "dgvNotaCredito"
            Me.dgvNotaCredito.ReadOnly = True
            Me.dgvNotaCredito.RowHeadersVisible = False
            Me.dgvNotaCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvNotaCredito.Size = New System.Drawing.Size(1286, 527)
            Me.dgvNotaCredito.TabIndex = 102
            '
            'gbTotal
            '
            Me.gbTotal.BackColor = System.Drawing.Color.White
            Me.gbTotal.Controls.Add(Me.lblSubtotalIva)
            Me.gbTotal.Controls.Add(Me.txtTotalSubtotal)
            Me.gbTotal.Controls.Add(Me.lblIva)
            Me.gbTotal.Controls.Add(Me.txtTotalIVA)
            Me.gbTotal.Controls.Add(Me.Label4)
            Me.gbTotal.Controls.Add(Me.txtTotalFacturas)
            Me.gbTotal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotal.Location = New System.Drawing.Point(1, 631)
            Me.gbTotal.Name = "gbTotal"
            Me.gbTotal.Size = New System.Drawing.Size(1292, 44)
            Me.gbTotal.TabIndex = 103
            Me.gbTotal.TabStop = False
            '
            'lblSubtotalIva
            '
            Me.lblSubtotalIva.AutoSize = True
            Me.lblSubtotalIva.Location = New System.Drawing.Point(724, 20)
            Me.lblSubtotalIva.Name = "lblSubtotalIva"
            Me.lblSubtotalIva.Size = New System.Drawing.Size(85, 13)
            Me.lblSubtotalIva.TabIndex = 9
            Me.lblSubtotalIva.Text = "SUBTOTAL 12%:"
            '
            'txtTotalSubtotal
            '
            Me.txtTotalSubtotal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalSubtotal.Location = New System.Drawing.Point(815, 15)
            Me.txtTotalSubtotal.Name = "txtTotalSubtotal"
            Me.txtTotalSubtotal.Size = New System.Drawing.Size(89, 23)
            Me.txtTotalSubtotal.TabIndex = 8
            Me.txtTotalSubtotal.Text = "0.00"
            Me.txtTotalSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIva
            '
            Me.lblIva.AutoSize = True
            Me.lblIva.Location = New System.Drawing.Point(913, 20)
            Me.lblIva.Name = "lblIva"
            Me.lblIva.Size = New System.Drawing.Size(61, 13)
            Me.lblIva.TabIndex = 7
            Me.lblIva.Text = "IVA(12%):"
            '
            'txtTotalIVA
            '
            Me.txtTotalIVA.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalIVA.Location = New System.Drawing.Point(978, 15)
            Me.txtTotalIVA.Name = "txtTotalIVA"
            Me.txtTotalIVA.Size = New System.Drawing.Size(89, 23)
            Me.txtTotalIVA.TabIndex = 6
            Me.txtTotalIVA.Text = "0.00"
            Me.txtTotalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(1071, 20)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(121, 13)
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "TOTAL NOTA CRÉDITO:"
            '
            'txtTotalFacturas
            '
            Me.txtTotalFacturas.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturas.Location = New System.Drawing.Point(1197, 15)
            Me.txtTotalFacturas.Name = "txtTotalFacturas"
            Me.txtTotalFacturas.Size = New System.Drawing.Size(89, 23)
            Me.txtTotalFacturas.TabIndex = 4
            Me.txtTotalFacturas.Text = "0.00"
            Me.txtTotalFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(48, 10)
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.ReadOnly = True
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(125, 43)
            Me.dgvFacturaVenta.TabIndex = 105
            '
            'dgvDetalleFacturaVenta
            '
            Me.dgvDetalleFacturaVenta.AllowUserToAddRows = False
            Me.dgvDetalleFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvDetalleFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleFacturaVenta.Location = New System.Drawing.Point(11, 192)
            Me.dgvDetalleFacturaVenta.Name = "dgvDetalleFacturaVenta"
            Me.dgvDetalleFacturaVenta.ReadOnly = True
            Me.dgvDetalleFacturaVenta.Size = New System.Drawing.Size(1270, 181)
            Me.dgvDetalleFacturaVenta.TabIndex = 106
            '
            'dgvCliente
            '
            Me.dgvCliente.AllowUserToAddRows = False
            Me.dgvCliente.AllowUserToDeleteRows = False
            Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCliente.Location = New System.Drawing.Point(464, 10)
            Me.dgvCliente.Name = "dgvCliente"
            Me.dgvCliente.ReadOnly = True
            Me.dgvCliente.Size = New System.Drawing.Size(125, 43)
            Me.dgvCliente.TabIndex = 107
            Me.dgvCliente.Visible = False
            '
            'gbEstadoFactura
            '
            Me.gbEstadoFactura.BackColor = System.Drawing.Color.White
            Me.gbEstadoFactura.Controls.Add(Me.rbTodas)
            Me.gbEstadoFactura.Controls.Add(Me.rbAnuladas)
            Me.gbEstadoFactura.Controls.Add(Me.rbActivas)
            Me.gbEstadoFactura.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEstadoFactura.Location = New System.Drawing.Point(796, 7)
            Me.gbEstadoFactura.Name = "gbEstadoFactura"
            Me.gbEstadoFactura.Size = New System.Drawing.Size(130, 61)
            Me.gbEstadoFactura.TabIndex = 108
            Me.gbEstadoFactura.TabStop = False
            Me.gbEstadoFactura.Text = "ESTADO FACTURA"
            '
            'rbTodas
            '
            Me.rbTodas.AutoSize = True
            Me.rbTodas.Checked = True
            Me.rbTodas.Location = New System.Drawing.Point(74, 18)
            Me.rbTodas.Name = "rbTodas"
            Me.rbTodas.Size = New System.Drawing.Size(55, 17)
            Me.rbTodas.TabIndex = 2
            Me.rbTodas.TabStop = True
            Me.rbTodas.Text = "TODAS"
            Me.rbTodas.UseVisualStyleBackColor = True
            '
            'rbAnuladas
            '
            Me.rbAnuladas.AutoSize = True
            Me.rbAnuladas.Location = New System.Drawing.Point(4, 36)
            Me.rbAnuladas.Name = "rbAnuladas"
            Me.rbAnuladas.Size = New System.Drawing.Size(73, 17)
            Me.rbAnuladas.TabIndex = 1
            Me.rbAnuladas.Text = "ANULADAS"
            Me.rbAnuladas.UseVisualStyleBackColor = True
            '
            'rbActivas
            '
            Me.rbActivas.AutoSize = True
            Me.rbActivas.Location = New System.Drawing.Point(4, 18)
            Me.rbActivas.Name = "rbActivas"
            Me.rbActivas.Size = New System.Drawing.Size(67, 17)
            Me.rbActivas.TabIndex = 0
            Me.rbActivas.Text = "ACTIVAS"
            Me.rbActivas.UseVisualStyleBackColor = True
            '
            'gbTipoReporte
            '
            Me.gbTipoReporte.BackColor = System.Drawing.Color.White
            Me.gbTipoReporte.Controls.Add(Me.rbNroNotaCredito)
            Me.gbTipoReporte.Controls.Add(Me.rbConsorcio)
            Me.gbTipoReporte.Controls.Add(Me.rbPorCliente)
            Me.gbTipoReporte.Controls.Add(Me.rbTodo)
            Me.gbTipoReporte.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoReporte.Location = New System.Drawing.Point(5, 6)
            Me.gbTipoReporte.Name = "gbTipoReporte"
            Me.gbTipoReporte.Size = New System.Drawing.Size(191, 61)
            Me.gbTipoReporte.TabIndex = 109
            Me.gbTipoReporte.TabStop = False
            Me.gbTipoReporte.Text = "TIPO DE REPORTE"
            '
            'rbNroNotaCredito
            '
            Me.rbNroNotaCredito.AutoSize = True
            Me.rbNroNotaCredito.Location = New System.Drawing.Point(96, 18)
            Me.rbNroNotaCredito.Name = "rbNroNotaCredito"
            Me.rbNroNotaCredito.Size = New System.Drawing.Size(73, 17)
            Me.rbNroNotaCredito.TabIndex = 34
            Me.rbNroNotaCredito.Text = "Nro Nota"
            Me.rbNroNotaCredito.UseVisualStyleBackColor = True
            '
            'rbConsorcio
            '
            Me.rbConsorcio.AutoSize = True
            Me.rbConsorcio.Location = New System.Drawing.Point(6, 36)
            Me.rbConsorcio.Name = "rbConsorcio"
            Me.rbConsorcio.Size = New System.Drawing.Size(55, 17)
            Me.rbConsorcio.TabIndex = 24
            Me.rbConsorcio.Text = "Grupo"
            Me.rbConsorcio.UseVisualStyleBackColor = True
            '
            'rbPorCliente
            '
            Me.rbPorCliente.AutoSize = True
            Me.rbPorCliente.Location = New System.Drawing.Point(6, 18)
            Me.rbPorCliente.Name = "rbPorCliente"
            Me.rbPorCliente.Size = New System.Drawing.Size(91, 17)
            Me.rbPorCliente.TabIndex = 1
            Me.rbPorCliente.Text = "Por Cliente"
            Me.rbPorCliente.UseVisualStyleBackColor = True
            '
            'rbTodo
            '
            Me.rbTodo.AutoSize = True
            Me.rbTodo.Checked = True
            Me.rbTodo.Location = New System.Drawing.Point(96, 38)
            Me.rbTodo.Name = "rbTodo"
            Me.rbTodo.Size = New System.Drawing.Size(49, 17)
            Me.rbTodo.TabIndex = 0
            Me.rbTodo.TabStop = True
            Me.rbTodo.Text = "Todo"
            Me.rbTodo.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.dgvNotaCredito)
            Me.GroupBox1.Controls.Add(Me.dgvDetalleFacturaVenta)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(7, 132)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1292, 546)
            Me.GroupBox1.TabIndex = 110
            Me.GroupBox1.TabStop = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportar, Me.btnSalir, Me.GENERARRIDEToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1294, 24)
            Me.MenuStrip1.TabIndex = 191
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(79, 20)
            Me.btnBuscar.Text = "BUSCAR"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 20)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.syscisepro.My.Resources.Resources.generate_tables_icon
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(108, 20)
            Me.btnSalir.Text = "GENERAR XML"
            '
            'GENERARRIDEToolStripMenuItem
            '
            Me.GENERARRIDEToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.GENERARRIDEToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.report
            Me.GENERARRIDEToolStripMenuItem.Name = "GENERARRIDEToolStripMenuItem"
            Me.GENERARRIDEToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
            Me.GENERARRIDEToolStripMenuItem.Text = "GENERAR RIDE"
            '
            'ofdSeleccionarArchivo
            '
            Me.ofdSeleccionarArchivo.FileName = "OpenFileDialog1"
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.Location = New System.Drawing.Point(1, 24)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1288, 106)
            Me.TabControl1.TabIndex = 192
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.gbTipoReporte)
            Me.TabPage1.Controls.Add(Me.gbClienteGeneral)
            Me.TabPage1.Controls.Add(Me.gbNumeroFactura)
            Me.TabPage1.Controls.Add(Me.gbEstadoFactura)
            Me.TabPage1.Controls.Add(Me.gbRangoFechas)
            Me.TabPage1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(1280, 80)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "CONSULTA"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.GroupBox2)
            Me.TabPage2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(1280, 80)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "RUTA DE DOCUMENTO"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.btnNotaCreditoPath)
            Me.GroupBox2.Controls.Add(Me.txtNotaCreditoPath)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(3, 6)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1150, 68)
            Me.GroupBox2.TabIndex = 2
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "SELECCIONE RUTA"
            '
            'btnNotaCreditoPath
            '
            Me.btnNotaCreditoPath.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnNotaCreditoPath.Location = New System.Drawing.Point(771, 25)
            Me.btnNotaCreditoPath.Name = "btnNotaCreditoPath"
            Me.btnNotaCreditoPath.Size = New System.Drawing.Size(44, 23)
            Me.btnNotaCreditoPath.TabIndex = 2
            Me.btnNotaCreditoPath.UseVisualStyleBackColor = True
            '
            'txtNotaCreditoPath
            '
            Me.txtNotaCreditoPath.Enabled = False
            Me.txtNotaCreditoPath.Location = New System.Drawing.Point(121, 25)
            Me.txtNotaCreditoPath.Name = "txtNotaCreditoPath"
            Me.txtNotaCreditoPath.Size = New System.Drawing.Size(621, 20)
            Me.txtNotaCreditoPath.TabIndex = 1
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(6, 28)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(103, 13)
            Me.Label9.TabIndex = 0
            Me.Label9.Text = "RUTA DE FACTURA:"
            '
            'FormConsultaNotasCredito
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1294, 675)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvFacturaVenta)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbTotal)
            Me.Controls.Add(Me.dgvCliente)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormConsultaNotasCredito"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "CONSULTA NOTAS DE CREDITO"
            Me.gbNumeroFactura.ResumeLayout(False)
            Me.gbNumeroFactura.PerformLayout()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.gbClienteGeneral.ResumeLayout(False)
            Me.gbClienteGeneral.PerformLayout()
            CType(Me.dgvNotaCredito, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbTotal.ResumeLayout(False)
            Me.gbTotal.PerformLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbEstadoFactura.ResumeLayout(False)
            Me.gbEstadoFactura.PerformLayout()
            Me.gbTipoReporte.ResumeLayout(False)
            Me.gbTipoReporte.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbNumeroFactura As System.Windows.Forms.GroupBox
        Friend WithEvents txtNumeroFacturaBuscar As System.Windows.Forms.TextBox
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbClienteGeneral As System.Windows.Forms.GroupBox
        Friend WithEvents txtClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents dgvNotaCredito As System.Windows.Forms.DataGridView
        Friend WithEvents gbTotal As System.Windows.Forms.GroupBox
        Friend WithEvents lblSubtotalIva As System.Windows.Forms.Label
        Friend WithEvents txtTotalSubtotal As System.Windows.Forms.TextBox
        Friend WithEvents lblIva As System.Windows.Forms.Label
        Friend WithEvents txtTotalIVA As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtTotalFacturas As System.Windows.Forms.TextBox
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
        Friend WithEvents gbEstadoFactura As System.Windows.Forms.GroupBox
        Friend WithEvents rbTodas As System.Windows.Forms.RadioButton
        Friend WithEvents rbAnuladas As System.Windows.Forms.RadioButton
        Friend WithEvents rbActivas As System.Windows.Forms.RadioButton
        Friend WithEvents gbTipoReporte As System.Windows.Forms.GroupBox
        Friend WithEvents rbNroNotaCredito As System.Windows.Forms.RadioButton
        Friend WithEvents rbConsorcio As System.Windows.Forms.RadioButton
        Friend WithEvents rbPorCliente As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodo As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnSalir As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GENERARRIDEToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ofdSeleccionarArchivo As OpenFileDialog
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents btnNotaCreditoPath As Button
        Friend WithEvents txtNotaCreditoPath As TextBox
        Friend WithEvents Label9 As Label
    End Class
End Namespace