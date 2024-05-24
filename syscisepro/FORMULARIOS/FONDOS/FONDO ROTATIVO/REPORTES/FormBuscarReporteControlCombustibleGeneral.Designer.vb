Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBuscarReporteControlCombustibleGeneral
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
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.dtpAsientoDesde = New System.Windows.Forms.DateTimePicker()
            Me.lblFechaSolicitudFR = New System.Windows.Forms.Label()
            Me.dtpAsientoHasta = New System.Windows.Forms.DateTimePicker()
            Me.Label4 = New System.Windows.Forms.Label()
            CType(Me.dgvControlCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbControl1.SuspendLayout()
            Me.gbControl2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvControlCombustible
            '
            Me.dgvControlCombustible.AllowUserToAddRows = False
            Me.dgvControlCombustible.AllowUserToDeleteRows = False
            Me.dgvControlCombustible.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvControlCombustible.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvControlCombustible.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvControlCombustible.Size = New System.Drawing.Size(860, 315)
            Me.dgvControlCombustible.TabIndex = 0
            '
            'lblIdControlC
            '
            Me.lblIdControlC.AutoSize = True
            Me.lblIdControlC.Location = New System.Drawing.Point(5, 21)
            Me.lblIdControlC.Name = "lblIdControlC"
            Me.lblIdControlC.Size = New System.Drawing.Size(75, 13)
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
            Me.lblValorControlC.Size = New System.Drawing.Size(44, 13)
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
            Me.lblMotivoControlC.Size = New System.Drawing.Size(54, 13)
            Me.lblMotivoControlC.TabIndex = 23
            Me.lblMotivoControlC.Text = "MOTIVO:"
            '
            'lblTotalKm
            '
            Me.lblTotalKm.AutoSize = True
            Me.lblTotalKm.Location = New System.Drawing.Point(5, 105)
            Me.lblTotalKm.Name = "lblTotalKm"
            Me.lblTotalKm.Size = New System.Drawing.Size(68, 13)
            Me.lblTotalKm.TabIndex = 24
            Me.lblTotalKm.Text = "TOTAL KM's:"
            '
            'lblIdVehiculo
            '
            Me.lblIdVehiculo.AutoSize = True
            Me.lblIdVehiculo.BackColor = System.Drawing.Color.White
            Me.lblIdVehiculo.Location = New System.Drawing.Point(363, 134)
            Me.lblIdVehiculo.Name = "lblIdVehiculo"
            Me.lblIdVehiculo.Size = New System.Drawing.Size(13, 13)
            Me.lblIdVehiculo.TabIndex = 25
            Me.lblIdVehiculo.Text = "0"
            '
            'lblIdRubro
            '
            Me.lblIdRubro.AutoSize = True
            Me.lblIdRubro.Location = New System.Drawing.Point(432, 106)
            Me.lblIdRubro.Name = "lblIdRubro"
            Me.lblIdRubro.Size = New System.Drawing.Size(13, 13)
            Me.lblIdRubro.TabIndex = 26
            Me.lblIdRubro.Text = "0"
            '
            'lblIdSalidaVehiculo
            '
            Me.lblIdSalidaVehiculo.AutoSize = True
            Me.lblIdSalidaVehiculo.Location = New System.Drawing.Point(181, 18)
            Me.lblIdSalidaVehiculo.Name = "lblIdSalidaVehiculo"
            Me.lblIdSalidaVehiculo.Size = New System.Drawing.Size(13, 13)
            Me.lblIdSalidaVehiculo.TabIndex = 27
            Me.lblIdSalidaVehiculo.Text = "0"
            '
            'txtIdControlC
            '
            Me.txtIdControlC.BackColor = System.Drawing.Color.White
            Me.txtIdControlC.Enabled = False
            Me.txtIdControlC.Location = New System.Drawing.Point(90, 18)
            Me.txtIdControlC.Name = "txtIdControlC"
            Me.txtIdControlC.Size = New System.Drawing.Size(100, 22)
            Me.txtIdControlC.TabIndex = 29
            '
            'txtFechaControlC
            '
            Me.txtFechaControlC.BackColor = System.Drawing.Color.White
            Me.txtFechaControlC.Enabled = False
            Me.txtFechaControlC.Location = New System.Drawing.Point(348, 18)
            Me.txtFechaControlC.Name = "txtFechaControlC"
            Me.txtFechaControlC.Size = New System.Drawing.Size(103, 22)
            Me.txtFechaControlC.TabIndex = 30
            '
            'txtValorControlC
            '
            Me.txtValorControlC.BackColor = System.Drawing.Color.White
            Me.txtValorControlC.Enabled = False
            Me.txtValorControlC.Location = New System.Drawing.Point(90, 46)
            Me.txtValorControlC.Name = "txtValorControlC"
            Me.txtValorControlC.Size = New System.Drawing.Size(100, 22)
            Me.txtValorControlC.TabIndex = 31
            '
            'txtDestinoControlC
            '
            Me.txtDestinoControlC.BackColor = System.Drawing.Color.White
            Me.txtDestinoControlC.Enabled = False
            Me.txtDestinoControlC.Location = New System.Drawing.Point(348, 46)
            Me.txtDestinoControlC.Name = "txtDestinoControlC"
            Me.txtDestinoControlC.Size = New System.Drawing.Size(103, 22)
            Me.txtDestinoControlC.TabIndex = 32
            '
            'txtMotivoControlC
            '
            Me.txtMotivoControlC.BackColor = System.Drawing.Color.White
            Me.txtMotivoControlC.Enabled = False
            Me.txtMotivoControlC.Location = New System.Drawing.Point(90, 74)
            Me.txtMotivoControlC.Name = "txtMotivoControlC"
            Me.txtMotivoControlC.Size = New System.Drawing.Size(361, 22)
            Me.txtMotivoControlC.TabIndex = 33
            '
            'txtTotalKmsControlC
            '
            Me.txtTotalKmsControlC.BackColor = System.Drawing.Color.White
            Me.txtTotalKmsControlC.Enabled = False
            Me.txtTotalKmsControlC.Location = New System.Drawing.Point(90, 102)
            Me.txtTotalKmsControlC.Name = "txtTotalKmsControlC"
            Me.txtTotalKmsControlC.Size = New System.Drawing.Size(100, 22)
            Me.txtTotalKmsControlC.TabIndex = 34
            '
            'txtVehiculo
            '
            Me.txtVehiculo.BackColor = System.Drawing.Color.White
            Me.txtVehiculo.Enabled = False
            Me.txtVehiculo.Location = New System.Drawing.Point(88, 130)
            Me.txtVehiculo.Name = "txtVehiculo"
            Me.txtVehiculo.Size = New System.Drawing.Size(363, 22)
            Me.txtVehiculo.TabIndex = 35
            '
            'txtRubro
            '
            Me.txtRubro.BackColor = System.Drawing.Color.White
            Me.txtRubro.Enabled = False
            Me.txtRubro.Location = New System.Drawing.Point(348, 102)
            Me.txtRubro.Name = "txtRubro"
            Me.txtRubro.Size = New System.Drawing.Size(103, 22)
            Me.txtRubro.TabIndex = 36
            '
            'txtFechaSalidaVehiculo
            '
            Me.txtFechaSalidaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtFechaSalidaVehiculo.Enabled = False
            Me.txtFechaSalidaVehiculo.Location = New System.Drawing.Point(90, 15)
            Me.txtFechaSalidaVehiculo.Name = "txtFechaSalidaVehiculo"
            Me.txtFechaSalidaVehiculo.Size = New System.Drawing.Size(100, 22)
            Me.txtFechaSalidaVehiculo.TabIndex = 37
            '
            'lblNombreVehiculo
            '
            Me.lblNombreVehiculo.AutoSize = True
            Me.lblNombreVehiculo.Location = New System.Drawing.Point(6, 133)
            Me.lblNombreVehiculo.Name = "lblNombreVehiculo"
            Me.lblNombreVehiculo.Size = New System.Drawing.Size(63, 13)
            Me.lblNombreVehiculo.TabIndex = 39
            Me.lblNombreVehiculo.Text = "VEHICULO:"
            '
            'txtKmSalidaVehiculo
            '
            Me.txtKmSalidaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtKmSalidaVehiculo.Enabled = False
            Me.txtKmSalidaVehiculo.Location = New System.Drawing.Point(90, 41)
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
            Me.lblKmSalidaVehiculo.Size = New System.Drawing.Size(80, 13)
            Me.lblKmSalidaVehiculo.TabIndex = 42
            Me.lblKmSalidaVehiculo.Text = "KILOMETRAJE:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(266, 105)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(47, 13)
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
            Me.gbControl1.Controls.Add(Me.lblTotalKm)
            Me.gbControl1.Controls.Add(Me.lblNombreVehiculo)
            Me.gbControl1.Controls.Add(Me.txtIdControlC)
            Me.gbControl1.Controls.Add(Me.txtRubro)
            Me.gbControl1.Controls.Add(Me.txtFechaControlC)
            Me.gbControl1.Controls.Add(Me.txtVehiculo)
            Me.gbControl1.Controls.Add(Me.txtValorControlC)
            Me.gbControl1.Controls.Add(Me.txtTotalKmsControlC)
            Me.gbControl1.Controls.Add(Me.txtDestinoControlC)
            Me.gbControl1.Controls.Add(Me.txtMotivoControlC)
            Me.gbControl1.Controls.Add(Me.lblIdVehiculo)
            Me.gbControl1.Controls.Add(Me.lblIdRubro)
            Me.gbControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbControl1.Location = New System.Drawing.Point(2, 29)
            Me.gbControl1.Name = "gbControl1"
            Me.gbControl1.Size = New System.Drawing.Size(467, 161)
            Me.gbControl1.TabIndex = 45
            Me.gbControl1.TabStop = False
            Me.gbControl1.Text = "CONTROL"
            '
            'gbControl2
            '
            Me.gbControl2.BackColor = System.Drawing.Color.White
            Me.gbControl2.Controls.Add(Me.lblFechaSalidaVehiculo)
            Me.gbControl2.Controls.Add(Me.lblKmSalidaVehiculo)
            Me.gbControl2.Controls.Add(Me.txtFechaSalidaVehiculo)
            Me.gbControl2.Controls.Add(Me.txtKmSalidaVehiculo)
            Me.gbControl2.Controls.Add(Me.lblIdSalidaVehiculo)
            Me.gbControl2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbControl2.Location = New System.Drawing.Point(470, 121)
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
            Me.GroupBox1.Controls.Add(Me.txtKmLlegadaVehiculo)
            Me.GroupBox1.Controls.Add(Me.txtFechaLlegadaVehiculo)
            Me.GroupBox1.Controls.Add(Me.lblIdLlegadaVehiculo)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(668, 121)
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
            Me.Label3.Size = New System.Drawing.Size(80, 13)
            Me.Label3.TabIndex = 50
            Me.Label3.Text = "KILOMETRAJE:"
            '
            'txtKmLlegadaVehiculo
            '
            Me.txtKmLlegadaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtKmLlegadaVehiculo.Enabled = False
            Me.txtKmLlegadaVehiculo.Location = New System.Drawing.Point(88, 41)
            Me.txtKmLlegadaVehiculo.Name = "txtKmLlegadaVehiculo"
            Me.txtKmLlegadaVehiculo.Size = New System.Drawing.Size(100, 22)
            Me.txtKmLlegadaVehiculo.TabIndex = 48
            '
            'txtFechaLlegadaVehiculo
            '
            Me.txtFechaLlegadaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtFechaLlegadaVehiculo.Enabled = False
            Me.txtFechaLlegadaVehiculo.Location = New System.Drawing.Point(88, 15)
            Me.txtFechaLlegadaVehiculo.Name = "txtFechaLlegadaVehiculo"
            Me.txtFechaLlegadaVehiculo.Size = New System.Drawing.Size(100, 22)
            Me.txtFechaLlegadaVehiculo.TabIndex = 47
            '
            'lblIdLlegadaVehiculo
            '
            Me.lblIdLlegadaVehiculo.AutoSize = True
            Me.lblIdLlegadaVehiculo.Location = New System.Drawing.Point(165, 33)
            Me.lblIdLlegadaVehiculo.Name = "lblIdLlegadaVehiculo"
            Me.lblIdLlegadaVehiculo.Size = New System.Drawing.Size(13, 13)
            Me.lblIdLlegadaVehiculo.TabIndex = 46
            Me.lblIdLlegadaVehiculo.Text = "0"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(864, 24)
            Me.MenuStrip1.TabIndex = 190
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(78, 20)
            Me.ToolStripMenuItem1.Text = "CARGAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.report
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(82, 20)
            Me.btnReporte.Text = "REPORTE"
            '
            'PictureBox1
            '
            Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
            Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.PictureBox1.Location = New System.Drawing.Point(563, 30)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(187, 89)
            Me.PictureBox1.TabIndex = 191
            Me.PictureBox1.TabStop = False
            '
            'dtpAsientoDesde
            '
            Me.dtpAsientoDesde.Location = New System.Drawing.Point(100, 202)
            Me.dtpAsientoDesde.Name = "dtpAsientoDesde"
            Me.dtpAsientoDesde.Size = New System.Drawing.Size(262, 22)
            Me.dtpAsientoDesde.TabIndex = 193
            '
            'lblFechaSolicitudFR
            '
            Me.lblFechaSolicitudFR.AutoSize = True
            Me.lblFechaSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaSolicitudFR.Location = New System.Drawing.Point(7, 205)
            Me.lblFechaSolicitudFR.Name = "lblFechaSolicitudFR"
            Me.lblFechaSolicitudFR.Size = New System.Drawing.Size(90, 13)
            Me.lblFechaSolicitudFR.TabIndex = 192
            Me.lblFechaSolicitudFR.Text = "CARGAR DESDE:"
            '
            'dtpAsientoHasta
            '
            Me.dtpAsientoHasta.Location = New System.Drawing.Point(449, 202)
            Me.dtpAsientoHasta.Name = "dtpAsientoHasta"
            Me.dtpAsientoHasta.Size = New System.Drawing.Size(262, 22)
            Me.dtpAsientoHasta.TabIndex = 195
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(400, 207)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(43, 13)
            Me.Label4.TabIndex = 194
            Me.Label4.Text = "HASTA:"
            '
            'FormBuscarReporteControlCombustibleGeneral
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(864, 543)
            Me.Controls.Add(Me.dtpAsientoHasta)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.dtpAsientoDesde)
            Me.Controls.Add(Me.lblFechaSolicitudFR)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbControl2)
            Me.Controls.Add(Me.gbControl1)
            Me.Controls.Add(Me.dgvControlCombustible)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormBuscarReporteControlCombustibleGeneral"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents dtpAsientoDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblFechaSolicitudFR As System.Windows.Forms.Label
        Friend WithEvents dtpAsientoHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label4 As System.Windows.Forms.Label
    End Class
End Namespace