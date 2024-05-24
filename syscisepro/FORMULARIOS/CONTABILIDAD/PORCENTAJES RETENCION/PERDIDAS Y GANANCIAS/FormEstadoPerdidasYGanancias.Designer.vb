Namespace FORMULARIOS.CONTABILIDAD.PERDIDAS_Y_GANANCIAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormEstadoPerdidasYGanancias
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
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtIngresos = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.txtAcreedorEgresos = New System.Windows.Forms.TextBox()
            Me.txtDeudorEgresos = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtAcreedorIngresos = New System.Windows.Forms.TextBox()
            Me.txtDeudorIngresos = New System.Windows.Forms.TextBox()
            Me.dgvEgresos = New System.Windows.Forms.DataGridView()
            Me.nodoEgreso = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.dgvIngresos = New System.Windows.Forms.DataGridView()
            Me.nodo = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ContextMenuStripClicDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.tsmOcultar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmMostrar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ContextMenuStripClicDerechoEgresos = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.tsmOcultarEgresos = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmMostrarEgresos = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbNivel = New System.Windows.Forms.ComboBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscarMensual = New System.Windows.Forms.ToolStripMenuItem()
            Me.Button1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            Me.ContextMenuStripClicDerechoEgresos.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.White
            Me.txtTotal.Enabled = False
            Me.txtTotal.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtTotal.Location = New System.Drawing.Point(859, -2)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(154, 26)
            Me.txtTotal.TabIndex = 282
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(664, 3)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(189, 19)
            Me.Label22.TabIndex = 281
            Me.Label22.Text = "(INGRESOS - EGRESOS)"
            '
            'txtEgresos
            '
            Me.txtEgresos.BackColor = System.Drawing.Color.White
            Me.txtEgresos.Enabled = False
            Me.txtEgresos.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEgresos.Location = New System.Drawing.Point(870, 558)
            Me.txtEgresos.Name = "txtEgresos"
            Me.txtEgresos.Size = New System.Drawing.Size(139, 26)
            Me.txtEgresos.TabIndex = 279
            Me.txtEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.Label20.Location = New System.Drawing.Point(774, 263)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(90, 22)
            Me.Label20.TabIndex = 278
            Me.Label20.Text = "INGRESOS"
            '
            'txtIngresos
            '
            Me.txtIngresos.BackColor = System.Drawing.Color.White
            Me.txtIngresos.Enabled = False
            Me.txtIngresos.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIngresos.Location = New System.Drawing.Point(870, 262)
            Me.txtIngresos.Name = "txtIngresos"
            Me.txtIngresos.Size = New System.Drawing.Size(139, 26)
            Me.txtIngresos.TabIndex = 277
            Me.txtIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label18.Location = New System.Drawing.Point(599, 562)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(55, 13)
            Me.Label18.TabIndex = 276
            Me.Label18.Text = "ACREEDOR"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label19.Location = New System.Drawing.Point(428, 562)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(43, 13)
            Me.Label19.TabIndex = 275
            Me.Label19.Text = "DEUDOR"
            '
            'txtAcreedorEgresos
            '
            Me.txtAcreedorEgresos.BackColor = System.Drawing.Color.White
            Me.txtAcreedorEgresos.Enabled = False
            Me.txtAcreedorEgresos.Location = New System.Drawing.Point(660, 559)
            Me.txtAcreedorEgresos.Name = "txtAcreedorEgresos"
            Me.txtAcreedorEgresos.Size = New System.Drawing.Size(88, 20)
            Me.txtAcreedorEgresos.TabIndex = 274
            Me.txtAcreedorEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudorEgresos
            '
            Me.txtDeudorEgresos.BackColor = System.Drawing.Color.White
            Me.txtDeudorEgresos.Enabled = False
            Me.txtDeudorEgresos.Location = New System.Drawing.Point(477, 559)
            Me.txtDeudorEgresos.Name = "txtDeudorEgresos"
            Me.txtDeudorEgresos.Size = New System.Drawing.Size(88, 20)
            Me.txtDeudorEgresos.TabIndex = 273
            Me.txtDeudorEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label2.Location = New System.Drawing.Point(596, 266)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(55, 13)
            Me.Label2.TabIndex = 272
            Me.Label2.Text = "ACREEDOR"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label3.Location = New System.Drawing.Point(434, 266)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(43, 13)
            Me.Label3.TabIndex = 271
            Me.Label3.Text = "DEUDOR"
            '
            'txtAcreedorIngresos
            '
            Me.txtAcreedorIngresos.BackColor = System.Drawing.Color.White
            Me.txtAcreedorIngresos.Enabled = False
            Me.txtAcreedorIngresos.Location = New System.Drawing.Point(657, 263)
            Me.txtAcreedorIngresos.Name = "txtAcreedorIngresos"
            Me.txtAcreedorIngresos.Size = New System.Drawing.Size(88, 20)
            Me.txtAcreedorIngresos.TabIndex = 270
            Me.txtAcreedorIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudorIngresos
            '
            Me.txtDeudorIngresos.BackColor = System.Drawing.Color.White
            Me.txtDeudorIngresos.Enabled = False
            Me.txtDeudorIngresos.Location = New System.Drawing.Point(483, 263)
            Me.txtDeudorIngresos.Name = "txtDeudorIngresos"
            Me.txtDeudorIngresos.Size = New System.Drawing.Size(88, 20)
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
            Me.dgvEgresos.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvEgresos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvEgresos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nodoEgreso})
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvEgresos.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvEgresos.Location = New System.Drawing.Point(0, 307)
            Me.dgvEgresos.Name = "dgvEgresos"
            Me.dgvEgresos.ReadOnly = True
            Me.dgvEgresos.RowHeadersVisible = False
            Me.dgvEgresos.RowHeadersWidth = 26
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvEgresos.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvEgresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvEgresos.Size = New System.Drawing.Size(1009, 250)
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
            Me.dgvIngresos.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvIngresos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvIngresos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nodo})
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvIngresos.DefaultCellStyle = DataGridViewCellStyle9
            Me.dgvIngresos.Location = New System.Drawing.Point(0, 11)
            Me.dgvIngresos.Name = "dgvIngresos"
            Me.dgvIngresos.ReadOnly = True
            Me.dgvIngresos.RowHeadersVisible = False
            Me.dgvIngresos.RowHeadersWidth = 26
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvIngresos.RowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvIngresos.Size = New System.Drawing.Size(1009, 250)
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
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Location = New System.Drawing.Point(36, 13)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(251, 20)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Location = New System.Drawing.Point(349, 10)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(251, 20)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(323, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(25, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "AL:"
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
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cbNivel)
            Me.GroupBox1.Controls.Add(Me.Label23)
            Me.GroupBox1.Controls.Add(Me.dtpFechaDesde)
            Me.GroupBox1.Controls.Add(Me.dtpFechaHasta)
            Me.GroupBox1.Controls.Add(Me.chkTodos)
            Me.GroupBox1.Controls.Add(Me.Label24)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(1, 30)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1009, 36)
            Me.GroupBox1.TabIndex = 118
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "FILTRAR DATOS"
            '
            'cbNivel
            '
            Me.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbNivel.FormattingEnabled = True
            Me.cbNivel.Items.AddRange(New Object() {" -- TODOS --", "1", "2", "3", "4", "5", "6"})
            Me.cbNivel.Location = New System.Drawing.Point(707, 10)
            Me.cbNivel.Name = "cbNivel"
            Me.cbNivel.Size = New System.Drawing.Size(121, 21)
            Me.cbNivel.TabIndex = 232
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Location = New System.Drawing.Point(652, 13)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(49, 13)
            Me.Label23.TabIndex = 117
            Me.Label23.Text = "Niveles"
            '
            'chkTodos
            '
            Me.chkTodos.Location = New System.Drawing.Point(870, 12)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(119, 16)
            Me.chkTodos.TabIndex = 229
            Me.chkTodos.Text = "Quitar $0.0"
            Me.chkTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkTodos.UseVisualStyleBackColor = True
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(7, 16)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(31, 13)
            Me.Label24.TabIndex = 230
            Me.Label24.Text = "DEL:"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.Label21)
            Me.GroupBox3.Controls.Add(Me.txtEgresos)
            Me.GroupBox3.Controls.Add(Me.dgvIngresos)
            Me.GroupBox3.Controls.Add(Me.Label20)
            Me.GroupBox3.Controls.Add(Me.dgvEgresos)
            Me.GroupBox3.Controls.Add(Me.txtIngresos)
            Me.GroupBox3.Controls.Add(Me.Label18)
            Me.GroupBox3.Controls.Add(Me.Label19)
            Me.GroupBox3.Controls.Add(Me.txtAcreedorEgresos)
            Me.GroupBox3.Controls.Add(Me.txtDeudorEgresos)
            Me.GroupBox3.Controls.Add(Me.Label2)
            Me.GroupBox3.Controls.Add(Me.Label3)
            Me.GroupBox3.Controls.Add(Me.txtAcreedorIngresos)
            Me.GroupBox3.Controls.Add(Me.txtDeudorIngresos)
            Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(1, 62)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(1012, 591)
            Me.GroupBox3.TabIndex = 231
            Me.GroupBox3.TabStop = False
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.ForeColor = System.Drawing.Color.Maroon
            Me.Label21.Location = New System.Drawing.Point(784, 559)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(80, 22)
            Me.Label21.TabIndex = 280
            Me.Label21.Text = "EGRESOS"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarMensual, Me.Button1, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1013, 24)
            Me.MenuStrip1.TabIndex = 290
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscarMensual
            '
            Me.btnBuscarMensual.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscarMensual.Name = "btnBuscarMensual"
            Me.btnBuscarMensual.Size = New System.Drawing.Size(81, 20)
            Me.btnBuscarMensual.Text = "CARGAR"
            '
            'Button1
            '
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(143, 20)
            Me.Button1.Text = "EXPORTAR GENERAL"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(89, 20)
            Me.ToolStripMenuItem1.Text = "INGRESOS"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(83, 20)
            Me.ToolStripMenuItem2.Text = "EGRESOS"
            '
            'btnReporte
            '
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.report
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(82, 20)
            Me.btnReporte.Text = "REPORTE"
            '
            'FormEstadoPerdidasYGanancias
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1013, 652)
            Me.Controls.Add(Me.txtTotal)
            Me.Controls.Add(Me.Label22)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.GroupBox3)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormEstadoPerdidasYGanancias"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ESTADO DE PERDIDAS Y GANANCIAS"
            CType(Me.dgvEgresos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
            Me.ContextMenuStripClicDerechoEgresos.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvIngresos As System.Windows.Forms.DataGridView
        Friend WithEvents dgvEgresos As System.Windows.Forms.DataGridView
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents tsmOcultar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmMostrar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ContextMenuStripClicDerechoEgresos As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents tsmOcultarEgresos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmMostrarEgresos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents txtAcreedorEgresos As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudorEgresos As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtAcreedorIngresos As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudorIngresos As System.Windows.Forms.TextBox
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents txtEgresos As System.Windows.Forms.TextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtIngresos As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents nodoEgreso As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents nodo As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents cbNivel As System.Windows.Forms.ComboBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscarMensual As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Button1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label21 As System.Windows.Forms.Label
    End Class
End Namespace