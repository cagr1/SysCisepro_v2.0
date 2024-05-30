Namespace FORMULARIOS.CONTABILIDAD.LIQUIDACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormRevisionLiquidaciones
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
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRevisionLiquidaciones))
            Me.gbLiquidacion = New System.Windows.Forms.GroupBox()
            Me.txtIdLiquidacion = New System.Windows.Forms.Label()
            Me.lblFechaLiquidacionFondoRotativo = New System.Windows.Forms.Label()
            Me.lblTotalLiquidacionFondoRotativo = New System.Windows.Forms.Label()
            Me.txtReposicionLiquidacion = New System.Windows.Forms.TextBox()
            Me.lblFondoLiquidacion = New System.Windows.Forms.Label()
            Me.txtSaldoLiquidacion = New System.Windows.Forms.TextBox()
            Me.lblGastosLiquidacion = New System.Windows.Forms.Label()
            Me.txtGastosLiquidacion = New System.Windows.Forms.TextBox()
            Me.lblSaldoLiquidacion = New System.Windows.Forms.Label()
            Me.txtFondoLiquidacion = New System.Windows.Forms.TextBox()
            Me.lblReposicionLiquidacion = New System.Windows.Forms.Label()
            Me.txtTotalLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtFechaLiquidacion = New System.Windows.Forms.TextBox()
            Me.dgvSolicitudFondoRotativo = New System.Windows.Forms.DataGridView()
            Me.CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.dgvLiquidacionesPendientes = New System.Windows.Forms.DataGridView()
            Me.chkSeleccionarTodo = New System.Windows.Forms.CheckBox()
            Me.chkSeleccionarTodoNoDeducibles = New System.Windows.Forms.CheckBox()
            Me.dgvSolicitudFonoRotativoNoDeducible = New System.Windows.Forms.DataGridView()
            Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.gbNoDeducibles = New System.Windows.Forms.GroupBox()
            Me.lblNoDeducibles = New System.Windows.Forms.Label()
            Me.gbDeducibles = New System.Windows.Forms.GroupBox()
            Me.lblDeducibles = New System.Windows.Forms.Label()
            Me.dgvComprobanteCompra = New System.Windows.Forms.DataGridView()
            Me.dgvComprobanteRetencionCompra = New System.Windows.Forms.DataGridView()
            Me.dgvDetalleComprobanteRetencionCompra = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnRecargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAgregarDiarioNoDeducibles = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAgregarDiarioDeducibles = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnFinRevision = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbLiquidacion.SuspendLayout()
            CType(Me.dgvSolicitudFondoRotativo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvLiquidacionesPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvSolicitudFonoRotativoNoDeducible, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbNoDeducibles.SuspendLayout()
            Me.gbDeducibles.SuspendLayout()
            CType(Me.dgvComprobanteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbLiquidacion
            '
            Me.gbLiquidacion.BackColor = System.Drawing.Color.White
            Me.gbLiquidacion.Controls.Add(Me.txtIdLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.lblFechaLiquidacionFondoRotativo)
            Me.gbLiquidacion.Controls.Add(Me.lblTotalLiquidacionFondoRotativo)
            Me.gbLiquidacion.Controls.Add(Me.txtReposicionLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.lblFondoLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.txtSaldoLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.lblGastosLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.txtGastosLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.lblSaldoLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.txtFondoLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.lblReposicionLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.txtTotalLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.txtFechaLiquidacion)
            Me.gbLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbLiquidacion.Location = New System.Drawing.Point(2, 96)
            Me.gbLiquidacion.Name = "gbLiquidacion"
            Me.gbLiquidacion.Size = New System.Drawing.Size(909, 42)
            Me.gbLiquidacion.TabIndex = 19
            Me.gbLiquidacion.TabStop = False
            Me.gbLiquidacion.Text = "LIQUIDACION"
            '
            'txtIdLiquidacion
            '
            Me.txtIdLiquidacion.AutoSize = True
            Me.txtIdLiquidacion.Location = New System.Drawing.Point(79, 0)
            Me.txtIdLiquidacion.Name = "txtIdLiquidacion"
            Me.txtIdLiquidacion.Size = New System.Drawing.Size(16, 13)
            Me.txtIdLiquidacion.TabIndex = 1
            Me.txtIdLiquidacion.Text = "..."
            '
            'lblFechaLiquidacionFondoRotativo
            '
            Me.lblFechaLiquidacionFondoRotativo.AutoSize = True
            Me.lblFechaLiquidacionFondoRotativo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaLiquidacionFondoRotativo.Location = New System.Drawing.Point(12, 17)
            Me.lblFechaLiquidacionFondoRotativo.Name = "lblFechaLiquidacionFondoRotativo"
            Me.lblFechaLiquidacionFondoRotativo.Size = New System.Drawing.Size(44, 13)
            Me.lblFechaLiquidacionFondoRotativo.TabIndex = 2
            Me.lblFechaLiquidacionFondoRotativo.Text = "FECHA:"
            '
            'lblTotalLiquidacionFondoRotativo
            '
            Me.lblTotalLiquidacionFondoRotativo.AutoSize = True
            Me.lblTotalLiquidacionFondoRotativo.Location = New System.Drawing.Point(271, 17)
            Me.lblTotalLiquidacionFondoRotativo.Name = "lblTotalLiquidacionFondoRotativo"
            Me.lblTotalLiquidacionFondoRotativo.Size = New System.Drawing.Size(45, 13)
            Me.lblTotalLiquidacionFondoRotativo.TabIndex = 3
            Me.lblTotalLiquidacionFondoRotativo.Text = "TOTAL:"
            '
            'txtReposicionLiquidacion
            '
            Me.txtReposicionLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtReposicionLiquidacion.Enabled = False
            Me.txtReposicionLiquidacion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtReposicionLiquidacion.Location = New System.Drawing.Point(837, 13)
            Me.txtReposicionLiquidacion.Name = "txtReposicionLiquidacion"
            Me.txtReposicionLiquidacion.Size = New System.Drawing.Size(66, 20)
            Me.txtReposicionLiquidacion.TabIndex = 14
            Me.txtReposicionLiquidacion.Text = "0.00"
            Me.txtReposicionLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblFondoLiquidacion
            '
            Me.lblFondoLiquidacion.AutoSize = True
            Me.lblFondoLiquidacion.Location = New System.Drawing.Point(391, 17)
            Me.lblFondoLiquidacion.Name = "lblFondoLiquidacion"
            Me.lblFondoLiquidacion.Size = New System.Drawing.Size(47, 13)
            Me.lblFondoLiquidacion.TabIndex = 4
            Me.lblFondoLiquidacion.Text = "FONDO:"
            '
            'txtSaldoLiquidacion
            '
            Me.txtSaldoLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtSaldoLiquidacion.Enabled = False
            Me.txtSaldoLiquidacion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSaldoLiquidacion.Location = New System.Drawing.Point(686, 13)
            Me.txtSaldoLiquidacion.Name = "txtSaldoLiquidacion"
            Me.txtSaldoLiquidacion.Size = New System.Drawing.Size(66, 20)
            Me.txtSaldoLiquidacion.TabIndex = 13
            Me.txtSaldoLiquidacion.Text = "0.00"
            Me.txtSaldoLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblGastosLiquidacion
            '
            Me.lblGastosLiquidacion.AutoSize = True
            Me.lblGastosLiquidacion.Location = New System.Drawing.Point(511, 17)
            Me.lblGastosLiquidacion.Name = "lblGastosLiquidacion"
            Me.lblGastosLiquidacion.Size = New System.Drawing.Size(54, 13)
            Me.lblGastosLiquidacion.TabIndex = 5
            Me.lblGastosLiquidacion.Text = "GASTOS:"
            '
            'txtGastosLiquidacion
            '
            Me.txtGastosLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtGastosLiquidacion.Enabled = False
            Me.txtGastosLiquidacion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGastosLiquidacion.Location = New System.Drawing.Point(566, 14)
            Me.txtGastosLiquidacion.Name = "txtGastosLiquidacion"
            Me.txtGastosLiquidacion.Size = New System.Drawing.Size(65, 20)
            Me.txtGastosLiquidacion.TabIndex = 12
            Me.txtGastosLiquidacion.Text = "0.00"
            Me.txtGastosLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblSaldoLiquidacion
            '
            Me.lblSaldoLiquidacion.AutoSize = True
            Me.lblSaldoLiquidacion.Location = New System.Drawing.Point(637, 16)
            Me.lblSaldoLiquidacion.Name = "lblSaldoLiquidacion"
            Me.lblSaldoLiquidacion.Size = New System.Drawing.Size(45, 13)
            Me.lblSaldoLiquidacion.TabIndex = 6
            Me.lblSaldoLiquidacion.Text = "SALDO:"
            '
            'txtFondoLiquidacion
            '
            Me.txtFondoLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtFondoLiquidacion.Enabled = False
            Me.txtFondoLiquidacion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFondoLiquidacion.Location = New System.Drawing.Point(440, 14)
            Me.txtFondoLiquidacion.Name = "txtFondoLiquidacion"
            Me.txtFondoLiquidacion.Size = New System.Drawing.Size(65, 20)
            Me.txtFondoLiquidacion.TabIndex = 11
            Me.txtFondoLiquidacion.Text = "0.00"
            Me.txtFondoLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblReposicionLiquidacion
            '
            Me.lblReposicionLiquidacion.AutoSize = True
            Me.lblReposicionLiquidacion.Location = New System.Drawing.Point(758, 16)
            Me.lblReposicionLiquidacion.Name = "lblReposicionLiquidacion"
            Me.lblReposicionLiquidacion.Size = New System.Drawing.Size(74, 13)
            Me.lblReposicionLiquidacion.TabIndex = 7
            Me.lblReposicionLiquidacion.Text = "REPOSICION:"
            '
            'txtTotalLiquidacion
            '
            Me.txtTotalLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtTotalLiquidacion.Enabled = False
            Me.txtTotalLiquidacion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalLiquidacion.Location = New System.Drawing.Point(320, 14)
            Me.txtTotalLiquidacion.Name = "txtTotalLiquidacion"
            Me.txtTotalLiquidacion.Size = New System.Drawing.Size(65, 20)
            Me.txtTotalLiquidacion.TabIndex = 10
            Me.txtTotalLiquidacion.Text = "0.00"
            Me.txtTotalLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtFechaLiquidacion
            '
            Me.txtFechaLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtFechaLiquidacion.Enabled = False
            Me.txtFechaLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaLiquidacion.Location = New System.Drawing.Point(61, 14)
            Me.txtFechaLiquidacion.Name = "txtFechaLiquidacion"
            Me.txtFechaLiquidacion.Size = New System.Drawing.Size(178, 21)
            Me.txtFechaLiquidacion.TabIndex = 9
            '
            'dgvSolicitudFondoRotativo
            '
            Me.dgvSolicitudFondoRotativo.AllowUserToAddRows = False
            Me.dgvSolicitudFondoRotativo.AllowUserToDeleteRows = False
            Me.dgvSolicitudFondoRotativo.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvSolicitudFondoRotativo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvSolicitudFondoRotativo.BackgroundColor = System.Drawing.Color.White
            Me.dgvSolicitudFondoRotativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvSolicitudFondoRotativo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvSolicitudFondoRotativo.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvSolicitudFondoRotativo.Location = New System.Drawing.Point(6, 22)
            Me.dgvSolicitudFondoRotativo.MultiSelect = False
            Me.dgvSolicitudFondoRotativo.Name = "dgvSolicitudFondoRotativo"
            Me.dgvSolicitudFondoRotativo.RowHeadersVisible = False
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSolicitudFondoRotativo.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvSolicitudFondoRotativo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSolicitudFondoRotativo.Size = New System.Drawing.Size(897, 228)
            Me.dgvSolicitudFondoRotativo.TabIndex = 17
            '
            'CHK
            '
            Me.CHK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.CHK.HeaderText = "CHK"
            Me.CHK.Name = "CHK"
            Me.CHK.Width = 35
            '
            'dgvLiquidacionesPendientes
            '
            Me.dgvLiquidacionesPendientes.AllowUserToAddRows = False
            Me.dgvLiquidacionesPendientes.AllowUserToDeleteRows = False
            Me.dgvLiquidacionesPendientes.AllowUserToResizeRows = False
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvLiquidacionesPendientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvLiquidacionesPendientes.BackgroundColor = System.Drawing.Color.White
            Me.dgvLiquidacionesPendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvLiquidacionesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvLiquidacionesPendientes.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvLiquidacionesPendientes.Location = New System.Drawing.Point(0, 25)
            Me.dgvLiquidacionesPendientes.MultiSelect = False
            Me.dgvLiquidacionesPendientes.Name = "dgvLiquidacionesPendientes"
            Me.dgvLiquidacionesPendientes.RowHeadersVisible = False
            Me.dgvLiquidacionesPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLiquidacionesPendientes.Size = New System.Drawing.Size(910, 68)
            Me.dgvLiquidacionesPendientes.TabIndex = 22
            '
            'chkSeleccionarTodo
            '
            Me.chkSeleccionarTodo.AutoSize = True
            Me.chkSeleccionarTodo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkSeleccionarTodo.Location = New System.Drawing.Point(770, -1)
            Me.chkSeleccionarTodo.Name = "chkSeleccionarTodo"
            Me.chkSeleccionarTodo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.chkSeleccionarTodo.Size = New System.Drawing.Size(147, 17)
            Me.chkSeleccionarTodo.TabIndex = 23
            Me.chkSeleccionarTodo.Text = "MARCAR / DESMARCAR"
            Me.chkSeleccionarTodo.UseVisualStyleBackColor = True
            '
            'chkSeleccionarTodoNoDeducibles
            '
            Me.chkSeleccionarTodoNoDeducibles.AutoSize = True
            Me.chkSeleccionarTodoNoDeducibles.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkSeleccionarTodoNoDeducibles.Location = New System.Drawing.Point(771, -1)
            Me.chkSeleccionarTodoNoDeducibles.Name = "chkSeleccionarTodoNoDeducibles"
            Me.chkSeleccionarTodoNoDeducibles.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.chkSeleccionarTodoNoDeducibles.Size = New System.Drawing.Size(147, 17)
            Me.chkSeleccionarTodoNoDeducibles.TabIndex = 30
            Me.chkSeleccionarTodoNoDeducibles.Text = "MARCAR / DESMARCAR"
            Me.chkSeleccionarTodoNoDeducibles.UseVisualStyleBackColor = True
            '
            'dgvSolicitudFonoRotativoNoDeducible
            '
            Me.dgvSolicitudFonoRotativoNoDeducible.AllowUserToAddRows = False
            Me.dgvSolicitudFonoRotativoNoDeducible.AllowUserToDeleteRows = False
            Me.dgvSolicitudFonoRotativoNoDeducible.AllowUserToResizeRows = False
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvSolicitudFonoRotativoNoDeducible.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvSolicitudFonoRotativoNoDeducible.BackgroundColor = System.Drawing.Color.White
            Me.dgvSolicitudFonoRotativoNoDeducible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvSolicitudFonoRotativoNoDeducible.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvSolicitudFonoRotativoNoDeducible.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvSolicitudFonoRotativoNoDeducible.Location = New System.Drawing.Point(6, 22)
            Me.dgvSolicitudFonoRotativoNoDeducible.MultiSelect = False
            Me.dgvSolicitudFonoRotativoNoDeducible.Name = "dgvSolicitudFonoRotativoNoDeducible"
            Me.dgvSolicitudFonoRotativoNoDeducible.RowHeadersVisible = False
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSolicitudFonoRotativoNoDeducible.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvSolicitudFonoRotativoNoDeducible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSolicitudFonoRotativoNoDeducible.Size = New System.Drawing.Size(897, 235)
            Me.dgvSolicitudFonoRotativoNoDeducible.TabIndex = 29
            '
            'DataGridViewCheckBoxColumn1
            '
            Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DataGridViewCheckBoxColumn1.HeaderText = "CHK"
            Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
            Me.DataGridViewCheckBoxColumn1.Width = 35
            '
            'gbNoDeducibles
            '
            Me.gbNoDeducibles.BackColor = System.Drawing.Color.White
            Me.gbNoDeducibles.Controls.Add(Me.lblNoDeducibles)
            Me.gbNoDeducibles.Controls.Add(Me.chkSeleccionarTodoNoDeducibles)
            Me.gbNoDeducibles.Controls.Add(Me.dgvSolicitudFonoRotativoNoDeducible)
            Me.gbNoDeducibles.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNoDeducibles.Location = New System.Drawing.Point(2, 144)
            Me.gbNoDeducibles.Name = "gbNoDeducibles"
            Me.gbNoDeducibles.Size = New System.Drawing.Size(909, 257)
            Me.gbNoDeducibles.TabIndex = 32
            Me.gbNoDeducibles.TabStop = False
            Me.gbNoDeducibles.Text = "NO DEDUCIBLES"
            '
            'lblNoDeducibles
            '
            Me.lblNoDeducibles.AutoSize = True
            Me.lblNoDeducibles.Location = New System.Drawing.Point(104, 0)
            Me.lblNoDeducibles.Name = "lblNoDeducibles"
            Me.lblNoDeducibles.Size = New System.Drawing.Size(16, 13)
            Me.lblNoDeducibles.TabIndex = 31
            Me.lblNoDeducibles.Text = "..."
            '
            'gbDeducibles
            '
            Me.gbDeducibles.BackColor = System.Drawing.Color.White
            Me.gbDeducibles.Controls.Add(Me.lblDeducibles)
            Me.gbDeducibles.Controls.Add(Me.chkSeleccionarTodo)
            Me.gbDeducibles.Controls.Add(Me.dgvSolicitudFondoRotativo)
            Me.gbDeducibles.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDeducibles.Location = New System.Drawing.Point(2, 403)
            Me.gbDeducibles.Name = "gbDeducibles"
            Me.gbDeducibles.Size = New System.Drawing.Size(909, 250)
            Me.gbDeducibles.TabIndex = 33
            Me.gbDeducibles.TabStop = False
            Me.gbDeducibles.Text = "DEDUCIBLES"
            '
            'lblDeducibles
            '
            Me.lblDeducibles.AutoSize = True
            Me.lblDeducibles.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDeducibles.Location = New System.Drawing.Point(104, 0)
            Me.lblDeducibles.Name = "lblDeducibles"
            Me.lblDeducibles.Size = New System.Drawing.Size(16, 13)
            Me.lblDeducibles.TabIndex = 32
            Me.lblDeducibles.Text = "..."
            '
            'dgvComprobanteCompra
            '
            Me.dgvComprobanteCompra.AllowUserToAddRows = False
            Me.dgvComprobanteCompra.AllowUserToDeleteRows = False
            Me.dgvComprobanteCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteCompra.Location = New System.Drawing.Point(917, 154)
            Me.dgvComprobanteCompra.Name = "dgvComprobanteCompra"
            Me.dgvComprobanteCompra.ReadOnly = True
            Me.dgvComprobanteCompra.Size = New System.Drawing.Size(240, 160)
            Me.dgvComprobanteCompra.TabIndex = 34
            '
            'dgvComprobanteRetencionCompra
            '
            Me.dgvComprobanteRetencionCompra.AllowUserToAddRows = False
            Me.dgvComprobanteRetencionCompra.AllowUserToDeleteRows = False
            Me.dgvComprobanteRetencionCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteRetencionCompra.Location = New System.Drawing.Point(917, 338)
            Me.dgvComprobanteRetencionCompra.Name = "dgvComprobanteRetencionCompra"
            Me.dgvComprobanteRetencionCompra.ReadOnly = True
            Me.dgvComprobanteRetencionCompra.Size = New System.Drawing.Size(240, 160)
            Me.dgvComprobanteRetencionCompra.TabIndex = 35
            '
            'dgvDetalleComprobanteRetencionCompra
            '
            Me.dgvDetalleComprobanteRetencionCompra.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencionCompra.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobanteRetencionCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleComprobanteRetencionCompra.Location = New System.Drawing.Point(917, 522)
            Me.dgvDetalleComprobanteRetencionCompra.Name = "dgvDetalleComprobanteRetencionCompra"
            Me.dgvDetalleComprobanteRetencionCompra.ReadOnly = True
            Me.dgvDetalleComprobanteRetencionCompra.Size = New System.Drawing.Size(240, 127)
            Me.dgvDetalleComprobanteRetencionCompra.TabIndex = 36
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRecargar, Me.btnAgregarDiarioNoDeducibles, Me.btnAgregarDiarioDeducibles, Me.btnFinRevision})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(913, 24)
            Me.MenuStrip1.TabIndex = 184
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnRecargar
            '
            Me.btnRecargar.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRecargar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnRecargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnRecargar.Name = "btnRecargar"
            Me.btnRecargar.Size = New System.Drawing.Size(126, 20)
            Me.btnRecargar.Text = "RECARGAR LIQU."
            '
            'btnAgregarDiarioNoDeducibles
            '
            Me.btnAgregarDiarioNoDeducibles.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarDiarioNoDeducibles.Image = CType(resources.GetObject("btnAgregarDiarioNoDeducibles.Image"), System.Drawing.Image)
            Me.btnAgregarDiarioNoDeducibles.Name = "btnAgregarDiarioNoDeducibles"
            Me.btnAgregarDiarioNoDeducibles.Size = New System.Drawing.Size(180, 20)
            Me.btnAgregarDiarioNoDeducibles.Text = "AGREGAR NO DEDUCIBLES"
            '
            'btnAgregarDiarioDeducibles
            '
            Me.btnAgregarDiarioDeducibles.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarDiarioDeducibles.Image = CType(resources.GetObject("btnAgregarDiarioDeducibles.Image"), System.Drawing.Image)
            Me.btnAgregarDiarioDeducibles.Name = "btnAgregarDiarioDeducibles"
            Me.btnAgregarDiarioDeducibles.Size = New System.Drawing.Size(160, 20)
            Me.btnAgregarDiarioDeducibles.Text = "AGREGAR DEDUCIBLES"
            '
            'btnFinRevision
            '
            Me.btnFinRevision.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFinRevision.Image = Global.syscisepro.My.Resources.Resources.oki
            Me.btnFinRevision.Name = "btnFinRevision"
            Me.btnFinRevision.Size = New System.Drawing.Size(157, 20)
            Me.btnFinRevision.Text = "FINALIZAR Y LIQUIDAR"
            '
            'FormRevisionLiquidaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(913, 656)
            Me.Controls.Add(Me.gbNoDeducibles)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvDetalleComprobanteRetencionCompra)
            Me.Controls.Add(Me.dgvComprobanteRetencionCompra)
            Me.Controls.Add(Me.dgvComprobanteCompra)
            Me.Controls.Add(Me.gbDeducibles)
            Me.Controls.Add(Me.dgvLiquidacionesPendientes)
            Me.Controls.Add(Me.gbLiquidacion)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormRevisionLiquidaciones"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REVISION DE LIQUIDACIONES"
            Me.gbLiquidacion.ResumeLayout(False)
            Me.gbLiquidacion.PerformLayout()
            CType(Me.dgvSolicitudFondoRotativo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvLiquidacionesPendientes, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvSolicitudFonoRotativoNoDeducible, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbNoDeducibles.ResumeLayout(False)
            Me.gbNoDeducibles.PerformLayout()
            Me.gbDeducibles.ResumeLayout(False)
            Me.gbDeducibles.PerformLayout()
            CType(Me.dgvComprobanteCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbLiquidacion As System.Windows.Forms.GroupBox
        Friend WithEvents txtIdLiquidacion As System.Windows.Forms.Label
        Friend WithEvents lblFechaLiquidacionFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblTotalLiquidacionFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents txtReposicionLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents lblFondoLiquidacion As System.Windows.Forms.Label
        Friend WithEvents txtSaldoLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents lblGastosLiquidacion As System.Windows.Forms.Label
        Friend WithEvents txtGastosLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents lblSaldoLiquidacion As System.Windows.Forms.Label
        Friend WithEvents txtFondoLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents lblReposicionLiquidacion As System.Windows.Forms.Label
        Friend WithEvents txtTotalLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents dgvSolicitudFondoRotativo As System.Windows.Forms.DataGridView
        Friend WithEvents dgvLiquidacionesPendientes As System.Windows.Forms.DataGridView
        Friend WithEvents CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents chkSeleccionarTodo As System.Windows.Forms.CheckBox
        Friend WithEvents chkSeleccionarTodoNoDeducibles As System.Windows.Forms.CheckBox
        Friend WithEvents dgvSolicitudFonoRotativoNoDeducible As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents gbNoDeducibles As System.Windows.Forms.GroupBox
        Friend WithEvents gbDeducibles As System.Windows.Forms.GroupBox
        Friend WithEvents dgvComprobanteCompra As System.Windows.Forms.DataGridView
        Friend WithEvents dgvComprobanteRetencionCompra As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleComprobanteRetencionCompra As System.Windows.Forms.DataGridView
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnRecargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAgregarDiarioNoDeducibles As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAgregarDiarioDeducibles As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnFinRevision As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblNoDeducibles As System.Windows.Forms.Label
        Friend WithEvents lblDeducibles As System.Windows.Forms.Label
    End Class
End Namespace