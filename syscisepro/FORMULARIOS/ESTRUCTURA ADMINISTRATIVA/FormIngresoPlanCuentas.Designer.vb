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
            Me.txtIdPlan = New System.Windows.Forms.TextBox()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.txtDetalle = New System.Windows.Forms.TextBox()
            Me.cbmMovimiento = New System.Windows.Forms.ComboBox()
            Me.cbmPresupuesto = New System.Windows.Forms.ComboBox()
            Me.cbmEmpresa = New System.Windows.Forms.ComboBox()
            Me.txtPadre = New System.Windows.Forms.TextBox()
            Me.cbmNivel = New System.Windows.Forms.ComboBox()
            Me.cbmTipo = New System.Windows.Forms.ComboBox()
            Me.dgvPlanDeCuentas = New System.Windows.Forms.DataGridView()
            Me.cbmEstadoContable = New System.Windows.Forms.ComboBox()
            Me.txtBuscar = New System.Windows.Forms.TextBox()
            Me.rbCodigo = New System.Windows.Forms.RadioButton()
            Me.rbCuenta = New System.Windows.Forms.RadioButton()
            Me.rbTodas = New System.Windows.Forms.RadioButton()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscarAsiento = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            CType(Me.dgvPlanDeCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtIdPlan
            '
            Me.txtIdPlan.BackColor = System.Drawing.Color.White
            Me.txtIdPlan.Enabled = False
            Me.txtIdPlan.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdPlan.ForeColor = System.Drawing.Color.Black
            Me.txtIdPlan.Location = New System.Drawing.Point(70, 3)
            Me.txtIdPlan.Name = "txtIdPlan"
            Me.txtIdPlan.Size = New System.Drawing.Size(59, 21)
            Me.txtIdPlan.TabIndex = 47
            '
            'txtCodigo
            '
            Me.txtCodigo.BackColor = System.Drawing.Color.White
            Me.txtCodigo.Enabled = False
            Me.txtCodigo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigo.ForeColor = System.Drawing.Color.Black
            Me.txtCodigo.Location = New System.Drawing.Point(70, 29)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
            Me.txtCodigo.TabIndex = 49
            '
            'txtDetalle
            '
            Me.txtDetalle.BackColor = System.Drawing.Color.White
            Me.txtDetalle.Enabled = False
            Me.txtDetalle.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalle.ForeColor = System.Drawing.Color.Black
            Me.txtDetalle.Location = New System.Drawing.Point(70, 57)
            Me.txtDetalle.Multiline = True
            Me.txtDetalle.Name = "txtDetalle"
            Me.txtDetalle.Size = New System.Drawing.Size(414, 21)
            Me.txtDetalle.TabIndex = 51
            '
            'cbmMovimiento
            '
            Me.cbmMovimiento.BackColor = System.Drawing.Color.White
            Me.cbmMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmMovimiento.Enabled = False
            Me.cbmMovimiento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmMovimiento.ForeColor = System.Drawing.Color.Black
            Me.cbmMovimiento.FormattingEnabled = True
            Me.cbmMovimiento.Items.AddRange(New Object() {"SI", "NO", ""})
            Me.cbmMovimiento.Location = New System.Drawing.Point(404, 30)
            Me.cbmMovimiento.Name = "cbmMovimiento"
            Me.cbmMovimiento.Size = New System.Drawing.Size(81, 21)
            Me.cbmMovimiento.TabIndex = 58
            '
            'cbmPresupuesto
            '
            Me.cbmPresupuesto.BackColor = System.Drawing.Color.White
            Me.cbmPresupuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmPresupuesto.Enabled = False
            Me.cbmPresupuesto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmPresupuesto.ForeColor = System.Drawing.Color.Black
            Me.cbmPresupuesto.FormattingEnabled = True
            Me.cbmPresupuesto.Items.AddRange(New Object() {"SI", "NO", ""})
            Me.cbmPresupuesto.Location = New System.Drawing.Point(592, 4)
            Me.cbmPresupuesto.Name = "cbmPresupuesto"
            Me.cbmPresupuesto.Size = New System.Drawing.Size(73, 21)
            Me.cbmPresupuesto.TabIndex = 59
            '
            'cbmEmpresa
            '
            Me.cbmEmpresa.BackColor = System.Drawing.Color.White
            Me.cbmEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmEmpresa.Enabled = False
            Me.cbmEmpresa.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmEmpresa.ForeColor = System.Drawing.Color.Black
            Me.cbmEmpresa.FormattingEnabled = True
            Me.cbmEmpresa.Location = New System.Drawing.Point(555, 57)
            Me.cbmEmpresa.Name = "cbmEmpresa"
            Me.cbmEmpresa.Size = New System.Drawing.Size(110, 21)
            Me.cbmEmpresa.TabIndex = 61
            '
            'txtPadre
            '
            Me.txtPadre.BackColor = System.Drawing.Color.White
            Me.txtPadre.Enabled = False
            Me.txtPadre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPadre.ForeColor = System.Drawing.Color.Black
            Me.txtPadre.Location = New System.Drawing.Point(232, 2)
            Me.txtPadre.Name = "txtPadre"
            Me.txtPadre.Size = New System.Drawing.Size(83, 22)
            Me.txtPadre.TabIndex = 53
            '
            'cbmNivel
            '
            Me.cbmNivel.BackColor = System.Drawing.Color.White
            Me.cbmNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmNivel.Enabled = False
            Me.cbmNivel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmNivel.ForeColor = System.Drawing.Color.Black
            Me.cbmNivel.FormattingEnabled = True
            Me.cbmNivel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
            Me.cbmNivel.Location = New System.Drawing.Point(232, 28)
            Me.cbmNivel.Name = "cbmNivel"
            Me.cbmNivel.Size = New System.Drawing.Size(83, 21)
            Me.cbmNivel.TabIndex = 63
            '
            'cbmTipo
            '
            Me.cbmTipo.BackColor = System.Drawing.Color.White
            Me.cbmTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmTipo.Enabled = False
            Me.cbmTipo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmTipo.ForeColor = System.Drawing.Color.Black
            Me.cbmTipo.FormattingEnabled = True
            Me.cbmTipo.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
            Me.cbmTipo.Location = New System.Drawing.Point(404, 4)
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
            Me.dgvPlanDeCuentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.dgvPlanDeCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None
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
            Me.dgvPlanDeCuentas.Location = New System.Drawing.Point(8, 30)
            Me.dgvPlanDeCuentas.MultiSelect = False
            Me.dgvPlanDeCuentas.Name = "dgvPlanDeCuentas"
            Me.dgvPlanDeCuentas.ReadOnly = True
            Me.dgvPlanDeCuentas.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPlanDeCuentas.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvPlanDeCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPlanDeCuentas.Size = New System.Drawing.Size(892, 333)
            Me.dgvPlanDeCuentas.TabIndex = 197
            '
            'cbmEstadoContable
            '
            Me.cbmEstadoContable.BackColor = System.Drawing.Color.White
            Me.cbmEstadoContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmEstadoContable.Enabled = False
            Me.cbmEstadoContable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmEstadoContable.ForeColor = System.Drawing.Color.Black
            Me.cbmEstadoContable.FormattingEnabled = True
            Me.cbmEstadoContable.Items.AddRange(New Object() {"1", "2", "3", "4"})
            Me.cbmEstadoContable.Location = New System.Drawing.Point(592, 30)
            Me.cbmEstadoContable.Name = "cbmEstadoContable"
            Me.cbmEstadoContable.Size = New System.Drawing.Size(73, 21)
            Me.cbmEstadoContable.TabIndex = 199
            '
            'txtBuscar
            '
            Me.txtBuscar.BackColor = System.Drawing.Color.White
            Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBuscar.Enabled = False
            Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBuscar.Location = New System.Drawing.Point(256, 2)
            Me.txtBuscar.Name = "txtBuscar"
            Me.txtBuscar.Size = New System.Drawing.Size(347, 22)
            Me.txtBuscar.TabIndex = 204
            '
            'rbCodigo
            '
            Me.rbCodigo.AutoSize = True
            Me.rbCodigo.BackColor = System.Drawing.Color.Transparent
            Me.rbCodigo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCodigo.Location = New System.Drawing.Point(69, 4)
            Me.rbCodigo.Name = "rbCodigo"
            Me.rbCodigo.Size = New System.Drawing.Size(79, 17)
            Me.rbCodigo.TabIndex = 207
            Me.rbCodigo.TabStop = True
            Me.rbCodigo.Text = "Por Código"
            Me.rbCodigo.UseVisualStyleBackColor = False
            '
            'rbCuenta
            '
            Me.rbCuenta.AutoSize = True
            Me.rbCuenta.BackColor = System.Drawing.Color.Transparent
            Me.rbCuenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCuenta.Location = New System.Drawing.Point(158, 4)
            Me.rbCuenta.Name = "rbCuenta"
            Me.rbCuenta.Size = New System.Drawing.Size(80, 17)
            Me.rbCuenta.TabIndex = 206
            Me.rbCuenta.TabStop = True
            Me.rbCuenta.Text = "Por Cuenta"
            Me.rbCuenta.UseVisualStyleBackColor = False
            '
            'rbTodas
            '
            Me.rbTodas.AutoSize = True
            Me.rbTodas.BackColor = System.Drawing.Color.Transparent
            Me.rbTodas.Checked = True
            Me.rbTodas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTodas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTodas.Location = New System.Drawing.Point(8, 3)
            Me.rbTodas.Name = "rbTodas"
            Me.rbTodas.Size = New System.Drawing.Size(55, 17)
            Me.rbTodas.TabIndex = 205
            Me.rbTodas.TabStop = True
            Me.rbTodas.Text = "Todas"
            Me.rbTodas.UseVisualStyleBackColor = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarAsiento, Me.btnNuevo, Me.btnGuardar, Me.btnModificar, Me.btnCancelar, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(919, 32)
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
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.KeyTip
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(6, 38)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmEstadoContable)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdPlan)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmPresupuesto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmEmpresa)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCodigo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmMovimiento)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmTipo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtPadre)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDetalle)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmNivel)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(908, 104)
            Me.KryptonGroupBox1.TabIndex = 210
            Me.KryptonGroupBox1.Values.Heading = " Datos"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(680, 58)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(220, 20)
            Me.KryptonLabel14.TabIndex = 203
            Me.KryptonLabel14.Values.Text = "4. Estado de Cambios en el Patrimonio"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(680, 39)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(175, 20)
            Me.KryptonLabel13.TabIndex = 202
            Me.KryptonLabel13.Values.Text = "3. Estado de Flujos de Efectivo"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(680, 19)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(179, 20)
            Me.KryptonLabel12.TabIndex = 201
            Me.KryptonLabel12.Values.Text = "2. Estado de Resultado Integral"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(680, 1)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(189, 20)
            Me.KryptonLabel11.TabIndex = 200
            Me.KryptonLabel11.Values.Text = "1. Estado de Situacion Financiera"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(495, 57)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(57, 20)
            Me.KryptonLabel10.TabIndex = 68
            Me.KryptonLabel10.Values.Text = "Empresa"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(497, 29)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(72, 20)
            Me.KryptonLabel9.TabIndex = 67
            Me.KryptonLabel9.Values.Text = "E. Contable"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(495, 5)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(78, 20)
            Me.KryptonLabel8.TabIndex = 66
            Me.KryptonLabel8.Values.Text = "Presupuesto"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(325, 29)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(76, 20)
            Me.KryptonLabel7.TabIndex = 65
            Me.KryptonLabel7.Values.Text = "Movimiento"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(325, 4)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel6.TabIndex = 64
            Me.KryptonLabel6.Values.Text = "Tipo"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(184, 30)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel5.TabIndex = 53
            Me.KryptonLabel5.Values.Text = "Nivel"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(184, 3)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel4.TabIndex = 52
            Me.KryptonLabel4.Values.Text = "Padre"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(3, 58)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel3.TabIndex = 2
            Me.KryptonLabel3.Values.Text = "Detalle"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(3, 30)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel2.TabIndex = 1
            Me.KryptonLabel2.Values.Text = "Codigo"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(4, 5)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Id"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(7, 146)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvPlanDeCuentas)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtBuscar)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.rbCuenta)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.rbCodigo)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.rbTodas)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(907, 390)
            Me.KryptonGroupBox2.TabIndex = 211
            Me.KryptonGroupBox2.Values.Heading = "Busqueda"
            '
            'FormIngresoPlanCuentas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(919, 539)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
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
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtIdPlan As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
        Friend WithEvents cbmMovimiento As System.Windows.Forms.ComboBox
        Friend WithEvents cbmPresupuesto As System.Windows.Forms.ComboBox
        Friend WithEvents cbmEmpresa As System.Windows.Forms.ComboBox
        Friend WithEvents txtPadre As System.Windows.Forms.TextBox
        Friend WithEvents cbmNivel As System.Windows.Forms.ComboBox
        Friend WithEvents cbmTipo As System.Windows.Forms.ComboBox
        Friend WithEvents dgvPlanDeCuentas As System.Windows.Forms.DataGridView
        Friend WithEvents cbmEstadoContable As System.Windows.Forms.ComboBox
        Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
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
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    End Class
End Namespace