Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormPagoComprobantesCompra
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPagoComprobantesCompra))
            Me.lblidPagosComprobantePago = New System.Windows.Forms.Label()
            Me.txtNuevoSaldoPagosComprobantesCompra = New System.Windows.Forms.TextBox()
            Me.txtMontoPagosComprobantesCompra = New System.Windows.Forms.TextBox()
            Me.txtAnteriorSaldoPagosComprobantesCompra = New System.Windows.Forms.TextBox()
            Me.txtNumeroPagosComrptobantesCompra = New System.Windows.Forms.TextBox()
            Me.dgvPagosComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.lblTipoComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblFechaComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblNumeroComprobanteCompra = New System.Windows.Forms.Label()
            Me.txtTotalComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.txtValorRetencionIVA = New System.Windows.Forms.TextBox()
            Me.txtValorRetencionFuente = New System.Windows.Forms.TextBox()
            Me.lblFechaComprobanteRetencion = New System.Windows.Forms.Label()
            Me.lblNumeroComprobanteRetencion = New System.Windows.Forms.Label()
            Me.txtTotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtIvaComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtDescuento = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12 = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0 = New System.Windows.Forms.TextBox()
            Me.lblEstadoComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.dgvComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.dgvComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.dgvDetalleComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel17 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel18 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel19 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox4 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel20 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel21 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvPagosComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
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
            Me.SuspendLayout()
            '
            'lblidPagosComprobantePago
            '
            Me.lblidPagosComprobantePago.AutoSize = True
            Me.lblidPagosComprobantePago.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblidPagosComprobantePago.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblidPagosComprobantePago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblidPagosComprobantePago.Location = New System.Drawing.Point(576, 44)
            Me.lblidPagosComprobantePago.Name = "lblidPagosComprobantePago"
            Me.lblidPagosComprobantePago.Size = New System.Drawing.Size(16, 13)
            Me.lblidPagosComprobantePago.TabIndex = 61
            Me.lblidPagosComprobantePago.Text = "..."
            '
            'txtNuevoSaldoPagosComprobantesCompra
            '
            Me.txtNuevoSaldoPagosComprobantesCompra.BackColor = System.Drawing.Color.White
            Me.txtNuevoSaldoPagosComprobantesCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNuevoSaldoPagosComprobantesCompra.Enabled = False
            Me.txtNuevoSaldoPagosComprobantesCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNuevoSaldoPagosComprobantesCompra.Location = New System.Drawing.Point(284, 29)
            Me.txtNuevoSaldoPagosComprobantesCompra.Name = "txtNuevoSaldoPagosComprobantesCompra"
            Me.txtNuevoSaldoPagosComprobantesCompra.Size = New System.Drawing.Size(88, 21)
            Me.txtNuevoSaldoPagosComprobantesCompra.TabIndex = 3
            Me.txtNuevoSaldoPagosComprobantesCompra.Text = "0.00"
            Me.txtNuevoSaldoPagosComprobantesCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtMontoPagosComprobantesCompra
            '
            Me.txtMontoPagosComprobantesCompra.BackColor = System.Drawing.Color.White
            Me.txtMontoPagosComprobantesCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMontoPagosComprobantesCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoPagosComprobantesCompra.Location = New System.Drawing.Point(284, 3)
            Me.txtMontoPagosComprobantesCompra.Name = "txtMontoPagosComprobantesCompra"
            Me.txtMontoPagosComprobantesCompra.Size = New System.Drawing.Size(88, 21)
            Me.txtMontoPagosComprobantesCompra.TabIndex = 2
            Me.txtMontoPagosComprobantesCompra.Text = "0.00"
            Me.txtMontoPagosComprobantesCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAnteriorSaldoPagosComprobantesCompra
            '
            Me.txtAnteriorSaldoPagosComprobantesCompra.BackColor = System.Drawing.Color.White
            Me.txtAnteriorSaldoPagosComprobantesCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtAnteriorSaldoPagosComprobantesCompra.Enabled = False
            Me.txtAnteriorSaldoPagosComprobantesCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAnteriorSaldoPagosComprobantesCompra.Location = New System.Drawing.Point(97, 29)
            Me.txtAnteriorSaldoPagosComprobantesCompra.Name = "txtAnteriorSaldoPagosComprobantesCompra"
            Me.txtAnteriorSaldoPagosComprobantesCompra.Size = New System.Drawing.Size(88, 21)
            Me.txtAnteriorSaldoPagosComprobantesCompra.TabIndex = 1
            Me.txtAnteriorSaldoPagosComprobantesCompra.Text = "0.00"
            Me.txtAnteriorSaldoPagosComprobantesCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNumeroPagosComrptobantesCompra
            '
            Me.txtNumeroPagosComrptobantesCompra.BackColor = System.Drawing.Color.White
            Me.txtNumeroPagosComrptobantesCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroPagosComrptobantesCompra.Enabled = False
            Me.txtNumeroPagosComrptobantesCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroPagosComrptobantesCompra.Location = New System.Drawing.Point(97, 3)
            Me.txtNumeroPagosComrptobantesCompra.Name = "txtNumeroPagosComrptobantesCompra"
            Me.txtNumeroPagosComrptobantesCompra.Size = New System.Drawing.Size(88, 21)
            Me.txtNumeroPagosComrptobantesCompra.TabIndex = 0
            Me.txtNumeroPagosComrptobantesCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvPagosComprobantesCompra
            '
            Me.dgvPagosComprobantesCompra.AllowUserToAddRows = False
            Me.dgvPagosComprobantesCompra.AllowUserToDeleteRows = False
            Me.dgvPagosComprobantesCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvPagosComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvPagosComprobantesCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvPagosComprobantesCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPagosComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPagosComprobantesCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvPagosComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPagosComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvPagosComprobantesCompra.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvPagosComprobantesCompra.Location = New System.Drawing.Point(0, 0)
            Me.dgvPagosComprobantesCompra.MultiSelect = False
            Me.dgvPagosComprobantesCompra.Name = "dgvPagosComprobantesCompra"
            Me.dgvPagosComprobantesCompra.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPagosComprobantesCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvPagosComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvPagosComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvPagosComprobantesCompra.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvPagosComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPagosComprobantesCompra.Size = New System.Drawing.Size(290, 323)
            Me.dgvPagosComprobantesCompra.TabIndex = 0
            '
            'lblTipoComprobanteCompra
            '
            Me.lblTipoComprobanteCompra.AutoSize = True
            Me.lblTipoComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblTipoComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipoComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblTipoComprobanteCompra.Location = New System.Drawing.Point(50, 60)
            Me.lblTipoComprobanteCompra.Name = "lblTipoComprobanteCompra"
            Me.lblTipoComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblTipoComprobanteCompra.TabIndex = 25
            Me.lblTipoComprobanteCompra.Text = "..."
            Me.lblTipoComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblFechaComprobanteCompra
            '
            Me.lblFechaComprobanteCompra.AutoSize = True
            Me.lblFechaComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblFechaComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblFechaComprobanteCompra.Location = New System.Drawing.Point(50, 32)
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
            Me.lblNumeroComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblNumeroComprobanteCompra.Location = New System.Drawing.Point(50, 7)
            Me.lblNumeroComprobanteCompra.Name = "lblNumeroComprobanteCompra"
            Me.lblNumeroComprobanteCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroComprobanteCompra.TabIndex = 21
            Me.lblNumeroComprobanteCompra.Text = "0"
            Me.lblNumeroComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtTotalComprobanteRetencion
            '
            Me.txtTotalComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteRetencion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalComprobanteRetencion.Enabled = False
            Me.txtTotalComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobanteRetencion.Location = New System.Drawing.Point(734, 59)
            Me.txtTotalComprobanteRetencion.Name = "txtTotalComprobanteRetencion"
            Me.txtTotalComprobanteRetencion.Size = New System.Drawing.Size(56, 14)
            Me.txtTotalComprobanteRetencion.TabIndex = 35
            Me.txtTotalComprobanteRetencion.Text = "0.00"
            Me.txtTotalComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtValorRetencionIVA
            '
            Me.txtValorRetencionIVA.BackColor = System.Drawing.Color.White
            Me.txtValorRetencionIVA.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtValorRetencionIVA.Enabled = False
            Me.txtValorRetencionIVA.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorRetencionIVA.Location = New System.Drawing.Point(734, 33)
            Me.txtValorRetencionIVA.Name = "txtValorRetencionIVA"
            Me.txtValorRetencionIVA.Size = New System.Drawing.Size(56, 14)
            Me.txtValorRetencionIVA.TabIndex = 34
            Me.txtValorRetencionIVA.Text = "0.00"
            Me.txtValorRetencionIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtValorRetencionFuente
            '
            Me.txtValorRetencionFuente.BackColor = System.Drawing.Color.White
            Me.txtValorRetencionFuente.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtValorRetencionFuente.Enabled = False
            Me.txtValorRetencionFuente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorRetencionFuente.Location = New System.Drawing.Point(734, 6)
            Me.txtValorRetencionFuente.Name = "txtValorRetencionFuente"
            Me.txtValorRetencionFuente.Size = New System.Drawing.Size(56, 14)
            Me.txtValorRetencionFuente.TabIndex = 33
            Me.txtValorRetencionFuente.Text = "0.00"
            Me.txtValorRetencionFuente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFechaComprobanteRetencion
            '
            Me.lblFechaComprobanteRetencion.AutoSize = True
            Me.lblFechaComprobanteRetencion.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblFechaComprobanteRetencion.Enabled = False
            Me.lblFechaComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaComprobanteRetencion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblFechaComprobanteRetencion.Location = New System.Drawing.Point(558, 32)
            Me.lblFechaComprobanteRetencion.Name = "lblFechaComprobanteRetencion"
            Me.lblFechaComprobanteRetencion.Size = New System.Drawing.Size(65, 13)
            Me.lblFechaComprobanteRetencion.TabIndex = 23
            Me.lblFechaComprobanteRetencion.Text = "00/00/0000"
            Me.lblFechaComprobanteRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNumeroComprobanteRetencion
            '
            Me.lblNumeroComprobanteRetencion.AutoSize = True
            Me.lblNumeroComprobanteRetencion.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblNumeroComprobanteRetencion.Enabled = False
            Me.lblNumeroComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroComprobanteRetencion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblNumeroComprobanteRetencion.Location = New System.Drawing.Point(558, 8)
            Me.lblNumeroComprobanteRetencion.Name = "lblNumeroComprobanteRetencion"
            Me.lblNumeroComprobanteRetencion.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroComprobanteRetencion.TabIndex = 21
            Me.lblNumeroComprobanteRetencion.Text = "0"
            Me.lblNumeroComprobanteRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtTotalComprobanteCompra
            '
            Me.txtTotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalComprobanteCompra.Enabled = False
            Me.txtTotalComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobanteCompra.Location = New System.Drawing.Point(373, 59)
            Me.txtTotalComprobanteCompra.Name = "txtTotalComprobanteCompra"
            Me.txtTotalComprobanteCompra.Size = New System.Drawing.Size(59, 14)
            Me.txtTotalComprobanteCompra.TabIndex = 32
            Me.txtTotalComprobanteCompra.Text = "0.00"
            Me.txtTotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaComprobanteCompra
            '
            Me.txtIvaComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtIvaComprobanteCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtIvaComprobanteCompra.Enabled = False
            Me.txtIvaComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIvaComprobanteCompra.Location = New System.Drawing.Point(373, 34)
            Me.txtIvaComprobanteCompra.Name = "txtIvaComprobanteCompra"
            Me.txtIvaComprobanteCompra.Size = New System.Drawing.Size(59, 14)
            Me.txtIvaComprobanteCompra.TabIndex = 31
            Me.txtIvaComprobanteCompra.Text = "0.00"
            Me.txtIvaComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotalComprobanteCompra
            '
            Me.txtSubtotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotalComprobanteCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotalComprobanteCompra.Enabled = False
            Me.txtSubtotalComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotalComprobanteCompra.Location = New System.Drawing.Point(373, 7)
            Me.txtSubtotalComprobanteCompra.Name = "txtSubtotalComprobanteCompra"
            Me.txtSubtotalComprobanteCompra.Size = New System.Drawing.Size(59, 14)
            Me.txtSubtotalComprobanteCompra.TabIndex = 30
            Me.txtSubtotalComprobanteCompra.Text = "0.00"
            Me.txtSubtotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDescuento
            '
            Me.txtDescuento.BackColor = System.Drawing.Color.White
            Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtDescuento.Enabled = False
            Me.txtDescuento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuento.Location = New System.Drawing.Point(227, 59)
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.Size = New System.Drawing.Size(59, 14)
            Me.txtDescuento.TabIndex = 29
            Me.txtDescuento.Text = "0.00"
            Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal12
            '
            Me.txtSubtotal12.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal12.Enabled = False
            Me.txtSubtotal12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12.Location = New System.Drawing.Point(227, 9)
            Me.txtSubtotal12.Name = "txtSubtotal12"
            Me.txtSubtotal12.Size = New System.Drawing.Size(59, 14)
            Me.txtSubtotal12.TabIndex = 27
            Me.txtSubtotal12.Text = "0.00"
            Me.txtSubtotal12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0
            '
            Me.txtSubtotal0.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal0.Enabled = False
            Me.txtSubtotal0.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0.Location = New System.Drawing.Point(227, 33)
            Me.txtSubtotal0.Name = "txtSubtotal0"
            Me.txtSubtotal0.Size = New System.Drawing.Size(59, 14)
            Me.txtSubtotal0.TabIndex = 28
            Me.txtSubtotal0.Text = "0.00"
            Me.txtSubtotal0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblEstadoComprobanteCompra
            '
            Me.lblEstadoComprobanteCompra.AutoSize = True
            Me.lblEstadoComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblEstadoComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstadoComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblEstadoComprobanteCompra.Location = New System.Drawing.Point(201, 122)
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
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(150, 122)
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
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvComprobantesCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvComprobantesCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgvComprobantesCompra.Location = New System.Drawing.Point(12, 232)
            Me.dgvComprobantesCompra.MultiSelect = False
            Me.dgvComprobantesCompra.Name = "dgvComprobantesCompra"
            Me.dgvComprobantesCompra.ReadOnly = True
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvComprobantesCompra.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesCompra.Size = New System.Drawing.Size(548, 345)
            Me.dgvComprobantesCompra.TabIndex = 86
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(6, 16)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(431, 20)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 2
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProveedorGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(91, 42)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 76
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'dgvComprobanteRetencion
            '
            Me.dgvComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvComprobanteRetencion.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteRetencion.Location = New System.Drawing.Point(323, 377)
            Me.dgvComprobanteRetencion.Name = "dgvComprobanteRetencion"
            Me.dgvComprobanteRetencion.Size = New System.Drawing.Size(101, 61)
            Me.dgvComprobanteRetencion.TabIndex = 92
            '
            'dgvDetalleComprobanteRetencion
            '
            Me.dgvDetalleComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencion.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleComprobanteRetencion.Location = New System.Drawing.Point(323, 461)
            Me.dgvDetalleComprobanteRetencion.Name = "dgvDetalleComprobanteRetencion"
            Me.dgvDetalleComprobanteRetencion.Size = New System.Drawing.Size(101, 62)
            Me.dgvDetalleComprobanteRetencion.TabIndex = 93
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnModificar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(866, 32)
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
            'btnModificar
            '
            Me.btnModificar.Enabled = False
            Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.edit_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(103, 28)
            Me.btnModificar.Text = "MODIFICAR"
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
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(9, 37)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(444, 79)
            Me.KryptonGroupBox1.TabIndex = 189
            Me.KryptonGroupBox1.Values.Heading = "Proveedor"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(9, 117)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalComprobanteRetencion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel19)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtValorRetencionIVA)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel18)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtValorRetencionFuente)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblFechaComprobanteRetencion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblNumeroComprobanteRetencion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtIvaComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSubtotalComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblTipoComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtDescuento)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblFechaComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSubtotal12)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSubtotal0)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblNumeroComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(851, 109)
            Me.KryptonGroupBox2.TabIndex = 191
            Me.KryptonGroupBox2.Values.Heading = "Comprobante Compra"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(6, 3)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel5.TabIndex = 1
            Me.KryptonLabel5.Values.Text = "Nro"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(6, 27)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel6.TabIndex = 2
            Me.KryptonLabel6.Values.Text = "Fecha"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(6, 53)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel7.TabIndex = 3
            Me.KryptonLabel7.Values.Text = "Tipo"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(308, 53)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel11.TabIndex = 40
            Me.KryptonLabel11.Values.Text = "Total"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(308, 27)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(29, 20)
            Me.KryptonLabel10.TabIndex = 39
            Me.KryptonLabel10.Values.Text = "IVA"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(308, 3)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel12.TabIndex = 38
            Me.KryptonLabel12.Values.Text = "SubTotal "
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(148, 53)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel13.TabIndex = 37
            Me.KryptonLabel13.Values.Text = "Descuento"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(148, 3)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel15.TabIndex = 35
            Me.KryptonLabel15.Values.Text = "SubTotal 12"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(460, 3)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(89, 20)
            Me.KryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel9.TabIndex = 41
            Me.KryptonLabel9.Values.Text = "Nro Retencion"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(460, 29)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(100, 20)
            Me.KryptonLabel16.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel16.TabIndex = 42
            Me.KryptonLabel16.Values.Text = "Fecha Retencion"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(641, 3)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(69, 20)
            Me.KryptonLabel17.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel17.TabIndex = 43
            Me.KryptonLabel17.Values.Text = "Ret Fuente"
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(641, 29)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.Size = New System.Drawing.Size(51, 20)
            Me.KryptonLabel18.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel18.TabIndex = 44
            Me.KryptonLabel18.Values.Text = "Ret IVA"
            '
            'KryptonLabel19
            '
            Me.KryptonLabel19.Location = New System.Drawing.Point(641, 53)
            Me.KryptonLabel19.Name = "KryptonLabel19"
            Me.KryptonLabel19.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel19.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel19.TabIndex = 45
            Me.KryptonLabel19.Values.Text = "Total"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(566, 232)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dgvPagosComprobantesCompra)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(294, 347)
            Me.KryptonGroupBox3.TabIndex = 192
            Me.KryptonGroupBox3.Values.Heading = "Pagos "
            '
            'KryptonGroupBox4
            '
            Me.KryptonGroupBox4.CaptionOverlap = 0R
            Me.KryptonGroupBox4.Enabled = False
            Me.KryptonGroupBox4.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox4.Location = New System.Drawing.Point(459, 37)
            Me.KryptonGroupBox4.Name = "KryptonGroupBox4"
            '
            'KryptonGroupBox4.Panel
            '
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel20)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel21)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtMontoPagosComprobantesCompra)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtNuevoSaldoPagosComprobantesCompra)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtNumeroPagosComrptobantesCompra)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtAnteriorSaldoPagosComprobantesCompra)
            Me.KryptonGroupBox4.Size = New System.Drawing.Size(401, 79)
            Me.KryptonGroupBox4.TabIndex = 193
            Me.KryptonGroupBox4.Values.Heading = "Nuevo Pago"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(191, 31)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(80, 20)
            Me.KryptonLabel8.TabIndex = 7
            Me.KryptonLabel8.Values.Text = "Nuevo Saldo"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(191, 3)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(92, 20)
            Me.KryptonLabel14.TabIndex = 6
            Me.KryptonLabel14.Values.Text = "Monto a pagar"
            '
            'KryptonLabel20
            '
            Me.KryptonLabel20.Location = New System.Drawing.Point(10, 30)
            Me.KryptonLabel20.Name = "KryptonLabel20"
            Me.KryptonLabel20.Size = New System.Drawing.Size(89, 20)
            Me.KryptonLabel20.TabIndex = 5
            Me.KryptonLabel20.Values.Text = "Saldo Anterior"
            '
            'KryptonLabel21
            '
            Me.KryptonLabel21.Location = New System.Drawing.Point(10, 3)
            Me.KryptonLabel21.Name = "KryptonLabel21"
            Me.KryptonLabel21.Size = New System.Drawing.Size(58, 20)
            Me.KryptonLabel21.TabIndex = 4
            Me.KryptonLabel21.Values.Text = "No Pago "
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(148, 29)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(69, 20)
            Me.KryptonLabel1.TabIndex = 46
            Me.KryptonLabel1.Values.Text = "SubTotal 0"
            '
            'FormPagoComprobantesCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(866, 591)
            Me.Controls.Add(Me.lblidPagosComprobantePago)
            Me.Controls.Add(Me.KryptonGroupBox4)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.lblEstadoComprobanteCompra)
            Me.Controls.Add(Me.lblIdComprobanteCompra)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.dgvComprobantesCompra)
            Me.Controls.Add(Me.lblIdProveedorGeneral)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvDetalleComprobanteRetencion)
            Me.Controls.Add(Me.dgvComprobanteRetencion)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormPagoComprobantesCompra"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REGISTROS DE PAGOS DE COMPROBANTES DE COMPRA"
            CType(Me.dgvPagosComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
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
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
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
        Friend WithEvents txtMontoPagosComprobantesCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtAnteriorSaldoPagosComprobantesCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroPagosComrptobantesCompra As System.Windows.Forms.TextBox
        Friend WithEvents dgvPagosComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents dgvComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents txtNuevoSaldoPagosComprobantesCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents lblidPagosComprobantePago As System.Windows.Forms.Label
        Friend WithEvents lblEstadoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblFechaComprobanteRetencion As System.Windows.Forms.Label
        Friend WithEvents lblNumeroComprobanteRetencion As System.Windows.Forms.Label
        Friend WithEvents lblTipoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblFechaComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblNumeroComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents txtTotalComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtValorRetencionIVA As System.Windows.Forms.TextBox
        Friend WithEvents txtValorRetencionFuente As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtIvaComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotalComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal12 As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0 As System.Windows.Forms.TextBox
        Friend WithEvents dgvComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel19 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel18 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel17 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox4 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel20 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel21 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace