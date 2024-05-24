Namespace FORMULARIOS.CONTABILIDAD.SRI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAnexoTransaccional
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnexoTransaccional))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.gpComandos = New System.Windows.Forms.GroupBox()
            Me.txtTotalVentas = New System.Windows.Forms.TextBox()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.dgvDetalleComprobanteRetencionVenta = New System.Windows.Forms.DataGridView()
            Me.dgvDetalleComprobanteRetencionCompra = New System.Windows.Forms.DataGridView()
            Me.dgvDatosAgrupadosVentas = New System.Windows.Forms.DataGridView()
            Me.TIPO_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NUMERO_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SUBTOTAL_0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SUBTOTAL_12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DESCUENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_RET_IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_RET_RENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvComprobanteRetencionCompra = New System.Windows.Forms.DataGridView()
            Me.dgvFacturasVenta = New System.Windows.Forms.DataGridView()
            Me.dgvComprobanteCompra = New System.Windows.Forms.DataGridView()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.lblHasta = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.btnCargar = New System.Windows.Forms.Button()
            Me.btnGenerarXML = New System.Windows.Forms.Button()
            Me.dgvAnexoCompras = New System.Windows.Forms.DataGridView()
            Me.panelDetalle = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtTotalValorRetenidoFuente = New System.Windows.Forms.TextBox()
            Me.dgvComprobantesAnulados = New System.Windows.Forms.DataGridView()
            Me.txtTotalBITarifa12Ventas = New System.Windows.Forms.TextBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtTotalValorRetenidoRetecioneEfectuaron = New System.Windows.Forms.TextBox()
            Me.txtTotalBINoIVAVentas = New System.Windows.Forms.TextBox()
            Me.txtTotalBITarifa0Compras = New System.Windows.Forms.TextBox()
            Me.dgvAnexoRetencionesEfectuaron = New System.Windows.Forms.DataGridView()
            Me.dgvAnexoRetencionesFuente = New System.Windows.Forms.DataGridView()
            Me.txtTotalValorIVACompras = New System.Windows.Forms.TextBox()
            Me.txtTotalBITarifa0Ventas = New System.Windows.Forms.TextBox()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtTotalBITarifa12Compras = New System.Windows.Forms.TextBox()
            Me.dgvAnexoRetencionIVA = New System.Windows.Forms.DataGridView()
            Me.OPERACION_RI = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CONCEPTO_RI = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_RETENIDO_RI = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtTotalValorRetenidoIVA = New System.Windows.Forms.TextBox()
            Me.txtTotalValorIVAVentas = New System.Windows.Forms.TextBox()
            Me.dgvAnexoVentas = New System.Windows.Forms.DataGridView()
            Me.TRANSACCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NRO_REGISTROS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.BI_TARIFA_0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.BI_TARIFA_12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtTotalBaseImponibleFuente = New System.Windows.Forms.TextBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.DetallE_ORDEN_COMPRATableAdapter1 = New syscisepro.DataSetOrdenCompraTableAdapters.DETALLE_ORDEN_COMPRATableAdapter()
            Me.gpComandos.SuspendLayout()
            CType(Me.dgvDetalleComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDatosAgrupadosVentas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvFacturasVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox5.SuspendLayout()
            CType(Me.dgvAnexoCompras, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelDetalle.SuspendLayout()
            CType(Me.dgvComprobantesAnulados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.Panel4.SuspendLayout()
            CType(Me.dgvAnexoRetencionesEfectuaron, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAnexoRetencionesFuente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel5.SuspendLayout()
            CType(Me.dgvAnexoRetencionIVA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAnexoVentas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'gpComandos
            '
            Me.gpComandos.BackColor = System.Drawing.Color.White
            Me.gpComandos.Controls.Add(Me.txtTotalVentas)
            Me.gpComandos.Controls.Add(Me.lblIdFacturaVenta)
            Me.gpComandos.Controls.Add(Me.lblIdComprobanteCompra)
            Me.gpComandos.Controls.Add(Me.dgvDetalleComprobanteRetencionVenta)
            Me.gpComandos.Controls.Add(Me.dgvDetalleComprobanteRetencionCompra)
            Me.gpComandos.Controls.Add(Me.dgvDatosAgrupadosVentas)
            Me.gpComandos.Controls.Add(Me.dgvComprobanteRetencionCompra)
            Me.gpComandos.Controls.Add(Me.dgvFacturasVenta)
            Me.gpComandos.Controls.Add(Me.dgvComprobanteCompra)
            Me.gpComandos.Controls.Add(Me.btnCancelar)
            Me.gpComandos.Controls.Add(Me.btnGuardar)
            Me.gpComandos.Controls.Add(Me.btnModificar)
            Me.gpComandos.Controls.Add(Me.btnNuevo)
            Me.gpComandos.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gpComandos.Location = New System.Drawing.Point(408, 2)
            Me.gpComandos.Name = "gpComandos"
            Me.gpComandos.Size = New System.Drawing.Size(816, 59)
            Me.gpComandos.TabIndex = 48
            Me.gpComandos.TabStop = False
            Me.gpComandos.Text = "COMANDOS"
            '
            'txtTotalVentas
            '
            Me.txtTotalVentas.Location = New System.Drawing.Point(745, 312)
            Me.txtTotalVentas.Name = "txtTotalVentas"
            Me.txtTotalVentas.Size = New System.Drawing.Size(60, 20)
            Me.txtTotalVentas.TabIndex = 63
            Me.txtTotalVentas.Text = "0,00"
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(428, 315)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(13, 13)
            Me.lblIdFacturaVenta.TabIndex = 62
            Me.lblIdFacturaVenta.Text = "0"
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(407, 315)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblIdComprobanteCompra.TabIndex = 61
            Me.lblIdComprobanteCompra.Text = "0"
            '
            'dgvDetalleComprobanteRetencionVenta
            '
            Me.dgvDetalleComprobanteRetencionVenta.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencionVenta.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobanteRetencionVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleComprobanteRetencionVenta.Location = New System.Drawing.Point(431, 330)
            Me.dgvDetalleComprobanteRetencionVenta.Name = "dgvDetalleComprobanteRetencionVenta"
            Me.dgvDetalleComprobanteRetencionVenta.ReadOnly = True
            Me.dgvDetalleComprobanteRetencionVenta.Size = New System.Drawing.Size(374, 76)
            Me.dgvDetalleComprobanteRetencionVenta.TabIndex = 60
            '
            'dgvDetalleComprobanteRetencionCompra
            '
            Me.dgvDetalleComprobanteRetencionCompra.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencionCompra.BackgroundColor = System.Drawing.SystemColors.Control
            Me.dgvDetalleComprobanteRetencionCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleComprobanteRetencionCompra.Location = New System.Drawing.Point(6, 433)
            Me.dgvDetalleComprobanteRetencionCompra.Name = "dgvDetalleComprobanteRetencionCompra"
            Me.dgvDetalleComprobanteRetencionCompra.Size = New System.Drawing.Size(414, 76)
            Me.dgvDetalleComprobanteRetencionCompra.TabIndex = 59
            '
            'dgvDatosAgrupadosVentas
            '
            Me.dgvDatosAgrupadosVentas.AllowUserToAddRows = False
            Me.dgvDatosAgrupadosVentas.AllowUserToDeleteRows = False
            Me.dgvDatosAgrupadosVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDatosAgrupadosVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPO_ID, Me.NUMERO_ID, Me.SUBTOTAL_0, Me.SUBTOTAL_12, Me.DESCUENTO, Me.SUBTOTAL, Me.IVA, Me.TOTAL, Me.VALOR_RET_IVA, Me.VALOR_RET_RENTA, Me.CANTIDAD})
            Me.dgvDatosAgrupadosVentas.Location = New System.Drawing.Point(431, 409)
            Me.dgvDatosAgrupadosVentas.Name = "dgvDatosAgrupadosVentas"
            Me.dgvDatosAgrupadosVentas.ReadOnly = True
            Me.dgvDatosAgrupadosVentas.Size = New System.Drawing.Size(374, 101)
            Me.dgvDatosAgrupadosVentas.TabIndex = 58
            '
            'TIPO_ID
            '
            Me.TIPO_ID.HeaderText = "TIPO_ID"
            Me.TIPO_ID.Name = "TIPO_ID"
            Me.TIPO_ID.ReadOnly = True
            '
            'NUMERO_ID
            '
            Me.NUMERO_ID.HeaderText = "NUMERO_ID"
            Me.NUMERO_ID.Name = "NUMERO_ID"
            Me.NUMERO_ID.ReadOnly = True
            '
            'SUBTOTAL_0
            '
            Me.SUBTOTAL_0.HeaderText = "SUBTOTAL_0"
            Me.SUBTOTAL_0.Name = "SUBTOTAL_0"
            Me.SUBTOTAL_0.ReadOnly = True
            '
            'SUBTOTAL_12
            '
            Me.SUBTOTAL_12.HeaderText = "SUBTOTAL_12"
            Me.SUBTOTAL_12.Name = "SUBTOTAL_12"
            Me.SUBTOTAL_12.ReadOnly = True
            '
            'DESCUENTO
            '
            Me.DESCUENTO.HeaderText = "DESCUENTO"
            Me.DESCUENTO.Name = "DESCUENTO"
            Me.DESCUENTO.ReadOnly = True
            '
            'SUBTOTAL
            '
            Me.SUBTOTAL.HeaderText = "SUBTOTAL"
            Me.SUBTOTAL.Name = "SUBTOTAL"
            Me.SUBTOTAL.ReadOnly = True
            '
            'IVA
            '
            Me.IVA.HeaderText = "IVA"
            Me.IVA.Name = "IVA"
            Me.IVA.ReadOnly = True
            '
            'TOTAL
            '
            Me.TOTAL.HeaderText = "TOTAL"
            Me.TOTAL.Name = "TOTAL"
            Me.TOTAL.ReadOnly = True
            '
            'VALOR_RET_IVA
            '
            Me.VALOR_RET_IVA.HeaderText = "VALOR_RET_IVA"
            Me.VALOR_RET_IVA.Name = "VALOR_RET_IVA"
            Me.VALOR_RET_IVA.ReadOnly = True
            '
            'VALOR_RET_RENTA
            '
            Me.VALOR_RET_RENTA.HeaderText = "VALOR_RET_RENTA"
            Me.VALOR_RET_RENTA.Name = "VALOR_RET_RENTA"
            Me.VALOR_RET_RENTA.ReadOnly = True
            '
            'CANTIDAD
            '
            Me.CANTIDAD.HeaderText = "CANTIDAD"
            Me.CANTIDAD.Name = "CANTIDAD"
            Me.CANTIDAD.ReadOnly = True
            '
            'dgvComprobanteRetencionCompra
            '
            Me.dgvComprobanteRetencionCompra.AllowUserToAddRows = False
            Me.dgvComprobanteRetencionCompra.BackgroundColor = System.Drawing.SystemColors.Control
            Me.dgvComprobanteRetencionCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteRetencionCompra.Location = New System.Drawing.Point(6, 330)
            Me.dgvComprobanteRetencionCompra.Name = "dgvComprobanteRetencionCompra"
            Me.dgvComprobanteRetencionCompra.Size = New System.Drawing.Size(414, 101)
            Me.dgvComprobanteRetencionCompra.TabIndex = 57
            '
            'dgvFacturasVenta
            '
            Me.dgvFacturasVenta.AllowUserToAddRows = False
            Me.dgvFacturasVenta.AllowUserToDeleteRows = False
            Me.dgvFacturasVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFacturasVenta.Location = New System.Drawing.Point(431, 64)
            Me.dgvFacturasVenta.Name = "dgvFacturasVenta"
            Me.dgvFacturasVenta.ReadOnly = True
            Me.dgvFacturasVenta.Size = New System.Drawing.Size(374, 248)
            Me.dgvFacturasVenta.TabIndex = 56
            '
            'dgvComprobanteCompra
            '
            Me.dgvComprobanteCompra.AllowUserToAddRows = False
            Me.dgvComprobanteCompra.BackgroundColor = System.Drawing.SystemColors.Control
            Me.dgvComprobanteCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteCompra.Location = New System.Drawing.Point(6, 64)
            Me.dgvComprobanteCompra.Name = "dgvComprobanteCompra"
            Me.dgvComprobanteCompra.Size = New System.Drawing.Size(414, 248)
            Me.dgvComprobanteCompra.TabIndex = 55
            '
            'btnCancelar
            '
            Me.btnCancelar.BackColor = System.Drawing.Color.White
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
            Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCancelar.Location = New System.Drawing.Point(691, 9)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(58, 43)
            Me.btnCancelar.TabIndex = 52
            Me.btnCancelar.Text = "CANCELAR"
            Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCancelar.UseVisualStyleBackColor = False
            '
            'btnGuardar
            '
            Me.btnGuardar.BackColor = System.Drawing.Color.White
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardar.Location = New System.Drawing.Point(748, 9)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(58, 43)
            Me.btnGuardar.TabIndex = 53
            Me.btnGuardar.Text = "GUARDAR"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = False
            '
            'btnModificar
            '
            Me.btnModificar.BackColor = System.Drawing.Color.White
            Me.btnModificar.Enabled = False
            Me.btnModificar.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
            Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnModificar.Location = New System.Drawing.Point(634, 9)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(58, 43)
            Me.btnModificar.TabIndex = 51
            Me.btnModificar.Text = "MODIFICAR"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnModificar.UseVisualStyleBackColor = False
            '
            'btnNuevo
            '
            Me.btnNuevo.BackColor = System.Drawing.Color.White
            Me.btnNuevo.Enabled = False
            Me.btnNuevo.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnNuevo.Location = New System.Drawing.Point(577, 9)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(58, 43)
            Me.btnNuevo.TabIndex = 50
            Me.btnNuevo.Text = "NUEVO"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNuevo.UseVisualStyleBackColor = False
            '
            'GroupBox5
            '
            Me.GroupBox5.BackColor = System.Drawing.Color.White
            Me.GroupBox5.Controls.Add(Me.dtpFechaDesde)
            Me.GroupBox5.Controls.Add(Me.lblHasta)
            Me.GroupBox5.Controls.Add(Me.dtpFechaHasta)
            Me.GroupBox5.Controls.Add(Me.btnCargar)
            Me.GroupBox5.Controls.Add(Me.btnGenerarXML)
            Me.GroupBox5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox5.Location = New System.Drawing.Point(1, 2)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(407, 59)
            Me.GroupBox5.TabIndex = 125
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "RANGO DE FECHAS"
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(13, 22)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(90, 20)
            Me.dtpFechaDesde.TabIndex = 9
            '
            'lblHasta
            '
            Me.lblHasta.AutoSize = True
            Me.lblHasta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHasta.Location = New System.Drawing.Point(109, 26)
            Me.lblHasta.Name = "lblHasta"
            Me.lblHasta.Size = New System.Drawing.Size(37, 13)
            Me.lblHasta.TabIndex = 11
            Me.lblHasta.Text = "HASTA"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(152, 22)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(90, 20)
            Me.dtpFechaHasta.TabIndex = 10
            '
            'btnCargar
            '
            Me.btnCargar.BackColor = System.Drawing.Color.White
            Me.btnCargar.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCargar.Image = CType(resources.GetObject("btnCargar.Image"), System.Drawing.Image)
            Me.btnCargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCargar.Location = New System.Drawing.Point(275, 9)
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(58, 43)
            Me.btnCargar.TabIndex = 55
            Me.btnCargar.Text = "CARGAR"
            Me.btnCargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCargar.UseVisualStyleBackColor = False
            '
            'btnGenerarXML
            '
            Me.btnGenerarXML.BackColor = System.Drawing.Color.White
            Me.btnGenerarXML.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGenerarXML.Image = CType(resources.GetObject("btnGenerarXML.Image"), System.Drawing.Image)
            Me.btnGenerarXML.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGenerarXML.Location = New System.Drawing.Point(332, 9)
            Me.btnGenerarXML.Name = "btnGenerarXML"
            Me.btnGenerarXML.Size = New System.Drawing.Size(58, 43)
            Me.btnGenerarXML.TabIndex = 56
            Me.btnGenerarXML.Text = "GENERAR XML"
            Me.btnGenerarXML.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGenerarXML.UseVisualStyleBackColor = False
            '
            'dgvAnexoCompras
            '
            Me.dgvAnexoCompras.AllowUserToAddRows = False
            Me.dgvAnexoCompras.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAnexoCompras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvAnexoCompras.BackgroundColor = System.Drawing.Color.White
            Me.dgvAnexoCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvAnexoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAnexoCompras.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvAnexoCompras.Location = New System.Drawing.Point(1, 90)
            Me.dgvAnexoCompras.Name = "dgvAnexoCompras"
            Me.dgvAnexoCompras.RowHeadersVisible = False
            Me.dgvAnexoCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAnexoCompras.Size = New System.Drawing.Size(610, 163)
            Me.dgvAnexoCompras.TabIndex = 158
            '
            'panelDetalle
            '
            Me.panelDetalle.BackColor = System.Drawing.Color.White
            Me.panelDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panelDetalle.Controls.Add(Me.Label1)
            Me.panelDetalle.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panelDetalle.Location = New System.Drawing.Point(1, 61)
            Me.panelDetalle.Name = "panelDetalle"
            Me.panelDetalle.Size = New System.Drawing.Size(610, 30)
            Me.panelDetalle.TabIndex = 170
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(258, 6)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 18)
            Me.Label1.TabIndex = 17
            Me.Label1.Text = "COMPRAS"
            '
            'txtTotalValorRetenidoFuente
            '
            Me.txtTotalValorRetenidoFuente.Location = New System.Drawing.Point(1127, 259)
            Me.txtTotalValorRetenidoFuente.Name = "txtTotalValorRetenidoFuente"
            Me.txtTotalValorRetenidoFuente.Size = New System.Drawing.Size(90, 20)
            Me.txtTotalValorRetenidoFuente.TabIndex = 160
            Me.txtTotalValorRetenidoFuente.Text = "0.00"
            Me.txtTotalValorRetenidoFuente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvComprobantesAnulados
            '
            Me.dgvComprobantesAnulados.AllowUserToAddRows = False
            Me.dgvComprobantesAnulados.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobantesAnulados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvComprobantesAnulados.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobantesAnulados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobantesAnulados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesAnulados.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvComprobantesAnulados.Location = New System.Drawing.Point(1, 464)
            Me.dgvComprobantesAnulados.Name = "dgvComprobantesAnulados"
            Me.dgvComprobantesAnulados.RowHeadersVisible = False
            Me.dgvComprobantesAnulados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesAnulados.Size = New System.Drawing.Size(610, 95)
            Me.dgvComprobantesAnulados.TabIndex = 180
            '
            'txtTotalBITarifa12Ventas
            '
            Me.txtTotalBITarifa12Ventas.Location = New System.Drawing.Point(302, 406)
            Me.txtTotalBITarifa12Ventas.Name = "txtTotalBITarifa12Ventas"
            Me.txtTotalBITarifa12Ventas.Size = New System.Drawing.Size(90, 20)
            Me.txtTotalBITarifa12Ventas.TabIndex = 166
            Me.txtTotalBITarifa12Ventas.Text = "0.00"
            Me.txtTotalBITarifa12Ventas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Location = New System.Drawing.Point(1, 281)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(610, 30)
            Me.Panel1.TabIndex = 171
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(261, 7)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(56, 18)
            Me.Label2.TabIndex = 18
            Me.Label2.Text = "VENTAS"
            '
            'Panel4
            '
            Me.Panel4.BackColor = System.Drawing.Color.White
            Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel4.Controls.Add(Me.Label5)
            Me.Panel4.Location = New System.Drawing.Point(614, 281)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(610, 30)
            Me.Panel4.TabIndex = 176
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(195, 6)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(248, 18)
            Me.Label5.TabIndex = 18
            Me.Label5.Text = "RETENCIÓN EN LA FUENTE DEL IVA"
            '
            'txtTotalValorRetenidoRetecioneEfectuaron
            '
            Me.txtTotalValorRetenidoRetecioneEfectuaron.Location = New System.Drawing.Point(1127, 560)
            Me.txtTotalValorRetenidoRetecioneEfectuaron.Name = "txtTotalValorRetenidoRetecioneEfectuaron"
            Me.txtTotalValorRetenidoRetecioneEfectuaron.Size = New System.Drawing.Size(90, 20)
            Me.txtTotalValorRetenidoRetecioneEfectuaron.TabIndex = 178
            Me.txtTotalValorRetenidoRetecioneEfectuaron.Text = "0.00"
            Me.txtTotalValorRetenidoRetecioneEfectuaron.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalBINoIVAVentas
            '
            Me.txtTotalBINoIVAVentas.Location = New System.Drawing.Point(408, 406)
            Me.txtTotalBINoIVAVentas.Name = "txtTotalBINoIVAVentas"
            Me.txtTotalBINoIVAVentas.Size = New System.Drawing.Size(90, 20)
            Me.txtTotalBINoIVAVentas.TabIndex = 163
            Me.txtTotalBINoIVAVentas.Text = "0.00"
            Me.txtTotalBINoIVAVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalBITarifa0Compras
            '
            Me.txtTotalBITarifa0Compras.Location = New System.Drawing.Point(301, 259)
            Me.txtTotalBITarifa0Compras.Name = "txtTotalBITarifa0Compras"
            Me.txtTotalBITarifa0Compras.Size = New System.Drawing.Size(90, 20)
            Me.txtTotalBITarifa0Compras.TabIndex = 169
            Me.txtTotalBITarifa0Compras.Text = "0.00"
            Me.txtTotalBITarifa0Compras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvAnexoRetencionesEfectuaron
            '
            Me.dgvAnexoRetencionesEfectuaron.AllowUserToAddRows = False
            Me.dgvAnexoRetencionesEfectuaron.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAnexoRetencionesEfectuaron.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvAnexoRetencionesEfectuaron.BackgroundColor = System.Drawing.Color.White
            Me.dgvAnexoRetencionesEfectuaron.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvAnexoRetencionesEfectuaron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAnexoRetencionesEfectuaron.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvAnexoRetencionesEfectuaron.Location = New System.Drawing.Point(614, 464)
            Me.dgvAnexoRetencionesEfectuaron.Name = "dgvAnexoRetencionesEfectuaron"
            Me.dgvAnexoRetencionesEfectuaron.RowHeadersVisible = False
            Me.dgvAnexoRetencionesEfectuaron.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAnexoRetencionesEfectuaron.Size = New System.Drawing.Size(610, 95)
            Me.dgvAnexoRetencionesEfectuaron.TabIndex = 177
            '
            'dgvAnexoRetencionesFuente
            '
            Me.dgvAnexoRetencionesFuente.AllowUserToAddRows = False
            Me.dgvAnexoRetencionesFuente.AllowUserToResizeRows = False
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAnexoRetencionesFuente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvAnexoRetencionesFuente.BackgroundColor = System.Drawing.Color.White
            Me.dgvAnexoRetencionesFuente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvAnexoRetencionesFuente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAnexoRetencionesFuente.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgvAnexoRetencionesFuente.Location = New System.Drawing.Point(614, 90)
            Me.dgvAnexoRetencionesFuente.Name = "dgvAnexoRetencionesFuente"
            Me.dgvAnexoRetencionesFuente.RowHeadersVisible = False
            Me.dgvAnexoRetencionesFuente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAnexoRetencionesFuente.Size = New System.Drawing.Size(610, 163)
            Me.dgvAnexoRetencionesFuente.TabIndex = 157
            '
            'txtTotalValorIVACompras
            '
            Me.txtTotalValorIVACompras.Location = New System.Drawing.Point(514, 259)
            Me.txtTotalValorIVACompras.Name = "txtTotalValorIVACompras"
            Me.txtTotalValorIVACompras.Size = New System.Drawing.Size(90, 20)
            Me.txtTotalValorIVACompras.TabIndex = 161
            Me.txtTotalValorIVACompras.Text = "0.00"
            Me.txtTotalValorIVACompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalBITarifa0Ventas
            '
            Me.txtTotalBITarifa0Ventas.Location = New System.Drawing.Point(196, 406)
            Me.txtTotalBITarifa0Ventas.Name = "txtTotalBITarifa0Ventas"
            Me.txtTotalBITarifa0Ventas.Size = New System.Drawing.Size(90, 20)
            Me.txtTotalBITarifa0Ventas.TabIndex = 168
            Me.txtTotalBITarifa0Ventas.Text = "0.00"
            Me.txtTotalBITarifa0Ventas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Panel5
            '
            Me.Panel5.BackColor = System.Drawing.Color.White
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.Label6)
            Me.Panel5.Location = New System.Drawing.Point(614, 435)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(610, 30)
            Me.Panel5.TabIndex = 179
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(94, 5)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(440, 18)
            Me.Label6.TabIndex = 18
            Me.Label6.Text = "RESUMEN DE RETENCIONES QUE LE EFECTUARON EN EL PERIODO"
            '
            'txtTotalBITarifa12Compras
            '
            Me.txtTotalBITarifa12Compras.Location = New System.Drawing.Point(407, 259)
            Me.txtTotalBITarifa12Compras.Name = "txtTotalBITarifa12Compras"
            Me.txtTotalBITarifa12Compras.Size = New System.Drawing.Size(90, 20)
            Me.txtTotalBITarifa12Compras.TabIndex = 167
            Me.txtTotalBITarifa12Compras.Text = "0.00"
            Me.txtTotalBITarifa12Compras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvAnexoRetencionIVA
            '
            Me.dgvAnexoRetencionIVA.AllowUserToAddRows = False
            Me.dgvAnexoRetencionIVA.AllowUserToResizeRows = False
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAnexoRetencionIVA.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvAnexoRetencionIVA.BackgroundColor = System.Drawing.Color.White
            Me.dgvAnexoRetencionIVA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvAnexoRetencionIVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAnexoRetencionIVA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OPERACION_RI, Me.CONCEPTO_RI, Me.VALOR_RETENIDO_RI})
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAnexoRetencionIVA.DefaultCellStyle = DataGridViewCellStyle11
            Me.dgvAnexoRetencionIVA.Location = New System.Drawing.Point(614, 310)
            Me.dgvAnexoRetencionIVA.Name = "dgvAnexoRetencionIVA"
            Me.dgvAnexoRetencionIVA.RowHeadersVisible = False
            Me.dgvAnexoRetencionIVA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAnexoRetencionIVA.Size = New System.Drawing.Size(610, 95)
            Me.dgvAnexoRetencionIVA.TabIndex = 174
            '
            'OPERACION_RI
            '
            Me.OPERACION_RI.HeaderText = "OPERACIÓN"
            Me.OPERACION_RI.Name = "OPERACION_RI"
            '
            'CONCEPTO_RI
            '
            Me.CONCEPTO_RI.HeaderText = "CONCEPTO"
            Me.CONCEPTO_RI.Name = "CONCEPTO_RI"
            '
            'VALOR_RETENIDO_RI
            '
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.VALOR_RETENIDO_RI.DefaultCellStyle = DataGridViewCellStyle10
            Me.VALOR_RETENIDO_RI.HeaderText = "VALOR RETENIDO"
            Me.VALOR_RETENIDO_RI.Name = "VALOR_RETENIDO_RI"
            '
            'txtTotalValorRetenidoIVA
            '
            Me.txtTotalValorRetenidoIVA.Location = New System.Drawing.Point(1127, 406)
            Me.txtTotalValorRetenidoIVA.Name = "txtTotalValorRetenidoIVA"
            Me.txtTotalValorRetenidoIVA.Size = New System.Drawing.Size(90, 20)
            Me.txtTotalValorRetenidoIVA.TabIndex = 175
            Me.txtTotalValorRetenidoIVA.Text = "0.00"
            Me.txtTotalValorRetenidoIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalValorIVAVentas
            '
            Me.txtTotalValorIVAVentas.Location = New System.Drawing.Point(514, 406)
            Me.txtTotalValorIVAVentas.Name = "txtTotalValorIVAVentas"
            Me.txtTotalValorIVAVentas.Size = New System.Drawing.Size(90, 20)
            Me.txtTotalValorIVAVentas.TabIndex = 162
            Me.txtTotalValorIVAVentas.Text = "0.00"
            Me.txtTotalValorIVAVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvAnexoVentas
            '
            Me.dgvAnexoVentas.AllowUserToAddRows = False
            Me.dgvAnexoVentas.AllowUserToResizeRows = False
            DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAnexoVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvAnexoVentas.BackgroundColor = System.Drawing.Color.White
            Me.dgvAnexoVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvAnexoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAnexoVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TRANSACCION, Me.NRO_REGISTROS, Me.BI_TARIFA_0, Me.BI_TARIFA_12, Me.VALOR_IVA})
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAnexoVentas.DefaultCellStyle = DataGridViewCellStyle16
            Me.dgvAnexoVentas.Location = New System.Drawing.Point(1, 310)
            Me.dgvAnexoVentas.Name = "dgvAnexoVentas"
            Me.dgvAnexoVentas.RowHeadersVisible = False
            Me.dgvAnexoVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAnexoVentas.Size = New System.Drawing.Size(610, 95)
            Me.dgvAnexoVentas.TabIndex = 159
            '
            'TRANSACCION
            '
            Me.TRANSACCION.HeaderText = "TRANSACCIÓN"
            Me.TRANSACCION.Name = "TRANSACCION"
            '
            'NRO_REGISTROS
            '
            Me.NRO_REGISTROS.HeaderText = "Nº REGISTROS"
            Me.NRO_REGISTROS.Name = "NRO_REGISTROS"
            '
            'BI_TARIFA_0
            '
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.BI_TARIFA_0.DefaultCellStyle = DataGridViewCellStyle13
            Me.BI_TARIFA_0.HeaderText = "BI TARIFA 0%"
            Me.BI_TARIFA_0.Name = "BI_TARIFA_0"
            '
            'BI_TARIFA_12
            '
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.BI_TARIFA_12.DefaultCellStyle = DataGridViewCellStyle14
            Me.BI_TARIFA_12.HeaderText = "BI TARIFA 12%"
            Me.BI_TARIFA_12.Name = "BI_TARIFA_12"
            '
            'VALOR_IVA
            '
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.VALOR_IVA.DefaultCellStyle = DataGridViewCellStyle15
            Me.VALOR_IVA.HeaderText = "VALOR IVA"
            Me.VALOR_IVA.Name = "VALOR_IVA"
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.White
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.Label3)
            Me.Panel2.Location = New System.Drawing.Point(1, 435)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(610, 30)
            Me.Panel2.TabIndex = 172
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(222, 5)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(176, 18)
            Me.Label3.TabIndex = 18
            Me.Label3.Text = "COMPROBANTES ANULADOS"
            '
            'txtTotalBaseImponibleFuente
            '
            Me.txtTotalBaseImponibleFuente.Location = New System.Drawing.Point(1021, 259)
            Me.txtTotalBaseImponibleFuente.Name = "txtTotalBaseImponibleFuente"
            Me.txtTotalBaseImponibleFuente.Size = New System.Drawing.Size(90, 20)
            Me.txtTotalBaseImponibleFuente.TabIndex = 164
            Me.txtTotalBaseImponibleFuente.Text = "0.00"
            Me.txtTotalBaseImponibleFuente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Panel3
            '
            Me.Panel3.BackColor = System.Drawing.Color.White
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.Label4)
            Me.Panel3.Location = New System.Drawing.Point(614, 61)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(610, 30)
            Me.Panel3.TabIndex = 173
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(116, 5)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(384, 18)
            Me.Label4.TabIndex = 18
            Me.Label4.Text = "RETENCIONES EN LA FUENTE DE IMPUESTO A LA RENTA"
            '
            'DetallE_ORDEN_COMPRATableAdapter1
            '
            Me.DetallE_ORDEN_COMPRATableAdapter1.ClearBeforeFill = True
            '
            'FormAnexoTransaccional
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1226, 584)
            Me.Controls.Add(Me.GroupBox5)
            Me.Controls.Add(Me.gpComandos)
            Me.Controls.Add(Me.dgvAnexoCompras)
            Me.Controls.Add(Me.panelDetalle)
            Me.Controls.Add(Me.txtTotalValorRetenidoFuente)
            Me.Controls.Add(Me.dgvComprobantesAnulados)
            Me.Controls.Add(Me.txtTotalBITarifa12Ventas)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Panel4)
            Me.Controls.Add(Me.txtTotalValorRetenidoRetecioneEfectuaron)
            Me.Controls.Add(Me.txtTotalBINoIVAVentas)
            Me.Controls.Add(Me.txtTotalBITarifa0Compras)
            Me.Controls.Add(Me.dgvAnexoRetencionesEfectuaron)
            Me.Controls.Add(Me.dgvAnexoRetencionesFuente)
            Me.Controls.Add(Me.txtTotalValorIVACompras)
            Me.Controls.Add(Me.txtTotalBITarifa0Ventas)
            Me.Controls.Add(Me.Panel5)
            Me.Controls.Add(Me.txtTotalBITarifa12Compras)
            Me.Controls.Add(Me.dgvAnexoRetencionIVA)
            Me.Controls.Add(Me.txtTotalValorRetenidoIVA)
            Me.Controls.Add(Me.txtTotalValorIVAVentas)
            Me.Controls.Add(Me.dgvAnexoVentas)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.txtTotalBaseImponibleFuente)
            Me.Controls.Add(Me.Panel3)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAnexoTransaccional"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "GENERAR ANEXO TRANSACCIONAL"
            Me.gpComandos.ResumeLayout(False)
            Me.gpComandos.PerformLayout()
            CType(Me.dgvDetalleComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDatosAgrupadosVentas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvFacturasVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            CType(Me.dgvAnexoCompras, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelDetalle.ResumeLayout(False)
            Me.panelDetalle.PerformLayout()
            CType(Me.dgvComprobantesAnulados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            CType(Me.dgvAnexoRetencionesEfectuaron, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAnexoRetencionesFuente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            CType(Me.dgvAnexoRetencionIVA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAnexoVentas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gpComandos As System.Windows.Forms.GroupBox
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblHasta As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnCargar As System.Windows.Forms.Button
        Friend WithEvents dgvDetalleComprobanteRetencionVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleComprobanteRetencionCompra As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDatosAgrupadosVentas As System.Windows.Forms.DataGridView
        Friend WithEvents dgvComprobanteRetencionCompra As System.Windows.Forms.DataGridView
        Friend WithEvents dgvFacturasVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dgvComprobanteCompra As System.Windows.Forms.DataGridView
        Friend WithEvents dgvAnexoCompras As System.Windows.Forms.DataGridView
        Friend WithEvents panelDetalle As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtTotalValorRetenidoFuente As System.Windows.Forms.TextBox
        Friend WithEvents dgvComprobantesAnulados As System.Windows.Forms.DataGridView
        Friend WithEvents txtTotalBITarifa12Ventas As System.Windows.Forms.TextBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtTotalValorRetenidoRetecioneEfectuaron As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalBINoIVAVentas As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalBITarifa0Compras As System.Windows.Forms.TextBox
        Friend WithEvents dgvAnexoRetencionesEfectuaron As System.Windows.Forms.DataGridView
        Friend WithEvents dgvAnexoRetencionesFuente As System.Windows.Forms.DataGridView
        Friend WithEvents txtTotalValorIVACompras As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalBITarifa0Ventas As System.Windows.Forms.TextBox
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtTotalBITarifa12Compras As System.Windows.Forms.TextBox
        Friend WithEvents dgvAnexoRetencionIVA As System.Windows.Forms.DataGridView
        Friend WithEvents txtTotalValorRetenidoIVA As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalValorIVAVentas As System.Windows.Forms.TextBox
        Friend WithEvents dgvAnexoVentas As System.Windows.Forms.DataGridView
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtTotalBaseImponibleFuente As System.Windows.Forms.TextBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents btnGenerarXML As System.Windows.Forms.Button
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents txtTotalVentas As System.Windows.Forms.TextBox
        Friend WithEvents OPERACION_RI As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CONCEPTO_RI As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR_RETENIDO_RI As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents TRANSACCION As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NRO_REGISTROS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents BI_TARIFA_0 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents BI_TARIFA_12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR_IVA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents TIPO_ID As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NUMERO_ID As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SUBTOTAL_0 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SUBTOTAL_12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DESCUENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SUBTOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IVA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR_RET_IVA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR_RET_RENTA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DetallE_ORDEN_COMPRATableAdapter1 As syscisepro.DataSetOrdenCompraTableAdapters.DETALLE_ORDEN_COMPRATableAdapter
    End Class
End Namespace