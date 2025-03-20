Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormConsultaFacturasVenta
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaFacturasVenta))
            Me.txtClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.txtTotalACobrar = New System.Windows.Forms.TextBox()
            Me.txtTotalRetencion = New System.Windows.Forms.TextBox()
            Me.txtTotalFacturas = New System.Windows.Forms.TextBox()
            Me.txtTotalIVA = New System.Windows.Forms.TextBox()
            Me.txtTotalSubtotal = New System.Windows.Forms.TextBox()
            Me.lblNroRegistros = New System.Windows.Forms.Label()
            Me.txtTotalNotaCredito = New System.Windows.Forms.TextBox()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.rbFacturasActivas = New System.Windows.Forms.RadioButton()
            Me.rbFacturasAnuladas = New System.Windows.Forms.RadioButton()
            Me.rbFacturasTodas = New System.Windows.Forms.RadioButton()
            Me.rbConcepto = New System.Windows.Forms.RadioButton()
            Me.rbNroFactura = New System.Windows.Forms.RadioButton()
            Me.rbConsorcio = New System.Windows.Forms.RadioButton()
            Me.rbPorCliente = New System.Windows.Forms.RadioButton()
            Me.rbTodo = New System.Windows.Forms.RadioButton()
            Me.dgvEmpresa = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnSalir = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.REPORTEDEVENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ESTADÍSTICOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnValidar = New System.Windows.Forms.ToolStripMenuItem()
            Me.GENERARFACTURAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnFacturaPath = New System.Windows.Forms.Button()
            Me.txtFacturaPath = New System.Windows.Forms.TextBox()
            Me.ofdSeleccionarArchivo = New System.Windows.Forms.OpenFileDialog()
            Me.MetroTabControl1 = New ReaLTaiizor.Controls.MetroTabControl()
            Me.MetroTabPage1 = New ReaLTaiizor.Child.Metro.MetroTabPage()
            Me.MetroTabPage2 = New ReaLTaiizor.Child.Metro.MetroTabPage()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.MetroTabControl1.SuspendLayout()
            Me.MetroTabPage1.SuspendLayout()
            Me.MetroTabPage2.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtClienteGeneral
            '
            Me.txtClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtClienteGeneral.Enabled = False
            Me.txtClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtClienteGeneral.Location = New System.Drawing.Point(225, 22)
            Me.txtClienteGeneral.Name = "txtClienteGeneral"
            Me.txtClienteGeneral.Size = New System.Drawing.Size(306, 21)
            Me.txtClienteGeneral.TabIndex = 31
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdClienteGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(300, 3)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(13, 13)
            Me.lblIdClienteGeneral.TabIndex = 30
            Me.lblIdClienteGeneral.Text = "0"
            '
            'txtTotalACobrar
            '
            Me.txtTotalACobrar.BackColor = System.Drawing.Color.White
            Me.txtTotalACobrar.Enabled = False
            Me.txtTotalACobrar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalACobrar.Location = New System.Drawing.Point(933, 10)
            Me.txtTotalACobrar.Name = "txtTotalACobrar"
            Me.txtTotalACobrar.Size = New System.Drawing.Size(73, 21)
            Me.txtTotalACobrar.TabIndex = 0
            Me.txtTotalACobrar.Text = "0.00"
            Me.txtTotalACobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalRetencion
            '
            Me.txtTotalRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalRetencion.Enabled = False
            Me.txtTotalRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalRetencion.Location = New System.Drawing.Point(596, 9)
            Me.txtTotalRetencion.Name = "txtTotalRetencion"
            Me.txtTotalRetencion.Size = New System.Drawing.Size(65, 21)
            Me.txtTotalRetencion.TabIndex = 2
            Me.txtTotalRetencion.Text = "0.00"
            Me.txtTotalRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalFacturas
            '
            Me.txtTotalFacturas.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturas.Enabled = False
            Me.txtTotalFacturas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturas.Location = New System.Drawing.Point(438, 8)
            Me.txtTotalFacturas.Name = "txtTotalFacturas"
            Me.txtTotalFacturas.Size = New System.Drawing.Size(75, 21)
            Me.txtTotalFacturas.TabIndex = 4
            Me.txtTotalFacturas.Text = "0.00"
            Me.txtTotalFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalIVA
            '
            Me.txtTotalIVA.BackColor = System.Drawing.Color.White
            Me.txtTotalIVA.Enabled = False
            Me.txtTotalIVA.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalIVA.Location = New System.Drawing.Point(285, 9)
            Me.txtTotalIVA.Name = "txtTotalIVA"
            Me.txtTotalIVA.Size = New System.Drawing.Size(68, 21)
            Me.txtTotalIVA.TabIndex = 6
            Me.txtTotalIVA.Text = "0.00"
            Me.txtTotalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalSubtotal
            '
            Me.txtTotalSubtotal.BackColor = System.Drawing.Color.White
            Me.txtTotalSubtotal.Enabled = False
            Me.txtTotalSubtotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalSubtotal.Location = New System.Drawing.Point(168, 10)
            Me.txtTotalSubtotal.Name = "txtTotalSubtotal"
            Me.txtTotalSubtotal.Size = New System.Drawing.Size(72, 21)
            Me.txtTotalSubtotal.TabIndex = 8
            Me.txtTotalSubtotal.Text = "0.00"
            Me.txtTotalSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblNroRegistros
            '
            Me.lblNroRegistros.AutoSize = True
            Me.lblNroRegistros.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblNroRegistros.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroRegistros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblNroRegistros.Location = New System.Drawing.Point(69, 12)
            Me.lblNroRegistros.Name = "lblNroRegistros"
            Me.lblNroRegistros.Size = New System.Drawing.Size(13, 13)
            Me.lblNroRegistros.TabIndex = 13
            Me.lblNroRegistros.Text = "0"
            '
            'txtTotalNotaCredito
            '
            Me.txtTotalNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtTotalNotaCredito.Enabled = False
            Me.txtTotalNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalNotaCredito.Location = New System.Drawing.Point(765, 10)
            Me.txtTotalNotaCredito.Name = "txtTotalNotaCredito"
            Me.txtTotalNotaCredito.Size = New System.Drawing.Size(66, 21)
            Me.txtTotalNotaCredito.TabIndex = 10
            Me.txtTotalNotaCredito.Text = "0.00"
            Me.txtTotalNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvFacturaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturaVenta.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(0, 0)
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.ReadOnly = True
            Me.dgvFacturaVenta.RowHeadersVisible = False
            Me.dgvFacturaVenta.RowHeadersWidth = 25
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(1013, 326)
            Me.dgvFacturaVenta.TabIndex = 51
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(736, 20)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(85, 21)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(834, 20)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(86, 21)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(899, 1)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(16, 13)
            Me.lblIdFacturaVenta.TabIndex = 4
            Me.lblIdFacturaVenta.Text = "..."
            Me.lblIdFacturaVenta.Visible = False
            '
            'rbFacturasActivas
            '
            Me.rbFacturasActivas.AutoSize = True
            Me.rbFacturasActivas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbFacturasActivas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbFacturasActivas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbFacturasActivas.Location = New System.Drawing.Point(535, 25)
            Me.rbFacturasActivas.Name = "rbFacturasActivas"
            Me.rbFacturasActivas.Size = New System.Drawing.Size(62, 17)
            Me.rbFacturasActivas.TabIndex = 0
            Me.rbFacturasActivas.Text = "Activas"
            Me.rbFacturasActivas.UseVisualStyleBackColor = False
            '
            'rbFacturasAnuladas
            '
            Me.rbFacturasAnuladas.AutoSize = True
            Me.rbFacturasAnuladas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbFacturasAnuladas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbFacturasAnuladas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbFacturasAnuladas.Location = New System.Drawing.Point(595, 25)
            Me.rbFacturasAnuladas.Name = "rbFacturasAnuladas"
            Me.rbFacturasAnuladas.Size = New System.Drawing.Size(71, 17)
            Me.rbFacturasAnuladas.TabIndex = 1
            Me.rbFacturasAnuladas.Text = "Anuladas"
            Me.rbFacturasAnuladas.UseVisualStyleBackColor = False
            '
            'rbFacturasTodas
            '
            Me.rbFacturasTodas.AutoSize = True
            Me.rbFacturasTodas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbFacturasTodas.Checked = True
            Me.rbFacturasTodas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbFacturasTodas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbFacturasTodas.Location = New System.Drawing.Point(664, 25)
            Me.rbFacturasTodas.Name = "rbFacturasTodas"
            Me.rbFacturasTodas.Size = New System.Drawing.Size(55, 17)
            Me.rbFacturasTodas.TabIndex = 2
            Me.rbFacturasTodas.TabStop = True
            Me.rbFacturasTodas.Text = "Todas"
            Me.rbFacturasTodas.UseVisualStyleBackColor = False
            '
            'rbConcepto
            '
            Me.rbConcepto.AutoSize = True
            Me.rbConcepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbConcepto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbConcepto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbConcepto.Location = New System.Drawing.Point(95, 1)
            Me.rbConcepto.Name = "rbConcepto"
            Me.rbConcepto.Size = New System.Drawing.Size(72, 17)
            Me.rbConcepto.TabIndex = 35
            Me.rbConcepto.Text = "Concepto"
            Me.rbConcepto.UseVisualStyleBackColor = False
            '
            'rbNroFactura
            '
            Me.rbNroFactura.AutoSize = True
            Me.rbNroFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbNroFactura.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNroFactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbNroFactura.Location = New System.Drawing.Point(8, 21)
            Me.rbNroFactura.Name = "rbNroFactura"
            Me.rbNroFactura.Size = New System.Drawing.Size(84, 17)
            Me.rbNroFactura.TabIndex = 34
            Me.rbNroFactura.Text = "Nro Factura"
            Me.rbNroFactura.UseVisualStyleBackColor = False
            '
            'rbConsorcio
            '
            Me.rbConsorcio.AutoSize = True
            Me.rbConsorcio.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbConsorcio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbConsorcio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbConsorcio.Location = New System.Drawing.Point(95, 19)
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
            Me.rbPorCliente.Location = New System.Drawing.Point(8, 3)
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
            Me.rbTodo.Location = New System.Drawing.Point(170, 1)
            Me.rbTodo.Name = "rbTodo"
            Me.rbTodo.Size = New System.Drawing.Size(49, 17)
            Me.rbTodo.TabIndex = 0
            Me.rbTodo.TabStop = True
            Me.rbTodo.Text = "Todo"
            Me.rbTodo.UseVisualStyleBackColor = False
            '
            'dgvEmpresa
            '
            Me.dgvEmpresa.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvEmpresa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvEmpresa.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvEmpresa.Location = New System.Drawing.Point(251, 56)
            Me.dgvEmpresa.Name = "dgvEmpresa"
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvEmpresa.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvEmpresa.Size = New System.Drawing.Size(33, 22)
            Me.dgvEmpresa.TabIndex = 105
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnSalir, Me.btnReporte, Me.btnExportar, Me.btnValidar, Me.GENERARFACTURAToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1026, 32)
            Me.MenuStrip1.TabIndex = 190
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(87, 28)
            Me.btnBuscar.Text = "BUSCAR"
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
            'btnReporte
            '
            Me.btnReporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTEDEVENTASToolStripMenuItem, Me.ESTADÍSTICOToolStripMenuItem})
            Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(90, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'REPORTEDEVENTASToolStripMenuItem
            '
            Me.REPORTEDEVENTASToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.REPORTEDEVENTASToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.REPORTEDEVENTASToolStripMenuItem.Name = "REPORTEDEVENTASToolStripMenuItem"
            Me.REPORTEDEVENTASToolStripMenuItem.Size = New System.Drawing.Size(202, 30)
            Me.REPORTEDEVENTASToolStripMenuItem.Text = "REPORTE DE VENTAS"
            '
            'ESTADÍSTICOToolStripMenuItem
            '
            Me.ESTADÍSTICOToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.finance_mode_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ESTADÍSTICOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ESTADÍSTICOToolStripMenuItem.Name = "ESTADÍSTICOToolStripMenuItem"
            Me.ESTADÍSTICOToolStripMenuItem.Size = New System.Drawing.Size(202, 30)
            Me.ESTADÍSTICOToolStripMenuItem.Text = "RESÚMEN ESTADÍSTICO"
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
            'btnValidar
            '
            Me.btnValidar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnValidar.Image = Global.syscisepro.My.Resources.Resources.check_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnValidar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnValidar.Name = "btnValidar"
            Me.btnValidar.Size = New System.Drawing.Size(86, 28)
            Me.btnValidar.Text = "VALIDAR"
            '
            'GENERARFACTURAToolStripMenuItem
            '
            Me.GENERARFACTURAToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.pdf
            Me.GENERARFACTURAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.GENERARFACTURAToolStripMenuItem.Name = "GENERARFACTURAToolStripMenuItem"
            Me.GENERARFACTURAToolStripMenuItem.Size = New System.Drawing.Size(93, 28)
            Me.GENERARFACTURAToolStripMenuItem.Text = "FACTURA"
            '
            'btnFacturaPath
            '
            Me.btnFacturaPath.BackColor = System.Drawing.Color.Transparent
            Me.btnFacturaPath.FlatAppearance.BorderSize = 0
            Me.btnFacturaPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnFacturaPath.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnFacturaPath.Location = New System.Drawing.Point(739, 11)
            Me.btnFacturaPath.Name = "btnFacturaPath"
            Me.btnFacturaPath.Size = New System.Drawing.Size(28, 28)
            Me.btnFacturaPath.TabIndex = 2
            Me.btnFacturaPath.UseVisualStyleBackColor = False
            '
            'txtFacturaPath
            '
            Me.txtFacturaPath.Enabled = False
            Me.txtFacturaPath.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFacturaPath.Location = New System.Drawing.Point(109, 11)
            Me.txtFacturaPath.Name = "txtFacturaPath"
            Me.txtFacturaPath.Size = New System.Drawing.Size(621, 21)
            Me.txtFacturaPath.TabIndex = 1
            '
            'ofdSeleccionarArchivo
            '
            Me.ofdSeleccionarArchivo.FileName = "OpenFileDialog1"
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
            Me.MetroTabControl1.Location = New System.Drawing.Point(1, 118)
            Me.MetroTabControl1.MCursor = System.Windows.Forms.Cursors.Hand
            Me.MetroTabControl1.Name = "MetroTabControl1"
            Me.MetroTabControl1.SelectedIndex = 0
            Me.MetroTabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
            Me.MetroTabControl1.Size = New System.Drawing.Size(1021, 372)
            Me.MetroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
            Me.MetroTabControl1.Speed = 100
            Me.MetroTabControl1.Style = ReaLTaiizor.[Enum].Metro.Style.Light
            Me.MetroTabControl1.StyleManager = Nothing
            Me.MetroTabControl1.TabIndex = 191
            Me.MetroTabControl1.TabStyle = ReaLTaiizor.[Enum].Metro.TabStyle.Style2
            Me.MetroTabControl1.ThemeAuthor = "Taiizor"
            Me.MetroTabControl1.ThemeName = "MetroLight"
            Me.MetroTabControl1.UnselectedTextColor = System.Drawing.Color.Gray
            '
            'MetroTabPage1
            '
            Me.MetroTabPage1.BaseColor = System.Drawing.Color.White
            Me.MetroTabPage1.Controls.Add(Me.dgvFacturaVenta)
            Me.MetroTabPage1.Font = Nothing
            Me.MetroTabPage1.ImageIndex = 0
            Me.MetroTabPage1.ImageKey = Nothing
            Me.MetroTabPage1.IsDerivedStyle = True
            Me.MetroTabPage1.Location = New System.Drawing.Point(4, 42)
            Me.MetroTabPage1.Name = "MetroTabPage1"
            Me.MetroTabPage1.Size = New System.Drawing.Size(1013, 326)
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
            Me.MetroTabPage2.Size = New System.Drawing.Size(1013, 326)
            Me.MetroTabPage2.Style = ReaLTaiizor.[Enum].Metro.Style.Light
            Me.MetroTabPage2.StyleManager = Nothing
            Me.MetroTabPage2.TabIndex = 1
            Me.MetroTabPage2.Text = "Ruta Documentos"
            Me.MetroTabPage2.ThemeAuthor = "Taiizor"
            Me.MetroTabPage2.ThemeName = "MetroLight"
            Me.MetroTabPage2.ToolTipText = Nothing
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(7, 19)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnFacturaPath)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtFacturaPath)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(799, 89)
            Me.KryptonGroupBox2.TabIndex = 0
            Me.KryptonGroupBox2.Values.Heading = "Seleccione la Ruta"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(7, 12)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(96, 20)
            Me.KryptonLabel5.TabIndex = 0
            Me.KryptonLabel5.Values.Text = "Ruta de Factura"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 37)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdFacturaVenta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbFacturasTodas)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbFacturasAnuladas)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbFacturasActivas)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbConcepto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbPorCliente)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbNroFactura)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbTodo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbConsorcio)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(1022, 75)
            Me.KryptonGroupBox1.TabIndex = 192
            Me.KryptonGroupBox1.Values.Heading = "Tipo"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(836, -3)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel4.TabIndex = 39
            Me.KryptonLabel4.Values.Text = "Hasta"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(736, -3)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel3.TabIndex = 38
            Me.KryptonLabel3.Values.Text = "Desde"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(535, -2)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(107, 20)
            Me.KryptonLabel2.TabIndex = 37
            Me.KryptonLabel2.Values.Text = "Estado de Factura"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(225, 0)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel1.TabIndex = 36
            Me.KryptonLabel1.Values.Text = "Cliente"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(1, 500)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalNotaCredito)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalACobrar)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblNroRegistros)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalSubtotal)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalRetencion)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalFacturas)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalIVA)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(1021, 55)
            Me.KryptonGroupBox3.TabIndex = 193
            Me.KryptonGroupBox3.Values.Heading = ""
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(839, 11)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(88, 20)
            Me.KryptonLabel12.TabIndex = 19
            Me.KryptonLabel12.Values.Text = "Total a Cobrar"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(671, 10)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(91, 20)
            Me.KryptonLabel11.TabIndex = 18
            Me.KryptonLabel11.Values.Text = "T Nota Credito"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(519, 8)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel10.TabIndex = 17
            Me.KryptonLabel10.Values.Text = "T Retencion"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(367, 10)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(65, 20)
            Me.KryptonLabel9.TabIndex = 16
            Me.KryptonLabel9.Values.Text = "T Facturas"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(254, 11)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(29, 20)
            Me.KryptonLabel8.TabIndex = 15
            Me.KryptonLabel8.Values.Text = "IVA"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(107, 10)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel7.TabIndex = 14
            Me.KryptonLabel7.Values.Text = "SubTotal"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(7, 10)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel6.TabIndex = 0
            Me.KryptonLabel6.Values.Text = "Nro Reg"
            '
            'FormConsultaFacturasVenta
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1026, 556)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MetroTabControl1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvEmpresa)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormConsultaFacturasVenta"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CONSULTA DE FACTURAS"
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.MetroTabControl1.ResumeLayout(False)
            Me.MetroTabPage1.ResumeLayout(False)
            Me.MetroTabPage2.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            Me.KryptonGroupBox2.Panel.PerformLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            Me.KryptonGroupBox3.Panel.PerformLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents txtClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalACobrar As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalFacturas As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalIVA As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalSubtotal As System.Windows.Forms.TextBox
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents rbFacturasActivas As System.Windows.Forms.RadioButton
        Friend WithEvents rbFacturasAnuladas As System.Windows.Forms.RadioButton
        Friend WithEvents rbFacturasTodas As System.Windows.Forms.RadioButton
        Friend WithEvents rbConsorcio As System.Windows.Forms.RadioButton
        Friend WithEvents rbPorCliente As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodo As System.Windows.Forms.RadioButton
        Friend WithEvents rbNroFactura As System.Windows.Forms.RadioButton
        Friend WithEvents rbConcepto As System.Windows.Forms.RadioButton
        Friend WithEvents txtTotalNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents lblNroRegistros As System.Windows.Forms.Label
        Friend WithEvents dgvEmpresa As System.Windows.Forms.DataGridView
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnValidar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnSalir As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents REPORTEDEVENTASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ESTADÍSTICOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GENERARFACTURAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ofdSeleccionarArchivo As System.Windows.Forms.OpenFileDialog
        Friend WithEvents btnFacturaPath As System.Windows.Forms.Button
        Friend WithEvents txtFacturaPath As System.Windows.Forms.TextBox
        Friend WithEvents MetroTabControl1 As ReaLTaiizor.Controls.MetroTabControl
        Friend WithEvents MetroTabPage1 As ReaLTaiizor.Child.Metro.MetroTabPage
        Friend WithEvents MetroTabPage2 As ReaLTaiizor.Child.Metro.MetroTabPage
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace