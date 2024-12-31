Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormKardex
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKardex))
            Me.btnllamar = New System.Windows.Forms.Button()
            Me.btnExportarComprobantes = New System.Windows.Forms.Button()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.txtConcepto = New System.Windows.Forms.TextBox()
            Me.txtBodega = New System.Windows.Forms.TextBox()
            Me.txtCentroCosto = New System.Windows.Forms.TextBox()
            Me.txtActividad = New System.Windows.Forms.TextBox()
            Me.txtRazón = New System.Windows.Forms.TextBox()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.txtCódigo = New System.Windows.Forms.TextBox()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.txtNumero = New System.Windows.Forms.TextBox()
            Me.txtBuscarKardex = New System.Windows.Forms.TextBox()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.dgvKardex = New System.Windows.Forms.DataGridView()
            Me.ttPublico = New System.Windows.Forms.ToolTip(Me.components)
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.dgvDetalleKardex = New System.Windows.Forms.DataGridView()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.crvKardex = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.msKardex.SuspendLayout()
            CType(Me.dgvKardex, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.dgvDetalleKardex, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnllamar
            '
            Me.btnllamar.Location = New System.Drawing.Point(418, 146)
            Me.btnllamar.Name = "btnllamar"
            Me.btnllamar.Size = New System.Drawing.Size(75, 23)
            Me.btnllamar.TabIndex = 197
            Me.btnllamar.Text = "llamar"
            Me.btnllamar.UseVisualStyleBackColor = True
            '
            'btnExportarComprobantes
            '
            Me.btnExportarComprobantes.BackColor = System.Drawing.Color.Transparent
            Me.btnExportarComprobantes.FlatAppearance.BorderSize = 0
            Me.btnExportarComprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExportarComprobantes.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarComprobantes.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarComprobantes.Location = New System.Drawing.Point(431, 34)
            Me.btnExportarComprobantes.Name = "btnExportarComprobantes"
            Me.btnExportarComprobantes.Size = New System.Drawing.Size(28, 28)
            Me.btnExportarComprobantes.TabIndex = 196
            Me.btnExportarComprobantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportarComprobantes.UseVisualStyleBackColor = False
            '
            'TextBox1
            '
            Me.TextBox1.BackColor = System.Drawing.Color.White
            Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox1.Enabled = False
            Me.TextBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.ForeColor = System.Drawing.Color.Black
            Me.TextBox1.Location = New System.Drawing.Point(70, 106)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(389, 21)
            Me.TextBox1.TabIndex = 81
            '
            'txtConcepto
            '
            Me.txtConcepto.BackColor = System.Drawing.Color.White
            Me.txtConcepto.Enabled = False
            Me.txtConcepto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConcepto.Location = New System.Drawing.Point(70, 159)
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.Size = New System.Drawing.Size(150, 21)
            Me.txtConcepto.TabIndex = 79
            Me.txtConcepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtBodega
            '
            Me.txtBodega.BackColor = System.Drawing.Color.White
            Me.txtBodega.Enabled = False
            Me.txtBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBodega.Location = New System.Drawing.Point(72, 29)
            Me.txtBodega.Name = "txtBodega"
            Me.txtBodega.Size = New System.Drawing.Size(160, 21)
            Me.txtBodega.TabIndex = 78
            Me.txtBodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCentroCosto
            '
            Me.txtCentroCosto.BackColor = System.Drawing.Color.White
            Me.txtCentroCosto.Enabled = False
            Me.txtCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCentroCosto.Location = New System.Drawing.Point(329, 30)
            Me.txtCentroCosto.Name = "txtCentroCosto"
            Me.txtCentroCosto.Size = New System.Drawing.Size(130, 21)
            Me.txtCentroCosto.TabIndex = 77
            Me.txtCentroCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtActividad
            '
            Me.txtActividad.BackColor = System.Drawing.Color.White
            Me.txtActividad.Enabled = False
            Me.txtActividad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtActividad.Location = New System.Drawing.Point(331, 3)
            Me.txtActividad.Name = "txtActividad"
            Me.txtActividad.Size = New System.Drawing.Size(128, 21)
            Me.txtActividad.TabIndex = 76
            Me.txtActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtRazón
            '
            Me.txtRazón.BackColor = System.Drawing.Color.White
            Me.txtRazón.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazón.Enabled = False
            Me.txtRazón.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazón.ForeColor = System.Drawing.Color.Black
            Me.txtRazón.Location = New System.Drawing.Point(70, 132)
            Me.txtRazón.Name = "txtRazón"
            Me.txtRazón.Size = New System.Drawing.Size(389, 21)
            Me.txtRazón.TabIndex = 74
            '
            'txtCedula
            '
            Me.txtCedula.BackColor = System.Drawing.Color.White
            Me.txtCedula.Enabled = False
            Me.txtCedula.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(320, 79)
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(70, 21)
            Me.txtCedula.TabIndex = 73
            Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtNombre
            '
            Me.txtNombre.BackColor = System.Drawing.Color.White
            Me.txtNombre.Enabled = False
            Me.txtNombre.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(70, 80)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(214, 21)
            Me.txtNombre.TabIndex = 71
            Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCódigo
            '
            Me.txtCódigo.BackColor = System.Drawing.Color.White
            Me.txtCódigo.Enabled = False
            Me.txtCódigo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCódigo.ForeColor = System.Drawing.Color.Black
            Me.txtCódigo.Location = New System.Drawing.Point(320, 55)
            Me.txtCódigo.Name = "txtCódigo"
            Me.txtCódigo.Size = New System.Drawing.Size(61, 21)
            Me.txtCódigo.TabIndex = 69
            Me.txtCódigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'dtpFecha
            '
            Me.dtpFecha.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFecha.Enabled = False
            Me.dtpFecha.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(72, 56)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(97, 21)
            Me.dtpFecha.TabIndex = 51
            '
            'txtNumero
            '
            Me.txtNumero.BackColor = System.Drawing.Color.White
            Me.txtNumero.Enabled = False
            Me.txtNumero.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumero.Location = New System.Drawing.Point(102, 3)
            Me.txtNumero.Name = "txtNumero"
            Me.txtNumero.Size = New System.Drawing.Size(104, 21)
            Me.txtNumero.TabIndex = 8
            Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtBuscarKardex
            '
            Me.txtBuscarKardex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBuscarKardex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBuscarKardex.Location = New System.Drawing.Point(65, 35)
            Me.txtBuscarKardex.Name = "txtBuscarKardex"
            Me.txtBuscarKardex.Size = New System.Drawing.Size(356, 22)
            Me.txtBuscarKardex.TabIndex = 194
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.tsmReporte})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(992, 32)
            Me.msKardex.TabIndex = 177
            Me.msKardex.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(87, 28)
            Me.ToolStripMenuItem1.Text = "BUSCAR"
            '
            'tsmReporte
            '
            Me.tsmReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.tsmReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmReporte.Name = "tsmReporte"
            Me.tsmReporte.Size = New System.Drawing.Size(93, 28)
            Me.tsmReporte.Text = "REPORTE "
            '
            'dgvKardex
            '
            Me.dgvKardex.AllowDrop = True
            Me.dgvKardex.AllowUserToAddRows = False
            Me.dgvKardex.AllowUserToDeleteRows = False
            Me.dgvKardex.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvKardex.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvKardex.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvKardex.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvKardex.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvKardex.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvKardex.Location = New System.Drawing.Point(8, 68)
            Me.dgvKardex.MultiSelect = False
            Me.dgvKardex.Name = "dgvKardex"
            Me.dgvKardex.ReadOnly = True
            Me.dgvKardex.RowHeadersVisible = False
            Me.dgvKardex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvKardex.Size = New System.Drawing.Size(490, 200)
            Me.dgvKardex.TabIndex = 129
            '
            'ttPublico
            '
            Me.ttPublico.AutoPopDelay = 5000
            Me.ttPublico.BackColor = System.Drawing.Color.LightSteelBlue
            Me.ttPublico.InitialDelay = 100
            Me.ttPublico.IsBalloon = True
            Me.ttPublico.ReshowDelay = 100
            Me.ttPublico.ShowAlways = True
            Me.ttPublico.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.KryptonNavigator1.SelectedIndex = 0
            Me.KryptonNavigator1.Size = New System.Drawing.Size(994, 638)
            Me.KryptonNavigator1.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonNavigator1.TabIndex = 1
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.dgvDetalleKardex)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Controls.Add(Me.KryptonLabel1)
            Me.KryptonPage1.Controls.Add(Me.btnExportarComprobantes)
            Me.KryptonPage1.Controls.Add(Me.msKardex)
            Me.KryptonPage1.Controls.Add(Me.txtBuscarKardex)
            Me.KryptonPage1.Controls.Add(Me.dgvKardex)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(992, 611)
            Me.KryptonPage1.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage1.Text = "Detalle Item"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "06641E07E2B94D0941A72EBA41F5E115"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.crvKardex)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(992, 611)
            Me.KryptonPage2.Text = "Reporte"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "916656427B00401E4BB9FBBC06B35DB2"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(13, 35)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(46, 20)
            Me.KryptonLabel1.TabIndex = 178
            Me.KryptonLabel1.Values.Text = "Buscar"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(504, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtConcepto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.TextBox1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRazón)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCedula)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombre)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumero)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtBodega)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCódigo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtActividad)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFecha)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(477, 233)
            Me.KryptonGroupBox1.TabIndex = 197
            Me.KryptonGroupBox1.Values.Heading = "Datos de Comprobante"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(86, 20)
            Me.KryptonLabel2.TabIndex = 198
            Me.KryptonLabel2.Values.Text = "Comprobante"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(247, 3)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel3.TabIndex = 199
            Me.KryptonLabel3.Values.Text = "Actividad"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(5, 29)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel4.TabIndex = 200
            Me.KryptonLabel4.Values.Text = "Bodega"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(247, 29)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel5.TabIndex = 201
            Me.KryptonLabel5.Values.Text = "C. Costo"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(5, 55)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel6.TabIndex = 202
            Me.KryptonLabel6.Values.Text = "Fecha"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(247, 54)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel7.TabIndex = 203
            Me.KryptonLabel7.Values.Text = "Codigo"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(5, 81)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel8.TabIndex = 204
            Me.KryptonLabel8.Values.Text = "Custodio"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(295, 80)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel9.TabIndex = 205
            Me.KryptonLabel9.Values.Text = "CI"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(5, 107)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(64, 20)
            Me.KryptonLabel10.TabIndex = 206
            Me.KryptonLabel10.Values.Text = "Ubicacion"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(5, 133)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel11.TabIndex = 207
            Me.KryptonLabel11.Values.Text = "Razon"
            '
            'dgvDetalleKardex
            '
            Me.dgvDetalleKardex.AllowDrop = True
            Me.dgvDetalleKardex.AllowUserToAddRows = False
            Me.dgvDetalleKardex.AllowUserToDeleteRows = False
            Me.dgvDetalleKardex.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleKardex.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvDetalleKardex.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvDetalleKardex.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleKardex.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDetalleKardex.Location = New System.Drawing.Point(9, 274)
            Me.dgvDetalleKardex.MultiSelect = False
            Me.dgvDetalleKardex.Name = "dgvDetalleKardex"
            Me.dgvDetalleKardex.ReadOnly = True
            Me.dgvDetalleKardex.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvDetalleKardex.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvDetalleKardex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleKardex.Size = New System.Drawing.Size(972, 326)
            Me.dgvDetalleKardex.TabIndex = 198
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(5, 160)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel12.TabIndex = 208
            Me.KryptonLabel12.Values.Text = "Concepto"
            '
            'crvKardex
            '
            Me.crvKardex.ActiveViewIndex = -1
            Me.crvKardex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvKardex.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvKardex.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvKardex.Location = New System.Drawing.Point(0, 0)
            Me.crvKardex.Name = "crvKardex"
            Me.crvKardex.Size = New System.Drawing.Size(992, 611)
            Me.crvKardex.TabIndex = 4
            Me.crvKardex.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FormKardex
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(994, 638)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Controls.Add(Me.btnllamar)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormKardex"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "KARDEX"
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            CType(Me.dgvKardex, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            Me.KryptonPage1.PerformLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.dgvDetalleKardex, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgvKardex As System.Windows.Forms.DataGridView
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents tsmReporte As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents ttPublico As System.Windows.Forms.ToolTip
        Friend WithEvents txtBuscarKardex As System.Windows.Forms.TextBox
        Friend WithEvents txtNumero As System.Windows.Forms.TextBox
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtCódigo As System.Windows.Forms.TextBox
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents txtRazón As System.Windows.Forms.TextBox
        Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
        Friend WithEvents txtBodega As System.Windows.Forms.TextBox
        Friend WithEvents txtCentroCosto As System.Windows.Forms.TextBox
        Friend WithEvents txtActividad As System.Windows.Forms.TextBox
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents btnExportarComprobantes As System.Windows.Forms.Button
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnllamar As System.Windows.Forms.Button
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents dgvDetalleKardex As DataGridView
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents crvKardex As CrystalDecisions.Windows.Forms.CrystalReportViewer
    End Class
End Namespace