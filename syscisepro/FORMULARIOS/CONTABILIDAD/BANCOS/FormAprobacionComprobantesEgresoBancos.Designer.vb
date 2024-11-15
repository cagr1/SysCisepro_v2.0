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
            Me.txtRazon = New System.Windows.Forms.TextBox()
            Me.txtRucCi = New System.Windows.Forms.TextBox()
            Me.txtActividad = New System.Windows.Forms.TextBox()
            Me.txtNumeroComprobanteEgreso = New System.Windows.Forms.TextBox()
            Me.txtNumeroCheque = New System.Windows.Forms.TextBox()
            Me.txtFechaComprobanteEgreso = New System.Windows.Forms.TextBox()
            Me.txtValorComprobante = New System.Windows.Forms.TextBox()
            Me.txtNumeroFactura = New System.Windows.Forms.TextBox()
            Me.txtCuenta = New System.Windows.Forms.TextBox()
            Me.txtBanco = New System.Windows.Forms.TextBox()
            Me.txtPagadoA = New System.Windows.Forms.TextBox()
            Me.txtTipoPago = New System.Windows.Forms.TextBox()
            Me.txtConcepto = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAprovar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnRechazar = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel15 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
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
            'dgvComprobanteEgresoBancos
            '
            Me.dgvComprobanteEgresoBancos.AllowUserToAddRows = False
            Me.dgvComprobanteEgresoBancos.AllowUserToDeleteRows = False
            Me.dgvComprobanteEgresoBancos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobanteEgresoBancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvComprobanteEgresoBancos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvComprobanteEgresoBancos.BorderStyle = System.Windows.Forms.BorderStyle.None
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
            Me.dgvComprobanteEgresoBancos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvComprobanteEgresoBancos.Location = New System.Drawing.Point(0, 0)
            Me.dgvComprobanteEgresoBancos.MultiSelect = False
            Me.dgvComprobanteEgresoBancos.Name = "dgvComprobanteEgresoBancos"
            Me.dgvComprobanteEgresoBancos.ReadOnly = True
            Me.dgvComprobanteEgresoBancos.RowHeadersVisible = False
            Me.dgvComprobanteEgresoBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteEgresoBancos.Size = New System.Drawing.Size(907, 263)
            Me.dgvComprobanteEgresoBancos.TabIndex = 44
            '
            'txtRazon
            '
            Me.txtRazon.BackColor = System.Drawing.Color.White
            Me.txtRazon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazon.Enabled = False
            Me.txtRazon.Location = New System.Drawing.Point(742, 54)
            Me.txtRazon.Multiline = True
            Me.txtRazon.Name = "txtRazon"
            Me.txtRazon.ReadOnly = True
            Me.txtRazon.Size = New System.Drawing.Size(159, 79)
            Me.txtRazon.TabIndex = 46
            '
            'txtRucCi
            '
            Me.txtRucCi.BackColor = System.Drawing.Color.White
            Me.txtRucCi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucCi.Enabled = False
            Me.txtRucCi.Location = New System.Drawing.Point(88, 115)
            Me.txtRucCi.Name = "txtRucCi"
            Me.txtRucCi.ReadOnly = True
            Me.txtRucCi.Size = New System.Drawing.Size(115, 22)
            Me.txtRucCi.TabIndex = 26
            '
            'txtActividad
            '
            Me.txtActividad.BackColor = System.Drawing.Color.White
            Me.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtActividad.Enabled = False
            Me.txtActividad.Location = New System.Drawing.Point(298, 29)
            Me.txtActividad.Name = "txtActividad"
            Me.txtActividad.ReadOnly = True
            Me.txtActividad.Size = New System.Drawing.Size(216, 22)
            Me.txtActividad.TabIndex = 30
            '
            'txtNumeroComprobanteEgreso
            '
            Me.txtNumeroComprobanteEgreso.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteEgreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroComprobanteEgreso.Enabled = False
            Me.txtNumeroComprobanteEgreso.Location = New System.Drawing.Point(89, 31)
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
            Me.txtNumeroCheque.Location = New System.Drawing.Point(599, 87)
            Me.txtNumeroCheque.Name = "txtNumeroCheque"
            Me.txtNumeroCheque.ReadOnly = True
            Me.txtNumeroCheque.Size = New System.Drawing.Size(133, 22)
            Me.txtNumeroCheque.TabIndex = 42
            '
            'txtFechaComprobanteEgreso
            '
            Me.txtFechaComprobanteEgreso.BackColor = System.Drawing.Color.White
            Me.txtFechaComprobanteEgreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaComprobanteEgreso.Enabled = False
            Me.txtFechaComprobanteEgreso.Location = New System.Drawing.Point(88, 59)
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
            Me.txtValorComprobante.Location = New System.Drawing.Point(599, 113)
            Me.txtValorComprobante.Name = "txtValorComprobante"
            Me.txtValorComprobante.ReadOnly = True
            Me.txtValorComprobante.Size = New System.Drawing.Size(133, 22)
            Me.txtValorComprobante.TabIndex = 40
            '
            'txtNumeroFactura
            '
            Me.txtNumeroFactura.BackColor = System.Drawing.Color.White
            Me.txtNumeroFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroFactura.Enabled = False
            Me.txtNumeroFactura.Location = New System.Drawing.Point(89, 87)
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
            Me.txtCuenta.Location = New System.Drawing.Point(599, 57)
            Me.txtCuenta.Name = "txtCuenta"
            Me.txtCuenta.ReadOnly = True
            Me.txtCuenta.Size = New System.Drawing.Size(133, 22)
            Me.txtCuenta.TabIndex = 38
            '
            'txtBanco
            '
            Me.txtBanco.BackColor = System.Drawing.Color.White
            Me.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBanco.Enabled = False
            Me.txtBanco.Location = New System.Drawing.Point(599, 27)
            Me.txtBanco.Name = "txtBanco"
            Me.txtBanco.ReadOnly = True
            Me.txtBanco.Size = New System.Drawing.Size(133, 22)
            Me.txtBanco.TabIndex = 36
            '
            'txtPagadoA
            '
            Me.txtPagadoA.BackColor = System.Drawing.Color.White
            Me.txtPagadoA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPagadoA.Enabled = False
            Me.txtPagadoA.Location = New System.Drawing.Point(298, 115)
            Me.txtPagadoA.Name = "txtPagadoA"
            Me.txtPagadoA.ReadOnly = True
            Me.txtPagadoA.Size = New System.Drawing.Size(217, 22)
            Me.txtPagadoA.TabIndex = 28
            '
            'txtTipoPago
            '
            Me.txtTipoPago.BackColor = System.Drawing.Color.White
            Me.txtTipoPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoPago.Enabled = False
            Me.txtTipoPago.Location = New System.Drawing.Point(298, 87)
            Me.txtTipoPago.Name = "txtTipoPago"
            Me.txtTipoPago.ReadOnly = True
            Me.txtTipoPago.Size = New System.Drawing.Size(216, 22)
            Me.txtTipoPago.TabIndex = 34
            '
            'txtConcepto
            '
            Me.txtConcepto.BackColor = System.Drawing.Color.White
            Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtConcepto.Enabled = False
            Me.txtConcepto.Location = New System.Drawing.Point(298, 59)
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.ReadOnly = True
            Me.txtConcepto.Size = New System.Drawing.Size(216, 22)
            Me.txtConcepto.TabIndex = 32
            '
            'MenuStrip1
            '
            Me.MenuStrip1.AllowMerge = False
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnAprovar, Me.btnRechazar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(919, 32)
            Me.MenuStrip1.TabIndex = 186
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(92, 28)
            Me.ToolStripMenuItem1.Text = "CARGAR "
            '
            'btnAprovar
            '
            Me.btnAprovar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAprovar.Image = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnAprovar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAprovar.Name = "btnAprovar"
            Me.btnAprovar.Size = New System.Drawing.Size(99, 28)
            Me.btnAprovar.Text = "APROBAR "
            '
            'btnRechazar
            '
            Me.btnRechazar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRechazar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnRechazar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnRechazar.Name = "btnRechazar"
            Me.btnRechazar.Size = New System.Drawing.Size(106, 28)
            Me.btnRechazar.Text = "RECHAZAR "
            '
            'GroupBox1
            '
            Me.GroupBox1.Location = New System.Drawing.Point(493, 336)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(109, 61)
            Me.GroupBox1.TabIndex = 187
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "DETALLES DE LA ÓRDEN"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(298, 3)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(115, 22)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(89, 3)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(115, 22)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRazon)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumeroCheque)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtValorComprobante)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtActividad)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCuenta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRucCi)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumeroComprobanteEgreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFechaComprobanteEgreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumeroFactura)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtPagadoA)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtConcepto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTipoPago)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(911, 170)
            Me.KryptonGroupBox1.TabIndex = 189
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(215, 3)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(18, 20)
            Me.KryptonLabel15.TabIndex = 48
            Me.KryptonLabel15.Values.Text = "A"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(742, 22)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel14.TabIndex = 47
            Me.KryptonLabel14.Values.Text = "Razon"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(525, 115)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel13.TabIndex = 38
            Me.KryptonLabel13.Values.Text = "Valor"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(525, 87)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(72, 20)
            Me.KryptonLabel12.TabIndex = 37
            Me.KryptonLabel12.Values.Text = "No Cheque"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(525, 59)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel11.TabIndex = 36
            Me.KryptonLabel11.Values.Text = "Cuenta"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(525, 29)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel10.TabIndex = 35
            Me.KryptonLabel10.Values.Text = "Banco"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(215, 112)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel9.TabIndex = 30
            Me.KryptonLabel9.Values.Text = "Pagado"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(215, 83)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(66, 20)
            Me.KryptonLabel8.TabIndex = 29
            Me.KryptonLabel8.Values.Text = "Tipo Pago"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(215, 57)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel7.TabIndex = 28
            Me.KryptonLabel7.Values.Text = "Concepto"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(215, 31)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel6.TabIndex = 27
            Me.KryptonLabel6.Values.Text = "Actividad"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(9, 112)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel5.TabIndex = 23
            Me.KryptonLabel5.Values.Text = "RUC/CI"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(9, 83)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(70, 20)
            Me.KryptonLabel4.TabIndex = 22
            Me.KryptonLabel4.Values.Text = "No Factura"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(11, 57)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel3.TabIndex = 21
            Me.KryptonLabel3.Values.Text = "Fecha"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(11, 5)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(26, 20)
            Me.KryptonLabel2.TabIndex = 3
            Me.KryptonLabel2.Values.Text = "De"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(9, 31)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(73, 20)
            Me.KryptonLabel1.TabIndex = 2
            Me.KryptonLabel1.Values.Text = "Numero CE"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(3, 211)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvComprobanteEgresoBancos)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(911, 287)
            Me.KryptonGroupBox2.TabIndex = 190
            Me.KryptonGroupBox2.Values.Heading = "Detalles de Orden"
            '
            'FormAprobacionComprobantesEgresoBancos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(919, 502)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAprobacionComprobantesEgresoBancos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "APROBACIÓN COMPROBANTES EGRESO"
            CType(Me.dgvComprobanteEgresoBancos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvComprobanteEgresoBancos As System.Windows.Forms.DataGridView
        Friend WithEvents txtRucCi As System.Windows.Forms.TextBox
        Friend WithEvents txtActividad As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroComprobanteEgreso As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroCheque As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaComprobanteEgreso As System.Windows.Forms.TextBox
        Friend WithEvents txtValorComprobante As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroFactura As System.Windows.Forms.TextBox
        Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
        Friend WithEvents txtBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtPagadoA As System.Windows.Forms.TextBox
        Friend WithEvents txtTipoPago As System.Windows.Forms.TextBox
        Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
        Friend WithEvents txtRazon As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnAprovar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnRechazar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
    End Class
End Namespace