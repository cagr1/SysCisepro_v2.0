Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormNotaCredito
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
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNotaCredito))
            Me.gbFechaNotaCredito = New System.Windows.Forms.GroupBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtRazonModificacionNotaCredito = New System.Windows.Forms.TextBox()
            Me.Label48 = New System.Windows.Forms.Label()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.txtComprobanteModificaNotaCredito = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.dtpFechaEmisionNotaCredito = New System.Windows.Forms.DateTimePicker()
            Me.gbValoresNotaCredito = New System.Windows.Forms.GroupBox()
            Me.txtDescuentoNotaCredito = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0NotaCredito = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12NotaCredito = New System.Windows.Forms.TextBox()
            Me.txtSubTotalNotaCredito = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtTotalNotaCredito = New System.Windows.Forms.TextBox()
            Me.txtIvaNotaCredito = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.lblIva = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.lblSubtotalIva = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblTipoPagoFacturaCompra = New System.Windows.Forms.Label()
            Me.panelDetalle = New System.Windows.Forms.Panel()
            Me.lblDetalleSolicitud = New System.Windows.Forms.Label()
            Me.gbDatosComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.lblFechaEmisionFacturaVenta = New System.Windows.Forms.Label()
            Me.lblNumeroFacturaVenta = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.gbValoresComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.txtSubtotal0 = New System.Windows.Forms.TextBox()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.lblSubTotal = New System.Windows.Forms.Label()
            Me.lblTotalOrdenCompra = New System.Windows.Forms.Label()
            Me.txtIva = New System.Windows.Forms.TextBox()
            Me.lblIvaOrdenCompra = New System.Windows.Forms.Label()
            Me.lblDescuentoOrdenCompra = New System.Windows.Forms.Label()
            Me.txtSubtotal = New System.Windows.Forms.TextBox()
            Me.lblSubtotal0OrdenCompra = New System.Windows.Forms.Label()
            Me.txtDescuento = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12 = New System.Windows.Forms.TextBox()
            Me.lblSubtotal12OrdenCompra = New System.Windows.Forms.Label()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.dgvDetalleFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.gbPtoEmision = New System.Windows.Forms.GroupBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.rbPtoEmision002 = New System.Windows.Forms.RadioButton()
            Me.rbPtoEmision001 = New System.Windows.Forms.RadioButton()
            Me.gbTipoEmision = New System.Windows.Forms.GroupBox()
            Me.rbTipoEmisionIndisponibilidadSistema = New System.Windows.Forms.RadioButton()
            Me.rbTipoEmisionNormal = New System.Windows.Forms.RadioButton()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.gbTipoAnbiente = New System.Windows.Forms.GroupBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.rbProduccion = New System.Windows.Forms.RadioButton()
            Me.rbPruebas = New System.Windows.Forms.RadioButton()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.gbClienteGeneral = New System.Windows.Forms.GroupBox()
            Me.lblRucClienteGenral = New System.Windows.Forms.Label()
            Me.lblLlevaContabilidadClienteGeneral = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtNombreComercialCliente = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtRucCiCliente = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.txtTelefonoClienteGeneral = New System.Windows.Forms.TextBox()
            Me.txtDireccionFacturacionCliente = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.gbEmpresa = New System.Windows.Forms.GroupBox()
            Me.txtDireccionEmpresa = New System.Windows.Forms.TextBox()
            Me.lblIdEmpresa = New System.Windows.Forms.Label()
            Me.lblNombreComercialEmpresa = New System.Windows.Forms.Label()
            Me.gbNumeracion = New System.Windows.Forms.GroupBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblPtoEmisionFacturaEmpresa = New System.Windows.Forms.Label()
            Me.lblNroAutoSRIEmpresa = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.lblNumeroSecuencialNotaCredito = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.lblEstablecimientoFacturaEmpresa = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.lblRucEmpresa = New System.Windows.Forms.Label()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarSinFirmar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbFechaNotaCredito.SuspendLayout()
            Me.gbValoresNotaCredito.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.panelDetalle.SuspendLayout()
            Me.gbDatosComprobanteCompra.SuspendLayout()
            Me.gbValoresComprobanteCompra.SuspendLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbPtoEmision.SuspendLayout()
            Me.gbTipoEmision.SuspendLayout()
            Me.gbTipoAnbiente.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.gbClienteGeneral.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.gbEmpresa.SuspendLayout()
            Me.gbNumeracion.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbFechaNotaCredito
            '
            Me.gbFechaNotaCredito.BackColor = System.Drawing.Color.White
            Me.gbFechaNotaCredito.Controls.Add(Me.Label12)
            Me.gbFechaNotaCredito.Controls.Add(Me.txtRazonModificacionNotaCredito)
            Me.gbFechaNotaCredito.Controls.Add(Me.Label48)
            Me.gbFechaNotaCredito.Controls.Add(Me.Label32)
            Me.gbFechaNotaCredito.Controls.Add(Me.txtComprobanteModificaNotaCredito)
            Me.gbFechaNotaCredito.Controls.Add(Me.Label7)
            Me.gbFechaNotaCredito.Controls.Add(Me.Label19)
            Me.gbFechaNotaCredito.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFechaNotaCredito.Location = New System.Drawing.Point(1, 524)
            Me.gbFechaNotaCredito.Name = "gbFechaNotaCredito"
            Me.gbFechaNotaCredito.Size = New System.Drawing.Size(517, 170)
            Me.gbFechaNotaCredito.TabIndex = 65
            Me.gbFechaNotaCredito.TabStop = False
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(151, 17)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(217, 15)
            Me.Label12.TabIndex = 62
            Me.Label12.Text = "DATOS DEL COMPROBANTE DE VENTA"
            '
            'txtRazonModificacionNotaCredito
            '
            Me.txtRazonModificacionNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtRazonModificacionNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazonModificacionNotaCredito.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazonModificacionNotaCredito.Location = New System.Drawing.Point(18, 110)
            Me.txtRazonModificacionNotaCredito.Multiline = True
            Me.txtRazonModificacionNotaCredito.Name = "txtRazonModificacionNotaCredito"
            Me.txtRazonModificacionNotaCredito.Size = New System.Drawing.Size(487, 42)
            Me.txtRazonModificacionNotaCredito.TabIndex = 43
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label48.Location = New System.Drawing.Point(15, 94)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(133, 13)
            Me.Label48.TabIndex = 61
            Me.Label48.Text = "RAZON DE MODIFICACIÓN"
            '
            'Label32
            '
            Me.Label32.AutoSize = True
            Me.Label32.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label32.Location = New System.Drawing.Point(15, 54)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(91, 13)
            Me.Label32.TabIndex = 57
            Me.Label32.Text = "COMPR. MODIF.:"
            '
            'txtComprobanteModificaNotaCredito
            '
            Me.txtComprobanteModificaNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtComprobanteModificaNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtComprobanteModificaNotaCredito.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtComprobanteModificaNotaCredito.Location = New System.Drawing.Point(108, 51)
            Me.txtComprobanteModificaNotaCredito.Name = "txtComprobanteModificaNotaCredito"
            Me.txtComprobanteModificaNotaCredito.Size = New System.Drawing.Size(146, 20)
            Me.txtComprobanteModificaNotaCredito.TabIndex = 42
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.Label7.Location = New System.Drawing.Point(15, 29)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(229, 13)
            Me.Label7.TabIndex = 59
            Me.Label7.Text = "_____________________________________"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.Label19.Location = New System.Drawing.Point(13, 67)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(229, 13)
            Me.Label19.TabIndex = 60
            Me.Label19.Text = "_____________________________________"
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label29.Location = New System.Drawing.Point(65, 16)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(91, 13)
            Me.Label29.TabIndex = 55
            Me.Label29.Text = "FECHA EMISIÓN:"
            '
            'dtpFechaEmisionNotaCredito
            '
            Me.dtpFechaEmisionNotaCredito.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionNotaCredito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionNotaCredito.Location = New System.Drawing.Point(166, 13)
            Me.dtpFechaEmisionNotaCredito.Name = "dtpFechaEmisionNotaCredito"
            Me.dtpFechaEmisionNotaCredito.Size = New System.Drawing.Size(131, 20)
            Me.dtpFechaEmisionNotaCredito.TabIndex = 41
            '
            'gbValoresNotaCredito
            '
            Me.gbValoresNotaCredito.BackColor = System.Drawing.Color.White
            Me.gbValoresNotaCredito.Controls.Add(Me.txtDescuentoNotaCredito)
            Me.gbValoresNotaCredito.Controls.Add(Me.txtSubtotal0NotaCredito)
            Me.gbValoresNotaCredito.Controls.Add(Me.txtSubtotal12NotaCredito)
            Me.gbValoresNotaCredito.Controls.Add(Me.txtSubTotalNotaCredito)
            Me.gbValoresNotaCredito.Controls.Add(Me.Label8)
            Me.gbValoresNotaCredito.Controls.Add(Me.txtTotalNotaCredito)
            Me.gbValoresNotaCredito.Controls.Add(Me.txtIvaNotaCredito)
            Me.gbValoresNotaCredito.Controls.Add(Me.Label9)
            Me.gbValoresNotaCredito.Controls.Add(Me.lblIva)
            Me.gbValoresNotaCredito.Controls.Add(Me.Label11)
            Me.gbValoresNotaCredito.Controls.Add(Me.Label13)
            Me.gbValoresNotaCredito.Controls.Add(Me.lblSubtotalIva)
            Me.gbValoresNotaCredito.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbValoresNotaCredito.Location = New System.Drawing.Point(518, 524)
            Me.gbValoresNotaCredito.Name = "gbValoresNotaCredito"
            Me.gbValoresNotaCredito.Size = New System.Drawing.Size(305, 170)
            Me.gbValoresNotaCredito.TabIndex = 64
            Me.gbValoresNotaCredito.TabStop = False
            '
            'txtDescuentoNotaCredito
            '
            Me.txtDescuentoNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtDescuentoNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescuentoNotaCredito.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuentoNotaCredito.Location = New System.Drawing.Point(190, 63)
            Me.txtDescuentoNotaCredito.Name = "txtDescuentoNotaCredito"
            Me.txtDescuentoNotaCredito.Size = New System.Drawing.Size(107, 23)
            Me.txtDescuentoNotaCredito.TabIndex = 29
            Me.txtDescuentoNotaCredito.Text = "0.00"
            Me.txtDescuentoNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0NotaCredito
            '
            Me.txtSubtotal0NotaCredito.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0NotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal0NotaCredito.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0NotaCredito.Location = New System.Drawing.Point(190, 37)
            Me.txtSubtotal0NotaCredito.Name = "txtSubtotal0NotaCredito"
            Me.txtSubtotal0NotaCredito.Size = New System.Drawing.Size(107, 23)
            Me.txtSubtotal0NotaCredito.TabIndex = 28
            Me.txtSubtotal0NotaCredito.Text = "0.00"
            Me.txtSubtotal0NotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal12NotaCredito
            '
            Me.txtSubtotal12NotaCredito.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12NotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal12NotaCredito.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12NotaCredito.Location = New System.Drawing.Point(190, 11)
            Me.txtSubtotal12NotaCredito.Name = "txtSubtotal12NotaCredito"
            Me.txtSubtotal12NotaCredito.Size = New System.Drawing.Size(107, 23)
            Me.txtSubtotal12NotaCredito.TabIndex = 27
            Me.txtSubtotal12NotaCredito.Text = "0.00"
            Me.txtSubtotal12NotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubTotalNotaCredito
            '
            Me.txtSubTotalNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtSubTotalNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubTotalNotaCredito.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotalNotaCredito.Location = New System.Drawing.Point(190, 89)
            Me.txtSubTotalNotaCredito.Name = "txtSubTotalNotaCredito"
            Me.txtSubTotalNotaCredito.Size = New System.Drawing.Size(107, 23)
            Me.txtSubTotalNotaCredito.TabIndex = 30
            Me.txtSubTotalNotaCredito.Text = "0.00"
            Me.txtSubTotalNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(65, 90)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(77, 15)
            Me.Label8.TabIndex = 31
            Me.Label8.Text = "SUB TOTAL:"
            '
            'txtTotalNotaCredito
            '
            Me.txtTotalNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtTotalNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalNotaCredito.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalNotaCredito.Location = New System.Drawing.Point(190, 142)
            Me.txtTotalNotaCredito.Name = "txtTotalNotaCredito"
            Me.txtTotalNotaCredito.Size = New System.Drawing.Size(107, 23)
            Me.txtTotalNotaCredito.TabIndex = 33
            Me.txtTotalNotaCredito.Text = "0.00"
            Me.txtTotalNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaNotaCredito
            '
            Me.txtIvaNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtIvaNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIvaNotaCredito.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIvaNotaCredito.Location = New System.Drawing.Point(190, 116)
            Me.txtIvaNotaCredito.Name = "txtIvaNotaCredito"
            Me.txtIvaNotaCredito.Size = New System.Drawing.Size(107, 23)
            Me.txtIvaNotaCredito.TabIndex = 32
            Me.txtIvaNotaCredito.Text = "0.00"
            Me.txtIvaNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(64, 143)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(49, 15)
            Me.Label9.TabIndex = 26
            Me.Label9.Text = "TOTAL:"
            '
            'lblIva
            '
            Me.lblIva.AutoSize = True
            Me.lblIva.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIva.Location = New System.Drawing.Point(65, 117)
            Me.lblIva.Name = "lblIva"
            Me.lblIva.Size = New System.Drawing.Size(77, 15)
            Me.lblIva.TabIndex = 25
            Me.lblIva.Text = "IVA (12%):"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(65, 64)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(77, 15)
            Me.Label11.TabIndex = 24
            Me.Label11.Text = "DESCUENTO:"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(65, 38)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(91, 15)
            Me.Label13.TabIndex = 23
            Me.Label13.Text = "SUB TOTAL 0:"
            '
            'lblSubtotalIva
            '
            Me.lblSubtotalIva.AutoSize = True
            Me.lblSubtotalIva.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotalIva.Location = New System.Drawing.Point(65, 14)
            Me.lblSubtotalIva.Name = "lblSubtotalIva"
            Me.lblSubtotalIva.Size = New System.Drawing.Size(98, 15)
            Me.lblSubtotalIva.TabIndex = 22
            Me.lblSubtotalIva.Text = "SUB TOTAL 12:"
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.Label24)
            Me.Panel1.Controls.Add(Me.lblIdFacturaVenta)
            Me.Panel1.Controls.Add(Me.Label6)
            Me.Panel1.Controls.Add(Me.lblTipoPagoFacturaCompra)
            Me.Panel1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(1, 166)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(822, 19)
            Me.Panel1.TabIndex = 98
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(335, 0)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(64, 18)
            Me.Label24.TabIndex = 17
            Me.Label24.Text = "FACTURA"
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(429, 2)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(28, 14)
            Me.lblIdFacturaVenta.TabIndex = 29
            Me.lblIdFacturaVenta.Text = "..."
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(463, 2)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(14, 14)
            Me.Label6.TabIndex = 93
            Me.Label6.Text = "/"
            '
            'lblTipoPagoFacturaCompra
            '
            Me.lblTipoPagoFacturaCompra.AutoSize = True
            Me.lblTipoPagoFacturaCompra.Location = New System.Drawing.Point(482, 2)
            Me.lblTipoPagoFacturaCompra.Name = "lblTipoPagoFacturaCompra"
            Me.lblTipoPagoFacturaCompra.Size = New System.Drawing.Size(28, 14)
            Me.lblTipoPagoFacturaCompra.TabIndex = 94
            Me.lblTipoPagoFacturaCompra.Text = "..."
            '
            'panelDetalle
            '
            Me.panelDetalle.BackColor = System.Drawing.Color.White
            Me.panelDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panelDetalle.Controls.Add(Me.lblDetalleSolicitud)
            Me.panelDetalle.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panelDetalle.Location = New System.Drawing.Point(1, 409)
            Me.panelDetalle.Name = "panelDetalle"
            Me.panelDetalle.Size = New System.Drawing.Size(822, 20)
            Me.panelDetalle.TabIndex = 97
            '
            'lblDetalleSolicitud
            '
            Me.lblDetalleSolicitud.AutoSize = True
            Me.lblDetalleSolicitud.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDetalleSolicitud.Location = New System.Drawing.Point(220, 0)
            Me.lblDetalleSolicitud.Name = "lblDetalleSolicitud"
            Me.lblDetalleSolicitud.Size = New System.Drawing.Size(296, 18)
            Me.lblDetalleSolicitud.TabIndex = 17
            Me.lblDetalleSolicitud.Text = "DETALLE DE FACTURA / NOTA DE CREDITO"
            '
            'gbDatosComprobanteCompra
            '
            Me.gbDatosComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblFechaEmisionFacturaVenta)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblNumeroFacturaVenta)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label28)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label3)
            Me.gbDatosComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatosComprobanteCompra.Location = New System.Drawing.Point(1, 339)
            Me.gbDatosComprobanteCompra.Name = "gbDatosComprobanteCompra"
            Me.gbDatosComprobanteCompra.Size = New System.Drawing.Size(517, 70)
            Me.gbDatosComprobanteCompra.TabIndex = 93
            Me.gbDatosComprobanteCompra.TabStop = False
            Me.gbDatosComprobanteCompra.Text = "Datos"
            '
            'lblFechaEmisionFacturaVenta
            '
            Me.lblFechaEmisionFacturaVenta.AutoSize = True
            Me.lblFechaEmisionFacturaVenta.Location = New System.Drawing.Point(94, 30)
            Me.lblFechaEmisionFacturaVenta.Name = "lblFechaEmisionFacturaVenta"
            Me.lblFechaEmisionFacturaVenta.Size = New System.Drawing.Size(67, 13)
            Me.lblFechaEmisionFacturaVenta.TabIndex = 23
            Me.lblFechaEmisionFacturaVenta.Text = "00/00/0000"
            Me.lblFechaEmisionFacturaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNumeroFacturaVenta
            '
            Me.lblNumeroFacturaVenta.AutoSize = True
            Me.lblNumeroFacturaVenta.Location = New System.Drawing.Point(77, 13)
            Me.lblNumeroFacturaVenta.Name = "lblNumeroFacturaVenta"
            Me.lblNumeroFacturaVenta.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroFacturaVenta.TabIndex = 21
            Me.lblNumeroFacturaVenta.Text = "0"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.Location = New System.Drawing.Point(5, 30)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(91, 13)
            Me.Label28.TabIndex = 12
            Me.Label28.Text = "Fecha Emisión:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(5, 13)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(73, 13)
            Me.Label3.TabIndex = 10
            Me.Label3.Text = "Nº FACTURA:"
            '
            'gbValoresComprobanteCompra
            '
            Me.gbValoresComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal0)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtTotal)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubTotal)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblTotalOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtIva)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblIvaOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblDescuentoOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal0OrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtDescuento)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal12)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal12OrdenCompra)
            Me.gbValoresComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbValoresComprobanteCompra.Location = New System.Drawing.Point(518, 339)
            Me.gbValoresComprobanteCompra.Name = "gbValoresComprobanteCompra"
            Me.gbValoresComprobanteCompra.Size = New System.Drawing.Size(305, 70)
            Me.gbValoresComprobanteCompra.TabIndex = 92
            Me.gbValoresComprobanteCompra.TabStop = False
            Me.gbValoresComprobanteCompra.Text = "Valores"
            '
            'txtSubtotal0
            '
            Me.txtSubtotal0.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal0.Enabled = False
            Me.txtSubtotal0.Location = New System.Drawing.Point(89, 30)
            Me.txtSubtotal0.Name = "txtSubtotal0"
            Me.txtSubtotal0.Size = New System.Drawing.Size(59, 13)
            Me.txtSubtotal0.TabIndex = 28
            Me.txtSubtotal0.Text = "0.00"
            Me.txtSubtotal0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.White
            Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotal.Enabled = False
            Me.txtTotal.Location = New System.Drawing.Point(238, 48)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(59, 13)
            Me.txtTotal.TabIndex = 32
            Me.txtTotal.Text = "0.00"
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubTotal
            '
            Me.lblSubTotal.AutoSize = True
            Me.lblSubTotal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotal.Location = New System.Drawing.Point(174, 13)
            Me.lblSubTotal.Name = "lblSubTotal"
            Me.lblSubTotal.Size = New System.Drawing.Size(67, 13)
            Me.lblSubTotal.TabIndex = 20
            Me.lblSubTotal.Text = "SUB TOTAL:"
            '
            'lblTotalOrdenCompra
            '
            Me.lblTotalOrdenCompra.AutoSize = True
            Me.lblTotalOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalOrdenCompra.Location = New System.Drawing.Point(174, 48)
            Me.lblTotalOrdenCompra.Name = "lblTotalOrdenCompra"
            Me.lblTotalOrdenCompra.Size = New System.Drawing.Size(43, 13)
            Me.lblTotalOrdenCompra.TabIndex = 14
            Me.lblTotalOrdenCompra.Text = "TOTAL:"
            '
            'txtIva
            '
            Me.txtIva.BackColor = System.Drawing.Color.White
            Me.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIva.Enabled = False
            Me.txtIva.Location = New System.Drawing.Point(238, 30)
            Me.txtIva.Name = "txtIva"
            Me.txtIva.Size = New System.Drawing.Size(59, 13)
            Me.txtIva.TabIndex = 31
            Me.txtIva.Text = "0.00"
            Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIvaOrdenCompra
            '
            Me.lblIvaOrdenCompra.AutoSize = True
            Me.lblIvaOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIvaOrdenCompra.Location = New System.Drawing.Point(174, 30)
            Me.lblIvaOrdenCompra.Name = "lblIvaOrdenCompra"
            Me.lblIvaOrdenCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblIvaOrdenCompra.TabIndex = 13
            Me.lblIvaOrdenCompra.Text = "IVA (12%):"
            '
            'lblDescuentoOrdenCompra
            '
            Me.lblDescuentoOrdenCompra.AutoSize = True
            Me.lblDescuentoOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescuentoOrdenCompra.Location = New System.Drawing.Point(4, 48)
            Me.lblDescuentoOrdenCompra.Name = "lblDescuentoOrdenCompra"
            Me.lblDescuentoOrdenCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblDescuentoOrdenCompra.TabIndex = 12
            Me.lblDescuentoOrdenCompra.Text = "DESCUENTO:"
            '
            'txtSubtotal
            '
            Me.txtSubtotal.BackColor = System.Drawing.Color.White
            Me.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal.Enabled = False
            Me.txtSubtotal.Location = New System.Drawing.Point(238, 12)
            Me.txtSubtotal.Name = "txtSubtotal"
            Me.txtSubtotal.Size = New System.Drawing.Size(59, 13)
            Me.txtSubtotal.TabIndex = 30
            Me.txtSubtotal.Text = "0.00"
            Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal0OrdenCompra
            '
            Me.lblSubtotal0OrdenCompra.AutoSize = True
            Me.lblSubtotal0OrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal0OrdenCompra.Location = New System.Drawing.Point(4, 30)
            Me.lblSubtotal0OrdenCompra.Name = "lblSubtotal0OrdenCompra"
            Me.lblSubtotal0OrdenCompra.Size = New System.Drawing.Size(79, 13)
            Me.lblSubtotal0OrdenCompra.TabIndex = 11
            Me.lblSubtotal0OrdenCompra.Text = "SUB TOTAL 0:"
            '
            'txtDescuento
            '
            Me.txtDescuento.BackColor = System.Drawing.Color.White
            Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescuento.Enabled = False
            Me.txtDescuento.Location = New System.Drawing.Point(89, 48)
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.Size = New System.Drawing.Size(59, 13)
            Me.txtDescuento.TabIndex = 29
            Me.txtDescuento.Text = "0.00"
            Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal12
            '
            Me.txtSubtotal12.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal12.Enabled = False
            Me.txtSubtotal12.Location = New System.Drawing.Point(89, 12)
            Me.txtSubtotal12.Name = "txtSubtotal12"
            Me.txtSubtotal12.Size = New System.Drawing.Size(59, 13)
            Me.txtSubtotal12.TabIndex = 27
            Me.txtSubtotal12.Text = "0.00"
            Me.txtSubtotal12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal12OrdenCompra
            '
            Me.lblSubtotal12OrdenCompra.AutoSize = True
            Me.lblSubtotal12OrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal12OrdenCompra.Location = New System.Drawing.Point(4, 12)
            Me.lblSubtotal12OrdenCompra.Name = "lblSubtotal12OrdenCompra"
            Me.lblSubtotal12OrdenCompra.Size = New System.Drawing.Size(85, 13)
            Me.lblSubtotal12OrdenCompra.TabIndex = 10
            Me.lblSubtotal12OrdenCompra.Text = "SUB TOTAL 12:"
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
            Me.dgvFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturaVenta.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvFacturaVenta.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(3, 16)
            Me.dgvFacturaVenta.MultiSelect = False
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.ReadOnly = True
            Me.dgvFacturaVenta.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvFacturaVenta.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(816, 138)
            Me.dgvFacturaVenta.TabIndex = 86
            '
            'dgvDetalleFacturaVenta
            '
            Me.dgvDetalleFacturaVenta.AllowUserToAddRows = False
            Me.dgvDetalleFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvDetalleFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvDetalleFacturaVenta.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalleFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvDetalleFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvDetalleFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDetalleFacturaVenta.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvDetalleFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvDetalleFacturaVenta.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetalleFacturaVenta.Location = New System.Drawing.Point(3, 16)
            Me.dgvDetalleFacturaVenta.Name = "dgvDetalleFacturaVenta"
            Me.dgvDetalleFacturaVenta.RowHeadersVisible = False
            Me.dgvDetalleFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleFacturaVenta.Size = New System.Drawing.Size(816, 81)
            Me.dgvDetalleFacturaVenta.TabIndex = 96
            '
            'gbPtoEmision
            '
            Me.gbPtoEmision.BackColor = System.Drawing.Color.White
            Me.gbPtoEmision.Controls.Add(Me.Label21)
            Me.gbPtoEmision.Controls.Add(Me.rbPtoEmision002)
            Me.gbPtoEmision.Controls.Add(Me.rbPtoEmision001)
            Me.gbPtoEmision.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbPtoEmision.Location = New System.Drawing.Point(1, 27)
            Me.gbPtoEmision.Name = "gbPtoEmision"
            Me.gbPtoEmision.Size = New System.Drawing.Size(268, 32)
            Me.gbPtoEmision.TabIndex = 103
            Me.gbPtoEmision.TabStop = False
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(4, 9)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(91, 15)
            Me.Label21.TabIndex = 16
            Me.Label21.Text = "PTO EMISIÓN:"
            '
            'rbPtoEmision002
            '
            Me.rbPtoEmision002.AutoSize = True
            Me.rbPtoEmision002.Location = New System.Drawing.Point(147, 9)
            Me.rbPtoEmision002.Name = "rbPtoEmision002"
            Me.rbPtoEmision002.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision002.TabIndex = 3
            Me.rbPtoEmision002.TabStop = True
            Me.rbPtoEmision002.Text = "002"
            Me.rbPtoEmision002.UseVisualStyleBackColor = True
            '
            'rbPtoEmision001
            '
            Me.rbPtoEmision001.AutoSize = True
            Me.rbPtoEmision001.Location = New System.Drawing.Point(98, 9)
            Me.rbPtoEmision001.Name = "rbPtoEmision001"
            Me.rbPtoEmision001.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision001.TabIndex = 2
            Me.rbPtoEmision001.TabStop = True
            Me.rbPtoEmision001.Text = "001"
            Me.rbPtoEmision001.UseVisualStyleBackColor = True
            '
            'gbTipoEmision
            '
            Me.gbTipoEmision.BackColor = System.Drawing.Color.White
            Me.gbTipoEmision.Controls.Add(Me.rbTipoEmisionIndisponibilidadSistema)
            Me.gbTipoEmision.Controls.Add(Me.rbTipoEmisionNormal)
            Me.gbTipoEmision.Controls.Add(Me.Label22)
            Me.gbTipoEmision.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoEmision.Location = New System.Drawing.Point(518, 27)
            Me.gbTipoEmision.Name = "gbTipoEmision"
            Me.gbTipoEmision.Size = New System.Drawing.Size(305, 32)
            Me.gbTipoEmision.TabIndex = 101
            Me.gbTipoEmision.TabStop = False
            '
            'rbTipoEmisionIndisponibilidadSistema
            '
            Me.rbTipoEmisionIndisponibilidadSistema.AutoSize = True
            Me.rbTipoEmisionIndisponibilidadSistema.Location = New System.Drawing.Point(128, 9)
            Me.rbTipoEmisionIndisponibilidadSistema.Name = "rbTipoEmisionIndisponibilidadSistema"
            Me.rbTipoEmisionIndisponibilidadSistema.Size = New System.Drawing.Size(133, 17)
            Me.rbTipoEmisionIndisponibilidadSistema.TabIndex = 22
            Me.rbTipoEmisionIndisponibilidadSistema.TabStop = True
            Me.rbTipoEmisionIndisponibilidadSistema.Text = "INDISP DEL SISTEMA"
            Me.rbTipoEmisionIndisponibilidadSistema.UseVisualStyleBackColor = True
            '
            'rbTipoEmisionNormal
            '
            Me.rbTipoEmisionNormal.AutoSize = True
            Me.rbTipoEmisionNormal.Location = New System.Drawing.Point(68, 9)
            Me.rbTipoEmisionNormal.Name = "rbTipoEmisionNormal"
            Me.rbTipoEmisionNormal.Size = New System.Drawing.Size(61, 17)
            Me.rbTipoEmisionNormal.TabIndex = 21
            Me.rbTipoEmisionNormal.TabStop = True
            Me.rbTipoEmisionNormal.Text = "NORMAL"
            Me.rbTipoEmisionNormal.UseVisualStyleBackColor = True
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(6, 9)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(63, 15)
            Me.Label22.TabIndex = 20
            Me.Label22.Text = "EMISIÓN:"
            '
            'gbTipoAnbiente
            '
            Me.gbTipoAnbiente.BackColor = System.Drawing.Color.White
            Me.gbTipoAnbiente.Controls.Add(Me.Label23)
            Me.gbTipoAnbiente.Controls.Add(Me.rbProduccion)
            Me.gbTipoAnbiente.Controls.Add(Me.rbPruebas)
            Me.gbTipoAnbiente.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoAnbiente.Location = New System.Drawing.Point(269, 27)
            Me.gbTipoAnbiente.Name = "gbTipoAnbiente"
            Me.gbTipoAnbiente.Size = New System.Drawing.Size(249, 32)
            Me.gbTipoAnbiente.TabIndex = 102
            Me.gbTipoAnbiente.TabStop = False
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.Location = New System.Drawing.Point(4, 9)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(70, 15)
            Me.Label23.TabIndex = 15
            Me.Label23.Text = "AMBIENTE:"
            '
            'rbProduccion
            '
            Me.rbProduccion.AutoSize = True
            Me.rbProduccion.Location = New System.Drawing.Point(140, 9)
            Me.rbProduccion.Name = "rbProduccion"
            Me.rbProduccion.Size = New System.Drawing.Size(85, 17)
            Me.rbProduccion.TabIndex = 1
            Me.rbProduccion.TabStop = True
            Me.rbProduccion.Text = "PRODUCCIÓN"
            Me.rbProduccion.UseVisualStyleBackColor = True
            '
            'rbPruebas
            '
            Me.rbPruebas.AutoSize = True
            Me.rbPruebas.Location = New System.Drawing.Point(74, 9)
            Me.rbPruebas.Name = "rbPruebas"
            Me.rbPruebas.Size = New System.Drawing.Size(67, 17)
            Me.rbPruebas.TabIndex = 0
            Me.rbPruebas.TabStop = True
            Me.rbPruebas.Text = "PRUEBAS"
            Me.rbPruebas.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.dgvDetalleFacturaVenta)
            Me.GroupBox1.Location = New System.Drawing.Point(1, 425)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(822, 100)
            Me.GroupBox1.TabIndex = 99
            Me.GroupBox1.TabStop = False
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.dgvFacturaVenta)
            Me.GroupBox2.Location = New System.Drawing.Point(1, 183)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(822, 157)
            Me.GroupBox2.TabIndex = 100
            Me.GroupBox2.TabStop = False
            '
            'gbClienteGeneral
            '
            Me.gbClienteGeneral.BackColor = System.Drawing.Color.White
            Me.gbClienteGeneral.Controls.Add(Me.lblRucClienteGenral)
            Me.gbClienteGeneral.Controls.Add(Me.lblLlevaContabilidadClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.Label2)
            Me.gbClienteGeneral.Controls.Add(Me.txtNombreComercialCliente)
            Me.gbClienteGeneral.Controls.Add(Me.Label10)
            Me.gbClienteGeneral.Controls.Add(Me.txtRucCiCliente)
            Me.gbClienteGeneral.Controls.Add(Me.lblIdClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.txtTelefonoClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.txtDireccionFacturacionCliente)
            Me.gbClienteGeneral.Controls.Add(Me.Label1)
            Me.gbClienteGeneral.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbClienteGeneral.Location = New System.Drawing.Point(1, 122)
            Me.gbClienteGeneral.Name = "gbClienteGeneral"
            Me.gbClienteGeneral.Size = New System.Drawing.Size(517, 44)
            Me.gbClienteGeneral.TabIndex = 104
            Me.gbClienteGeneral.TabStop = False
            '
            'lblRucClienteGenral
            '
            Me.lblRucClienteGenral.AutoSize = True
            Me.lblRucClienteGenral.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRucClienteGenral.Location = New System.Drawing.Point(343, 2)
            Me.lblRucClienteGenral.Name = "lblRucClienteGenral"
            Me.lblRucClienteGenral.Size = New System.Drawing.Size(25, 13)
            Me.lblRucClienteGenral.TabIndex = 11
            Me.lblRucClienteGenral.Text = "..."
            '
            'lblLlevaContabilidadClienteGeneral
            '
            Me.lblLlevaContabilidadClienteGeneral.AutoSize = True
            Me.lblLlevaContabilidadClienteGeneral.Location = New System.Drawing.Point(132, 2)
            Me.lblLlevaContabilidadClienteGeneral.Name = "lblLlevaContabilidadClienteGeneral"
            Me.lblLlevaContabilidadClienteGeneral.Size = New System.Drawing.Size(25, 13)
            Me.lblLlevaContabilidadClienteGeneral.TabIndex = 10
            Me.lblLlevaContabilidadClienteGeneral.Text = "..."
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(284, 2)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(49, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "RUC/CI:"
            '
            'txtNombreComercialCliente
            '
            Me.txtNombreComercialCliente.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialCliente.Location = New System.Drawing.Point(50, 17)
            Me.txtNombreComercialCliente.Name = "txtNombreComercialCliente"
            Me.txtNombreComercialCliente.Size = New System.Drawing.Size(460, 20)
            Me.txtNombreComercialCliente.TabIndex = 1
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(4, 20)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(49, 13)
            Me.Label10.TabIndex = 0
            Me.Label10.Text = "SR(ES):"
            '
            'txtRucCiCliente
            '
            Me.txtRucCiCliente.Location = New System.Drawing.Point(342, 17)
            Me.txtRucCiCliente.Name = "txtRucCiCliente"
            Me.txtRucCiCliente.Size = New System.Drawing.Size(110, 20)
            Me.txtRucCiCliente.TabIndex = 3
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(418, 22)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(13, 13)
            Me.lblIdClienteGeneral.TabIndex = 8
            Me.lblIdClienteGeneral.Text = "0"
            '
            'txtTelefonoClienteGeneral
            '
            Me.txtTelefonoClienteGeneral.Location = New System.Drawing.Point(399, 17)
            Me.txtTelefonoClienteGeneral.Name = "txtTelefonoClienteGeneral"
            Me.txtTelefonoClienteGeneral.ReadOnly = True
            Me.txtTelefonoClienteGeneral.Size = New System.Drawing.Size(110, 20)
            Me.txtTelefonoClienteGeneral.TabIndex = 7
            '
            'txtDireccionFacturacionCliente
            '
            Me.txtDireccionFacturacionCliente.Location = New System.Drawing.Point(50, 17)
            Me.txtDireccionFacturacionCliente.Name = "txtDireccionFacturacionCliente"
            Me.txtDireccionFacturacionCliente.ReadOnly = True
            Me.txtDireccionFacturacionCliente.Size = New System.Drawing.Size(282, 20)
            Me.txtDireccionFacturacionCliente.TabIndex = 5
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(5, 2)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(121, 13)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Lleva Contabilidad:"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.dtpFechaEmisionNotaCredito)
            Me.GroupBox3.Controls.Add(Me.Label29)
            Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(518, 122)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(305, 44)
            Me.GroupBox3.TabIndex = 105
            Me.GroupBox3.TabStop = False
            '
            'gbEmpresa
            '
            Me.gbEmpresa.BackColor = System.Drawing.Color.White
            Me.gbEmpresa.Controls.Add(Me.txtDireccionEmpresa)
            Me.gbEmpresa.Controls.Add(Me.lblIdEmpresa)
            Me.gbEmpresa.Controls.Add(Me.lblNombreComercialEmpresa)
            Me.gbEmpresa.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEmpresa.Location = New System.Drawing.Point(1, 57)
            Me.gbEmpresa.Name = "gbEmpresa"
            Me.gbEmpresa.Size = New System.Drawing.Size(573, 65)
            Me.gbEmpresa.TabIndex = 107
            Me.gbEmpresa.TabStop = False
            '
            'txtDireccionEmpresa
            '
            Me.txtDireccionEmpresa.BackColor = System.Drawing.Color.White
            Me.txtDireccionEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtDireccionEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccionEmpresa.Location = New System.Drawing.Point(6, 30)
            Me.txtDireccionEmpresa.Multiline = True
            Me.txtDireccionEmpresa.Name = "txtDireccionEmpresa"
            Me.txtDireccionEmpresa.Size = New System.Drawing.Size(561, 29)
            Me.txtDireccionEmpresa.TabIndex = 4
            Me.txtDireccionEmpresa.Text = "DIRECCIÓN EMPRESA"
            Me.txtDireccionEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblIdEmpresa
            '
            Me.lblIdEmpresa.AutoSize = True
            Me.lblIdEmpresa.Location = New System.Drawing.Point(6, 0)
            Me.lblIdEmpresa.Name = "lblIdEmpresa"
            Me.lblIdEmpresa.Size = New System.Drawing.Size(25, 13)
            Me.lblIdEmpresa.TabIndex = 3
            Me.lblIdEmpresa.Text = "..."
            '
            'lblNombreComercialEmpresa
            '
            Me.lblNombreComercialEmpresa.AutoSize = True
            Me.lblNombreComercialEmpresa.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreComercialEmpresa.Location = New System.Drawing.Point(283, 9)
            Me.lblNombreComercialEmpresa.Name = "lblNombreComercialEmpresa"
            Me.lblNombreComercialEmpresa.Size = New System.Drawing.Size(36, 19)
            Me.lblNombreComercialEmpresa.TabIndex = 0
            Me.lblNombreComercialEmpresa.Text = "..."
            '
            'gbNumeracion
            '
            Me.gbNumeracion.BackColor = System.Drawing.Color.White
            Me.gbNumeracion.Controls.Add(Me.Label4)
            Me.gbNumeracion.Controls.Add(Me.lblPtoEmisionFacturaEmpresa)
            Me.gbNumeracion.Controls.Add(Me.lblNroAutoSRIEmpresa)
            Me.gbNumeracion.Controls.Add(Me.Label5)
            Me.gbNumeracion.Controls.Add(Me.Label20)
            Me.gbNumeracion.Controls.Add(Me.lblNumeroSecuencialNotaCredito)
            Me.gbNumeracion.Controls.Add(Me.Label26)
            Me.gbNumeracion.Controls.Add(Me.lblEstablecimientoFacturaEmpresa)
            Me.gbNumeracion.Controls.Add(Me.Label27)
            Me.gbNumeracion.Controls.Add(Me.Label30)
            Me.gbNumeracion.Controls.Add(Me.lblRucEmpresa)
            Me.gbNumeracion.Controls.Add(Me.Label31)
            Me.gbNumeracion.Controls.Add(Me.Label33)
            Me.gbNumeracion.Controls.Add(Me.Label34)
            Me.gbNumeracion.Controls.Add(Me.Label35)
            Me.gbNumeracion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNumeracion.Location = New System.Drawing.Point(574, 57)
            Me.gbNumeracion.Name = "gbNumeracion"
            Me.gbNumeracion.Size = New System.Drawing.Size(249, 65)
            Me.gbNumeracion.TabIndex = 106
            Me.gbNumeracion.TabStop = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(165, 32)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(13, 13)
            Me.Label4.TabIndex = 14
            Me.Label4.Text = "-"
            '
            'lblPtoEmisionFacturaEmpresa
            '
            Me.lblPtoEmisionFacturaEmpresa.AutoSize = True
            Me.lblPtoEmisionFacturaEmpresa.Location = New System.Drawing.Point(141, 32)
            Me.lblPtoEmisionFacturaEmpresa.Name = "lblPtoEmisionFacturaEmpresa"
            Me.lblPtoEmisionFacturaEmpresa.Size = New System.Drawing.Size(25, 13)
            Me.lblPtoEmisionFacturaEmpresa.TabIndex = 13
            Me.lblPtoEmisionFacturaEmpresa.Text = "..."
            '
            'lblNroAutoSRIEmpresa
            '
            Me.lblNroAutoSRIEmpresa.AutoSize = True
            Me.lblNroAutoSRIEmpresa.Location = New System.Drawing.Point(137, 50)
            Me.lblNroAutoSRIEmpresa.Name = "lblNroAutoSRIEmpresa"
            Me.lblNroAutoSRIEmpresa.Size = New System.Drawing.Size(25, 13)
            Me.lblNroAutoSRIEmpresa.TabIndex = 12
            Me.lblNroAutoSRIEmpresa.Text = "..."
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 50)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(61, 13)
            Me.Label5.TabIndex = 11
            Me.Label5.Text = "AUT. SRI:"
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(111, 49)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(13, 13)
            Me.Label20.TabIndex = 10
            Me.Label20.Text = "|"
            '
            'lblNumeroSecuencialNotaCredito
            '
            Me.lblNumeroSecuencialNotaCredito.AutoSize = True
            Me.lblNumeroSecuencialNotaCredito.Location = New System.Drawing.Point(176, 32)
            Me.lblNumeroSecuencialNotaCredito.Name = "lblNumeroSecuencialNotaCredito"
            Me.lblNumeroSecuencialNotaCredito.Size = New System.Drawing.Size(25, 13)
            Me.lblNumeroSecuencialNotaCredito.TabIndex = 9
            Me.lblNumeroSecuencialNotaCredito.Text = "..."
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(131, 32)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(13, 13)
            Me.Label26.TabIndex = 8
            Me.Label26.Text = "-"
            '
            'lblEstablecimientoFacturaEmpresa
            '
            Me.lblEstablecimientoFacturaEmpresa.AutoSize = True
            Me.lblEstablecimientoFacturaEmpresa.Location = New System.Drawing.Point(106, 32)
            Me.lblEstablecimientoFacturaEmpresa.Name = "lblEstablecimientoFacturaEmpresa"
            Me.lblEstablecimientoFacturaEmpresa.Size = New System.Drawing.Size(25, 13)
            Me.lblEstablecimientoFacturaEmpresa.TabIndex = 6
            Me.lblEstablecimientoFacturaEmpresa.Text = "..."
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(83, 32)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(25, 13)
            Me.Label27.TabIndex = 5
            Me.Label27.Text = "Nº."
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(6, 30)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(77, 15)
            Me.Label30.TabIndex = 4
            Me.Label30.Text = "N. CRÉDITO"
            '
            'lblRucEmpresa
            '
            Me.lblRucEmpresa.AutoSize = True
            Me.lblRucEmpresa.Location = New System.Drawing.Point(137, 9)
            Me.lblRucEmpresa.Name = "lblRucEmpresa"
            Me.lblRucEmpresa.Size = New System.Drawing.Size(25, 13)
            Me.lblRucEmpresa.TabIndex = 3
            Me.lblRucEmpresa.Text = "..."
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Location = New System.Drawing.Point(6, 9)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(43, 13)
            Me.Label31.TabIndex = 2
            Me.Label31.Text = "R.U.C."
            '
            'Label33
            '
            Me.Label33.AutoSize = True
            Me.Label33.Location = New System.Drawing.Point(111, 9)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(13, 13)
            Me.Label33.TabIndex = 1
            Me.Label33.Text = "|"
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.ForeColor = System.Drawing.SystemColors.ControlDark
            Me.Label34.Location = New System.Drawing.Point(20, 14)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(217, 13)
            Me.Label34.TabIndex = 0
            Me.Label34.Text = "___________________________________"
            '
            'Label35
            '
            Me.Label35.AutoSize = True
            Me.Label35.ForeColor = System.Drawing.SystemColors.ControlDark
            Me.Label35.Location = New System.Drawing.Point(20, 35)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(217, 13)
            Me.Label35.TabIndex = 7
            Me.Label35.Text = "___________________________________"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardarSinFirmar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(824, 24)
            Me.MenuStrip1.TabIndex = 188
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevo
            '
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.NuevoRegistro
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(74, 20)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardarSinFirmar
            '
            Me.btnGuardarSinFirmar.Enabled = False
            Me.btnGuardarSinFirmar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarSinFirmar.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.btnGuardarSinFirmar.Name = "btnGuardarSinFirmar"
            Me.btnGuardarSinFirmar.Size = New System.Drawing.Size(87, 20)
            Me.btnGuardarSinFirmar.Text = "GUARDAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(89, 20)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'FormNotaCredito
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(824, 695)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbPtoEmision)
            Me.Controls.Add(Me.gbFechaNotaCredito)
            Me.Controls.Add(Me.gbValoresNotaCredito)
            Me.Controls.Add(Me.gbTipoAnbiente)
            Me.Controls.Add(Me.gbEmpresa)
            Me.Controls.Add(Me.gbNumeracion)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.gbClienteGeneral)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.panelDetalle)
            Me.Controls.Add(Me.gbTipoEmision)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbDatosComprobanteCompra)
            Me.Controls.Add(Me.gbValoresComprobanteCompra)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormNotaCredito"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REGISTRAR NOTA DE CRÉDITO"
            Me.gbFechaNotaCredito.ResumeLayout(False)
            Me.gbFechaNotaCredito.PerformLayout()
            Me.gbValoresNotaCredito.ResumeLayout(False)
            Me.gbValoresNotaCredito.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.panelDetalle.ResumeLayout(False)
            Me.panelDetalle.PerformLayout()
            Me.gbDatosComprobanteCompra.ResumeLayout(False)
            Me.gbDatosComprobanteCompra.PerformLayout()
            Me.gbValoresComprobanteCompra.ResumeLayout(False)
            Me.gbValoresComprobanteCompra.PerformLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbPtoEmision.ResumeLayout(False)
            Me.gbPtoEmision.PerformLayout()
            Me.gbTipoEmision.ResumeLayout(False)
            Me.gbTipoEmision.PerformLayout()
            Me.gbTipoAnbiente.ResumeLayout(False)
            Me.gbTipoAnbiente.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.gbClienteGeneral.ResumeLayout(False)
            Me.gbClienteGeneral.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.gbEmpresa.ResumeLayout(False)
            Me.gbEmpresa.PerformLayout()
            Me.gbNumeracion.ResumeLayout(False)
            Me.gbNumeracion.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbFechaNotaCredito As System.Windows.Forms.GroupBox
        Friend WithEvents txtRazonModificacionNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents Label48 As System.Windows.Forms.Label
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaEmisionNotaCredito As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents txtComprobanteModificaNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents gbValoresNotaCredito As System.Windows.Forms.GroupBox
        Friend WithEvents gbDatosComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents lblFechaEmisionFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents lblNumeroFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents gbValoresComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents lblSubTotal As System.Windows.Forms.Label
        Friend WithEvents lblTotalOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtIva As System.Windows.Forms.TextBox
        Friend WithEvents lblIvaOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblDescuentoOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
        Friend WithEvents lblSubtotal0OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
        Friend WithEvents lblSubtotal12OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal12 As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0 As System.Windows.Forms.TextBox
        Friend WithEvents lblTipoPagoFacturaCompra As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents txtDescuentoNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0NotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal12NotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtSubTotalNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtTotalNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtIvaNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents lblIva As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents lblSubtotalIva As System.Windows.Forms.Label
        Friend WithEvents dgvDetalleFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents gbPtoEmision As System.Windows.Forms.GroupBox
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents rbPtoEmision002 As System.Windows.Forms.RadioButton
        Friend WithEvents rbPtoEmision001 As System.Windows.Forms.RadioButton
        Friend WithEvents gbTipoEmision As System.Windows.Forms.GroupBox
        Friend WithEvents rbTipoEmisionIndisponibilidadSistema As System.Windows.Forms.RadioButton
        Friend WithEvents rbTipoEmisionNormal As System.Windows.Forms.RadioButton
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents gbTipoAnbiente As System.Windows.Forms.GroupBox
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents rbProduccion As System.Windows.Forms.RadioButton
        Friend WithEvents rbPruebas As System.Windows.Forms.RadioButton
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents panelDetalle As System.Windows.Forms.Panel
        Friend WithEvents lblDetalleSolicitud As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents gbClienteGeneral As System.Windows.Forms.GroupBox
        Friend WithEvents lblRucClienteGenral As System.Windows.Forms.Label
        Friend WithEvents lblLlevaContabilidadClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtNombreComercialCliente As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtRucCiCliente As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents txtTelefonoClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccionFacturacionCliente As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents gbEmpresa As System.Windows.Forms.GroupBox
        Friend WithEvents txtDireccionEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents lblIdEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblNombreComercialEmpresa As System.Windows.Forms.Label
        Friend WithEvents gbNumeracion As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblPtoEmisionFacturaEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblNroAutoSRIEmpresa As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents lblNumeroSecuencialNotaCredito As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents lblEstablecimientoFacturaEmpresa As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents lblRucEmpresa As System.Windows.Forms.Label
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents Label35 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarSinFirmar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace