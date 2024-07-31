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
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComprobanteIngresoBanco))
            Me.gbClienteGeneral = New System.Windows.Forms.GroupBox()
            Me.txtNombreComercialClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.gbFacturaVenta = New System.Windows.Forms.GroupBox()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.gbPagosFacturaVenta = New System.Windows.Forms.GroupBox()
            Me.dgvPagosFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.gbCabeceraComprobante = New System.Windows.Forms.GroupBox()
            Me.dtpFechaEmisionComprobanteIngreso = New System.Windows.Forms.DateTimePicker()
            Me.lblIdComprobanteIngresoBancos = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtNumeroComprobanteIngreso = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.pCentroCosto = New System.Windows.Forms.Panel()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
            Me.lblCentroCosto = New System.Windows.Forms.Label()
            Me.txtActividad = New System.Windows.Forms.TextBox()
            Me.lblActividad = New System.Windows.Forms.Label()
            Me.lblConcepto = New System.Windows.Forms.Label()
            Me.gbAcreditado = New System.Windows.Forms.GroupBox()
            Me.rbAcreditadoBancos = New System.Windows.Forms.RadioButton()
            Me.rbAcreditadoCaja = New System.Windows.Forms.RadioButton()
            Me.rbAcreditadoCruceCtas = New System.Windows.Forms.RadioButton()
            Me.btnAgregarConceptoComprobante = New System.Windows.Forms.Button()
            Me.cmbCuentasContables = New System.Windows.Forms.ComboBox()
            Me.gbFormaPago = New System.Windows.Forms.GroupBox()
            Me.rbNotaCredito = New System.Windows.Forms.RadioButton()
            Me.rbCheque = New System.Windows.Forms.RadioButton()
            Me.rbTransaccion = New System.Windows.Forms.RadioButton()
            Me.rbEfectivo = New System.Windows.Forms.RadioButton()
            Me.rbTarjetaCredido = New System.Windows.Forms.RadioButton()
            Me.gbFacturasAPagar = New System.Windows.Forms.GroupBox()
            Me.txtFacturasAPagar = New System.Windows.Forms.TextBox()
            Me.gbValorComprobanteIngreso = New System.Windows.Forms.GroupBox()
            Me.txtValorComprobaneIngreso = New System.Windows.Forms.TextBox()
            Me.gbObservaciones = New System.Windows.Forms.GroupBox()
            Me.txtObservacionesComprobanteIngreso = New System.Windows.Forms.TextBox()
            Me.gbBanco = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
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
            Me.gbCheque = New System.Windows.Forms.GroupBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtNumeroCheque = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtTitularCheque = New System.Windows.Forms.TextBox()
            Me.dtpFechaEmisionCheque = New System.Windows.Forms.DateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtCtaCteCheque = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtBancoCheque = New System.Windows.Forms.TextBox()
            Me.gbTotalDebeTotalHaber = New System.Windows.Forms.GroupBox()
            Me.lblValorCuentaBanco = New System.Windows.Forms.Label()
            Me.txtTotalHaber = New System.Windows.Forms.TextBox()
            Me.txtTotalDebe = New System.Windows.Forms.TextBox()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.gbBotonesAgregarEditar = New System.Windows.Forms.GroupBox()
            Me.gbCtaContable = New System.Windows.Forms.GroupBox()
            Me.lblCodigoCuentaContable = New System.Windows.Forms.Label()
            Me.ContextMenuStripClicDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ToolStripMenuItemEliminar = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbClienteGeneral.SuspendLayout()
            Me.gbFacturaVenta.SuspendLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbPagosFacturaVenta.SuspendLayout()
            CType(Me.dgvPagosFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbCabeceraComprobante.SuspendLayout()
            Me.pCentroCosto.SuspendLayout()
            Me.gbAcreditado.SuspendLayout()
            Me.gbFormaPago.SuspendLayout()
            Me.gbFacturasAPagar.SuspendLayout()
            Me.gbValorComprobanteIngreso.SuspendLayout()
            Me.gbObservaciones.SuspendLayout()
            Me.gbBanco.SuspendLayout()
            CType(Me.dgvComprobanteIngresoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbCheque.SuspendLayout()
            Me.gbTotalDebeTotalHaber.SuspendLayout()
            Me.gbBotonesAgregarEditar.SuspendLayout()
            Me.gbCtaContable.SuspendLayout()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbClienteGeneral
            '
            Me.gbClienteGeneral.BackColor = System.Drawing.Color.White
            Me.gbClienteGeneral.Controls.Add(Me.txtNombreComercialClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.lblIdClienteGeneral)
            Me.gbClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbClienteGeneral.Location = New System.Drawing.Point(513, 36)
            Me.gbClienteGeneral.Name = "gbClienteGeneral"
            Me.gbClienteGeneral.Size = New System.Drawing.Size(336, 57)
            Me.gbClienteGeneral.TabIndex = 99
            Me.gbClienteGeneral.TabStop = False
            Me.gbClienteGeneral.Text = "CLIENTE"
            '
            'txtNombreComercialClienteGeneral
            '
            Me.txtNombreComercialClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialClienteGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialClienteGeneral.Location = New System.Drawing.Point(6, 19)
            Me.txtNombreComercialClienteGeneral.Name = "txtNombreComercialClienteGeneral"
            Me.txtNombreComercialClienteGeneral.Size = New System.Drawing.Size(309, 20)
            Me.txtNombreComercialClienteGeneral.TabIndex = 2
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(214, 0)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdClienteGeneral.TabIndex = 76
            Me.lblIdClienteGeneral.Text = "..."
            '
            'gbFacturaVenta
            '
            Me.gbFacturaVenta.BackColor = System.Drawing.Color.White
            Me.gbFacturaVenta.Controls.Add(Me.lblIdFacturaVenta)
            Me.gbFacturaVenta.Controls.Add(Me.dgvFacturaVenta)
            Me.gbFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFacturaVenta.Location = New System.Drawing.Point(538, 95)
            Me.gbFacturaVenta.Name = "gbFacturaVenta"
            Me.gbFacturaVenta.Size = New System.Drawing.Size(333, 310)
            Me.gbFacturaVenta.TabIndex = 100
            Me.gbFacturaVenta.TabStop = False
            Me.gbFacturaVenta.Text = "FACTURAS VENTAS"
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(216, 0)
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
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(3, 17)
            Me.dgvFacturaVenta.MultiSelect = False
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.RowHeadersVisible = False
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(327, 290)
            Me.dgvFacturaVenta.TabIndex = 0
            '
            'chk
            '
            Me.chk.HeaderText = "CHK"
            Me.chk.Name = "chk"
            Me.chk.Width = 30
            '
            'gbPagosFacturaVenta
            '
            Me.gbPagosFacturaVenta.BackColor = System.Drawing.Color.White
            Me.gbPagosFacturaVenta.Controls.Add(Me.dgvPagosFacturaVenta)
            Me.gbPagosFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbPagosFacturaVenta.Location = New System.Drawing.Point(549, 406)
            Me.gbPagosFacturaVenta.Name = "gbPagosFacturaVenta"
            Me.gbPagosFacturaVenta.Size = New System.Drawing.Size(323, 222)
            Me.gbPagosFacturaVenta.TabIndex = 101
            Me.gbPagosFacturaVenta.TabStop = False
            Me.gbPagosFacturaVenta.Text = "PAGOS POR FACTURA"
            '
            'dgvPagosFacturaVenta
            '
            Me.dgvPagosFacturaVenta.AllowUserToAddRows = False
            Me.dgvPagosFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvPagosFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvPagosFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvPagosFacturaVenta.BackgroundColor = System.Drawing.Color.White
            Me.dgvPagosFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPagosFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvPagosFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPagosFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvPagosFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPagosFacturaVenta.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvPagosFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvPagosFacturaVenta.Location = New System.Drawing.Point(3, 17)
            Me.dgvPagosFacturaVenta.MultiSelect = False
            Me.dgvPagosFacturaVenta.Name = "dgvPagosFacturaVenta"
            Me.dgvPagosFacturaVenta.RowHeadersVisible = False
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvPagosFacturaVenta.RowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvPagosFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPagosFacturaVenta.Size = New System.Drawing.Size(317, 202)
            Me.dgvPagosFacturaVenta.TabIndex = 0
            '
            'gbCabeceraComprobante
            '
            Me.gbCabeceraComprobante.BackColor = System.Drawing.Color.White
            Me.gbCabeceraComprobante.Controls.Add(Me.dtpFechaEmisionComprobanteIngreso)
            Me.gbCabeceraComprobante.Controls.Add(Me.lblIdComprobanteIngresoBancos)
            Me.gbCabeceraComprobante.Controls.Add(Me.Label7)
            Me.gbCabeceraComprobante.Controls.Add(Me.txtNumeroComprobanteIngreso)
            Me.gbCabeceraComprobante.Controls.Add(Me.Label6)
            Me.gbCabeceraComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbCabeceraComprobante.Location = New System.Drawing.Point(1, 36)
            Me.gbCabeceraComprobante.Name = "gbCabeceraComprobante"
            Me.gbCabeceraComprobante.Size = New System.Drawing.Size(507, 58)
            Me.gbCabeceraComprobante.TabIndex = 102
            Me.gbCabeceraComprobante.TabStop = False
            '
            'dtpFechaEmisionComprobanteIngreso
            '
            Me.dtpFechaEmisionComprobanteIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionComprobanteIngreso.Location = New System.Drawing.Point(225, 19)
            Me.dtpFechaEmisionComprobanteIngreso.Name = "dtpFechaEmisionComprobanteIngreso"
            Me.dtpFechaEmisionComprobanteIngreso.Size = New System.Drawing.Size(138, 21)
            Me.dtpFechaEmisionComprobanteIngreso.TabIndex = 78
            '
            'lblIdComprobanteIngresoBancos
            '
            Me.lblIdComprobanteIngresoBancos.AutoSize = True
            Me.lblIdComprobanteIngresoBancos.Location = New System.Drawing.Point(133, 0)
            Me.lblIdComprobanteIngresoBancos.Name = "lblIdComprobanteIngresoBancos"
            Me.lblIdComprobanteIngresoBancos.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteIngresoBancos.TabIndex = 77
            Me.lblIdComprobanteIngresoBancos.Text = "..."
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(176, 21)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(44, 13)
            Me.Label7.TabIndex = 2
            Me.Label7.Text = "FECHA:"
            '
            'txtNumeroComprobanteIngreso
            '
            Me.txtNumeroComprobanteIngreso.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroComprobanteIngreso.Location = New System.Drawing.Point(66, 19)
            Me.txtNumeroComprobanteIngreso.Name = "txtNumeroComprobanteIngreso"
            Me.txtNumeroComprobanteIngreso.Size = New System.Drawing.Size(100, 21)
            Me.txtNumeroComprobanteIngreso.TabIndex = 1
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(11, 22)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(56, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "NUMERO:"
            '
            'pCentroCosto
            '
            Me.pCentroCosto.Controls.Add(Me.cmbConcepto)
            Me.pCentroCosto.Controls.Add(Me.Label5)
            Me.pCentroCosto.Controls.Add(Me.cmbCentroCosto)
            Me.pCentroCosto.Controls.Add(Me.lblCentroCosto)
            Me.pCentroCosto.Controls.Add(Me.txtActividad)
            Me.pCentroCosto.Controls.Add(Me.lblActividad)
            Me.pCentroCosto.Controls.Add(Me.lblConcepto)
            Me.pCentroCosto.Controls.Add(Me.gbAcreditado)
            Me.pCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pCentroCosto.Location = New System.Drawing.Point(1, 98)
            Me.pCentroCosto.Name = "pCentroCosto"
            Me.pCentroCosto.Size = New System.Drawing.Size(507, 85)
            Me.pCentroCosto.TabIndex = 103
            '
            'cmbConcepto
            '
            Me.cmbConcepto.BackColor = System.Drawing.Color.White
            Me.cmbConcepto.DropDownHeight = 150
            Me.cmbConcepto.DropDownWidth = 500
            Me.cmbConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbConcepto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.IntegralHeight = False
            Me.cmbConcepto.Location = New System.Drawing.Point(327, 9)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(146, 21)
            Me.cmbConcepto.TabIndex = 36
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(2, 40)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(86, 13)
            Me.Label5.TabIndex = 32
            Me.Label5.Text = "ACREDITADO A:"
            '
            'cmbCentroCosto
            '
            Me.cmbCentroCosto.BackColor = System.Drawing.Color.White
            Me.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCentroCosto.FormattingEnabled = True
            Me.cmbCentroCosto.Location = New System.Drawing.Point(328, 41)
            Me.cmbCentroCosto.Name = "cmbCentroCosto"
            Me.cmbCentroCosto.Size = New System.Drawing.Size(145, 21)
            Me.cmbCentroCosto.TabIndex = 29
            '
            'lblCentroCosto
            '
            Me.lblCentroCosto.AutoSize = True
            Me.lblCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCentroCosto.Location = New System.Drawing.Point(234, 44)
            Me.lblCentroCosto.Name = "lblCentroCosto"
            Me.lblCentroCosto.Size = New System.Drawing.Size(93, 13)
            Me.lblCentroCosto.TabIndex = 28
            Me.lblCentroCosto.Text = "CENTRO COSTO:"
            '
            'txtActividad
            '
            Me.txtActividad.BackColor = System.Drawing.Color.White
            Me.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtActividad.Enabled = False
            Me.txtActividad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtActividad.Location = New System.Drawing.Point(87, 4)
            Me.txtActividad.Name = "txtActividad"
            Me.txtActividad.Size = New System.Drawing.Size(132, 21)
            Me.txtActividad.TabIndex = 15
            Me.txtActividad.Text = "1010106"
            '
            'lblActividad
            '
            Me.lblActividad.AutoSize = True
            Me.lblActividad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblActividad.Location = New System.Drawing.Point(2, 9)
            Me.lblActividad.Name = "lblActividad"
            Me.lblActividad.Size = New System.Drawing.Size(68, 13)
            Me.lblActividad.TabIndex = 5
            Me.lblActividad.Text = "ACTIVIDAD :"
            '
            'lblConcepto
            '
            Me.lblConcepto.AutoSize = True
            Me.lblConcepto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblConcepto.Location = New System.Drawing.Point(234, 13)
            Me.lblConcepto.Name = "lblConcepto"
            Me.lblConcepto.Size = New System.Drawing.Size(68, 13)
            Me.lblConcepto.TabIndex = 6
            Me.lblConcepto.Text = "CONCEPTO:"
            '
            'gbAcreditado
            '
            Me.gbAcreditado.Controls.Add(Me.rbAcreditadoBancos)
            Me.gbAcreditado.Controls.Add(Me.rbAcreditadoCaja)
            Me.gbAcreditado.Controls.Add(Me.rbAcreditadoCruceCtas)
            Me.gbAcreditado.Location = New System.Drawing.Point(87, 20)
            Me.gbAcreditado.Name = "gbAcreditado"
            Me.gbAcreditado.Size = New System.Drawing.Size(132, 59)
            Me.gbAcreditado.TabIndex = 70
            Me.gbAcreditado.TabStop = False
            '
            'rbAcreditadoBancos
            '
            Me.rbAcreditadoBancos.AutoSize = True
            Me.rbAcreditadoBancos.Checked = True
            Me.rbAcreditadoBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbAcreditadoBancos.Location = New System.Drawing.Point(6, 8)
            Me.rbAcreditadoBancos.Name = "rbAcreditadoBancos"
            Me.rbAcreditadoBancos.Size = New System.Drawing.Size(62, 17)
            Me.rbAcreditadoBancos.TabIndex = 67
            Me.rbAcreditadoBancos.TabStop = True
            Me.rbAcreditadoBancos.Text = "Bancos"
            Me.rbAcreditadoBancos.UseVisualStyleBackColor = True
            '
            'rbAcreditadoCaja
            '
            Me.rbAcreditadoCaja.AutoSize = True
            Me.rbAcreditadoCaja.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbAcreditadoCaja.Location = New System.Drawing.Point(6, 24)
            Me.rbAcreditadoCaja.Name = "rbAcreditadoCaja"
            Me.rbAcreditadoCaja.Size = New System.Drawing.Size(47, 17)
            Me.rbAcreditadoCaja.TabIndex = 68
            Me.rbAcreditadoCaja.TabStop = True
            Me.rbAcreditadoCaja.Text = "Caja"
            Me.rbAcreditadoCaja.UseVisualStyleBackColor = True
            '
            'rbAcreditadoCruceCtas
            '
            Me.rbAcreditadoCruceCtas.AutoSize = True
            Me.rbAcreditadoCruceCtas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbAcreditadoCruceCtas.Location = New System.Drawing.Point(6, 40)
            Me.rbAcreditadoCruceCtas.Name = "rbAcreditadoCruceCtas"
            Me.rbAcreditadoCruceCtas.Size = New System.Drawing.Size(80, 17)
            Me.rbAcreditadoCruceCtas.TabIndex = 69
            Me.rbAcreditadoCruceCtas.TabStop = True
            Me.rbAcreditadoCruceCtas.Text = "Cruce Ctas"
            Me.rbAcreditadoCruceCtas.UseVisualStyleBackColor = True
            '
            'btnAgregarConceptoComprobante
            '
            Me.btnAgregarConceptoComprobante.BackColor = System.Drawing.Color.White
            Me.btnAgregarConceptoComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarConceptoComprobante.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarConceptoComprobante.Location = New System.Drawing.Point(4, 11)
            Me.btnAgregarConceptoComprobante.Name = "btnAgregarConceptoComprobante"
            Me.btnAgregarConceptoComprobante.Size = New System.Drawing.Size(41, 30)
            Me.btnAgregarConceptoComprobante.TabIndex = 23
            Me.btnAgregarConceptoComprobante.UseVisualStyleBackColor = False
            '
            'cmbCuentasContables
            '
            Me.cmbCuentasContables.BackColor = System.Drawing.Color.White
            Me.cmbCuentasContables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentasContables.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentasContables.FormattingEnabled = True
            Me.cmbCuentasContables.Location = New System.Drawing.Point(6, 15)
            Me.cmbCuentasContables.Name = "cmbCuentasContables"
            Me.cmbCuentasContables.Size = New System.Drawing.Size(212, 21)
            Me.cmbCuentasContables.TabIndex = 31
            '
            'gbFormaPago
            '
            Me.gbFormaPago.BackColor = System.Drawing.Color.White
            Me.gbFormaPago.Controls.Add(Me.rbNotaCredito)
            Me.gbFormaPago.Controls.Add(Me.rbCheque)
            Me.gbFormaPago.Controls.Add(Me.rbTransaccion)
            Me.gbFormaPago.Controls.Add(Me.rbEfectivo)
            Me.gbFormaPago.Controls.Add(Me.rbTarjetaCredido)
            Me.gbFormaPago.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFormaPago.Location = New System.Drawing.Point(1, 185)
            Me.gbFormaPago.Name = "gbFormaPago"
            Me.gbFormaPago.Size = New System.Drawing.Size(243, 45)
            Me.gbFormaPago.TabIndex = 104
            Me.gbFormaPago.TabStop = False
            Me.gbFormaPago.Text = "FORMA PAGO:"
            '
            'rbNotaCredito
            '
            Me.rbNotaCredito.AutoSize = True
            Me.rbNotaCredito.Location = New System.Drawing.Point(201, 19)
            Me.rbNotaCredito.Name = "rbNotaCredito"
            Me.rbNotaCredito.Size = New System.Drawing.Size(39, 17)
            Me.rbNotaCredito.TabIndex = 68
            Me.rbNotaCredito.TabStop = True
            Me.rbNotaCredito.Text = "Nc"
            Me.rbNotaCredito.UseVisualStyleBackColor = True
            '
            'rbCheque
            '
            Me.rbCheque.AutoSize = True
            Me.rbCheque.Location = New System.Drawing.Point(12, 19)
            Me.rbCheque.Name = "rbCheque"
            Me.rbCheque.Size = New System.Drawing.Size(44, 17)
            Me.rbCheque.TabIndex = 64
            Me.rbCheque.TabStop = True
            Me.rbCheque.Text = "Che"
            Me.rbCheque.UseVisualStyleBackColor = True
            '
            'rbTransaccion
            '
            Me.rbTransaccion.AutoSize = True
            Me.rbTransaccion.Location = New System.Drawing.Point(156, 19)
            Me.rbTransaccion.Name = "rbTransaccion"
            Me.rbTransaccion.Size = New System.Drawing.Size(42, 17)
            Me.rbTransaccion.TabIndex = 67
            Me.rbTransaccion.TabStop = True
            Me.rbTransaccion.Text = "Tra"
            Me.rbTransaccion.UseVisualStyleBackColor = True
            '
            'rbEfectivo
            '
            Me.rbEfectivo.AutoSize = True
            Me.rbEfectivo.Checked = True
            Me.rbEfectivo.Location = New System.Drawing.Point(57, 19)
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
            Me.rbTarjetaCredido.Location = New System.Drawing.Point(103, 19)
            Me.rbTarjetaCredido.Name = "rbTarjetaCredido"
            Me.rbTarjetaCredido.Size = New System.Drawing.Size(44, 17)
            Me.rbTarjetaCredido.TabIndex = 66
            Me.rbTarjetaCredido.TabStop = True
            Me.rbTarjetaCredido.Text = "Tarj"
            Me.rbTarjetaCredido.UseVisualStyleBackColor = True
            '
            'gbFacturasAPagar
            '
            Me.gbFacturasAPagar.BackColor = System.Drawing.Color.White
            Me.gbFacturasAPagar.Controls.Add(Me.txtFacturasAPagar)
            Me.gbFacturasAPagar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFacturasAPagar.Location = New System.Drawing.Point(250, 185)
            Me.gbFacturasAPagar.Name = "gbFacturasAPagar"
            Me.gbFacturasAPagar.Size = New System.Drawing.Size(258, 80)
            Me.gbFacturasAPagar.TabIndex = 105
            Me.gbFacturasAPagar.TabStop = False
            Me.gbFacturasAPagar.Text = "FACTURAS"
            '
            'txtFacturasAPagar
            '
            Me.txtFacturasAPagar.BackColor = System.Drawing.Color.White
            Me.txtFacturasAPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFacturasAPagar.Location = New System.Drawing.Point(9, 16)
            Me.txtFacturasAPagar.Multiline = True
            Me.txtFacturasAPagar.Name = "txtFacturasAPagar"
            Me.txtFacturasAPagar.Size = New System.Drawing.Size(230, 58)
            Me.txtFacturasAPagar.TabIndex = 23
            '
            'gbValorComprobanteIngreso
            '
            Me.gbValorComprobanteIngreso.BackColor = System.Drawing.Color.White
            Me.gbValorComprobanteIngreso.Controls.Add(Me.txtValorComprobaneIngreso)
            Me.gbValorComprobanteIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbValorComprobanteIngreso.Location = New System.Drawing.Point(442, 310)
            Me.gbValorComprobanteIngreso.Name = "gbValorComprobanteIngreso"
            Me.gbValorComprobanteIngreso.Size = New System.Drawing.Size(89, 47)
            Me.gbValorComprobanteIngreso.TabIndex = 106
            Me.gbValorComprobanteIngreso.TabStop = False
            Me.gbValorComprobanteIngreso.Text = "VALOR:"
            '
            'txtValorComprobaneIngreso
            '
            Me.txtValorComprobaneIngreso.BackColor = System.Drawing.Color.White
            Me.txtValorComprobaneIngreso.Location = New System.Drawing.Point(10, 18)
            Me.txtValorComprobaneIngreso.Name = "txtValorComprobaneIngreso"
            Me.txtValorComprobaneIngreso.Size = New System.Drawing.Size(69, 21)
            Me.txtValorComprobaneIngreso.TabIndex = 0
            Me.txtValorComprobaneIngreso.Text = "0.00"
            Me.txtValorComprobaneIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'gbObservaciones
            '
            Me.gbObservaciones.BackColor = System.Drawing.Color.White
            Me.gbObservaciones.Controls.Add(Me.txtObservacionesComprobanteIngreso)
            Me.gbObservaciones.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbObservaciones.Location = New System.Drawing.Point(211, 357)
            Me.gbObservaciones.Name = "gbObservaciones"
            Me.gbObservaciones.Size = New System.Drawing.Size(219, 47)
            Me.gbObservaciones.TabIndex = 107
            Me.gbObservaciones.TabStop = False
            Me.gbObservaciones.Text = "OBSERVACIONES"
            '
            'txtObservacionesComprobanteIngreso
            '
            Me.txtObservacionesComprobanteIngreso.BackColor = System.Drawing.Color.White
            Me.txtObservacionesComprobanteIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionesComprobanteIngreso.Location = New System.Drawing.Point(6, 18)
            Me.txtObservacionesComprobanteIngreso.Name = "txtObservacionesComprobanteIngreso"
            Me.txtObservacionesComprobanteIngreso.Size = New System.Drawing.Size(198, 21)
            Me.txtObservacionesComprobanteIngreso.TabIndex = 24
            Me.txtObservacionesComprobanteIngreso.Text = "..."
            '
            'gbBanco
            '
            Me.gbBanco.BackColor = System.Drawing.Color.White
            Me.gbBanco.Controls.Add(Me.Label10)
            Me.gbBanco.Controls.Add(Me.cmbCuentaBancos)
            Me.gbBanco.Controls.Add(Me.cmbBancos)
            Me.gbBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBanco.Location = New System.Drawing.Point(211, 310)
            Me.gbBanco.Name = "gbBanco"
            Me.gbBanco.Size = New System.Drawing.Size(227, 47)
            Me.gbBanco.TabIndex = 108
            Me.gbBanco.TabStop = False
            Me.gbBanco.Text = "BANCO: "
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(126, 0)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(62, 13)
            Me.Label10.TabIndex = 34
            Me.Label10.Text = "CA/CC/TA:"
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(125, 18)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(94, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.BackColor = System.Drawing.Color.White
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(9, 18)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(107, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'btnEditarValores
            '
            Me.btnEditarValores.BackColor = System.Drawing.Color.White
            Me.btnEditarValores.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditarValores.Image = Global.syscisepro.My.Resources.Resources.edit_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnEditarValores.Location = New System.Drawing.Point(48, 11)
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
            DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobanteIngresoBanco.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvComprobanteIngresoBanco.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobanteIngresoBanco.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobanteIngresoBanco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobanteIngresoBanco.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteIngresoBanco.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvComprobanteIngresoBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteIngresoBanco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.CUENTA, Me.CONCEPTO, Me.DETALLE, Me.DEBE, Me.HABER, Me.ID_CC})
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteIngresoBanco.DefaultCellStyle = DataGridViewCellStyle12
            Me.dgvComprobanteIngresoBanco.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvComprobanteIngresoBanco.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvComprobanteIngresoBanco.Location = New System.Drawing.Point(3, 16)
            Me.dgvComprobanteIngresoBanco.MultiSelect = False
            Me.dgvComprobanteIngresoBanco.Name = "dgvComprobanteIngresoBanco"
            Me.dgvComprobanteIngresoBanco.RowHeadersVisible = False
            Me.dgvComprobanteIngresoBanco.RowHeadersWidth = 25
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobanteIngresoBanco.RowsDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvComprobanteIngresoBanco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteIngresoBanco.Size = New System.Drawing.Size(537, 210)
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
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DEBE.DefaultCellStyle = DataGridViewCellStyle10
            Me.DEBE.HeaderText = "DEBE"
            Me.DEBE.Name = "DEBE"
            Me.DEBE.Width = 85
            '
            'HABER
            '
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.HABER.DefaultCellStyle = DataGridViewCellStyle11
            Me.HABER.HeaderText = "HABER"
            Me.HABER.Name = "HABER"
            Me.HABER.Width = 85
            '
            'ID_CC
            '
            Me.ID_CC.HeaderText = "ID_CC"
            Me.ID_CC.Name = "ID_CC"
            '
            'gbCheque
            '
            Me.gbCheque.BackColor = System.Drawing.Color.White
            Me.gbCheque.Controls.Add(Me.Label9)
            Me.gbCheque.Controls.Add(Me.txtNumeroCheque)
            Me.gbCheque.Controls.Add(Me.Label4)
            Me.gbCheque.Controls.Add(Me.txtTitularCheque)
            Me.gbCheque.Controls.Add(Me.dtpFechaEmisionCheque)
            Me.gbCheque.Controls.Add(Me.Label3)
            Me.gbCheque.Controls.Add(Me.Label2)
            Me.gbCheque.Controls.Add(Me.txtCtaCteCheque)
            Me.gbCheque.Controls.Add(Me.Label1)
            Me.gbCheque.Controls.Add(Me.txtBancoCheque)
            Me.gbCheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbCheque.Location = New System.Drawing.Point(1, 230)
            Me.gbCheque.Name = "gbCheque"
            Me.gbCheque.Size = New System.Drawing.Size(205, 174)
            Me.gbCheque.TabIndex = 110
            Me.gbCheque.TabStop = False
            Me.gbCheque.Text = "CHEQUE"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(8, 151)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(56, 13)
            Me.Label9.TabIndex = 44
            Me.Label9.Text = "NÚMERO:"
            '
            'txtNumeroCheque
            '
            Me.txtNumeroCheque.BackColor = System.Drawing.Color.White
            Me.txtNumeroCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroCheque.Location = New System.Drawing.Point(69, 148)
            Me.txtNumeroCheque.Name = "txtNumeroCheque"
            Me.txtNumeroCheque.Size = New System.Drawing.Size(129, 21)
            Me.txtNumeroCheque.TabIndex = 43
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(8, 55)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(54, 13)
            Me.Label4.TabIndex = 40
            Me.Label4.Text = "TITULAR:"
            '
            'txtTitularCheque
            '
            Me.txtTitularCheque.BackColor = System.Drawing.Color.White
            Me.txtTitularCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTitularCheque.Location = New System.Drawing.Point(69, 52)
            Me.txtTitularCheque.Name = "txtTitularCheque"
            Me.txtTitularCheque.Size = New System.Drawing.Size(129, 21)
            Me.txtTitularCheque.TabIndex = 39
            '
            'dtpFechaEmisionCheque
            '
            Me.dtpFechaEmisionCheque.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionCheque.Location = New System.Drawing.Point(69, 20)
            Me.dtpFechaEmisionCheque.Name = "dtpFechaEmisionCheque"
            Me.dtpFechaEmisionCheque.Size = New System.Drawing.Size(129, 21)
            Me.dtpFechaEmisionCheque.TabIndex = 38
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(8, 23)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(56, 13)
            Me.Label3.TabIndex = 37
            Me.Label3.Text = "FECHA E.:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(8, 119)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(54, 13)
            Me.Label2.TabIndex = 36
            Me.Label2.Text = "CTA-CTE:"
            '
            'txtCtaCteCheque
            '
            Me.txtCtaCteCheque.BackColor = System.Drawing.Color.White
            Me.txtCtaCteCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCtaCteCheque.Location = New System.Drawing.Point(69, 116)
            Me.txtCtaCteCheque.Name = "txtCtaCteCheque"
            Me.txtCtaCteCheque.Size = New System.Drawing.Size(129, 21)
            Me.txtCtaCteCheque.TabIndex = 35
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(8, 87)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(47, 13)
            Me.Label1.TabIndex = 34
            Me.Label1.Text = "BANCO:"
            '
            'txtBancoCheque
            '
            Me.txtBancoCheque.BackColor = System.Drawing.Color.White
            Me.txtBancoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBancoCheque.Location = New System.Drawing.Point(69, 84)
            Me.txtBancoCheque.Name = "txtBancoCheque"
            Me.txtBancoCheque.Size = New System.Drawing.Size(129, 21)
            Me.txtBancoCheque.TabIndex = 0
            '
            'gbTotalDebeTotalHaber
            '
            Me.gbTotalDebeTotalHaber.BackColor = System.Drawing.Color.White
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.lblValorCuentaBanco)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.txtTotalHaber)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.txtTotalDebe)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.lblTotal)
            Me.gbTotalDebeTotalHaber.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotalDebeTotalHaber.Location = New System.Drawing.Point(7, 626)
            Me.gbTotalDebeTotalHaber.Name = "gbTotalDebeTotalHaber"
            Me.gbTotalDebeTotalHaber.Size = New System.Drawing.Size(865, 37)
            Me.gbTotalDebeTotalHaber.TabIndex = 111
            Me.gbTotalDebeTotalHaber.TabStop = False
            '
            'lblValorCuentaBanco
            '
            Me.lblValorCuentaBanco.AutoSize = True
            Me.lblValorCuentaBanco.Location = New System.Drawing.Point(38, 14)
            Me.lblValorCuentaBanco.Name = "lblValorCuentaBanco"
            Me.lblValorCuentaBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblValorCuentaBanco.TabIndex = 38
            Me.lblValorCuentaBanco.Text = "..."
            '
            'txtTotalHaber
            '
            Me.txtTotalHaber.BackColor = System.Drawing.Color.White
            Me.txtTotalHaber.Location = New System.Drawing.Point(444, 11)
            Me.txtTotalHaber.Name = "txtTotalHaber"
            Me.txtTotalHaber.Size = New System.Drawing.Size(73, 21)
            Me.txtTotalHaber.TabIndex = 35
            Me.txtTotalHaber.Text = "0.00"
            Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalDebe
            '
            Me.txtTotalDebe.BackColor = System.Drawing.Color.White
            Me.txtTotalDebe.Location = New System.Drawing.Point(370, 11)
            Me.txtTotalDebe.Name = "txtTotalDebe"
            Me.txtTotalDebe.Size = New System.Drawing.Size(73, 21)
            Me.txtTotalDebe.TabIndex = 36
            Me.txtTotalDebe.Text = "0.00"
            Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Location = New System.Drawing.Point(315, 14)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(48, 13)
            Me.lblTotal.TabIndex = 34
            Me.lblTotal.Text = "TOTAL :"
            '
            'gbBotonesAgregarEditar
            '
            Me.gbBotonesAgregarEditar.BackColor = System.Drawing.Color.White
            Me.gbBotonesAgregarEditar.Controls.Add(Me.btnEditarValores)
            Me.gbBotonesAgregarEditar.Controls.Add(Me.btnAgregarConceptoComprobante)
            Me.gbBotonesAgregarEditar.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBotonesAgregarEditar.Location = New System.Drawing.Point(436, 358)
            Me.gbBotonesAgregarEditar.Name = "gbBotonesAgregarEditar"
            Me.gbBotonesAgregarEditar.Size = New System.Drawing.Size(95, 47)
            Me.gbBotonesAgregarEditar.TabIndex = 112
            Me.gbBotonesAgregarEditar.TabStop = False
            '
            'gbCtaContable
            '
            Me.gbCtaContable.BackColor = System.Drawing.Color.White
            Me.gbCtaContable.Controls.Add(Me.lblCodigoCuentaContable)
            Me.gbCtaContable.Controls.Add(Me.cmbCuentasContables)
            Me.gbCtaContable.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbCtaContable.Location = New System.Drawing.Point(212, 267)
            Me.gbCtaContable.Name = "gbCtaContable"
            Me.gbCtaContable.Size = New System.Drawing.Size(232, 43)
            Me.gbCtaContable.TabIndex = 113
            Me.gbCtaContable.TabStop = False
            Me.gbCtaContable.Text = "CUENTA CONTABLE:"
            '
            'lblCodigoCuentaContable
            '
            Me.lblCodigoCuentaContable.AutoSize = True
            Me.lblCodigoCuentaContable.Location = New System.Drawing.Point(119, 0)
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
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.dgvComprobanteIngresoBanco)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(1, 404)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(543, 229)
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
            Me.MenuStrip1.Size = New System.Drawing.Size(876, 32)
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
            'FormComprobanteIngresoBanco
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(876, 665)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbCtaContable)
            Me.Controls.Add(Me.gbBotonesAgregarEditar)
            Me.Controls.Add(Me.gbCheque)
            Me.Controls.Add(Me.gbObservaciones)
            Me.Controls.Add(Me.gbBanco)
            Me.Controls.Add(Me.gbValorComprobanteIngreso)
            Me.Controls.Add(Me.gbFacturasAPagar)
            Me.Controls.Add(Me.gbFormaPago)
            Me.Controls.Add(Me.pCentroCosto)
            Me.Controls.Add(Me.gbCabeceraComprobante)
            Me.Controls.Add(Me.gbPagosFacturaVenta)
            Me.Controls.Add(Me.gbFacturaVenta)
            Me.Controls.Add(Me.gbClienteGeneral)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbTotalDebeTotalHaber)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormComprobanteIngresoBanco"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "COMPROBANTE DE INGRESO BANCOS"
            Me.gbClienteGeneral.ResumeLayout(False)
            Me.gbClienteGeneral.PerformLayout()
            Me.gbFacturaVenta.ResumeLayout(False)
            Me.gbFacturaVenta.PerformLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbPagosFacturaVenta.ResumeLayout(False)
            CType(Me.dgvPagosFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbCabeceraComprobante.ResumeLayout(False)
            Me.gbCabeceraComprobante.PerformLayout()
            Me.pCentroCosto.ResumeLayout(False)
            Me.pCentroCosto.PerformLayout()
            Me.gbAcreditado.ResumeLayout(False)
            Me.gbAcreditado.PerformLayout()
            Me.gbFormaPago.ResumeLayout(False)
            Me.gbFormaPago.PerformLayout()
            Me.gbFacturasAPagar.ResumeLayout(False)
            Me.gbFacturasAPagar.PerformLayout()
            Me.gbValorComprobanteIngreso.ResumeLayout(False)
            Me.gbValorComprobanteIngreso.PerformLayout()
            Me.gbObservaciones.ResumeLayout(False)
            Me.gbObservaciones.PerformLayout()
            Me.gbBanco.ResumeLayout(False)
            Me.gbBanco.PerformLayout()
            CType(Me.dgvComprobanteIngresoBanco, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbCheque.ResumeLayout(False)
            Me.gbCheque.PerformLayout()
            Me.gbTotalDebeTotalHaber.ResumeLayout(False)
            Me.gbTotalDebeTotalHaber.PerformLayout()
            Me.gbBotonesAgregarEditar.ResumeLayout(False)
            Me.gbCtaContable.ResumeLayout(False)
            Me.gbCtaContable.PerformLayout()
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbClienteGeneral As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombreComercialClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents gbFacturaVenta As System.Windows.Forms.GroupBox
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents gbPagosFacturaVenta As System.Windows.Forms.GroupBox
        Friend WithEvents dgvPagosFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents gbCabeceraComprobante As System.Windows.Forms.GroupBox
        Friend WithEvents pCentroCosto As System.Windows.Forms.Panel
        Friend WithEvents cmbCuentasContables As System.Windows.Forms.ComboBox
        Friend WithEvents btnAgregarConceptoComprobante As System.Windows.Forms.Button
        Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
        Friend WithEvents txtActividad As System.Windows.Forms.TextBox
        Friend WithEvents lblActividad As System.Windows.Forms.Label
        Friend WithEvents lblConcepto As System.Windows.Forms.Label
        Friend WithEvents gbFormaPago As System.Windows.Forms.GroupBox
        Friend WithEvents rbCheque As System.Windows.Forms.RadioButton
        Friend WithEvents rbTransaccion As System.Windows.Forms.RadioButton
        Friend WithEvents rbEfectivo As System.Windows.Forms.RadioButton
        Friend WithEvents rbTarjetaCredido As System.Windows.Forms.RadioButton
        Friend WithEvents gbFacturasAPagar As System.Windows.Forms.GroupBox
        Friend WithEvents txtFacturasAPagar As System.Windows.Forms.TextBox
        Friend WithEvents gbValorComprobanteIngreso As System.Windows.Forms.GroupBox
        Friend WithEvents txtValorComprobaneIngreso As System.Windows.Forms.TextBox
        Friend WithEvents gbObservaciones As System.Windows.Forms.GroupBox
        Friend WithEvents txtObservacionesComprobanteIngreso As System.Windows.Forms.TextBox
        Friend WithEvents gbBanco As System.Windows.Forms.GroupBox
        Friend WithEvents btnEditarValores As System.Windows.Forms.Button
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents dgvComprobanteIngresoBanco As System.Windows.Forms.DataGridView
        Friend WithEvents gbCheque As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtTitularCheque As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaEmisionCheque As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtCtaCteCheque As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtBancoCheque As System.Windows.Forms.TextBox
        Friend WithEvents gbTotalDebeTotalHaber As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtNumeroComprobanteIngreso As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteIngresoBancos As System.Windows.Forms.Label
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtNumeroCheque As System.Windows.Forms.TextBox
        Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CUENTA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CONCEPTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DETALLE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DEBE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents HABER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_CC As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents gbBotonesAgregarEditar As System.Windows.Forms.GroupBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents gbCtaContable As System.Windows.Forms.GroupBox
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents lblCodigoCuentaContable As System.Windows.Forms.Label
        Friend WithEvents dtpFechaEmisionComprobanteIngreso As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbAcreditado As System.Windows.Forms.GroupBox
        Friend WithEvents rbAcreditadoBancos As System.Windows.Forms.RadioButton
        Friend WithEvents rbAcreditadoCaja As System.Windows.Forms.RadioButton
        Friend WithEvents rbAcreditadoCruceCtas As System.Windows.Forms.RadioButton
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ToolStripMenuItemEliminar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents rbNotaCredito As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblValorCuentaBanco As System.Windows.Forms.Label
    End Class
End Namespace