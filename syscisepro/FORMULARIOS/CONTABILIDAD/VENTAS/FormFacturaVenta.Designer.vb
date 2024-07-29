Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormFacturaVenta
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
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFacturaVenta))
            Me.gbValores = New System.Windows.Forms.GroupBox()
            Me.cmbIva = New System.Windows.Forms.ComboBox()
            Me.lblDescuentoOrdenCompra = New System.Windows.Forms.Label()
            Me.txtDescuento = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0 = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12 = New System.Windows.Forms.TextBox()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.txtSubTotal = New System.Windows.Forms.TextBox()
            Me.lblSubtotalIva = New System.Windows.Forms.Label()
            Me.lblSubTotal = New System.Windows.Forms.Label()
            Me.lblTotalOrdenCompra = New System.Windows.Forms.Label()
            Me.txtIva = New System.Windows.Forms.TextBox()
            Me.lblIva = New System.Windows.Forms.Label()
            Me.lblSubtotal0OrdenCompra = New System.Windows.Forms.Label()
            Me.gbNumeracion = New System.Windows.Forms.GroupBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.lblPtoEmisionFacturaEmpresa = New System.Windows.Forms.Label()
            Me.lblNroAutoSRIEmpresa = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.lblNumeroFacturaVenta = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.lblEstablecimientoFacturaEmpresa = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblRucEmpresa = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.gbCliente = New System.Windows.Forms.GroupBox()
            Me.cmbDirecciones = New System.Windows.Forms.ComboBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.lblRucCiCliente = New System.Windows.Forms.Label()
            Me.lblLlevaContabilidad = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtNombreComercialCliente = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtRucCiCliente = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.txtTelefonoClienteGeneral = New System.Windows.Forms.TextBox()
            Me.txtDireccionFacturacionCliente = New System.Windows.Forms.TextBox()
            Me.txtGuiaRemisionFacturaVenta = New System.Windows.Forms.TextBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.dtpFechaEmisionFacturaVenta = New System.Windows.Forms.DateTimePicker()
            Me.gbFecha = New System.Windows.Forms.GroupBox()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.panelDetalle = New System.Windows.Forms.Panel()
            Me.lblDetalleSolicitud = New System.Windows.Forms.Label()
            Me.dgvDetalleFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.eliminarItem = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.idItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nombreProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cantidadProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.valorUnitarioProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.valorTotalProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbEmpresa = New System.Windows.Forms.GroupBox()
            Me.txtDireccionEmpresa = New System.Windows.Forms.Label()
            Me.lblIdEmpresa = New System.Windows.Forms.Label()
            Me.lblNombreComercialEmpresa = New System.Windows.Forms.Label()
            Me.gbSon = New System.Windows.Forms.GroupBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtSon = New System.Windows.Forms.TextBox()
            Me.gbObservaciones = New System.Windows.Forms.GroupBox()
            Me.txtObservacionesFactura = New System.Windows.Forms.TextBox()
            Me.gbTipoPago = New System.Windows.Forms.GroupBox()
            Me.cmbTipoPagoFactura = New System.Windows.Forms.ComboBox()
            Me.lblCodigoFormasPago = New System.Windows.Forms.Label()
            Me.gbFormaPago = New System.Windows.Forms.GroupBox()
            Me.rbCredito = New System.Windows.Forms.RadioButton()
            Me.rbContado = New System.Windows.Forms.RadioButton()
            Me.gbConceptoFactura = New System.Windows.Forms.GroupBox()
            Me.lblCodigoCuentaConcepto = New System.Windows.Forms.Label()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.gbTipoAnbiente = New System.Windows.Forms.GroupBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.rbProduccion = New System.Windows.Forms.RadioButton()
            Me.rbPruebas = New System.Windows.Forms.RadioButton()
            Me.gbTipoEmision = New System.Windows.Forms.GroupBox()
            Me.rbTipoEmisionIndisponibilidadSistema = New System.Windows.Forms.RadioButton()
            Me.rbTipoEmisionNormal = New System.Windows.Forms.RadioButton()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.dgvAsientoDiarioFactura = New System.Windows.Forms.DataGridView()
            Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CONCEPTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DETALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DEBE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.HABER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.rbPtoEmision001 = New System.Windows.Forms.RadioButton()
            Me.rbPtoEmision002 = New System.Windows.Forms.RadioButton()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.gbPtoEmision = New System.Windows.Forms.GroupBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.cbxConvenio = New System.Windows.Forms.ComboBox()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCompEgreso = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.gbValores.SuspendLayout()
            Me.gbNumeracion.SuspendLayout()
            Me.gbCliente.SuspendLayout()
            Me.gbFecha.SuspendLayout()
            Me.panelDetalle.SuspendLayout()
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbEmpresa.SuspendLayout()
            Me.gbSon.SuspendLayout()
            Me.gbObservaciones.SuspendLayout()
            Me.gbTipoPago.SuspendLayout()
            Me.gbFormaPago.SuspendLayout()
            Me.gbConceptoFactura.SuspendLayout()
            Me.gbTipoAnbiente.SuspendLayout()
            Me.gbTipoEmision.SuspendLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            CType(Me.dgvAsientoDiarioFactura, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbPtoEmision.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbValores
            '
            Me.gbValores.BackColor = System.Drawing.Color.White
            Me.gbValores.Controls.Add(Me.cmbIva)
            Me.gbValores.Controls.Add(Me.lblDescuentoOrdenCompra)
            Me.gbValores.Controls.Add(Me.txtDescuento)
            Me.gbValores.Controls.Add(Me.txtSubtotal0)
            Me.gbValores.Controls.Add(Me.txtSubtotal12)
            Me.gbValores.Controls.Add(Me.txtTotal)
            Me.gbValores.Controls.Add(Me.txtSubTotal)
            Me.gbValores.Controls.Add(Me.lblSubtotalIva)
            Me.gbValores.Controls.Add(Me.lblSubTotal)
            Me.gbValores.Controls.Add(Me.lblTotalOrdenCompra)
            Me.gbValores.Controls.Add(Me.txtIva)
            Me.gbValores.Controls.Add(Me.lblIva)
            Me.gbValores.Controls.Add(Me.lblSubtotal0OrdenCompra)
            Me.gbValores.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbValores.Location = New System.Drawing.Point(609, 397)
            Me.gbValores.Name = "gbValores"
            Me.gbValores.Size = New System.Drawing.Size(180, 157)
            Me.gbValores.TabIndex = 71
            Me.gbValores.TabStop = False
            '
            'cmbIva
            '
            Me.cmbIva.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbIva.FormattingEnabled = True
            Me.cmbIva.Location = New System.Drawing.Point(13, 99)
            Me.cmbIva.Name = "cmbIva"
            Me.cmbIva.Size = New System.Drawing.Size(80, 21)
            Me.cmbIva.TabIndex = 22
            Me.cmbIva.Text = "IVA"
            '
            'lblDescuentoOrdenCompra
            '
            Me.lblDescuentoOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescuentoOrdenCompra.Location = New System.Drawing.Point(12, 49)
            Me.lblDescuentoOrdenCompra.Name = "lblDescuentoOrdenCompra"
            Me.lblDescuentoOrdenCompra.Size = New System.Drawing.Size(74, 17)
            Me.lblDescuentoOrdenCompra.TabIndex = 12
            Me.lblDescuentoOrdenCompra.Text = "DESCUENTO:"
            '
            'txtDescuento
            '
            Me.txtDescuento.BackColor = System.Drawing.Color.White
            Me.txtDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescuento.Enabled = False
            Me.txtDescuento.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuento.Location = New System.Drawing.Point(98, 43)
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.ReadOnly = True
            Me.txtDescuento.Size = New System.Drawing.Size(75, 23)
            Me.txtDescuento.TabIndex = 18
            Me.txtDescuento.Text = "0.00"
            Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0
            '
            Me.txtSubtotal0.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal0.Enabled = False
            Me.txtSubtotal0.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0.Location = New System.Drawing.Point(98, 43)
            Me.txtSubtotal0.Name = "txtSubtotal0"
            Me.txtSubtotal0.ReadOnly = True
            Me.txtSubtotal0.Size = New System.Drawing.Size(75, 23)
            Me.txtSubtotal0.TabIndex = 17
            Me.txtSubtotal0.Text = "0.00"
            Me.txtSubtotal0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtSubtotal0.Visible = False
            '
            'txtSubtotal12
            '
            Me.txtSubtotal12.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal12.Enabled = False
            Me.txtSubtotal12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12.Location = New System.Drawing.Point(98, 16)
            Me.txtSubtotal12.Name = "txtSubtotal12"
            Me.txtSubtotal12.ReadOnly = True
            Me.txtSubtotal12.Size = New System.Drawing.Size(75, 23)
            Me.txtSubtotal12.TabIndex = 16
            Me.txtSubtotal12.Text = "0.00"
            Me.txtSubtotal12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.White
            Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotal.Enabled = False
            Me.txtTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotal.Location = New System.Drawing.Point(98, 124)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.ReadOnly = True
            Me.txtTotal.Size = New System.Drawing.Size(75, 23)
            Me.txtTotal.TabIndex = 21
            Me.txtTotal.Text = "0.00"
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubTotal
            '
            Me.txtSubTotal.BackColor = System.Drawing.Color.White
            Me.txtSubTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubTotal.Enabled = False
            Me.txtSubTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotal.Location = New System.Drawing.Point(98, 70)
            Me.txtSubTotal.Name = "txtSubTotal"
            Me.txtSubTotal.ReadOnly = True
            Me.txtSubTotal.Size = New System.Drawing.Size(75, 23)
            Me.txtSubTotal.TabIndex = 19
            Me.txtSubTotal.Text = "0.00"
            Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotalIva
            '
            Me.lblSubtotalIva.AutoSize = True
            Me.lblSubtotalIva.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotalIva.Location = New System.Drawing.Point(10, 21)
            Me.lblSubtotalIva.Name = "lblSubtotalIva"
            Me.lblSubtotalIva.Size = New System.Drawing.Size(84, 13)
            Me.lblSubtotalIva.TabIndex = 10
            Me.lblSubtotalIva.Text = "SUB TOTAL 12:"
            '
            'lblSubTotal
            '
            Me.lblSubTotal.AutoSize = True
            Me.lblSubTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotal.Location = New System.Drawing.Point(10, 75)
            Me.lblSubTotal.Name = "lblSubTotal"
            Me.lblSubTotal.Size = New System.Drawing.Size(69, 13)
            Me.lblSubTotal.TabIndex = 20
            Me.lblSubTotal.Text = "SUB TOTAL:"
            '
            'lblTotalOrdenCompra
            '
            Me.lblTotalOrdenCompra.AutoSize = True
            Me.lblTotalOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalOrdenCompra.Location = New System.Drawing.Point(10, 129)
            Me.lblTotalOrdenCompra.Name = "lblTotalOrdenCompra"
            Me.lblTotalOrdenCompra.Size = New System.Drawing.Size(45, 13)
            Me.lblTotalOrdenCompra.TabIndex = 14
            Me.lblTotalOrdenCompra.Text = "TOTAL:"
            '
            'txtIva
            '
            Me.txtIva.BackColor = System.Drawing.Color.White
            Me.txtIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIva.Enabled = False
            Me.txtIva.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIva.Location = New System.Drawing.Point(98, 97)
            Me.txtIva.Name = "txtIva"
            Me.txtIva.ReadOnly = True
            Me.txtIva.Size = New System.Drawing.Size(75, 23)
            Me.txtIva.TabIndex = 20
            Me.txtIva.Text = "0.00"
            Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIva
            '
            Me.lblIva.AutoSize = True
            Me.lblIva.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIva.Location = New System.Drawing.Point(10, 102)
            Me.lblIva.Name = "lblIva"
            Me.lblIva.Size = New System.Drawing.Size(67, 13)
            Me.lblIva.TabIndex = 13
            Me.lblIva.Text = "IVA (12%):"
            '
            'lblSubtotal0OrdenCompra
            '
            Me.lblSubtotal0OrdenCompra.AutoSize = True
            Me.lblSubtotal0OrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal0OrdenCompra.Location = New System.Drawing.Point(11, 49)
            Me.lblSubtotal0OrdenCompra.Name = "lblSubtotal0OrdenCompra"
            Me.lblSubtotal0OrdenCompra.Size = New System.Drawing.Size(79, 13)
            Me.lblSubtotal0OrdenCompra.TabIndex = 11
            Me.lblSubtotal0OrdenCompra.Text = "SUB TOTAL 0:"
            Me.lblSubtotal0OrdenCompra.Visible = False
            '
            'gbNumeracion
            '
            Me.gbNumeracion.BackColor = System.Drawing.Color.White
            Me.gbNumeracion.Controls.Add(Me.Label17)
            Me.gbNumeracion.Controls.Add(Me.lblPtoEmisionFacturaEmpresa)
            Me.gbNumeracion.Controls.Add(Me.lblNroAutoSRIEmpresa)
            Me.gbNumeracion.Controls.Add(Me.Label9)
            Me.gbNumeracion.Controls.Add(Me.Label8)
            Me.gbNumeracion.Controls.Add(Me.lblNumeroFacturaVenta)
            Me.gbNumeracion.Controls.Add(Me.Label7)
            Me.gbNumeracion.Controls.Add(Me.lblEstablecimientoFacturaEmpresa)
            Me.gbNumeracion.Controls.Add(Me.Label5)
            Me.gbNumeracion.Controls.Add(Me.Label4)
            Me.gbNumeracion.Controls.Add(Me.lblRucEmpresa)
            Me.gbNumeracion.Controls.Add(Me.Label3)
            Me.gbNumeracion.Controls.Add(Me.Label2)
            Me.gbNumeracion.Controls.Add(Me.Label1)
            Me.gbNumeracion.Controls.Add(Me.Label6)
            Me.gbNumeracion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNumeracion.Location = New System.Drawing.Point(573, 67)
            Me.gbNumeracion.Name = "gbNumeracion"
            Me.gbNumeracion.Size = New System.Drawing.Size(216, 65)
            Me.gbNumeracion.TabIndex = 74
            Me.gbNumeracion.TabStop = False
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(168, 30)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(10, 13)
            Me.Label17.TabIndex = 14
            Me.Label17.Text = "-"
            '
            'lblPtoEmisionFacturaEmpresa
            '
            Me.lblPtoEmisionFacturaEmpresa.AutoSize = True
            Me.lblPtoEmisionFacturaEmpresa.Location = New System.Drawing.Point(141, 30)
            Me.lblPtoEmisionFacturaEmpresa.Name = "lblPtoEmisionFacturaEmpresa"
            Me.lblPtoEmisionFacturaEmpresa.Size = New System.Drawing.Size(16, 13)
            Me.lblPtoEmisionFacturaEmpresa.TabIndex = 13
            Me.lblPtoEmisionFacturaEmpresa.Text = "..."
            '
            'lblNroAutoSRIEmpresa
            '
            Me.lblNroAutoSRIEmpresa.AutoSize = True
            Me.lblNroAutoSRIEmpresa.Location = New System.Drawing.Point(140, 48)
            Me.lblNroAutoSRIEmpresa.Name = "lblNroAutoSRIEmpresa"
            Me.lblNroAutoSRIEmpresa.Size = New System.Drawing.Size(16, 13)
            Me.lblNroAutoSRIEmpresa.TabIndex = 12
            Me.lblNroAutoSRIEmpresa.Text = "..."
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(9, 48)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(53, 13)
            Me.Label9.TabIndex = 11
            Me.Label9.Text = "AUT. SRI:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(114, 47)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(10, 13)
            Me.Label8.TabIndex = 10
            Me.Label8.Text = "|"
            '
            'lblNumeroFacturaVenta
            '
            Me.lblNumeroFacturaVenta.AutoSize = True
            Me.lblNumeroFacturaVenta.Location = New System.Drawing.Point(184, 30)
            Me.lblNumeroFacturaVenta.Name = "lblNumeroFacturaVenta"
            Me.lblNumeroFacturaVenta.Size = New System.Drawing.Size(16, 13)
            Me.lblNumeroFacturaVenta.TabIndex = 9
            Me.lblNumeroFacturaVenta.Text = "..."
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(127, 30)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(10, 13)
            Me.Label7.TabIndex = 8
            Me.Label7.Text = "-"
            '
            'lblEstablecimientoFacturaEmpresa
            '
            Me.lblEstablecimientoFacturaEmpresa.AutoSize = True
            Me.lblEstablecimientoFacturaEmpresa.Location = New System.Drawing.Point(100, 30)
            Me.lblEstablecimientoFacturaEmpresa.Name = "lblEstablecimientoFacturaEmpresa"
            Me.lblEstablecimientoFacturaEmpresa.Size = New System.Drawing.Size(16, 13)
            Me.lblEstablecimientoFacturaEmpresa.TabIndex = 6
            Me.lblEstablecimientoFacturaEmpresa.Text = "..."
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(72, 30)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(23, 13)
            Me.Label5.TabIndex = 5
            Me.Label5.Text = "Nº."
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(9, 28)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(56, 15)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "FACTURA"
            '
            'lblRucEmpresa
            '
            Me.lblRucEmpresa.AutoSize = True
            Me.lblRucEmpresa.Location = New System.Drawing.Point(140, 11)
            Me.lblRucEmpresa.Name = "lblRucEmpresa"
            Me.lblRucEmpresa.Size = New System.Drawing.Size(16, 13)
            Me.lblRucEmpresa.TabIndex = 3
            Me.lblRucEmpresa.Text = "..."
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(9, 11)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(37, 13)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "R.U.C."
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(114, 11)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(10, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "|"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
            Me.Label1.Location = New System.Drawing.Point(23, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(182, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "___________________________________"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
            Me.Label6.Location = New System.Drawing.Point(23, 33)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(182, 13)
            Me.Label6.TabIndex = 7
            Me.Label6.Text = "___________________________________"
            '
            'gbCliente
            '
            Me.gbCliente.BackColor = System.Drawing.Color.White
            Me.gbCliente.Controls.Add(Me.cmbDirecciones)
            Me.gbCliente.Controls.Add(Me.Label14)
            Me.gbCliente.Controls.Add(Me.lblRucCiCliente)
            Me.gbCliente.Controls.Add(Me.lblLlevaContabilidad)
            Me.gbCliente.Controls.Add(Me.Label16)
            Me.gbCliente.Controls.Add(Me.Label11)
            Me.gbCliente.Controls.Add(Me.txtNombreComercialCliente)
            Me.gbCliente.Controls.Add(Me.Label10)
            Me.gbCliente.Controls.Add(Me.txtRucCiCliente)
            Me.gbCliente.Controls.Add(Me.lblIdClienteGeneral)
            Me.gbCliente.Controls.Add(Me.txtTelefonoClienteGeneral)
            Me.gbCliente.Controls.Add(Me.txtDireccionFacturacionCliente)
            Me.gbCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbCliente.Location = New System.Drawing.Point(1, 129)
            Me.gbCliente.Name = "gbCliente"
            Me.gbCliente.Size = New System.Drawing.Size(598, 70)
            Me.gbCliente.TabIndex = 75
            Me.gbCliente.TabStop = False
            '
            'cmbDirecciones
            '
            Me.cmbDirecciones.BackColor = System.Drawing.Color.White
            Me.cmbDirecciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbDirecciones.DropDownWidth = 450
            Me.cmbDirecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbDirecciones.FormattingEnabled = True
            Me.cmbDirecciones.Location = New System.Drawing.Point(50, 41)
            Me.cmbDirecciones.Name = "cmbDirecciones"
            Me.cmbDirecciones.Size = New System.Drawing.Size(542, 21)
            Me.cmbDirecciones.TabIndex = 13
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(4, 48)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(40, 13)
            Me.Label14.TabIndex = 12
            Me.Label14.Text = "DIREC:"
            '
            'lblRucCiCliente
            '
            Me.lblRucCiCliente.AutoSize = True
            Me.lblRucCiCliente.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRucCiCliente.Location = New System.Drawing.Point(343, 4)
            Me.lblRucCiCliente.Name = "lblRucCiCliente"
            Me.lblRucCiCliente.Size = New System.Drawing.Size(25, 13)
            Me.lblRucCiCliente.TabIndex = 11
            Me.lblRucCiCliente.Text = "..."
            '
            'lblLlevaContabilidad
            '
            Me.lblLlevaContabilidad.AutoSize = True
            Me.lblLlevaContabilidad.Location = New System.Drawing.Point(132, 4)
            Me.lblLlevaContabilidad.Name = "lblLlevaContabilidad"
            Me.lblLlevaContabilidad.Size = New System.Drawing.Size(16, 13)
            Me.lblLlevaContabilidad.TabIndex = 10
            Me.lblLlevaContabilidad.Text = "..."
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(5, 5)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(101, 13)
            Me.Label16.TabIndex = 9
            Me.Label16.Text = "Lleva Contabilidad:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(284, 4)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(46, 13)
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "RUC/CI:"
            '
            'txtNombreComercialCliente
            '
            Me.txtNombreComercialCliente.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialCliente.Location = New System.Drawing.Point(50, 19)
            Me.txtNombreComercialCliente.Name = "txtNombreComercialCliente"
            Me.txtNombreComercialCliente.Size = New System.Drawing.Size(542, 21)
            Me.txtNombreComercialCliente.TabIndex = 1
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(4, 22)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(45, 13)
            Me.Label10.TabIndex = 0
            Me.Label10.Text = "SR(ES):"
            '
            'txtRucCiCliente
            '
            Me.txtRucCiCliente.Location = New System.Drawing.Point(342, 19)
            Me.txtRucCiCliente.Name = "txtRucCiCliente"
            Me.txtRucCiCliente.Size = New System.Drawing.Size(110, 21)
            Me.txtRucCiCliente.TabIndex = 3
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(418, 24)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(13, 13)
            Me.lblIdClienteGeneral.TabIndex = 8
            Me.lblIdClienteGeneral.Text = "0"
            '
            'txtTelefonoClienteGeneral
            '
            Me.txtTelefonoClienteGeneral.Location = New System.Drawing.Point(399, 19)
            Me.txtTelefonoClienteGeneral.Name = "txtTelefonoClienteGeneral"
            Me.txtTelefonoClienteGeneral.ReadOnly = True
            Me.txtTelefonoClienteGeneral.Size = New System.Drawing.Size(110, 21)
            Me.txtTelefonoClienteGeneral.TabIndex = 7
            '
            'txtDireccionFacturacionCliente
            '
            Me.txtDireccionFacturacionCliente.Location = New System.Drawing.Point(50, 19)
            Me.txtDireccionFacturacionCliente.Name = "txtDireccionFacturacionCliente"
            Me.txtDireccionFacturacionCliente.ReadOnly = True
            Me.txtDireccionFacturacionCliente.Size = New System.Drawing.Size(282, 21)
            Me.txtDireccionFacturacionCliente.TabIndex = 5
            '
            'txtGuiaRemisionFacturaVenta
            '
            Me.txtGuiaRemisionFacturaVenta.Location = New System.Drawing.Point(19, 41)
            Me.txtGuiaRemisionFacturaVenta.Name = "txtGuiaRemisionFacturaVenta"
            Me.txtGuiaRemisionFacturaVenta.Size = New System.Drawing.Size(132, 20)
            Me.txtGuiaRemisionFacturaVenta.TabIndex = 9
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(11, 21)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(91, 13)
            Me.Label15.TabIndex = 10
            Me.Label15.Text = "FECHA EMISIÓN:"
            '
            'dtpFechaEmisionFacturaVenta
            '
            Me.dtpFechaEmisionFacturaVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionFacturaVenta.Location = New System.Drawing.Point(10, 41)
            Me.dtpFechaEmisionFacturaVenta.Name = "dtpFechaEmisionFacturaVenta"
            Me.dtpFechaEmisionFacturaVenta.Size = New System.Drawing.Size(172, 20)
            Me.dtpFechaEmisionFacturaVenta.TabIndex = 11
            '
            'gbFecha
            '
            Me.gbFecha.BackColor = System.Drawing.Color.White
            Me.gbFecha.Controls.Add(Me.lblIdFacturaVenta)
            Me.gbFecha.Controls.Add(Me.Label15)
            Me.gbFecha.Controls.Add(Me.dtpFechaEmisionFacturaVenta)
            Me.gbFecha.Controls.Add(Me.txtGuiaRemisionFacturaVenta)
            Me.gbFecha.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFecha.Location = New System.Drawing.Point(600, 128)
            Me.gbFecha.Name = "gbFecha"
            Me.gbFecha.Size = New System.Drawing.Size(189, 70)
            Me.gbFecha.TabIndex = 76
            Me.gbFecha.TabStop = False
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(136, 4)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(25, 13)
            Me.lblIdFacturaVenta.TabIndex = 4
            Me.lblIdFacturaVenta.Text = "..."
            '
            'panelDetalle
            '
            Me.panelDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.panelDetalle.Controls.Add(Me.lblDetalleSolicitud)
            Me.panelDetalle.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panelDetalle.ForeColor = System.Drawing.Color.White
            Me.panelDetalle.Location = New System.Drawing.Point(1, 200)
            Me.panelDetalle.Name = "panelDetalle"
            Me.panelDetalle.Size = New System.Drawing.Size(788, 21)
            Me.panelDetalle.TabIndex = 78
            '
            'lblDetalleSolicitud
            '
            Me.lblDetalleSolicitud.AutoSize = True
            Me.lblDetalleSolicitud.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDetalleSolicitud.Location = New System.Drawing.Point(303, 2)
            Me.lblDetalleSolicitud.Name = "lblDetalleSolicitud"
            Me.lblDetalleSolicitud.Size = New System.Drawing.Size(152, 18)
            Me.lblDetalleSolicitud.TabIndex = 17
            Me.lblDetalleSolicitud.Text = "DETALLE DE FACTURA"
            '
            'dgvDetalleFacturaVenta
            '
            Me.dgvDetalleFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvDetalleFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDetalleFacturaVenta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
            Me.dgvDetalleFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvDetalleFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvDetalleFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleFacturaVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminarItem, Me.idItem, Me.nombreProductoServicio, Me.cantidadProductoServicio, Me.valorUnitarioProductoServicio, Me.descuento, Me.valorTotalProductoServicio})
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDetalleFacturaVenta.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvDetalleFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvDetalleFacturaVenta.GridColor = System.Drawing.Color.White
            Me.dgvDetalleFacturaVenta.Location = New System.Drawing.Point(2, 17)
            Me.dgvDetalleFacturaVenta.Name = "dgvDetalleFacturaVenta"
            Me.dgvDetalleFacturaVenta.RowHeadersVisible = False
            Me.dgvDetalleFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleFacturaVenta.Size = New System.Drawing.Size(785, 159)
            Me.dgvDetalleFacturaVenta.TabIndex = 79
            '
            'eliminarItem
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.Red
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
            Me.eliminarItem.DefaultCellStyle = DataGridViewCellStyle3
            Me.eliminarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.eliminarItem.HeaderText = "SUPR"
            Me.eliminarItem.Name = "eliminarItem"
            Me.eliminarItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.eliminarItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.eliminarItem.Text = "(X)"
            Me.eliminarItem.ToolTipText = "Eliminar Fila"
            Me.eliminarItem.UseColumnTextForButtonValue = True
            Me.eliminarItem.Width = 40
            '
            'idItem
            '
            Me.idItem.HeaderText = "ID"
            Me.idItem.Name = "idItem"
            Me.idItem.Width = 50
            '
            'nombreProductoServicio
            '
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.nombreProductoServicio.DefaultCellStyle = DataGridViewCellStyle4
            Me.nombreProductoServicio.HeaderText = "PRODUCTO/SERVICIO"
            Me.nombreProductoServicio.Name = "nombreProductoServicio"
            Me.nombreProductoServicio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.nombreProductoServicio.Width = 370
            '
            'cantidadProductoServicio
            '
            Me.cantidadProductoServicio.HeaderText = "CANT."
            Me.cantidadProductoServicio.Name = "cantidadProductoServicio"
            Me.cantidadProductoServicio.Width = 55
            '
            'valorUnitarioProductoServicio
            '
            Me.valorUnitarioProductoServicio.HeaderText = "V. UNITARIO"
            Me.valorUnitarioProductoServicio.Name = "valorUnitarioProductoServicio"
            Me.valorUnitarioProductoServicio.Width = 107
            '
            'descuento
            '
            Me.descuento.HeaderText = "DESC."
            Me.descuento.Name = "descuento"
            Me.descuento.Width = 90
            '
            'valorTotalProductoServicio
            '
            Me.valorTotalProductoServicio.HeaderText = "V. TOTAL"
            Me.valorTotalProductoServicio.Name = "valorTotalProductoServicio"
            Me.valorTotalProductoServicio.Width = 90
            '
            'gbEmpresa
            '
            Me.gbEmpresa.BackColor = System.Drawing.Color.White
            Me.gbEmpresa.Controls.Add(Me.txtDireccionEmpresa)
            Me.gbEmpresa.Controls.Add(Me.lblIdEmpresa)
            Me.gbEmpresa.Controls.Add(Me.lblNombreComercialEmpresa)
            Me.gbEmpresa.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEmpresa.Location = New System.Drawing.Point(1, 67)
            Me.gbEmpresa.Name = "gbEmpresa"
            Me.gbEmpresa.Size = New System.Drawing.Size(571, 65)
            Me.gbEmpresa.TabIndex = 80
            Me.gbEmpresa.TabStop = False
            '
            'txtDireccionEmpresa
            '
            Me.txtDireccionEmpresa.Location = New System.Drawing.Point(8, 32)
            Me.txtDireccionEmpresa.Name = "txtDireccionEmpresa"
            Me.txtDireccionEmpresa.Size = New System.Drawing.Size(557, 28)
            Me.txtDireccionEmpresa.TabIndex = 5
            Me.txtDireccionEmpresa.Text = "Dirección Empresa"
            Me.txtDireccionEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblIdEmpresa
            '
            Me.lblIdEmpresa.AutoSize = True
            Me.lblIdEmpresa.Location = New System.Drawing.Point(5, 0)
            Me.lblIdEmpresa.Name = "lblIdEmpresa"
            Me.lblIdEmpresa.Size = New System.Drawing.Size(16, 13)
            Me.lblIdEmpresa.TabIndex = 3
            Me.lblIdEmpresa.Text = "..."
            '
            'lblNombreComercialEmpresa
            '
            Me.lblNombreComercialEmpresa.AutoSize = True
            Me.lblNombreComercialEmpresa.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreComercialEmpresa.Location = New System.Drawing.Point(283, 13)
            Me.lblNombreComercialEmpresa.Name = "lblNombreComercialEmpresa"
            Me.lblNombreComercialEmpresa.Size = New System.Drawing.Size(21, 19)
            Me.lblNombreComercialEmpresa.TabIndex = 0
            Me.lblNombreComercialEmpresa.Text = "..."
            '
            'gbSon
            '
            Me.gbSon.BackColor = System.Drawing.Color.White
            Me.gbSon.Controls.Add(Me.Label12)
            Me.gbSon.Controls.Add(Me.txtSon)
            Me.gbSon.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbSon.Location = New System.Drawing.Point(1, 397)
            Me.gbSon.Name = "gbSon"
            Me.gbSon.Size = New System.Drawing.Size(607, 36)
            Me.gbSon.TabIndex = 85
            Me.gbSon.TabStop = False
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(8, 14)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(33, 13)
            Me.Label12.TabIndex = 2
            Me.Label12.Text = "SON:"
            '
            'txtSon
            '
            Me.txtSon.BackColor = System.Drawing.Color.White
            Me.txtSon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSon.Location = New System.Drawing.Point(45, 10)
            Me.txtSon.Name = "txtSon"
            Me.txtSon.ReadOnly = True
            Me.txtSon.Size = New System.Drawing.Size(556, 22)
            Me.txtSon.TabIndex = 1
            '
            'gbObservaciones
            '
            Me.gbObservaciones.BackColor = System.Drawing.Color.White
            Me.gbObservaciones.Controls.Add(Me.txtObservacionesFactura)
            Me.gbObservaciones.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbObservaciones.Location = New System.Drawing.Point(1, 512)
            Me.gbObservaciones.Name = "gbObservaciones"
            Me.gbObservaciones.Size = New System.Drawing.Size(607, 40)
            Me.gbObservaciones.TabIndex = 84
            Me.gbObservaciones.TabStop = False
            Me.gbObservaciones.Text = "OBSERVACIONES:"
            '
            'txtObservacionesFactura
            '
            Me.txtObservacionesFactura.BackColor = System.Drawing.Color.White
            Me.txtObservacionesFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionesFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacionesFactura.Location = New System.Drawing.Point(7, 14)
            Me.txtObservacionesFactura.Name = "txtObservacionesFactura"
            Me.txtObservacionesFactura.Size = New System.Drawing.Size(594, 20)
            Me.txtObservacionesFactura.TabIndex = 5
            '
            'gbTipoPago
            '
            Me.gbTipoPago.BackColor = System.Drawing.Color.White
            Me.gbTipoPago.Controls.Add(Me.cmbTipoPagoFactura)
            Me.gbTipoPago.Controls.Add(Me.lblCodigoFormasPago)
            Me.gbTipoPago.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoPago.Location = New System.Drawing.Point(83, 434)
            Me.gbTipoPago.Name = "gbTipoPago"
            Me.gbTipoPago.Size = New System.Drawing.Size(259, 40)
            Me.gbTipoPago.TabIndex = 83
            Me.gbTipoPago.TabStop = False
            Me.gbTipoPago.Text = "FORMAS DE PAGO:"
            '
            'cmbTipoPagoFactura
            '
            Me.cmbTipoPagoFactura.BackColor = System.Drawing.Color.White
            Me.cmbTipoPagoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoPagoFactura.DropDownWidth = 450
            Me.cmbTipoPagoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbTipoPagoFactura.FormattingEnabled = True
            Me.cmbTipoPagoFactura.Items.AddRange(New Object() {"EFECTIVO", "CHEQUE", "NOTA DE CRÉDITO"})
            Me.cmbTipoPagoFactura.Location = New System.Drawing.Point(11, 13)
            Me.cmbTipoPagoFactura.Name = "cmbTipoPagoFactura"
            Me.cmbTipoPagoFactura.Size = New System.Drawing.Size(232, 21)
            Me.cmbTipoPagoFactura.TabIndex = 2
            '
            'lblCodigoFormasPago
            '
            Me.lblCodigoFormasPago.AutoSize = True
            Me.lblCodigoFormasPago.Location = New System.Drawing.Point(108, 0)
            Me.lblCodigoFormasPago.Name = "lblCodigoFormasPago"
            Me.lblCodigoFormasPago.Size = New System.Drawing.Size(13, 13)
            Me.lblCodigoFormasPago.TabIndex = 3
            Me.lblCodigoFormasPago.Text = "0"
            '
            'gbFormaPago
            '
            Me.gbFormaPago.BackColor = System.Drawing.Color.White
            Me.gbFormaPago.Controls.Add(Me.rbCredito)
            Me.gbFormaPago.Controls.Add(Me.rbContado)
            Me.gbFormaPago.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFormaPago.Location = New System.Drawing.Point(1, 434)
            Me.gbFormaPago.Name = "gbFormaPago"
            Me.gbFormaPago.Size = New System.Drawing.Size(81, 77)
            Me.gbFormaPago.TabIndex = 82
            Me.gbFormaPago.TabStop = False
            Me.gbFormaPago.Text = "TIPO PAGO:"
            '
            'rbCredito
            '
            Me.rbCredito.AutoSize = True
            Me.rbCredito.Checked = True
            Me.rbCredito.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCredito.Location = New System.Drawing.Point(8, 48)
            Me.rbCredito.Name = "rbCredito"
            Me.rbCredito.Size = New System.Drawing.Size(58, 14)
            Me.rbCredito.TabIndex = 3
            Me.rbCredito.TabStop = True
            Me.rbCredito.Text = "CRÉDITO"
            Me.rbCredito.UseVisualStyleBackColor = True
            '
            'rbContado
            '
            Me.rbContado.AutoSize = True
            Me.rbContado.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbContado.Location = New System.Drawing.Point(8, 29)
            Me.rbContado.Name = "rbContado"
            Me.rbContado.Size = New System.Drawing.Size(58, 14)
            Me.rbContado.TabIndex = 2
            Me.rbContado.Text = "CONTADO"
            Me.rbContado.UseVisualStyleBackColor = True
            '
            'gbConceptoFactura
            '
            Me.gbConceptoFactura.BackColor = System.Drawing.Color.White
            Me.gbConceptoFactura.Controls.Add(Me.lblCodigoCuentaConcepto)
            Me.gbConceptoFactura.Controls.Add(Me.cmbConcepto)
            Me.gbConceptoFactura.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbConceptoFactura.Location = New System.Drawing.Point(343, 434)
            Me.gbConceptoFactura.Name = "gbConceptoFactura"
            Me.gbConceptoFactura.Size = New System.Drawing.Size(265, 40)
            Me.gbConceptoFactura.TabIndex = 86
            Me.gbConceptoFactura.TabStop = False
            Me.gbConceptoFactura.Text = "CONCEPTO:"
            '
            'lblCodigoCuentaConcepto
            '
            Me.lblCodigoCuentaConcepto.AutoSize = True
            Me.lblCodigoCuentaConcepto.Location = New System.Drawing.Point(79, 2)
            Me.lblCodigoCuentaConcepto.Name = "lblCodigoCuentaConcepto"
            Me.lblCodigoCuentaConcepto.Size = New System.Drawing.Size(16, 13)
            Me.lblCodigoCuentaConcepto.TabIndex = 1
            Me.lblCodigoCuentaConcepto.Text = "..."
            '
            'cmbConcepto
            '
            Me.cmbConcepto.BackColor = System.Drawing.Color.White
            Me.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbConcepto.DropDownWidth = 450
            Me.cmbConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.Location = New System.Drawing.Point(6, 16)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(253, 21)
            Me.cmbConcepto.TabIndex = 0
            '
            'gbTipoAnbiente
            '
            Me.gbTipoAnbiente.Controls.Add(Me.Label18)
            Me.gbTipoAnbiente.Controls.Add(Me.rbProduccion)
            Me.gbTipoAnbiente.Controls.Add(Me.rbPruebas)
            Me.gbTipoAnbiente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoAnbiente.Location = New System.Drawing.Point(290, 34)
            Me.gbTipoAnbiente.Name = "gbTipoAnbiente"
            Me.gbTipoAnbiente.Size = New System.Drawing.Size(291, 32)
            Me.gbTipoAnbiente.TabIndex = 87
            Me.gbTipoAnbiente.TabStop = False
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(22, 11)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(70, 15)
            Me.Label18.TabIndex = 15
            Me.Label18.Text = "AMBIENTE:"
            '
            'rbProduccion
            '
            Me.rbProduccion.AutoSize = True
            Me.rbProduccion.Checked = True
            Me.rbProduccion.Location = New System.Drawing.Point(179, 11)
            Me.rbProduccion.Name = "rbProduccion"
            Me.rbProduccion.Size = New System.Drawing.Size(94, 17)
            Me.rbProduccion.TabIndex = 1
            Me.rbProduccion.TabStop = True
            Me.rbProduccion.Text = "PRODUCCIÓN"
            Me.rbProduccion.UseVisualStyleBackColor = True
            '
            'rbPruebas
            '
            Me.rbPruebas.AutoSize = True
            Me.rbPruebas.Location = New System.Drawing.Point(103, 11)
            Me.rbPruebas.Name = "rbPruebas"
            Me.rbPruebas.Size = New System.Drawing.Size(73, 17)
            Me.rbPruebas.TabIndex = 0
            Me.rbPruebas.Text = "PRUEBAS"
            Me.rbPruebas.UseVisualStyleBackColor = True
            '
            'gbTipoEmision
            '
            Me.gbTipoEmision.Controls.Add(Me.rbTipoEmisionIndisponibilidadSistema)
            Me.gbTipoEmision.Controls.Add(Me.rbTipoEmisionNormal)
            Me.gbTipoEmision.Controls.Add(Me.Label20)
            Me.gbTipoEmision.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoEmision.Location = New System.Drawing.Point(585, 34)
            Me.gbTipoEmision.Name = "gbTipoEmision"
            Me.gbTipoEmision.Size = New System.Drawing.Size(364, 32)
            Me.gbTipoEmision.TabIndex = 15
            Me.gbTipoEmision.TabStop = False
            '
            'rbTipoEmisionIndisponibilidadSistema
            '
            Me.rbTipoEmisionIndisponibilidadSistema.AutoSize = True
            Me.rbTipoEmisionIndisponibilidadSistema.Location = New System.Drawing.Point(177, 10)
            Me.rbTipoEmisionIndisponibilidadSistema.Name = "rbTipoEmisionIndisponibilidadSistema"
            Me.rbTipoEmisionIndisponibilidadSistema.Size = New System.Drawing.Size(132, 17)
            Me.rbTipoEmisionIndisponibilidadSistema.TabIndex = 22
            Me.rbTipoEmisionIndisponibilidadSistema.Text = "INDISP DEL SISTEMA"
            Me.rbTipoEmisionIndisponibilidadSistema.UseVisualStyleBackColor = True
            '
            'rbTipoEmisionNormal
            '
            Me.rbTipoEmisionNormal.AutoSize = True
            Me.rbTipoEmisionNormal.Checked = True
            Me.rbTipoEmisionNormal.Location = New System.Drawing.Point(84, 10)
            Me.rbTipoEmisionNormal.Name = "rbTipoEmisionNormal"
            Me.rbTipoEmisionNormal.Size = New System.Drawing.Size(71, 17)
            Me.rbTipoEmisionNormal.TabIndex = 21
            Me.rbTipoEmisionNormal.TabStop = True
            Me.rbTipoEmisionNormal.Text = "NORMAL"
            Me.rbTipoEmisionNormal.UseVisualStyleBackColor = True
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(13, 12)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(55, 13)
            Me.Label20.TabIndex = 20
            Me.Label20.Text = "EMISIÓN:"
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
            Me.dgvFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvFacturaVenta.GridColor = System.Drawing.Color.White
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(3, 17)
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.ReadOnly = True
            Me.dgvFacturaVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvFacturaVenta.RowHeadersVisible = False
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(255, 611)
            Me.dgvFacturaVenta.TabIndex = 89
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.dgvDetalleFacturaVenta)
            Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(0, 220)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
            Me.GroupBox2.Size = New System.Drawing.Size(789, 178)
            Me.GroupBox2.TabIndex = 91
            Me.GroupBox2.TabStop = False
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.dgvFacturaVenta)
            Me.GroupBox3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(795, 67)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(261, 631)
            Me.GroupBox3.TabIndex = 92
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "HISTORIAL DE FACTURACIÓN"
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.White
            Me.GroupBox4.Controls.Add(Me.dgvAsientoDiarioFactura)
            Me.GroupBox4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.Location = New System.Drawing.Point(1, 573)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(788, 125)
            Me.GroupBox4.TabIndex = 93
            Me.GroupBox4.TabStop = False
            '
            'dgvAsientoDiarioFactura
            '
            Me.dgvAsientoDiarioFactura.AllowUserToAddRows = False
            Me.dgvAsientoDiarioFactura.AllowUserToDeleteRows = False
            Me.dgvAsientoDiarioFactura.AllowUserToResizeRows = False
            DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientoDiarioFactura.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvAsientoDiarioFactura.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
            Me.dgvAsientoDiarioFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvAsientoDiarioFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvAsientoDiarioFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientoDiarioFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvAsientoDiarioFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAsientoDiarioFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.CUENTA, Me.CONCEPTO, Me.DETALLE, Me.DEBE, Me.HABER})
            Me.dgvAsientoDiarioFactura.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvAsientoDiarioFactura.GridColor = System.Drawing.Color.White
            Me.dgvAsientoDiarioFactura.Location = New System.Drawing.Point(3, 16)
            Me.dgvAsientoDiarioFactura.Name = "dgvAsientoDiarioFactura"
            Me.dgvAsientoDiarioFactura.ReadOnly = True
            Me.dgvAsientoDiarioFactura.RowHeadersVisible = False
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvAsientoDiarioFactura.RowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvAsientoDiarioFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientoDiarioFactura.Size = New System.Drawing.Size(782, 106)
            Me.dgvAsientoDiarioFactura.TabIndex = 28
            '
            'CODIGO
            '
            Me.CODIGO.HeaderText = "CODIGO"
            Me.CODIGO.Name = "CODIGO"
            Me.CODIGO.ReadOnly = True
            Me.CODIGO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.CODIGO.Width = 94
            '
            'CUENTA
            '
            Me.CUENTA.HeaderText = "CUENTA"
            Me.CUENTA.Name = "CUENTA"
            Me.CUENTA.ReadOnly = True
            Me.CUENTA.Width = 170
            '
            'CONCEPTO
            '
            Me.CONCEPTO.HeaderText = "CONCEPTO"
            Me.CONCEPTO.Name = "CONCEPTO"
            Me.CONCEPTO.ReadOnly = True
            Me.CONCEPTO.Width = 160
            '
            'DETALLE
            '
            Me.DETALLE.HeaderText = "DETALLE"
            Me.DETALLE.Name = "DETALLE"
            Me.DETALLE.ReadOnly = True
            Me.DETALLE.Width = 200
            '
            'DEBE
            '
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DEBE.DefaultCellStyle = DataGridViewCellStyle10
            Me.DEBE.HeaderText = "DEBE"
            Me.DEBE.Name = "DEBE"
            Me.DEBE.ReadOnly = True
            Me.DEBE.Width = 85
            '
            'HABER
            '
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.HABER.DefaultCellStyle = DataGridViewCellStyle11
            Me.HABER.HeaderText = "HABER"
            Me.HABER.Name = "HABER"
            Me.HABER.ReadOnly = True
            Me.HABER.Width = 85
            '
            'rbPtoEmision001
            '
            Me.rbPtoEmision001.AutoSize = True
            Me.rbPtoEmision001.Location = New System.Drawing.Point(140, 11)
            Me.rbPtoEmision001.Name = "rbPtoEmision001"
            Me.rbPtoEmision001.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision001.TabIndex = 2
            Me.rbPtoEmision001.Text = "001"
            Me.rbPtoEmision001.UseVisualStyleBackColor = True
            '
            'rbPtoEmision002
            '
            Me.rbPtoEmision002.AutoSize = True
            Me.rbPtoEmision002.Checked = True
            Me.rbPtoEmision002.Location = New System.Drawing.Point(212, 11)
            Me.rbPtoEmision002.Name = "rbPtoEmision002"
            Me.rbPtoEmision002.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision002.TabIndex = 3
            Me.rbPtoEmision002.TabStop = True
            Me.rbPtoEmision002.Text = "002"
            Me.rbPtoEmision002.UseVisualStyleBackColor = True
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New System.Drawing.Point(18, 11)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(91, 15)
            Me.Label19.TabIndex = 16
            Me.Label19.Text = "PTO EMISIÓN:"
            '
            'gbPtoEmision
            '
            Me.gbPtoEmision.Controls.Add(Me.Label19)
            Me.gbPtoEmision.Controls.Add(Me.rbPtoEmision002)
            Me.gbPtoEmision.Controls.Add(Me.rbPtoEmision001)
            Me.gbPtoEmision.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbPtoEmision.Location = New System.Drawing.Point(0, 34)
            Me.gbPtoEmision.Name = "gbPtoEmision"
            Me.gbPtoEmision.Size = New System.Drawing.Size(286, 32)
            Me.gbPtoEmision.TabIndex = 88
            Me.gbPtoEmision.TabStop = False
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(334, 4)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(144, 18)
            Me.Label13.TabIndex = 17
            Me.Label13.Text = "ASIENTO DE DIARIO"
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.Panel1.Controls.Add(Me.Label13)
            Me.Panel1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.ForeColor = System.Drawing.Color.White
            Me.Panel1.Location = New System.Drawing.Point(1, 554)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(788, 22)
            Me.Panel1.TabIndex = 79
            '
            'cbxConvenio
            '
            Me.cbxConvenio.BackColor = System.Drawing.Color.White
            Me.cbxConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxConvenio.DropDownWidth = 450
            Me.cbxConvenio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbxConvenio.FormattingEnabled = True
            Me.cbxConvenio.Location = New System.Drawing.Point(11, 13)
            Me.cbxConvenio.Name = "cbxConvenio"
            Me.cbxConvenio.Size = New System.Drawing.Size(508, 21)
            Me.cbxConvenio.TabIndex = 2
            '
            'GroupBox5
            '
            Me.GroupBox5.BackColor = System.Drawing.Color.White
            Me.GroupBox5.Controls.Add(Me.cbxConvenio)
            Me.GroupBox5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox5.Location = New System.Drawing.Point(83, 474)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(525, 38)
            Me.GroupBox5.TabIndex = 94
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "CONVENIO DÉBITO BANCARIO"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.AutoSize = False
            Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnCompEgreso, Me.btnModificar, Me.btnGuardar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.MenuStrip1.Size = New System.Drawing.Size(1091, 32)
            Me.MenuStrip1.TabIndex = 187
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
            'btnCompEgreso
            '
            Me.btnCompEgreso.Image = Global.syscisepro.My.Resources.Resources.note_add_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCompEgreso.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCompEgreso.Name = "btnCompEgreso"
            Me.btnCompEgreso.Size = New System.Drawing.Size(126, 28)
            Me.btnCompEgreso.Text = "COMP. EGRESO"
            '
            'btnModificar
            '
            Me.btnModificar.Enabled = False
            Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(95, 28)
            Me.btnModificar.Text = "GUARDAR"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.generate_tables_icon
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(119, 20)
            Me.btnGuardar.Text = "GUARDAR FIRM."
            Me.btnGuardar.Visible = False
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
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.White
            Me.Panel2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel2.ForeColor = System.Drawing.Color.White
            Me.Panel2.Location = New System.Drawing.Point(1, 1)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(391, 26)
            Me.Panel2.TabIndex = 95
            '
            'FormFacturaVenta
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1060, 702)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbPtoEmision)
            Me.Controls.Add(Me.GroupBox5)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.gbTipoAnbiente)
            Me.Controls.Add(Me.gbTipoEmision)
            Me.Controls.Add(Me.gbEmpresa)
            Me.Controls.Add(Me.gbNumeracion)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.panelDetalle)
            Me.Controls.Add(Me.gbFecha)
            Me.Controls.Add(Me.gbCliente)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.gbConceptoFactura)
            Me.Controls.Add(Me.gbSon)
            Me.Controls.Add(Me.gbObservaciones)
            Me.Controls.Add(Me.gbTipoPago)
            Me.Controls.Add(Me.gbValores)
            Me.Controls.Add(Me.GroupBox4)
            Me.Controls.Add(Me.gbFormaPago)
            Me.Controls.Add(Me.Panel2)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormFacturaVenta"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "FACTURA VENTA"
            Me.gbValores.ResumeLayout(False)
            Me.gbValores.PerformLayout()
            Me.gbNumeracion.ResumeLayout(False)
            Me.gbNumeracion.PerformLayout()
            Me.gbCliente.ResumeLayout(False)
            Me.gbCliente.PerformLayout()
            Me.gbFecha.ResumeLayout(False)
            Me.gbFecha.PerformLayout()
            Me.panelDetalle.ResumeLayout(False)
            Me.panelDetalle.PerformLayout()
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbEmpresa.ResumeLayout(False)
            Me.gbEmpresa.PerformLayout()
            Me.gbSon.ResumeLayout(False)
            Me.gbSon.PerformLayout()
            Me.gbObservaciones.ResumeLayout(False)
            Me.gbObservaciones.PerformLayout()
            Me.gbTipoPago.ResumeLayout(False)
            Me.gbTipoPago.PerformLayout()
            Me.gbFormaPago.ResumeLayout(False)
            Me.gbFormaPago.PerformLayout()
            Me.gbConceptoFactura.ResumeLayout(False)
            Me.gbConceptoFactura.PerformLayout()
            Me.gbTipoAnbiente.ResumeLayout(False)
            Me.gbTipoAnbiente.PerformLayout()
            Me.gbTipoEmision.ResumeLayout(False)
            Me.gbTipoEmision.PerformLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            CType(Me.dgvAsientoDiarioFactura, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbPtoEmision.ResumeLayout(False)
            Me.gbPtoEmision.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbValores As System.Windows.Forms.GroupBox
        Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0 As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal12 As System.Windows.Forms.TextBox
        Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
        Friend WithEvents lblSubTotal As System.Windows.Forms.Label
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents txtIva As System.Windows.Forms.TextBox
        Friend WithEvents lblTotalOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblIva As System.Windows.Forms.Label
        Friend WithEvents lblDescuentoOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblSubtotal0OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblSubtotalIva As System.Windows.Forms.Label
        Friend WithEvents gbNumeracion As System.Windows.Forms.GroupBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents lblNumeroFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblRucEmpresa As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents gbCliente As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombreComercialCliente As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaEmisionFacturaVenta As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents txtGuiaRemisionFacturaVenta As System.Windows.Forms.TextBox
        Friend WithEvents txtTelefonoClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccionFacturacionCliente As System.Windows.Forms.TextBox
        Friend WithEvents txtRucCiCliente As System.Windows.Forms.TextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents gbFecha As System.Windows.Forms.GroupBox
        Friend WithEvents panelDetalle As System.Windows.Forms.Panel
        Friend WithEvents lblDetalleSolicitud As System.Windows.Forms.Label
        Friend WithEvents dgvDetalleFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents gbEmpresa As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents lblNombreComercialEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblIdEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents gbSon As System.Windows.Forms.GroupBox
        Friend WithEvents txtSon As System.Windows.Forms.TextBox
        Friend WithEvents gbObservaciones As System.Windows.Forms.GroupBox
        Friend WithEvents txtObservacionesFactura As System.Windows.Forms.TextBox
        Friend WithEvents gbTipoPago As System.Windows.Forms.GroupBox
        Friend WithEvents cmbTipoPagoFactura As System.Windows.Forms.ComboBox
        Friend WithEvents gbFormaPago As System.Windows.Forms.GroupBox
        Friend WithEvents rbCredito As System.Windows.Forms.RadioButton
        Friend WithEvents rbContado As System.Windows.Forms.RadioButton
        Friend WithEvents gbConceptoFactura As System.Windows.Forms.GroupBox
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents lblCodigoCuentaConcepto As System.Windows.Forms.Label
        Friend WithEvents lblLlevaContabilidad As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents gbTipoAnbiente As System.Windows.Forms.GroupBox
        Friend WithEvents rbPruebas As System.Windows.Forms.RadioButton
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents lblPtoEmisionFacturaEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblNroAutoSRIEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblEstablecimientoFacturaEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblRucCiCliente As System.Windows.Forms.Label
        Friend WithEvents gbTipoEmision As System.Windows.Forms.GroupBox
        Friend WithEvents rbTipoEmisionIndisponibilidadSistema As System.Windows.Forms.RadioButton
        Friend WithEvents rbTipoEmisionNormal As System.Windows.Forms.RadioButton
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents rbProduccion As System.Windows.Forms.RadioButton
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents dgvAsientoDiarioFactura As System.Windows.Forms.DataGridView
        Friend WithEvents lblCodigoFormasPago As System.Windows.Forms.Label
        Friend WithEvents rbPtoEmision001 As System.Windows.Forms.RadioButton
        Friend WithEvents rbPtoEmision002 As System.Windows.Forms.RadioButton
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents gbPtoEmision As System.Windows.Forms.GroupBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents cbxConvenio As System.Windows.Forms.ComboBox
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CUENTA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CONCEPTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DETALLE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DEBE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents HABER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txtDireccionEmpresa As System.Windows.Forms.Label
        Friend WithEvents btnCompEgreso As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents eliminarItem As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents idItem As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents nombreProductoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cantidadProductoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents valorUnitarioProductoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents descuento As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents valorTotalProductoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cmbDirecciones As System.Windows.Forms.ComboBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents cmbIva As System.Windows.Forms.ComboBox
    End Class
End Namespace