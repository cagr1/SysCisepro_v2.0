Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormComprobantesRetencionCompras
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
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComprobantesRetencionCompras))
            Me.dgvDetalleComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.EjercicioFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CodigoRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.BaseImponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PorcentajeRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ValorRetenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cmbBienServicio = New System.Windows.Forms.ComboBox()
            Me.txtBaseImponible = New System.Windows.Forms.TextBox()
            Me.txtValorRetencion = New System.Windows.Forms.TextBox()
            Me.txtPorcentajeRetencion = New System.Windows.Forms.TextBox()
            Me.cmbContribuyente = New System.Windows.Forms.ComboBox()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.cmbImpuesto = New System.Windows.Forms.ComboBox()
            Me.btnEliminarImpuesto = New System.Windows.Forms.Button()
            Me.btnAgregarImpuesto = New System.Windows.Forms.Button()
            Me.txtNumAutoSRIComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.dtpComprobanteRetencion = New System.Windows.Forms.DateTimePicker()
            Me.txtTotalComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.txtNumeroComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.dtpMes = New System.Windows.Forms.DateTimePicker()
            Me.EsContrbuyenteEspecial = New System.Windows.Forms.Label()
            Me.lblRucProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.lblEstadoComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.dgvComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.dgvPagosComprobanteCompra = New System.Windows.Forms.DataGridView()
            Me.dgvAsientoComprobanteCompra = New System.Windows.Forms.DataGridView()
            Me.rbPtoEmision002 = New System.Windows.Forms.RadioButton()
            Me.rbPtoEmision001 = New System.Windows.Forms.RadioButton()
            Me.dtpFechaEmisionComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.lblTipoComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblFechaComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblNumeroComprobanteCompra = New System.Windows.Forms.Label()
            Me.txtTotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtIvaComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtDescuento = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12 = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0 = New System.Windows.Forms.TextBox()
            Me.lblIdDetalleComprobanteRetencionCompra = New System.Windows.Forms.Label()
            Me.lblEstadoDetalleComprabanteRetencionCompra = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGenerarXML = New System.Windows.Forms.ToolStripMenuItem()
            Me.rbCompras = New System.Windows.Forms.RadioButton()
            Me.rbCajaChica = New System.Windows.Forms.RadioButton()
            Me.rbFondoRotativo = New System.Windows.Forms.RadioButton()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.dgvComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox4 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel17 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel18 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel19 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel20 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel21 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel22 = New Krypton.Toolkit.KryptonLabel()
            Me.lblIdComprobanteRetencion = New System.Windows.Forms.Label()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvPagosComprobanteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAsientoComprobanteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox4.Panel.SuspendLayout()
            Me.KryptonGroupBox4.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvDetalleComprobanteRetencion
            '
            Me.dgvDetalleComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencion.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobanteRetencion.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvDetalleComprobanteRetencion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDetalleComprobanteRetencion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvDetalleComprobanteRetencion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleComprobanteRetencion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvDetalleComprobanteRetencion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EjercicioFiscal, Me.CodigoRetencion, Me.BaseImponible, Me.Impuesto, Me.PorcentajeRetencion, Me.ValorRetenido, Me.Column1, Me.Column2})
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDetalleComprobanteRetencion.DefaultCellStyle = DataGridViewCellStyle11
            Me.dgvDetalleComprobanteRetencion.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetalleComprobanteRetencion.Location = New System.Drawing.Point(5, 87)
            Me.dgvDetalleComprobanteRetencion.MultiSelect = False
            Me.dgvDetalleComprobanteRetencion.Name = "dgvDetalleComprobanteRetencion"
            Me.dgvDetalleComprobanteRetencion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobanteRetencion.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvDetalleComprobanteRetencion.RowHeadersVisible = False
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvDetalleComprobanteRetencion.RowsDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvDetalleComprobanteRetencion.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvDetalleComprobanteRetencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobanteRetencion.Size = New System.Drawing.Size(652, 106)
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
            'cmbBienServicio
            '
            Me.cmbBienServicio.BackColor = System.Drawing.Color.White
            Me.cmbBienServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBienServicio.DropDownWidth = 100
            Me.cmbBienServicio.Enabled = False
            Me.cmbBienServicio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBienServicio.FormattingEnabled = True
            Me.cmbBienServicio.Items.AddRange(New Object() {"BIEN", "SERV."})
            Me.cmbBienServicio.Location = New System.Drawing.Point(578, 60)
            Me.cmbBienServicio.Name = "cmbBienServicio"
            Me.cmbBienServicio.Size = New System.Drawing.Size(79, 21)
            Me.cmbBienServicio.TabIndex = 107
            '
            'txtBaseImponible
            '
            Me.txtBaseImponible.BackColor = System.Drawing.Color.White
            Me.txtBaseImponible.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBaseImponible.Enabled = False
            Me.txtBaseImponible.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBaseImponible.Location = New System.Drawing.Point(264, 61)
            Me.txtBaseImponible.Name = "txtBaseImponible"
            Me.txtBaseImponible.Size = New System.Drawing.Size(88, 21)
            Me.txtBaseImponible.TabIndex = 105
            Me.txtBaseImponible.Text = "0.00"
            Me.txtBaseImponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtValorRetencion
            '
            Me.txtValorRetencion.BackColor = System.Drawing.Color.White
            Me.txtValorRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorRetencion.Enabled = False
            Me.txtValorRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorRetencion.Location = New System.Drawing.Point(442, 61)
            Me.txtValorRetencion.Name = "txtValorRetencion"
            Me.txtValorRetencion.Size = New System.Drawing.Size(76, 21)
            Me.txtValorRetencion.TabIndex = 102
            Me.txtValorRetencion.Text = "0.00"
            Me.txtValorRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtPorcentajeRetencion
            '
            Me.txtPorcentajeRetencion.BackColor = System.Drawing.Color.White
            Me.txtPorcentajeRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPorcentajeRetencion.Enabled = False
            Me.txtPorcentajeRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPorcentajeRetencion.Location = New System.Drawing.Point(81, 61)
            Me.txtPorcentajeRetencion.Name = "txtPorcentajeRetencion"
            Me.txtPorcentajeRetencion.Size = New System.Drawing.Size(64, 21)
            Me.txtPorcentajeRetencion.TabIndex = 101
            Me.txtPorcentajeRetencion.Text = "0"
            Me.txtPorcentajeRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'cmbContribuyente
            '
            Me.cmbContribuyente.BackColor = System.Drawing.Color.White
            Me.cmbContribuyente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbContribuyente.DropDownWidth = 300
            Me.cmbContribuyente.Enabled = False
            Me.cmbContribuyente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbContribuyente.FormattingEnabled = True
            Me.cmbContribuyente.Location = New System.Drawing.Point(552, 33)
            Me.cmbContribuyente.Name = "cmbContribuyente"
            Me.cmbContribuyente.Size = New System.Drawing.Size(106, 21)
            Me.cmbContribuyente.TabIndex = 91
            '
            'cmbConcepto
            '
            Me.cmbConcepto.BackColor = System.Drawing.Color.White
            Me.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbConcepto.DropDownWidth = 600
            Me.cmbConcepto.Enabled = False
            Me.cmbConcepto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.Location = New System.Drawing.Point(264, 33)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(159, 21)
            Me.cmbConcepto.TabIndex = 90
            '
            'cmbImpuesto
            '
            Me.cmbImpuesto.BackColor = System.Drawing.Color.White
            Me.cmbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbImpuesto.Enabled = False
            Me.cmbImpuesto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbImpuesto.FormattingEnabled = True
            Me.cmbImpuesto.Location = New System.Drawing.Point(81, 33)
            Me.cmbImpuesto.Name = "cmbImpuesto"
            Me.cmbImpuesto.Size = New System.Drawing.Size(102, 21)
            Me.cmbImpuesto.TabIndex = 89
            '
            'btnEliminarImpuesto
            '
            Me.btnEliminarImpuesto.BackColor = System.Drawing.Color.Transparent
            Me.btnEliminarImpuesto.FlatAppearance.BorderSize = 0
            Me.btnEliminarImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEliminarImpuesto.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminarImpuesto.Location = New System.Drawing.Point(634, 2)
            Me.btnEliminarImpuesto.Name = "btnEliminarImpuesto"
            Me.btnEliminarImpuesto.Size = New System.Drawing.Size(32, 28)
            Me.btnEliminarImpuesto.TabIndex = 87
            Me.btnEliminarImpuesto.UseVisualStyleBackColor = False
            '
            'btnAgregarImpuesto
            '
            Me.btnAgregarImpuesto.BackColor = System.Drawing.Color.Transparent
            Me.btnAgregarImpuesto.FlatAppearance.BorderSize = 0
            Me.btnAgregarImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAgregarImpuesto.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarImpuesto.Location = New System.Drawing.Point(597, 2)
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
            Me.txtNumAutoSRIComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumAutoSRIComprobanteRetencion.Location = New System.Drawing.Point(81, 4)
            Me.txtNumAutoSRIComprobanteRetencion.Name = "txtNumAutoSRIComprobanteRetencion"
            Me.txtNumAutoSRIComprobanteRetencion.Size = New System.Drawing.Size(102, 21)
            Me.txtNumAutoSRIComprobanteRetencion.TabIndex = 85
            Me.txtNumAutoSRIComprobanteRetencion.Text = "1113541356"
            '
            'dtpComprobanteRetencion
            '
            Me.dtpComprobanteRetencion.Enabled = False
            Me.dtpComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpComprobanteRetencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpComprobanteRetencion.Location = New System.Drawing.Point(476, 5)
            Me.dtpComprobanteRetencion.Name = "dtpComprobanteRetencion"
            Me.dtpComprobanteRetencion.Size = New System.Drawing.Size(106, 21)
            Me.dtpComprobanteRetencion.TabIndex = 23
            '
            'txtTotalComprobanteRetencion
            '
            Me.txtTotalComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteRetencion.Enabled = False
            Me.txtTotalComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobanteRetencion.Location = New System.Drawing.Point(573, 196)
            Me.txtTotalComprobanteRetencion.Name = "txtTotalComprobanteRetencion"
            Me.txtTotalComprobanteRetencion.Size = New System.Drawing.Size(84, 21)
            Me.txtTotalComprobanteRetencion.TabIndex = 43
            Me.txtTotalComprobanteRetencion.Text = "0.00"
            Me.txtTotalComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNumeroComprobanteRetencion
            '
            Me.txtNumeroComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroComprobanteRetencion.Enabled = False
            Me.txtNumeroComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroComprobanteRetencion.Location = New System.Drawing.Point(264, 5)
            Me.txtNumeroComprobanteRetencion.Name = "txtNumeroComprobanteRetencion"
            Me.txtNumeroComprobanteRetencion.Size = New System.Drawing.Size(136, 21)
            Me.txtNumeroComprobanteRetencion.TabIndex = 22
            '
            'dtpMes
            '
            Me.dtpMes.CustomFormat = "MMM yyyy"
            Me.dtpMes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpMes.Location = New System.Drawing.Point(551, 6)
            Me.dtpMes.Name = "dtpMes"
            Me.dtpMes.ShowUpDown = True
            Me.dtpMes.Size = New System.Drawing.Size(93, 21)
            Me.dtpMes.TabIndex = 104
            '
            'EsContrbuyenteEspecial
            '
            Me.EsContrbuyenteEspecial.AutoSize = True
            Me.EsContrbuyenteEspecial.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.EsContrbuyenteEspecial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EsContrbuyenteEspecial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.EsContrbuyenteEspecial.Location = New System.Drawing.Point(318, 40)
            Me.EsContrbuyenteEspecial.Name = "EsContrbuyenteEspecial"
            Me.EsContrbuyenteEspecial.Size = New System.Drawing.Size(16, 13)
            Me.EsContrbuyenteEspecial.TabIndex = 79
            Me.EsContrbuyenteEspecial.Text = "..."
            '
            'lblRucProveedorGeneral
            '
            Me.lblRucProveedorGeneral.AutoSize = True
            Me.lblRucProveedorGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblRucProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRucProveedorGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblRucProveedorGeneral.Location = New System.Drawing.Point(190, 40)
            Me.lblRucProveedorGeneral.Name = "lblRucProveedorGeneral"
            Me.lblRucProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblRucProveedorGeneral.TabIndex = 77
            Me.lblRucProveedorGeneral.Text = "..."
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(6, 5)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(489, 21)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 2
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProveedorGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(75, 40)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 76
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'lblEstadoComprobanteCompra
            '
            Me.lblEstadoComprobanteCompra.AutoSize = True
            Me.lblEstadoComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblEstadoComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstadoComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblEstadoComprobanteCompra.Location = New System.Drawing.Point(211, 105)
            Me.lblEstadoComprobanteCompra.Name = "lblEstadoComprobanteCompra"
            Me.lblEstadoComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblEstadoComprobanteCompra.TabIndex = 94
            Me.lblEstadoComprobanteCompra.Text = "..."
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(159, 104)
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
            DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvComprobantesCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvComprobantesCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle16
            Me.dgvComprobantesCompra.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvComprobantesCompra.Location = New System.Drawing.Point(0, 0)
            Me.dgvComprobantesCompra.MultiSelect = False
            Me.dgvComprobantesCompra.Name = "dgvComprobantesCompra"
            Me.dgvComprobantesCompra.ReadOnly = True
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
            Me.dgvComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle18
            Me.dgvComprobantesCompra.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesCompra.Size = New System.Drawing.Size(680, 164)
            Me.dgvComprobantesCompra.TabIndex = 86
            '
            'dgvPagosComprobanteCompra
            '
            Me.dgvPagosComprobanteCompra.AllowUserToAddRows = False
            Me.dgvPagosComprobanteCompra.AllowUserToDeleteRows = False
            Me.dgvPagosComprobanteCompra.AllowUserToResizeColumns = False
            Me.dgvPagosComprobanteCompra.AllowUserToResizeRows = False
            Me.dgvPagosComprobanteCompra.BackgroundColor = System.Drawing.Color.White
            Me.dgvPagosComprobanteCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPagosComprobanteCompra.Location = New System.Drawing.Point(454, 208)
            Me.dgvPagosComprobanteCompra.MultiSelect = False
            Me.dgvPagosComprobanteCompra.Name = "dgvPagosComprobanteCompra"
            Me.dgvPagosComprobanteCompra.ReadOnly = True
            Me.dgvPagosComprobanteCompra.RowHeadersVisible = False
            Me.dgvPagosComprobanteCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPagosComprobanteCompra.Size = New System.Drawing.Size(71, 56)
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
            Me.dgvAsientoComprobanteCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAsientoComprobanteCompra.Location = New System.Drawing.Point(263, 208)
            Me.dgvAsientoComprobanteCompra.MultiSelect = False
            Me.dgvAsientoComprobanteCompra.Name = "dgvAsientoComprobanteCompra"
            Me.dgvAsientoComprobanteCompra.ReadOnly = True
            Me.dgvAsientoComprobanteCompra.RowHeadersVisible = False
            Me.dgvAsientoComprobanteCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientoComprobanteCompra.Size = New System.Drawing.Size(71, 56)
            Me.dgvAsientoComprobanteCompra.TabIndex = 191
            Me.dgvAsientoComprobanteCompra.Visible = False
            '
            'rbPtoEmision002
            '
            Me.rbPtoEmision002.AutoSize = True
            Me.rbPtoEmision002.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPtoEmision002.Checked = True
            Me.rbPtoEmision002.Enabled = False
            Me.rbPtoEmision002.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPtoEmision002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPtoEmision002.Location = New System.Drawing.Point(124, 4)
            Me.rbPtoEmision002.Name = "rbPtoEmision002"
            Me.rbPtoEmision002.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision002.TabIndex = 28
            Me.rbPtoEmision002.TabStop = True
            Me.rbPtoEmision002.Text = "002"
            Me.rbPtoEmision002.UseVisualStyleBackColor = False
            '
            'rbPtoEmision001
            '
            Me.rbPtoEmision001.AutoSize = True
            Me.rbPtoEmision001.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPtoEmision001.Enabled = False
            Me.rbPtoEmision001.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPtoEmision001.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPtoEmision001.Location = New System.Drawing.Point(81, 4)
            Me.rbPtoEmision001.Name = "rbPtoEmision001"
            Me.rbPtoEmision001.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision001.TabIndex = 27
            Me.rbPtoEmision001.Text = "001"
            Me.rbPtoEmision001.UseVisualStyleBackColor = False
            '
            'dtpFechaEmisionComprobanteCompra
            '
            Me.dtpFechaEmisionComprobanteCompra.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionComprobanteCompra.Enabled = False
            Me.dtpFechaEmisionComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionComprobanteCompra.Location = New System.Drawing.Point(80, 45)
            Me.dtpFechaEmisionComprobanteCompra.Name = "dtpFechaEmisionComprobanteCompra"
            Me.dtpFechaEmisionComprobanteCompra.Size = New System.Drawing.Size(86, 21)
            Me.dtpFechaEmisionComprobanteCompra.TabIndex = 26
            '
            'lblTipoComprobanteCompra
            '
            Me.lblTipoComprobanteCompra.AutoSize = True
            Me.lblTipoComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblTipoComprobanteCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipoComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblTipoComprobanteCompra.Location = New System.Drawing.Point(78, 70)
            Me.lblTipoComprobanteCompra.Name = "lblTipoComprobanteCompra"
            Me.lblTipoComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblTipoComprobanteCompra.TabIndex = 25
            Me.lblTipoComprobanteCompra.Text = "..."
            Me.lblTipoComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblFechaComprobanteCompra
            '
            Me.lblFechaComprobanteCompra.AutoSize = True
            Me.lblFechaComprobanteCompra.Location = New System.Drawing.Point(81, 47)
            Me.lblFechaComprobanteCompra.Name = "lblFechaComprobanteCompra"
            Me.lblFechaComprobanteCompra.Size = New System.Drawing.Size(65, 13)
            Me.lblFechaComprobanteCompra.TabIndex = 23
            Me.lblFechaComprobanteCompra.Text = "00/00/0000"
            Me.lblFechaComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNumeroComprobanteCompra
            '
            Me.lblNumeroComprobanteCompra.AutoSize = True
            Me.lblNumeroComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblNumeroComprobanteCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblNumeroComprobanteCompra.Location = New System.Drawing.Point(81, 25)
            Me.lblNumeroComprobanteCompra.Name = "lblNumeroComprobanteCompra"
            Me.lblNumeroComprobanteCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroComprobanteCompra.TabIndex = 21
            Me.lblNumeroComprobanteCompra.Text = "0"
            Me.lblNumeroComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtTotalComprobanteCompra
            '
            Me.txtTotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteCompra.Enabled = False
            Me.txtTotalComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobanteCompra.Location = New System.Drawing.Point(427, 56)
            Me.txtTotalComprobanteCompra.Name = "txtTotalComprobanteCompra"
            Me.txtTotalComprobanteCompra.Size = New System.Drawing.Size(59, 21)
            Me.txtTotalComprobanteCompra.TabIndex = 32
            Me.txtTotalComprobanteCompra.Text = "0.00"
            Me.txtTotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaComprobanteCompra
            '
            Me.txtIvaComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtIvaComprobanteCompra.Enabled = False
            Me.txtIvaComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIvaComprobanteCompra.Location = New System.Drawing.Point(427, 31)
            Me.txtIvaComprobanteCompra.Name = "txtIvaComprobanteCompra"
            Me.txtIvaComprobanteCompra.Size = New System.Drawing.Size(59, 21)
            Me.txtIvaComprobanteCompra.TabIndex = 31
            Me.txtIvaComprobanteCompra.Text = "0.00"
            Me.txtIvaComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotalComprobanteCompra
            '
            Me.txtSubtotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotalComprobanteCompra.Enabled = False
            Me.txtSubtotalComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotalComprobanteCompra.Location = New System.Drawing.Point(427, 4)
            Me.txtSubtotalComprobanteCompra.Name = "txtSubtotalComprobanteCompra"
            Me.txtSubtotalComprobanteCompra.Size = New System.Drawing.Size(59, 21)
            Me.txtSubtotalComprobanteCompra.TabIndex = 30
            Me.txtSubtotalComprobanteCompra.Text = "0.00"
            Me.txtSubtotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDescuento
            '
            Me.txtDescuento.BackColor = System.Drawing.Color.White
            Me.txtDescuento.Enabled = False
            Me.txtDescuento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuento.Location = New System.Drawing.Point(272, 57)
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.Size = New System.Drawing.Size(59, 21)
            Me.txtDescuento.TabIndex = 29
            Me.txtDescuento.Text = "0.00"
            Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal12
            '
            Me.txtSubtotal12.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12.Enabled = False
            Me.txtSubtotal12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12.Location = New System.Drawing.Point(272, 5)
            Me.txtSubtotal12.Name = "txtSubtotal12"
            Me.txtSubtotal12.Size = New System.Drawing.Size(59, 21)
            Me.txtSubtotal12.TabIndex = 27
            Me.txtSubtotal12.Text = "0.00"
            Me.txtSubtotal12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0
            '
            Me.txtSubtotal0.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0.Enabled = False
            Me.txtSubtotal0.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0.Location = New System.Drawing.Point(272, 32)
            Me.txtSubtotal0.Name = "txtSubtotal0"
            Me.txtSubtotal0.Size = New System.Drawing.Size(59, 21)
            Me.txtSubtotal0.TabIndex = 28
            Me.txtSubtotal0.Text = "0.00"
            Me.txtSubtotal0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIdDetalleComprobanteRetencionCompra
            '
            Me.lblIdDetalleComprobanteRetencionCompra.AutoSize = True
            Me.lblIdDetalleComprobanteRetencionCompra.Location = New System.Drawing.Point(616, 57)
            Me.lblIdDetalleComprobanteRetencionCompra.Name = "lblIdDetalleComprobanteRetencionCompra"
            Me.lblIdDetalleComprobanteRetencionCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblIdDetalleComprobanteRetencionCompra.TabIndex = 78
            Me.lblIdDetalleComprobanteRetencionCompra.Text = "0"
            Me.lblIdDetalleComprobanteRetencionCompra.Visible = False
            '
            'lblEstadoDetalleComprabanteRetencionCompra
            '
            Me.lblEstadoDetalleComprabanteRetencionCompra.AutoSize = True
            Me.lblEstadoDetalleComprabanteRetencionCompra.Location = New System.Drawing.Point(649, 57)
            Me.lblEstadoDetalleComprabanteRetencionCompra.Name = "lblEstadoDetalleComprabanteRetencionCompra"
            Me.lblEstadoDetalleComprabanteRetencionCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblEstadoDetalleComprabanteRetencionCompra.TabIndex = 97
            Me.lblEstadoDetalleComprabanteRetencionCompra.Text = "0"
            Me.lblEstadoDetalleComprabanteRetencionCompra.Visible = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar, Me.btnGenerarXML})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(687, 32)
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
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(95, 28)
            Me.btnGuardar.Text = "GUARDAR"
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
            'btnGenerarXML
            '
            Me.btnGenerarXML.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGenerarXML.Image = Global.syscisepro.My.Resources.Resources.checkbook_20dp_FILL0_wght400_GRAD0_opsz20__2_
            Me.btnGenerarXML.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGenerarXML.Name = "btnGenerarXML"
            Me.btnGenerarXML.Size = New System.Drawing.Size(116, 28)
            Me.btnGenerarXML.Text = "GENERAR XML"
            '
            'rbCompras
            '
            Me.rbCompras.AutoSize = True
            Me.rbCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbCompras.Checked = True
            Me.rbCompras.Enabled = False
            Me.rbCompras.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCompras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCompras.Location = New System.Drawing.Point(523, 61)
            Me.rbCompras.Name = "rbCompras"
            Me.rbCompras.Size = New System.Drawing.Size(70, 17)
            Me.rbCompras.TabIndex = 2
            Me.rbCompras.TabStop = True
            Me.rbCompras.Text = "Compras"
            Me.rbCompras.UseVisualStyleBackColor = False
            '
            'rbCajaChica
            '
            Me.rbCajaChica.AutoSize = True
            Me.rbCajaChica.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbCajaChica.Enabled = False
            Me.rbCajaChica.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCajaChica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCajaChica.Location = New System.Drawing.Point(523, 35)
            Me.rbCajaChica.Name = "rbCajaChica"
            Me.rbCajaChica.Size = New System.Drawing.Size(47, 17)
            Me.rbCajaChica.TabIndex = 1
            Me.rbCajaChica.TabStop = True
            Me.rbCajaChica.Text = "Caja"
            Me.rbCajaChica.UseVisualStyleBackColor = False
            '
            'rbFondoRotativo
            '
            Me.rbFondoRotativo.AutoSize = True
            Me.rbFondoRotativo.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbFondoRotativo.Enabled = False
            Me.rbFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbFondoRotativo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbFondoRotativo.Location = New System.Drawing.Point(523, 5)
            Me.rbFondoRotativo.Name = "rbFondoRotativo"
            Me.rbFondoRotativo.Size = New System.Drawing.Size(59, 17)
            Me.rbFondoRotativo.TabIndex = 0
            Me.rbFondoRotativo.TabStop = True
            Me.rbFondoRotativo.Text = "Fondo"
            Me.rbFondoRotativo.UseVisualStyleBackColor = False
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpMes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(684, 60)
            Me.KryptonGroupBox1.TabIndex = 190
            Me.KryptonGroupBox1.Values.Heading = "Proveedor"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(156, 40)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(29, 13)
            Me.Label2.TabIndex = 191
            Me.Label2.Text = "RUC"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(504, 6)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(33, 20)
            Me.KryptonLabel1.TabIndex = 3
            Me.KryptonLabel1.Values.Text = "Mes"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(0, 99)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvComprobantesCompra)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(684, 188)
            Me.KryptonGroupBox2.TabIndex = 192
            Me.KryptonGroupBox2.Values.Heading = "Comprobantes Compra"
            '
            'dgvComprobanteRetencion
            '
            Me.dgvComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvComprobanteRetencion.AllowUserToDeleteRows = False
            Me.dgvComprobanteRetencion.AllowUserToResizeColumns = False
            Me.dgvComprobanteRetencion.AllowUserToResizeRows = False
            Me.dgvComprobanteRetencion.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteRetencion.Location = New System.Drawing.Point(354, 208)
            Me.dgvComprobanteRetencion.MultiSelect = False
            Me.dgvComprobanteRetencion.Name = "dgvComprobanteRetencion"
            Me.dgvComprobanteRetencion.ReadOnly = True
            Me.dgvComprobanteRetencion.RowHeadersVisible = False
            Me.dgvComprobanteRetencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteRetencion.Size = New System.Drawing.Size(71, 56)
            Me.dgvComprobanteRetencion.TabIndex = 95
            Me.dgvComprobanteRetencion.Visible = False
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(0, 291)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblEstadoDetalleComprabanteRetencionCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.rbCompras)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblIdDetalleComprobanteRetencionCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.rbCajaChica)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.rbFondoRotativo)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtIvaComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSubtotalComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblTipoComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dtpFechaEmisionComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblFechaComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.rbPtoEmision002)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtDescuento)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.rbPtoEmision001)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSubtotal12)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSubtotal0)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblNumeroComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(684, 120)
            Me.KryptonGroupBox3.TabIndex = 193
            Me.KryptonGroupBox3.Values.Heading = "Datos"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(3, 2)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel2.TabIndex = 0
            Me.KryptonLabel2.Values.Text = "Pto Emision"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(3, 20)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel3.TabIndex = 1
            Me.KryptonLabel3.Values.Text = "Nro"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(3, 42)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel4.TabIndex = 2
            Me.KryptonLabel4.Values.Text = "Fecha"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(6, 66)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel5.TabIndex = 3
            Me.KryptonLabel5.Values.Text = "Tipo"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(191, 5)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel6.TabIndex = 29
            Me.KryptonLabel6.Values.Text = "SubTotal 12"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(191, 32)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(69, 20)
            Me.KryptonLabel7.TabIndex = 30
            Me.KryptonLabel7.Values.Text = "SubTotal 0"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(191, 58)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel8.TabIndex = 31
            Me.KryptonLabel8.Values.Text = "Descuento"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(362, 5)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel9.TabIndex = 32
            Me.KryptonLabel9.Values.Text = "SubTotal "
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(362, 32)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(29, 20)
            Me.KryptonLabel10.TabIndex = 33
            Me.KryptonLabel10.Values.Text = "IVA"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(362, 57)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel11.TabIndex = 34
            Me.KryptonLabel11.Values.Text = "Total"
            '
            'KryptonGroupBox4
            '
            Me.KryptonGroupBox4.CaptionOverlap = 0R
            Me.KryptonGroupBox4.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox4.Location = New System.Drawing.Point(0, 414)
            Me.KryptonGroupBox4.Name = "KryptonGroupBox4"
            '
            'KryptonGroupBox4.Panel
            '
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel22)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel21)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dgvDetalleComprobanteRetencion)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel20)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel19)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtValorRetencion)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbBienServicio)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel18)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtBaseImponible)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtTotalComprobanteRetencion)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtPorcentajeRetencion)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtNumAutoSRIComprobanteRetencion)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbImpuesto)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtNumeroComprobanteRetencion)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dtpComprobanteRetencion)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbContribuyente)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.btnAgregarImpuesto)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.btnEliminarImpuesto)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbConcepto)
            Me.KryptonGroupBox4.Size = New System.Drawing.Size(684, 247)
            Me.KryptonGroupBox4.TabIndex = 194
            Me.KryptonGroupBox4.Values.Heading = "Retencion"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(5, 4)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(58, 20)
            Me.KryptonLabel12.TabIndex = 0
            Me.KryptonLabel12.Values.Text = "Auto SRI"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(5, 33)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(62, 20)
            Me.KryptonLabel13.TabIndex = 86
            Me.KryptonLabel13.Values.Text = "Impuesto"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(198, 4)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel14.TabIndex = 90
            Me.KryptonLabel14.Values.Text = "Nro Ret"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(418, 4)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel15.TabIndex = 91
            Me.KryptonLabel15.Values.Text = "Fecha"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(198, 33)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel16.TabIndex = 92
            Me.KryptonLabel16.Values.Text = "Concepto"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(456, 34)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(88, 20)
            Me.KryptonLabel17.TabIndex = 93
            Me.KryptonLabel17.Values.Text = "Contribuyente"
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(157, 61)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.Size = New System.Drawing.Size(94, 20)
            Me.KryptonLabel18.TabIndex = 94
            Me.KryptonLabel18.Values.Text = "Base Imponible"
            '
            'KryptonLabel19
            '
            Me.KryptonLabel19.Location = New System.Drawing.Point(6, 61)
            Me.KryptonLabel19.Name = "KryptonLabel19"
            Me.KryptonLabel19.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel19.TabIndex = 95
            Me.KryptonLabel19.Values.Text = "Porcentaje"
            '
            'KryptonLabel20
            '
            Me.KryptonLabel20.Location = New System.Drawing.Point(535, 60)
            Me.KryptonLabel20.Name = "KryptonLabel20"
            Me.KryptonLabel20.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel20.TabIndex = 106
            Me.KryptonLabel20.Values.Text = "Tipo"
            '
            'KryptonLabel21
            '
            Me.KryptonLabel21.Location = New System.Drawing.Point(374, 62)
            Me.KryptonLabel21.Name = "KryptonLabel21"
            Me.KryptonLabel21.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel21.TabIndex = 110
            Me.KryptonLabel21.Values.Text = "Retenido"
            '
            'KryptonLabel22
            '
            Me.KryptonLabel22.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel22.Location = New System.Drawing.Point(456, 196)
            Me.KryptonLabel22.Name = "KryptonLabel22"
            Me.KryptonLabel22.Size = New System.Drawing.Size(102, 20)
            Me.KryptonLabel22.TabIndex = 111
            Me.KryptonLabel22.Values.Text = "Total Retencion"
            '
            'lblIdComprobanteRetencion
            '
            Me.lblIdComprobanteRetencion.AutoSize = True
            Me.lblIdComprobanteRetencion.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteRetencion.Enabled = False
            Me.lblIdComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteRetencion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteRetencion.Location = New System.Drawing.Point(86, 419)
            Me.lblIdComprobanteRetencion.Name = "lblIdComprobanteRetencion"
            Me.lblIdComprobanteRetencion.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteRetencion.TabIndex = 69
            Me.lblIdComprobanteRetencion.Text = "..."
            '
            'FormComprobantesRetencionCompras
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(687, 662)
            Me.Controls.Add(Me.lblIdComprobanteRetencion)
            Me.Controls.Add(Me.KryptonGroupBox4)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.lblEstadoComprobanteCompra)
            Me.Controls.Add(Me.lblIdComprobanteCompra)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.lblIdProveedorGeneral)
            Me.Controls.Add(Me.EsContrbuyenteEspecial)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dgvAsientoComprobanteCompra)
            Me.Controls.Add(Me.dgvPagosComprobanteCompra)
            Me.Controls.Add(Me.lblRucProveedorGeneral)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvComprobanteRetencion)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormComprobantesRetencionCompras"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "AJUSTAR COMPROBANTES DE RETENCIÓN COMPRAS"
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvPagosComprobanteCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAsientoComprobanteCompra, System.ComponentModel.ISupportInitialize).EndInit()
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
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
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
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtTotalComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents lblEstadoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents dgvComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents lblTipoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblFechaComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblNumeroComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents txtTotalComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtIvaComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotalComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal12 As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0 As System.Windows.Forms.TextBox
        Friend WithEvents dtpComprobanteRetencion As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtNumeroComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents lblIdDetalleComprobanteRetencionCompra As System.Windows.Forms.Label
        Friend WithEvents lblEstadoDetalleComprabanteRetencionCompra As System.Windows.Forms.Label
        Friend WithEvents lblRucProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents dtpFechaEmisionComprobanteCompra As System.Windows.Forms.DateTimePicker
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGenerarXML As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EsContrbuyenteEspecial As System.Windows.Forms.Label
        Friend WithEvents txtNumAutoSRIComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents dtpMes As System.Windows.Forms.DateTimePicker
        Friend WithEvents rbCompras As System.Windows.Forms.RadioButton
        Friend WithEvents rbCajaChica As System.Windows.Forms.RadioButton
        Friend WithEvents rbFondoRotativo As System.Windows.Forms.RadioButton
        Friend WithEvents btnEliminarImpuesto As System.Windows.Forms.Button
        Friend WithEvents btnAgregarImpuesto As System.Windows.Forms.Button
        Friend WithEvents cmbContribuyente As System.Windows.Forms.ComboBox
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents cmbImpuesto As System.Windows.Forms.ComboBox
        Friend WithEvents txtValorRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtPorcentajeRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtBaseImponible As System.Windows.Forms.TextBox
        Friend WithEvents rbPtoEmision002 As System.Windows.Forms.RadioButton
        Friend WithEvents rbPtoEmision001 As System.Windows.Forms.RadioButton
        Friend WithEvents dgvPagosComprobanteCompra As System.Windows.Forms.DataGridView
        Friend WithEvents dgvAsientoComprobanteCompra As System.Windows.Forms.DataGridView
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
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents Label2 As Label
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents dgvComprobanteRetencion As DataGridView
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox4 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel17 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel22 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel21 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel20 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel19 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel18 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblIdComprobanteRetencion As Label
    End Class
End Namespace