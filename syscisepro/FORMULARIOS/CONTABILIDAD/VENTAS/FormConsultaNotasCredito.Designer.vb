Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormConsultaNotasCredito
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaNotasCredito))
            Me.txtNumeroFacturaBuscar = New System.Windows.Forms.TextBox()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.txtClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.dgvNotaCredito = New System.Windows.Forms.DataGridView()
            Me.txtTotalSubtotal = New System.Windows.Forms.TextBox()
            Me.txtTotalIVA = New System.Windows.Forms.TextBox()
            Me.txtTotalFacturas = New System.Windows.Forms.TextBox()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.dgvDetalleFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.dgvCliente = New System.Windows.Forms.DataGridView()
            Me.rbTodas = New System.Windows.Forms.RadioButton()
            Me.rbAnuladas = New System.Windows.Forms.RadioButton()
            Me.rbActivas = New System.Windows.Forms.RadioButton()
            Me.rbNroNotaCredito = New System.Windows.Forms.RadioButton()
            Me.rbConsorcio = New System.Windows.Forms.RadioButton()
            Me.rbPorCliente = New System.Windows.Forms.RadioButton()
            Me.rbTodo = New System.Windows.Forms.RadioButton()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnSalir = New System.Windows.Forms.ToolStripMenuItem()
            Me.GENERARRIDEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ofdSeleccionarArchivo = New System.Windows.Forms.OpenFileDialog()
            Me.btnNotaCreditoPath = New System.Windows.Forms.Button()
            Me.txtNotaCreditoPath = New System.Windows.Forms.TextBox()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.MetroTabControl1 = New ReaLTaiizor.Controls.MetroTabControl()
            Me.MetroTabPage1 = New ReaLTaiizor.Child.Metro.MetroTabPage()
            Me.MetroTabPage2 = New ReaLTaiizor.Child.Metro.MetroTabPage()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.lblIva = New Krypton.Toolkit.KryptonLabel()
            Me.lblSubtotalIva = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvNotaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.MetroTabControl1.SuspendLayout()
            Me.MetroTabPage1.SuspendLayout()
            Me.MetroTabPage2.SuspendLayout()
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
            'txtNumeroFacturaBuscar
            '
            Me.txtNumeroFacturaBuscar.BackColor = System.Drawing.Color.White
            Me.txtNumeroFacturaBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroFacturaBuscar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroFacturaBuscar.Location = New System.Drawing.Point(914, 24)
            Me.txtNumeroFacturaBuscar.Name = "txtNumeroFacturaBuscar"
            Me.txtNumeroFacturaBuscar.Size = New System.Drawing.Size(105, 21)
            Me.txtNumeroFacturaBuscar.TabIndex = 0
            Me.txtNumeroFacturaBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdFacturaVenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdFacturaVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(873, 5)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(16, 13)
            Me.lblIdFacturaVenta.TabIndex = 4
            Me.lblIdFacturaVenta.Text = "..."
            Me.lblIdFacturaVenta.Visible = False
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(802, 23)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(87, 21)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(695, 24)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(89, 21)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'txtClienteGeneral
            '
            Me.txtClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtClienteGeneral.Enabled = False
            Me.txtClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtClienteGeneral.Location = New System.Drawing.Point(176, 23)
            Me.txtClienteGeneral.Name = "txtClienteGeneral"
            Me.txtClienteGeneral.Size = New System.Drawing.Size(297, 21)
            Me.txtClienteGeneral.TabIndex = 31
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdClienteGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(241, 5)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(13, 13)
            Me.lblIdClienteGeneral.TabIndex = 30
            Me.lblIdClienteGeneral.Text = "0"
            '
            'dgvNotaCredito
            '
            Me.dgvNotaCredito.AllowUserToAddRows = False
            Me.dgvNotaCredito.AllowUserToDeleteRows = False
            Me.dgvNotaCredito.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvNotaCredito.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvNotaCredito.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvNotaCredito.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvNotaCredito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvNotaCredito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvNotaCredito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvNotaCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvNotaCredito.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvNotaCredito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvNotaCredito.Location = New System.Drawing.Point(0, 0)
            Me.dgvNotaCredito.MultiSelect = False
            Me.dgvNotaCredito.Name = "dgvNotaCredito"
            Me.dgvNotaCredito.ReadOnly = True
            Me.dgvNotaCredito.RowHeadersVisible = False
            Me.dgvNotaCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvNotaCredito.Size = New System.Drawing.Size(1030, 367)
            Me.dgvNotaCredito.TabIndex = 102
            '
            'txtTotalSubtotal
            '
            Me.txtTotalSubtotal.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalSubtotal.Location = New System.Drawing.Point(555, 13)
            Me.txtTotalSubtotal.Name = "txtTotalSubtotal"
            Me.txtTotalSubtotal.Size = New System.Drawing.Size(89, 22)
            Me.txtTotalSubtotal.TabIndex = 8
            Me.txtTotalSubtotal.Text = "0.00"
            Me.txtTotalSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalIVA
            '
            Me.txtTotalIVA.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalIVA.Location = New System.Drawing.Point(717, 13)
            Me.txtTotalIVA.Name = "txtTotalIVA"
            Me.txtTotalIVA.Size = New System.Drawing.Size(89, 22)
            Me.txtTotalIVA.TabIndex = 6
            Me.txtTotalIVA.Text = "0.00"
            Me.txtTotalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalFacturas
            '
            Me.txtTotalFacturas.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturas.Location = New System.Drawing.Point(931, 13)
            Me.txtTotalFacturas.Name = "txtTotalFacturas"
            Me.txtTotalFacturas.Size = New System.Drawing.Size(89, 22)
            Me.txtTotalFacturas.TabIndex = 4
            Me.txtTotalFacturas.Text = "0.00"
            Me.txtTotalFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(615, 53)
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.ReadOnly = True
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(44, 38)
            Me.dgvFacturaVenta.TabIndex = 105
            '
            'dgvDetalleFacturaVenta
            '
            Me.dgvDetalleFacturaVenta.AllowUserToAddRows = False
            Me.dgvDetalleFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvDetalleFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleFacturaVenta.Location = New System.Drawing.Point(534, 171)
            Me.dgvDetalleFacturaVenta.Name = "dgvDetalleFacturaVenta"
            Me.dgvDetalleFacturaVenta.ReadOnly = True
            Me.dgvDetalleFacturaVenta.Size = New System.Drawing.Size(192, 115)
            Me.dgvDetalleFacturaVenta.TabIndex = 106
            '
            'dgvCliente
            '
            Me.dgvCliente.AllowUserToAddRows = False
            Me.dgvCliente.AllowUserToDeleteRows = False
            Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCliente.Location = New System.Drawing.Point(548, 53)
            Me.dgvCliente.Name = "dgvCliente"
            Me.dgvCliente.ReadOnly = True
            Me.dgvCliente.Size = New System.Drawing.Size(44, 38)
            Me.dgvCliente.TabIndex = 107
            Me.dgvCliente.Visible = False
            '
            'rbTodas
            '
            Me.rbTodas.AutoSize = True
            Me.rbTodas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbTodas.Checked = True
            Me.rbTodas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTodas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTodas.Location = New System.Drawing.Point(626, 24)
            Me.rbTodas.Name = "rbTodas"
            Me.rbTodas.Size = New System.Drawing.Size(55, 17)
            Me.rbTodas.TabIndex = 2
            Me.rbTodas.TabStop = True
            Me.rbTodas.Text = "Todas"
            Me.rbTodas.UseVisualStyleBackColor = False
            '
            'rbAnuladas
            '
            Me.rbAnuladas.AutoSize = True
            Me.rbAnuladas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbAnuladas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbAnuladas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbAnuladas.Location = New System.Drawing.Point(553, 24)
            Me.rbAnuladas.Name = "rbAnuladas"
            Me.rbAnuladas.Size = New System.Drawing.Size(71, 17)
            Me.rbAnuladas.TabIndex = 1
            Me.rbAnuladas.Text = "Anuladas"
            Me.rbAnuladas.UseVisualStyleBackColor = False
            '
            'rbActivas
            '
            Me.rbActivas.AutoSize = True
            Me.rbActivas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbActivas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbActivas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbActivas.Location = New System.Drawing.Point(488, 24)
            Me.rbActivas.Name = "rbActivas"
            Me.rbActivas.Size = New System.Drawing.Size(62, 17)
            Me.rbActivas.TabIndex = 0
            Me.rbActivas.Text = "Activas"
            Me.rbActivas.UseVisualStyleBackColor = False
            '
            'rbNroNotaCredito
            '
            Me.rbNroNotaCredito.AutoSize = True
            Me.rbNroNotaCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbNroNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNroNotaCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbNroNotaCredito.Location = New System.Drawing.Point(99, 3)
            Me.rbNroNotaCredito.Name = "rbNroNotaCredito"
            Me.rbNroNotaCredito.Size = New System.Drawing.Size(70, 17)
            Me.rbNroNotaCredito.TabIndex = 34
            Me.rbNroNotaCredito.Text = "Nro Nota"
            Me.rbNroNotaCredito.UseVisualStyleBackColor = False
            '
            'rbConsorcio
            '
            Me.rbConsorcio.AutoSize = True
            Me.rbConsorcio.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbConsorcio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbConsorcio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbConsorcio.Location = New System.Drawing.Point(9, 21)
            Me.rbConsorcio.Name = "rbConsorcio"
            Me.rbConsorcio.Size = New System.Drawing.Size(55, 17)
            Me.rbConsorcio.TabIndex = 24
            Me.rbConsorcio.Text = "Grupo"
            Me.rbConsorcio.UseVisualStyleBackColor = False
            '
            'rbPorCliente
            '
            Me.rbPorCliente.AutoSize = True
            Me.rbPorCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPorCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPorCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPorCliente.Location = New System.Drawing.Point(9, 3)
            Me.rbPorCliente.Name = "rbPorCliente"
            Me.rbPorCliente.Size = New System.Drawing.Size(80, 17)
            Me.rbPorCliente.TabIndex = 1
            Me.rbPorCliente.Text = "Por Cliente"
            Me.rbPorCliente.UseVisualStyleBackColor = False
            '
            'rbTodo
            '
            Me.rbTodo.AutoSize = True
            Me.rbTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbTodo.Checked = True
            Me.rbTodo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTodo.Location = New System.Drawing.Point(99, 23)
            Me.rbTodo.Name = "rbTodo"
            Me.rbTodo.Size = New System.Drawing.Size(49, 17)
            Me.rbTodo.TabIndex = 0
            Me.rbTodo.TabStop = True
            Me.rbTodo.Text = "Todo"
            Me.rbTodo.UseVisualStyleBackColor = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportar, Me.btnSalir, Me.GENERARRIDEToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1041, 32)
            Me.MenuStrip1.TabIndex = 191
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(84, 28)
            Me.btnBuscar.Text = "BUSCAR"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(96, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.syscisepro.My.Resources.Resources.checkbook_20dp_FILL0_wght400_GRAD0_opsz20__2_
            Me.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(116, 28)
            Me.btnSalir.Text = "GENERAR XML"
            '
            'GENERARRIDEToolStripMenuItem
            '
            Me.GENERARRIDEToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.GENERARRIDEToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.pdf
            Me.GENERARRIDEToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.GENERARRIDEToolStripMenuItem.Name = "GENERARRIDEToolStripMenuItem"
            Me.GENERARRIDEToolStripMenuItem.Size = New System.Drawing.Size(67, 28)
            Me.GENERARRIDEToolStripMenuItem.Text = "RIDE"
            '
            'ofdSeleccionarArchivo
            '
            Me.ofdSeleccionarArchivo.FileName = "OpenFileDialog1"
            '
            'btnNotaCreditoPath
            '
            Me.btnNotaCreditoPath.BackColor = System.Drawing.Color.Transparent
            Me.btnNotaCreditoPath.FlatAppearance.BorderSize = 0
            Me.btnNotaCreditoPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNotaCreditoPath.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnNotaCreditoPath.Location = New System.Drawing.Point(736, 3)
            Me.btnNotaCreditoPath.Name = "btnNotaCreditoPath"
            Me.btnNotaCreditoPath.Size = New System.Drawing.Size(28, 28)
            Me.btnNotaCreditoPath.TabIndex = 2
            Me.btnNotaCreditoPath.UseVisualStyleBackColor = False
            '
            'txtNotaCreditoPath
            '
            Me.txtNotaCreditoPath.Enabled = False
            Me.txtNotaCreditoPath.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNotaCreditoPath.Location = New System.Drawing.Point(156, 4)
            Me.txtNotaCreditoPath.Name = "txtNotaCreditoPath"
            Me.txtNotaCreditoPath.Size = New System.Drawing.Size(574, 23)
            Me.txtNotaCreditoPath.TabIndex = 1
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(1, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdFacturaVenta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumeroFacturaBuscar)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbTodas)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbAnuladas)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbActivas)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbNroNotaCredito)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbPorCliente)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbConsorcio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbTodo)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(1038, 80)
            Me.KryptonGroupBox1.TabIndex = 193
            Me.KryptonGroupBox1.Values.Heading = "Tipo"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(911, 2)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(87, 20)
            Me.KryptonLabel5.TabIndex = 39
            Me.KryptonLabel5.Values.Text = "Nro N Credito"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(802, 1)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel4.TabIndex = 38
            Me.KryptonLabel4.Values.Text = "Hasta"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(695, 1)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel3.TabIndex = 37
            Me.KryptonLabel3.Values.Text = "Desde"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(489, 2)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(90, 20)
            Me.KryptonLabel2.TabIndex = 36
            Me.KryptonLabel2.Values.Text = "Estado Factura"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(176, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel1.TabIndex = 35
            Me.KryptonLabel1.Values.Text = "Cliente"
            '
            'MetroTabControl1
            '
            Me.MetroTabControl1.AnimateEasingType = ReaLTaiizor.[Enum].Metro.EasingType.CubeOut
            Me.MetroTabControl1.AnimateTime = 200
            Me.MetroTabControl1.BackgroundColor = System.Drawing.Color.White
            Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
            Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
            Me.MetroTabControl1.ControlsVisible = True
            Me.MetroTabControl1.IsDerivedStyle = True
            Me.MetroTabControl1.ItemSize = New System.Drawing.Size(100, 38)
            Me.MetroTabControl1.Location = New System.Drawing.Point(1, 120)
            Me.MetroTabControl1.MCursor = System.Windows.Forms.Cursors.Hand
            Me.MetroTabControl1.Name = "MetroTabControl1"
            Me.MetroTabControl1.SelectedIndex = 0
            Me.MetroTabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
            Me.MetroTabControl1.Size = New System.Drawing.Size(1038, 413)
            Me.MetroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
            Me.MetroTabControl1.Speed = 100
            Me.MetroTabControl1.Style = ReaLTaiizor.[Enum].Metro.Style.Light
            Me.MetroTabControl1.StyleManager = Nothing
            Me.MetroTabControl1.TabIndex = 194
            Me.MetroTabControl1.TabStyle = ReaLTaiizor.[Enum].Metro.TabStyle.Style2
            Me.MetroTabControl1.ThemeAuthor = "Taiizor"
            Me.MetroTabControl1.ThemeName = "MetroLight"
            Me.MetroTabControl1.UnselectedTextColor = System.Drawing.Color.Gray
            '
            'MetroTabPage1
            '
            Me.MetroTabPage1.BaseColor = System.Drawing.Color.White
            Me.MetroTabPage1.Controls.Add(Me.dgvNotaCredito)
            Me.MetroTabPage1.Font = Nothing
            Me.MetroTabPage1.ImageIndex = 0
            Me.MetroTabPage1.ImageKey = Nothing
            Me.MetroTabPage1.IsDerivedStyle = True
            Me.MetroTabPage1.Location = New System.Drawing.Point(4, 42)
            Me.MetroTabPage1.Name = "MetroTabPage1"
            Me.MetroTabPage1.Size = New System.Drawing.Size(1030, 367)
            Me.MetroTabPage1.Style = ReaLTaiizor.[Enum].Metro.Style.Light
            Me.MetroTabPage1.StyleManager = Nothing
            Me.MetroTabPage1.TabIndex = 0
            Me.MetroTabPage1.Text = "Consulta"
            Me.MetroTabPage1.ThemeAuthor = "Taiizor"
            Me.MetroTabPage1.ThemeName = "MetroLight"
            Me.MetroTabPage1.ToolTipText = Nothing
            '
            'MetroTabPage2
            '
            Me.MetroTabPage2.BaseColor = System.Drawing.Color.White
            Me.MetroTabPage2.Controls.Add(Me.KryptonGroupBox2)
            Me.MetroTabPage2.Font = Nothing
            Me.MetroTabPage2.ImageIndex = 0
            Me.MetroTabPage2.ImageKey = Nothing
            Me.MetroTabPage2.IsDerivedStyle = True
            Me.MetroTabPage2.Location = New System.Drawing.Point(4, 42)
            Me.MetroTabPage2.Name = "MetroTabPage2"
            Me.MetroTabPage2.Size = New System.Drawing.Size(1030, 366)
            Me.MetroTabPage2.Style = ReaLTaiizor.[Enum].Metro.Style.Light
            Me.MetroTabPage2.StyleManager = Nothing
            Me.MetroTabPage2.TabIndex = 1
            Me.MetroTabPage2.Text = "Ruta de Documento"
            Me.MetroTabPage2.ThemeAuthor = "Taiizor"
            Me.MetroTabPage2.ThemeName = "MetroLight"
            Me.MetroTabPage2.ToolTipText = Nothing
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(12, 20)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnNotaCreditoPath)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtNotaCreditoPath)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(784, 70)
            Me.KryptonGroupBox2.TabIndex = 0
            Me.KryptonGroupBox2.Values.Heading = "Seleccione Ruta"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(7, 6)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(143, 20)
            Me.KryptonLabel6.TabIndex = 0
            Me.KryptonLabel6.Values.Text = "Ruta de Nota de Credito"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(0, 538)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalSubtotal)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalIVA)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalFacturas)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblIva)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblSubtotalIva)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(1039, 56)
            Me.KryptonGroupBox3.TabIndex = 195
            Me.KryptonGroupBox3.Values.Heading = ""
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(831, 16)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(96, 20)
            Me.KryptonLabel9.TabIndex = 2
            Me.KryptonLabel9.Values.Text = "Total N. Credito"
            '
            'lblIva
            '
            Me.lblIva.Location = New System.Drawing.Point(675, 16)
            Me.lblIva.Name = "lblIva"
            Me.lblIva.Size = New System.Drawing.Size(29, 20)
            Me.lblIva.TabIndex = 1
            Me.lblIva.Values.Text = "IVA"
            '
            'lblSubtotalIva
            '
            Me.lblSubtotalIva.Location = New System.Drawing.Point(485, 16)
            Me.lblSubtotalIva.Name = "lblSubtotalIva"
            Me.lblSubtotalIva.Size = New System.Drawing.Size(59, 20)
            Me.lblSubtotalIva.TabIndex = 0
            Me.lblSubtotalIva.Values.Text = "SubTotal"
            '
            'FormConsultaNotasCredito
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1041, 594)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.MetroTabControl1)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvFacturaVenta)
            Me.Controls.Add(Me.dgvCliente)
            Me.Controls.Add(Me.dgvDetalleFacturaVenta)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormConsultaNotasCredito"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CONSULTA NOTAS DE CREDITO"
            CType(Me.dgvNotaCredito, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.MetroTabControl1.ResumeLayout(False)
            Me.MetroTabPage1.ResumeLayout(False)
            Me.MetroTabPage2.ResumeLayout(False)
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
        Friend WithEvents txtNumeroFacturaBuscar As System.Windows.Forms.TextBox
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents dgvNotaCredito As System.Windows.Forms.DataGridView
        Friend WithEvents txtTotalSubtotal As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalIVA As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalFacturas As System.Windows.Forms.TextBox
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
        Friend WithEvents rbTodas As System.Windows.Forms.RadioButton
        Friend WithEvents rbAnuladas As System.Windows.Forms.RadioButton
        Friend WithEvents rbActivas As System.Windows.Forms.RadioButton
        Friend WithEvents rbNroNotaCredito As System.Windows.Forms.RadioButton
        Friend WithEvents rbConsorcio As System.Windows.Forms.RadioButton
        Friend WithEvents rbPorCliente As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodo As System.Windows.Forms.RadioButton
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnSalir As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GENERARRIDEToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ofdSeleccionarArchivo As OpenFileDialog
        Friend WithEvents btnNotaCreditoPath As Button
        Friend WithEvents txtNotaCreditoPath As TextBox
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents MetroTabControl1 As ReaLTaiizor.Controls.MetroTabControl
        Friend WithEvents MetroTabPage1 As ReaLTaiizor.Child.Metro.MetroTabPage
        Friend WithEvents MetroTabPage2 As ReaLTaiizor.Child.Metro.MetroTabPage
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblIva As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblSubtotalIva As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace