Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormrRevisionFacturacionVentas
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormrRevisionFacturacionVentas))
            Me.dgvRevisionFacturacion = New System.Windows.Forms.DataGridView()
            Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtTotalFacturadoMesAnte5 = New System.Windows.Forms.TextBox()
            Me.lblMesAnte5 = New System.Windows.Forms.Label()
            Me.txtTotalFacturadoMesAnte4 = New System.Windows.Forms.TextBox()
            Me.lblMesAnte4 = New System.Windows.Forms.Label()
            Me.txtTotalFacturadoMesAnte3 = New System.Windows.Forms.TextBox()
            Me.lblMesAnte3 = New System.Windows.Forms.Label()
            Me.txtTotalFacturadoMesAnte2 = New System.Windows.Forms.TextBox()
            Me.lblMesAnte2 = New System.Windows.Forms.Label()
            Me.txtTotalFacturadoMesAnte = New System.Windows.Forms.TextBox()
            Me.lblMesAnte = New System.Windows.Forms.Label()
            Me.txtTotalFacturadoMesActual = New System.Windows.Forms.TextBox()
            Me.lblMesActual = New System.Windows.Forms.Label()
            Me.gbDatosFacturaVenta = New System.Windows.Forms.GroupBox()
            Me.lblEstadoFacturaVenta = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.txtRazonSocialClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblFechaComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblNumeroFacturaVenta = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.gbComprobanteRetencion = New System.Windows.Forms.GroupBox()
            Me.txtTotalComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.txtValorRetencionIVA = New System.Windows.Forms.TextBox()
            Me.txtValorRetencionFuente = New System.Windows.Forms.TextBox()
            Me.lblFechaComprobanteRetencion = New System.Windows.Forms.Label()
            Me.lblNumeroComprobanteRetencion = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.gbValoresFacturaVenta = New System.Windows.Forms.GroupBox()
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
            Me.dgvDetalleComprobanteRetencionVenta = New System.Windows.Forms.DataGridView()
            Me.dgvComprobanteRetencionVenta = New System.Windows.Forms.DataGridView()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnMarcarTodo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnDesmarcarTodo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAprovar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnFacturacion = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvRevisionFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.gbDatosFacturaVenta.SuspendLayout()
            Me.gbComprobanteRetencion.SuspendLayout()
            Me.gbValoresFacturaVenta.SuspendLayout()
            CType(Me.dgvDetalleComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvRevisionFacturacion
            '
            Me.dgvRevisionFacturacion.AllowUserToAddRows = False
            Me.dgvRevisionFacturacion.AllowUserToDeleteRows = False
            Me.dgvRevisionFacturacion.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvRevisionFacturacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvRevisionFacturacion.BackgroundColor = System.Drawing.Color.White
            Me.dgvRevisionFacturacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvRevisionFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvRevisionFacturacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvRevisionFacturacion.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvRevisionFacturacion.Location = New System.Drawing.Point(1, 104)
            Me.dgvRevisionFacturacion.MultiSelect = False
            Me.dgvRevisionFacturacion.Name = "dgvRevisionFacturacion"
            Me.dgvRevisionFacturacion.ReadOnly = True
            Me.dgvRevisionFacturacion.RowHeadersVisible = False
            Me.dgvRevisionFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRevisionFacturacion.Size = New System.Drawing.Size(1123, 414)
            Me.dgvRevisionFacturacion.TabIndex = 128
            '
            'chk
            '
            Me.chk.HeaderText = "CHK"
            Me.chk.Name = "chk"
            Me.chk.ReadOnly = True
            Me.chk.Width = 45
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.txtTotalFacturadoMesAnte5)
            Me.GroupBox1.Controls.Add(Me.lblMesAnte5)
            Me.GroupBox1.Controls.Add(Me.txtTotalFacturadoMesAnte4)
            Me.GroupBox1.Controls.Add(Me.lblMesAnte4)
            Me.GroupBox1.Controls.Add(Me.txtTotalFacturadoMesAnte3)
            Me.GroupBox1.Controls.Add(Me.lblMesAnte3)
            Me.GroupBox1.Controls.Add(Me.txtTotalFacturadoMesAnte2)
            Me.GroupBox1.Controls.Add(Me.lblMesAnte2)
            Me.GroupBox1.Controls.Add(Me.txtTotalFacturadoMesAnte)
            Me.GroupBox1.Controls.Add(Me.lblMesAnte)
            Me.GroupBox1.Controls.Add(Me.txtTotalFacturadoMesActual)
            Me.GroupBox1.Controls.Add(Me.lblMesActual)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(1, 519)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1123, 46)
            Me.GroupBox1.TabIndex = 134
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "HISTORIAL FACTURACIÓN"
            '
            'txtTotalFacturadoMesAnte5
            '
            Me.txtTotalFacturadoMesAnte5.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturadoMesAnte5.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalFacturadoMesAnte5.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturadoMesAnte5.Location = New System.Drawing.Point(93, 18)
            Me.txtTotalFacturadoMesAnte5.Name = "txtTotalFacturadoMesAnte5"
            Me.txtTotalFacturadoMesAnte5.ReadOnly = True
            Me.txtTotalFacturadoMesAnte5.Size = New System.Drawing.Size(90, 15)
            Me.txtTotalFacturadoMesAnte5.TabIndex = 47
            Me.txtTotalFacturadoMesAnte5.Text = "0.00"
            Me.txtTotalFacturadoMesAnte5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMesAnte5
            '
            Me.lblMesAnte5.AutoSize = True
            Me.lblMesAnte5.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMesAnte5.Location = New System.Drawing.Point(13, 18)
            Me.lblMesAnte5.Name = "lblMesAnte5"
            Me.lblMesAnte5.Size = New System.Drawing.Size(16, 14)
            Me.lblMesAnte5.TabIndex = 46
            Me.lblMesAnte5.Text = "..."
            '
            'txtTotalFacturadoMesAnte4
            '
            Me.txtTotalFacturadoMesAnte4.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturadoMesAnte4.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalFacturadoMesAnte4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturadoMesAnte4.Location = New System.Drawing.Point(281, 17)
            Me.txtTotalFacturadoMesAnte4.Name = "txtTotalFacturadoMesAnte4"
            Me.txtTotalFacturadoMesAnte4.ReadOnly = True
            Me.txtTotalFacturadoMesAnte4.Size = New System.Drawing.Size(90, 15)
            Me.txtTotalFacturadoMesAnte4.TabIndex = 45
            Me.txtTotalFacturadoMesAnte4.Text = "0.00"
            Me.txtTotalFacturadoMesAnte4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMesAnte4
            '
            Me.lblMesAnte4.AutoSize = True
            Me.lblMesAnte4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMesAnte4.Location = New System.Drawing.Point(189, 17)
            Me.lblMesAnte4.Name = "lblMesAnte4"
            Me.lblMesAnte4.Size = New System.Drawing.Size(16, 14)
            Me.lblMesAnte4.TabIndex = 44
            Me.lblMesAnte4.Text = "..."
            '
            'txtTotalFacturadoMesAnte3
            '
            Me.txtTotalFacturadoMesAnte3.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturadoMesAnte3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalFacturadoMesAnte3.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturadoMesAnte3.Location = New System.Drawing.Point(472, 17)
            Me.txtTotalFacturadoMesAnte3.Name = "txtTotalFacturadoMesAnte3"
            Me.txtTotalFacturadoMesAnte3.ReadOnly = True
            Me.txtTotalFacturadoMesAnte3.Size = New System.Drawing.Size(90, 15)
            Me.txtTotalFacturadoMesAnte3.TabIndex = 43
            Me.txtTotalFacturadoMesAnte3.Text = "0.00"
            Me.txtTotalFacturadoMesAnte3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMesAnte3
            '
            Me.lblMesAnte3.AutoSize = True
            Me.lblMesAnte3.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMesAnte3.Location = New System.Drawing.Point(376, 17)
            Me.lblMesAnte3.Name = "lblMesAnte3"
            Me.lblMesAnte3.Size = New System.Drawing.Size(16, 14)
            Me.lblMesAnte3.TabIndex = 42
            Me.lblMesAnte3.Text = "..."
            '
            'txtTotalFacturadoMesAnte2
            '
            Me.txtTotalFacturadoMesAnte2.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturadoMesAnte2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalFacturadoMesAnte2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturadoMesAnte2.Location = New System.Drawing.Point(659, 17)
            Me.txtTotalFacturadoMesAnte2.Name = "txtTotalFacturadoMesAnte2"
            Me.txtTotalFacturadoMesAnte2.ReadOnly = True
            Me.txtTotalFacturadoMesAnte2.Size = New System.Drawing.Size(90, 15)
            Me.txtTotalFacturadoMesAnte2.TabIndex = 41
            Me.txtTotalFacturadoMesAnte2.Text = "0.00"
            Me.txtTotalFacturadoMesAnte2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMesAnte2
            '
            Me.lblMesAnte2.AutoSize = True
            Me.lblMesAnte2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMesAnte2.Location = New System.Drawing.Point(569, 17)
            Me.lblMesAnte2.Name = "lblMesAnte2"
            Me.lblMesAnte2.Size = New System.Drawing.Size(16, 14)
            Me.lblMesAnte2.TabIndex = 40
            Me.lblMesAnte2.Text = "..."
            '
            'txtTotalFacturadoMesAnte
            '
            Me.txtTotalFacturadoMesAnte.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturadoMesAnte.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalFacturadoMesAnte.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturadoMesAnte.Location = New System.Drawing.Point(835, 17)
            Me.txtTotalFacturadoMesAnte.Name = "txtTotalFacturadoMesAnte"
            Me.txtTotalFacturadoMesAnte.ReadOnly = True
            Me.txtTotalFacturadoMesAnte.Size = New System.Drawing.Size(90, 15)
            Me.txtTotalFacturadoMesAnte.TabIndex = 39
            Me.txtTotalFacturadoMesAnte.Text = "0.00"
            Me.txtTotalFacturadoMesAnte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMesAnte
            '
            Me.lblMesAnte.AutoSize = True
            Me.lblMesAnte.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMesAnte.Location = New System.Drawing.Point(752, 17)
            Me.lblMesAnte.Name = "lblMesAnte"
            Me.lblMesAnte.Size = New System.Drawing.Size(16, 14)
            Me.lblMesAnte.TabIndex = 38
            Me.lblMesAnte.Text = "..."
            '
            'txtTotalFacturadoMesActual
            '
            Me.txtTotalFacturadoMesActual.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturadoMesActual.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalFacturadoMesActual.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturadoMesActual.Location = New System.Drawing.Point(1020, 17)
            Me.txtTotalFacturadoMesActual.Name = "txtTotalFacturadoMesActual"
            Me.txtTotalFacturadoMesActual.ReadOnly = True
            Me.txtTotalFacturadoMesActual.Size = New System.Drawing.Size(90, 15)
            Me.txtTotalFacturadoMesActual.TabIndex = 37
            Me.txtTotalFacturadoMesActual.Text = "0.00"
            Me.txtTotalFacturadoMesActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMesActual
            '
            Me.lblMesActual.AutoSize = True
            Me.lblMesActual.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMesActual.Location = New System.Drawing.Point(932, 17)
            Me.lblMesActual.Name = "lblMesActual"
            Me.lblMesActual.Size = New System.Drawing.Size(16, 14)
            Me.lblMesActual.TabIndex = 36
            Me.lblMesActual.Text = "..."
            '
            'gbDatosFacturaVenta
            '
            Me.gbDatosFacturaVenta.BackColor = System.Drawing.Color.White
            Me.gbDatosFacturaVenta.Controls.Add(Me.lblEstadoFacturaVenta)
            Me.gbDatosFacturaVenta.Controls.Add(Me.Label6)
            Me.gbDatosFacturaVenta.Controls.Add(Me.lblIdFacturaVenta)
            Me.gbDatosFacturaVenta.Controls.Add(Me.txtRazonSocialClienteGeneral)
            Me.gbDatosFacturaVenta.Controls.Add(Me.lblFechaComprobanteCompra)
            Me.gbDatosFacturaVenta.Controls.Add(Me.lblNumeroFacturaVenta)
            Me.gbDatosFacturaVenta.Controls.Add(Me.Label27)
            Me.gbDatosFacturaVenta.Controls.Add(Me.Label28)
            Me.gbDatosFacturaVenta.Controls.Add(Me.Label30)
            Me.gbDatosFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatosFacturaVenta.Location = New System.Drawing.Point(1, 34)
            Me.gbDatosFacturaVenta.Name = "gbDatosFacturaVenta"
            Me.gbDatosFacturaVenta.Size = New System.Drawing.Size(468, 69)
            Me.gbDatosFacturaVenta.TabIndex = 130
            Me.gbDatosFacturaVenta.TabStop = False
            Me.gbDatosFacturaVenta.Text = "Datos"
            '
            'lblEstadoFacturaVenta
            '
            Me.lblEstadoFacturaVenta.AutoSize = True
            Me.lblEstadoFacturaVenta.Font = New System.Drawing.Font("Roboto", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstadoFacturaVenta.Location = New System.Drawing.Point(109, 1)
            Me.lblEstadoFacturaVenta.Name = "lblEstadoFacturaVenta"
            Me.lblEstadoFacturaVenta.Size = New System.Drawing.Size(11, 11)
            Me.lblEstadoFacturaVenta.TabIndex = 97
            Me.lblEstadoFacturaVenta.Text = "..."
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(90, 1)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(10, 10)
            Me.Label6.TabIndex = 96
            Me.Label6.Text = "/"
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Font = New System.Drawing.Font("Roboto", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(59, 1)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(11, 11)
            Me.lblIdFacturaVenta.TabIndex = 95
            Me.lblIdFacturaVenta.Text = "..."
            '
            'txtRazonSocialClienteGeneral
            '
            Me.txtRazonSocialClienteGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtRazonSocialClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazonSocialClienteGeneral.Location = New System.Drawing.Point(128, 31)
            Me.txtRazonSocialClienteGeneral.Name = "txtRazonSocialClienteGeneral"
            Me.txtRazonSocialClienteGeneral.Size = New System.Drawing.Size(210, 14)
            Me.txtRazonSocialClienteGeneral.TabIndex = 33
            Me.txtRazonSocialClienteGeneral.Text = "..."
            '
            'lblFechaComprobanteCompra
            '
            Me.lblFechaComprobanteCompra.AutoSize = True
            Me.lblFechaComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaComprobanteCompra.Location = New System.Drawing.Point(394, 31)
            Me.lblFechaComprobanteCompra.Name = "lblFechaComprobanteCompra"
            Me.lblFechaComprobanteCompra.Size = New System.Drawing.Size(65, 13)
            Me.lblFechaComprobanteCompra.TabIndex = 23
            Me.lblFechaComprobanteCompra.Text = "00/00/0000"
            Me.lblFechaComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNumeroFacturaVenta
            '
            Me.lblNumeroFacturaVenta.AutoSize = True
            Me.lblNumeroFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroFacturaVenta.Location = New System.Drawing.Point(36, 31)
            Me.lblNumeroFacturaVenta.Name = "lblNumeroFacturaVenta"
            Me.lblNumeroFacturaVenta.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroFacturaVenta.TabIndex = 21
            Me.lblNumeroFacturaVenta.Text = "0"
            Me.lblNumeroFacturaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label27.Location = New System.Drawing.Point(71, 32)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(45, 13)
            Me.Label27.TabIndex = 13
            Me.Label27.Text = "Cliente:"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.Location = New System.Drawing.Point(347, 32)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(40, 13)
            Me.Label28.TabIndex = 12
            Me.Label28.Text = "Fecha:"
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(3, 31)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(28, 13)
            Me.Label30.TabIndex = 10
            Me.Label30.Text = "Nro:"
            '
            'gbComprobanteRetencion
            '
            Me.gbComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.gbComprobanteRetencion.Controls.Add(Me.txtTotalComprobanteRetencion)
            Me.gbComprobanteRetencion.Controls.Add(Me.txtValorRetencionIVA)
            Me.gbComprobanteRetencion.Controls.Add(Me.txtValorRetencionFuente)
            Me.gbComprobanteRetencion.Controls.Add(Me.lblFechaComprobanteRetencion)
            Me.gbComprobanteRetencion.Controls.Add(Me.lblNumeroComprobanteRetencion)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label13)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label14)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label16)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label17)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label18)
            Me.gbComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComprobanteRetencion.Location = New System.Drawing.Point(814, 33)
            Me.gbComprobanteRetencion.Name = "gbComprobanteRetencion"
            Me.gbComprobanteRetencion.Size = New System.Drawing.Size(310, 70)
            Me.gbComprobanteRetencion.TabIndex = 131
            Me.gbComprobanteRetencion.TabStop = False
            Me.gbComprobanteRetencion.Text = "Retención"
            '
            'txtTotalComprobanteRetencion
            '
            Me.txtTotalComprobanteRetencion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobanteRetencion.Location = New System.Drawing.Point(221, 52)
            Me.txtTotalComprobanteRetencion.Name = "txtTotalComprobanteRetencion"
            Me.txtTotalComprobanteRetencion.Size = New System.Drawing.Size(70, 14)
            Me.txtTotalComprobanteRetencion.TabIndex = 35
            Me.txtTotalComprobanteRetencion.Text = "0.00"
            Me.txtTotalComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtValorRetencionIVA
            '
            Me.txtValorRetencionIVA.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtValorRetencionIVA.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorRetencionIVA.Location = New System.Drawing.Point(221, 34)
            Me.txtValorRetencionIVA.Name = "txtValorRetencionIVA"
            Me.txtValorRetencionIVA.Size = New System.Drawing.Size(70, 14)
            Me.txtValorRetencionIVA.TabIndex = 34
            Me.txtValorRetencionIVA.Text = "0.00"
            Me.txtValorRetencionIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtValorRetencionFuente
            '
            Me.txtValorRetencionFuente.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtValorRetencionFuente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorRetencionFuente.Location = New System.Drawing.Point(221, 16)
            Me.txtValorRetencionFuente.Name = "txtValorRetencionFuente"
            Me.txtValorRetencionFuente.Size = New System.Drawing.Size(70, 14)
            Me.txtValorRetencionFuente.TabIndex = 33
            Me.txtValorRetencionFuente.Text = "0.00"
            Me.txtValorRetencionFuente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFechaComprobanteRetencion
            '
            Me.lblFechaComprobanteRetencion.AutoSize = True
            Me.lblFechaComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaComprobanteRetencion.Location = New System.Drawing.Point(48, 34)
            Me.lblFechaComprobanteRetencion.Name = "lblFechaComprobanteRetencion"
            Me.lblFechaComprobanteRetencion.Size = New System.Drawing.Size(65, 13)
            Me.lblFechaComprobanteRetencion.TabIndex = 23
            Me.lblFechaComprobanteRetencion.Text = "00/00/0000"
            Me.lblFechaComprobanteRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNumeroComprobanteRetencion
            '
            Me.lblNumeroComprobanteRetencion.AutoSize = True
            Me.lblNumeroComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroComprobanteRetencion.Location = New System.Drawing.Point(48, 16)
            Me.lblNumeroComprobanteRetencion.Name = "lblNumeroComprobanteRetencion"
            Me.lblNumeroComprobanteRetencion.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroComprobanteRetencion.TabIndex = 21
            Me.lblNumeroComprobanteRetencion.Text = "0"
            Me.lblNumeroComprobanteRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(141, 35)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(47, 13)
            Me.Label13.TabIndex = 20
            Me.Label13.Text = "Ret IVA:"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(141, 52)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(45, 13)
            Me.Label14.TabIndex = 14
            Me.Label14.Text = "TOTAL:"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New System.Drawing.Point(7, 34)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(40, 13)
            Me.Label16.TabIndex = 12
            Me.Label16.Text = "Fecha:"
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(141, 16)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(64, 13)
            Me.Label17.TabIndex = 11
            Me.Label17.Text = "Ret Fuente:"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(7, 16)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(28, 13)
            Me.Label18.TabIndex = 10
            Me.Label18.Text = "Nro:"
            '
            'gbValoresFacturaVenta
            '
            Me.gbValoresFacturaVenta.BackColor = System.Drawing.Color.White
            Me.gbValoresFacturaVenta.Controls.Add(Me.txtTotal)
            Me.gbValoresFacturaVenta.Controls.Add(Me.lblSubTotal)
            Me.gbValoresFacturaVenta.Controls.Add(Me.lblTotalOrdenCompra)
            Me.gbValoresFacturaVenta.Controls.Add(Me.txtIva)
            Me.gbValoresFacturaVenta.Controls.Add(Me.lblIvaOrdenCompra)
            Me.gbValoresFacturaVenta.Controls.Add(Me.lblDescuentoOrdenCompra)
            Me.gbValoresFacturaVenta.Controls.Add(Me.txtSubtotal)
            Me.gbValoresFacturaVenta.Controls.Add(Me.lblSubtotal0OrdenCompra)
            Me.gbValoresFacturaVenta.Controls.Add(Me.txtDescuento)
            Me.gbValoresFacturaVenta.Controls.Add(Me.lblSubtotal12OrdenCompra)
            Me.gbValoresFacturaVenta.Controls.Add(Me.txtSubtotal12)
            Me.gbValoresFacturaVenta.Controls.Add(Me.txtSubtotal0)
            Me.gbValoresFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbValoresFacturaVenta.Location = New System.Drawing.Point(472, 34)
            Me.gbValoresFacturaVenta.Name = "gbValoresFacturaVenta"
            Me.gbValoresFacturaVenta.Size = New System.Drawing.Size(339, 70)
            Me.gbValoresFacturaVenta.TabIndex = 129
            Me.gbValoresFacturaVenta.TabStop = False
            Me.gbValoresFacturaVenta.Text = "Valores"
            '
            'txtTotal
            '
            Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotal.Location = New System.Drawing.Point(256, 52)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(70, 14)
            Me.txtTotal.TabIndex = 32
            Me.txtTotal.Text = "0.00"
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubTotal
            '
            Me.lblSubTotal.AutoSize = True
            Me.lblSubTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotal.Location = New System.Drawing.Point(187, 17)
            Me.lblSubTotal.Name = "lblSubTotal"
            Me.lblSubTotal.Size = New System.Drawing.Size(69, 13)
            Me.lblSubTotal.TabIndex = 20
            Me.lblSubTotal.Text = "SUB TOTAL:"
            '
            'lblTotalOrdenCompra
            '
            Me.lblTotalOrdenCompra.AutoSize = True
            Me.lblTotalOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalOrdenCompra.Location = New System.Drawing.Point(187, 52)
            Me.lblTotalOrdenCompra.Name = "lblTotalOrdenCompra"
            Me.lblTotalOrdenCompra.Size = New System.Drawing.Size(45, 13)
            Me.lblTotalOrdenCompra.TabIndex = 14
            Me.lblTotalOrdenCompra.Text = "TOTAL:"
            '
            'txtIva
            '
            Me.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtIva.Location = New System.Drawing.Point(256, 34)
            Me.txtIva.Name = "txtIva"
            Me.txtIva.Size = New System.Drawing.Size(70, 14)
            Me.txtIva.TabIndex = 31
            Me.txtIva.Text = "0.00"
            Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIvaOrdenCompra
            '
            Me.lblIvaOrdenCompra.AutoSize = True
            Me.lblIvaOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIvaOrdenCompra.Location = New System.Drawing.Point(187, 34)
            Me.lblIvaOrdenCompra.Name = "lblIvaOrdenCompra"
            Me.lblIvaOrdenCompra.Size = New System.Drawing.Size(58, 13)
            Me.lblIvaOrdenCompra.TabIndex = 13
            Me.lblIvaOrdenCompra.Text = "IVA (12%):"
            '
            'lblDescuentoOrdenCompra
            '
            Me.lblDescuentoOrdenCompra.AutoSize = True
            Me.lblDescuentoOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescuentoOrdenCompra.Location = New System.Drawing.Point(6, 52)
            Me.lblDescuentoOrdenCompra.Name = "lblDescuentoOrdenCompra"
            Me.lblDescuentoOrdenCompra.Size = New System.Drawing.Size(73, 13)
            Me.lblDescuentoOrdenCompra.TabIndex = 12
            Me.lblDescuentoOrdenCompra.Text = "DESCUENTO:"
            '
            'txtSubtotal
            '
            Me.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal.Location = New System.Drawing.Point(256, 16)
            Me.txtSubtotal.Name = "txtSubtotal"
            Me.txtSubtotal.Size = New System.Drawing.Size(70, 14)
            Me.txtSubtotal.TabIndex = 30
            Me.txtSubtotal.Text = "0.00"
            Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal0OrdenCompra
            '
            Me.lblSubtotal0OrdenCompra.AutoSize = True
            Me.lblSubtotal0OrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal0OrdenCompra.Location = New System.Drawing.Point(6, 34)
            Me.lblSubtotal0OrdenCompra.Name = "lblSubtotal0OrdenCompra"
            Me.lblSubtotal0OrdenCompra.Size = New System.Drawing.Size(78, 13)
            Me.lblSubtotal0OrdenCompra.TabIndex = 11
            Me.lblSubtotal0OrdenCompra.Text = "SUB TOTAL 0:"
            '
            'txtDescuento
            '
            Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtDescuento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuento.Location = New System.Drawing.Point(91, 52)
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.Size = New System.Drawing.Size(79, 14)
            Me.txtDescuento.TabIndex = 29
            Me.txtDescuento.Text = "0.00"
            Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal12OrdenCompra
            '
            Me.lblSubtotal12OrdenCompra.AutoSize = True
            Me.lblSubtotal12OrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal12OrdenCompra.Location = New System.Drawing.Point(6, 16)
            Me.lblSubtotal12OrdenCompra.Name = "lblSubtotal12OrdenCompra"
            Me.lblSubtotal12OrdenCompra.Size = New System.Drawing.Size(84, 13)
            Me.lblSubtotal12OrdenCompra.TabIndex = 10
            Me.lblSubtotal12OrdenCompra.Text = "SUB TOTAL 12:"
            '
            'txtSubtotal12
            '
            Me.txtSubtotal12.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12.Location = New System.Drawing.Point(91, 16)
            Me.txtSubtotal12.Name = "txtSubtotal12"
            Me.txtSubtotal12.Size = New System.Drawing.Size(79, 14)
            Me.txtSubtotal12.TabIndex = 27
            Me.txtSubtotal12.Text = "0.00"
            Me.txtSubtotal12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0
            '
            Me.txtSubtotal0.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal0.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0.Location = New System.Drawing.Point(91, 34)
            Me.txtSubtotal0.Name = "txtSubtotal0"
            Me.txtSubtotal0.Size = New System.Drawing.Size(79, 14)
            Me.txtSubtotal0.TabIndex = 28
            Me.txtSubtotal0.Text = "0.00"
            Me.txtSubtotal0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvDetalleComprobanteRetencionVenta
            '
            Me.dgvDetalleComprobanteRetencionVenta.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencionVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetalleComprobanteRetencionVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleComprobanteRetencionVenta.Location = New System.Drawing.Point(946, 70)
            Me.dgvDetalleComprobanteRetencionVenta.Name = "dgvDetalleComprobanteRetencionVenta"
            Me.dgvDetalleComprobanteRetencionVenta.Size = New System.Drawing.Size(161, 61)
            Me.dgvDetalleComprobanteRetencionVenta.TabIndex = 133
            Me.dgvDetalleComprobanteRetencionVenta.Visible = False
            '
            'dgvComprobanteRetencionVenta
            '
            Me.dgvComprobanteRetencionVenta.AllowUserToAddRows = False
            Me.dgvComprobanteRetencionVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvComprobanteRetencionVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteRetencionVenta.Location = New System.Drawing.Point(976, 72)
            Me.dgvComprobanteRetencionVenta.Name = "dgvComprobanteRetencionVenta"
            Me.dgvComprobanteRetencionVenta.Size = New System.Drawing.Size(148, 61)
            Me.dgvComprobanteRetencionVenta.TabIndex = 132
            Me.dgvComprobanteRetencionVenta.Visible = False
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnMarcarTodo, Me.btnDesmarcarTodo, Me.btnAprovar, Me.btnExportar, Me.btnFacturacion})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(1130, 32)
            Me.msKardex.TabIndex = 180
            Me.msKardex.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(85, 28)
            Me.btnBuscar.Text = "BUSCAR"
            '
            'btnMarcarTodo
            '
            Me.btnMarcarTodo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnMarcarTodo.Image = Global.syscisepro.My.Resources.Resources.checklist_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnMarcarTodo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnMarcarTodo.Name = "btnMarcarTodo"
            Me.btnMarcarTodo.Size = New System.Drawing.Size(120, 28)
            Me.btnMarcarTodo.Text = "MARCAR TODO"
            '
            'btnDesmarcarTodo
            '
            Me.btnDesmarcarTodo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDesmarcarTodo.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnDesmarcarTodo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnDesmarcarTodo.Name = "btnDesmarcarTodo"
            Me.btnDesmarcarTodo.Size = New System.Drawing.Size(141, 28)
            Me.btnDesmarcarTodo.Text = "DESMARCAR TODO"
            '
            'btnAprovar
            '
            Me.btnAprovar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAprovar.Image = Global.syscisepro.My.Resources.Resources.check_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAprovar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAprovar.Name = "btnAprovar"
            Me.btnAprovar.Size = New System.Drawing.Size(92, 28)
            Me.btnAprovar.Text = "APROBAR"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(99, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'btnFacturacion
            '
            Me.btnFacturacion.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFacturacion.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnFacturacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnFacturacion.Name = "btnFacturacion"
            Me.btnFacturacion.Size = New System.Drawing.Size(99, 28)
            Me.btnFacturacion.Text = "FACTURAR"
            '
            'FormrRevisionFacturacionVentas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1130, 566)
            Me.Controls.Add(Me.dgvRevisionFacturacion)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbDatosFacturaVenta)
            Me.Controls.Add(Me.gbComprobanteRetencion)
            Me.Controls.Add(Me.gbValoresFacturaVenta)
            Me.Controls.Add(Me.dgvComprobanteRetencionVenta)
            Me.Controls.Add(Me.dgvDetalleComprobanteRetencionVenta)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormrRevisionFacturacionVentas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REVISIÓN DE FACTURACIÓN VENTAS"
            CType(Me.dgvRevisionFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbDatosFacturaVenta.ResumeLayout(False)
            Me.gbDatosFacturaVenta.PerformLayout()
            Me.gbComprobanteRetencion.ResumeLayout(False)
            Me.gbComprobanteRetencion.PerformLayout()
            Me.gbValoresFacturaVenta.ResumeLayout(False)
            Me.gbValoresFacturaVenta.PerformLayout()
            CType(Me.dgvDetalleComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvRevisionFacturacion As System.Windows.Forms.DataGridView
        Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents gbDatosFacturaVenta As System.Windows.Forms.GroupBox
        Friend WithEvents txtRazonSocialClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblNumeroFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents gbComprobanteRetencion As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtValorRetencionIVA As System.Windows.Forms.TextBox
        Friend WithEvents txtValorRetencionFuente As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaComprobanteRetencion As System.Windows.Forms.Label
        Friend WithEvents lblNumeroComprobanteRetencion As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents gbValoresFacturaVenta As System.Windows.Forms.GroupBox
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
        Friend WithEvents lblEstadoFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents dgvDetalleComprobanteRetencionVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dgvComprobanteRetencionVenta As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalFacturadoMesAnte5 As System.Windows.Forms.TextBox
        Friend WithEvents lblMesAnte5 As System.Windows.Forms.Label
        Friend WithEvents txtTotalFacturadoMesAnte4 As System.Windows.Forms.TextBox
        Friend WithEvents lblMesAnte4 As System.Windows.Forms.Label
        Friend WithEvents txtTotalFacturadoMesAnte3 As System.Windows.Forms.TextBox
        Friend WithEvents lblMesAnte3 As System.Windows.Forms.Label
        Friend WithEvents txtTotalFacturadoMesAnte2 As System.Windows.Forms.TextBox
        Friend WithEvents lblMesAnte2 As System.Windows.Forms.Label
        Friend WithEvents txtTotalFacturadoMesAnte As System.Windows.Forms.TextBox
        Friend WithEvents lblMesAnte As System.Windows.Forms.Label
        Friend WithEvents txtTotalFacturadoMesActual As System.Windows.Forms.TextBox
        Friend WithEvents lblMesActual As System.Windows.Forms.Label
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnMarcarTodo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnDesmarcarTodo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAprovar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnFacturacion As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace