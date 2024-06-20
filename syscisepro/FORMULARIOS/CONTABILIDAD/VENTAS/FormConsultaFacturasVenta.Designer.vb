Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormConsultaFacturasVenta
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
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaFacturasVenta))
            Me.gbClienteGeneral = New System.Windows.Forms.GroupBox()
            Me.txtClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.txtTotalACobrar = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtTotalRetencion = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtTotalFacturas = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtTotalIVA = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtTotalSubtotal = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.gbTotal = New System.Windows.Forms.GroupBox()
            Me.lblNroRegistros = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtTotalNotaCredito = New System.Windows.Forms.TextBox()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.rbFacturasActivas = New System.Windows.Forms.RadioButton()
            Me.rbFacturasAnuladas = New System.Windows.Forms.RadioButton()
            Me.rbFacturasTodas = New System.Windows.Forms.RadioButton()
            Me.gbEstadoFactura = New System.Windows.Forms.GroupBox()
            Me.gbTipoReporte = New System.Windows.Forms.GroupBox()
            Me.rbConcepto = New System.Windows.Forms.RadioButton()
            Me.rbNroFactura = New System.Windows.Forms.RadioButton()
            Me.rbConsorcio = New System.Windows.Forms.RadioButton()
            Me.rbPorCliente = New System.Windows.Forms.RadioButton()
            Me.rbTodo = New System.Windows.Forms.RadioButton()
            Me.dgvEmpresa = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnSalir = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.REPORTEDEVENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ESTADÍSTICOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnValidar = New System.Windows.Forms.ToolStripMenuItem()
            Me.GENERARFACTURAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.BUSQUEDA = New System.Windows.Forms.TabPage()
            Me.REPORTE = New System.Windows.Forms.TabPage()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnFacturaPath = New System.Windows.Forms.Button()
            Me.txtFacturaPath = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.ofdSeleccionarArchivo = New System.Windows.Forms.OpenFileDialog()
            Me.gbClienteGeneral.SuspendLayout()
            Me.gbTotal.SuspendLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbRangoFechas.SuspendLayout()
            Me.gbEstadoFactura.SuspendLayout()
            Me.gbTipoReporte.SuspendLayout()
            CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.BUSQUEDA.SuspendLayout()
            Me.REPORTE.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbClienteGeneral
            '
            Me.gbClienteGeneral.BackColor = System.Drawing.Color.White
            Me.gbClienteGeneral.Controls.Add(Me.txtClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.lblIdClienteGeneral)
            Me.gbClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbClienteGeneral.Location = New System.Drawing.Point(319, 35)
            Me.gbClienteGeneral.Name = "gbClienteGeneral"
            Me.gbClienteGeneral.Size = New System.Drawing.Size(419, 50)
            Me.gbClienteGeneral.TabIndex = 47
            Me.gbClienteGeneral.TabStop = False
            Me.gbClienteGeneral.Text = "CLIENTES"
            '
            'txtClienteGeneral
            '
            Me.txtClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtClienteGeneral.Location = New System.Drawing.Point(9, 21)
            Me.txtClienteGeneral.Name = "txtClienteGeneral"
            Me.txtClienteGeneral.Size = New System.Drawing.Size(404, 21)
            Me.txtClienteGeneral.TabIndex = 31
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(398, 0)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(13, 13)
            Me.lblIdClienteGeneral.TabIndex = 30
            Me.lblIdClienteGeneral.Text = "0"
            '
            'txtTotalACobrar
            '
            Me.txtTotalACobrar.BackColor = System.Drawing.Color.White
            Me.txtTotalACobrar.Enabled = False
            Me.txtTotalACobrar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalACobrar.Location = New System.Drawing.Point(1185, 15)
            Me.txtTotalACobrar.Name = "txtTotalACobrar"
            Me.txtTotalACobrar.Size = New System.Drawing.Size(97, 23)
            Me.txtTotalACobrar.TabIndex = 0
            Me.txtTotalACobrar.Text = "0.00"
            Me.txtTotalACobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(1085, 20)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(97, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "TOTAL A COBRAR:"
            '
            'txtTotalRetencion
            '
            Me.txtTotalRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalRetencion.Enabled = False
            Me.txtTotalRetencion.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalRetencion.Location = New System.Drawing.Point(743, 15)
            Me.txtTotalRetencion.Name = "txtTotalRetencion"
            Me.txtTotalRetencion.Size = New System.Drawing.Size(97, 23)
            Me.txtTotalRetencion.TabIndex = 2
            Me.txtTotalRetencion.Text = "0.00"
            Me.txtTotalRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(634, 20)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(103, 13)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "TOTAL RETENCIÓN:"
            '
            'txtTotalFacturas
            '
            Me.txtTotalFacturas.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturas.Enabled = False
            Me.txtTotalFacturas.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturas.Location = New System.Drawing.Point(535, 15)
            Me.txtTotalFacturas.Name = "txtTotalFacturas"
            Me.txtTotalFacturas.Size = New System.Drawing.Size(97, 23)
            Me.txtTotalFacturas.TabIndex = 4
            Me.txtTotalFacturas.Text = "0.00"
            Me.txtTotalFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(432, 20)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(97, 13)
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "TOTAL FACTURAS:"
            '
            'txtTotalIVA
            '
            Me.txtTotalIVA.BackColor = System.Drawing.Color.White
            Me.txtTotalIVA.Enabled = False
            Me.txtTotalIVA.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalIVA.Location = New System.Drawing.Point(332, 15)
            Me.txtTotalIVA.Name = "txtTotalIVA"
            Me.txtTotalIVA.Size = New System.Drawing.Size(97, 23)
            Me.txtTotalIVA.TabIndex = 6
            Me.txtTotalIVA.Text = "0.00"
            Me.txtTotalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(295, 20)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(31, 13)
            Me.Label5.TabIndex = 7
            Me.Label5.Text = "IVA:"
            '
            'txtTotalSubtotal
            '
            Me.txtTotalSubtotal.BackColor = System.Drawing.Color.White
            Me.txtTotalSubtotal.Enabled = False
            Me.txtTotalSubtotal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalSubtotal.Location = New System.Drawing.Point(196, 15)
            Me.txtTotalSubtotal.Name = "txtTotalSubtotal"
            Me.txtTotalSubtotal.Size = New System.Drawing.Size(97, 23)
            Me.txtTotalSubtotal.TabIndex = 8
            Me.txtTotalSubtotal.Text = "0.00"
            Me.txtTotalSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(129, 20)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(61, 13)
            Me.Label6.TabIndex = 9
            Me.Label6.Text = "SUBTOTAL:"
            '
            'gbTotal
            '
            Me.gbTotal.BackColor = System.Drawing.Color.White
            Me.gbTotal.Controls.Add(Me.lblNroRegistros)
            Me.gbTotal.Controls.Add(Me.Label8)
            Me.gbTotal.Controls.Add(Me.Label7)
            Me.gbTotal.Controls.Add(Me.txtTotalNotaCredito)
            Me.gbTotal.Controls.Add(Me.Label6)
            Me.gbTotal.Controls.Add(Me.txtTotalSubtotal)
            Me.gbTotal.Controls.Add(Me.Label5)
            Me.gbTotal.Controls.Add(Me.txtTotalIVA)
            Me.gbTotal.Controls.Add(Me.Label4)
            Me.gbTotal.Controls.Add(Me.txtTotalFacturas)
            Me.gbTotal.Controls.Add(Me.Label3)
            Me.gbTotal.Controls.Add(Me.txtTotalRetencion)
            Me.gbTotal.Controls.Add(Me.Label2)
            Me.gbTotal.Controls.Add(Me.txtTotalACobrar)
            Me.gbTotal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotal.Location = New System.Drawing.Point(1, 630)
            Me.gbTotal.Name = "gbTotal"
            Me.gbTotal.Size = New System.Drawing.Size(1292, 44)
            Me.gbTotal.TabIndex = 52
            Me.gbTotal.TabStop = False
            '
            'lblNroRegistros
            '
            Me.lblNroRegistros.AutoSize = True
            Me.lblNroRegistros.Location = New System.Drawing.Point(63, 20)
            Me.lblNroRegistros.Name = "lblNroRegistros"
            Me.lblNroRegistros.Size = New System.Drawing.Size(13, 13)
            Me.lblNroRegistros.TabIndex = 13
            Me.lblNroRegistros.Text = "0"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(2, 20)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(55, 13)
            Me.Label8.TabIndex = 12
            Me.Label8.Text = "NRO REG:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(858, 20)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(121, 13)
            Me.Label7.TabIndex = 11
            Me.Label7.Text = "TOTAL NOTA CREDITO:"
            '
            'txtTotalNotaCredito
            '
            Me.txtTotalNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtTotalNotaCredito.Enabled = False
            Me.txtTotalNotaCredito.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalNotaCredito.Location = New System.Drawing.Point(983, 15)
            Me.txtTotalNotaCredito.Name = "txtTotalNotaCredito"
            Me.txtTotalNotaCredito.Size = New System.Drawing.Size(97, 23)
            Me.txtTotalNotaCredito.TabIndex = 10
            Me.txtTotalNotaCredito.Text = "0.00"
            Me.txtTotalNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.Color.White
            Me.dgvFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturaVenta.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(3, 16)
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.ReadOnly = True
            Me.dgvFacturaVenta.RowHeadersVisible = False
            Me.dgvFacturaVenta.RowHeadersWidth = 25
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(1272, 509)
            Me.dgvFacturaVenta.TabIndex = 51
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(10, 18)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(128, 21)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(180, 17)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(142, 21)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(166, 21)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(13, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "a"
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(176, 1)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(16, 13)
            Me.lblIdFacturaVenta.TabIndex = 4
            Me.lblIdFacturaVenta.Text = "..."
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.lblIdFacturaVenta)
            Me.gbRangoFechas.Controls.Add(Me.Label1)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaDesde)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(961, 35)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(332, 50)
            Me.gbRangoFechas.TabIndex = 48
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'rbFacturasActivas
            '
            Me.rbFacturasActivas.AutoSize = True
            Me.rbFacturasActivas.Location = New System.Drawing.Point(6, 21)
            Me.rbFacturasActivas.Name = "rbFacturasActivas"
            Me.rbFacturasActivas.Size = New System.Drawing.Size(70, 17)
            Me.rbFacturasActivas.TabIndex = 0
            Me.rbFacturasActivas.Text = "ACTIVAS"
            Me.rbFacturasActivas.UseVisualStyleBackColor = True
            '
            'rbFacturasAnuladas
            '
            Me.rbFacturasAnuladas.AutoSize = True
            Me.rbFacturasAnuladas.Location = New System.Drawing.Point(79, 21)
            Me.rbFacturasAnuladas.Name = "rbFacturasAnuladas"
            Me.rbFacturasAnuladas.Size = New System.Drawing.Size(81, 17)
            Me.rbFacturasAnuladas.TabIndex = 1
            Me.rbFacturasAnuladas.Text = "ANULADAS"
            Me.rbFacturasAnuladas.UseVisualStyleBackColor = True
            '
            'rbFacturasTodas
            '
            Me.rbFacturasTodas.AutoSize = True
            Me.rbFacturasTodas.Checked = True
            Me.rbFacturasTodas.Location = New System.Drawing.Point(162, 21)
            Me.rbFacturasTodas.Name = "rbFacturasTodas"
            Me.rbFacturasTodas.Size = New System.Drawing.Size(61, 17)
            Me.rbFacturasTodas.TabIndex = 2
            Me.rbFacturasTodas.TabStop = True
            Me.rbFacturasTodas.Text = "TODAS"
            Me.rbFacturasTodas.UseVisualStyleBackColor = True
            '
            'gbEstadoFactura
            '
            Me.gbEstadoFactura.BackColor = System.Drawing.Color.White
            Me.gbEstadoFactura.Controls.Add(Me.rbFacturasTodas)
            Me.gbEstadoFactura.Controls.Add(Me.rbFacturasAnuladas)
            Me.gbEstadoFactura.Controls.Add(Me.rbFacturasActivas)
            Me.gbEstadoFactura.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEstadoFactura.Location = New System.Drawing.Point(738, 35)
            Me.gbEstadoFactura.Name = "gbEstadoFactura"
            Me.gbEstadoFactura.Size = New System.Drawing.Size(223, 50)
            Me.gbEstadoFactura.TabIndex = 49
            Me.gbEstadoFactura.TabStop = False
            Me.gbEstadoFactura.Text = "ESTADO"
            '
            'gbTipoReporte
            '
            Me.gbTipoReporte.BackColor = System.Drawing.Color.White
            Me.gbTipoReporte.Controls.Add(Me.rbConcepto)
            Me.gbTipoReporte.Controls.Add(Me.rbNroFactura)
            Me.gbTipoReporte.Controls.Add(Me.rbConsorcio)
            Me.gbTipoReporte.Controls.Add(Me.rbPorCliente)
            Me.gbTipoReporte.Controls.Add(Me.rbTodo)
            Me.gbTipoReporte.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoReporte.Location = New System.Drawing.Point(1, 35)
            Me.gbTipoReporte.Name = "gbTipoReporte"
            Me.gbTipoReporte.Size = New System.Drawing.Size(318, 50)
            Me.gbTipoReporte.TabIndex = 97
            Me.gbTipoReporte.TabStop = False
            Me.gbTipoReporte.Text = "TIPO DE REPORTE"
            '
            'rbConcepto
            '
            Me.rbConcepto.AutoSize = True
            Me.rbConcepto.Location = New System.Drawing.Point(117, 10)
            Me.rbConcepto.Name = "rbConcepto"
            Me.rbConcepto.Size = New System.Drawing.Size(72, 17)
            Me.rbConcepto.TabIndex = 35
            Me.rbConcepto.Text = "Concepto"
            Me.rbConcepto.UseVisualStyleBackColor = True
            '
            'rbNroFactura
            '
            Me.rbNroFactura.AutoSize = True
            Me.rbNroFactura.Location = New System.Drawing.Point(6, 30)
            Me.rbNroFactura.Name = "rbNroFactura"
            Me.rbNroFactura.Size = New System.Drawing.Size(84, 17)
            Me.rbNroFactura.TabIndex = 34
            Me.rbNroFactura.Text = "Nro Factura"
            Me.rbNroFactura.UseVisualStyleBackColor = True
            '
            'rbConsorcio
            '
            Me.rbConsorcio.AutoSize = True
            Me.rbConsorcio.Location = New System.Drawing.Point(117, 28)
            Me.rbConsorcio.Name = "rbConsorcio"
            Me.rbConsorcio.Size = New System.Drawing.Size(55, 17)
            Me.rbConsorcio.TabIndex = 24
            Me.rbConsorcio.Text = "Grupo"
            Me.rbConsorcio.UseVisualStyleBackColor = True
            '
            'rbPorCliente
            '
            Me.rbPorCliente.AutoSize = True
            Me.rbPorCliente.Location = New System.Drawing.Point(6, 12)
            Me.rbPorCliente.Name = "rbPorCliente"
            Me.rbPorCliente.Size = New System.Drawing.Size(80, 17)
            Me.rbPorCliente.TabIndex = 1
            Me.rbPorCliente.Text = "Por Cliente"
            Me.rbPorCliente.UseVisualStyleBackColor = True
            '
            'rbTodo
            '
            Me.rbTodo.AutoSize = True
            Me.rbTodo.Checked = True
            Me.rbTodo.Location = New System.Drawing.Point(214, 13)
            Me.rbTodo.Name = "rbTodo"
            Me.rbTodo.Size = New System.Drawing.Size(49, 17)
            Me.rbTodo.TabIndex = 0
            Me.rbTodo.TabStop = True
            Me.rbTodo.Text = "Todo"
            Me.rbTodo.UseVisualStyleBackColor = True
            '
            'dgvEmpresa
            '
            Me.dgvEmpresa.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvEmpresa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvEmpresa.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvEmpresa.Location = New System.Drawing.Point(215, 13)
            Me.dgvEmpresa.Name = "dgvEmpresa"
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvEmpresa.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvEmpresa.Size = New System.Drawing.Size(125, 43)
            Me.dgvEmpresa.TabIndex = 105
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.dgvFacturaVenta)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(0, 3)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1278, 528)
            Me.GroupBox1.TabIndex = 106
            Me.GroupBox1.TabStop = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnSalir, Me.btnReporte, Me.btnExportar, Me.btnValidar, Me.GENERARFACTURAToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1294, 32)
            Me.MenuStrip1.TabIndex = 190
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(87, 28)
            Me.btnBuscar.Text = "BUSCAR"
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.syscisepro.My.Resources.Resources.checkbook_20dp_FILL0_wght400_GRAD0_opsz20__2_
            Me.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(116, 28)
            Me.btnSalir.Text = "GENERAR XML"
            '
            'btnReporte
            '
            Me.btnReporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTEDEVENTASToolStripMenuItem, Me.ESTADÍSTICOToolStripMenuItem})
            Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(90, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'REPORTEDEVENTASToolStripMenuItem
            '
            Me.REPORTEDEVENTASToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.REPORTEDEVENTASToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.REPORTEDEVENTASToolStripMenuItem.Name = "REPORTEDEVENTASToolStripMenuItem"
            Me.REPORTEDEVENTASToolStripMenuItem.Size = New System.Drawing.Size(202, 30)
            Me.REPORTEDEVENTASToolStripMenuItem.Text = "REPORTE DE VENTAS"
            '
            'ESTADÍSTICOToolStripMenuItem
            '
            Me.ESTADÍSTICOToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.finance_mode_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ESTADÍSTICOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ESTADÍSTICOToolStripMenuItem.Name = "ESTADÍSTICOToolStripMenuItem"
            Me.ESTADÍSTICOToolStripMenuItem.Size = New System.Drawing.Size(202, 30)
            Me.ESTADÍSTICOToolStripMenuItem.Text = "RESÚMEN ESTADÍSTICO"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(96, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'btnValidar
            '
            Me.btnValidar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnValidar.Image = Global.syscisepro.My.Resources.Resources.check_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnValidar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnValidar.Name = "btnValidar"
            Me.btnValidar.Size = New System.Drawing.Size(86, 28)
            Me.btnValidar.Text = "VALIDAR"
            '
            'GENERARFACTURAToolStripMenuItem
            '
            Me.GENERARFACTURAToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.GENERARFACTURAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.GENERARFACTURAToolStripMenuItem.Name = "GENERARFACTURAToolStripMenuItem"
            Me.GENERARFACTURAToolStripMenuItem.Size = New System.Drawing.Size(97, 28)
            Me.GENERARFACTURAToolStripMenuItem.Text = "GENERAR "
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.BUSQUEDA)
            Me.TabControl1.Controls.Add(Me.REPORTE)
            Me.TabControl1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.Location = New System.Drawing.Point(1, 86)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1289, 553)
            Me.TabControl1.TabIndex = 52
            '
            'BUSQUEDA
            '
            Me.BUSQUEDA.Controls.Add(Me.GroupBox1)
            Me.BUSQUEDA.Location = New System.Drawing.Point(4, 22)
            Me.BUSQUEDA.Name = "BUSQUEDA"
            Me.BUSQUEDA.Padding = New System.Windows.Forms.Padding(3)
            Me.BUSQUEDA.Size = New System.Drawing.Size(1281, 527)
            Me.BUSQUEDA.TabIndex = 0
            Me.BUSQUEDA.Text = "CONSULTA"
            Me.BUSQUEDA.UseVisualStyleBackColor = True
            '
            'REPORTE
            '
            Me.REPORTE.Controls.Add(Me.GroupBox2)
            Me.REPORTE.Location = New System.Drawing.Point(4, 22)
            Me.REPORTE.Name = "REPORTE"
            Me.REPORTE.Padding = New System.Windows.Forms.Padding(3)
            Me.REPORTE.Size = New System.Drawing.Size(1281, 527)
            Me.REPORTE.TabIndex = 1
            Me.REPORTE.Text = "RUTA DOCUMENTOS"
            Me.REPORTE.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.btnFacturaPath)
            Me.GroupBox2.Controls.Add(Me.txtFacturaPath)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(7, 22)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1150, 83)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "SELECCIONE RUTA"
            '
            'btnFacturaPath
            '
            Me.btnFacturaPath.FlatAppearance.BorderSize = 0
            Me.btnFacturaPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnFacturaPath.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnFacturaPath.Location = New System.Drawing.Point(751, 22)
            Me.btnFacturaPath.Name = "btnFacturaPath"
            Me.btnFacturaPath.Size = New System.Drawing.Size(28, 28)
            Me.btnFacturaPath.TabIndex = 2
            Me.btnFacturaPath.UseVisualStyleBackColor = True
            '
            'txtFacturaPath
            '
            Me.txtFacturaPath.Enabled = False
            Me.txtFacturaPath.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFacturaPath.Location = New System.Drawing.Point(121, 25)
            Me.txtFacturaPath.Name = "txtFacturaPath"
            Me.txtFacturaPath.Size = New System.Drawing.Size(621, 21)
            Me.txtFacturaPath.TabIndex = 1
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(6, 28)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(104, 13)
            Me.Label9.TabIndex = 0
            Me.Label9.Text = "RUTA DE FACTURA:"
            '
            'ofdSeleccionarArchivo
            '
            Me.ofdSeleccionarArchivo.FileName = "OpenFileDialog1"
            '
            'FormConsultaFacturasVenta
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1294, 675)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbTipoReporte)
            Me.Controls.Add(Me.gbEstadoFactura)
            Me.Controls.Add(Me.gbRangoFechas)
            Me.Controls.Add(Me.gbClienteGeneral)
            Me.Controls.Add(Me.dgvEmpresa)
            Me.Controls.Add(Me.gbTotal)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormConsultaFacturasVenta"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CONSULTA DE FACTURAS"
            Me.gbClienteGeneral.ResumeLayout(False)
            Me.gbClienteGeneral.PerformLayout()
            Me.gbTotal.ResumeLayout(False)
            Me.gbTotal.PerformLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.gbEstadoFactura.ResumeLayout(False)
            Me.gbEstadoFactura.PerformLayout()
            Me.gbTipoReporte.ResumeLayout(False)
            Me.gbTipoReporte.PerformLayout()
            CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.BUSQUEDA.ResumeLayout(False)
            Me.REPORTE.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbClienteGeneral As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents txtClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalACobrar As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtTotalRetencion As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtTotalFacturas As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtTotalIVA As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtTotalSubtotal As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents gbTotal As System.Windows.Forms.GroupBox
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents rbFacturasActivas As System.Windows.Forms.RadioButton
        Friend WithEvents rbFacturasAnuladas As System.Windows.Forms.RadioButton
        Friend WithEvents rbFacturasTodas As System.Windows.Forms.RadioButton
        Friend WithEvents gbEstadoFactura As System.Windows.Forms.GroupBox
        Friend WithEvents gbTipoReporte As System.Windows.Forms.GroupBox
        Friend WithEvents rbConsorcio As System.Windows.Forms.RadioButton
        Friend WithEvents rbPorCliente As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodo As System.Windows.Forms.RadioButton
        Friend WithEvents rbNroFactura As System.Windows.Forms.RadioButton
        Friend WithEvents rbConcepto As System.Windows.Forms.RadioButton
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtTotalNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents lblNroRegistros As System.Windows.Forms.Label
        Friend WithEvents dgvEmpresa As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnValidar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnSalir As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents REPORTEDEVENTASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ESTADÍSTICOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents BUSQUEDA As System.Windows.Forms.TabPage
        Friend WithEvents REPORTE As System.Windows.Forms.TabPage
        Friend WithEvents GENERARFACTURAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ofdSeleccionarArchivo As System.Windows.Forms.OpenFileDialog
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents btnFacturaPath As System.Windows.Forms.Button
        Friend WithEvents txtFacturaPath As System.Windows.Forms.TextBox
    End Class
End Namespace