Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBuscarReporteControlCombustibleGeneral
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarReporteControlCombustibleGeneral))
            Me.dgvControlCombustible = New System.Windows.Forms.DataGridView()
            Me.lblIdControlC = New System.Windows.Forms.Label()
            Me.lblFechaControlC = New System.Windows.Forms.Label()
            Me.lblValorControlC = New System.Windows.Forms.Label()
            Me.lblDestinoControlC = New System.Windows.Forms.Label()
            Me.lblMotivoControlC = New System.Windows.Forms.Label()
            Me.lblTotalKm = New System.Windows.Forms.Label()
            Me.lblIdVehiculo = New System.Windows.Forms.Label()
            Me.lblIdRubro = New System.Windows.Forms.Label()
            Me.lblIdSalidaVehiculo = New System.Windows.Forms.Label()
            Me.txtIdControlC = New System.Windows.Forms.TextBox()
            Me.txtFechaControlC = New System.Windows.Forms.TextBox()
            Me.txtValorControlC = New System.Windows.Forms.TextBox()
            Me.txtDestinoControlC = New System.Windows.Forms.TextBox()
            Me.txtMotivoControlC = New System.Windows.Forms.TextBox()
            Me.txtTotalKmsControlC = New System.Windows.Forms.TextBox()
            Me.txtVehiculo = New System.Windows.Forms.TextBox()
            Me.txtRubro = New System.Windows.Forms.TextBox()
            Me.txtFechaSalidaVehiculo = New System.Windows.Forms.TextBox()
            Me.lblNombreVehiculo = New System.Windows.Forms.Label()
            Me.txtKmSalidaVehiculo = New System.Windows.Forms.TextBox()
            Me.lblFechaSalidaVehiculo = New System.Windows.Forms.Label()
            Me.lblKmSalidaVehiculo = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.gbControl1 = New System.Windows.Forms.GroupBox()
            Me.gbControl2 = New System.Windows.Forms.GroupBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtKmLlegadaVehiculo = New System.Windows.Forms.TextBox()
            Me.txtFechaLlegadaVehiculo = New System.Windows.Forms.TextBox()
            Me.lblIdLlegadaVehiculo = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.dtpAsientoDesde = New System.Windows.Forms.DateTimePicker()
            Me.dtpAsientoHasta = New System.Windows.Forms.DateTimePicker()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvControlCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbControl1.SuspendLayout()
            Me.gbControl2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvControlCombustible
            '
            Me.dgvControlCombustible.AllowUserToAddRows = False
            Me.dgvControlCombustible.AllowUserToDeleteRows = False
            Me.dgvControlCombustible.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvControlCombustible.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvControlCombustible.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvControlCombustible.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvControlCombustible.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvControlCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvControlCombustible.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvControlCombustible.Location = New System.Drawing.Point(2, 227)
            Me.dgvControlCombustible.MultiSelect = False
            Me.dgvControlCombustible.Name = "dgvControlCombustible"
            Me.dgvControlCombustible.RowHeadersVisible = False
            Me.dgvControlCombustible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvControlCombustible.Size = New System.Drawing.Size(795, 306)
            Me.dgvControlCombustible.TabIndex = 0
            '
            'lblIdControlC
            '
            Me.lblIdControlC.AutoSize = True
            Me.lblIdControlC.Location = New System.Drawing.Point(5, 21)
            Me.lblIdControlC.Name = "lblIdControlC"
            Me.lblIdControlC.Size = New System.Drawing.Size(74, 13)
            Me.lblIdControlC.TabIndex = 19
            Me.lblIdControlC.Text = "ID CONTROL:"
            '
            'lblFechaControlC
            '
            Me.lblFechaControlC.AutoSize = True
            Me.lblFechaControlC.Location = New System.Drawing.Point(266, 21)
            Me.lblFechaControlC.Name = "lblFechaControlC"
            Me.lblFechaControlC.Size = New System.Drawing.Size(47, 13)
            Me.lblFechaControlC.TabIndex = 20
            Me.lblFechaControlC.Text = "FECHA: "
            '
            'lblValorControlC
            '
            Me.lblValorControlC.AutoSize = True
            Me.lblValorControlC.Location = New System.Drawing.Point(5, 49)
            Me.lblValorControlC.Name = "lblValorControlC"
            Me.lblValorControlC.Size = New System.Drawing.Size(45, 13)
            Me.lblValorControlC.TabIndex = 21
            Me.lblValorControlC.Text = "VALOR:"
            '
            'lblDestinoControlC
            '
            Me.lblDestinoControlC.AutoSize = True
            Me.lblDestinoControlC.BackColor = System.Drawing.Color.White
            Me.lblDestinoControlC.Location = New System.Drawing.Point(266, 49)
            Me.lblDestinoControlC.Name = "lblDestinoControlC"
            Me.lblDestinoControlC.Size = New System.Drawing.Size(56, 13)
            Me.lblDestinoControlC.TabIndex = 22
            Me.lblDestinoControlC.Text = "DESTINO:"
            '
            'lblMotivoControlC
            '
            Me.lblMotivoControlC.AutoSize = True
            Me.lblMotivoControlC.Location = New System.Drawing.Point(5, 77)
            Me.lblMotivoControlC.Name = "lblMotivoControlC"
            Me.lblMotivoControlC.Size = New System.Drawing.Size(53, 13)
            Me.lblMotivoControlC.TabIndex = 23
            Me.lblMotivoControlC.Text = "MOTIVO:"
            '
            'lblTotalKm
            '
            Me.lblTotalKm.AutoSize = True
            Me.lblTotalKm.Location = New System.Drawing.Point(5, 105)
            Me.lblTotalKm.Name = "lblTotalKm"
            Me.lblTotalKm.Size = New System.Drawing.Size(73, 13)
            Me.lblTotalKm.TabIndex = 24
            Me.lblTotalKm.Text = "TOTAL KM's:"
            '
            'lblIdVehiculo
            '
            Me.lblIdVehiculo.AutoSize = True
            Me.lblIdVehiculo.BackColor = System.Drawing.Color.White
            Me.lblIdVehiculo.Location = New System.Drawing.Point(640, 100)
            Me.lblIdVehiculo.Name = "lblIdVehiculo"
            Me.lblIdVehiculo.Size = New System.Drawing.Size(13, 13)
            Me.lblIdVehiculo.TabIndex = 25
            Me.lblIdVehiculo.Text = "0"
            Me.lblIdVehiculo.Visible = False
            '
            'lblIdRubro
            '
            Me.lblIdRubro.AutoSize = True
            Me.lblIdRubro.Location = New System.Drawing.Point(389, 97)
            Me.lblIdRubro.Name = "lblIdRubro"
            Me.lblIdRubro.Size = New System.Drawing.Size(13, 13)
            Me.lblIdRubro.TabIndex = 26
            Me.lblIdRubro.Text = "0"
            Me.lblIdRubro.Visible = False
            '
            'lblIdSalidaVehiculo
            '
            Me.lblIdSalidaVehiculo.AutoSize = True
            Me.lblIdSalidaVehiculo.Location = New System.Drawing.Point(653, 20)
            Me.lblIdSalidaVehiculo.Name = "lblIdSalidaVehiculo"
            Me.lblIdSalidaVehiculo.Size = New System.Drawing.Size(13, 13)
            Me.lblIdSalidaVehiculo.TabIndex = 27
            Me.lblIdSalidaVehiculo.Text = "0"
            Me.lblIdSalidaVehiculo.Visible = False
            '
            'txtIdControlC
            '
            Me.txtIdControlC.BackColor = System.Drawing.Color.White
            Me.txtIdControlC.Enabled = False
            Me.txtIdControlC.Location = New System.Drawing.Point(71, 7)
            Me.txtIdControlC.Name = "txtIdControlC"
            Me.txtIdControlC.Size = New System.Drawing.Size(81, 22)
            Me.txtIdControlC.TabIndex = 29
            '
            'txtFechaControlC
            '
            Me.txtFechaControlC.BackColor = System.Drawing.Color.White
            Me.txtFechaControlC.Enabled = False
            Me.txtFechaControlC.Location = New System.Drawing.Point(280, 9)
            Me.txtFechaControlC.Name = "txtFechaControlC"
            Me.txtFechaControlC.Size = New System.Drawing.Size(103, 22)
            Me.txtFechaControlC.TabIndex = 30
            '
            'txtValorControlC
            '
            Me.txtValorControlC.BackColor = System.Drawing.Color.White
            Me.txtValorControlC.Enabled = False
            Me.txtValorControlC.Location = New System.Drawing.Point(71, 35)
            Me.txtValorControlC.Name = "txtValorControlC"
            Me.txtValorControlC.Size = New System.Drawing.Size(81, 22)
            Me.txtValorControlC.TabIndex = 31
            '
            'txtDestinoControlC
            '
            Me.txtDestinoControlC.BackColor = System.Drawing.Color.White
            Me.txtDestinoControlC.Enabled = False
            Me.txtDestinoControlC.Location = New System.Drawing.Point(281, 37)
            Me.txtDestinoControlC.Name = "txtDestinoControlC"
            Me.txtDestinoControlC.Size = New System.Drawing.Size(103, 22)
            Me.txtDestinoControlC.TabIndex = 32
            '
            'txtMotivoControlC
            '
            Me.txtMotivoControlC.BackColor = System.Drawing.Color.White
            Me.txtMotivoControlC.Enabled = False
            Me.txtMotivoControlC.Location = New System.Drawing.Point(71, 63)
            Me.txtMotivoControlC.Name = "txtMotivoControlC"
            Me.txtMotivoControlC.Size = New System.Drawing.Size(312, 22)
            Me.txtMotivoControlC.TabIndex = 33
            '
            'txtTotalKmsControlC
            '
            Me.txtTotalKmsControlC.BackColor = System.Drawing.Color.White
            Me.txtTotalKmsControlC.Enabled = False
            Me.txtTotalKmsControlC.Location = New System.Drawing.Point(71, 91)
            Me.txtTotalKmsControlC.Name = "txtTotalKmsControlC"
            Me.txtTotalKmsControlC.Size = New System.Drawing.Size(81, 22)
            Me.txtTotalKmsControlC.TabIndex = 34
            '
            'txtVehiculo
            '
            Me.txtVehiculo.BackColor = System.Drawing.Color.White
            Me.txtVehiculo.Enabled = False
            Me.txtVehiculo.Location = New System.Drawing.Point(473, 92)
            Me.txtVehiculo.Name = "txtVehiculo"
            Me.txtVehiculo.Size = New System.Drawing.Size(147, 22)
            Me.txtVehiculo.TabIndex = 35
            '
            'txtRubro
            '
            Me.txtRubro.BackColor = System.Drawing.Color.White
            Me.txtRubro.Enabled = False
            Me.txtRubro.Location = New System.Drawing.Point(280, 92)
            Me.txtRubro.Name = "txtRubro"
            Me.txtRubro.Size = New System.Drawing.Size(103, 22)
            Me.txtRubro.TabIndex = 36
            '
            'txtFechaSalidaVehiculo
            '
            Me.txtFechaSalidaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtFechaSalidaVehiculo.Enabled = False
            Me.txtFechaSalidaVehiculo.Location = New System.Drawing.Point(656, 39)
            Me.txtFechaSalidaVehiculo.Name = "txtFechaSalidaVehiculo"
            Me.txtFechaSalidaVehiculo.Size = New System.Drawing.Size(100, 22)
            Me.txtFechaSalidaVehiculo.TabIndex = 37
            '
            'lblNombreVehiculo
            '
            Me.lblNombreVehiculo.AutoSize = True
            Me.lblNombreVehiculo.Location = New System.Drawing.Point(6, 133)
            Me.lblNombreVehiculo.Name = "lblNombreVehiculo"
            Me.lblNombreVehiculo.Size = New System.Drawing.Size(62, 13)
            Me.lblNombreVehiculo.TabIndex = 39
            Me.lblNombreVehiculo.Text = "VEHICULO:"
            '
            'txtKmSalidaVehiculo
            '
            Me.txtKmSalidaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtKmSalidaVehiculo.Enabled = False
            Me.txtKmSalidaVehiculo.Location = New System.Drawing.Point(656, 65)
            Me.txtKmSalidaVehiculo.Name = "txtKmSalidaVehiculo"
            Me.txtKmSalidaVehiculo.Size = New System.Drawing.Size(100, 22)
            Me.txtKmSalidaVehiculo.TabIndex = 40
            '
            'lblFechaSalidaVehiculo
            '
            Me.lblFechaSalidaVehiculo.AutoSize = True
            Me.lblFechaSalidaVehiculo.Location = New System.Drawing.Point(5, 18)
            Me.lblFechaSalidaVehiculo.Name = "lblFechaSalidaVehiculo"
            Me.lblFechaSalidaVehiculo.Size = New System.Drawing.Size(44, 13)
            Me.lblFechaSalidaVehiculo.TabIndex = 41
            Me.lblFechaSalidaVehiculo.Text = "FECHA:"
            '
            'lblKmSalidaVehiculo
            '
            Me.lblKmSalidaVehiculo.AutoSize = True
            Me.lblKmSalidaVehiculo.Location = New System.Drawing.Point(5, 44)
            Me.lblKmSalidaVehiculo.Name = "lblKmSalidaVehiculo"
            Me.lblKmSalidaVehiculo.Size = New System.Drawing.Size(83, 13)
            Me.lblKmSalidaVehiculo.TabIndex = 42
            Me.lblKmSalidaVehiculo.Text = "KILOMETRAJE:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(266, 105)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(46, 13)
            Me.Label1.TabIndex = 44
            Me.Label1.Text = "RUBRO:"
            '
            'gbControl1
            '
            Me.gbControl1.BackColor = System.Drawing.Color.White
            Me.gbControl1.Controls.Add(Me.lblIdControlC)
            Me.gbControl1.Controls.Add(Me.Label1)
            Me.gbControl1.Controls.Add(Me.lblFechaControlC)
            Me.gbControl1.Controls.Add(Me.lblValorControlC)
            Me.gbControl1.Controls.Add(Me.lblDestinoControlC)
            Me.gbControl1.Controls.Add(Me.lblMotivoControlC)
            Me.gbControl1.Controls.Add(Me.gbControl2)
            Me.gbControl1.Controls.Add(Me.GroupBox1)
            Me.gbControl1.Controls.Add(Me.lblTotalKm)
            Me.gbControl1.Controls.Add(Me.lblNombreVehiculo)
            Me.gbControl1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbControl1.Location = New System.Drawing.Point(332, 91)
            Me.gbControl1.Name = "gbControl1"
            Me.gbControl1.Size = New System.Drawing.Size(170, 42)
            Me.gbControl1.TabIndex = 45
            Me.gbControl1.TabStop = False
            Me.gbControl1.Text = "CONTROL"
            '
            'gbControl2
            '
            Me.gbControl2.BackColor = System.Drawing.Color.White
            Me.gbControl2.Controls.Add(Me.lblFechaSalidaVehiculo)
            Me.gbControl2.Controls.Add(Me.lblKmSalidaVehiculo)
            Me.gbControl2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbControl2.Location = New System.Drawing.Point(377, 8)
            Me.gbControl2.Name = "gbControl2"
            Me.gbControl2.Size = New System.Drawing.Size(195, 69)
            Me.gbControl2.TabIndex = 46
            Me.gbControl2.TabStop = False
            Me.gbControl2.Text = "SALIDA"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(451, 74)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(195, 69)
            Me.GroupBox1.TabIndex = 48
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "LLEGADA"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(4, 19)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(44, 13)
            Me.Label2.TabIndex = 49
            Me.Label2.Text = "FECHA:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(4, 45)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(83, 13)
            Me.Label3.TabIndex = 50
            Me.Label3.Text = "KILOMETRAJE:"
            '
            'txtKmLlegadaVehiculo
            '
            Me.txtKmLlegadaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtKmLlegadaVehiculo.Enabled = False
            Me.txtKmLlegadaVehiculo.Location = New System.Drawing.Point(473, 65)
            Me.txtKmLlegadaVehiculo.Name = "txtKmLlegadaVehiculo"
            Me.txtKmLlegadaVehiculo.Size = New System.Drawing.Size(100, 22)
            Me.txtKmLlegadaVehiculo.TabIndex = 48
            '
            'txtFechaLlegadaVehiculo
            '
            Me.txtFechaLlegadaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtFechaLlegadaVehiculo.Enabled = False
            Me.txtFechaLlegadaVehiculo.Location = New System.Drawing.Point(473, 35)
            Me.txtFechaLlegadaVehiculo.Name = "txtFechaLlegadaVehiculo"
            Me.txtFechaLlegadaVehiculo.Size = New System.Drawing.Size(100, 22)
            Me.txtFechaLlegadaVehiculo.TabIndex = 47
            '
            'lblIdLlegadaVehiculo
            '
            Me.lblIdLlegadaVehiculo.AutoSize = True
            Me.lblIdLlegadaVehiculo.Location = New System.Drawing.Point(473, 16)
            Me.lblIdLlegadaVehiculo.Name = "lblIdLlegadaVehiculo"
            Me.lblIdLlegadaVehiculo.Size = New System.Drawing.Size(13, 13)
            Me.lblIdLlegadaVehiculo.TabIndex = 46
            Me.lblIdLlegadaVehiculo.Text = "0"
            Me.lblIdLlegadaVehiculo.Visible = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(800, 32)
            Me.MenuStrip1.TabIndex = 190
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(86, 28)
            Me.ToolStripMenuItem1.Text = "CARGAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(90, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'dtpAsientoDesde
            '
            Me.dtpAsientoDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAsientoDesde.Location = New System.Drawing.Point(76, 45)
            Me.dtpAsientoDesde.Name = "dtpAsientoDesde"
            Me.dtpAsientoDesde.Size = New System.Drawing.Size(215, 21)
            Me.dtpAsientoDesde.TabIndex = 193
            '
            'dtpAsientoHasta
            '
            Me.dtpAsientoHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAsientoHasta.Location = New System.Drawing.Point(397, 45)
            Me.dtpAsientoHasta.Name = "dtpAsientoHasta"
            Me.dtpAsientoHasta.Size = New System.Drawing.Size(218, 21)
            Me.dtpAsientoHasta.TabIndex = 195
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 72)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdSalidaVehiculo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtKmSalidaVehiculo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFechaSalidaVehiculo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtKmLlegadaVehiculo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdLlegadaVehiculo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFechaLlegadaVehiculo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdVehiculo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdRubro)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdControlC)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRubro)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtValorControlC)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDestinoControlC)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtMotivoControlC)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFechaControlC)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTotalKmsControlC)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtVehiculo)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(793, 149)
            Me.KryptonGroupBox1.TabIndex = 196
            Me.KryptonGroupBox1.Values.Heading = "Control"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(7, 65)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel3.TabIndex = 2
            Me.KryptonLabel3.Values.Text = "Motivo"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(7, 39)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel2.TabIndex = 1
            Me.KryptonLabel2.Values.Text = "Valor"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(7, 11)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(22, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "ID"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(6, 90)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel4.TabIndex = 3
            Me.KryptonLabel4.Values.Text = "Total Km"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(414, 94)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(58, 20)
            Me.KryptonLabel5.TabIndex = 4
            Me.KryptonLabel5.Values.Text = "Vehiculo"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(218, 9)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel6.TabIndex = 36
            Me.KryptonLabel6.Values.Text = "Fecha"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(218, 37)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel7.TabIndex = 37
            Me.KryptonLabel7.Values.Text = "Destino"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(218, 94)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel8.TabIndex = 38
            Me.KryptonLabel8.Values.Text = "Rubro"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(414, 39)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel9.TabIndex = 39
            Me.KryptonLabel9.Values.Text = "Fecha"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(414, 65)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel10.TabIndex = 40
            Me.KryptonLabel10.Values.Text = "Kms"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(414, 11)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel11.TabIndex = 49
            Me.KryptonLabel11.Values.Text = "Llegada"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(595, 65)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel12.TabIndex = 51
            Me.KryptonLabel12.Values.Text = "Kms"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(595, 39)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel13.TabIndex = 50
            Me.KryptonLabel13.Values.Text = "Fecha"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(595, 13)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(43, 20)
            Me.KryptonLabel14.TabIndex = 52
            Me.KryptonLabel14.Values.Text = "Salida"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(12, 46)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel15.TabIndex = 53
            Me.KryptonLabel15.Values.Text = "Desde"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(332, 45)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel16.TabIndex = 197
            Me.KryptonLabel16.Values.Text = "Hasta"
            '
            'FormBuscarReporteControlCombustibleGeneral
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(800, 543)
            Me.Controls.Add(Me.KryptonLabel16)
            Me.Controls.Add(Me.KryptonLabel15)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.dtpAsientoHasta)
            Me.Controls.Add(Me.dtpAsientoDesde)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbControl1)
            Me.Controls.Add(Me.dgvControlCombustible)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormBuscarReporteControlCombustibleGeneral"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REPORTE CONTROL COMBUSTIBLE"
            CType(Me.dgvControlCombustible, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbControl1.ResumeLayout(False)
            Me.gbControl1.PerformLayout()
            Me.gbControl2.ResumeLayout(False)
            Me.gbControl2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvControlCombustible As System.Windows.Forms.DataGridView
        Friend WithEvents lblIdControlC As System.Windows.Forms.Label
        Friend WithEvents lblFechaControlC As System.Windows.Forms.Label
        Friend WithEvents lblValorControlC As System.Windows.Forms.Label
        Friend WithEvents lblDestinoControlC As System.Windows.Forms.Label
        Friend WithEvents lblMotivoControlC As System.Windows.Forms.Label
        Friend WithEvents lblTotalKm As System.Windows.Forms.Label
        Friend WithEvents lblIdVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblIdRubro As System.Windows.Forms.Label
        Friend WithEvents lblIdSalidaVehiculo As System.Windows.Forms.Label
        Friend WithEvents txtIdControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtValorControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtDestinoControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtMotivoControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalKmsControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents txtRubro As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaSalidaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreVehiculo As System.Windows.Forms.Label
        Friend WithEvents txtKmSalidaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaSalidaVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblKmSalidaVehiculo As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents gbControl1 As System.Windows.Forms.GroupBox
        Friend WithEvents gbControl2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtKmLlegadaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents lblIdLlegadaVehiculo As System.Windows.Forms.Label
        Friend WithEvents txtFechaLlegadaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents dtpAsientoDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpAsientoHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace