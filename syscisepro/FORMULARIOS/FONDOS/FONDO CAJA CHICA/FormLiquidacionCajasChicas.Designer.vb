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
            Me.dtpFechaLiquidacion = New System.Windows.Forms.DateTimePicker()
            Me.txtIdLiquidacion = New System.Windows.Forms.TextBox()
            Me.cbmProvincia = New System.Windows.Forms.ComboBox()
            Me.crvLiquidacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAnularSolicitud = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnLiquidacionFondoCCH = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarSolicitudCCH = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tcLiquidar = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.lblTotalLiquidacion = New System.Windows.Forms.Label()
            Me.txtTotalLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtReposicionFondoCajaChica = New System.Windows.Forms.TextBox()
            Me.txtsaldoFondoCajaChica = New System.Windows.Forms.TextBox()
            Me.txtGastosFondoCajaChica = New System.Windows.Forms.TextBox()
            Me.txtFondoCajaChica = New System.Windows.Forms.TextBox()
            Me.lblCantidadReposicionFondoRotativo = New System.Windows.Forms.Label()
            Me.lblSaldoFondoRotativo = New System.Windows.Forms.Label()
            Me.lblCantidadGastosFondoRotativo = New System.Windows.Forms.Label()
            Me.lblCantidadFondoRotativo = New System.Windows.Forms.Label()
            Me.dgvLiquidacionFondoCajaChica = New System.Windows.Forms.DataGridView()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.cbmCentroCosto = New System.Windows.Forms.ComboBox()
            Me.cbmCajasChicas = New System.Windows.Forms.ComboBox()
            Me.cbmParroquia = New System.Windows.Forms.ComboBox()
            Me.cbmCanton = New System.Windows.Forms.ComboBox()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.bntCargar = New System.Windows.Forms.Button()
            Me.txtIdLiquidacionBusqueda = New System.Windows.Forms.TextBox()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.tcLiquidar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcLiquidar.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.dgvLiquidacionFondoCajaChica, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dtpFechaLiquidacion
            '
            Me.dtpFechaLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaLiquidacion.Location = New System.Drawing.Point(181, 4)
            Me.dtpFechaLiquidacion.Name = "dtpFechaLiquidacion"
            Me.dtpFechaLiquidacion.Size = New System.Drawing.Size(196, 21)
            Me.dtpFechaLiquidacion.TabIndex = 65
            '
            'txtIdLiquidacion
            '
            Me.txtIdLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtIdLiquidacion.Enabled = False
            Me.txtIdLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdLiquidacion.Location = New System.Drawing.Point(36, 4)
            Me.txtIdLiquidacion.Name = "txtIdLiquidacion"
            Me.txtIdLiquidacion.Size = New System.Drawing.Size(68, 21)
            Me.txtIdLiquidacion.TabIndex = 56
            '
            'cbmProvincia
            '
            Me.cbmProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmProvincia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmProvincia.FormattingEnabled = True
            Me.cbmProvincia.Location = New System.Drawing.Point(181, 32)
            Me.cbmProvincia.Name = "cbmProvincia"
            Me.cbmProvincia.Size = New System.Drawing.Size(196, 21)
            Me.cbmProvincia.TabIndex = 25
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
            Me.crvLiquidacion.Size = New System.Drawing.Size(943, 516)
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
            Me.MenuStrip1.Size = New System.Drawing.Size(945, 32)
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
            'tcLiquidar
            '
            Me.tcLiquidar.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.tcLiquidar.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.tcLiquidar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcLiquidar.Location = New System.Drawing.Point(0, 32)
            Me.tcLiquidar.Name = "tcLiquidar"
            Me.tcLiquidar.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup
            Me.tcLiquidar.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.tcLiquidar.SelectedIndex = 0
            Me.tcLiquidar.Size = New System.Drawing.Size(945, 543)
            Me.tcLiquidar.TabIndex = 188
            Me.tcLiquidar.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.lblTotalLiquidacion)
            Me.KryptonPage1.Controls.Add(Me.txtTotalLiquidacion)
            Me.KryptonPage1.Controls.Add(Me.txtReposicionFondoCajaChica)
            Me.KryptonPage1.Controls.Add(Me.txtsaldoFondoCajaChica)
            Me.KryptonPage1.Controls.Add(Me.txtGastosFondoCajaChica)
            Me.KryptonPage1.Controls.Add(Me.txtFondoCajaChica)
            Me.KryptonPage1.Controls.Add(Me.lblCantidadReposicionFondoRotativo)
            Me.KryptonPage1.Controls.Add(Me.lblSaldoFondoRotativo)
            Me.KryptonPage1.Controls.Add(Me.lblCantidadGastosFondoRotativo)
            Me.KryptonPage1.Controls.Add(Me.lblCantidadFondoRotativo)
            Me.KryptonPage1.Controls.Add(Me.dgvLiquidacionFondoCajaChica)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(943, 514)
            Me.KryptonPage1.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.KryptonPage1.Text = "Liquidar"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "E21640E7135F4D8355907E1D5D49FC8B"
            '
            'lblTotalLiquidacion
            '
            Me.lblTotalLiquidacion.AutoSize = True
            Me.lblTotalLiquidacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblTotalLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalLiquidacion.Location = New System.Drawing.Point(727, 490)
            Me.lblTotalLiquidacion.Name = "lblTotalLiquidacion"
            Me.lblTotalLiquidacion.Size = New System.Drawing.Size(48, 13)
            Me.lblTotalLiquidacion.TabIndex = 70
            Me.lblTotalLiquidacion.Text = "TOTAL :"
            '
            'txtTotalLiquidacion
            '
            Me.txtTotalLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtTotalLiquidacion.Enabled = False
            Me.txtTotalLiquidacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalLiquidacion.ForeColor = System.Drawing.Color.Black
            Me.txtTotalLiquidacion.Location = New System.Drawing.Point(794, 485)
            Me.txtTotalLiquidacion.Name = "txtTotalLiquidacion"
            Me.txtTotalLiquidacion.Size = New System.Drawing.Size(110, 23)
            Me.txtTotalLiquidacion.TabIndex = 69
            Me.txtTotalLiquidacion.Text = "0.00"
            Me.txtTotalLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtReposicionFondoCajaChica
            '
            Me.txtReposicionFondoCajaChica.BackColor = System.Drawing.Color.White
            Me.txtReposicionFondoCajaChica.Enabled = False
            Me.txtReposicionFondoCajaChica.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtReposicionFondoCajaChica.ForeColor = System.Drawing.Color.Black
            Me.txtReposicionFondoCajaChica.Location = New System.Drawing.Point(625, 485)
            Me.txtReposicionFondoCajaChica.Name = "txtReposicionFondoCajaChica"
            Me.txtReposicionFondoCajaChica.Size = New System.Drawing.Size(90, 23)
            Me.txtReposicionFondoCajaChica.TabIndex = 68
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
            Me.txtsaldoFondoCajaChica.Location = New System.Drawing.Point(238, 484)
            Me.txtsaldoFondoCajaChica.Name = "txtsaldoFondoCajaChica"
            Me.txtsaldoFondoCajaChica.Size = New System.Drawing.Size(74, 23)
            Me.txtsaldoFondoCajaChica.TabIndex = 67
            Me.txtsaldoFondoCajaChica.Text = "0.00"
            Me.txtsaldoFondoCajaChica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtGastosFondoCajaChica
            '
            Me.txtGastosFondoCajaChica.BackColor = System.Drawing.Color.White
            Me.txtGastosFondoCajaChica.Enabled = False
            Me.txtGastosFondoCajaChica.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGastosFondoCajaChica.ForeColor = System.Drawing.Color.Black
            Me.txtGastosFondoCajaChica.Location = New System.Drawing.Point(414, 484)
            Me.txtGastosFondoCajaChica.Name = "txtGastosFondoCajaChica"
            Me.txtGastosFondoCajaChica.Size = New System.Drawing.Size(90, 23)
            Me.txtGastosFondoCajaChica.TabIndex = 66
            Me.txtGastosFondoCajaChica.Text = "0.00"
            Me.txtGastosFondoCajaChica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtFondoCajaChica
            '
            Me.txtFondoCajaChica.BackColor = System.Drawing.Color.White
            Me.txtFondoCajaChica.Enabled = False
            Me.txtFondoCajaChica.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFondoCajaChica.ForeColor = System.Drawing.Color.Black
            Me.txtFondoCajaChica.Location = New System.Drawing.Point(71, 485)
            Me.txtFondoCajaChica.Name = "txtFondoCajaChica"
            Me.txtFondoCajaChica.Size = New System.Drawing.Size(69, 23)
            Me.txtFondoCajaChica.TabIndex = 65
            Me.txtFondoCajaChica.Text = "0.00"
            Me.txtFondoCajaChica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblCantidadReposicionFondoRotativo
            '
            Me.lblCantidadReposicionFondoRotativo.AutoSize = True
            Me.lblCantidadReposicionFondoRotativo.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblCantidadReposicionFondoRotativo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidadReposicionFondoRotativo.Location = New System.Drawing.Point(535, 490)
            Me.lblCantidadReposicionFondoRotativo.Name = "lblCantidadReposicionFondoRotativo"
            Me.lblCantidadReposicionFondoRotativo.Size = New System.Drawing.Size(77, 13)
            Me.lblCantidadReposicionFondoRotativo.TabIndex = 64
            Me.lblCantidadReposicionFondoRotativo.Text = "REPOSICION :"
            '
            'lblSaldoFondoRotativo
            '
            Me.lblSaldoFondoRotativo.AutoSize = True
            Me.lblSaldoFondoRotativo.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblSaldoFondoRotativo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSaldoFondoRotativo.Location = New System.Drawing.Point(172, 488)
            Me.lblSaldoFondoRotativo.Name = "lblSaldoFondoRotativo"
            Me.lblSaldoFondoRotativo.Size = New System.Drawing.Size(48, 13)
            Me.lblSaldoFondoRotativo.TabIndex = 63
            Me.lblSaldoFondoRotativo.Text = "SALDO :"
            '
            'lblCantidadGastosFondoRotativo
            '
            Me.lblCantidadGastosFondoRotativo.AutoSize = True
            Me.lblCantidadGastosFondoRotativo.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblCantidadGastosFondoRotativo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidadGastosFondoRotativo.Location = New System.Drawing.Point(345, 488)
            Me.lblCantidadGastosFondoRotativo.Name = "lblCantidadGastosFondoRotativo"
            Me.lblCantidadGastosFondoRotativo.Size = New System.Drawing.Size(57, 13)
            Me.lblCantidadGastosFondoRotativo.TabIndex = 62
            Me.lblCantidadGastosFondoRotativo.Text = "GASTOS :"
            '
            'lblCantidadFondoRotativo
            '
            Me.lblCantidadFondoRotativo.AutoSize = True
            Me.lblCantidadFondoRotativo.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblCantidadFondoRotativo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidadFondoRotativo.Location = New System.Drawing.Point(6, 488)
            Me.lblCantidadFondoRotativo.Name = "lblCantidadFondoRotativo"
            Me.lblCantidadFondoRotativo.Size = New System.Drawing.Size(50, 13)
            Me.lblCantidadFondoRotativo.TabIndex = 61
            Me.lblCantidadFondoRotativo.Text = "FONDO :"
            '
            'dgvLiquidacionFondoCajaChica
            '
            Me.dgvLiquidacionFondoCajaChica.AllowUserToAddRows = False
            Me.dgvLiquidacionFondoCajaChica.AllowUserToDeleteRows = False
            Me.dgvLiquidacionFondoCajaChica.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvLiquidacionFondoCajaChica.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvLiquidacionFondoCajaChica.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvLiquidacionFondoCajaChica.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvLiquidacionFondoCajaChica.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvLiquidacionFondoCajaChica.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvLiquidacionFondoCajaChica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvLiquidacionFondoCajaChica.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvLiquidacionFondoCajaChica.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvLiquidacionFondoCajaChica.Location = New System.Drawing.Point(0, 74)
            Me.dgvLiquidacionFondoCajaChica.MultiSelect = False
            Me.dgvLiquidacionFondoCajaChica.Name = "dgvLiquidacionFondoCajaChica"
            Me.dgvLiquidacionFondoCajaChica.ReadOnly = True
            Me.dgvLiquidacionFondoCajaChica.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvLiquidacionFondoCajaChica.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvLiquidacionFondoCajaChica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLiquidacionFondoCajaChica.Size = New System.Drawing.Size(941, 404)
            Me.dgvLiquidacionFondoCajaChica.TabIndex = 49
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCajasChicas)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmParroquia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCanton)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmProvincia)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(945, 68)
            Me.KryptonGroupBox1.TabIndex = 0
            Me.KryptonGroupBox1.Values.Heading = ""
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(637, 32)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel7.TabIndex = 74
            Me.KryptonLabel7.Values.Text = "Parroquia"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(637, 6)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(82, 20)
            Me.KryptonLabel6.TabIndex = 73
            Me.KryptonLabel6.Values.Text = "Centro Costo"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(399, 32)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel5.TabIndex = 72
            Me.KryptonLabel5.Values.Text = "Canton"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(399, 6)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel4.TabIndex = 71
            Me.KryptonLabel4.Values.Text = "Caja"
            '
            'cbmCentroCosto
            '
            Me.cbmCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCentroCosto.FormattingEnabled = True
            Me.cbmCentroCosto.Location = New System.Drawing.Point(728, 4)
            Me.cbmCentroCosto.Name = "cbmCentroCosto"
            Me.cbmCentroCosto.Size = New System.Drawing.Size(153, 21)
            Me.cbmCentroCosto.TabIndex = 70
            '
            'cbmCajasChicas
            '
            Me.cbmCajasChicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCajasChicas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCajasChicas.FormattingEnabled = True
            Me.cbmCajasChicas.Location = New System.Drawing.Point(469, 4)
            Me.cbmCajasChicas.Name = "cbmCajasChicas"
            Me.cbmCajasChicas.Size = New System.Drawing.Size(157, 21)
            Me.cbmCajasChicas.TabIndex = 69
            '
            'cbmParroquia
            '
            Me.cbmParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParroquia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmParroquia.FormattingEnabled = True
            Me.cbmParroquia.Location = New System.Drawing.Point(728, 35)
            Me.cbmParroquia.Name = "cbmParroquia"
            Me.cbmParroquia.Size = New System.Drawing.Size(153, 21)
            Me.cbmParroquia.TabIndex = 68
            '
            'cbmCanton
            '
            Me.cbmCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCanton.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCanton.FormattingEnabled = True
            Me.cbmCanton.Location = New System.Drawing.Point(469, 35)
            Me.cbmCanton.Name = "cbmCanton"
            Me.cbmCanton.Size = New System.Drawing.Size(157, 21)
            Me.cbmCanton.TabIndex = 67
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
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.bntCargar)
            Me.KryptonPage2.Controls.Add(Me.txtIdLiquidacionBusqueda)
            Me.KryptonPage2.Controls.Add(Me.crvLiquidacion)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(943, 516)
            Me.KryptonPage2.Text = "Reporte"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "E5A1FE75D5854D54B5A766B8E1C49DF2"
            '
            'bntCargar
            '
            Me.bntCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntCargar.Location = New System.Drawing.Point(818, 3)
            Me.bntCargar.Name = "bntCargar"
            Me.bntCargar.Size = New System.Drawing.Size(75, 23)
            Me.bntCargar.TabIndex = 192
            Me.bntCargar.Text = "CARGAR"
            Me.bntCargar.UseVisualStyleBackColor = True
            '
            'txtIdLiquidacionBusqueda
            '
            Me.txtIdLiquidacionBusqueda.Location = New System.Drawing.Point(717, 3)
            Me.txtIdLiquidacionBusqueda.Name = "txtIdLiquidacionBusqueda"
            Me.txtIdLiquidacionBusqueda.Size = New System.Drawing.Size(95, 22)
            Me.txtIdLiquidacionBusqueda.TabIndex = 191
            '
            'FormLiquidacionCajasChicas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(945, 575)
            Me.Controls.Add(Me.tcLiquidar)
            Me.Controls.Add(Me.MenuStrip1)
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
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.tcLiquidar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcLiquidar.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            Me.KryptonPage1.PerformLayout()
            CType(Me.dgvLiquidacionFondoCajaChica, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            Me.KryptonPage2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtIdLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents cbmProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents crvLiquidacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents dtpFechaLiquidacion As System.Windows.Forms.DateTimePicker
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnLiquidacionFondoCCH As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarSolicitudCCH As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAnularSolicitud As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tcLiquidar As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents cbmCentroCosto As ComboBox
        Friend WithEvents cbmCajasChicas As ComboBox
        Friend WithEvents cbmParroquia As ComboBox
        Friend WithEvents cbmCanton As ComboBox
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblTotalLiquidacion As Label
        Friend WithEvents txtTotalLiquidacion As TextBox
        Friend WithEvents txtReposicionFondoCajaChica As TextBox
        Friend WithEvents txtsaldoFondoCajaChica As TextBox
        Friend WithEvents txtGastosFondoCajaChica As TextBox
        Friend WithEvents txtFondoCajaChica As TextBox
        Friend WithEvents lblCantidadReposicionFondoRotativo As Label
        Friend WithEvents lblSaldoFondoRotativo As Label
        Friend WithEvents lblCantidadGastosFondoRotativo As Label
        Friend WithEvents lblCantidadFondoRotativo As Label
        Friend WithEvents dgvLiquidacionFondoCajaChica As DataGridView
        Friend WithEvents bntCargar As Button
        Friend WithEvents txtIdLiquidacionBusqueda As TextBox
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    End Class
End Namespace