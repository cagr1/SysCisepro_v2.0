Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormLiquidacionFondoRotativo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLiquidacionFondoRotativo))
            Me.cmbParroquia = New System.Windows.Forms.ComboBox()
            Me.cmbCanton = New System.Windows.Forms.ComboBox()
            Me.cmbProvincia = New System.Windows.Forms.ComboBox()
            Me.dgvLiquidacionFondoRotativo = New System.Windows.Forms.DataGridView()
            Me.txtTotalLiquidacion = New System.Windows.Forms.TextBox()
            Me.lblTotalLiquidacion = New System.Windows.Forms.Label()
            Me.txtIdLiquidacion = New System.Windows.Forms.TextBox()
            Me.lblCantidadFondoRotativo = New System.Windows.Forms.Label()
            Me.lblCantidadGastosFondoRotativo = New System.Windows.Forms.Label()
            Me.lblSaldoFondoRotativo = New System.Windows.Forms.Label()
            Me.lblCantidadReposicionFondoRotativo = New System.Windows.Forms.Label()
            Me.txtCantidadFondoRotativo = New System.Windows.Forms.TextBox()
            Me.txtCantidadGastosFondoRotativo = New System.Windows.Forms.TextBox()
            Me.txtCantidadSaldoFondoRotativo = New System.Windows.Forms.TextBox()
            Me.txtCantidadReposicionFondoRotativo = New System.Windows.Forms.TextBox()
            Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dtpFechaLiquidacion = New System.Windows.Forms.DateTimePicker()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnLiquidacionFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarSolicitudFR = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarSolicitudFR = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAnularSolicitud = New System.Windows.Forms.ToolStripMenuItem()
            Me.crvLiquidacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.TabControl1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.txtIdLiquidacionBusqueda = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            CType(Me.dgvLiquidacionFondoRotativo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'cmbParroquia
            '
            Me.cmbParroquia.BackColor = System.Drawing.Color.White
            Me.cmbParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbParroquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbParroquia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbParroquia.FormattingEnabled = True
            Me.cmbParroquia.Location = New System.Drawing.Point(700, 31)
            Me.cmbParroquia.Name = "cmbParroquia"
            Me.cmbParroquia.Size = New System.Drawing.Size(175, 21)
            Me.cmbParroquia.TabIndex = 27
            '
            'cmbCanton
            '
            Me.cmbCanton.BackColor = System.Drawing.Color.White
            Me.cmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCanton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCanton.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCanton.FormattingEnabled = True
            Me.cmbCanton.Location = New System.Drawing.Point(455, 31)
            Me.cmbCanton.Name = "cmbCanton"
            Me.cmbCanton.Size = New System.Drawing.Size(156, 21)
            Me.cmbCanton.TabIndex = 26
            '
            'cmbProvincia
            '
            Me.cmbProvincia.BackColor = System.Drawing.Color.White
            Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbProvincia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbProvincia.FormattingEnabled = True
            Me.cmbProvincia.Location = New System.Drawing.Point(196, 33)
            Me.cmbProvincia.Name = "cmbProvincia"
            Me.cmbProvincia.Size = New System.Drawing.Size(167, 21)
            Me.cmbProvincia.TabIndex = 25
            '
            'dgvLiquidacionFondoRotativo
            '
            Me.dgvLiquidacionFondoRotativo.AllowUserToAddRows = False
            Me.dgvLiquidacionFondoRotativo.AllowUserToDeleteRows = False
            Me.dgvLiquidacionFondoRotativo.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvLiquidacionFondoRotativo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvLiquidacionFondoRotativo.BackgroundColor = System.Drawing.Color.White
            Me.dgvLiquidacionFondoRotativo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvLiquidacionFondoRotativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvLiquidacionFondoRotativo.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvLiquidacionFondoRotativo.Location = New System.Drawing.Point(2, 69)
            Me.dgvLiquidacionFondoRotativo.Name = "dgvLiquidacionFondoRotativo"
            Me.dgvLiquidacionFondoRotativo.ReadOnly = True
            Me.dgvLiquidacionFondoRotativo.RowHeadersVisible = False
            Me.dgvLiquidacionFondoRotativo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLiquidacionFondoRotativo.Size = New System.Drawing.Size(903, 404)
            Me.dgvLiquidacionFondoRotativo.TabIndex = 14
            '
            'txtTotalLiquidacion
            '
            Me.txtTotalLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtTotalLiquidacion.Enabled = False
            Me.txtTotalLiquidacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalLiquidacion.Location = New System.Drawing.Point(772, 13)
            Me.txtTotalLiquidacion.Name = "txtTotalLiquidacion"
            Me.txtTotalLiquidacion.ReadOnly = True
            Me.txtTotalLiquidacion.Size = New System.Drawing.Size(85, 23)
            Me.txtTotalLiquidacion.TabIndex = 15
            Me.txtTotalLiquidacion.Text = "0.00"
            Me.txtTotalLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotalLiquidacion
            '
            Me.lblTotalLiquidacion.AutoSize = True
            Me.lblTotalLiquidacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalLiquidacion.Location = New System.Drawing.Point(719, 19)
            Me.lblTotalLiquidacion.Name = "lblTotalLiquidacion"
            Me.lblTotalLiquidacion.Size = New System.Drawing.Size(46, 13)
            Me.lblTotalLiquidacion.TabIndex = 16
            Me.lblTotalLiquidacion.Text = "TOTAL :"
            '
            'txtIdLiquidacion
            '
            Me.txtIdLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtIdLiquidacion.Enabled = False
            Me.txtIdLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdLiquidacion.Location = New System.Drawing.Point(36, 4)
            Me.txtIdLiquidacion.Name = "txtIdLiquidacion"
            Me.txtIdLiquidacion.ReadOnly = True
            Me.txtIdLiquidacion.Size = New System.Drawing.Size(76, 21)
            Me.txtIdLiquidacion.TabIndex = 18
            '
            'lblCantidadFondoRotativo
            '
            Me.lblCantidadFondoRotativo.AutoSize = True
            Me.lblCantidadFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidadFondoRotativo.Location = New System.Drawing.Point(13, 18)
            Me.lblCantidadFondoRotativo.Name = "lblCantidadFondoRotativo"
            Me.lblCantidadFondoRotativo.Size = New System.Drawing.Size(50, 13)
            Me.lblCantidadFondoRotativo.TabIndex = 19
            Me.lblCantidadFondoRotativo.Text = "FONDO:"
            '
            'lblCantidadGastosFondoRotativo
            '
            Me.lblCantidadGastosFondoRotativo.AutoSize = True
            Me.lblCantidadGastosFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidadGastosFondoRotativo.Location = New System.Drawing.Point(186, 18)
            Me.lblCantidadGastosFondoRotativo.Name = "lblCantidadGastosFondoRotativo"
            Me.lblCantidadGastosFondoRotativo.Size = New System.Drawing.Size(51, 13)
            Me.lblCantidadGastosFondoRotativo.TabIndex = 20
            Me.lblCantidadGastosFondoRotativo.Text = "GASTOS:"
            '
            'lblSaldoFondoRotativo
            '
            Me.lblSaldoFondoRotativo.AutoSize = True
            Me.lblSaldoFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSaldoFondoRotativo.Location = New System.Drawing.Point(383, 19)
            Me.lblSaldoFondoRotativo.Name = "lblSaldoFondoRotativo"
            Me.lblSaldoFondoRotativo.Size = New System.Drawing.Size(45, 13)
            Me.lblSaldoFondoRotativo.TabIndex = 21
            Me.lblSaldoFondoRotativo.Text = "SALDO:"
            '
            'lblCantidadReposicionFondoRotativo
            '
            Me.lblCantidadReposicionFondoRotativo.AutoSize = True
            Me.lblCantidadReposicionFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidadReposicionFondoRotativo.Location = New System.Drawing.Point(545, 18)
            Me.lblCantidadReposicionFondoRotativo.Name = "lblCantidadReposicionFondoRotativo"
            Me.lblCantidadReposicionFondoRotativo.Size = New System.Drawing.Size(74, 13)
            Me.lblCantidadReposicionFondoRotativo.TabIndex = 22
            Me.lblCantidadReposicionFondoRotativo.Text = "REPOSICION:"
            '
            'txtCantidadFondoRotativo
            '
            Me.txtCantidadFondoRotativo.BackColor = System.Drawing.Color.White
            Me.txtCantidadFondoRotativo.Enabled = False
            Me.txtCantidadFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCantidadFondoRotativo.Location = New System.Drawing.Point(65, 14)
            Me.txtCantidadFondoRotativo.Name = "txtCantidadFondoRotativo"
            Me.txtCantidadFondoRotativo.ReadOnly = True
            Me.txtCantidadFondoRotativo.Size = New System.Drawing.Size(80, 22)
            Me.txtCantidadFondoRotativo.TabIndex = 23
            Me.txtCantidadFondoRotativo.Text = "0.00"
            Me.txtCantidadFondoRotativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtCantidadGastosFondoRotativo
            '
            Me.txtCantidadGastosFondoRotativo.BackColor = System.Drawing.Color.White
            Me.txtCantidadGastosFondoRotativo.Enabled = False
            Me.txtCantidadGastosFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCantidadGastosFondoRotativo.Location = New System.Drawing.Point(241, 14)
            Me.txtCantidadGastosFondoRotativo.Name = "txtCantidadGastosFondoRotativo"
            Me.txtCantidadGastosFondoRotativo.ReadOnly = True
            Me.txtCantidadGastosFondoRotativo.Size = New System.Drawing.Size(80, 22)
            Me.txtCantidadGastosFondoRotativo.TabIndex = 24
            Me.txtCantidadGastosFondoRotativo.Text = "0.00"
            Me.txtCantidadGastosFondoRotativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtCantidadSaldoFondoRotativo
            '
            Me.txtCantidadSaldoFondoRotativo.AcceptsReturn = True
            Me.txtCantidadSaldoFondoRotativo.BackColor = System.Drawing.Color.White
            Me.txtCantidadSaldoFondoRotativo.Enabled = False
            Me.txtCantidadSaldoFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCantidadSaldoFondoRotativo.Location = New System.Drawing.Point(431, 15)
            Me.txtCantidadSaldoFondoRotativo.Name = "txtCantidadSaldoFondoRotativo"
            Me.txtCantidadSaldoFondoRotativo.ReadOnly = True
            Me.txtCantidadSaldoFondoRotativo.Size = New System.Drawing.Size(80, 22)
            Me.txtCantidadSaldoFondoRotativo.TabIndex = 25
            Me.txtCantidadSaldoFondoRotativo.Text = "0.00"
            Me.txtCantidadSaldoFondoRotativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtCantidadReposicionFondoRotativo
            '
            Me.txtCantidadReposicionFondoRotativo.BackColor = System.Drawing.Color.White
            Me.txtCantidadReposicionFondoRotativo.Enabled = False
            Me.txtCantidadReposicionFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCantidadReposicionFondoRotativo.Location = New System.Drawing.Point(621, 14)
            Me.txtCantidadReposicionFondoRotativo.Name = "txtCantidadReposicionFondoRotativo"
            Me.txtCantidadReposicionFondoRotativo.ReadOnly = True
            Me.txtCantidadReposicionFondoRotativo.Size = New System.Drawing.Size(80, 22)
            Me.txtCantidadReposicionFondoRotativo.TabIndex = 26
            Me.txtCantidadReposicionFondoRotativo.Text = "0.00"
            Me.txtCantidadReposicionFondoRotativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'cmbCentroCosto
            '
            Me.cmbCentroCosto.BackColor = System.Drawing.Color.White
            Me.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCentroCosto.FormattingEnabled = True
            Me.cmbCentroCosto.Location = New System.Drawing.Point(457, 4)
            Me.cmbCentroCosto.Name = "cmbCentroCosto"
            Me.cmbCentroCosto.Size = New System.Drawing.Size(154, 21)
            Me.cmbCentroCosto.TabIndex = 28
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.GroupBox1.Controls.Add(Me.lblCantidadFondoRotativo)
            Me.GroupBox1.Controls.Add(Me.txtTotalLiquidacion)
            Me.GroupBox1.Controls.Add(Me.lblTotalLiquidacion)
            Me.GroupBox1.Controls.Add(Me.lblCantidadGastosFondoRotativo)
            Me.GroupBox1.Controls.Add(Me.txtCantidadReposicionFondoRotativo)
            Me.GroupBox1.Controls.Add(Me.lblSaldoFondoRotativo)
            Me.GroupBox1.Controls.Add(Me.txtCantidadSaldoFondoRotativo)
            Me.GroupBox1.Controls.Add(Me.lblCantidadReposicionFondoRotativo)
            Me.GroupBox1.Controls.Add(Me.txtCantidadGastosFondoRotativo)
            Me.GroupBox1.Controls.Add(Me.txtCantidadFondoRotativo)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(3, 476)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(899, 50)
            Me.GroupBox1.TabIndex = 30
            Me.GroupBox1.TabStop = False
            '
            'dtpFechaLiquidacion
            '
            Me.dtpFechaLiquidacion.CalendarFont = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaLiquidacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaLiquidacion.Location = New System.Drawing.Point(196, 3)
            Me.dtpFechaLiquidacion.Name = "dtpFechaLiquidacion"
            Me.dtpFechaLiquidacion.Size = New System.Drawing.Size(87, 22)
            Me.dtpFechaLiquidacion.TabIndex = 31
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargar, Me.btnLiquidacionFondoRotativo, Me.btnGuardarSolicitudFR, Me.btnCancelarSolicitudFR, Me.btnAnularSolicitud})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(907, 32)
            Me.MenuStrip1.TabIndex = 188
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
            'btnLiquidacionFondoRotativo
            '
            Me.btnLiquidacionFondoRotativo.Enabled = False
            Me.btnLiquidacionFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLiquidacionFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnLiquidacionFondoRotativo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnLiquidacionFondoRotativo.Name = "btnLiquidacionFondoRotativo"
            Me.btnLiquidacionFondoRotativo.Size = New System.Drawing.Size(92, 28)
            Me.btnLiquidacionFondoRotativo.Text = "LIQUIDAR"
            '
            'btnGuardarSolicitudFR
            '
            Me.btnGuardarSolicitudFR.Enabled = False
            Me.btnGuardarSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarSolicitudFR.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarSolicitudFR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarSolicitudFR.Name = "btnGuardarSolicitudFR"
            Me.btnGuardarSolicitudFR.Size = New System.Drawing.Size(95, 28)
            Me.btnGuardarSolicitudFR.Text = "GUARDAR"
            '
            'btnCancelarSolicitudFR
            '
            Me.btnCancelarSolicitudFR.Enabled = False
            Me.btnCancelarSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarSolicitudFR.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarSolicitudFR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelarSolicitudFR.Name = "btnCancelarSolicitudFR"
            Me.btnCancelarSolicitudFR.Size = New System.Drawing.Size(97, 28)
            Me.btnCancelarSolicitudFR.Text = "CANCELAR"
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
            'crvLiquidacion
            '
            Me.crvLiquidacion.ActiveViewIndex = -1
            Me.crvLiquidacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvLiquidacion.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvLiquidacion.Location = New System.Drawing.Point(0, 0)
            Me.crvLiquidacion.Name = "crvLiquidacion"
            Me.crvLiquidacion.ShowLogo = False
            Me.crvLiquidacion.Size = New System.Drawing.Size(905, 528)
            Me.crvLiquidacion.TabIndex = 1
            Me.crvLiquidacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbParroquia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCanton)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbProvincia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(905, 68)
            Me.KryptonGroupBox1.TabIndex = 190
            Me.KryptonGroupBox1.Values.Heading = ""
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(625, 32)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel7.TabIndex = 74
            Me.KryptonLabel7.Values.Text = "Parroquia"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(349, 5)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(82, 20)
            Me.KryptonLabel6.TabIndex = 73
            Me.KryptonLabel6.Values.Text = "Centro Costo"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(379, 32)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel5.TabIndex = 72
            Me.KryptonLabel5.Values.Text = "Canton"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(115, 33)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel3.TabIndex = 66
            Me.KryptonLabel3.Values.Text = "Provincia"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(115, 6)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel2.TabIndex = 57
            Me.KryptonLabel2.Values.Text = "Fecha"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(9, 5)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Id"
            '
            'TabControl1
            '
            Me.TabControl1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.TabControl1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 32)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(907, 555)
            Me.TabControl1.TabIndex = 191
            Me.TabControl1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.GroupBox1)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Controls.Add(Me.dgvLiquidacionFondoRotativo)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(905, 528)
            Me.KryptonPage1.Text = "Liquidacion"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "6F935103EEFC4EA74B92ACC754567A7E"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.btnReporte)
            Me.KryptonPage2.Controls.Add(Me.txtIdLiquidacionBusqueda)
            Me.KryptonPage2.Controls.Add(Me.Label6)
            Me.KryptonPage2.Controls.Add(Me.crvLiquidacion)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(905, 528)
            Me.KryptonPage2.Text = "Reporte"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "F082EB6A25914D2AC189495E4ECDFC26"
            '
            'btnReporte
            '
            Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReporte.Location = New System.Drawing.Point(790, 4)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(75, 23)
            Me.btnReporte.TabIndex = 10
            Me.btnReporte.Text = "CARGAR"
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'txtIdLiquidacionBusqueda
            '
            Me.txtIdLiquidacionBusqueda.Location = New System.Drawing.Point(685, 4)
            Me.txtIdLiquidacionBusqueda.Name = "txtIdLiquidacionBusqueda"
            Me.txtIdLiquidacionBusqueda.Size = New System.Drawing.Size(95, 22)
            Me.txtIdLiquidacionBusqueda.TabIndex = 9
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(586, 7)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(93, 13)
            Me.Label6.TabIndex = 8
            Me.Label6.Text = "ID LIQUIDACIÓN:"
            '
            'FormLiquidacionFondoRotativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(907, 587)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormLiquidacionFondoRotativo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "LIQUIDACION DE FONDO ROTATIVO"
            CType(Me.dgvLiquidacionFondoRotativo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            Me.KryptonPage2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvLiquidacionFondoRotativo As System.Windows.Forms.DataGridView
        Friend WithEvents txtTotalLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents lblTotalLiquidacion As System.Windows.Forms.Label
        Friend WithEvents txtIdLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents lblCantidadFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblCantidadGastosFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblSaldoFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblCantidadReposicionFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents txtCantidadFondoRotativo As System.Windows.Forms.TextBox
        Friend WithEvents txtCantidadGastosFondoRotativo As System.Windows.Forms.TextBox
        Friend WithEvents txtCantidadSaldoFondoRotativo As System.Windows.Forms.TextBox
        Friend WithEvents txtCantidadReposicionFondoRotativo As System.Windows.Forms.TextBox
        Friend WithEvents cmbParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCanton As System.Windows.Forms.ComboBox
        Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaLiquidacion As System.Windows.Forms.DateTimePicker
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnLiquidacionFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarSolicitudFR As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarSolicitudFR As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents crvLiquidacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents btnAnularSolicitud As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents TabControl1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents btnReporte As Button
        Friend WithEvents txtIdLiquidacionBusqueda As TextBox
        Friend WithEvents Label6 As Label
    End Class
End Namespace