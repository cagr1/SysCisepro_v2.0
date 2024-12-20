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
            Me.txtRazonSocialClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblFechaComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblNumeroFacturaVenta = New System.Windows.Forms.Label()
            Me.gbComprobanteRetencion = New System.Windows.Forms.GroupBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtTotalComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.txtValorRetencionIVA = New System.Windows.Forms.TextBox()
            Me.txtValorRetencionFuente = New System.Windows.Forms.TextBox()
            Me.lblFechaComprobanteRetencion = New System.Windows.Forms.Label()
            Me.lblNumeroComprobanteRetencion = New System.Windows.Forms.Label()
            Me.gbValoresFacturaVenta = New System.Windows.Forms.GroupBox()
            Me.lblSubTotal = New System.Windows.Forms.Label()
            Me.lblTotalOrdenCompra = New System.Windows.Forms.Label()
            Me.lblIvaOrdenCompra = New System.Windows.Forms.Label()
            Me.lblDescuentoOrdenCompra = New System.Windows.Forms.Label()
            Me.lblSubtotal0OrdenCompra = New System.Windows.Forms.Label()
            Me.lblSubtotal12OrdenCompra = New System.Windows.Forms.Label()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.txtIva = New System.Windows.Forms.TextBox()
            Me.txtSubtotal = New System.Windows.Forms.TextBox()
            Me.txtDescuento = New System.Windows.Forms.TextBox()
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
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.lblEstadoFacturaVenta = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvRevisionFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.gbComprobanteRetencion.SuspendLayout()
            Me.gbValoresFacturaVenta.SuspendLayout()
            CType(Me.dgvDetalleComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
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
            Me.SuspendLayout()
            '
            'dgvRevisionFacturacion
            '
            Me.dgvRevisionFacturacion.AllowUserToAddRows = False
            Me.dgvRevisionFacturacion.AllowUserToDeleteRows = False
            Me.dgvRevisionFacturacion.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvRevisionFacturacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvRevisionFacturacion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvRevisionFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.None
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
            Me.dgvRevisionFacturacion.Location = New System.Drawing.Point(1, 141)
            Me.dgvRevisionFacturacion.MultiSelect = False
            Me.dgvRevisionFacturacion.Name = "dgvRevisionFacturacion"
            Me.dgvRevisionFacturacion.ReadOnly = True
            Me.dgvRevisionFacturacion.RowHeadersVisible = False
            Me.dgvRevisionFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRevisionFacturacion.Size = New System.Drawing.Size(1046, 372)
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
            Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
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
            Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.GroupBox1.Location = New System.Drawing.Point(1, 519)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1046, 46)
            Me.GroupBox1.TabIndex = 134
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "HISTORIAL FACTURACIÓN"
            '
            'txtTotalFacturadoMesAnte5
            '
            Me.txtTotalFacturadoMesAnte5.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturadoMesAnte5.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalFacturadoMesAnte5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturadoMesAnte5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtTotalFacturadoMesAnte5.Location = New System.Drawing.Point(72, 18)
            Me.txtTotalFacturadoMesAnte5.Name = "txtTotalFacturadoMesAnte5"
            Me.txtTotalFacturadoMesAnte5.ReadOnly = True
            Me.txtTotalFacturadoMesAnte5.Size = New System.Drawing.Size(80, 14)
            Me.txtTotalFacturadoMesAnte5.TabIndex = 47
            Me.txtTotalFacturadoMesAnte5.Text = "0.00"
            Me.txtTotalFacturadoMesAnte5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMesAnte5
            '
            Me.lblMesAnte5.AutoSize = True
            Me.lblMesAnte5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMesAnte5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblMesAnte5.Location = New System.Drawing.Point(13, 18)
            Me.lblMesAnte5.Name = "lblMesAnte5"
            Me.lblMesAnte5.Size = New System.Drawing.Size(16, 13)
            Me.lblMesAnte5.TabIndex = 46
            Me.lblMesAnte5.Text = "..."
            Me.lblMesAnte5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtTotalFacturadoMesAnte4
            '
            Me.txtTotalFacturadoMesAnte4.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturadoMesAnte4.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalFacturadoMesAnte4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturadoMesAnte4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtTotalFacturadoMesAnte4.Location = New System.Drawing.Point(249, 17)
            Me.txtTotalFacturadoMesAnte4.Name = "txtTotalFacturadoMesAnte4"
            Me.txtTotalFacturadoMesAnte4.ReadOnly = True
            Me.txtTotalFacturadoMesAnte4.Size = New System.Drawing.Size(80, 14)
            Me.txtTotalFacturadoMesAnte4.TabIndex = 45
            Me.txtTotalFacturadoMesAnte4.Text = "0.00"
            Me.txtTotalFacturadoMesAnte4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMesAnte4
            '
            Me.lblMesAnte4.AutoSize = True
            Me.lblMesAnte4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMesAnte4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblMesAnte4.Location = New System.Drawing.Point(181, 17)
            Me.lblMesAnte4.Name = "lblMesAnte4"
            Me.lblMesAnte4.Size = New System.Drawing.Size(16, 13)
            Me.lblMesAnte4.TabIndex = 44
            Me.lblMesAnte4.Text = "..."
            '
            'txtTotalFacturadoMesAnte3
            '
            Me.txtTotalFacturadoMesAnte3.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturadoMesAnte3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalFacturadoMesAnte3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturadoMesAnte3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtTotalFacturadoMesAnte3.Location = New System.Drawing.Point(437, 17)
            Me.txtTotalFacturadoMesAnte3.Name = "txtTotalFacturadoMesAnte3"
            Me.txtTotalFacturadoMesAnte3.ReadOnly = True
            Me.txtTotalFacturadoMesAnte3.Size = New System.Drawing.Size(80, 14)
            Me.txtTotalFacturadoMesAnte3.TabIndex = 43
            Me.txtTotalFacturadoMesAnte3.Text = "0.00"
            Me.txtTotalFacturadoMesAnte3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMesAnte3
            '
            Me.lblMesAnte3.AutoSize = True
            Me.lblMesAnte3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMesAnte3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblMesAnte3.Location = New System.Drawing.Point(367, 17)
            Me.lblMesAnte3.Name = "lblMesAnte3"
            Me.lblMesAnte3.Size = New System.Drawing.Size(16, 13)
            Me.lblMesAnte3.TabIndex = 42
            Me.lblMesAnte3.Text = "..."
            Me.lblMesAnte3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtTotalFacturadoMesAnte2
            '
            Me.txtTotalFacturadoMesAnte2.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturadoMesAnte2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalFacturadoMesAnte2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturadoMesAnte2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtTotalFacturadoMesAnte2.Location = New System.Drawing.Point(614, 17)
            Me.txtTotalFacturadoMesAnte2.Name = "txtTotalFacturadoMesAnte2"
            Me.txtTotalFacturadoMesAnte2.ReadOnly = True
            Me.txtTotalFacturadoMesAnte2.Size = New System.Drawing.Size(80, 14)
            Me.txtTotalFacturadoMesAnte2.TabIndex = 41
            Me.txtTotalFacturadoMesAnte2.Text = "0.00"
            Me.txtTotalFacturadoMesAnte2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMesAnte2
            '
            Me.lblMesAnte2.AutoSize = True
            Me.lblMesAnte2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMesAnte2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblMesAnte2.Location = New System.Drawing.Point(547, 17)
            Me.lblMesAnte2.Name = "lblMesAnte2"
            Me.lblMesAnte2.Size = New System.Drawing.Size(16, 13)
            Me.lblMesAnte2.TabIndex = 40
            Me.lblMesAnte2.Text = "..."
            Me.lblMesAnte2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtTotalFacturadoMesAnte
            '
            Me.txtTotalFacturadoMesAnte.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturadoMesAnte.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalFacturadoMesAnte.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturadoMesAnte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtTotalFacturadoMesAnte.Location = New System.Drawing.Point(795, 17)
            Me.txtTotalFacturadoMesAnte.Name = "txtTotalFacturadoMesAnte"
            Me.txtTotalFacturadoMesAnte.ReadOnly = True
            Me.txtTotalFacturadoMesAnte.Size = New System.Drawing.Size(80, 14)
            Me.txtTotalFacturadoMesAnte.TabIndex = 39
            Me.txtTotalFacturadoMesAnte.Text = "0.00"
            Me.txtTotalFacturadoMesAnte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMesAnte
            '
            Me.lblMesAnte.AutoSize = True
            Me.lblMesAnte.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMesAnte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblMesAnte.Location = New System.Drawing.Point(714, 17)
            Me.lblMesAnte.Name = "lblMesAnte"
            Me.lblMesAnte.Size = New System.Drawing.Size(16, 13)
            Me.lblMesAnte.TabIndex = 38
            Me.lblMesAnte.Text = "..."
            Me.lblMesAnte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtTotalFacturadoMesActual
            '
            Me.txtTotalFacturadoMesActual.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturadoMesActual.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalFacturadoMesActual.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturadoMesActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtTotalFacturadoMesActual.Location = New System.Drawing.Point(950, 17)
            Me.txtTotalFacturadoMesActual.Name = "txtTotalFacturadoMesActual"
            Me.txtTotalFacturadoMesActual.ReadOnly = True
            Me.txtTotalFacturadoMesActual.Size = New System.Drawing.Size(80, 14)
            Me.txtTotalFacturadoMesActual.TabIndex = 37
            Me.txtTotalFacturadoMesActual.Text = "0.00"
            Me.txtTotalFacturadoMesActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMesActual
            '
            Me.lblMesActual.AutoSize = True
            Me.lblMesActual.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMesActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblMesActual.Location = New System.Drawing.Point(880, 17)
            Me.lblMesActual.Name = "lblMesActual"
            Me.lblMesActual.Size = New System.Drawing.Size(16, 13)
            Me.lblMesActual.TabIndex = 36
            Me.lblMesActual.Text = "..."
            Me.lblMesActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'gbDatosFacturaVenta
            '
            Me.gbDatosFacturaVenta.BackColor = System.Drawing.Color.White
            Me.gbDatosFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatosFacturaVenta.Location = New System.Drawing.Point(450, 61)
            Me.gbDatosFacturaVenta.Name = "gbDatosFacturaVenta"
            Me.gbDatosFacturaVenta.Size = New System.Drawing.Size(57, 42)
            Me.gbDatosFacturaVenta.TabIndex = 130
            Me.gbDatosFacturaVenta.TabStop = False
            Me.gbDatosFacturaVenta.Text = "Datos"
            '
            'txtRazonSocialClienteGeneral
            '
            Me.txtRazonSocialClienteGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.txtRazonSocialClienteGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtRazonSocialClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazonSocialClienteGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtRazonSocialClienteGeneral.Location = New System.Drawing.Point(87, 26)
            Me.txtRazonSocialClienteGeneral.Name = "txtRazonSocialClienteGeneral"
            Me.txtRazonSocialClienteGeneral.Size = New System.Drawing.Size(230, 14)
            Me.txtRazonSocialClienteGeneral.TabIndex = 33
            Me.txtRazonSocialClienteGeneral.Text = "..."
            '
            'lblFechaComprobanteCompra
            '
            Me.lblFechaComprobanteCompra.AutoSize = True
            Me.lblFechaComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblFechaComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblFechaComprobanteCompra.Location = New System.Drawing.Point(84, 52)
            Me.lblFechaComprobanteCompra.Name = "lblFechaComprobanteCompra"
            Me.lblFechaComprobanteCompra.Size = New System.Drawing.Size(65, 13)
            Me.lblFechaComprobanteCompra.TabIndex = 23
            Me.lblFechaComprobanteCompra.Text = "00/00/0000"
            Me.lblFechaComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNumeroFacturaVenta
            '
            Me.lblNumeroFacturaVenta.AutoSize = True
            Me.lblNumeroFacturaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblNumeroFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroFacturaVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblNumeroFacturaVenta.Location = New System.Drawing.Point(84, 4)
            Me.lblNumeroFacturaVenta.Name = "lblNumeroFacturaVenta"
            Me.lblNumeroFacturaVenta.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroFacturaVenta.TabIndex = 21
            Me.lblNumeroFacturaVenta.Text = "0"
            Me.lblNumeroFacturaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'gbComprobanteRetencion
            '
            Me.gbComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.gbComprobanteRetencion.Controls.Add(Me.Label13)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label14)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label16)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label17)
            Me.gbComprobanteRetencion.Controls.Add(Me.Label18)
            Me.gbComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComprobanteRetencion.Location = New System.Drawing.Point(586, 70)
            Me.gbComprobanteRetencion.Name = "gbComprobanteRetencion"
            Me.gbComprobanteRetencion.Size = New System.Drawing.Size(75, 33)
            Me.gbComprobanteRetencion.TabIndex = 131
            Me.gbComprobanteRetencion.TabStop = False
            Me.gbComprobanteRetencion.Text = "Retención"
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
            'txtTotalComprobanteRetencion
            '
            Me.txtTotalComprobanteRetencion.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.txtTotalComprobanteRetencion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotalComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobanteRetencion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtTotalComprobanteRetencion.Location = New System.Drawing.Point(242, 49)
            Me.txtTotalComprobanteRetencion.Name = "txtTotalComprobanteRetencion"
            Me.txtTotalComprobanteRetencion.Size = New System.Drawing.Size(70, 14)
            Me.txtTotalComprobanteRetencion.TabIndex = 35
            Me.txtTotalComprobanteRetencion.Text = "0.00"
            Me.txtTotalComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtValorRetencionIVA
            '
            Me.txtValorRetencionIVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.txtValorRetencionIVA.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtValorRetencionIVA.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorRetencionIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtValorRetencionIVA.Location = New System.Drawing.Point(242, 26)
            Me.txtValorRetencionIVA.Name = "txtValorRetencionIVA"
            Me.txtValorRetencionIVA.Size = New System.Drawing.Size(70, 14)
            Me.txtValorRetencionIVA.TabIndex = 34
            Me.txtValorRetencionIVA.Text = "0.00"
            Me.txtValorRetencionIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtValorRetencionFuente
            '
            Me.txtValorRetencionFuente.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.txtValorRetencionFuente.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtValorRetencionFuente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorRetencionFuente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtValorRetencionFuente.Location = New System.Drawing.Point(242, 4)
            Me.txtValorRetencionFuente.Name = "txtValorRetencionFuente"
            Me.txtValorRetencionFuente.Size = New System.Drawing.Size(70, 14)
            Me.txtValorRetencionFuente.TabIndex = 33
            Me.txtValorRetencionFuente.Text = "0.00"
            Me.txtValorRetencionFuente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFechaComprobanteRetencion
            '
            Me.lblFechaComprobanteRetencion.AutoSize = True
            Me.lblFechaComprobanteRetencion.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblFechaComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaComprobanteRetencion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblFechaComprobanteRetencion.Location = New System.Drawing.Point(55, 30)
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
            Me.lblNumeroComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroComprobanteRetencion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblNumeroComprobanteRetencion.Location = New System.Drawing.Point(57, 10)
            Me.lblNumeroComprobanteRetencion.Name = "lblNumeroComprobanteRetencion"
            Me.lblNumeroComprobanteRetencion.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroComprobanteRetencion.TabIndex = 21
            Me.lblNumeroComprobanteRetencion.Text = "0"
            Me.lblNumeroComprobanteRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'gbValoresFacturaVenta
            '
            Me.gbValoresFacturaVenta.BackColor = System.Drawing.Color.White
            Me.gbValoresFacturaVenta.Controls.Add(Me.lblSubTotal)
            Me.gbValoresFacturaVenta.Controls.Add(Me.lblTotalOrdenCompra)
            Me.gbValoresFacturaVenta.Controls.Add(Me.lblIvaOrdenCompra)
            Me.gbValoresFacturaVenta.Controls.Add(Me.lblDescuentoOrdenCompra)
            Me.gbValoresFacturaVenta.Controls.Add(Me.lblSubtotal0OrdenCompra)
            Me.gbValoresFacturaVenta.Controls.Add(Me.lblSubtotal12OrdenCompra)
            Me.gbValoresFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbValoresFacturaVenta.Location = New System.Drawing.Point(479, 68)
            Me.gbValoresFacturaVenta.Name = "gbValoresFacturaVenta"
            Me.gbValoresFacturaVenta.Size = New System.Drawing.Size(61, 36)
            Me.gbValoresFacturaVenta.TabIndex = 129
            Me.gbValoresFacturaVenta.TabStop = False
            Me.gbValoresFacturaVenta.Text = "Valores"
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
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtTotal.Location = New System.Drawing.Point(242, 55)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(69, 14)
            Me.txtTotal.TabIndex = 32
            Me.txtTotal.Text = "0.00"
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIva
            '
            Me.txtIva.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtIva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtIva.Location = New System.Drawing.Point(241, 31)
            Me.txtIva.Name = "txtIva"
            Me.txtIva.Size = New System.Drawing.Size(69, 15)
            Me.txtIva.TabIndex = 31
            Me.txtIva.Text = "0.00"
            Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal
            '
            Me.txtSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtSubtotal.Location = New System.Drawing.Point(242, 10)
            Me.txtSubtotal.Name = "txtSubtotal"
            Me.txtSubtotal.Size = New System.Drawing.Size(69, 14)
            Me.txtSubtotal.TabIndex = 30
            Me.txtSubtotal.Text = "0.00"
            Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDescuento
            '
            Me.txtDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtDescuento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtDescuento.Location = New System.Drawing.Point(85, 55)
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.Size = New System.Drawing.Size(69, 14)
            Me.txtDescuento.TabIndex = 29
            Me.txtDescuento.Text = "0.00"
            Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal12
            '
            Me.txtSubtotal12.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.txtSubtotal12.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtSubtotal12.Location = New System.Drawing.Point(85, 10)
            Me.txtSubtotal12.Name = "txtSubtotal12"
            Me.txtSubtotal12.Size = New System.Drawing.Size(69, 14)
            Me.txtSubtotal12.TabIndex = 27
            Me.txtSubtotal12.Text = "0.00"
            Me.txtSubtotal12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0
            '
            Me.txtSubtotal0.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.txtSubtotal0.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal0.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtSubtotal0.Location = New System.Drawing.Point(85, 32)
            Me.txtSubtotal0.Name = "txtSubtotal0"
            Me.txtSubtotal0.Size = New System.Drawing.Size(69, 14)
            Me.txtSubtotal0.TabIndex = 28
            Me.txtSubtotal0.Text = "0.00"
            Me.txtSubtotal0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvDetalleComprobanteRetencionVenta
            '
            Me.dgvDetalleComprobanteRetencionVenta.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencionVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetalleComprobanteRetencionVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleComprobanteRetencionVenta.Location = New System.Drawing.Point(764, 70)
            Me.dgvDetalleComprobanteRetencionVenta.Name = "dgvDetalleComprobanteRetencionVenta"
            Me.dgvDetalleComprobanteRetencionVenta.Size = New System.Drawing.Size(84, 61)
            Me.dgvDetalleComprobanteRetencionVenta.TabIndex = 133
            Me.dgvDetalleComprobanteRetencionVenta.Visible = False
            '
            'dgvComprobanteRetencionVenta
            '
            Me.dgvComprobanteRetencionVenta.AllowUserToAddRows = False
            Me.dgvComprobanteRetencionVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvComprobanteRetencionVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteRetencionVenta.Location = New System.Drawing.Point(602, 89)
            Me.dgvComprobanteRetencionVenta.Name = "dgvComprobanteRetencionVenta"
            Me.dgvComprobanteRetencionVenta.Size = New System.Drawing.Size(58, 40)
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
            Me.msKardex.Size = New System.Drawing.Size(1050, 32)
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
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(5, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRazonSocialClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblFechaComprobanteCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblNumeroFacturaVenta)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(328, 100)
            Me.KryptonGroupBox1.TabIndex = 181
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(10, 49)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel3.TabIndex = 36
            Me.KryptonLabel3.Values.Text = "Fecha"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(10, 26)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel2.TabIndex = 35
            Me.KryptonLabel2.Values.Text = "Cliente"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(10, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel1.TabIndex = 34
            Me.KryptonLabel1.Values.Text = "Nro"
            '
            'lblEstadoFacturaVenta
            '
            Me.lblEstadoFacturaVenta.AutoSize = True
            Me.lblEstadoFacturaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblEstadoFacturaVenta.Font = New System.Drawing.Font("Roboto", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstadoFacturaVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblEstadoFacturaVenta.Location = New System.Drawing.Point(136, 41)
            Me.lblEstadoFacturaVenta.Name = "lblEstadoFacturaVenta"
            Me.lblEstadoFacturaVenta.Size = New System.Drawing.Size(11, 11)
            Me.lblEstadoFacturaVenta.TabIndex = 184
            Me.lblEstadoFacturaVenta.Text = "..."
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(109, 41)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(10, 10)
            Me.Label6.TabIndex = 183
            Me.Label6.Text = "/"
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdFacturaVenta.Font = New System.Drawing.Font("Roboto", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdFacturaVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(79, 41)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(11, 11)
            Me.lblIdFacturaVenta.TabIndex = 182
            Me.lblIdFacturaVenta.Text = "..."
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(339, 35)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotal)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtIva)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSubtotal)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSubtotal12)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSubtotal0)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtDescuento)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(336, 100)
            Me.KryptonGroupBox2.TabIndex = 185
            Me.KryptonGroupBox2.Values.Heading = "Valores"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(177, 49)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel9.TabIndex = 39
            Me.KryptonLabel9.Values.Text = "Total"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(177, 26)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(29, 20)
            Me.KryptonLabel8.TabIndex = 38
            Me.KryptonLabel8.Values.Text = "IVA "
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(177, 4)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel7.TabIndex = 37
            Me.KryptonLabel7.Values.Text = "SubTotal"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(10, 49)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel4.TabIndex = 36
            Me.KryptonLabel4.Values.Text = "Descuento"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(10, 26)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(69, 20)
            Me.KryptonLabel5.TabIndex = 35
            Me.KryptonLabel5.Values.Text = "SubTotal 0"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(10, 4)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel6.TabIndex = 34
            Me.KryptonLabel6.Values.Text = "SubTotal 12"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(683, 35)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalComprobanteRetencion)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtValorRetencionIVA)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtValorRetencionFuente)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblFechaComprobanteRetencion)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblNumeroComprobanteRetencion)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(333, 100)
            Me.KryptonGroupBox3.TabIndex = 186
            Me.KryptonGroupBox3.Values.Heading = "Retencion"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(163, 47)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel10.TabIndex = 39
            Me.KryptonLabel10.Values.Text = "Total"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(163, 26)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(51, 20)
            Me.KryptonLabel11.TabIndex = 38
            Me.KryptonLabel11.Values.Text = "Ret IVA "
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(163, 4)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(69, 20)
            Me.KryptonLabel12.TabIndex = 37
            Me.KryptonLabel12.Values.Text = "Ret Fuente"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(10, 26)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel14.TabIndex = 35
            Me.KryptonLabel14.Values.Text = "Fecha"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(10, 4)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel15.TabIndex = 34
            Me.KryptonLabel15.Values.Text = "Nro"
            '
            'FormrRevisionFacturacionVentas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1050, 566)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.lblEstadoFacturaVenta)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.lblIdFacturaVenta)
            Me.Controls.Add(Me.dgvRevisionFacturacion)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbDatosFacturaVenta)
            Me.Controls.Add(Me.gbComprobanteRetencion)
            Me.Controls.Add(Me.gbValoresFacturaVenta)
            Me.Controls.Add(Me.dgvComprobanteRetencionVenta)
            Me.Controls.Add(Me.dgvDetalleComprobanteRetencionVenta)
            Me.Controls.Add(Me.KryptonGroupBox1)
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
            Me.gbComprobanteRetencion.ResumeLayout(False)
            Me.gbComprobanteRetencion.PerformLayout()
            Me.gbValoresFacturaVenta.ResumeLayout(False)
            Me.gbValoresFacturaVenta.PerformLayout()
            CType(Me.dgvDetalleComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
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
            Me.KryptonGroupBox3.Panel.PerformLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvRevisionFacturacion As System.Windows.Forms.DataGridView
        Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents gbDatosFacturaVenta As System.Windows.Forms.GroupBox
        Friend WithEvents txtRazonSocialClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblNumeroFacturaVenta As System.Windows.Forms.Label
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
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblEstadoFacturaVenta As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents lblIdFacturaVenta As Label
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace