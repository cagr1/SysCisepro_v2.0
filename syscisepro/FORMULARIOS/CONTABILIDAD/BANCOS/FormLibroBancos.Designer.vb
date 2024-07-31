Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormLibroBancos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLibroBancos))
            Me.gbBanco = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblIdComprobanteEgresoBanco = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.gbComandos = New System.Windows.Forms.GroupBox()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.lblce = New System.Windows.Forms.Label()
            Me.lblci = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtTotalEmitidosCobrados = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtTotalEmitidosNoCobrados = New System.Windows.Forms.TextBox()
            Me.txtTotalEmitidosCobradosMesAnterior = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtSaldoLibroBancos = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtTotalHaber = New System.Windows.Forms.TextBox()
            Me.txtTotalDebe = New System.Windows.Forms.TextBox()
            Me.dgvLibroBancos = New System.Windows.Forms.DataGridView()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.lblMesActual = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtSaldoCtaBanco = New System.Windows.Forms.TextBox()
            Me.dgvChequesEmitidosAprobados = New System.Windows.Forms.DataGridView()
            Me.dgvEmitidosCobrados = New System.Windows.Forms.DataGridView()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.gbBanco.SuspendLayout()
            Me.gbRangoFechas.SuspendLayout()
            Me.gbComandos.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvLibroBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvChequesEmitidosAprobados, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvEmitidosCobrados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbBanco
            '
            Me.gbBanco.Controls.Add(Me.Label10)
            Me.gbBanco.Controls.Add(Me.cmbCuentaBancos)
            Me.gbBanco.Controls.Add(Me.cmbBancos)
            Me.gbBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBanco.Location = New System.Drawing.Point(270, 4)
            Me.gbBanco.Name = "gbBanco"
            Me.gbBanco.Size = New System.Drawing.Size(348, 48)
            Me.gbBanco.TabIndex = 120
            Me.gbBanco.TabStop = False
            Me.gbBanco.Text = "BANCO: "
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(159, 2)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(62, 13)
            Me.Label10.TabIndex = 34
            Me.Label10.Text = "CA/CC/TA:"
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(156, 18)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(178, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(6, 18)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(132, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.Controls.Add(Me.dtpDesde)
            Me.gbRangoFechas.Controls.Add(Me.Label3)
            Me.gbRangoFechas.Controls.Add(Me.lblIdComprobanteEgresoBanco)
            Me.gbRangoFechas.Controls.Add(Me.Label1)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(1, 4)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(267, 48)
            Me.gbRangoFechas.TabIndex = 119
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS (MES)"
            '
            'dtpDesde
            '
            Me.dtpDesde.CustomFormat = "MMMM - yyyy"
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDesde.Location = New System.Drawing.Point(42, 19)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.ShowUpDown = True
            Me.dtpDesde.Size = New System.Drawing.Size(177, 21)
            Me.dtpDesde.TabIndex = 0
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(11, 22)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(29, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Mes"
            '
            'lblIdComprobanteEgresoBanco
            '
            Me.lblIdComprobanteEgresoBanco.AutoSize = True
            Me.lblIdComprobanteEgresoBanco.Location = New System.Drawing.Point(165, 0)
            Me.lblIdComprobanteEgresoBanco.Name = "lblIdComprobanteEgresoBanco"
            Me.lblIdComprobanteEgresoBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteEgresoBanco.TabIndex = 3
            Me.lblIdComprobanteEgresoBanco.Text = "..."
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(141, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(37, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Hasta"
            Me.Label1.Visible = False
            '
            'gbComandos
            '
            Me.gbComandos.Controls.Add(Me.btnExportar)
            Me.gbComandos.Controls.Add(Me.btnBuscar)
            Me.gbComandos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComandos.Location = New System.Drawing.Point(621, 3)
            Me.gbComandos.Name = "gbComandos"
            Me.gbComandos.Size = New System.Drawing.Size(134, 48)
            Me.gbComandos.TabIndex = 118
            Me.gbComandos.TabStop = False
            '
            'btnExportar
            '
            Me.btnExportar.BackColor = System.Drawing.Color.White
            Me.btnExportar.FlatAppearance.BorderSize = 0
            Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.ForeColor = System.Drawing.Color.Black
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.Location = New System.Drawing.Point(71, 11)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(41, 30)
            Me.btnExportar.TabIndex = 19
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnExportar.UseVisualStyleBackColor = False
            '
            'btnBuscar
            '
            Me.btnBuscar.BackColor = System.Drawing.Color.White
            Me.btnBuscar.FlatAppearance.BorderSize = 0
            Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.ForeColor = System.Drawing.Color.Black
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.Location = New System.Drawing.Point(12, 11)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(41, 30)
            Me.btnBuscar.TabIndex = 18
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = False
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.Label13)
            Me.GroupBox1.Controls.Add(Me.lblce)
            Me.GroupBox1.Controls.Add(Me.lblci)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.txtSaldoInicial)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.txtTotalEmitidosCobrados)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.txtTotalEmitidosNoCobrados)
            Me.GroupBox1.Controls.Add(Me.txtTotalEmitidosCobradosMesAnterior)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.txtSaldoLibroBancos)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtTotalHaber)
            Me.GroupBox1.Controls.Add(Me.txtTotalDebe)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(1, 492)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(754, 96)
            Me.GroupBox1.TabIndex = 121
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Totales"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(310, 75)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(133, 13)
            Me.Label13.TabIndex = 16
            Me.Label13.Text = "CANT. COMPROBANTES:"
            '
            'lblce
            '
            Me.lblce.AutoSize = True
            Me.lblce.Location = New System.Drawing.Point(534, 75)
            Me.lblce.Name = "lblce"
            Me.lblce.Size = New System.Drawing.Size(23, 13)
            Me.lblce.TabIndex = 15
            Me.lblce.Text = "CE:"
            '
            'lblci
            '
            Me.lblci.AutoSize = True
            Me.lblci.Location = New System.Drawing.Point(449, 75)
            Me.lblci.Name = "lblci"
            Me.lblci.Size = New System.Drawing.Size(20, 13)
            Me.lblci.TabIndex = 14
            Me.lblci.Text = "CI:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(306, 15)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(85, 13)
            Me.Label11.TabIndex = 13
            Me.Label11.Text = "SALDO INICIAL:"
            '
            'txtSaldoInicial
            '
            Me.txtSaldoInicial.BackColor = System.Drawing.Color.White
            Me.txtSaldoInicial.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSaldoInicial.Location = New System.Drawing.Point(402, 11)
            Me.txtSaldoInicial.Name = "txtSaldoInicial"
            Me.txtSaldoInicial.ReadOnly = True
            Me.txtSaldoInicial.Size = New System.Drawing.Size(121, 22)
            Me.txtSaldoInicial.TabIndex = 12
            Me.txtSaldoInicial.Text = "0.00"
            Me.txtSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(8, 17)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(178, 13)
            Me.Label9.TabIndex = 11
            Me.Label9.Text = "Cheques Emitidos Cobrados Mes :"
            '
            'txtTotalEmitidosCobrados
            '
            Me.txtTotalEmitidosCobrados.BackColor = System.Drawing.Color.White
            Me.txtTotalEmitidosCobrados.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalEmitidosCobrados.Location = New System.Drawing.Point(201, 13)
            Me.txtTotalEmitidosCobrados.Name = "txtTotalEmitidosCobrados"
            Me.txtTotalEmitidosCobrados.ReadOnly = True
            Me.txtTotalEmitidosCobrados.Size = New System.Drawing.Size(99, 22)
            Me.txtTotalEmitidosCobrados.TabIndex = 10
            Me.txtTotalEmitidosCobrados.Text = "0.00"
            Me.txtTotalEmitidosCobrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(8, 69)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(190, 13)
            Me.Label8.TabIndex = 9
            Me.Label8.Text = "Cheques Cobrados Del Mes Anterior:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(8, 43)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(170, 13)
            Me.Label7.TabIndex = 8
            Me.Label7.Text = "Cheques Emitidos No Cobrados :"
            '
            'txtTotalEmitidosNoCobrados
            '
            Me.txtTotalEmitidosNoCobrados.BackColor = System.Drawing.Color.White
            Me.txtTotalEmitidosNoCobrados.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalEmitidosNoCobrados.Location = New System.Drawing.Point(201, 39)
            Me.txtTotalEmitidosNoCobrados.Name = "txtTotalEmitidosNoCobrados"
            Me.txtTotalEmitidosNoCobrados.ReadOnly = True
            Me.txtTotalEmitidosNoCobrados.Size = New System.Drawing.Size(99, 22)
            Me.txtTotalEmitidosNoCobrados.TabIndex = 7
            Me.txtTotalEmitidosNoCobrados.Text = "0.00"
            Me.txtTotalEmitidosNoCobrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalEmitidosCobradosMesAnterior
            '
            Me.txtTotalEmitidosCobradosMesAnterior.BackColor = System.Drawing.Color.White
            Me.txtTotalEmitidosCobradosMesAnterior.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalEmitidosCobradosMesAnterior.Location = New System.Drawing.Point(201, 65)
            Me.txtTotalEmitidosCobradosMesAnterior.Name = "txtTotalEmitidosCobradosMesAnterior"
            Me.txtTotalEmitidosCobradosMesAnterior.ReadOnly = True
            Me.txtTotalEmitidosCobradosMesAnterior.Size = New System.Drawing.Size(99, 22)
            Me.txtTotalEmitidosCobradosMesAnterior.TabIndex = 6
            Me.txtTotalEmitidosCobradosMesAnterior.Text = "0.00"
            Me.txtTotalEmitidosCobradosMesAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(570, 64)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(45, 13)
            Me.Label6.TabIndex = 5
            Me.Label6.Text = "SALDO:"
            '
            'txtSaldoLibroBancos
            '
            Me.txtSaldoLibroBancos.BackColor = System.Drawing.Color.White
            Me.txtSaldoLibroBancos.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSaldoLibroBancos.Location = New System.Drawing.Point(621, 61)
            Me.txtSaldoLibroBancos.Name = "txtSaldoLibroBancos"
            Me.txtSaldoLibroBancos.ReadOnly = True
            Me.txtSaldoLibroBancos.Size = New System.Drawing.Size(121, 22)
            Me.txtSaldoLibroBancos.TabIndex = 4
            Me.txtSaldoLibroBancos.Text = "0.00"
            Me.txtSaldoLibroBancos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(570, 38)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(45, 13)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "HABER:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(576, 12)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(36, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "DEBE:"
            '
            'txtTotalHaber
            '
            Me.txtTotalHaber.BackColor = System.Drawing.Color.White
            Me.txtTotalHaber.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalHaber.Location = New System.Drawing.Point(621, 35)
            Me.txtTotalHaber.Name = "txtTotalHaber"
            Me.txtTotalHaber.ReadOnly = True
            Me.txtTotalHaber.Size = New System.Drawing.Size(121, 22)
            Me.txtTotalHaber.TabIndex = 1
            Me.txtTotalHaber.Text = "0.00"
            Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalDebe
            '
            Me.txtTotalDebe.BackColor = System.Drawing.Color.White
            Me.txtTotalDebe.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalDebe.Location = New System.Drawing.Point(621, 9)
            Me.txtTotalDebe.Name = "txtTotalDebe"
            Me.txtTotalDebe.ReadOnly = True
            Me.txtTotalDebe.Size = New System.Drawing.Size(121, 22)
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
            Me.dgvLibroBancos.BackgroundColor = System.Drawing.Color.White
            Me.dgvLibroBancos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvLibroBancos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvLibroBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvLibroBancos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvLibroBancos.Location = New System.Drawing.Point(4, 10)
            Me.dgvLibroBancos.Name = "dgvLibroBancos"
            Me.dgvLibroBancos.ReadOnly = True
            Me.dgvLibroBancos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvLibroBancos.RowHeadersVisible = False
            Me.dgvLibroBancos.RowHeadersWidth = 25
            Me.dgvLibroBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLibroBancos.Size = New System.Drawing.Size(745, 305)
            Me.dgvLibroBancos.TabIndex = 122
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.lblMesActual)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.txtSaldoCtaBanco)
            Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(277, 54)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(356, 39)
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
            Me.dgvChequesEmitidosAprobados.BackgroundColor = System.Drawing.Color.White
            Me.dgvChequesEmitidosAprobados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvChequesEmitidosAprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvChequesEmitidosAprobados.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvChequesEmitidosAprobados.Location = New System.Drawing.Point(6, 341)
            Me.dgvChequesEmitidosAprobados.Name = "dgvChequesEmitidosAprobados"
            Me.dgvChequesEmitidosAprobados.ReadOnly = True
            Me.dgvChequesEmitidosAprobados.RowHeadersVisible = False
            Me.dgvChequesEmitidosAprobados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvChequesEmitidosAprobados.Size = New System.Drawing.Size(340, 104)
            Me.dgvChequesEmitidosAprobados.TabIndex = 123
            '
            'dgvEmitidosCobrados
            '
            Me.dgvEmitidosCobrados.AllowUserToAddRows = False
            Me.dgvEmitidosCobrados.AllowUserToDeleteRows = False
            Me.dgvEmitidosCobrados.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvEmitidosCobrados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvEmitidosCobrados.BackgroundColor = System.Drawing.Color.White
            Me.dgvEmitidosCobrados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvEmitidosCobrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvEmitidosCobrados.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvEmitidosCobrados.Location = New System.Drawing.Point(353, 341)
            Me.dgvEmitidosCobrados.Name = "dgvEmitidosCobrados"
            Me.dgvEmitidosCobrados.ReadOnly = True
            Me.dgvEmitidosCobrados.RowHeadersVisible = False
            Me.dgvEmitidosCobrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvEmitidosCobrados.Size = New System.Drawing.Size(396, 104)
            Me.dgvEmitidosCobrados.TabIndex = 124
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.Label14)
            Me.GroupBox3.Controls.Add(Me.Label12)
            Me.GroupBox3.Controls.Add(Me.dgvLibroBancos)
            Me.GroupBox3.Controls.Add(Me.dgvEmitidosCobrados)
            Me.GroupBox3.Controls.Add(Me.dgvChequesEmitidosAprobados)
            Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(0, 45)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(755, 493)
            Me.GroupBox3.TabIndex = 125
            Me.GroupBox3.TabStop = False
            '
            'Label14
            '
            Me.Label14.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(356, 319)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(263, 15)
            Me.Label14.TabIndex = 126
            Me.Label14.Text = "Emitidos (cobrados)"
            '
            'Label12
            '
            Me.Label12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(6, 318)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(198, 15)
            Me.Label12.TabIndex = 125
            Me.Label12.Text = "Emitidos (no cobrados)                                                    Emitido" &
    "s (cobrados)"
            '
            'FormLibroBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(759, 593)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbBanco)
            Me.Controls.Add(Me.gbRangoFechas)
            Me.Controls.Add(Me.gbComandos)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox2)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormLibroBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "Libro Bancos"
            Me.gbBanco.ResumeLayout(False)
            Me.gbBanco.PerformLayout()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.gbComandos.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvLibroBancos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.dgvChequesEmitidosAprobados, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvEmitidosCobrados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbBanco As System.Windows.Forms.GroupBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteEgresoBanco As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbComandos As System.Windows.Forms.GroupBox
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents dgvLibroBancos As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtSaldoCtaBanco As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtSaldoLibroBancos As System.Windows.Forms.TextBox
        Friend WithEvents dgvChequesEmitidosAprobados As System.Windows.Forms.DataGridView
        Friend WithEvents dgvEmitidosCobrados As System.Windows.Forms.DataGridView
        Friend WithEvents lblMesActual As System.Windows.Forms.Label
        Friend WithEvents txtTotalEmitidosNoCobrados As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalEmitidosCobradosMesAnterior As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtTotalEmitidosCobrados As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtSaldoInicial As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents lblce As System.Windows.Forms.Label
        Friend WithEvents lblci As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As Label
    End Class
End Namespace