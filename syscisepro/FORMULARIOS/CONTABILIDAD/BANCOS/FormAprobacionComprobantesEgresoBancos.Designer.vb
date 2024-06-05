Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAprobacionComprobantesEgresoBancos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAprobacionComprobantesEgresoBancos))
            Me.dgvComprobanteEgresoBancos = New System.Windows.Forms.DataGridView()
            Me.gbComprobanteEgresoBancos = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtRazon = New System.Windows.Forms.TextBox()
            Me.lblNumeroComprobante = New System.Windows.Forms.Label()
            Me.txtRucCi = New System.Windows.Forms.TextBox()
            Me.lblRucCi = New System.Windows.Forms.Label()
            Me.txtActividad = New System.Windows.Forms.TextBox()
            Me.lblActividad = New System.Windows.Forms.Label()
            Me.txtNumeroComprobanteEgreso = New System.Windows.Forms.TextBox()
            Me.txtNumeroCheque = New System.Windows.Forms.TextBox()
            Me.lblFechaComprobanteEgreso = New System.Windows.Forms.Label()
            Me.lblNumeroCheque = New System.Windows.Forms.Label()
            Me.txtFechaComprobanteEgreso = New System.Windows.Forms.TextBox()
            Me.txtValorComprobante = New System.Windows.Forms.TextBox()
            Me.lblNumeroFactura = New System.Windows.Forms.Label()
            Me.lblValorComprobante = New System.Windows.Forms.Label()
            Me.txtNumeroFactura = New System.Windows.Forms.TextBox()
            Me.txtCuenta = New System.Windows.Forms.TextBox()
            Me.lblCuenta = New System.Windows.Forms.Label()
            Me.txtBanco = New System.Windows.Forms.TextBox()
            Me.lblPagadoA = New System.Windows.Forms.Label()
            Me.lblBanco = New System.Windows.Forms.Label()
            Me.txtPagadoA = New System.Windows.Forms.TextBox()
            Me.txtTipoPago = New System.Windows.Forms.TextBox()
            Me.lblTipoPago = New System.Windows.Forms.Label()
            Me.txtConcepto = New System.Windows.Forms.TextBox()
            Me.lblConcepto = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAprovar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnRechazar = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbComprobanteEgresoBancos.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.gbRangoFechas.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvComprobanteEgresoBancos
            '
            Me.dgvComprobanteEgresoBancos.AllowUserToAddRows = False
            Me.dgvComprobanteEgresoBancos.AllowUserToDeleteRows = False
            Me.dgvComprobanteEgresoBancos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobanteEgresoBancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvComprobanteEgresoBancos.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobanteEgresoBancos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobanteEgresoBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteEgresoBancos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobanteEgresoBancos.Location = New System.Drawing.Point(3, 15)
            Me.dgvComprobanteEgresoBancos.MultiSelect = False
            Me.dgvComprobanteEgresoBancos.Name = "dgvComprobanteEgresoBancos"
            Me.dgvComprobanteEgresoBancos.ReadOnly = True
            Me.dgvComprobanteEgresoBancos.RowHeadersVisible = False
            Me.dgvComprobanteEgresoBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteEgresoBancos.Size = New System.Drawing.Size(1105, 277)
            Me.dgvComprobanteEgresoBancos.TabIndex = 44
            '
            'gbComprobanteEgresoBancos
            '
            Me.gbComprobanteEgresoBancos.BackColor = System.Drawing.Color.White
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.Label1)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.txtRazon)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.lblNumeroComprobante)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.txtRucCi)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.lblRucCi)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.txtActividad)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.lblActividad)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.txtNumeroComprobanteEgreso)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.txtNumeroCheque)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.lblFechaComprobanteEgreso)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.lblNumeroCheque)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.txtFechaComprobanteEgreso)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.txtValorComprobante)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.lblNumeroFactura)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.lblValorComprobante)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.txtNumeroFactura)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.txtCuenta)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.lblCuenta)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.txtBanco)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.lblPagadoA)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.lblBanco)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.txtPagadoA)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.txtTipoPago)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.lblTipoPago)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.txtConcepto)
            Me.gbComprobanteEgresoBancos.Controls.Add(Me.lblConcepto)
            Me.gbComprobanteEgresoBancos.Location = New System.Drawing.Point(2, 69)
            Me.gbComprobanteEgresoBancos.Name = "gbComprobanteEgresoBancos"
            Me.gbComprobanteEgresoBancos.Size = New System.Drawing.Size(1111, 124)
            Me.gbComprobanteEgresoBancos.TabIndex = 46
            Me.gbComprobanteEgresoBancos.TabStop = False
            Me.gbComprobanteEgresoBancos.Text = "COMPROBANTE DE EGRESO"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(883, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(47, 13)
            Me.Label1.TabIndex = 45
            Me.Label1.Text = "RAZON:"
            '
            'txtRazon
            '
            Me.txtRazon.BackColor = System.Drawing.Color.White
            Me.txtRazon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazon.Enabled = False
            Me.txtRazon.Location = New System.Drawing.Point(933, 17)
            Me.txtRazon.Multiline = True
            Me.txtRazon.Name = "txtRazon"
            Me.txtRazon.ReadOnly = True
            Me.txtRazon.Size = New System.Drawing.Size(172, 98)
            Me.txtRazon.TabIndex = 46
            '
            'lblNumeroComprobante
            '
            Me.lblNumeroComprobante.AutoSize = True
            Me.lblNumeroComprobante.Location = New System.Drawing.Point(14, 20)
            Me.lblNumeroComprobante.Name = "lblNumeroComprobante"
            Me.lblNumeroComprobante.Size = New System.Drawing.Size(87, 13)
            Me.lblNumeroComprobante.TabIndex = 19
            Me.lblNumeroComprobante.Text = "NUMERO :  CE -"
            '
            'txtRucCi
            '
            Me.txtRucCi.BackColor = System.Drawing.Color.White
            Me.txtRucCi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucCi.Enabled = False
            Me.txtRucCi.Location = New System.Drawing.Point(107, 95)
            Me.txtRucCi.Name = "txtRucCi"
            Me.txtRucCi.ReadOnly = True
            Me.txtRucCi.Size = New System.Drawing.Size(115, 22)
            Me.txtRucCi.TabIndex = 26
            '
            'lblRucCi
            '
            Me.lblRucCi.AutoSize = True
            Me.lblRucCi.Location = New System.Drawing.Point(14, 98)
            Me.lblRucCi.Name = "lblRucCi"
            Me.lblRucCi.Size = New System.Drawing.Size(46, 13)
            Me.lblRucCi.TabIndex = 25
            Me.lblRucCi.Text = "RUC/CI:"
            '
            'txtActividad
            '
            Me.txtActividad.BackColor = System.Drawing.Color.White
            Me.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtActividad.Enabled = False
            Me.txtActividad.Location = New System.Drawing.Point(319, 17)
            Me.txtActividad.Name = "txtActividad"
            Me.txtActividad.ReadOnly = True
            Me.txtActividad.Size = New System.Drawing.Size(322, 22)
            Me.txtActividad.TabIndex = 30
            '
            'lblActividad
            '
            Me.lblActividad.AutoSize = True
            Me.lblActividad.Location = New System.Drawing.Point(238, 20)
            Me.lblActividad.Name = "lblActividad"
            Me.lblActividad.Size = New System.Drawing.Size(72, 13)
            Me.lblActividad.TabIndex = 29
            Me.lblActividad.Text = "ACTIVIDAD  :"
            '
            'txtNumeroComprobanteEgreso
            '
            Me.txtNumeroComprobanteEgreso.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteEgreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroComprobanteEgreso.Enabled = False
            Me.txtNumeroComprobanteEgreso.Location = New System.Drawing.Point(107, 17)
            Me.txtNumeroComprobanteEgreso.Name = "txtNumeroComprobanteEgreso"
            Me.txtNumeroComprobanteEgreso.ReadOnly = True
            Me.txtNumeroComprobanteEgreso.Size = New System.Drawing.Size(61, 22)
            Me.txtNumeroComprobanteEgreso.TabIndex = 20
            '
            'txtNumeroCheque
            '
            Me.txtNumeroCheque.BackColor = System.Drawing.Color.White
            Me.txtNumeroCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroCheque.Enabled = False
            Me.txtNumeroCheque.Location = New System.Drawing.Point(714, 69)
            Me.txtNumeroCheque.Name = "txtNumeroCheque"
            Me.txtNumeroCheque.ReadOnly = True
            Me.txtNumeroCheque.Size = New System.Drawing.Size(133, 22)
            Me.txtNumeroCheque.TabIndex = 42
            '
            'lblFechaComprobanteEgreso
            '
            Me.lblFechaComprobanteEgreso.AutoSize = True
            Me.lblFechaComprobanteEgreso.Location = New System.Drawing.Point(14, 46)
            Me.lblFechaComprobanteEgreso.Name = "lblFechaComprobanteEgreso"
            Me.lblFechaComprobanteEgreso.Size = New System.Drawing.Size(47, 13)
            Me.lblFechaComprobanteEgreso.TabIndex = 21
            Me.lblFechaComprobanteEgreso.Text = "FECHA :"
            '
            'lblNumeroCheque
            '
            Me.lblNumeroCheque.AutoSize = True
            Me.lblNumeroCheque.Location = New System.Drawing.Point(647, 72)
            Me.lblNumeroCheque.Name = "lblNumeroCheque"
            Me.lblNumeroCheque.Size = New System.Drawing.Size(69, 13)
            Me.lblNumeroCheque.TabIndex = 41
            Me.lblNumeroCheque.Text = "Nº CHEQUE:"
            '
            'txtFechaComprobanteEgreso
            '
            Me.txtFechaComprobanteEgreso.BackColor = System.Drawing.Color.White
            Me.txtFechaComprobanteEgreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaComprobanteEgreso.Enabled = False
            Me.txtFechaComprobanteEgreso.Location = New System.Drawing.Point(107, 43)
            Me.txtFechaComprobanteEgreso.Name = "txtFechaComprobanteEgreso"
            Me.txtFechaComprobanteEgreso.ReadOnly = True
            Me.txtFechaComprobanteEgreso.Size = New System.Drawing.Size(115, 22)
            Me.txtFechaComprobanteEgreso.TabIndex = 22
            '
            'txtValorComprobante
            '
            Me.txtValorComprobante.BackColor = System.Drawing.Color.White
            Me.txtValorComprobante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorComprobante.Enabled = False
            Me.txtValorComprobante.Location = New System.Drawing.Point(714, 95)
            Me.txtValorComprobante.Name = "txtValorComprobante"
            Me.txtValorComprobante.ReadOnly = True
            Me.txtValorComprobante.Size = New System.Drawing.Size(133, 22)
            Me.txtValorComprobante.TabIndex = 40
            '
            'lblNumeroFactura
            '
            Me.lblNumeroFactura.AutoSize = True
            Me.lblNumeroFactura.Location = New System.Drawing.Point(14, 72)
            Me.lblNumeroFactura.Name = "lblNumeroFactura"
            Me.lblNumeroFactura.Size = New System.Drawing.Size(87, 13)
            Me.lblNumeroFactura.TabIndex = 23
            Me.lblNumeroFactura.Text = "NRO FACTURA :"
            '
            'lblValorComprobante
            '
            Me.lblValorComprobante.AutoSize = True
            Me.lblValorComprobante.Location = New System.Drawing.Point(647, 98)
            Me.lblValorComprobante.Name = "lblValorComprobante"
            Me.lblValorComprobante.Size = New System.Drawing.Size(53, 13)
            Me.lblValorComprobante.TabIndex = 39
            Me.lblValorComprobante.Text = "VALOR $:"
            '
            'txtNumeroFactura
            '
            Me.txtNumeroFactura.BackColor = System.Drawing.Color.White
            Me.txtNumeroFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroFactura.Enabled = False
            Me.txtNumeroFactura.Location = New System.Drawing.Point(107, 69)
            Me.txtNumeroFactura.Name = "txtNumeroFactura"
            Me.txtNumeroFactura.ReadOnly = True
            Me.txtNumeroFactura.Size = New System.Drawing.Size(115, 22)
            Me.txtNumeroFactura.TabIndex = 24
            '
            'txtCuenta
            '
            Me.txtCuenta.BackColor = System.Drawing.Color.White
            Me.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCuenta.Enabled = False
            Me.txtCuenta.Location = New System.Drawing.Point(714, 43)
            Me.txtCuenta.Name = "txtCuenta"
            Me.txtCuenta.ReadOnly = True
            Me.txtCuenta.Size = New System.Drawing.Size(133, 22)
            Me.txtCuenta.TabIndex = 38
            '
            'lblCuenta
            '
            Me.lblCuenta.AutoSize = True
            Me.lblCuenta.Location = New System.Drawing.Point(647, 46)
            Me.lblCuenta.Name = "lblCuenta"
            Me.lblCuenta.Size = New System.Drawing.Size(54, 13)
            Me.lblCuenta.TabIndex = 37
            Me.lblCuenta.Text = "CUENTA :"
            '
            'txtBanco
            '
            Me.txtBanco.BackColor = System.Drawing.Color.White
            Me.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBanco.Enabled = False
            Me.txtBanco.Location = New System.Drawing.Point(714, 17)
            Me.txtBanco.Name = "txtBanco"
            Me.txtBanco.ReadOnly = True
            Me.txtBanco.Size = New System.Drawing.Size(133, 22)
            Me.txtBanco.TabIndex = 36
            '
            'lblPagadoA
            '
            Me.lblPagadoA.AutoSize = True
            Me.lblPagadoA.Location = New System.Drawing.Point(238, 98)
            Me.lblPagadoA.Name = "lblPagadoA"
            Me.lblPagadoA.Size = New System.Drawing.Size(67, 13)
            Me.lblPagadoA.TabIndex = 27
            Me.lblPagadoA.Text = "PAGADO A :"
            '
            'lblBanco
            '
            Me.lblBanco.AutoSize = True
            Me.lblBanco.Location = New System.Drawing.Point(647, 20)
            Me.lblBanco.Name = "lblBanco"
            Me.lblBanco.Size = New System.Drawing.Size(50, 13)
            Me.lblBanco.TabIndex = 35
            Me.lblBanco.Text = "BANCO :"
            '
            'txtPagadoA
            '
            Me.txtPagadoA.BackColor = System.Drawing.Color.White
            Me.txtPagadoA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPagadoA.Enabled = False
            Me.txtPagadoA.Location = New System.Drawing.Point(318, 95)
            Me.txtPagadoA.Name = "txtPagadoA"
            Me.txtPagadoA.ReadOnly = True
            Me.txtPagadoA.Size = New System.Drawing.Size(323, 22)
            Me.txtPagadoA.TabIndex = 28
            '
            'txtTipoPago
            '
            Me.txtTipoPago.BackColor = System.Drawing.Color.White
            Me.txtTipoPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoPago.Enabled = False
            Me.txtTipoPago.Location = New System.Drawing.Point(319, 69)
            Me.txtTipoPago.Name = "txtTipoPago"
            Me.txtTipoPago.ReadOnly = True
            Me.txtTipoPago.Size = New System.Drawing.Size(322, 22)
            Me.txtTipoPago.TabIndex = 34
            '
            'lblTipoPago
            '
            Me.lblTipoPago.AutoSize = True
            Me.lblTipoPago.Location = New System.Drawing.Point(238, 72)
            Me.lblTipoPago.Name = "lblTipoPago"
            Me.lblTipoPago.Size = New System.Drawing.Size(69, 13)
            Me.lblTipoPago.TabIndex = 33
            Me.lblTipoPago.Text = "TIPO PAGO :"
            '
            'txtConcepto
            '
            Me.txtConcepto.BackColor = System.Drawing.Color.White
            Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtConcepto.Enabled = False
            Me.txtConcepto.Location = New System.Drawing.Point(319, 43)
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.ReadOnly = True
            Me.txtConcepto.Size = New System.Drawing.Size(322, 22)
            Me.txtConcepto.TabIndex = 32
            '
            'lblConcepto
            '
            Me.lblConcepto.AutoSize = True
            Me.lblConcepto.Location = New System.Drawing.Point(238, 46)
            Me.lblConcepto.Name = "lblConcepto"
            Me.lblConcepto.Size = New System.Drawing.Size(70, 13)
            Me.lblConcepto.TabIndex = 31
            Me.lblConcepto.Text = "CONCEPTO :"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.AllowMerge = False
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnAprovar, Me.btnRechazar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1115, 24)
            Me.MenuStrip1.TabIndex = 186
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 20)
            Me.ToolStripMenuItem1.Text = "CARGAR COMPROBANTES"
            '
            'btnAprovar
            '
            Me.btnAprovar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAprovar.Image = Global.syscisepro.My.Resources.Resources.ok
            Me.btnAprovar.Name = "btnAprovar"
            Me.btnAprovar.Size = New System.Drawing.Size(168, 20)
            Me.btnAprovar.Text = "APROBAR COMPROBANTE"
            '
            'btnRechazar
            '
            Me.btnRechazar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRechazar.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnRechazar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnRechazar.Name = "btnRechazar"
            Me.btnRechazar.Size = New System.Drawing.Size(175, 20)
            Me.btnRechazar.Text = "RECHAZAR COMPROBANTE"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dgvComprobanteEgresoBancos)
            Me.GroupBox1.Location = New System.Drawing.Point(2, 193)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1111, 295)
            Me.GroupBox1.TabIndex = 187
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "DETALLES DE LA ÓRDEN"
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaDesde)
            Me.gbRangoFechas.Controls.Add(Me.Label9)
            Me.gbRangoFechas.Controls.Add(Me.Label2)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(2, 27)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(1111, 41)
            Me.gbRangoFechas.TabIndex = 188
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "CARGAR COMPROBANTES DESDE LA FECHA"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Location = New System.Drawing.Point(332, 15)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(234, 20)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Location = New System.Drawing.Point(47, 15)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(234, 20)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(17, 18)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(31, 13)
            Me.Label9.TabIndex = 3
            Me.Label9.Text = "DEL:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(307, 18)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(25, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "AL:"
            '
            'FormAprobacionComprobantesEgresoBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1115, 491)
            Me.Controls.Add(Me.gbRangoFechas)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbComprobanteEgresoBancos)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAprobacionComprobantesEgresoBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "APROBACIÓN COMPROBANTES EGRESO"
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbComprobanteEgresoBancos.ResumeLayout(False)
            Me.gbComprobanteEgresoBancos.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvComprobanteEgresoBancos As System.Windows.Forms.DataGridView
        Friend WithEvents gbComprobanteEgresoBancos As System.Windows.Forms.GroupBox
        Friend WithEvents lblNumeroComprobante As System.Windows.Forms.Label
        Friend WithEvents txtRucCi As System.Windows.Forms.TextBox
        Friend WithEvents lblRucCi As System.Windows.Forms.Label
        Friend WithEvents txtActividad As System.Windows.Forms.TextBox
        Friend WithEvents lblActividad As System.Windows.Forms.Label
        Friend WithEvents txtNumeroComprobanteEgreso As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroCheque As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaComprobanteEgreso As System.Windows.Forms.Label
        Friend WithEvents lblNumeroCheque As System.Windows.Forms.Label
        Friend WithEvents txtFechaComprobanteEgreso As System.Windows.Forms.TextBox
        Friend WithEvents txtValorComprobante As System.Windows.Forms.TextBox
        Friend WithEvents lblNumeroFactura As System.Windows.Forms.Label
        Friend WithEvents lblValorComprobante As System.Windows.Forms.Label
        Friend WithEvents txtNumeroFactura As System.Windows.Forms.TextBox
        Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
        Friend WithEvents lblCuenta As System.Windows.Forms.Label
        Friend WithEvents txtBanco As System.Windows.Forms.TextBox
        Friend WithEvents lblPagadoA As System.Windows.Forms.Label
        Friend WithEvents lblBanco As System.Windows.Forms.Label
        Friend WithEvents txtPagadoA As System.Windows.Forms.TextBox
        Friend WithEvents txtTipoPago As System.Windows.Forms.TextBox
        Friend WithEvents lblTipoPago As System.Windows.Forms.Label
        Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
        Friend WithEvents lblConcepto As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtRazon As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnAprovar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnRechazar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace