Namespace FORMULARIOS.CONTABILIDAD.CUENTAS_POR_COBRAR


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmCuentasPorCobrarGeneralClienteConvenio
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
            Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.txtNombreComercialClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.rbPorCliente = New System.Windows.Forms.RadioButton()
            Me.rbGeneral = New System.Windows.Forms.RadioButton()
            Me.cbxBanco = New System.Windows.Forms.ComboBox()
            Me.lblIdComprobanteEgresoBanco = New System.Windows.Forms.Label()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
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
            Me.txtTotalNotaCredito = New System.Windows.Forms.TextBox()
            Me.txtTotalCuentasPorCobrar = New System.Windows.Forms.TextBox()
            Me.txtTotalAbonado = New System.Windows.Forms.TextBox()
            Me.txtTotalFacturas = New System.Windows.Forms.TextBox()
            Me.txtTotalRetencion = New System.Windows.Forms.TextBox()
            Me.txtTotalACobrar = New System.Windows.Forms.TextBox()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
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
            Me.SuspendLayout()
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(895, 32)
            Me.MenuStrip1.TabIndex = 185
            Me.MenuStrip1.Text = "PENDIENTES"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(92, 28)
            Me.btnBuscar.Text = "BUSCAR "
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
            'txtNombreComercialClienteGeneral
            '
            Me.txtNombreComercialClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialClienteGeneral.Enabled = False
            Me.txtNombreComercialClienteGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialClienteGeneral.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtNombreComercialClienteGeneral.Location = New System.Drawing.Point(161, 18)
            Me.txtNombreComercialClienteGeneral.Name = "txtNombreComercialClienteGeneral"
            Me.txtNombreComercialClienteGeneral.Size = New System.Drawing.Size(278, 20)
            Me.txtNombreComercialClienteGeneral.TabIndex = 2
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdClienteGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(302, 0)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdClienteGeneral.TabIndex = 76
            Me.lblIdClienteGeneral.Text = "..."
            '
            'rbPorCliente
            '
            Me.rbPorCliente.AutoSize = True
            Me.rbPorCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPorCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPorCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPorCliente.Location = New System.Drawing.Point(75, 19)
            Me.rbPorCliente.Name = "rbPorCliente"
            Me.rbPorCliente.Size = New System.Drawing.Size(80, 17)
            Me.rbPorCliente.TabIndex = 1
            Me.rbPorCliente.TabStop = True
            Me.rbPorCliente.Text = "Por Cliente"
            Me.rbPorCliente.UseVisualStyleBackColor = False
            '
            'rbGeneral
            '
            Me.rbGeneral.AutoSize = True
            Me.rbGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbGeneral.Checked = True
            Me.rbGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbGeneral.Location = New System.Drawing.Point(5, 19)
            Me.rbGeneral.Name = "rbGeneral"
            Me.rbGeneral.Size = New System.Drawing.Size(64, 17)
            Me.rbGeneral.TabIndex = 0
            Me.rbGeneral.TabStop = True
            Me.rbGeneral.Text = "General"
            Me.rbGeneral.UseVisualStyleBackColor = False
            '
            'cbxBanco
            '
            Me.cbxBanco.BackColor = System.Drawing.Color.White
            Me.cbxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxBanco.DropDownWidth = 200
            Me.cbxBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxBanco.FormattingEnabled = True
            Me.cbxBanco.Items.AddRange(New Object() {"-- TODOS --", "A DEBITAR BANCO MACHALA", "A DEBITAR INTERBANCARIO"})
            Me.cbxBanco.Location = New System.Drawing.Point(754, 17)
            Me.cbxBanco.Name = "cbxBanco"
            Me.cbxBanco.Size = New System.Drawing.Size(132, 21)
            Me.cbxBanco.TabIndex = 14
            '
            'lblIdComprobanteEgresoBanco
            '
            Me.lblIdComprobanteEgresoBanco.AutoSize = True
            Me.lblIdComprobanteEgresoBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteEgresoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteEgresoBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteEgresoBanco.Location = New System.Drawing.Point(610, 0)
            Me.lblIdComprobanteEgresoBanco.Name = "lblIdComprobanteEgresoBanco"
            Me.lblIdComprobanteEgresoBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteEgresoBanco.TabIndex = 3
            Me.lblIdComprobanteEgresoBanco.Text = "..."
            '
            'dtpHasta
            '
            Me.dtpHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(646, 17)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(98, 21)
            Me.dtpHasta.TabIndex = 1
            '
            'dtpDesde
            '
            Me.dtpDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(500, 18)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(97, 21)
            Me.dtpDesde.TabIndex = 0
            Me.dtpDesde.Value = New Date(2013, 1, 1, 0, 1, 0, 0)
            '
            'dgvCuentasPorCobrar
            '
            Me.dgvCuentasPorCobrar.AllowUserToAddRows = False
            Me.dgvCuentasPorCobrar.AllowUserToDeleteRows = False
            Me.dgvCuentasPorCobrar.AllowUserToResizeRows = False
            DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCuentasPorCobrar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle27
            Me.dgvCuentasPorCobrar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvCuentasPorCobrar.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvCuentasPorCobrar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvCuentasPorCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCuentasPorCobrar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15})
            DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCuentasPorCobrar.DefaultCellStyle = DataGridViewCellStyle39
            Me.dgvCuentasPorCobrar.GridColor = System.Drawing.SystemColors.ControlLightLight
            Me.dgvCuentasPorCobrar.Location = New System.Drawing.Point(3, 110)
            Me.dgvCuentasPorCobrar.MultiSelect = False
            Me.dgvCuentasPorCobrar.Name = "dgvCuentasPorCobrar"
            Me.dgvCuentasPorCobrar.ReadOnly = True
            Me.dgvCuentasPorCobrar.RowHeadersVisible = False
            Me.dgvCuentasPorCobrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCuentasPorCobrar.Size = New System.Drawing.Size(888, 319)
            Me.dgvCuentasPorCobrar.TabIndex = 189
            '
            'Column1
            '
            DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column1.DefaultCellStyle = DataGridViewCellStyle28
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
            DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column3.DefaultCellStyle = DataGridViewCellStyle29
            Me.Column3.HeaderText = "ID FACT"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 60
            '
            'Column4
            '
            DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column4.DefaultCellStyle = DataGridViewCellStyle30
            Me.Column4.HeaderText = "N° FACTURA"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 110
            '
            'Column5
            '
            DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column5.DefaultCellStyle = DataGridViewCellStyle31
            Me.Column5.HeaderText = "FEC. EMISIÓN"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Width = 120
            '
            'Column6
            '
            DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column6.DefaultCellStyle = DataGridViewCellStyle32
            Me.Column6.HeaderText = "FACTURADO"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.Width = 80
            '
            'Column7
            '
            DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column7.DefaultCellStyle = DataGridViewCellStyle33
            Me.Column7.HeaderText = "RETENIDO"
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.Width = 80
            '
            'Column8
            '
            DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column8.DefaultCellStyle = DataGridViewCellStyle34
            Me.Column8.HeaderText = "A COBRAR"
            Me.Column8.Name = "Column8"
            Me.Column8.ReadOnly = True
            Me.Column8.Width = 80
            '
            'Column9
            '
            DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column9.DefaultCellStyle = DataGridViewCellStyle35
            Me.Column9.HeaderText = "NOT. CRÉDITO"
            Me.Column9.Name = "Column9"
            Me.Column9.ReadOnly = True
            Me.Column9.Width = 80
            '
            'Column10
            '
            DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column10.DefaultCellStyle = DataGridViewCellStyle36
            Me.Column10.HeaderText = "ABONADO"
            Me.Column10.Name = "Column10"
            Me.Column10.ReadOnly = True
            Me.Column10.Width = 80
            '
            'Column11
            '
            DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column11.DefaultCellStyle = DataGridViewCellStyle37
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
            Me.Column13.Width = 350
            '
            'Column14
            '
            Me.Column14.HeaderText = "TITULAR CUENTA"
            Me.Column14.Name = "Column14"
            Me.Column14.ReadOnly = True
            Me.Column14.Width = 350
            '
            'Column15
            '
            DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column15.DefaultCellStyle = DataGridViewCellStyle38
            Me.Column15.HeaderText = "$$ CONVENIO"
            Me.Column15.Name = "Column15"
            Me.Column15.ReadOnly = True
            '
            'txtTotalNotaCredito
            '
            Me.txtTotalNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtTotalNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalNotaCredito.Location = New System.Drawing.Point(358, 31)
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
            Me.txtTotalCuentasPorCobrar.Location = New System.Drawing.Point(589, 32)
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
            Me.txtTotalAbonado.Location = New System.Drawing.Point(589, 4)
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
            Me.txtTotalFacturas.Location = New System.Drawing.Point(118, 3)
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
            Me.txtTotalRetencion.Location = New System.Drawing.Point(118, 30)
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
            Me.txtTotalACobrar.Location = New System.Drawing.Point(358, 3)
            Me.txtTotalACobrar.Name = "txtTotalACobrar"
            Me.txtTotalACobrar.ReadOnly = True
            Me.txtTotalACobrar.Size = New System.Drawing.Size(95, 21)
            Me.txtTotalACobrar.TabIndex = 0
            Me.txtTotalACobrar.Text = "0.00"
            Me.txtTotalACobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 36)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbxBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdComprobanteEgresoBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbPorCliente)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpHasta)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(890, 68)
            Me.KryptonGroupBox1.TabIndex = 191
            Me.KryptonGroupBox1.Values.Heading = "Tipo"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(601, 17)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel2.TabIndex = 78
            Me.KryptonLabel2.Values.Text = "Hasta"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(449, 18)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel1.TabIndex = 77
            Me.KryptonLabel1.Values.Text = "Desde"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(169, 61)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(42, 13)
            Me.Label5.TabIndex = 192
            Me.Label5.Text = "Cliente"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(762, 61)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(38, 13)
            Me.Label6.TabIndex = 193
            Me.Label6.Text = "Banco"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(3, 435)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalCuentasPorCobrar)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalNotaCredito)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalAbonado)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalFacturas)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalRetencion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalACobrar)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(760, 82)
            Me.KryptonGroupBox2.TabIndex = 194
            Me.KryptonGroupBox2.Values.Heading = "Valores"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(492, 32)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(71, 20)
            Me.KryptonLabel8.TabIndex = 15
            Me.KryptonLabel8.Values.Text = "Total Saldo"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(492, 4)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(91, 20)
            Me.KryptonLabel7.TabIndex = 14
            Me.KryptonLabel7.Values.Text = "Total Abonado"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(256, 30)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(96, 20)
            Me.KryptonLabel6.TabIndex = 7
            Me.KryptonLabel6.Values.Text = "Total N. Credito"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(256, 4)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(78, 20)
            Me.KryptonLabel5.TabIndex = 6
            Me.KryptonLabel5.Values.Text = "Total Cobrar"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(8, 30)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(96, 20)
            Me.KryptonLabel4.TabIndex = 5
            Me.KryptonLabel4.Values.Text = "Total Retencion"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(8, 4)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(104, 20)
            Me.KryptonLabel3.TabIndex = 0
            Me.KryptonLabel3.Values.Text = "Total Facturacion"
            '
            'FrmCuentasPorCobrarGeneralClienteConvenio
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(895, 518)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.dgvCuentasPorCobrar)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Name = "FrmCuentasPorCobrarGeneralClienteConvenio"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "DETALLE DE CUENTAS POR CLIENTE / CONVENIO DÉBITO BANCARIO"
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
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtNombreComercialClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents rbPorCliente As System.Windows.Forms.RadioButton
        Friend WithEvents rbGeneral As System.Windows.Forms.RadioButton
        Friend WithEvents lblIdComprobanteEgresoBanco As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents dgvCuentasPorCobrar As System.Windows.Forms.DataGridView
        Friend WithEvents txtTotalNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalCuentasPorCobrar As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalAbonado As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalFacturas As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalACobrar As System.Windows.Forms.TextBox
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
        Friend WithEvents cbxBanco As System.Windows.Forms.ComboBox
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents Label5 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    End Class

End Namespace