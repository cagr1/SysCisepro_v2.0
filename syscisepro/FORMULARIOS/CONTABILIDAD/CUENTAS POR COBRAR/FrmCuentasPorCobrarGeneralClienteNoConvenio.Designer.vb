Namespace FORMULARIOS.CONTABILIDAD.CUENTAS_POR_COBRAR
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCuentasPorCobrarGeneralClienteNoConvenio
        Inherits System.Windows.Forms.Form

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCuentasPorCobrarGeneralClienteNoConvenio))
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
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbTotal = New System.Windows.Forms.GroupBox()
            Me.txtTotalNotaCredito = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtTotalCuentasPorCobrar = New System.Windows.Forms.TextBox()
            Me.txtTotalAbonado = New System.Windows.Forms.TextBox()
            Me.txtTotalFacturas = New System.Windows.Forms.TextBox()
            Me.txtTotalRetencion = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtTotalACobrar = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtNombreComercialClienteGeneral = New System.Windows.Forms.TextBox()
            Me.rbPorCliente = New System.Windows.Forms.RadioButton()
            Me.rbGeneral = New System.Windows.Forms.RadioButton()
            Me.gbTipoReporte = New System.Windows.Forms.GroupBox()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.lblIdComprobanteEgresoBanco = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.gbClienteGeneral = New System.Windows.Forms.GroupBox()
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
            Me.MenuStrip1.SuspendLayout()
            Me.gbTotal.SuspendLayout()
            Me.gbTipoReporte.SuspendLayout()
            Me.gbRangoFechas.SuspendLayout()
            Me.gbClienteGeneral.SuspendLayout()
            CType(Me.dgvCuentasPorCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1294, 24)
            Me.MenuStrip1.TabIndex = 191
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(119, 20)
            Me.btnBuscar.Text = "BUSCAR TODOS"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(91, 20)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'gbTotal
            '
            Me.gbTotal.BackColor = System.Drawing.Color.White
            Me.gbTotal.Controls.Add(Me.txtTotalNotaCredito)
            Me.gbTotal.Controls.Add(Me.Label9)
            Me.gbTotal.Controls.Add(Me.txtTotalCuentasPorCobrar)
            Me.gbTotal.Controls.Add(Me.txtTotalAbonado)
            Me.gbTotal.Controls.Add(Me.txtTotalFacturas)
            Me.gbTotal.Controls.Add(Me.txtTotalRetencion)
            Me.gbTotal.Controls.Add(Me.Label2)
            Me.gbTotal.Controls.Add(Me.txtTotalACobrar)
            Me.gbTotal.Controls.Add(Me.Label8)
            Me.gbTotal.Controls.Add(Me.Label1)
            Me.gbTotal.Controls.Add(Me.Label3)
            Me.gbTotal.Controls.Add(Me.Label4)
            Me.gbTotal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotal.Location = New System.Drawing.Point(0, 609)
            Me.gbTotal.Name = "gbTotal"
            Me.gbTotal.Size = New System.Drawing.Size(1292, 44)
            Me.gbTotal.TabIndex = 196
            Me.gbTotal.TabStop = False
            '
            'txtTotalNotaCredito
            '
            Me.txtTotalNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtTotalNotaCredito.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalNotaCredito.Location = New System.Drawing.Point(877, 15)
            Me.txtTotalNotaCredito.Name = "txtTotalNotaCredito"
            Me.txtTotalNotaCredito.ReadOnly = True
            Me.txtTotalNotaCredito.Size = New System.Drawing.Size(95, 23)
            Me.txtTotalNotaCredito.TabIndex = 13
            Me.txtTotalNotaCredito.Text = "0.00"
            Me.txtTotalNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(804, 13)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(67, 26)
            Me.Label9.TabIndex = 14
            Me.Label9.Text = "TOTAL NOTA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CRÉDITO:"
            '
            'txtTotalCuentasPorCobrar
            '
            Me.txtTotalCuentasPorCobrar.BackColor = System.Drawing.Color.White
            Me.txtTotalCuentasPorCobrar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalCuentasPorCobrar.Location = New System.Drawing.Point(1188, 15)
            Me.txtTotalCuentasPorCobrar.Name = "txtTotalCuentasPorCobrar"
            Me.txtTotalCuentasPorCobrar.ReadOnly = True
            Me.txtTotalCuentasPorCobrar.Size = New System.Drawing.Size(95, 23)
            Me.txtTotalCuentasPorCobrar.TabIndex = 0
            Me.txtTotalCuentasPorCobrar.Text = "0.00"
            Me.txtTotalCuentasPorCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalAbonado
            '
            Me.txtTotalAbonado.BackColor = System.Drawing.Color.White
            Me.txtTotalAbonado.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalAbonado.Location = New System.Drawing.Point(1040, 15)
            Me.txtTotalAbonado.Name = "txtTotalAbonado"
            Me.txtTotalAbonado.ReadOnly = True
            Me.txtTotalAbonado.Size = New System.Drawing.Size(95, 23)
            Me.txtTotalAbonado.TabIndex = 10
            Me.txtTotalAbonado.Text = "0.00"
            Me.txtTotalAbonado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalFacturas
            '
            Me.txtTotalFacturas.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturas.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturas.Location = New System.Drawing.Point(364, 15)
            Me.txtTotalFacturas.Name = "txtTotalFacturas"
            Me.txtTotalFacturas.ReadOnly = True
            Me.txtTotalFacturas.Size = New System.Drawing.Size(95, 23)
            Me.txtTotalFacturas.TabIndex = 4
            Me.txtTotalFacturas.Text = "0.00"
            Me.txtTotalFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalRetencion
            '
            Me.txtTotalRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalRetencion.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalRetencion.Location = New System.Drawing.Point(536, 15)
            Me.txtTotalRetencion.Name = "txtTotalRetencion"
            Me.txtTotalRetencion.ReadOnly = True
            Me.txtTotalRetencion.Size = New System.Drawing.Size(95, 23)
            Me.txtTotalRetencion.TabIndex = 2
            Me.txtTotalRetencion.Text = "0.00"
            Me.txtTotalRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(641, 13)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(49, 26)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "TOTAL A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COBRAR:"
            '
            'txtTotalACobrar
            '
            Me.txtTotalACobrar.BackColor = System.Drawing.Color.White
            Me.txtTotalACobrar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalACobrar.Location = New System.Drawing.Point(692, 15)
            Me.txtTotalACobrar.Name = "txtTotalACobrar"
            Me.txtTotalACobrar.ReadOnly = True
            Me.txtTotalACobrar.Size = New System.Drawing.Size(95, 23)
            Me.txtTotalACobrar.TabIndex = 0
            Me.txtTotalACobrar.Text = "0.00"
            Me.txtTotalACobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(1146, 13)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(43, 26)
            Me.Label8.TabIndex = 12
            Me.Label8.Text = "TOTAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SALDO:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(985, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(55, 26)
            Me.Label1.TabIndex = 11
            Me.Label1.Text = "TOTAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ABONADO:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(470, 13)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(67, 26)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "TOTAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RETENCIÓN:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(287, 13)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(79, 26)
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "TOTAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FACTURACIÓN:"
            '
            'txtNombreComercialClienteGeneral
            '
            Me.txtNombreComercialClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialClienteGeneral.Enabled = False
            Me.txtNombreComercialClienteGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialClienteGeneral.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtNombreComercialClienteGeneral.Location = New System.Drawing.Point(6, 14)
            Me.txtNombreComercialClienteGeneral.Name = "txtNombreComercialClienteGeneral"
            Me.txtNombreComercialClienteGeneral.Size = New System.Drawing.Size(456, 20)
            Me.txtNombreComercialClienteGeneral.TabIndex = 2
            '
            'rbPorCliente
            '
            Me.rbPorCliente.AutoSize = True
            Me.rbPorCliente.Location = New System.Drawing.Point(136, 14)
            Me.rbPorCliente.Name = "rbPorCliente"
            Me.rbPorCliente.Size = New System.Drawing.Size(91, 17)
            Me.rbPorCliente.TabIndex = 1
            Me.rbPorCliente.TabStop = True
            Me.rbPorCliente.Text = "POR CLIENTE"
            Me.rbPorCliente.UseVisualStyleBackColor = True
            '
            'rbGeneral
            '
            Me.rbGeneral.AutoSize = True
            Me.rbGeneral.Checked = True
            Me.rbGeneral.Location = New System.Drawing.Point(12, 14)
            Me.rbGeneral.Name = "rbGeneral"
            Me.rbGeneral.Size = New System.Drawing.Size(67, 17)
            Me.rbGeneral.TabIndex = 0
            Me.rbGeneral.TabStop = True
            Me.rbGeneral.Text = "GENERAL"
            Me.rbGeneral.UseVisualStyleBackColor = True
            '
            'gbTipoReporte
            '
            Me.gbTipoReporte.Controls.Add(Me.rbPorCliente)
            Me.gbTipoReporte.Controls.Add(Me.rbGeneral)
            Me.gbTipoReporte.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoReporte.Location = New System.Drawing.Point(0, 28)
            Me.gbTipoReporte.Name = "gbTipoReporte"
            Me.gbTipoReporte.Size = New System.Drawing.Size(242, 40)
            Me.gbTipoReporte.TabIndex = 192
            Me.gbTipoReporte.TabStop = False
            Me.gbTipoReporte.Text = "TIPO DE REPORTE"
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.Controls.Add(Me.Label10)
            Me.gbRangoFechas.Controls.Add(Me.lblIdComprobanteEgresoBanco)
            Me.gbRangoFechas.Controls.Add(Me.Label7)
            Me.gbRangoFechas.Controls.Add(Me.dtpHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpDesde)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(710, 28)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(582, 40)
            Me.gbRangoFechas.TabIndex = 194
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(13, 19)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(37, 13)
            Me.Label10.TabIndex = 4
            Me.Label10.Text = "Desde"
            '
            'lblIdComprobanteEgresoBanco
            '
            Me.lblIdComprobanteEgresoBanco.AutoSize = True
            Me.lblIdComprobanteEgresoBanco.Location = New System.Drawing.Point(191, 0)
            Me.lblIdComprobanteEgresoBanco.Name = "lblIdComprobanteEgresoBanco"
            Me.lblIdComprobanteEgresoBanco.Size = New System.Drawing.Size(25, 13)
            Me.lblIdComprobanteEgresoBanco.TabIndex = 3
            Me.lblIdComprobanteEgresoBanco.Text = "..."
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(191, 18)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(37, 13)
            Me.Label7.TabIndex = 2
            Me.Label7.Text = "hasta"
            '
            'dtpHasta
            '
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(234, 15)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(98, 20)
            Me.dtpHasta.TabIndex = 1
            '
            'dtpDesde
            '
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(56, 14)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(97, 20)
            Me.dtpDesde.TabIndex = 0
            Me.dtpDesde.Value = New Date(2013, 1, 1, 0, 1, 0, 0)
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(74, -1)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(25, 13)
            Me.lblIdClienteGeneral.TabIndex = 76
            Me.lblIdClienteGeneral.Text = "..."
            '
            'gbClienteGeneral
            '
            Me.gbClienteGeneral.Controls.Add(Me.txtNombreComercialClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.lblIdClienteGeneral)
            Me.gbClienteGeneral.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbClienteGeneral.Location = New System.Drawing.Point(242, 28)
            Me.gbClienteGeneral.Name = "gbClienteGeneral"
            Me.gbClienteGeneral.Size = New System.Drawing.Size(468, 40)
            Me.gbClienteGeneral.TabIndex = 193
            Me.gbClienteGeneral.TabStop = False
            Me.gbClienteGeneral.Text = "CLIENTE"
            '
            'dgvCuentasPorCobrar
            '
            Me.dgvCuentasPorCobrar.AllowUserToAddRows = False
            Me.dgvCuentasPorCobrar.AllowUserToDeleteRows = False
            Me.dgvCuentasPorCobrar.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCuentasPorCobrar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCuentasPorCobrar.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvCuentasPorCobrar.Location = New System.Drawing.Point(1, 68)
            Me.dgvCuentasPorCobrar.MultiSelect = False
            Me.dgvCuentasPorCobrar.Name = "dgvCuentasPorCobrar"
            Me.dgvCuentasPorCobrar.ReadOnly = True
            Me.dgvCuentasPorCobrar.RowHeadersVisible = False
            Me.dgvCuentasPorCobrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCuentasPorCobrar.Size = New System.Drawing.Size(1292, 543)
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
            'FrmCuentasPorCobrarGeneralClienteNoConvenio
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1294, 655)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbTotal)
            Me.Controls.Add(Me.gbTipoReporte)
            Me.Controls.Add(Me.gbRangoFechas)
            Me.Controls.Add(Me.gbClienteGeneral)
            Me.Controls.Add(Me.dgvCuentasPorCobrar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "FrmCuentasPorCobrarGeneralClienteNoConvenio"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "DETALLE DE CUENTAS POR CLIENTE / SIN CONVENIO DÉBITO BANCARIO"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.gbTotal.ResumeLayout(False)
            Me.gbTotal.PerformLayout()
            Me.gbTipoReporte.ResumeLayout(False)
            Me.gbTipoReporte.PerformLayout()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.gbClienteGeneral.ResumeLayout(False)
            Me.gbClienteGeneral.PerformLayout()
            CType(Me.dgvCuentasPorCobrar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents gbTotal As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtTotalCuentasPorCobrar As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalAbonado As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalFacturas As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalRetencion As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtTotalACobrar As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtNombreComercialClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents rbPorCliente As System.Windows.Forms.RadioButton
        Friend WithEvents rbGeneral As System.Windows.Forms.RadioButton
        Friend WithEvents gbTipoReporte As System.Windows.Forms.GroupBox
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteEgresoBanco As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents gbClienteGeneral As System.Windows.Forms.GroupBox
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
    End Class
End Namespace