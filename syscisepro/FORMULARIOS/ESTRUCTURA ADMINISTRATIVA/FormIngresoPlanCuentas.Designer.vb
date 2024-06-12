Namespace FORMULARIOS.ESTRUCTURA_ADMINISTRATIVA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormIngresoPlanCuentas
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIngresoPlanCuentas))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtIdPlan = New System.Windows.Forms.TextBox()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtDetalle = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cbmMovimiento = New System.Windows.Forms.ComboBox()
            Me.cbmPresupuesto = New System.Windows.Forms.ComboBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.cbmEmpresa = New System.Windows.Forms.ComboBox()
            Me.txtPadre = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cbmNivel = New System.Windows.Forms.ComboBox()
            Me.cbmTipo = New System.Windows.Forms.ComboBox()
            Me.dgvPlanDeCuentas = New System.Windows.Forms.DataGridView()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.cbmEstadoContable = New System.Windows.Forms.ComboBox()
            Me.ListBox1 = New System.Windows.Forms.ListBox()
            Me.txtBuscar = New System.Windows.Forms.TextBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.rbCodigo = New System.Windows.Forms.RadioButton()
            Me.rbCuenta = New System.Windows.Forms.RadioButton()
            Me.rbTodas = New System.Windows.Forms.RadioButton()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscarAsiento = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvPlanDeCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(4, 12)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(21, 13)
            Me.Label1.TabIndex = 46
            Me.Label1.Text = "ID:"
            '
            'txtIdPlan
            '
            Me.txtIdPlan.BackColor = System.Drawing.Color.White
            Me.txtIdPlan.Enabled = False
            Me.txtIdPlan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdPlan.ForeColor = System.Drawing.Color.Black
            Me.txtIdPlan.Location = New System.Drawing.Point(62, 12)
            Me.txtIdPlan.Name = "txtIdPlan"
            Me.txtIdPlan.Size = New System.Drawing.Size(59, 22)
            Me.txtIdPlan.TabIndex = 47
            '
            'txtCodigo
            '
            Me.txtCodigo.BackColor = System.Drawing.Color.White
            Me.txtCodigo.Enabled = False
            Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigo.ForeColor = System.Drawing.Color.Black
            Me.txtCodigo.Location = New System.Drawing.Point(62, 37)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(100, 22)
            Me.txtCodigo.TabIndex = 49
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Location = New System.Drawing.Point(4, 41)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(54, 13)
            Me.Label2.TabIndex = 48
            Me.Label2.Text = "CODIGO:"
            '
            'txtDetalle
            '
            Me.txtDetalle.BackColor = System.Drawing.Color.White
            Me.txtDetalle.Enabled = False
            Me.txtDetalle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalle.ForeColor = System.Drawing.Color.Black
            Me.txtDetalle.Location = New System.Drawing.Point(62, 63)
            Me.txtDetalle.Multiline = True
            Me.txtDetalle.Name = "txtDetalle"
            Me.txtDetalle.Size = New System.Drawing.Size(436, 27)
            Me.txtDetalle.TabIndex = 51
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Location = New System.Drawing.Point(4, 63)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(52, 13)
            Me.Label3.TabIndex = 50
            Me.Label3.Text = "DETALLE:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.Black
            Me.Label5.Location = New System.Drawing.Point(336, 41)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(80, 13)
            Me.Label5.TabIndex = 54
            Me.Label5.Text = "MOVIMIENTO:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.Black
            Me.Label6.Location = New System.Drawing.Point(520, 13)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(83, 13)
            Me.Label6.TabIndex = 55
            Me.Label6.Text = "PRESUPUESTO:"
            '
            'cbmMovimiento
            '
            Me.cbmMovimiento.BackColor = System.Drawing.Color.White
            Me.cbmMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmMovimiento.Enabled = False
            Me.cbmMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmMovimiento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmMovimiento.ForeColor = System.Drawing.Color.Black
            Me.cbmMovimiento.FormattingEnabled = True
            Me.cbmMovimiento.Items.AddRange(New Object() {"SI", "NO", ""})
            Me.cbmMovimiento.Location = New System.Drawing.Point(417, 37)
            Me.cbmMovimiento.Name = "cbmMovimiento"
            Me.cbmMovimiento.Size = New System.Drawing.Size(81, 21)
            Me.cbmMovimiento.TabIndex = 58
            '
            'cbmPresupuesto
            '
            Me.cbmPresupuesto.BackColor = System.Drawing.Color.White
            Me.cbmPresupuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmPresupuesto.Enabled = False
            Me.cbmPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmPresupuesto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmPresupuesto.ForeColor = System.Drawing.Color.Black
            Me.cbmPresupuesto.FormattingEnabled = True
            Me.cbmPresupuesto.Items.AddRange(New Object() {"SI", "NO", ""})
            Me.cbmPresupuesto.Location = New System.Drawing.Point(634, 12)
            Me.cbmPresupuesto.Name = "cbmPresupuesto"
            Me.cbmPresupuesto.Size = New System.Drawing.Size(73, 21)
            Me.cbmPresupuesto.TabIndex = 59
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.Black
            Me.Label8.Location = New System.Drawing.Point(520, 68)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(58, 13)
            Me.Label8.TabIndex = 60
            Me.Label8.Text = "EMPRESA:"
            '
            'cbmEmpresa
            '
            Me.cbmEmpresa.BackColor = System.Drawing.Color.White
            Me.cbmEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmEmpresa.Enabled = False
            Me.cbmEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmEmpresa.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmEmpresa.ForeColor = System.Drawing.Color.Black
            Me.cbmEmpresa.FormattingEnabled = True
            Me.cbmEmpresa.Location = New System.Drawing.Point(577, 65)
            Me.cbmEmpresa.Name = "cbmEmpresa"
            Me.cbmEmpresa.Size = New System.Drawing.Size(130, 21)
            Me.cbmEmpresa.TabIndex = 61
            '
            'txtPadre
            '
            Me.txtPadre.BackColor = System.Drawing.Color.White
            Me.txtPadre.Enabled = False
            Me.txtPadre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPadre.ForeColor = System.Drawing.Color.Black
            Me.txtPadre.Location = New System.Drawing.Point(227, 12)
            Me.txtPadre.Name = "txtPadre"
            Me.txtPadre.Size = New System.Drawing.Size(83, 22)
            Me.txtPadre.TabIndex = 53
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.Black
            Me.Label9.Location = New System.Drawing.Point(336, 15)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(34, 13)
            Me.Label9.TabIndex = 56
            Me.Label9.Text = "TIPO:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Location = New System.Drawing.Point(177, 14)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(43, 13)
            Me.Label4.TabIndex = 52
            Me.Label4.Text = "PADRE:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.Black
            Me.Label7.Location = New System.Drawing.Point(182, 41)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(39, 13)
            Me.Label7.TabIndex = 62
            Me.Label7.Text = "NIVEL:"
            '
            'cbmNivel
            '
            Me.cbmNivel.BackColor = System.Drawing.Color.White
            Me.cbmNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmNivel.Enabled = False
            Me.cbmNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmNivel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmNivel.ForeColor = System.Drawing.Color.Black
            Me.cbmNivel.FormattingEnabled = True
            Me.cbmNivel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
            Me.cbmNivel.Location = New System.Drawing.Point(227, 38)
            Me.cbmNivel.Name = "cbmNivel"
            Me.cbmNivel.Size = New System.Drawing.Size(83, 21)
            Me.cbmNivel.TabIndex = 63
            '
            'cbmTipo
            '
            Me.cbmTipo.BackColor = System.Drawing.Color.White
            Me.cbmTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmTipo.Enabled = False
            Me.cbmTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmTipo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmTipo.ForeColor = System.Drawing.Color.Black
            Me.cbmTipo.FormattingEnabled = True
            Me.cbmTipo.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
            Me.cbmTipo.Location = New System.Drawing.Point(418, 12)
            Me.cbmTipo.Name = "cbmTipo"
            Me.cbmTipo.Size = New System.Drawing.Size(80, 21)
            Me.cbmTipo.TabIndex = 57
            '
            'dgvPlanDeCuentas
            '
            Me.dgvPlanDeCuentas.AllowUserToAddRows = False
            Me.dgvPlanDeCuentas.AllowUserToDeleteRows = False
            Me.dgvPlanDeCuentas.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvPlanDeCuentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvPlanDeCuentas.BackgroundColor = System.Drawing.Color.White
            Me.dgvPlanDeCuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPlanDeCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvPlanDeCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPlanDeCuentas.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvPlanDeCuentas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvPlanDeCuentas.Location = New System.Drawing.Point(3, 18)
            Me.dgvPlanDeCuentas.MultiSelect = False
            Me.dgvPlanDeCuentas.Name = "dgvPlanDeCuentas"
            Me.dgvPlanDeCuentas.ReadOnly = True
            Me.dgvPlanDeCuentas.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPlanDeCuentas.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvPlanDeCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPlanDeCuentas.Size = New System.Drawing.Size(1005, 583)
            Me.dgvPlanDeCuentas.TabIndex = 197
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.Black
            Me.Label10.Location = New System.Drawing.Point(521, 33)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(63, 26)
            Me.Label10.TabIndex = 198
            Me.Label10.Text = "ESTADO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CONTABLE:"
            '
            'cbmEstadoContable
            '
            Me.cbmEstadoContable.BackColor = System.Drawing.Color.White
            Me.cbmEstadoContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmEstadoContable.Enabled = False
            Me.cbmEstadoContable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmEstadoContable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmEstadoContable.ForeColor = System.Drawing.Color.Black
            Me.cbmEstadoContable.FormattingEnabled = True
            Me.cbmEstadoContable.Items.AddRange(New Object() {"1", "2", "3", "4"})
            Me.cbmEstadoContable.Location = New System.Drawing.Point(634, 38)
            Me.cbmEstadoContable.Name = "cbmEstadoContable"
            Me.cbmEstadoContable.Size = New System.Drawing.Size(73, 21)
            Me.cbmEstadoContable.TabIndex = 199
            '
            'ListBox1
            '
            Me.ListBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ListBox1.FormattingEnabled = True
            Me.ListBox1.Items.AddRange(New Object() {"1. ESTADO DE SITUCION FINANCIERA", "", "2. ESTADO DE RESULTADO INTEGRAL", "", "3. ESTADO DE FLUJOS DE EFECTIVOS", "", "4. ESTADO DE CAMBIOS EN EL PATRIMONIO"})
            Me.ListBox1.Location = New System.Drawing.Point(725, 32)
            Me.ListBox1.Name = "ListBox1"
            Me.ListBox1.Size = New System.Drawing.Size(286, 95)
            Me.ListBox1.TabIndex = 201
            '
            'txtBuscar
            '
            Me.txtBuscar.BackColor = System.Drawing.Color.White
            Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBuscar.Enabled = False
            Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBuscar.Location = New System.Drawing.Point(372, 15)
            Me.txtBuscar.Name = "txtBuscar"
            Me.txtBuscar.Size = New System.Drawing.Size(633, 22)
            Me.txtBuscar.TabIndex = 204
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.rbCodigo)
            Me.GroupBox3.Controls.Add(Me.rbCuenta)
            Me.GroupBox3.Controls.Add(Me.rbTodas)
            Me.GroupBox3.Controls.Add(Me.txtBuscar)
            Me.GroupBox3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(1, 129)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(1011, 45)
            Me.GroupBox3.TabIndex = 206
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "BUSQUEDA"
            '
            'rbCodigo
            '
            Me.rbCodigo.AutoSize = True
            Me.rbCodigo.Location = New System.Drawing.Point(132, 17)
            Me.rbCodigo.Name = "rbCodigo"
            Me.rbCodigo.Size = New System.Drawing.Size(79, 17)
            Me.rbCodigo.TabIndex = 207
            Me.rbCodigo.TabStop = True
            Me.rbCodigo.Text = "Por Código"
            Me.rbCodigo.UseVisualStyleBackColor = True
            '
            'rbCuenta
            '
            Me.rbCuenta.AutoSize = True
            Me.rbCuenta.Location = New System.Drawing.Point(281, 17)
            Me.rbCuenta.Name = "rbCuenta"
            Me.rbCuenta.Size = New System.Drawing.Size(80, 17)
            Me.rbCuenta.TabIndex = 206
            Me.rbCuenta.TabStop = True
            Me.rbCuenta.Text = "Por Cuenta"
            Me.rbCuenta.UseVisualStyleBackColor = True
            '
            'rbTodas
            '
            Me.rbTodas.AutoSize = True
            Me.rbTodas.Checked = True
            Me.rbTodas.Location = New System.Drawing.Point(17, 17)
            Me.rbTodas.Name = "rbTodas"
            Me.rbTodas.Size = New System.Drawing.Size(55, 17)
            Me.rbTodas.TabIndex = 205
            Me.rbTodas.TabStop = True
            Me.rbTodas.Text = "Todas"
            Me.rbTodas.UseVisualStyleBackColor = True
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.White
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Controls.Add(Me.txtIdPlan)
            Me.GroupBox4.Controls.Add(Me.Label2)
            Me.GroupBox4.Controls.Add(Me.txtCodigo)
            Me.GroupBox4.Controls.Add(Me.cbmEstadoContable)
            Me.GroupBox4.Controls.Add(Me.Label3)
            Me.GroupBox4.Controls.Add(Me.Label10)
            Me.GroupBox4.Controls.Add(Me.txtDetalle)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.txtPadre)
            Me.GroupBox4.Controls.Add(Me.Label6)
            Me.GroupBox4.Controls.Add(Me.Label9)
            Me.GroupBox4.Controls.Add(Me.cbmTipo)
            Me.GroupBox4.Controls.Add(Me.cbmMovimiento)
            Me.GroupBox4.Controls.Add(Me.cbmPresupuesto)
            Me.GroupBox4.Controls.Add(Me.cbmEmpresa)
            Me.GroupBox4.Controls.Add(Me.cbmNivel)
            Me.GroupBox4.Controls.Add(Me.Label7)
            Me.GroupBox4.Controls.Add(Me.Label8)
            Me.GroupBox4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.Location = New System.Drawing.Point(2, 33)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(718, 96)
            Me.GroupBox4.TabIndex = 207
            Me.GroupBox4.TabStop = False
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.dgvPlanDeCuentas)
            Me.GroupBox5.Location = New System.Drawing.Point(0, 164)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(1011, 604)
            Me.GroupBox5.TabIndex = 208
            Me.GroupBox5.TabStop = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarAsiento, Me.btnNuevo, Me.btnGuardar, Me.btnModificar, Me.btnCancelar, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1012, 32)
            Me.MenuStrip1.TabIndex = 209
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscarAsiento
            '
            Me.btnBuscarAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarAsiento.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarAsiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscarAsiento.Name = "btnBuscarAsiento"
            Me.btnBuscarAsiento.Size = New System.Drawing.Size(85, 28)
            Me.btnBuscarAsiento.Text = "BUSCAR"
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnModificar
            '
            Me.btnModificar.Enabled = False
            Me.btnModificar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(113, 28)
            Me.btnModificar.Text = "ACTUALIZAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(99, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'FormIngresoPlanCuentas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1012, 772)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.GroupBox4)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.ListBox1)
            Me.Controls.Add(Me.GroupBox5)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormIngresoPlanCuentas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "MANTENIMIENTO DE PLAN DE CUENTAS"
            CType(Me.dgvPlanDeCuentas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtIdPlan As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cbmMovimiento As System.Windows.Forms.ComboBox
        Friend WithEvents cbmPresupuesto As System.Windows.Forms.ComboBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents cbmEmpresa As System.Windows.Forms.ComboBox
        Friend WithEvents txtPadre As System.Windows.Forms.TextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cbmNivel As System.Windows.Forms.ComboBox
        Friend WithEvents cbmTipo As System.Windows.Forms.ComboBox
        Friend WithEvents dgvPlanDeCuentas As System.Windows.Forms.DataGridView
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents cbmEstadoContable As System.Windows.Forms.ComboBox
        Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
        Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents rbCuenta As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodas As System.Windows.Forms.RadioButton
        Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscarAsiento As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace