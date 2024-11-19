Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormLibroBancos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLibroBancos))
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.lblIdComprobanteEgresoBanco = New System.Windows.Forms.Label()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.lblce = New System.Windows.Forms.Label()
            Me.lblci = New System.Windows.Forms.Label()
            Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
            Me.txtTotalEmitidosCobrados = New System.Windows.Forms.TextBox()
            Me.txtTotalEmitidosNoCobrados = New System.Windows.Forms.TextBox()
            Me.txtTotalEmitidosCobradosMesAnterior = New System.Windows.Forms.TextBox()
            Me.txtSaldoLibroBancos = New System.Windows.Forms.TextBox()
            Me.txtTotalHaber = New System.Windows.Forms.TextBox()
            Me.txtTotalDebe = New System.Windows.Forms.TextBox()
            Me.dgvLibroBancos = New System.Windows.Forms.DataGridView()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.lblMesActual = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtSaldoCtaBanco = New System.Windows.Forms.TextBox()
            Me.dgvChequesEmitidosAprobados = New System.Windows.Forms.DataGridView()
            Me.dgvEmitidosCobrados = New System.Windows.Forms.DataGridView()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.label12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.lblcobrados = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvLibroBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvChequesEmitidosAprobados, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvEmitidosCobrados, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(439, 5)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(129, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(223, 4)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(132, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'dtpDesde
            '
            Me.dtpDesde.CustomFormat = "MMMM - yyyy"
            Me.dtpDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDesde.Location = New System.Drawing.Point(46, 4)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.ShowUpDown = True
            Me.dtpDesde.Size = New System.Drawing.Size(118, 21)
            Me.dtpDesde.TabIndex = 0
            '
            'lblIdComprobanteEgresoBanco
            '
            Me.lblIdComprobanteEgresoBanco.AutoSize = True
            Me.lblIdComprobanteEgresoBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteEgresoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteEgresoBanco.Location = New System.Drawing.Point(147, 10)
            Me.lblIdComprobanteEgresoBanco.Name = "lblIdComprobanteEgresoBanco"
            Me.lblIdComprobanteEgresoBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteEgresoBanco.TabIndex = 3
            Me.lblIdComprobanteEgresoBanco.Text = "..."
            '
            'btnExportar
            '
            Me.btnExportar.BackColor = System.Drawing.Color.Transparent
            Me.btnExportar.FlatAppearance.BorderSize = 0
            Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.ForeColor = System.Drawing.Color.Black
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.Location = New System.Drawing.Point(616, 4)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(30, 30)
            Me.btnExportar.TabIndex = 19
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnExportar.UseVisualStyleBackColor = False
            '
            'btnBuscar
            '
            Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
            Me.btnBuscar.FlatAppearance.BorderSize = 0
            Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.ForeColor = System.Drawing.Color.Black
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.Location = New System.Drawing.Point(574, 3)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(30, 30)
            Me.btnBuscar.TabIndex = 18
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = False
            '
            'lblce
            '
            Me.lblce.AutoSize = True
            Me.lblce.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblce.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblce.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblce.Location = New System.Drawing.Point(357, 51)
            Me.lblce.Name = "lblce"
            Me.lblce.Size = New System.Drawing.Size(23, 13)
            Me.lblce.TabIndex = 15
            Me.lblce.Text = "CE:"
            '
            'lblci
            '
            Me.lblci.AutoSize = True
            Me.lblci.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblci.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblci.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblci.Location = New System.Drawing.Point(285, 51)
            Me.lblci.Name = "lblci"
            Me.lblci.Size = New System.Drawing.Size(20, 13)
            Me.lblci.TabIndex = 14
            Me.lblci.Text = "CI:"
            '
            'txtSaldoInicial
            '
            Me.txtSaldoInicial.BackColor = System.Drawing.Color.White
            Me.txtSaldoInicial.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSaldoInicial.Location = New System.Drawing.Point(360, 3)
            Me.txtSaldoInicial.Name = "txtSaldoInicial"
            Me.txtSaldoInicial.ReadOnly = True
            Me.txtSaldoInicial.Size = New System.Drawing.Size(84, 22)
            Me.txtSaldoInicial.TabIndex = 12
            Me.txtSaldoInicial.Text = "0.00"
            Me.txtSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalEmitidosCobrados
            '
            Me.txtTotalEmitidosCobrados.BackColor = System.Drawing.Color.White
            Me.txtTotalEmitidosCobrados.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalEmitidosCobrados.Location = New System.Drawing.Point(193, 2)
            Me.txtTotalEmitidosCobrados.Name = "txtTotalEmitidosCobrados"
            Me.txtTotalEmitidosCobrados.ReadOnly = True
            Me.txtTotalEmitidosCobrados.Size = New System.Drawing.Size(84, 21)
            Me.txtTotalEmitidosCobrados.TabIndex = 10
            Me.txtTotalEmitidosCobrados.Text = "0.00"
            Me.txtTotalEmitidosCobrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalEmitidosNoCobrados
            '
            Me.txtTotalEmitidosNoCobrados.BackColor = System.Drawing.Color.White
            Me.txtTotalEmitidosNoCobrados.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalEmitidosNoCobrados.Location = New System.Drawing.Point(193, 26)
            Me.txtTotalEmitidosNoCobrados.Name = "txtTotalEmitidosNoCobrados"
            Me.txtTotalEmitidosNoCobrados.ReadOnly = True
            Me.txtTotalEmitidosNoCobrados.Size = New System.Drawing.Size(84, 21)
            Me.txtTotalEmitidosNoCobrados.TabIndex = 7
            Me.txtTotalEmitidosNoCobrados.Text = "0.00"
            Me.txtTotalEmitidosNoCobrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalEmitidosCobradosMesAnterior
            '
            Me.txtTotalEmitidosCobradosMesAnterior.BackColor = System.Drawing.Color.White
            Me.txtTotalEmitidosCobradosMesAnterior.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalEmitidosCobradosMesAnterior.Location = New System.Drawing.Point(193, 49)
            Me.txtTotalEmitidosCobradosMesAnterior.Name = "txtTotalEmitidosCobradosMesAnterior"
            Me.txtTotalEmitidosCobradosMesAnterior.ReadOnly = True
            Me.txtTotalEmitidosCobradosMesAnterior.Size = New System.Drawing.Size(84, 21)
            Me.txtTotalEmitidosCobradosMesAnterior.TabIndex = 6
            Me.txtTotalEmitidosCobradosMesAnterior.Text = "0.00"
            Me.txtTotalEmitidosCobradosMesAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSaldoLibroBancos
            '
            Me.txtSaldoLibroBancos.BackColor = System.Drawing.Color.White
            Me.txtSaldoLibroBancos.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSaldoLibroBancos.Location = New System.Drawing.Point(533, 55)
            Me.txtSaldoLibroBancos.Name = "txtSaldoLibroBancos"
            Me.txtSaldoLibroBancos.ReadOnly = True
            Me.txtSaldoLibroBancos.Size = New System.Drawing.Size(95, 22)
            Me.txtSaldoLibroBancos.TabIndex = 4
            Me.txtSaldoLibroBancos.Text = "0.00"
            Me.txtSaldoLibroBancos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalHaber
            '
            Me.txtTotalHaber.BackColor = System.Drawing.Color.White
            Me.txtTotalHaber.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalHaber.Location = New System.Drawing.Point(533, 29)
            Me.txtTotalHaber.Name = "txtTotalHaber"
            Me.txtTotalHaber.ReadOnly = True
            Me.txtTotalHaber.Size = New System.Drawing.Size(95, 22)
            Me.txtTotalHaber.TabIndex = 1
            Me.txtTotalHaber.Text = "0.00"
            Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalDebe
            '
            Me.txtTotalDebe.BackColor = System.Drawing.Color.White
            Me.txtTotalDebe.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalDebe.Location = New System.Drawing.Point(533, 3)
            Me.txtTotalDebe.Name = "txtTotalDebe"
            Me.txtTotalDebe.ReadOnly = True
            Me.txtTotalDebe.Size = New System.Drawing.Size(95, 22)
            Me.txtTotalDebe.TabIndex = 0
            Me.txtTotalDebe.Text = "0.00"
            Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvLibroBancos
            '
            Me.dgvLibroBancos.AllowUserToAddRows = False
            Me.dgvLibroBancos.AllowUserToDeleteRows = False
            Me.dgvLibroBancos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvLibroBancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvLibroBancos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvLibroBancos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvLibroBancos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvLibroBancos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvLibroBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvLibroBancos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvLibroBancos.Location = New System.Drawing.Point(3, 70)
            Me.dgvLibroBancos.Name = "dgvLibroBancos"
            Me.dgvLibroBancos.ReadOnly = True
            Me.dgvLibroBancos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvLibroBancos.RowHeadersVisible = False
            Me.dgvLibroBancos.RowHeadersWidth = 25
            Me.dgvLibroBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLibroBancos.Size = New System.Drawing.Size(659, 265)
            Me.dgvLibroBancos.TabIndex = 122
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.lblMesActual)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.txtSaldoCtaBanco)
            Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(277, 16)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(67, 39)
            Me.GroupBox2.TabIndex = 122
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Cabecera"
            Me.GroupBox2.Visible = False
            '
            'lblMesActual
            '
            Me.lblMesActual.AutoSize = True
            Me.lblMesActual.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMesActual.Location = New System.Drawing.Point(64, -2)
            Me.lblMesActual.Name = "lblMesActual"
            Me.lblMesActual.Size = New System.Drawing.Size(28, 15)
            Me.lblMesActual.TabIndex = 37
            Me.lblMesActual.Text = "..."
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(92, 16)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(73, 13)
            Me.Label5.TabIndex = 5
            Me.Label5.Text = "SALDO CTA.:"
            Me.Label5.Visible = False
            '
            'txtSaldoCtaBanco
            '
            Me.txtSaldoCtaBanco.BackColor = System.Drawing.Color.White
            Me.txtSaldoCtaBanco.Location = New System.Drawing.Point(171, 13)
            Me.txtSaldoCtaBanco.Name = "txtSaldoCtaBanco"
            Me.txtSaldoCtaBanco.ReadOnly = True
            Me.txtSaldoCtaBanco.Size = New System.Drawing.Size(98, 20)
            Me.txtSaldoCtaBanco.TabIndex = 4
            Me.txtSaldoCtaBanco.Text = "0.00"
            Me.txtSaldoCtaBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtSaldoCtaBanco.Visible = False
            '
            'dgvChequesEmitidosAprobados
            '
            Me.dgvChequesEmitidosAprobados.AllowUserToAddRows = False
            Me.dgvChequesEmitidosAprobados.AllowUserToDeleteRows = False
            Me.dgvChequesEmitidosAprobados.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvChequesEmitidosAprobados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvChequesEmitidosAprobados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvChequesEmitidosAprobados.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvChequesEmitidosAprobados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvChequesEmitidosAprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvChequesEmitidosAprobados.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvChequesEmitidosAprobados.Location = New System.Drawing.Point(7, 363)
            Me.dgvChequesEmitidosAprobados.Name = "dgvChequesEmitidosAprobados"
            Me.dgvChequesEmitidosAprobados.ReadOnly = True
            Me.dgvChequesEmitidosAprobados.RowHeadersVisible = False
            Me.dgvChequesEmitidosAprobados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvChequesEmitidosAprobados.Size = New System.Drawing.Size(331, 88)
            Me.dgvChequesEmitidosAprobados.TabIndex = 123
            '
            'dgvEmitidosCobrados
            '
            Me.dgvEmitidosCobrados.AllowUserToAddRows = False
            Me.dgvEmitidosCobrados.AllowUserToDeleteRows = False
            Me.dgvEmitidosCobrados.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvEmitidosCobrados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvEmitidosCobrados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvEmitidosCobrados.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvEmitidosCobrados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvEmitidosCobrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvEmitidosCobrados.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvEmitidosCobrados.Location = New System.Drawing.Point(344, 363)
            Me.dgvEmitidosCobrados.Name = "dgvEmitidosCobrados"
            Me.dgvEmitidosCobrados.ReadOnly = True
            Me.dgvEmitidosCobrados.RowHeadersVisible = False
            Me.dgvEmitidosCobrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvEmitidosCobrados.Size = New System.Drawing.Size(318, 88)
            Me.dgvEmitidosCobrados.TabIndex = 124
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 3)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnExportar)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnBuscar)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCuentaBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbBancos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(659, 63)
            Me.KryptonGroupBox1.TabIndex = 126
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(364, 5)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(66, 20)
            Me.KryptonLabel3.TabIndex = 26
            Me.KryptonLabel3.Values.Text = "CA/CC/TA"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(171, 4)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel2.TabIndex = 1
            Me.KryptonLabel2.Values.Text = "Banco"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(4, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(33, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Mes"
            '
            'label12
            '
            Me.label12.Location = New System.Drawing.Point(11, 343)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(136, 20)
            Me.label12.TabIndex = 127
            Me.label12.Values.Text = "Emitidos (no cobrados)"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(7, 457)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblce)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSaldoLibroBancos)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblci)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalHaber)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalDebe)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSaldoInicial)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalEmitidosCobrados)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalEmitidosCobradosMesAnterior)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalEmitidosNoCobrados)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(655, 112)
            Me.KryptonGroupBox2.TabIndex = 129
            Me.KryptonGroupBox2.Values.Heading = "Totales"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(488, 49)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel12.TabIndex = 134
            Me.KryptonLabel12.Values.Text = "Saldo"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(488, 27)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel11.TabIndex = 133
            Me.KryptonLabel11.Values.Text = "Haber"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(488, 5)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel10.TabIndex = 132
            Me.KryptonLabel10.Values.Text = "Debe"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(283, 26)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(115, 20)
            Me.KryptonLabel9.TabIndex = 131
            Me.KryptonLabel9.Values.Text = "Cant Comprobante"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(283, 3)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(76, 20)
            Me.KryptonLabel8.TabIndex = 130
            Me.KryptonLabel8.Values.Text = "Saldo Inicial"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(3, 49)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(188, 20)
            Me.KryptonLabel7.TabIndex = 130
            Me.KryptonLabel7.Values.Text = "Cheques Cobrados Mes Anterior"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(3, 26)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(184, 20)
            Me.KryptonLabel6.TabIndex = 129
            Me.KryptonLabel6.Values.Text = "Cheques Emitidos No Cobrados"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(190, 20)
            Me.KryptonLabel5.TabIndex = 128
            Me.KryptonLabel5.Values.Text = "Cheques Emitidos Cobrados Mes"
            '
            'lblcobrados
            '
            Me.lblcobrados.Location = New System.Drawing.Point(346, 341)
            Me.lblcobrados.Name = "lblcobrados"
            Me.lblcobrados.Size = New System.Drawing.Size(119, 20)
            Me.lblcobrados.TabIndex = 30
            Me.lblcobrados.Values.Text = "Emitidos (cobrados)"
            '
            'FormLibroBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(662, 567)
            Me.Controls.Add(Me.lblcobrados)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.label12)
            Me.Controls.Add(Me.lblIdComprobanteEgresoBanco)
            Me.Controls.Add(Me.dgvEmitidosCobrados)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.dgvChequesEmitidosAprobados)
            Me.Controls.Add(Me.dgvLibroBancos)
            Me.Controls.Add(Me.GroupBox2)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormLibroBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "Libro Bancos"
            CType(Me.dgvLibroBancos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.dgvChequesEmitidosAprobados, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvEmitidosCobrados, System.ComponentModel.ISupportInitialize).EndInit()
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
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents lblIdComprobanteEgresoBanco As System.Windows.Forms.Label
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents dgvLibroBancos As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtSaldoCtaBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtSaldoLibroBancos As System.Windows.Forms.TextBox
        Friend WithEvents dgvChequesEmitidosAprobados As System.Windows.Forms.DataGridView
        Friend WithEvents dgvEmitidosCobrados As System.Windows.Forms.DataGridView
        Friend WithEvents lblMesActual As System.Windows.Forms.Label
        Friend WithEvents txtTotalEmitidosNoCobrados As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalEmitidosCobradosMesAnterior As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalEmitidosCobrados As System.Windows.Forms.TextBox
        Friend WithEvents txtSaldoInicial As System.Windows.Forms.TextBox
        Friend WithEvents lblce As System.Windows.Forms.Label
        Friend WithEvents lblci As System.Windows.Forms.Label
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents label12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblcobrados As ComponentFactory.Krypton.Toolkit.KryptonLabel
    End Class
End Namespace