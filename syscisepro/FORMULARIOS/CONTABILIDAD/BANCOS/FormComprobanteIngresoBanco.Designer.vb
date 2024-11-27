Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormComprobanteIngresoBanco
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
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComprobanteIngresoBanco))
            Me.txtNombreComercialClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.dgvPagosFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.dtpFechaEmisionComprobanteIngreso = New System.Windows.Forms.DateTimePicker()
            Me.lblIdComprobanteIngresoBancos = New System.Windows.Forms.Label()
            Me.txtNumeroComprobanteIngreso = New System.Windows.Forms.TextBox()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
            Me.txtActividad = New System.Windows.Forms.TextBox()
            Me.gbAcreditado = New System.Windows.Forms.GroupBox()
            Me.rbAcreditadoBancos = New System.Windows.Forms.RadioButton()
            Me.rbAcreditadoCaja = New System.Windows.Forms.RadioButton()
            Me.rbAcreditadoCruceCtas = New System.Windows.Forms.RadioButton()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.RadioButton9 = New System.Windows.Forms.RadioButton()
            Me.RadioButton10 = New System.Windows.Forms.RadioButton()
            Me.RadioButton11 = New System.Windows.Forms.RadioButton()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.btnAgregarConceptoComprobante = New System.Windows.Forms.Button()
            Me.cmbCuentasContables = New System.Windows.Forms.ComboBox()
            Me.txtFacturasAPagar = New System.Windows.Forms.TextBox()
            Me.txtValorComprobaneIngreso = New System.Windows.Forms.TextBox()
            Me.txtObservacionesComprobanteIngreso = New System.Windows.Forms.TextBox()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.btnEditarValores = New System.Windows.Forms.Button()
            Me.dgvComprobanteIngresoBanco = New System.Windows.Forms.DataGridView()
            Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CONCEPTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DETALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DEBE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.HABER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_CC = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtNumeroCheque = New System.Windows.Forms.TextBox()
            Me.txtTitularCheque = New System.Windows.Forms.TextBox()
            Me.dtpFechaEmisionCheque = New System.Windows.Forms.DateTimePicker()
            Me.txtCtaCteCheque = New System.Windows.Forms.TextBox()
            Me.txtBancoCheque = New System.Windows.Forms.TextBox()
            Me.gbTotalDebeTotalHaber = New System.Windows.Forms.GroupBox()
            Me.lblValorCuentaBanco = New System.Windows.Forms.Label()
            Me.txtTotalHaber = New System.Windows.Forms.TextBox()
            Me.txtTotalDebe = New System.Windows.Forms.TextBox()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.lblCodigoCuentaContable = New System.Windows.Forms.Label()
            Me.ContextMenuStripClicDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ToolStripMenuItemEliminar = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.gbPagosFacturaVenta = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.gbFacturaVenta = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.gbFormaPago = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.rbNotaCredito = New System.Windows.Forms.RadioButton()
            Me.rbCheque = New System.Windows.Forms.RadioButton()
            Me.rbTransaccion = New System.Windows.Forms.RadioButton()
            Me.rbEfectivo = New System.Windows.Forms.RadioButton()
            Me.rbTarjetaCredido = New System.Windows.Forms.RadioButton()
            Me.gbCheque = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvPagosFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbAcreditado.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            CType(Me.dgvComprobanteIngresoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbTotalDebeTotalHaber.SuspendLayout()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.gbPagosFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gbPagosFacturaVenta.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbPagosFacturaVenta.Panel.SuspendLayout()
            Me.gbPagosFacturaVenta.SuspendLayout()
            CType(Me.gbFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gbFacturaVenta.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbFacturaVenta.Panel.SuspendLayout()
            Me.gbFacturaVenta.SuspendLayout()
            CType(Me.gbFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gbFormaPago.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbFormaPago.Panel.SuspendLayout()
            Me.gbFormaPago.SuspendLayout()
            CType(Me.gbCheque, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gbCheque.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbCheque.Panel.SuspendLayout()
            Me.gbCheque.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtNombreComercialClienteGeneral
            '
            Me.txtNombreComercialClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialClienteGeneral.Enabled = False
            Me.txtNombreComercialClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialClienteGeneral.Location = New System.Drawing.Point(349, 14)
            Me.txtNombreComercialClienteGeneral.Name = "txtNombreComercialClienteGeneral"
            Me.txtNombreComercialClienteGeneral.Size = New System.Drawing.Size(380, 21)
            Me.txtNombreComercialClienteGeneral.TabIndex = 2
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdClienteGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(354, -2)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdClienteGeneral.TabIndex = 76
            Me.lblIdClienteGeneral.Text = "..."
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblIdFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdFacturaVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(607, 49)
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
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.dgvFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFacturaVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturaVenta.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(0, 0)
            Me.dgvFacturaVenta.MultiSelect = False
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvFacturaVenta.RowHeadersVisible = False
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvFacturaVenta.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvFacturaVenta.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(297, 286)
            Me.dgvFacturaVenta.TabIndex = 0
            '
            'chk
            '
            Me.chk.HeaderText = "CHK"
            Me.chk.Name = "chk"
            Me.chk.Width = 30
            '
            'dgvPagosFacturaVenta
            '
            Me.dgvPagosFacturaVenta.AllowUserToAddRows = False
            Me.dgvPagosFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvPagosFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvPagosFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvPagosFacturaVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.dgvPagosFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPagosFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvPagosFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPagosFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvPagosFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPagosFacturaVenta.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgvPagosFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvPagosFacturaVenta.Location = New System.Drawing.Point(0, 0)
            Me.dgvPagosFacturaVenta.MultiSelect = False
            Me.dgvPagosFacturaVenta.Name = "dgvPagosFacturaVenta"
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPagosFacturaVenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvPagosFacturaVenta.RowHeadersVisible = False
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvPagosFacturaVenta.RowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvPagosFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPagosFacturaVenta.Size = New System.Drawing.Size(297, 198)
            Me.dgvPagosFacturaVenta.TabIndex = 0
            '
            'dtpFechaEmisionComprobanteIngreso
            '
            Me.dtpFechaEmisionComprobanteIngreso.Enabled = False
            Me.dtpFechaEmisionComprobanteIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionComprobanteIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionComprobanteIngreso.Location = New System.Drawing.Point(201, 14)
            Me.dtpFechaEmisionComprobanteIngreso.Name = "dtpFechaEmisionComprobanteIngreso"
            Me.dtpFechaEmisionComprobanteIngreso.Size = New System.Drawing.Size(83, 21)
            Me.dtpFechaEmisionComprobanteIngreso.TabIndex = 78
            '
            'lblIdComprobanteIngresoBancos
            '
            Me.lblIdComprobanteIngresoBancos.AutoSize = True
            Me.lblIdComprobanteIngresoBancos.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteIngresoBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteIngresoBancos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteIngresoBancos.Location = New System.Drawing.Point(80, 0)
            Me.lblIdComprobanteIngresoBancos.Name = "lblIdComprobanteIngresoBancos"
            Me.lblIdComprobanteIngresoBancos.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteIngresoBancos.TabIndex = 77
            Me.lblIdComprobanteIngresoBancos.Text = "..."
            '
            'txtNumeroComprobanteIngreso
            '
            Me.txtNumeroComprobanteIngreso.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroComprobanteIngreso.Enabled = False
            Me.txtNumeroComprobanteIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroComprobanteIngreso.Location = New System.Drawing.Point(77, 14)
            Me.txtNumeroComprobanteIngreso.Name = "txtNumeroComprobanteIngreso"
            Me.txtNumeroComprobanteIngreso.Size = New System.Drawing.Size(66, 21)
            Me.txtNumeroComprobanteIngreso.TabIndex = 1
            '
            'cmbConcepto
            '
            Me.cmbConcepto.BackColor = System.Drawing.Color.White
            Me.cmbConcepto.DropDownHeight = 150
            Me.cmbConcepto.DropDownWidth = 500
            Me.cmbConcepto.Enabled = False
            Me.cmbConcepto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.IntegralHeight = False
            Me.cmbConcepto.Location = New System.Drawing.Point(296, 47)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(146, 21)
            Me.cmbConcepto.TabIndex = 36
            '
            'cmbCentroCosto
            '
            Me.cmbCentroCosto.BackColor = System.Drawing.Color.White
            Me.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCentroCosto.Enabled = False
            Me.cmbCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCentroCosto.FormattingEnabled = True
            Me.cmbCentroCosto.Location = New System.Drawing.Point(296, 76)
            Me.cmbCentroCosto.Name = "cmbCentroCosto"
            Me.cmbCentroCosto.Size = New System.Drawing.Size(145, 21)
            Me.cmbCentroCosto.TabIndex = 29
            '
            'txtActividad
            '
            Me.txtActividad.BackColor = System.Drawing.Color.White
            Me.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtActividad.Enabled = False
            Me.txtActividad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtActividad.Location = New System.Drawing.Point(77, 42)
            Me.txtActividad.Name = "txtActividad"
            Me.txtActividad.Size = New System.Drawing.Size(66, 21)
            Me.txtActividad.TabIndex = 15
            Me.txtActividad.Text = "1010106"
            '
            'gbAcreditado
            '
            Me.gbAcreditado.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.gbAcreditado.Controls.Add(Me.rbAcreditadoBancos)
            Me.gbAcreditado.Controls.Add(Me.rbAcreditadoCaja)
            Me.gbAcreditado.Controls.Add(Me.rbAcreditadoCruceCtas)
            Me.gbAcreditado.Controls.Add(Me.GroupBox4)
            Me.gbAcreditado.Controls.Add(Me.Label5)
            Me.gbAcreditado.Controls.Add(Me.Label6)
            Me.gbAcreditado.Location = New System.Drawing.Point(77, 69)
            Me.gbAcreditado.Name = "gbAcreditado"
            Me.gbAcreditado.Size = New System.Drawing.Size(107, 59)
            Me.gbAcreditado.TabIndex = 70
            Me.gbAcreditado.TabStop = False
            '
            'rbAcreditadoBancos
            '
            Me.rbAcreditadoBancos.AutoSize = True
            Me.rbAcreditadoBancos.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbAcreditadoBancos.Checked = True
            Me.rbAcreditadoBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbAcreditadoBancos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbAcreditadoBancos.Location = New System.Drawing.Point(6, 8)
            Me.rbAcreditadoBancos.Name = "rbAcreditadoBancos"
            Me.rbAcreditadoBancos.Size = New System.Drawing.Size(62, 17)
            Me.rbAcreditadoBancos.TabIndex = 67
            Me.rbAcreditadoBancos.TabStop = True
            Me.rbAcreditadoBancos.Text = "Bancos"
            Me.rbAcreditadoBancos.UseVisualStyleBackColor = False
            '
            'rbAcreditadoCaja
            '
            Me.rbAcreditadoCaja.AutoSize = True
            Me.rbAcreditadoCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbAcreditadoCaja.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbAcreditadoCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbAcreditadoCaja.Location = New System.Drawing.Point(6, 24)
            Me.rbAcreditadoCaja.Name = "rbAcreditadoCaja"
            Me.rbAcreditadoCaja.Size = New System.Drawing.Size(47, 17)
            Me.rbAcreditadoCaja.TabIndex = 68
            Me.rbAcreditadoCaja.TabStop = True
            Me.rbAcreditadoCaja.Text = "Caja"
            Me.rbAcreditadoCaja.UseVisualStyleBackColor = False
            '
            'rbAcreditadoCruceCtas
            '
            Me.rbAcreditadoCruceCtas.AutoSize = True
            Me.rbAcreditadoCruceCtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbAcreditadoCruceCtas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbAcreditadoCruceCtas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbAcreditadoCruceCtas.Location = New System.Drawing.Point(6, 40)
            Me.rbAcreditadoCruceCtas.Name = "rbAcreditadoCruceCtas"
            Me.rbAcreditadoCruceCtas.Size = New System.Drawing.Size(80, 17)
            Me.rbAcreditadoCruceCtas.TabIndex = 69
            Me.rbAcreditadoCruceCtas.TabStop = True
            Me.rbAcreditadoCruceCtas.Text = "Cruce Ctas"
            Me.rbAcreditadoCruceCtas.UseVisualStyleBackColor = False
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.GroupBox4.Controls.Add(Me.RadioButton9)
            Me.GroupBox4.Controls.Add(Me.RadioButton10)
            Me.GroupBox4.Controls.Add(Me.RadioButton11)
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(107, 59)
            Me.GroupBox4.TabIndex = 70
            Me.GroupBox4.TabStop = False
            '
            'RadioButton9
            '
            Me.RadioButton9.AutoSize = True
            Me.RadioButton9.Checked = True
            Me.RadioButton9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RadioButton9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.RadioButton9.Location = New System.Drawing.Point(6, 8)
            Me.RadioButton9.Name = "RadioButton9"
            Me.RadioButton9.Size = New System.Drawing.Size(62, 17)
            Me.RadioButton9.TabIndex = 67
            Me.RadioButton9.TabStop = True
            Me.RadioButton9.Text = "Bancos"
            Me.RadioButton9.UseVisualStyleBackColor = True
            '
            'RadioButton10
            '
            Me.RadioButton10.AutoSize = True
            Me.RadioButton10.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RadioButton10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.RadioButton10.Location = New System.Drawing.Point(6, 24)
            Me.RadioButton10.Name = "RadioButton10"
            Me.RadioButton10.Size = New System.Drawing.Size(47, 17)
            Me.RadioButton10.TabIndex = 68
            Me.RadioButton10.TabStop = True
            Me.RadioButton10.Text = "Caja"
            Me.RadioButton10.UseVisualStyleBackColor = True
            '
            'RadioButton11
            '
            Me.RadioButton11.AutoSize = True
            Me.RadioButton11.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RadioButton11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.RadioButton11.Location = New System.Drawing.Point(6, 40)
            Me.RadioButton11.Name = "RadioButton11"
            Me.RadioButton11.Size = New System.Drawing.Size(80, 17)
            Me.RadioButton11.TabIndex = 69
            Me.RadioButton11.TabStop = True
            Me.RadioButton11.Text = "Cruce Ctas"
            Me.RadioButton11.UseVisualStyleBackColor = True
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(-3, -69)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(16, 13)
            Me.Label5.TabIndex = 77
            Me.Label5.Text = "..."
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(269, -71)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(16, 13)
            Me.Label6.TabIndex = 76
            Me.Label6.Text = "..."
            '
            'btnAgregarConceptoComprobante
            '
            Me.btnAgregarConceptoComprobante.BackColor = System.Drawing.Color.Transparent
            Me.btnAgregarConceptoComprobante.FlatAppearance.BorderSize = 0
            Me.btnAgregarConceptoComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAgregarConceptoComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarConceptoComprobante.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarConceptoComprobante.Location = New System.Drawing.Point(423, 289)
            Me.btnAgregarConceptoComprobante.Name = "btnAgregarConceptoComprobante"
            Me.btnAgregarConceptoComprobante.Size = New System.Drawing.Size(41, 30)
            Me.btnAgregarConceptoComprobante.TabIndex = 23
            Me.btnAgregarConceptoComprobante.UseVisualStyleBackColor = False
            '
            'cmbCuentasContables
            '
            Me.cmbCuentasContables.BackColor = System.Drawing.Color.White
            Me.cmbCuentasContables.DropDownWidth = 200
            Me.cmbCuentasContables.Enabled = False
            Me.cmbCuentasContables.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentasContables.FormattingEnabled = True
            Me.cmbCuentasContables.Location = New System.Drawing.Point(295, 215)
            Me.cmbCuentasContables.Name = "cmbCuentasContables"
            Me.cmbCuentasContables.Size = New System.Drawing.Size(146, 21)
            Me.cmbCuentasContables.TabIndex = 31
            '
            'txtFacturasAPagar
            '
            Me.txtFacturasAPagar.BackColor = System.Drawing.Color.White
            Me.txtFacturasAPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFacturasAPagar.Enabled = False
            Me.txtFacturasAPagar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFacturasAPagar.Location = New System.Drawing.Point(295, 128)
            Me.txtFacturasAPagar.Multiline = True
            Me.txtFacturasAPagar.Name = "txtFacturasAPagar"
            Me.txtFacturasAPagar.Size = New System.Drawing.Size(205, 58)
            Me.txtFacturasAPagar.TabIndex = 23
            '
            'txtValorComprobaneIngreso
            '
            Me.txtValorComprobaneIngreso.BackColor = System.Drawing.Color.White
            Me.txtValorComprobaneIngreso.Enabled = False
            Me.txtValorComprobaneIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorComprobaneIngreso.Location = New System.Drawing.Point(296, 299)
            Me.txtValorComprobaneIngreso.Name = "txtValorComprobaneIngreso"
            Me.txtValorComprobaneIngreso.Size = New System.Drawing.Size(69, 21)
            Me.txtValorComprobaneIngreso.TabIndex = 0
            Me.txtValorComprobaneIngreso.Text = "0.00"
            Me.txtValorComprobaneIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtObservacionesComprobanteIngreso
            '
            Me.txtObservacionesComprobanteIngreso.BackColor = System.Drawing.Color.White
            Me.txtObservacionesComprobanteIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionesComprobanteIngreso.Enabled = False
            Me.txtObservacionesComprobanteIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacionesComprobanteIngreso.Location = New System.Drawing.Point(296, 324)
            Me.txtObservacionesComprobanteIngreso.Name = "txtObservacionesComprobanteIngreso"
            Me.txtObservacionesComprobanteIngreso.Size = New System.Drawing.Size(198, 21)
            Me.txtObservacionesComprobanteIngreso.TabIndex = 24
            Me.txtObservacionesComprobanteIngreso.Text = "..."
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.Enabled = False
            Me.cmbCuentaBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(296, 270)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(94, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.BackColor = System.Drawing.Color.White
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 180
            Me.cmbBancos.Enabled = False
            Me.cmbBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(296, 242)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(94, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'btnEditarValores
            '
            Me.btnEditarValores.BackColor = System.Drawing.Color.Transparent
            Me.btnEditarValores.FlatAppearance.BorderSize = 0
            Me.btnEditarValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditarValores.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditarValores.Image = Global.syscisepro.My.Resources.Resources.edit_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnEditarValores.Location = New System.Drawing.Point(465, 289)
            Me.btnEditarValores.Name = "btnEditarValores"
            Me.btnEditarValores.Size = New System.Drawing.Size(37, 30)
            Me.btnEditarValores.TabIndex = 33
            Me.btnEditarValores.UseVisualStyleBackColor = False
            '
            'dgvComprobanteIngresoBanco
            '
            Me.dgvComprobanteIngresoBanco.AllowUserToAddRows = False
            Me.dgvComprobanteIngresoBanco.AllowUserToDeleteRows = False
            Me.dgvComprobanteIngresoBanco.AllowUserToResizeRows = False
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobanteIngresoBanco.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvComprobanteIngresoBanco.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvComprobanteIngresoBanco.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobanteIngresoBanco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobanteIngresoBanco.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteIngresoBanco.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvComprobanteIngresoBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteIngresoBanco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.CUENTA, Me.CONCEPTO, Me.DETALLE, Me.DEBE, Me.HABER, Me.ID_CC})
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteIngresoBanco.DefaultCellStyle = DataGridViewCellStyle15
            Me.dgvComprobanteIngresoBanco.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvComprobanteIngresoBanco.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvComprobanteIngresoBanco.Location = New System.Drawing.Point(3, 16)
            Me.dgvComprobanteIngresoBanco.MultiSelect = False
            Me.dgvComprobanteIngresoBanco.Name = "dgvComprobanteIngresoBanco"
            Me.dgvComprobanteIngresoBanco.RowHeadersVisible = False
            Me.dgvComprobanteIngresoBanco.RowHeadersWidth = 25
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobanteIngresoBanco.RowsDefaultCellStyle = DataGridViewCellStyle16
            Me.dgvComprobanteIngresoBanco.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvComprobanteIngresoBanco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteIngresoBanco.Size = New System.Drawing.Size(483, 202)
            Me.dgvComprobanteIngresoBanco.TabIndex = 109
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
            Me.CUENTA.Width = 140
            '
            'CONCEPTO
            '
            Me.CONCEPTO.HeaderText = "CONCEPTO"
            Me.CONCEPTO.Name = "CONCEPTO"
            Me.CONCEPTO.Width = 140
            '
            'DETALLE
            '
            Me.DETALLE.HeaderText = "DETALLE"
            Me.DETALLE.Name = "DETALLE"
            Me.DETALLE.Width = 140
            '
            'DEBE
            '
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DEBE.DefaultCellStyle = DataGridViewCellStyle13
            Me.DEBE.HeaderText = "DEBE"
            Me.DEBE.Name = "DEBE"
            Me.DEBE.Width = 85
            '
            'HABER
            '
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.HABER.DefaultCellStyle = DataGridViewCellStyle14
            Me.HABER.HeaderText = "HABER"
            Me.HABER.Name = "HABER"
            Me.HABER.Width = 85
            '
            'ID_CC
            '
            Me.ID_CC.HeaderText = "ID_CC"
            Me.ID_CC.Name = "ID_CC"
            '
            'txtNumeroCheque
            '
            Me.txtNumeroCheque.BackColor = System.Drawing.Color.White
            Me.txtNumeroCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroCheque.Location = New System.Drawing.Point(70, 112)
            Me.txtNumeroCheque.Name = "txtNumeroCheque"
            Me.txtNumeroCheque.Size = New System.Drawing.Size(106, 21)
            Me.txtNumeroCheque.TabIndex = 43
            '
            'txtTitularCheque
            '
            Me.txtTitularCheque.BackColor = System.Drawing.Color.White
            Me.txtTitularCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTitularCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTitularCheque.Location = New System.Drawing.Point(70, 31)
            Me.txtTitularCheque.Name = "txtTitularCheque"
            Me.txtTitularCheque.Size = New System.Drawing.Size(106, 21)
            Me.txtTitularCheque.TabIndex = 39
            '
            'dtpFechaEmisionCheque
            '
            Me.dtpFechaEmisionCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionCheque.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionCheque.Location = New System.Drawing.Point(70, 4)
            Me.dtpFechaEmisionCheque.Name = "dtpFechaEmisionCheque"
            Me.dtpFechaEmisionCheque.Size = New System.Drawing.Size(106, 21)
            Me.dtpFechaEmisionCheque.TabIndex = 38
            '
            'txtCtaCteCheque
            '
            Me.txtCtaCteCheque.BackColor = System.Drawing.Color.White
            Me.txtCtaCteCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCtaCteCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCtaCteCheque.Location = New System.Drawing.Point(70, 86)
            Me.txtCtaCteCheque.Name = "txtCtaCteCheque"
            Me.txtCtaCteCheque.Size = New System.Drawing.Size(106, 21)
            Me.txtCtaCteCheque.TabIndex = 35
            '
            'txtBancoCheque
            '
            Me.txtBancoCheque.BackColor = System.Drawing.Color.White
            Me.txtBancoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBancoCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBancoCheque.Location = New System.Drawing.Point(70, 58)
            Me.txtBancoCheque.Name = "txtBancoCheque"
            Me.txtBancoCheque.Size = New System.Drawing.Size(106, 21)
            Me.txtBancoCheque.TabIndex = 0
            '
            'gbTotalDebeTotalHaber
            '
            Me.gbTotalDebeTotalHaber.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.lblValorCuentaBanco)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.txtTotalHaber)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.txtTotalDebe)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.lblTotal)
            Me.gbTotalDebeTotalHaber.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotalDebeTotalHaber.Location = New System.Drawing.Point(6, 581)
            Me.gbTotalDebeTotalHaber.Name = "gbTotalDebeTotalHaber"
            Me.gbTotalDebeTotalHaber.Size = New System.Drawing.Size(807, 37)
            Me.gbTotalDebeTotalHaber.TabIndex = 111
            Me.gbTotalDebeTotalHaber.TabStop = False
            '
            'lblValorCuentaBanco
            '
            Me.lblValorCuentaBanco.AutoSize = True
            Me.lblValorCuentaBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblValorCuentaBanco.Location = New System.Drawing.Point(38, 14)
            Me.lblValorCuentaBanco.Name = "lblValorCuentaBanco"
            Me.lblValorCuentaBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblValorCuentaBanco.TabIndex = 38
            Me.lblValorCuentaBanco.Text = "..."
            '
            'txtTotalHaber
            '
            Me.txtTotalHaber.BackColor = System.Drawing.Color.White
            Me.txtTotalHaber.Location = New System.Drawing.Point(506, 10)
            Me.txtTotalHaber.Name = "txtTotalHaber"
            Me.txtTotalHaber.Size = New System.Drawing.Size(73, 21)
            Me.txtTotalHaber.TabIndex = 35
            Me.txtTotalHaber.Text = "0.00"
            Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalDebe
            '
            Me.txtTotalDebe.BackColor = System.Drawing.Color.White
            Me.txtTotalDebe.Location = New System.Drawing.Point(417, 11)
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
            Me.lblTotal.Location = New System.Drawing.Point(315, 14)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(54, 13)
            Me.lblTotal.TabIndex = 34
            Me.lblTotal.Text = "TOTAL :"
            '
            'lblCodigoCuentaContable
            '
            Me.lblCodigoCuentaContable.AutoSize = True
            Me.lblCodigoCuentaContable.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.lblCodigoCuentaContable.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigoCuentaContable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblCodigoCuentaContable.Location = New System.Drawing.Point(293, 190)
            Me.lblCodigoCuentaContable.Name = "lblCodigoCuentaContable"
            Me.lblCodigoCuentaContable.Size = New System.Drawing.Size(16, 13)
            Me.lblCodigoCuentaContable.TabIndex = 37
            Me.lblCodigoCuentaContable.Text = "..."
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
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.GroupBox1.Controls.Add(Me.dgvComprobanteIngresoBanco)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(13, 359)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(489, 221)
            Me.GroupBox1.TabIndex = 114
            Me.GroupBox1.TabStop = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(826, 32)
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
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 33)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.gbPagosFacturaVenta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdFacturaVenta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.gbFacturaVenta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtValorComprobaneIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel18)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnEditarValores)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnAgregarConceptoComprobante)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtObservacionesComprobanteIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.gbFormaPago)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCuentaBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.gbCheque)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.gbTotalDebeTotalHaber)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.Label3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCodigoCuentaContable)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.GroupBox1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCuentasContables)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFacturasAPagar)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbConcepto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdComprobanteIngresoBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.gbAcreditado)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtActividad)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaEmisionComprobanteIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumeroComprobanteIngreso)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(826, 630)
            Me.KryptonGroupBox1.TabIndex = 212
            Me.KryptonGroupBox1.Values.Heading = ""
            '
            'gbPagosFacturaVenta
            '
            Me.gbPagosFacturaVenta.CaptionOverlap = 0R
            Me.gbPagosFacturaVenta.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.gbPagosFacturaVenta.Location = New System.Drawing.Point(515, 362)
            Me.gbPagosFacturaVenta.Name = "gbPagosFacturaVenta"
            '
            'gbPagosFacturaVenta.Panel
            '
            Me.gbPagosFacturaVenta.Panel.Controls.Add(Me.dgvPagosFacturaVenta)
            Me.gbPagosFacturaVenta.Size = New System.Drawing.Size(301, 222)
            Me.gbPagosFacturaVenta.TabIndex = 120
            Me.gbPagosFacturaVenta.Values.Heading = "Pagos Factura"
            '
            'gbFacturaVenta
            '
            Me.gbFacturaVenta.CaptionOverlap = 0R
            Me.gbFacturaVenta.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.gbFacturaVenta.Location = New System.Drawing.Point(515, 46)
            Me.gbFacturaVenta.Name = "gbFacturaVenta"
            '
            'gbFacturaVenta.Panel
            '
            Me.gbFacturaVenta.Panel.Controls.Add(Me.dgvFacturaVenta)
            Me.gbFacturaVenta.Size = New System.Drawing.Size(301, 310)
            Me.gbFacturaVenta.TabIndex = 119
            Me.gbFacturaVenta.Values.Heading = "Factura Venta"
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(201, 298)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel18.TabIndex = 118
            Me.KryptonLabel18.Values.Text = "Valor"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(201, 270)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(64, 20)
            Me.KryptonLabel17.TabIndex = 117
            Me.KryptonLabel17.Values.Text = "CA/CT/TA"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(200, 323)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(90, 20)
            Me.KryptonLabel16.TabIndex = 116
            Me.KryptonLabel16.Values.Text = "Observaciones"
            '
            'gbFormaPago
            '
            Me.gbFormaPago.CaptionOverlap = 0R
            Me.gbFormaPago.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.gbFormaPago.Location = New System.Drawing.Point(11, 134)
            Me.gbFormaPago.Name = "gbFormaPago"
            '
            'gbFormaPago.Panel
            '
            Me.gbFormaPago.Panel.Controls.Add(Me.rbNotaCredito)
            Me.gbFormaPago.Panel.Controls.Add(Me.rbCheque)
            Me.gbFormaPago.Panel.Controls.Add(Me.rbTransaccion)
            Me.gbFormaPago.Panel.Controls.Add(Me.rbEfectivo)
            Me.gbFormaPago.Panel.Controls.Add(Me.rbTarjetaCredido)
            Me.gbFormaPago.Size = New System.Drawing.Size(246, 52)
            Me.gbFormaPago.TabIndex = 115
            Me.gbFormaPago.Values.Heading = "Pago"
            '
            'rbNotaCredito
            '
            Me.rbNotaCredito.AutoSize = True
            Me.rbNotaCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.rbNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNotaCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbNotaCredito.Location = New System.Drawing.Point(195, 3)
            Me.rbNotaCredito.Name = "rbNotaCredito"
            Me.rbNotaCredito.Size = New System.Drawing.Size(39, 17)
            Me.rbNotaCredito.TabIndex = 73
            Me.rbNotaCredito.TabStop = True
            Me.rbNotaCredito.Text = "Nc"
            Me.rbNotaCredito.UseVisualStyleBackColor = False
            '
            'rbCheque
            '
            Me.rbCheque.AutoSize = True
            Me.rbCheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.rbCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCheque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCheque.Location = New System.Drawing.Point(6, 3)
            Me.rbCheque.Name = "rbCheque"
            Me.rbCheque.Size = New System.Drawing.Size(44, 17)
            Me.rbCheque.TabIndex = 69
            Me.rbCheque.TabStop = True
            Me.rbCheque.Text = "Che"
            Me.rbCheque.UseVisualStyleBackColor = False
            '
            'rbTransaccion
            '
            Me.rbTransaccion.AutoSize = True
            Me.rbTransaccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.rbTransaccion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTransaccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTransaccion.Location = New System.Drawing.Point(150, 3)
            Me.rbTransaccion.Name = "rbTransaccion"
            Me.rbTransaccion.Size = New System.Drawing.Size(42, 17)
            Me.rbTransaccion.TabIndex = 72
            Me.rbTransaccion.TabStop = True
            Me.rbTransaccion.Text = "Tra"
            Me.rbTransaccion.UseVisualStyleBackColor = False
            '
            'rbEfectivo
            '
            Me.rbEfectivo.AutoSize = True
            Me.rbEfectivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.rbEfectivo.Checked = True
            Me.rbEfectivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbEfectivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbEfectivo.Location = New System.Drawing.Point(51, 3)
            Me.rbEfectivo.Name = "rbEfectivo"
            Me.rbEfectivo.Size = New System.Drawing.Size(41, 17)
            Me.rbEfectivo.TabIndex = 70
            Me.rbEfectivo.TabStop = True
            Me.rbEfectivo.Text = "Efe"
            Me.rbEfectivo.UseVisualStyleBackColor = False
            '
            'rbTarjetaCredido
            '
            Me.rbTarjetaCredido.AutoSize = True
            Me.rbTarjetaCredido.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.rbTarjetaCredido.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTarjetaCredido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTarjetaCredido.Location = New System.Drawing.Point(97, 3)
            Me.rbTarjetaCredido.Name = "rbTarjetaCredido"
            Me.rbTarjetaCredido.Size = New System.Drawing.Size(44, 17)
            Me.rbTarjetaCredido.TabIndex = 71
            Me.rbTarjetaCredido.TabStop = True
            Me.rbTarjetaCredido.Text = "Tarj"
            Me.rbTarjetaCredido.UseVisualStyleBackColor = False
            '
            'gbCheque
            '
            Me.gbCheque.CaptionOverlap = 0R
            Me.gbCheque.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.gbCheque.Location = New System.Drawing.Point(11, 190)
            Me.gbCheque.Name = "gbCheque"
            '
            'gbCheque.Panel
            '
            Me.gbCheque.Panel.Controls.Add(Me.KryptonLabel15)
            Me.gbCheque.Panel.Controls.Add(Me.txtNumeroCheque)
            Me.gbCheque.Panel.Controls.Add(Me.KryptonLabel14)
            Me.gbCheque.Panel.Controls.Add(Me.KryptonLabel13)
            Me.gbCheque.Panel.Controls.Add(Me.txtTitularCheque)
            Me.gbCheque.Panel.Controls.Add(Me.KryptonLabel12)
            Me.gbCheque.Panel.Controls.Add(Me.dtpFechaEmisionCheque)
            Me.gbCheque.Panel.Controls.Add(Me.KryptonLabel11)
            Me.gbCheque.Panel.Controls.Add(Me.txtBancoCheque)
            Me.gbCheque.Panel.Controls.Add(Me.txtCtaCteCheque)
            Me.gbCheque.Size = New System.Drawing.Size(183, 166)
            Me.gbCheque.TabIndex = 114
            Me.gbCheque.Values.Heading = "Cheque"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(6, 109)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(55, 20)
            Me.KryptonLabel15.TabIndex = 119
            Me.KryptonLabel15.Values.Text = "Numero"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(6, 83)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(29, 20)
            Me.KryptonLabel14.TabIndex = 118
            Me.KryptonLabel14.Values.Text = "Cta"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(3, 57)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel13.TabIndex = 117
            Me.KryptonLabel13.Values.Text = "Banco"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(3, 31)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel12.TabIndex = 116
            Me.KryptonLabel12.Values.Text = "Titular"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(3, 5)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel11.TabIndex = 115
            Me.KryptonLabel11.Values.Text = "Fecha"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(201, 242)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel10.TabIndex = 113
            Me.KryptonLabel10.Values.Text = "Banco"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(201, 216)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(81, 20)
            Me.KryptonLabel9.TabIndex = 112
            Me.KryptonLabel9.Values.Text = "Cta Contable"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(293, 190)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(16, 13)
            Me.Label3.TabIndex = 37
            Me.Label3.Text = "..."
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(296, 102)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel8.TabIndex = 111
            Me.KryptonLabel8.Values.Text = "Facturas"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(201, 76)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(82, 20)
            Me.KryptonLabel7.TabIndex = 83
            Me.KryptonLabel7.Values.Text = "Centro Costo"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(199, 48)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel6.TabIndex = 82
            Me.KryptonLabel6.Values.Text = "Concepto"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(6, 67)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(70, 20)
            Me.KryptonLabel5.TabIndex = 81
            Me.KryptonLabel5.Values.Text = "Acreditado"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(6, 40)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel4.TabIndex = 80
            Me.KryptonLabel4.Values.Text = "Actividad"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(295, 14)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel3.TabIndex = 79
            Me.KryptonLabel3.Values.Text = "Cliente"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(152, 14)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel2.TabIndex = 2
            Me.KryptonLabel2.Values.Text = "Fecha"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(6, 14)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel1.TabIndex = 1
            Me.KryptonLabel1.Values.Text = "Nro"
            '
            'FormComprobanteIngresoBanco
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(826, 665)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormComprobanteIngresoBanco"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "COMPROBANTE DE INGRESO BANCOS"
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvPagosFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbAcreditado.ResumeLayout(False)
            Me.gbAcreditado.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            CType(Me.dgvComprobanteIngresoBanco, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbTotalDebeTotalHaber.ResumeLayout(False)
            Me.gbTotalDebeTotalHaber.PerformLayout()
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.gbPagosFacturaVenta.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbPagosFacturaVenta.Panel.ResumeLayout(False)
            CType(Me.gbPagosFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbPagosFacturaVenta.ResumeLayout(False)
            CType(Me.gbFacturaVenta.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbFacturaVenta.Panel.ResumeLayout(False)
            CType(Me.gbFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbFacturaVenta.ResumeLayout(False)
            CType(Me.gbFormaPago.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbFormaPago.Panel.ResumeLayout(False)
            Me.gbFormaPago.Panel.PerformLayout()
            CType(Me.gbFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbFormaPago.ResumeLayout(False)
            CType(Me.gbCheque.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbCheque.Panel.ResumeLayout(False)
            Me.gbCheque.Panel.PerformLayout()
            CType(Me.gbCheque, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbCheque.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtNombreComercialClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dgvPagosFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents cmbCuentasContables As System.Windows.Forms.ComboBox
        Friend WithEvents btnAgregarConceptoComprobante As System.Windows.Forms.Button
        Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents txtActividad As System.Windows.Forms.TextBox
        Friend WithEvents txtFacturasAPagar As System.Windows.Forms.TextBox
        Friend WithEvents txtValorComprobaneIngreso As System.Windows.Forms.TextBox
        Friend WithEvents txtObservacionesComprobanteIngreso As System.Windows.Forms.TextBox
        Friend WithEvents btnEditarValores As System.Windows.Forms.Button
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents dgvComprobanteIngresoBanco As System.Windows.Forms.DataGridView
        Friend WithEvents txtTitularCheque As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaEmisionCheque As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtCtaCteCheque As System.Windows.Forms.TextBox
        Friend WithEvents txtBancoCheque As System.Windows.Forms.TextBox
        Friend WithEvents gbTotalDebeTotalHaber As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents txtNumeroComprobanteIngreso As System.Windows.Forms.TextBox
        Friend WithEvents lblIdComprobanteIngresoBancos As System.Windows.Forms.Label
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents txtNumeroCheque As System.Windows.Forms.TextBox
        Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CUENTA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CONCEPTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DETALLE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DEBE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents HABER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_CC As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents lblCodigoCuentaContable As System.Windows.Forms.Label
        Friend WithEvents dtpFechaEmisionComprobanteIngreso As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbAcreditado As System.Windows.Forms.GroupBox
        Friend WithEvents rbAcreditadoBancos As System.Windows.Forms.RadioButton
        Friend WithEvents rbAcreditadoCaja As System.Windows.Forms.RadioButton
        Friend WithEvents rbAcreditadoCruceCtas As System.Windows.Forms.RadioButton
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ToolStripMenuItemEliminar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblValorCuentaBanco As System.Windows.Forms.Label
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents gbCheque As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents gbFormaPago As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents rbNotaCredito As RadioButton
        Friend WithEvents rbCheque As RadioButton
        Friend WithEvents rbTransaccion As RadioButton
        Friend WithEvents rbEfectivo As RadioButton
        Friend WithEvents rbTarjetaCredido As RadioButton
        Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents Label3 As Label
        Friend WithEvents GroupBox4 As GroupBox
        Friend WithEvents RadioButton9 As RadioButton
        Friend WithEvents RadioButton10 As RadioButton
        Friend WithEvents RadioButton11 As RadioButton
        Friend WithEvents Label5 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents gbFacturaVenta As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents gbPagosFacturaVenta As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    End Class
End Namespace