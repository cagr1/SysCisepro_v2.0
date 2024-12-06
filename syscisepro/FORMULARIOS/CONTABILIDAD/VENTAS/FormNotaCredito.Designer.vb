Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormNotaCredito
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
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNotaCredito))
            Me.txtRazonModificacionNotaCredito = New System.Windows.Forms.TextBox()
            Me.txtComprobanteModificaNotaCredito = New System.Windows.Forms.TextBox()
            Me.dtpFechaEmisionNotaCredito = New System.Windows.Forms.DateTimePicker()
            Me.txtDescuentoNotaCredito = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0NotaCredito = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12NotaCredito = New System.Windows.Forms.TextBox()
            Me.txtSubTotalNotaCredito = New System.Windows.Forms.TextBox()
            Me.txtTotalNotaCredito = New System.Windows.Forms.TextBox()
            Me.txtIvaNotaCredito = New System.Windows.Forms.TextBox()
            Me.lblFechaEmisionFacturaVenta = New System.Windows.Forms.Label()
            Me.lblNumeroFacturaVenta = New System.Windows.Forms.Label()
            Me.txtSubtotal0 = New System.Windows.Forms.TextBox()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.txtIva = New System.Windows.Forms.TextBox()
            Me.txtSubtotal = New System.Windows.Forms.TextBox()
            Me.txtDescuento = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12 = New System.Windows.Forms.TextBox()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.dgvDetalleFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.rbPtoEmision002 = New System.Windows.Forms.RadioButton()
            Me.rbPtoEmision001 = New System.Windows.Forms.RadioButton()
            Me.rbTipoEmisionIndisponibilidadSistema = New System.Windows.Forms.RadioButton()
            Me.rbTipoEmisionNormal = New System.Windows.Forms.RadioButton()
            Me.rbProduccion = New System.Windows.Forms.RadioButton()
            Me.rbPruebas = New System.Windows.Forms.RadioButton()
            Me.txtNombreComercialCliente = New System.Windows.Forms.TextBox()
            Me.txtRucCiCliente = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.txtTelefonoClienteGeneral = New System.Windows.Forms.TextBox()
            Me.txtDireccionFacturacionCliente = New System.Windows.Forms.TextBox()
            Me.lblIdEmpresa = New System.Windows.Forms.Label()
            Me.lblPtoEmisionFacturaEmpresa = New System.Windows.Forms.Label()
            Me.lblNroAutoSRIEmpresa = New System.Windows.Forms.Label()
            Me.lblNumeroSecuencialNotaCredito = New System.Windows.Forms.Label()
            Me.lblEstablecimientoFacturaEmpresa = New System.Windows.Forms.Label()
            Me.lblRucEmpresa = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarSinFirmar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.SpaceSeparatorVertical2 = New ReaLTaiizor.Controls.SpaceSeparatorVertical()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.SpaceSeparatorVertical1 = New ReaLTaiizor.Controls.SpaceSeparatorVertical()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.txtDireccionEmpresa = New Krypton.Toolkit.KryptonLabel()
            Me.lblNombreComercialEmpresa = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.lblIvaOrdenCompra = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel17 = New Krypton.Toolkit.KryptonLabel()
            Me.lblSubtotal12OrdenCompra = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.lblLlevaContabilidadClienteGeneral = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.lblRucClienteGenral = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblTipoPagoFacturaCompra = New System.Windows.Forms.Label()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.KryptonGroupBox4 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox5 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel19 = New Krypton.Toolkit.KryptonLabel()
            Me.lblIva = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel21 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel22 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel23 = New Krypton.Toolkit.KryptonLabel()
            Me.lblSubtotalIva = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel18 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox4.Panel.SuspendLayout()
            Me.KryptonGroupBox4.SuspendLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox5.Panel.SuspendLayout()
            Me.KryptonGroupBox5.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtRazonModificacionNotaCredito
            '
            Me.txtRazonModificacionNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtRazonModificacionNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazonModificacionNotaCredito.Font = New System.Drawing.Font("Roboto", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazonModificacionNotaCredito.Location = New System.Drawing.Point(103, 34)
            Me.txtRazonModificacionNotaCredito.Multiline = True
            Me.txtRazonModificacionNotaCredito.Name = "txtRazonModificacionNotaCredito"
            Me.txtRazonModificacionNotaCredito.Size = New System.Drawing.Size(223, 42)
            Me.txtRazonModificacionNotaCredito.TabIndex = 43
            '
            'txtComprobanteModificaNotaCredito
            '
            Me.txtComprobanteModificaNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtComprobanteModificaNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtComprobanteModificaNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtComprobanteModificaNotaCredito.Location = New System.Drawing.Point(103, 3)
            Me.txtComprobanteModificaNotaCredito.Name = "txtComprobanteModificaNotaCredito"
            Me.txtComprobanteModificaNotaCredito.Size = New System.Drawing.Size(146, 21)
            Me.txtComprobanteModificaNotaCredito.TabIndex = 42
            '
            'dtpFechaEmisionNotaCredito
            '
            Me.dtpFechaEmisionNotaCredito.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionNotaCredito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionNotaCredito.Location = New System.Drawing.Point(413, 3)
            Me.dtpFechaEmisionNotaCredito.Name = "dtpFechaEmisionNotaCredito"
            Me.dtpFechaEmisionNotaCredito.Size = New System.Drawing.Size(87, 21)
            Me.dtpFechaEmisionNotaCredito.TabIndex = 41
            '
            'txtDescuentoNotaCredito
            '
            Me.txtDescuentoNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtDescuentoNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescuentoNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuentoNotaCredito.Location = New System.Drawing.Point(516, 49)
            Me.txtDescuentoNotaCredito.Name = "txtDescuentoNotaCredito"
            Me.txtDescuentoNotaCredito.Size = New System.Drawing.Size(107, 21)
            Me.txtDescuentoNotaCredito.TabIndex = 29
            Me.txtDescuentoNotaCredito.Text = "0.00"
            Me.txtDescuentoNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0NotaCredito
            '
            Me.txtSubtotal0NotaCredito.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0NotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal0NotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0NotaCredito.Location = New System.Drawing.Point(516, 26)
            Me.txtSubtotal0NotaCredito.Name = "txtSubtotal0NotaCredito"
            Me.txtSubtotal0NotaCredito.Size = New System.Drawing.Size(107, 21)
            Me.txtSubtotal0NotaCredito.TabIndex = 28
            Me.txtSubtotal0NotaCredito.Text = "0.00"
            Me.txtSubtotal0NotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal12NotaCredito
            '
            Me.txtSubtotal12NotaCredito.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12NotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal12NotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12NotaCredito.Location = New System.Drawing.Point(516, 3)
            Me.txtSubtotal12NotaCredito.Name = "txtSubtotal12NotaCredito"
            Me.txtSubtotal12NotaCredito.Size = New System.Drawing.Size(107, 21)
            Me.txtSubtotal12NotaCredito.TabIndex = 27
            Me.txtSubtotal12NotaCredito.Text = "0.00"
            Me.txtSubtotal12NotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubTotalNotaCredito
            '
            Me.txtSubTotalNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtSubTotalNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubTotalNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotalNotaCredito.Location = New System.Drawing.Point(516, 72)
            Me.txtSubTotalNotaCredito.Name = "txtSubTotalNotaCredito"
            Me.txtSubTotalNotaCredito.Size = New System.Drawing.Size(107, 21)
            Me.txtSubTotalNotaCredito.TabIndex = 30
            Me.txtSubTotalNotaCredito.Text = "0.00"
            Me.txtSubTotalNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalNotaCredito
            '
            Me.txtTotalNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtTotalNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalNotaCredito.Location = New System.Drawing.Point(516, 118)
            Me.txtTotalNotaCredito.Name = "txtTotalNotaCredito"
            Me.txtTotalNotaCredito.Size = New System.Drawing.Size(107, 21)
            Me.txtTotalNotaCredito.TabIndex = 33
            Me.txtTotalNotaCredito.Text = "0.00"
            Me.txtTotalNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaNotaCredito
            '
            Me.txtIvaNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtIvaNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIvaNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIvaNotaCredito.Location = New System.Drawing.Point(516, 95)
            Me.txtIvaNotaCredito.Name = "txtIvaNotaCredito"
            Me.txtIvaNotaCredito.Size = New System.Drawing.Size(107, 21)
            Me.txtIvaNotaCredito.TabIndex = 32
            Me.txtIvaNotaCredito.Text = "0.00"
            Me.txtIvaNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFechaEmisionFacturaVenta
            '
            Me.lblFechaEmisionFacturaVenta.AutoSize = True
            Me.lblFechaEmisionFacturaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblFechaEmisionFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaEmisionFacturaVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblFechaEmisionFacturaVenta.Location = New System.Drawing.Point(100, 189)
            Me.lblFechaEmisionFacturaVenta.Name = "lblFechaEmisionFacturaVenta"
            Me.lblFechaEmisionFacturaVenta.Size = New System.Drawing.Size(65, 13)
            Me.lblFechaEmisionFacturaVenta.TabIndex = 23
            Me.lblFechaEmisionFacturaVenta.Text = "00/00/0000"
            Me.lblFechaEmisionFacturaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNumeroFacturaVenta
            '
            Me.lblNumeroFacturaVenta.AutoSize = True
            Me.lblNumeroFacturaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblNumeroFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroFacturaVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblNumeroFacturaVenta.Location = New System.Drawing.Point(100, 168)
            Me.lblNumeroFacturaVenta.Name = "lblNumeroFacturaVenta"
            Me.lblNumeroFacturaVenta.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroFacturaVenta.TabIndex = 21
            Me.lblNumeroFacturaVenta.Text = "0"
            '
            'txtSubtotal0
            '
            Me.txtSubtotal0.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal0.Enabled = False
            Me.txtSubtotal0.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0.Location = New System.Drawing.Point(320, 189)
            Me.txtSubtotal0.Name = "txtSubtotal0"
            Me.txtSubtotal0.Size = New System.Drawing.Size(59, 14)
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
            Me.txtTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotal.Location = New System.Drawing.Point(614, 189)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(59, 14)
            Me.txtTotal.TabIndex = 32
            Me.txtTotal.Text = "0.00"
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIva
            '
            Me.txtIva.BackColor = System.Drawing.Color.White
            Me.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIva.Enabled = False
            Me.txtIva.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIva.Location = New System.Drawing.Point(614, 171)
            Me.txtIva.Name = "txtIva"
            Me.txtIva.Size = New System.Drawing.Size(59, 14)
            Me.txtIva.TabIndex = 31
            Me.txtIva.Text = "0.00"
            Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal
            '
            Me.txtSubtotal.BackColor = System.Drawing.Color.White
            Me.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal.Enabled = False
            Me.txtSubtotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal.Location = New System.Drawing.Point(470, 168)
            Me.txtSubtotal.Name = "txtSubtotal"
            Me.txtSubtotal.Size = New System.Drawing.Size(59, 14)
            Me.txtSubtotal.TabIndex = 30
            Me.txtSubtotal.Text = "0.00"
            Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDescuento
            '
            Me.txtDescuento.BackColor = System.Drawing.Color.White
            Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescuento.Enabled = False
            Me.txtDescuento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuento.Location = New System.Drawing.Point(470, 190)
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.Size = New System.Drawing.Size(59, 14)
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
            Me.txtSubtotal12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12.Location = New System.Drawing.Point(320, 168)
            Me.txtSubtotal12.Name = "txtSubtotal12"
            Me.txtSubtotal12.Size = New System.Drawing.Size(59, 14)
            Me.txtSubtotal12.TabIndex = 27
            Me.txtSubtotal12.Text = "0.00"
            Me.txtSubtotal12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturaVenta.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvFacturaVenta.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(3, 30)
            Me.dgvFacturaVenta.MultiSelect = False
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvFacturaVenta.RowHeadersVisible = False
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvFacturaVenta.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvFacturaVenta.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(719, 130)
            Me.dgvFacturaVenta.TabIndex = 86
            '
            'dgvDetalleFacturaVenta
            '
            Me.dgvDetalleFacturaVenta.AllowUserToAddRows = False
            Me.dgvDetalleFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvDetalleFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvDetalleFacturaVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvDetalleFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvDetalleFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvDetalleFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDetalleFacturaVenta.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgvDetalleFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvDetalleFacturaVenta.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetalleFacturaVenta.Location = New System.Drawing.Point(0, 0)
            Me.dgvDetalleFacturaVenta.Name = "dgvDetalleFacturaVenta"
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleFacturaVenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvDetalleFacturaVenta.RowHeadersVisible = False
            Me.dgvDetalleFacturaVenta.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvDetalleFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleFacturaVenta.Size = New System.Drawing.Size(726, 101)
            Me.dgvDetalleFacturaVenta.TabIndex = 96
            '
            'rbPtoEmision002
            '
            Me.rbPtoEmision002.AutoSize = True
            Me.rbPtoEmision002.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPtoEmision002.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPtoEmision002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPtoEmision002.Location = New System.Drawing.Point(128, 7)
            Me.rbPtoEmision002.Name = "rbPtoEmision002"
            Me.rbPtoEmision002.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision002.TabIndex = 3
            Me.rbPtoEmision002.TabStop = True
            Me.rbPtoEmision002.Text = "002"
            Me.rbPtoEmision002.UseVisualStyleBackColor = False
            '
            'rbPtoEmision001
            '
            Me.rbPtoEmision001.AutoSize = True
            Me.rbPtoEmision001.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPtoEmision001.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPtoEmision001.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPtoEmision001.Location = New System.Drawing.Point(81, 7)
            Me.rbPtoEmision001.Name = "rbPtoEmision001"
            Me.rbPtoEmision001.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision001.TabIndex = 2
            Me.rbPtoEmision001.TabStop = True
            Me.rbPtoEmision001.Text = "001"
            Me.rbPtoEmision001.UseVisualStyleBackColor = False
            '
            'rbTipoEmisionIndisponibilidadSistema
            '
            Me.rbTipoEmisionIndisponibilidadSistema.AutoSize = True
            Me.rbTipoEmisionIndisponibilidadSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbTipoEmisionIndisponibilidadSistema.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTipoEmisionIndisponibilidadSistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTipoEmisionIndisponibilidadSistema.Location = New System.Drawing.Point(589, 5)
            Me.rbTipoEmisionIndisponibilidadSistema.Name = "rbTipoEmisionIndisponibilidadSistema"
            Me.rbTipoEmisionIndisponibilidadSistema.Size = New System.Drawing.Size(100, 17)
            Me.rbTipoEmisionIndisponibilidadSistema.TabIndex = 22
            Me.rbTipoEmisionIndisponibilidadSistema.TabStop = True
            Me.rbTipoEmisionIndisponibilidadSistema.Text = "Indisp Sistema"
            Me.rbTipoEmisionIndisponibilidadSistema.UseVisualStyleBackColor = False
            '
            'rbTipoEmisionNormal
            '
            Me.rbTipoEmisionNormal.AutoSize = True
            Me.rbTipoEmisionNormal.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbTipoEmisionNormal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTipoEmisionNormal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTipoEmisionNormal.Location = New System.Drawing.Point(513, 5)
            Me.rbTipoEmisionNormal.Name = "rbTipoEmisionNormal"
            Me.rbTipoEmisionNormal.Size = New System.Drawing.Size(62, 17)
            Me.rbTipoEmisionNormal.TabIndex = 21
            Me.rbTipoEmisionNormal.TabStop = True
            Me.rbTipoEmisionNormal.Text = "Normal"
            Me.rbTipoEmisionNormal.UseVisualStyleBackColor = False
            '
            'rbProduccion
            '
            Me.rbProduccion.AutoSize = True
            Me.rbProduccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbProduccion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProduccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbProduccion.Location = New System.Drawing.Point(331, 7)
            Me.rbProduccion.Name = "rbProduccion"
            Me.rbProduccion.Size = New System.Drawing.Size(81, 17)
            Me.rbProduccion.TabIndex = 1
            Me.rbProduccion.TabStop = True
            Me.rbProduccion.Text = "Produccion"
            Me.rbProduccion.UseVisualStyleBackColor = False
            '
            'rbPruebas
            '
            Me.rbPruebas.AutoSize = True
            Me.rbPruebas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPruebas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPruebas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPruebas.Location = New System.Drawing.Point(259, 7)
            Me.rbPruebas.Name = "rbPruebas"
            Me.rbPruebas.Size = New System.Drawing.Size(66, 17)
            Me.rbPruebas.TabIndex = 0
            Me.rbPruebas.TabStop = True
            Me.rbPruebas.Text = "Pruebas"
            Me.rbPruebas.UseVisualStyleBackColor = False
            '
            'txtNombreComercialCliente
            '
            Me.txtNombreComercialCliente.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialCliente.Location = New System.Drawing.Point(44, 2)
            Me.txtNombreComercialCliente.Name = "txtNombreComercialCliente"
            Me.txtNombreComercialCliente.Size = New System.Drawing.Size(319, 21)
            Me.txtNombreComercialCliente.TabIndex = 1
            '
            'txtRucCiCliente
            '
            Me.txtRucCiCliente.Location = New System.Drawing.Point(240, 3)
            Me.txtRucCiCliente.Name = "txtRucCiCliente"
            Me.txtRucCiCliente.Size = New System.Drawing.Size(110, 20)
            Me.txtRucCiCliente.TabIndex = 3
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(315, 7)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(13, 13)
            Me.lblIdClienteGeneral.TabIndex = 8
            Me.lblIdClienteGeneral.Text = "0"
            '
            'txtTelefonoClienteGeneral
            '
            Me.txtTelefonoClienteGeneral.Location = New System.Drawing.Point(244, 3)
            Me.txtTelefonoClienteGeneral.Name = "txtTelefonoClienteGeneral"
            Me.txtTelefonoClienteGeneral.ReadOnly = True
            Me.txtTelefonoClienteGeneral.Size = New System.Drawing.Size(110, 20)
            Me.txtTelefonoClienteGeneral.TabIndex = 7
            '
            'txtDireccionFacturacionCliente
            '
            Me.txtDireccionFacturacionCliente.Location = New System.Drawing.Point(75, 3)
            Me.txtDireccionFacturacionCliente.Name = "txtDireccionFacturacionCliente"
            Me.txtDireccionFacturacionCliente.ReadOnly = True
            Me.txtDireccionFacturacionCliente.Size = New System.Drawing.Size(282, 20)
            Me.txtDireccionFacturacionCliente.TabIndex = 5
            '
            'lblIdEmpresa
            '
            Me.lblIdEmpresa.AutoSize = True
            Me.lblIdEmpresa.Location = New System.Drawing.Point(698, 79)
            Me.lblIdEmpresa.Name = "lblIdEmpresa"
            Me.lblIdEmpresa.Size = New System.Drawing.Size(16, 13)
            Me.lblIdEmpresa.TabIndex = 3
            Me.lblIdEmpresa.Text = "..."
            Me.lblIdEmpresa.Visible = False
            '
            'lblPtoEmisionFacturaEmpresa
            '
            Me.lblPtoEmisionFacturaEmpresa.AutoSize = True
            Me.lblPtoEmisionFacturaEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblPtoEmisionFacturaEmpresa.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPtoEmisionFacturaEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblPtoEmisionFacturaEmpresa.Location = New System.Drawing.Point(492, 26)
            Me.lblPtoEmisionFacturaEmpresa.Name = "lblPtoEmisionFacturaEmpresa"
            Me.lblPtoEmisionFacturaEmpresa.Size = New System.Drawing.Size(16, 13)
            Me.lblPtoEmisionFacturaEmpresa.TabIndex = 13
            Me.lblPtoEmisionFacturaEmpresa.Text = "..."
            '
            'lblNroAutoSRIEmpresa
            '
            Me.lblNroAutoSRIEmpresa.AutoSize = True
            Me.lblNroAutoSRIEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblNroAutoSRIEmpresa.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroAutoSRIEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblNroAutoSRIEmpresa.Location = New System.Drawing.Point(636, 6)
            Me.lblNroAutoSRIEmpresa.Name = "lblNroAutoSRIEmpresa"
            Me.lblNroAutoSRIEmpresa.Size = New System.Drawing.Size(16, 13)
            Me.lblNroAutoSRIEmpresa.TabIndex = 12
            Me.lblNroAutoSRIEmpresa.Text = "..."
            '
            'lblNumeroSecuencialNotaCredito
            '
            Me.lblNumeroSecuencialNotaCredito.AutoSize = True
            Me.lblNumeroSecuencialNotaCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblNumeroSecuencialNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroSecuencialNotaCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblNumeroSecuencialNotaCredito.Location = New System.Drawing.Point(523, 26)
            Me.lblNumeroSecuencialNotaCredito.Name = "lblNumeroSecuencialNotaCredito"
            Me.lblNumeroSecuencialNotaCredito.Size = New System.Drawing.Size(16, 13)
            Me.lblNumeroSecuencialNotaCredito.TabIndex = 9
            Me.lblNumeroSecuencialNotaCredito.Text = "..."
            '
            'lblEstablecimientoFacturaEmpresa
            '
            Me.lblEstablecimientoFacturaEmpresa.AutoSize = True
            Me.lblEstablecimientoFacturaEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblEstablecimientoFacturaEmpresa.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstablecimientoFacturaEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblEstablecimientoFacturaEmpresa.Location = New System.Drawing.Point(463, 26)
            Me.lblEstablecimientoFacturaEmpresa.Name = "lblEstablecimientoFacturaEmpresa"
            Me.lblEstablecimientoFacturaEmpresa.Size = New System.Drawing.Size(16, 13)
            Me.lblEstablecimientoFacturaEmpresa.TabIndex = 6
            Me.lblEstablecimientoFacturaEmpresa.Text = "..."
            '
            'lblRucEmpresa
            '
            Me.lblRucEmpresa.AutoSize = True
            Me.lblRucEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblRucEmpresa.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRucEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblRucEmpresa.Location = New System.Drawing.Point(463, 4)
            Me.lblRucEmpresa.Name = "lblRucEmpresa"
            Me.lblRucEmpresa.Size = New System.Drawing.Size(16, 13)
            Me.lblRucEmpresa.TabIndex = 3
            Me.lblRucEmpresa.Text = "..."
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardarSinFirmar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(732, 32)
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
            'btnGuardarSinFirmar
            '
            Me.btnGuardarSinFirmar.Enabled = False
            Me.btnGuardarSinFirmar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarSinFirmar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarSinFirmar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarSinFirmar.Name = "btnGuardarSinFirmar"
            Me.btnGuardarSinFirmar.Size = New System.Drawing.Size(95, 28)
            Me.btnGuardarSinFirmar.Text = "GUARDAR"
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
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(1, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbTipoEmisionIndisponibilidadSistema)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbTipoEmisionNormal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbProduccion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbPtoEmision002)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbPruebas)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.SpaceSeparatorVertical2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbPtoEmision001)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.SpaceSeparatorVertical1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(730, 36)
            Me.KryptonGroupBox1.TabIndex = 189
            Me.KryptonGroupBox1.Values.Heading = ""
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(456, 4)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel3.TabIndex = 6
            Me.KryptonLabel3.Values.Text = "Emision"
            '
            'SpaceSeparatorVertical2
            '
            Me.SpaceSeparatorVertical2.Customization = "Kioq/yoqKv8jIyP/Kioq/w=="
            Me.SpaceSeparatorVertical2.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.SpaceSeparatorVertical2.Image = Nothing
            Me.SpaceSeparatorVertical2.Location = New System.Drawing.Point(439, 5)
            Me.SpaceSeparatorVertical2.Name = "SpaceSeparatorVertical2"
            Me.SpaceSeparatorVertical2.NoRounding = False
            Me.SpaceSeparatorVertical2.Size = New System.Drawing.Size(4, 15)
            Me.SpaceSeparatorVertical2.TabIndex = 5
            Me.SpaceSeparatorVertical2.Text = "SpaceSeparatorVertical2"
            Me.SpaceSeparatorVertical2.Transparent = False
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(190, 4)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel2.TabIndex = 4
            Me.KryptonLabel2.Values.Text = "Ambiente"
            '
            'SpaceSeparatorVertical1
            '
            Me.SpaceSeparatorVertical1.Customization = "Kioq/yoqKv8jIyP/Kioq/w=="
            Me.SpaceSeparatorVertical1.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.SpaceSeparatorVertical1.Image = Nothing
            Me.SpaceSeparatorVertical1.Location = New System.Drawing.Point(176, 6)
            Me.SpaceSeparatorVertical1.Name = "SpaceSeparatorVertical1"
            Me.SpaceSeparatorVertical1.NoRounding = False
            Me.SpaceSeparatorVertical1.Size = New System.Drawing.Size(4, 15)
            Me.SpaceSeparatorVertical1.TabIndex = 3
            Me.SpaceSeparatorVertical1.Text = "SpaceSeparatorVertical1"
            Me.SpaceSeparatorVertical1.Transparent = False
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(4, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Pto Emision"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(1, 71)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtDireccionEmpresa)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblNombreComercialEmpresa)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblNroAutoSRIEmpresa)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblPtoEmisionFacturaEmpresa)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblNumeroSecuencialNotaCredito)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblRucEmpresa)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblEstablecimientoFacturaEmpresa)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(730, 74)
            Me.KryptonGroupBox2.TabIndex = 190
            Me.KryptonGroupBox2.Values.Heading = "Datos Empresa"
            '
            'txtDireccionEmpresa
            '
            Me.txtDireccionEmpresa.Location = New System.Drawing.Point(6, 24)
            Me.txtDireccionEmpresa.Name = "txtDireccionEmpresa"
            Me.txtDireccionEmpresa.Size = New System.Drawing.Size(58, 17)
            Me.txtDireccionEmpresa.StateCommon.ShortText.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccionEmpresa.TabIndex = 16
            Me.txtDireccionEmpresa.Values.Text = "Direccion"
            '
            'lblNombreComercialEmpresa
            '
            Me.lblNombreComercialEmpresa.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.lblNombreComercialEmpresa.Location = New System.Drawing.Point(7, 3)
            Me.lblNombreComercialEmpresa.Name = "lblNombreComercialEmpresa"
            Me.lblNombreComercialEmpresa.Size = New System.Drawing.Size(31, 20)
            Me.lblNombreComercialEmpresa.TabIndex = 15
            Me.lblNombreComercialEmpresa.Values.Text = "CIA"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(572, 2)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(58, 20)
            Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel6.TabIndex = 14
            Me.KryptonLabel6.Values.Text = "Auto SRI"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(384, 24)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(70, 20)
            Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel5.TabIndex = 6
            Me.KryptonLabel5.Values.Text = "No Credito"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(384, 2)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel4.TabIndex = 5
            Me.KryptonLabel4.Values.Text = "RUC"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(1, 146)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotal)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSubtotal0)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblIvaOrdenCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtIva)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSubtotal)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblSubtotal12OrdenCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblFechaEmisionFacturaVenta)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtDescuento)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblNumeroFacturaVenta)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSubtotal12)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dgvFacturaVenta)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblLlevaContabilidadClienteGeneral)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblRucClienteGenral)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dtpFechaEmisionNotaCredito)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtNombreComercialCliente)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtDireccionFacturacionCliente)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtRucCiCliente)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblIdClienteGeneral)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTelefonoClienteGeneral)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(730, 241)
            Me.KryptonGroupBox3.TabIndex = 191
            Me.KryptonGroupBox3.Values.Heading = "Datos Cliente"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(552, 184)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel13.TabIndex = 204
            Me.KryptonLabel13.Values.Text = "Total"
            '
            'lblIvaOrdenCompra
            '
            Me.lblIvaOrdenCompra.Location = New System.Drawing.Point(552, 165)
            Me.lblIvaOrdenCompra.Name = "lblIvaOrdenCompra"
            Me.lblIvaOrdenCompra.Size = New System.Drawing.Size(29, 20)
            Me.lblIvaOrdenCompra.TabIndex = 203
            Me.lblIvaOrdenCompra.Values.Text = "IVA"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(396, 165)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel15.TabIndex = 202
            Me.KryptonLabel15.Values.Text = "SubTotal"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(396, 186)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel16.TabIndex = 201
            Me.KryptonLabel16.Values.Text = "Descuento"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(236, 184)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(69, 20)
            Me.KryptonLabel17.TabIndex = 200
            Me.KryptonLabel17.Values.Text = "SubTotal 0"
            '
            'lblSubtotal12OrdenCompra
            '
            Me.lblSubtotal12OrdenCompra.Location = New System.Drawing.Point(236, 165)
            Me.lblSubtotal12OrdenCompra.Name = "lblSubtotal12OrdenCompra"
            Me.lblSubtotal12OrdenCompra.Size = New System.Drawing.Size(75, 20)
            Me.lblSubtotal12OrdenCompra.TabIndex = 199
            Me.lblSubtotal12OrdenCompra.Values.Text = "SubTotal 12"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(5, 183)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(88, 20)
            Me.KryptonLabel12.TabIndex = 88
            Me.KryptonLabel12.Values.Text = "Fecha Emision"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(7, 162)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(70, 20)
            Me.KryptonLabel11.TabIndex = 87
            Me.KryptonLabel11.Values.Text = "No Factura"
            '
            'lblLlevaContabilidadClienteGeneral
            '
            Me.lblLlevaContabilidadClienteGeneral.Location = New System.Drawing.Point(685, 3)
            Me.lblLlevaContabilidadClienteGeneral.Name = "lblLlevaContabilidadClienteGeneral"
            Me.lblLlevaContabilidadClienteGeneral.Size = New System.Drawing.Size(16, 20)
            Me.lblLlevaContabilidadClienteGeneral.TabIndex = 45
            Me.lblLlevaContabilidadClienteGeneral.Values.Text = ".."
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(642, 3)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(43, 20)
            Me.KryptonLabel10.TabIndex = 44
            Me.KryptonLabel10.Values.Text = "Conta"
            '
            'lblRucClienteGenral
            '
            Me.lblRucClienteGenral.Location = New System.Drawing.Point(539, 3)
            Me.lblRucClienteGenral.Name = "lblRucClienteGenral"
            Me.lblRucClienteGenral.Size = New System.Drawing.Size(16, 20)
            Me.lblRucClienteGenral.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
            Me.lblRucClienteGenral.TabIndex = 43
            Me.lblRucClienteGenral.Values.Text = ".."
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(504, 3)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel9.TabIndex = 42
            Me.KryptonLabel9.Values.Text = "RUC"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(367, 3)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel8.TabIndex = 9
            Me.KryptonLabel8.Values.Text = "Fecha"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(2, 3)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel7.TabIndex = 7
            Me.KryptonLabel7.Values.Text = "Sr(es)"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
            Me.Label1.Location = New System.Drawing.Point(390, 149)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(46, 15)
            Me.Label1.TabIndex = 192
            Me.Label1.Text = "Factura"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
            Me.Label4.Location = New System.Drawing.Point(578, 150)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(30, 15)
            Me.Label4.TabIndex = 194
            Me.Label4.Text = "Tipo"
            '
            'lblTipoPagoFacturaCompra
            '
            Me.lblTipoPagoFacturaCompra.AutoSize = True
            Me.lblTipoPagoFacturaCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblTipoPagoFacturaCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipoPagoFacturaCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblTipoPagoFacturaCompra.Location = New System.Drawing.Point(615, 152)
            Me.lblTipoPagoFacturaCompra.Name = "lblTipoPagoFacturaCompra"
            Me.lblTipoPagoFacturaCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblTipoPagoFacturaCompra.TabIndex = 195
            Me.lblTipoPagoFacturaCompra.Text = "..."
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdFacturaVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(467, 151)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(16, 13)
            Me.lblIdFacturaVenta.TabIndex = 196
            Me.lblIdFacturaVenta.Text = "..."
            '
            'KryptonGroupBox4
            '
            Me.KryptonGroupBox4.CaptionOverlap = 0R
            Me.KryptonGroupBox4.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox4.Location = New System.Drawing.Point(1, 388)
            Me.KryptonGroupBox4.Name = "KryptonGroupBox4"
            '
            'KryptonGroupBox4.Panel
            '
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dgvDetalleFacturaVenta)
            Me.KryptonGroupBox4.Size = New System.Drawing.Size(730, 125)
            Me.KryptonGroupBox4.TabIndex = 197
            Me.KryptonGroupBox4.Values.Heading = "Detalle Factura / Nota de Credito"
            '
            'KryptonGroupBox5
            '
            Me.KryptonGroupBox5.CaptionOverlap = 0R
            Me.KryptonGroupBox5.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox5.Location = New System.Drawing.Point(0, 514)
            Me.KryptonGroupBox5.Name = "KryptonGroupBox5"
            '
            'KryptonGroupBox5.Panel
            '
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtSubTotalNotaCredito)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtTotalNotaCredito)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtDescuentoNotaCredito)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtIvaNotaCredito)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.KryptonLabel19)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtSubtotal0NotaCredito)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.lblIva)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtSubtotal12NotaCredito)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.KryptonLabel21)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.KryptonLabel22)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.KryptonLabel23)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.lblSubtotalIva)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.KryptonLabel18)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtRazonModificacionNotaCredito)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtComprobanteModificaNotaCredito)
            Me.KryptonGroupBox5.Size = New System.Drawing.Size(731, 170)
            Me.KryptonGroupBox5.TabIndex = 198
            Me.KryptonGroupBox5.Values.Heading = "Datos Comprobante de venta"
            '
            'KryptonLabel19
            '
            Me.KryptonLabel19.Location = New System.Drawing.Point(413, 118)
            Me.KryptonLabel19.Name = "KryptonLabel19"
            Me.KryptonLabel19.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel19.TabIndex = 210
            Me.KryptonLabel19.Values.Text = "Total"
            '
            'lblIva
            '
            Me.lblIva.Location = New System.Drawing.Point(413, 95)
            Me.lblIva.Name = "lblIva"
            Me.lblIva.Size = New System.Drawing.Size(29, 20)
            Me.lblIva.TabIndex = 209
            Me.lblIva.Values.Text = "IVA"
            '
            'KryptonLabel21
            '
            Me.KryptonLabel21.Location = New System.Drawing.Point(413, 49)
            Me.KryptonLabel21.Name = "KryptonLabel21"
            Me.KryptonLabel21.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel21.TabIndex = 208
            Me.KryptonLabel21.Values.Text = "SubTotal"
            '
            'KryptonLabel22
            '
            Me.KryptonLabel22.Location = New System.Drawing.Point(413, 72)
            Me.KryptonLabel22.Name = "KryptonLabel22"
            Me.KryptonLabel22.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel22.TabIndex = 207
            Me.KryptonLabel22.Values.Text = "Descuento"
            '
            'KryptonLabel23
            '
            Me.KryptonLabel23.Location = New System.Drawing.Point(413, 26)
            Me.KryptonLabel23.Name = "KryptonLabel23"
            Me.KryptonLabel23.Size = New System.Drawing.Size(69, 20)
            Me.KryptonLabel23.TabIndex = 206
            Me.KryptonLabel23.Values.Text = "SubTotal 0"
            '
            'lblSubtotalIva
            '
            Me.lblSubtotalIva.Location = New System.Drawing.Point(413, 3)
            Me.lblSubtotalIva.Name = "lblSubtotalIva"
            Me.lblSubtotalIva.Size = New System.Drawing.Size(75, 20)
            Me.lblSubtotalIva.TabIndex = 205
            Me.lblSubtotalIva.Values.Text = "SubTotal 12"
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(1, 29)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.Size = New System.Drawing.Size(80, 20)
            Me.KryptonLabel18.TabIndex = 89
            Me.KryptonLabel18.Values.Text = "Razon Modif"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(1, 3)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(83, 20)
            Me.KryptonLabel14.TabIndex = 88
            Me.KryptonLabel14.Values.Text = "Compr Modif"
            '
            'FormNotaCredito
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(732, 685)
            Me.Controls.Add(Me.KryptonGroupBox5)
            Me.Controls.Add(Me.KryptonGroupBox4)
            Me.Controls.Add(Me.lblIdFacturaVenta)
            Me.Controls.Add(Me.lblTipoPagoFacturaCompra)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.lblIdEmpresa)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormNotaCredito"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REGISTRAR NOTA DE CRÉDITO"
            Me.TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Classic
            Me.TopMost = True
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            Me.KryptonGroupBox2.Panel.PerformLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            Me.KryptonGroupBox3.Panel.PerformLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.ResumeLayout(False)
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.Panel.ResumeLayout(False)
            Me.KryptonGroupBox5.Panel.PerformLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtRazonModificacionNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaEmisionNotaCredito As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtComprobanteModificaNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaEmisionFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents lblNumeroFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents txtIva As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
        Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal12 As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0 As System.Windows.Forms.TextBox
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents txtDescuentoNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0NotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal12NotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtSubTotalNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtIvaNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents dgvDetalleFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents rbPtoEmision002 As System.Windows.Forms.RadioButton
        Friend WithEvents rbPtoEmision001 As System.Windows.Forms.RadioButton
        Friend WithEvents rbTipoEmisionIndisponibilidadSistema As System.Windows.Forms.RadioButton
        Friend WithEvents rbTipoEmisionNormal As System.Windows.Forms.RadioButton
        Friend WithEvents rbProduccion As System.Windows.Forms.RadioButton
        Friend WithEvents rbPruebas As System.Windows.Forms.RadioButton
        Friend WithEvents txtNombreComercialCliente As System.Windows.Forms.TextBox
        Friend WithEvents txtRucCiCliente As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents txtTelefonoClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccionFacturacionCliente As System.Windows.Forms.TextBox
        Friend WithEvents lblIdEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblPtoEmisionFacturaEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblNroAutoSRIEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblNumeroSecuencialNotaCredito As System.Windows.Forms.Label
        Friend WithEvents lblEstablecimientoFacturaEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblRucEmpresa As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarSinFirmar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents SpaceSeparatorVertical2 As ReaLTaiizor.Controls.SpaceSeparatorVertical
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents SpaceSeparatorVertical1 As ReaLTaiizor.Controls.SpaceSeparatorVertical
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtDireccionEmpresa As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblNombreComercialEmpresa As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblLlevaContabilidadClienteGeneral As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblRucClienteGenral As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents Label1 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents lblTipoPagoFacturaCompra As Label
        Friend WithEvents lblIdFacturaVenta As Label
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblIvaOrdenCompra As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel17 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblSubtotal12OrdenCompra As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox4 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox5 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel19 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblIva As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel21 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel22 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel23 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblSubtotalIva As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel18 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace