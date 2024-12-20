Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormFacturaVenta
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
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFacturaVenta))
            Me.cmbIva = New System.Windows.Forms.ComboBox()
            Me.txtDescuento = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0 = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12 = New System.Windows.Forms.TextBox()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.txtSubTotal = New System.Windows.Forms.TextBox()
            Me.txtIva = New System.Windows.Forms.TextBox()
            Me.cmbDirecciones = New System.Windows.Forms.ComboBox()
            Me.lblRucCiCliente = New System.Windows.Forms.Label()
            Me.lblLlevaContabilidad = New System.Windows.Forms.Label()
            Me.txtNombreComercialCliente = New System.Windows.Forms.TextBox()
            Me.txtRucCiCliente = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.txtTelefonoClienteGeneral = New System.Windows.Forms.TextBox()
            Me.txtDireccionFacturacionCliente = New System.Windows.Forms.TextBox()
            Me.txtGuiaRemisionFacturaVenta = New System.Windows.Forms.TextBox()
            Me.dtpFechaEmisionFacturaVenta = New System.Windows.Forms.DateTimePicker()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.dgvDetalleFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.eliminarItem = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.idItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nombreProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cantidadProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.valorUnitarioProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.valorTotalProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblIdEmpresa = New System.Windows.Forms.Label()
            Me.txtSon = New System.Windows.Forms.TextBox()
            Me.txtObservacionesFactura = New System.Windows.Forms.TextBox()
            Me.cmbTipoPagoFactura = New System.Windows.Forms.ComboBox()
            Me.lblCodigoFormasPago = New System.Windows.Forms.Label()
            Me.rbCredito = New System.Windows.Forms.RadioButton()
            Me.rbContado = New System.Windows.Forms.RadioButton()
            Me.lblCodigoCuentaConcepto = New System.Windows.Forms.Label()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.rbProduccion = New System.Windows.Forms.RadioButton()
            Me.rbPruebas = New System.Windows.Forms.RadioButton()
            Me.rbTipoEmisionIndisponibilidadSistema = New System.Windows.Forms.RadioButton()
            Me.rbTipoEmisionNormal = New System.Windows.Forms.RadioButton()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.rbPtoEmision001 = New System.Windows.Forms.RadioButton()
            Me.rbPtoEmision002 = New System.Windows.Forms.RadioButton()
            Me.cbxConvenio = New System.Windows.Forms.ComboBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCompEgreso = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.txtDireccionEmpresa = New Krypton.Toolkit.KryptonLabel()
            Me.lblNombreComercialEmpresa = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.lblNroAutoSRIEmpresa = New System.Windows.Forms.Label()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.lblPtoEmisionFacturaEmpresa = New System.Windows.Forms.Label()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.lblNumeroFacturaVenta = New System.Windows.Forms.Label()
            Me.lblRucEmpresa = New System.Windows.Forms.Label()
            Me.lblEstablecimientoFacturaEmpresa = New System.Windows.Forms.Label()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.KryptonGroupBox4 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel18 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel19 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel21 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel22 = New Krypton.Toolkit.KryptonLabel()
            Me.lblSubtotalIva = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.lblIva = New System.Windows.Forms.Label()
            Me.KryptonGroupBox5 = New Krypton.Toolkit.KryptonGroupBox()
            Me.dgvAsientoDiarioFactura = New System.Windows.Forms.DataGridView()
            Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CONCEPTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DETALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DEBE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.HABER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.KryptonGroupBox6 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox7 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox8 = New Krypton.Toolkit.KryptonGroupBox()
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
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
            CType(Me.dgvAsientoDiarioFactura, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox6.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox6.Panel.SuspendLayout()
            Me.KryptonGroupBox6.SuspendLayout()
            CType(Me.KryptonGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox7.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox7.Panel.SuspendLayout()
            Me.KryptonGroupBox7.SuspendLayout()
            CType(Me.KryptonGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox8.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox8.Panel.SuspendLayout()
            Me.KryptonGroupBox8.SuspendLayout()
            Me.SuspendLayout()
            '
            'cmbIva
            '
            Me.cmbIva.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbIva.FormattingEnabled = True
            Me.cmbIva.Location = New System.Drawing.Point(501, 266)
            Me.cmbIva.Name = "cmbIva"
            Me.cmbIva.Size = New System.Drawing.Size(78, 21)
            Me.cmbIva.TabIndex = 22
            Me.cmbIva.Text = "IVA"
            '
            'txtDescuento
            '
            Me.txtDescuento.BackColor = System.Drawing.Color.White
            Me.txtDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescuento.Enabled = False
            Me.txtDescuento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuento.Location = New System.Drawing.Point(607, 215)
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.ReadOnly = True
            Me.txtDescuento.Size = New System.Drawing.Size(75, 21)
            Me.txtDescuento.TabIndex = 18
            Me.txtDescuento.Text = "0.00"
            Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0
            '
            Me.txtSubtotal0.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal0.Enabled = False
            Me.txtSubtotal0.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0.Location = New System.Drawing.Point(607, 214)
            Me.txtSubtotal0.Name = "txtSubtotal0"
            Me.txtSubtotal0.ReadOnly = True
            Me.txtSubtotal0.Size = New System.Drawing.Size(75, 21)
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
            Me.txtSubtotal12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12.Location = New System.Drawing.Point(607, 190)
            Me.txtSubtotal12.Name = "txtSubtotal12"
            Me.txtSubtotal12.ReadOnly = True
            Me.txtSubtotal12.Size = New System.Drawing.Size(75, 21)
            Me.txtSubtotal12.TabIndex = 16
            Me.txtSubtotal12.Text = "0.00"
            Me.txtSubtotal12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.White
            Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotal.Enabled = False
            Me.txtTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotal.Location = New System.Drawing.Point(607, 292)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.ReadOnly = True
            Me.txtTotal.Size = New System.Drawing.Size(75, 21)
            Me.txtTotal.TabIndex = 21
            Me.txtTotal.Text = "0.00"
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubTotal
            '
            Me.txtSubTotal.BackColor = System.Drawing.Color.White
            Me.txtSubTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubTotal.Enabled = False
            Me.txtSubTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotal.Location = New System.Drawing.Point(607, 240)
            Me.txtSubTotal.Name = "txtSubTotal"
            Me.txtSubTotal.ReadOnly = True
            Me.txtSubTotal.Size = New System.Drawing.Size(75, 21)
            Me.txtSubTotal.TabIndex = 19
            Me.txtSubTotal.Text = "0.00"
            Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIva
            '
            Me.txtIva.BackColor = System.Drawing.Color.White
            Me.txtIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIva.Enabled = False
            Me.txtIva.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIva.Location = New System.Drawing.Point(607, 266)
            Me.txtIva.Name = "txtIva"
            Me.txtIva.ReadOnly = True
            Me.txtIva.Size = New System.Drawing.Size(75, 21)
            Me.txtIva.TabIndex = 20
            Me.txtIva.Text = "0.00"
            Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'cmbDirecciones
            '
            Me.cmbDirecciones.BackColor = System.Drawing.Color.White
            Me.cmbDirecciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbDirecciones.DropDownWidth = 450
            Me.cmbDirecciones.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbDirecciones.FormattingEnabled = True
            Me.cmbDirecciones.Location = New System.Drawing.Point(67, 30)
            Me.cmbDirecciones.Name = "cmbDirecciones"
            Me.cmbDirecciones.Size = New System.Drawing.Size(312, 21)
            Me.cmbDirecciones.TabIndex = 13
            '
            'lblRucCiCliente
            '
            Me.lblRucCiCliente.AutoSize = True
            Me.lblRucCiCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblRucCiCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRucCiCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblRucCiCliente.Location = New System.Drawing.Point(556, 9)
            Me.lblRucCiCliente.Name = "lblRucCiCliente"
            Me.lblRucCiCliente.Size = New System.Drawing.Size(16, 13)
            Me.lblRucCiCliente.TabIndex = 11
            Me.lblRucCiCliente.Text = "..."
            '
            'lblLlevaContabilidad
            '
            Me.lblLlevaContabilidad.AutoSize = True
            Me.lblLlevaContabilidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblLlevaContabilidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLlevaContabilidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblLlevaContabilidad.Location = New System.Drawing.Point(700, 9)
            Me.lblLlevaContabilidad.Name = "lblLlevaContabilidad"
            Me.lblLlevaContabilidad.Size = New System.Drawing.Size(16, 13)
            Me.lblLlevaContabilidad.TabIndex = 10
            Me.lblLlevaContabilidad.Text = "..."
            '
            'txtNombreComercialCliente
            '
            Me.txtNombreComercialCliente.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialCliente.Location = New System.Drawing.Point(67, 5)
            Me.txtNombreComercialCliente.Name = "txtNombreComercialCliente"
            Me.txtNombreComercialCliente.Size = New System.Drawing.Size(312, 21)
            Me.txtNombreComercialCliente.TabIndex = 1
            '
            'txtRucCiCliente
            '
            Me.txtRucCiCliente.Location = New System.Drawing.Point(290, 5)
            Me.txtRucCiCliente.Name = "txtRucCiCliente"
            Me.txtRucCiCliente.Size = New System.Drawing.Size(74, 20)
            Me.txtRucCiCliente.TabIndex = 3
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(334, 34)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(13, 13)
            Me.lblIdClienteGeneral.TabIndex = 8
            Me.lblIdClienteGeneral.Text = "0"
            '
            'txtTelefonoClienteGeneral
            '
            Me.txtTelefonoClienteGeneral.Location = New System.Drawing.Point(307, 4)
            Me.txtTelefonoClienteGeneral.Name = "txtTelefonoClienteGeneral"
            Me.txtTelefonoClienteGeneral.ReadOnly = True
            Me.txtTelefonoClienteGeneral.Size = New System.Drawing.Size(69, 20)
            Me.txtTelefonoClienteGeneral.TabIndex = 7
            '
            'txtDireccionFacturacionCliente
            '
            Me.txtDireccionFacturacionCliente.Location = New System.Drawing.Point(70, 4)
            Me.txtDireccionFacturacionCliente.Name = "txtDireccionFacturacionCliente"
            Me.txtDireccionFacturacionCliente.ReadOnly = True
            Me.txtDireccionFacturacionCliente.Size = New System.Drawing.Size(282, 20)
            Me.txtDireccionFacturacionCliente.TabIndex = 5
            '
            'txtGuiaRemisionFacturaVenta
            '
            Me.txtGuiaRemisionFacturaVenta.Location = New System.Drawing.Point(431, 5)
            Me.txtGuiaRemisionFacturaVenta.Name = "txtGuiaRemisionFacturaVenta"
            Me.txtGuiaRemisionFacturaVenta.Size = New System.Drawing.Size(74, 20)
            Me.txtGuiaRemisionFacturaVenta.TabIndex = 9
            '
            'dtpFechaEmisionFacturaVenta
            '
            Me.dtpFechaEmisionFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionFacturaVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionFacturaVenta.Location = New System.Drawing.Point(429, 6)
            Me.dtpFechaEmisionFacturaVenta.Name = "dtpFechaEmisionFacturaVenta"
            Me.dtpFechaEmisionFacturaVenta.Size = New System.Drawing.Size(83, 21)
            Me.dtpFechaEmisionFacturaVenta.TabIndex = 11
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(641, 161)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(16, 13)
            Me.lblIdFacturaVenta.TabIndex = 4
            Me.lblIdFacturaVenta.Text = "..."
            '
            'dgvDetalleFacturaVenta
            '
            Me.dgvDetalleFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvDetalleFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDetalleFacturaVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvDetalleFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvDetalleFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvDetalleFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleFacturaVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminarItem, Me.idItem, Me.nombreProductoServicio, Me.cantidadProductoServicio, Me.valorUnitarioProductoServicio, Me.descuento, Me.valorTotalProductoServicio})
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDetalleFacturaVenta.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvDetalleFacturaVenta.GridColor = System.Drawing.Color.White
            Me.dgvDetalleFacturaVenta.Location = New System.Drawing.Point(3, 3)
            Me.dgvDetalleFacturaVenta.Name = "dgvDetalleFacturaVenta"
            Me.dgvDetalleFacturaVenta.RowHeadersVisible = False
            Me.dgvDetalleFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleFacturaVenta.Size = New System.Drawing.Size(717, 183)
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
            Me.nombreProductoServicio.Width = 300
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
            'lblIdEmpresa
            '
            Me.lblIdEmpresa.AutoSize = True
            Me.lblIdEmpresa.Location = New System.Drawing.Point(707, 84)
            Me.lblIdEmpresa.Name = "lblIdEmpresa"
            Me.lblIdEmpresa.Size = New System.Drawing.Size(16, 13)
            Me.lblIdEmpresa.TabIndex = 3
            Me.lblIdEmpresa.Text = "..."
            Me.lblIdEmpresa.Visible = False
            '
            'txtSon
            '
            Me.txtSon.BackColor = System.Drawing.Color.White
            Me.txtSon.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSon.Location = New System.Drawing.Point(67, 189)
            Me.txtSon.Name = "txtSon"
            Me.txtSon.ReadOnly = True
            Me.txtSon.Size = New System.Drawing.Size(312, 23)
            Me.txtSon.TabIndex = 1
            '
            'txtObservacionesFactura
            '
            Me.txtObservacionesFactura.BackColor = System.Drawing.Color.White
            Me.txtObservacionesFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionesFactura.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacionesFactura.Location = New System.Drawing.Point(103, 294)
            Me.txtObservacionesFactura.Name = "txtObservacionesFactura"
            Me.txtObservacionesFactura.Size = New System.Drawing.Size(305, 21)
            Me.txtObservacionesFactura.TabIndex = 5
            '
            'cmbTipoPagoFactura
            '
            Me.cmbTipoPagoFactura.BackColor = System.Drawing.Color.White
            Me.cmbTipoPagoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoPagoFactura.DropDownWidth = 450
            Me.cmbTipoPagoFactura.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipoPagoFactura.FormattingEnabled = True
            Me.cmbTipoPagoFactura.Items.AddRange(New Object() {"EFECTIVO", "CHEQUE", "NOTA DE CRÉDITO"})
            Me.cmbTipoPagoFactura.Location = New System.Drawing.Point(183, 216)
            Me.cmbTipoPagoFactura.Name = "cmbTipoPagoFactura"
            Me.cmbTipoPagoFactura.Size = New System.Drawing.Size(173, 21)
            Me.cmbTipoPagoFactura.TabIndex = 2
            '
            'lblCodigoFormasPago
            '
            Me.lblCodigoFormasPago.AutoSize = True
            Me.lblCodigoFormasPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblCodigoFormasPago.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigoFormasPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblCodigoFormasPago.Location = New System.Drawing.Point(372, 243)
            Me.lblCodigoFormasPago.Name = "lblCodigoFormasPago"
            Me.lblCodigoFormasPago.Size = New System.Drawing.Size(13, 13)
            Me.lblCodigoFormasPago.TabIndex = 3
            Me.lblCodigoFormasPago.Text = "0"
            '
            'rbCredito
            '
            Me.rbCredito.AutoSize = True
            Me.rbCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbCredito.Checked = True
            Me.rbCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCredito.Location = New System.Drawing.Point(15, 268)
            Me.rbCredito.Name = "rbCredito"
            Me.rbCredito.Size = New System.Drawing.Size(61, 17)
            Me.rbCredito.TabIndex = 3
            Me.rbCredito.TabStop = True
            Me.rbCredito.Text = "Credito"
            Me.rbCredito.UseVisualStyleBackColor = False
            '
            'rbContado
            '
            Me.rbContado.AutoSize = True
            Me.rbContado.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbContado.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbContado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbContado.Location = New System.Drawing.Point(15, 242)
            Me.rbContado.Name = "rbContado"
            Me.rbContado.Size = New System.Drawing.Size(66, 17)
            Me.rbContado.TabIndex = 2
            Me.rbContado.Text = "Contado"
            Me.rbContado.UseVisualStyleBackColor = False
            '
            'lblCodigoCuentaConcepto
            '
            Me.lblCodigoCuentaConcepto.AutoSize = True
            Me.lblCodigoCuentaConcepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblCodigoCuentaConcepto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigoCuentaConcepto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblCodigoCuentaConcepto.Location = New System.Drawing.Point(372, 219)
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
            Me.cmbConcepto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.Location = New System.Drawing.Point(183, 240)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(173, 21)
            Me.cmbConcepto.TabIndex = 0
            '
            'rbProduccion
            '
            Me.rbProduccion.AutoSize = True
            Me.rbProduccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbProduccion.Checked = True
            Me.rbProduccion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProduccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbProduccion.Location = New System.Drawing.Point(154, 4)
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
            Me.rbPruebas.Location = New System.Drawing.Point(76, 4)
            Me.rbPruebas.Name = "rbPruebas"
            Me.rbPruebas.Size = New System.Drawing.Size(66, 17)
            Me.rbPruebas.TabIndex = 0
            Me.rbPruebas.Text = "Pruebas"
            Me.rbPruebas.UseVisualStyleBackColor = False
            '
            'rbTipoEmisionIndisponibilidadSistema
            '
            Me.rbTipoEmisionIndisponibilidadSistema.AutoSize = True
            Me.rbTipoEmisionIndisponibilidadSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbTipoEmisionIndisponibilidadSistema.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTipoEmisionIndisponibilidadSistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTipoEmisionIndisponibilidadSistema.Location = New System.Drawing.Point(129, 4)
            Me.rbTipoEmisionIndisponibilidadSistema.Name = "rbTipoEmisionIndisponibilidadSistema"
            Me.rbTipoEmisionIndisponibilidadSistema.Size = New System.Drawing.Size(118, 17)
            Me.rbTipoEmisionIndisponibilidadSistema.TabIndex = 22
            Me.rbTipoEmisionIndisponibilidadSistema.Text = "Indisp del Sistema"
            Me.rbTipoEmisionIndisponibilidadSistema.UseVisualStyleBackColor = False
            '
            'rbTipoEmisionNormal
            '
            Me.rbTipoEmisionNormal.AutoSize = True
            Me.rbTipoEmisionNormal.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbTipoEmisionNormal.Checked = True
            Me.rbTipoEmisionNormal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTipoEmisionNormal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTipoEmisionNormal.Location = New System.Drawing.Point(65, 5)
            Me.rbTipoEmisionNormal.Name = "rbTipoEmisionNormal"
            Me.rbTipoEmisionNormal.Size = New System.Drawing.Size(62, 17)
            Me.rbTipoEmisionNormal.TabIndex = 21
            Me.rbTipoEmisionNormal.TabStop = True
            Me.rbTipoEmisionNormal.Text = "Normal"
            Me.rbTipoEmisionNormal.UseVisualStyleBackColor = False
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvFacturaVenta.GridColor = System.Drawing.Color.White
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(0, 0)
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.ReadOnly = True
            Me.dgvFacturaVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvFacturaVenta.RowHeadersVisible = False
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(268, 634)
            Me.dgvFacturaVenta.TabIndex = 89
            '
            'rbPtoEmision001
            '
            Me.rbPtoEmision001.AutoSize = True
            Me.rbPtoEmision001.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPtoEmision001.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPtoEmision001.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPtoEmision001.Location = New System.Drawing.Point(82, 5)
            Me.rbPtoEmision001.Name = "rbPtoEmision001"
            Me.rbPtoEmision001.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision001.TabIndex = 2
            Me.rbPtoEmision001.Text = "001"
            Me.rbPtoEmision001.UseVisualStyleBackColor = False
            '
            'rbPtoEmision002
            '
            Me.rbPtoEmision002.AutoSize = True
            Me.rbPtoEmision002.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPtoEmision002.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPtoEmision002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPtoEmision002.Location = New System.Drawing.Point(127, 5)
            Me.rbPtoEmision002.Name = "rbPtoEmision002"
            Me.rbPtoEmision002.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision002.TabIndex = 3
            Me.rbPtoEmision002.Text = "002"
            Me.rbPtoEmision002.UseVisualStyleBackColor = False
            '
            'cbxConvenio
            '
            Me.cbxConvenio.BackColor = System.Drawing.Color.White
            Me.cbxConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxConvenio.DropDownWidth = 450
            Me.cbxConvenio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxConvenio.FormattingEnabled = True
            Me.cbxConvenio.Location = New System.Drawing.Point(260, 266)
            Me.cbxConvenio.Name = "cbxConvenio"
            Me.cbxConvenio.Size = New System.Drawing.Size(148, 21)
            Me.cbxConvenio.TabIndex = 2
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
            Me.MenuStrip1.Size = New System.Drawing.Size(1007, 32)
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
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(6, 2)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel3.TabIndex = 6
            Me.KryptonLabel3.Values.Text = "Emision"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel2.TabIndex = 4
            Me.KryptonLabel2.Values.Text = "Ambiente"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(3, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Pto Emision"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(4, 79)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtDireccionEmpresa)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblNombreComercialEmpresa)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblNroAutoSRIEmpresa)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblPtoEmisionFacturaEmpresa)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblNumeroFacturaVenta)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblRucEmpresa)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblEstablecimientoFacturaEmpresa)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(730, 74)
            Me.KryptonGroupBox2.TabIndex = 191
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
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(384, 24)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel7.TabIndex = 6
            Me.KryptonLabel7.Values.Text = "Factura"
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
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(384, 2)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel8.TabIndex = 5
            Me.KryptonLabel8.Values.Text = "RUC"
            '
            'lblNumeroFacturaVenta
            '
            Me.lblNumeroFacturaVenta.AutoSize = True
            Me.lblNumeroFacturaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblNumeroFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroFacturaVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblNumeroFacturaVenta.Location = New System.Drawing.Point(523, 26)
            Me.lblNumeroFacturaVenta.Name = "lblNumeroFacturaVenta"
            Me.lblNumeroFacturaVenta.Size = New System.Drawing.Size(16, 13)
            Me.lblNumeroFacturaVenta.TabIndex = 9
            Me.lblNumeroFacturaVenta.Text = "..."
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
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(4, 155)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.cmbDirecciones)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblLlevaContabilidad)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dtpFechaEmisionFacturaVenta)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblRucCiCliente)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtNombreComercialCliente)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtDireccionFacturacionCliente)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtGuiaRemisionFacturaVenta)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTelefonoClienteGeneral)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtRucCiCliente)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblIdClienteGeneral)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(730, 84)
            Me.KryptonGroupBox3.TabIndex = 192
            Me.KryptonGroupBox3.Values.Heading = "Datos Cliente"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(4, 32)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(26, 20)
            Me.KryptonLabel11.TabIndex = 49
            Me.KryptonLabel11.Values.Text = "Dir"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(656, 6)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(43, 20)
            Me.KryptonLabel10.TabIndex = 48
            Me.KryptonLabel10.Values.Text = "Conta"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(516, 6)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel9.TabIndex = 47
            Me.KryptonLabel9.Values.Text = "RUC"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(382, 6)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel4.TabIndex = 46
            Me.KryptonLabel4.Values.Text = "Fecha"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(7, 6)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel5.TabIndex = 45
            Me.KryptonLabel5.Values.Text = "Sr(es)"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
            Me.Label1.Location = New System.Drawing.Point(584, 161)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(46, 15)
            Me.Label1.TabIndex = 193
            Me.Label1.Text = "Factura"
            '
            'KryptonGroupBox4
            '
            Me.KryptonGroupBox4.CaptionOverlap = 0R
            Me.KryptonGroupBox4.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox4.Location = New System.Drawing.Point(7, 240)
            Me.KryptonGroupBox4.Name = "KryptonGroupBox4"
            '
            'KryptonGroupBox4.Panel
            '
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtObservacionesFactura)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel18)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbIva)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtDescuento)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel19)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel21)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtSubtotal12)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtTotal)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel22)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtSubTotal)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.lblSubtotalIva)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cbxConvenio)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.lblCodigoCuentaConcepto)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtIva)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.lblCodigoFormasPago)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbConcepto)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbTipoPagoFactura)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.rbCredito)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.rbContado)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtSon)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dgvDetalleFacturaVenta)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtSubtotal0)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.lblIva)
            Me.KryptonGroupBox4.Size = New System.Drawing.Size(727, 346)
            Me.KryptonGroupBox4.TabIndex = 194
            Me.KryptonGroupBox4.Values.Heading = "Detalle Factura"
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(7, 294)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.Size = New System.Drawing.Size(90, 20)
            Me.KryptonLabel18.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel18.TabIndex = 215
            Me.KryptonLabel18.Values.Text = "Observaciones"
            '
            'KryptonLabel19
            '
            Me.KryptonLabel19.Location = New System.Drawing.Point(498, 293)
            Me.KryptonLabel19.Name = "KryptonLabel19"
            Me.KryptonLabel19.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel19.TabIndex = 214
            Me.KryptonLabel19.Values.Text = "Total"
            '
            'KryptonLabel21
            '
            Me.KryptonLabel21.Location = New System.Drawing.Point(499, 241)
            Me.KryptonLabel21.Name = "KryptonLabel21"
            Me.KryptonLabel21.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel21.TabIndex = 213
            Me.KryptonLabel21.Values.Text = "SubTotal"
            '
            'KryptonLabel22
            '
            Me.KryptonLabel22.Location = New System.Drawing.Point(499, 216)
            Me.KryptonLabel22.Name = "KryptonLabel22"
            Me.KryptonLabel22.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel22.TabIndex = 212
            Me.KryptonLabel22.Values.Text = "Descuento"
            '
            'lblSubtotalIva
            '
            Me.lblSubtotalIva.Location = New System.Drawing.Point(499, 192)
            Me.lblSubtotalIva.Name = "lblSubtotalIva"
            Me.lblSubtotalIva.Size = New System.Drawing.Size(75, 20)
            Me.lblSubtotalIva.TabIndex = 211
            Me.lblSubtotalIva.Values.Text = "SubTotal 12"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(101, 268)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(152, 20)
            Me.KryptonLabel16.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel16.TabIndex = 85
            Me.KryptonLabel16.Values.Text = "Convenio Debito Bancario"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(100, 242)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel15.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel15.TabIndex = 84
            Me.KryptonLabel15.Values.Text = "Concepto"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(101, 216)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(76, 20)
            Me.KryptonLabel13.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel13.TabIndex = 83
            Me.KryptonLabel13.Values.Text = "Forma Pago"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(7, 216)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel14.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel14.TabIndex = 82
            Me.KryptonLabel14.Values.Text = "Pago"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(7, 192)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel12.TabIndex = 80
            Me.KryptonLabel12.Values.Text = "Son"
            '
            'lblIva
            '
            Me.lblIva.AutoSize = True
            Me.lblIva.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIva.Location = New System.Drawing.Point(506, 269)
            Me.lblIva.Name = "lblIva"
            Me.lblIva.Size = New System.Drawing.Size(67, 13)
            Me.lblIva.TabIndex = 13
            Me.lblIva.Text = "IVA (12%):"
            '
            'KryptonGroupBox5
            '
            Me.KryptonGroupBox5.CaptionOverlap = 0R
            Me.KryptonGroupBox5.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox5.Location = New System.Drawing.Point(740, 37)
            Me.KryptonGroupBox5.Name = "KryptonGroupBox5"
            '
            'KryptonGroupBox5.Panel
            '
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.dgvFacturaVenta)
            Me.KryptonGroupBox5.Size = New System.Drawing.Size(272, 658)
            Me.KryptonGroupBox5.TabIndex = 195
            Me.KryptonGroupBox5.Values.Heading = "Historial de facturacion"
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
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientoDiarioFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvAsientoDiarioFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAsientoDiarioFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.CUENTA, Me.CONCEPTO, Me.DETALLE, Me.DEBE, Me.HABER})
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientoDiarioFactura.DefaultCellStyle = DataGridViewCellStyle12
            Me.dgvAsientoDiarioFactura.GridColor = System.Drawing.Color.White
            Me.dgvAsientoDiarioFactura.Location = New System.Drawing.Point(7, 589)
            Me.dgvAsientoDiarioFactura.Name = "dgvAsientoDiarioFactura"
            Me.dgvAsientoDiarioFactura.ReadOnly = True
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientoDiarioFactura.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvAsientoDiarioFactura.RowHeadersVisible = False
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Roboto", 8.0!)
            Me.dgvAsientoDiarioFactura.RowsDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvAsientoDiarioFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientoDiarioFactura.Size = New System.Drawing.Size(727, 106)
            Me.dgvAsientoDiarioFactura.TabIndex = 196
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
            'KryptonGroupBox6
            '
            Me.KryptonGroupBox6.CaptionOverlap = 0R
            Me.KryptonGroupBox6.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox6.Location = New System.Drawing.Point(4, 37)
            Me.KryptonGroupBox6.Name = "KryptonGroupBox6"
            '
            'KryptonGroupBox6.Panel
            '
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.rbPtoEmision001)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.rbPtoEmision002)
            Me.KryptonGroupBox6.Size = New System.Drawing.Size(183, 36)
            Me.KryptonGroupBox6.TabIndex = 197
            Me.KryptonGroupBox6.Values.Heading = ""
            '
            'KryptonGroupBox7
            '
            Me.KryptonGroupBox7.CaptionOverlap = 0R
            Me.KryptonGroupBox7.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox7.Location = New System.Drawing.Point(443, 37)
            Me.KryptonGroupBox7.Name = "KryptonGroupBox7"
            '
            'KryptonGroupBox7.Panel
            '
            Me.KryptonGroupBox7.Panel.Controls.Add(Me.rbTipoEmisionIndisponibilidadSistema)
            Me.KryptonGroupBox7.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox7.Panel.Controls.Add(Me.rbTipoEmisionNormal)
            Me.KryptonGroupBox7.Size = New System.Drawing.Size(291, 36)
            Me.KryptonGroupBox7.TabIndex = 198
            Me.KryptonGroupBox7.Values.Heading = ""
            '
            'KryptonGroupBox8
            '
            Me.KryptonGroupBox8.CaptionOverlap = 0R
            Me.KryptonGroupBox8.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox8.Location = New System.Drawing.Point(193, 37)
            Me.KryptonGroupBox8.Name = "KryptonGroupBox8"
            '
            'KryptonGroupBox8.Panel
            '
            Me.KryptonGroupBox8.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox8.Panel.Controls.Add(Me.rbPruebas)
            Me.KryptonGroupBox8.Panel.Controls.Add(Me.rbProduccion)
            Me.KryptonGroupBox8.Size = New System.Drawing.Size(244, 36)
            Me.KryptonGroupBox8.TabIndex = 199
            Me.KryptonGroupBox8.Values.Heading = ""
            '
            'FormFacturaVenta
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1016, 696)
            Me.Controls.Add(Me.KryptonGroupBox8)
            Me.Controls.Add(Me.KryptonGroupBox7)
            Me.Controls.Add(Me.KryptonGroupBox6)
            Me.Controls.Add(Me.dgvAsientoDiarioFactura)
            Me.Controls.Add(Me.KryptonGroupBox5)
            Me.Controls.Add(Me.KryptonGroupBox4)
            Me.Controls.Add(Me.lblIdFacturaVenta)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.lblIdEmpresa)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.Panel2)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormFacturaVenta"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "FACTURA VENTA"
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
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
            Me.KryptonGroupBox4.Panel.PerformLayout()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.ResumeLayout(False)
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.ResumeLayout(False)
            CType(Me.dgvAsientoDiarioFactura, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox6.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox6.Panel.ResumeLayout(False)
            Me.KryptonGroupBox6.Panel.PerformLayout()
            CType(Me.KryptonGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox6.ResumeLayout(False)
            CType(Me.KryptonGroupBox7.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox7.Panel.ResumeLayout(False)
            Me.KryptonGroupBox7.Panel.PerformLayout()
            CType(Me.KryptonGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox7.ResumeLayout(False)
            CType(Me.KryptonGroupBox8.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox8.Panel.ResumeLayout(False)
            Me.KryptonGroupBox8.Panel.PerformLayout()
            CType(Me.KryptonGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox8.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0 As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal12 As System.Windows.Forms.TextBox
        Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents txtIva As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreComercialCliente As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaEmisionFacturaVenta As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtGuiaRemisionFacturaVenta As System.Windows.Forms.TextBox
        Friend WithEvents txtTelefonoClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccionFacturacionCliente As System.Windows.Forms.TextBox
        Friend WithEvents txtRucCiCliente As System.Windows.Forms.TextBox
        Friend WithEvents dgvDetalleFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents lblIdEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents txtSon As System.Windows.Forms.TextBox
        Friend WithEvents txtObservacionesFactura As System.Windows.Forms.TextBox
        Friend WithEvents cmbTipoPagoFactura As System.Windows.Forms.ComboBox
        Friend WithEvents rbCredito As System.Windows.Forms.RadioButton
        Friend WithEvents rbContado As System.Windows.Forms.RadioButton
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents lblCodigoCuentaConcepto As System.Windows.Forms.Label
        Friend WithEvents lblLlevaContabilidad As System.Windows.Forms.Label
        Friend WithEvents rbPruebas As System.Windows.Forms.RadioButton
        Friend WithEvents lblRucCiCliente As System.Windows.Forms.Label
        Friend WithEvents rbTipoEmisionIndisponibilidadSistema As System.Windows.Forms.RadioButton
        Friend WithEvents rbTipoEmisionNormal As System.Windows.Forms.RadioButton
        Friend WithEvents rbProduccion As System.Windows.Forms.RadioButton
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents lblCodigoFormasPago As System.Windows.Forms.Label
        Friend WithEvents rbPtoEmision001 As System.Windows.Forms.RadioButton
        Friend WithEvents rbPtoEmision002 As System.Windows.Forms.RadioButton
        Friend WithEvents cbxConvenio As System.Windows.Forms.ComboBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnCompEgreso As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents cmbDirecciones As System.Windows.Forms.ComboBox
        Friend WithEvents cmbIva As System.Windows.Forms.ComboBox
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents txtDireccionEmpresa As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblNombreComercialEmpresa As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblNroAutoSRIEmpresa As Label
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblPtoEmisionFacturaEmpresa As Label
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblNumeroFacturaVenta As Label
        Friend WithEvents lblRucEmpresa As Label
        Friend WithEvents lblEstablecimientoFacturaEmpresa As Label
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents Label1 As Label
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox4 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents eliminarItem As DataGridViewButtonColumn
        Friend WithEvents idItem As DataGridViewTextBoxColumn
        Friend WithEvents nombreProductoServicio As DataGridViewTextBoxColumn
        Friend WithEvents cantidadProductoServicio As DataGridViewTextBoxColumn
        Friend WithEvents valorUnitarioProductoServicio As DataGridViewTextBoxColumn
        Friend WithEvents descuento As DataGridViewTextBoxColumn
        Friend WithEvents valorTotalProductoServicio As DataGridViewTextBoxColumn
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel19 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel21 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel22 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblSubtotalIva As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel18 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblIva As Label
        Friend WithEvents KryptonGroupBox5 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents dgvAsientoDiarioFactura As DataGridView
        Friend WithEvents CODIGO As DataGridViewTextBoxColumn
        Friend WithEvents CUENTA As DataGridViewTextBoxColumn
        Friend WithEvents CONCEPTO As DataGridViewTextBoxColumn
        Friend WithEvents DETALLE As DataGridViewTextBoxColumn
        Friend WithEvents DEBE As DataGridViewTextBoxColumn
        Friend WithEvents HABER As DataGridViewTextBoxColumn
        Friend WithEvents KryptonGroupBox6 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox7 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox8 As Krypton.Toolkit.KryptonGroupBox
    End Class
End Namespace