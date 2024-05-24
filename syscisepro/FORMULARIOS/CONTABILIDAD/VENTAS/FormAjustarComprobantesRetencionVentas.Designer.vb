Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAjustarComprobantesRetencionVentas
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
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAjustarComprobantesRetencionVentas))
            Me.gbRetencion = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.cmbImpuesto = New System.Windows.Forms.ComboBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtValorRetencion = New System.Windows.Forms.TextBox()
            Me.txtPorcentajeRetencion = New System.Windows.Forms.TextBox()
            Me.txtBaseImponible = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dgvDetalleComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.txtNumAutoSRIComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.lblIdComprobanteRetencion = New System.Windows.Forms.Label()
            Me.dtpComprobanteRetencion = New System.Windows.Forms.DateTimePicker()
            Me.lblFechaRetencion = New System.Windows.Forms.Label()
            Me.lblTotalRetencion = New System.Windows.Forms.Label()
            Me.txtTotalComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.lblNroRetencion = New System.Windows.Forms.Label()
            Me.txtNumeroComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.lblEstadoDetalleComprabanteRetencionCompra = New System.Windows.Forms.Label()
            Me.lblIdDetalleComprobanteRetencionCompra = New System.Windows.Forms.Label()
            Me.gbDatosComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.lblTipoPagoFacturaVenta = New System.Windows.Forms.Label()
            Me.lblFechaEmisionFacturaVenta = New System.Windows.Forms.Label()
            Me.lblNumeroFacturaVenta = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.gbFacturasVenta = New System.Windows.Forms.GroupBox()
            Me.lblFechaEmisionVenta = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.lblEstadoFacturaVenta = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.lblNumeroRegistroVenta = New System.Windows.Forms.Label()
            Me.dgvPagosFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.dgvAsientoDiarioVenta = New System.Windows.Forms.DataGridView()
            Me.gbValoresComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.lblSubTotal = New System.Windows.Forms.Label()
            Me.lblTotalOrdenCompra = New System.Windows.Forms.Label()
            Me.txtIva = New System.Windows.Forms.TextBox()
            Me.lblIvaOrdenCompra = New System.Windows.Forms.Label()
            Me.lblDescuentoOrdenCompra = New System.Windows.Forms.Label()
            Me.txtSubtotal = New System.Windows.Forms.TextBox()
            Me.lblSubtotal0OrdenCompra = New System.Windows.Forms.Label()
            Me.txtDescuento = New System.Windows.Forms.TextBox()
            Me.lblSubtotal12OrdenCompra = New System.Windows.Forms.Label()
            Me.txtSubtotal12 = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0 = New System.Windows.Forms.TextBox()
            Me.dgvComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.gbClienteGeneral = New System.Windows.Forms.GroupBox()
            Me.dtpMes = New System.Windows.Forms.DateTimePicker()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.lblLlevaContabilidadClienteGeneral = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.lblRucClienteGenral = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialCliente = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.gbBuscarFactura = New System.Windows.Forms.GroupBox()
            Me.btnBuscarAsiento = New System.Windows.Forms.Button()
            Me.txtNumeroFacturaBuscar = New System.Windows.Forms.TextBox()
            Me.gbRetenciones = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnAnular = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbRetencion.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbDatosComprobanteCompra.SuspendLayout()
            Me.gbFacturasVenta.SuspendLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvPagosFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAsientoDiarioVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbValoresComprobanteCompra.SuspendLayout()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbClienteGeneral.SuspendLayout()
            Me.gbBuscarFactura.SuspendLayout()
            Me.gbRetenciones.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbRetencion
            '
            Me.gbRetencion.BackColor = System.Drawing.Color.White
            Me.gbRetencion.Controls.Add(Me.GroupBox2)
            Me.gbRetencion.Controls.Add(Me.GroupBox1)
            Me.gbRetencion.Controls.Add(Me.txtNumAutoSRIComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.Label12)
            Me.gbRetencion.Controls.Add(Me.lblIdComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.dtpComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.lblFechaRetencion)
            Me.gbRetencion.Controls.Add(Me.lblTotalRetencion)
            Me.gbRetencion.Controls.Add(Me.txtTotalComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.lblNroRetencion)
            Me.gbRetencion.Controls.Add(Me.txtNumeroComprobanteRetencion)
            Me.gbRetencion.Enabled = False
            Me.gbRetencion.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRetencion.Location = New System.Drawing.Point(0, 464)
            Me.gbRetencion.Name = "gbRetencion"
            Me.gbRetencion.Size = New System.Drawing.Size(709, 231)
            Me.gbRetencion.TabIndex = 98
            Me.gbRetencion.TabStop = False
            Me.gbRetencion.Text = "RETENCIÓN"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.cmbConcepto)
            Me.GroupBox2.Controls.Add(Me.cmbImpuesto)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.txtValorRetencion)
            Me.GroupBox2.Controls.Add(Me.txtPorcentajeRetencion)
            Me.GroupBox2.Controls.Add(Me.txtBaseImponible)
            Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(9, 42)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(690, 43)
            Me.GroupBox2.TabIndex = 77
            Me.GroupBox2.TabStop = False
            '
            'cmbConcepto
            '
            Me.cmbConcepto.BackColor = System.Drawing.Color.White
            Me.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbConcepto.DropDownWidth = 600
            Me.cmbConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbConcepto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.Location = New System.Drawing.Point(136, 15)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(83, 21)
            Me.cmbConcepto.TabIndex = 102
            '
            'cmbImpuesto
            '
            Me.cmbImpuesto.BackColor = System.Drawing.Color.White
            Me.cmbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbImpuesto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbImpuesto.FormattingEnabled = True
            Me.cmbImpuesto.Location = New System.Drawing.Point(5, 16)
            Me.cmbImpuesto.Name = "cmbImpuesto"
            Me.cmbImpuesto.Size = New System.Drawing.Size(88, 21)
            Me.cmbImpuesto.TabIndex = 101
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(600, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(79, 13)
            Me.Label7.TabIndex = 100
            Me.Label7.Text = "VAL RETENIDO"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(405, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(67, 13)
            Me.Label5.TabIndex = 99
            Me.Label5.Text = "PORCENTAJE"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(15, 1)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(55, 13)
            Me.Label4.TabIndex = 98
            Me.Label4.Text = "IMPUESTO"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(266, 1)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(91, 13)
            Me.Label3.TabIndex = 97
            Me.Label3.Text = "BASE IMPONIBLE"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(144, 1)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(43, 13)
            Me.Label2.TabIndex = 96
            Me.Label2.Text = "CÓDIGO"
            '
            'txtValorRetencion
            '
            Me.txtValorRetencion.BackColor = System.Drawing.Color.White
            Me.txtValorRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorRetencion.Enabled = False
            Me.txtValorRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorRetencion.Location = New System.Drawing.Point(595, 16)
            Me.txtValorRetencion.Name = "txtValorRetencion"
            Me.txtValorRetencion.Size = New System.Drawing.Size(88, 20)
            Me.txtValorRetencion.TabIndex = 76
            Me.txtValorRetencion.Text = "0.00"
            Me.txtValorRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtPorcentajeRetencion
            '
            Me.txtPorcentajeRetencion.BackColor = System.Drawing.Color.White
            Me.txtPorcentajeRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPorcentajeRetencion.Enabled = False
            Me.txtPorcentajeRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPorcentajeRetencion.Location = New System.Drawing.Point(408, 16)
            Me.txtPorcentajeRetencion.Name = "txtPorcentajeRetencion"
            Me.txtPorcentajeRetencion.Size = New System.Drawing.Size(70, 20)
            Me.txtPorcentajeRetencion.TabIndex = 75
            Me.txtPorcentajeRetencion.Text = "0"
            Me.txtPorcentajeRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtBaseImponible
            '
            Me.txtBaseImponible.BackColor = System.Drawing.Color.White
            Me.txtBaseImponible.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBaseImponible.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBaseImponible.Location = New System.Drawing.Point(269, 16)
            Me.txtBaseImponible.Name = "txtBaseImponible"
            Me.txtBaseImponible.Size = New System.Drawing.Size(88, 20)
            Me.txtBaseImponible.TabIndex = 73
            Me.txtBaseImponible.Text = "0.00"
            Me.txtBaseImponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dgvDetalleComprobanteRetencion)
            Me.GroupBox1.Location = New System.Drawing.Point(9, 77)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(690, 124)
            Me.GroupBox1.TabIndex = 82
            Me.GroupBox1.TabStop = False
            '
            'dgvDetalleComprobanteRetencion
            '
            Me.dgvDetalleComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencion.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobanteRetencion.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleComprobanteRetencion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDetalleComprobanteRetencion.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalleComprobanteRetencion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleComprobanteRetencion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDetalleComprobanteRetencion.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvDetalleComprobanteRetencion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvDetalleComprobanteRetencion.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetalleComprobanteRetencion.Location = New System.Drawing.Point(3, 19)
            Me.dgvDetalleComprobanteRetencion.Name = "dgvDetalleComprobanteRetencion"
            Me.dgvDetalleComprobanteRetencion.ReadOnly = True
            Me.dgvDetalleComprobanteRetencion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvDetalleComprobanteRetencion.RowHeadersVisible = False
            Me.dgvDetalleComprobanteRetencion.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvDetalleComprobanteRetencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobanteRetencion.Size = New System.Drawing.Size(684, 102)
            Me.dgvDetalleComprobanteRetencion.TabIndex = 53
            '
            'txtNumAutoSRIComprobanteRetencion
            '
            Me.txtNumAutoSRIComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtNumAutoSRIComprobanteRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumAutoSRIComprobanteRetencion.Location = New System.Drawing.Point(77, 17)
            Me.txtNumAutoSRIComprobanteRetencion.Name = "txtNumAutoSRIComprobanteRetencion"
            Me.txtNumAutoSRIComprobanteRetencion.Size = New System.Drawing.Size(117, 23)
            Me.txtNumAutoSRIComprobanteRetencion.TabIndex = 81
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(6, 21)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(73, 13)
            Me.Label12.TabIndex = 80
            Me.Label12.Text = "# AUTO SRI:"
            '
            'lblIdComprobanteRetencion
            '
            Me.lblIdComprobanteRetencion.AutoSize = True
            Me.lblIdComprobanteRetencion.Location = New System.Drawing.Point(80, 0)
            Me.lblIdComprobanteRetencion.Name = "lblIdComprobanteRetencion"
            Me.lblIdComprobanteRetencion.Size = New System.Drawing.Size(28, 15)
            Me.lblIdComprobanteRetencion.TabIndex = 69
            Me.lblIdComprobanteRetencion.Text = "..."
            '
            'dtpComprobanteRetencion
            '
            Me.dtpComprobanteRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpComprobanteRetencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpComprobanteRetencion.Location = New System.Drawing.Point(511, 17)
            Me.dtpComprobanteRetencion.Name = "dtpComprobanteRetencion"
            Me.dtpComprobanteRetencion.Size = New System.Drawing.Size(185, 20)
            Me.dtpComprobanteRetencion.TabIndex = 23
            '
            'lblFechaRetencion
            '
            Me.lblFechaRetencion.AutoSize = True
            Me.lblFechaRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaRetencion.Location = New System.Drawing.Point(466, 21)
            Me.lblFechaRetencion.Name = "lblFechaRetencion"
            Me.lblFechaRetencion.Size = New System.Drawing.Size(43, 13)
            Me.lblFechaRetencion.TabIndex = 46
            Me.lblFechaRetencion.Text = "FECHA:"
            '
            'lblTotalRetencion
            '
            Me.lblTotalRetencion.AutoSize = True
            Me.lblTotalRetencion.Location = New System.Drawing.Point(479, 207)
            Me.lblTotalRetencion.Name = "lblTotalRetencion"
            Me.lblTotalRetencion.Size = New System.Drawing.Size(119, 15)
            Me.lblTotalRetencion.TabIndex = 44
            Me.lblTotalRetencion.Text = "TOTAL RETENCIÓN:"
            '
            'txtTotalComprobanteRetencion
            '
            Me.txtTotalComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalComprobanteRetencion.Enabled = False
            Me.txtTotalComprobanteRetencion.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobanteRetencion.Location = New System.Drawing.Point(604, 202)
            Me.txtTotalComprobanteRetencion.Name = "txtTotalComprobanteRetencion"
            Me.txtTotalComprobanteRetencion.Size = New System.Drawing.Size(95, 25)
            Me.txtTotalComprobanteRetencion.TabIndex = 43
            Me.txtTotalComprobanteRetencion.Text = "0.00"
            Me.txtTotalComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblNroRetencion
            '
            Me.lblNroRetencion.AutoSize = True
            Me.lblNroRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroRetencion.Location = New System.Drawing.Point(211, 20)
            Me.lblNroRetencion.Name = "lblNroRetencion"
            Me.lblNroRetencion.Size = New System.Drawing.Size(61, 13)
            Me.lblNroRetencion.TabIndex = 28
            Me.lblNroRetencion.Text = "NRO RET.:"
            '
            'txtNumeroComprobanteRetencion
            '
            Me.txtNumeroComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroComprobanteRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroComprobanteRetencion.Location = New System.Drawing.Point(274, 18)
            Me.txtNumeroComprobanteRetencion.Name = "txtNumeroComprobanteRetencion"
            Me.txtNumeroComprobanteRetencion.Size = New System.Drawing.Size(173, 20)
            Me.txtNumeroComprobanteRetencion.TabIndex = 22
            '
            'lblEstadoDetalleComprabanteRetencionCompra
            '
            Me.lblEstadoDetalleComprabanteRetencionCompra.AutoSize = True
            Me.lblEstadoDetalleComprabanteRetencionCompra.Location = New System.Drawing.Point(598, 524)
            Me.lblEstadoDetalleComprabanteRetencionCompra.Name = "lblEstadoDetalleComprabanteRetencionCompra"
            Me.lblEstadoDetalleComprabanteRetencionCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblEstadoDetalleComprabanteRetencionCompra.TabIndex = 107
            Me.lblEstadoDetalleComprabanteRetencionCompra.Text = "0"
            '
            'lblIdDetalleComprobanteRetencionCompra
            '
            Me.lblIdDetalleComprobanteRetencionCompra.AutoSize = True
            Me.lblIdDetalleComprobanteRetencionCompra.Location = New System.Drawing.Point(565, 524)
            Me.lblIdDetalleComprobanteRetencionCompra.Name = "lblIdDetalleComprobanteRetencionCompra"
            Me.lblIdDetalleComprobanteRetencionCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblIdDetalleComprobanteRetencionCompra.TabIndex = 99
            Me.lblIdDetalleComprobanteRetencionCompra.Text = "0"
            '
            'gbDatosComprobanteCompra
            '
            Me.gbDatosComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblTipoPagoFacturaVenta)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblFechaEmisionFacturaVenta)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblNumeroFacturaVenta)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label27)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label28)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label30)
            Me.gbDatosComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatosComprobanteCompra.Location = New System.Drawing.Point(0, 259)
            Me.gbDatosComprobanteCompra.Name = "gbDatosComprobanteCompra"
            Me.gbDatosComprobanteCompra.Size = New System.Drawing.Size(170, 74)
            Me.gbDatosComprobanteCompra.TabIndex = 103
            Me.gbDatosComprobanteCompra.TabStop = False
            Me.gbDatosComprobanteCompra.Text = "Datos"
            '
            'lblTipoPagoFacturaVenta
            '
            Me.lblTipoPagoFacturaVenta.AutoSize = True
            Me.lblTipoPagoFacturaVenta.Location = New System.Drawing.Point(61, 52)
            Me.lblTipoPagoFacturaVenta.Name = "lblTipoPagoFacturaVenta"
            Me.lblTipoPagoFacturaVenta.Size = New System.Drawing.Size(25, 13)
            Me.lblTipoPagoFacturaVenta.TabIndex = 25
            Me.lblTipoPagoFacturaVenta.Text = "..."
            Me.lblTipoPagoFacturaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblFechaEmisionFacturaVenta
            '
            Me.lblFechaEmisionFacturaVenta.AutoSize = True
            Me.lblFechaEmisionFacturaVenta.Location = New System.Drawing.Point(61, 34)
            Me.lblFechaEmisionFacturaVenta.Name = "lblFechaEmisionFacturaVenta"
            Me.lblFechaEmisionFacturaVenta.Size = New System.Drawing.Size(67, 13)
            Me.lblFechaEmisionFacturaVenta.TabIndex = 23
            Me.lblFechaEmisionFacturaVenta.Text = "00/00/0000"
            Me.lblFechaEmisionFacturaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNumeroFacturaVenta
            '
            Me.lblNumeroFacturaVenta.AutoSize = True
            Me.lblNumeroFacturaVenta.Location = New System.Drawing.Point(61, 16)
            Me.lblNumeroFacturaVenta.Name = "lblNumeroFacturaVenta"
            Me.lblNumeroFacturaVenta.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroFacturaVenta.TabIndex = 21
            Me.lblNumeroFacturaVenta.Text = "0"
            Me.lblNumeroFacturaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label27.Location = New System.Drawing.Point(12, 52)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(37, 13)
            Me.Label27.TabIndex = 13
            Me.Label27.Text = "Tipo:"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.Location = New System.Drawing.Point(12, 34)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(43, 13)
            Me.Label28.TabIndex = 12
            Me.Label28.Text = "Fecha:"
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(12, 16)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(31, 13)
            Me.Label30.TabIndex = 10
            Me.Label30.Text = "Nro:"
            '
            'gbFacturasVenta
            '
            Me.gbFacturasVenta.BackColor = System.Drawing.Color.White
            Me.gbFacturasVenta.Controls.Add(Me.lblFechaEmisionVenta)
            Me.gbFacturasVenta.Controls.Add(Me.Label13)
            Me.gbFacturasVenta.Controls.Add(Me.dgvFacturaVenta)
            Me.gbFacturasVenta.Controls.Add(Me.lblEstadoFacturaVenta)
            Me.gbFacturasVenta.Controls.Add(Me.Label6)
            Me.gbFacturasVenta.Controls.Add(Me.lblIdFacturaVenta)
            Me.gbFacturasVenta.Controls.Add(Me.lblNumeroRegistroVenta)
            Me.gbFacturasVenta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFacturasVenta.Location = New System.Drawing.Point(0, 67)
            Me.gbFacturasVenta.Name = "gbFacturasVenta"
            Me.gbFacturasVenta.Size = New System.Drawing.Size(709, 266)
            Me.gbFacturasVenta.TabIndex = 106
            Me.gbFacturasVenta.TabStop = False
            Me.gbFacturasVenta.Text = "FACTURA VENTA:"
            '
            'lblFechaEmisionVenta
            '
            Me.lblFechaEmisionVenta.AutoSize = True
            Me.lblFechaEmisionVenta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaEmisionVenta.Location = New System.Drawing.Point(365, 0)
            Me.lblFechaEmisionVenta.Name = "lblFechaEmisionVenta"
            Me.lblFechaEmisionVenta.Size = New System.Drawing.Size(67, 13)
            Me.lblFechaEmisionVenta.TabIndex = 97
            Me.lblFechaEmisionVenta.Text = "00/00/0000"
            Me.lblFechaEmisionVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(276, 0)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(91, 13)
            Me.Label13.TabIndex = 96
            Me.Label13.Text = "Fecha Emisión:"
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.Color.White
            Me.dgvFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturaVenta.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvFacturaVenta.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(3, 16)
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.ReadOnly = True
            Me.dgvFacturaVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvFacturaVenta.RowHeadersVisible = False
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvFacturaVenta.RowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(703, 247)
            Me.dgvFacturaVenta.TabIndex = 95
            '
            'lblEstadoFacturaVenta
            '
            Me.lblEstadoFacturaVenta.AutoSize = True
            Me.lblEstadoFacturaVenta.Location = New System.Drawing.Point(206, 0)
            Me.lblEstadoFacturaVenta.Name = "lblEstadoFacturaVenta"
            Me.lblEstadoFacturaVenta.Size = New System.Drawing.Size(25, 13)
            Me.lblEstadoFacturaVenta.TabIndex = 94
            Me.lblEstadoFacturaVenta.Text = "..."
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(187, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(13, 13)
            Me.Label6.TabIndex = 93
            Me.Label6.Text = "/"
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(153, 0)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(25, 13)
            Me.lblIdFacturaVenta.TabIndex = 29
            Me.lblIdFacturaVenta.Text = "..."
            '
            'lblNumeroRegistroVenta
            '
            Me.lblNumeroRegistroVenta.AutoSize = True
            Me.lblNumeroRegistroVenta.Location = New System.Drawing.Point(439, 134)
            Me.lblNumeroRegistroVenta.Name = "lblNumeroRegistroVenta"
            Me.lblNumeroRegistroVenta.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroRegistroVenta.TabIndex = 112
            Me.lblNumeroRegistroVenta.Text = "0"
            '
            'dgvPagosFacturaVenta
            '
            Me.dgvPagosFacturaVenta.AllowUserToAddRows = False
            Me.dgvPagosFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvPagosFacturaVenta.AllowUserToResizeColumns = False
            Me.dgvPagosFacturaVenta.AllowUserToResizeRows = False
            Me.dgvPagosFacturaVenta.BackgroundColor = System.Drawing.Color.White
            Me.dgvPagosFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPagosFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvPagosFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPagosFacturaVenta.DefaultCellStyle = DataGridViewCellStyle9
            Me.dgvPagosFacturaVenta.Location = New System.Drawing.Point(258, 80)
            Me.dgvPagosFacturaVenta.Name = "dgvPagosFacturaVenta"
            Me.dgvPagosFacturaVenta.ReadOnly = True
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPagosFacturaVenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvPagosFacturaVenta.RowHeadersVisible = False
            Me.dgvPagosFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPagosFacturaVenta.Size = New System.Drawing.Size(435, 114)
            Me.dgvPagosFacturaVenta.TabIndex = 110
            '
            'dgvAsientoDiarioVenta
            '
            Me.dgvAsientoDiarioVenta.AllowUserToAddRows = False
            Me.dgvAsientoDiarioVenta.AllowUserToDeleteRows = False
            Me.dgvAsientoDiarioVenta.AllowUserToResizeColumns = False
            Me.dgvAsientoDiarioVenta.AllowUserToResizeRows = False
            Me.dgvAsientoDiarioVenta.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsientoDiarioVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientoDiarioVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvAsientoDiarioVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientoDiarioVenta.DefaultCellStyle = DataGridViewCellStyle12
            Me.dgvAsientoDiarioVenta.Location = New System.Drawing.Point(258, 200)
            Me.dgvAsientoDiarioVenta.Name = "dgvAsientoDiarioVenta"
            Me.dgvAsientoDiarioVenta.ReadOnly = True
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientoDiarioVenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvAsientoDiarioVenta.RowHeadersVisible = False
            Me.dgvAsientoDiarioVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientoDiarioVenta.Size = New System.Drawing.Size(435, 124)
            Me.dgvAsientoDiarioVenta.TabIndex = 111
            '
            'gbValoresComprobanteCompra
            '
            Me.gbValoresComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtTotal)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubTotal)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblTotalOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtIva)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblIvaOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblDescuentoOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal0OrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtDescuento)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal12OrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal12)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal0)
            Me.gbValoresComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbValoresComprobanteCompra.Location = New System.Drawing.Point(164, 259)
            Me.gbValoresComprobanteCompra.Name = "gbValoresComprobanteCompra"
            Me.gbValoresComprobanteCompra.Size = New System.Drawing.Size(539, 74)
            Me.gbValoresComprobanteCompra.TabIndex = 100
            Me.gbValoresComprobanteCompra.TabStop = False
            Me.gbValoresComprobanteCompra.Text = "Valores"
            '
            'txtTotal
            '
            Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotal.Location = New System.Drawing.Point(334, 52)
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
            Me.lblSubTotal.Location = New System.Drawing.Point(261, 16)
            Me.lblSubTotal.Name = "lblSubTotal"
            Me.lblSubTotal.Size = New System.Drawing.Size(67, 13)
            Me.lblSubTotal.TabIndex = 20
            Me.lblSubTotal.Text = "SUB TOTAL:"
            '
            'lblTotalOrdenCompra
            '
            Me.lblTotalOrdenCompra.AutoSize = True
            Me.lblTotalOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalOrdenCompra.Location = New System.Drawing.Point(261, 51)
            Me.lblTotalOrdenCompra.Name = "lblTotalOrdenCompra"
            Me.lblTotalOrdenCompra.Size = New System.Drawing.Size(43, 13)
            Me.lblTotalOrdenCompra.TabIndex = 14
            Me.lblTotalOrdenCompra.Text = "TOTAL:"
            '
            'txtIva
            '
            Me.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtIva.Location = New System.Drawing.Point(334, 34)
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
            Me.lblIvaOrdenCompra.Location = New System.Drawing.Point(261, 33)
            Me.lblIvaOrdenCompra.Name = "lblIvaOrdenCompra"
            Me.lblIvaOrdenCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblIvaOrdenCompra.TabIndex = 13
            Me.lblIvaOrdenCompra.Text = "IVA (12%):"
            '
            'lblDescuentoOrdenCompra
            '
            Me.lblDescuentoOrdenCompra.AutoSize = True
            Me.lblDescuentoOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescuentoOrdenCompra.Location = New System.Drawing.Point(60, 52)
            Me.lblDescuentoOrdenCompra.Name = "lblDescuentoOrdenCompra"
            Me.lblDescuentoOrdenCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblDescuentoOrdenCompra.TabIndex = 12
            Me.lblDescuentoOrdenCompra.Text = "DESCUENTO:"
            '
            'txtSubtotal
            '
            Me.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal.Location = New System.Drawing.Point(334, 16)
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
            Me.lblSubtotal0OrdenCompra.Location = New System.Drawing.Point(60, 34)
            Me.lblSubtotal0OrdenCompra.Name = "lblSubtotal0OrdenCompra"
            Me.lblSubtotal0OrdenCompra.Size = New System.Drawing.Size(79, 13)
            Me.lblSubtotal0OrdenCompra.TabIndex = 11
            Me.lblSubtotal0OrdenCompra.Text = "SUB TOTAL 0:"
            '
            'txtDescuento
            '
            Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtDescuento.Location = New System.Drawing.Point(156, 52)
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.Size = New System.Drawing.Size(59, 13)
            Me.txtDescuento.TabIndex = 29
            Me.txtDescuento.Text = "0.00"
            Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal12OrdenCompra
            '
            Me.lblSubtotal12OrdenCompra.AutoSize = True
            Me.lblSubtotal12OrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal12OrdenCompra.Location = New System.Drawing.Point(60, 16)
            Me.lblSubtotal12OrdenCompra.Name = "lblSubtotal12OrdenCompra"
            Me.lblSubtotal12OrdenCompra.Size = New System.Drawing.Size(85, 13)
            Me.lblSubtotal12OrdenCompra.TabIndex = 10
            Me.lblSubtotal12OrdenCompra.Text = "SUB TOTAL 12:"
            '
            'txtSubtotal12
            '
            Me.txtSubtotal12.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal12.Location = New System.Drawing.Point(156, 16)
            Me.txtSubtotal12.Name = "txtSubtotal12"
            Me.txtSubtotal12.Size = New System.Drawing.Size(59, 13)
            Me.txtSubtotal12.TabIndex = 27
            Me.txtSubtotal12.Text = "0.00"
            Me.txtSubtotal12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0
            '
            Me.txtSubtotal0.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal0.Location = New System.Drawing.Point(156, 34)
            Me.txtSubtotal0.Name = "txtSubtotal0"
            Me.txtSubtotal0.Size = New System.Drawing.Size(59, 13)
            Me.txtSubtotal0.TabIndex = 28
            Me.txtSubtotal0.Text = "0.00"
            Me.txtSubtotal0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvComprobanteRetencion
            '
            Me.dgvComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvComprobanteRetencion.AllowUserToDeleteRows = False
            Me.dgvComprobanteRetencion.AllowUserToResizeRows = False
            DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobanteRetencion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvComprobanteRetencion.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobanteRetencion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobanteRetencion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobanteRetencion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteRetencion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteRetencion.DefaultCellStyle = DataGridViewCellStyle16
            Me.dgvComprobanteRetencion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvComprobanteRetencion.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvComprobanteRetencion.Location = New System.Drawing.Point(3, 16)
            Me.dgvComprobanteRetencion.Name = "dgvComprobanteRetencion"
            Me.dgvComprobanteRetencion.ReadOnly = True
            Me.dgvComprobanteRetencion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvComprobanteRetencion.RowHeadersVisible = False
            Me.dgvComprobanteRetencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteRetencion.Size = New System.Drawing.Size(703, 112)
            Me.dgvComprobanteRetencion.TabIndex = 105
            '
            'gbClienteGeneral
            '
            Me.gbClienteGeneral.BackColor = System.Drawing.Color.White
            Me.gbClienteGeneral.Controls.Add(Me.dtpMes)
            Me.gbClienteGeneral.Controls.Add(Me.Label8)
            Me.gbClienteGeneral.Controls.Add(Me.Label9)
            Me.gbClienteGeneral.Controls.Add(Me.lblLlevaContabilidadClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.Label10)
            Me.gbClienteGeneral.Controls.Add(Me.lblRucClienteGenral)
            Me.gbClienteGeneral.Controls.Add(Me.Label11)
            Me.gbClienteGeneral.Controls.Add(Me.lblIdClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.txtNombreComercialCliente)
            Me.gbClienteGeneral.Controls.Add(Me.Label14)
            Me.gbClienteGeneral.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbClienteGeneral.Location = New System.Drawing.Point(0, 26)
            Me.gbClienteGeneral.Name = "gbClienteGeneral"
            Me.gbClienteGeneral.Size = New System.Drawing.Size(541, 41)
            Me.gbClienteGeneral.TabIndex = 108
            Me.gbClienteGeneral.TabStop = False
            Me.gbClienteGeneral.Text = "CLIENTE:"
            '
            'dtpMes
            '
            Me.dtpMes.CustomFormat = "MMM yyyy"
            Me.dtpMes.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpMes.Location = New System.Drawing.Point(442, 15)
            Me.dtpMes.Name = "dtpMes"
            Me.dtpMes.ShowUpDown = True
            Me.dtpMes.Size = New System.Drawing.Size(93, 20)
            Me.dtpMes.TabIndex = 102
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(244, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(121, 13)
            Me.Label8.TabIndex = 100
            Me.Label8.Text = "LLEVA CONTABILIDAD:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(110, 0)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(31, 13)
            Me.Label9.TabIndex = 99
            Me.Label9.Text = "RUC:"
            '
            'lblLlevaContabilidadClienteGeneral
            '
            Me.lblLlevaContabilidadClienteGeneral.AutoSize = True
            Me.lblLlevaContabilidadClienteGeneral.Location = New System.Drawing.Point(365, 0)
            Me.lblLlevaContabilidadClienteGeneral.Name = "lblLlevaContabilidadClienteGeneral"
            Me.lblLlevaContabilidadClienteGeneral.Size = New System.Drawing.Size(25, 13)
            Me.lblLlevaContabilidadClienteGeneral.TabIndex = 98
            Me.lblLlevaContabilidadClienteGeneral.Text = "..."
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(229, 0)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(13, 13)
            Me.Label10.TabIndex = 97
            Me.Label10.Text = "/"
            '
            'lblRucClienteGenral
            '
            Me.lblRucClienteGenral.AutoSize = True
            Me.lblRucClienteGenral.Location = New System.Drawing.Point(141, 0)
            Me.lblRucClienteGenral.Name = "lblRucClienteGenral"
            Me.lblRucClienteGenral.Size = New System.Drawing.Size(25, 13)
            Me.lblRucClienteGenral.TabIndex = 96
            Me.lblRucClienteGenral.Text = "..."
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(95, 0)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(13, 13)
            Me.Label11.TabIndex = 95
            Me.Label11.Text = "/"
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(60, 0)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(25, 13)
            Me.lblIdClienteGeneral.TabIndex = 1
            Me.lblIdClienteGeneral.Text = "..."
            '
            'txtNombreComercialCliente
            '
            Me.txtNombreComercialCliente.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialCliente.Location = New System.Drawing.Point(5, 14)
            Me.txtNombreComercialCliente.Name = "txtNombreComercialCliente"
            Me.txtNombreComercialCliente.Size = New System.Drawing.Size(403, 20)
            Me.txtNombreComercialCliente.TabIndex = 0
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(414, 19)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(31, 13)
            Me.Label14.TabIndex = 101
            Me.Label14.Text = "MES:"
            '
            'gbBuscarFactura
            '
            Me.gbBuscarFactura.BackColor = System.Drawing.Color.White
            Me.gbBuscarFactura.Controls.Add(Me.btnBuscarAsiento)
            Me.gbBuscarFactura.Controls.Add(Me.txtNumeroFacturaBuscar)
            Me.gbBuscarFactura.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBuscarFactura.Location = New System.Drawing.Point(541, 26)
            Me.gbBuscarFactura.Name = "gbBuscarFactura"
            Me.gbBuscarFactura.Size = New System.Drawing.Size(168, 41)
            Me.gbBuscarFactura.TabIndex = 109
            Me.gbBuscarFactura.TabStop = False
            Me.gbBuscarFactura.Text = "BUSCAR FACTURA"
            '
            'btnBuscarAsiento
            '
            Me.btnBuscarAsiento.BackColor = System.Drawing.Color.White
            Me.btnBuscarAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarAsiento.Image = CType(resources.GetObject("btnBuscarAsiento.Image"), System.Drawing.Image)
            Me.btnBuscarAsiento.Location = New System.Drawing.Point(126, 12)
            Me.btnBuscarAsiento.Name = "btnBuscarAsiento"
            Me.btnBuscarAsiento.Size = New System.Drawing.Size(32, 28)
            Me.btnBuscarAsiento.TabIndex = 26
            Me.btnBuscarAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBuscarAsiento.UseVisualStyleBackColor = False
            '
            'txtNumeroFacturaBuscar
            '
            Me.txtNumeroFacturaBuscar.BackColor = System.Drawing.Color.White
            Me.txtNumeroFacturaBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroFacturaBuscar.Location = New System.Drawing.Point(17, 16)
            Me.txtNumeroFacturaBuscar.Name = "txtNumeroFacturaBuscar"
            Me.txtNumeroFacturaBuscar.Size = New System.Drawing.Size(105, 20)
            Me.txtNumeroFacturaBuscar.TabIndex = 0
            Me.txtNumeroFacturaBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'gbRetenciones
            '
            Me.gbRetenciones.BackColor = System.Drawing.Color.White
            Me.gbRetenciones.Controls.Add(Me.dgvComprobanteRetencion)
            Me.gbRetenciones.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRetenciones.Location = New System.Drawing.Point(0, 333)
            Me.gbRetenciones.Name = "gbRetenciones"
            Me.gbRetenciones.Size = New System.Drawing.Size(709, 131)
            Me.gbRetenciones.TabIndex = 96
            Me.gbRetenciones.TabStop = False
            Me.gbRetenciones.Text = "Seleccione un Retención"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAnular})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
            Me.MenuStrip1.TabIndex = 190
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnAnular
            '
            Me.btnAnular.Image = Global.syscisepro.My.Resources.Resources.EliminarRegistro
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(81, 20)
            Me.btnAnular.Text = "ANULAR"
            '
            'FormAjustarComprobantesRetencionVentas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(709, 697)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbRetenciones)
            Me.Controls.Add(Me.gbBuscarFactura)
            Me.Controls.Add(Me.gbClienteGeneral)
            Me.Controls.Add(Me.gbRetencion)
            Me.Controls.Add(Me.lblEstadoDetalleComprabanteRetencionCompra)
            Me.Controls.Add(Me.lblIdDetalleComprobanteRetencionCompra)
            Me.Controls.Add(Me.gbFacturasVenta)
            Me.Controls.Add(Me.gbDatosComprobanteCompra)
            Me.Controls.Add(Me.gbValoresComprobanteCompra)
            Me.Controls.Add(Me.dgvAsientoDiarioVenta)
            Me.Controls.Add(Me.dgvPagosFacturaVenta)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormAjustarComprobantesRetencionVentas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AJUSTAR COMPROBANTES DE RETENCION VENTAS"
            Me.gbRetencion.ResumeLayout(False)
            Me.gbRetencion.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbDatosComprobanteCompra.ResumeLayout(False)
            Me.gbDatosComprobanteCompra.PerformLayout()
            Me.gbFacturasVenta.ResumeLayout(False)
            Me.gbFacturasVenta.PerformLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvPagosFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAsientoDiarioVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbValoresComprobanteCompra.ResumeLayout(False)
            Me.gbValoresComprobanteCompra.PerformLayout()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbClienteGeneral.ResumeLayout(False)
            Me.gbClienteGeneral.PerformLayout()
            Me.gbBuscarFactura.ResumeLayout(False)
            Me.gbBuscarFactura.PerformLayout()
            Me.gbRetenciones.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbRetencion As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtValorRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtPorcentajeRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtBaseImponible As System.Windows.Forms.TextBox
        Friend WithEvents lblIdComprobanteRetencion As System.Windows.Forms.Label
        Friend WithEvents dtpComprobanteRetencion As System.Windows.Forms.DateTimePicker
        Friend WithEvents dgvDetalleComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents lblFechaRetencion As System.Windows.Forms.Label
        Friend WithEvents lblTotalRetencion As System.Windows.Forms.Label
        Friend WithEvents txtTotalComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents lblNroRetencion As System.Windows.Forms.Label
        Friend WithEvents txtNumeroComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents lblEstadoDetalleComprabanteRetencionCompra As System.Windows.Forms.Label
        Friend WithEvents lblIdDetalleComprobanteRetencionCompra As System.Windows.Forms.Label
        Friend WithEvents gbDatosComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents lblTipoPagoFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents lblFechaEmisionFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents lblNumeroFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents gbFacturasVenta As System.Windows.Forms.GroupBox
        Friend WithEvents lblEstadoFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
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
        Friend WithEvents dgvComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents gbClienteGeneral As System.Windows.Forms.GroupBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents lblLlevaContabilidadClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents lblRucClienteGenral As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents txtNombreComercialCliente As System.Windows.Forms.TextBox
        Friend WithEvents gbBuscarFactura As System.Windows.Forms.GroupBox
        Friend WithEvents btnBuscarAsiento As System.Windows.Forms.Button
        Friend WithEvents txtNumeroFacturaBuscar As System.Windows.Forms.TextBox
        Friend WithEvents txtNumAutoSRIComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents gbRetenciones As System.Windows.Forms.GroupBox
        Friend WithEvents lblFechaEmisionVenta As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents dgvPagosFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dgvAsientoDiarioVenta As System.Windows.Forms.DataGridView
        Friend WithEvents lblNumeroRegistroVenta As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnAnular As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents dtpMes As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmbImpuesto As System.Windows.Forms.ComboBox
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
    End Class
End Namespace