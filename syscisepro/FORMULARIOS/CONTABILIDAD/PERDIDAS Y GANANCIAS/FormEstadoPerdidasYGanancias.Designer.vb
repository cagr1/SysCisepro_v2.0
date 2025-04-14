Namespace FORMULARIOS.CONTABILIDAD.PERDIDAS_Y_GANANCIAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormEstadoPerdidasYGanancias
        'Inherits System.Windows.Forms.Form
        Inherits Krypton.Toolkit.KryptonForm
        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEstadoPerdidasYGanancias))
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.txtEgresos = New System.Windows.Forms.TextBox()
            Me.txtIngresos = New System.Windows.Forms.TextBox()
            Me.txtAcreedorEgresos = New System.Windows.Forms.TextBox()
            Me.txtDeudorEgresos = New System.Windows.Forms.TextBox()
            Me.txtAcreedorIngresos = New System.Windows.Forms.TextBox()
            Me.txtDeudorIngresos = New System.Windows.Forms.TextBox()
            Me.dgvEgresos = New System.Windows.Forms.DataGridView()
            Me.nodoEgreso = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.dgvIngresos = New System.Windows.Forms.DataGridView()
            Me.nodo = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.ContextMenuStripClicDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.tsmOcultar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmMostrar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ContextMenuStripClicDerechoEgresos = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.tsmOcultarEgresos = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmMostrarEgresos = New System.Windows.Forms.ToolStripMenuItem()
            Me.cbNivel = New System.Windows.Forms.ComboBox()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.btnExcel = New ComponentFactory.Krypton.Toolkit.KryptonDropButton()
            Me.kcmExcelMenu = New ComponentFactory.Krypton.Toolkit.KryptonContextMenu()
            Me.KryptonContextMenuItems2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
            Me.KryptonContextMenuItem1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
            Me.KryptonContextMenuItem2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
            Me.KryptonContextMenuItem3 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
            Me.btnReporteNew = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.btnCargar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.KryptonPage3 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.dgvPresupuesto = New Krypton.Toolkit.KryptonDataGridView()
            Me.KryptonGroupBox5 = New Krypton.Toolkit.KryptonGroupBox()
            Me.btnCargarPresupuesto = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.btnExportarPresupuesto = New Krypton.Toolkit.KryptonButton()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.dtpFechaDesdePresupuesto = New Krypton.Toolkit.KryptonDateTimePicker()
            Me.dtpFechaHastaPresupuesto = New Krypton.Toolkit.KryptonDateTimePicker()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.btnCuztomize = New Krypton.Toolkit.KryptonButton()
            Me.dgvComparacion = New Krypton.Toolkit.KryptonDataGridView()
            Me.nodoCom = New Krypton.Toolkit.KryptonDataGridViewButtonColumn()
            Me.KryptonGroupBox4 = New Krypton.Toolkit.KryptonGroupBox()
            Me.chkOcultar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
            Me.btnExportarComparacion = New Krypton.Toolkit.KryptonButton()
            Me.cbxDates = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
            Me.cbxShowColumns = New Krypton.Toolkit.KryptonComboBox()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.dtpFechaDesdeMes = New Krypton.Toolkit.KryptonDateTimePicker()
            Me.dtpFechaHastaMes = New Krypton.Toolkit.KryptonDateTimePicker()
            Me.KryptonRibbonGroupButton1 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
            Me.KryptonRibbonGroupButton2 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
            Me.KryptonRibbonGroupButton3 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
            Me.KryptonRibbonGroupTriple1 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple()
            Me.KryptonRibbonGroup1 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup()
            Me.KryptonContextMenuItems1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
            Me.nodoComPresupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.dgvEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            Me.ContextMenuStripClicDerechoEgresos.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage3.SuspendLayout()
            CType(Me.dgvPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox5.Panel.SuspendLayout()
            Me.KryptonGroupBox5.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            CType(Me.dgvComparacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox4.Panel.SuspendLayout()
            Me.KryptonGroupBox4.SuspendLayout()
            CType(Me.cbxDates, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbxShowColumns, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.White
            Me.txtTotal.Enabled = False
            Me.txtTotal.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtTotal.Location = New System.Drawing.Point(590, 8)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(119, 27)
            Me.txtTotal.TabIndex = 282
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label22.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label22.Location = New System.Drawing.Point(407, 18)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(142, 15)
            Me.Label22.TabIndex = 281
            Me.Label22.Text = "(INGRESOS - EGRESOS)"
            '
            'txtEgresos
            '
            Me.txtEgresos.BackColor = System.Drawing.Color.White
            Me.txtEgresos.Enabled = False
            Me.txtEgresos.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEgresos.Location = New System.Drawing.Point(536, 206)
            Me.txtEgresos.Name = "txtEgresos"
            Me.txtEgresos.Size = New System.Drawing.Size(139, 26)
            Me.txtEgresos.TabIndex = 279
            Me.txtEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIngresos
            '
            Me.txtIngresos.BackColor = System.Drawing.Color.White
            Me.txtIngresos.Enabled = False
            Me.txtIngresos.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIngresos.Location = New System.Drawing.Point(536, 203)
            Me.txtIngresos.Name = "txtIngresos"
            Me.txtIngresos.Size = New System.Drawing.Size(139, 26)
            Me.txtIngresos.TabIndex = 277
            Me.txtIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAcreedorEgresos
            '
            Me.txtAcreedorEgresos.BackColor = System.Drawing.Color.White
            Me.txtAcreedorEgresos.Enabled = False
            Me.txtAcreedorEgresos.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedorEgresos.Location = New System.Drawing.Point(263, 203)
            Me.txtAcreedorEgresos.Name = "txtAcreedorEgresos"
            Me.txtAcreedorEgresos.Size = New System.Drawing.Size(88, 26)
            Me.txtAcreedorEgresos.TabIndex = 274
            Me.txtAcreedorEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudorEgresos
            '
            Me.txtDeudorEgresos.BackColor = System.Drawing.Color.White
            Me.txtDeudorEgresos.Enabled = False
            Me.txtDeudorEgresos.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudorEgresos.Location = New System.Drawing.Point(78, 206)
            Me.txtDeudorEgresos.Name = "txtDeudorEgresos"
            Me.txtDeudorEgresos.Size = New System.Drawing.Size(88, 26)
            Me.txtDeudorEgresos.TabIndex = 273
            Me.txtDeudorEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAcreedorIngresos
            '
            Me.txtAcreedorIngresos.BackColor = System.Drawing.Color.White
            Me.txtAcreedorIngresos.Enabled = False
            Me.txtAcreedorIngresos.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedorIngresos.Location = New System.Drawing.Point(263, 207)
            Me.txtAcreedorIngresos.Name = "txtAcreedorIngresos"
            Me.txtAcreedorIngresos.Size = New System.Drawing.Size(88, 26)
            Me.txtAcreedorIngresos.TabIndex = 270
            Me.txtAcreedorIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudorIngresos
            '
            Me.txtDeudorIngresos.BackColor = System.Drawing.Color.White
            Me.txtDeudorIngresos.Enabled = False
            Me.txtDeudorIngresos.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudorIngresos.Location = New System.Drawing.Point(83, 207)
            Me.txtDeudorIngresos.Name = "txtDeudorIngresos"
            Me.txtDeudorIngresos.Size = New System.Drawing.Size(88, 26)
            Me.txtDeudorIngresos.TabIndex = 269
            Me.txtDeudorIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvEgresos
            '
            Me.dgvEgresos.AllowUserToAddRows = False
            Me.dgvEgresos.AllowUserToDeleteRows = False
            Me.dgvEgresos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvEgresos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvEgresos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvEgresos.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvEgresos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvEgresos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nodoEgreso})
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvEgresos.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvEgresos.Location = New System.Drawing.Point(11, 3)
            Me.dgvEgresos.Name = "dgvEgresos"
            Me.dgvEgresos.ReadOnly = True
            Me.dgvEgresos.RowHeadersVisible = False
            Me.dgvEgresos.RowHeadersWidth = 26
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvEgresos.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvEgresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvEgresos.Size = New System.Drawing.Size(754, 194)
            Me.dgvEgresos.TabIndex = 228
            '
            'nodoEgreso
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
            Me.nodoEgreso.DefaultCellStyle = DataGridViewCellStyle3
            Me.nodoEgreso.HeaderText = "+"
            Me.nodoEgreso.Name = "nodoEgreso"
            Me.nodoEgreso.ReadOnly = True
            Me.nodoEgreso.ToolTipText = "Expandir / Contraer"
            Me.nodoEgreso.Width = 50
            '
            'dgvIngresos
            '
            Me.dgvIngresos.AllowUserToAddRows = False
            Me.dgvIngresos.AllowUserToDeleteRows = False
            Me.dgvIngresos.AllowUserToResizeRows = False
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvIngresos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvIngresos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvIngresos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvIngresos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nodo})
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvIngresos.DefaultCellStyle = DataGridViewCellStyle9
            Me.dgvIngresos.Location = New System.Drawing.Point(6, 3)
            Me.dgvIngresos.Name = "dgvIngresos"
            Me.dgvIngresos.ReadOnly = True
            Me.dgvIngresos.RowHeadersVisible = False
            Me.dgvIngresos.RowHeadersWidth = 26
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvIngresos.RowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvIngresos.Size = New System.Drawing.Size(764, 200)
            Me.dgvIngresos.TabIndex = 226
            '
            'nodo
            '
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
            Me.nodo.DefaultCellStyle = DataGridViewCellStyle8
            Me.nodo.HeaderText = "+"
            Me.nodo.Name = "nodo"
            Me.nodo.ReadOnly = True
            Me.nodo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.nodo.ToolTipText = "Expandir / Contraer"
            Me.nodo.Width = 50
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(66, 4)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(105, 21)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(234, 4)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(105, 21)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'ContextMenuStripClicDerecho
            '
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
            'ContextMenuStripClicDerechoEgresos
            '
            Me.ContextMenuStripClicDerechoEgresos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.ContextMenuStripClicDerechoEgresos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmOcultarEgresos, Me.tsmMostrarEgresos})
            Me.ContextMenuStripClicDerechoEgresos.Name = "ContextMenuStripClicDerecho"
            Me.ContextMenuStripClicDerechoEgresos.Size = New System.Drawing.Size(130, 48)
            '
            'tsmOcultarEgresos
            '
            Me.tsmOcultarEgresos.Name = "tsmOcultarEgresos"
            Me.tsmOcultarEgresos.Size = New System.Drawing.Size(129, 22)
            Me.tsmOcultarEgresos.Text = "OCULTAR"
            '
            'tsmMostrarEgresos
            '
            Me.tsmMostrarEgresos.Name = "tsmMostrarEgresos"
            Me.tsmMostrarEgresos.Size = New System.Drawing.Size(129, 22)
            Me.tsmMostrarEgresos.Text = "MOSTRAR"
            '
            'cbNivel
            '
            Me.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbNivel.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbNivel.FormattingEnabled = True
            Me.cbNivel.Items.AddRange(New Object() {" -- TODOS --", "1", "2", "3", "4", "5", "6"})
            Me.cbNivel.Location = New System.Drawing.Point(508, 2)
            Me.cbNivel.Name = "cbNivel"
            Me.cbNivel.Size = New System.Drawing.Size(121, 21)
            Me.cbNivel.TabIndex = 232
            '
            'chkTodos
            '
            Me.chkTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkTodos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkTodos.Location = New System.Drawing.Point(647, 4)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(119, 16)
            Me.chkTodos.TabIndex = 229
            Me.chkTodos.Text = "Quitar $0.0"
            Me.chkTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkTodos.UseVisualStyleBackColor = False
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(6, 45)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbNivel)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkTodos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaDesde)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(780, 54)
            Me.KryptonGroupBox1.TabIndex = 291
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(451, 3)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel3.TabIndex = 2
            Me.KryptonLabel3.Values.Text = "Niveles"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(185, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel2.TabIndex = 1
            Me.KryptonLabel2.Values.Text = "Hasta"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(9, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Desde"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(6, 106)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvIngresos)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtIngresos)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtDeudorIngresos)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtAcreedorIngresos)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(780, 260)
            Me.KryptonGroupBox2.TabIndex = 292
            Me.KryptonGroupBox2.Values.Heading = "Ingresos"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl
            Me.KryptonLabel6.Location = New System.Drawing.Point(426, 207)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(71, 22)
            Me.KryptonLabel6.StateNormal.LongText.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.KryptonLabel6.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.KryptonLabel6.TabIndex = 271
            Me.KryptonLabel6.Values.Text = "Ingresos"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(197, 209)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel5.TabIndex = 270
            Me.KryptonLabel5.Values.Text = "Acreedor"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(26, 209)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(51, 20)
            Me.KryptonLabel4.TabIndex = 1
            Me.KryptonLabel4.Values.Text = "Deudor"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(6, 372)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtEgresos)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dgvEgresos)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtDeudorEgresos)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtAcreedorEgresos)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(780, 262)
            Me.KryptonGroupBox3.TabIndex = 293
            Me.KryptonGroupBox3.Values.Heading = "Egresos"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
            Me.KryptonLabel7.Location = New System.Drawing.Point(426, 209)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(67, 22)
            Me.KryptonLabel7.StateNormal.LongText.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.KryptonLabel7.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.KryptonLabel7.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.KryptonLabel7.TabIndex = 271
            Me.KryptonLabel7.Values.Text = "Egresos"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(197, 209)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel8.TabIndex = 270
            Me.KryptonLabel8.Values.Text = "Acreedor"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(26, 209)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(51, 20)
            Me.KryptonLabel9.TabIndex = 1
            Me.KryptonLabel9.Values.Text = "Deudor"
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage3, Me.KryptonPage2})
            Me.KryptonNavigator1.SelectedIndex = 1
            Me.KryptonNavigator1.Size = New System.Drawing.Size(819, 670)
            Me.KryptonNavigator1.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonNavigator1.TabIndex = 294
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.btnExcel)
            Me.KryptonPage1.Controls.Add(Me.btnReporteNew)
            Me.KryptonPage1.Controls.Add(Me.Label22)
            Me.KryptonPage1.Controls.Add(Me.txtTotal)
            Me.KryptonPage1.Controls.Add(Me.btnCargar)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox3)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox2)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(817, 641)
            Me.KryptonPage1.Text = "General"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "7FFBC1C00EEF478B3F89240E9045C7F5"
            '
            'btnExcel
            '
            Me.btnExcel.AutoSize = True
            Me.btnExcel.KryptonContextMenu = Me.kcmExcelMenu
            Me.btnExcel.Location = New System.Drawing.Point(102, 8)
            Me.btnExcel.Name = "btnExcel"
            Me.btnExcel.Size = New System.Drawing.Size(93, 30)
            Me.btnExcel.TabIndex = 299
            Me.btnExcel.Values.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExcel.Values.Text = "Excel"
            '
            'kcmExcelMenu
            '
            Me.kcmExcelMenu.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuItems2})
            '
            'KryptonContextMenuItems2
            '
            Me.KryptonContextMenuItems2.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuItem1, Me.KryptonContextMenuItem2, Me.KryptonContextMenuItem3})
            '
            'KryptonContextMenuItem1
            '
            Me.KryptonContextMenuItem1.Text = "General"
            '
            'KryptonContextMenuItem2
            '
            Me.KryptonContextMenuItem2.Text = "Ingresos"
            '
            'KryptonContextMenuItem3
            '
            Me.KryptonContextMenuItem3.Text = "Egresos"
            '
            'btnReporteNew
            '
            Me.btnReporteNew.AutoSize = True
            Me.btnReporteNew.Location = New System.Drawing.Point(202, 8)
            Me.btnReporteNew.Name = "btnReporteNew"
            Me.btnReporteNew.Size = New System.Drawing.Size(93, 30)
            Me.btnReporteNew.TabIndex = 298
            Me.btnReporteNew.Values.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporteNew.Values.Text = "Reporte"
            '
            'btnCargar
            '
            Me.btnCargar.AutoSize = True
            Me.btnCargar.Location = New System.Drawing.Point(7, 8)
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(88, 30)
            Me.btnCargar.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft
            Me.btnCargar.TabIndex = 294
            Me.btnCargar.Values.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCargar.Values.Text = "Cargar"
            '
            'KryptonPage3
            '
            Me.KryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage3.Controls.Add(Me.dgvPresupuesto)
            Me.KryptonPage3.Controls.Add(Me.KryptonGroupBox5)
            Me.KryptonPage3.Flags = 65534
            Me.KryptonPage3.LastVisibleSet = True
            Me.KryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage3.Name = "KryptonPage3"
            Me.KryptonPage3.Size = New System.Drawing.Size(817, 641)
            Me.KryptonPage3.Text = "Presupuesto"
            Me.KryptonPage3.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage3.UniqueName = "BF4127518BD649E68E974F94B79053EE"
            '
            'dgvPresupuesto
            '
            Me.dgvPresupuesto.AllowUserToAddRows = False
            Me.dgvPresupuesto.AllowUserToDeleteRows = False
            Me.dgvPresupuesto.AllowUserToOrderColumns = True
            Me.dgvPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPresupuesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nodoComPresupuesto})
            Me.dgvPresupuesto.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Sheet
            Me.dgvPresupuesto.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
            Me.dgvPresupuesto.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet
            Me.dgvPresupuesto.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet
            Me.dgvPresupuesto.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet
            Me.dgvPresupuesto.Location = New System.Drawing.Point(9, 86)
            Me.dgvPresupuesto.Name = "dgvPresupuesto"
            Me.dgvPresupuesto.RowHeadersVisible = False
            Me.dgvPresupuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPresupuesto.Size = New System.Drawing.Size(795, 544)
            Me.dgvPresupuesto.StateNormal.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvPresupuesto.TabIndex = 253
            '
            'KryptonGroupBox5
            '
            Me.KryptonGroupBox5.CaptionOverlap = 0R
            Me.KryptonGroupBox5.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox5.Location = New System.Drawing.Point(7, 13)
            Me.KryptonGroupBox5.Name = "KryptonGroupBox5"
            '
            'KryptonGroupBox5.Panel
            '
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.btnCargarPresupuesto)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.btnExportarPresupuesto)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.dtpFechaDesdePresupuesto)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.dtpFechaHastaPresupuesto)
            Me.KryptonGroupBox5.Size = New System.Drawing.Size(799, 69)
            Me.KryptonGroupBox5.TabIndex = 231
            Me.KryptonGroupBox5.Values.Heading = "Busqueda"
            Me.KryptonGroupBox5.Values.Image = Global.syscisepro.My.Resources.Resources.calendar_month_24dp_FILL0_wght400_GRAD0_opsz24__2_
            '
            'btnCargarPresupuesto
            '
            Me.btnCargarPresupuesto.AutoSize = True
            Me.btnCargarPresupuesto.Location = New System.Drawing.Point(7, 1)
            Me.btnCargarPresupuesto.Name = "btnCargarPresupuesto"
            Me.btnCargarPresupuesto.Size = New System.Drawing.Size(88, 30)
            Me.btnCargarPresupuesto.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft
            Me.btnCargarPresupuesto.TabIndex = 295
            Me.btnCargarPresupuesto.Values.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCargarPresupuesto.Values.Text = "Cargar"
            '
            'btnExportarPresupuesto
            '
            Me.btnExportarPresupuesto.Location = New System.Drawing.Point(680, 5)
            Me.btnExportarPresupuesto.Name = "btnExportarPresupuesto"
            Me.btnExportarPresupuesto.Size = New System.Drawing.Size(30, 30)
            Me.btnExportarPresupuesto.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.[False]
            Me.btnExportarPresupuesto.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.[False]
            Me.btnExportarPresupuesto.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.btnExportarPresupuesto.TabIndex = 234
            Me.btnExportarPresupuesto.Values.ImageStates.ImageCheckedNormal = Nothing
            Me.btnExportarPresupuesto.Values.ImageStates.ImageCheckedPressed = Nothing
            Me.btnExportarPresupuesto.Values.ImageStates.ImageCheckedTracking = Nothing
            Me.btnExportarPresupuesto.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarPresupuesto.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarPresupuesto.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarPresupuesto.Values.Text = ""
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(256, 8)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel12.TabIndex = 231
            Me.KryptonLabel12.Values.Text = "Hasta"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(111, 7)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel13.TabIndex = 230
            Me.KryptonLabel13.Values.Text = "Desde"
            '
            'dtpFechaDesdePresupuesto
            '
            Me.dtpFechaDesdePresupuesto.AlwaysActive = False
            Me.dtpFechaDesdePresupuesto.CalendarTodayDate = New Date(2025, 2, 4, 0, 0, 0, 0)
            Me.dtpFechaDesdePresupuesto.CustomFormat = "MMMM - yyyy"
            Me.dtpFechaDesdePresupuesto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesdePresupuesto.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
            Me.dtpFechaDesdePresupuesto.Location = New System.Drawing.Point(162, 5)
            Me.dtpFechaDesdePresupuesto.Name = "dtpFechaDesdePresupuesto"
            Me.dtpFechaDesdePresupuesto.Size = New System.Drawing.Size(85, 21)
            Me.dtpFechaDesdePresupuesto.TabIndex = 228
            '
            'dtpFechaHastaPresupuesto
            '
            Me.dtpFechaHastaPresupuesto.AlwaysActive = False
            Me.dtpFechaHastaPresupuesto.CalendarTodayDate = New Date(2025, 2, 4, 0, 0, 0, 0)
            Me.dtpFechaHastaPresupuesto.CustomFormat = "MMMM - yyyy"
            Me.dtpFechaHastaPresupuesto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHastaPresupuesto.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
            Me.dtpFechaHastaPresupuesto.Location = New System.Drawing.Point(303, 4)
            Me.dtpFechaHastaPresupuesto.Name = "dtpFechaHastaPresupuesto"
            Me.dtpFechaHastaPresupuesto.Size = New System.Drawing.Size(86, 21)
            Me.dtpFechaHastaPresupuesto.TabIndex = 229
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.btnCuztomize)
            Me.KryptonPage2.Controls.Add(Me.dgvComparacion)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox4)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(817, 641)
            Me.KryptonPage2.Text = "Comparativo"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "0DF740431DB546AAFB85B2916D7DE92D"
            '
            'btnCuztomize
            '
            Me.btnCuztomize.Location = New System.Drawing.Point(126, 13)
            Me.btnCuztomize.Name = "btnCuztomize"
            Me.btnCuztomize.Size = New System.Drawing.Size(130, 23)
            Me.btnCuztomize.TabIndex = 255
            Me.btnCuztomize.Values.Text = "Personalizar Reporte"
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
            Me.dgvComparacion.Location = New System.Drawing.Point(11, 85)
            Me.dgvComparacion.Name = "dgvComparacion"
            Me.dgvComparacion.RowHeadersVisible = False
            Me.dgvComparacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComparacion.Size = New System.Drawing.Size(795, 544)
            Me.dgvComparacion.StateNormal.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvComparacion.TabIndex = 252
            '
            'nodoCom
            '
            Me.nodoCom.HeaderText = "+"
            Me.nodoCom.Name = "nodoCom"
            Me.nodoCom.Width = 30
            '
            'KryptonGroupBox4
            '
            Me.KryptonGroupBox4.CaptionOverlap = 0R
            Me.KryptonGroupBox4.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox4.Location = New System.Drawing.Point(7, 10)
            Me.KryptonGroupBox4.Name = "KryptonGroupBox4"
            '
            'KryptonGroupBox4.Panel
            '
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.chkOcultar)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.btnExportarComparacion)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cbxDates)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cbxShowColumns)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dtpFechaDesdeMes)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dtpFechaHastaMes)
            Me.KryptonGroupBox4.Size = New System.Drawing.Size(799, 69)
            Me.KryptonGroupBox4.TabIndex = 230
            Me.KryptonGroupBox4.Values.Heading = "Busqueda"
            Me.KryptonGroupBox4.Values.Image = Global.syscisepro.My.Resources.Resources.calendar_month_24dp_FILL0_wght400_GRAD0_opsz24__2_
            '
            'chkOcultar
            '
            Me.chkOcultar.Images.CheckedNormal = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
            Me.chkOcultar.Images.CheckedPressed = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
            Me.chkOcultar.Images.CheckedTracking = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
            Me.chkOcultar.Location = New System.Drawing.Point(561, 11)
            Me.chkOcultar.Name = "chkOcultar"
            Me.chkOcultar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
            Me.chkOcultar.Size = New System.Drawing.Size(91, 18)
            Me.chkOcultar.StateCommon.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkOcultar.TabIndex = 252
            Me.chkOcultar.Values.Text = "Quitar $0.00"
            '
            'btnExportarComparacion
            '
            Me.btnExportarComparacion.Location = New System.Drawing.Point(680, 3)
            Me.btnExportarComparacion.Name = "btnExportarComparacion"
            Me.btnExportarComparacion.Size = New System.Drawing.Size(30, 30)
            Me.btnExportarComparacion.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.[False]
            Me.btnExportarComparacion.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.[False]
            Me.btnExportarComparacion.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.btnExportarComparacion.TabIndex = 234
            Me.btnExportarComparacion.Values.ImageStates.ImageCheckedNormal = Nothing
            Me.btnExportarComparacion.Values.ImageStates.ImageCheckedPressed = Nothing
            Me.btnExportarComparacion.Values.ImageStates.ImageCheckedTracking = Nothing
            Me.btnExportarComparacion.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarComparacion.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarComparacion.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarComparacion.Values.Text = ""
            '
            'cbxDates
            '
            Me.cbxDates.AlwaysActive = False
            Me.cbxDates.DropDownWidth = 150
            Me.cbxDates.Items.AddRange(New Object() {"Mensual", "Trimestral", "Semestral", "Anual ", "Personalizado"})
            Me.cbxDates.Location = New System.Drawing.Point(10, 8)
            Me.cbxDates.Name = "cbxDates"
            Me.cbxDates.Size = New System.Drawing.Size(76, 21)
            Me.cbxDates.TabIndex = 233
            Me.cbxDates.Text = "Fechas"
            '
            'cbxShowColumns
            '
            Me.cbxShowColumns.AlwaysActive = False
            Me.cbxShowColumns.DropDownWidth = 121
            Me.cbxShowColumns.IntegralHeight = False
            Me.cbxShowColumns.Items.AddRange(New Object() {"Mensual", "Trimestral", "Semestral", "Anual"})
            Me.cbxShowColumns.Location = New System.Drawing.Point(409, 8)
            Me.cbxShowColumns.Name = "cbxShowColumns"
            Me.cbxShowColumns.Size = New System.Drawing.Size(131, 21)
            Me.cbxShowColumns.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
            Me.cbxShowColumns.TabIndex = 232
            Me.cbxShowColumns.Text = "Ordenar Columnas"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(256, 8)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel11.TabIndex = 231
            Me.KryptonLabel11.Values.Text = "Hasta"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(111, 8)
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
            Me.dtpFechaDesdeMes.Location = New System.Drawing.Point(162, 8)
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
            Me.dtpFechaHastaMes.Location = New System.Drawing.Point(303, 8)
            Me.dtpFechaHastaMes.Name = "dtpFechaHastaMes"
            Me.dtpFechaHastaMes.Size = New System.Drawing.Size(86, 21)
            Me.dtpFechaHastaMes.TabIndex = 229
            '
            'KryptonRibbonGroupButton1
            '
            Me.KryptonRibbonGroupButton1.ImageLarge = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.KryptonRibbonGroupButton1.TextLine1 = "Cargar"
            '
            'KryptonRibbonGroupButton2
            '
            Me.KryptonRibbonGroupButton2.ImageLarge = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.KryptonRibbonGroupButton2.TextLine1 = "General"
            '
            'KryptonRibbonGroupButton3
            '
            Me.KryptonRibbonGroupButton3.ImageLarge = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            '
            'KryptonRibbonGroupTriple1
            '
            Me.KryptonRibbonGroupTriple1.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.KryptonRibbonGroupButton1, Me.KryptonRibbonGroupButton2, Me.KryptonRibbonGroupButton3})
            '
            'KryptonRibbonGroup1
            '
            Me.KryptonRibbonGroup1.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer() {Me.KryptonRibbonGroupTriple1})
            '
            'nodoComPresupuesto
            '
            Me.nodoComPresupuesto.HeaderText = "+"
            Me.nodoComPresupuesto.Name = "nodoComPresupuesto"
            Me.nodoComPresupuesto.Width = 25
            '
            'FormEstadoPerdidasYGanancias
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(819, 670)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormEstadoPerdidasYGanancias"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ESTADO DE PERDIDAS Y GANANCIAS"
            CType(Me.dgvEgresos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
            Me.ContextMenuStripClicDerechoEgresos.ResumeLayout(False)
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            Me.KryptonGroupBox2.Panel.PerformLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            Me.KryptonGroupBox3.Panel.PerformLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            Me.KryptonPage1.PerformLayout()
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage3.ResumeLayout(False)
            CType(Me.dgvPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.Panel.ResumeLayout(False)
            Me.KryptonGroupBox5.Panel.PerformLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.ResumeLayout(False)
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            CType(Me.dgvComparacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.Panel.ResumeLayout(False)
            Me.KryptonGroupBox4.Panel.PerformLayout()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.ResumeLayout(False)
            CType(Me.cbxDates, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbxShowColumns, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgvIngresos As System.Windows.Forms.DataGridView
        Friend WithEvents dgvEgresos As System.Windows.Forms.DataGridView
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents tsmOcultar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmMostrar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ContextMenuStripClicDerechoEgresos As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents tsmOcultarEgresos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmMostrarEgresos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtAcreedorEgresos As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudorEgresos As System.Windows.Forms.TextBox
        Friend WithEvents txtAcreedorIngresos As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudorIngresos As System.Windows.Forms.TextBox
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents txtEgresos As System.Windows.Forms.TextBox
        Friend WithEvents txtIngresos As System.Windows.Forms.TextBox
        Friend WithEvents nodoEgreso As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents nodo As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents cbNivel As System.Windows.Forms.ComboBox
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents dtpFechaDesdeMes As Krypton.Toolkit.KryptonDateTimePicker
        Friend WithEvents dtpFechaHastaMes As Krypton.Toolkit.KryptonDateTimePicker
        Friend WithEvents KryptonGroupBox4 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents dgvComparacion As Krypton.Toolkit.KryptonDataGridView
        Friend WithEvents cbxShowColumns As Krypton.Toolkit.KryptonComboBox
        Friend WithEvents KryptonRibbonGroupButton1 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Friend WithEvents KryptonRibbonGroupButton2 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Friend WithEvents KryptonRibbonGroupButton3 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
        Friend WithEvents KryptonRibbonGroupTriple1 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
        Friend WithEvents KryptonRibbonGroup1 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
        Friend WithEvents cbxDates As ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Friend WithEvents btnCargar As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents btnReporteNew As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents btnExcel As ComponentFactory.Krypton.Toolkit.KryptonDropButton
        Friend WithEvents kcmExcelMenu As ComponentFactory.Krypton.Toolkit.KryptonContextMenu
        Friend WithEvents KryptonContextMenuItems2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
        Friend WithEvents KryptonContextMenuItem1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
        Friend WithEvents KryptonContextMenuItem2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
        Friend WithEvents KryptonContextMenuItem3 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
        Friend WithEvents KryptonContextMenuItems1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
        Friend WithEvents btnCuztomize As Krypton.Toolkit.KryptonButton
        Friend WithEvents btnExportarComparacion As Krypton.Toolkit.KryptonButton
        Friend WithEvents nodoCom As Krypton.Toolkit.KryptonDataGridViewButtonColumn
        Friend WithEvents chkOcultar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Friend WithEvents KryptonPage3 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox5 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents btnExportarPresupuesto As Krypton.Toolkit.KryptonButton
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents dtpFechaDesdePresupuesto As Krypton.Toolkit.KryptonDateTimePicker
        Friend WithEvents dtpFechaHastaPresupuesto As Krypton.Toolkit.KryptonDateTimePicker
        Friend WithEvents btnCargarPresupuesto As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents dgvPresupuesto As Krypton.Toolkit.KryptonDataGridView
        Friend WithEvents nodoComPresupuesto As DataGridViewTextBoxColumn
    End Class
End Namespace