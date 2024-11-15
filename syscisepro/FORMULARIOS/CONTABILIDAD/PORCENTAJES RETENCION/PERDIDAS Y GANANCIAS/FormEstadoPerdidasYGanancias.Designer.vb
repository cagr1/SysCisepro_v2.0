Namespace FORMULARIOS.CONTABILIDAD.PERDIDAS_Y_GANANCIAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormEstadoPerdidasYGanancias
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
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscarMensual = New System.Windows.Forms.ToolStripMenuItem()
            Me.Button1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            Me.ContextMenuStripClicDerechoEgresos.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
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
            Me.SuspendLayout()
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.White
            Me.txtTotal.Enabled = False
            Me.txtTotal.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtTotal.Location = New System.Drawing.Point(635, 0)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(119, 27)
            Me.txtTotal.TabIndex = 282
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer))
            Me.Label22.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label22.Location = New System.Drawing.Point(488, 6)
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
            Me.txtEgresos.Location = New System.Drawing.Point(531, 203)
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
            Me.txtIngresos.Location = New System.Drawing.Point(536, 209)
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
            Me.txtAcreedorEgresos.Location = New System.Drawing.Point(258, 203)
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
            Me.txtDeudorEgresos.Location = New System.Drawing.Point(78, 203)
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
            Me.txtAcreedorIngresos.Location = New System.Drawing.Point(263, 209)
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
            Me.txtDeudorIngresos.Location = New System.Drawing.Point(83, 209)
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
            Me.dgvIngresos.Size = New System.Drawing.Size(757, 206)
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
            Me.dtpFechaDesde.Location = New System.Drawing.Point(60, 3)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(163, 21)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Location = New System.Drawing.Point(285, 4)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(160, 21)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'ContextMenuStripClicDerecho
            '
            Me.ContextMenuStripClicDerecho.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmOcultar, Me.tsmMostrar})
            Me.ContextMenuStripClicDerecho.Name = "ContextMenuStripClicDerecho"
            Me.ContextMenuStripClicDerecho.Size = New System.Drawing.Size(129, 48)
            '
            'tsmOcultar
            '
            Me.tsmOcultar.Name = "tsmOcultar"
            Me.tsmOcultar.Size = New System.Drawing.Size(128, 22)
            Me.tsmOcultar.Text = "OCULTAR"
            '
            'tsmMostrar
            '
            Me.tsmMostrar.Name = "tsmMostrar"
            Me.tsmMostrar.Size = New System.Drawing.Size(128, 22)
            Me.tsmMostrar.Text = "MOSTRAR"
            '
            'ContextMenuStripClicDerechoEgresos
            '
            Me.ContextMenuStripClicDerechoEgresos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmOcultarEgresos, Me.tsmMostrarEgresos})
            Me.ContextMenuStripClicDerechoEgresos.Name = "ContextMenuStripClicDerecho"
            Me.ContextMenuStripClicDerechoEgresos.Size = New System.Drawing.Size(129, 48)
            '
            'tsmOcultarEgresos
            '
            Me.tsmOcultarEgresos.Name = "tsmOcultarEgresos"
            Me.tsmOcultarEgresos.Size = New System.Drawing.Size(128, 22)
            Me.tsmOcultarEgresos.Text = "OCULTAR"
            '
            'tsmMostrarEgresos
            '
            Me.tsmMostrarEgresos.Name = "tsmMostrarEgresos"
            Me.tsmMostrarEgresos.Size = New System.Drawing.Size(128, 22)
            Me.tsmMostrarEgresos.Text = "MOSTRAR"
            '
            'cbNivel
            '
            Me.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarMensual, Me.Button1, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(791, 32)
            Me.MenuStrip1.TabIndex = 290
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscarMensual
            '
            Me.btnBuscarMensual.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarMensual.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscarMensual.Name = "btnBuscarMensual"
            Me.btnBuscarMensual.Size = New System.Drawing.Size(89, 28)
            Me.btnBuscarMensual.Text = "CARGAR"
            '
            'Button1
            '
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(93, 28)
            Me.Button1.Text = "GENERAL"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(97, 28)
            Me.ToolStripMenuItem1.Text = "INGRESOS"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(91, 28)
            Me.ToolStripMenuItem2.Text = "EGRESOS"
            '
            'btnReporte
            '
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(90, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(4, 35)
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
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(783, 57)
            Me.KryptonGroupBox1.TabIndex = 291
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(9, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Desde"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(236, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel2.TabIndex = 1
            Me.KryptonLabel2.Values.Text = "Hasta"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(451, 3)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel3.TabIndex = 2
            Me.KryptonLabel3.Values.Text = "Niveles"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(5, 96)
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
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(782, 262)
            Me.KryptonGroupBox2.TabIndex = 292
            Me.KryptonGroupBox2.Values.Heading = "Ingresos"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(26, 209)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(51, 20)
            Me.KryptonLabel4.TabIndex = 1
            Me.KryptonLabel4.Values.Text = "Deudor"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(197, 209)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel5.TabIndex = 270
            Me.KryptonLabel5.Values.Text = "Acreedor"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl
            Me.KryptonLabel6.Location = New System.Drawing.Point(426, 209)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(75, 24)
            Me.KryptonLabel6.StateNormal.LongText.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.KryptonLabel6.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.KryptonLabel6.TabIndex = 271
            Me.KryptonLabel6.Values.Text = "Ingresos"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(5, 366)
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
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(782, 262)
            Me.KryptonGroupBox3.TabIndex = 293
            Me.KryptonGroupBox3.Values.Heading = "Egresos"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
            Me.KryptonLabel7.Location = New System.Drawing.Point(426, 209)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(71, 24)
            Me.KryptonLabel7.StateNormal.LongText.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.KryptonLabel7.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.KryptonLabel7.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
            'FormEstadoPerdidasYGanancias
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(791, 640)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.txtTotal)
            Me.Controls.Add(Me.Label22)
            Me.Controls.Add(Me.MenuStrip1)
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
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
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
            Me.ResumeLayout(False)
            Me.PerformLayout()

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
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscarMensual As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Button1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
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
    End Class
End Namespace