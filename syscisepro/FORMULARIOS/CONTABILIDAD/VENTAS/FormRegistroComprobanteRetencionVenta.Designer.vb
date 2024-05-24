Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormRegistroComprobanteRetencionVenta
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistroComprobanteRetencionVenta))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.gbRetencion = New System.Windows.Forms.GroupBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cmbBienServicio = New System.Windows.Forms.ComboBox()
            Me.btnEliminarImpuesto = New System.Windows.Forms.Button()
            Me.cmbContribuyente = New System.Windows.Forms.ComboBox()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.cmbImpuesto = New System.Windows.Forms.ComboBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dgvDetalleComprobanteRetencionVenta = New System.Windows.Forms.DataGridView()
            Me.txtNumAutoSRIComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblIdComprobanteRetencion = New System.Windows.Forms.Label()
            Me.dtpComprobanteRetencion = New System.Windows.Forms.DateTimePicker()
            Me.btnAgregarImpuesto = New System.Windows.Forms.Button()
            Me.lblContribuyente = New System.Windows.Forms.Label()
            Me.lblConcepto = New System.Windows.Forms.Label()
            Me.lblImpuesto = New System.Windows.Forms.Label()
            Me.lblFechaRetencion = New System.Windows.Forms.Label()
            Me.lblTotalRetencion = New System.Windows.Forms.Label()
            Me.txtTotalComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.lblNroRetencion = New System.Windows.Forms.Label()
            Me.txtNumeroComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.gbFacturaVenta = New System.Windows.Forms.GroupBox()
            Me.gbBuscarFactura = New System.Windows.Forms.GroupBox()
            Me.btnBuscarAsiento = New System.Windows.Forms.Button()
            Me.txtNumeroFacturaBuscar = New System.Windows.Forms.TextBox()
            Me.gbDatosComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.lblFechaEmisionVenta = New System.Windows.Forms.Label()
            Me.lblNumeroFacturaVenta = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
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
            Me.lblTipoPagoFacturaCompra = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.dgvComprobanteRetencionVenta = New System.Windows.Forms.DataGridView()
            Me.gbClienteGeneral = New System.Windows.Forms.GroupBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.lblContribuyenteEspecial = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblLlevaContabilidadClienteGeneral = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblRucClienteGenral = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialCliente = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.EjercicioFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CodigoRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.BaseImponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PorcentajeRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ValorRetenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbRetencion.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvDetalleComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbFacturaVenta.SuspendLayout()
            Me.gbBuscarFactura.SuspendLayout()
            Me.gbDatosComprobanteCompra.SuspendLayout()
            Me.gbValoresComprobanteCompra.SuspendLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbClienteGeneral.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbRetencion
            '
            Me.gbRetencion.BackColor = System.Drawing.Color.White
            Me.gbRetencion.Controls.Add(Me.Label9)
            Me.gbRetencion.Controls.Add(Me.cmbBienServicio)
            Me.gbRetencion.Controls.Add(Me.btnEliminarImpuesto)
            Me.gbRetencion.Controls.Add(Me.cmbContribuyente)
            Me.gbRetencion.Controls.Add(Me.cmbConcepto)
            Me.gbRetencion.Controls.Add(Me.cmbImpuesto)
            Me.gbRetencion.Controls.Add(Me.GroupBox1)
            Me.gbRetencion.Controls.Add(Me.txtNumAutoSRIComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.Label3)
            Me.gbRetencion.Controls.Add(Me.lblIdComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.dtpComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.btnAgregarImpuesto)
            Me.gbRetencion.Controls.Add(Me.lblContribuyente)
            Me.gbRetencion.Controls.Add(Me.lblConcepto)
            Me.gbRetencion.Controls.Add(Me.lblImpuesto)
            Me.gbRetencion.Controls.Add(Me.lblFechaRetencion)
            Me.gbRetencion.Controls.Add(Me.lblTotalRetencion)
            Me.gbRetencion.Controls.Add(Me.txtTotalComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.lblNroRetencion)
            Me.gbRetencion.Controls.Add(Me.txtNumeroComprobanteRetencion)
            Me.gbRetencion.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRetencion.Location = New System.Drawing.Point(1, 357)
            Me.gbRetencion.Name = "gbRetencion"
            Me.gbRetencion.Size = New System.Drawing.Size(709, 212)
            Me.gbRetencion.TabIndex = 73
            Me.gbRetencion.TabStop = False
            Me.gbRetencion.Text = "RETENCIÓN"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(618, 47)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(31, 13)
            Me.Label9.TabIndex = 110
            Me.Label9.Text = "TIPO"
            '
            'cmbBienServicio
            '
            Me.cmbBienServicio.BackColor = System.Drawing.Color.White
            Me.cmbBienServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBienServicio.DropDownWidth = 100
            Me.cmbBienServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBienServicio.FormattingEnabled = True
            Me.cmbBienServicio.Items.AddRange(New Object() {"BIEN", "SERV."})
            Me.cmbBienServicio.Location = New System.Drawing.Point(649, 42)
            Me.cmbBienServicio.Name = "cmbBienServicio"
            Me.cmbBienServicio.Size = New System.Drawing.Size(51, 23)
            Me.cmbBienServicio.TabIndex = 109
            '
            'btnEliminarImpuesto
            '
            Me.btnEliminarImpuesto.BackColor = System.Drawing.Color.White
            Me.btnEliminarImpuesto.Image = CType(resources.GetObject("btnEliminarImpuesto.Image"), System.Drawing.Image)
            Me.btnEliminarImpuesto.Location = New System.Drawing.Point(669, 14)
            Me.btnEliminarImpuesto.Name = "btnEliminarImpuesto"
            Me.btnEliminarImpuesto.Size = New System.Drawing.Size(32, 28)
            Me.btnEliminarImpuesto.TabIndex = 28
            Me.btnEliminarImpuesto.UseVisualStyleBackColor = False
            '
            'cmbContribuyente
            '
            Me.cmbContribuyente.BackColor = System.Drawing.Color.White
            Me.cmbContribuyente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbContribuyente.DropDownWidth = 300
            Me.cmbContribuyente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbContribuyente.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbContribuyente.FormattingEnabled = True
            Me.cmbContribuyente.Location = New System.Drawing.Point(498, 44)
            Me.cmbContribuyente.Name = "cmbContribuyente"
            Me.cmbContribuyente.Size = New System.Drawing.Size(113, 21)
            Me.cmbContribuyente.TabIndex = 26
            '
            'cmbConcepto
            '
            Me.cmbConcepto.BackColor = System.Drawing.Color.White
            Me.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbConcepto.DropDownWidth = 600
            Me.cmbConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbConcepto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.Location = New System.Drawing.Point(265, 44)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(129, 21)
            Me.cmbConcepto.TabIndex = 25
            '
            'cmbImpuesto
            '
            Me.cmbImpuesto.BackColor = System.Drawing.Color.White
            Me.cmbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbImpuesto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbImpuesto.FormattingEnabled = True
            Me.cmbImpuesto.Location = New System.Drawing.Point(74, 44)
            Me.cmbImpuesto.Name = "cmbImpuesto"
            Me.cmbImpuesto.Size = New System.Drawing.Size(117, 21)
            Me.cmbImpuesto.TabIndex = 24
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dgvDetalleComprobanteRetencionVenta)
            Me.GroupBox1.Location = New System.Drawing.Point(9, 60)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
            Me.GroupBox1.Size = New System.Drawing.Size(690, 120)
            Me.GroupBox1.TabIndex = 72
            Me.GroupBox1.TabStop = False
            '
            'dgvDetalleComprobanteRetencionVenta
            '
            Me.dgvDetalleComprobanteRetencionVenta.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencionVenta.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobanteRetencionVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleComprobanteRetencionVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDetalleComprobanteRetencionVenta.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalleComprobanteRetencionVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleComprobanteRetencionVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobanteRetencionVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvDetalleComprobanteRetencionVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EjercicioFiscal, Me.CodigoRetencion, Me.BaseImponible, Me.Impuesto, Me.PorcentajeRetencion, Me.ValorRetenido, Me.Column1, Me.Column2})
            Me.dgvDetalleComprobanteRetencionVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvDetalleComprobanteRetencionVenta.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetalleComprobanteRetencionVenta.Location = New System.Drawing.Point(2, 18)
            Me.dgvDetalleComprobanteRetencionVenta.MultiSelect = False
            Me.dgvDetalleComprobanteRetencionVenta.Name = "dgvDetalleComprobanteRetencionVenta"
            Me.dgvDetalleComprobanteRetencionVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvDetalleComprobanteRetencionVenta.RowHeadersVisible = False
            Me.dgvDetalleComprobanteRetencionVenta.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvDetalleComprobanteRetencionVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobanteRetencionVenta.Size = New System.Drawing.Size(686, 100)
            Me.dgvDetalleComprobanteRetencionVenta.TabIndex = 50
            '
            'txtNumAutoSRIComprobanteRetencion
            '
            Me.txtNumAutoSRIComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtNumAutoSRIComprobanteRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumAutoSRIComprobanteRetencion.Location = New System.Drawing.Point(74, 17)
            Me.txtNumAutoSRIComprobanteRetencion.Name = "txtNumAutoSRIComprobanteRetencion"
            Me.txtNumAutoSRIComprobanteRetencion.Size = New System.Drawing.Size(117, 23)
            Me.txtNumAutoSRIComprobanteRetencion.TabIndex = 71
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(3, 21)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(73, 13)
            Me.Label3.TabIndex = 70
            Me.Label3.Text = "# AUTO SRI:"
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
            Me.dtpComprobanteRetencion.Location = New System.Drawing.Point(498, 17)
            Me.dtpComprobanteRetencion.Name = "dtpComprobanteRetencion"
            Me.dtpComprobanteRetencion.Size = New System.Drawing.Size(113, 20)
            Me.dtpComprobanteRetencion.TabIndex = 23
            '
            'btnAgregarImpuesto
            '
            Me.btnAgregarImpuesto.BackColor = System.Drawing.Color.White
            Me.btnAgregarImpuesto.Image = CType(resources.GetObject("btnAgregarImpuesto.Image"), System.Drawing.Image)
            Me.btnAgregarImpuesto.Location = New System.Drawing.Point(633, 13)
            Me.btnAgregarImpuesto.Name = "btnAgregarImpuesto"
            Me.btnAgregarImpuesto.Size = New System.Drawing.Size(32, 28)
            Me.btnAgregarImpuesto.TabIndex = 27
            Me.btnAgregarImpuesto.UseVisualStyleBackColor = False
            '
            'lblContribuyente
            '
            Me.lblContribuyente.AutoSize = True
            Me.lblContribuyente.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblContribuyente.Location = New System.Drawing.Point(407, 47)
            Me.lblContribuyente.Name = "lblContribuyente"
            Me.lblContribuyente.Size = New System.Drawing.Size(91, 13)
            Me.lblContribuyente.TabIndex = 52
            Me.lblContribuyente.Text = "CONTRIBUYENTE:"
            '
            'lblConcepto
            '
            Me.lblConcepto.AutoSize = True
            Me.lblConcepto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblConcepto.Location = New System.Drawing.Point(203, 47)
            Me.lblConcepto.Name = "lblConcepto"
            Me.lblConcepto.Size = New System.Drawing.Size(61, 13)
            Me.lblConcepto.TabIndex = 50
            Me.lblConcepto.Text = "CONCEPTO:"
            '
            'lblImpuesto
            '
            Me.lblImpuesto.AutoSize = True
            Me.lblImpuesto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblImpuesto.Location = New System.Drawing.Point(3, 47)
            Me.lblImpuesto.Name = "lblImpuesto"
            Me.lblImpuesto.Size = New System.Drawing.Size(61, 13)
            Me.lblImpuesto.TabIndex = 48
            Me.lblImpuesto.Text = "IMPUESTO:"
            '
            'lblFechaRetencion
            '
            Me.lblFechaRetencion.AutoSize = True
            Me.lblFechaRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaRetencion.Location = New System.Drawing.Point(407, 21)
            Me.lblFechaRetencion.Name = "lblFechaRetencion"
            Me.lblFechaRetencion.Size = New System.Drawing.Size(43, 13)
            Me.lblFechaRetencion.TabIndex = 46
            Me.lblFechaRetencion.Text = "FECHA:"
            '
            'lblTotalRetencion
            '
            Me.lblTotalRetencion.AutoSize = True
            Me.lblTotalRetencion.Location = New System.Drawing.Point(469, 184)
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
            Me.txtTotalComprobanteRetencion.Location = New System.Drawing.Point(595, 181)
            Me.txtTotalComprobanteRetencion.Name = "txtTotalComprobanteRetencion"
            Me.txtTotalComprobanteRetencion.Size = New System.Drawing.Size(104, 25)
            Me.txtTotalComprobanteRetencion.TabIndex = 43
            Me.txtTotalComprobanteRetencion.Text = "0.00"
            Me.txtTotalComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblNroRetencion
            '
            Me.lblNroRetencion.AutoSize = True
            Me.lblNroRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroRetencion.Location = New System.Drawing.Point(203, 21)
            Me.lblNroRetencion.Name = "lblNroRetencion"
            Me.lblNroRetencion.Size = New System.Drawing.Size(49, 13)
            Me.lblNroRetencion.TabIndex = 28
            Me.lblNroRetencion.Text = "NRO CR:"
            '
            'txtNumeroComprobanteRetencion
            '
            Me.txtNumeroComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroComprobanteRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroComprobanteRetencion.Location = New System.Drawing.Point(265, 18)
            Me.txtNumeroComprobanteRetencion.Name = "txtNumeroComprobanteRetencion"
            Me.txtNumeroComprobanteRetencion.Size = New System.Drawing.Size(129, 20)
            Me.txtNumeroComprobanteRetencion.TabIndex = 22
            '
            'gbFacturaVenta
            '
            Me.gbFacturaVenta.BackColor = System.Drawing.Color.White
            Me.gbFacturaVenta.Controls.Add(Me.gbBuscarFactura)
            Me.gbFacturaVenta.Controls.Add(Me.gbDatosComprobanteCompra)
            Me.gbFacturaVenta.Controls.Add(Me.gbValoresComprobanteCompra)
            Me.gbFacturaVenta.Controls.Add(Me.lblTipoPagoFacturaCompra)
            Me.gbFacturaVenta.Controls.Add(Me.Label6)
            Me.gbFacturaVenta.Controls.Add(Me.lblIdFacturaVenta)
            Me.gbFacturaVenta.Controls.Add(Me.dgvFacturaVenta)
            Me.gbFacturaVenta.Controls.Add(Me.dgvComprobanteRetencionVenta)
            Me.gbFacturaVenta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFacturaVenta.Location = New System.Drawing.Point(1, 67)
            Me.gbFacturaVenta.Name = "gbFacturaVenta"
            Me.gbFacturaVenta.Size = New System.Drawing.Size(709, 290)
            Me.gbFacturaVenta.TabIndex = 89
            Me.gbFacturaVenta.TabStop = False
            Me.gbFacturaVenta.Text = "FACTURAS DE VENTAS"
            '
            'gbBuscarFactura
            '
            Me.gbBuscarFactura.Controls.Add(Me.btnBuscarAsiento)
            Me.gbBuscarFactura.Controls.Add(Me.txtNumeroFacturaBuscar)
            Me.gbBuscarFactura.Location = New System.Drawing.Point(9, 14)
            Me.gbBuscarFactura.Name = "gbBuscarFactura"
            Me.gbBuscarFactura.Size = New System.Drawing.Size(219, 70)
            Me.gbBuscarFactura.TabIndex = 95
            Me.gbBuscarFactura.TabStop = False
            Me.gbBuscarFactura.Text = "BUSCAR FACTURA"
            '
            'btnBuscarAsiento
            '
            Me.btnBuscarAsiento.BackColor = System.Drawing.Color.White
            Me.btnBuscarAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarAsiento.Image = CType(resources.GetObject("btnBuscarAsiento.Image"), System.Drawing.Image)
            Me.btnBuscarAsiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBuscarAsiento.Location = New System.Drawing.Point(119, 29)
            Me.btnBuscarAsiento.Name = "btnBuscarAsiento"
            Me.btnBuscarAsiento.Size = New System.Drawing.Size(84, 23)
            Me.btnBuscarAsiento.TabIndex = 26
            Me.btnBuscarAsiento.Text = "BUSCAR #"
            Me.btnBuscarAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBuscarAsiento.UseVisualStyleBackColor = False
            '
            'txtNumeroFacturaBuscar
            '
            Me.txtNumeroFacturaBuscar.BackColor = System.Drawing.Color.White
            Me.txtNumeroFacturaBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroFacturaBuscar.Location = New System.Drawing.Point(9, 31)
            Me.txtNumeroFacturaBuscar.Name = "txtNumeroFacturaBuscar"
            Me.txtNumeroFacturaBuscar.Size = New System.Drawing.Size(105, 20)
            Me.txtNumeroFacturaBuscar.TabIndex = 0
            Me.txtNumeroFacturaBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'gbDatosComprobanteCompra
            '
            Me.gbDatosComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblFechaEmisionVenta)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblNumeroFacturaVenta)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label28)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label30)
            Me.gbDatosComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatosComprobanteCompra.Location = New System.Drawing.Point(229, 14)
            Me.gbDatosComprobanteCompra.Name = "gbDatosComprobanteCompra"
            Me.gbDatosComprobanteCompra.Size = New System.Drawing.Size(177, 70)
            Me.gbDatosComprobanteCompra.TabIndex = 93
            Me.gbDatosComprobanteCompra.TabStop = False
            Me.gbDatosComprobanteCompra.Text = "Datos"
            '
            'lblFechaEmisionVenta
            '
            Me.lblFechaEmisionVenta.AutoSize = True
            Me.lblFechaEmisionVenta.Location = New System.Drawing.Point(92, 34)
            Me.lblFechaEmisionVenta.Name = "lblFechaEmisionVenta"
            Me.lblFechaEmisionVenta.Size = New System.Drawing.Size(67, 13)
            Me.lblFechaEmisionVenta.TabIndex = 23
            Me.lblFechaEmisionVenta.Text = "00/00/0000"
            Me.lblFechaEmisionVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNumeroFacturaVenta
            '
            Me.lblNumeroFacturaVenta.AutoSize = True
            Me.lblNumeroFacturaVenta.Location = New System.Drawing.Point(92, 17)
            Me.lblNumeroFacturaVenta.Name = "lblNumeroFacturaVenta"
            Me.lblNumeroFacturaVenta.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroFacturaVenta.TabIndex = 21
            Me.lblNumeroFacturaVenta.Text = "0"
            Me.lblNumeroFacturaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.Location = New System.Drawing.Point(3, 34)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(91, 13)
            Me.Label28.TabIndex = 12
            Me.Label28.Text = "Fecha Emisión:"
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(3, 17)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(73, 13)
            Me.Label30.TabIndex = 10
            Me.Label30.Text = "Nº FACTURA:"
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
            Me.gbValoresComprobanteCompra.Location = New System.Drawing.Point(407, 14)
            Me.gbValoresComprobanteCompra.Name = "gbValoresComprobanteCompra"
            Me.gbValoresComprobanteCompra.Size = New System.Drawing.Size(292, 70)
            Me.gbValoresComprobanteCompra.TabIndex = 92
            Me.gbValoresComprobanteCompra.TabStop = False
            Me.gbValoresComprobanteCompra.Text = "Valores"
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.White
            Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotal.Enabled = False
            Me.txtTotal.Location = New System.Drawing.Point(226, 52)
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
            Me.lblSubTotal.Location = New System.Drawing.Point(162, 17)
            Me.lblSubTotal.Name = "lblSubTotal"
            Me.lblSubTotal.Size = New System.Drawing.Size(67, 13)
            Me.lblSubTotal.TabIndex = 20
            Me.lblSubTotal.Text = "SUB TOTAL:"
            '
            'lblTotalOrdenCompra
            '
            Me.lblTotalOrdenCompra.AutoSize = True
            Me.lblTotalOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalOrdenCompra.Location = New System.Drawing.Point(162, 52)
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
            Me.txtIva.Location = New System.Drawing.Point(226, 34)
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
            Me.lblIvaOrdenCompra.Location = New System.Drawing.Point(162, 34)
            Me.lblIvaOrdenCompra.Name = "lblIvaOrdenCompra"
            Me.lblIvaOrdenCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblIvaOrdenCompra.TabIndex = 13
            Me.lblIvaOrdenCompra.Text = "IVA (12%):"
            '
            'lblDescuentoOrdenCompra
            '
            Me.lblDescuentoOrdenCompra.AutoSize = True
            Me.lblDescuentoOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescuentoOrdenCompra.Location = New System.Drawing.Point(4, 52)
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
            Me.txtSubtotal.Location = New System.Drawing.Point(226, 16)
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
            Me.lblSubtotal0OrdenCompra.Location = New System.Drawing.Point(4, 34)
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
            Me.txtDescuento.Location = New System.Drawing.Point(89, 52)
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
            Me.lblSubtotal12OrdenCompra.Location = New System.Drawing.Point(4, 16)
            Me.lblSubtotal12OrdenCompra.Name = "lblSubtotal12OrdenCompra"
            Me.lblSubtotal12OrdenCompra.Size = New System.Drawing.Size(85, 13)
            Me.lblSubtotal12OrdenCompra.TabIndex = 10
            Me.lblSubtotal12OrdenCompra.Text = "SUB TOTAL 12:"
            '
            'txtSubtotal12
            '
            Me.txtSubtotal12.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal12.Enabled = False
            Me.txtSubtotal12.Location = New System.Drawing.Point(89, 16)
            Me.txtSubtotal12.Name = "txtSubtotal12"
            Me.txtSubtotal12.Size = New System.Drawing.Size(59, 13)
            Me.txtSubtotal12.TabIndex = 27
            Me.txtSubtotal12.Text = "0.00"
            Me.txtSubtotal12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0
            '
            Me.txtSubtotal0.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal0.Enabled = False
            Me.txtSubtotal0.Location = New System.Drawing.Point(89, 34)
            Me.txtSubtotal0.Name = "txtSubtotal0"
            Me.txtSubtotal0.Size = New System.Drawing.Size(59, 13)
            Me.txtSubtotal0.TabIndex = 28
            Me.txtSubtotal0.Text = "0.00"
            Me.txtSubtotal0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTipoPagoFacturaCompra
            '
            Me.lblTipoPagoFacturaCompra.AutoSize = True
            Me.lblTipoPagoFacturaCompra.Location = New System.Drawing.Point(181, 0)
            Me.lblTipoPagoFacturaCompra.Name = "lblTipoPagoFacturaCompra"
            Me.lblTipoPagoFacturaCompra.Size = New System.Drawing.Size(25, 13)
            Me.lblTipoPagoFacturaCompra.TabIndex = 94
            Me.lblTipoPagoFacturaCompra.Text = "..."
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(162, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(13, 13)
            Me.Label6.TabIndex = 93
            Me.Label6.Text = "/"
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(128, 0)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(25, 13)
            Me.lblIdFacturaVenta.TabIndex = 29
            Me.lblIdFacturaVenta.Text = "..."
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.Color.White
            Me.dgvFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturaVenta.DefaultCellStyle = DataGridViewCellStyle12
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(8, 85)
            Me.dgvFacturaVenta.MultiSelect = False
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.ReadOnly = True
            Me.dgvFacturaVenta.RowHeadersVisible = False
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvFacturaVenta.RowsDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(691, 134)
            Me.dgvFacturaVenta.TabIndex = 86
            '
            'dgvComprobanteRetencionVenta
            '
            Me.dgvComprobanteRetencionVenta.AllowUserToAddRows = False
            Me.dgvComprobanteRetencionVenta.AllowUserToDeleteRows = False
            Me.dgvComprobanteRetencionVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobanteRetencionVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvComprobanteRetencionVenta.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobanteRetencionVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobanteRetencionVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteRetencionVenta.Location = New System.Drawing.Point(8, 225)
            Me.dgvComprobanteRetencionVenta.MultiSelect = False
            Me.dgvComprobanteRetencionVenta.Name = "dgvComprobanteRetencionVenta"
            Me.dgvComprobanteRetencionVenta.ReadOnly = True
            Me.dgvComprobanteRetencionVenta.RowHeadersVisible = False
            Me.dgvComprobanteRetencionVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteRetencionVenta.Size = New System.Drawing.Size(690, 62)
            Me.dgvComprobanteRetencionVenta.TabIndex = 96
            '
            'gbClienteGeneral
            '
            Me.gbClienteGeneral.BackColor = System.Drawing.Color.White
            Me.gbClienteGeneral.Controls.Add(Me.Label8)
            Me.gbClienteGeneral.Controls.Add(Me.lblContribuyenteEspecial)
            Me.gbClienteGeneral.Controls.Add(Me.Label7)
            Me.gbClienteGeneral.Controls.Add(Me.Label5)
            Me.gbClienteGeneral.Controls.Add(Me.Label4)
            Me.gbClienteGeneral.Controls.Add(Me.lblLlevaContabilidadClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.Label2)
            Me.gbClienteGeneral.Controls.Add(Me.lblRucClienteGenral)
            Me.gbClienteGeneral.Controls.Add(Me.Label1)
            Me.gbClienteGeneral.Controls.Add(Me.lblIdClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.txtNombreComercialCliente)
            Me.gbClienteGeneral.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbClienteGeneral.Location = New System.Drawing.Point(1, 26)
            Me.gbClienteGeneral.Name = "gbClienteGeneral"
            Me.gbClienteGeneral.Size = New System.Drawing.Size(709, 41)
            Me.gbClienteGeneral.TabIndex = 94
            Me.gbClienteGeneral.TabStop = False
            Me.gbClienteGeneral.Text = "CLIENTE:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(430, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(145, 13)
            Me.Label8.TabIndex = 103
            Me.Label8.Text = "CONTRIBUYENTE ESPECIAL:"
            '
            'lblContribuyenteEspecial
            '
            Me.lblContribuyenteEspecial.AutoSize = True
            Me.lblContribuyenteEspecial.Location = New System.Drawing.Point(581, 0)
            Me.lblContribuyenteEspecial.Name = "lblContribuyenteEspecial"
            Me.lblContribuyenteEspecial.Size = New System.Drawing.Size(25, 13)
            Me.lblContribuyenteEspecial.TabIndex = 102
            Me.lblContribuyenteEspecial.Text = "..."
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(411, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(13, 13)
            Me.Label7.TabIndex = 101
            Me.Label7.Text = "/"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(244, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(121, 13)
            Me.Label5.TabIndex = 100
            Me.Label5.Text = "LLEVA CONTABILIDAD:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(110, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(31, 13)
            Me.Label4.TabIndex = 99
            Me.Label4.Text = "RUC:"
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
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(229, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(13, 13)
            Me.Label2.TabIndex = 97
            Me.Label2.Text = "/"
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
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(95, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(13, 13)
            Me.Label1.TabIndex = 95
            Me.Label1.Text = "/"
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
            Me.txtNombreComercialCliente.Location = New System.Drawing.Point(8, 15)
            Me.txtNombreComercialCliente.Name = "txtNombreComercialCliente"
            Me.txtNombreComercialCliente.Size = New System.Drawing.Size(693, 20)
            Me.txtNombreComercialCliente.TabIndex = 0
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(710, 24)
            Me.MenuStrip1.TabIndex = 189
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevo
            '
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.NuevoRegistro
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(74, 20)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(87, 20)
            Me.btnGuardar.Text = "GUARDAR"
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
            'EjercicioFiscal
            '
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EjercicioFiscal.DefaultCellStyle = DataGridViewCellStyle3
            Me.EjercicioFiscal.HeaderText = "AÑO"
            Me.EjercicioFiscal.Name = "EjercicioFiscal"
            Me.EjercicioFiscal.ReadOnly = True
            Me.EjercicioFiscal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.EjercicioFiscal.Width = 60
            '
            'CodigoRetencion
            '
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CodigoRetencion.DefaultCellStyle = DataGridViewCellStyle4
            Me.CodigoRetencion.HeaderText = "CODIGO"
            Me.CodigoRetencion.Name = "CodigoRetencion"
            Me.CodigoRetencion.ReadOnly = True
            Me.CodigoRetencion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.CodigoRetencion.Width = 60
            '
            'BaseImponible
            '
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BaseImponible.DefaultCellStyle = DataGridViewCellStyle5
            Me.BaseImponible.HeaderText = "BASE"
            Me.BaseImponible.Name = "BaseImponible"
            Me.BaseImponible.ReadOnly = True
            Me.BaseImponible.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.BaseImponible.Width = 70
            '
            'Impuesto
            '
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Impuesto.DefaultCellStyle = DataGridViewCellStyle6
            Me.Impuesto.HeaderText = "IMPUESTO"
            Me.Impuesto.Name = "Impuesto"
            Me.Impuesto.ReadOnly = True
            Me.Impuesto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Impuesto.Width = 70
            '
            'PorcentajeRetencion
            '
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PorcentajeRetencion.DefaultCellStyle = DataGridViewCellStyle7
            Me.PorcentajeRetencion.HeaderText = "%"
            Me.PorcentajeRetencion.Name = "PorcentajeRetencion"
            Me.PorcentajeRetencion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.PorcentajeRetencion.Width = 60
            '
            'ValorRetenido
            '
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ValorRetenido.DefaultCellStyle = DataGridViewCellStyle8
            Me.ValorRetenido.HeaderText = "VALOR"
            Me.ValorRetenido.Name = "ValorRetenido"
            Me.ValorRetenido.ReadOnly = True
            Me.ValorRetenido.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.ValorRetenido.Width = 70
            '
            'Column1
            '
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            Me.Column1.DefaultCellStyle = DataGridViewCellStyle9
            Me.Column1.HeaderText = "CODIGO"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            '
            'Column2
            '
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            Me.Column2.DefaultCellStyle = DataGridViewCellStyle10
            Me.Column2.HeaderText = "CUENTA"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 350
            '
            'FormRegistroComprobanteRetencionVenta
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(710, 570)
            Me.Controls.Add(Me.gbRetencion)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbClienteGeneral)
            Me.Controls.Add(Me.gbFacturaVenta)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormRegistroComprobanteRetencionVenta"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REGISTRO COMPROBANTE RETENCION A FACTURA VENTA"
            Me.gbRetencion.ResumeLayout(False)
            Me.gbRetencion.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgvDetalleComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbFacturaVenta.ResumeLayout(False)
            Me.gbFacturaVenta.PerformLayout()
            Me.gbBuscarFactura.ResumeLayout(False)
            Me.gbBuscarFactura.PerformLayout()
            Me.gbDatosComprobanteCompra.ResumeLayout(False)
            Me.gbDatosComprobanteCompra.PerformLayout()
            Me.gbValoresComprobanteCompra.ResumeLayout(False)
            Me.gbValoresComprobanteCompra.PerformLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbClienteGeneral.ResumeLayout(False)
            Me.gbClienteGeneral.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbRetencion As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdComprobanteRetencion As System.Windows.Forms.Label
        Friend WithEvents dtpComprobanteRetencion As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnEliminarImpuesto As System.Windows.Forms.Button
        Friend WithEvents btnAgregarImpuesto As System.Windows.Forms.Button
        Friend WithEvents lblContribuyente As System.Windows.Forms.Label
        Friend WithEvents cmbContribuyente As System.Windows.Forms.ComboBox
        Friend WithEvents lblConcepto As System.Windows.Forms.Label
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents lblImpuesto As System.Windows.Forms.Label
        Friend WithEvents cmbImpuesto As System.Windows.Forms.ComboBox
        Friend WithEvents lblFechaRetencion As System.Windows.Forms.Label
        Friend WithEvents lblTotalRetencion As System.Windows.Forms.Label
        Friend WithEvents txtTotalComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents lblNroRetencion As System.Windows.Forms.Label
        Friend WithEvents txtNumeroComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents gbFacturaVenta As System.Windows.Forms.GroupBox
        Friend WithEvents gbDatosComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents lblFechaEmisionVenta As System.Windows.Forms.Label
        Friend WithEvents lblNumeroFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents Label30 As System.Windows.Forms.Label
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
        Friend WithEvents gbClienteGeneral As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombreComercialCliente As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents lblRucClienteGenral As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblLlevaContabilidadClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtNumAutoSRIComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents gbBuscarFactura As System.Windows.Forms.GroupBox
        Friend WithEvents txtNumeroFacturaBuscar As System.Windows.Forms.TextBox
        Friend WithEvents btnBuscarAsiento As System.Windows.Forms.Button
        Friend WithEvents dgvComprobanteRetencionVenta As System.Windows.Forms.DataGridView
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents lblContribuyenteEspecial As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cmbBienServicio As System.Windows.Forms.ComboBox
        Friend WithEvents dgvDetalleComprobanteRetencionVenta As System.Windows.Forms.DataGridView
        Friend WithEvents EjercicioFiscal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CodigoRetencion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents BaseImponible As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Impuesto As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents PorcentajeRetencion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ValorRetenido As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace