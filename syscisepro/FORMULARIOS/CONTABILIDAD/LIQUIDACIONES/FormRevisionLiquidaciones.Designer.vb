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
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRevisionLiquidaciones))
            Me.txtIdLiquidacion = New System.Windows.Forms.Label()
            Me.txtReposicionLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtSaldoLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtGastosLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtFondoLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtTotalLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtFechaLiquidacion = New System.Windows.Forms.TextBox()
            Me.dgvSolicitudFondoRotativo = New System.Windows.Forms.DataGridView()
            Me.CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.dgvLiquidacionesPendientes = New System.Windows.Forms.DataGridView()
            Me.chkSeleccionarTodo = New System.Windows.Forms.CheckBox()
            Me.dgvSolicitudFonoRotativoNoDeducible = New System.Windows.Forms.DataGridView()
            Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.lblNoDeducibles = New System.Windows.Forms.Label()
            Me.lblDeducibles = New System.Windows.Forms.Label()
            Me.dgvComprobanteCompra = New System.Windows.Forms.DataGridView()
            Me.dgvComprobanteRetencionCompra = New System.Windows.Forms.DataGridView()
            Me.dgvDetalleComprobanteRetencionCompra = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnRecargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAgregarDiarioNoDeducibles = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAgregarDiarioDeducibles = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnFinRevision = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.chkSeleccionarTodoNoDeducibles = New System.Windows.Forms.CheckBox()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            CType(Me.dgvSolicitudFondoRotativo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvLiquidacionesPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvSolicitudFonoRotativoNoDeducible, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).BeginInit()
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
            'txtIdLiquidacion
            '
            Me.txtIdLiquidacion.AutoSize = True
            Me.txtIdLiquidacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.txtIdLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdLiquidacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtIdLiquidacion.Location = New System.Drawing.Point(93, 40)
            Me.txtIdLiquidacion.Name = "txtIdLiquidacion"
            Me.txtIdLiquidacion.Size = New System.Drawing.Size(16, 13)
            Me.txtIdLiquidacion.TabIndex = 1
            Me.txtIdLiquidacion.Text = "..."
            '
            'txtReposicionLiquidacion
            '
            Me.txtReposicionLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtReposicionLiquidacion.Enabled = False
            Me.txtReposicionLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtReposicionLiquidacion.Location = New System.Drawing.Point(730, 6)
            Me.txtReposicionLiquidacion.Name = "txtReposicionLiquidacion"
            Me.txtReposicionLiquidacion.Size = New System.Drawing.Size(66, 21)
            Me.txtReposicionLiquidacion.TabIndex = 14
            Me.txtReposicionLiquidacion.Text = "0.00"
            Me.txtReposicionLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtSaldoLiquidacion
            '
            Me.txtSaldoLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtSaldoLiquidacion.Enabled = False
            Me.txtSaldoLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSaldoLiquidacion.Location = New System.Drawing.Point(582, 6)
            Me.txtSaldoLiquidacion.Name = "txtSaldoLiquidacion"
            Me.txtSaldoLiquidacion.Size = New System.Drawing.Size(66, 21)
            Me.txtSaldoLiquidacion.TabIndex = 13
            Me.txtSaldoLiquidacion.Text = "0.00"
            Me.txtSaldoLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtGastosLiquidacion
            '
            Me.txtGastosLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtGastosLiquidacion.Enabled = False
            Me.txtGastosLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGastosLiquidacion.Location = New System.Drawing.Point(459, 6)
            Me.txtGastosLiquidacion.Name = "txtGastosLiquidacion"
            Me.txtGastosLiquidacion.Size = New System.Drawing.Size(65, 21)
            Me.txtGastosLiquidacion.TabIndex = 12
            Me.txtGastosLiquidacion.Text = "0.00"
            Me.txtGastosLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtFondoLiquidacion
            '
            Me.txtFondoLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtFondoLiquidacion.Enabled = False
            Me.txtFondoLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFondoLiquidacion.Location = New System.Drawing.Point(337, 6)
            Me.txtFondoLiquidacion.Name = "txtFondoLiquidacion"
            Me.txtFondoLiquidacion.Size = New System.Drawing.Size(65, 21)
            Me.txtFondoLiquidacion.TabIndex = 11
            Me.txtFondoLiquidacion.Text = "0.00"
            Me.txtFondoLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtTotalLiquidacion
            '
            Me.txtTotalLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtTotalLiquidacion.Enabled = False
            Me.txtTotalLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalLiquidacion.Location = New System.Drawing.Point(215, 6)
            Me.txtTotalLiquidacion.Name = "txtTotalLiquidacion"
            Me.txtTotalLiquidacion.Size = New System.Drawing.Size(65, 21)
            Me.txtTotalLiquidacion.TabIndex = 10
            Me.txtTotalLiquidacion.Text = "0.00"
            Me.txtTotalLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtFechaLiquidacion
            '
            Me.txtFechaLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtFechaLiquidacion.Enabled = False
            Me.txtFechaLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaLiquidacion.Location = New System.Drawing.Point(55, 6)
            Me.txtFechaLiquidacion.Name = "txtFechaLiquidacion"
            Me.txtFechaLiquidacion.Size = New System.Drawing.Size(108, 21)
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
            Me.dgvSolicitudFondoRotativo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvSolicitudFondoRotativo.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSolicitudFondoRotativo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvSolicitudFondoRotativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvSolicitudFondoRotativo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvSolicitudFondoRotativo.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvSolicitudFondoRotativo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvSolicitudFondoRotativo.Location = New System.Drawing.Point(0, 0)
            Me.dgvSolicitudFondoRotativo.MultiSelect = False
            Me.dgvSolicitudFondoRotativo.Name = "dgvSolicitudFondoRotativo"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSolicitudFondoRotativo.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvSolicitudFondoRotativo.RowHeadersVisible = False
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSolicitudFondoRotativo.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvSolicitudFondoRotativo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSolicitudFondoRotativo.Size = New System.Drawing.Size(815, 152)
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
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvLiquidacionesPendientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvLiquidacionesPendientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvLiquidacionesPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvLiquidacionesPendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvLiquidacionesPendientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvLiquidacionesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvLiquidacionesPendientes.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgvLiquidacionesPendientes.Location = New System.Drawing.Point(5, 32)
            Me.dgvLiquidacionesPendientes.MultiSelect = False
            Me.dgvLiquidacionesPendientes.Name = "dgvLiquidacionesPendientes"
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvLiquidacionesPendientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvLiquidacionesPendientes.RowHeadersVisible = False
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvLiquidacionesPendientes.RowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvLiquidacionesPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLiquidacionesPendientes.Size = New System.Drawing.Size(797, 90)
            Me.dgvLiquidacionesPendientes.TabIndex = 22
            '
            'chkSeleccionarTodo
            '
            Me.chkSeleccionarTodo.AutoSize = True
            Me.chkSeleccionarTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkSeleccionarTodo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkSeleccionarTodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkSeleccionarTodo.Location = New System.Drawing.Point(689, 376)
            Me.chkSeleccionarTodo.Name = "chkSeleccionarTodo"
            Me.chkSeleccionarTodo.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkSeleccionarTodo.Size = New System.Drawing.Size(128, 17)
            Me.chkSeleccionarTodo.TabIndex = 23
            Me.chkSeleccionarTodo.Text = "Marcar / Desmarcar"
            Me.chkSeleccionarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkSeleccionarTodo.UseVisualStyleBackColor = False
            '
            'dgvSolicitudFonoRotativoNoDeducible
            '
            Me.dgvSolicitudFonoRotativoNoDeducible.AllowUserToAddRows = False
            Me.dgvSolicitudFonoRotativoNoDeducible.AllowUserToDeleteRows = False
            Me.dgvSolicitudFonoRotativoNoDeducible.AllowUserToResizeRows = False
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvSolicitudFonoRotativoNoDeducible.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvSolicitudFonoRotativoNoDeducible.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvSolicitudFonoRotativoNoDeducible.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSolicitudFonoRotativoNoDeducible.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvSolicitudFonoRotativoNoDeducible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvSolicitudFonoRotativoNoDeducible.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvSolicitudFonoRotativoNoDeducible.DefaultCellStyle = DataGridViewCellStyle13
            Me.dgvSolicitudFonoRotativoNoDeducible.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvSolicitudFonoRotativoNoDeducible.Location = New System.Drawing.Point(0, 0)
            Me.dgvSolicitudFonoRotativoNoDeducible.MultiSelect = False
            Me.dgvSolicitudFonoRotativoNoDeducible.Name = "dgvSolicitudFonoRotativoNoDeducible"
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSolicitudFonoRotativoNoDeducible.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvSolicitudFonoRotativoNoDeducible.RowHeadersVisible = False
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSolicitudFonoRotativoNoDeducible.RowsDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvSolicitudFonoRotativoNoDeducible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSolicitudFonoRotativoNoDeducible.Size = New System.Drawing.Size(815, 152)
            Me.dgvSolicitudFonoRotativoNoDeducible.TabIndex = 29
            '
            'DataGridViewCheckBoxColumn1
            '
            Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DataGridViewCheckBoxColumn1.HeaderText = "CHK"
            Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
            Me.DataGridViewCheckBoxColumn1.Width = 35
            '
            'lblNoDeducibles
            '
            Me.lblNoDeducibles.AutoSize = True
            Me.lblNoDeducibles.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblNoDeducibles.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNoDeducibles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblNoDeducibles.Location = New System.Drawing.Point(107, 196)
            Me.lblNoDeducibles.Name = "lblNoDeducibles"
            Me.lblNoDeducibles.Size = New System.Drawing.Size(16, 13)
            Me.lblNoDeducibles.TabIndex = 31
            Me.lblNoDeducibles.Text = "..."
            '
            'lblDeducibles
            '
            Me.lblDeducibles.AutoSize = True
            Me.lblDeducibles.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblDeducibles.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDeducibles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblDeducibles.Location = New System.Drawing.Point(91, 376)
            Me.lblDeducibles.Name = "lblDeducibles"
            Me.lblDeducibles.Size = New System.Drawing.Size(16, 13)
            Me.lblDeducibles.TabIndex = 32
            Me.lblDeducibles.Text = "..."
            '
            'dgvComprobanteCompra
            '
            Me.dgvComprobanteCompra.AllowUserToAddRows = False
            Me.dgvComprobanteCompra.AllowUserToDeleteRows = False
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
            Me.dgvComprobanteCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteCompra.DefaultCellStyle = DataGridViewCellStyle17
            Me.dgvComprobanteCompra.Location = New System.Drawing.Point(437, 52)
            Me.dgvComprobanteCompra.Name = "dgvComprobanteCompra"
            Me.dgvComprobanteCompra.ReadOnly = True
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
            Me.dgvComprobanteCompra.Size = New System.Drawing.Size(297, 50)
            Me.dgvComprobanteCompra.TabIndex = 34
            '
            'dgvComprobanteRetencionCompra
            '
            Me.dgvComprobanteRetencionCompra.AllowUserToAddRows = False
            Me.dgvComprobanteRetencionCompra.AllowUserToDeleteRows = False
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle19.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteRetencionCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
            Me.dgvComprobanteRetencionCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle20.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteRetencionCompra.DefaultCellStyle = DataGridViewCellStyle20
            Me.dgvComprobanteRetencionCompra.Location = New System.Drawing.Point(704, 434)
            Me.dgvComprobanteRetencionCompra.Name = "dgvComprobanteRetencionCompra"
            Me.dgvComprobanteRetencionCompra.ReadOnly = True
            DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle21.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteRetencionCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
            Me.dgvComprobanteRetencionCompra.Size = New System.Drawing.Size(72, 46)
            Me.dgvComprobanteRetencionCompra.TabIndex = 35
            '
            'dgvDetalleComprobanteRetencionCompra
            '
            Me.dgvDetalleComprobanteRetencionCompra.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencionCompra.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobanteRetencionCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleComprobanteRetencionCompra.Location = New System.Drawing.Point(481, 6)
            Me.dgvDetalleComprobanteRetencionCompra.Name = "dgvDetalleComprobanteRetencionCompra"
            Me.dgvDetalleComprobanteRetencionCompra.ReadOnly = True
            Me.dgvDetalleComprobanteRetencionCompra.Size = New System.Drawing.Size(240, 127)
            Me.dgvDetalleComprobanteRetencionCompra.TabIndex = 36
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRecargar, Me.btnAgregarDiarioNoDeducibles, Me.btnAgregarDiarioDeducibles, Me.btnFinRevision})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(820, 32)
            Me.MenuStrip1.TabIndex = 184
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnRecargar
            '
            Me.btnRecargar.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRecargar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnRecargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnRecargar.Name = "btnRecargar"
            Me.btnRecargar.Size = New System.Drawing.Size(88, 28)
            Me.btnRecargar.Text = "BUSCAR"
            '
            'btnAgregarDiarioNoDeducibles
            '
            Me.btnAgregarDiarioNoDeducibles.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarDiarioNoDeducibles.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarDiarioNoDeducibles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAgregarDiarioNoDeducibles.Name = "btnAgregarDiarioNoDeducibles"
            Me.btnAgregarDiarioNoDeducibles.Size = New System.Drawing.Size(132, 28)
            Me.btnAgregarDiarioNoDeducibles.Text = "NO DEDUCIBLES"
            '
            'btnAgregarDiarioDeducibles
            '
            Me.btnAgregarDiarioDeducibles.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarDiarioDeducibles.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarDiarioDeducibles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAgregarDiarioDeducibles.Name = "btnAgregarDiarioDeducibles"
            Me.btnAgregarDiarioDeducibles.Size = New System.Drawing.Size(112, 28)
            Me.btnAgregarDiarioDeducibles.Text = "DEDUCIBLES"
            '
            'btnFinRevision
            '
            Me.btnFinRevision.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFinRevision.Image = Global.syscisepro.My.Resources.Resources.check_circle_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnFinRevision.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnFinRevision.Name = "btnFinRevision"
            Me.btnFinRevision.Size = New System.Drawing.Size(163, 28)
            Me.btnFinRevision.Text = "FINALIZAR / LIQUIDAR"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtReposicionLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtSaldoLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dgvLiquidacionesPendientes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFechaLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dgvComprobanteCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTotalLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFondoLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtGastosLiquidacion)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(819, 150)
            Me.KryptonGroupBox1.TabIndex = 185
            Me.KryptonGroupBox1.Values.Heading = "Liquidacion"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(654, 6)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(70, 20)
            Me.KryptonLabel6.TabIndex = 14
            Me.KryptonLabel6.Values.Text = "Reposicion"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(530, 6)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(46, 20)
            Me.KryptonLabel5.TabIndex = 13
            Me.KryptonLabel5.Values.Text = "Saldos"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(408, 6)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(47, 20)
            Me.KryptonLabel4.TabIndex = 12
            Me.KryptonLabel4.Values.Text = "Gastos"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(286, 6)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel3.TabIndex = 11
            Me.KryptonLabel3.Values.Text = "Fondo"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(170, 6)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel2.TabIndex = 10
            Me.KryptonLabel2.Values.Text = "Total"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(7, 5)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Fecha"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(0, 191)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvSolicitudFonoRotativoNoDeducible)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(819, 176)
            Me.KryptonGroupBox2.TabIndex = 186
            Me.KryptonGroupBox2.Values.Heading = "No Deducibles"
            '
            'chkSeleccionarTodoNoDeducibles
            '
            Me.chkSeleccionarTodoNoDeducibles.AutoSize = True
            Me.chkSeleccionarTodoNoDeducibles.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkSeleccionarTodoNoDeducibles.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkSeleccionarTodoNoDeducibles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkSeleccionarTodoNoDeducibles.Location = New System.Drawing.Point(688, 196)
            Me.chkSeleccionarTodoNoDeducibles.Name = "chkSeleccionarTodoNoDeducibles"
            Me.chkSeleccionarTodoNoDeducibles.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkSeleccionarTodoNoDeducibles.Size = New System.Drawing.Size(128, 17)
            Me.chkSeleccionarTodoNoDeducibles.TabIndex = 30
            Me.chkSeleccionarTodoNoDeducibles.Text = "Marcar / Desmarcar"
            Me.chkSeleccionarTodoNoDeducibles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkSeleccionarTodoNoDeducibles.UseVisualStyleBackColor = False
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(0, 371)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dgvSolicitudFondoRotativo)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dgvDetalleComprobanteRetencionCompra)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(819, 176)
            Me.KryptonGroupBox3.TabIndex = 187
            Me.KryptonGroupBox3.Values.Heading = "Deducibles"
            '
            'FormRevisionLiquidaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(820, 547)
            Me.Controls.Add(Me.chkSeleccionarTodo)
            Me.Controls.Add(Me.lblDeducibles)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.chkSeleccionarTodoNoDeducibles)
            Me.Controls.Add(Me.lblNoDeducibles)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.txtIdLiquidacion)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvComprobanteRetencionCompra)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormRevisionLiquidaciones"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REVISION DE LIQUIDACIONES"
            CType(Me.dgvSolicitudFondoRotativo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvLiquidacionesPendientes, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvSolicitudFonoRotativoNoDeducible, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtIdLiquidacion As System.Windows.Forms.Label
        Friend WithEvents txtReposicionLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtSaldoLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtGastosLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtFondoLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents dgvSolicitudFondoRotativo As System.Windows.Forms.DataGridView
        Friend WithEvents dgvLiquidacionesPendientes As System.Windows.Forms.DataGridView
        Friend WithEvents CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents chkSeleccionarTodo As System.Windows.Forms.CheckBox
        Friend WithEvents dgvSolicitudFonoRotativoNoDeducible As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
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
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents chkSeleccionarTodoNoDeducibles As CheckBox
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
    End Class
End Namespace