Namespace FORMULARIOS.CONTABILIDAD.CUENTAS_POR_COBRAR
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCuentasPorCobrarGeneralClienteNoConvenio
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
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.txtTotalNotaCredito = New System.Windows.Forms.TextBox()
            Me.txtTotalCuentasPorCobrar = New System.Windows.Forms.TextBox()
            Me.txtTotalAbonado = New System.Windows.Forms.TextBox()
            Me.txtTotalFacturas = New System.Windows.Forms.TextBox()
            Me.txtTotalRetencion = New System.Windows.Forms.TextBox()
            Me.txtTotalACobrar = New System.Windows.Forms.TextBox()
            Me.txtNombreComercialClienteGeneral = New System.Windows.Forms.TextBox()
            Me.rbPorCliente = New System.Windows.Forms.RadioButton()
            Me.rbGeneral = New System.Windows.Forms.RadioButton()
            Me.lblIdComprobanteEgresoBanco = New System.Windows.Forms.Label()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.dgvCuentasPorCobrar = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.txtCliente = New System.Windows.Forms.TextBox()
            Me.dtpHastaAcu = New System.Windows.Forms.DateTimePicker()
            Me.rbClienteAcu = New System.Windows.Forms.RadioButton()
            Me.dtpDesdeAcu = New System.Windows.Forms.DateTimePicker()
            Me.rbGeneralAcu = New System.Windows.Forms.RadioButton()
            Me.btnBuscarAcumulado = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.dgvClienteAcumulado = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
            Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Facturado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.uno_30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.treintauno_60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.sesenta_90 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.noventa_120 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cientoveinte = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.dgvCuentasPorCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            CType(Me.dgvClienteAcumulado, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportar, Me.ToolStripMenuItem1})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(879, 32)
            Me.MenuStrip1.TabIndex = 191
            Me.MenuStrip1.Text = "msIngresoBodega"
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
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(99, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.checkbook_20dp_FILL0_wght400_GRAD0_opsz20__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(110, 28)
            Me.ToolStripMenuItem1.Text = "PENDIENTES"
            '
            'txtTotalNotaCredito
            '
            Me.txtTotalNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtTotalNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalNotaCredito.Location = New System.Drawing.Point(361, 35)
            Me.txtTotalNotaCredito.Name = "txtTotalNotaCredito"
            Me.txtTotalNotaCredito.ReadOnly = True
            Me.txtTotalNotaCredito.Size = New System.Drawing.Size(95, 21)
            Me.txtTotalNotaCredito.TabIndex = 13
            Me.txtTotalNotaCredito.Text = "0.00"
            Me.txtTotalNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalCuentasPorCobrar
            '
            Me.txtTotalCuentasPorCobrar.BackColor = System.Drawing.Color.White
            Me.txtTotalCuentasPorCobrar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalCuentasPorCobrar.Location = New System.Drawing.Point(609, 36)
            Me.txtTotalCuentasPorCobrar.Name = "txtTotalCuentasPorCobrar"
            Me.txtTotalCuentasPorCobrar.ReadOnly = True
            Me.txtTotalCuentasPorCobrar.Size = New System.Drawing.Size(95, 21)
            Me.txtTotalCuentasPorCobrar.TabIndex = 0
            Me.txtTotalCuentasPorCobrar.Text = "0.00"
            Me.txtTotalCuentasPorCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalAbonado
            '
            Me.txtTotalAbonado.BackColor = System.Drawing.Color.White
            Me.txtTotalAbonado.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalAbonado.Location = New System.Drawing.Point(609, 8)
            Me.txtTotalAbonado.Name = "txtTotalAbonado"
            Me.txtTotalAbonado.ReadOnly = True
            Me.txtTotalAbonado.Size = New System.Drawing.Size(95, 21)
            Me.txtTotalAbonado.TabIndex = 10
            Me.txtTotalAbonado.Text = "0.00"
            Me.txtTotalAbonado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalFacturas
            '
            Me.txtTotalFacturas.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturas.Location = New System.Drawing.Point(118, 7)
            Me.txtTotalFacturas.Name = "txtTotalFacturas"
            Me.txtTotalFacturas.ReadOnly = True
            Me.txtTotalFacturas.Size = New System.Drawing.Size(95, 21)
            Me.txtTotalFacturas.TabIndex = 4
            Me.txtTotalFacturas.Text = "0.00"
            Me.txtTotalFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalRetencion
            '
            Me.txtTotalRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalRetencion.Location = New System.Drawing.Point(118, 35)
            Me.txtTotalRetencion.Name = "txtTotalRetencion"
            Me.txtTotalRetencion.ReadOnly = True
            Me.txtTotalRetencion.Size = New System.Drawing.Size(95, 21)
            Me.txtTotalRetencion.TabIndex = 2
            Me.txtTotalRetencion.Text = "0.00"
            Me.txtTotalRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalACobrar
            '
            Me.txtTotalACobrar.BackColor = System.Drawing.Color.White
            Me.txtTotalACobrar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalACobrar.Location = New System.Drawing.Point(361, 8)
            Me.txtTotalACobrar.Name = "txtTotalACobrar"
            Me.txtTotalACobrar.ReadOnly = True
            Me.txtTotalACobrar.Size = New System.Drawing.Size(95, 21)
            Me.txtTotalACobrar.TabIndex = 0
            Me.txtTotalACobrar.Text = "0.00"
            Me.txtTotalACobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNombreComercialClienteGeneral
            '
            Me.txtNombreComercialClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialClienteGeneral.Enabled = False
            Me.txtNombreComercialClienteGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialClienteGeneral.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtNombreComercialClienteGeneral.Location = New System.Drawing.Point(241, 3)
            Me.txtNombreComercialClienteGeneral.Name = "txtNombreComercialClienteGeneral"
            Me.txtNombreComercialClienteGeneral.Size = New System.Drawing.Size(304, 20)
            Me.txtNombreComercialClienteGeneral.TabIndex = 2
            '
            'rbPorCliente
            '
            Me.rbPorCliente.AutoSize = True
            Me.rbPorCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPorCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPorCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPorCliente.Location = New System.Drawing.Point(96, 6)
            Me.rbPorCliente.Name = "rbPorCliente"
            Me.rbPorCliente.Size = New System.Drawing.Size(60, 17)
            Me.rbPorCliente.TabIndex = 1
            Me.rbPorCliente.TabStop = True
            Me.rbPorCliente.Text = "Cliente"
            Me.rbPorCliente.UseVisualStyleBackColor = False
            '
            'rbGeneral
            '
            Me.rbGeneral.AutoSize = True
            Me.rbGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbGeneral.Checked = True
            Me.rbGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbGeneral.Location = New System.Drawing.Point(9, 7)
            Me.rbGeneral.Name = "rbGeneral"
            Me.rbGeneral.Size = New System.Drawing.Size(64, 17)
            Me.rbGeneral.TabIndex = 0
            Me.rbGeneral.TabStop = True
            Me.rbGeneral.Text = "General"
            Me.rbGeneral.UseVisualStyleBackColor = False
            '
            'lblIdComprobanteEgresoBanco
            '
            Me.lblIdComprobanteEgresoBanco.AutoSize = True
            Me.lblIdComprobanteEgresoBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteEgresoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteEgresoBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteEgresoBanco.Location = New System.Drawing.Point(624, 42)
            Me.lblIdComprobanteEgresoBanco.Name = "lblIdComprobanteEgresoBanco"
            Me.lblIdComprobanteEgresoBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteEgresoBanco.TabIndex = 3
            Me.lblIdComprobanteEgresoBanco.Text = "..."
            '
            'dtpHasta
            '
            Me.dtpHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(746, 3)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(88, 21)
            Me.dtpHasta.TabIndex = 1
            '
            'dtpDesde
            '
            Me.dtpDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(605, 2)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(85, 21)
            Me.dtpDesde.TabIndex = 0
            Me.dtpDesde.Value = New Date(2013, 1, 1, 0, 1, 0, 0)
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdClienteGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(277, 42)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdClienteGeneral.TabIndex = 76
            Me.lblIdClienteGeneral.Text = "..."
            '
            'dgvCuentasPorCobrar
            '
            Me.dgvCuentasPorCobrar.AllowUserToAddRows = False
            Me.dgvCuentasPorCobrar.AllowUserToDeleteRows = False
            Me.dgvCuentasPorCobrar.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCuentasPorCobrar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCuentasPorCobrar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvCuentasPorCobrar.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvCuentasPorCobrar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvCuentasPorCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCuentasPorCobrar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15})
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCuentasPorCobrar.DefaultCellStyle = DataGridViewCellStyle13
            Me.dgvCuentasPorCobrar.GridColor = System.Drawing.SystemColors.ControlLightLight
            Me.dgvCuentasPorCobrar.Location = New System.Drawing.Point(4, 62)
            Me.dgvCuentasPorCobrar.MultiSelect = False
            Me.dgvCuentasPorCobrar.Name = "dgvCuentasPorCobrar"
            Me.dgvCuentasPorCobrar.ReadOnly = True
            Me.dgvCuentasPorCobrar.RowHeadersVisible = False
            Me.dgvCuentasPorCobrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCuentasPorCobrar.Size = New System.Drawing.Size(860, 335)
            Me.dgvCuentasPorCobrar.TabIndex = 195
            '
            'Column1
            '
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
            Me.Column1.HeaderText = "ID CL"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 60
            '
            'Column2
            '
            Me.Column2.HeaderText = "RAZÓN SOCIAL (CLIENTE)"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 350
            '
            'Column3
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
            Me.Column3.HeaderText = "ID FACT"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 60
            '
            'Column4
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
            Me.Column4.HeaderText = "N° FACTURA"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 110
            '
            'Column5
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column5.DefaultCellStyle = DataGridViewCellStyle5
            Me.Column5.HeaderText = "FEC. EMISIÓN"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Width = 120
            '
            'Column6
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column6.DefaultCellStyle = DataGridViewCellStyle6
            Me.Column6.HeaderText = "FACTURADO"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.Width = 80
            '
            'Column7
            '
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column7.DefaultCellStyle = DataGridViewCellStyle7
            Me.Column7.HeaderText = "RETENIDO"
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.Width = 80
            '
            'Column8
            '
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column8.DefaultCellStyle = DataGridViewCellStyle8
            Me.Column8.HeaderText = "A COBRAR"
            Me.Column8.Name = "Column8"
            Me.Column8.ReadOnly = True
            Me.Column8.Width = 80
            '
            'Column9
            '
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column9.DefaultCellStyle = DataGridViewCellStyle9
            Me.Column9.HeaderText = "NOT. CRÉDITO"
            Me.Column9.Name = "Column9"
            Me.Column9.ReadOnly = True
            Me.Column9.Width = 80
            '
            'Column10
            '
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column10.DefaultCellStyle = DataGridViewCellStyle10
            Me.Column10.HeaderText = "ABONADO"
            Me.Column10.Name = "Column10"
            Me.Column10.ReadOnly = True
            Me.Column10.Width = 80
            '
            'Column11
            '
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column11.DefaultCellStyle = DataGridViewCellStyle11
            Me.Column11.HeaderText = "SALDO"
            Me.Column11.Name = "Column11"
            Me.Column11.ReadOnly = True
            Me.Column11.Width = 80
            '
            'Column12
            '
            Me.Column12.HeaderText = "OBSERVACIONES"
            Me.Column12.Name = "Column12"
            Me.Column12.ReadOnly = True
            Me.Column12.Width = 250
            '
            'Column13
            '
            Me.Column13.HeaderText = "CUETNA A DEBITAR"
            Me.Column13.Name = "Column13"
            Me.Column13.ReadOnly = True
            Me.Column13.Visible = False
            Me.Column13.Width = 350
            '
            'Column14
            '
            Me.Column14.HeaderText = "TITULAR CUENTA"
            Me.Column14.Name = "Column14"
            Me.Column14.ReadOnly = True
            Me.Column14.Visible = False
            Me.Column14.Width = 350
            '
            'Column15
            '
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column15.DefaultCellStyle = DataGridViewCellStyle12
            Me.Column15.HeaderText = "$$ CONVENIO"
            Me.Column15.Name = "Column15"
            Me.Column15.ReadOnly = True
            Me.Column15.Visible = False
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 3)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbPorCliente)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbGeneral)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(861, 55)
            Me.KryptonGroupBox1.TabIndex = 197
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(701, 2)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel3.TabIndex = 4
            Me.KryptonLabel3.Values.Text = "Hasta"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(549, 0)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel2.TabIndex = 3
            Me.KryptonLabel2.Values.Text = "Desde"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(189, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel1.TabIndex = 2
            Me.KryptonLabel1.Values.Text = "Cliente"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(2, 401)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalNotaCredito)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalCuentasPorCobrar)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalAbonado)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalRetencion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalACobrar)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalFacturas)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(862, 90)
            Me.KryptonGroupBox2.TabIndex = 198
            Me.KryptonGroupBox2.Values.Heading = "Valores"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(492, 36)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(71, 20)
            Me.KryptonLabel8.TabIndex = 15
            Me.KryptonLabel8.Values.Text = "Total Saldo"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(492, 8)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(91, 20)
            Me.KryptonLabel7.TabIndex = 14
            Me.KryptonLabel7.Values.Text = "Total Abonado"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(256, 34)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(96, 20)
            Me.KryptonLabel6.TabIndex = 7
            Me.KryptonLabel6.Values.Text = "Total N. Credito"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(256, 8)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(78, 20)
            Me.KryptonLabel5.TabIndex = 6
            Me.KryptonLabel5.Values.Text = "Total Cobrar"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(8, 34)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(96, 20)
            Me.KryptonLabel4.TabIndex = 5
            Me.KryptonLabel4.Values.Text = "Total Retencion"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(8, 8)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(104, 20)
            Me.KryptonLabel9.TabIndex = 0
            Me.KryptonLabel9.Values.Text = "Total Facturacion"
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Bar.BarMapExtraText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.None
            Me.KryptonNavigator1.Bar.BarMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.Small
            Me.KryptonNavigator1.Bar.BarMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.TextTitle
            Me.KryptonNavigator1.Bar.CheckButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
            Me.KryptonNavigator1.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameHeight
            Me.KryptonNavigator1.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.RoundedOutsizeMedium
            Me.KryptonNavigator1.Bar.TabStyle = ComponentFactory.Krypton.Toolkit.TabStyle.Dock
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.SelectPage
            Me.KryptonNavigator1.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic
            Me.KryptonNavigator1.Button.ContextMenuMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.Small
            Me.KryptonNavigator1.Button.ContextMenuMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.TextTitle
            Me.KryptonNavigator1.Button.NextButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
            Me.KryptonNavigator1.Button.NextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic
            Me.KryptonNavigator1.Button.PreviousButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
            Me.KryptonNavigator1.Button.PreviousButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic
            Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KryptonNavigator1.Group.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient
            Me.KryptonNavigator1.Group.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlClient
            Me.KryptonNavigator1.Header.HeaderStyleBar = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
            Me.KryptonNavigator1.Header.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
            Me.KryptonNavigator1.Header.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 32)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup
            Me.KryptonNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.KryptonNavigator1.Panel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
            Me.KryptonNavigator1.SelectedIndex = 1
            Me.KryptonNavigator1.Size = New System.Drawing.Size(879, 525)
            Me.KryptonNavigator1.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonNavigator1.StateNormal.Page.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
            Me.KryptonNavigator1.TabIndex = 199
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox2)
            Me.KryptonPage1.Controls.Add(Me.dgvCuentasPorCobrar)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(877, 496)
            Me.KryptonPage1.Text = "Busqueda"
            Me.KryptonPage1.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "8CE5953AC163468F9F8934745D9FB2FD"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.dgvClienteAcumulado)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox3)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(877, 496)
            Me.KryptonPage2.Text = "Acumulado"
            Me.KryptonPage2.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "A132AF518D4F4C483E8B6305622E03D6"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(4, 3)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.btnBuscarAcumulado)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtCliente)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dtpHastaAcu)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.rbClienteAcu)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dtpDesdeAcu)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.rbGeneralAcu)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(861, 55)
            Me.KryptonGroupBox3.TabIndex = 198
            Me.KryptonGroupBox3.Values.Heading = "Busqueda"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(659, 5)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel10.TabIndex = 4
            Me.KryptonLabel10.Values.Text = "Hasta"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(519, 5)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel11.TabIndex = 3
            Me.KryptonLabel11.Values.Text = "Desde"
            '
            'txtCliente
            '
            Me.txtCliente.BackColor = System.Drawing.Color.White
            Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCliente.Enabled = False
            Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtCliente.Location = New System.Drawing.Point(152, 4)
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.Size = New System.Drawing.Size(304, 20)
            Me.txtCliente.TabIndex = 2
            '
            'dtpHastaAcu
            '
            Me.dtpHastaAcu.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHastaAcu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHastaAcu.Location = New System.Drawing.Point(705, 3)
            Me.dtpHastaAcu.Name = "dtpHastaAcu"
            Me.dtpHastaAcu.Size = New System.Drawing.Size(88, 21)
            Me.dtpHastaAcu.TabIndex = 1
            '
            'rbClienteAcu
            '
            Me.rbClienteAcu.AutoSize = True
            Me.rbClienteAcu.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbClienteAcu.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbClienteAcu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbClienteAcu.Location = New System.Drawing.Point(75, 7)
            Me.rbClienteAcu.Name = "rbClienteAcu"
            Me.rbClienteAcu.Size = New System.Drawing.Size(60, 17)
            Me.rbClienteAcu.TabIndex = 1
            Me.rbClienteAcu.TabStop = True
            Me.rbClienteAcu.Text = "Cliente"
            Me.rbClienteAcu.UseVisualStyleBackColor = False
            '
            'dtpDesdeAcu
            '
            Me.dtpDesdeAcu.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDesdeAcu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesdeAcu.Location = New System.Drawing.Point(567, 4)
            Me.dtpDesdeAcu.Name = "dtpDesdeAcu"
            Me.dtpDesdeAcu.Size = New System.Drawing.Size(85, 21)
            Me.dtpDesdeAcu.TabIndex = 0
            Me.dtpDesdeAcu.Value = New Date(2013, 1, 1, 0, 1, 0, 0)
            '
            'rbGeneralAcu
            '
            Me.rbGeneralAcu.AutoSize = True
            Me.rbGeneralAcu.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbGeneralAcu.Checked = True
            Me.rbGeneralAcu.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbGeneralAcu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbGeneralAcu.Location = New System.Drawing.Point(9, 7)
            Me.rbGeneralAcu.Name = "rbGeneralAcu"
            Me.rbGeneralAcu.Size = New System.Drawing.Size(64, 17)
            Me.rbGeneralAcu.TabIndex = 0
            Me.rbGeneralAcu.TabStop = True
            Me.rbGeneralAcu.Text = "General"
            Me.rbGeneralAcu.UseVisualStyleBackColor = False
            '
            'btnBuscarAcumulado
            '
            Me.btnBuscarAcumulado.AutoSize = True
            Me.btnBuscarAcumulado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnBuscarAcumulado.Location = New System.Drawing.Point(473, -1)
            Me.btnBuscarAcumulado.Name = "btnBuscarAcumulado"
            Me.btnBuscarAcumulado.Size = New System.Drawing.Size(32, 32)
            Me.btnBuscarAcumulado.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnBuscarAcumulado.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
            Me.btnBuscarAcumulado.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnBuscarAcumulado.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
            Me.btnBuscarAcumulado.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
            Me.btnBuscarAcumulado.StateCommon.Content.Padding = New System.Windows.Forms.Padding(2)
            Me.btnBuscarAcumulado.TabIndex = 250
            Me.btnBuscarAcumulado.Values.ImageStates.ImageCheckedNormal = Nothing
            Me.btnBuscarAcumulado.Values.ImageStates.ImageCheckedPressed = Nothing
            Me.btnBuscarAcumulado.Values.ImageStates.ImageCheckedTracking = Nothing
            Me.btnBuscarAcumulado.Values.ImageStates.ImageDisabled = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarAcumulado.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarAcumulado.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnBuscarAcumulado.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnBuscarAcumulado.Values.Text = ""
            '
            'dgvClienteAcumulado
            '
            Me.dgvClienteAcumulado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvClienteAcumulado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cliente, Me.factura, Me.fecha, Me.Facturado, Me.uno_30, Me.treintauno_60, Me.sesenta_90, Me.noventa_120, Me.cientoveinte, Me.total})
            Me.dgvClienteAcumulado.Location = New System.Drawing.Point(4, 62)
            Me.dgvClienteAcumulado.Name = "dgvClienteAcumulado"
            Me.dgvClienteAcumulado.RowHeadersVisible = False
            Me.dgvClienteAcumulado.Size = New System.Drawing.Size(860, 424)
            Me.dgvClienteAcumulado.StateNormal.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvClienteAcumulado.StateNormal.Background.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
            Me.dgvClienteAcumulado.TabIndex = 199
            '
            'cliente
            '
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.cliente.DefaultCellStyle = DataGridViewCellStyle14
            Me.cliente.HeaderText = "Cliente"
            Me.cliente.Name = "cliente"
            '
            'factura
            '
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.factura.DefaultCellStyle = DataGridViewCellStyle15
            Me.factura.HeaderText = "No Factura"
            Me.factura.Name = "factura"
            '
            'fecha
            '
            Me.fecha.HeaderText = "Fecha Emision"
            Me.fecha.Name = "fecha"
            '
            'Facturado
            '
            Me.Facturado.HeaderText = "Facturado"
            Me.Facturado.Name = "Facturado"
            '
            'uno_30
            '
            Me.uno_30.HeaderText = "[1-30]"
            Me.uno_30.Name = "uno_30"
            '
            'treintauno_60
            '
            Me.treintauno_60.HeaderText = "[31-60]"
            Me.treintauno_60.Name = "treintauno_60"
            '
            'sesenta_90
            '
            Me.sesenta_90.HeaderText = "[61-90]"
            Me.sesenta_90.Name = "sesenta_90"
            '
            'noventa_120
            '
            Me.noventa_120.HeaderText = "[91-120]"
            Me.noventa_120.Name = "noventa_120"
            '
            'cientoveinte
            '
            Me.cientoveinte.HeaderText = "[>120]"
            Me.cientoveinte.Name = "cientoveinte"
            '
            'total
            '
            Me.total.HeaderText = "Total"
            Me.total.Name = "total"
            '
            'FrmCuentasPorCobrarGeneralClienteNoConvenio
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(879, 557)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Controls.Add(Me.lblIdComprobanteEgresoBanco)
            Me.Controls.Add(Me.lblIdClienteGeneral)
            Me.Controls.Add(Me.MenuStrip1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "FrmCuentasPorCobrarGeneralClienteNoConvenio"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "DETALLE DE CUENTAS POR CLIENTE / SIN CONVENIO DÉBITO BANCARIO"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.dgvCuentasPorCobrar, System.ComponentModel.ISupportInitialize).EndInit()
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
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            Me.KryptonGroupBox3.Panel.PerformLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            CType(Me.dgvClienteAcumulado, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtTotalNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalCuentasPorCobrar As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalAbonado As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalFacturas As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalACobrar As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreComercialClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents rbPorCliente As System.Windows.Forms.RadioButton
        Friend WithEvents rbGeneral As System.Windows.Forms.RadioButton
        Friend WithEvents lblIdComprobanteEgresoBanco As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents dgvCuentasPorCobrar As System.Windows.Forms.DataGridView
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtCliente As TextBox
        Friend WithEvents dtpHastaAcu As DateTimePicker
        Friend WithEvents rbClienteAcu As RadioButton
        Friend WithEvents dtpDesdeAcu As DateTimePicker
        Friend WithEvents rbGeneralAcu As RadioButton
        Friend WithEvents btnBuscarAcumulado As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents dgvClienteAcumulado As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Friend WithEvents cliente As DataGridViewTextBoxColumn
        Friend WithEvents factura As DataGridViewTextBoxColumn
        Friend WithEvents fecha As DataGridViewTextBoxColumn
        Friend WithEvents Facturado As DataGridViewTextBoxColumn
        Friend WithEvents uno_30 As DataGridViewTextBoxColumn
        Friend WithEvents treintauno_60 As DataGridViewTextBoxColumn
        Friend WithEvents sesenta_90 As DataGridViewTextBoxColumn
        Friend WithEvents noventa_120 As DataGridViewTextBoxColumn
        Friend WithEvents cientoveinte As DataGridViewTextBoxColumn
        Friend WithEvents total As DataGridViewTextBoxColumn
    End Class
End Namespace