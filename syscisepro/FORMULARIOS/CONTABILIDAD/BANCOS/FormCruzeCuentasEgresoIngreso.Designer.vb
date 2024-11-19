Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormCruzeCuentasEgresoIngreso
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCruzeCuentasEgresoIngreso))
            Me.txtNombreComercialClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.gbPagosFacturaVenta = New System.Windows.Forms.GroupBox()
            Me.dgvPagosFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.gbFacturaVenta = New System.Windows.Forms.GroupBox()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialProveedor = New System.Windows.Forms.TextBox()
            Me.gbPagosComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.dgvPagosComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.gbComprobantesCompra = New System.Windows.Forms.GroupBox()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.dgvComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.gbFacturasTotalCXC = New System.Windows.Forms.GroupBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtValorComprobaneIngreso = New System.Windows.Forms.TextBox()
            Me.txtFacturasAPagar = New System.Windows.Forms.TextBox()
            Me.gbFacturasTotalCXP = New System.Windows.Forms.GroupBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtValorComprobanteEgresoBancos = New System.Windows.Forms.TextBox()
            Me.txtFacturaReceptor = New System.Windows.Forms.TextBox()
            Me.rbtSoloCruce = New System.Windows.Forms.RadioButton()
            Me.rbComprobanteIngreso = New System.Windows.Forms.RadioButton()
            Me.rbComprobanteEgreso = New System.Windows.Forms.RadioButton()
            Me.dgvAsientoDiario = New System.Windows.Forms.DataGridView()
            Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CONCEPTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DETALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DEBE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.HABER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_CC = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_FV = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtNumeroCheque = New System.Windows.Forms.TextBox()
            Me.txtTitularCheque = New System.Windows.Forms.TextBox()
            Me.dtpFechaEmisionCheque = New System.Windows.Forms.DateTimePicker()
            Me.txtCtaCteCheque = New System.Windows.Forms.TextBox()
            Me.txtBancoCheque = New System.Windows.Forms.TextBox()
            Me.gbFormaPago = New System.Windows.Forms.GroupBox()
            Me.rbCheque = New System.Windows.Forms.RadioButton()
            Me.rbTransaccion = New System.Windows.Forms.RadioButton()
            Me.rbEfectivo = New System.Windows.Forms.RadioButton()
            Me.rbTarjetaCredido = New System.Windows.Forms.RadioButton()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.btnEditarValores = New System.Windows.Forms.Button()
            Me.btnAgregarConceptoComprobante = New System.Windows.Forms.Button()
            Me.lblCodigoCuentaContable = New System.Windows.Forms.Label()
            Me.cmbCuentasContables = New System.Windows.Forms.ComboBox()
            Me.gbTotalDebeTotalHaber = New System.Windows.Forms.GroupBox()
            Me.txtTotalHaber = New System.Windows.Forms.TextBox()
            Me.txtTotalDebe = New System.Windows.Forms.TextBox()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.dtpFechaEmisionComprobante = New System.Windows.Forms.DateTimePicker()
            Me.txtValorDebeAjuste = New System.Windows.Forms.TextBox()
            Me.txtValorHaberAjuste = New System.Windows.Forms.TextBox()
            Me.ContextMenuStripClicDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ToolStripMenuItemEliminar = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbpAsientoContable = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.lblIdComprobanteIngresoBancos = New System.Windows.Forms.Label()
            Me.lblIdComprobanteEgresoBancos = New System.Windows.Forms.Label()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.gbPagosFacturaVenta.SuspendLayout()
            CType(Me.dgvPagosFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbFacturaVenta.SuspendLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbPagosComprobanteCompra.SuspendLayout()
            CType(Me.dgvPagosComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbComprobantesCompra.SuspendLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbFacturasTotalCXC.SuspendLayout()
            Me.gbFacturasTotalCXP.SuspendLayout()
            CType(Me.dgvAsientoDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbFormaPago.SuspendLayout()
            Me.gbTotalDebeTotalHaber.SuspendLayout()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            Me.gbpAsientoContable.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtNombreComercialClienteGeneral
            '
            Me.txtNombreComercialClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialClienteGeneral.Location = New System.Drawing.Point(252, 4)
            Me.txtNombreComercialClienteGeneral.Name = "txtNombreComercialClienteGeneral"
            Me.txtNombreComercialClienteGeneral.Size = New System.Drawing.Size(310, 21)
            Me.txtNombreComercialClienteGeneral.TabIndex = 2
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdClienteGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(268, 40)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdClienteGeneral.TabIndex = 76
            Me.lblIdClienteGeneral.Text = "..."
            '
            'gbPagosFacturaVenta
            '
            Me.gbPagosFacturaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gbPagosFacturaVenta.Controls.Add(Me.dgvPagosFacturaVenta)
            Me.gbPagosFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbPagosFacturaVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.gbPagosFacturaVenta.Location = New System.Drawing.Point(1, 338)
            Me.gbPagosFacturaVenta.Name = "gbPagosFacturaVenta"
            Me.gbPagosFacturaVenta.Size = New System.Drawing.Size(283, 227)
            Me.gbPagosFacturaVenta.TabIndex = 103
            Me.gbPagosFacturaVenta.TabStop = False
            Me.gbPagosFacturaVenta.Text = "Pagos por Factura"
            '
            'dgvPagosFacturaVenta
            '
            Me.dgvPagosFacturaVenta.AllowUserToAddRows = False
            Me.dgvPagosFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvPagosFacturaVenta.AllowUserToResizeRows = False
            Me.dgvPagosFacturaVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvPagosFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPagosFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvPagosFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPagosFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvPagosFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPagosFacturaVenta.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvPagosFacturaVenta.Location = New System.Drawing.Point(6, 19)
            Me.dgvPagosFacturaVenta.MultiSelect = False
            Me.dgvPagosFacturaVenta.Name = "dgvPagosFacturaVenta"
            Me.dgvPagosFacturaVenta.RowHeadersVisible = False
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvPagosFacturaVenta.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvPagosFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPagosFacturaVenta.Size = New System.Drawing.Size(291, 206)
            Me.dgvPagosFacturaVenta.TabIndex = 0
            '
            'gbFacturaVenta
            '
            Me.gbFacturaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gbFacturaVenta.Controls.Add(Me.lblIdFacturaVenta)
            Me.gbFacturaVenta.Controls.Add(Me.dgvFacturaVenta)
            Me.gbFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFacturaVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.gbFacturaVenta.Location = New System.Drawing.Point(1, 94)
            Me.gbFacturaVenta.Name = "gbFacturaVenta"
            Me.gbFacturaVenta.Size = New System.Drawing.Size(283, 193)
            Me.gbFacturaVenta.TabIndex = 102
            Me.gbFacturaVenta.TabStop = False
            Me.gbFacturaVenta.Text = "Facturas Ventas"
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(235, 0)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(16, 13)
            Me.lblIdFacturaVenta.TabIndex = 30
            Me.lblIdFacturaVenta.Text = "..."
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFacturaVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturaVenta.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(3, 17)
            Me.dgvFacturaVenta.MultiSelect = False
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.RowHeadersVisible = False
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(277, 173)
            Me.dgvFacturaVenta.TabIndex = 0
            '
            'chk
            '
            Me.chk.HeaderText = "CHK"
            Me.chk.Name = "chk"
            Me.chk.Width = 30
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProveedorGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(625, 39)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 1
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'txtNombreComercialProveedor
            '
            Me.txtNombreComercialProveedor.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedor.Location = New System.Drawing.Point(681, 5)
            Me.txtNombreComercialProveedor.Name = "txtNombreComercialProveedor"
            Me.txtNombreComercialProveedor.Size = New System.Drawing.Size(297, 21)
            Me.txtNombreComercialProveedor.TabIndex = 0
            '
            'gbPagosComprobanteCompra
            '
            Me.gbPagosComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gbPagosComprobanteCompra.Controls.Add(Me.dgvPagosComprobantesCompra)
            Me.gbPagosComprobanteCompra.Enabled = False
            Me.gbPagosComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbPagosComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.gbPagosComprobanteCompra.Location = New System.Drawing.Point(291, 338)
            Me.gbPagosComprobanteCompra.Name = "gbPagosComprobanteCompra"
            Me.gbPagosComprobanteCompra.Size = New System.Drawing.Size(283, 227)
            Me.gbPagosComprobanteCompra.TabIndex = 106
            Me.gbPagosComprobanteCompra.TabStop = False
            Me.gbPagosComprobanteCompra.Text = "Pagos x Comprobante"
            '
            'dgvPagosComprobantesCompra
            '
            Me.dgvPagosComprobantesCompra.AllowUserToAddRows = False
            Me.dgvPagosComprobantesCompra.AllowUserToDeleteRows = False
            Me.dgvPagosComprobantesCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvPagosComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvPagosComprobantesCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvPagosComprobantesCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPagosComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvPagosComprobantesCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPagosComprobantesCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvPagosComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPagosComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle9
            Me.dgvPagosComprobantesCompra.Location = New System.Drawing.Point(6, 19)
            Me.dgvPagosComprobantesCompra.MultiSelect = False
            Me.dgvPagosComprobantesCompra.Name = "dgvPagosComprobantesCompra"
            Me.dgvPagosComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvPagosComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvPagosComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPagosComprobantesCompra.Size = New System.Drawing.Size(293, 206)
            Me.dgvPagosComprobantesCompra.TabIndex = 0
            '
            'gbComprobantesCompra
            '
            Me.gbComprobantesCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gbComprobantesCompra.Controls.Add(Me.lblIdComprobanteCompra)
            Me.gbComprobantesCompra.Controls.Add(Me.dgvComprobantesCompra)
            Me.gbComprobantesCompra.Enabled = False
            Me.gbComprobantesCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComprobantesCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.gbComprobantesCompra.Location = New System.Drawing.Point(291, 95)
            Me.gbComprobantesCompra.Name = "gbComprobantesCompra"
            Me.gbComprobantesCompra.Size = New System.Drawing.Size(283, 192)
            Me.gbComprobantesCompra.TabIndex = 105
            Me.gbComprobantesCompra.TabStop = False
            Me.gbComprobantesCompra.Text = "Comprobantes Compra"
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(249, 1)
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
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvComprobantesCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvComprobantesCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvComprobantesCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobantesCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle13
            Me.dgvComprobantesCompra.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvComprobantesCompra.Location = New System.Drawing.Point(3, 17)
            Me.dgvComprobantesCompra.MultiSelect = False
            Me.dgvComprobantesCompra.Name = "dgvComprobantesCompra"
            Me.dgvComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesCompra.Size = New System.Drawing.Size(277, 172)
            Me.dgvComprobantesCompra.TabIndex = 0
            '
            'DataGridViewCheckBoxColumn1
            '
            Me.DataGridViewCheckBoxColumn1.HeaderText = "CHK"
            Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
            Me.DataGridViewCheckBoxColumn1.Width = 30
            '
            'gbFacturasTotalCXC
            '
            Me.gbFacturasTotalCXC.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.gbFacturasTotalCXC.Controls.Add(Me.Label5)
            Me.gbFacturasTotalCXC.Controls.Add(Me.txtValorComprobaneIngreso)
            Me.gbFacturasTotalCXC.Controls.Add(Me.txtFacturasAPagar)
            Me.gbFacturasTotalCXC.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFacturasTotalCXC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.gbFacturasTotalCXC.Location = New System.Drawing.Point(1, 291)
            Me.gbFacturasTotalCXC.Name = "gbFacturasTotalCXC"
            Me.gbFacturasTotalCXC.Size = New System.Drawing.Size(283, 43)
            Me.gbFacturasTotalCXC.TabIndex = 103
            Me.gbFacturasTotalCXC.TabStop = False
            Me.gbFacturasTotalCXC.Text = "Facturas CXC"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(186, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(59, 13)
            Me.Label5.TabIndex = 77
            Me.Label5.Text = "Total CXC:"
            '
            'txtValorComprobaneIngreso
            '
            Me.txtValorComprobaneIngreso.BackColor = System.Drawing.Color.White
            Me.txtValorComprobaneIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorComprobaneIngreso.Enabled = False
            Me.txtValorComprobaneIngreso.Location = New System.Drawing.Point(185, 16)
            Me.txtValorComprobaneIngreso.Name = "txtValorComprobaneIngreso"
            Me.txtValorComprobaneIngreso.Size = New System.Drawing.Size(91, 21)
            Me.txtValorComprobaneIngreso.TabIndex = 25
            Me.txtValorComprobaneIngreso.Text = "0.00"
            Me.txtValorComprobaneIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtFacturasAPagar
            '
            Me.txtFacturasAPagar.BackColor = System.Drawing.Color.White
            Me.txtFacturasAPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFacturasAPagar.Enabled = False
            Me.txtFacturasAPagar.Location = New System.Drawing.Point(3, 16)
            Me.txtFacturasAPagar.Name = "txtFacturasAPagar"
            Me.txtFacturasAPagar.Size = New System.Drawing.Size(174, 21)
            Me.txtFacturasAPagar.TabIndex = 24
            '
            'gbFacturasTotalCXP
            '
            Me.gbFacturasTotalCXP.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.gbFacturasTotalCXP.Controls.Add(Me.Label6)
            Me.gbFacturasTotalCXP.Controls.Add(Me.txtValorComprobanteEgresoBancos)
            Me.gbFacturasTotalCXP.Controls.Add(Me.txtFacturaReceptor)
            Me.gbFacturasTotalCXP.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFacturasTotalCXP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.gbFacturasTotalCXP.Location = New System.Drawing.Point(291, 291)
            Me.gbFacturasTotalCXP.Name = "gbFacturasTotalCXP"
            Me.gbFacturasTotalCXP.Size = New System.Drawing.Size(283, 43)
            Me.gbFacturasTotalCXP.TabIndex = 104
            Me.gbFacturasTotalCXP.TabStop = False
            Me.gbFacturasTotalCXP.Text = "Facturas CXP"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(189, 1)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(59, 13)
            Me.Label6.TabIndex = 78
            Me.Label6.Text = "Total CXP:"
            '
            'txtValorComprobanteEgresoBancos
            '
            Me.txtValorComprobanteEgresoBancos.BackColor = System.Drawing.Color.White
            Me.txtValorComprobanteEgresoBancos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorComprobanteEgresoBancos.Enabled = False
            Me.txtValorComprobanteEgresoBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorComprobanteEgresoBancos.Location = New System.Drawing.Point(181, 16)
            Me.txtValorComprobanteEgresoBancos.Name = "txtValorComprobanteEgresoBancos"
            Me.txtValorComprobanteEgresoBancos.Size = New System.Drawing.Size(91, 21)
            Me.txtValorComprobanteEgresoBancos.TabIndex = 30
            Me.txtValorComprobanteEgresoBancos.Text = "0.00"
            Me.txtValorComprobanteEgresoBancos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtFacturaReceptor
            '
            Me.txtFacturaReceptor.BackColor = System.Drawing.Color.White
            Me.txtFacturaReceptor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFacturaReceptor.Enabled = False
            Me.txtFacturaReceptor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFacturaReceptor.Location = New System.Drawing.Point(3, 16)
            Me.txtFacturaReceptor.Name = "txtFacturaReceptor"
            Me.txtFacturaReceptor.Size = New System.Drawing.Size(174, 21)
            Me.txtFacturaReceptor.TabIndex = 23
            '
            'rbtSoloCruce
            '
            Me.rbtSoloCruce.AutoSize = True
            Me.rbtSoloCruce.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbtSoloCruce.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtSoloCruce.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbtSoloCruce.Location = New System.Drawing.Point(3, 6)
            Me.rbtSoloCruce.Name = "rbtSoloCruce"
            Me.rbtSoloCruce.Size = New System.Drawing.Size(54, 17)
            Me.rbtSoloCruce.TabIndex = 79
            Me.rbtSoloCruce.Text = "Cruce"
            Me.rbtSoloCruce.UseVisualStyleBackColor = False
            '
            'rbComprobanteIngreso
            '
            Me.rbComprobanteIngreso.AutoSize = True
            Me.rbComprobanteIngreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbComprobanteIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbComprobanteIngreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbComprobanteIngreso.Location = New System.Drawing.Point(63, 6)
            Me.rbComprobanteIngreso.Name = "rbComprobanteIngreso"
            Me.rbComprobanteIngreso.Size = New System.Drawing.Size(62, 17)
            Me.rbComprobanteIngreso.TabIndex = 1
            Me.rbComprobanteIngreso.Text = "Ingreso"
            Me.rbComprobanteIngreso.UseVisualStyleBackColor = False
            '
            'rbComprobanteEgreso
            '
            Me.rbComprobanteEgreso.AutoSize = True
            Me.rbComprobanteEgreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbComprobanteEgreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbComprobanteEgreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbComprobanteEgreso.Location = New System.Drawing.Point(127, 6)
            Me.rbComprobanteEgreso.Name = "rbComprobanteEgreso"
            Me.rbComprobanteEgreso.Size = New System.Drawing.Size(59, 17)
            Me.rbComprobanteEgreso.TabIndex = 0
            Me.rbComprobanteEgreso.Text = "Egreso"
            Me.rbComprobanteEgreso.UseVisualStyleBackColor = False
            '
            'dgvAsientoDiario
            '
            Me.dgvAsientoDiario.AllowUserToAddRows = False
            Me.dgvAsientoDiario.AllowUserToDeleteRows = False
            Me.dgvAsientoDiario.AllowUserToResizeRows = False
            DataGridViewCellStyle15.BackColor = System.Drawing.Color.Silver
            Me.dgvAsientoDiario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvAsientoDiario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvAsientoDiario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvAsientoDiario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvAsientoDiario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientoDiario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
            Me.dgvAsientoDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAsientoDiario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.CUENTA, Me.CONCEPTO, Me.DETALLE, Me.DEBE, Me.HABER, Me.ID_CC, Me.ID_FV})
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle19.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientoDiario.DefaultCellStyle = DataGridViewCellStyle19
            Me.dgvAsientoDiario.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvAsientoDiario.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvAsientoDiario.Location = New System.Drawing.Point(3, 17)
            Me.dgvAsientoDiario.MultiSelect = False
            Me.dgvAsientoDiario.Name = "dgvAsientoDiario"
            Me.dgvAsientoDiario.RowHeadersVisible = False
            DataGridViewCellStyle20.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvAsientoDiario.RowsDefaultCellStyle = DataGridViewCellStyle20
            Me.dgvAsientoDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientoDiario.Size = New System.Drawing.Size(403, 202)
            Me.dgvAsientoDiario.TabIndex = 108
            '
            'CODIGO
            '
            Me.CODIGO.HeaderText = "CODIGO"
            Me.CODIGO.Name = "CODIGO"
            Me.CODIGO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.CODIGO.Width = 90
            '
            'CUENTA
            '
            Me.CUENTA.HeaderText = "CUENTA"
            Me.CUENTA.Name = "CUENTA"
            '
            'CONCEPTO
            '
            Me.CONCEPTO.HeaderText = "CONCEPTO"
            Me.CONCEPTO.Name = "CONCEPTO"
            '
            'DETALLE
            '
            Me.DETALLE.HeaderText = "DETALLE"
            Me.DETALLE.Name = "DETALLE"
            '
            'DEBE
            '
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DEBE.DefaultCellStyle = DataGridViewCellStyle17
            Me.DEBE.HeaderText = "DEBE"
            Me.DEBE.Name = "DEBE"
            Me.DEBE.Width = 85
            '
            'HABER
            '
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.HABER.DefaultCellStyle = DataGridViewCellStyle18
            Me.HABER.HeaderText = "HABER"
            Me.HABER.Name = "HABER"
            Me.HABER.Width = 85
            '
            'ID_CC
            '
            Me.ID_CC.HeaderText = "ID_CC"
            Me.ID_CC.Name = "ID_CC"
            Me.ID_CC.Width = 50
            '
            'ID_FV
            '
            Me.ID_FV.HeaderText = "ID_FV"
            Me.ID_FV.Name = "ID_FV"
            '
            'txtNumeroCheque
            '
            Me.txtNumeroCheque.BackColor = System.Drawing.Color.White
            Me.txtNumeroCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroCheque.Location = New System.Drawing.Point(291, 62)
            Me.txtNumeroCheque.Name = "txtNumeroCheque"
            Me.txtNumeroCheque.Size = New System.Drawing.Size(106, 21)
            Me.txtNumeroCheque.TabIndex = 43
            '
            'txtTitularCheque
            '
            Me.txtTitularCheque.BackColor = System.Drawing.Color.White
            Me.txtTitularCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTitularCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTitularCheque.Location = New System.Drawing.Point(209, 89)
            Me.txtTitularCheque.Name = "txtTitularCheque"
            Me.txtTitularCheque.Size = New System.Drawing.Size(188, 21)
            Me.txtTitularCheque.TabIndex = 39
            '
            'dtpFechaEmisionCheque
            '
            Me.dtpFechaEmisionCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionCheque.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionCheque.Location = New System.Drawing.Point(56, 90)
            Me.dtpFechaEmisionCheque.Name = "dtpFechaEmisionCheque"
            Me.dtpFechaEmisionCheque.Size = New System.Drawing.Size(92, 21)
            Me.dtpFechaEmisionCheque.TabIndex = 38
            '
            'txtCtaCteCheque
            '
            Me.txtCtaCteCheque.BackColor = System.Drawing.Color.White
            Me.txtCtaCteCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCtaCteCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCtaCteCheque.Location = New System.Drawing.Point(285, 114)
            Me.txtCtaCteCheque.Name = "txtCtaCteCheque"
            Me.txtCtaCteCheque.Size = New System.Drawing.Size(112, 21)
            Me.txtCtaCteCheque.TabIndex = 35
            '
            'txtBancoCheque
            '
            Me.txtBancoCheque.BackColor = System.Drawing.Color.White
            Me.txtBancoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBancoCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBancoCheque.Location = New System.Drawing.Point(56, 115)
            Me.txtBancoCheque.Name = "txtBancoCheque"
            Me.txtBancoCheque.Size = New System.Drawing.Size(114, 21)
            Me.txtBancoCheque.TabIndex = 0
            '
            'gbFormaPago
            '
            Me.gbFormaPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.gbFormaPago.Controls.Add(Me.rbCheque)
            Me.gbFormaPago.Controls.Add(Me.rbTransaccion)
            Me.gbFormaPago.Controls.Add(Me.rbEfectivo)
            Me.gbFormaPago.Controls.Add(Me.rbTarjetaCredido)
            Me.gbFormaPago.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFormaPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.gbFormaPago.Location = New System.Drawing.Point(3, 52)
            Me.gbFormaPago.Name = "gbFormaPago"
            Me.gbFormaPago.Size = New System.Drawing.Size(200, 37)
            Me.gbFormaPago.TabIndex = 114
            Me.gbFormaPago.TabStop = False
            Me.gbFormaPago.Text = "Pago"
            '
            'rbCheque
            '
            Me.rbCheque.AutoSize = True
            Me.rbCheque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCheque.Location = New System.Drawing.Point(6, 14)
            Me.rbCheque.Name = "rbCheque"
            Me.rbCheque.Size = New System.Drawing.Size(44, 17)
            Me.rbCheque.TabIndex = 64
            Me.rbCheque.Text = "Che"
            Me.rbCheque.UseVisualStyleBackColor = True
            '
            'rbTransaccion
            '
            Me.rbTransaccion.AutoSize = True
            Me.rbTransaccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTransaccion.Location = New System.Drawing.Point(150, 14)
            Me.rbTransaccion.Name = "rbTransaccion"
            Me.rbTransaccion.Size = New System.Drawing.Size(42, 17)
            Me.rbTransaccion.TabIndex = 67
            Me.rbTransaccion.Text = "Tra"
            Me.rbTransaccion.UseVisualStyleBackColor = True
            '
            'rbEfectivo
            '
            Me.rbEfectivo.AutoSize = True
            Me.rbEfectivo.Checked = True
            Me.rbEfectivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbEfectivo.Location = New System.Drawing.Point(53, 14)
            Me.rbEfectivo.Name = "rbEfectivo"
            Me.rbEfectivo.Size = New System.Drawing.Size(41, 17)
            Me.rbEfectivo.TabIndex = 65
            Me.rbEfectivo.TabStop = True
            Me.rbEfectivo.Text = "Efe"
            Me.rbEfectivo.UseVisualStyleBackColor = True
            '
            'rbTarjetaCredido
            '
            Me.rbTarjetaCredido.AutoSize = True
            Me.rbTarjetaCredido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTarjetaCredido.Location = New System.Drawing.Point(101, 14)
            Me.rbTarjetaCredido.Name = "rbTarjetaCredido"
            Me.rbTarjetaCredido.Size = New System.Drawing.Size(44, 17)
            Me.rbTarjetaCredido.TabIndex = 66
            Me.rbTarjetaCredido.Text = "Tarj"
            Me.rbTarjetaCredido.UseVisualStyleBackColor = True
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(300, 30)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(97, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.BackColor = System.Drawing.Color.White
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(56, 30)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(107, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'btnEditarValores
            '
            Me.btnEditarValores.BackColor = System.Drawing.Color.Transparent
            Me.btnEditarValores.FlatAppearance.BorderSize = 0
            Me.btnEditarValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditarValores.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditarValores.Image = Global.syscisepro.My.Resources.Resources.edit_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnEditarValores.Location = New System.Drawing.Point(346, 141)
            Me.btnEditarValores.Name = "btnEditarValores"
            Me.btnEditarValores.Size = New System.Drawing.Size(31, 30)
            Me.btnEditarValores.TabIndex = 33
            Me.btnEditarValores.UseVisualStyleBackColor = False
            '
            'btnAgregarConceptoComprobante
            '
            Me.btnAgregarConceptoComprobante.BackColor = System.Drawing.Color.Transparent
            Me.btnAgregarConceptoComprobante.FlatAppearance.BorderSize = 0
            Me.btnAgregarConceptoComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAgregarConceptoComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarConceptoComprobante.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarConceptoComprobante.Location = New System.Drawing.Point(303, 140)
            Me.btnAgregarConceptoComprobante.Name = "btnAgregarConceptoComprobante"
            Me.btnAgregarConceptoComprobante.Size = New System.Drawing.Size(37, 30)
            Me.btnAgregarConceptoComprobante.TabIndex = 23
            Me.btnAgregarConceptoComprobante.UseVisualStyleBackColor = False
            '
            'lblCodigoCuentaContable
            '
            Me.lblCodigoCuentaContable.AutoSize = True
            Me.lblCodigoCuentaContable.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblCodigoCuentaContable.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigoCuentaContable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblCodigoCuentaContable.Location = New System.Drawing.Point(725, 100)
            Me.lblCodigoCuentaContable.Name = "lblCodigoCuentaContable"
            Me.lblCodigoCuentaContable.Size = New System.Drawing.Size(16, 13)
            Me.lblCodigoCuentaContable.TabIndex = 37
            Me.lblCodigoCuentaContable.Text = "..."
            '
            'cmbCuentasContables
            '
            Me.cmbCuentasContables.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentasContables.FormattingEnabled = True
            Me.cmbCuentasContables.Location = New System.Drawing.Point(56, 3)
            Me.cmbCuentasContables.Name = "cmbCuentasContables"
            Me.cmbCuentasContables.Size = New System.Drawing.Size(157, 21)
            Me.cmbCuentasContables.TabIndex = 31
            '
            'gbTotalDebeTotalHaber
            '
            Me.gbTotalDebeTotalHaber.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.txtTotalHaber)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.txtTotalDebe)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.lblTotal)
            Me.gbTotalDebeTotalHaber.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotalDebeTotalHaber.Location = New System.Drawing.Point(580, 523)
            Me.gbTotalDebeTotalHaber.Name = "gbTotalDebeTotalHaber"
            Me.gbTotalDebeTotalHaber.Size = New System.Drawing.Size(409, 42)
            Me.gbTotalDebeTotalHaber.TabIndex = 118
            Me.gbTotalDebeTotalHaber.TabStop = False
            '
            'txtTotalHaber
            '
            Me.txtTotalHaber.BackColor = System.Drawing.Color.White
            Me.txtTotalHaber.Enabled = False
            Me.txtTotalHaber.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalHaber.Location = New System.Drawing.Point(235, 11)
            Me.txtTotalHaber.Name = "txtTotalHaber"
            Me.txtTotalHaber.Size = New System.Drawing.Size(73, 21)
            Me.txtTotalHaber.TabIndex = 35
            Me.txtTotalHaber.Text = "0.00"
            Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalDebe
            '
            Me.txtTotalDebe.BackColor = System.Drawing.Color.White
            Me.txtTotalDebe.Enabled = False
            Me.txtTotalDebe.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalDebe.Location = New System.Drawing.Point(161, 11)
            Me.txtTotalDebe.Name = "txtTotalDebe"
            Me.txtTotalDebe.Size = New System.Drawing.Size(73, 21)
            Me.txtTotalDebe.TabIndex = 36
            Me.txtTotalDebe.Text = "0.00"
            Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Roboto Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblTotal.Location = New System.Drawing.Point(89, 14)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(54, 13)
            Me.lblTotal.TabIndex = 34
            Me.lblTotal.Text = "TOTAL :"
            '
            'dtpFechaEmisionComprobante
            '
            Me.dtpFechaEmisionComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionComprobante.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionComprobante.Location = New System.Drawing.Point(311, 4)
            Me.dtpFechaEmisionComprobante.Name = "dtpFechaEmisionComprobante"
            Me.dtpFechaEmisionComprobante.Size = New System.Drawing.Size(87, 21)
            Me.dtpFechaEmisionComprobante.TabIndex = 78
            '
            'txtValorDebeAjuste
            '
            Me.txtValorDebeAjuste.BackColor = System.Drawing.Color.White
            Me.txtValorDebeAjuste.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorDebeAjuste.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorDebeAjuste.Location = New System.Drawing.Point(56, 141)
            Me.txtValorDebeAjuste.Name = "txtValorDebeAjuste"
            Me.txtValorDebeAjuste.Size = New System.Drawing.Size(73, 21)
            Me.txtValorDebeAjuste.TabIndex = 0
            Me.txtValorDebeAjuste.Text = "0.00"
            Me.txtValorDebeAjuste.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtValorHaberAjuste
            '
            Me.txtValorHaberAjuste.BackColor = System.Drawing.Color.White
            Me.txtValorHaberAjuste.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorHaberAjuste.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorHaberAjuste.Location = New System.Drawing.Point(209, 140)
            Me.txtValorHaberAjuste.Name = "txtValorHaberAjuste"
            Me.txtValorHaberAjuste.Size = New System.Drawing.Size(73, 21)
            Me.txtValorHaberAjuste.TabIndex = 0
            Me.txtValorHaberAjuste.Text = "0.00"
            Me.txtValorHaberAjuste.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'ContextMenuStripClicDerecho
            '
            Me.ContextMenuStripClicDerecho.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemEliminar})
            Me.ContextMenuStripClicDerecho.Name = "ContextMenuStripClicDerecho"
            Me.ContextMenuStripClicDerecho.Size = New System.Drawing.Size(118, 26)
            '
            'ToolStripMenuItemEliminar
            '
            Me.ToolStripMenuItemEliminar.Name = "ToolStripMenuItemEliminar"
            Me.ToolStripMenuItemEliminar.Size = New System.Drawing.Size(117, 22)
            Me.ToolStripMenuItemEliminar.Text = "Eliminar"
            '
            'gbpAsientoContable
            '
            Me.gbpAsientoContable.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gbpAsientoContable.Controls.Add(Me.dgvAsientoDiario)
            Me.gbpAsientoContable.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbpAsientoContable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.gbpAsientoContable.Location = New System.Drawing.Point(580, 296)
            Me.gbpAsientoContable.Name = "gbpAsientoContable"
            Me.gbpAsientoContable.Size = New System.Drawing.Size(409, 222)
            Me.gbpAsientoContable.TabIndex = 122
            Me.gbpAsientoContable.TabStop = False
            Me.gbpAsientoContable.Text = "Asiento"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(991, 32)
            Me.MenuStrip1.TabIndex = 211
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
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(-1, 34)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialProveedor)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbtSoloCruce)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbComprobanteIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbComprobanteEgreso)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(992, 56)
            Me.KryptonGroupBox1.TabIndex = 212
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(590, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(67, 20)
            Me.KryptonLabel2.TabIndex = 81
            Me.KryptonLabel2.Values.Text = "Proveedor"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(198, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel1.TabIndex = 80
            Me.KryptonLabel1.Values.Text = "Cliente"
            '
            'lblIdComprobanteIngresoBancos
            '
            Me.lblIdComprobanteIngresoBancos.AutoSize = True
            Me.lblIdComprobanteIngresoBancos.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteIngresoBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteIngresoBancos.Location = New System.Drawing.Point(74, 41)
            Me.lblIdComprobanteIngresoBancos.Name = "lblIdComprobanteIngresoBancos"
            Me.lblIdComprobanteIngresoBancos.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteIngresoBancos.TabIndex = 77
            Me.lblIdComprobanteIngresoBancos.Text = "..."
            '
            'lblIdComprobanteEgresoBancos
            '
            Me.lblIdComprobanteEgresoBancos.AutoSize = True
            Me.lblIdComprobanteEgresoBancos.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteEgresoBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteEgresoBancos.Location = New System.Drawing.Point(178, 40)
            Me.lblIdComprobanteEgresoBancos.Name = "lblIdComprobanteEgresoBancos"
            Me.lblIdComprobanteEgresoBancos.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteEgresoBancos.TabIndex = 78
            Me.lblIdComprobanteEgresoBancos.Text = "..."
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(580, 93)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnEditarValores)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtValorHaberAjuste)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnAgregarConceptoComprobante)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtValorDebeAjuste)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtCtaCteCheque)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTitularCheque)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtNumeroCheque)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtBancoCheque)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dtpFechaEmisionCheque)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.cmbCuentaBancos)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dtpFechaEmisionComprobante)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.cmbBancos)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.cmbCuentasContables)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.gbFormaPago)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(411, 198)
            Me.KryptonGroupBox2.TabIndex = 213
            Me.KryptonGroupBox2.Values.Heading = "Datos Contables"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(156, 141)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel13.TabIndex = 121
            Me.KryptonLabel13.Values.Text = "Haber"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(3, 141)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel12.TabIndex = 120
            Me.KryptonLabel12.Values.Text = "Debe"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(219, 114)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel11.TabIndex = 119
            Me.KryptonLabel11.Values.Text = "Cta/Cte"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(3, 115)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel10.TabIndex = 118
            Me.KryptonLabel10.Values.Text = "Banco"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(154, 89)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel9.TabIndex = 117
            Me.KryptonLabel9.Values.Text = "Titular"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(3, 89)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel8.TabIndex = 116
            Me.KryptonLabel8.Values.Text = "Fecha E"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(213, 63)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(72, 20)
            Me.KryptonLabel7.TabIndex = 115
            Me.KryptonLabel7.Values.Text = "No Cheque"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(213, 30)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(66, 20)
            Me.KryptonLabel6.TabIndex = 84
            Me.KryptonLabel6.Values.Text = "CA/CC/TA"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(3, 29)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel5.TabIndex = 83
            Me.KryptonLabel5.Values.Text = "Banco"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(220, 3)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(90, 20)
            Me.KryptonLabel4.TabIndex = 82
            Me.KryptonLabel4.Values.Text = "Fecha Compro"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(3, 6)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel3.TabIndex = 81
            Me.KryptonLabel3.Values.Text = "Cuenta"
            '
            'FormCruzeCuentasEgresoIngreso
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(991, 564)
            Me.Controls.Add(Me.lblCodigoCuentaContable)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.lblIdProveedorGeneral)
            Me.Controls.Add(Me.lblIdClienteGeneral)
            Me.Controls.Add(Me.lblIdComprobanteEgresoBancos)
            Me.Controls.Add(Me.lblIdComprobanteIngresoBancos)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbpAsientoContable)
            Me.Controls.Add(Me.gbTotalDebeTotalHaber)
            Me.Controls.Add(Me.gbFacturasTotalCXP)
            Me.Controls.Add(Me.gbFacturasTotalCXC)
            Me.Controls.Add(Me.gbPagosComprobanteCompra)
            Me.Controls.Add(Me.gbComprobantesCompra)
            Me.Controls.Add(Me.gbPagosFacturaVenta)
            Me.Controls.Add(Me.gbFacturaVenta)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormCruzeCuentasEgresoIngreso"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CRUCE CUENTAS EGRESO INGRESO"
            Me.gbPagosFacturaVenta.ResumeLayout(False)
            CType(Me.dgvPagosFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbFacturaVenta.ResumeLayout(False)
            Me.gbFacturaVenta.PerformLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbPagosComprobanteCompra.ResumeLayout(False)
            CType(Me.dgvPagosComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbComprobantesCompra.ResumeLayout(False)
            Me.gbComprobantesCompra.PerformLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbFacturasTotalCXC.ResumeLayout(False)
            Me.gbFacturasTotalCXC.PerformLayout()
            Me.gbFacturasTotalCXP.ResumeLayout(False)
            Me.gbFacturasTotalCXP.PerformLayout()
            CType(Me.dgvAsientoDiario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbFormaPago.ResumeLayout(False)
            Me.gbFormaPago.PerformLayout()
            Me.gbTotalDebeTotalHaber.ResumeLayout(False)
            Me.gbTotalDebeTotalHaber.PerformLayout()
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
            Me.gbpAsientoContable.ResumeLayout(False)
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
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtNombreComercialClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents gbPagosFacturaVenta As System.Windows.Forms.GroupBox
        Friend WithEvents dgvPagosFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents gbFacturaVenta As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtNombreComercialProveedor As System.Windows.Forms.TextBox
        Friend WithEvents gbPagosComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents dgvPagosComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents gbComprobantesCompra As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents dgvComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents gbFacturasTotalCXC As System.Windows.Forms.GroupBox
        Friend WithEvents gbFacturasTotalCXP As System.Windows.Forms.GroupBox
        Friend WithEvents rbComprobanteIngreso As System.Windows.Forms.RadioButton
        Friend WithEvents rbComprobanteEgreso As System.Windows.Forms.RadioButton
        Friend WithEvents dgvAsientoDiario As System.Windows.Forms.DataGridView
        Friend WithEvents txtNumeroCheque As System.Windows.Forms.TextBox
        Friend WithEvents txtTitularCheque As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaEmisionCheque As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtCtaCteCheque As System.Windows.Forms.TextBox
        Friend WithEvents txtBancoCheque As System.Windows.Forms.TextBox
        Friend WithEvents gbFormaPago As System.Windows.Forms.GroupBox
        Friend WithEvents rbCheque As System.Windows.Forms.RadioButton
        Friend WithEvents rbTransaccion As System.Windows.Forms.RadioButton
        Friend WithEvents rbEfectivo As System.Windows.Forms.RadioButton
        Friend WithEvents rbTarjetaCredido As System.Windows.Forms.RadioButton
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents btnEditarValores As System.Windows.Forms.Button
        Friend WithEvents btnAgregarConceptoComprobante As System.Windows.Forms.Button
        Friend WithEvents lblCodigoCuentaContable As System.Windows.Forms.Label
        Friend WithEvents cmbCuentasContables As System.Windows.Forms.ComboBox
        Friend WithEvents gbTotalDebeTotalHaber As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents dtpFechaEmisionComprobante As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtFacturasAPagar As System.Windows.Forms.TextBox
        Friend WithEvents txtFacturaReceptor As System.Windows.Forms.TextBox
        Friend WithEvents txtValorComprobaneIngreso As System.Windows.Forms.TextBox
        Friend WithEvents txtValorComprobanteEgresoBancos As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtValorDebeAjuste As System.Windows.Forms.TextBox
        Friend WithEvents txtValorHaberAjuste As System.Windows.Forms.TextBox
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ToolStripMenuItemEliminar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CUENTA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CONCEPTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DETALLE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DEBE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents HABER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_CC As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_FV As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents rbtSoloCruce As System.Windows.Forms.RadioButton
        Friend WithEvents gbpAsientoContable As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents lblIdComprobanteIngresoBancos As Label
        Friend WithEvents lblIdComprobanteEgresoBancos As Label
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    End Class
End Namespace