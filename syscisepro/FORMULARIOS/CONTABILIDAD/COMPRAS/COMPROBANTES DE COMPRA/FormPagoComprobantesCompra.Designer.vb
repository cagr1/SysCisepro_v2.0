Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormPagoComprobantesCompra
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPagoComprobantesCompra))
            Me.gbNuevoPagoComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.lblidPagosComprobantePago = New System.Windows.Forms.Label()
            Me.lblNuevoSaldoComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblMontoPagoComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblSaldoAnteriorComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblNumeroPagoComprobanteCompra = New System.Windows.Forms.Label()
            Me.txtNuevoSaldoPagosComprobantesCompra = New System.Windows.Forms.TextBox()
            Me.txtMontoPagosComprobantesCompra = New System.Windows.Forms.TextBox()
            Me.txtAnteriorSaldoPagosComprobantesCompra = New System.Windows.Forms.TextBox()
            Me.txtNumeroPagosComrptobantesCompra = New System.Windows.Forms.TextBox()
            Me.lblSeparador1 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dgvPagosComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.gbDatosComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.lblTipoComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblFechaComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblNumeroComprobanteCompra = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.gbComprobanteRetencion = New System.Windows.Forms.GroupBox()
            Me.txtTotalComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.txtValorRetencionIVA = New System.Windows.Forms.TextBox()
            Me.txtValorRetencionFuente = New System.Windows.Forms.TextBox()
            Me.lblFechaComprobanteRetencion = New System.Windows.Forms.Label()
            Me.lblNumeroComprobanteRetencion = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.gbValoresComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.txtTotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblSubTotal = New System.Windows.Forms.Label()
            Me.lblTotalOrdenCompra = New System.Windows.Forms.Label()
            Me.txtIvaComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblIvaOrdenCompra = New System.Windows.Forms.Label()
            Me.lblDescuentoOrdenCompra = New System.Windows.Forms.Label()
            Me.txtSubtotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblSubtotal0OrdenCompra = New System.Windows.Forms.Label()
            Me.txtDescuento = New System.Windows.Forms.TextBox()
            Me.lblSubtotal12OrdenCompra = New System.Windows.Forms.Label()
            Me.txtSubtotal12 = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0 = New System.Windows.Forms.TextBox()
            Me.lblEstadoComprobanteCompra = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.dgvComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.gbNombreComercialProveedor = New System.Windows.Forms.GroupBox()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.dgvComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.dgvDetalleComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbNuevoPagoComprobanteCompra.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvPagosComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.gbDatosComprobanteCompra.SuspendLayout()
            Me.gbComprobanteRetencion.SuspendLayout()
            Me.gbValoresComprobanteCompra.SuspendLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbNombreComercialProveedor.SuspendLayout()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbNuevoPagoComprobanteCompra
            '
            Me.gbNuevoPagoComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbNuevoPagoComprobanteCompra.Controls.Add(Me.lblidPagosComprobantePago)
            Me.gbNuevoPagoComprobanteCompra.Controls.Add(Me.lblNuevoSaldoComprobanteCompra)
            Me.gbNuevoPagoComprobanteCompra.Controls.Add(Me.lblMontoPagoComprobanteCompra)
            Me.gbNuevoPagoComprobanteCompra.Controls.Add(Me.lblSaldoAnteriorComprobanteCompra)
            Me.gbNuevoPagoComprobanteCompra.Controls.Add(Me.lblNumeroPagoComprobanteCompra)
            Me.gbNuevoPagoComprobanteCompra.Controls.Add(Me.txtNuevoSaldoPagosComprobantesCompra)
            Me.gbNuevoPagoComprobanteCompra.Controls.Add(Me.txtMontoPagosComprobantesCompra)
            Me.gbNuevoPagoComprobanteCompra.Controls.Add(Me.txtAnteriorSaldoPagosComprobantesCompra)
            Me.gbNuevoPagoComprobanteCompra.Controls.Add(Me.txtNumeroPagosComrptobantesCompra)
            Me.gbNuevoPagoComprobanteCompra.Controls.Add(Me.lblSeparador1)
            Me.gbNuevoPagoComprobanteCompra.Controls.Add(Me.Label1)
            Me.gbNuevoPagoComprobanteCompra.Controls.Add(Me.Label2)
            Me.gbNuevoPagoComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNuevoPagoComprobanteCompra.Location = New System.Drawing.Point(812, 33)
            Me.gbNuevoPagoComprobanteCompra.Name = "gbNuevoPagoComprobanteCompra"
            Me.gbNuevoPagoComprobanteCompra.Size = New System.Drawing.Size(305, 168)
            Me.gbNuevoPagoComprobanteCompra.TabIndex = 86
            Me.gbNuevoPagoComprobanteCompra.TabStop = False
            Me.gbNuevoPagoComprobanteCompra.Text = "NUEVO PAGO"
            '
            'lblidPagosComprobantePago
            '
            Me.lblidPagosComprobantePago.AutoSize = True
            Me.lblidPagosComprobantePago.Location = New System.Drawing.Point(89, -1)
            Me.lblidPagosComprobantePago.Name = "lblidPagosComprobantePago"
            Me.lblidPagosComprobantePago.Size = New System.Drawing.Size(16, 13)
            Me.lblidPagosComprobantePago.TabIndex = 61
            Me.lblidPagosComprobantePago.Text = "..."
            '
            'lblNuevoSaldoComprobanteCompra
            '
            Me.lblNuevoSaldoComprobanteCompra.AutoSize = True
            Me.lblNuevoSaldoComprobanteCompra.Location = New System.Drawing.Point(6, 141)
            Me.lblNuevoSaldoComprobanteCompra.Name = "lblNuevoSaldoComprobanteCompra"
            Me.lblNuevoSaldoComprobanteCompra.Size = New System.Drawing.Size(169, 13)
            Me.lblNuevoSaldoComprobanteCompra.TabIndex = 7
            Me.lblNuevoSaldoComprobanteCompra.Text = "NUEVO SALDO COMP. COMPRA:"
            '
            'lblMontoPagoComprobanteCompra
            '
            Me.lblMontoPagoComprobanteCompra.AutoSize = True
            Me.lblMontoPagoComprobanteCompra.Location = New System.Drawing.Point(6, 102)
            Me.lblMontoPagoComprobanteCompra.Name = "lblMontoPagoComprobanteCompra"
            Me.lblMontoPagoComprobanteCompra.Size = New System.Drawing.Size(184, 13)
            Me.lblMontoPagoComprobanteCompra.TabIndex = 6
            Me.lblMontoPagoComprobanteCompra.Text = "MONTO A PAGAR COMP. COMPRA:"
            '
            'lblSaldoAnteriorComprobanteCompra
            '
            Me.lblSaldoAnteriorComprobanteCompra.AutoSize = True
            Me.lblSaldoAnteriorComprobanteCompra.Location = New System.Drawing.Point(6, 64)
            Me.lblSaldoAnteriorComprobanteCompra.Name = "lblSaldoAnteriorComprobanteCompra"
            Me.lblSaldoAnteriorComprobanteCompra.Size = New System.Drawing.Size(186, 13)
            Me.lblSaldoAnteriorComprobanteCompra.TabIndex = 5
            Me.lblSaldoAnteriorComprobanteCompra.Text = "SALDO ANTERIOR COMP. COMPRA:"
            '
            'lblNumeroPagoComprobanteCompra
            '
            Me.lblNumeroPagoComprobanteCompra.AutoSize = True
            Me.lblNumeroPagoComprobanteCompra.Location = New System.Drawing.Point(6, 27)
            Me.lblNumeroPagoComprobanteCompra.Name = "lblNumeroPagoComprobanteCompra"
            Me.lblNumeroPagoComprobanteCompra.Size = New System.Drawing.Size(150, 13)
            Me.lblNumeroPagoComprobanteCompra.TabIndex = 4
            Me.lblNumeroPagoComprobanteCompra.Text = "NRO PAGO COMP. COMPRA:"
            '
            'txtNuevoSaldoPagosComprobantesCompra
            '
            Me.txtNuevoSaldoPagosComprobantesCompra.BackColor = System.Drawing.Color.White
            Me.txtNuevoSaldoPagosComprobantesCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNuevoSaldoPagosComprobantesCompra.Enabled = False
            Me.txtNuevoSaldoPagosComprobantesCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNuevoSaldoPagosComprobantesCompra.Location = New System.Drawing.Point(194, 138)
            Me.txtNuevoSaldoPagosComprobantesCompra.Name = "txtNuevoSaldoPagosComprobantesCompra"
            Me.txtNuevoSaldoPagosComprobantesCompra.Size = New System.Drawing.Size(102, 20)
            Me.txtNuevoSaldoPagosComprobantesCompra.TabIndex = 3
            Me.txtNuevoSaldoPagosComprobantesCompra.Text = "0.00"
            Me.txtNuevoSaldoPagosComprobantesCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtMontoPagosComprobantesCompra
            '
            Me.txtMontoPagosComprobantesCompra.BackColor = System.Drawing.Color.White
            Me.txtMontoPagosComprobantesCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMontoPagosComprobantesCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoPagosComprobantesCompra.Location = New System.Drawing.Point(194, 99)
            Me.txtMontoPagosComprobantesCompra.Name = "txtMontoPagosComprobantesCompra"
            Me.txtMontoPagosComprobantesCompra.Size = New System.Drawing.Size(102, 20)
            Me.txtMontoPagosComprobantesCompra.TabIndex = 2
            Me.txtMontoPagosComprobantesCompra.Text = "0.00"
            Me.txtMontoPagosComprobantesCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAnteriorSaldoPagosComprobantesCompra
            '
            Me.txtAnteriorSaldoPagosComprobantesCompra.BackColor = System.Drawing.Color.White
            Me.txtAnteriorSaldoPagosComprobantesCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtAnteriorSaldoPagosComprobantesCompra.Enabled = False
            Me.txtAnteriorSaldoPagosComprobantesCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAnteriorSaldoPagosComprobantesCompra.Location = New System.Drawing.Point(194, 61)
            Me.txtAnteriorSaldoPagosComprobantesCompra.Name = "txtAnteriorSaldoPagosComprobantesCompra"
            Me.txtAnteriorSaldoPagosComprobantesCompra.Size = New System.Drawing.Size(102, 20)
            Me.txtAnteriorSaldoPagosComprobantesCompra.TabIndex = 1
            Me.txtAnteriorSaldoPagosComprobantesCompra.Text = "0.00"
            Me.txtAnteriorSaldoPagosComprobantesCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNumeroPagosComrptobantesCompra
            '
            Me.txtNumeroPagosComrptobantesCompra.BackColor = System.Drawing.Color.White
            Me.txtNumeroPagosComrptobantesCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroPagosComrptobantesCompra.Enabled = False
            Me.txtNumeroPagosComrptobantesCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroPagosComrptobantesCompra.Location = New System.Drawing.Point(194, 24)
            Me.txtNumeroPagosComrptobantesCompra.Name = "txtNumeroPagosComrptobantesCompra"
            Me.txtNumeroPagosComrptobantesCompra.Size = New System.Drawing.Size(102, 20)
            Me.txtNumeroPagosComrptobantesCompra.TabIndex = 0
            Me.txtNumeroPagosComrptobantesCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSeparador1
            '
            Me.lblSeparador1.AutoSize = True
            Me.lblSeparador1.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.lblSeparador1.Location = New System.Drawing.Point(8, 41)
            Me.lblSeparador1.Name = "lblSeparador1"
            Me.lblSeparador1.Size = New System.Drawing.Size(242, 13)
            Me.lblSeparador1.TabIndex = 58
            Me.lblSeparador1.Text = "_______________________________________________"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.Label1.Location = New System.Drawing.Point(8, 78)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(242, 13)
            Me.Label1.TabIndex = 59
            Me.Label1.Text = "_______________________________________________"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.Label2.Location = New System.Drawing.Point(8, 117)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(242, 13)
            Me.Label2.TabIndex = 60
            Me.Label2.Text = "_______________________________________________"
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.dgvPagosComprobantesCompra)
            Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(812, 201)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(305, 389)
            Me.GroupBox2.TabIndex = 87
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "PAGOS POR COMPROBANTE"
            '
            'dgvPagosComprobantesCompra
            '
            Me.dgvPagosComprobantesCompra.AllowUserToAddRows = False
            Me.dgvPagosComprobantesCompra.AllowUserToDeleteRows = False
            Me.dgvPagosComprobantesCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvPagosComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvPagosComprobantesCompra.BackgroundColor = System.Drawing.Color.White
            Me.dgvPagosComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvPagosComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPagosComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvPagosComprobantesCompra.Location = New System.Drawing.Point(9, 20)
            Me.dgvPagosComprobantesCompra.MultiSelect = False
            Me.dgvPagosComprobantesCompra.Name = "dgvPagosComprobantesCompra"
            Me.dgvPagosComprobantesCompra.ReadOnly = True
            Me.dgvPagosComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvPagosComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvPagosComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPagosComprobantesCompra.Size = New System.Drawing.Size(286, 361)
            Me.dgvPagosComprobantesCompra.TabIndex = 0
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.gbDatosComprobanteCompra)
            Me.GroupBox1.Controls.Add(Me.gbComprobanteRetencion)
            Me.GroupBox1.Controls.Add(Me.gbValoresComprobanteCompra)
            Me.GroupBox1.Controls.Add(Me.lblEstadoComprobanteCompra)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.lblIdComprobanteCompra)
            Me.GroupBox1.Controls.Add(Me.dgvComprobantesCompra)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(1, 97)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(811, 495)
            Me.GroupBox1.TabIndex = 88
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "COMPROBANTES DE COMPRA"
            '
            'gbDatosComprobanteCompra
            '
            Me.gbDatosComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblTipoComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblFechaComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblNumeroComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label27)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label28)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label30)
            Me.gbDatosComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatosComprobanteCompra.Location = New System.Drawing.Point(9, 14)
            Me.gbDatosComprobanteCompra.Name = "gbDatosComprobanteCompra"
            Me.gbDatosComprobanteCompra.Size = New System.Drawing.Size(170, 83)
            Me.gbDatosComprobanteCompra.TabIndex = 93
            Me.gbDatosComprobanteCompra.TabStop = False
            Me.gbDatosComprobanteCompra.Text = "Datos"
            '
            'lblTipoComprobanteCompra
            '
            Me.lblTipoComprobanteCompra.AutoSize = True
            Me.lblTipoComprobanteCompra.Location = New System.Drawing.Point(55, 52)
            Me.lblTipoComprobanteCompra.Name = "lblTipoComprobanteCompra"
            Me.lblTipoComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblTipoComprobanteCompra.TabIndex = 25
            Me.lblTipoComprobanteCompra.Text = "..."
            Me.lblTipoComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblFechaComprobanteCompra
            '
            Me.lblFechaComprobanteCompra.AutoSize = True
            Me.lblFechaComprobanteCompra.Location = New System.Drawing.Point(55, 34)
            Me.lblFechaComprobanteCompra.Name = "lblFechaComprobanteCompra"
            Me.lblFechaComprobanteCompra.Size = New System.Drawing.Size(65, 13)
            Me.lblFechaComprobanteCompra.TabIndex = 23
            Me.lblFechaComprobanteCompra.Text = "00/00/0000"
            Me.lblFechaComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNumeroComprobanteCompra
            '
            Me.lblNumeroComprobanteCompra.AutoSize = True
            Me.lblNumeroComprobanteCompra.Location = New System.Drawing.Point(55, 16)
            Me.lblNumeroComprobanteCompra.Name = "lblNumeroComprobanteCompra"
            Me.lblNumeroComprobanteCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroComprobanteCompra.TabIndex = 21
            Me.lblNumeroComprobanteCompra.Text = "0"
            Me.lblNumeroComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label27.Location = New System.Drawing.Point(6, 52)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(37, 13)
            Me.Label27.TabIndex = 13
            Me.Label27.Text = "Tipo:"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.Location = New System.Drawing.Point(6, 34)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(43, 13)
            Me.Label28.TabIndex = 12
            Me.Label28.Text = "Fecha:"
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(6, 16)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(31, 13)
            Me.Label30.TabIndex = 10
            Me.Label30.Text = "Nro:"
            '
            'gbComprobanteRetencion
            '
            Me.gbComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.gbComprobanteRetencion.Controls.Add(Me.txtTotalComprobanteRetencion)
            Me.gbComprobanteRetencion.Controls.Add(Me.txtValorRetencionIVA)
            Me.gbComprobanteRetencion.Controls.Add(Me.txtValorRetencionFuente)
            Me.gbComprobanteRetencion.Controls.Add(Me.lblFechaComprobanteRetencion)
            Me.gbComprobanteRetencion.Controls.Add(Me.lblNumeroComprobanteRetencion)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label13)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label14)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label16)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label17)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label18)
            Me.gbComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComprobanteRetencion.Location = New System.Drawing.Point(492, 14)
            Me.gbComprobanteRetencion.Name = "gbComprobanteRetencion"
            Me.gbComprobanteRetencion.Size = New System.Drawing.Size(311, 83)
            Me.gbComprobanteRetencion.TabIndex = 93
            Me.gbComprobanteRetencion.TabStop = False
            Me.gbComprobanteRetencion.Text = "Retención"
            '
            'txtTotalComprobanteRetencion
            '
            Me.txtTotalComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteRetencion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalComprobanteRetencion.Enabled = False
            Me.txtTotalComprobanteRetencion.Location = New System.Drawing.Point(234, 52)
            Me.txtTotalComprobanteRetencion.Name = "txtTotalComprobanteRetencion"
            Me.txtTotalComprobanteRetencion.Size = New System.Drawing.Size(56, 14)
            Me.txtTotalComprobanteRetencion.TabIndex = 35
            Me.txtTotalComprobanteRetencion.Text = "0.00"
            Me.txtTotalComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtValorRetencionIVA
            '
            Me.txtValorRetencionIVA.BackColor = System.Drawing.Color.White
            Me.txtValorRetencionIVA.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtValorRetencionIVA.Enabled = False
            Me.txtValorRetencionIVA.Location = New System.Drawing.Point(234, 34)
            Me.txtValorRetencionIVA.Name = "txtValorRetencionIVA"
            Me.txtValorRetencionIVA.Size = New System.Drawing.Size(56, 14)
            Me.txtValorRetencionIVA.TabIndex = 34
            Me.txtValorRetencionIVA.Text = "0.00"
            Me.txtValorRetencionIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtValorRetencionFuente
            '
            Me.txtValorRetencionFuente.BackColor = System.Drawing.Color.White
            Me.txtValorRetencionFuente.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtValorRetencionFuente.Enabled = False
            Me.txtValorRetencionFuente.Location = New System.Drawing.Point(234, 16)
            Me.txtValorRetencionFuente.Name = "txtValorRetencionFuente"
            Me.txtValorRetencionFuente.Size = New System.Drawing.Size(56, 14)
            Me.txtValorRetencionFuente.TabIndex = 33
            Me.txtValorRetencionFuente.Text = "0.00"
            Me.txtValorRetencionFuente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFechaComprobanteRetencion
            '
            Me.lblFechaComprobanteRetencion.AutoSize = True
            Me.lblFechaComprobanteRetencion.Enabled = False
            Me.lblFechaComprobanteRetencion.Location = New System.Drawing.Point(48, 34)
            Me.lblFechaComprobanteRetencion.Name = "lblFechaComprobanteRetencion"
            Me.lblFechaComprobanteRetencion.Size = New System.Drawing.Size(65, 13)
            Me.lblFechaComprobanteRetencion.TabIndex = 23
            Me.lblFechaComprobanteRetencion.Text = "00/00/0000"
            Me.lblFechaComprobanteRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNumeroComprobanteRetencion
            '
            Me.lblNumeroComprobanteRetencion.AutoSize = True
            Me.lblNumeroComprobanteRetencion.Enabled = False
            Me.lblNumeroComprobanteRetencion.Location = New System.Drawing.Point(48, 16)
            Me.lblNumeroComprobanteRetencion.Name = "lblNumeroComprobanteRetencion"
            Me.lblNumeroComprobanteRetencion.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroComprobanteRetencion.TabIndex = 21
            Me.lblNumeroComprobanteRetencion.Text = "0"
            Me.lblNumeroComprobanteRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(162, 35)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(55, 13)
            Me.Label13.TabIndex = 20
            Me.Label13.Text = "Ret IVA:"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(162, 52)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(43, 13)
            Me.Label14.TabIndex = 14
            Me.Label14.Text = "TOTAL:"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New System.Drawing.Point(7, 34)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(43, 13)
            Me.Label16.TabIndex = 12
            Me.Label16.Text = "Fecha:"
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(162, 16)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(73, 13)
            Me.Label17.TabIndex = 11
            Me.Label17.Text = "Ret Fuente:"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(7, 16)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(31, 13)
            Me.Label18.TabIndex = 10
            Me.Label18.Text = "Nro:"
            '
            'gbValoresComprobanteCompra
            '
            Me.gbValoresComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtTotalComprobanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubTotal)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblTotalOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtIvaComprobanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblIvaOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblDescuentoOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotalComprobanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal0OrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtDescuento)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal12OrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal12)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal0)
            Me.gbValoresComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbValoresComprobanteCompra.Location = New System.Drawing.Point(180, 14)
            Me.gbValoresComprobanteCompra.Name = "gbValoresComprobanteCompra"
            Me.gbValoresComprobanteCompra.Size = New System.Drawing.Size(311, 83)
            Me.gbValoresComprobanteCompra.TabIndex = 92
            Me.gbValoresComprobanteCompra.TabStop = False
            Me.gbValoresComprobanteCompra.Text = "Valores"
            '
            'txtTotalComprobanteCompra
            '
            Me.txtTotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalComprobanteCompra.Enabled = False
            Me.txtTotalComprobanteCompra.Location = New System.Drawing.Point(232, 52)
            Me.txtTotalComprobanteCompra.Name = "txtTotalComprobanteCompra"
            Me.txtTotalComprobanteCompra.Size = New System.Drawing.Size(59, 14)
            Me.txtTotalComprobanteCompra.TabIndex = 32
            Me.txtTotalComprobanteCompra.Text = "0.00"
            Me.txtTotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubTotal
            '
            Me.lblSubTotal.AutoSize = True
            Me.lblSubTotal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotal.Location = New System.Drawing.Point(168, 17)
            Me.lblSubTotal.Name = "lblSubTotal"
            Me.lblSubTotal.Size = New System.Drawing.Size(67, 13)
            Me.lblSubTotal.TabIndex = 20
            Me.lblSubTotal.Text = "SUB TOTAL:"
            '
            'lblTotalOrdenCompra
            '
            Me.lblTotalOrdenCompra.AutoSize = True
            Me.lblTotalOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalOrdenCompra.Location = New System.Drawing.Point(168, 52)
            Me.lblTotalOrdenCompra.Name = "lblTotalOrdenCompra"
            Me.lblTotalOrdenCompra.Size = New System.Drawing.Size(43, 13)
            Me.lblTotalOrdenCompra.TabIndex = 14
            Me.lblTotalOrdenCompra.Text = "TOTAL:"
            '
            'txtIvaComprobanteCompra
            '
            Me.txtIvaComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtIvaComprobanteCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtIvaComprobanteCompra.Enabled = False
            Me.txtIvaComprobanteCompra.Location = New System.Drawing.Point(232, 34)
            Me.txtIvaComprobanteCompra.Name = "txtIvaComprobanteCompra"
            Me.txtIvaComprobanteCompra.Size = New System.Drawing.Size(59, 14)
            Me.txtIvaComprobanteCompra.TabIndex = 31
            Me.txtIvaComprobanteCompra.Text = "0.00"
            Me.txtIvaComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIvaOrdenCompra
            '
            Me.lblIvaOrdenCompra.AutoSize = True
            Me.lblIvaOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIvaOrdenCompra.Location = New System.Drawing.Point(168, 34)
            Me.lblIvaOrdenCompra.Name = "lblIvaOrdenCompra"
            Me.lblIvaOrdenCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblIvaOrdenCompra.TabIndex = 13
            Me.lblIvaOrdenCompra.Text = "IVA (12%):"
            '
            'lblDescuentoOrdenCompra
            '
            Me.lblDescuentoOrdenCompra.AutoSize = True
            Me.lblDescuentoOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescuentoOrdenCompra.Location = New System.Drawing.Point(6, 52)
            Me.lblDescuentoOrdenCompra.Name = "lblDescuentoOrdenCompra"
            Me.lblDescuentoOrdenCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblDescuentoOrdenCompra.TabIndex = 12
            Me.lblDescuentoOrdenCompra.Text = "DESCUENTO:"
            '
            'txtSubtotalComprobanteCompra
            '
            Me.txtSubtotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotalComprobanteCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotalComprobanteCompra.Enabled = False
            Me.txtSubtotalComprobanteCompra.Location = New System.Drawing.Point(232, 16)
            Me.txtSubtotalComprobanteCompra.Name = "txtSubtotalComprobanteCompra"
            Me.txtSubtotalComprobanteCompra.Size = New System.Drawing.Size(59, 14)
            Me.txtSubtotalComprobanteCompra.TabIndex = 30
            Me.txtSubtotalComprobanteCompra.Text = "0.00"
            Me.txtSubtotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal0OrdenCompra
            '
            Me.lblSubtotal0OrdenCompra.AutoSize = True
            Me.lblSubtotal0OrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal0OrdenCompra.Location = New System.Drawing.Point(6, 34)
            Me.lblSubtotal0OrdenCompra.Name = "lblSubtotal0OrdenCompra"
            Me.lblSubtotal0OrdenCompra.Size = New System.Drawing.Size(79, 13)
            Me.lblSubtotal0OrdenCompra.TabIndex = 11
            Me.lblSubtotal0OrdenCompra.Text = "SUB TOTAL 0:"
            '
            'txtDescuento
            '
            Me.txtDescuento.BackColor = System.Drawing.Color.White
            Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtDescuento.Enabled = False
            Me.txtDescuento.Location = New System.Drawing.Point(91, 52)
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.Size = New System.Drawing.Size(59, 14)
            Me.txtDescuento.TabIndex = 29
            Me.txtDescuento.Text = "0.00"
            Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal12OrdenCompra
            '
            Me.lblSubtotal12OrdenCompra.AutoSize = True
            Me.lblSubtotal12OrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal12OrdenCompra.Location = New System.Drawing.Point(6, 16)
            Me.lblSubtotal12OrdenCompra.Name = "lblSubtotal12OrdenCompra"
            Me.lblSubtotal12OrdenCompra.Size = New System.Drawing.Size(85, 13)
            Me.lblSubtotal12OrdenCompra.TabIndex = 10
            Me.lblSubtotal12OrdenCompra.Text = "SUB TOTAL 12:"
            '
            'txtSubtotal12
            '
            Me.txtSubtotal12.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal12.Enabled = False
            Me.txtSubtotal12.Location = New System.Drawing.Point(91, 16)
            Me.txtSubtotal12.Name = "txtSubtotal12"
            Me.txtSubtotal12.Size = New System.Drawing.Size(59, 14)
            Me.txtSubtotal12.TabIndex = 27
            Me.txtSubtotal12.Text = "0.00"
            Me.txtSubtotal12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0
            '
            Me.txtSubtotal0.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal0.Enabled = False
            Me.txtSubtotal0.Location = New System.Drawing.Point(91, 34)
            Me.txtSubtotal0.Name = "txtSubtotal0"
            Me.txtSubtotal0.Size = New System.Drawing.Size(59, 14)
            Me.txtSubtotal0.TabIndex = 28
            Me.txtSubtotal0.Text = "0.00"
            Me.txtSubtotal0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblEstadoComprobanteCompra
            '
            Me.lblEstadoComprobanteCompra.AutoSize = True
            Me.lblEstadoComprobanteCompra.Location = New System.Drawing.Point(230, 0)
            Me.lblEstadoComprobanteCompra.Name = "lblEstadoComprobanteCompra"
            Me.lblEstadoComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblEstadoComprobanteCompra.TabIndex = 94
            Me.lblEstadoComprobanteCompra.Text = "..."
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(211, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(12, 13)
            Me.Label6.TabIndex = 93
            Me.Label6.Text = "/"
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(177, 0)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteCompra.TabIndex = 29
            Me.lblIdComprobanteCompra.Text = "..."
            '
            'dgvComprobantesCompra
            '
            Me.dgvComprobantesCompra.AllowUserToAddRows = False
            Me.dgvComprobantesCompra.AllowUserToDeleteRows = False
            Me.dgvComprobantesCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvComprobantesCompra.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvComprobantesCompra.Location = New System.Drawing.Point(9, 97)
            Me.dgvComprobantesCompra.MultiSelect = False
            Me.dgvComprobantesCompra.Name = "dgvComprobantesCompra"
            Me.dgvComprobantesCompra.ReadOnly = True
            Me.dgvComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesCompra.Size = New System.Drawing.Size(794, 390)
            Me.dgvComprobantesCompra.TabIndex = 86
            '
            'gbNombreComercialProveedor
            '
            Me.gbNombreComercialProveedor.BackColor = System.Drawing.Color.White
            Me.gbNombreComercialProveedor.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblIdProveedorGeneral)
            Me.gbNombreComercialProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNombreComercialProveedor.Location = New System.Drawing.Point(1, 33)
            Me.gbNombreComercialProveedor.Name = "gbNombreComercialProveedor"
            Me.gbNombreComercialProveedor.Size = New System.Drawing.Size(811, 62)
            Me.gbNombreComercialProveedor.TabIndex = 90
            Me.gbNombreComercialProveedor.TabStop = False
            Me.gbNombreComercialProveedor.Text = "PROVEEDOR"
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(9, 25)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(794, 20)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 2
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(80, -1)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 76
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'dgvComprobanteRetencion
            '
            Me.dgvComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvComprobanteRetencion.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteRetencion.Location = New System.Drawing.Point(822, 398)
            Me.dgvComprobanteRetencion.Name = "dgvComprobanteRetencion"
            Me.dgvComprobanteRetencion.Size = New System.Drawing.Size(286, 61)
            Me.dgvComprobanteRetencion.TabIndex = 92
            '
            'dgvDetalleComprobanteRetencion
            '
            Me.dgvDetalleComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencion.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleComprobanteRetencion.Location = New System.Drawing.Point(822, 465)
            Me.dgvDetalleComprobanteRetencion.Name = "dgvDetalleComprobanteRetencion"
            Me.dgvDetalleComprobanteRetencion.Size = New System.Drawing.Size(286, 86)
            Me.dgvDetalleComprobanteRetencion.TabIndex = 93
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnModificar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1117, 32)
            Me.MenuStrip1.TabIndex = 188
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevo
            '
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(82, 28)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(95, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnModificar
            '
            Me.btnModificar.Enabled = False
            Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.edit_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(103, 28)
            Me.btnModificar.Text = "MODIFICAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(97, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'FormPagoComprobantesCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1117, 591)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbNombreComercialProveedor)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.gbNuevoPagoComprobanteCompra)
            Me.Controls.Add(Me.dgvDetalleComprobanteRetencion)
            Me.Controls.Add(Me.dgvComprobanteRetencion)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormPagoComprobantesCompra"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REGISTROS DE PAGOS DE COMPROBANTES DE COMPRA"
            Me.gbNuevoPagoComprobanteCompra.ResumeLayout(False)
            Me.gbNuevoPagoComprobanteCompra.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgvPagosComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbDatosComprobanteCompra.ResumeLayout(False)
            Me.gbDatosComprobanteCompra.PerformLayout()
            Me.gbComprobanteRetencion.ResumeLayout(False)
            Me.gbComprobanteRetencion.PerformLayout()
            Me.gbValoresComprobanteCompra.ResumeLayout(False)
            Me.gbValoresComprobanteCompra.PerformLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbNombreComercialProveedor.ResumeLayout(False)
            Me.gbNombreComercialProveedor.PerformLayout()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbNuevoPagoComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents txtMontoPagosComprobantesCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtAnteriorSaldoPagosComprobantesCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroPagosComrptobantesCompra As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents dgvPagosComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents dgvComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents lblNuevoSaldoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblMontoPagoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblSaldoAnteriorComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblNumeroPagoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents txtNuevoSaldoPagosComprobantesCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblSeparador1 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents gbNombreComercialProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents lblidPagosComprobantePago As System.Windows.Forms.Label
        Friend WithEvents lblEstadoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents gbValoresComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents lblSubTotal As System.Windows.Forms.Label
        Friend WithEvents lblTotalOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblIvaOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblDescuentoOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblSubtotal0OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblSubtotal12OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents gbComprobanteRetencion As System.Windows.Forms.GroupBox
        Friend WithEvents lblFechaComprobanteRetencion As System.Windows.Forms.Label
        Friend WithEvents lblNumeroComprobanteRetencion As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents gbDatosComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents lblTipoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblFechaComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblNumeroComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents txtTotalComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtValorRetencionIVA As System.Windows.Forms.TextBox
        Friend WithEvents txtValorRetencionFuente As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtIvaComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotalComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal12 As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0 As System.Windows.Forms.TextBox
        Friend WithEvents dgvComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace