Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormComprobantesRetencionCompras
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
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComprobantesRetencionCompras))
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.gbRetencion = New System.Windows.Forms.GroupBox()
            Me.dgvDetalleComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.EjercicioFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CodigoRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.BaseImponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PorcentajeRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ValorRetenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cmbBienServicio = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtBaseImponible = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtValorRetencion = New System.Windows.Forms.TextBox()
            Me.txtPorcentajeRetencion = New System.Windows.Forms.TextBox()
            Me.lblContribuyente = New System.Windows.Forms.Label()
            Me.cmbContribuyente = New System.Windows.Forms.ComboBox()
            Me.lblConcepto = New System.Windows.Forms.Label()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.lblImpuesto = New System.Windows.Forms.Label()
            Me.cmbImpuesto = New System.Windows.Forms.ComboBox()
            Me.btnEliminarImpuesto = New System.Windows.Forms.Button()
            Me.btnAgregarImpuesto = New System.Windows.Forms.Button()
            Me.txtNumAutoSRIComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.lblIdComprobanteRetencion = New System.Windows.Forms.Label()
            Me.dtpComprobanteRetencion = New System.Windows.Forms.DateTimePicker()
            Me.lblTotalRetencion = New System.Windows.Forms.Label()
            Me.txtTotalComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.txtNumeroComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.lblNroRetencion = New System.Windows.Forms.Label()
            Me.lblFechaRetencion = New System.Windows.Forms.Label()
            Me.gbNombreComercialProveedor = New System.Windows.Forms.GroupBox()
            Me.dtpMes = New System.Windows.Forms.DateTimePicker()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.EsContrbuyenteEspecial = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.lblRucProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.dgvComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblEstadoComprobanteCompra = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.dgvComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.dgvPagosComprobanteCompra = New System.Windows.Forms.DataGridView()
            Me.dgvAsientoComprobanteCompra = New System.Windows.Forms.DataGridView()
            Me.gbDatosComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.rbPtoEmision002 = New System.Windows.Forms.RadioButton()
            Me.rbPtoEmision001 = New System.Windows.Forms.RadioButton()
            Me.dtpFechaEmisionComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.lblTipoComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblFechaComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblNumeroComprobanteCompra = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.gbValoresComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.txtTotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblSubTotal = New System.Windows.Forms.Label()
            Me.lblTotalOrdenCompra = New System.Windows.Forms.Label()
            Me.txtIvaComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblIvaOrdenCompra = New System.Windows.Forms.Label()
            Me.lblDescuentoOrdenCompra = New System.Windows.Forms.Label()
            Me.txtSubtotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblSubtotal0OrdenCompra = New System.Windows.Forms.Label()
            Me.txtDescuento = New System.Windows.Forms.TextBox()
            Me.lblSubtotal12OrdenCompra = New System.Windows.Forms.Label()
            Me.txtSubtotal12 = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0 = New System.Windows.Forms.TextBox()
            Me.lblIdDetalleComprobanteRetencionCompra = New System.Windows.Forms.Label()
            Me.lblEstadoDetalleComprabanteRetencionCompra = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGenerarXML = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbParametrosBusqueda = New System.Windows.Forms.GroupBox()
            Me.rbCompras = New System.Windows.Forms.RadioButton()
            Me.rbCajaChica = New System.Windows.Forms.RadioButton()
            Me.rbFondoRotativo = New System.Windows.Forms.RadioButton()
            Me.gbRetencion.SuspendLayout()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbNombreComercialProveedor.SuspendLayout()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvPagosComprobanteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAsientoComprobanteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbDatosComprobanteCompra.SuspendLayout()
            Me.gbValoresComprobanteCompra.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.gbParametrosBusqueda.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbRetencion
            '
            Me.gbRetencion.BackColor = System.Drawing.Color.White
            Me.gbRetencion.Controls.Add(Me.dgvDetalleComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.Label1)
            Me.gbRetencion.Controls.Add(Me.cmbBienServicio)
            Me.gbRetencion.Controls.Add(Me.Label3)
            Me.gbRetencion.Controls.Add(Me.txtBaseImponible)
            Me.gbRetencion.Controls.Add(Me.Label7)
            Me.gbRetencion.Controls.Add(Me.Label5)
            Me.gbRetencion.Controls.Add(Me.txtValorRetencion)
            Me.gbRetencion.Controls.Add(Me.txtPorcentajeRetencion)
            Me.gbRetencion.Controls.Add(Me.lblContribuyente)
            Me.gbRetencion.Controls.Add(Me.cmbContribuyente)
            Me.gbRetencion.Controls.Add(Me.lblConcepto)
            Me.gbRetencion.Controls.Add(Me.cmbConcepto)
            Me.gbRetencion.Controls.Add(Me.lblImpuesto)
            Me.gbRetencion.Controls.Add(Me.cmbImpuesto)
            Me.gbRetencion.Controls.Add(Me.btnEliminarImpuesto)
            Me.gbRetencion.Controls.Add(Me.btnAgregarImpuesto)
            Me.gbRetencion.Controls.Add(Me.txtNumAutoSRIComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.Label12)
            Me.gbRetencion.Controls.Add(Me.lblIdComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.dtpComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.lblTotalRetencion)
            Me.gbRetencion.Controls.Add(Me.txtTotalComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.txtNumeroComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.lblNroRetencion)
            Me.gbRetencion.Controls.Add(Me.lblFechaRetencion)
            Me.gbRetencion.Enabled = False
            Me.gbRetencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRetencion.Location = New System.Drawing.Point(0, 457)
            Me.gbRetencion.Name = "gbRetencion"
            Me.gbRetencion.Size = New System.Drawing.Size(710, 230)
            Me.gbRetencion.TabIndex = 73
            Me.gbRetencion.TabStop = False
            Me.gbRetencion.Text = "RETENCIÓN"
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
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvDetalleComprobanteRetencion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EjercicioFiscal, Me.CodigoRetencion, Me.BaseImponible, Me.Impuesto, Me.PorcentajeRetencion, Me.ValorRetenido, Me.Column1, Me.Column2})
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDetalleComprobanteRetencion.DefaultCellStyle = DataGridViewCellStyle11
            Me.dgvDetalleComprobanteRetencion.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetalleComprobanteRetencion.Location = New System.Drawing.Point(3, 87)
            Me.dgvDetalleComprobanteRetencion.MultiSelect = False
            Me.dgvDetalleComprobanteRetencion.Name = "dgvDetalleComprobanteRetencion"
            Me.dgvDetalleComprobanteRetencion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobanteRetencion.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvDetalleComprobanteRetencion.RowHeadersVisible = False
            Me.dgvDetalleComprobanteRetencion.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvDetalleComprobanteRetencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobanteRetencion.Size = New System.Drawing.Size(704, 106)
            Me.dgvDetalleComprobanteRetencion.TabIndex = 109
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
            Me.BaseImponible.HeaderText = "BASE IMPONIBLE"
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
            Me.Impuesto.Width = 60
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
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(655, 45)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(31, 13)
            Me.Label1.TabIndex = 108
            Me.Label1.Text = "TIPO"
            '
            'cmbBienServicio
            '
            Me.cmbBienServicio.BackColor = System.Drawing.Color.White
            Me.cmbBienServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBienServicio.DropDownWidth = 100
            Me.cmbBienServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBienServicio.FormattingEnabled = True
            Me.cmbBienServicio.Items.AddRange(New Object() {"BIEN", "SERV."})
            Me.cmbBienServicio.Location = New System.Drawing.Point(653, 59)
            Me.cmbBienServicio.Name = "cmbBienServicio"
            Me.cmbBienServicio.Size = New System.Drawing.Size(56, 21)
            Me.cmbBienServicio.TabIndex = 107
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(475, 45)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(91, 13)
            Me.Label3.TabIndex = 106
            Me.Label3.Text = "BASE IMPONIBLE"
            '
            'txtBaseImponible
            '
            Me.txtBaseImponible.BackColor = System.Drawing.Color.White
            Me.txtBaseImponible.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBaseImponible.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBaseImponible.Location = New System.Drawing.Point(478, 60)
            Me.txtBaseImponible.Name = "txtBaseImponible"
            Me.txtBaseImponible.Size = New System.Drawing.Size(88, 20)
            Me.txtBaseImponible.TabIndex = 105
            Me.txtBaseImponible.Text = "0.00"
            Me.txtBaseImponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(567, 44)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(55, 13)
            Me.Label7.TabIndex = 104
            Me.Label7.Text = "RETENIDO"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(406, 44)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(67, 13)
            Me.Label5.TabIndex = 103
            Me.Label5.Text = "PORCENTAJE"
            '
            'txtValorRetencion
            '
            Me.txtValorRetencion.BackColor = System.Drawing.Color.White
            Me.txtValorRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorRetencion.Enabled = False
            Me.txtValorRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorRetencion.Location = New System.Drawing.Point(570, 60)
            Me.txtValorRetencion.Name = "txtValorRetencion"
            Me.txtValorRetencion.Size = New System.Drawing.Size(76, 20)
            Me.txtValorRetencion.TabIndex = 102
            Me.txtValorRetencion.Text = "0.00"
            Me.txtValorRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtPorcentajeRetencion
            '
            Me.txtPorcentajeRetencion.BackColor = System.Drawing.Color.White
            Me.txtPorcentajeRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPorcentajeRetencion.Enabled = False
            Me.txtPorcentajeRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPorcentajeRetencion.Location = New System.Drawing.Point(409, 60)
            Me.txtPorcentajeRetencion.Name = "txtPorcentajeRetencion"
            Me.txtPorcentajeRetencion.Size = New System.Drawing.Size(64, 20)
            Me.txtPorcentajeRetencion.TabIndex = 101
            Me.txtPorcentajeRetencion.Text = "0"
            Me.txtPorcentajeRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblContribuyente
            '
            Me.lblContribuyente.AutoSize = True
            Me.lblContribuyente.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblContribuyente.Location = New System.Drawing.Point(283, 44)
            Me.lblContribuyente.Name = "lblContribuyente"
            Me.lblContribuyente.Size = New System.Drawing.Size(91, 13)
            Me.lblContribuyente.TabIndex = 94
            Me.lblContribuyente.Text = "CONTRIBUYENTE:"
            '
            'cmbContribuyente
            '
            Me.cmbContribuyente.BackColor = System.Drawing.Color.White
            Me.cmbContribuyente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbContribuyente.DropDownWidth = 300
            Me.cmbContribuyente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbContribuyente.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbContribuyente.FormattingEnabled = True
            Me.cmbContribuyente.Location = New System.Drawing.Point(274, 60)
            Me.cmbContribuyente.Name = "cmbContribuyente"
            Me.cmbContribuyente.Size = New System.Drawing.Size(123, 21)
            Me.cmbContribuyente.TabIndex = 91
            '
            'lblConcepto
            '
            Me.lblConcepto.AutoSize = True
            Me.lblConcepto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblConcepto.Location = New System.Drawing.Point(137, 44)
            Me.lblConcepto.Name = "lblConcepto"
            Me.lblConcepto.Size = New System.Drawing.Size(61, 13)
            Me.lblConcepto.TabIndex = 93
            Me.lblConcepto.Text = "CONCEPTO:"
            '
            'cmbConcepto
            '
            Me.cmbConcepto.BackColor = System.Drawing.Color.White
            Me.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbConcepto.DropDownWidth = 600
            Me.cmbConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbConcepto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.Location = New System.Drawing.Point(133, 60)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(129, 21)
            Me.cmbConcepto.TabIndex = 90
            '
            'lblImpuesto
            '
            Me.lblImpuesto.AutoSize = True
            Me.lblImpuesto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblImpuesto.Location = New System.Drawing.Point(5, 44)
            Me.lblImpuesto.Name = "lblImpuesto"
            Me.lblImpuesto.Size = New System.Drawing.Size(61, 13)
            Me.lblImpuesto.TabIndex = 92
            Me.lblImpuesto.Text = "IMPUESTO:"
            '
            'cmbImpuesto
            '
            Me.cmbImpuesto.BackColor = System.Drawing.Color.White
            Me.cmbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbImpuesto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbImpuesto.FormattingEnabled = True
            Me.cmbImpuesto.Location = New System.Drawing.Point(5, 60)
            Me.cmbImpuesto.Name = "cmbImpuesto"
            Me.cmbImpuesto.Size = New System.Drawing.Size(117, 21)
            Me.cmbImpuesto.TabIndex = 89
            '
            'btnEliminarImpuesto
            '
            Me.btnEliminarImpuesto.BackColor = System.Drawing.Color.White
            Me.btnEliminarImpuesto.Image = CType(resources.GetObject("btnEliminarImpuesto.Image"), System.Drawing.Image)
            Me.btnEliminarImpuesto.Location = New System.Drawing.Point(672, 9)
            Me.btnEliminarImpuesto.Name = "btnEliminarImpuesto"
            Me.btnEliminarImpuesto.Size = New System.Drawing.Size(32, 28)
            Me.btnEliminarImpuesto.TabIndex = 87
            Me.btnEliminarImpuesto.UseVisualStyleBackColor = False
            '
            'btnAgregarImpuesto
            '
            Me.btnAgregarImpuesto.BackColor = System.Drawing.Color.White
            Me.btnAgregarImpuesto.Image = CType(resources.GetObject("btnAgregarImpuesto.Image"), System.Drawing.Image)
            Me.btnAgregarImpuesto.Location = New System.Drawing.Point(641, 9)
            Me.btnAgregarImpuesto.Name = "btnAgregarImpuesto"
            Me.btnAgregarImpuesto.Size = New System.Drawing.Size(32, 28)
            Me.btnAgregarImpuesto.TabIndex = 86
            Me.btnAgregarImpuesto.UseVisualStyleBackColor = False
            '
            'txtNumAutoSRIComprobanteRetencion
            '
            Me.txtNumAutoSRIComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtNumAutoSRIComprobanteRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumAutoSRIComprobanteRetencion.Enabled = False
            Me.txtNumAutoSRIComprobanteRetencion.Location = New System.Drawing.Point(79, 14)
            Me.txtNumAutoSRIComprobanteRetencion.Name = "txtNumAutoSRIComprobanteRetencion"
            Me.txtNumAutoSRIComprobanteRetencion.Size = New System.Drawing.Size(117, 20)
            Me.txtNumAutoSRIComprobanteRetencion.TabIndex = 85
            Me.txtNumAutoSRIComprobanteRetencion.Text = "1113541356"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(8, 18)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(73, 13)
            Me.Label12.TabIndex = 84
            Me.Label12.Text = "# AUTO SRI:"
            '
            'lblIdComprobanteRetencion
            '
            Me.lblIdComprobanteRetencion.AutoSize = True
            Me.lblIdComprobanteRetencion.Enabled = False
            Me.lblIdComprobanteRetencion.Location = New System.Drawing.Point(80, 0)
            Me.lblIdComprobanteRetencion.Name = "lblIdComprobanteRetencion"
            Me.lblIdComprobanteRetencion.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteRetencion.TabIndex = 69
            Me.lblIdComprobanteRetencion.Text = "..."
            '
            'dtpComprobanteRetencion
            '
            Me.dtpComprobanteRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpComprobanteRetencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpComprobanteRetencion.Location = New System.Drawing.Point(484, 15)
            Me.dtpComprobanteRetencion.Name = "dtpComprobanteRetencion"
            Me.dtpComprobanteRetencion.Size = New System.Drawing.Size(147, 20)
            Me.dtpComprobanteRetencion.TabIndex = 23
            '
            'lblTotalRetencion
            '
            Me.lblTotalRetencion.AutoSize = True
            Me.lblTotalRetencion.Location = New System.Drawing.Point(503, 204)
            Me.lblTotalRetencion.Name = "lblTotalRetencion"
            Me.lblTotalRetencion.Size = New System.Drawing.Size(111, 13)
            Me.lblTotalRetencion.TabIndex = 44
            Me.lblTotalRetencion.Text = "TOTAL RETENCIÓN:"
            '
            'txtTotalComprobanteRetencion
            '
            Me.txtTotalComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteRetencion.Enabled = False
            Me.txtTotalComprobanteRetencion.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobanteRetencion.Location = New System.Drawing.Point(620, 199)
            Me.txtTotalComprobanteRetencion.Name = "txtTotalComprobanteRetencion"
            Me.txtTotalComprobanteRetencion.Size = New System.Drawing.Size(84, 22)
            Me.txtTotalComprobanteRetencion.TabIndex = 43
            Me.txtTotalComprobanteRetencion.Text = "0.00"
            Me.txtTotalComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNumeroComprobanteRetencion
            '
            Me.txtNumeroComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroComprobanteRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroComprobanteRetencion.Location = New System.Drawing.Point(279, 15)
            Me.txtNumeroComprobanteRetencion.Name = "txtNumeroComprobanteRetencion"
            Me.txtNumeroComprobanteRetencion.Size = New System.Drawing.Size(136, 20)
            Me.txtNumeroComprobanteRetencion.TabIndex = 22
            '
            'lblNroRetencion
            '
            Me.lblNroRetencion.AutoSize = True
            Me.lblNroRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroRetencion.Location = New System.Drawing.Point(220, 17)
            Me.lblNroRetencion.Name = "lblNroRetencion"
            Me.lblNroRetencion.Size = New System.Drawing.Size(61, 13)
            Me.lblNroRetencion.TabIndex = 28
            Me.lblNroRetencion.Text = "NRO RET.:"
            '
            'lblFechaRetencion
            '
            Me.lblFechaRetencion.AutoSize = True
            Me.lblFechaRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaRetencion.Location = New System.Drawing.Point(441, 18)
            Me.lblFechaRetencion.Name = "lblFechaRetencion"
            Me.lblFechaRetencion.Size = New System.Drawing.Size(43, 13)
            Me.lblFechaRetencion.TabIndex = 46
            Me.lblFechaRetencion.Text = "FECHA:"
            '
            'gbNombreComercialProveedor
            '
            Me.gbNombreComercialProveedor.BackColor = System.Drawing.Color.White
            Me.gbNombreComercialProveedor.Controls.Add(Me.dtpMes)
            Me.gbNombreComercialProveedor.Controls.Add(Me.Label14)
            Me.gbNombreComercialProveedor.Controls.Add(Me.EsContrbuyenteEspecial)
            Me.gbNombreComercialProveedor.Controls.Add(Me.Label9)
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblRucProveedorGeneral)
            Me.gbNombreComercialProveedor.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblIdProveedorGeneral)
            Me.gbNombreComercialProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNombreComercialProveedor.Location = New System.Drawing.Point(0, 29)
            Me.gbNombreComercialProveedor.Name = "gbNombreComercialProveedor"
            Me.gbNombreComercialProveedor.Size = New System.Drawing.Size(710, 42)
            Me.gbNombreComercialProveedor.TabIndex = 94
            Me.gbNombreComercialProveedor.TabStop = False
            Me.gbNombreComercialProveedor.Text = "PROVEEDOR"
            '
            'dtpMes
            '
            Me.dtpMes.CustomFormat = "MMM yyyy"
            Me.dtpMes.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpMes.Location = New System.Drawing.Point(611, 16)
            Me.dtpMes.Name = "dtpMes"
            Me.dtpMes.ShowUpDown = True
            Me.dtpMes.Size = New System.Drawing.Size(93, 20)
            Me.dtpMes.TabIndex = 104
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(581, 20)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(33, 13)
            Me.Label14.TabIndex = 103
            Me.Label14.Text = "MES:"
            '
            'EsContrbuyenteEspecial
            '
            Me.EsContrbuyenteEspecial.AutoSize = True
            Me.EsContrbuyenteEspecial.Location = New System.Drawing.Point(317, 0)
            Me.EsContrbuyenteEspecial.Name = "EsContrbuyenteEspecial"
            Me.EsContrbuyenteEspecial.Size = New System.Drawing.Size(16, 13)
            Me.EsContrbuyenteEspecial.TabIndex = 79
            Me.EsContrbuyenteEspecial.Text = "..."
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(152, -1)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(33, 13)
            Me.Label9.TabIndex = 78
            Me.Label9.Text = "RUC:"
            '
            'lblRucProveedorGeneral
            '
            Me.lblRucProveedorGeneral.AutoSize = True
            Me.lblRucProveedorGeneral.Location = New System.Drawing.Point(189, -1)
            Me.lblRucProveedorGeneral.Name = "lblRucProveedorGeneral"
            Me.lblRucProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblRucProveedorGeneral.TabIndex = 77
            Me.lblRucProveedorGeneral.Text = "..."
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(9, 16)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(559, 20)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 2
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(87, -1)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 76
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'dgvComprobanteRetencion
            '
            Me.dgvComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvComprobanteRetencion.AllowUserToDeleteRows = False
            Me.dgvComprobanteRetencion.AllowUserToResizeColumns = False
            Me.dgvComprobanteRetencion.AllowUserToResizeRows = False
            Me.dgvComprobanteRetencion.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteRetencion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteRetencion.DefaultCellStyle = DataGridViewCellStyle14
            Me.dgvComprobanteRetencion.Location = New System.Drawing.Point(208, 267)
            Me.dgvComprobanteRetencion.MultiSelect = False
            Me.dgvComprobanteRetencion.Name = "dgvComprobanteRetencion"
            Me.dgvComprobanteRetencion.ReadOnly = True
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteRetencion.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvComprobanteRetencion.RowHeadersVisible = False
            Me.dgvComprobanteRetencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteRetencion.Size = New System.Drawing.Size(441, 86)
            Me.dgvComprobanteRetencion.TabIndex = 95
            Me.dgvComprobanteRetencion.Visible = False
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.lblEstadoComprobanteCompra)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.lblIdComprobanteCompra)
            Me.GroupBox1.Controls.Add(Me.dgvComprobantesCompra)
            Me.GroupBox1.Controls.Add(Me.dgvComprobanteRetencion)
            Me.GroupBox1.Controls.Add(Me.dgvPagosComprobanteCompra)
            Me.GroupBox1.Controls.Add(Me.dgvAsientoComprobanteCompra)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(0, 72)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(710, 290)
            Me.GroupBox1.TabIndex = 96
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "COMPROBANTES DE COMPRA"
            '
            'lblEstadoComprobanteCompra
            '
            Me.lblEstadoComprobanteCompra.AutoSize = True
            Me.lblEstadoComprobanteCompra.Location = New System.Drawing.Point(245, 0)
            Me.lblEstadoComprobanteCompra.Name = "lblEstadoComprobanteCompra"
            Me.lblEstadoComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblEstadoComprobanteCompra.TabIndex = 94
            Me.lblEstadoComprobanteCompra.Text = "..."
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(226, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(12, 13)
            Me.Label6.TabIndex = 93
            Me.Label6.Text = "/"
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(183, 0)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteCompra.TabIndex = 29
            Me.lblIdComprobanteCompra.Text = "..."
            '
            'dgvComprobantesCompra
            '
            Me.dgvComprobantesCompra.AllowUserToAddRows = False
            Me.dgvComprobantesCompra.AllowUserToDeleteRows = False
            Me.dgvComprobantesCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
            Me.dgvComprobantesCompra.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle17
            Me.dgvComprobantesCompra.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvComprobantesCompra.Location = New System.Drawing.Point(3, 16)
            Me.dgvComprobantesCompra.MultiSelect = False
            Me.dgvComprobantesCompra.Name = "dgvComprobantesCompra"
            Me.dgvComprobantesCompra.ReadOnly = True
            Me.dgvComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle18
            Me.dgvComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesCompra.Size = New System.Drawing.Size(704, 271)
            Me.dgvComprobantesCompra.TabIndex = 86
            '
            'dgvPagosComprobanteCompra
            '
            Me.dgvPagosComprobanteCompra.AllowUserToAddRows = False
            Me.dgvPagosComprobanteCompra.AllowUserToDeleteRows = False
            Me.dgvPagosComprobanteCompra.AllowUserToResizeColumns = False
            Me.dgvPagosComprobanteCompra.AllowUserToResizeRows = False
            Me.dgvPagosComprobanteCompra.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPagosComprobanteCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
            Me.dgvPagosComprobanteCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPagosComprobanteCompra.DefaultCellStyle = DataGridViewCellStyle20
            Me.dgvPagosComprobanteCompra.Location = New System.Drawing.Point(206, 19)
            Me.dgvPagosComprobanteCompra.MultiSelect = False
            Me.dgvPagosComprobanteCompra.Name = "dgvPagosComprobanteCompra"
            Me.dgvPagosComprobanteCompra.ReadOnly = True
            DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPagosComprobanteCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
            Me.dgvPagosComprobanteCompra.RowHeadersVisible = False
            Me.dgvPagosComprobanteCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPagosComprobanteCompra.Size = New System.Drawing.Size(441, 86)
            Me.dgvPagosComprobanteCompra.TabIndex = 190
            Me.dgvPagosComprobanteCompra.Visible = False
            '
            'dgvAsientoComprobanteCompra
            '
            Me.dgvAsientoComprobanteCompra.AllowUserToAddRows = False
            Me.dgvAsientoComprobanteCompra.AllowUserToDeleteRows = False
            Me.dgvAsientoComprobanteCompra.AllowUserToResizeColumns = False
            Me.dgvAsientoComprobanteCompra.AllowUserToResizeRows = False
            Me.dgvAsientoComprobanteCompra.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientoComprobanteCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
            Me.dgvAsientoComprobanteCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientoComprobanteCompra.DefaultCellStyle = DataGridViewCellStyle23
            Me.dgvAsientoComprobanteCompra.Location = New System.Drawing.Point(206, 111)
            Me.dgvAsientoComprobanteCompra.MultiSelect = False
            Me.dgvAsientoComprobanteCompra.Name = "dgvAsientoComprobanteCompra"
            Me.dgvAsientoComprobanteCompra.ReadOnly = True
            DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientoComprobanteCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
            Me.dgvAsientoComprobanteCompra.RowHeadersVisible = False
            Me.dgvAsientoComprobanteCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientoComprobanteCompra.Size = New System.Drawing.Size(441, 147)
            Me.dgvAsientoComprobanteCompra.TabIndex = 191
            Me.dgvAsientoComprobanteCompra.Visible = False
            '
            'gbDatosComprobanteCompra
            '
            Me.gbDatosComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label19)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.rbPtoEmision002)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.rbPtoEmision001)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.dtpFechaEmisionComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblTipoComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblFechaComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblNumeroComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label27)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label28)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label30)
            Me.gbDatosComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatosComprobanteCompra.Location = New System.Drawing.Point(0, 364)
            Me.gbDatosComprobanteCompra.Name = "gbDatosComprobanteCompra"
            Me.gbDatosComprobanteCompra.Size = New System.Drawing.Size(208, 90)
            Me.gbDatosComprobanteCompra.TabIndex = 93
            Me.gbDatosComprobanteCompra.TabStop = False
            Me.gbDatosComprobanteCompra.Text = "Datos"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label19.Location = New System.Drawing.Point(13, 14)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(79, 13)
            Me.Label19.TabIndex = 29
            Me.Label19.Text = "PTO EMISIÓN:"
            '
            'rbPtoEmision002
            '
            Me.rbPtoEmision002.AutoSize = True
            Me.rbPtoEmision002.Checked = True
            Me.rbPtoEmision002.Enabled = False
            Me.rbPtoEmision002.Location = New System.Drawing.Point(150, 14)
            Me.rbPtoEmision002.Name = "rbPtoEmision002"
            Me.rbPtoEmision002.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision002.TabIndex = 28
            Me.rbPtoEmision002.TabStop = True
            Me.rbPtoEmision002.Text = "002"
            Me.rbPtoEmision002.UseVisualStyleBackColor = True
            '
            'rbPtoEmision001
            '
            Me.rbPtoEmision001.AutoSize = True
            Me.rbPtoEmision001.Enabled = False
            Me.rbPtoEmision001.Location = New System.Drawing.Point(107, 14)
            Me.rbPtoEmision001.Name = "rbPtoEmision001"
            Me.rbPtoEmision001.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision001.TabIndex = 27
            Me.rbPtoEmision001.Text = "001"
            Me.rbPtoEmision001.UseVisualStyleBackColor = True
            '
            'dtpFechaEmisionComprobanteCompra
            '
            Me.dtpFechaEmisionComprobanteCompra.Enabled = False
            Me.dtpFechaEmisionComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionComprobanteCompra.Location = New System.Drawing.Point(64, 49)
            Me.dtpFechaEmisionComprobanteCompra.Name = "dtpFechaEmisionComprobanteCompra"
            Me.dtpFechaEmisionComprobanteCompra.Size = New System.Drawing.Size(135, 20)
            Me.dtpFechaEmisionComprobanteCompra.TabIndex = 26
            '
            'lblTipoComprobanteCompra
            '
            Me.lblTipoComprobanteCompra.AutoSize = True
            Me.lblTipoComprobanteCompra.Location = New System.Drawing.Point(61, 72)
            Me.lblTipoComprobanteCompra.Name = "lblTipoComprobanteCompra"
            Me.lblTipoComprobanteCompra.Size = New System.Drawing.Size(25, 13)
            Me.lblTipoComprobanteCompra.TabIndex = 25
            Me.lblTipoComprobanteCompra.Text = "..."
            Me.lblTipoComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblFechaComprobanteCompra
            '
            Me.lblFechaComprobanteCompra.AutoSize = True
            Me.lblFechaComprobanteCompra.Location = New System.Drawing.Point(61, 51)
            Me.lblFechaComprobanteCompra.Name = "lblFechaComprobanteCompra"
            Me.lblFechaComprobanteCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblFechaComprobanteCompra.TabIndex = 23
            Me.lblFechaComprobanteCompra.Text = "00/00/0000"
            Me.lblFechaComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNumeroComprobanteCompra
            '
            Me.lblNumeroComprobanteCompra.AutoSize = True
            Me.lblNumeroComprobanteCompra.Location = New System.Drawing.Point(61, 33)
            Me.lblNumeroComprobanteCompra.Name = "lblNumeroComprobanteCompra"
            Me.lblNumeroComprobanteCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroComprobanteCompra.TabIndex = 21
            Me.lblNumeroComprobanteCompra.Text = "0"
            Me.lblNumeroComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label27.Location = New System.Drawing.Point(12, 72)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(37, 13)
            Me.Label27.TabIndex = 13
            Me.Label27.Text = "Tipo:"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.Location = New System.Drawing.Point(12, 51)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(43, 13)
            Me.Label28.TabIndex = 12
            Me.Label28.Text = "Fecha:"
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(12, 33)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(31, 13)
            Me.Label30.TabIndex = 10
            Me.Label30.Text = "Nro:"
            '
            'gbValoresComprobanteCompra
            '
            Me.gbValoresComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtTotalComprobanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubTotal)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblTotalOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtIvaComprobanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblIvaOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblDescuentoOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotalComprobanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal0OrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtDescuento)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal12OrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal12)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal0)
            Me.gbValoresComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbValoresComprobanteCompra.Location = New System.Drawing.Point(214, 364)
            Me.gbValoresComprobanteCompra.Name = "gbValoresComprobanteCompra"
            Me.gbValoresComprobanteCompra.Size = New System.Drawing.Size(382, 90)
            Me.gbValoresComprobanteCompra.TabIndex = 92
            Me.gbValoresComprobanteCompra.TabStop = False
            Me.gbValoresComprobanteCompra.Text = "Valores"
            '
            'txtTotalComprobanteCompra
            '
            Me.txtTotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteCompra.Enabled = False
            Me.txtTotalComprobanteCompra.Location = New System.Drawing.Point(289, 64)
            Me.txtTotalComprobanteCompra.Name = "txtTotalComprobanteCompra"
            Me.txtTotalComprobanteCompra.Size = New System.Drawing.Size(59, 20)
            Me.txtTotalComprobanteCompra.TabIndex = 32
            Me.txtTotalComprobanteCompra.Text = "0.00"
            Me.txtTotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubTotal
            '
            Me.lblSubTotal.AutoSize = True
            Me.lblSubTotal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotal.Location = New System.Drawing.Point(216, 21)
            Me.lblSubTotal.Name = "lblSubTotal"
            Me.lblSubTotal.Size = New System.Drawing.Size(67, 13)
            Me.lblSubTotal.TabIndex = 20
            Me.lblSubTotal.Text = "SUB TOTAL:"
            '
            'lblTotalOrdenCompra
            '
            Me.lblTotalOrdenCompra.AutoSize = True
            Me.lblTotalOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalOrdenCompra.Location = New System.Drawing.Point(216, 65)
            Me.lblTotalOrdenCompra.Name = "lblTotalOrdenCompra"
            Me.lblTotalOrdenCompra.Size = New System.Drawing.Size(43, 13)
            Me.lblTotalOrdenCompra.TabIndex = 14
            Me.lblTotalOrdenCompra.Text = "TOTAL:"
            '
            'txtIvaComprobanteCompra
            '
            Me.txtIvaComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtIvaComprobanteCompra.Enabled = False
            Me.txtIvaComprobanteCompra.Location = New System.Drawing.Point(289, 42)
            Me.txtIvaComprobanteCompra.Name = "txtIvaComprobanteCompra"
            Me.txtIvaComprobanteCompra.Size = New System.Drawing.Size(59, 20)
            Me.txtIvaComprobanteCompra.TabIndex = 31
            Me.txtIvaComprobanteCompra.Text = "0.00"
            Me.txtIvaComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIvaOrdenCompra
            '
            Me.lblIvaOrdenCompra.AutoSize = True
            Me.lblIvaOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIvaOrdenCompra.Location = New System.Drawing.Point(216, 43)
            Me.lblIvaOrdenCompra.Name = "lblIvaOrdenCompra"
            Me.lblIvaOrdenCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblIvaOrdenCompra.TabIndex = 13
            Me.lblIvaOrdenCompra.Text = "IVA (12%):"
            '
            'lblDescuentoOrdenCompra
            '
            Me.lblDescuentoOrdenCompra.AutoSize = True
            Me.lblDescuentoOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescuentoOrdenCompra.Location = New System.Drawing.Point(23, 66)
            Me.lblDescuentoOrdenCompra.Name = "lblDescuentoOrdenCompra"
            Me.lblDescuentoOrdenCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblDescuentoOrdenCompra.TabIndex = 12
            Me.lblDescuentoOrdenCompra.Text = "DESCUENTO:"
            '
            'txtSubtotalComprobanteCompra
            '
            Me.txtSubtotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotalComprobanteCompra.Enabled = False
            Me.txtSubtotalComprobanteCompra.Location = New System.Drawing.Point(289, 19)
            Me.txtSubtotalComprobanteCompra.Name = "txtSubtotalComprobanteCompra"
            Me.txtSubtotalComprobanteCompra.Size = New System.Drawing.Size(59, 20)
            Me.txtSubtotalComprobanteCompra.TabIndex = 30
            Me.txtSubtotalComprobanteCompra.Text = "0.00"
            Me.txtSubtotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal0OrdenCompra
            '
            Me.lblSubtotal0OrdenCompra.AutoSize = True
            Me.lblSubtotal0OrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal0OrdenCompra.Location = New System.Drawing.Point(23, 44)
            Me.lblSubtotal0OrdenCompra.Name = "lblSubtotal0OrdenCompra"
            Me.lblSubtotal0OrdenCompra.Size = New System.Drawing.Size(79, 13)
            Me.lblSubtotal0OrdenCompra.TabIndex = 11
            Me.lblSubtotal0OrdenCompra.Text = "SUB TOTAL 0:"
            '
            'txtDescuento
            '
            Me.txtDescuento.BackColor = System.Drawing.Color.White
            Me.txtDescuento.Enabled = False
            Me.txtDescuento.Location = New System.Drawing.Point(119, 64)
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.Size = New System.Drawing.Size(59, 20)
            Me.txtDescuento.TabIndex = 29
            Me.txtDescuento.Text = "0.00"
            Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal12OrdenCompra
            '
            Me.lblSubtotal12OrdenCompra.AutoSize = True
            Me.lblSubtotal12OrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal12OrdenCompra.Location = New System.Drawing.Point(23, 21)
            Me.lblSubtotal12OrdenCompra.Name = "lblSubtotal12OrdenCompra"
            Me.lblSubtotal12OrdenCompra.Size = New System.Drawing.Size(85, 13)
            Me.lblSubtotal12OrdenCompra.TabIndex = 10
            Me.lblSubtotal12OrdenCompra.Text = "SUB TOTAL 12:"
            '
            'txtSubtotal12
            '
            Me.txtSubtotal12.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12.Enabled = False
            Me.txtSubtotal12.Location = New System.Drawing.Point(119, 19)
            Me.txtSubtotal12.Name = "txtSubtotal12"
            Me.txtSubtotal12.Size = New System.Drawing.Size(59, 20)
            Me.txtSubtotal12.TabIndex = 27
            Me.txtSubtotal12.Text = "0.00"
            Me.txtSubtotal12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0
            '
            Me.txtSubtotal0.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0.Enabled = False
            Me.txtSubtotal0.Location = New System.Drawing.Point(119, 42)
            Me.txtSubtotal0.Name = "txtSubtotal0"
            Me.txtSubtotal0.Size = New System.Drawing.Size(59, 20)
            Me.txtSubtotal0.TabIndex = 28
            Me.txtSubtotal0.Text = "0.00"
            Me.txtSubtotal0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIdDetalleComprobanteRetencionCompra
            '
            Me.lblIdDetalleComprobanteRetencionCompra.AutoSize = True
            Me.lblIdDetalleComprobanteRetencionCompra.Location = New System.Drawing.Point(32, 62)
            Me.lblIdDetalleComprobanteRetencionCompra.Name = "lblIdDetalleComprobanteRetencionCompra"
            Me.lblIdDetalleComprobanteRetencionCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblIdDetalleComprobanteRetencionCompra.TabIndex = 78
            Me.lblIdDetalleComprobanteRetencionCompra.Text = "0"
            Me.lblIdDetalleComprobanteRetencionCompra.Visible = False
            '
            'lblEstadoDetalleComprabanteRetencionCompra
            '
            Me.lblEstadoDetalleComprabanteRetencionCompra.AutoSize = True
            Me.lblEstadoDetalleComprabanteRetencionCompra.Location = New System.Drawing.Point(65, 62)
            Me.lblEstadoDetalleComprabanteRetencionCompra.Name = "lblEstadoDetalleComprabanteRetencionCompra"
            Me.lblEstadoDetalleComprabanteRetencionCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblEstadoDetalleComprabanteRetencionCompra.TabIndex = 97
            Me.lblEstadoDetalleComprabanteRetencionCompra.Text = "0"
            Me.lblEstadoDetalleComprabanteRetencionCompra.Visible = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar, Me.btnGenerarXML})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(710, 24)
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
            'btnGenerarXML
            '
            Me.btnGenerarXML.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGenerarXML.Image = Global.syscisepro.My.Resources.Resources.generate_tables_icon
            Me.btnGenerarXML.Name = "btnGenerarXML"
            Me.btnGenerarXML.Size = New System.Drawing.Size(108, 20)
            Me.btnGenerarXML.Text = "GENERAR XML"
            '
            'gbParametrosBusqueda
            '
            Me.gbParametrosBusqueda.BackColor = System.Drawing.Color.White
            Me.gbParametrosBusqueda.Controls.Add(Me.rbCompras)
            Me.gbParametrosBusqueda.Controls.Add(Me.rbCajaChica)
            Me.gbParametrosBusqueda.Controls.Add(Me.rbFondoRotativo)
            Me.gbParametrosBusqueda.Controls.Add(Me.lblEstadoDetalleComprabanteRetencionCompra)
            Me.gbParametrosBusqueda.Controls.Add(Me.lblIdDetalleComprobanteRetencionCompra)
            Me.gbParametrosBusqueda.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbParametrosBusqueda.Location = New System.Drawing.Point(602, 364)
            Me.gbParametrosBusqueda.Name = "gbParametrosBusqueda"
            Me.gbParametrosBusqueda.Size = New System.Drawing.Size(107, 90)
            Me.gbParametrosBusqueda.TabIndex = 189
            Me.gbParametrosBusqueda.TabStop = False
            Me.gbParametrosBusqueda.Text = "COMP INGRESO"
            '
            'rbCompras
            '
            Me.rbCompras.AutoSize = True
            Me.rbCompras.Checked = True
            Me.rbCompras.Enabled = False
            Me.rbCompras.Location = New System.Drawing.Point(15, 59)
            Me.rbCompras.Name = "rbCompras"
            Me.rbCompras.Size = New System.Drawing.Size(67, 17)
            Me.rbCompras.TabIndex = 2
            Me.rbCompras.TabStop = True
            Me.rbCompras.Text = "COMPRAS"
            Me.rbCompras.UseVisualStyleBackColor = True
            '
            'rbCajaChica
            '
            Me.rbCajaChica.AutoSize = True
            Me.rbCajaChica.Enabled = False
            Me.rbCajaChica.Location = New System.Drawing.Point(15, 42)
            Me.rbCajaChica.Name = "rbCajaChica"
            Me.rbCajaChica.Size = New System.Drawing.Size(49, 17)
            Me.rbCajaChica.TabIndex = 1
            Me.rbCajaChica.TabStop = True
            Me.rbCajaChica.Text = "CAJA"
            Me.rbCajaChica.UseVisualStyleBackColor = True
            '
            'rbFondoRotativo
            '
            Me.rbFondoRotativo.AutoSize = True
            Me.rbFondoRotativo.Enabled = False
            Me.rbFondoRotativo.Location = New System.Drawing.Point(15, 24)
            Me.rbFondoRotativo.Name = "rbFondoRotativo"
            Me.rbFondoRotativo.Size = New System.Drawing.Size(55, 17)
            Me.rbFondoRotativo.TabIndex = 0
            Me.rbFondoRotativo.TabStop = True
            Me.rbFondoRotativo.Text = "FONDO"
            Me.rbFondoRotativo.UseVisualStyleBackColor = True
            '
            'FormComprobantesRetencionCompras
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(710, 690)
            Me.Controls.Add(Me.gbParametrosBusqueda)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbRetencion)
            Me.Controls.Add(Me.gbDatosComprobanteCompra)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbValoresComprobanteCompra)
            Me.Controls.Add(Me.gbNombreComercialProveedor)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormComprobantesRetencionCompras"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AJUSTAR COMPROBANTES DE RETENCIÓN COMPRAS"
            Me.gbRetencion.ResumeLayout(False)
            Me.gbRetencion.PerformLayout()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbNombreComercialProveedor.ResumeLayout(False)
            Me.gbNombreComercialProveedor.PerformLayout()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvPagosComprobanteCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAsientoComprobanteCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbDatosComprobanteCompra.ResumeLayout(False)
            Me.gbDatosComprobanteCompra.PerformLayout()
            Me.gbValoresComprobanteCompra.ResumeLayout(False)
            Me.gbValoresComprobanteCompra.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.gbParametrosBusqueda.ResumeLayout(False)
            Me.gbParametrosBusqueda.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbRetencion As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdComprobanteRetencion As System.Windows.Forms.Label
        Friend WithEvents lblTotalRetencion As System.Windows.Forms.Label
        Friend WithEvents txtTotalComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents gbNombreComercialProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents dgvComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblEstadoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents dgvComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents gbDatosComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents lblTipoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblFechaComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblNumeroComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents gbValoresComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblSubTotal As System.Windows.Forms.Label
        Friend WithEvents lblTotalOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtIvaComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblIvaOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblDescuentoOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtSubtotalComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblSubtotal0OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
        Friend WithEvents lblSubtotal12OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal12 As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0 As System.Windows.Forms.TextBox
        Friend WithEvents dtpComprobanteRetencion As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblFechaRetencion As System.Windows.Forms.Label
        Friend WithEvents lblNroRetencion As System.Windows.Forms.Label
        Friend WithEvents txtNumeroComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents lblIdDetalleComprobanteRetencionCompra As System.Windows.Forms.Label
        Friend WithEvents lblEstadoDetalleComprabanteRetencionCompra As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents lblRucProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents dtpFechaEmisionComprobanteCompra As System.Windows.Forms.DateTimePicker
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGenerarXML As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EsContrbuyenteEspecial As System.Windows.Forms.Label
        Friend WithEvents txtNumAutoSRIComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpMes As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents gbParametrosBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents rbCompras As System.Windows.Forms.RadioButton
        Friend WithEvents rbCajaChica As System.Windows.Forms.RadioButton
        Friend WithEvents rbFondoRotativo As System.Windows.Forms.RadioButton
        Friend WithEvents btnEliminarImpuesto As System.Windows.Forms.Button
        Friend WithEvents btnAgregarImpuesto As System.Windows.Forms.Button
        Friend WithEvents lblContribuyente As System.Windows.Forms.Label
        Friend WithEvents cmbContribuyente As System.Windows.Forms.ComboBox
        Friend WithEvents lblConcepto As System.Windows.Forms.Label
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents lblImpuesto As System.Windows.Forms.Label
        Friend WithEvents cmbImpuesto As System.Windows.Forms.ComboBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtValorRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtPorcentajeRetencion As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtBaseImponible As System.Windows.Forms.TextBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents rbPtoEmision002 As System.Windows.Forms.RadioButton
        Friend WithEvents rbPtoEmision001 As System.Windows.Forms.RadioButton
        Friend WithEvents dgvPagosComprobanteCompra As System.Windows.Forms.DataGridView
        Friend WithEvents dgvAsientoComprobanteCompra As System.Windows.Forms.DataGridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cmbBienServicio As System.Windows.Forms.ComboBox
        Friend WithEvents dgvDetalleComprobanteRetencion As System.Windows.Forms.DataGridView
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