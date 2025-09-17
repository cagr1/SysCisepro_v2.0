Namespace FORMULARIOS.CONTABILIDAD.BALANCE
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBalanceFinal
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBalanceFinal))
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.cbNivel = New System.Windows.Forms.ComboBox()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.dgvMayores = New System.Windows.Forms.DataGridView()
            Me.nodo = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.LbCount1 = New System.Windows.Forms.Label()
            Me.txtUtilidad = New System.Windows.Forms.TextBox()
            Me.lblUtilidadPerdida = New System.Windows.Forms.Label()
            Me.txtDeudor = New System.Windows.Forms.TextBox()
            Me.txtAcreedor = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtCapital = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.tvBalanceComprobacion = New System.Windows.Forms.TreeView()
            Me.ContextMenuStripClicDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.tsmOcultar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmMostrar = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnArbol = New System.Windows.Forms.ToolStripMenuItem()
            Me.tcAuxiliares = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage3 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.dgvComparacion = New Krypton.Toolkit.KryptonDataGridView()
            Me.nodoCom = New Krypton.Toolkit.KryptonDataGridViewButtonColumn()
            Me.btnCuztomize = New Krypton.Toolkit.KryptonButton()
            Me.KryptonGroupBox4 = New Krypton.Toolkit.KryptonGroupBox()
            Me.btnExportarComparacion = New Krypton.Toolkit.KryptonButton()
            Me.chkOcultar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
            Me.cbxDates = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
            Me.cbxShowColumns = New Krypton.Toolkit.KryptonComboBox()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.dtpFechaDesdeMes = New Krypton.Toolkit.KryptonDateTimePicker()
            Me.dtpFechaHastaMes = New Krypton.Toolkit.KryptonDateTimePicker()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            CType(Me.dgvMayores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.tcAuxiliares, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcAuxiliares.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage3.SuspendLayout()
            CType(Me.dgvComparacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox4.Panel.SuspendLayout()
            Me.KryptonGroupBox4.SuspendLayout()
            CType(Me.cbxDates, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbxShowColumns, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'chkTodos
            '
            Me.chkTodos.BackColor = System.Drawing.Color.Transparent
            Me.chkTodos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkTodos.Location = New System.Drawing.Point(546, 5)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(94, 22)
            Me.chkTodos.TabIndex = 235
            Me.chkTodos.Text = "Quitar $0.0"
            Me.chkTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkTodos.UseVisualStyleBackColor = False
            '
            'cbNivel
            '
            Me.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbNivel.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbNivel.FormattingEnabled = True
            Me.cbNivel.Items.AddRange(New Object() {" -- TODOS --", "1", "2", "3", "4", "5"})
            Me.cbNivel.Location = New System.Drawing.Point(390, 4)
            Me.cbNivel.Name = "cbNivel"
            Me.cbNivel.Size = New System.Drawing.Size(121, 21)
            Me.cbNivel.TabIndex = 234
            '
            'dtpFinal
            '
            Me.dtpFinal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFinal.Location = New System.Drawing.Point(212, 3)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(110, 21)
            Me.dtpFinal.TabIndex = 255
            '
            'dtpInicio
            '
            Me.dtpInicio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpInicio.Location = New System.Drawing.Point(56, 4)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(103, 21)
            Me.dtpInicio.TabIndex = 254
            '
            'dgvMayores
            '
            Me.dgvMayores.AllowUserToAddRows = False
            Me.dgvMayores.AllowUserToDeleteRows = False
            Me.dgvMayores.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvMayores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvMayores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvMayores.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMayores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvMayores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvMayores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nodo})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMayores.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvMayores.Location = New System.Drawing.Point(5, 45)
            Me.dgvMayores.Name = "dgvMayores"
            Me.dgvMayores.RowHeadersVisible = False
            Me.dgvMayores.RowHeadersWidth = 26
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvMayores.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvMayores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMayores.Size = New System.Drawing.Size(911, 513)
            Me.dgvMayores.TabIndex = 225
            '
            'nodo
            '
            Me.nodo.HeaderText = "+"
            Me.nodo.Name = "nodo"
            Me.nodo.Width = 25
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.LbCount1)
            Me.GroupBox2.Controls.Add(Me.txtUtilidad)
            Me.GroupBox2.Controls.Add(Me.lblUtilidadPerdida)
            Me.GroupBox2.Controls.Add(Me.txtDeudor)
            Me.GroupBox2.Controls.Add(Me.txtAcreedor)
            Me.GroupBox2.Controls.Add(Me.Label10)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.txtCapital)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(5, 558)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(904, 43)
            Me.GroupBox2.TabIndex = 253
            Me.GroupBox2.TabStop = False
            '
            'LbCount1
            '
            Me.LbCount1.AutoSize = True
            Me.LbCount1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LbCount1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.LbCount1.Location = New System.Drawing.Point(6, 17)
            Me.LbCount1.Name = "LbCount1"
            Me.LbCount1.Size = New System.Drawing.Size(0, 13)
            Me.LbCount1.TabIndex = 282
            '
            'txtUtilidad
            '
            Me.txtUtilidad.BackColor = System.Drawing.Color.White
            Me.txtUtilidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUtilidad.Location = New System.Drawing.Point(774, 12)
            Me.txtUtilidad.Name = "txtUtilidad"
            Me.txtUtilidad.ReadOnly = True
            Me.txtUtilidad.Size = New System.Drawing.Size(113, 21)
            Me.txtUtilidad.TabIndex = 250
            Me.txtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblUtilidadPerdida
            '
            Me.lblUtilidadPerdida.AutoSize = True
            Me.lblUtilidadPerdida.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUtilidadPerdida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblUtilidadPerdida.Location = New System.Drawing.Point(709, 16)
            Me.lblUtilidadPerdida.Name = "lblUtilidadPerdida"
            Me.lblUtilidadPerdida.Size = New System.Drawing.Size(54, 13)
            Me.lblUtilidadPerdida.TabIndex = 251
            Me.lblUtilidadPerdida.Text = "UTILIDAD"
            '
            'txtDeudor
            '
            Me.txtDeudor.BackColor = System.Drawing.Color.White
            Me.txtDeudor.Enabled = False
            Me.txtDeudor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudor.Location = New System.Drawing.Point(139, 12)
            Me.txtDeudor.Name = "txtDeudor"
            Me.txtDeudor.Size = New System.Drawing.Size(113, 21)
            Me.txtDeudor.TabIndex = 241
            Me.txtDeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAcreedor
            '
            Me.txtAcreedor.BackColor = System.Drawing.Color.White
            Me.txtAcreedor.Enabled = False
            Me.txtAcreedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedor.Location = New System.Drawing.Point(328, 12)
            Me.txtAcreedor.Name = "txtAcreedor"
            Me.txtAcreedor.Size = New System.Drawing.Size(113, 21)
            Me.txtAcreedor.TabIndex = 242
            Me.txtAcreedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(469, 16)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(105, 13)
            Me.Label10.TabIndex = 249
            Me.Label10.Text = "PATRIMONIO NETO"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(87, 16)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(46, 13)
            Me.Label8.TabIndex = 243
            Me.Label8.Text = "ACTIVO"
            '
            'txtCapital
            '
            Me.txtCapital.BackColor = System.Drawing.Color.White
            Me.txtCapital.Enabled = False
            Me.txtCapital.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCapital.Location = New System.Drawing.Point(578, 11)
            Me.txtCapital.Name = "txtCapital"
            Me.txtCapital.Size = New System.Drawing.Size(113, 21)
            Me.txtCapital.TabIndex = 248
            Me.txtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(278, 17)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(45, 13)
            Me.Label9.TabIndex = 244
            Me.Label9.Text = "PASIVO"
            '
            'tvBalanceComprobacion
            '
            Me.tvBalanceComprobacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.tvBalanceComprobacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvBalanceComprobacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tvBalanceComprobacion.Location = New System.Drawing.Point(0, 0)
            Me.tvBalanceComprobacion.Name = "tvBalanceComprobacion"
            Me.tvBalanceComprobacion.Size = New System.Drawing.Size(920, 602)
            Me.tvBalanceComprobacion.TabIndex = 0
            '
            'ContextMenuStripClicDerecho
            '
            Me.ContextMenuStripClicDerecho.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.ContextMenuStripClicDerecho.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmOcultar, Me.tsmMostrar})
            Me.ContextMenuStripClicDerecho.Name = "ContextMenuStripClicDerecho"
            Me.ContextMenuStripClicDerecho.Size = New System.Drawing.Size(130, 48)
            '
            'tsmOcultar
            '
            Me.tsmOcultar.Name = "tsmOcultar"
            Me.tsmOcultar.Size = New System.Drawing.Size(129, 22)
            Me.tsmOcultar.Text = "OCULTAR"
            '
            'tsmMostrar
            '
            Me.tsmMostrar.Name = "tsmMostrar"
            Me.tsmMostrar.Size = New System.Drawing.Size(129, 22)
            Me.tsmMostrar.Text = "MOSTRAR"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargar, Me.btnExportar, Me.btnArbol})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(922, 32)
            Me.MenuStrip1.TabIndex = 290
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnCargar
            '
            Me.btnCargar.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(89, 28)
            Me.btnCargar.Text = "CARGAR"
            '
            'btnExportar
            '
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(99, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'btnArbol
            '
            Me.btnArbol.Image = Global.syscisepro.My.Resources.Resources.account_tree_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnArbol.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnArbol.Name = "btnArbol"
            Me.btnArbol.Size = New System.Drawing.Size(80, 28)
            Me.btnArbol.Text = "ÁRBOL"
            '
            'tcAuxiliares
            '
            Me.tcAuxiliares.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.tcAuxiliares.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.tcAuxiliares.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcAuxiliares.Location = New System.Drawing.Point(0, 32)
            Me.tcAuxiliares.Name = "tcAuxiliares"
            Me.tcAuxiliares.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup
            Me.tcAuxiliares.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage3, Me.KryptonPage2})
            Me.tcAuxiliares.SelectedIndex = 0
            Me.tcAuxiliares.Size = New System.Drawing.Size(922, 631)
            Me.tcAuxiliares.TabIndex = 291
            Me.tcAuxiliares.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Controls.Add(Me.dgvMayores)
            Me.KryptonPage1.Controls.Add(Me.GroupBox2)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(920, 602)
            Me.KryptonPage1.Text = "Mayores"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "21E19C2E67CA4541098720E93A94B53D"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 2)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkTodos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbNivel)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFinal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpInicio)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(920, 41)
            Me.KryptonGroupBox1.TabIndex = 0
            Me.KryptonGroupBox1.Values.Heading = ""
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(334, 3)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel3.TabIndex = 256
            Me.KryptonLabel3.Values.Text = "Niveles"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(165, 4)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel2.TabIndex = 255
            Me.KryptonLabel2.Values.Text = "Hasta"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(5, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Desde"
            '
            'KryptonPage3
            '
            Me.KryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage3.Controls.Add(Me.dgvComparacion)
            Me.KryptonPage3.Controls.Add(Me.btnCuztomize)
            Me.KryptonPage3.Controls.Add(Me.KryptonGroupBox4)
            Me.KryptonPage3.Flags = 65534
            Me.KryptonPage3.LastVisibleSet = True
            Me.KryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage3.Name = "KryptonPage3"
            Me.KryptonPage3.Size = New System.Drawing.Size(920, 602)
            Me.KryptonPage3.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage3.Text = "Comparativo"
            Me.KryptonPage3.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage3.UniqueName = "B29FDC7AF5D5473543A218A3C1F082DA"
            '
            'dgvComparacion
            '
            Me.dgvComparacion.AllowUserToAddRows = False
            Me.dgvComparacion.AllowUserToDeleteRows = False
            Me.dgvComparacion.AllowUserToOrderColumns = True
            Me.dgvComparacion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComparacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nodoCom})
            Me.dgvComparacion.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Sheet
            Me.dgvComparacion.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
            Me.dgvComparacion.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet
            Me.dgvComparacion.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet
            Me.dgvComparacion.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet
            Me.dgvComparacion.Location = New System.Drawing.Point(14, 93)
            Me.dgvComparacion.Name = "dgvComparacion"
            Me.dgvComparacion.RowHeadersVisible = False
            Me.dgvComparacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComparacion.Size = New System.Drawing.Size(799, 506)
            Me.dgvComparacion.StateNormal.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvComparacion.TabIndex = 257
            '
            'nodoCom
            '
            Me.nodoCom.HeaderText = "+"
            Me.nodoCom.Name = "nodoCom"
            Me.nodoCom.Width = 30
            '
            'btnCuztomize
            '
            Me.btnCuztomize.Location = New System.Drawing.Point(132, 14)
            Me.btnCuztomize.Name = "btnCuztomize"
            Me.btnCuztomize.Size = New System.Drawing.Size(130, 23)
            Me.btnCuztomize.TabIndex = 256
            Me.btnCuztomize.Values.Text = "Personalizar Reporte"
            '
            'KryptonGroupBox4
            '
            Me.KryptonGroupBox4.CaptionOverlap = 0R
            Me.KryptonGroupBox4.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox4.Location = New System.Drawing.Point(14, 11)
            Me.KryptonGroupBox4.Name = "KryptonGroupBox4"
            '
            'KryptonGroupBox4.Panel
            '
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.btnExportarComparacion)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.chkOcultar)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cbxDates)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cbxShowColumns)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dtpFechaDesdeMes)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dtpFechaHastaMes)
            Me.KryptonGroupBox4.Size = New System.Drawing.Size(799, 69)
            Me.KryptonGroupBox4.TabIndex = 231
            Me.KryptonGroupBox4.Values.Heading = "Busqueda"
            Me.KryptonGroupBox4.Values.Image = Global.syscisepro.My.Resources.Resources.calendar_month_24dp_FILL0_wght400_GRAD0_opsz24__2_
            '
            'btnExportarComparacion
            '
            Me.btnExportarComparacion.Location = New System.Drawing.Point(574, 3)
            Me.btnExportarComparacion.Name = "btnExportarComparacion"
            Me.btnExportarComparacion.Size = New System.Drawing.Size(30, 30)
            Me.btnExportarComparacion.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.[False]
            Me.btnExportarComparacion.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.[False]
            Me.btnExportarComparacion.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.btnExportarComparacion.TabIndex = 254
            Me.btnExportarComparacion.Values.ImageStates.ImageCheckedNormal = Nothing
            Me.btnExportarComparacion.Values.ImageStates.ImageCheckedPressed = Nothing
            Me.btnExportarComparacion.Values.ImageStates.ImageCheckedTracking = Nothing
            Me.btnExportarComparacion.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarComparacion.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarComparacion.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarComparacion.Values.Text = ""
            '
            'chkOcultar
            '
            Me.chkOcultar.Images.CheckedNormal = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
            Me.chkOcultar.Images.CheckedPressed = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
            Me.chkOcultar.Images.CheckedTracking = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
            Me.chkOcultar.Location = New System.Drawing.Point(471, 10)
            Me.chkOcultar.Name = "chkOcultar"
            Me.chkOcultar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
            Me.chkOcultar.Size = New System.Drawing.Size(91, 18)
            Me.chkOcultar.StateCommon.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkOcultar.TabIndex = 253
            Me.chkOcultar.Values.Text = "Quitar $0.00"
            '
            'cbxDates
            '
            Me.cbxDates.AlwaysActive = False
            Me.cbxDates.DropDownWidth = 150
            Me.cbxDates.Items.AddRange(New Object() {"Mensual", "Trimestral", "Semestral", "Anual ", "Personalizado"})
            Me.cbxDates.Location = New System.Drawing.Point(714, 10)
            Me.cbxDates.Name = "cbxDates"
            Me.cbxDates.Size = New System.Drawing.Size(76, 21)
            Me.cbxDates.TabIndex = 233
            Me.cbxDates.Text = "Fechas"
            Me.cbxDates.Visible = False
            '
            'cbxShowColumns
            '
            Me.cbxShowColumns.AlwaysActive = False
            Me.cbxShowColumns.DropDownWidth = 121
            Me.cbxShowColumns.IntegralHeight = False
            Me.cbxShowColumns.Items.AddRange(New Object() {"Mensual", "Trimestral", "Semestral", "Anual"})
            Me.cbxShowColumns.Location = New System.Drawing.Point(313, 8)
            Me.cbxShowColumns.Name = "cbxShowColumns"
            Me.cbxShowColumns.Size = New System.Drawing.Size(131, 21)
            Me.cbxShowColumns.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
            Me.cbxShowColumns.TabIndex = 232
            Me.cbxShowColumns.Text = "Ordenar Columnas"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(160, 8)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel11.TabIndex = 231
            Me.KryptonLabel11.Values.Text = "Hasta"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(15, 8)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel10.TabIndex = 230
            Me.KryptonLabel10.Values.Text = "Desde"
            '
            'dtpFechaDesdeMes
            '
            Me.dtpFechaDesdeMes.AlwaysActive = False
            Me.dtpFechaDesdeMes.CalendarTodayDate = New Date(2025, 2, 4, 0, 0, 0, 0)
            Me.dtpFechaDesdeMes.CustomFormat = "MMMM - yyyy"
            Me.dtpFechaDesdeMes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesdeMes.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
            Me.dtpFechaDesdeMes.Location = New System.Drawing.Point(66, 8)
            Me.dtpFechaDesdeMes.Name = "dtpFechaDesdeMes"
            Me.dtpFechaDesdeMes.Size = New System.Drawing.Size(85, 21)
            Me.dtpFechaDesdeMes.TabIndex = 228
            '
            'dtpFechaHastaMes
            '
            Me.dtpFechaHastaMes.AlwaysActive = False
            Me.dtpFechaHastaMes.CalendarTodayDate = New Date(2025, 2, 4, 0, 0, 0, 0)
            Me.dtpFechaHastaMes.CustomFormat = "MMMM - yyyy"
            Me.dtpFechaHastaMes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHastaMes.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
            Me.dtpFechaHastaMes.Location = New System.Drawing.Point(207, 8)
            Me.dtpFechaHastaMes.Name = "dtpFechaHastaMes"
            Me.dtpFechaHastaMes.Size = New System.Drawing.Size(86, 21)
            Me.dtpFechaHastaMes.TabIndex = 229
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.tvBalanceComprobacion)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(920, 602)
            Me.KryptonPage2.Text = "Arbol"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "FF643023690441A3F980E845C980F1C1"
            '
            'FormBalanceFinal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(922, 663)
            Me.Controls.Add(Me.tcAuxiliares)
            Me.Controls.Add(Me.MenuStrip1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormBalanceFinal"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BALANCE FINAL"
            CType(Me.dgvMayores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.tcAuxiliares, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcAuxiliares.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage3.ResumeLayout(False)
            CType(Me.dgvComparacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.Panel.ResumeLayout(False)
            Me.KryptonGroupBox4.Panel.PerformLayout()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.ResumeLayout(False)
            CType(Me.cbxDates, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbxShowColumns, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtAcreedor As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudor As System.Windows.Forms.TextBox
        Friend WithEvents dgvMayores As System.Windows.Forms.DataGridView
        Friend WithEvents tvBalanceComprobacion As System.Windows.Forms.TreeView
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents tsmOcultar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmMostrar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtCapital As System.Windows.Forms.TextBox
        Friend WithEvents lblUtilidadPerdida As System.Windows.Forms.Label
        Friend WithEvents txtUtilidad As System.Windows.Forms.TextBox
        Friend WithEvents nodo As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents LbCount1 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnArbol As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents cbNivel As System.Windows.Forms.ComboBox
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents tcAuxiliares As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage3 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox4 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents cbxDates As ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Friend WithEvents cbxShowColumns As Krypton.Toolkit.KryptonComboBox
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents dtpFechaDesdeMes As Krypton.Toolkit.KryptonDateTimePicker
        Friend WithEvents dtpFechaHastaMes As Krypton.Toolkit.KryptonDateTimePicker
        Friend WithEvents btnCuztomize As Krypton.Toolkit.KryptonButton
        Friend WithEvents dgvComparacion As Krypton.Toolkit.KryptonDataGridView
        Friend WithEvents nodoCom As Krypton.Toolkit.KryptonDataGridViewButtonColumn
        Friend WithEvents chkOcultar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Friend WithEvents btnExportarComparacion As Krypton.Toolkit.KryptonButton
    End Class
End Namespace