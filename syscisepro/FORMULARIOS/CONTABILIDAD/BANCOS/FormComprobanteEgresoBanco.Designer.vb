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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComprobanteEgresoBanco))
            Me.lblNumeroComprobanteEgreso = New System.Windows.Forms.Label()
            Me.lblFechaComprobante = New System.Windows.Forms.Label()
            Me.lblPagadoA = New System.Windows.Forms.Label()
            Me.lblRucCi = New System.Windows.Forms.Label()
            Me.lblActividad = New System.Windows.Forms.Label()
            Me.lblTipoPago = New System.Windows.Forms.Label()
            Me.lblRazonComprobanteEgreso = New System.Windows.Forms.Label()
            Me.lblBanco = New System.Windows.Forms.Label()
            Me.lblTipoCuenta = New System.Windows.Forms.Label()
            Me.lblNumeroCheque = New System.Windows.Forms.Label()
            Me.txtNumeroComprobanteEgresoBanco = New System.Windows.Forms.TextBox()
            Me.txtPagadoA = New System.Windows.Forms.TextBox()
            Me.txtActividad = New System.Windows.Forms.TextBox()
            Me.txtRazonComprobanteEgresoBanco = New System.Windows.Forms.TextBox()
            Me.txtRucCi = New System.Windows.Forms.TextBox()
            Me.txtNumeroCheque = New System.Windows.Forms.TextBox()
            Me.gbBanco = New System.Windows.Forms.GroupBox()
            Me.btnEditarValores = New System.Windows.Forms.Button()
            Me.btnAgregarBancosComprobante = New System.Windows.Forms.Button()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.cmbTipoPago = New System.Windows.Forms.ComboBox()
            Me.gbReceptor = New System.Windows.Forms.GroupBox()
            Me.btnBuscarPersonal = New System.Windows.Forms.Button()
            Me.txtFacturaReceptor = New System.Windows.Forms.TextBox()
            Me.lblFacturaAPagar = New System.Windows.Forms.Label()
            Me.gbCabecera = New System.Windows.Forms.GroupBox()
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
            Me.lblValorComprobanteEgreso = New System.Windows.Forms.Label()
            Me.txtValorComprobanteEgresoBancos = New System.Windows.Forms.TextBox()
            Me.pCentroCosto = New System.Windows.Forms.Panel()
            Me.txtConceptoComprobanteEgreso = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cmbCuentasContables = New System.Windows.Forms.ComboBox()
            Me.btnAgregarConceptoComprobante = New System.Windows.Forms.Button()
            Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
            Me.lblCentroCosto = New System.Windows.Forms.Label()
            Me.chkTransferenciaInterna = New System.Windows.Forms.CheckBox()
            Me.txtTotalHaber = New System.Windows.Forms.TextBox()
            Me.txtTotalDebe = New System.Windows.Forms.TextBox()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.gbProveedor = New System.Windows.Forms.GroupBox()
            Me.chkActivar = New System.Windows.Forms.CheckBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialProveedor = New System.Windows.Forms.TextBox()
            Me.gbComprobantesCompra = New System.Windows.Forms.GroupBox()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.dgvComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.gbPagosComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.dgvPagosComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.gbTotalDebeHaber = New System.Windows.Forms.GroupBox()
            Me.dgvCompEgresoPagosCompCompra = New System.Windows.Forms.DataGridView()
            Me.ID_CE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_CC_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_PCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MONTO_PCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NRO_REG_ASIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ContextMenuStripClicDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ToolStripMenuItemEliminar = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbBanco.SuspendLayout()
            Me.gbReceptor.SuspendLayout()
            Me.gbCabecera.SuspendLayout()
            CType(Me.dgvComprobanteEgresoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pCentroCosto.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.gbProveedor.SuspendLayout()
            Me.gbComprobantesCompra.SuspendLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbPagosComprobanteCompra.SuspendLayout()
            CType(Me.dgvPagosComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbTotalDebeHaber.SuspendLayout()
            CType(Me.dgvCompEgresoPagosCompCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblNumeroComprobanteEgreso
            '
            Me.lblNumeroComprobanteEgreso.AutoSize = True
            Me.lblNumeroComprobanteEgreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroComprobanteEgreso.Location = New System.Drawing.Point(9, 23)
            Me.lblNumeroComprobanteEgreso.Name = "lblNumeroComprobanteEgreso"
            Me.lblNumeroComprobanteEgreso.Size = New System.Drawing.Size(61, 13)
            Me.lblNumeroComprobanteEgreso.TabIndex = 1
            Me.lblNumeroComprobanteEgreso.Text = "NRO :  CE -"
            '
            'lblFechaComprobante
            '
            Me.lblFechaComprobante.AutoSize = True
            Me.lblFechaComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaComprobante.Location = New System.Drawing.Point(146, 26)
            Me.lblFechaComprobante.Name = "lblFechaComprobante"
            Me.lblFechaComprobante.Size = New System.Drawing.Size(44, 13)
            Me.lblFechaComprobante.TabIndex = 2
            Me.lblFechaComprobante.Text = "FECHA:"
            '
            'lblPagadoA
            '
            Me.lblPagadoA.AutoSize = True
            Me.lblPagadoA.Location = New System.Drawing.Point(231, 23)
            Me.lblPagadoA.Name = "lblPagadoA"
            Me.lblPagadoA.Size = New System.Drawing.Size(63, 13)
            Me.lblPagadoA.TabIndex = 3
            Me.lblPagadoA.Text = "PAGADO A:"
            '
            'lblRucCi
            '
            Me.lblRucCi.AutoSize = True
            Me.lblRucCi.Location = New System.Drawing.Point(7, 23)
            Me.lblRucCi.Name = "lblRucCi"
            Me.lblRucCi.Size = New System.Drawing.Size(55, 13)
            Me.lblRucCi.TabIndex = 4
            Me.lblRucCi.Text = "RUC/C.I. :"
            '
            'lblActividad
            '
            Me.lblActividad.AutoSize = True
            Me.lblActividad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblActividad.Location = New System.Drawing.Point(406, 23)
            Me.lblActividad.Name = "lblActividad"
            Me.lblActividad.Size = New System.Drawing.Size(68, 13)
            Me.lblActividad.TabIndex = 5
            Me.lblActividad.Text = "ACTIVIDAD :"
            '
            'lblTipoPago
            '
            Me.lblTipoPago.AutoSize = True
            Me.lblTipoPago.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipoPago.Location = New System.Drawing.Point(7, 23)
            Me.lblTipoPago.Name = "lblTipoPago"
            Me.lblTipoPago.Size = New System.Drawing.Size(67, 13)
            Me.lblTipoPago.TabIndex = 7
            Me.lblTipoPago.Text = "TIPO PAGO:"
            '
            'lblRazonComprobanteEgreso
            '
            Me.lblRazonComprobanteEgreso.AutoSize = True
            Me.lblRazonComprobanteEgreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRazonComprobanteEgreso.Location = New System.Drawing.Point(274, 45)
            Me.lblRazonComprobanteEgreso.Name = "lblRazonComprobanteEgreso"
            Me.lblRazonComprobanteEgreso.Size = New System.Drawing.Size(50, 13)
            Me.lblRazonComprobanteEgreso.TabIndex = 8
            Me.lblRazonComprobanteEgreso.Text = "RAZON :"
            '
            'lblBanco
            '
            Me.lblBanco.AutoSize = True
            Me.lblBanco.Location = New System.Drawing.Point(6, 23)
            Me.lblBanco.Name = "lblBanco"
            Me.lblBanco.Size = New System.Drawing.Size(59, 13)
            Me.lblBanco.TabIndex = 9
            Me.lblBanco.Text = "NOMBRE :"
            '
            'lblTipoCuenta
            '
            Me.lblTipoCuenta.AutoSize = True
            Me.lblTipoCuenta.Location = New System.Drawing.Point(178, 23)
            Me.lblTipoCuenta.Name = "lblTipoCuenta"
            Me.lblTipoCuenta.Size = New System.Drawing.Size(88, 13)
            Me.lblTipoCuenta.TabIndex = 10
            Me.lblTipoCuenta.Text = "NRO CC/CA/TC:"
            '
            'lblNumeroCheque
            '
            Me.lblNumeroCheque.AutoSize = True
            Me.lblNumeroCheque.Location = New System.Drawing.Point(383, 23)
            Me.lblNumeroCheque.Name = "lblNumeroCheque"
            Me.lblNumeroCheque.Size = New System.Drawing.Size(59, 13)
            Me.lblNumeroCheque.TabIndex = 11
            Me.lblNumeroCheque.Text = "NUMERO: "
            '
            'txtNumeroComprobanteEgresoBanco
            '
            Me.txtNumeroComprobanteEgresoBanco.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteEgresoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroComprobanteEgresoBanco.Location = New System.Drawing.Point(81, 20)
            Me.txtNumeroComprobanteEgresoBanco.Name = "txtNumeroComprobanteEgresoBanco"
            Me.txtNumeroComprobanteEgresoBanco.Size = New System.Drawing.Size(52, 21)
            Me.txtNumeroComprobanteEgresoBanco.TabIndex = 13
            '
            'txtPagadoA
            '
            Me.txtPagadoA.BackColor = System.Drawing.Color.White
            Me.txtPagadoA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPagadoA.Location = New System.Drawing.Point(295, 20)
            Me.txtPagadoA.Name = "txtPagadoA"
            Me.txtPagadoA.Size = New System.Drawing.Size(264, 21)
            Me.txtPagadoA.TabIndex = 14
            '
            'txtActividad
            '
            Me.txtActividad.BackColor = System.Drawing.Color.White
            Me.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtActividad.Enabled = False
            Me.txtActividad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtActividad.Location = New System.Drawing.Point(470, 20)
            Me.txtActividad.Name = "txtActividad"
            Me.txtActividad.Size = New System.Drawing.Size(125, 21)
            Me.txtActividad.TabIndex = 15
            Me.txtActividad.Text = "1010102"
            '
            'txtRazonComprobanteEgresoBanco
            '
            Me.txtRazonComprobanteEgresoBanco.BackColor = System.Drawing.Color.White
            Me.txtRazonComprobanteEgresoBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazonComprobanteEgresoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazonComprobanteEgresoBanco.Location = New System.Drawing.Point(326, 42)
            Me.txtRazonComprobanteEgresoBanco.Name = "txtRazonComprobanteEgresoBanco"
            Me.txtRazonComprobanteEgresoBanco.Size = New System.Drawing.Size(262, 21)
            Me.txtRazonComprobanteEgresoBanco.TabIndex = 17
            '
            'txtRucCi
            '
            Me.txtRucCi.BackColor = System.Drawing.Color.White
            Me.txtRucCi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucCi.Location = New System.Drawing.Point(88, 20)
            Me.txtRucCi.Name = "txtRucCi"
            Me.txtRucCi.Size = New System.Drawing.Size(135, 21)
            Me.txtRucCi.TabIndex = 20
            '
            'txtNumeroCheque
            '
            Me.txtNumeroCheque.BackColor = System.Drawing.Color.White
            Me.txtNumeroCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroCheque.Location = New System.Drawing.Point(441, 20)
            Me.txtNumeroCheque.Name = "txtNumeroCheque"
            Me.txtNumeroCheque.Size = New System.Drawing.Size(79, 21)
            Me.txtNumeroCheque.TabIndex = 23
            '
            'gbBanco
            '
            Me.gbBanco.BackColor = System.Drawing.Color.White
            Me.gbBanco.Controls.Add(Me.btnEditarValores)
            Me.gbBanco.Controls.Add(Me.btnAgregarBancosComprobante)
            Me.gbBanco.Controls.Add(Me.cmbCuentaBancos)
            Me.gbBanco.Controls.Add(Me.cmbBancos)
            Me.gbBanco.Controls.Add(Me.lblBanco)
            Me.gbBanco.Controls.Add(Me.txtNumeroCheque)
            Me.gbBanco.Controls.Add(Me.lblTipoCuenta)
            Me.gbBanco.Controls.Add(Me.lblNumeroCheque)
            Me.gbBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBanco.Location = New System.Drawing.Point(0, 325)
            Me.gbBanco.Name = "gbBanco"
            Me.gbBanco.Size = New System.Drawing.Size(614, 52)
            Me.gbBanco.TabIndex = 24
            Me.gbBanco.TabStop = False
            Me.gbBanco.Text = "BANCO"
            '
            'btnEditarValores
            '
            Me.btnEditarValores.BackColor = System.Drawing.Color.White
            Me.btnEditarValores.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditarValores.Image = Global.syscisepro.My.Resources.Resources.edit_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnEditarValores.Location = New System.Drawing.Point(566, 18)
            Me.btnEditarValores.Name = "btnEditarValores"
            Me.btnEditarValores.Size = New System.Drawing.Size(41, 30)
            Me.btnEditarValores.TabIndex = 33
            Me.btnEditarValores.UseVisualStyleBackColor = False
            '
            'btnAgregarBancosComprobante
            '
            Me.btnAgregarBancosComprobante.BackColor = System.Drawing.Color.White
            Me.btnAgregarBancosComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarBancosComprobante.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarBancosComprobante.Location = New System.Drawing.Point(525, 18)
            Me.btnAgregarBancosComprobante.Name = "btnAgregarBancosComprobante"
            Me.btnAgregarBancosComprobante.Size = New System.Drawing.Size(41, 30)
            Me.btnAgregarBancosComprobante.TabIndex = 32
            Me.btnAgregarBancosComprobante.UseVisualStyleBackColor = False
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(266, 19)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(113, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.BackColor = System.Drawing.Color.White
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(67, 20)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(106, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'cmbTipoPago
            '
            Me.cmbTipoPago.BackColor = System.Drawing.Color.White
            Me.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbTipoPago.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipoPago.FormattingEnabled = True
            Me.cmbTipoPago.Items.AddRange(New Object() {"CHEQUE", "EFECTIVO", "CREDITO A CUENTA", "NOTA DE CREDITO", "NOTA DE DEBITO"})
            Me.cmbTipoPago.Location = New System.Drawing.Point(87, 20)
            Me.cmbTipoPago.Name = "cmbTipoPago"
            Me.cmbTipoPago.Size = New System.Drawing.Size(134, 21)
            Me.cmbTipoPago.TabIndex = 8
            '
            'gbReceptor
            '
            Me.gbReceptor.BackColor = System.Drawing.Color.White
            Me.gbReceptor.Controls.Add(Me.btnBuscarPersonal)
            Me.gbReceptor.Controls.Add(Me.txtFacturaReceptor)
            Me.gbReceptor.Controls.Add(Me.lblFacturaAPagar)
            Me.gbReceptor.Controls.Add(Me.txtPagadoA)
            Me.gbReceptor.Controls.Add(Me.lblPagadoA)
            Me.gbReceptor.Controls.Add(Me.lblRucCi)
            Me.gbReceptor.Controls.Add(Me.txtRucCi)
            Me.gbReceptor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbReceptor.Location = New System.Drawing.Point(0, 187)
            Me.gbReceptor.Name = "gbReceptor"
            Me.gbReceptor.Size = New System.Drawing.Size(614, 85)
            Me.gbReceptor.TabIndex = 25
            Me.gbReceptor.TabStop = False
            Me.gbReceptor.Text = "RECEPTOR"
            '
            'btnBuscarPersonal
            '
            Me.btnBuscarPersonal.BackColor = System.Drawing.Color.White
            Me.btnBuscarPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarPersonal.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarPersonal.Location = New System.Drawing.Point(567, 14)
            Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
            Me.btnBuscarPersonal.Size = New System.Drawing.Size(41, 30)
            Me.btnBuscarPersonal.TabIndex = 25
            Me.btnBuscarPersonal.UseVisualStyleBackColor = False
            '
            'txtFacturaReceptor
            '
            Me.txtFacturaReceptor.BackColor = System.Drawing.Color.White
            Me.txtFacturaReceptor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFacturaReceptor.Location = New System.Drawing.Point(88, 50)
            Me.txtFacturaReceptor.Name = "txtFacturaReceptor"
            Me.txtFacturaReceptor.Size = New System.Drawing.Size(519, 21)
            Me.txtFacturaReceptor.TabIndex = 22
            '
            'lblFacturaAPagar
            '
            Me.lblFacturaAPagar.AutoSize = True
            Me.lblFacturaAPagar.Location = New System.Drawing.Point(7, 53)
            Me.lblFacturaAPagar.Name = "lblFacturaAPagar"
            Me.lblFacturaAPagar.Size = New System.Drawing.Size(71, 13)
            Me.lblFacturaAPagar.TabIndex = 21
            Me.lblFacturaAPagar.Text = "FACTURA(s):"
            '
            'gbCabecera
            '
            Me.gbCabecera.BackColor = System.Drawing.Color.White
            Me.gbCabecera.Controls.Add(Me.dtpFechaComprobanteEgreso)
            Me.gbCabecera.Controls.Add(Me.lblIdComprobanteEgresoBancos)
            Me.gbCabecera.Controls.Add(Me.lblFechaComprobante)
            Me.gbCabecera.Controls.Add(Me.txtNumeroComprobanteEgresoBanco)
            Me.gbCabecera.Controls.Add(Me.lblActividad)
            Me.gbCabecera.Controls.Add(Me.txtActividad)
            Me.gbCabecera.Controls.Add(Me.lblNumeroComprobanteEgreso)
            Me.gbCabecera.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbCabecera.Location = New System.Drawing.Point(-1, 35)
            Me.gbCabecera.Name = "gbCabecera"
            Me.gbCabecera.Size = New System.Drawing.Size(615, 62)
            Me.gbCabecera.TabIndex = 26
            Me.gbCabecera.TabStop = False
            Me.gbCabecera.Text = "CABECERA:"
            '
            'dtpFechaComprobanteEgreso
            '
            Me.dtpFechaComprobanteEgreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaComprobanteEgreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaComprobanteEgreso.Location = New System.Drawing.Point(193, 20)
            Me.dtpFechaComprobanteEgreso.Name = "dtpFechaComprobanteEgreso"
            Me.dtpFechaComprobanteEgreso.Size = New System.Drawing.Size(112, 21)
            Me.dtpFechaComprobanteEgreso.TabIndex = 21
            '
            'lblIdComprobanteEgresoBancos
            '
            Me.lblIdComprobanteEgresoBancos.AutoSize = True
            Me.lblIdComprobanteEgresoBancos.Location = New System.Drawing.Point(360, 0)
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
            Me.dgvComprobanteEgresoBanco.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobanteEgresoBanco.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobanteEgresoBanco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvComprobanteEgresoBanco.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteEgresoBanco.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobanteEgresoBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteEgresoBanco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.CUENTA, Me.CONCEPTO, Me.DETALLE, Me.DEBE, Me.HABER, Me.ID_CC})
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteEgresoBanco.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvComprobanteEgresoBanco.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvComprobanteEgresoBanco.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvComprobanteEgresoBanco.Location = New System.Drawing.Point(3, 16)
            Me.dgvComprobanteEgresoBanco.MultiSelect = False
            Me.dgvComprobanteEgresoBanco.Name = "dgvComprobanteEgresoBanco"
            Me.dgvComprobanteEgresoBanco.RowHeadersVisible = False
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobanteEgresoBanco.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvComprobanteEgresoBanco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteEgresoBanco.Size = New System.Drawing.Size(608, 179)
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
            'lblValorComprobanteEgreso
            '
            Me.lblValorComprobanteEgreso.AutoSize = True
            Me.lblValorComprobanteEgreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblValorComprobanteEgreso.Location = New System.Drawing.Point(392, 23)
            Me.lblValorComprobanteEgreso.Name = "lblValorComprobanteEgreso"
            Me.lblValorComprobanteEgreso.Size = New System.Drawing.Size(45, 13)
            Me.lblValorComprobanteEgreso.TabIndex = 28
            Me.lblValorComprobanteEgreso.Text = "VALOR:"
            '
            'txtValorComprobanteEgresoBancos
            '
            Me.txtValorComprobanteEgresoBancos.BackColor = System.Drawing.Color.White
            Me.txtValorComprobanteEgresoBancos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorComprobanteEgresoBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorComprobanteEgresoBancos.Location = New System.Drawing.Point(446, 20)
            Me.txtValorComprobanteEgresoBancos.Name = "txtValorComprobanteEgresoBancos"
            Me.txtValorComprobanteEgresoBancos.Size = New System.Drawing.Size(106, 21)
            Me.txtValorComprobanteEgresoBancos.TabIndex = 29
            Me.txtValorComprobanteEgresoBancos.Text = "0.00"
            Me.txtValorComprobanteEgresoBancos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'pCentroCosto
            '
            Me.pCentroCosto.BackColor = System.Drawing.Color.White
            Me.pCentroCosto.Controls.Add(Me.txtConceptoComprobanteEgreso)
            Me.pCentroCosto.Controls.Add(Me.Label2)
            Me.pCentroCosto.Controls.Add(Me.Label1)
            Me.pCentroCosto.Controls.Add(Me.lblRazonComprobanteEgreso)
            Me.pCentroCosto.Controls.Add(Me.txtRazonComprobanteEgresoBanco)
            Me.pCentroCosto.Controls.Add(Me.cmbCuentasContables)
            Me.pCentroCosto.Controls.Add(Me.btnAgregarConceptoComprobante)
            Me.pCentroCosto.Controls.Add(Me.cmbCentroCosto)
            Me.pCentroCosto.Controls.Add(Me.lblCentroCosto)
            Me.pCentroCosto.Controls.Add(Me.chkTransferenciaInterna)
            Me.pCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pCentroCosto.Location = New System.Drawing.Point(0, 99)
            Me.pCentroCosto.Name = "pCentroCosto"
            Me.pCentroCosto.Size = New System.Drawing.Size(614, 87)
            Me.pCentroCosto.TabIndex = 30
            '
            'txtConceptoComprobanteEgreso
            '
            Me.txtConceptoComprobanteEgreso.BackColor = System.Drawing.Color.White
            Me.txtConceptoComprobanteEgreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtConceptoComprobanteEgreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConceptoComprobanteEgreso.Location = New System.Drawing.Point(92, 42)
            Me.txtConceptoComprobanteEgreso.Name = "txtConceptoComprobanteEgreso"
            Me.txtConceptoComprobanteEgreso.Size = New System.Drawing.Size(168, 21)
            Me.txtConceptoComprobanteEgreso.TabIndex = 37
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 45)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(68, 13)
            Me.Label2.TabIndex = 36
            Me.Label2.Text = "CONCEPTO:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(272, 15)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(93, 13)
            Me.Label1.TabIndex = 35
            Me.Label1.Text = "CTA. CONTABLE:"
            '
            'cmbCuentasContables
            '
            Me.cmbCuentasContables.BackColor = System.Drawing.Color.White
            Me.cmbCuentasContables.DropDownHeight = 150
            Me.cmbCuentasContables.DropDownWidth = 500
            Me.cmbCuentasContables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentasContables.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentasContables.FormattingEnabled = True
            Me.cmbCuentasContables.IntegralHeight = False
            Me.cmbCuentasContables.Location = New System.Drawing.Point(367, 12)
            Me.cmbCuentasContables.Name = "cmbCuentasContables"
            Me.cmbCuentasContables.Size = New System.Drawing.Size(172, 21)
            Me.cmbCuentasContables.TabIndex = 31
            '
            'btnAgregarConceptoComprobante
            '
            Me.btnAgregarConceptoComprobante.BackColor = System.Drawing.Color.White
            Me.btnAgregarConceptoComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarConceptoComprobante.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarConceptoComprobante.Location = New System.Drawing.Point(542, 10)
            Me.btnAgregarConceptoComprobante.Name = "btnAgregarConceptoComprobante"
            Me.btnAgregarConceptoComprobante.Size = New System.Drawing.Size(41, 30)
            Me.btnAgregarConceptoComprobante.TabIndex = 23
            Me.btnAgregarConceptoComprobante.UseVisualStyleBackColor = False
            '
            'cmbCentroCosto
            '
            Me.cmbCentroCosto.BackColor = System.Drawing.Color.White
            Me.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCentroCosto.Enabled = False
            Me.cmbCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCentroCosto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCentroCosto.FormattingEnabled = True
            Me.cmbCentroCosto.Location = New System.Drawing.Point(92, 12)
            Me.cmbCentroCosto.Name = "cmbCentroCosto"
            Me.cmbCentroCosto.Size = New System.Drawing.Size(168, 21)
            Me.cmbCentroCosto.TabIndex = 29
            '
            'lblCentroCosto
            '
            Me.lblCentroCosto.AutoSize = True
            Me.lblCentroCosto.Enabled = False
            Me.lblCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCentroCosto.Location = New System.Drawing.Point(6, 15)
            Me.lblCentroCosto.Name = "lblCentroCosto"
            Me.lblCentroCosto.Size = New System.Drawing.Size(93, 13)
            Me.lblCentroCosto.TabIndex = 28
            Me.lblCentroCosto.Text = "CENTRO COSTO:"
            '
            'chkTransferenciaInterna
            '
            Me.chkTransferenciaInterna.AutoSize = True
            Me.chkTransferenciaInterna.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkTransferenciaInterna.Location = New System.Drawing.Point(92, 66)
            Me.chkTransferenciaInterna.Name = "chkTransferenciaInterna"
            Me.chkTransferenciaInterna.Size = New System.Drawing.Size(162, 17)
            Me.chkTransferenciaInterna.TabIndex = 38
            Me.chkTransferenciaInterna.Text = "CRUCE INTERNO CUENTAS"
            Me.chkTransferenciaInterna.UseVisualStyleBackColor = True
            '
            'txtTotalHaber
            '
            Me.txtTotalHaber.BackColor = System.Drawing.Color.White
            Me.txtTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalHaber.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalHaber.Location = New System.Drawing.Point(505, 14)
            Me.txtTotalHaber.Name = "txtTotalHaber"
            Me.txtTotalHaber.Size = New System.Drawing.Size(89, 14)
            Me.txtTotalHaber.TabIndex = 32
            Me.txtTotalHaber.Text = "0.00"
            Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalDebe
            '
            Me.txtTotalDebe.BackColor = System.Drawing.Color.White
            Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalDebe.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalDebe.Location = New System.Drawing.Point(409, 14)
            Me.txtTotalDebe.Name = "txtTotalDebe"
            Me.txtTotalDebe.Size = New System.Drawing.Size(89, 14)
            Me.txtTotalDebe.TabIndex = 33
            Me.txtTotalDebe.Text = "0.00"
            Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(359, 15)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(48, 13)
            Me.lblTotal.TabIndex = 30
            Me.lblTotal.Text = "TOTAL :"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.lblTipoPago)
            Me.GroupBox1.Controls.Add(Me.cmbTipoPago)
            Me.GroupBox1.Controls.Add(Me.lblValorComprobanteEgreso)
            Me.GroupBox1.Controls.Add(Me.txtValorComprobanteEgresoBancos)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(0, 272)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(614, 53)
            Me.GroupBox1.TabIndex = 34
            Me.GroupBox1.TabStop = False
            '
            'gbProveedor
            '
            Me.gbProveedor.BackColor = System.Drawing.Color.White
            Me.gbProveedor.Controls.Add(Me.chkActivar)
            Me.gbProveedor.Controls.Add(Me.lblIdProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtNombreComercialProveedor)
            Me.gbProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbProveedor.Location = New System.Drawing.Point(615, 35)
            Me.gbProveedor.Name = "gbProveedor"
            Me.gbProveedor.Size = New System.Drawing.Size(355, 62)
            Me.gbProveedor.TabIndex = 35
            Me.gbProveedor.TabStop = False
            Me.gbProveedor.Text = "PROVEEDOR:"
            '
            'chkActivar
            '
            Me.chkActivar.AutoSize = True
            Me.chkActivar.Location = New System.Drawing.Point(277, 0)
            Me.chkActivar.Name = "chkActivar"
            Me.chkActivar.Size = New System.Drawing.Size(61, 17)
            Me.chkActivar.TabIndex = 2
            Me.chkActivar.Text = "Activar"
            Me.chkActivar.UseVisualStyleBackColor = True
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(73, 0)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 1
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'txtNombreComercialProveedor
            '
            Me.txtNombreComercialProveedor.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedor.Location = New System.Drawing.Point(6, 19)
            Me.txtNombreComercialProveedor.Name = "txtNombreComercialProveedor"
            Me.txtNombreComercialProveedor.Size = New System.Drawing.Size(335, 21)
            Me.txtNombreComercialProveedor.TabIndex = 0
            '
            'gbComprobantesCompra
            '
            Me.gbComprobantesCompra.BackColor = System.Drawing.Color.White
            Me.gbComprobantesCompra.Controls.Add(Me.lblIdComprobanteCompra)
            Me.gbComprobantesCompra.Controls.Add(Me.dgvComprobantesCompra)
            Me.gbComprobantesCompra.Enabled = False
            Me.gbComprobantesCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComprobantesCompra.Location = New System.Drawing.Point(615, 99)
            Me.gbComprobantesCompra.Name = "gbComprobantesCompra"
            Me.gbComprobantesCompra.Size = New System.Drawing.Size(355, 317)
            Me.gbComprobantesCompra.TabIndex = 36
            Me.gbComprobantesCompra.TabStop = False
            Me.gbComprobantesCompra.Text = "COMPROBANTES COMPRA"
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(164, 0)
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
            Me.dgvComprobantesCompra.BackgroundColor = System.Drawing.Color.White
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
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle9
            Me.dgvComprobantesCompra.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvComprobantesCompra.Location = New System.Drawing.Point(3, 17)
            Me.dgvComprobantesCompra.MultiSelect = False
            Me.dgvComprobantesCompra.Name = "dgvComprobantesCompra"
            Me.dgvComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesCompra.Size = New System.Drawing.Size(349, 297)
            Me.dgvComprobantesCompra.TabIndex = 0
            '
            'chk
            '
            Me.chk.HeaderText = "CHK"
            Me.chk.Name = "chk"
            Me.chk.Width = 30
            '
            'gbPagosComprobanteCompra
            '
            Me.gbPagosComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbPagosComprobanteCompra.Controls.Add(Me.dgvPagosComprobantesCompra)
            Me.gbPagosComprobanteCompra.Enabled = False
            Me.gbPagosComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbPagosComprobanteCompra.Location = New System.Drawing.Point(615, 416)
            Me.gbPagosComprobanteCompra.Name = "gbPagosComprobanteCompra"
            Me.gbPagosComprobanteCompra.Size = New System.Drawing.Size(357, 194)
            Me.gbPagosComprobanteCompra.TabIndex = 88
            Me.gbPagosComprobanteCompra.TabStop = False
            Me.gbPagosComprobanteCompra.Text = "PAGOS POR COMPROBANTE"
            '
            'dgvPagosComprobantesCompra
            '
            Me.dgvPagosComprobantesCompra.AllowUserToAddRows = False
            Me.dgvPagosComprobantesCompra.AllowUserToDeleteRows = False
            Me.dgvPagosComprobantesCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvPagosComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvPagosComprobantesCompra.BackgroundColor = System.Drawing.Color.White
            Me.dgvPagosComprobantesCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPagosComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvPagosComprobantesCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPagosComprobantesCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvPagosComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPagosComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle13
            Me.dgvPagosComprobantesCompra.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvPagosComprobantesCompra.Location = New System.Drawing.Point(3, 17)
            Me.dgvPagosComprobantesCompra.MultiSelect = False
            Me.dgvPagosComprobantesCompra.Name = "dgvPagosComprobantesCompra"
            Me.dgvPagosComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvPagosComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvPagosComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPagosComprobantesCompra.Size = New System.Drawing.Size(351, 174)
            Me.dgvPagosComprobantesCompra.TabIndex = 0
            '
            'gbTotalDebeHaber
            '
            Me.gbTotalDebeHaber.BackColor = System.Drawing.Color.White
            Me.gbTotalDebeHaber.Controls.Add(Me.txtTotalHaber)
            Me.gbTotalDebeHaber.Controls.Add(Me.txtTotalDebe)
            Me.gbTotalDebeHaber.Controls.Add(Me.lblTotal)
            Me.gbTotalDebeHaber.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotalDebeHaber.Location = New System.Drawing.Point(-1, 571)
            Me.gbTotalDebeHaber.Name = "gbTotalDebeHaber"
            Me.gbTotalDebeHaber.Size = New System.Drawing.Size(615, 38)
            Me.gbTotalDebeHaber.TabIndex = 90
            Me.gbTotalDebeHaber.TabStop = False
            '
            'dgvCompEgresoPagosCompCompra
            '
            Me.dgvCompEgresoPagosCompCompra.AllowUserToAddRows = False
            Me.dgvCompEgresoPagosCompCompra.AllowUserToDeleteRows = False
            Me.dgvCompEgresoPagosCompCompra.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvCompEgresoPagosCompCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCompEgresoPagosCompCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_CE, Me.ID_CC_, Me.ID_PCC, Me.MONTO_PCC, Me.NRO_REG_ASIENTO})
            Me.dgvCompEgresoPagosCompCompra.Location = New System.Drawing.Point(733, 391)
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
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.dgvComprobanteEgresoBanco)
            Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(0, 377)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(614, 198)
            Me.GroupBox2.TabIndex = 92
            Me.GroupBox2.TabStop = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(973, 32)
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
            'FormComprobanteEgresoBanco
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(973, 613)
            Me.Controls.Add(Me.gbProveedor)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbPagosComprobanteCompra)
            Me.Controls.Add(Me.gbComprobantesCompra)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.pCentroCosto)
            Me.Controls.Add(Me.gbCabecera)
            Me.Controls.Add(Me.gbReceptor)
            Me.Controls.Add(Me.gbBanco)
            Me.Controls.Add(Me.dgvCompEgresoPagosCompCompra)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.gbTotalDebeHaber)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormComprobanteEgresoBanco"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "COMPROBANTE DE EGRESO"
            Me.gbBanco.ResumeLayout(False)
            Me.gbBanco.PerformLayout()
            Me.gbReceptor.ResumeLayout(False)
            Me.gbReceptor.PerformLayout()
            Me.gbCabecera.ResumeLayout(False)
            Me.gbCabecera.PerformLayout()
            CType(Me.dgvComprobanteEgresoBanco, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pCentroCosto.ResumeLayout(False)
            Me.pCentroCosto.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbProveedor.ResumeLayout(False)
            Me.gbProveedor.PerformLayout()
            Me.gbComprobantesCompra.ResumeLayout(False)
            Me.gbComprobantesCompra.PerformLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbPagosComprobanteCompra.ResumeLayout(False)
            CType(Me.dgvPagosComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbTotalDebeHaber.ResumeLayout(False)
            Me.gbTotalDebeHaber.PerformLayout()
            CType(Me.dgvCompEgresoPagosCompCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblNumeroComprobanteEgreso As System.Windows.Forms.Label
        Friend WithEvents lblFechaComprobante As System.Windows.Forms.Label
        Friend WithEvents lblPagadoA As System.Windows.Forms.Label
        Friend WithEvents lblRucCi As System.Windows.Forms.Label
        Friend WithEvents lblActividad As System.Windows.Forms.Label
        Friend WithEvents lblTipoPago As System.Windows.Forms.Label
        Friend WithEvents lblRazonComprobanteEgreso As System.Windows.Forms.Label
        Friend WithEvents lblBanco As System.Windows.Forms.Label
        Friend WithEvents lblTipoCuenta As System.Windows.Forms.Label
        Friend WithEvents lblNumeroCheque As System.Windows.Forms.Label
        Friend WithEvents txtNumeroComprobanteEgresoBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtPagadoA As System.Windows.Forms.TextBox
        Friend WithEvents txtActividad As System.Windows.Forms.TextBox
        Friend WithEvents txtRazonComprobanteEgresoBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtRucCi As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroCheque As System.Windows.Forms.TextBox
        Friend WithEvents gbBanco As System.Windows.Forms.GroupBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbTipoPago As System.Windows.Forms.ComboBox
        Friend WithEvents gbReceptor As System.Windows.Forms.GroupBox
        Friend WithEvents txtFacturaReceptor As System.Windows.Forms.TextBox
        Friend WithEvents lblFacturaAPagar As System.Windows.Forms.Label
        Friend WithEvents gbCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents dgvComprobanteEgresoBanco As System.Windows.Forms.DataGridView
        Friend WithEvents lblValorComprobanteEgreso As System.Windows.Forms.Label
        Friend WithEvents txtValorComprobanteEgresoBancos As System.Windows.Forms.TextBox
        Friend WithEvents pCentroCosto As System.Windows.Forms.Panel
        Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents btnAgregarConceptoComprobante As System.Windows.Forms.Button
        Friend WithEvents btnBuscarPersonal As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdComprobanteEgresoBancos As System.Windows.Forms.Label
        Friend WithEvents gbProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombreComercialProveedor As System.Windows.Forms.TextBox
        Friend WithEvents gbComprobantesCompra As System.Windows.Forms.GroupBox
        Friend WithEvents dgvComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents gbPagosComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents dgvPagosComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents chkActivar As System.Windows.Forms.CheckBox
        Friend WithEvents gbTotalDebeHaber As System.Windows.Forms.GroupBox
        Friend WithEvents cmbCuentasContables As System.Windows.Forms.ComboBox
        Friend WithEvents btnAgregarBancosComprobante As System.Windows.Forms.Button
        Friend WithEvents dgvCompEgresoPagosCompCompra As System.Windows.Forms.DataGridView
        Friend WithEvents ID_CE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_CC_ As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_PCC As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents MONTO_PCC As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NRO_REG_ASIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnEditarValores As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ToolStripMenuItemEliminar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtConceptoComprobanteEgreso As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaComprobanteEgreso As System.Windows.Forms.DateTimePicker
        Friend WithEvents chkTransferenciaInterna As System.Windows.Forms.CheckBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
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
    End Class
End Namespace