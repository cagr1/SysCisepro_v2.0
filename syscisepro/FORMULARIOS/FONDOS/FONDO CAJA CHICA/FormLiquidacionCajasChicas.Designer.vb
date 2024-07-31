Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormLiquidacionCajasChicas
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLiquidacionCajasChicas))
            Me.tcLiquidar = New System.Windows.Forms.TabControl()
            Me.tpLiquidar = New System.Windows.Forms.TabPage()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtReposicionFondoCajaChica = New System.Windows.Forms.TextBox()
            Me.txtsaldoFondoCajaChica = New System.Windows.Forms.TextBox()
            Me.txtGastosFondoCajaChica = New System.Windows.Forms.TextBox()
            Me.txtFondoCajaChica = New System.Windows.Forms.TextBox()
            Me.lblCantidadReposicionFondoRotativo = New System.Windows.Forms.Label()
            Me.lblSaldoFondoRotativo = New System.Windows.Forms.Label()
            Me.lblCantidadGastosFondoRotativo = New System.Windows.Forms.Label()
            Me.lblCantidadFondoRotativo = New System.Windows.Forms.Label()
            Me.lblTotalLiquidacion = New System.Windows.Forms.Label()
            Me.txtTotalLiquidacion = New System.Windows.Forms.TextBox()
            Me.pCentroCostoControlCFR = New System.Windows.Forms.Panel()
            Me.dtpFechaLiquidacion = New System.Windows.Forms.DateTimePicker()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.cbmCentroCosto = New System.Windows.Forms.ComboBox()
            Me.lblCaja = New System.Windows.Forms.Label()
            Me.cbmCajasChicas = New System.Windows.Forms.ComboBox()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtIdLiquidacion = New System.Windows.Forms.TextBox()
            Me.lblFechaLiquidacion = New System.Windows.Forms.Label()
            Me.cbmParroquia = New System.Windows.Forms.ComboBox()
            Me.cbmCanton = New System.Windows.Forms.ComboBox()
            Me.cbmProvincia = New System.Windows.Forms.ComboBox()
            Me.lblParroquia = New System.Windows.Forms.Label()
            Me.lblProvincia = New System.Windows.Forms.Label()
            Me.lblCanton = New System.Windows.Forms.Label()
            Me.dgvLiquidacionFondoCajaChica = New System.Windows.Forms.DataGridView()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.bntCargar = New System.Windows.Forms.Button()
            Me.txtIdLiquidacionBusqueda = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.crvLiquidacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAnularSolicitud = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnLiquidacionFondoCCH = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarSolicitudCCH = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tcLiquidar.SuspendLayout()
            Me.tpLiquidar.SuspendLayout()
            Me.pCentroCostoControlCFR.SuspendLayout()
            CType(Me.dgvLiquidacionFondoCajaChica, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage2.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcLiquidar
            '
            Me.tcLiquidar.Controls.Add(Me.tpLiquidar)
            Me.tcLiquidar.Controls.Add(Me.TabPage2)
            Me.tcLiquidar.Location = New System.Drawing.Point(2, 33)
            Me.tcLiquidar.Name = "tcLiquidar"
            Me.tcLiquidar.SelectedIndex = 0
            Me.tcLiquidar.Size = New System.Drawing.Size(1011, 559)
            Me.tcLiquidar.TabIndex = 0
            '
            'tpLiquidar
            '
            Me.tpLiquidar.BackColor = System.Drawing.Color.White
            Me.tpLiquidar.Controls.Add(Me.Label5)
            Me.tpLiquidar.Controls.Add(Me.txtReposicionFondoCajaChica)
            Me.tpLiquidar.Controls.Add(Me.txtsaldoFondoCajaChica)
            Me.tpLiquidar.Controls.Add(Me.txtGastosFondoCajaChica)
            Me.tpLiquidar.Controls.Add(Me.txtFondoCajaChica)
            Me.tpLiquidar.Controls.Add(Me.lblCantidadReposicionFondoRotativo)
            Me.tpLiquidar.Controls.Add(Me.lblSaldoFondoRotativo)
            Me.tpLiquidar.Controls.Add(Me.lblCantidadGastosFondoRotativo)
            Me.tpLiquidar.Controls.Add(Me.lblCantidadFondoRotativo)
            Me.tpLiquidar.Controls.Add(Me.lblTotalLiquidacion)
            Me.tpLiquidar.Controls.Add(Me.txtTotalLiquidacion)
            Me.tpLiquidar.Controls.Add(Me.pCentroCostoControlCFR)
            Me.tpLiquidar.Controls.Add(Me.dgvLiquidacionFondoCajaChica)
            Me.tpLiquidar.Controls.Add(Me.Label4)
            Me.tpLiquidar.Controls.Add(Me.Label3)
            Me.tpLiquidar.Controls.Add(Me.Label2)
            Me.tpLiquidar.Controls.Add(Me.Label22)
            Me.tpLiquidar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tpLiquidar.Location = New System.Drawing.Point(4, 22)
            Me.tpLiquidar.Name = "tpLiquidar"
            Me.tpLiquidar.Padding = New System.Windows.Forms.Padding(3)
            Me.tpLiquidar.Size = New System.Drawing.Size(1003, 533)
            Me.tpLiquidar.TabIndex = 0
            Me.tpLiquidar.Text = "LIQUIDAR"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.Green
            Me.Label5.Location = New System.Drawing.Point(867, 505)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(13, 13)
            Me.Label5.TabIndex = 66
            Me.Label5.Text = "$"
            '
            'txtReposicionFondoCajaChica
            '
            Me.txtReposicionFondoCajaChica.BackColor = System.Drawing.Color.White
            Me.txtReposicionFondoCajaChica.Enabled = False
            Me.txtReposicionFondoCajaChica.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtReposicionFondoCajaChica.ForeColor = System.Drawing.Color.Black
            Me.txtReposicionFondoCajaChica.Location = New System.Drawing.Point(626, 503)
            Me.txtReposicionFondoCajaChica.Name = "txtReposicionFondoCajaChica"
            Me.txtReposicionFondoCajaChica.Size = New System.Drawing.Size(90, 23)
            Me.txtReposicionFondoCajaChica.TabIndex = 60
            Me.txtReposicionFondoCajaChica.Text = "0.00"
            Me.txtReposicionFondoCajaChica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtsaldoFondoCajaChica
            '
            Me.txtsaldoFondoCajaChica.AcceptsReturn = True
            Me.txtsaldoFondoCajaChica.BackColor = System.Drawing.Color.White
            Me.txtsaldoFondoCajaChica.Enabled = False
            Me.txtsaldoFondoCajaChica.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtsaldoFondoCajaChica.ForeColor = System.Drawing.Color.Black
            Me.txtsaldoFondoCajaChica.Location = New System.Drawing.Point(239, 502)
            Me.txtsaldoFondoCajaChica.Name = "txtsaldoFondoCajaChica"
            Me.txtsaldoFondoCajaChica.Size = New System.Drawing.Size(74, 23)
            Me.txtsaldoFondoCajaChica.TabIndex = 59
            Me.txtsaldoFondoCajaChica.Text = "0.00"
            Me.txtsaldoFondoCajaChica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtGastosFondoCajaChica
            '
            Me.txtGastosFondoCajaChica.BackColor = System.Drawing.Color.White
            Me.txtGastosFondoCajaChica.Enabled = False
            Me.txtGastosFondoCajaChica.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGastosFondoCajaChica.ForeColor = System.Drawing.Color.Black
            Me.txtGastosFondoCajaChica.Location = New System.Drawing.Point(415, 502)
            Me.txtGastosFondoCajaChica.Name = "txtGastosFondoCajaChica"
            Me.txtGastosFondoCajaChica.Size = New System.Drawing.Size(90, 23)
            Me.txtGastosFondoCajaChica.TabIndex = 58
            Me.txtGastosFondoCajaChica.Text = "0.00"
            Me.txtGastosFondoCajaChica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtFondoCajaChica
            '
            Me.txtFondoCajaChica.BackColor = System.Drawing.Color.White
            Me.txtFondoCajaChica.Enabled = False
            Me.txtFondoCajaChica.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFondoCajaChica.ForeColor = System.Drawing.Color.Black
            Me.txtFondoCajaChica.Location = New System.Drawing.Point(72, 503)
            Me.txtFondoCajaChica.Name = "txtFondoCajaChica"
            Me.txtFondoCajaChica.Size = New System.Drawing.Size(69, 23)
            Me.txtFondoCajaChica.TabIndex = 57
            Me.txtFondoCajaChica.Text = "0.00"
            Me.txtFondoCajaChica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblCantidadReposicionFondoRotativo
            '
            Me.lblCantidadReposicionFondoRotativo.AutoSize = True
            Me.lblCantidadReposicionFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidadReposicionFondoRotativo.Location = New System.Drawing.Point(536, 508)
            Me.lblCantidadReposicionFondoRotativo.Name = "lblCantidadReposicionFondoRotativo"
            Me.lblCantidadReposicionFondoRotativo.Size = New System.Drawing.Size(77, 13)
            Me.lblCantidadReposicionFondoRotativo.TabIndex = 56
            Me.lblCantidadReposicionFondoRotativo.Text = "REPOSICION :"
            '
            'lblSaldoFondoRotativo
            '
            Me.lblSaldoFondoRotativo.AutoSize = True
            Me.lblSaldoFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSaldoFondoRotativo.Location = New System.Drawing.Point(173, 506)
            Me.lblSaldoFondoRotativo.Name = "lblSaldoFondoRotativo"
            Me.lblSaldoFondoRotativo.Size = New System.Drawing.Size(48, 13)
            Me.lblSaldoFondoRotativo.TabIndex = 55
            Me.lblSaldoFondoRotativo.Text = "SALDO :"
            '
            'lblCantidadGastosFondoRotativo
            '
            Me.lblCantidadGastosFondoRotativo.AutoSize = True
            Me.lblCantidadGastosFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidadGastosFondoRotativo.Location = New System.Drawing.Point(346, 506)
            Me.lblCantidadGastosFondoRotativo.Name = "lblCantidadGastosFondoRotativo"
            Me.lblCantidadGastosFondoRotativo.Size = New System.Drawing.Size(54, 13)
            Me.lblCantidadGastosFondoRotativo.TabIndex = 54
            Me.lblCantidadGastosFondoRotativo.Text = "GASTOS :"
            '
            'lblCantidadFondoRotativo
            '
            Me.lblCantidadFondoRotativo.AutoSize = True
            Me.lblCantidadFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidadFondoRotativo.Location = New System.Drawing.Point(7, 506)
            Me.lblCantidadFondoRotativo.Name = "lblCantidadFondoRotativo"
            Me.lblCantidadFondoRotativo.Size = New System.Drawing.Size(53, 13)
            Me.lblCantidadFondoRotativo.TabIndex = 53
            Me.lblCantidadFondoRotativo.Text = "FONDO :"
            '
            'lblTotalLiquidacion
            '
            Me.lblTotalLiquidacion.AutoSize = True
            Me.lblTotalLiquidacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalLiquidacion.Location = New System.Drawing.Point(817, 506)
            Me.lblTotalLiquidacion.Name = "lblTotalLiquidacion"
            Me.lblTotalLiquidacion.Size = New System.Drawing.Size(44, 13)
            Me.lblTotalLiquidacion.TabIndex = 50
            Me.lblTotalLiquidacion.Text = "TOTAL :"
            '
            'txtTotalLiquidacion
            '
            Me.txtTotalLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtTotalLiquidacion.Enabled = False
            Me.txtTotalLiquidacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalLiquidacion.ForeColor = System.Drawing.Color.Black
            Me.txtTotalLiquidacion.Location = New System.Drawing.Point(884, 501)
            Me.txtTotalLiquidacion.Name = "txtTotalLiquidacion"
            Me.txtTotalLiquidacion.Size = New System.Drawing.Size(110, 23)
            Me.txtTotalLiquidacion.TabIndex = 49
            Me.txtTotalLiquidacion.Text = "0.00"
            Me.txtTotalLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'pCentroCostoControlCFR
            '
            Me.pCentroCostoControlCFR.Controls.Add(Me.dtpFechaLiquidacion)
            Me.pCentroCostoControlCFR.Controls.Add(Me.Label8)
            Me.pCentroCostoControlCFR.Controls.Add(Me.cbmCentroCosto)
            Me.pCentroCostoControlCFR.Controls.Add(Me.lblCaja)
            Me.pCentroCostoControlCFR.Controls.Add(Me.cbmCajasChicas)
            Me.pCentroCostoControlCFR.Controls.Add(Me.TextBox1)
            Me.pCentroCostoControlCFR.Controls.Add(Me.Label1)
            Me.pCentroCostoControlCFR.Controls.Add(Me.txtIdLiquidacion)
            Me.pCentroCostoControlCFR.Controls.Add(Me.lblFechaLiquidacion)
            Me.pCentroCostoControlCFR.Controls.Add(Me.cbmParroquia)
            Me.pCentroCostoControlCFR.Controls.Add(Me.cbmCanton)
            Me.pCentroCostoControlCFR.Controls.Add(Me.cbmProvincia)
            Me.pCentroCostoControlCFR.Controls.Add(Me.lblParroquia)
            Me.pCentroCostoControlCFR.Controls.Add(Me.lblProvincia)
            Me.pCentroCostoControlCFR.Controls.Add(Me.lblCanton)
            Me.pCentroCostoControlCFR.Location = New System.Drawing.Point(0, 0)
            Me.pCentroCostoControlCFR.Name = "pCentroCostoControlCFR"
            Me.pCentroCostoControlCFR.Size = New System.Drawing.Size(1003, 60)
            Me.pCentroCostoControlCFR.TabIndex = 45
            '
            'dtpFechaLiquidacion
            '
            Me.dtpFechaLiquidacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaLiquidacion.Location = New System.Drawing.Point(171, 6)
            Me.dtpFechaLiquidacion.Name = "dtpFechaLiquidacion"
            Me.dtpFechaLiquidacion.Size = New System.Drawing.Size(206, 22)
            Me.dtpFechaLiquidacion.TabIndex = 65
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(690, 4)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(67, 26)
            Me.Label8.TabIndex = 63
            Me.Label8.Text = "CENTRO DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COSTO:"
            '
            'cbmCentroCosto
            '
            Me.cbmCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCentroCosto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCentroCosto.FormattingEnabled = True
            Me.cbmCentroCosto.Location = New System.Drawing.Point(767, 5)
            Me.cbmCentroCosto.Name = "cbmCentroCosto"
            Me.cbmCentroCosto.Size = New System.Drawing.Size(198, 21)
            Me.cbmCentroCosto.TabIndex = 62
            '
            'lblCaja
            '
            Me.lblCaja.AutoSize = True
            Me.lblCaja.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCaja.Location = New System.Drawing.Point(405, 10)
            Me.lblCaja.Name = "lblCaja"
            Me.lblCaja.Size = New System.Drawing.Size(36, 13)
            Me.lblCaja.TabIndex = 60
            Me.lblCaja.Text = "CAJA:"
            '
            'cbmCajasChicas
            '
            Me.cbmCajasChicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCajasChicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCajasChicas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCajasChicas.FormattingEnabled = True
            Me.cbmCajasChicas.Location = New System.Drawing.Point(458, 6)
            Me.cbmCajasChicas.Name = "cbmCajasChicas"
            Me.cbmCajasChicas.Size = New System.Drawing.Size(202, 21)
            Me.cbmCajasChicas.TabIndex = 59
            '
            'TextBox1
            '
            Me.TextBox1.BackColor = System.Drawing.Color.White
            Me.TextBox1.Enabled = False
            Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.Location = New System.Drawing.Point(35, 6)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(43, 22)
            Me.TextBox1.TabIndex = 58
            Me.TextBox1.Text = "LCCH"
            Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(12, 10)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(22, 13)
            Me.Label1.TabIndex = 57
            Me.Label1.Text = "N°:"
            '
            'txtIdLiquidacion
            '
            Me.txtIdLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtIdLiquidacion.Enabled = False
            Me.txtIdLiquidacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdLiquidacion.Location = New System.Drawing.Point(10, 30)
            Me.txtIdLiquidacion.Name = "txtIdLiquidacion"
            Me.txtIdLiquidacion.Size = New System.Drawing.Size(68, 22)
            Me.txtIdLiquidacion.TabIndex = 56
            '
            'lblFechaLiquidacion
            '
            Me.lblFechaLiquidacion.AutoSize = True
            Me.lblFechaLiquidacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaLiquidacion.Location = New System.Drawing.Point(94, 6)
            Me.lblFechaLiquidacion.Name = "lblFechaLiquidacion"
            Me.lblFechaLiquidacion.Size = New System.Drawing.Size(79, 26)
            Me.lblFechaLiquidacion.TabIndex = 53
            Me.lblFechaLiquidacion.Text = "FEC. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LIQUIDACION:"
            '
            'cbmParroquia
            '
            Me.cbmParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParroquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmParroquia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmParroquia.FormattingEnabled = True
            Me.cbmParroquia.Location = New System.Drawing.Point(767, 32)
            Me.cbmParroquia.Name = "cbmParroquia"
            Me.cbmParroquia.Size = New System.Drawing.Size(198, 21)
            Me.cbmParroquia.TabIndex = 27
            '
            'cbmCanton
            '
            Me.cbmCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCanton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCanton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCanton.FormattingEnabled = True
            Me.cbmCanton.Location = New System.Drawing.Point(458, 33)
            Me.cbmCanton.Name = "cbmCanton"
            Me.cbmCanton.Size = New System.Drawing.Size(202, 21)
            Me.cbmCanton.TabIndex = 26
            '
            'cbmProvincia
            '
            Me.cbmProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmProvincia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmProvincia.FormattingEnabled = True
            Me.cbmProvincia.Location = New System.Drawing.Point(171, 33)
            Me.cbmProvincia.Name = "cbmProvincia"
            Me.cbmProvincia.Size = New System.Drawing.Size(206, 21)
            Me.cbmProvincia.TabIndex = 25
            '
            'lblParroquia
            '
            Me.lblParroquia.AutoSize = True
            Me.lblParroquia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblParroquia.Location = New System.Drawing.Point(690, 35)
            Me.lblParroquia.Name = "lblParroquia"
            Me.lblParroquia.Size = New System.Drawing.Size(71, 13)
            Me.lblParroquia.TabIndex = 5
            Me.lblParroquia.Text = "PARROQUIA:"
            '
            'lblProvincia
            '
            Me.lblProvincia.AutoSize = True
            Me.lblProvincia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProvincia.Location = New System.Drawing.Point(94, 35)
            Me.lblProvincia.Name = "lblProvincia"
            Me.lblProvincia.Size = New System.Drawing.Size(67, 13)
            Me.lblProvincia.TabIndex = 1
            Me.lblProvincia.Text = "PROVINCIA:"
            '
            'lblCanton
            '
            Me.lblCanton.AutoSize = True
            Me.lblCanton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCanton.Location = New System.Drawing.Point(404, 33)
            Me.lblCanton.Name = "lblCanton"
            Me.lblCanton.Size = New System.Drawing.Size(54, 13)
            Me.lblCanton.TabIndex = 3
            Me.lblCanton.Text = "CANTON:"
            '
            'dgvLiquidacionFondoCajaChica
            '
            Me.dgvLiquidacionFondoCajaChica.AllowUserToAddRows = False
            Me.dgvLiquidacionFondoCajaChica.AllowUserToDeleteRows = False
            Me.dgvLiquidacionFondoCajaChica.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvLiquidacionFondoCajaChica.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvLiquidacionFondoCajaChica.BackgroundColor = System.Drawing.Color.White
            Me.dgvLiquidacionFondoCajaChica.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvLiquidacionFondoCajaChica.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvLiquidacionFondoCajaChica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvLiquidacionFondoCajaChica.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvLiquidacionFondoCajaChica.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvLiquidacionFondoCajaChica.Location = New System.Drawing.Point(0, 61)
            Me.dgvLiquidacionFondoCajaChica.MultiSelect = False
            Me.dgvLiquidacionFondoCajaChica.Name = "dgvLiquidacionFondoCajaChica"
            Me.dgvLiquidacionFondoCajaChica.ReadOnly = True
            Me.dgvLiquidacionFondoCajaChica.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvLiquidacionFondoCajaChica.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvLiquidacionFondoCajaChica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLiquidacionFondoCajaChica.Size = New System.Drawing.Size(1003, 437)
            Me.dgvLiquidacionFondoCajaChica.TabIndex = 48
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.Green
            Me.Label4.Location = New System.Drawing.Point(614, 509)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(13, 13)
            Me.Label4.TabIndex = 65
            Me.Label4.Text = "$"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.Green
            Me.Label3.Location = New System.Drawing.Point(227, 506)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(13, 13)
            Me.Label3.TabIndex = 64
            Me.Label3.Text = "$"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.Green
            Me.Label2.Location = New System.Drawing.Point(403, 506)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(13, 13)
            Me.Label2.TabIndex = 63
            Me.Label2.Text = "$"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.ForeColor = System.Drawing.Color.Green
            Me.Label22.Location = New System.Drawing.Point(61, 507)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(13, 13)
            Me.Label22.TabIndex = 62
            Me.Label22.Text = "$"
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = System.Drawing.Color.White
            Me.TabPage2.Controls.Add(Me.bntCargar)
            Me.TabPage2.Controls.Add(Me.txtIdLiquidacionBusqueda)
            Me.TabPage2.Controls.Add(Me.Label6)
            Me.TabPage2.Controls.Add(Me.crvLiquidacion)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(1003, 575)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "REPORTE"
            '
            'bntCargar
            '
            Me.bntCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntCargar.Location = New System.Drawing.Point(919, 7)
            Me.bntCargar.Name = "bntCargar"
            Me.bntCargar.Size = New System.Drawing.Size(75, 23)
            Me.bntCargar.TabIndex = 3
            Me.bntCargar.Text = "CARGAR"
            Me.bntCargar.UseVisualStyleBackColor = True
            '
            'txtIdLiquidacionBusqueda
            '
            Me.txtIdLiquidacionBusqueda.Location = New System.Drawing.Point(824, 8)
            Me.txtIdLiquidacionBusqueda.Name = "txtIdLiquidacionBusqueda"
            Me.txtIdLiquidacionBusqueda.Size = New System.Drawing.Size(95, 22)
            Me.txtIdLiquidacionBusqueda.TabIndex = 2
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(731, 13)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(93, 13)
            Me.Label6.TabIndex = 1
            Me.Label6.Text = "ID LIQUIDACIÓN:"
            '
            'crvLiquidacion
            '
            Me.crvLiquidacion.ActiveViewIndex = -1
            Me.crvLiquidacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvLiquidacion.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvLiquidacion.Location = New System.Drawing.Point(3, 3)
            Me.crvLiquidacion.Name = "crvLiquidacion"
            Me.crvLiquidacion.Size = New System.Drawing.Size(997, 569)
            Me.crvLiquidacion.TabIndex = 0
            Me.crvLiquidacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargar, Me.btnAnularSolicitud, Me.btnLiquidacionFondoCCH, Me.btnGuardarSolicitudCCH, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1012, 32)
            Me.MenuStrip1.TabIndex = 187
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnCargar
            '
            Me.btnCargar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(87, 28)
            Me.btnCargar.Text = "BUSCAR"
            '
            'btnAnularSolicitud
            '
            Me.btnAnularSolicitud.Enabled = False
            Me.btnAnularSolicitud.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnularSolicitud.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnAnularSolicitud.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAnularSolicitud.Name = "btnAnularSolicitud"
            Me.btnAnularSolicitud.Size = New System.Drawing.Size(88, 28)
            Me.btnAnularSolicitud.Text = "ANULAR "
            '
            'btnLiquidacionFondoCCH
            '
            Me.btnLiquidacionFondoCCH.Enabled = False
            Me.btnLiquidacionFondoCCH.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLiquidacionFondoCCH.Image = Global.syscisepro.My.Resources.Resources.edit_note_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnLiquidacionFondoCCH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnLiquidacionFondoCCH.Name = "btnLiquidacionFondoCCH"
            Me.btnLiquidacionFondoCCH.Size = New System.Drawing.Size(92, 28)
            Me.btnLiquidacionFondoCCH.Text = "LIQUIDAR"
            '
            'btnGuardarSolicitudCCH
            '
            Me.btnGuardarSolicitudCCH.Enabled = False
            Me.btnGuardarSolicitudCCH.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarSolicitudCCH.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarSolicitudCCH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarSolicitudCCH.Name = "btnGuardarSolicitudCCH"
            Me.btnGuardarSolicitudCCH.Size = New System.Drawing.Size(95, 28)
            Me.btnGuardarSolicitudCCH.Text = "GUARDAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(97, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'FormLiquidacionCajasChicas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1012, 594)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tcLiquidar)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormLiquidacionCajasChicas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "LIQUIDACIÓN DE CAJA CHICA"
            Me.tcLiquidar.ResumeLayout(False)
            Me.tpLiquidar.ResumeLayout(False)
            Me.tpLiquidar.PerformLayout()
            Me.pCentroCostoControlCFR.ResumeLayout(False)
            Me.pCentroCostoControlCFR.PerformLayout()
            CType(Me.dgvLiquidacionFondoCajaChica, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tcLiquidar As System.Windows.Forms.TabControl
        Friend WithEvents tpLiquidar As System.Windows.Forms.TabPage
        Friend WithEvents txtReposicionFondoCajaChica As System.Windows.Forms.TextBox
        Friend WithEvents txtsaldoFondoCajaChica As System.Windows.Forms.TextBox
        Friend WithEvents txtGastosFondoCajaChica As System.Windows.Forms.TextBox
        Friend WithEvents txtFondoCajaChica As System.Windows.Forms.TextBox
        Friend WithEvents lblCantidadReposicionFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblSaldoFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblCantidadGastosFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblCantidadFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblTotalLiquidacion As System.Windows.Forms.Label
        Friend WithEvents txtTotalLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents pCentroCostoControlCFR As System.Windows.Forms.Panel
        Friend WithEvents txtIdLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaLiquidacion As System.Windows.Forms.Label
        Friend WithEvents cbmParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cbmCanton As System.Windows.Forms.ComboBox
        Friend WithEvents cbmProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents lblParroquia As System.Windows.Forms.Label
        Friend WithEvents lblProvincia As System.Windows.Forms.Label
        Friend WithEvents lblCanton As System.Windows.Forms.Label
        Friend WithEvents dgvLiquidacionFondoCajaChica As System.Windows.Forms.DataGridView
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents lblCaja As System.Windows.Forms.Label
        Friend WithEvents cbmCajasChicas As System.Windows.Forms.ComboBox
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents crvLiquidacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents bntCargar As System.Windows.Forms.Button
        Friend WithEvents txtIdLiquidacionBusqueda As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents cbmCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents dtpFechaLiquidacion As System.Windows.Forms.DateTimePicker
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnLiquidacionFondoCCH As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarSolicitudCCH As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAnularSolicitud As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace