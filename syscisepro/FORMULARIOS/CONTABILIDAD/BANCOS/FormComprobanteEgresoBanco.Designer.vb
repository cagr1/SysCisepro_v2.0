Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormComprobanteEgresoBanco
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComprobanteEgresoBanco))
            Me.txtNumeroComprobanteEgresoBanco = New System.Windows.Forms.TextBox()
            Me.txtPagadoA = New System.Windows.Forms.TextBox()
            Me.txtActividad = New System.Windows.Forms.TextBox()
            Me.txtRazonComprobanteEgresoBanco = New System.Windows.Forms.TextBox()
            Me.txtRucCi = New System.Windows.Forms.TextBox()
            Me.txtNumeroCheque = New System.Windows.Forms.TextBox()
            Me.btnEditarValores = New System.Windows.Forms.Button()
            Me.btnAgregarBancosComprobante = New System.Windows.Forms.Button()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.cmbTipoPago = New System.Windows.Forms.ComboBox()
            Me.btnBuscarPersonal = New System.Windows.Forms.Button()
            Me.txtFacturaReceptor = New System.Windows.Forms.TextBox()
            Me.dtpFechaComprobanteEgreso = New System.Windows.Forms.DateTimePicker()
            Me.lblIdComprobanteEgresoBancos = New System.Windows.Forms.Label()
            Me.dgvComprobanteEgresoBanco = New System.Windows.Forms.DataGridView()
            Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CONCEPTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DETALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DEBE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.HABER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_CC = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtValorComprobanteEgresoBancos = New System.Windows.Forms.TextBox()
            Me.txtConceptoComprobanteEgreso = New System.Windows.Forms.TextBox()
            Me.cmbCuentasContables = New System.Windows.Forms.ComboBox()
            Me.btnAgregarConceptoComprobante = New System.Windows.Forms.Button()
            Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
            Me.chkTransferenciaInterna = New System.Windows.Forms.CheckBox()
            Me.txtTotalHaber = New System.Windows.Forms.TextBox()
            Me.txtTotalDebe = New System.Windows.Forms.TextBox()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.chkActivar = New System.Windows.Forms.CheckBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialProveedor = New System.Windows.Forms.TextBox()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.dgvComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.dgvCompEgresoPagosCompCompra = New System.Windows.Forms.DataGridView()
            Me.ID_CE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_CC_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_PCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MONTO_PCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NRO_REG_ASIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ContextMenuStripClicDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ToolStripMenuItemEliminar = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.dgvPagosComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.gbFacturaVenta = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvComprobanteEgresoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvCompEgresoPagosCompCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.dgvPagosComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gbFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gbFacturaVenta.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbFacturaVenta.Panel.SuspendLayout()
            Me.gbFacturaVenta.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtNumeroComprobanteEgresoBanco
            '
            Me.txtNumeroComprobanteEgresoBanco.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteEgresoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroComprobanteEgresoBanco.Location = New System.Drawing.Point(38, 15)
            Me.txtNumeroComprobanteEgresoBanco.Name = "txtNumeroComprobanteEgresoBanco"
            Me.txtNumeroComprobanteEgresoBanco.Size = New System.Drawing.Size(45, 21)
            Me.txtNumeroComprobanteEgresoBanco.TabIndex = 13
            '
            'txtPagadoA
            '
            Me.txtPagadoA.BackColor = System.Drawing.Color.White
            Me.txtPagadoA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPagadoA.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPagadoA.Location = New System.Drawing.Point(235, 143)
            Me.txtPagadoA.Name = "txtPagadoA"
            Me.txtPagadoA.Size = New System.Drawing.Size(195, 21)
            Me.txtPagadoA.TabIndex = 14
            '
            'txtActividad
            '
            Me.txtActividad.BackColor = System.Drawing.Color.White
            Me.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtActividad.Enabled = False
            Me.txtActividad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtActividad.Location = New System.Drawing.Point(307, 16)
            Me.txtActividad.Name = "txtActividad"
            Me.txtActividad.Size = New System.Drawing.Size(123, 21)
            Me.txtActividad.TabIndex = 15
            Me.txtActividad.Text = "1010102"
            '
            'txtRazonComprobanteEgresoBanco
            '
            Me.txtRazonComprobanteEgresoBanco.BackColor = System.Drawing.Color.White
            Me.txtRazonComprobanteEgresoBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazonComprobanteEgresoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazonComprobanteEgresoBanco.Location = New System.Drawing.Point(307, 80)
            Me.txtRazonComprobanteEgresoBanco.Name = "txtRazonComprobanteEgresoBanco"
            Me.txtRazonComprobanteEgresoBanco.Size = New System.Drawing.Size(124, 21)
            Me.txtRazonComprobanteEgresoBanco.TabIndex = 17
            '
            'txtRucCi
            '
            Me.txtRucCi.BackColor = System.Drawing.Color.White
            Me.txtRucCi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucCi.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRucCi.Location = New System.Drawing.Point(70, 143)
            Me.txtRucCi.Name = "txtRucCi"
            Me.txtRucCi.Size = New System.Drawing.Size(101, 21)
            Me.txtRucCi.TabIndex = 20
            '
            'txtNumeroCheque
            '
            Me.txtNumeroCheque.BackColor = System.Drawing.Color.White
            Me.txtNumeroCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroCheque.Location = New System.Drawing.Point(379, 236)
            Me.txtNumeroCheque.Name = "txtNumeroCheque"
            Me.txtNumeroCheque.Size = New System.Drawing.Size(79, 21)
            Me.txtNumeroCheque.TabIndex = 23
            '
            'btnEditarValores
            '
            Me.btnEditarValores.BackColor = System.Drawing.Color.Transparent
            Me.btnEditarValores.FlatAppearance.BorderSize = 0
            Me.btnEditarValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditarValores.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditarValores.Image = Global.syscisepro.My.Resources.Resources.edit_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnEditarValores.Location = New System.Drawing.Point(500, 229)
            Me.btnEditarValores.Name = "btnEditarValores"
            Me.btnEditarValores.Size = New System.Drawing.Size(30, 30)
            Me.btnEditarValores.TabIndex = 33
            Me.btnEditarValores.UseVisualStyleBackColor = False
            '
            'btnAgregarBancosComprobante
            '
            Me.btnAgregarBancosComprobante.BackColor = System.Drawing.Color.Transparent
            Me.btnAgregarBancosComprobante.FlatAppearance.BorderSize = 0
            Me.btnAgregarBancosComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAgregarBancosComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarBancosComprobante.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarBancosComprobante.Location = New System.Drawing.Point(464, 228)
            Me.btnAgregarBancosComprobante.Name = "btnAgregarBancosComprobante"
            Me.btnAgregarBancosComprobante.Size = New System.Drawing.Size(30, 30)
            Me.btnAgregarBancosComprobante.TabIndex = 32
            Me.btnAgregarBancosComprobante.UseVisualStyleBackColor = False
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(235, 235)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(79, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.BackColor = System.Drawing.Color.White
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(70, 235)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(101, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'cmbTipoPago
            '
            Me.cmbTipoPago.BackColor = System.Drawing.Color.White
            Me.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoPago.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipoPago.FormattingEnabled = True
            Me.cmbTipoPago.Items.AddRange(New Object() {"CHEQUE", "EFECTIVO", "CREDITO A CUENTA", "NOTA DE CREDITO", "NOTA DE DEBITO"})
            Me.cmbTipoPago.Location = New System.Drawing.Point(71, 204)
            Me.cmbTipoPago.Name = "cmbTipoPago"
            Me.cmbTipoPago.Size = New System.Drawing.Size(100, 21)
            Me.cmbTipoPago.TabIndex = 8
            '
            'btnBuscarPersonal
            '
            Me.btnBuscarPersonal.BackColor = System.Drawing.Color.Transparent
            Me.btnBuscarPersonal.FlatAppearance.BorderSize = 0
            Me.btnBuscarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscarPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarPersonal.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarPersonal.Location = New System.Drawing.Point(436, 135)
            Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
            Me.btnBuscarPersonal.Size = New System.Drawing.Size(30, 30)
            Me.btnBuscarPersonal.TabIndex = 25
            Me.btnBuscarPersonal.UseVisualStyleBackColor = False
            '
            'txtFacturaReceptor
            '
            Me.txtFacturaReceptor.BackColor = System.Drawing.Color.White
            Me.txtFacturaReceptor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFacturaReceptor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFacturaReceptor.Location = New System.Drawing.Point(70, 175)
            Me.txtFacturaReceptor.Name = "txtFacturaReceptor"
            Me.txtFacturaReceptor.Size = New System.Drawing.Size(101, 21)
            Me.txtFacturaReceptor.TabIndex = 22
            '
            'dtpFechaComprobanteEgreso
            '
            Me.dtpFechaComprobanteEgreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaComprobanteEgreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaComprobanteEgreso.Location = New System.Drawing.Point(131, 16)
            Me.dtpFechaComprobanteEgreso.Name = "dtpFechaComprobanteEgreso"
            Me.dtpFechaComprobanteEgreso.Size = New System.Drawing.Size(85, 21)
            Me.dtpFechaComprobanteEgreso.TabIndex = 21
            '
            'lblIdComprobanteEgresoBancos
            '
            Me.lblIdComprobanteEgresoBancos.AutoSize = True
            Me.lblIdComprobanteEgresoBancos.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteEgresoBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteEgresoBancos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteEgresoBancos.Location = New System.Drawing.Point(311, -1)
            Me.lblIdComprobanteEgresoBancos.Name = "lblIdComprobanteEgresoBancos"
            Me.lblIdComprobanteEgresoBancos.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteEgresoBancos.TabIndex = 20
            Me.lblIdComprobanteEgresoBancos.Text = "..."
            '
            'dgvComprobanteEgresoBanco
            '
            Me.dgvComprobanteEgresoBanco.AllowUserToAddRows = False
            Me.dgvComprobanteEgresoBanco.AllowUserToDeleteRows = False
            Me.dgvComprobanteEgresoBanco.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobanteEgresoBanco.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvComprobanteEgresoBanco.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvComprobanteEgresoBanco.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobanteEgresoBanco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvComprobanteEgresoBanco.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteEgresoBanco.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobanteEgresoBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteEgresoBanco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.CUENTA, Me.CONCEPTO, Me.DETALLE, Me.DEBE, Me.HABER, Me.ID_CC})
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteEgresoBanco.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvComprobanteEgresoBanco.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvComprobanteEgresoBanco.Location = New System.Drawing.Point(7, 271)
            Me.dgvComprobanteEgresoBanco.MultiSelect = False
            Me.dgvComprobanteEgresoBanco.Name = "dgvComprobanteEgresoBanco"
            Me.dgvComprobanteEgresoBanco.RowHeadersVisible = False
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobanteEgresoBanco.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvComprobanteEgresoBanco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteEgresoBanco.Size = New System.Drawing.Size(523, 179)
            Me.dgvComprobanteEgresoBanco.TabIndex = 27
            '
            'CODIGO
            '
            Me.CODIGO.HeaderText = "COD."
            Me.CODIGO.Name = "CODIGO"
            Me.CODIGO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.CODIGO.Width = 80
            '
            'CUENTA
            '
            Me.CUENTA.HeaderText = "CUENTA"
            Me.CUENTA.Name = "CUENTA"
            Me.CUENTA.Width = 150
            '
            'CONCEPTO
            '
            Me.CONCEPTO.HeaderText = "CONCEPTO"
            Me.CONCEPTO.Name = "CONCEPTO"
            Me.CONCEPTO.Width = 150
            '
            'DETALLE
            '
            Me.DETALLE.HeaderText = "DETALLE"
            Me.DETALLE.Name = "DETALLE"
            Me.DETALLE.Width = 215
            '
            'DEBE
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DEBE.DefaultCellStyle = DataGridViewCellStyle3
            Me.DEBE.HeaderText = "DEBE"
            Me.DEBE.Name = "DEBE"
            Me.DEBE.Width = 70
            '
            'HABER
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.HABER.DefaultCellStyle = DataGridViewCellStyle4
            Me.HABER.HeaderText = "HABER"
            Me.HABER.Name = "HABER"
            Me.HABER.Width = 70
            '
            'ID_CC
            '
            Me.ID_CC.HeaderText = "ID_CC"
            Me.ID_CC.Name = "ID_CC"
            Me.ID_CC.Visible = False
            Me.ID_CC.Width = 50
            '
            'txtValorComprobanteEgresoBancos
            '
            Me.txtValorComprobanteEgresoBancos.BackColor = System.Drawing.Color.White
            Me.txtValorComprobanteEgresoBancos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorComprobanteEgresoBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorComprobanteEgresoBancos.Location = New System.Drawing.Point(235, 204)
            Me.txtValorComprobanteEgresoBancos.Name = "txtValorComprobanteEgresoBancos"
            Me.txtValorComprobanteEgresoBancos.Size = New System.Drawing.Size(79, 21)
            Me.txtValorComprobanteEgresoBancos.TabIndex = 29
            Me.txtValorComprobanteEgresoBancos.Text = "0.00"
            Me.txtValorComprobanteEgresoBancos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtConceptoComprobanteEgreso
            '
            Me.txtConceptoComprobanteEgreso.BackColor = System.Drawing.Color.White
            Me.txtConceptoComprobanteEgreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtConceptoComprobanteEgreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConceptoComprobanteEgreso.Location = New System.Drawing.Point(85, 79)
            Me.txtConceptoComprobanteEgreso.Name = "txtConceptoComprobanteEgreso"
            Me.txtConceptoComprobanteEgreso.Size = New System.Drawing.Size(129, 21)
            Me.txtConceptoComprobanteEgreso.TabIndex = 37
            '
            'cmbCuentasContables
            '
            Me.cmbCuentasContables.BackColor = System.Drawing.Color.White
            Me.cmbCuentasContables.DropDownHeight = 150
            Me.cmbCuentasContables.DropDownWidth = 500
            Me.cmbCuentasContables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentasContables.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentasContables.FormattingEnabled = True
            Me.cmbCuentasContables.IntegralHeight = False
            Me.cmbCuentasContables.Location = New System.Drawing.Point(307, 46)
            Me.cmbCuentasContables.Name = "cmbCuentasContables"
            Me.cmbCuentasContables.Size = New System.Drawing.Size(123, 21)
            Me.cmbCuentasContables.TabIndex = 31
            '
            'btnAgregarConceptoComprobante
            '
            Me.btnAgregarConceptoComprobante.BackColor = System.Drawing.Color.Transparent
            Me.btnAgregarConceptoComprobante.FlatAppearance.BorderSize = 0
            Me.btnAgregarConceptoComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAgregarConceptoComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarConceptoComprobante.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarConceptoComprobante.Location = New System.Drawing.Point(440, 42)
            Me.btnAgregarConceptoComprobante.Name = "btnAgregarConceptoComprobante"
            Me.btnAgregarConceptoComprobante.Size = New System.Drawing.Size(30, 30)
            Me.btnAgregarConceptoComprobante.TabIndex = 23
            Me.btnAgregarConceptoComprobante.UseVisualStyleBackColor = False
            '
            'cmbCentroCosto
            '
            Me.cmbCentroCosto.BackColor = System.Drawing.Color.White
            Me.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCentroCosto.Enabled = False
            Me.cmbCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCentroCosto.FormattingEnabled = True
            Me.cmbCentroCosto.Location = New System.Drawing.Point(85, 47)
            Me.cmbCentroCosto.Name = "cmbCentroCosto"
            Me.cmbCentroCosto.Size = New System.Drawing.Size(129, 21)
            Me.cmbCentroCosto.TabIndex = 29
            '
            'chkTransferenciaInterna
            '
            Me.chkTransferenciaInterna.AutoSize = True
            Me.chkTransferenciaInterna.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkTransferenciaInterna.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkTransferenciaInterna.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkTransferenciaInterna.Location = New System.Drawing.Point(84, 105)
            Me.chkTransferenciaInterna.Name = "chkTransferenciaInterna"
            Me.chkTransferenciaInterna.Size = New System.Drawing.Size(137, 17)
            Me.chkTransferenciaInterna.TabIndex = 38
            Me.chkTransferenciaInterna.Text = "Cruce Interno Cuentas"
            Me.chkTransferenciaInterna.UseVisualStyleBackColor = False
            '
            'txtTotalHaber
            '
            Me.txtTotalHaber.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.txtTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalHaber.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalHaber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtTotalHaber.Location = New System.Drawing.Point(433, 463)
            Me.txtTotalHaber.Name = "txtTotalHaber"
            Me.txtTotalHaber.Size = New System.Drawing.Size(89, 16)
            Me.txtTotalHaber.TabIndex = 32
            Me.txtTotalHaber.Text = "0.00"
            Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalDebe
            '
            Me.txtTotalDebe.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalDebe.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalDebe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtTotalDebe.Location = New System.Drawing.Point(321, 464)
            Me.txtTotalDebe.Name = "txtTotalDebe"
            Me.txtTotalDebe.Size = New System.Drawing.Size(89, 16)
            Me.txtTotalDebe.TabIndex = 33
            Me.txtTotalDebe.Text = "0.00"
            Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblTotal.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblTotal.Location = New System.Drawing.Point(253, 464)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(52, 15)
            Me.lblTotal.TabIndex = 30
            Me.lblTotal.Text = "TOTAL :"
            '
            'chkActivar
            '
            Me.chkActivar.AutoSize = True
            Me.chkActivar.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkActivar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkActivar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkActivar.Location = New System.Drawing.Point(700, 0)
            Me.chkActivar.Name = "chkActivar"
            Me.chkActivar.Size = New System.Drawing.Size(61, 17)
            Me.chkActivar.TabIndex = 2
            Me.chkActivar.Text = "Activar"
            Me.chkActivar.UseVisualStyleBackColor = False
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProveedorGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(513, 1)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 1
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'txtNombreComercialProveedor
            '
            Me.txtNombreComercialProveedor.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedor.Enabled = False
            Me.txtNombreComercialProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedor.Location = New System.Drawing.Point(509, 18)
            Me.txtNombreComercialProveedor.Name = "txtNombreComercialProveedor"
            Me.txtNombreComercialProveedor.Size = New System.Drawing.Size(301, 21)
            Me.txtNombreComercialProveedor.TabIndex = 0
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblIdComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(674, 49)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteCompra.TabIndex = 1
            Me.lblIdComprobanteCompra.Text = "..."
            '
            'dgvComprobantesCompra
            '
            Me.dgvComprobantesCompra.AllowUserToAddRows = False
            Me.dgvComprobantesCompra.AllowUserToDeleteRows = False
            Me.dgvComprobantesCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvComprobantesCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.dgvComprobantesCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvComprobantesCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobantesCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle9
            Me.dgvComprobantesCompra.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvComprobantesCompra.Location = New System.Drawing.Point(0, 0)
            Me.dgvComprobantesCompra.MultiSelect = False
            Me.dgvComprobantesCompra.Name = "dgvComprobantesCompra"
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesCompra.Size = New System.Drawing.Size(270, 271)
            Me.dgvComprobantesCompra.TabIndex = 0
            '
            'chk
            '
            Me.chk.HeaderText = "CHK"
            Me.chk.Name = "chk"
            Me.chk.Width = 30
            '
            'dgvCompEgresoPagosCompCompra
            '
            Me.dgvCompEgresoPagosCompCompra.AllowUserToAddRows = False
            Me.dgvCompEgresoPagosCompCompra.AllowUserToDeleteRows = False
            Me.dgvCompEgresoPagosCompCompra.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvCompEgresoPagosCompCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCompEgresoPagosCompCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_CE, Me.ID_CC_, Me.ID_PCC, Me.MONTO_PCC, Me.NRO_REG_ASIENTO})
            Me.dgvCompEgresoPagosCompCompra.Location = New System.Drawing.Point(575, 352)
            Me.dgvCompEgresoPagosCompCompra.Name = "dgvCompEgresoPagosCompCompra"
            Me.dgvCompEgresoPagosCompCompra.ReadOnly = True
            Me.dgvCompEgresoPagosCompCompra.Size = New System.Drawing.Size(228, 172)
            Me.dgvCompEgresoPagosCompCompra.TabIndex = 91
            '
            'ID_CE
            '
            Me.ID_CE.HeaderText = "ID CE"
            Me.ID_CE.Name = "ID_CE"
            Me.ID_CE.ReadOnly = True
            '
            'ID_CC_
            '
            Me.ID_CC_.HeaderText = "ID_CC_"
            Me.ID_CC_.Name = "ID_CC_"
            Me.ID_CC_.ReadOnly = True
            '
            'ID_PCC
            '
            Me.ID_PCC.HeaderText = "ID PCC"
            Me.ID_PCC.Name = "ID_PCC"
            Me.ID_PCC.ReadOnly = True
            '
            'MONTO_PCC
            '
            Me.MONTO_PCC.HeaderText = "MONTO_PCC"
            Me.MONTO_PCC.Name = "MONTO_PCC"
            Me.MONTO_PCC.ReadOnly = True
            '
            'NRO_REG_ASIENTO
            '
            Me.NRO_REG_ASIENTO.HeaderText = "NRO_REG_ASIENTO"
            Me.NRO_REG_ASIENTO.Name = "NRO_REG_ASIENTO"
            Me.NRO_REG_ASIENTO.ReadOnly = True
            '
            'ContextMenuStripClicDerecho
            '
            Me.ContextMenuStripClicDerecho.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemEliminar})
            Me.ContextMenuStripClicDerecho.Name = "ContextMenuStripClicDerecho"
            Me.ContextMenuStripClicDerecho.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.ContextMenuStripClicDerecho.Size = New System.Drawing.Size(118, 26)
            '
            'ToolStripMenuItemEliminar
            '
            Me.ToolStripMenuItemEliminar.Name = "ToolStripMenuItemEliminar"
            Me.ToolStripMenuItemEliminar.Size = New System.Drawing.Size(117, 22)
            Me.ToolStripMenuItemEliminar.Text = "Eliminar"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(817, 32)
            Me.MenuStrip1.TabIndex = 210
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(92, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 34)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonGroupBox2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdComprobanteCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.gbFacturaVenta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblTotal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTotalHaber)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTotalDebe)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dgvComprobanteEgresoBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnEditarValores)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumeroCheque)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnAgregarBancosComprobante)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtValorComprobanteEgresoBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCuentaBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbTipoPago)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnBuscarPersonal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnAgregarConceptoComprobante)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtPagadoA)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFacturaReceptor)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtConceptoComprobanteEgreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRucCi)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCuentasContables)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRazonComprobanteEgresoBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkActivar)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialProveedor)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkTransferenciaInterna)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdComprobanteEgresoBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtActividad)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaComprobanteEgreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumeroComprobanteEgresoBanco)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(817, 502)
            Me.KryptonGroupBox1.TabIndex = 211
            Me.KryptonGroupBox1.Values.Heading = ""
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(536, 341)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvPagosComprobantesCompra)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(274, 150)
            Me.KryptonGroupBox2.TabIndex = 121
            Me.KryptonGroupBox2.Values.Heading = "Pagos Comprobante"
            '
            'dgvPagosComprobantesCompra
            '
            Me.dgvPagosComprobantesCompra.AllowUserToAddRows = False
            Me.dgvPagosComprobantesCompra.AllowUserToDeleteRows = False
            Me.dgvPagosComprobantesCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvPagosComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvPagosComprobantesCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.dgvPagosComprobantesCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPagosComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvPagosComprobantesCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPagosComprobantesCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvPagosComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPagosComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle14
            Me.dgvPagosComprobantesCompra.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvPagosComprobantesCompra.Location = New System.Drawing.Point(0, 0)
            Me.dgvPagosComprobantesCompra.MultiSelect = False
            Me.dgvPagosComprobantesCompra.Name = "dgvPagosComprobantesCompra"
            Me.dgvPagosComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvPagosComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvPagosComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPagosComprobantesCompra.Size = New System.Drawing.Size(270, 126)
            Me.dgvPagosComprobantesCompra.TabIndex = 0
            '
            'gbFacturaVenta
            '
            Me.gbFacturaVenta.CaptionOverlap = 0R
            Me.gbFacturaVenta.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.gbFacturaVenta.Location = New System.Drawing.Point(536, 44)
            Me.gbFacturaVenta.Name = "gbFacturaVenta"
            '
            'gbFacturaVenta.Panel
            '
            Me.gbFacturaVenta.Panel.Controls.Add(Me.dgvComprobantesCompra)
            Me.gbFacturaVenta.Size = New System.Drawing.Size(274, 295)
            Me.gbFacturaVenta.TabIndex = 120
            Me.gbFacturaVenta.Values.Heading = "Comprobante Compra"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(320, 235)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(55, 20)
            Me.KryptonLabel17.TabIndex = 61
            Me.KryptonLabel17.Values.Text = "Numero"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(180, 203)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel16.TabIndex = 60
            Me.KryptonLabel16.Values.Text = "Valor"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(180, 236)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel15.TabIndex = 59
            Me.KryptonLabel15.Values.Text = "Cuenta"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(3, 232)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel14.TabIndex = 58
            Me.KryptonLabel14.Values.Text = "Banco"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(3, 206)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(66, 20)
            Me.KryptonLabel13.TabIndex = 57
            Me.KryptonLabel13.Values.Text = "Tipo Pago"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(180, 143)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel12.TabIndex = 56
            Me.KryptonLabel12.Values.Text = "Pagado"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(3, 175)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel10.TabIndex = 55
            Me.KryptonLabel10.Values.Text = "Factura"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(3, 143)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel9.TabIndex = 54
            Me.KryptonLabel9.Values.Text = "Ruc/ CI"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(3, 117)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
            Me.KryptonLabel11.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel11.TabIndex = 53
            Me.KryptonLabel11.Values.Text = "Receptor"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(220, 80)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel8.TabIndex = 40
            Me.KryptonLabel8.Values.Text = "Razon"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(220, 48)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(81, 20)
            Me.KryptonLabel7.TabIndex = 39
            Me.KryptonLabel7.Values.Text = "Cta Contable"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(3, 80)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel6.TabIndex = 30
            Me.KryptonLabel6.Values.Text = "Concepto"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(3, 47)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(82, 20)
            Me.KryptonLabel5.TabIndex = 24
            Me.KryptonLabel5.Values.Text = "Centro Costo"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(436, 16)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(67, 20)
            Me.KryptonLabel4.TabIndex = 23
            Me.KryptonLabel4.Values.Text = "Proveedor"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(220, 17)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel3.TabIndex = 22
            Me.KryptonLabel3.Values.Text = "Actividad"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(89, 16)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel2.TabIndex = 14
            Me.KryptonLabel2.Values.Text = "Fecha"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(3, 16)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Nro"
            '
            'FormComprobanteEgresoBanco
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(817, 533)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvCompEgresoPagosCompCompra)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormComprobanteEgresoBanco"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "COMPROBANTE DE EGRESO"
            CType(Me.dgvComprobanteEgresoBanco, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvCompEgresoPagosCompCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
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
            CType(Me.dgvPagosComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gbFacturaVenta.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbFacturaVenta.Panel.ResumeLayout(False)
            CType(Me.gbFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbFacturaVenta.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtNumeroComprobanteEgresoBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtPagadoA As System.Windows.Forms.TextBox
        Friend WithEvents txtActividad As System.Windows.Forms.TextBox
        Friend WithEvents txtRazonComprobanteEgresoBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtRucCi As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroCheque As System.Windows.Forms.TextBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbTipoPago As System.Windows.Forms.ComboBox
        Friend WithEvents txtFacturaReceptor As System.Windows.Forms.TextBox
        Friend WithEvents dgvComprobanteEgresoBanco As System.Windows.Forms.DataGridView
        Friend WithEvents txtValorComprobanteEgresoBancos As System.Windows.Forms.TextBox
        Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents btnAgregarConceptoComprobante As System.Windows.Forms.Button
        Friend WithEvents btnBuscarPersonal As System.Windows.Forms.Button
        Friend WithEvents lblIdComprobanteEgresoBancos As System.Windows.Forms.Label
        Friend WithEvents txtNombreComercialProveedor As System.Windows.Forms.TextBox
        Friend WithEvents dgvComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents chkActivar As System.Windows.Forms.CheckBox
        Friend WithEvents cmbCuentasContables As System.Windows.Forms.ComboBox
        Friend WithEvents btnAgregarBancosComprobante As System.Windows.Forms.Button
        Friend WithEvents dgvCompEgresoPagosCompCompra As System.Windows.Forms.DataGridView
        Friend WithEvents ID_CE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_CC_ As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_PCC As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents MONTO_PCC As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NRO_REG_ASIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnEditarValores As System.Windows.Forms.Button
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ToolStripMenuItemEliminar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtConceptoComprobanteEgreso As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaComprobanteEgreso As System.Windows.Forms.DateTimePicker
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CUENTA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CONCEPTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DETALLE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DEBE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents HABER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_CC As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents chkTransferenciaInterna As CheckBox
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents dgvPagosComprobantesCompra As DataGridView
        Friend WithEvents gbFacturaVenta As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    End Class
End Namespace